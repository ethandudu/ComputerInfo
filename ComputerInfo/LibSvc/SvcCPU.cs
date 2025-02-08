using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcCPU : BaseSvc
    {
        private CPU[] m_aoCPUs;

        #region Constructor
        public SvcCPU()
        {
            m_eSvcType = SvcType.CPU;
            m_aoCPUs = GetCPUs();
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
        public static CPU[] GetCPUs()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
