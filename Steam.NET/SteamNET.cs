using Newtonsoft.Json;
using Steam.NET.Requests;
using Steam.NET.Responses;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Steam.NET
{
    public class SteamNET : ISteamNET
    {
        public virtual async Task<SteamUserInfoResponse> GetSteamUserInfoAsync(SteamUserInfoRequest request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var res = await client.GetAsync($"https://partner.steam-api.com/ISteamMicroTxn/GetUserInfo/v2?key={request.Key}&steamid={request.SteamId}");

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<SteamUserInfoResponse>(response);
                    }
                }
            }
            catch
            { }

            return null;
        }
        public virtual async Task<SteamReportResponse> GetSteamReportAsync(SteamReportRequest request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var res = await client.GetAsync($"https://partner.steam-api.com/ISteamMicroTxn/GetReport/v4/?key={request.Key}&appid={request.AppId}&type={request.Type}&time={request.Time}&maxresults={request.Maxresults}");

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<SteamReportResponse>(response);
                    }
                }
            }
            catch
            { }

            return null;
        }
        public virtual async Task<SteamAgreementResponse> GetSteamAgreementAsync(SteamAgreementRequest request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var res = await client.GetAsync($"https://partner.steam-api.com/ISteamMicroTxn/GetUserAgreementInfo/v1/?key={request.Key}&steamid={request.SteamId}&appid={request.AppId}");

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<SteamAgreementResponse>(response);
                    }
                }
            }
            catch
            { }

            return null;
        }
        public virtual async Task<SteamTransactionResponse> GetSteamTransactionAsync(SteamTransactionRequest request)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var res = await client.GetAsync($"https://partner.steam-api.com/ISteamMicroTxn/QueryTxn/v2/?key={request.Key}&appid={request.AppId}&orderid={request.Orderid}&transid={request.Transid}");

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<SteamTransactionResponse>(response);
                    }
                }
            }
            catch
            { }

            return null;
        }

        public virtual async Task<PurchaseSteamInitResponse> PostSteamInitPurchaseAsync(PurchaseSteamInitRequest request)
        {
            var formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("amount[0]", (request.Amount * 100).ToString()),
                new KeyValuePair<string, string>("appid", request.AppId),
                new KeyValuePair<string, string>("currency", request.Currency),
                new KeyValuePair<string, string>("description[0]", request.Description),
                new KeyValuePair<string, string>("itemcount", request.ItemCount.ToString()),
                new KeyValuePair<string, string>("itemid[0]", request.ItemId),
                new KeyValuePair<string, string>("key", request.Key),
                new KeyValuePair<string, string>("language", request.Language),
                new KeyValuePair<string, string>("orderid", request.OrderId),
                new KeyValuePair<string, string>("qty[0]", request.Qty.ToString()),
                new KeyValuePair<string, string>("steamid", request.SteamId)
            };

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var req = new HttpRequestMessage(HttpMethod.Post, "https://partner.steam-api.com/ISteamMicroTxn/InitTxn/v3/")
                    {
                        Content = new FormUrlEncodedContent(formData)
                    };

                    var res = await client.SendAsync(req);

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<PurchaseSteamInitResponse>(response);
                    }
                }
            }
            catch { }

            return null;
        }
        public virtual async Task<PurchaseSteamFinalizeResponse> PostSteamFinalizePurchaseAsync(PurchaseSteamFinalizeRequest request)
        {
            var formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("appid", request.AppId),
                new KeyValuePair<string, string>("key", request.Key),
                new KeyValuePair<string, string>("orderid", request.OrderId),
            };

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var req = new HttpRequestMessage(HttpMethod.Post, "https://partner.steam-api.com/ISteamMicroTxn/FinalizeTxn/v2/")
                    {
                        Content = new FormUrlEncodedContent(formData)
                    };

                    var res = await client.SendAsync(req);

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<PurchaseSteamFinalizeResponse>(response);
                    }
                }
            }
            catch { }

            return null;
        }
        public virtual async Task<PurchaseSteamRefundResponse> PostSteamRefundPurchaseAsync(PurchaseSteamRefundRequest request)
        {
            var formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("appid", request.AppId),
                new KeyValuePair<string, string>("key", request.Key),
                new KeyValuePair<string, string>("orderid", request.OrderId),
            };

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var req = new HttpRequestMessage(HttpMethod.Post, "https://partner.steam-api.com/ISteamMicroTxn/RefundTxn/v2/")
                    {
                        Content = new FormUrlEncodedContent(formData)
                    };

                    var res = await client.SendAsync(req);

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<PurchaseSteamRefundResponse>(response);
                    }
                }
            }
            catch { }

            return null;
        }

        public virtual async Task<PurchaseSteamProcessAgreementResponse> PostSteamProcessAgreementAsync(PurchaseSteamProcessAgreementRequest request)
        {
            var formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("appid", request.AppId),
                new KeyValuePair<string, string>("key", request.Key),
                new KeyValuePair<string, string>("steamid", request.SteamId),
                new KeyValuePair<string, string>("agreementid", request.Agreementid),
                new KeyValuePair<string, string>("nextprocessdate", request.Nextprocessdate),
            };

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var req = new HttpRequestMessage(HttpMethod.Post, "https://partner.steam-api.com/ISteamMicroTxn/ProcessAgreement/v1/")
                    {
                        Content = new FormUrlEncodedContent(formData)
                    };

                    var res = await client.SendAsync(req);

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<PurchaseSteamProcessAgreementResponse>(response);
                    }
                }
            }
            catch { }

            return null;
        }
        public virtual async Task<PurchaseSteamAdjustAgreementResponse> PostSteamAdjustAgreementAsync(PurchaseSteamAdjustAgreementRequest request)
        {
            var formData = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("appid", request.AppId),
                new KeyValuePair<string, string>("key", request.Key),
                new KeyValuePair<string, string>("steamid", request.SteamId),
                new KeyValuePair<string, string>("agreementid", request.Agreementid),
                new KeyValuePair<string, string>("nextprocessdate", request.Nextprocessdate),
            };

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var req = new HttpRequestMessage(HttpMethod.Post, "https://partner.steam-api.com/ISteamMicroTxn/AdjustAgreement/v1/")
                    {
                        Content = new FormUrlEncodedContent(formData)
                    };

                    var res = await client.SendAsync(req);

                    if (res.IsSuccessStatusCode)
                    {
                        var response = await res.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<PurchaseSteamAdjustAgreementResponse>(response);
                    }
                }
            }
            catch { }

            return null;
        }
    }
}
