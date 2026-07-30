namespace mod_sysutil_diag_and_maint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            Maintenance = new TabPage();
            lblStatus = new Label();
            btnDeleteTemp = new Button();
            txtLog = new RichTextBox();
            btnFLushDNS = new Button();
            Diagnostics = new TabPage();
            lblGpuTemp = new Label();
            lblCpuTemp = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            Maintenance.SuspendLayout();
            Diagnostics.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Maintenance);
            tabControl1.Controls.Add(Diagnostics);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(987, 667);
            tabControl1.TabIndex = 0;
            // 
            // Maintenance
            // 
            Maintenance.Controls.Add(lblStatus);
            Maintenance.Controls.Add(btnDeleteTemp);
            Maintenance.Controls.Add(txtLog);
            Maintenance.Controls.Add(btnFLushDNS);
            Maintenance.Location = new Point(4, 24);
            Maintenance.Name = "Maintenance";
            Maintenance.Padding = new Padding(3);
            Maintenance.Size = new Size(979, 639);
            Maintenance.TabIndex = 0;
            Maintenance.Text = "Maintenance";
            Maintenance.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 81);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status: Idle";
            // 
            // btnDeleteTemp
            // 
            btnDeleteTemp.Location = new Point(129, 27);
            btnDeleteTemp.Name = "btnDeleteTemp";
            btnDeleteTemp.Size = new Size(137, 43);
            btnDeleteTemp.TabIndex = 2;
            btnDeleteTemp.Text = "Delete Temporary Files";
            btnDeleteTemp.UseVisualStyleBackColor = true;
            btnDeleteTemp.Click += btnDeleteTemp_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(15, 138);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(507, 206);
            txtLog.TabIndex = 1;
            txtLog.Text = "";
            // 
            // btnFLushDNS
            // 
            btnFLushDNS.Location = new Point(15, 27);
            btnFLushDNS.Name = "btnFLushDNS";
            btnFLushDNS.Size = new Size(108, 43);
            btnFLushDNS.TabIndex = 0;
            btnFLushDNS.Text = "Flsuh DNS";
            btnFLushDNS.UseVisualStyleBackColor = true;
            btnFLushDNS.Click += btnFLushDNS_Click;
            // 
            // Diagnostics
            // 
            Diagnostics.Controls.Add(lblGpuTemp);
            Diagnostics.Controls.Add(lblCpuTemp);
            Diagnostics.Location = new Point(4, 24);
            Diagnostics.Name = "Diagnostics";
            Diagnostics.Padding = new Padding(3);
            Diagnostics.Size = new Size(979, 639);
            Diagnostics.TabIndex = 1;
            Diagnostics.Text = "Diagnostics";
            Diagnostics.UseVisualStyleBackColor = true;
            // 
            // lblGpuTemp
            // 
            lblGpuTemp.AutoSize = true;
            lblGpuTemp.Location = new Point(19, 59);
            lblGpuTemp.Name = "lblGpuTemp";
            lblGpuTemp.Size = new Size(95, 15);
            lblGpuTemp.TabIndex = 1;
            lblGpuTemp.Text = "GPU Temp: -- °C";
            // 
            // lblCpuTemp
            // 
            lblCpuTemp.AutoSize = true;
            lblCpuTemp.Location = new Point(19, 30);
            lblCpuTemp.Name = "lblCpuTemp";
            lblCpuTemp.Size = new Size(95, 15);
            lblCpuTemp.TabIndex = 0;
            lblCpuTemp.Text = "CPU Temp: -- °C";
            lblCpuTemp.Click += lblCpuTemp_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 890);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Maintenance.ResumeLayout(false);
            Maintenance.PerformLayout();
            Diagnostics.ResumeLayout(false);
            Diagnostics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Maintenance;
        private Button btnFLushDNS;
        private TabPage Diagnostics;
        private Button btnDeleteTemp;
        private RichTextBox txtLog;
        private Label lblStatus;
        private Label lblCpuTemp;
        private Label lblGpuTemp;
        private System.Windows.Forms.Timer timer1;
    }
}
