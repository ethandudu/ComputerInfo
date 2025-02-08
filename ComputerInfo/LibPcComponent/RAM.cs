using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum RAMType
    {
        DDR,
        DDR2,
        DDR3,
        DDR4,
        DDR5,
        GDDR5,
        GDDR5X,
        GDDR6,
        HBM,
        HBM2,
        HBM3,
        LPDDR,
        LPDDR2,
        LPDDR3,
        LPDDR4,
        LPDDR5,
        UNKNOWN
    }

    enum RAMFormFactor
    {
        DIMM,
        SODIMM,
        UNKNOWN
    }
    internal class RAM : BasePcComponent
    {
        private int m_iFrequency;
        private int m_iCapacity;
        private RAMType m_eType;
        private RAMFormFactor m_eFormFactor;
        private int m_iSlot;

        #region Constructor

        public RAM()
        {
            m_iFrequency = -1;
            m_iCapacity = -1;
            m_eType = RAMType.UNKNOWN;
            m_eFormFactor = RAMFormFactor.UNKNOWN;
            m_iSlot = -1;
        }

        #endregion
    }
}
