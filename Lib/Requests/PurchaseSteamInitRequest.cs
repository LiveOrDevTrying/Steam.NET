namespace Steam.Net.Lib.Requests
{
    public class PurchaseSteamInitRequest
    {
        public string Key { get; set; }
        public string OrderId { get; set; }
        public string SteamId { get; set; }
        public string AppId { get; set; }
        public int ItemCount { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string ItemId { get; set; }
        public int Qty { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
    }
}
