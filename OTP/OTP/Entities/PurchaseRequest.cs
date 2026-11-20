namespace OTP.Entities;

public class PurchaseRequest
{
    public int Id { get; private set; }

    public int MaterialId { get; private set; }

    public int Count { get; private set; }

    public DateTime RequestDate { get; private set; }

    public static PurchaseRequest CreateOperation(int id, int materialId, int count)
    {
        return new PurchaseRequest
        {
            Id = id,
            MaterialId = materialId,
            Count = count,
            RequestDate = DateTime.Now
        };
    }
}
