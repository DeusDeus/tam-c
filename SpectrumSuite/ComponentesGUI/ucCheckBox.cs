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
    public partial class ucCheckBox : UserControl
    {
        public enum TipoDato : int
        {
            Int = 0,
            Double = 1,
            Char = 2,
            Date = 3,
            Bool = 4
        }

        TipoDato tipo_dato;
        public bool solo_lectura;
        public bool es_obligatorio;
        public bool flag_BD;
        public string nombre_campo;
        public string nombre_control;

        public ucCheckBox()
        {
            InitializeComponent();
        }

        public TipoDato Tipo_Dato
        {
            get
            {
                return tipo_dato;
            }
            set
            {
                tipo_dato = value;
            }
        }

        public bool Solo_Lectura
        {
            get
            {
                return solo_lectura;
            }

            set
            {
                solo_lectura = value;
                if (solo_lectura == true)
                {
                    cbControl.Enabled= false;
                    cbControl.BackColor= Color.AliceBlue;
                }
            }
        }

        public bool Es_Obligatorio
        {
            get
            {
                return es_obligatorio;
            }

            set
            {
                es_obligatorio = value;
            }
        }

        public bool Flag_BD
        {
            get
            {
                return flag_BD;
            }

            set
            {
                flag_BD = value;
            }
        }

        public string Nombre_Campo
        {
            get
            {
                return nombre_campo;
            }
            set
            {
                nombre_campo = value;
            }
        }

        public string Nombre_Control
        {
            get
            {
                return nombre_control;
            }
            set
            {
                nombre_control = value;
            }
        }
    }
}
