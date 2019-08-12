using Newtonsoft.Json;

namespace Steam.Net.Lib.Responses
{
    public class PurchaseSteamInitResponse
    {
        public Response response { get; set; }
        public class Response
        {
            public string result { get; set; }
            [JsonProperty(PropertyName = "params")]
            public Params _params { get; set; }
            public Errors error { get; set; }
        }

        public class Params
        {
            public string orderid { get; set; }
            public string transid { get; set; }
        }

        public class Errors
        {
            public int errorcode { get; set; }
            public string errordesc { get; set; }
        }
    }
}
