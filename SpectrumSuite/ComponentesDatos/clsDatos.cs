using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace ComponentesDatos
{
    public class clsDatos
    {
        private const string strServidor = "192.168.0.4";
        private const string strCatalogo = "riesgos";
        private const string strUsuario = "sa";
        private const string strContrasena = "sa";

        public static SqlConnection Conectar()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + "; user id = " + strUsuario + "; password = " + strContrasena + "; Trusted_Connection = FALSE";
            return cnn;
        }

        public static SqlConnection Conectar(string pstrUsuario, string pstrContrasena)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + ";user id = " + pstrUsuario + ";password = " + pstrContrasena + ";Trusted_Connection = FALSE";
            return cnn;
        }

        public static DataSet Consultar(string strComandoSql)
        {
            try
            {
                SqlConnection cnn = Conectar();
                SqlCommand sqlComando = new SqlCommand(strComandoSql, cnn);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlComando);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cnn.Close();

                return ds;
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocurrió un Error \n" + e,"Error",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
