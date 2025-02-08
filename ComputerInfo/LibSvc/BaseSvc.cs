using ComputerInfo.LibSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ComputerInfo.LibSvc
{
    enum SvcType
    {
        Disk,
        Battery,
        OS,
        Network,
        CPU,
        RAM,
        GPU,
        Motherboard,
        UNKNOWN
    }

    internal abstract class BaseSvc
    {
        protected SvcType m_eSvcType;

        #region Constructor

        public BaseSvc()
        {
            m_eSvcType = SvcType.UNKNOWN;
        }

        #endregion

        #region Properties

        public SvcType SvcType
        {
            get { return m_eSvcType; }
        }

        #endregion

        #region Methods

        public abstract XmlElement GetXmlElement();
        public abstract String GetTextInfo();
        public abstract TreeNode GetTreeNode();

        #endregion
    }
}
