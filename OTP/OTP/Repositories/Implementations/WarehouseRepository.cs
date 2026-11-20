using OTP.Entities;

namespace OTP.Repositories.Implementations;

internal class WarehouseRepository : IWarehouseRepository
{
    public void CreateWarehouse(Warehouse warehouse)
    {
    }

    public void DeleteWarehouse(int id)
    {
    }

    public Warehouse ReadWarehouseById(int id)
    {
        return Warehouse.CreateEntity(0, string.Empty, string.Empty);
    }

    public IEnumerable<Warehouse> ReadWarehouses()
    {
        return [];
    }

    public void UpdateWarehouse(Warehouse warehouse)
    {
    }
}
