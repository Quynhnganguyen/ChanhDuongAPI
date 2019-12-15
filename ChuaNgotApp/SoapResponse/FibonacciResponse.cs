using System.Xml.Serialization;

namespace ChuaNgotApp.SoapResponse
{
    [XmlRoot("FibonacciResponse")]
    public class FibonacciResponse
    {
        [XmlElement("FibonacciResult")]
        public string FibonacciResult { get; set; }
    }
}
