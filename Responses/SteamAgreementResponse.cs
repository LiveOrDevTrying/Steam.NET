using Newtonsoft.Json;

namespace Steam.NET.Responses
{
    public class SteamAgreementResponse
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
            public Agreement[] agreements { get; set; }

            public class Agreement
            {
                public string agreementid { get; set; }
                public string itemid { get; set; }
                public string status { get; set; }
                public string period { get; set; }
                public string frequency { get; set; }
                public string startdate { get; set; }
                public string enddate { get; set; }
                public string recurringamt { get; set; }
                public string currency { get; set; }
                public string timecreated { get; set; }
                public string lastpayment { get; set; }
                public string lastamount { get; set; }
                public string nextpayment { get; set; }
                public string outstanding { get; set; }
                public string failedattempts { get; set; }
            }
        }

        public class Errors
        {
            public string errorcode { get; set; }
            public string errordesc { get; set; }
        }
    }
}
