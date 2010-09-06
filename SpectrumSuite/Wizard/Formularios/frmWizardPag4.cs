using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wizard.Formularios
{
    public partial class frmWizardPag4 : Form
    {
        private frmWizardPag3 objWizardPag3;
        private Connect objConnect;

        public frmWizardPag4(Form frmWizardPag3, Connect pobjConnect)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            objWizardPag3 = (frmWizardPag3)frmWizardPag3;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            objConnect.Reset();
            this.Dispose();
        }
    }
}
