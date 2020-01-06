using ChanhDuongAPI.ServicesCore;
using Xunit;

namespace ChanhDuongAPI.Tests
{
    public class XmlToJsonTests
    {
        [Theory]
        [InlineData("hello")]
        [InlineData("<foo>hello</bar>")]
        public void XmlToJson_FailXmlShouldBeAnnounce(string xml)
        {
            string expected = "Bad Xml format";
            string actual = XmlToJson.Convert(xml);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("<foo/>", "{\"foo\":null}")]
        [InlineData("<foo>bar</foo>", "{\"foo\":\"bar\"}")]
        public void XmlToJson_SimpleXmlShouldBeConverted(string xml, string expected)
        {
            string actual = XmlToJson.Convert(xml);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void XmlToJson_LongXmlShouldBeConverted()
        {
            string xml = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            string expected = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";
            string actual = XmlToJson.Convert(xml);
            Assert.Equal(expected, actual);
        }
    }
}
