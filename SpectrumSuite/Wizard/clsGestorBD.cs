using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Wizard
{
    public class clsGestorBD
    {
        private const string strServidor = "192.168.9.4";
        private const string strCatalogo = "riesgos";
        private const string strUsuario = "sa";
        private const string strContrasena = "sa";

        private static SqlConnection Conectar(string pstrUsuario, string pstrContrasena)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + "; user id = " + pstrUsuario + "; password = " + pstrContrasena + "; Trusted_Connection = FALSE";
            return cnn;
        }

        public static DataTable Consultar(string pstrComandoSql)
        {
            try
            {
                SqlConnection cnn = Conectar("sa","sa");
                SqlCommand sqlComando = new SqlCommand(pstrComandoSql, cnn);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlComando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cnn.Close();

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un Error \n" + e, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable ConsultaStoredProcedure(string pstrNombreModulo, string pstrNombreStoredProcedure, int pnumTipoOperacion)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParametro;
                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@NombreModulo"; //TipoOperacion1: NombreModulo; TipoOperacion2: NombreServicio
                sqlParametro.Value = pstrNombreModulo;
                sqlParametro.Direction = ParameterDirection.Input;

                sqlComando.Parameters.Add(sqlParametro);

                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@TipoOperacion";
                sqlParametro.Value = pnumTipoOperacion;
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

        public static bool EjecutaStoredProcedure(string pstrNombreStoredProcedure, string ptxtArchivoXML)
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

        public static bool CrearTabla(string pstrNombreTabla, DataGridView pdgvAtributos)
        {
            string strScript;

            strScript  = "CREATE TABLE " + pstrNombreTabla + "\n";
            strScript += "{";

            for (int i = 0; i < pdgvAtributos.Rows.Count; i++)
            {
                string strNombreAtributo;
                string strTipoDato;
                string strNulidad;
            }

            strScript += "}\n";
            strScript += "GO";

            strScript += "ALTER TABLE " + pstrNombreTabla + "\n";
            strScript += "ADD CONSTRAINT XPK"+pstrNombreTabla+" PRIMARY KEY (";
            
            for (int i = 0; i < pdgvAtributos.Rows.Count; i++)
            {
                //Se agrega los que son llave primaria
                
            }
            

            strScript += " ASC)\n";
            strScript += "GO";

            return true;
        }

        public static bool CrearStoredProcedure()
        {
            return true;
        }
    }
}
