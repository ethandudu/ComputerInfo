using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcRAM : BaseSvc
    {
        private RAM[] m_aoRAMs;
        #region Constructor

        public SvcRAM()
        {
            m_eSvcType = SvcType.RAM;
            m_aoRAMs = GetRAMs();
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
        public static RAM[] GetRAMs()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
