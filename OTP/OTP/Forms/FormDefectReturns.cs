using Unity;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormDefectReturns : Form
{
    private readonly IUnityContainer _container;

    private readonly IDefectReturnRepository _defectReturnRepository;

    public FormDefectReturns(IUnityContainer container, IDefectReturnRepository defectReturnRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _defectReturnRepository = defectReturnRepository ??
            throw new ArgumentNullException(nameof(defectReturnRepository));
    }

    private void FormDefectReturns_Load(object sender, EventArgs e)
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
            _container.Resolve<FormDefectReturn>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _defectReturnRepository.ReadDefectReturns().ToList();
}
