using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuaNgotApp.Utils
{
    public class SoapService
    {
        private readonly string url;
        public string response;

        public SoapService(string url)
        {
            this.url = url;
        }
        public async Task SendRequest(string body)
        {
            try
            {
                response = await CreateSoapEnvelope(body).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                response = e.Message;
            }
        }
        public async Task<string> CreateSoapEnvelope(string body)
        {
            string soapString = @"<?xml version=""1.0"" encoding=""utf-8""?><soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""><soap:Body>"+
                  body +
                  @"</soap:Body></soap:Envelope>";

            HttpResponseMessage response = await PostXmlRequest(url, soapString).ConfigureAwait(false);
            string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return content;
        }

        public static async Task<HttpResponseMessage> PostXmlRequest(string baseUrl, string xmlString)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
                return await httpClient.PostAsync(baseUrl, httpContent).ConfigureAwait(false);
            }
        }
    }
}
