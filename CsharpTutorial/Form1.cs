using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebifiLib;

namespace CsharpTutorial
{
    public partial class Form1 : Form
    {
        private List<string> discoveredNames;
        private List<int> discoveredSessionIDs;

        public Form1()
        {
            InitializeComponent();
        }

        private void webifiControl_ConnectionStatus(object sender, bool connected)
        {
            if (connected)
            {
                textBoxMessages.Text = "Connection successful";
                buttonSend.Enabled = true;
                buttonSendDiscovery.Enabled = true;
            }
            else
            {
                textBoxMessages.Text = "Disconnected";
                buttonSend.Enabled = false;
                buttonSendDiscovery.Enabled = false;
            }
        }

        private void webifiControl_DataReceived(object sender, byte[] data, string dataType, int fromSessionID)
        {
            //check if received data is a discovery response
            if (dataType == "Discovery Response")
            {
                string discoveredName = Webifi.ConvertByteArrayToString(data);
                discoveredNames.Add(discoveredName);
                discoveredSessionIDs.Add(fromSessionID);
                textBoxMessages.Text = "Number of devices discovered: " + discoveredSessionIDs.Count.ToString();
            }
            else
            {
                //data received from another device
                string dataStr = Webifi.ConvertByteArrayToString(data);
                textBoxRec.Text = textBoxRec.Text + dataStr + "(Data type: " + dataType + ", from: " + fromSessionID.ToString() + ")";
            }
        }

        private void webifiControl_Error(object sender, string errorCode)
        {
            textBoxMessages.Text = "Error " + errorCode + ": " + webifiControl.GetErrorCodeDescription(errorCode);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            WebifiDataToSend sendData = new WebifiDataToSend();
            //convert the string to a byte array for sending.
            sendData.dataForSending = Encoding.UTF8.GetBytes(textBoxSend.Text);
            sendData.dataType = "Test data";  //optional field
            webifiControl.SendData(sendData);
        }

        private void buttonSendDiscovery_Click(object sender, EventArgs e)
        {
            discoveredNames = new List<string>();
            discoveredSessionIDs = new List<int>();
            webifiControl.SendDiscovery();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRec.Text = "";
        }
    }
}
