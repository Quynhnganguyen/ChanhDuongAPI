using System.Xml.Serialization;
namespace ChuaNgotApp.SoapResponse
{
    [XmlRoot(ElementName = "XmlToJsonResponse", Namespace = "http://chanhduong.org/")]
    public partial class XmlToJsonResponse
    {
        private string xmlToJsonResultField;

        [XmlElement("XmlToJsonResult")]
        public string XmlToJsonResult
        {
            get { return xmlToJsonResultField; }
            set { xmlToJsonResultField = value; }
        }
    }
}