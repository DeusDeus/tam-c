using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace AdministradorTablas
{
    public partial class frmPrueba : Form
    {
        private bool blnIndicador = true;
        private string nombreTabla = "";
        private string nombreSP = "";
        private string nombreTrigger = "";

        public frmPrueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blnIndicador = true;
            dgvAtributos.Rows.Add("", "char", "", false, "null");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAtributos.RowCount > 0)
            {
                dgvAtributos.Rows.RemoveAt(dgvAtributos.CurrentRow.Index);
            }
        }

        private void dgvAtributos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAtributos.RowCount > 0)
            {
                if ((dgvAtributos.CurrentRow.Cells[1].Value.ToString().CompareTo("char") == 0) ||
                    (dgvAtributos.CurrentRow.Cells[1].Value.ToString().CompareTo("float") == 0) ||
                    (dgvAtributos.CurrentRow.Cells[1].Value.ToString().CompareTo("varchar") == 0))
                {
                    dgvAtributos.CurrentRow.Cells[2].ReadOnly = false;
                }
                else
                {
                    dgvAtributos.CurrentRow.Cells[2].Value = "";
                    dgvAtributos.CurrentRow.Cells[2].ReadOnly = true;
                }

                if (dgvAtributos.CurrentRow.Cells[3].Value.ToString().CompareTo("True") == 0)
                {
                    if (blnIndicador)
                    {
                        dgvAtributos.CurrentRow.Cells[4].Value = "not null";
                        blnIndicador = false;
                    }
                    else
                    {
                        if (dgvAtributos.CurrentRow.Cells[4].Value.ToString().CompareTo("null") == 0)
                        {
                            MessageBox.Show("No puede asignarle el valor 'null' a una llave primaria (PK)");
                            dgvAtributos.CurrentRow.Cells[4].Value = "not null";
                        }
                    }   
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvAtributos.CurrentRow.Index > 0)
            {
                string strNombreAtributo, strTipoDato, strTamano, strPK, strNulidad;
                int numIndiceActual;

                strNombreAtributo = dgvAtributos.CurrentRow.Cells[0].Value.ToString();
                strTipoDato = dgvAtributos.CurrentRow.Cells[1].Value.ToString();
                strTamano = dgvAtributos.CurrentRow.Cells[2].Value.ToString();
                strPK = dgvAtributos.CurrentRow.Cells[3].Value.ToString();
                strNulidad = dgvAtributos.CurrentRow.Cells[4].Value.ToString();
                numIndiceActual = dgvAtributos.CurrentRow.Index;

                dgvAtributos.CurrentRow.Cells[0].Value = dgvAtributos.Rows[numIndiceActual - 1].Cells[0].Value;
                dgvAtributos.CurrentRow.Cells[1].Value = dgvAtributos.Rows[numIndiceActual - 1].Cells[1].Value;
                dgvAtributos.CurrentRow.Cells[2].Value = dgvAtributos.Rows[numIndiceActual - 1].Cells[2].Value;
                dgvAtributos.CurrentRow.Cells[3].Value = dgvAtributos.Rows[numIndiceActual - 1].Cells[3].Value;
                dgvAtributos.CurrentRow.Cells[4].Value = dgvAtributos.Rows[numIndiceActual - 1].Cells[4].Value;

                dgvAtributos.Rows[numIndiceActual - 1].Cells[0].Value = strNombreAtributo;
                dgvAtributos.Rows[numIndiceActual - 1].Cells[1].Value = strTipoDato;
                dgvAtributos.Rows[numIndiceActual - 1].Cells[2].Value = strTamano;
                dgvAtributos.Rows[numIndiceActual - 1].Cells[3].Value = strPK;
                dgvAtributos.Rows[numIndiceActual - 1].Cells[4].Value = strNulidad;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvAtributos.CurrentRow.Index < (dgvAtributos.RowCount - 1))
            {
                string strNombreAtributo, strTipoDato, strTamano, strPK, strNulidad;
                int numIndiceActual;

                strNombreAtributo = dgvAtributos.CurrentRow.Cells[0].Value.ToString();
                strTipoDato = dgvAtributos.CurrentRow.Cells[1].Value.ToString();
                strTamano = dgvAtributos.CurrentRow.Cells[2].Value.ToString();
                strPK = dgvAtributos.CurrentRow.Cells[3].Value.ToString();
                strNulidad = dgvAtributos.CurrentRow.Cells[4].Value.ToString();
                numIndiceActual = dgvAtributos.CurrentRow.Index;

                dgvAtributos.CurrentRow.Cells[0].Value = dgvAtributos.Rows[numIndiceActual + 1].Cells[0].Value;
                dgvAtributos.CurrentRow.Cells[1].Value = dgvAtributos.Rows[numIndiceActual + 1].Cells[1].Value;
                dgvAtributos.CurrentRow.Cells[2].Value = dgvAtributos.Rows[numIndiceActual + 1].Cells[2].Value;
                dgvAtributos.CurrentRow.Cells[3].Value = dgvAtributos.Rows[numIndiceActual + 1].Cells[3].Value;
                dgvAtributos.CurrentRow.Cells[4].Value = dgvAtributos.Rows[numIndiceActual + 1].Cells[4].Value;

                dgvAtributos.Rows[numIndiceActual + 1].Cells[0].Value = strNombreAtributo;
                dgvAtributos.Rows[numIndiceActual + 1].Cells[1].Value = strTipoDato;
                dgvAtributos.Rows[numIndiceActual + 1].Cells[2].Value = strTamano;
                dgvAtributos.Rows[numIndiceActual + 1].Cells[3].Value = strPK;
                dgvAtributos.Rows[numIndiceActual + 1].Cells[4].Value = strNulidad;
            }
        }

        private bool ValidarGrilla()
        {
            bool existePK = false;

            for (int i = 0; i < dgvAtributos.Rows.Count; i++)
            {
                if (dgvAtributos.Rows[i].Cells[0].Value.ToString().CompareTo("") == 0)
                {
                    return false;
                }
                switch (dgvAtributos.Rows[i].Cells[1].Value.ToString())
                {
                    case "char":
                        if (dgvAtributos.Rows[i].Cells[2].Value.ToString().CompareTo("") == 0)
                        {
                            return false;
                        }
                        break;
                    case "float":
                        if (dgvAtributos.Rows[i].Cells[2].Value.ToString().CompareTo("") == 0)
                        {
                            return false;
                        }
                        break;
                    case "int":
                        if (dgvAtributos.Rows[i].Cells[2].Value.ToString().CompareTo("") != 0)
                        {
                            return false;
                        }
                        break;
                    case "varchar":
                        if (dgvAtributos.Rows[i].Cells[2].Value.ToString().CompareTo("") == 0)
                        {
                            return false;
                        }
                        break;
                }
                if (((bool)dgvAtributos.Rows[i].Cells[3].Value) == true)
                {
                    existePK = true;
                }
            }

            if (existePK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.CompareTo("") != 0)
            {
                if (dgvAtributos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe ingresar los atributos de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ValidarGrilla())
                    {
                        try
                        {
                            List<clsAtributo> lstAtributos = new List<clsAtributo>();

                            for (int i = 0; i < dgvAtributos.Rows.Count; i++)
                            {
                                clsAtributo objAtributo = new clsAtributo();

                                objAtributo.NombreAtributo = dgvAtributos.Rows[i].Cells[0].Value.ToString();
                                objAtributo.TipoDato = dgvAtributos.Rows[i].Cells[1].Value.ToString();
                                objAtributo.Tamano = dgvAtributos.Rows[i].Cells[2].Value.ToString();
                                
                                lstAtributos.Add(objAtributo);
                            }

                            if (clsGestorBD.CrearTabla(txtNombre.Text, dgvAtributos)) //Crea la Tabla
                            {
                                nombreTabla = txtNombre.Text;

                                if (cbxAuditoria.Checked)
                                {
                                    clsGestorBD.CrearTriggerTabla(txtNombre.Text);

                                    nombreTrigger = "tA_" + nombreTabla;
                                }

                                if (cbxStoredProcedure.Checked)
                                {
                                    nombreSP = "up_Man" + txtNombre.Text;

                                    clsGestorBD.CrearStoredProcedure(nombreSP, txtNombre.Text);
                                }

                                clsGestorBD.GuardarMetadata(nombreTabla, nombreSP, nombreTrigger);

                                DialogResult dr = MessageBox.Show("Se creó la tabla " + txtNombre.Text + " satisfactoriamente\n" + "¿Desea crear otra tabla?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (dr == DialogResult.Yes)
                                {
                                    dgvAtributos.DataMember = null;
                                }
                                else
                                {
                                    this.Dispose();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un Error\nVerifique los tipos de dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Faltan datos\n- Verifique que haya ingresado todos los datos\n- Verifique que exista al menos 1 Primary Key (PK)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (txtNombre.Text.Length == 0)
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
                }
                e.Handled = false;
            }
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            DataTable dt = clsGestorBD.CargarMetadata(null);

            foreach (DataRow dr in dt.Rows)
            {
                string strNombre = dr["NombreTabla"].ToString();
                string strNombreSP = dr["NombreSP"].ToString();
                bool blnSP = false;
                bool blnTrigger = false;

                if (dr["NombreSP"].ToString().CompareTo("") != 0)
                {
                    blnSP = true;
                }

                if (dr["NombreTrigger"].ToString().CompareTo("") != 0)
                {
                    blnTrigger = true;
                }

                dgvTablas.Rows.Add(strNombre, blnSP, blnTrigger, strNombreSP);
            }

            if (dgvTablas.RowCount == 0)
            {
                cmdAgregarQuitarSP.Visible = false;
                cmdAgregarQuitarTrigger.Visible = false;
            }
            else
            {
                cmdAgregarQuitarSP.Visible = true;
                cmdAgregarQuitarTrigger.Visible = true;
            }
        }

        private void dgvTablas_SelectionChanged(object sender, EventArgs e)
        {
            if ((bool)dgvTablas.CurrentRow.Cells[1].Value == true)
            {
                cmdAgregarQuitarSP.Text = "Quitar Stored Procedure";
            }
            else
            {
                cmdAgregarQuitarSP.Text = "Agregar Stored Procedure";
            }

            if ((bool)dgvTablas.CurrentRow.Cells[2].Value == true)
            {
                cmdAgregarQuitarTrigger.Text = "Quitar Trigger";
            }
            else
            {
                cmdAgregarQuitarTrigger.Text = "Agregar Trigger";
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            dgvAtributos.Rows.Clear();
            cbxAuditoria.Checked = true;
            cbxStoredProcedure.Checked = true;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            cmdNuevo.Visible = false;
            cmdEliminar.Visible = false;
            this.tbcTablas.SelectTab(1);
            LimpiarFormulario();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmdNuevo.Visible = true;
            cmdEliminar.Visible = true;
            this.tbcTablas.SelectTab(0);
            LimpiarFormulario();
        }

        private void txtNombreTabla_TextChanged(object sender, EventArgs e)
        {
            dgvTablas.DataMember = null;
            DataTable dt = clsGestorBD.CargarMetadata(txtNombreTabla.Text);

            foreach (DataRow dr in dt.Rows)
            {
                string strNombre = dr["NombreTabla"].ToString();
                bool blnSP = false;
                bool blnTrigger = false;

                if (dr["NombreSP"].ToString().CompareTo("") != 0)
                {
                    blnSP = true;
                }

                if (dr["NombreTrigger"].ToString().CompareTo("") != 0)
                {
                    blnTrigger = true;
                }

                dgvTablas.Rows.Add(strNombre, blnSP, blnTrigger);
            }

            if (dgvTablas.RowCount == 0)
            {
                cmdAgregarQuitarSP.Visible = false;
                cmdAgregarQuitarTrigger.Visible = false;
            }
            else
            {
                cmdAgregarQuitarSP.Visible = true;
                cmdAgregarQuitarTrigger.Visible = true;
            }
        }

        private void cmdAgregarQuitarSP_Click(object sender, EventArgs e)
        {
            string strNombreTabla = dgvTablas.CurrentRow.Cells[0].Value.ToString();
            
            if (cmdAgregarQuitarSP.Text.CompareTo("Agregar Stored Procedure") == 0)
            {
                clsGestorBD.CrearStoredProcedure("up_Man" + strNombreTabla, strNombreTabla);
                
                string strNombreTrigger = "";

                if ((bool)dgvTablas.CurrentRow.Cells[2].Value == true){
                    strNombreTrigger = "tA_"+strNombreTabla;
                }

                clsGestorBD.ActualizarMetadata(strNombreTabla, "up_Man" + strNombreTabla, strNombreTrigger);
            }
            else
            {
                clsGestorBD.BorrarStoredProcedure("up_Man" + strNombreTabla);
            }

            dgvTablas.DataMember = null;
            CargarGrilla();
        }

        private void cmdAgregarQuitarTrigger_Click(object sender, EventArgs e)
        {
            string strNombreTabla = dgvTablas.CurrentRow.Cells[0].Value.ToString();
            
            if (cmdAgregarQuitarTrigger.Text.CompareTo("Agregar Trigger") == 0)
            {
                clsGestorBD.CrearTriggerTabla(strNombreTabla);
                clsGestorBD.ActualizarMetadata(strNombreTabla, dgvTablas.CurrentRow.Cells[3].Value.ToString(), "tA_" + strNombreTabla);
            }
            else
            {
                clsGestorBD.BorrarTrigger("tA_" + strNombreTabla);
            }

            dgvTablas.DataMember = null;
            CargarGrilla();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
