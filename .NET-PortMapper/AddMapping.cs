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
        public AddPortOptions protocol;
        
        public AddMapping()
        {
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
            success = true;
            this.Close();
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
