namespace PryzmWare.USBUtill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filesList = new System.Windows.Forms.TreeView();
            this.txtDeviceLabel = new System.Windows.Forms.TextBox();
            this.chkSetDeviceLabl = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flwStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMin = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filesList);
            this.groupBox1.Controls.Add(this.txtDeviceLabel);
            this.groupBox1.Controls.Add(this.chkSetDeviceLabl);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(1317, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // filesList
            // 
            this.filesList.Location = new System.Drawing.Point(13, 47);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(1291, 76);
            this.filesList.TabIndex = 6;
            // 
            // txtDeviceLabel
            // 
            this.txtDeviceLabel.Location = new System.Drawing.Point(139, 21);
            this.txtDeviceLabel.Name = "txtDeviceLabel";
            this.txtDeviceLabel.Size = new System.Drawing.Size(1165, 20);
            this.txtDeviceLabel.TabIndex = 3;
            this.txtDeviceLabel.Text = "SHOTDOWNUSB";
            // 
            // chkSetDeviceLabl
            // 
            this.chkSetDeviceLabl.AutoSize = true;
            this.chkSetDeviceLabl.Location = new System.Drawing.Point(13, 23);
            this.chkSetDeviceLabl.Name = "chkSetDeviceLabl";
            this.chkSetDeviceLabl.Size = new System.Drawing.Size(108, 17);
            this.chkSetDeviceLabl.TabIndex = 2;
            this.chkSetDeviceLabl.Text = "Set Device Label";
            this.chkSetDeviceLabl.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flwStatus);
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1317, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // flwStatus
            // 
            this.flwStatus.AutoScroll = true;
            this.flwStatus.Location = new System.Drawing.Point(10, 20);
            this.flwStatus.Name = "flwStatus";
            this.flwStatus.Padding = new System.Windows.Forms.Padding(10);
            this.flwStatus.Size = new System.Drawing.Size(1301, 199);
            this.flwStatus.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1342, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1327, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Programed By Reece Ketley";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMin);
            this.groupBox3.Controls.Add(this.txtHour);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1317, 99);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // txtMin
            // 
            this.txtMin.AutoSize = true;
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMin.Location = new System.Drawing.Point(5, 42);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(203, 25);
            this.txtMin.TabIndex = 2;
            this.txtMin.Text = "USB\'s Per Minute:";
            this.txtMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHour
            // 
            this.txtHour.AutoSize = true;
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHour.Location = new System.Drawing.Point(5, 67);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(189, 25);
            this.txtHour.TabIndex = 1;
            this.txtHour.Text = "USB\'s Per Hour: ";
            this.txtHour.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtHour.Click += new System.EventHandler(this.txtHour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "USB\'s Proccesed: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PryzmWare - USBUtill";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDeviceLabel;
        private System.Windows.Forms.CheckBox chkSetDeviceLabl;
        private System.Windows.Forms.TreeView filesList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.FlowLayoutPanel flwStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMin;
        private System.Windows.Forms.Label txtHour;
    }
}

