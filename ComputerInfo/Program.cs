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

            XmlDocument oXmlDocOS = new XmlDocument();
            oXmlDocOS.AppendChild(oXmlDocOS.ImportNode(oSvcOS.GetXmlElement(), true));

            XmlDocument oXmlDocBattery = new XmlDocument();
            oXmlDocBattery.AppendChild(oXmlDocBattery.ImportNode(oSvcBattery.GetXmlElement(), true));

            XmlDocument oXmlDocRAM = new XmlDocument();
            oXmlDocRAM.AppendChild(oXmlDocRAM.ImportNode(oSvcRAM.GetXmlElement(), true));

            XmlDocument oXmlDoc = XmlHelper.MergeXmlDocuments(oXmlDocOS, oXmlDocBattery, oXmlDocRAM);

            // Formatted XML
            StringBuilder oStringBuilder = new StringBuilder();
            XmlWriterSettings oXmlWriterSettings = new XmlWriterSettings();
            oXmlWriterSettings.Indent = true;
            oXmlWriterSettings.IndentChars = "  ";
            using (XmlWriter oXmlWriter = XmlWriter.Create(oStringBuilder, oXmlWriterSettings))
            {
                oXmlDoc.WriteTo(oXmlWriter);
            }

            FrmMain oFrmMain = new FrmMain(oStringBuilder.ToString());
            Application.Run(oFrmMain);
        }
    }
}
