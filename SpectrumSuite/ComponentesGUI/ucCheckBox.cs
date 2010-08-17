using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentesGUI
{
    public partial class ucCheckBox : CheckBox 
    {
        public ucCheckBox()
        {
            InitializeComponent();
        }


        public bool blnSoloLectura;
        public bool blnObligatorio;
        public bool blnIndBaseDatos;
        public string strNombreCampoBaseDatos;
        public string strNombreControl;
        public string strTipoDato;

        public bool Solo_Lectura
        {
            get
            {
                return blnSoloLectura;
            }

            set
            {
                blnSoloLectura = value;
                if (blnSoloLectura == true)
                {
                    this.Enabled = false;
                }
                else
                {
                    this.Enabled = true;
                }
            }
        }

        public bool Es_Obligatorio
        {
            get
            {
                return blnObligatorio;
            }

            set
            {
                blnObligatorio = value;
            }
        }

        public bool Flag_BD
        {
            get
            {
                return blnIndBaseDatos;
            }

            set
            {
                blnIndBaseDatos = value;
            }
        }

        public string Nombre_Campo
        {
            get
            {
                return strNombreCampoBaseDatos;
            }
            set
            {
                strNombreCampoBaseDatos = value;
            }
        }

        public string Nombre_Control
        {
            get
            {
                return strNombreControl;
            }
            set
            {
                strNombreControl = value;
            }
        }

        public string Tipo_Dato
        {
            get
            {
                return strTipoDato;
            }
            set
            {
                strTipoDato = value;
            }
        }
    }
}
