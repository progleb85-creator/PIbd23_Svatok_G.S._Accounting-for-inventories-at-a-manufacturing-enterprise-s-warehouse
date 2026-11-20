using OTP.Entities;

namespace OTP.Repositories.Implementations;

internal class ProductionIssueRepository : IProductionIssueRepository
{
    public void CreateProductionIssue(ProductionIssue productionIssue)
    {
    }

    public void DeleteProductionIssue(int id)
    {
    }

    public IEnumerable<ProductionIssue> ReadProductionIssues(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? productId = null, int? warehouseId = null, int? materialId = null)
    {
        return [];
    }
}
