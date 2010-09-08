using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentesComun;
using ComponentesNegocio;

namespace SpectrumSuite
{
    public partial class frmPlaza : Form
    {
        private List<Control> lstControles = new List<Control>();
        int numIndicador = 0;
        
        public frmPlaza()
        {
            InitializeComponent();
        }

        private void frmPlaza_Load(object sender, EventArgs e)
        {
            DataSet ds = clsNegocio.CargarFormulario(this.Name);

            numIndicador = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                clsComun.CargarControl(this, dr);
            }

            CargarPlazas();
            CargarMonedas();
        }

        private void CargarPlazas()
        {
            DataSet dsPlaza;
            
            clsComun.ActivarControl(lblTipoLista);
            clsComun.ActivarControl(lblCodigoPlaza);
            clsComun.ActivarControl(lblDescripcionPlaza);
            clsComun.ActivarControl(lblDescripcionPlazaCorta);

            clsComun.CrearListaControles(this, lstControles);

            dsPlaza = clsNegocio.ConsultarServicio(lstControles, "TRX00001");

            dgvPlaza.DataSource = dsPlaza.Tables[0];

            for (int i = 0; i < dgvPlaza.Rows.Count; i++) dgvPlaza.Rows[i].ReadOnly = true;
            
            clsComun.DesactivarControl(lblTipoLista);
            clsComun.DesactivarControl(lblCodigoPlaza);
            clsComun.DesactivarControl(lblDescripcionPlaza);
            clsComun.DesactivarControl(lblDescripcionPlazaCorta);
            lstControles.Clear();
        }

        private void CargarPlaza(string pstrCodigoPlaza)
        {
            DataSet dsPlaza;
            string strValorTipoListaAuxiliar, strValorCodigoPlazaAuxiliar;

            strValorTipoListaAuxiliar = lblTipoLista.Valor;
            strValorCodigoPlazaAuxiliar = lblCodigoPlaza.Valor;

            lblTipoLista.Valor = "1";
            lblCodigoPlaza.Valor = pstrCodigoPlaza;
            
            clsComun.ActivarControl(lblTipoLista);
            clsComun.ActivarControl(lblCodigoPlaza);
            clsComun.ActivarControl(lblDescripcionPlaza);
            clsComun.ActivarControl(lblDescripcionPlazaCorta);

            clsComun.CrearListaControles(this, lstControles);

            dsPlaza = clsNegocio.ConsultarServicio(lstControles, "TRX00001");

            txtCodigo.Text = dsPlaza.Tables[0].Rows[0]["CodPlaza"].ToString();
            txtDescripcion2.Text = dsPlaza.Tables[0].Rows[0]["DescripPlaza"].ToString();
            txtAbreviatura.Text = dsPlaza.Tables[0].Rows[0]["DescripPlazaCorta"].ToString();

            clsComun.DesactivarControl(lblTipoLista);
            clsComun.DesactivarControl(lblCodigoPlaza);
            clsComun.DesactivarControl(lblDescripcionPlaza);
            clsComun.DesactivarControl(lblDescripcionPlazaCorta);
            lstControles.Clear();

            lblTipoLista.Valor = strValorTipoListaAuxiliar;
            lblCodigoPlaza.Valor = strValorCodigoPlazaAuxiliar;

            CargarMonedasPlaza(pstrCodigoPlaza);
        }

        private void CargarMonedasPlaza(string pstrCodigoPlaza)
        {
            DataSet dsMonedas;
            string strValorTipoListaAuxiliar, strValorCodigoPlazaAuxiliar;

            strValorTipoListaAuxiliar = lblTipoLista.Valor;
            strValorCodigoPlazaAuxiliar = lblCodigoPlaza.Valor;

            lblTipoLista.Valor = "2";
            lblCodigoPlaza.Valor = pstrCodigoPlaza;

            clsComun.ActivarControl(lblTipoLista);
            clsComun.ActivarControl(lblCodigoPlaza);
            clsComun.ActivarControl(lblDescripcionPlaza);
            clsComun.ActivarControl(lblDescripcionPlazaCorta);

            clsComun.CrearListaControles(this, lstControles);

            dsMonedas = clsNegocio.ConsultarServicio(lstControles, "TRX00001");

            for (int i = 0; i < dsMonedas.Tables[0].Rows.Count; i++)
            {
                string strCodigoMoneda = dsMonedas.Tables[0].Rows[i]["CodMoneda"].ToString();
                string strDescripcionMoneda = dsMonedas.Tables[0].Rows[i]["GlsMoneda"].ToString();

                string[] strRow = { strCodigoMoneda, strDescripcionMoneda };

                dgvMoneda.Rows.Add(strRow);
            }
            
            clsComun.DesactivarControl(lblTipoLista);
            clsComun.DesactivarControl(lblCodigoPlaza);
            clsComun.DesactivarControl(lblDescripcionPlaza);
            clsComun.DesactivarControl(lblDescripcionPlazaCorta);
            lstControles.Clear();

            lblTipoLista.Valor = strValorTipoListaAuxiliar;
            lblCodigoPlaza.Valor = strValorCodigoPlazaAuxiliar;
        }

        private void CargarMonedas()
        {
            DataSet dsMonedas;

            clsComun.ActivarControl(lblTipoListaMoneda);
            clsComun.ActivarControl(lblCodigoMoneda);
            clsComun.ActivarControl(lblDescripcionMoneda);

            clsComun.CrearListaControles(this, lstControles);

            dsMonedas = clsNegocio.ConsultarServicio(lstControles, "TRX00002");

            foreach (DataRow dr in dsMonedas.Tables[0].Rows)
            {
                cboMoneda.Items.Add(dr["DescripMoneda"]);
            }

            if (cboMoneda.Items.Count > 0) cboMoneda.SelectedIndex = 0;

            clsComun.DesactivarControl(lblTipoListaMoneda);
            clsComun.DesactivarControl(lblCodigoMoneda);
            clsComun.DesactivarControl(lblDescripcionMoneda);
            lstControles.Clear();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtDescripcion2.Clear();
            txtAbreviatura.Clear();
            if (cboMoneda.Items.Count > 0) cboMoneda.SelectedIndex = 0;

            dgvMoneda.Rows.Clear();
        }

        private void LlenarDatos()
        {
            if (dgvPlaza.CurrentRow != null)
            {
                string strCodigoPlaza;

                numIndicador = 1;
                strCodigoPlaza = dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value.ToString();
                this.tbcPlaza.SelectTab(1);
                CargarPlaza(strCodigoPlaza);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una plaza", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool BuscarRepeticion(string pstrDescripcionMoneda)
        {
            bool blnRepetido = false;
            for (int i = 0; i < dgvMoneda.Rows.Count; i++)
            {
                string strDescripcionMoneda = dgvMoneda.Rows[i].Cells[1].Value.ToString();
                if (String.Compare(strDescripcionMoneda, pstrDescripcionMoneda) == 0) { blnRepetido = true; break; }
            }
            return blnRepetido;
        }

        public string BuscarCodigoMoneda(string pstrDescripcionMoneda)
        {
            string strCodigoMoneda = "";
            string strValorTipoListaAuxiliar, strValorDescripcionMonedaAuxiliar;

            DataSet dsMonedas;

            strValorTipoListaAuxiliar = lblTipoListaMoneda.Valor;
            strValorDescripcionMonedaAuxiliar = lblDescripcionMoneda.Valor;

            lblTipoListaMoneda.Valor = "3";
            lblDescripcionMoneda.Valor = pstrDescripcionMoneda;

            clsComun.ActivarControl(lblTipoListaMoneda);
            clsComun.ActivarControl(lblCodigoMoneda);
            clsComun.ActivarControl(lblDescripcionMoneda);

            clsComun.CrearListaControles(this, lstControles);

            dsMonedas = clsNegocio.ConsultarServicio(lstControles, "TRX00002");

            strCodigoMoneda = dsMonedas.Tables[0].Rows[0]["CodMoneda"].ToString();

            clsComun.DesactivarControl(lblTipoListaMoneda);
            clsComun.DesactivarControl(lblCodigoMoneda);
            clsComun.DesactivarControl(lblDescripcionMoneda);

            lblTipoListaMoneda.Valor = strValorTipoListaAuxiliar;
            lblDescripcionMoneda.Valor = strValorDescripcionMonedaAuxiliar;
            lstControles.Clear();

            return strCodigoMoneda;
        }

        private void tbcPlaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPlaza.SelectedIndex == 1)
            {
                tabPage1.Enabled = false;
                this.cmdBuscar.Visible = false;
                this.cmdEliminar.Visible = false;
                this.cmdNuevo.Visible = false;
                this.cmdModificar.Visible = false;
                //llenar_datos();
            }
            else
            {
                this.cmdBuscar.Visible = true;
                this.cmdEliminar.Visible = true;
                this.cmdNuevo.Visible = true;
                this.cmdModificar.Visible = true;
            }
        }

        private void tbcPlaza_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            numIndicador = 0;
            this.tbcPlaza.SelectTab(1);
            LimpiarFormulario();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlaza.Rows.Count > 0)
            {
                numIndicador = 2;

                clsComun.ActivarControlXML(txtCodigo);
                clsComun.ActivarControlXML(txtDescripcion2);
                clsComun.ActivarControlXML(txtAbreviatura);
                clsComun.ActivarControlXML(dgvMoneda);

                clsComun.CrearListaControlesXML(this, lstControles);

                txtCodigo.Valor = dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion2.Valor = txtDescripcion2.Text;
                txtAbreviatura.Valor = txtAbreviatura.Text;
                lblTipoOperacion.Valor = numIndicador.ToString();
                lblArchivoXML.Valor = clsComun.RutaXML(lstControles, lblCabecera.NombreTagXML);
                lblArchivoXML.Tipo_Dato = "xml";

                clsComun.DesactivarControlXML(txtCodigo);
                clsComun.DesactivarControlXML(txtDescripcion2);
                clsComun.DesactivarControlXML(txtAbreviatura);
                clsComun.DesactivarControlXML(dgvMoneda);

                lstControles.Clear();

                clsComun.ActivarControl(lblTipoOperacion);
                clsComun.ActivarControl(lblCodigoUsuario);
                clsComun.ActivarControl(lblArchivoXML);

                clsComun.CrearListaControles(this, lstControles);

                clsComun.DesactivarControl(lblTipoOperacion);
                clsComun.DesactivarControl(lblCodigoUsuario);
                clsComun.DesactivarControl(lblArchivoXML);

                if (clsNegocio.EjecutarServicio(lstControles, "TRX00003"))
                {
                    MessageBox.Show("Se eliminó la Plaza satisfactoriamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la Plaza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lstControles.Clear();
            }
            else
            {
                MessageBox.Show("No existen plazas a eliminar", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            CargarPlazas();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string strValorDescripcionPlazaAuxiliar;

            strValorDescripcionPlazaAuxiliar = lblDescripcionPlaza.Valor;

            lblDescripcionPlaza.Valor = txtDescripcion.Text;

            CargarPlazas();

            lblDescripcionPlaza.Valor = strValorDescripcionPlazaAuxiliar;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (cboMoneda.SelectedItem != null)
            {
                string strDescripcionMoneda = cboMoneda.SelectedItem.ToString();
                bool blnRepetido = BuscarRepeticion(strDescripcionMoneda);
                if (!(blnRepetido))
                {
                    String strCodigoMoneda = BuscarCodigoMoneda(cboMoneda.SelectedItem.ToString());
                    string[] row = { strCodigoMoneda, cboMoneda.SelectedItem.ToString() };
                    dgvMoneda.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("Usted ya tiene agregado este tipo de moneda", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            cboMoneda.SelectedIndex = 0;
        }

        private void cmdEliminar2_Click(object sender, EventArgs e)
        {
            if (dgvMoneda.Rows.Count > 0)
            {
                dgvMoneda.Rows.RemoveAt(dgvMoneda.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("No hay monedas para eliminar", "Mensaje de Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            tabPage1.Enabled = true;
            LimpiarFormulario();
            CargarPlazas();
            this.tbcPlaza.SelectTab(0);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarVentana())
            {
                clsComun.ActivarControlXML(txtCodigo);
                clsComun.ActivarControlXML(txtDescripcion2);
                clsComun.ActivarControlXML(txtAbreviatura);
                clsComun.ActivarControlXML(dgvMoneda);

                clsComun.CrearListaControlesXML(this, lstControles);

                txtCodigo.Valor = txtCodigo.Text;
                txtDescripcion2.Valor = txtDescripcion2.Text;
                txtAbreviatura.Valor = txtAbreviatura.Text;
                lblTipoOperacion.Valor = numIndicador.ToString();
                lblArchivoXML.Valor = clsComun.RutaXML(lstControles, lblCabecera.NombreTagXML);
                lblArchivoXML.Tipo_Dato = "xml";

                clsComun.DesactivarControlXML(txtCodigo);
                clsComun.DesactivarControlXML(txtDescripcion2);
                clsComun.DesactivarControlXML(txtAbreviatura);
                clsComun.DesactivarControlXML(dgvMoneda);

                lstControles.Clear();

                clsComun.ActivarControl(lblTipoOperacion);
                clsComun.ActivarControl(lblCodigoUsuario);
                clsComun.ActivarControl(lblArchivoXML);

                clsComun.CrearListaControles(this, lstControles);

                clsComun.DesactivarControl(lblTipoOperacion);
                clsComun.DesactivarControl(lblCodigoUsuario);
                clsComun.DesactivarControl(lblArchivoXML);

                if (clsNegocio.EjecutarServicio(lstControles, "TRX00003"))
                {
                    MessageBox.Show("Se guardó la Plaza satisfactoriamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error mientras se intentaba grabar la Plaza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lstControles.Clear();
            }
        }

        private bool ValidarVentana()
        {
            return true;
        } 
    }
}
