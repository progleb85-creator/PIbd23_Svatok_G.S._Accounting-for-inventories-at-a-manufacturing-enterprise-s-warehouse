using Unity;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormProductionIssues : Form
{
    private readonly IUnityContainer _container;

    private readonly IProductionIssueRepository _productionIssueRepository;

    public FormProductionIssues(IUnityContainer container, IProductionIssueRepository productionIssueRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _productionIssueRepository = productionIssueRepository ??
            throw new ArgumentNullException(nameof(productionIssueRepository));
    }

    private void FormProductionIssues_Load(object sender, EventArgs e)
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
            _container.Resolve<FormProductionIssue>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _productionIssueRepository.DeleteProductionIssue(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList()
    {
        dataGridViewData.DataSource = _productionIssueRepository.ReadProductionIssues().ToList();
        var materialsColumn = dataGridViewData.Columns["Materials"];
        if (materialsColumn != null)
        {
            materialsColumn.Visible = false;
        }
    }

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
        return true;
    }
}
