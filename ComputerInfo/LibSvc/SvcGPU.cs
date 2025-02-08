using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcGPU : BaseSvc
    {
        private GPU[] m_aoGPUs;

        #region Constructor

        public SvcGPU()
        {
            m_eSvcType = SvcType.GPU;
            m_aoGPUs = GetGPUs();
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

        public static GPU[] GetGPUs()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
