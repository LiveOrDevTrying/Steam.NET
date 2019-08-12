namespace Steam.Net.Lib.Requests
{
    public class PurchaseSteamAdjustAgreementRequest
    {
        public string Key { get; set; }
        public string SteamId { get; set; }
        public string AppId { get; set; }
        public string Agreementid { get; set; }
        public string Nextprocessdate { get; set; }
    }
}
