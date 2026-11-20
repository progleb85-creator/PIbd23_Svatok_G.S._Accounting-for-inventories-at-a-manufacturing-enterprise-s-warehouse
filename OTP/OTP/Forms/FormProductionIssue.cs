using OTP.Entities;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormProductionIssue : Form
{
    private readonly IProductionIssueRepository _productionIssueRepository;

    public FormProductionIssue(IProductionIssueRepository productionIssueRepository,
        IProductRepository productRepository, IWarehouseRepository warehouseRepository,
        IMaterialRepository materialRepository)
    {
        InitializeComponent();
        _productionIssueRepository = productionIssueRepository ??
            throw new ArgumentNullException(nameof(productionIssueRepository));

        comboBoxProduct.DataSource = productRepository.ReadProducts().ToList();
        comboBoxProduct.DisplayMember = "Name";
        comboBoxProduct.ValueMember = "Id";

        comboBoxWarehouse.DataSource = warehouseRepository.ReadWarehouses().ToList();
        comboBoxWarehouse.DisplayMember = "Name";
        comboBoxWarehouse.ValueMember = "Id";

        ColumnMaterial.DataSource = materialRepository.ReadMaterials().ToList();
        ColumnMaterial.DisplayMember = "Name";
        ColumnMaterial.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            var materials = CreateListMaterialProductionIssuesFromDataGrid();
            if (comboBoxProduct.SelectedIndex < 0 ||
                comboBoxWarehouse.SelectedIndex < 0 ||
                materials.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _productionIssueRepository.CreateProductionIssue(ProductionIssue.CreateOperation(0,
                (int)comboBoxProduct.SelectedValue!, (int)comboBoxWarehouse.SelectedValue!, materials));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private List<MaterialProductionIssue> CreateListMaterialProductionIssuesFromDataGrid()
    {
        var list = new List<MaterialProductionIssue>();
        foreach (DataGridViewRow row in dataGridViewMaterials.Rows)
        {
            var materialValue = row.Cells["ColumnMaterial"].Value;
            var countValue = row.Cells["ColumnCount"].Value;
            if (materialValue == null && countValue == null)
            {
                continue;
            }

            if (materialValue == null || !int.TryParse(countValue?.ToString(), out var count) || count < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            list.Add(MaterialProductionIssue.CreateElement(0, Convert.ToInt32(materialValue), count));
        }

        if (list.GroupBy(x => x.MaterialId).Any(x => x.Count() > 1))
        {
            throw new Exception("Один и тот же материал указан более одного раза");
        }

        return list;
    }
}
