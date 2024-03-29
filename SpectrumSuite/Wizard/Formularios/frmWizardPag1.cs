﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using EnvDTE;
using System.Data;

namespace Wizard.Formularios
{
    public partial class frmWizardPag1 : Form
    {
        private List<string> lstModulos = new List<string>();
        private List<ProjectItem> lstFormularios = new List<ProjectItem>();
        private frmWizardPag2 objWizardPag2 = null;
        private DataTable dt = new DataTable();
        private Connect objConnect;
        private ProjectItem item;
        private string strNombreModulo;

        public frmWizardPag1(Connect pobjConnect)
        {
            try
            {
                InitializeComponent();
                objConnect = pobjConnect;
                lstModulos = objConnect.ObtenerModulos();
                LLenarComboModulos(lstModulos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema\nAsegúrese de que el proyecto que desee gestionar esté como 'Proyecto de Inicio'","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LLenarComboModulos(List<string> plstModulos)
        {
            foreach (string nombre in plstModulos)
            {
                //MessageBox.Show(nombre);
                cboModulos.Items.Add(nombre);
            }
        }

        public DataTable ObtenerTablaMetadata()
        {
            return dt;
        }

        public string ObtenerNombreFormulario()
        {
            string strNombreFormulario = "";
            string strAuxiliar = "";

            strNombreFormulario = item.Name;

            for (int i = 0; i < strNombreFormulario.Length; i++)
            {
                if (strNombreFormulario[i] == '.')
                {
                    break;
                }
                else
                {
                    strAuxiliar += strNombreFormulario[i];
                }
            }

            return strAuxiliar;
        }

        public string ObtenerNombreModulo()
        {
            return strNombreModulo;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            strNombreModulo = cboModulos.SelectedItem.ToString();
            
            dt = clsGestorBD.Consultar("SELECT * FROM Metadata WHERE Parent = '" + ObtenerNombreFormulario() + "'");

            if (objWizardPag2 == null)
            {
                objWizardPag2 = new frmWizardPag2(this, objConnect, item);
            }
            else
            {
                objWizardPag2.LLenarGrilla(item);
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
                item = lstFormularios[cboFormularios.SelectedIndex];
                cmdSiguiente.Enabled = true;
            }
            else
            {
                cmdSiguiente.Enabled = false;
            }
        }
    }
}
