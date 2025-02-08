using ComputerInfo.LibPcComponent;
using System;
using System.Management;
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
        public override System.Xml.XmlElement GetXmlElement()
        {
            throw new NotImplementedException();
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
