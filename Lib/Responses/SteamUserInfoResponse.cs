using Newtonsoft.Json;

namespace Steam.Net.Lib.Responses
{
    public class SteamUserInfoResponse
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
            public string state { get; set; }
            public string country { get; set; }
            public string currency { get; set; }
            public string status { get; set; }
        }

        public class Errors
        {
            public string errorcode { get; set; }
            public string errordesc { get; set; }
        }
    }
}
