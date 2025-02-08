using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public override string GetTextInfo()
        {
            return string.Format("OS: {0} - {1} - {2} - {3} - {4}", m_oOs.Name, m_oOs.BuildVersion, m_oOs.UserLogin, m_oOs.ComputerName, m_oOs.Architecture);
        }

        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            throw new NotImplementedException();
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
