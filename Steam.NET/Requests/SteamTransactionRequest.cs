namespace Steam.NET.Requests
{
    public class SteamTransactionRequest
    {
        public string Key { get; set; }
        public string AppId { get; set; }
        public string Orderid { get; set; }
        public string Transid { get; set; }
    }
}
