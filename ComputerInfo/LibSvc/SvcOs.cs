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
    internal class SvcOs : BaseSvc
    {
        private OS m_oOs;

        #region Constructor

        public SvcOs()
        {
            m_eSvcType = SvcType.OS;
            m_oOs = GetOs();
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            XmlDocument oxMlDocument = new XmlDocument();
            XmlElement oXmlElement = oxMlDocument.CreateElement("OS");
            XmlElement oNameElement = oxMlDocument.CreateElement("Name");
            oNameElement.InnerText = m_oOs.Name;
            oXmlElement.AppendChild(oNameElement);

            XmlElement oBuildVersionElement = oxMlDocument.CreateElement("BuildVersion");
            oBuildVersionElement.InnerText = m_oOs.BuildVersion;
            oXmlElement.AppendChild(oBuildVersionElement);

            XmlElement oUserLoginElement = oxMlDocument.CreateElement("UserLogin");
            oUserLoginElement.InnerText = m_oOs.UserLogin;
            oXmlElement.AppendChild(oUserLoginElement);

            XmlElement oComputerNameElement = oxMlDocument.CreateElement("ComputerName");
            oComputerNameElement.InnerText = m_oOs.ComputerName;
            oXmlElement.AppendChild(oComputerNameElement);

            XmlElement oArchitectureElement = oxMlDocument.CreateElement("Architecture");
            oArchitectureElement.InnerText = m_oOs.Architecture.ToString();
            oXmlElement.AppendChild(oArchitectureElement);
            return oXmlElement;
        }

        public override string GetTextInfo()
        {
            return string.Format("OS: {0} - {1} - {2} - {3} - {4}", m_oOs.Name, m_oOs.BuildVersion, m_oOs.UserLogin, m_oOs.ComputerName, m_oOs.Architecture);
        }

        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            // Root node
            TreeNode oTreeNode = new TreeNode("OS");
            oTreeNode.Tag = this;

            // Child nodes
            if (!string.IsNullOrEmpty(m_oOs.Name))
            {
                oTreeNode.Nodes.Add("Name", "Name: " + m_oOs.Name);
            }

            if (!string.IsNullOrEmpty(m_oOs.BuildVersion))
            {
                oTreeNode.Nodes.Add("BuildVersion", "Build Version: " + m_oOs.BuildVersion);
            }

            if (!string.IsNullOrEmpty(m_oOs.UserLogin))
            {
                oTreeNode.Nodes.Add("UserLogin", "User Login: " + m_oOs.UserLogin);
            }

            if (!string.IsNullOrEmpty(m_oOs.ComputerName))
            {
                oTreeNode.Nodes.Add("ComputerName", "Computer Name: " + m_oOs.ComputerName);
            }

            if (m_oOs.Architecture != Architecture.UNKNOWN)
            {
                oTreeNode.Nodes.Add("Architecture", "Architecture: " + m_oOs.Architecture);
            }

            return oTreeNode;
        }

        public static OS GetOs()
        {
            OS oOs = new OS();
            oOs.Name = GetOSFullName();
            oOs.BuildVersion = System.Environment.OSVersion.Version.ToString();
            oOs.UserLogin = System.Environment.UserName;
            oOs.ComputerName = System.Environment.MachineName;
            oOs.Architecture = GetArchitecture();
            return oOs;
        }

        private static Architecture GetArchitecture()
        {
            switch (System.Environment.Is64BitOperatingSystem)
            {
                case true:
                    return Architecture.x64;
                case false:
                    return Architecture.x86;
                default:
                    return Architecture.UNKNOWN;
            }
        }

        private static string GetOSFullName()
        {
            string osFullName = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                osFullName = os["Caption"].ToString();
                break;
            }
            return osFullName;
        }
    }

    #endregion
}
