﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Wizard.Formularios
{
    public partial class frmWizardPag3 : Form
    {
        private frmWizardPag2 objWizardPag2;
        private frmWizardPag4 objWizardPag4;
        private Connect objConnect;
        private string strNombreModulo;
        private string strNombreServicio;
        private bool blnGuardado = true;
        private bool blnCambio = false;
        private int numIndicador = 0; //0: nuevo; 1: modificar
        private List<clsParametro> lstParametros = new List<clsParametro>();

        public frmWizardPag3(Form frmWizardPag2, Connect pobjConnect)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            objWizardPag2 = (frmWizardPag2)frmWizardPag2;
            strNombreModulo = objWizardPag2.ObtenerNombreModulo();
            cmdGuardar.Enabled = false;
            LlenarComboServicios(strNombreModulo, "up_WISelServicio");
            LlenarComboProcedures(strNombreModulo,"up_WISelProcedimiento");
        }

        private void LlenarComboServicios(string pstrNombreModulo, string pstrNombreStoredProcedure)
        {
            DataTable dt = new DataTable();

            dt = clsGestorBD.ConsultaStoredProcedure(pstrNombreModulo, pstrNombreStoredProcedure, 1);

            foreach (DataRow dr in dt.Rows)
            {
                cboServicios.Items.Add(dr["NombreServicio"]);
            }
        }

        private void LlenarComboProcedures(string pstrNombreModulo, string pstrNombreStoredProcedure)
        {
            DataTable dt = new DataTable();

            dt = clsGestorBD.ConsultaStoredProcedure(pstrNombreModulo, pstrNombreStoredProcedure, 1);

            foreach (DataRow dr in dt.Rows)
            {
                cboProcedures.Items.Add(dr["name"]);
            }
        }

        private bool Repetido(string pstrElemento)
        {
            for (int i = 0; i < lstServicios.Items.Count; i++)
            {
                if (lstServicios.Items[i].ToString().CompareTo(pstrElemento) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (cboServicios.SelectedIndex >= 0)
            {
                if (!Repetido(cboServicios.SelectedItem.ToString()))
                {
                    if (cboServicios.SelectedItem.ToString().CompareTo(strNombreServicio) != 0)
                    {
                        blnCambio = true;
                        blnGuardado = false;

                        if (numIndicador == 1) cmdGuardar.Enabled = true;
                        lstServicios.Items.Add(cboServicios.SelectedItem.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Este servicio ya ha sido agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un servicio","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cmdAgregar2_Click(object sender, EventArgs e)
        {
            if (cboProcedures.SelectedIndex >= 0)
            {
                if (!Repetido(cboProcedures.SelectedItem.ToString()))
                {
                    blnCambio = true;
                    blnGuardado = false;
                    if (numIndicador == 1) cmdGuardar.Enabled = true;
                    lstServicios.Items.Add(cboProcedures.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Este stored procedure ya ha sido agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un stored procedure", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdQuitar_Click(object sender, EventArgs e)
        {
            if (lstServicios.SelectedIndex >= 0)
            {
                blnCambio = true;
                blnGuardado = false;
                if (numIndicador == 1) cmdGuardar.Enabled = true;
                lstServicios.Items.RemoveAt(lstServicios.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un servicio a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string Serializar(List<clsParametro> plstParametros)
        {
            try
            {
                string strXML = null;
                MemoryStream ms = new MemoryStream();
                XmlSerializer xs = new XmlSerializer(typeof(List<clsParametro>));
                XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Default);

                XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
                xsn.Add(String.Empty, String.Empty);

                xs.Serialize(xtw, plstParametros, xsn);
                ms = (MemoryStream)xtw.BaseStream;

                UTF8Encoding encoding = new UTF8Encoding();
                strXML = encoding.GetString(ms.ToArray());

                return strXML;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;
            }
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
                objConnect.Reset();
                this.Dispose();
            }
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            lstParametros.Clear();
            clsParametro objParametro;
            bool blnExito = false;

            if (numIndicador == 0)
            {
                if (lstServicios.Items.Count > 0)
                {
                    for (int i = 0; i < lstServicios.Items.Count; i++)
                    {
                        objParametro = new clsParametro();

                        objParametro.StrNombreServicio = "";
                        objParametro.StrNombreParametro = lstServicios.Items[i].ToString();

                        if (lstServicios.Items[i].ToString().Substring(0, 1).CompareTo("T") == 0)
                        {
                            objParametro.ChrTipoServicio = "N";
                        }
                        else
                        {
                            objParametro.ChrTipoServicio = "B";
                        }

                        objParametro.NumTipoOperacion = numIndicador;

                        objParametro.NumOrden = i + 1;

                        lstParametros.Add(objParametro);
                    }
                    
                    string strXML = this.Serializar(lstParametros);

                    if (clsGestorBD.EjecutaStoredProcedure("up_WIManServicio", strXML))
                    {
                        blnExito = true;
                    }
                    else
                    {
                        blnExito = false;
                    }
                }
                else
                {
                    lstParametros.Clear();
                    //MessageBox.Show("No hay cambio");
                }
            }

            //MessageBox.Show("PASO");

            if (objWizardPag2.numIndicador == 0 || objWizardPag2.numIndicador == 1)
            {
                List<clsMetadata> lstMetadata = new List<clsMetadata>();
                
                lstMetadata = objWizardPag2.ObtenerListaMetadata();
                //MessageBox.Show(lstMetadata.Count+"");
                string strXML = objWizardPag2.Serializar(lstMetadata);
                
                //MessageBox.Show(strXML);
                
                if (clsGestorBD.EjecutaStoredProcedure("up_WIManMetadata", strXML))
                {
                    blnExito = true;
                }
                else
                {
                    blnExito = false;
                }
            }
            else
            {

            }

            if (blnExito)
            {
                if (objWizardPag4 == null)
                {
                    objWizardPag4 = new frmWizardPag4(this, objConnect);
                }

                objWizardPag4.Location = this.Location;
                objWizardPag4.Visible = true;
                this.Visible = false;
            }
        }

        private void cmdVer_Click(object sender, EventArgs e)
        {
            numIndicador = 1;

            if (cboServicios.SelectedIndex >= 0)
            {
                if (lblServicio.Text.CompareTo("") == 0)
                {
                    DataTable dt = new DataTable();

                    dt = clsGestorBD.ConsultaStoredProcedure(cboServicios.SelectedItem.ToString(), "up_WISelServicio", 2);

                    lstServicios.Items.Clear();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lstServicios.Items.Add(dt.Rows[i]["NombreServicio"]);
                    }

                    lblServicio.Text = cboServicios.SelectedItem.ToString();
                    strNombreServicio = cboServicios.SelectedItem.ToString();
                }
                else
                {
                    if (blnGuardado)
                    {
                        DataTable dt = new DataTable();

                        dt = clsGestorBD.ConsultaStoredProcedure(cboServicios.SelectedItem.ToString(), "up_WISelServicio", 2);

                        lstServicios.Items.Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lstServicios.Items.Add(dt.Rows[i]["NombreServicio"]);
                        }

                        lblServicio.Text = cboServicios.SelectedItem.ToString();
                        strNombreServicio = cboServicios.SelectedItem.ToString();
                    }

                    if (lblServicio.Text.CompareTo(cboServicios.SelectedItem.ToString()) == 0)
                    {
                        //No hace nada porque está en el servicio actual
                    }
                    else
                    {
                        if (blnCambio && !blnGuardado)
                        {
                            DialogResult dr = MessageBox.Show("Hay cambios realizados que no han sido guardados y se perderán\n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (dr == DialogResult.Yes)
                            {
                                blnGuardado = true;
                                blnCambio = false;
                                lstServicios.Items.Clear();
                                DataTable dt = new DataTable();

                                dt = clsGestorBD.ConsultaStoredProcedure(cboServicios.SelectedItem.ToString(), "up_WISelServicio", 2);

                                lstServicios.Items.Clear();

                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    lstServicios.Items.Add(dt.Rows[i]["NombreServicio"]);
                                }
                                lblServicio.Text = cboServicios.SelectedItem.ToString();
                                strNombreServicio = cboServicios.SelectedItem.ToString();
                                cmdGuardar.Enabled = false;
                            }
                        }
                        else
                        {
                            lblServicio.Text = cboServicios.SelectedItem.ToString();
                            strNombreServicio = cboServicios.SelectedItem.ToString();
                        }
                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            lstParametros.Clear();
            clsParametro objParametro;
            bool blnExito = false;

            for (int i = 0; i < lstServicios.Items.Count; i++)
            {
                objParametro = new clsParametro();

                objParametro.StrNombreServicio = lblServicio.Text.ToString();
                objParametro.StrNombreParametro = lstServicios.Items[i].ToString();

                if (lstServicios.Items[i].ToString().Substring(0, 1).CompareTo("T") == 0)
                {
                    objParametro.ChrTipoServicio = "N";
                }
                else
                {
                    objParametro.ChrTipoServicio = "B";
                }

                objParametro.NumTipoOperacion = numIndicador;

                objParametro.NumOrden = i + 1;

                lstParametros.Add(objParametro);
            }

            string strXML = this.Serializar(lstParametros);

            MessageBox.Show(strXML);

            if (clsGestorBD.EjecutaStoredProcedure("up_WIManServicio", strXML))
            {
                blnExito = true;
            }
            else
            {
                blnExito = false;
            }

            if (blnExito)
            {
                MessageBox.Show("Los cambios se guardaron exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blnGuardado = true;
                cmdGuardar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al tratar de guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            if (!blnGuardado)
            {
                DialogResult dr = MessageBox.Show("Hay cambios realizados que no han sido guardados y se perderán\n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    numIndicador = 0;
                    cboProcedures.SelectedIndex = -1;
                    cboServicios.SelectedIndex = -1;
                    lblServicio.Text = "";
                    strNombreServicio = "";
                    lstServicios.Items.Clear();
                    cmdGuardar.Enabled = false;
                }
            }
            else
            {
                numIndicador = 0;
                cboProcedures.SelectedIndex = -1;
                cboServicios.SelectedIndex = -1;
                lblServicio.Text = "";
                strNombreServicio = "";
                lstServicios.Items.Clear();
                cmdGuardar.Enabled = false;
            }
        }

        private void lstServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstServicios.Items.Count == 0)
            {
                cmdGuardar.Enabled = false;
            }
        }

        public void Reset()
        {
            lstParametros.Clear();
            cboProcedures.SelectedIndex = -1;
            cboServicios.SelectedIndex = -1;
            lblServicio.Text = "";
            lstServicios.Items.Clear();
            numIndicador = 0;
        }
    }
}
