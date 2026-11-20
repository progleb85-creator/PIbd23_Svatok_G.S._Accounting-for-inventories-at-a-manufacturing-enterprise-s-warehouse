namespace OTP.Entities;

public class DefectReturn
{
    public int Id { get; private set; }

    public int MaterialId { get; private set; }

    public int WarehouseId { get; private set; }

    public int Count { get; private set; }

    public DateTime ReturnDate { get; private set; }

    public static DefectReturn CreateOperation(int id, int materialId, int warehouseId, int count)
    {
        return new DefectReturn
        {
            Id = id,
            MaterialId = materialId,
            WarehouseId = warehouseId,
            Count = count,
            ReturnDate = DateTime.Now
        };
    }
}