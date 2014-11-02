namespace NET_PortMapper
{
    partial class AddMapping
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLocal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPublic = new System.Windows.Forms.NumericUpDown();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInternalIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(75, 6);
            this.tbDescription.MaxLength = 40;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(282, 20);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // nudLocal
            // 
            this.nudLocal.Location = new System.Drawing.Point(75, 32);
            this.nudLocal.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudLocal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLocal.Name = "nudLocal";
            this.nudLocal.Size = new System.Drawing.Size(120, 20);
            this.nudLocal.TabIndex = 2;
            this.nudLocal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLocal.ValueChanged += new System.EventHandler(this.nudLocal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Public Port";
            // 
            // nudPublic
            // 
            this.nudPublic.Location = new System.Drawing.Point(75, 58);
            this.nudPublic.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPublic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPublic.Name = "nudPublic";
            this.nudPublic.Size = new System.Drawing.Size(120, 20);
            this.nudPublic.TabIndex = 4;
            this.nudPublic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPublic.ValueChanged += new System.EventHandler(this.nudPublic_ValueChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 149);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "Ok";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(282, 149);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // cbProtocol
            // 
            this.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Location = new System.Drawing.Point(75, 84);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(121, 21);
            this.cbProtocol.TabIndex = 8;
            this.cbProtocol.SelectedIndexChanged += new System.EventHandler(this.cbProtocol_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Protocol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP-Address";
            // 
            // tbInternalIP
            // 
            this.tbInternalIP.Location = new System.Drawing.Point(75, 111);
            this.tbInternalIP.MaxLength = 40;
            this.tbInternalIP.Name = "tbInternalIP";
            this.tbInternalIP.Size = new System.Drawing.Size(282, 20);
            this.tbInternalIP.TabIndex = 11;
            // 
            // AddMapping
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(369, 184);
            this.ControlBox = false;
            this.Controls.Add(this.tbInternalIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProtocol);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPublic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMapping";
            this.Text = "Add a Mapping";
            ((System.ComponentModel.ISupportInitialize)(this.nudLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPublic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPublic;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInternalIP;
    }
}