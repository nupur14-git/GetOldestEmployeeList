using System.Net;
using System.Net.Http.Headers;

namespace Web
{
    public class ClientResponse : IClientResponse
    {
        public const string API_URL = "http://dummy.restapiexample.com/api/v1/employees";
        public async Task<EmployeeResponse> GetThirdPartyResponse()
        {
            var thirdPartyResponse = new EmployeeResponse();
            try
            {
                var handler = new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli,
                    AllowAutoRedirect = false
                };
                HttpClient client = new HttpClient(handler);
                try
                {

                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("en-US"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
                    client.DefaultRequestHeaders.Connection.Add("keep-alive");
                    client.DefaultRequestHeaders.Referrer = new Uri("https://dummy.restapiexample.com/");
                    client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue { NoCache = true };
                    client.DefaultRequestHeaders.Add("Cookie", "humans_21909=1");

                    HttpResponseMessage responseMessage = await client.GetAsync(API_URL);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var data = responseMessage.Content.ReadAsStringAsync().Result;
                        thirdPartyResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<EmployeeResponse>(data);
                    }
                    else
                    {
                        thirdPartyResponse = null;
                    }
                }
                catch (Exception ex)
                {
                    //gulp the error for now
                    thirdPartyResponse = null;
                }
            }
            catch (Exception ex)
            {
                thirdPartyResponse = null;
            }
            return thirdPartyResponse;
        }
    }
}
