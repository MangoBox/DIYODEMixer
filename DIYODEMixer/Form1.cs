using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYODEMixer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toggleConnectButton_Click(object sender, EventArgs e)
        {

            if (Program._serialPort.IsOpen)
            {
                //Serial port is open, time to close it!
                Program.CloseMixerCOM();
                SetCOMDisconnected();
            }
            else
            {
                //Serial port isn't open, time to open it!
                Program.OpenMixerCOM();
                SetCOMConnected();
            }
            
        }

        public void channelAssignmentChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int index;
            int.TryParse(comboBox.Name.Substring("sourceCombobox".Length - 1), out index);


        }

        public void SetCOMDisconnected()
        {
            statusText.Text = "Status: Disconnected";
            statusText.ForeColor = Color.Red;
            connectButton.Text = "Connect";
            comPortBox.Enabled = true;
        }

        public void SetCOMConnected()
        {
            statusText.Text = "Status: Connected";
            statusText.ForeColor = Color.Green;
            connectButton.Text = "Disconnect";
            comPortBox.Enabled = false;
        }

        private void changeCOMPort(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            String comPort = (string)comboBox.Items[comboBox.SelectedIndex];
            Program.portName = comPort;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
