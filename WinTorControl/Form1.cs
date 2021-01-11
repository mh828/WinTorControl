using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTorControl
{
    public partial class Form1 : Form
    {
        Core core;
        List<KeyValuePair<string, string>> TorEvents;
        string HashFileAuthentication;
        public Form1()
        {
            InitializeComponent();

            TorEvents = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("CIRC","Circuit status changed"),
                new KeyValuePair<string, string>("STREAM","Stream status changed"),
                new KeyValuePair<string, string>("ORCONN","OR Connection status changed"),
                new KeyValuePair<string, string>("BW","Bandwidth used in the last second"),

                new KeyValuePair<string, string>("DEBUG","Log DEBUG messages"),
                new KeyValuePair<string, string>("INFO","Log INFO messages"),
                new KeyValuePair<string, string>("NOTICE","Log NOTICE messages"),
                new KeyValuePair<string, string>("WARN","Log WARN messages"),
                new KeyValuePair<string, string>("ERR","Log ERR messages"),

                new KeyValuePair<string, string>("NEWDESC","New descriptors available"),

                new KeyValuePair<string, string>("ADDRMAP","ADDRMAP"),
                new KeyValuePair<string, string>("AUTHDIR_NEWDESCS","Descriptors uploaded to us in our role as authoritative dirserver"),
                new KeyValuePair<string, string>("DESCCHANGED","Our descriptor changed"),


                new KeyValuePair<string, string>("STATUS_GENERAL","General Status events"),
                new KeyValuePair<string, string>("STATUS_CLIENT","Client Status events"),
                new KeyValuePair<string, string>("STATUS_SERVER","Server Status events"),

                new KeyValuePair<string, string>("GUARD","Our set of guard nodes has changed"),
                new KeyValuePair<string, string>("STREAM_BW","Bandwidth used on an application stream"),
                new KeyValuePair<string, string>("CLIENTS_SEEN","Per-country client stats"),
                new KeyValuePair<string, string>("NEWCONSENSUS","New consensus networkstatus has arrived"),
                new KeyValuePair<string, string>("BUILDTIMEOUT_SET","New circuit buildtime has been set"),
                new KeyValuePair<string, string>("SIGNAL","Signal received"),
                new KeyValuePair<string, string>("CONF_CHANGED","Configuration changed"),
                new KeyValuePair<string, string>("CIRC_MINOR","Circuit status changed slightly"),
                new KeyValuePair<string, string>("TRANSPORT_LAUNCHED","Pluggable transport launched"),
                new KeyValuePair<string, string>("CIRC_BW","Bandwidth used by all streams attached to a circuit"),
                new KeyValuePair<string, string>("CELL_STATS","Per-circuit cell stats"),
                new KeyValuePair<string, string>("HS_DESC","HiddenService descriptors"),
                new KeyValuePair<string, string>("HS_DESC_CONTENT","HiddenService descriptors content"),
                new KeyValuePair<string, string>("NETWORK_LIVENESS","Network liveness has changed")
            };


            ((ListBox)checkedListBox1).DataSource = TorEvents;
            ((ListBox)checkedListBox1).DisplayMember = "Value";
            ((ListBox)checkedListBox1).ValueMember = "Key";

            cmbSignals.DataSource = new string[] {
                "RELOAD",
                "SHUTDOWN",
                "DUMP",
                "DEBUG",
                "HALT",
                "HUP",
                "INT",
                "USR1",
                "USR2",
                "TERM",
                "NEWNYM",
                "CLEARDNSCACHE",
                "HEARTBEAT",
                "ACTIVE",
                "DORMANT"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            core = new Core();
            core.OnConnectionClose += Core_OnConnectionClose;
            core.OnMessage += Core_OnMessage;
            core.OnEventNotification += Core_OnEventNotification;
        }

        void sendCommand(string command)
        {
            this.Enabled = false;
            core.command(command);
        }

        private void Core_OnEventNotification(string obj)
        {
            rtbEvents.AppendText(obj + "\n");
            rtbEvents.ScrollToCaret();
        }

        private void Core_OnMessage(string obj)
        {
            rtbMessages.AppendText(obj + "\n");
            rtbMessages.ScrollToCaret();
            this.Enabled = true;
        }

        private void Core_OnConnectionClose(Exception obj)
        {
            rtbMessages.AppendText(obj.Message + "\n");
            rtbMessages.ScrollToCaret();
            this.ChangeConnectionState(false);
        }

        private void btnMakeConnection_Click(object sender, EventArgs e)
        {
            ChangeConnectionState(true);
            if (core.connect(txtHost.Text, (int)numPort.Value))
            {
                if (!string.IsNullOrEmpty(HashFileAuthentication))
                    sendCommand(string.Format("AUTHENTICATE {0}", HashFileAuthentication));
                else
                    sendCommand(string.Format("AUTHENTICATE \"{0}\"", txtHashedPassword.Text));
            }
        }


        void ChangeConnectionState(bool connected)
        {
            this.gbxConnect.Enabled = !connected;
            this.gbxComment.Enabled =
                this.gbSignal.Enabled =
                this.gbEvents.Enabled =
                connected;
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            sendCommand(txtCommands.Text);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sendCommand("QUIT");
        }

        private void btnSetEvent_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (KeyValuePair<string, string> item in checkedListBox1.CheckedItems)
            {
                message += item.Key + " ";
            }

            sendCommand("SETEVENTS " + message.Trim());
        }

        private void btnClearEvents_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            sendCommand("SETEVENTS ");
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            rtbEvents.Text = "";
        }

        private void btnClearMessages_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = "";
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {
            if (cmbSignals.SelectedItem != null)
                sendCommand("SIGNAL " + cmbSignals.SelectedItem.ToString());
        }

        private void btnopeFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    HashFileAuthentication = BitConverter.ToString(File.ReadAllBytes(openFileDialog1.FileName)).Replace("-", string.Empty);
                }
            }
        }
    }
}
