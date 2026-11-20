using OTP.Entities;

namespace OTP.Repositories.Implementations;

internal class PurchaseRequestRepository : IPurchaseRequestRepository
{
    public void CreatePurchaseRequest(PurchaseRequest purchaseRequest)
    {
    }

    public IEnumerable<PurchaseRequest> ReadPurchaseRequests(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? materialId = null)
    {
        return [];
    }
}
