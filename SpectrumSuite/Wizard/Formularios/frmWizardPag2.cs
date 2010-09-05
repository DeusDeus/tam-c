using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wizard.Formularios
{
    public partial class frmWizardPag2 : Form
    {
        private frmWizardPag1 objWizardPag1;
        private frmWizardPag3 objWizardPag3;

        public frmWizardPag2(Form frmWizardPag1)
        {
            InitializeComponent();
            objWizardPag3 = new frmWizardPag3(this);
            objWizardPag3.Visible = false;
            objWizardPag1 = (frmWizardPag1)frmWizardPag1;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            objWizardPag3.Location = this.Location;
            objWizardPag3.Visible = true;
            this.Visible = false;
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            objWizardPag1.Location = this.Location;
            objWizardPag1.Visible = true;
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
