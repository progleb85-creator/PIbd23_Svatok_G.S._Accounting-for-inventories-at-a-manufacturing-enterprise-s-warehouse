using OTP.Entities;

namespace OTP.Repositories.Implementations;

internal class DefectReturnRepository : IDefectReturnRepository
{
    public void CreateDefectReturn(DefectReturn defectReturn)
    {
    }

    public IEnumerable<DefectReturn> ReadDefectReturns(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? materialId = null, int? warehouseId = null)
    {
        return [];
    }
}
