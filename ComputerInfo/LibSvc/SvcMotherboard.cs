using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcMotherboard : BaseSvc
    {
        private Motherboard m_oMotherboard;
        #region Constructor
        public SvcMotherboard()
        {
            m_eSvcType = SvcType.Motherboard;
            m_oMotherboard = GetMotherboard();
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
        public static Motherboard GetMotherboard()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
