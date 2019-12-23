using System.Xml.Serialization;

namespace ChuaNgotApp.SoapResponse
{
    [XmlRoot(ElementName = "FibonacciResponse", Namespace = "http://chanhduong.org/")]
    public partial class FibonacciResponse
    {
        private string fibonacciResultField;

        [XmlElement("FibonacciResult")]
        public string FibonacciResult
        {
            get { return fibonacciResultField; }
            set { fibonacciResultField = value; }
        }
    }
}
