using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnvDTE;
using SpectrumSuite;
using ComponentesDatos;

namespace Wizard.Formularios
{
    public partial class frmWizardPag2 : Form
    {
        private frmWizardPag1 objWizardPag1;
        private frmWizardPag3 objWizardPag3 = null;
        private Connect objConnect;
        private string strNombreModulo;
        private ProjectItem item;

        public frmWizardPag2(Form frmWizardPag1, Connect pobjConnect, ProjectItem pitem)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            objWizardPag1 = (frmWizardPag1)frmWizardPag1;
            item = pitem;
            LLenarGrilla(item);
        }

        private void LLenarGrilla(ProjectItem pitem)
        {
            List<String> lista = new List<string>();

            if (String.Compare(pitem.Name, "frmPlaza.cs") == 0)
            {
                DataTable dt = new DataTable();

                dt = clsDatos.Consultar("select * from Metadata where Parent='frmPlaza'");

                //if (dt.Rows.Count>0)
                //{
                //    frmPlaza obj = new frmPlaza();
                //    llenar_lista_controles(obj, lista);
                //    llenar_filas(lista);  
                //}
                //else
                //{
                    for (int i = 0; i < dt.Rows.Count;i++ )
                    {
                        String pcad = dt.Rows[i]["Nombre"].ToString();
                        String tipo = dt.Rows[i]["Tipo"].ToString();
                        String parent = dt.Rows[i]["Parent"].ToString();
                        String IndVisible = dt.Rows[i]["IndVisible"].ToString();
                        String IndObligatorio = dt.Rows[i]["IndObligatorio"].ToString();
                        String IndCalculado = dt.Rows[i]["IndCalculado"].ToString();
                        String Formula = dt.Rows[i]["Formula"].ToString();
                        String NombreCampoBD = dt.Rows[i]["NombreCampoBD"].ToString();
                        String Valor = dt.Rows[i]["Valor"].ToString();
                        String TipoDato = dt.Rows[i]["TipoDato"].ToString();
                        String Longitud = dt.Rows[i]["Longitud"].ToString();
                        String Precision = dt.Rows[i]["Precision"].ToString();
                        String IO = dt.Rows[i]["IO"].ToString();
                        String Calculo = dt.Rows[i]["Calculo"].ToString();
                        String TagXML = dt.Rows[i]["TagXML"].ToString();

                        string[] row = {pcad,tipo,parent,null,null,null,Formula,NombreCampoBD,Valor,TipoDato,Longitud,Precision,IO,Calculo,TagXML};

                        dgvMetadata.Rows.Add(row);

                        if (IndVisible.CompareTo("X") == 0)
                            ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value = true;
                        if (IndObligatorio.CompareTo("X") == 0)
                            ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[4]).Value = true;
                        if (IndCalculado.CompareTo("X") == 0)
                            ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[5]).Value = true;
                        //dgvMetadata.Rows.Add(row);
                    }
                //}
            }
        }

        private void llenar_filas(List<string> lista)
        {
            dgvMetadata.Rows.Clear();
            int i = 0;
            while (i < lista.Count)
            {
                String pcad = lista[i];
                string[] row = { pcad};
                dgvMetadata.Rows.Add(row);
                i++;
            }
        } 

        public void llenar_lista_controles(Control ctr, List<string> lista)
        {
            if ((ctr is Form) == false)
            {
                if (string.Compare(ctr.Name, "") != 0) lista.Add(ctr.Name);
            }
            if (ctr.HasChildren)
            {
                foreach (Control ctrl in ctr.Controls) llenar_lista_controles(ctrl, lista);
            }
        }

        public string ObtenerNombreModulo()
        {
            return strNombreModulo;
        }

        public DataTable retornar_metadatos()
        {
            DataTable dt= new DataTable();
            DataRow pRow=dt.NewRow();
            for (int i = 0; i < dgvMetadata.Rows.Count; i++)
            {
                pRow[0] = dgvMetadata.Rows[i].Cells[0].Value.ToString();
                //dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value.ToString();
                //MessageBox.Show(dgvMetadata.Rows[i].Cells[0].Value.ToString());
                dt.Rows.Add(pRow);
            }
            return dt;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            strNombreModulo = objWizardPag1.ObtenerNombreModulo();

            if (objWizardPag3 == null)
            {
                objWizardPag3 = new frmWizardPag3(this, objConnect);
            }

            objWizardPag3.Location = this.Location;
            objWizardPag3.Visible = true;
            this.Visible = false;

            //retornar_metadatos();
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
                objConnect.Reset();
                this.Dispose();
            }
        }
    }
}
