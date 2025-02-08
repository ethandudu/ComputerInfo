using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal class Driver
    {
        private string m_sName;
        private string m_sVendor;
        private string m_sBuildVersion;
        private string m_sBuildDate;

        #region Constructor

        public Driver()
        {
            m_sName = string.Empty;
            m_sVendor = string.Empty;
            m_sBuildVersion = string.Empty;
            m_sBuildDate = string.Empty;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }

        public string Vendor
        {
            get { return m_sVendor; }
            set { m_sVendor = value; }
        }

        public string BuildVersion
        {
            get { return m_sBuildVersion; }
            set { m_sBuildVersion = value; }
        }

        public string BuildDate
        {
            get { return m_sBuildDate; }
            set { m_sBuildDate = value; }
        }
    }

    #endregion
}
