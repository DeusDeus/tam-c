using System;
using System.Windows.Forms;
using System.Collections.Generic;
using EnvDTE;

namespace Wizard.Formularios
{
    public partial class frmWizardPag1 : Form
    {
        private List<string> lstModulos = new List<string>();
        private List<ProjectItem> lstFormularios = new List<ProjectItem>();
        private frmWizardPag2 objWizardPag2 = null;
        private Connect objConnect;
        private ProjectItem item;
        private string strNombreModulo;

        public frmWizardPag1(Connect pobjConnect)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            lstModulos = objConnect.ObtenerModulos();
            LLenarComboModulos(lstModulos);
        }

        private void LLenarComboModulos(List<string> plstModulos)
        {
            foreach (string nombre in plstModulos)
            {
                cboModulos.Items.Add(nombre);
            }
        }

        public ProjectItem ObtenerFormulario()
        {
            return item;
        }

        public string ObtenerNombreModulo()
        {
            return strNombreModulo;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            item = lstFormularios[cboFormularios.SelectedIndex];
            strNombreModulo = cboModulos.SelectedItem.ToString();
            
            if (objWizardPag2 == null)
            {
                objWizardPag2 = new frmWizardPag2(this, objConnect);
            }

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

        private void cboModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModulos.SelectedIndex >= 0)
            {
                lstFormularios = objConnect.ObtenerFormularios(cboModulos.SelectedItem.ToString());

                for (int i = 0; i < lstFormularios.Count; i++)
                {
                    cboFormularios.Items.Add(lstFormularios[i].Name);
                }
            }
            else
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cboFormularios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModulos.SelectedIndex >= 0)
            {
                cmdSiguiente.Enabled = true;
            }
            else
            {
                cmdSiguiente.Enabled = false;
            }
        }
    }
}
