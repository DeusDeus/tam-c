using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentesNegocio;
using ComponentesGUI;

namespace SpectrumSuite
{
    public partial class frmPlaza : Form
    {
        public frmPlaza()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmPlaza_Load(object sender, EventArgs e)
        {
            DataSet ds = clsNegocio.CargarFormulario(this.Name);
            dgvPlaza.DataSource = ds;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.Name.CompareTo(dr["NombreObjeto"]) == 0)
                    {
                        switch ((String)dr["TipoObjeto"]) {
                            case "cmd":
                                ((ucButton)ctr).Name = "";
                                break;
                            case "cbx":
                                ((ucCheckBox)ctr).Name = "";
                                break;
                            case "cbo":
                                ((ucComboBox)ctr).Name = "";
                                break;
                            case "dtp":
                                ((ucDateTimePicker)ctr).Name = "";
                                break;
                            case "lbl":
                                ((ucLabel)ctr).Name = "";
                                break;
                            case "txt":
                                ((ucTextBox)ctr).Name = "";
                                break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
