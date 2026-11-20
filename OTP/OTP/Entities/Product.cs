namespace OTP.Entities;

public class Product
{
    public int Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Article { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public static Product CreateEntity(int id, string name, string article, string description)
    {
        return new Product
        {
            Id = id,
            Name = name ?? string.Empty,
            Article = article ?? string.Empty,
            Description = description ?? string.Empty
        };
    }
}
