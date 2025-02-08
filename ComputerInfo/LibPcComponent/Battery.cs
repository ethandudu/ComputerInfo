using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum BatteryState
    {
        Charging,
        Discharging,
        PluggedNotCharging,
        Unknown
    }

    internal class Battery : BasePcComponent
    {
        private int m_iBatteryLevel;
        private int m_iBatteryCapacity;
        private BatteryState m_eBatteryState;
        private int m_iCycleCount;

        #region Constructor

        public Battery()
        {
            m_iBatteryLevel = -1;
            m_iBatteryCapacity = -1;
            m_eBatteryState = BatteryState.Unknown;
            m_iCycleCount = -1;
        }

        #endregion

        #region Properties

        public int BatteryLevel
        {
            get { return m_iBatteryLevel; }
            set { m_iBatteryLevel = value; }
        }

        public int BatteryCapacity
        {
            get { return m_iBatteryCapacity; }
            set { m_iBatteryCapacity = value; }
        }

        public BatteryState BatteryState
        {
            get { return m_eBatteryState; }
            set { m_eBatteryState = value; }
        }

        public int CycleCount
        {
            get { return m_iCycleCount; }
            set { m_iCycleCount = value; }
        }

        #endregion
    }
}
