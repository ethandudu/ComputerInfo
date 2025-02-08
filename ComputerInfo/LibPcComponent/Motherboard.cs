using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal class Motherboard : BasePcComponent
    {
        private string m_sBiosVersion;
        private string m_sTemp;

        #region Constructor

        public Motherboard()
        {
            m_sBiosVersion = string.Empty;
            m_sTemp = string.Empty;
        }

        #endregion

        #region Properties

        public string BiosVersion
        {
            get { return m_sBiosVersion; }
            set { m_sBiosVersion = value; }
        }

        public string Temp
        {
            get { return m_sTemp; }
            set { m_sTemp = value; }
        }

        #endregion
    }
}
