using Unity;

namespace OTP.Forms;

public partial class Form1 : Form
{
    private readonly IUnityContainer _container;

    public Form1(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
    }

    private void MaterialsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormMaterials>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormProducts>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void WarehousesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormWarehouses>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ProductionIssuesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormProductionIssues>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DefectReturnsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormDefectReturns>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PurchaseRequestsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormPurchaseRequests>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
