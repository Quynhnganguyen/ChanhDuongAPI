﻿using ChuaNgotApp.SoapResponse;
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
        PleaseWaitForm pleaseWait = new PleaseWaitForm();

        public ChuaNgotForm()
        {
            InitializeComponent();
        }

        private void FibonacciButton_Click(object sender, EventArgs e)
        {
            if (fibonacciValid)
            {
                string body = @"<Fibonacci xmlns=""http://chanhduong.org/""><n>" + n + "</n></Fibonacci>";
                SoapService soapService = new SoapService(ChanhDuongURL);
                DialogResult messageBox;
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
                    messageBox = MessageBox.Show(textMessage, captionMessage, MessageBoxButtons.OK);
                }
            }
        }

        private void XmlToJsonButton_Click(object sender, EventArgs e)
        {
            if (xmlValid)
            {
                string xmlToSend = xml?.Replace("<", "&lt;");
                string body = @"<XmlToJson xmlns=""http://chanhduong.org/""><xml>" + xmlToSend + "</xml></XmlToJson>";
                SoapService soapService = new SoapService(ChanhDuongURL);
                DialogResult messageBox;
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
                    messageBox = MessageBox.Show(textMessage, captionMessage, MessageBoxButtons.OK);
                }
            }
        }

        private void TextBoxForN_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                fibonacciValid = true;
                if (textBox != null)
                    n = Int32.Parse(textBox.Text);
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
