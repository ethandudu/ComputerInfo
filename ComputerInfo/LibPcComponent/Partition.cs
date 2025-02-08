using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum PartitionType
    {
        PRIMARY,
        EXTENDED,
        LOGICAL,
        UNKNOWN
    }

    internal class Partition
    {
        private int m_iNumber;
        private string m_sName;
        private PartitionType m_eType;
        private string m_sFileSystem;
        private UInt64 m_iSize;
        private int m_iUsedSpace;
        private int m_iFreeSpace;
        private int m_iAllocationUnitSize;

        #region Constructor

        public Partition()
        {
            m_iNumber = -1;
            m_sName = string.Empty;
            m_eType = PartitionType.UNKNOWN;
            m_sFileSystem = string.Empty;
            m_iSize = 0;
            m_iUsedSpace = -1;
            m_iFreeSpace = -1;
            m_iAllocationUnitSize = -1;
        }

        #endregion

        #region Properties

        public int Number
        {
            get { return m_iNumber; }
            set { m_iNumber = value; }
        }

        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }

        public PartitionType Type
        {
            get { return m_eType; }
            set { m_eType = value; }
        }

        public string FileSystem
        {
            get { return m_sFileSystem; }
            set { m_sFileSystem = value; }
        }

        public UInt64 Size
        {
            get { return m_iSize; }
            set { m_iSize = value; }
        }

        public int UsedSpace
        {
            get { return m_iUsedSpace; }
            set { m_iUsedSpace = value; }
        }

        public int FreeSpace
        {
            get { return m_iFreeSpace; }
            set { m_iFreeSpace = value; }
        }

        public int AllocationUnitSize
        {
            get { return m_iAllocationUnitSize; }
            set { m_iAllocationUnitSize = value; }
        }

        #endregion
    }
}
