using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdministradorTablas
{
    public class clsAtributo
    {
        private string nombreAtributo;

        public string NombreAtributo
        {
            get { return nombreAtributo; }
            set { nombreAtributo = value; }
        }
        private string tipoDato;

        public string TipoDato
        {
            get { return tipoDato; }
            set { tipoDato = value; }
        }
        private string tamano;

        public string Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }
    }
}
