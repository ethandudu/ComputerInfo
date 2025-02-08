using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal class IPV6Config : BaseIPConfig
    {
        private string m_sLocalLinkAddress;
        private string m_sGlobalAddress;
        private string m_sTemporaryAddress;

        #region Constructor

        public IPV6Config()
        {
            m_sLocalLinkAddress = string.Empty;
            m_sGlobalAddress = string.Empty;
            m_sTemporaryAddress = string.Empty;
        }

        #endregion

        #region Properties

        public string LocalLinkAddress
        {
            get { return m_sLocalLinkAddress; }
            set { m_sLocalLinkAddress = value; }
        }

        public string GlobalAddress
        {
            get { return m_sGlobalAddress; }
            set { m_sGlobalAddress = value; }
        }

        public string TemporaryAddress
        {
            get { return m_sTemporaryAddress; }
            set { m_sTemporaryAddress = value; }
        }

        #endregion
    }
}
