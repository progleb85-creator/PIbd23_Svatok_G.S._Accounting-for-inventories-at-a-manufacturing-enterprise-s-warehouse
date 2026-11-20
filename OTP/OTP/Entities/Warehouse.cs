namespace OTP.Entities;

public class Warehouse
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Address { get; private set; } = string.Empty;

    public static Warehouse CreateEntity(int id, string name, string address)
    {
        return new Warehouse
        {
            Id = id,
            Name = name ?? string.Empty,
            Address = address ?? string.Empty
        };
    }
}
