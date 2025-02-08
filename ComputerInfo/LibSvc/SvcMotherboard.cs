using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ComputerInfo.LibSvc
{
    internal class SvcMotherboard : BaseSvc
    {
        private Motherboard m_oMotherboard;
        #region Constructor
        public SvcMotherboard()
        {
            m_eSvcType = SvcType.Motherboard;
            m_oMotherboard = GetMotherboard();
        }
        #endregion

        #region Properties
        #endregion

        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            XmlDocument oXmlDocument = new XmlDocument();
            XmlElement oXmlElement = oXmlDocument.CreateElement("Motherboard");
            if (!string.IsNullOrEmpty(m_oMotherboard.Name))
            {
                XmlElement oNameElement = oXmlDocument.CreateElement("Name");
                oNameElement.InnerText = m_oMotherboard.Name;
                oXmlElement.AppendChild(oNameElement);
            }
            if (!string.IsNullOrEmpty(m_oMotherboard.Vendor))
            {
                XmlElement oVendorElement = oXmlDocument.CreateElement("Vendor");
                oVendorElement.InnerText = m_oMotherboard.Vendor;
                oXmlElement.AppendChild(oVendorElement);
            }
            if (!string.IsNullOrEmpty(m_oMotherboard.Serial))
            {
                XmlElement oSerialElement = oXmlDocument.CreateElement("Serial");
                oSerialElement.InnerText = m_oMotherboard.Serial;
                oXmlElement.AppendChild(oSerialElement);
            }
            if (!string.IsNullOrEmpty(m_oMotherboard.BiosVersion))
            {
                XmlElement oBiosVersionElement = oXmlDocument.CreateElement("BiosVersion");
                oBiosVersionElement.InnerText = m_oMotherboard.BiosVersion;
                oXmlElement.AppendChild(oBiosVersionElement);
            }
            return oXmlElement;
        }
        public override string GetTextInfo()
        {
            string sTextInfo = "Motherboard Information: ";
            sTextInfo += string.Format("Name: {0} - Manufacturer: {1} - Serial: {2} - Bios Version: {3}",
                m_oMotherboard.Name, m_oMotherboard.Vendor, m_oMotherboard.Serial, m_oMotherboard.BiosVersion);
            return sTextInfo;
        }
        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            // Root node
            TreeNode oTreeNode = new TreeNode("Motherboard");
            oTreeNode.Tag = this;

            if (!string.IsNullOrEmpty(m_oMotherboard.Name))
            {
                oTreeNode.Nodes.Add("Name: " + m_oMotherboard.Name);
            }

            if (!string.IsNullOrEmpty(m_oMotherboard.Vendor))
            {
                oTreeNode.Nodes.Add("Vendor: " + m_oMotherboard.Vendor);
            }

            if (!string.IsNullOrEmpty(m_oMotherboard.Serial))
            {
                oTreeNode.Nodes.Add("Serial: " + m_oMotherboard.Serial);
            }

            if (!string.IsNullOrEmpty(m_oMotherboard.BiosVersion))
            {
                oTreeNode.Nodes.Add("Bios Version: " + m_oMotherboard.BiosVersion);
            }

            return oTreeNode;
        }

        public static Motherboard GetMotherboard()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            Motherboard oMotherboard = new Motherboard();
            foreach (ManagementObject queryObj in searcher.Get())
            {
                oMotherboard.Name = queryObj["Product"].ToString();
                oMotherboard.Vendor = queryObj["Manufacturer"].ToString();
                oMotherboard.Serial = queryObj["SerialNumber"].ToString();

                searcher = new ManagementObjectSearcher("SELECT BIOSVersion FROM Win32_BIOS");
                foreach (ManagementObject queryObjBios in searcher.Get())
                {
                    Object oBiosVersion = queryObjBios["BIOSVersion"];
                    if (oBiosVersion != null)
                    {
                        oMotherboard.BiosVersion = ((string[])oBiosVersion)[1].ToString();
                    }
                }
            }
            return oMotherboard;
        }

        #endregion
    }
}
