namespace OTP.Entities;

public class MaterialProductionIssue
{
    public int Id { get; private set; }

    public int MaterialId { get; private set; }

    public int Count { get; private set; }

    public static MaterialProductionIssue CreateElement(int id, int materialId, int count)
    {
        return new MaterialProductionIssue
        {
            Id = id,
            MaterialId = materialId,
            Count = count
        };
    }
}