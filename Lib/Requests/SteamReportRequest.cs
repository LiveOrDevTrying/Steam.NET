namespace Steam.Net.Lib.Requests
{
    public class SteamReportRequest
    {
        public string Key { get; set; }
        public string AppId { get; set; }
        public string Type { get; set; }
        public string Time { get; set; }
        public int Maxresults { get; set; }
    }
}
