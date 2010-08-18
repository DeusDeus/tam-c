using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentesComun;
using ComponentesNegocio;

namespace SpectrumSuite
{
    public partial class frmPlaza : Form
    {
        private List<Control> lstControles = new List<Control>();
        
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
            DataSet dsPlaza;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                clsComun.CargarControl(this, dr);
            }

            clsComun.ActivarControl(lblTipoLista);
            clsComun.ActivarControl(lblCodigoPlaza);
            clsComun.ActivarControl(lblDescripcionPlaza);
            clsComun.ActivarControl(lblDescripcionPlazaCorta);

            clsComun.CrearListaControles(this, lstControles);

            dsPlaza = clsNegocio.ConsultarServicio(lstControles, "TRX002");

            dgvPlaza.DataSource = dsPlaza.Tables[0];

            for (int i = 0; i < dgvPlaza.Rows.Count; i++) dgvPlaza.Columns[i].ReadOnly = true;
        }
    }
}
