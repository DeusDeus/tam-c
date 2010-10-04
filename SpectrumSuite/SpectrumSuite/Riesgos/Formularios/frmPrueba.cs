using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpectrumSuite.Riesgos.Formularios
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            cboPrueba.Items.Add("WILDER");
            cboPrueba.Items.Add("JOSUE");
            cboPrueba.Items.Add("CHICANA");
            cboPrueba.Items.Add("VIVAR");
            cboPrueba.Items.Add("PUCP");

            cboPrueba.ForeColor = Color.Blue;
        }
    }
}
