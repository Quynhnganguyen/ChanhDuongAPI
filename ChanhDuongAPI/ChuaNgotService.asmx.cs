using System;
using System.Numerics;
using System.Web.Services;
using System.Xml;

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
            BigInteger response = -1;
            if (1<= n && n <= 100)
            {
                response = CalculFibonacci(n);
            }
            return response.ToString();
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            string response;
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);
                response = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
            }
            catch (XmlException e)
            {
                response = "Bad Xml format";
                string error = e.Message;
            }

            return response;
        }

        private BigInteger CalculFibonacci(int n)
        {
            BigInteger a = 0;
            BigInteger b = 1;
            for (int i = 31; i >= 0; i--)
            {
                BigInteger d = a * (b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

    }
}
