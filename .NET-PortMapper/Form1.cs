using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

using Mono.Nat;
using Mono.Nat.Upnp;
using Mono.Nat.Pmp;

namespace NET_PortMapper
{
    public partial class Form1 : Form
    {
        List<INatDevice> devices = new List<INatDevice>();
        
        public Form1()
        {
            InitializeComponent();
            //Hook into the events so you know when a router has been detected or has gone offline
            NatUtility.DeviceFound += DeviceFound;
            NatUtility.DeviceLost += DeviceLost;

            //Start searching for upnp enabled routers
            NatUtility.StartDiscovery();
        }

        delegate void AddDeviceDelegate(INatDevice device);
        delegate void RemoveDeviceDelegate(INatDevice device);

        /// <summary>
        /// Adding devices to the list and listbox
        /// </summary>
        /// <param name="device"></param>
        private void AddDevice(INatDevice device)
        {
            if (!devices.Contains(device))
            {
                devices.Add(device);
                //listBoxDevices.Items.Add(device.ToString());
                IPAddress external = device.GetExternalIP();
                Mapping[] maps = device.GetAllMappings();

                //complicated stuff because the library only allows to display some data via .ToString() as far as I know
                string str = device.ToString();
                lvDevices.Items.Add(ReadBetween("EndPoint:", ",", str));
                lvDevices.Items[lvDevices.Items.Count-1].SubItems.Add(external.ToString());
                lvDevices.Items[lvDevices.Items.Count - 1].SubItems.Add(maps.Length.ToString());
                lvDevices.Items[lvDevices.Items.Count - 1].SubItems.Add(ReadBetween("/dyndev/uuid:", ",", str));

                //if it's the first added, select it
                if (lvDevices.Items.Count == 1)
                    lvDevices.Items[0].Selected = true;
            }
        }

        /// <summary>
        /// Remove the device
        /// </summary>
        /// <param name="device"></param>
        private void RemoveDevice(INatDevice device)
        {
            if (devices.Contains(device))
            {
                devices.Remove(device);
                for (int i = 0; i < lvDevices.Items.Count; i++)
                {
                    if (device.ToString().Contains(lvDevices.Items[i].SubItems[3].Text))
                    {
                        lvDevices.Items.Remove(lvDevices.Items[i]);
                    }
                }
            }
        }
        
        /// <summary>
        /// Event that handles a new found device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void DeviceFound(object sender, DeviceEventArgs args)
        {
            //Make it thread-safe
            AddDeviceDelegate AddDeviceInstance = new AddDeviceDelegate(this.AddDevice);
            this.Invoke(AddDeviceInstance, new object[] { args.Device });
        }

        /// <summary>
        /// Is called when the connection to a device is lost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void DeviceLost(object sender, DeviceEventArgs args)
        {
            RemoveDeviceDelegate RemoveDeviceInstance = new RemoveDeviceDelegate(RemoveDevice);
            this.Invoke(RemoveDeviceInstance, new object[] { args.Device });
        }

        /// <summary>
        /// Read a value between 2 strings in a string
        /// </summary>
        /// <param name="begin">Starting string</param>
        /// <param name="end">Tailing string</param>
        /// <param name="text">The string containing text</param>
        /// <returns></returns>
        string ReadBetween(string begin, string end, string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (begin.Length + i > text.Length)
                    return null;
                if (text.Substring(i, begin.Length) == begin)
                {
                    for (int j = i + begin.Length; j < text.Length; j++)
                    {
                        if (end.Length + j > text.Length)
                            return null;
                        if (text.Substring(j, end.Length) == end)
                        {
                            return text.Substring(i + begin.Length, j - (i + begin.Length));
                        }
                    }
                }
            }
            return null;
        }

        private void lvDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if something is selected
            if (lvDevices.SelectedItems.Count > 0)
            {
                tbDeviceInfo.Text = GetDeviceByUUID(lvDevices.SelectedItems[0].SubItems[3].Text).ToString();
                UpdateMappings(lvDevices.SelectedItems[0].SubItems[3].Text);
            }
            else
            {
                tbDeviceInfo.Text = "";
                lvMappings.Items.Clear();
            }
        }

        INatDevice GetDeviceByUUID(string uuid)
        {
            INatDevice device = null;
            for (int i = 0; i < devices.Count; i++)
            {
                if (devices[i].ToString().Contains(lvDevices.SelectedItems[0].SubItems[3].Text))
                {
                    device = devices[i];
                }
            }
            return device;
        }

        private void UpdateMappings(string uuid)
        {
            INatDevice device = null;
            for (int i = 0; i < devices.Count; i++)
            {
                if (devices[i].ToString().Contains(lvDevices.SelectedItems[0].SubItems[3].Text))
                {
                    device = devices[i];
                }
            }

            lvMappings.Items.Clear();
            foreach (Mapping mp in device.GetAllMappings())
            {
                lvMappings.Items.Add(mp.Description);
                lvMappings.Items[lvMappings.Items.Count - 1].SubItems.Add(mp.PrivatePort.ToString());
                lvMappings.Items[lvMappings.Items.Count - 1].SubItems.Add(mp.PublicPort.ToString());
                lvMappings.Items[lvMappings.Items.Count - 1].SubItems.Add(mp.Protocol.ToString());
                lvMappings.Items[lvMappings.Items.Count - 1].SubItems.Add(mp.InternalIP.ToString());
            }
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }


        private void AddMap(ref INatDevice device, Protocol ptype, IPAddress internalIP, int localport, int publicport, string description)
        {
            try
            {
                Mapping mapper = null;
                mapper = new Mapping(ptype, internalIP, localport, publicport);
                mapper.Description = description;
                device.CreatePortMap(mapper);
            }
            catch (MappingException)
            {
                MessageBox.Show("Sorry, something went wrong.\n"
                    + "Could not add the port due to an error.\n"
                    + "This error may occur because the port is already taken\n"
                    + "or the port lies within a not allowed range.\n\n"
                    + "Try a different port, for example above 1024.", "Error...");
            }
            catch (Exception e)
            {
                MessageBox.Show("An unknown error occurred. The content of the error is:\n\n" + e.ToString(), "Error...");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lvDevices.SelectedItems.Count > 0)
            {
                INatDevice device = GetDeviceByUUID(lvDevices.SelectedItems[0].SubItems[3].Text);
                AddMapping map = new AddMapping();
                
                map.ShowDialog();
                if (map.success)
                {
                    if (map.protocol == AddMapping.AddPortOptions.Both)
                    {
                        AddMap(ref device, Protocol.Tcp, map.internalIP, map.localport, map.publicport, map.description);
                        AddMap(ref device, Protocol.Udp, map.internalIP, map.localport, map.publicport, map.description);
                    }
                    else if (map.protocol == AddMapping.AddPortOptions.TCP)
                    {
                        AddMap(ref device, Protocol.Tcp, map.internalIP, map.localport, map.publicport, map.description);
                    }
                    else if (map.protocol == AddMapping.AddPortOptions.UDP)
                    {
                        AddMap(ref device, Protocol.Udp, map.internalIP, map.localport, map.publicport, map.description);
                    }
                    UpdateMappings(lvDevices.SelectedItems[0].SubItems[3].Text);
                }
            }
            else
            {
                MessageBox.Show("Please select a device from the devices list to add the portmap to", "Oops...");
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lvDevices.SelectedItems.Count > 0)
            {
                INatDevice device = GetDeviceByUUID(lvDevices.SelectedItems[0].SubItems[3].Text);
                for (int i = 0; i < lvMappings.SelectedItems.Count; i++)
                {
                    foreach (Mapping mp in device.GetAllMappings())
                    {
                        if (mp.PrivatePort == Convert.ToInt32(lvMappings.SelectedItems[i].SubItems[1].Text) &&
                            mp.PublicPort == Convert.ToInt32(lvMappings.SelectedItems[i].SubItems[2].Text) &&
                            mp.Protocol.ToString() == lvMappings.SelectedItems[i].SubItems[3].Text &&
                            mp.Description == lvMappings.SelectedItems[i].SubItems[0].Text)
                        {
                            device.DeletePortMap(mp);
                        }
                    }
                }
                UpdateMappings(lvDevices.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            if (lvDevices.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove all mappings?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    INatDevice device = GetDeviceByUUID(lvDevices.SelectedItems[0].SubItems[3].Text);
                    foreach (Mapping mp in device.GetAllMappings())
                        device.DeletePortMap(mp);
                    UpdateMappings(lvDevices.SelectedItems[0].SubItems[3].Text);
                }
            }
        }

        /// <summary>
        /// This timer updates the amount of mappings for non selected hosts every 10 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBackground_Tick(object sender, EventArgs e)
        {
            //not ready yet
        }

        /// <summary>
        /// This timer updates the mappings (if changed) for the selected host
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            if (lvDevices.SelectedItems.Count > 0)
            {
                INatDevice device = GetDeviceByUUID(lvDevices.SelectedItems[0].SubItems[3].Text);
                Mapping[] maps = device.GetAllMappings();
                if (maps.Length != Convert.ToInt32(lvDevices.SelectedItems[0].SubItems[2].Text))
                {
                    lvDevices.SelectedItems[0].SubItems[2].Text = maps.Length.ToString();
                    UpdateMappings(lvDevices.SelectedItems[0].SubItems[3].Text);
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (lvDevices.SelectedItems.Count > 0)
            {
                INatDevice device = GetDeviceByUUID(lvDevices.SelectedItems[0].SubItems[3].Text);
                Mapping[] maps = device.GetAllMappings();
                if (maps.Length != Convert.ToInt32(lvDevices.SelectedItems[0].SubItems[2].Text))
                {
                    lvDevices.SelectedItems[0].SubItems[2].Text = maps.Length.ToString();
                    UpdateMappings(lvDevices.SelectedItems[0].SubItems[3].Text);
                }
            }
        }
    }
}
