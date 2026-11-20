using OTP.Entities;

namespace OTP.Repositories;

public interface IMaterialRepository
{
    IEnumerable<Material> ReadMaterials();
    Material ReadMaterialById(int id);
    void CreateMaterial(Material material);
    void UpdateMaterial(Material material);
    void DeleteMaterial(int id);
}