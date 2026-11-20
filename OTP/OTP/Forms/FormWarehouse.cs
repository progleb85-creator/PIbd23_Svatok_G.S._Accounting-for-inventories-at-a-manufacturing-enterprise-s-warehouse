using OTP.Entities;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormWarehouse : Form
{
    private readonly IWarehouseRepository _warehouseRepository;

    private int? _warehouseId;

    public int Id
    {
        set
        {
            try
            {
                var warehouse = _warehouseRepository.ReadWarehouseById(value);
                if (warehouse == null)
                {
                    throw new InvalidDataException(nameof(warehouse));
                }

                textBoxName.Text = warehouse.Name;
                textBoxAddress.Text = warehouse.Address;
                _warehouseId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    public FormWarehouse(IWarehouseRepository warehouseRepository)
    {
        InitializeComponent();
        _warehouseRepository = warehouseRepository ??
            throw new ArgumentNullException(nameof(warehouseRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_warehouseId.HasValue)
            {
                _warehouseRepository.UpdateWarehouse(CreateWarehouse(_warehouseId.Value));
            }
            else
            {
                _warehouseRepository.CreateWarehouse(CreateWarehouse(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Warehouse CreateWarehouse(int id) =>
        Warehouse.CreateEntity(id, textBoxName.Text, textBoxAddress.Text);
}
