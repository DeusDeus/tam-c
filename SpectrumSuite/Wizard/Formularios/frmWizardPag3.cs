using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Wizard.Formularios
{
    public partial class frmWizardPag3 : Form
    {
        private frmWizardPag2 objWizardPag2;
        private frmWizardPag4 objWizardPag4;
        private Connect objConnect;
        private string strNombreModulo;
        private const string strServidor = "192.168.0.4";
        private const string strCatalogo = "riesgos";
        private const string strUsuario = "sa";
        private const string strContrasena = "sa";
        private int numIndicador = 0; //0:Insert, 1: Update
        private int numIndiceAnterior = 0;
        private bool blnPrimeraVez = true;

        public frmWizardPag3(Form frmWizardPag2, Connect pobjConnect)
        {
            InitializeComponent();
            objConnect = pobjConnect;
            objWizardPag2 = (frmWizardPag2)frmWizardPag2;
            strNombreModulo = objWizardPag2.ObtenerNombreModulo();
            LlenarComboServicios(strNombreModulo, "up_WISelServicio");
            LlenarComboProcedures(strNombreModulo,"up_WISelProcedimiento");
            DesactivarParametros();
        }

        private SqlConnection Conectar(string pstrUsuario, string pstrContrasena)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + "; user id = " + pstrUsuario + "; password = " + pstrContrasena + "; Trusted_Connection = FALSE";
            return cnn;
        }

        private void LlenarComboServicios(string pstrNombreModulo, string pstrNombreStoredProcedure)
        {
            DataTable dt = new DataTable();

            dt = ConsultaStoredProcedure(pstrNombreModulo, pstrNombreStoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                cboServicios.Items.Add(dr["NombreServicio"]);
            }
        }

        private void LlenarComboProcedures(string pstrNombreModulo, string pstrNombreStoredProcedure)
        {
            DataTable dt = new DataTable();

            dt = ConsultaStoredProcedure(pstrNombreModulo, pstrNombreStoredProcedure);

            foreach (DataRow dr in dt.Rows)
            {
                cboProcedures.Items.Add(dr["name"]);
            }
        }

        private void ActivarParametros()
        {
            dgvDetalleServicio.Enabled = true;
            cmdAgregar3.Enabled = true;
            cmdQuitar.Enabled = true;
            cmdGuardar.Enabled = true;
        }

        private void DesactivarParametros()
        {
            dgvDetalleServicio.Enabled = false;
            cmdAgregar3.Enabled = false;
            cmdQuitar.Enabled = false;
            cmdGuardar.Enabled = false;
        }

        private DataTable ConsultaStoredProcedure(string pstrNombreModulo, string pstrNombreStoredProcedure)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;
                
                SqlParameter sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@NombreModulo";
                sqlParametro.Value = pstrNombreModulo;
                sqlParametro.Direction = ParameterDirection.Input;
                
                sqlComando.Parameters.Add(sqlParametro);
                
                SqlDataAdapter da = new SqlDataAdapter(sqlComando);
                
                da.Fill(dt);

                cnn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }

        private bool EjecutaStoredProcedure(string pstrNombreStoredProcedure, string ptxtArchivoXML)
        {
            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParametro;

                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@vchXML";
                sqlParametro.Value = ptxtArchivoXML;
                sqlParametro.Direction = ParameterDirection.Input;

                sqlComando.Parameters.Add(sqlParametro);

                sqlComando.ExecuteNonQuery();

                cnn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
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
            if (objWizardPag4 == null)
            {
                objWizardPag4 = new frmWizardPag4(this, objConnect);
            }

            objWizardPag4.Location = this.Location;
            objWizardPag4.Visible = true;
            this.Visible = false;
        }

        private void cmdAgregar3_Click(object sender, EventArgs e)
        {
            int numNumeroFilas = dgvDetalleServicio.Rows.Count;

            if (numNumeroFilas == 0)
            {
                dgvDetalleServicio.Rows.Add();
                dgvDetalleServicio.Rows[0].Cells[0].Value = 1;
                dgvDetalleServicio.Rows[0].Cells[1].Value = "";
            }
            else
            {
                if (dgvDetalleServicio.Rows[numNumeroFilas - 1].Cells[1].Value.ToString().CompareTo("") == 0)
                {
                    MessageBox.Show("Debe ingresar el nombre del último parámetro ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDetalleServicio.Rows.Add();
                    dgvDetalleServicio.Rows[numNumeroFilas].Cells[0].Value = numNumeroFilas + 1;
                    dgvDetalleServicio.Rows[numNumeroFilas].Cells[1].Value = "";
                }
            }
        }

        private void cmdQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleServicio.Rows.Count > 0)
            {
                dgvDetalleServicio.Rows.RemoveAt(dgvDetalleServicio.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("No hay parámetros que eliminar","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private bool repetido(string pstrElemento)
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
                if (!repetido(cboServicios.SelectedItem.ToString()))
                {
                    lstServicios.Items.Add(cboServicios.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdAgregar2_Click(object sender, EventArgs e)
        {
            if (cboProcedures.SelectedIndex >= 0)
            {
                if (!repetido(cboProcedures.SelectedItem.ToString()))
                {
                    lstServicios.Items.Add(cboProcedures.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un stored procedure", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lstServicios.Items.Count > 0)
            {
                if (e.KeyChar == ((Char)Keys.Delete))
                {
                    lstServicios.Items.RemoveAt(lstServicios.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("No hay servicios que eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnPrimeraVez)
            {
                numIndiceAnterior = lstServicios.SelectedIndex;
                blnPrimeraVez = false;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Los cambios realizados no se han guardado y se perderán\n ¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    dgvDetalleServicio.Rows.Clear();
                }
                else
                {
                    blnPrimeraVez = true;
                    lstServicios.SelectedIndex = numIndiceAnterior;
                }
            }

            if (lstServicios.Items.Count > 0 && lstServicios.SelectedIndex >= 0)
            {
                if (lstServicios.SelectedItem.ToString().Substring(0, 2).CompareTo("up") == 0)
                {
                    DataTable dt = new DataTable();
                    dt = ConsultaStoredProcedure(lstServicios.SelectedItem.ToString(), "up_WISelParametro");

                    if (dt.Rows.Count > 0)
                    {
                        numIndicador = 1;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dgvDetalleServicio.Rows.Add();
                            dgvDetalleServicio.Rows[i].Cells[0].Value = i + 1;
                            dgvDetalleServicio.Rows[i].Cells[1].Value = dt.Rows[i]["NombreParametro"];
                            dgvDetalleServicio.Rows[i].Cells[2].Value = dt.Rows[i]["IdParametro"];
                        }
                    }
                    else
                    {
                        numIndicador = 0;
                    }

                    ActivarParametros();
                }
                else
                {
                    DesactivarParametros();
                }
            }
            else
            {
                DesactivarParametros();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (!Vacio())
            {
                List<clsParametro> lstParametros = new List<clsParametro>();
                for (int i = 0; i < dgvDetalleServicio.Rows.Count; i++)
                {
                    clsParametro parametro = new clsParametro();
                    parametro.StrNombreStoredProcedure = lstServicios.SelectedItem.ToString();
                    parametro.StrNombreParametro = dgvDetalleServicio.Rows[i].Cells[1].Value.ToString();
                    parametro.NumIdParametro = Int32.Parse(dgvDetalleServicio.Rows[i].Cells[2].Value.ToString());
                    
                    if (numIndicador == 0)
                    {
                        parametro.NumTipoOperacion = 0;
                    }
                    else
                    {
                        parametro.NumTipoOperacion = 1;
                    }
                    lstParametros.Add(parametro);
                }

                string strXML = Serializar(lstParametros);

                //AQUÍ EMPIEZA EL MANTENIMIENTO
                if (numIndicador == 0)
                {
                    //"INSERT"
                    EjecutaStoredProcedure("up_WIManParametro", strXML);
                }
                else
                {
                    //"UPDATE"
                    EjecutaStoredProcedure("up_WIManParametro", strXML);
                }
            }
            else
            {
                MessageBox.Show("Falta ingresar el nombre de un parámetro o no ha ingresado uno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool Vacio()
        {
            if (dgvDetalleServicio.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDetalleServicio.Rows.Count; i++)
                {
                    if (dgvDetalleServicio.Rows[i].Cells[1].Value.ToString().CompareTo("") == 0)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }

            return false;
        }

        private string Serializar(List<clsParametro> parametros)
        {
            string strXML = null;
            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(List<clsParametro>));
            XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Default);

            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(String.Empty, String.Empty);

            xs.Serialize(xtw, parametros, xsn);
            ms = (MemoryStream)xtw.BaseStream;

            UTF8Encoding encoding = new UTF8Encoding();
            strXML = encoding.GetString(ms.ToArray());

            return strXML;
        }

        private void dgvDetalleServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvDetalleServicio.Rows.Count > 0)
            {
                if (e.KeyChar == ((Char)Keys.Delete))
                {
                    dgvDetalleServicio.Rows.RemoveAt(dgvDetalleServicio.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("No hay servicios que eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
