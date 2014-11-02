using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

using Mono.Nat;

namespace NET_PortMapper
{
    public partial class AddMapping : Form
    {
        public enum AddPortOptions { TCP, UDP, Both }
        
        public bool success = false;
        public string description;
        public int localport, publicport;
        public IPAddress internalIP;
        public AddPortOptions protocol;
        
        public AddMapping()
        {
            internalIP = IPAddress.None;

            InitializeComponent();

            cbProtocol.Items.Clear();
            string[] items = Enum.GetNames(typeof(AddPortOptions));
            for (int i = 0; i < items.Length; i++)
                cbProtocol.Items.Add(items[i]);
            cbProtocol.Text = "TCP";
            protocol = AddPortOptions.TCP;

            tbDescription.Text = "My Port Map";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Validation
            if (!String.IsNullOrEmpty(tbInternalIP.Text)
                && !IPAddress.TryParse(tbInternalIP.Text, out internalIP))
            {
                MessageBox.Show("You must enter a valid IP (or an empty one to use your current ip)", "Invalid IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                success = true;
                this.Close();
            }
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            description = tbDescription.Text;
        }

        private void nudPublic_ValueChanged(object sender, EventArgs e)
        {
            publicport = Convert.ToInt32(nudPublic.Value);
        }

        private void nudLocal_ValueChanged(object sender, EventArgs e)
        {
            localport = Convert.ToInt32(nudLocal.Value);
        }

        private void cbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items = Enum.GetNames(typeof(AddPortOptions));
            for (int i = 0; i < items.Length; i++)
                if (items[i] == cbProtocol.Text)
                    protocol = (AddPortOptions)i;
        }
    }
}
