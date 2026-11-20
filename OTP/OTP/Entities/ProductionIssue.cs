namespace OTP.Entities;

public class ProductionIssue
{
    public int Id { get; private set; }

    public int ProductId { get; private set; }

    public int WarehouseId { get; private set; }

    public DateTime IssueDate { get; private set; }

    public IEnumerable<MaterialProductionIssue> Materials { get; private set; } = [];

    public static ProductionIssue CreateOperation(int id, int productId, int warehouseId,
        IEnumerable<MaterialProductionIssue> materials)
    {
        return new ProductionIssue
        {
            Id = id,
            ProductId = productId,
            WarehouseId = warehouseId,
            IssueDate = DateTime.Now,
            Materials = materials ?? []
        };
    }
}