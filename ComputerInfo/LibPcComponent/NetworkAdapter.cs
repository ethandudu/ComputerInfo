using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum NetworkAdapterType
    {
        Ethernet,
        Wifi,
        Bluetooth,
        UNKNOWN
    }

    enum StatusType
    {
        Connected,
        Disconnected,
        UNKNOWN
    }

    enum SoftwareStatusType
    {
        Enabled,
        Disabled,
        UNKNOWN
    }

    internal class NetworkAdapter : BasePcComponent
    {
        private string m_sMacAddress;
        private NetworkAdapterType m_eType;
        private StatusType m_eConnectionStatus;
        private SoftwareStatusType m_eStatus;

        #region Constructor

        public NetworkAdapter()
        {
            m_sMacAddress = string.Empty;
            m_eType = NetworkAdapterType.UNKNOWN;
            m_eConnectionStatus = StatusType.UNKNOWN;
            m_eStatus = SoftwareStatusType.UNKNOWN;
        }

        #endregion

        #region Properties

        public string MacAddress
        {
            get { return m_sMacAddress; }
            set { m_sMacAddress = value; }
        }

        public NetworkAdapterType Type
        {
            get { return m_eType; }
            set { m_eType = value; }
        }

        public StatusType ConnectionStatus
        {
            get { return m_eConnectionStatus; }
            set { m_eConnectionStatus = value; }
        }

        public SoftwareStatusType Status
        {
            get { return m_eStatus; }
            set { m_eStatus = value; }
        }

        #endregion

    }
}
