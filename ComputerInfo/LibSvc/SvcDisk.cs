using ComputerInfo.LibPcComponent;
using LibreHardwareMonitor.Hardware;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ComputerInfo.LibSvc
{
    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }
        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }
    }
    internal class SvcDisk : BaseSvc
    {
        private Disk[] m_aoDisks;

        #region Constructor

        public SvcDisk()
        {
            m_eSvcType = SvcType.Disk;
            m_aoDisks = GetDisks();
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            XmlDocument oXmlDocument = new XmlDocument();
            XmlElement oXmlElement = oXmlDocument.CreateElement("Disks");

            foreach (Disk oDisk in m_aoDisks)
            {
                XmlElement oDiskElement = oXmlDocument.CreateElement("Disk");

                if (oDisk.Size > 0)
                {
                    XmlElement oSizeElement = oXmlDocument.CreateElement("Size");
                    oSizeElement.InnerText = oDisk.Size.ToString();
                    oDiskElement.AppendChild(oSizeElement);
                }

                oXmlElement.AppendChild(oDiskElement);

                XmlElement oPartitionsElement = oXmlDocument.CreateElement("Partitions");
                foreach (Partition oPartition in oDisk.Partitions)
                {
                    XmlElement oPartitionElement = oXmlDocument.CreateElement("Partition");

                    if (oPartition.Size > 0)
                    {
                        XmlElement oSizeElement = oXmlDocument.CreateElement("Size");
                        oSizeElement.InnerText = oPartition.Size.ToString();
                        oPartitionElement.AppendChild(oSizeElement);
                    }

                    oXmlElement.AppendChild(oPartitionElement);

                    if (!String.IsNullOrEmpty(oPartition.FileSystem))
                    {
                        XmlElement oFileSystemElement = oXmlDocument.CreateElement("FileSystem");
                        oFileSystemElement.InnerText = oPartition.FileSystem;
                        oPartitionElement.AppendChild(oFileSystemElement);
                    }

                    oXmlElement.AppendChild(oPartitionElement);

                    if (oPartition.AllocationUnitSize > 0)
                    {
                        XmlElement oAllocationUnitSizeElement = oXmlDocument.CreateElement("AllocationUnitSize");
                        oAllocationUnitSizeElement.InnerText = oPartition.AllocationUnitSize.ToString();
                        oPartitionElement.AppendChild(oAllocationUnitSizeElement);
                    }

                    oXmlElement.AppendChild(oPartitionElement);
                    
                    if (!String.IsNullOrEmpty(oPartition.Name))
                    {
                        XmlElement oNameElement = oXmlDocument.CreateElement("Name");
                        oNameElement.InnerText = oPartition.Name;
                        oPartitionElement.AppendChild(oNameElement);
                    }

                    oXmlElement.AppendChild(oPartitionElement);

                }
                oDiskElement.AppendChild(oPartitionsElement);

            }

            return oXmlElement;
        }

        public override string GetTextInfo()
        {
            throw new NotImplementedException();
        }

        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            throw new NotImplementedException();
        }

        public static Disk[] GetDisks()
        {
            List<Disk> aoDisks = new List<Disk>();

            // Use WMI to get disk information
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            ManagementObjectCollection oCollection = oSearcher.Get();
            foreach (ManagementObject o in oCollection)
            {
                Disk oDisk = new Disk();
                oDisk.Size = Convert.ToUInt64(o["Size"]);
                oDisk.Serial = o["SerialNumber"].ToString();
                oDisk.Vendor = o["Manufacturer"].ToString();
                oDisk.Name = o["Model"].ToString();

                // Get partitions
                List<Partition> aoPartitions = new List<Partition>();
                ManagementObjectSearcher oSearcherPartitions = new ManagementObjectSearcher("ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + o["DeviceID"] + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition");
                ManagementObjectCollection oCollectionPartitions = oSearcherPartitions.Get();
                foreach (ManagementObject oPartition in oCollectionPartitions)
                {
                    Partition oPart = new Partition();
                    oPart.Name = oPartition["Name"].ToString();
                    oPart.Size = Convert.ToUInt64(oPartition["Size"]);
                    oPart.FileSystem = oPartition["Type"].ToString();
                    oPart.AllocationUnitSize = Convert.ToInt32(oPartition["BlockSize"]);
                    aoPartitions.Add(oPart);
                }
                oDisk.Partitions = aoPartitions.ToArray();

                aoDisks.Add(oDisk);
            }

            return aoDisks.ToArray();
        }

        #endregion
    }
}
