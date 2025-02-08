using ComputerInfo.LibSvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerInfo;
using QRCoder;

namespace ComputerInfo
{
    public partial class FrmMain : Form
    {

        public FrmMain(string rctTextContent, TreeNode oTreeNode = null)
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmMain_Load);
            
            rctXML.Text = rctTextContent;
            if (oTreeNode != null)
            {
                trvHardware.Nodes.Add(oTreeNode);
                trvHardware.ExpandAll();
            }

            LibPcComponent.CPU[] aoCPUs = LibSvc.SvcCPU.GetCPUs();
            if (aoCPUs.Length > 0)
            {
                txtCPUSpec.Text = aoCPUs[0].Name;
                txtCoreCount.Text = aoCPUs[0].CoreCount.ToString();
                txtThreadsCount.Text = aoCPUs[0].ThreadCount.ToString();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Computer Information";

            // Set the correct CPU Logo
            ComputerInfo.LibSvc.Manufacturer oManufacturer = ComputerInfo.LibSvc.SvcCPU.GetManufacturer();
            switch(oManufacturer)
            {
                case ComputerInfo.LibSvc.Manufacturer.AMD:
                    pctLogoCPU.Image = Properties.Resources.LOGO_SQUARE_AMD;
                    break;
                case ComputerInfo.LibSvc.Manufacturer.INTEL:
                    pctLogoCPU.Image = Properties.Resources.LOGO_SQUARE_INTEL;
                    break;
                case ComputerInfo.LibSvc.Manufacturer.UNKNOWN:
                    break;
            }
        }

        private void rctXML_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCopier_Click(object sender, EventArgs e)
        {
            // Copy the content of the RichTextBox to the clipboard
            Clipboard.SetText(rctXML.Text);
            MessageBox.Show("The content has been copied to the clipboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Save the content of the RichTextBox to a file
            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            oSaveFileDialog.FilterIndex = 1;
            oSaveFileDialog.RestoreDirectory = true;
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(oSaveFileDialog.FileName, rctXML.Text);
            }
        }

        private void trvHardware_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Select the correct tab page based on the tag of the selected node
            if (e.Node.Tag != null)
            {
                // Cast the tag to a BaseSvc object
                LibSvc.BaseSvc oBaseSvc = (LibSvc.BaseSvc)e.Node.Tag;
                // Get the name of the service
                LibSvc.SvcType eSvcType = oBaseSvc.SvcType;

                switch (eSvcType)
                {
                    case LibSvc.SvcType.CPU:
                        tbSvcInfo.SelectedTab = tbCPU;
                        break;
                    case LibSvc.SvcType.RAM:
                        tbSvcInfo.SelectedTab = tbRAM;
                        break;
                    case LibSvc.SvcType.OS:
                        tbSvcInfo.SelectedTab = tbOS;
                        break;
                    case LibSvc.SvcType.Disk:
                        tbSvcInfo.SelectedTab = tbDisk;
                        break;
                    case LibSvc.SvcType.Battery:
                        tbSvcInfo.SelectedTab = tbBattery;
                        break;
                    case LibSvc.SvcType.GPU:
                        tbSvcInfo.SelectedTab = tbGPU;
                        break;
                    case LibSvc.SvcType.Motherboard:
                        tbSvcInfo.SelectedTab = tbMotherboard;
                        break;
                    case SvcType.UNKNOWN:
                        break;
                }
            }
        }
    }
}
