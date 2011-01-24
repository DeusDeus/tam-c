using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ComponentesComun;
using ComponentesDatos;
using ComponentesNegocio;

namespace SpectrumSuite.Riesgos.Formularios
{
    public partial class frmPrueba : Form
    {
        private List<Control> lstControles = new List<Control>();
        int numIndicador = 0;

        public frmPrueba()
        {
            InitializeComponent();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            DataSet ds = clsNegocio.CargarFormulario(this.Name);

            numIndicador = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                clsComun.CargarControl(this, dr);
            }

            CargarPersonas();
        }

        private void CargarPersonas()
        {
            DataTable dt = clsDatos.Consultar("SELECT * FROM Prueba");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["Id"].ToString();
                string paterno = dt.Rows[i]["Paterno"].ToString();
                string materno = dt.Rows[i]["Materno"].ToString();
                string nombres = dt.Rows[i]["Nombres"].ToString();

                string[] strRow = { id, paterno, materno, nombres };

                dgvPersonas.Rows.Add(strRow);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            numIndicador = 1;
            this.tbcPersonas.SelectTab(1);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtMaterno.Clear();
            txtPaterno.Clear();
            txtNombres.Clear();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            if (ValidarVentana())
            {
                if (numIndicador == 1)
                {
                    clsComun.ActivarControl(txtPaterno);
                    clsComun.ActivarControl(txtMaterno);
                    clsComun.ActivarControl(txtNombres);

                    clsComun.CrearListaControles(this, lstControles);

                    txtPaterno.Valor = txtPaterno.Text;
                    txtMaterno.Valor = txtMaterno.Text;
                    txtNombres.Valor = txtNombres.Text;
                    txtPaterno.Nombre_Campo = "Paterno";
                    txtMaterno.Nombre_Campo = "Materno";
                    txtNombres.Nombre_Campo = "Nombres";
                    txtPaterno.Tipo_Dato = "varchar";
                    txtMaterno.Tipo_Dato = "varchar";
                    txtNombres.Tipo_Dato = "varchar";
                    txtPaterno.Tipo_Dato = "varchar";
                    txtMaterno.Tipo_Dato = "varchar";
                    txtNombres.Tipo_Dato = "varchar";
                    txtPaterno.IndicadorIdentity = "0";
                    txtMaterno.IndicadorIdentity = "0";
                    txtNombres.IndicadorIdentity = "0";
                    txtPaterno.IndicadorPK = "0";
                    txtMaterno.IndicadorPK = "0";
                    txtNombres.IndicadorPK = "0";

                    string strRutaXML = clsComun.RutaXMLEstandarizado(lstControles);

                    clsComun.DesactivarControl(txtPaterno);
                    clsComun.DesactivarControl(txtMaterno);
                    clsComun.DesactivarControl(txtNombres);

                    lstControles.Clear();

                    if (clsNegocio.EjecutarServicioEstandarizado("TRXCR11", strRutaXML, numIndicador))
                    {
                        MessageBox.Show("Se guardó la Persona satisfactoriamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Delete(strRutaXML);
                        dgvPersonas.DataMember = null;
                        CargarPersonas();
                        this.tbcPersonas.SelectTab(0);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba grabar la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lstControles.Clear();
                }
                else if (numIndicador == 2)
                {
                    clsComun.ActivarControl(lblId);
                    clsComun.ActivarControl(txtPaterno);
                    clsComun.ActivarControl(txtMaterno);
                    clsComun.ActivarControl(txtNombres);

                    clsComun.CrearListaControles(this, lstControles);
  
                    txtPaterno.Valor = txtPaterno.Text;
                    txtMaterno.Valor = txtMaterno.Text;
                    txtNombres.Valor = txtNombres.Text;
                    lblId.Nombre_Campo = "Id";
                    txtPaterno.Nombre_Campo = "Paterno";
                    txtMaterno.Nombre_Campo = "Materno";
                    txtNombres.Nombre_Campo = "Nombres";
                    lblId.Tipo_Dato = "int";
                    txtPaterno.Tipo_Dato = "varchar";
                    txtMaterno.Tipo_Dato = "varchar";
                    txtNombres.Tipo_Dato = "varchar";
                    lblId.IndicadorIdentity = "1";
                    txtPaterno.IndicadorIdentity = "0";
                    txtMaterno.IndicadorIdentity = "0";
                    txtNombres.IndicadorIdentity = "0";
                    lblId.IndicadorPK = "1";
                    txtPaterno.IndicadorPK = "0";
                    txtMaterno.IndicadorPK = "0";
                    txtNombres.IndicadorPK = "0";

                    string strRutaXML = clsComun.RutaXMLEstandarizado(lstControles);

                    clsComun.DesactivarControl(lblId);
                    clsComun.DesactivarControl(txtPaterno);
                    clsComun.DesactivarControl(txtMaterno);
                    clsComun.DesactivarControl(txtNombres);

                    lstControles.Clear();

                    if (clsNegocio.EjecutarServicioEstandarizado("TRXCR11", strRutaXML, numIndicador))
                    {
                        MessageBox.Show("Se modificó la Persona satisfactoriamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Delete(strRutaXML);
                        dgvPersonas.DataMember = null;
                        CargarPersonas();
                        this.tbcPersonas.SelectTab(0);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba modificar la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lstControles.Clear();
                }
            }
        }

        private bool ValidarVentana()
        {
            if (txtNombres.Text.Length > 0 && txtPaterno.Text.Length > 0 && txtMaterno.Text.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(this,"Todos los campos son obligatorios","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                numIndicador = 2;

                string id = dgvPersonas.Rows[dgvPersonas.CurrentRow.Index].Cells[0].Value.ToString();

                lblId.Valor = id;

                DataTable dt = clsDatos.Consultar("SELECT * FROM Prueba WHERE Id = " + id);

                LlenarFormulario(dt);

                this.tbcPersonas.SelectTab(1);
            }
        }

        private void LlenarFormulario(DataTable pdt)
        {
            txtNombres.Text = pdt.Rows[0]["Nombres"].ToString();
            txtPaterno.Text = pdt.Rows[0]["Paterno"].ToString();
            txtMaterno.Text = pdt.Rows[0]["Materno"].ToString();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                numIndicador = 3;

                string id = dgvPersonas.Rows[dgvPersonas.CurrentRow.Index].Cells[0].Value.ToString();
                
                clsComun.ActivarControl(lblId);
                clsComun.ActivarControl(txtPaterno);
                clsComun.ActivarControl(txtMaterno);
                clsComun.ActivarControl(txtNombres);

                clsComun.CrearListaControles(this, lstControles);

                lblId.Valor = id;
                txtPaterno.Valor = txtPaterno.Text;
                txtMaterno.Valor = txtMaterno.Text;
                txtNombres.Valor = txtNombres.Text;
                lblId.Nombre_Campo = "Id";
                txtPaterno.Nombre_Campo = "Paterno";
                txtMaterno.Nombre_Campo = "Materno";
                txtNombres.Nombre_Campo = "Nombres";
                lblId.Tipo_Dato = "int";
                txtPaterno.Tipo_Dato = "varchar";
                txtMaterno.Tipo_Dato = "varchar";
                txtNombres.Tipo_Dato = "varchar";
                lblId.IndicadorIdentity = "1";
                txtPaterno.IndicadorIdentity = "0";
                txtMaterno.IndicadorIdentity = "0";
                txtNombres.IndicadorIdentity = "0";
                lblId.IndicadorPK = "1";
                txtPaterno.IndicadorPK = "0";
                txtMaterno.IndicadorPK = "0";
                txtNombres.IndicadorPK = "0";

                string strRutaXML = clsComun.RutaXMLEstandarizado(lstControles);

                clsComun.DesactivarControl(lblId);
                clsComun.DesactivarControl(txtPaterno);
                clsComun.DesactivarControl(txtMaterno);
                clsComun.DesactivarControl(txtNombres);

                lstControles.Clear();

                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Persona?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    if (clsNegocio.EjecutarServicioEstandarizado("TRXCR11", strRutaXML, numIndicador))
                    {
                        MessageBox.Show("Se eliminó la Persona satisfactoriamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Delete(strRutaXML);
                        dgvPersonas.DataMember = null;
                        CargarPersonas();
                        this.tbcPersonas.SelectTab(0);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    lstControles.Clear();

                    LimpiarFormulario();

                    dgvPersonas.DataMember = null;
                    CargarPersonas();
                }
            }
        }
    }
}
