using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal abstract class BasePcComponent
    {
        protected string m_sName;
        protected string m_sVendor;
        protected string m_sSerial;
        protected Driver m_oDriver;

        #region Constructor

        public BasePcComponent()
        {
            m_sName = string.Empty;
            m_sVendor = string.Empty;
            m_sSerial = string.Empty;
            m_oDriver = null;
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

        public string Serial
        {
            get { return m_sSerial; }
            set { m_sSerial = value; }
        }

        public Driver Driver
        {
            get { return m_oDriver; }
            set { m_oDriver = value; }
        }

        #endregion
    }
}
