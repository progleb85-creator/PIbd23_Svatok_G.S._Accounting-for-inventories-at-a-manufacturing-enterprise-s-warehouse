using OTP.Entities;

namespace OTP.Repositories.Implementations;

internal class ProductRepository : IProductRepository
{
    public void CreateProduct(Product product)
    {
    }

    public void DeleteProduct(int id)
    {
    }

    public Product ReadProductById(int id)
    {
        return Product.CreateEntity(0, string.Empty, string.Empty, string.Empty);
    }

    public IEnumerable<Product> ReadProducts()
    {
        return [];
    }

    public void UpdateProduct(Product product)
    {
    }
}
