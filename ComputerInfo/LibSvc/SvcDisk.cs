using ComputerInfo.LibPcComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibSvc
{
    internal class SvcDisk : BaseSvc
    {
        private Disk[] m_aoDisks;

        #region Constructor

        public SvcDisk()
        {
            m_eSvcType = SvcType.Disk;
            m_aoDisks = GetDisks();
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

        public static Disk[] GetDisks()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
