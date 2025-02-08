using ComputerInfo.LibSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerInfo
{
    internal static class Program
    {
        // Constant (-1) to indicate that an integer value is not set
        public const int NOT_SET = -1;
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            SvcOs oSvcOS = new SvcOs();
            Console.WriteLine(oSvcOS.GetTextInfo());
            SvcBattery oSvcBattery = new SvcBattery();
            Console.WriteLine(oSvcBattery.GetTextInfo());
            Console.WriteLine(oSvcBattery.GetXmlElement().OuterXml);
        }
    }
}
