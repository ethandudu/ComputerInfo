using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum RAMType
    {
        UNKNOWN = 0,
        Other = 1,
        DRAM = 2,
        SynchronousDRAM = 3,
        CacheDRAM = 4,
        EDO = 5,
        EDRAM = 6,
        VRAM = 7,
        SRAM = 8,
        RAM = 9,
        ROM = 10,
        Flash = 11,
        EEPROM = 12,
        FEPROM = 13,
        EPROM = 14,
        CDRAM = 15,
        _3DRAM = 16,
        SDRAM = 17,
        SGRAM = 18,
        RDRAM = 19,
        DDR = 20,
        DDR2 = 21,
        DDR2FBDIMM = 22,
        DDR3 = 24,
        FBD2 = 25,
        DDR4 = 26
    }

    enum RAMFormFactor
    {
        UNKNOWN = 0,
        Other = 1,
        SIP = 2,
        DIP = 3,
        ZIP = 4,
        SOJ = 5,
        Proprietary = 6,
        SIMM = 7,
        DIMM = 8,
        TSOP = 9,
        PGA = 10,
        RIMM = 11,
        SODIMM = 12,
        SRIMM = 13,
        SMD = 14,
        SSMP = 15,
        QFP = 16,
        TQFP = 17,
        SOIC = 18,
        LCC = 19,
        PLCC = 20,
        BGA = 21,
        FPBGA = 22,
        LGA = 23,
        FBDIMM = 24
    }

    internal class RAM : BasePcComponent
    {
        private int m_iFrequency;
        private UInt64 m_iCapacity;
        private RAMType m_eType;
        private RAMFormFactor m_eFormFactor;
        private int m_iSlot;

        #region Constructor

        public RAM()
        {
            m_iFrequency = -1;
            m_iCapacity = 0;
            m_eType = RAMType.UNKNOWN;
            m_eFormFactor = RAMFormFactor.UNKNOWN;
            m_iSlot = -1;
        }

        #endregion

        #region Properties

        public int Frequency
        {
            get { return m_iFrequency; }
            set { m_iFrequency = value; }
        }

        public UInt64 Capacity
        {
            get { return m_iCapacity; }
            set { m_iCapacity = value; }
        }

        public RAMType Type
        {
            get { return m_eType; }
            set { m_eType = value; }
        }

        public RAMFormFactor FormFactor
        {
            get { return m_eFormFactor; }
            set { m_eFormFactor = value; }
        }

        public int Slot
        {
            get { return m_iSlot; }
            set { m_iSlot = value; }
        }

        #endregion
    }
}
