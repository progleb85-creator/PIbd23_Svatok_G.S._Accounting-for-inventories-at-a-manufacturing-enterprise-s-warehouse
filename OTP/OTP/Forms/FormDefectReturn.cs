using OTP.Entities;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormDefectReturn : Form
{
    private readonly IDefectReturnRepository _defectReturnRepository;

    public FormDefectReturn(IDefectReturnRepository defectReturnRepository,
        IMaterialRepository materialRepository, IWarehouseRepository warehouseRepository)
    {
        InitializeComponent();
        _defectReturnRepository = defectReturnRepository ??
            throw new ArgumentNullException(nameof(defectReturnRepository));

        comboBoxMaterial.DataSource = materialRepository.ReadMaterials().ToList();
        comboBoxMaterial.DisplayMember = "Name";
        comboBoxMaterial.ValueMember = "Id";

        comboBoxWarehouse.DataSource = warehouseRepository.ReadWarehouses().ToList();
        comboBoxWarehouse.DisplayMember = "Name";
        comboBoxWarehouse.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxMaterial.SelectedIndex < 0 ||
                comboBoxWarehouse.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _defectReturnRepository.CreateDefectReturn(DefectReturn.CreateOperation(0,
                (int)comboBoxMaterial.SelectedValue!, (int)comboBoxWarehouse.SelectedValue!,
                Convert.ToInt32(numericUpDownCount.Value)));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
