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
            this.SuspendLayout();
            // 
            // rctXML
            // 
            this.rctXML.Location = new System.Drawing.Point(416, 12);
            this.rctXML.Name = "rctXML";
            this.rctXML.Size = new System.Drawing.Size(372, 426);
            this.rctXML.TabIndex = 0;
            this.rctXML.Text = "";
            // 
            // trvHardware
            // 
            this.trvHardware.Location = new System.Drawing.Point(12, 12);
            this.trvHardware.Name = "trvHardware";
            this.trvHardware.Size = new System.Drawing.Size(398, 426);
            this.trvHardware.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trvHardware);
            this.Controls.Add(this.rctXML);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctXML;
        private System.Windows.Forms.TreeView trvHardware;
    }
}