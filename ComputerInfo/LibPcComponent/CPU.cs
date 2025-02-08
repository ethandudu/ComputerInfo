using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum ArchitectureType
    {
        x86 = 0,
        MIPS = 1,
        Alpha = 2,
        PowerPC = 3,
        ARM = 5,
        ia64 = 6,
        x64 = 9,
        ARM64 = 12,
        UNKNOWN = -1
    }
    internal class CPU : BasePcComponent
    {
        private string m_sCPUID;
        private string m_sFirmwareVersion;
        private int m_iCoreCount;
        private int m_iThreadCount;
        private ArchitectureType m_eArchitecture;
        private int m_iBaseClock;
        private int m_iMaxClock;
        private int m_iCurrentClock;
        private int m_iTemperature;

        #region Constructor

        public CPU()
        {
            m_sCPUID = string.Empty;
            m_sFirmwareVersion = string.Empty;
            m_iCoreCount = -1;
            m_iThreadCount = -1;
            m_eArchitecture = ArchitectureType.UNKNOWN;
            m_iBaseClock = -1;
            m_iMaxClock = -1;
            m_iCurrentClock = -1;
            m_iTemperature = -1;
        }

        #endregion

        #region Properties

        public string CPUID
        {
            get { return m_sCPUID; }
            set { m_sCPUID = value; }
        }

        public string FirmwareVersion
        {
            get { return m_sFirmwareVersion; }
            set { m_sFirmwareVersion = value; }
        }

        public int CoreCount
        {
            get { return m_iCoreCount; }
            set { m_iCoreCount = value; }
        }

        public int ThreadCount
        {
            get { return m_iThreadCount; }
            set { m_iThreadCount = value; }
        }

        public ArchitectureType Architecture
        {
            get { return m_eArchitecture; }
            set { m_eArchitecture = value; }
        }

        public int BaseClock
        {
            get { return m_iBaseClock; }
            set { m_iBaseClock = value; }
        }

        public int MaxClock
        {
            get { return m_iMaxClock; }
            set { m_iMaxClock = value; }
        }

        public int CurrentClock
        {
            get { return m_iCurrentClock; }
            set { m_iCurrentClock = value; }
        }

        public int Temperature
        {
            get { return m_iTemperature; }
            set { m_iTemperature = value; }
        }

        #endregion
    }
}
