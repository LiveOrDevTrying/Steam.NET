namespace Steam.NET.Requests
{
    public class PurchaseSteamFinalizeRequest
    {
        public string Key { get; set; }
        public string OrderId { get; set; }
        public string AppId { get; set; }
    }
}
