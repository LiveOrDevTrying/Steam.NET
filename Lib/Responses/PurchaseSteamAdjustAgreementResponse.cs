using Newtonsoft.Json;

namespace Steam.Net.Lib.Responses
{
    public class PurchaseSteamAdjustAgreementResponse
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
            public string agreementid { get; set; }
            public string nextprocessdate { get; set; }
        }

        public class Errors
        {
            public string errorcode { get; set; }
            public string errordesc { get; set; }
        }
    }
}
