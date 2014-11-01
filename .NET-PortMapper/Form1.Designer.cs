namespace NET_PortMapper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbDevices = new System.Windows.Forms.GroupBox();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbMappings = new System.Windows.Forms.GroupBox();
            this.lvMappings = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDeviceInfo = new System.Windows.Forms.GroupBox();
            this.tbDeviceInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btRemoveAll = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.timerCurrent = new System.Windows.Forms.Timer(this.components);
            this.timerBackground = new System.Windows.Forms.Timer(this.components);
            this.gbDevices.SuspendLayout();
            this.gbMappings.SuspendLayout();
            this.gbDeviceInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDevices
            // 
            this.gbDevices.Controls.Add(this.lvDevices);
            this.gbDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDevices.Location = new System.Drawing.Point(0, 0);
            this.gbDevices.Name = "gbDevices";
            this.gbDevices.Size = new System.Drawing.Size(734, 157);
            this.gbDevices.TabIndex = 0;
            this.gbDevices.TabStop = false;
            this.gbDevices.Text = "Devices";
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDevices.GridLines = true;
            this.lvDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDevices.Location = new System.Drawing.Point(3, 16);
            this.lvDevices.MultiSelect = false;
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(728, 138);
            this.lvDevices.TabIndex = 0;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            this.lvDevices.SelectedIndexChanged += new System.EventHandler(this.lvDevices_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP-Address";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "External IP";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mappings";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UUID";
            this.columnHeader4.Width = 350;
            // 
            // gbMappings
            // 
            this.gbMappings.Controls.Add(this.lvMappings);
            this.gbMappings.Controls.Add(this.gbDeviceInfo);
            this.gbMappings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMappings.Location = new System.Drawing.Point(0, 157);
            this.gbMappings.Name = "gbMappings";
            this.gbMappings.Size = new System.Drawing.Size(734, 372);
            this.gbMappings.TabIndex = 1;
            this.gbMappings.TabStop = false;
            this.gbMappings.Text = "Mappings";
            // 
            // lvMappings
            // 
            this.lvMappings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvMappings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMappings.GridLines = true;
            this.lvMappings.Location = new System.Drawing.Point(3, 16);
            this.lvMappings.Name = "lvMappings";
            this.lvMappings.Size = new System.Drawing.Size(464, 353);
            this.lvMappings.TabIndex = 3;
            this.lvMappings.UseCompatibleStateImageBehavior = false;
            this.lvMappings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Local-Port";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Public-Port";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Protocol";
            this.columnHeader11.Width = 100;
            // 
            // gbDeviceInfo
            // 
            this.gbDeviceInfo.Controls.Add(this.tbDeviceInfo);
            this.gbDeviceInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbDeviceInfo.Location = new System.Drawing.Point(467, 16);
            this.gbDeviceInfo.Name = "gbDeviceInfo";
            this.gbDeviceInfo.Size = new System.Drawing.Size(264, 353);
            this.gbDeviceInfo.TabIndex = 2;
            this.gbDeviceInfo.TabStop = false;
            this.gbDeviceInfo.Text = "Device Information";
            // 
            // tbDeviceInfo
            // 
            this.tbDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDeviceInfo.Location = new System.Drawing.Point(3, 16);
            this.tbDeviceInfo.Multiline = true;
            this.tbDeviceInfo.Name = "tbDeviceInfo";
            this.tbDeviceInfo.ReadOnly = true;
            this.tbDeviceInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDeviceInfo.Size = new System.Drawing.Size(258, 334);
            this.tbDeviceInfo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.btRemoveAll);
            this.panel1.Controls.Add(this.btAbout);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 33);
            this.panel1.TabIndex = 2;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(276, 7);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btRemoveAll
            // 
            this.btRemoveAll.Location = new System.Drawing.Point(168, 7);
            this.btRemoveAll.Name = "btRemoveAll";
            this.btRemoveAll.Size = new System.Drawing.Size(102, 23);
            this.btRemoveAll.TabIndex = 3;
            this.btRemoveAll.Text = "Remove All";
            this.btRemoveAll.UseVisualStyleBackColor = true;
            this.btRemoveAll.Click += new System.EventHandler(this.btRemoveAll_Click);
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(357, 7);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(75, 23);
            this.btAbout.TabIndex = 2;
            this.btAbout.Text = "About";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(87, 7);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(6, 7);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 0;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // timerCurrent
            // 
            this.timerCurrent.Interval = 1000;
            this.timerCurrent.Tick += new System.EventHandler(this.timerCurrent_Tick);
            // 
            // timerBackground
            // 
            this.timerBackground.Interval = 10000;
            this.timerBackground.Tick += new System.EventHandler(this.timerBackground_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 562);
            this.Controls.Add(this.gbMappings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDevices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "Form1";
            this.Text = ".NET Port Mapping tool";
            this.gbDevices.ResumeLayout(false);
            this.gbMappings.ResumeLayout(false);
            this.gbDeviceInfo.ResumeLayout(false);
            this.gbDeviceInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDevices;
        private System.Windows.Forms.GroupBox gbMappings;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox gbDeviceInfo;
        private System.Windows.Forms.TextBox tbDeviceInfo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.ListView lvMappings;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btRemoveAll;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timerCurrent;
        private System.Windows.Forms.Timer timerBackground;
        private System.Windows.Forms.Button btUpdate;
    }
}

