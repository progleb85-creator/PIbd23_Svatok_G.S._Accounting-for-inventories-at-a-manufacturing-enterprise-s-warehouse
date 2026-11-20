using Unity;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormPurchaseRequests : Form
{
    private readonly IUnityContainer _container;

    private readonly IPurchaseRequestRepository _purchaseRequestRepository;

    public FormPurchaseRequests(IUnityContainer container, IPurchaseRequestRepository purchaseRequestRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _purchaseRequestRepository = purchaseRequestRepository ??
            throw new ArgumentNullException(nameof(purchaseRequestRepository));
    }

    private void FormPurchaseRequests_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormPurchaseRequest>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _purchaseRequestRepository.ReadPurchaseRequests().ToList();
}
