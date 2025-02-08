using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal class GraphicAPI
    {
        private string m_sName;
        private string m_sVersion;

        #region Constructor

        public GraphicAPI()
        {
            m_sName = string.Empty;
            m_sVersion = string.Empty;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }

        public string Version
        {
            get { return m_sVersion; }
            set { m_sVersion = value; }
        }

        #endregion
    }
}
