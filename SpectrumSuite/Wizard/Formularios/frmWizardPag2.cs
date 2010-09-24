﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ComponentesGUI;
using EnvDTE;
using SpectrumSuite.Riesgos.Formularios;

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
        private List<Control> lstControles = new List<Control>();

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
            clsMetadata objMetadata;

            lstMetadata.Clear();

            for (int i = 0; i < dgvMetadata.Rows.Count - 1; i++)
            {
                objMetadata = new clsMetadata();

                for (int j = 0; j < dgvMetadata.Columns.Count - 1; j++)
                {
                    string strNombre, strTipo, strIndVisible, strIndObligatorio, strIndCalculado, strParent, strFormula, 
                           strNombreCampoBD, strValor, strTipoDato,
                           strLongitud, strPrecision, strIO, strCalculo, strTagXML;
                    switch (j)
                    {
                        case 0:
                            strNombre = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Nombre = strNombre;
                            //MessageBox.Show(strNombre);
                            break;
                        case 1:
                            strTipo = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Tipo = strTipo;
                            //MessageBox.Show(strTipo);
                            break;
                        case 2:
                            strParent = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Parent = strParent;
                            //MessageBox.Show(strParent);
                            break;
                        case 3:
                            //MessageBox.Show(((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value + "");

                            if ((bool)((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value)
                            {
                                strIndVisible = "X";
                            }
                            else
                            {
                                strIndVisible = " ";
                            }
                            objMetadata.IndVisible = strIndVisible;
                            //MessageBox.Show(strIndVisible);
                            break;
                        case 4:
                            //MessageBox.Show(((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[4]).Value + "");

                            if ((bool)((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[4]).Value)
                            {
                                strIndObligatorio = "X";
                            }
                            else
                            {
                                strIndObligatorio = " ";
                            }
                            objMetadata.IndObligatorio = strIndObligatorio;
                            //MessageBox.Show(strIndObligatorio);
                            break;
                        case 5:
                            if ((bool)((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[5]).Value)
                            {
                                strIndCalculado = "X";
                            }
                            else
                            {
                                strIndCalculado = " ";
                            }
                            objMetadata.IndCalculado = strIndCalculado;
                            //MessageBox.Show(strIndCalculado);
                            break;
                        case 6:
                            strFormula = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Formula = strFormula;
                            //MessageBox.Show(strFormula);
                            break;
                        case 7:
                            strNombreCampoBD = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.NombreCampoBD = strNombreCampoBD;
                            //MessageBox.Show(strNombreCampoBD);
                            break;
                        case 8:
                            strValor = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Valor = strValor;
                            //MessageBox.Show(strValor);
                            break;
                        case 9:
                            strTipoDato = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.TipoDato = strTipoDato;
                            //MessageBox.Show(strTipoDato);
                            break;
                        case 10:
                            strLongitud = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Longitud = strLongitud;
                            //MessageBox.Show(strLongitud);
                            break;
                        case 11:
                            strPrecision = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Precision = strPrecision;
                           //MessageBox.Show(strPrecision);
                            break;
                        case 12:
                            strIO = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Io = strIO;
                            //MessageBox.Show(strIO);
                            break;
                        case 13:
                            strCalculo = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.Calculo = strCalculo;
                            //MessageBox.Show(strCalculo);
                            break;
                        case 14:
                            strTagXML = dgvMetadata.Rows[i].Cells[j].Value.ToString();
                            objMetadata.TagXML = strTagXML;
                            //MessageBox.Show(strTagXML);
                            break;
                    }
                }

                lstMetadata.Add(objMetadata);
            }
        }

        public void LLenarGrilla(ProjectItem pitem)
        {
           dgvMetadata.Rows.Clear();

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
                   {
                       ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value = true;
                   }
                   else
                   {
                       ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[3]).Value = false;
                   }

                   if (IndObligatorio.CompareTo("X") == 0)
                   {
                       ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[4]).Value = true;
                   }
                   else
                   {
                       ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[4]).Value = false;
                   }

                   if (IndCalculado.CompareTo("X") == 0)
                   {
                       ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[5]).Value = true;
                   }
                   else
                   {
                       ((DataGridViewCheckBoxCell)dgvMetadata.Rows[i].Cells[5]).Value = false;
                   }
               }
           }
           else
           {
              CrearListaControles(new frmPrueba(),lstControles);
              LLenar_filas(lstControles);
           }
        }

        private void LLenar_filas(List<Control> lista)
        {
            dgvMetadata.Rows.Clear();

            for (int i = 0; i < lstControles.Count; i++)
            {
                String strNombreControl = lista[i].Name;
                dgvMetadata.Rows.Add();
                dgvMetadata.Rows[i].Cells[0].Value = strNombreControl;
                dgvMetadata.Rows[i].Cells[2].Value = objWizardPag1.ObtenerNombreFormulario();
                dgvMetadata.Rows[i].Cells[14].Value = "";
            }
        }

        public static void CrearListaControles(Control pctr, List<Control> pstrControles)
        {
            if (pctr is ucButton)
            {
                pstrControles.Add(pctr);
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    pstrControles.Add(pctr);
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        pstrControles.Add(pctr);
                    }
                    else
                    {
                        if (pctr is ucDataGridView)
                        {
                            pstrControles.Add(pctr);
                        }
                        else
                        {
                            if (pctr is ucDateTimePicker)
                            {
                                pstrControles.Add(pctr);
                            }
                            else
                            {
                                if (pctr is ucLabel)
                                {
                                    pstrControles.Add(pctr);
                                }
                                else
                                {
                                    if (pctr is ucTextBox)
                                    {
                                        pstrControles.Add(pctr);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (pctr.HasChildren)
            {
                foreach (Control ctr in pctr.Controls)
                {
                    CrearListaControles(ctr, pstrControles);
                }
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

        private bool ValidarGrilla()
        {
            for (int i = 0; i < dgvMetadata.Rows.Count; i++)
            {
                if (dgvMetadata.Rows[i].Cells[2].Value == null)
                {
                    return false;
                }
                if (dgvMetadata.Rows[i].Cells[9].Value == null)
                {
                    return false;
                }
            }

            return true;
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            strNombreModulo = objWizardPag1.ObtenerNombreModulo();

            if (ValidarGrilla())
            {
                this.ObtenerGrilla();

                if (objWizardPag3 == null)
                {
                    objWizardPag3 = new frmWizardPag3(this, objConnect);
                }

                objWizardPag3.Location = this.Location;
                objWizardPag3.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Falta(n) ingresar algun(os) dato(s) obligatorio(s)","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Si vuelve a atrás se perderán los cambios realizados hasta el momento\n¿Desea volver a atrás?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                
                //objWizardPag3.Reset();
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
