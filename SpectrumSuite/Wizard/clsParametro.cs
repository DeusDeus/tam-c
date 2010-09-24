using System;
using System.Collections.Generic;
using System.Text;

namespace Wizard
{
    public class clsParametro
    {
        private string strNombreServicio;

        public string StrNombreServicio
        {
            get { return strNombreServicio; }
            set { strNombreServicio = value; }
        }
        private string strNombreParametro;

        public string StrNombreParametro
        {
            get { return strNombreParametro; }
            set { strNombreParametro = value; }
        }
        private string chrTipoServicio;

        public string ChrTipoServicio
        {
            get { return chrTipoServicio; }
            set { chrTipoServicio = value; }
        }
        private int numTipoOperacion;

        public int NumTipoOperacion
        {
            get { return numTipoOperacion; }
            set { numTipoOperacion = value; }
        }
        private int numOrden;

        public int NumOrden
        {
            get { return numOrden; }
            set { numOrden = value; }
        }
    }
}
