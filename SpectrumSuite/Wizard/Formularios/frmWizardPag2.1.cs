using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Wizard.Formularios
{
    public partial class frmWizard2Detalle : Form
    {
        private List<clsMetadataDetalle> lstMetadataDetalle = new List<clsMetadataDetalle>();
        private string strNombreControl;

        public frmWizard2Detalle(string pstrNombreControl)
        {
            InitializeComponent();
            strNombreControl = pstrNombreControl;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numContador;
            numContador = dgvMetadataDetalle.Rows.Count + 1;
            if (numContador == 1)
            {
                dgvMetadataDetalle.Rows.Add(numContador, "");
            }
            else
            {
                if (validarGrilla())
                {
                    dgvMetadataDetalle.Rows.Add(numContador, "");
                }
            }
        }

        private bool validarGrilla()
        {
            for (int i = 0; i < dgvMetadataDetalle.Rows.Count; i++)
            {
                if (dgvMetadataDetalle.Rows[i].Cells[1].Value.ToString().CompareTo("") == 0)
                {
                    return false;
                }
            }
            
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMetadataDetalle.Rows.Count > 0)
            {
                dgvMetadataDetalle.Rows.RemoveAt(dgvMetadataDetalle.CurrentRow.Index);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            clsMetadataDetalle objMetadataDetalle;
            bool blnExito = false;

            lstMetadataDetalle.Clear();

            if ((txtCabecera.Text.CompareTo("") != 0) && (dgvMetadataDetalle.Rows.Count > 0) && validarGrilla())
            {
                for (int i = 0; i < dgvMetadataDetalle.Rows.Count; i++)
                {
                    objMetadataDetalle = new clsMetadataDetalle();

                    objMetadataDetalle.StrNombreControl = strNombreControl;
                    objMetadataDetalle.StrNombreCabecera = txtCabecera.Text;
                    objMetadataDetalle.StrMetadataDetalle = dgvMetadataDetalle.Rows[i].Cells[1].Value.ToString();
                    lstMetadataDetalle.Add(objMetadataDetalle);
                }

                string strXML;

                strXML = Serializar(lstMetadataDetalle);

                if (clsGestorBD.EjecutaStoredProcedure("up_WIManMetadataDetalle", strXML))
                {
                    blnExito = true;
                }
                else
                {
                    blnExito = false;
                }

                if (blnExito)
                {
                    MessageBox.Show("Los datos se registraron exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la cabecera XML y al menos 1 Tag XML", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string Serializar(List<clsMetadataDetalle> plstMetadataDetalle)
        {
            string strXML = null;
            
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(List<clsMetadataDetalle>));
            XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Default);

            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(String.Empty, String.Empty);

            xs.Serialize(xtw, plstMetadataDetalle, xsn);
            ms = (MemoryStream)xtw.BaseStream;

            UTF8Encoding encoding = new UTF8Encoding();
            strXML = encoding.GetString(ms.ToArray());
            
            MessageBox.Show(strXML);
            return strXML;
        }
    }
}
