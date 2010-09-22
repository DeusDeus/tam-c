using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using EnvDTE;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Wizard.Formularios
{
    public partial class frmWizardPag2 : Form
    {
        private frmWizardPag1 objWizardPag1;
        private frmWizardPag3 objWizardPag3 = null;
        private Connect objConnect;
        private string strNombreModulo;
        private ProjectItem item;
        private DataTable dt = new DataTable();
        private List<clsMetadata> lstMetadata = new List<clsMetadata>();

        public frmWizardPag2(Form frmWizardPag1, Connect pobjConnect, ProjectItem pitem)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            objWizardPag1 = (frmWizardPag1)frmWizardPag1;
            item = pitem;
            LLenarGrilla(item);
        }

        private void ObtenerGrilla()
        {
            lstMetadata.Clear();

            for (int i = 0; i < dgvMetadata.Rows.Count; i++)
            {
                clsMetadata objMetadata = new clsMetadata();

                for (int j = 0; j < dgvMetadata.Columns.Count; j++)
                {
                    string strNombre, strTipo, strIndVisible, strIndObligatorio, strIndCalculado, strParent, strFormula, 
                           strNombreCampoBD, strValor, strTipoDato,
                           strLongitud, strPrecision, strIO, strCalculo, strTagXML;

                    switch (j)
                    {
                        case 0:
                            strNombre = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Nombre = strNombre;
                            break;
                        case 1:
                            strTipo = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Tipo = strTipo;
                            break;
                        case 2:
                            strParent = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Parent = strParent;
                            break;
                        case 3:
                            if (((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value.ToString().CompareTo("true") == 0)
                            {
                                strIndObligatorio = "X";
                            }
                            else
                            {
                                strIndObligatorio = " ";
                            }
                            objMetadata.IndObligatorio = strIndObligatorio;
                            break;
                        case 4:
                            if (((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value.ToString().CompareTo("true") == 0)
                            {
                                strIndCalculado = "X";
                            }
                            else
                            {
                                strIndCalculado = " ";
                            }
                            objMetadata.IndCalculado = strIndCalculado;
                            break;
                        case 5:
                            if (((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value.ToString().CompareTo("true") == 0)
                            {
                                strIndVisible = "X";
                            }
                            else
                            {
                                strIndVisible = " ";
                            }
                            objMetadata.IndVisible = strIndVisible;
                            break;
                        case 6:
                            strFormula = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Formula = strFormula;
                            break;
                        case 7:
                            strNombreCampoBD = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.NombreCampoBD = strNombreCampoBD;
                            break;
                        case 8:
                            strValor = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Valor = strValor;
                            break;
                        case 9:
                            strTipoDato = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.TipoDato = strTipoDato;
                            break;
                        case 10:
                            strLongitud = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Longitud = strLongitud;
                            break;
                        case 11:
                            strPrecision = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Precision = strPrecision;
                            break;
                        case 12:
                            strIO = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Io = strIO;
                            break;
                        case 13:
                            strCalculo = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Calculo = strCalculo;
                            break;
                        case 14:
                            strTagXML = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.TagXML = strTagXML;
                            break;
                    }
                }

                lstMetadata.Add(objMetadata);
            }
        }

        private void LLenarGrilla(ProjectItem pitem)
        {
            List<String> lista = new List<string>();

            if (String.Compare(pitem.Name, "frmPlaza.cs") == 0)
            {
                dt = objWizardPag1.ObtenerTablaMetadata();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
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

                        string[] row = { pcad, tipo, parent, null, null, null, Formula, NombreCampoBD, Valor, TipoDato, Longitud, Precision, IO, Calculo, TagXML };

                        dgvMetadata.Rows.Add(row);

                        if (IndVisible.CompareTo("X") == 0)
                            ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value = true;

                        if (IndObligatorio.CompareTo("X") == 0)
                            ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[4]).Value = true;

                        if (IndCalculado.CompareTo("X") == 0)
                            ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[5]).Value = true;
                    }
                }
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

        public string Serializar()
        {
            string strXML = null;
            
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(List<clsMetadata>));
            XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Default);

            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(String.Empty, String.Empty);

            xs.Serialize(xtw, lstMetadata, xsn);
            ms = (MemoryStream)xtw.BaseStream;

            UTF8Encoding encoding = new UTF8Encoding();
            strXML = encoding.GetString(ms.ToArray());

            return strXML;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            strNombreModulo = objWizardPag1.ObtenerNombreModulo();

            ObtenerGrilla();

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
            DialogResult dr = MessageBox.Show("Si vuelve a atrás se perderán los cambios realizados hasta el momento\n¿Desea volver a atrás?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                objWizardPag3.Reset();
                this.Reset();
                objWizardPag1.Location = this.Location;
                objWizardPag1.Visible = true;
                this.Visible = false;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                objConnect.Reset();
                this.Dispose();
            }
        }

        public void Reset()
        {
            lstMetadata.Clear();
        }
    }
}
