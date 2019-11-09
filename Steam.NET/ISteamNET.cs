using Steam.NET.Requests;
using Steam.NET.Responses;
using System.Threading.Tasks;

namespace Steam.NET
{
    public interface ISteamNET
    {
        Task<SteamAgreementResponse> GetSteamAgreementAsync(SteamAgreementRequest request);
        Task<SteamReportResponse> GetSteamReportAsync(SteamReportRequest request);
        Task<SteamTransactionResponse> GetSteamTransactionAsync(SteamTransactionRequest request);
        Task<SteamUserInfoResponse> GetSteamUserInfoAsync(SteamUserInfoRequest request);

        Task<PurchaseSteamAdjustAgreementResponse> PostSteamAdjustAgreementAsync(PurchaseSteamAdjustAgreementRequest request);
        Task<PurchaseSteamProcessAgreementResponse> PostSteamProcessAgreementAsync(PurchaseSteamProcessAgreementRequest request);

        Task<PurchaseSteamInitResponse> PostSteamInitPurchaseAsync(PurchaseSteamInitRequest request);
        Task<PurchaseSteamFinalizeResponse> PostSteamFinalizePurchaseAsync(PurchaseSteamFinalizeRequest request);
        Task<PurchaseSteamRefundResponse> PostSteamRefundPurchaseAsync(PurchaseSteamRefundRequest request);
    }
}