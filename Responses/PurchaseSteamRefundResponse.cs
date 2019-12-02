using Newtonsoft.Json;

namespace Steam.NET.Responses
{
    public class PurchaseSteamRefundResponse 
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
            public string errorcode { get; set; }
            public string errordesc { get; set; }
        }
    }
}
