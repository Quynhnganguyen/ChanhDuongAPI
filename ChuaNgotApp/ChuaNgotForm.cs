using ChuaNgotApp.SoapResponse;
using ChuaNgotApp.Utils;
using System;
using System.Windows.Forms;

namespace ChuaNgotApp
{
    public partial class ChuaNgotForm : Form
    {
        private int? n;
        private string xml;
        private bool fibonacciValid;
        private bool xmlValid;
        private const string ChanhDuongURL = "https://localhost:44382/ChuaNgotService.asmx";


        public ChuaNgotForm()
        {
            InitializeComponent();
        }

        private void FibonacciButton_Click(object sender, EventArgs e)
        {
            if (fibonacciValid)
            {
                Form waitForm = new WaitForm(this);
                waitForm.Show(this);
                string body = @"<Fibonacci xmlns=""http://chanhduong.org/""><n>" + n + "</n></Fibonacci>";
                SoapService soapService = new SoapService(ChanhDuongURL);
                string textMessage = "";
                string captionMessage = "";
                try
                {
                    soapService.SendRequest(body).Wait();
                    FibonacciResponse result = (FibonacciResponse)SerializerSoapXml.Deserialize(typeof(FibonacciResponse), soapService.response);
                    textMessage = result.FibonacciResult;
                    captionMessage = "Fibonacci of " + n;
                }
                catch (Exception ex)
                {
                    textMessage = ex.Message;
                    captionMessage = "Error";
                }
                finally
                {
                    waitForm.Close();
                    MessageBox.Show(textMessage, captionMessage, MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("N is blank!", "Info", MessageBoxButtons.OK);
            }

        }

        private void XmlToJsonButton_Click(object sender, EventArgs e)
        {
            if (xmlValid)
            {
                Form waitForm = new WaitForm(this);
                waitForm.Show(this);
                string xmlToSend = xml?.Replace("<", "&lt;");
                string body = @"<XmlToJson xmlns=""http://chanhduong.org/""><xml>" + xmlToSend + "</xml></XmlToJson>";
                SoapService soapService = new SoapService(ChanhDuongURL);
                string textMessage = "";
                string captionMessage = "";
                try
                {
                    soapService.SendRequest(body).Wait();
                    XmlToJsonResponse result = (XmlToJsonResponse)SerializerSoapXml.Deserialize(typeof(XmlToJsonResponse), soapService.response);
                    textMessage = result.XmlToJsonResult;
                    captionMessage = "Json";
                }
                catch (Exception ex)
                {
                    textMessage = ex.Message;
                    captionMessage = "Error";
                }
                finally
                {
                    waitForm.Close();
                    MessageBox.Show(textMessage, captionMessage, MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Xml is blank!", "Info", MessageBoxButtons.OK);
            }

        }

        private void TextBoxForN_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                fibonacciValid = true;
                if (textBox != null)
                    try
                    {
                        n = Int32.Parse(textBox.Text);
                    }
                    catch (FormatException)
                    {
                        if (!String.IsNullOrEmpty(textBox.Text))
                        {
                            MessageBox.Show("N must be an int!", "Info", MessageBoxButtons.OK);
                        }
                        else
                        {
                            fibonacciValid = false;
                        }
                    }
                else
                    fibonacciValid = false;
            }
        }

        private void TextBoxForXml_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                xmlValid = true;
                if (textBox != null)
                    xml = textBox.Text;
                else
                    xmlValid = false;
            }
        }
    }
}
