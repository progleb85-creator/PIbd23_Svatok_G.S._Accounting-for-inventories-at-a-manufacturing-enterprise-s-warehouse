using OTP.Entities;

namespace OTP.Repositories;

public interface IDefectReturnRepository
{
    IEnumerable<DefectReturn> ReadDefectReturns(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? materialId = null, int? warehouseId = null);
    void CreateDefectReturn(DefectReturn defectReturn);
}
