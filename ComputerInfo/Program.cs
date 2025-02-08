using ComputerInfo.LibSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ComputerInfo
{
    internal static class Program
    {
        // Constant (-1) to indicate that an integer value is not set
        public const int NOT_SET = -1;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SvcOs oSvcOS = new SvcOs();
            SvcBattery oSvcBattery = new SvcBattery();
            SvcRAM oSvcRAM = new SvcRAM();
            SvcCPU oSvcCpu = new SvcCPU();
            SvcGPU oSvgGPU = new SvcGPU();
            SvcMotherboard oSvcMotherboard = new SvcMotherboard();
            SvcDisk oSvcDisk = new SvcDisk();

            XmlDocument oXmlDocOS = new XmlDocument();
            oXmlDocOS.AppendChild(oXmlDocOS.ImportNode(oSvcOS.GetXmlElement(), true));

            XmlDocument oXmlDocCpu = new XmlDocument();
            oXmlDocCpu.AppendChild(oXmlDocCpu.ImportNode(oSvcCpu.GetXmlElement(), true));

            XmlDocument oXmlDocBattery = new XmlDocument();
            oXmlDocBattery.AppendChild(oXmlDocBattery.ImportNode(oSvcBattery.GetXmlElement(), true));

            XmlDocument oXmlDocRAM = new XmlDocument();
            oXmlDocRAM.AppendChild(oXmlDocRAM.ImportNode(oSvcRAM.GetXmlElement(), true));

            XmlDocument oXmlDocGPU = new XmlDocument();
            oXmlDocGPU.AppendChild(oXmlDocGPU.ImportNode(oSvgGPU.GetXmlElement(), true));

            XmlDocument oXmlDocMotherboard = new XmlDocument();
            oXmlDocMotherboard.AppendChild(oXmlDocMotherboard.ImportNode(oSvcMotherboard.GetXmlElement(), true));

            XmlDocument oXmlDocDisk = new XmlDocument();
            oXmlDocDisk.AppendChild(oXmlDocDisk.ImportNode(oSvcDisk.GetXmlElement(), true));

            XmlDocument oXmlDoc = XmlHelper.MergeXmlDocuments(oXmlDocOS, oXmlDocCpu, oXmlDocBattery, oXmlDocRAM, oXmlDocGPU, oXmlDocMotherboard, oXmlDocDisk);

            // Formatted XML
            StringBuilder oStringBuilder = new StringBuilder();
            XmlWriterSettings oXmlWriterSettings = new XmlWriterSettings();
            oXmlWriterSettings.Indent = true;
            oXmlWriterSettings.IndentChars = "  ";
            using (XmlWriter oXmlWriter = XmlWriter.Create(oStringBuilder, oXmlWriterSettings))
            {
                oXmlDoc.WriteTo(oXmlWriter);
            }

            // TreeView root node
            TreeNode oTreeNode = new TreeNode("ComputerInfo");
            oTreeNode.Nodes.Add(oSvcCpu.GetTreeNode());
            oTreeNode.Nodes.Add(oSvcRAM.GetTreeNode());
            oTreeNode.Nodes.Add(oSvgGPU.GetTreeNode());
            oTreeNode.Nodes.Add(oSvcDisk.GetTreeNode());
            oTreeNode.Nodes.Add(oSvcBattery.GetTreeNode());
            oTreeNode.Nodes.Add(oSvcMotherboard.GetTreeNode());
            oTreeNode.Nodes.Add(oSvcOS.GetTreeNode());

            FrmMain oFrmMain = new FrmMain(oStringBuilder.ToString(), oTreeNode);
            Application.Run(oFrmMain);
        }
    }
}
