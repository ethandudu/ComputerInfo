using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerInfo.LibSvc
{
    internal class SvcRAM : BaseSvc
    {
        private RAM[] m_aoRAMs;
        #region Constructor

        public SvcRAM()
        {
            m_eSvcType = SvcType.RAM;
            m_aoRAMs = GetRAMs();
        }
        #endregion

        #region Properties
        #endregion

        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            XmlDocument oXmlDoc = new XmlDocument();
            XmlElement oXmlElement = oXmlDoc.CreateElement("RAMs");
            foreach (RAM ram in m_aoRAMs)
            {
                XmlElement oXmlElementRAM = oXmlDoc.CreateElement("RAM");
                
                if (ram.Name != String.Empty)
                {
                    XmlElement oXmlElementName = oXmlDoc.CreateElement("Name");
                    oXmlElementName.InnerText = ram.Name;
                    oXmlElementRAM.AppendChild(oXmlElementName);
                }

                if (ram.Serial != String.Empty)
                {
                    XmlElement oXmlElementSerial = oXmlDoc.CreateElement("Serial");
                    oXmlElementSerial.InnerText = ram.Serial;
                    oXmlElementRAM.AppendChild(oXmlElementSerial);
                }

                if (ram.Frequency != Program.NOT_SET)
                {
                    XmlElement oXmlElementFrequency = oXmlDoc.CreateElement("Frequency");
                    oXmlElementFrequency.InnerText = ram.Frequency.ToString();
                    oXmlElementRAM.AppendChild(oXmlElementFrequency);
                }

                if (ram.Capacity != 0)
                {
                    XmlElement oXmlElementCapacity = oXmlDoc.CreateElement("Capacity");
                    oXmlElementCapacity.InnerText = ram.Capacity.ToString();
                    oXmlElementRAM.AppendChild(oXmlElementCapacity);
                }

                if (ram.Type != RAMType.UNKNOWN)
                {
                    XmlElement oXmlElementType = oXmlDoc.CreateElement("Type");
                    oXmlElementType.InnerText = ram.Type.ToString();
                    oXmlElementRAM.AppendChild(oXmlElementType);
                }

                if (ram.FormFactor != RAMFormFactor.UNKNOWN)
                {
                    XmlElement oXmlElementFormFactor = oXmlDoc.CreateElement("FormFactor");
                    oXmlElementFormFactor.InnerText = ram.FormFactor.ToString();
                    oXmlElementRAM.AppendChild(oXmlElementFormFactor);
                }

                if (ram.Vendor != String.Empty)
                {
                    XmlElement oXmlElementVendor = oXmlDoc.CreateElement("Vendor");
                    oXmlElementVendor.InnerText = ram.Vendor;
                    oXmlElementRAM.AppendChild(oXmlElementVendor);
                }

                oXmlElement.AppendChild(oXmlElementRAM);
            }
            return oXmlElement;
        }
        public override string GetTextInfo()
        {
            string sTextInfo = "RAMs:\n";
            foreach (RAM ram in m_aoRAMs)
            {
                sTextInfo += "Name: " + ram.Name + "\n";
                sTextInfo += "Serial: " + ram.Serial + "\n";
                sTextInfo += "Frequency: " + ram.Frequency + " MHz\n";
                sTextInfo += "Capacity: " + ram.Capacity + " MB\n";
                sTextInfo += "Type: " + ram.Type + "\n";
                sTextInfo += "Form factor: " + ram.FormFactor + "\n";
                sTextInfo += "Vendor: " + ram.Vendor + "\n";
                //sTextInfo += "Slot: " + ram.Slot + "\n";
                sTextInfo += "\n";
            }
            return sTextInfo;
        }
        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            // Root node
            TreeNode oTreeNode = new TreeNode("RAMs");
            oTreeNode.Tag = this;

            // Add each RAM to the tree node
            foreach (RAM ram in m_aoRAMs)
            {
                TreeNode oRAMNode = new TreeNode(ram.Name);
                if (!string.IsNullOrEmpty(ram.Serial))
                {
                    oRAMNode.Nodes.Add("Serial: " + ram.Serial);
                }
                if (ram.Frequency != Program.NOT_SET)
                {
                    oRAMNode.Nodes.Add("Frequency: " + ram.Frequency + " MHz");
                }
                if (ram.Capacity != 0)
                {
                    oRAMNode.Nodes.Add("Capacity: " + ram.Capacity + " MB");
                }
                if (ram.Type != RAMType.UNKNOWN)
                {
                    oRAMNode.Nodes.Add("Type: " + ram.Type);
                }
                if (ram.FormFactor != RAMFormFactor.UNKNOWN)
                {
                    oRAMNode.Nodes.Add("Form factor: " + ram.FormFactor);
                }
                if (!string.IsNullOrEmpty(ram.Vendor))
                {
                    oRAMNode.Nodes.Add("Vendor: " + ram.Vendor);
                }
                //if (ram.Slot != Program.NOT_SET)
                //{
                //    oRAMNode.Nodes.Add("Slot: " + ram.Slot);
                //}
                oTreeNode.Nodes.Add(oRAMNode);
            }

            return oTreeNode;
        }
        public static RAM[] GetRAMs()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            List<RAM> rams = new List<RAM>();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                RAM ram = new RAM();
                // Set the RAM object's properties
                ram.Name = queryObj["Name"].ToString();
                ram.Serial = queryObj["SerialNumber"].ToString();
                ram.Frequency = Convert.ToInt32(queryObj["Speed"]);
                ram.Capacity = Convert.ToUInt64(queryObj["Capacity"]) / 1024 / 1024;
                ram.Type = (RAMType)Enum.Parse(typeof(RAMType), queryObj["MemoryType"].ToString());
                ram.FormFactor = (RAMFormFactor)Enum.Parse(typeof(RAMFormFactor), queryObj["FormFactor"].ToString());
                ram.Vendor = queryObj["Manufacturer"].ToString();
                //ram.Slot = Convert.ToInt32(queryObj["DeviceLocator"]);
                rams.Add(ram);
            }

            // Return the list as an array
            return rams.ToArray();
        }

        #endregion
    }
}
