using System.Xml.Serialization;

namespace ChuaNgotApp.SoapResponse
{
    [XmlRoot("XmlToJsonResponse")]
    public class XmlToJsonResponse
    {
        [XmlElement("XmlToJsonResult")]
        public string XmlToJsonResult { get; set; }
    }
}
