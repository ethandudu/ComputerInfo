using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    enum Architecture
    {
        x86,
        x64,
        ARM,
        ARM64,
        UNKNOWN
    }

    internal class OS
    {
        private string m_sName;
        private string m_sBuildVersion;
        private string m_sUserLogin;
        private string m_sComputerName;
        private Architecture m_eArchitecture;

        #region Constructor

        public OS()
        {
            m_sName = string.Empty;
            m_sBuildVersion = string.Empty;
            m_sUserLogin = string.Empty;
            m_sComputerName = string.Empty;
            m_eArchitecture = Architecture.UNKNOWN;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }

        public string BuildVersion
        {
            get { return m_sBuildVersion; }
            set { m_sBuildVersion = value; }
        }

        public string UserLogin
        {
            get { return m_sUserLogin; }
            set { m_sUserLogin = value; }
        }

        public string ComputerName
        {
            get { return m_sComputerName; }
            set { m_sComputerName = value; }
        }

        public Architecture Architecture
        {
            get { return m_eArchitecture; }
            set { m_eArchitecture = value; }
        }

        #endregion
    }
}
