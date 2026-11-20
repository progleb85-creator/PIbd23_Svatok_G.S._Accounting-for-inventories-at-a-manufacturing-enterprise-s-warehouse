using OTP.Entities;

namespace OTP.Repositories;

public interface IProductionIssueRepository
{
    IEnumerable<ProductionIssue> ReadProductionIssues(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? productId = null, int? warehouseId = null, int? materialId = null);

    void CreateProductionIssue(ProductionIssue productionIssue);

    void DeleteProductionIssue(int id);
}
