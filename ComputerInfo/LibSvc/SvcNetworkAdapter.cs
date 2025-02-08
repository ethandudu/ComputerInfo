using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcNetworkAdapter : BaseSvc
    {
        private SvcNetworkAdapter[] m_aoNetworkAdapters;

        #region Constructor

        public SvcNetworkAdapter()
        {
            m_eSvcType = SvcType.Network;
            m_aoNetworkAdapters = GetNetworkAdapters();
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override System.Xml.XmlElement GetXmlElement()
        {
            throw new NotImplementedException();
        }

        public override string GetTextInfo()
        {
            throw new NotImplementedException();
        }

        public override System.Windows.Forms.TreeNode GetTreeNode()
        {
            throw new NotImplementedException();
        }

        public static SvcNetworkAdapter[] GetNetworkAdapters()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
