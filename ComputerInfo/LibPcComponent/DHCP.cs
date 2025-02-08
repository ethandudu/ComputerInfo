using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum DHCPStatus
    {
        Enabled,
        Disabled,
        UNKNOWN
    }

    internal class DHCP
    {
        private DHCPStatus m_eDHCPStatus;
        private string m_sLeaseObtained;
        private string m_sLeaseExpires;
        private string m_sDHCPServerIP;

        #region Constructor

        public DHCP()
        {
            m_eDHCPStatus = DHCPStatus.UNKNOWN;
            m_sLeaseObtained = string.Empty;
            m_sLeaseExpires = string.Empty;
            m_sDHCPServerIP = string.Empty;
        }

        #endregion

        #region Properties

        public DHCPStatus Status
        {
            get { return m_eDHCPStatus; }
            set { m_eDHCPStatus = value; }
        }

        public string LeaseObtained
        {
            get { return m_sLeaseObtained; }
            set { m_sLeaseObtained = value; }
        }

        public string LeaseExpires
        {
            get { return m_sLeaseExpires; }
            set { m_sLeaseExpires = value; }
        }

        public string DHCPServerIP
        {
            get { return m_sDHCPServerIP; }
            set { m_sDHCPServerIP = value; }
        }

        #endregion
    }
}
