using OTP.Entities;

namespace OTP.Repositories;

public interface IPurchaseRequestRepository
{
    IEnumerable<PurchaseRequest> ReadPurchaseRequests(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? materialId = null);
    void CreatePurchaseRequest(PurchaseRequest purchaseRequest);
}
