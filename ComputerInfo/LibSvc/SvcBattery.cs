using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcBattery : BaseSvc
    {
        private Battery[] m_aoBatteries;
        
        #region Constructor
        public SvcBattery()
        {
            m_eSvcType = SvcType.Battery;
            m_aoBatteries = GetBatteries();
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
        public static Battery[] GetBatteries()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
