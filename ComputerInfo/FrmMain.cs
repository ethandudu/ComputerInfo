using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerInfo
{
    public partial class FrmMain : Form
    {

        public FrmMain(string rctTextContent, TreeNode oTreeNode = null)
        {
            InitializeComponent();
            rctXML.Text = rctTextContent;
            if (oTreeNode != null)
            {
                trvHardware.Nodes.Add(oTreeNode);
                trvHardware.ExpandAll();
            }
        }
    }
}
