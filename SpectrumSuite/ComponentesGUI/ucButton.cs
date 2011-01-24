using System.Windows.Forms;

namespace ComponentesGUI
{
    public partial class ucButton : Button
    {
        public ucButton()
        {
            InitializeComponent();
        }

        private bool blnSoloLectura;
        private bool blnObligatorio;
        private bool blnIndBaseDatos;
        private bool blnIndCalculado;
        private bool blnIndicador = false;
        private bool blnIndicadorXML = false;
        private string strNombreTagXML;
        private string strNombreCampoBaseDatos;
        private string strNombreControl;
        private string strValor;
        private string strTipoDato;
        private string strLongitud;
        private string strPrecision;
        private string strIO;
        private string strCalculo;
        private string strFormula;
        private string strIdent;
        private string strPk;

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

        public bool Indicador
        {
            get
            {
                return blnIndicador;
            }

            set
            {
                blnIndicador = value;
            }
        }

        public bool IndicadorXML
        {
            get
            {
                return blnIndicadorXML;
            }

            set
            {
                blnIndicadorXML = value;
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

        public string Valor
        {
            get
            {
                return strValor;
            }
            set
            {
                strValor = value;
            }
        }

        public string Longitud
        {
            get
            {
                return strLongitud;
            }
            set
            {
                strLongitud = value;
            }
        }

        public string Precision
        {
            get
            {
                return strPrecision;
            }
            set
            {
                strPrecision = value;
            }
        }

        public string IO
        {
            get
            {
                return strIO;
            }
            set
            {
                strIO = value;
            }
        }

        public string Calculo
        {
            get
            {
                return strCalculo;
            }
            set
            {
                strCalculo = value;
            }
        }

        public string Formula
        {
            get
            {
                return strFormula;
            }
            set
            {
                strFormula = value;
            }
        }

        public bool Es_Calculado
        {
            get
            {
                return blnIndCalculado;
            }

            set
            {
                blnIndCalculado = value;
            }
        }

        public string NombreTagXML
        {
            get
            {
                return strNombreTagXML;
            }
            set
            {
                strNombreTagXML = value;
            }
        }

        public string IndicadorIdentity
        {
            get
            {
                return strIdent;
            }
            set
            {
                strIdent = value;
            }
        }

        public string IndicadorPK
        {
            get
            {
                return strPk;
            }
            set
            {
                strPk = value;
            }
        }
    }
}
