using OTP.Entities;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormPurchaseRequest : Form
{
    private readonly IPurchaseRequestRepository _purchaseRequestRepository;

    public FormPurchaseRequest(IPurchaseRequestRepository purchaseRequestRepository,
        IMaterialRepository materialRepository)
    {
        InitializeComponent();
        _purchaseRequestRepository = purchaseRequestRepository ??
            throw new ArgumentNullException(nameof(purchaseRequestRepository));

        comboBoxMaterial.DataSource = materialRepository.ReadMaterials().ToList();
        comboBoxMaterial.DisplayMember = "Name";
        comboBoxMaterial.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxMaterial.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _purchaseRequestRepository.CreatePurchaseRequest(PurchaseRequest.CreateOperation(0,
                (int)comboBoxMaterial.SelectedValue!, Convert.ToInt32(numericUpDownCount.Value)));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
