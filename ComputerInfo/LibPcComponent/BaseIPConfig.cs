using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum IPVersion
    {
        IPv4,
        IPv6,
        UNKNOWN
    }

    internal abstract class BaseIPConfig
    {
        protected IPVersion m_eIPVersion;
        protected string m_sIP;
        protected string m_sSubnetMask;
        protected string m_sGateway;
        protected string[] m_asDnsServersIP;
        protected DHCP m_oDHCP;

        #region Constructor

        public BaseIPConfig()
        {
            m_eIPVersion = IPVersion.UNKNOWN;
            m_sIP = string.Empty;
            m_sSubnetMask = string.Empty;
            m_sGateway = string.Empty;
            m_asDnsServersIP = null;
        }

        #endregion

        #region Properties

        public IPVersion IPVersion
        {
            get { return m_eIPVersion; }
            set { m_eIPVersion = value; }
        }

        public string IP
        {
            get { return m_sIP; }
            set { m_sIP = value; }
        }

        public string SubnetMask
        {
            get { return m_sSubnetMask; }
            set { m_sSubnetMask = value; }
        }

        public string Gateway
        {
            get { return m_sGateway; }
            set { m_sGateway = value; }
        }

        public string[] DnsServersIP
        {
            get { return m_asDnsServersIP; }
            set { m_asDnsServersIP = value; }
        }

        public DHCP DHCP
        {
            get { return m_oDHCP; }
            set { m_oDHCP = value; }
        }

        #endregion
    }
}
