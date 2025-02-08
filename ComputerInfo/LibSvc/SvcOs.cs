using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcOs : BaseSvc
    {
        private OS m_oOs;

        #region Constructor

        public SvcOs()
        {
            m_eSvcType = SvcType.OS;
            m_oOs = GetOs();
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

        public static OS GetOs()
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
