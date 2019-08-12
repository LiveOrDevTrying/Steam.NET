using System.Threading.Tasks;
using Steam.Net.Lib;
using Steam.Net.Lib.Requests;
using Steam.Net.Lib.Responses;

namespace Steam.Net.Services
{
    public interface ISteamWebAPI
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