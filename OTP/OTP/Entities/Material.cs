namespace OTP.Entities;

public class Material
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public MaterialType MaterialType { get; private set; }

    public StorageCondition StorageCondition { get; private set; }

    public string Unit { get; private set; } = string.Empty;

    public int MinimumStock { get; private set; }

    public static Material CreateEntity(int id, string name, MaterialType materialType,
        StorageCondition storageCondition, string unit, int minimumStock)
    {
        return new Material
        {
            Id = id,
            Name = name ?? string.Empty,
            MaterialType = materialType,
            StorageCondition = storageCondition,
            Unit = unit ?? string.Empty,
            MinimumStock = minimumStock
        };
    }
}