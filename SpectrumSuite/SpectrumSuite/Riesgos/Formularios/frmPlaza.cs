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
        int estado = 0;
        
        public frmPlaza()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmPlaza_Load(object sender, EventArgs e)
        {
            DataSet ds = clsNegocio.CargarFormulario(this.Name);

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

            dsPlaza = clsNegocio.ConsultarServicio(lstControles, "TRX002");

            dgvPlaza.DataSource = dsPlaza.Tables[0];

            for (int i = 0; i < dgvPlaza.Rows.Count; i++) dgvPlaza.Columns[i].ReadOnly = true;
            
            clsComun.DesactivarControl(lblTipoLista);
            clsComun.DesactivarControl(lblCodigoPlaza);
            clsComun.DesactivarControl(lblDescripcionPlaza);
            clsComun.DesactivarControl(lblDescripcionPlazaCorta);
            lstControles.Clear();
        }

        private void CargarMonedas()
        {
            DataSet dsMonedas;

            clsComun.ActivarControl(lblTipoListaMoneda);
            clsComun.ActivarControl(lblCodigoMoneda);
            clsComun.ActivarControl(lblDescripcionMoneda);

            clsComun.CrearListaControles(this, lstControles);

            dsMonedas = clsNegocio.ConsultarServicio(lstControles, "TRX001");

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
            estado = 0;
            this.tbcPlaza.SelectTab(1);
            limpiar_formulario();
        }

        private void limpiar_formulario()
        {
            textcodigo.Text = " ";
            txtDescripcion2.Text = " ";
            textAbreviatura.Text = " ";
            cboMoneda.SelectedIndex = -1;

            dgvMoneda.Rows.Clear();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            llenar_datos();
        }

        private void llenar_datos()
        {
            if (dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value != null)
            {
                estado = 1;
                this.tbcPlaza.SelectTab(1);
                string cod = dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value.ToString();
                Plaza p = dao.getPlaza(cod);
                limpiar_formulario();
                textcodigo.Text = p.CodPlaza;
                txtDescripcion2.Text = p.DescripPlaza;
                textAbreviatura.Text = p.DescripPlazaCorta;
                for (int i = 0; i < p.listmonedas.Count; i++)
                {
                    string pcodmoneda = p.listmonedas[i].pcodmoneda;
                    string pdescripmoneda = p.listmonedas[i].pdescripmoneda;
                    string[] row = { pcodmoneda, pdescripmoneda };
                    dgvMoneda.Rows.Add(row);
                }
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlaza.Focus() == true)
            {
                if (dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value != null)
                {
                    DialogResult res = MessageBox.Show("¿Está seguro que desea borrar esta fila?", "Sistema",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        estado = 2;
                        Plaza plaza = new Plaza();
                        plaza.CodPlaza = dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[0].Value.ToString();
                        plaza.DescripPlaza = dgvPlaza.Rows[dgvPlaza.CurrentRow.Index].Cells[1].Value.ToString();

                        string stringxml = null;
                        stringxml = plaza.serializar_plaza(plaza);

                        stringxml = stringxml.Trim();

                        dao.ejecutaProcedimiento("up_CRManPlaza", "@valTipoOperacion|@vchXML", estado.ToString(), stringxml);
                        dgvPlaza.Rows.RemoveAt(dgvPlaza.CurrentRow.Index);
                    }
                }
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (dgvPlaza.Rows[0].Cells[0].Value != null)
            {
                //Cargardgv1(text_descrip_list.Text);
                CargarPlazas();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            tabPage1.Enabled = true;
            limpiar_formulario();
            //Cargardgv1("");
            CargarPlazas();
            this.tbcPlaza.SelectTab(0);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (cboMoneda.SelectedItem != null)
            {
                string cad = cboMoneda.SelectedItem.ToString();
                bool no_hay_repeticion = buscar_repeticion(cad);
                if (!(no_hay_repeticion))
                {
                    String pcodmoneda = buscar_pcodmoneda(cboMoneda.SelectedItem.ToString());
                    string[] row = { pcodmoneda, cboMoneda.SelectedItem.ToString() };
                    dgvMoneda.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("Usted ya tiene agregado este tipo de moneda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            cboMoneda.SelectedIndex = -1;
        }

        private bool buscar_repeticion(string s3)
        {
            bool s = false;
            for (int i = 0; i < dgvMoneda.Rows.Count; i++)
            {
                string s1 = dgvMoneda.Rows[i].Cells[1].Value.ToString();
                if (String.Compare(s1, s3) == 0) { s = true; break; }
            }
            return s;
        }

        public string buscar_pcodmoneda(string pal)
        {
            int i = 0;
            string s = null;
            //while (i < this.monedas.Count)
            //{
            //    if (String.Compare(monedas[i].pdescripmoneda, pal) == 0)
            //    {
            //        s = monedas[i].pcodmoneda;
            //        break;
            //    }
            //    i++;
            //}
            return s;
        }

        private void cmdEliminar2_Click(object sender, EventArgs e)
        {
            if (dgvMoneda.Focus() == true)
            {
                if (dgvMoneda.Rows.Count > 0)
                {
                    if (dgvMoneda.Rows[dgvMoneda.CurrentRow.Index].Cells[0].Value != null)
                    {
                        dgvMoneda.Rows.RemoveAt(dgvMoneda.CurrentRow.Index);
                        cboMoneda.SelectedIndex = -1;
                    }
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (textDescrip.Text.Trim().Length != 0)
            {
                tabPage1.Enabled = true;
                List<Moneda> listmonedas = new List<Moneda>();
                int i = 0;
                for (i = 0; i < dgvMoneda.Rows.Count; i++)
                {
                    Moneda moneda = new Moneda();
                    moneda.pcodmoneda = dgvMoneda.Rows[i].Cells[0].Value.ToString();
                    moneda.pdescripmoneda = dgvMoneda.Rows[i].Cells[1].Value.ToString();
                    listmonedas.Add(moneda);
                }

                Plaza plaza = new Plaza(textcodigo.Text, textDescrip.Text, textAbreviatura.Text, listmonedas);

                string stringxml = null;
                stringxml = plaza.serializar_plaza(plaza);

                stringxml = stringxml.Trim();
                //Console.WriteLine(stringxml);
                try
                {
                    dao.ejecutaProcedimiento("up_CRManPlaza", "@CodUsuario|@valTipoOperacion|@vchXML", "sa", estado.ToString(), stringxml);
                    //dao.ejecutaProcedimiento("p_CRManPlaza", "@CodUsuario|@valTipoOperacion|@vchXML", "sa", estado.ToString(), stringxml);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al momento de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    string s = "El error ocurrio en el formulario frmPlaza." + " El error fue: " + ex.Message;
                    //errores_log(s);
                }
                limpiar_formulario();
                //Cargardgv1(text_descrip_list.Text);
                CargarPlazas();
                tbcPlaza.SelectTab(0);
            }
            else
            {
                MessageBox.Show("Debe ingresar la descripción de la Plaza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textDescrip.Focus();
            }
        }
    }
}
