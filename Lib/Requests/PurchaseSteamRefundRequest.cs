namespace Steam.Net.Lib.Requests
{
    public class PurchaseSteamRefundRequest
    {
        public string Key { get; set; }
        public string OrderId { get; set; }
        public string AppId { get; set; }
    }
}
