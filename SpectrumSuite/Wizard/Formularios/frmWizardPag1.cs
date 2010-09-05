using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wizard.Formularios
{
    public partial class frmWizardPag1 : Form
    {
        private frmWizardPag2 objWizardPag2;

        public frmWizardPag1()
        {
            InitializeComponent();
            objWizardPag2 = new frmWizardPag2(this);
            objWizardPag2.Visible = false;
            objWizardPag2.Location = this.Location;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            objWizardPag2.Location = this.Location;
            objWizardPag2.Visible = true;
            this.Visible = false;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Está seguro que desea cancelar", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
