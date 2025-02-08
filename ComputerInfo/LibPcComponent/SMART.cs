using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum DiskType
    {
        HDD,
        SSD,
        SSHD,
        UNKNOWN
    }

    enum ConnectionType
    {
        SATA,
        IDE,
        SCSI,
        USB,
        NVMe,
        M2,
        PCIE,
        UNKNOWN
    }

    internal class SMART
    {
        private int m_iTemperature;
        private int m_iReallocatedSectors;
        private int m_iBadSectors;
        private int m_iDataRead;
        private int m_iDataWritten;
        private int m_iPowerOnCount;
        private int m_iPowerOnHours;
        private ConnectionType m_eConnectionType;
        private DiskType m_eDiskType;

        #region Constructor

        public SMART()
        {
            m_iTemperature = -1;
            m_iReallocatedSectors = -1;
            m_iBadSectors = -1;
            m_iDataRead = -1;
            m_iDataWritten = -1;
            m_iPowerOnCount = -1;
            m_iPowerOnHours = -1;
            m_eConnectionType = ConnectionType.UNKNOWN;
            m_eDiskType = DiskType.UNKNOWN;
        }

        #endregion

        #region Properties

        public int Temperature
        {
            get { return m_iTemperature; }
            set { m_iTemperature = value; }
        }

        public int ReallocatedSectors
        {
            get { return m_iReallocatedSectors; }
            set { m_iReallocatedSectors = value; }
        }

        public int BadSectors
        {
            get { return m_iBadSectors; }
            set { m_iBadSectors = value; }
        }

        public int DataRead
        {
            get { return m_iDataRead; }
            set { m_iDataRead = value; }
        }

        public int DataWritten
        {
            get { return m_iDataWritten; }
            set { m_iDataWritten = value; }
        }

        public int PowerOnCount
        {
            get { return m_iPowerOnCount; }
            set { m_iPowerOnCount = value; }
        }

        public int PowerOnHours
        {
            get { return m_iPowerOnHours; }
            set { m_iPowerOnHours = value; }
        }

        public ConnectionType ConnectionType
        {
            get { return m_eConnectionType; }
            set { m_eConnectionType = value; }
        }

        public DiskType DiskType
        {
            get { return m_eDiskType; }
            set { m_eDiskType = value; }
        }

        #endregion

    }
}
