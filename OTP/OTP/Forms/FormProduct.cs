using OTP.Entities;
using OTP.Repositories;

namespace OTP.Forms;

public partial class FormProduct : Form
{
    private readonly IProductRepository _productRepository;

    private int? _productId;

    public int Id
    {
        set
        {
            try
            {
                var product = _productRepository.ReadProductById(value);
                if (product == null)
                {
                    throw new InvalidDataException(nameof(product));
                }

                textBoxName.Text = product.Name;
                textBoxArticle.Text = product.Article;
                textBoxDescription.Text = product.Description;
                _productId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    public FormProduct(IProductRepository productRepository)
    {
        InitializeComponent();
        _productRepository = productRepository ??
            throw new ArgumentNullException(nameof(productRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxArticle.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_productId.HasValue)
            {
                _productRepository.UpdateProduct(CreateProduct(_productId.Value));
            }
            else
            {
                _productRepository.CreateProduct(CreateProduct(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Product CreateProduct(int id) =>
        Product.CreateEntity(id, textBoxName.Text, textBoxArticle.Text, textBoxDescription.Text);
}
