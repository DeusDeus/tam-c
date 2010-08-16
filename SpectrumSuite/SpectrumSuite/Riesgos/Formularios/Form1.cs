using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentesNegocio;

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
            DataTable dt = clsNegocio.CargarFormulario(this.Name);

            dgvPlaza.DataSource = dt;
        }
    }
}
