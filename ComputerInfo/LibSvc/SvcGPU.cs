using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcGPU : BaseSvc
    {
        private GPU[] m_aoGPUs;

        #region Constructor

        public SvcGPU()
        {
            m_eSvcType = SvcType.GPU;
            m_aoGPUs = GetGPUs();
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            XmlDocument oXmlDocument = new XmlDocument();
            XmlElement oXmlElement = oXmlDocument.CreateElement("GPUs");

            foreach (GPU oGPU in m_aoGPUs)
            {
                XmlElement oGPUElement = oXmlDocument.CreateElement("GPU");
                
                if (!String.IsNullOrEmpty(oGPU.Name))
                {
                    XmlElement oNameElement = oXmlDocument.CreateElement("Name");
                    oNameElement.InnerText = oGPU.Name;
                    oGPUElement.AppendChild(oNameElement);
                }

                if (!String.IsNullOrEmpty(oGPU.Serial))
                {
                    XmlElement oSerialElement = oXmlDocument.CreateElement("Serial");
                    oSerialElement.InnerText = oGPU.Serial;
                    oGPUElement.AppendChild(oSerialElement);
                }

                if (!String.IsNullOrEmpty(oGPU.DeviceID))
                {
                    XmlElement oDeviceIDElement = oXmlDocument.CreateElement("DeviceID");
                    oDeviceIDElement.InnerText = oGPU.DeviceID;
                    oGPUElement.AppendChild(oDeviceIDElement);
                }

                if (!String.IsNullOrEmpty(oGPU.VideoProcessor))
                {
                    XmlElement oVideoProcessorElement = oXmlDocument.CreateElement("VideoProcessor");
                    oVideoProcessorElement.InnerText = oGPU.VideoProcessor;
                    oGPUElement.AppendChild(oVideoProcessorElement);
                }

                if (oGPU.Ram.Capacity != 0)
                {
                    XmlElement oRamElement = oXmlDocument.CreateElement("RAM");
                    oRamElement.InnerText = oGPU.Ram.Capacity.ToString();
                    oGPUElement.AppendChild(oRamElement);
                }

                if (!String.IsNullOrEmpty(oGPU.Driver.BuildDate))
                {
                    XmlElement oDriverBuildDateElement = oXmlDocument.CreateElement("DriverBuildDate");
                    oDriverBuildDateElement.InnerText = oGPU.Driver.BuildDate;
                    oGPUElement.AppendChild(oDriverBuildDateElement);
                }

                if (!String.IsNullOrEmpty(oGPU.Driver.Vendor))
                {
                    XmlElement oDriverVendorElement = oXmlDocument.CreateElement("DriverVendor");
                    oDriverVendorElement.InnerText = oGPU.Driver.Vendor;
                    oGPUElement.AppendChild(oDriverVendorElement);
                }

                if (!String.IsNullOrEmpty(oGPU.Driver.BuildVersion))
                {
                    XmlElement oDriverBuildVersionElement = oXmlDocument.CreateElement("DriverBuildVersion");
                    oDriverBuildVersionElement.InnerText = oGPU.Driver.BuildVersion;
                    oGPUElement.AppendChild(oDriverBuildVersionElement);
                }

                oXmlElement.AppendChild(oGPUElement);
            }

            return oXmlElement;
        }

        public override string GetTextInfo()
        {
            string sInfo = "GPU Information:\n";
            foreach (GPU oGPU in m_aoGPUs)
            {
                sInfo += "Name: " + oGPU.Name + "\n";
                sInfo += "Serial: " + oGPU.Serial + "\n";
                sInfo += "Device ID: " + oGPU.DeviceID + "\n";
                sInfo += "Video Processor: " + oGPU.VideoProcessor + "\n";
                sInfo += "RAM: " + oGPU.Ram.Capacity + " MB\n";
                sInfo += "Driver Build Date: " + oGPU.Driver.BuildDate + "\n";
                sInfo += "Driver Vendor: " + oGPU.Driver.Vendor + "\n";
                sInfo += "Driver Build Version: " + oGPU.Driver.BuildVersion + "\n";
            }
            return sInfo;
        }

        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            throw new NotImplementedException();
        }

        public static GPU[] GetGPUs()
        {
            // Use the WMI to get the GPU information
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            ManagementObjectCollection searchList = searcher.Get();
            List<GPU> aoGPUs = new List<GPU>();

            foreach (ManagementObject obj in searchList)
            {
                GPU oGPU = new GPU();
                Driver oDriver = new Driver();
                RAM oRAM = new RAM();

                oGPU.Name = obj["Name"].ToString();
                oGPU.DeviceID = obj["DeviceID"].ToString();

                // Get the RAM information
                oRAM.Capacity = Convert.ToUInt64(obj["AdapterRAM"]) / 1024 / 1024;
                oGPU.Ram = oRAM;

                // Get the driver information
                oDriver.BuildDate = obj["DriverDate"].ToString();
                //oDriver.Name = obj["InstalledDisplayDrivers"].ToString();
                oDriver.BuildVersion = obj["DriverVersion"].ToString();
                oGPU.Driver = oDriver;

                aoGPUs.Add(oGPU);
            }

            return aoGPUs.ToArray();
        }

        #endregion
    }
}
