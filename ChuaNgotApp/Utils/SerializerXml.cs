using System;
using System.IO;
using System.Xml.Serialization;

namespace ChuaNgotApp.Utils
{
    static class SerializerXml
    {
        public static object Deserialize(Type typeName, string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeName);
            TextReader reader = new StreamReader(xml);
            return serializer.Deserialize(reader);
        }
    }
}
