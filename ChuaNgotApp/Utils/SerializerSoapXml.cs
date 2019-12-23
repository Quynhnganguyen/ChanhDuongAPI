using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ChuaNgotApp.Utils
{
    static class SerializerSoapXml
    {
        public static object Deserialize(Type typeName, string xmlResponse)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlResponse);
            XmlNamespaceManager ns = new XmlNamespaceManager(xmlDocument.NameTable);
            ns.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            ns.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
            var bodyNode = xmlDocument.SelectSingleNode("//soap:Envelope/soap:Body", ns);

            XmlSerializer serializer = new XmlSerializer(typeName);
            StringReader reader = new StringReader(bodyNode.InnerXml);
            return serializer.Deserialize(reader);
        }
    }
}
