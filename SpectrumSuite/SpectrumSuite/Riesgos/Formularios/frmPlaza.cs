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

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                clsComun.CargarControl(this, dr);
            }

            CargarPlazas();
            CargarMonedas();
        }

        private void CargarPlazas()
        {
            DataSet dsPlaza;
            
            clsComun.ActivarControl(lblTipoLista);
            clsComun.ActivarControl(lblCodigoPlaza);
            clsComun.ActivarControl(lblDescripcionPlaza);
            clsComun.ActivarControl(lblDescripcionPlazaCorta);

            clsComun.CrearListaControles(this, lstControles);

            dsPlaza = clsNegocio.ConsultarServicio(lstControles, "TRX002");

            dgvPlaza.DataSource = dsPlaza.Tables[0];

            for (int i = 0; i < dgvPlaza.Rows.Count; i++) dgvPlaza.Columns[i].ReadOnly = true;
            
            clsComun.DesactivarControl(lblTipoLista);
            clsComun.DesactivarControl(lblCodigoPlaza);
            clsComun.DesactivarControl(lblDescripcionPlaza);
            clsComun.DesactivarControl(lblDescripcionPlazaCorta);
            lstControles.Clear();
        }

        private void CargarMonedas()
        {
            DataSet dsMonedas;

            clsComun.ActivarControl(lblTipoListaMoneda);
            clsComun.ActivarControl(lblCodigoMoneda);
            clsComun.ActivarControl(lblDescripcionMoneda);

            clsComun.CrearListaControles(this, lstControles);

            dsMonedas = clsNegocio.ConsultarServicio(lstControles, "TRX001");

            foreach (DataRow dr in dsMonedas.Tables[0].Rows)
            {
                cboMoneda.Items.Add(dr["DescripMoneda"]);
            }

            if (cboMoneda.Items.Count > 0) cboMoneda.SelectedIndex = 0;

            clsComun.DesactivarControl(lblTipoListaMoneda);
            clsComun.DesactivarControl(lblCodigoMoneda);
            clsComun.DesactivarControl(lblDescripcionMoneda);
            lstControles.Clear();
        }
    }
}
