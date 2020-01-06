using System.Numerics;
using System.Web.Services;

namespace ChanhDuongAPI
{
    /// <summary>
    /// Summary description for Fibonacci
    /// </summary>
    [WebService(Namespace = "http://chanhduong.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ChuaNgotService : WebService
    {

        [WebMethod]
        public string Fibonacci(int n)
        {
            BigInteger response = ServicesCore.Fibonacci.Calculate(n);
            return response.ToString();
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            string response = ServicesCore.XmlToJson.Convert(xml);
            return response;
        }
    }
}
