using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerInfo.LibPcComponent
{
    internal class GPU : BasePcComponent
    {
        private int m_iFrequency;
        private int m_iWorkLoad;
        private int m_iTemperature;
        private int m_iPCIeSlot;
        private RAM m_oRam;
        private GraphicAPI m_oGraphicAPI;

        #region Constructor

        public GPU()
        {
            m_iFrequency = -1;
            m_iWorkLoad = -1;
            m_iTemperature = -1;
            m_iPCIeSlot = -1;
            m_oRam = new RAM();
            m_oGraphicAPI = new GraphicAPI();
        }

        #endregion

        #region Properties

        public int Frequency
        {
            get { return m_iFrequency; }
            set { m_iFrequency = value; }
        }

        public int WorkLoad
        {
            get { return m_iWorkLoad; }
            set { m_iWorkLoad = value; }
        }

        public int Temperature
        {
            get { return m_iTemperature; }
            set { m_iTemperature = value; }
        }

        public int PCIeSlot
        {
            get { return m_iPCIeSlot; }
            set { m_iPCIeSlot = value; }
        }

        public RAM Ram
        {
            get { return m_oRam; }
            set { m_oRam = value; }
        }

        public GraphicAPI GraphicAPI
        {
            get { return m_oGraphicAPI; }
            set { m_oGraphicAPI = value; }
        }

        #endregion
    }
}
