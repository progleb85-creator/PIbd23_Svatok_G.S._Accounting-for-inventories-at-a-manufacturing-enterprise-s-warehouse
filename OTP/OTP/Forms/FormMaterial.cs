using OTP.Entities;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormMaterial : Form
{
    private readonly IMaterialRepository _materialRepository;

    private int? _materialId;

    public int Id
    {
        set
        {
            try
            {
                var material = _materialRepository.ReadMaterialById(value);
                if (material == null)
                {
                    throw new InvalidDataException(nameof(material));
                }

                textBoxName.Text = material.Name;
                comboBoxMaterialType.SelectedValue = material.MaterialType;
                textBoxUnit.Text = material.Unit;
                numericUpDownMinimumStock.Value = material.MinimumStock;
                for (var i = 0; i < checkedListBoxStorageCondition.Items.Count; i++)
                {
                    var item = (StorageConditionItem)checkedListBoxStorageCondition.Items[i];
                    checkedListBoxStorageCondition.SetItemChecked(i, material.StorageCondition.HasFlag(item.Value));
                }

                _materialId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    public FormMaterial(IMaterialRepository materialRepository)
    {
        InitializeComponent();
        _materialRepository = materialRepository ??
            throw new ArgumentNullException(nameof(materialRepository));

        comboBoxMaterialType.DisplayMember = "Name";
        comboBoxMaterialType.ValueMember = "Value";
        comboBoxMaterialType.DataSource = Enum.GetValues<MaterialType>()
            .Select(x => new { Value = x, Name = x.GetDescription() })
            .ToList();

        foreach (var value in Enum.GetValues<StorageCondition>().Where(x => x != StorageCondition.None))
        {
            checkedListBoxStorageCondition.Items.Add(new StorageConditionItem(value, value.GetDescription()));
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxUnit.Text) ||
                comboBoxMaterialType.SelectedValue is not MaterialType materialType ||
                materialType == MaterialType.None ||
                checkedListBoxStorageCondition.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_materialId.HasValue)
            {
                _materialRepository.UpdateMaterial(CreateMaterial(_materialId.Value));
            }
            else
            {
                _materialRepository.CreateMaterial(CreateMaterial(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Material CreateMaterial(int id)
    {
        var storageCondition = StorageCondition.None;
        foreach (StorageConditionItem item in checkedListBoxStorageCondition.CheckedItems)
        {
            storageCondition |= item.Value;
        }

        return Material.CreateEntity(id, textBoxName.Text, (MaterialType)comboBoxMaterialType.SelectedValue!,
            storageCondition, textBoxUnit.Text, Convert.ToInt32(numericUpDownMinimumStock.Value));
    }

    private sealed record StorageConditionItem(StorageCondition Value, string Name)
    {
        public override string ToString() => Name;
    }
}
