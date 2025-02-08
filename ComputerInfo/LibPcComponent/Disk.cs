using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal class Disk : BasePcComponent
    {
        private int m_iSize;
        private SMART m_oSMART;
        private Partition[] m_aPartitions;

        #region Constructor

        public Disk()
        {
            m_iSize = -1;
            m_oSMART = null;
            m_aPartitions = null;
        }

        #endregion

        #region Properties

        public int Size
        {
            get { return m_iSize; }
            set { m_iSize = value; }
        }

        public SMART SMART
        {
            get { return m_oSMART; }
            set { m_oSMART = value; }
        }

        public Partition[] Partitions
        {
            get { return m_aPartitions; }
            set { m_aPartitions = value; }
        }

        #endregion
    }
}
