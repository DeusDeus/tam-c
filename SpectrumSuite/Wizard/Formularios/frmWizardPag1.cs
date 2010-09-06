using System;
using System.Windows.Forms;

namespace Wizard.Formularios
{
    public partial class frmWizardPag1 : Form
    {
        private frmWizardPag2 objWizardPag2;
        private Connect objConnect;

        public frmWizardPag1(Connect pobjConnect)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            objWizardPag2 = new frmWizardPag2(this, objConnect);
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
            DialogResult dr = MessageBox.Show("Está seguro que desea cancelar", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                objConnect.Reset();
                this.Dispose();
            }
        }
    }
}
