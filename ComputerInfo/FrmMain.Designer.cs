namespace ComputerInfo
{
    partial class FrmMain
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
            this.rctXML = new System.Windows.Forms.RichTextBox();
            this.trvHardware = new System.Windows.Forms.TreeView();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnCopier = new System.Windows.Forms.Button();
            this.tbSvcInfo = new System.Windows.Forms.TabControl();
            this.tbCPU = new System.Windows.Forms.TabPage();
            this.tbRAM = new System.Windows.Forms.TabPage();
            this.tbGPU = new System.Windows.Forms.TabPage();
            this.tbDisk = new System.Windows.Forms.TabPage();
            this.tbBattery = new System.Windows.Forms.TabPage();
            this.tbMotherboard = new System.Windows.Forms.TabPage();
            this.tbOS = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreadsCount = new System.Windows.Forms.TextBox();
            this.pctLogoCPU = new System.Windows.Forms.PictureBox();
            this.txtCPUSpec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCoreCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbSvcInfo.SuspendLayout();
            this.tbCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // rctXML
            // 
            this.rctXML.Location = new System.Drawing.Point(4, 19);
            this.rctXML.Name = "rctXML";
            this.rctXML.Size = new System.Drawing.Size(420, 366);
            this.rctXML.TabIndex = 0;
            this.rctXML.Text = "";
            this.rctXML.TextChanged += new System.EventHandler(this.rctXML_TextChanged);
            // 
            // trvHardware
            // 
            this.trvHardware.Location = new System.Drawing.Point(6, 19);
            this.trvHardware.Name = "trvHardware";
            this.trvHardware.Size = new System.Drawing.Size(386, 584);
            this.trvHardware.TabIndex = 1;
            this.trvHardware.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvHardware_AfterSelect);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(430, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvHardware);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 609);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Infos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMail);
            this.groupBox3.Controls.Add(this.btnCopier);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.rctXML);
            this.groupBox3.Location = new System.Drawing.Point(416, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 391);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XML";
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(430, 77);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(75, 23);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Mail";
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // btnCopier
            // 
            this.btnCopier.Location = new System.Drawing.Point(430, 48);
            this.btnCopier.Name = "btnCopier";
            this.btnCopier.Size = new System.Drawing.Size(75, 23);
            this.btnCopier.TabIndex = 3;
            this.btnCopier.Text = "Copier";
            this.btnCopier.UseVisualStyleBackColor = true;
            this.btnCopier.Click += new System.EventHandler(this.btnCopier_Click);
            // 
            // tbSvcInfo
            // 
            this.tbSvcInfo.Controls.Add(this.tbCPU);
            this.tbSvcInfo.Controls.Add(this.tbRAM);
            this.tbSvcInfo.Controls.Add(this.tbGPU);
            this.tbSvcInfo.Controls.Add(this.tbDisk);
            this.tbSvcInfo.Controls.Add(this.tbBattery);
            this.tbSvcInfo.Controls.Add(this.tbMotherboard);
            this.tbSvcInfo.Controls.Add(this.tbOS);
            this.tbSvcInfo.Location = new System.Drawing.Point(416, 14);
            this.tbSvcInfo.Name = "tbSvcInfo";
            this.tbSvcInfo.SelectedIndex = 0;
            this.tbSvcInfo.Size = new System.Drawing.Size(511, 212);
            this.tbSvcInfo.TabIndex = 13;
            // 
            // tbCPU
            // 
            this.tbCPU.Controls.Add(this.label1);
            this.tbCPU.Controls.Add(this.pctLogoCPU);
            this.tbCPU.Controls.Add(this.txtThreadsCount);
            this.tbCPU.Controls.Add(this.txtCoreCount);
            this.tbCPU.Controls.Add(this.label3);
            this.tbCPU.Controls.Add(this.txtCPUSpec);
            this.tbCPU.Controls.Add(this.label2);
            this.tbCPU.Location = new System.Drawing.Point(4, 22);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tbCPU.Size = new System.Drawing.Size(503, 186);
            this.tbCPU.TabIndex = 0;
            this.tbCPU.Text = "CPU";
            this.tbCPU.UseVisualStyleBackColor = true;
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(4, 22);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Padding = new System.Windows.Forms.Padding(3);
            this.tbRAM.Size = new System.Drawing.Size(503, 186);
            this.tbRAM.TabIndex = 1;
            this.tbRAM.Text = "RAM";
            this.tbRAM.UseVisualStyleBackColor = true;
            // 
            // tbGPU
            // 
            this.tbGPU.Location = new System.Drawing.Point(4, 22);
            this.tbGPU.Name = "tbGPU";
            this.tbGPU.Padding = new System.Windows.Forms.Padding(3);
            this.tbGPU.Size = new System.Drawing.Size(503, 186);
            this.tbGPU.TabIndex = 2;
            this.tbGPU.Text = "GPU";
            this.tbGPU.UseVisualStyleBackColor = true;
            // 
            // tbDisk
            // 
            this.tbDisk.Location = new System.Drawing.Point(4, 22);
            this.tbDisk.Name = "tbDisk";
            this.tbDisk.Padding = new System.Windows.Forms.Padding(3);
            this.tbDisk.Size = new System.Drawing.Size(503, 186);
            this.tbDisk.TabIndex = 3;
            this.tbDisk.Text = "Disk";
            this.tbDisk.UseVisualStyleBackColor = true;
            // 
            // tbBattery
            // 
            this.tbBattery.Location = new System.Drawing.Point(4, 22);
            this.tbBattery.Name = "tbBattery";
            this.tbBattery.Padding = new System.Windows.Forms.Padding(3);
            this.tbBattery.Size = new System.Drawing.Size(503, 186);
            this.tbBattery.TabIndex = 4;
            this.tbBattery.Text = "Battery";
            this.tbBattery.UseVisualStyleBackColor = true;
            // 
            // tbMotherboard
            // 
            this.tbMotherboard.Location = new System.Drawing.Point(4, 22);
            this.tbMotherboard.Name = "tbMotherboard";
            this.tbMotherboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbMotherboard.Size = new System.Drawing.Size(503, 186);
            this.tbMotherboard.TabIndex = 5;
            this.tbMotherboard.Text = "Motherboard";
            this.tbMotherboard.UseVisualStyleBackColor = true;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(4, 22);
            this.tbOS.Name = "tbOS";
            this.tbOS.Padding = new System.Windows.Forms.Padding(3);
            this.tbOS.Size = new System.Drawing.Size(503, 186);
            this.tbOS.TabIndex = 6;
            this.tbOS.Text = "OS";
            this.tbOS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CPU Specification";
            // 
            // txtThreadsCount
            // 
            this.txtThreadsCount.Location = new System.Drawing.Point(282, 30);
            this.txtThreadsCount.Name = "txtThreadsCount";
            this.txtThreadsCount.Size = new System.Drawing.Size(31, 20);
            this.txtThreadsCount.TabIndex = 16;
            // 
            // pctLogoCPU
            // 
            this.pctLogoCPU.Location = new System.Drawing.Point(6, 6);
            this.pctLogoCPU.Name = "pctLogoCPU";
            this.pctLogoCPU.Size = new System.Drawing.Size(128, 128);
            this.pctLogoCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoCPU.TabIndex = 10;
            this.pctLogoCPU.TabStop = false;
            // 
            // txtCPUSpec
            // 
            this.txtCPUSpec.Location = new System.Drawing.Point(239, 3);
            this.txtCPUSpec.Name = "txtCPUSpec";
            this.txtCPUSpec.Size = new System.Drawing.Size(256, 20);
            this.txtCPUSpec.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Core(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thread(s)";
            // 
            // txtCoreCount
            // 
            this.txtCoreCount.Location = new System.Drawing.Point(186, 30);
            this.txtCoreCount.Name = "txtCoreCount";
            this.txtCoreCount.Size = new System.Drawing.Size(31, 20);
            this.txtCoreCount.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 635);
            this.Controls.Add(this.tbSvcInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tbSvcInfo.ResumeLayout(false);
            this.tbCPU.ResumeLayout(false);
            this.tbCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctXML;
        private System.Windows.Forms.TreeView trvHardware;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCopier;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.TabControl tbSvcInfo;
        private System.Windows.Forms.TabPage tbCPU;
        private System.Windows.Forms.TabPage tbRAM;
        private System.Windows.Forms.TabPage tbGPU;
        private System.Windows.Forms.TabPage tbDisk;
        private System.Windows.Forms.TabPage tbBattery;
        private System.Windows.Forms.TabPage tbMotherboard;
        private System.Windows.Forms.TabPage tbOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctLogoCPU;
        private System.Windows.Forms.TextBox txtThreadsCount;
        private System.Windows.Forms.TextBox txtCoreCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPUSpec;
        private System.Windows.Forms.Label label2;
    }
}