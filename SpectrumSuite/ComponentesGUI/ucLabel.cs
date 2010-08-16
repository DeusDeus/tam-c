﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentesGUI
{
    public partial class ucLabel : Label
    {
        public ucLabel()
        {
            InitializeComponent();
        }

        public enum TipoDato : int
        {
            Int = 0,
            Double = 1,
            Char = 2,
            Date = 3,
            Bool = 4
        }

        TipoDato td;
        public bool blnSoloLectura;
        public bool blnObligatorio;
        public bool blnIndBaseDatos;
        public string strNombreCampoBaseDatos;
        public string strNombreControl;

        public TipoDato Tipo_Dato
        {
            get
            {
                return td;
            }
            set
            {
                td = value;
            }
        }

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
    }
}
