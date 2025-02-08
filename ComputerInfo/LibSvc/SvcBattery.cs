using ComputerInfo.LibPcComponent;
using System;
using System.Management;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcBattery : BaseSvc
    {
        private Battery[] m_aoBatteries;

        #region Constructor
        public SvcBattery()
        {
            m_eSvcType = SvcType.Battery;
            m_aoBatteries = GetBatteries();
        }
        #endregion
        #region Properties
        #endregion
        #region Methods
        public override XmlElement GetXmlElement()
        {
            XmlDocument oXmlDocument = new XmlDocument();
            XmlElement oXmlElement = oXmlDocument.CreateElement("Batteries");
            foreach (Battery battery in m_aoBatteries)
            {
                XmlElement oBatteryElement = oXmlDocument.CreateElement("Battery");
                
                if (battery.BatteryLevel != Program.NOT_SET)
                {
                    XmlElement oBatteryLevelElement = oXmlDocument.CreateElement("BatteryLevel");
                    oBatteryLevelElement.InnerText = battery.BatteryLevel.ToString();
                    oBatteryElement.AppendChild(oBatteryLevelElement);
                }
                
                if (battery.BatteryCapacity != Program.NOT_SET)
                {
                    XmlElement oBatteryCapacityElement = oXmlDocument.CreateElement("BatteryCapacity");
                    oBatteryCapacityElement.InnerText = battery.BatteryCapacity.ToString();
                    oBatteryElement.AppendChild(oBatteryCapacityElement);
                }
                
                if (battery.BatteryState != BatteryState.Unknown)
                {
                    XmlElement oBatteryStateElement = oXmlDocument.CreateElement("BatteryState");
                    oBatteryStateElement.InnerText = battery.BatteryState.ToString();
                    oBatteryElement.AppendChild(oBatteryStateElement);
                }

                if (battery.CycleCount != Program.NOT_SET)
                {
                    XmlElement oCycleCountElement = oXmlDocument.CreateElement("CycleCount");
                    oCycleCountElement.InnerText = battery.CycleCount.ToString();
                    oBatteryElement.AppendChild(oCycleCountElement);
                }

                oXmlElement.AppendChild(oBatteryElement);
            }
            return oXmlElement;
        }
        public override string GetTextInfo()
        {
            string sTextInfo = "Batteries: ";
            foreach (Battery battery in m_aoBatteries)
            {
                sTextInfo += string.Format("{0}% - {1} mWh - {2} - {3} cycles", battery.BatteryLevel, battery.BatteryCapacity, battery.BatteryState, battery.CycleCount);
            }
            return sTextInfo;
        }
        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            throw new NotImplementedException();
        }
        public static Battery[] GetBatteries()
        {
            // Use the Win32_Battery API

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Battery");
            ManagementObjectCollection collection = searcher.Get();
            Battery[] aoBatteries = new Battery[collection.Count];
            int i = 0;
            foreach (ManagementObject item in collection)
            {
                aoBatteries[i++]
                    = new Battery
                    {
                        BatteryLevel = Convert.ToInt32(item["EstimatedChargeRemaining"]),
                        BatteryCapacity = Convert.ToInt32(item["FullChargeCapacity"]),
                        BatteryState = (BatteryState)Convert.ToInt32(item["BatteryStatus"]),
                    };
            }
            return aoBatteries;
        }
        #endregion
    }
}
