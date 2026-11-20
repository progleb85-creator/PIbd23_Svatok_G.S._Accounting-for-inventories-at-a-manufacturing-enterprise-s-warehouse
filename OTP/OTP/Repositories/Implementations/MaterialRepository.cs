using OTP.Entities;

namespace OTP.Repositories.Implementations;

internal class MaterialRepository : IMaterialRepository
{
    public void CreateMaterial(Material material)
    {
    }

    public void DeleteMaterial(int id)
    {
    }

    public Material ReadMaterialById(int id)
    {
        return Material.CreateEntity(0, string.Empty, MaterialType.None, StorageCondition.None, string.Empty, 0);
    }

    public IEnumerable<Material> ReadMaterials()
    {
        return [];
    }

    public void UpdateMaterial(Material material)
    {
    }
}
