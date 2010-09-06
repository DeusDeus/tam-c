using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wizard.Formularios
{
    public partial class frmWizardPag3 : Form
    {
        private frmWizardPag2 objWizardPag2;
        private frmWizardPag4 objWizardPag4; 

        public frmWizardPag3(Form frmWizardPag2)
        {
            InitializeComponent();
            objWizardPag4 = new frmWizardPag4(this);
            objWizardPag4.Visible = false;
            objWizardPag4.Location = this.Location;
            objWizardPag2 = (frmWizardPag2)frmWizardPag2;
        }

        private void cmdAtras_Click(object sender, EventArgs e)
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

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            objWizardPag4.Location = this.Location;
            objWizardPag4.Visible = true;
            this.Visible = false;
        }
    }
}
