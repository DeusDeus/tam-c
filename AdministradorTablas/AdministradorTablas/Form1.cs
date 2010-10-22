using System;
using System.Windows.Forms;

namespace AdministradorTablas
{
    public partial class frmPrueba : Form
    {
        private bool blnIndicador = true;

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidarGrilla())
            {
                if (clsGestorBD.CrearTabla(txtNombre.Text, dgvAtributos))
                {
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
        }
    }
}
