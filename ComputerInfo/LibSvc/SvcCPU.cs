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
    enum Manufacturer
    {
        AMD,
        INTEL,
        UNKNOWN,
    }
    internal class SvcCPU : BaseSvc
    {
        private CPU[] m_aoCPUs;

        #region Constructor
        public SvcCPU()
        {
            m_eSvcType = SvcType.CPU;
            m_aoCPUs = GetCPUs();
        }
        #endregion
        
        #region Properties
        #endregion
        
        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            XmlDocument oXmlDocument = new XmlDocument();
            XmlElement oXmlElement = oXmlDocument.CreateElement("CPUs");
            foreach (CPU oCPU in m_aoCPUs)
            {
                XmlElement oCPUElement = oXmlDocument.CreateElement("CPU");
                if (!string.IsNullOrEmpty(oCPU.CPUID))
                {
                    XmlElement oCPUIDElement = oXmlDocument.CreateElement("CPUID");
                    oCPUIDElement.InnerText = oCPU.CPUID;
                    oCPUElement.AppendChild(oCPUIDElement);
                }
                if (!string.IsNullOrEmpty(oCPU.Name))
                {
                    XmlElement oNameElement = oXmlDocument.CreateElement("Name");
                    oNameElement.InnerText = oCPU.Name;
                    oCPUElement.AppendChild(oNameElement);
                }
                if (oCPU.Architecture != ArchitectureType.UNKNOWN)
                {
                    XmlElement oArchitectureElement = oXmlDocument.CreateElement("Architecture");
                    oArchitectureElement.InnerText = oCPU.Architecture.ToString();
                    oCPUElement.AppendChild(oArchitectureElement);
                }
                if (!string.IsNullOrEmpty(oCPU.Vendor))
                {
                    XmlElement oVendorElement = oXmlDocument.CreateElement("Vendor");
                    oVendorElement.InnerText = oCPU.Vendor;
                    oCPUElement.AppendChild(oVendorElement);
                }
                if (oCPU.CoreCount != Program.NOT_SET)
                {
                    XmlElement oCoreCountElement = oXmlDocument.CreateElement("CoreCount");
                    oCoreCountElement.InnerText = oCPU.CoreCount.ToString();
                    oCPUElement.AppendChild(oCoreCountElement);
                }
                if (oCPU.ThreadCount != Program.NOT_SET)
                {
                    XmlElement oThreadCountElement = oXmlDocument.CreateElement("ThreadCount");
                    oThreadCountElement.InnerText = oCPU.ThreadCount.ToString();
                    oCPUElement.AppendChild(oThreadCountElement);
                }
                if (oCPU.MaxClock != Program.NOT_SET)
                {
                    XmlElement oMaxClockElement = oXmlDocument.CreateElement("MaxClock");
                    oMaxClockElement.InnerText = oCPU.MaxClock.ToString();
                    oCPUElement.AppendChild(oMaxClockElement);
                }
                if (oCPU.CurrentClock != Program.NOT_SET)
                {
                    XmlElement oCurrentClockElement = oXmlDocument.CreateElement("CurrentClock");
                    oCurrentClockElement.InnerText = oCPU.CurrentClock.ToString();
                    oCPUElement.AppendChild(oCurrentClockElement);
                }
                oXmlElement.AppendChild(oCPUElement);
            }
            return oXmlElement;
        }
        public override string GetTextInfo()
        {
            string sTextInfo = string.Empty;
            foreach (CPU oCPU in m_aoCPUs)
            {
                sTextInfo += "CPU ID: " + oCPU.CPUID + "\n";
                sTextInfo += "Name: " + oCPU.Name + "\n";
                sTextInfo += "Architecture: " + oCPU.Architecture + "\n";
                sTextInfo += "Vendor: " + oCPU.Vendor + "\n";
                sTextInfo += "Core count: " + oCPU.CoreCount + "\n";
                sTextInfo += "Thread count: " + oCPU.ThreadCount + "\n";
                sTextInfo += "Max clock: " + oCPU.MaxClock + " MHz\n";
                sTextInfo += "Current clock: " + oCPU.CurrentClock + " MHz\n";
                sTextInfo += "\n";
            }
            return sTextInfo;
        }
        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            // Root node
            TreeNode oTreeNode = new TreeNode("CPUs");
            oTreeNode.Tag = this;

            // Add each CPU to the tree node
            foreach (CPU oCPU in m_aoCPUs)
            {
                TreeNode oCPUNode = new TreeNode(oCPU.Name);
                if (!string.IsNullOrEmpty(oCPU.CPUID))
                {
                    oCPUNode.Nodes.Add("CPU ID: " + oCPU.CPUID);
                }

                if (oCPU.Architecture != ArchitectureType.UNKNOWN)
                {
                    oCPUNode.Nodes.Add("Architecture: " + oCPU.Architecture);
                }

                if (!string.IsNullOrEmpty(oCPU.Vendor))
                {
                    oCPUNode.Nodes.Add("Vendor: " + oCPU.Vendor);
                }

                if (oCPU.CoreCount != Program.NOT_SET)
                {
                    oCPUNode.Nodes.Add("Core count: " + oCPU.CoreCount);
                }

                if (oCPU.ThreadCount != Program.NOT_SET)
                {
                    oCPUNode.Nodes.Add("Thread count: " + oCPU.ThreadCount);
                }

                if (oCPU.MaxClock != Program.NOT_SET)
                {
                    oCPUNode.Nodes.Add("Max clock: " + oCPU.MaxClock + " MHz");
                }

                if (oCPU.CurrentClock != Program.NOT_SET)
                {
                    oCPUNode.Nodes.Add("Current clock: " + oCPU.CurrentClock + " MHz");
                }

                oTreeNode.Nodes.Add(oCPUNode);
            }

            return oTreeNode;
        }
        public static CPU[] GetCPUs()
        {
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection oCollection = oSearcher.Get();
            CPU[] aoCPUs = new CPU[oCollection.Count];
            int iIndex = 0;
            foreach (ManagementObject oObject in oCollection)
            {
                aoCPUs[iIndex] = new CPU();
                aoCPUs[iIndex].CPUID = oObject["ProcessorId"].ToString();
                aoCPUs[iIndex].Name = oObject["Name"].ToString();
                aoCPUs[iIndex].Architecture = (ArchitectureType)Enum.Parse(typeof(ArchitectureType), oObject["Architecture"].ToString());
                aoCPUs[iIndex].Vendor = oObject["Manufacturer"].ToString();
                aoCPUs[iIndex].Serial = oObject["SerialNumber"].ToString();
                aoCPUs[iIndex].CoreCount = int.Parse(oObject["NumberOfCores"].ToString());
                aoCPUs[iIndex].ThreadCount = int.Parse(oObject["NumberOfLogicalProcessors"].ToString());
                aoCPUs[iIndex].MaxClock = int.Parse(oObject["MaxClockSpeed"].ToString());
                aoCPUs[iIndex].CurrentClock = int.Parse(oObject["CurrentClockSpeed"].ToString());
                iIndex++;
            }
            return aoCPUs;
        }

        public static Manufacturer GetManufacturer()
        {
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection oCollection = oSearcher.Get();
            foreach (ManagementObject oObject in oCollection)
            {
                string sManufacturer = oObject["Manufacturer"].ToString();
                if (sManufacturer.Contains("Intel"))
                {
                    return Manufacturer.INTEL;
                }
                else if (sManufacturer.Contains("AMD"))
                {
                    return Manufacturer.AMD;
                }
            }
            return Manufacturer.UNKNOWN;
        }

        #endregion
    }
}
