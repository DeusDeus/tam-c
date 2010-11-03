using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdministradorTablas
{
    public class clsGestorBD
    {
        private const string strServidor = "192.168.0.4";
        private const string strCatalogo = "riesgos";
        private const string strUsuario = "sa";
        private const string strContrasena = "sa";

        private static SqlConnection Conectar(string pstrUsuario, string pstrContrasena)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + "; user id = " + pstrUsuario + "; password = " + pstrContrasena + "; Trusted_Connection = FALSE";
            return cnn;
        }

        public static bool CrearTabla(string pstrNombreTabla, DataGridView pdgvAtributos)
        {
            List<string> lstPrimaryKeys = new List<string>();
            string strScript;

            strScript = "CREATE TABLE " + pstrNombreTabla + "\n";
            strScript += "(";

            int numAtributos = pdgvAtributos.Rows.Count - 1;

            for (int i = 0; i <= numAtributos; i++)
            {
                string strNombreAtributo;
                string strTipoDato;
                string strTamano;
                string strNulidad;

                strNombreAtributo = pdgvAtributos.Rows[i].Cells[0].Value.ToString();
                strTipoDato = pdgvAtributos.Rows[i].Cells[1].Value.ToString();
                strTamano = pdgvAtributos.Rows[i].Cells[2].Value.ToString();

                if (strTamano.CompareTo("") != 0)
                {
                    strTipoDato += "(" + strTamano + ")";
                }

                if (pdgvAtributos.Rows[i].Cells[3].Value.ToString().CompareTo("True") == 0)
                {
                    lstPrimaryKeys.Add(strNombreAtributo);
                }

                strNulidad = pdgvAtributos.Rows[i].Cells[4].Value.ToString();

                if (strNulidad.CompareTo("identity") == 0)
                {
                    strNulidad = "identity (1,1)";
                }

                if (i != numAtributos)
                {
                    strScript += strNombreAtributo + " " + strTipoDato + " " + strNulidad + " ,\n";
                }
                else
                {
                    strScript += strNombreAtributo + " " + strTipoDato + " " + strNulidad + " \n";
                }
            }

            strScript += ")\n";
            //strScript += "go\n";

            strScript += "ALTER TABLE " + pstrNombreTabla + "\n";
            strScript += "ADD CONSTRAINT XPK" + pstrNombreTabla + " PRIMARY KEY (";

            int numPKs = lstPrimaryKeys.Count - 1;

            for (int i = 0; i <= numPKs; i++)
            {
                string strPK;

                strPK = lstPrimaryKeys[i];

                if (i != numPKs)
                {
                    strPK += " ASC, ";
                }
                else
                {
                    strPK += " ASC";
                }

                strScript += strPK;

            }

            strScript += ")\n";
            //strScript += "GO\n";

            try
            {
                SqlConnection cnn = Conectar("sa","sa");
                SqlCommand sqlComando = new SqlCommand(strScript, cnn);
                cnn.Open();

                sqlComando.ExecuteNonQuery();
                cnn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool CrearStoredProcedure(string pstrNombreStoredProcedure, List<clsAtributo> lstAtributos)
        {
            try
            {
                string strScript = "";

                strScript += "IF EXISTS (SELECT name FROM sysobjects WHERE TYPE = 'P' AND NAME = '" + pstrNombreStoredProcedure + "')\n";
                strScript += "DROP PROCEDURE " + pstrNombreStoredProcedure + "\n";
                strScript += "ELSE\n";
                strScript += "CREATE PROCEDURE [dbo].[up_WISelProcedimiento]\n";
                strScript += "( @TipoOperacion INT,\n";
                strScript += "@vchXML XML\n";
                strScript += ")\n";
                strScript += "AS\n";
                strScript += "BEGIN\n";
                    strScript += "IF (@TipoOperacion = 0)\n"; //INSERT
                    strScript += "BEGIN\n";
                    
                    strScript += "END\n";
                    strScript += "IF (@TipoOperacion = 1)\n"; //UPDATE
                    strScript += "BEGIN\n";

                    strScript += "END\n";
                    strScript += "IF (@TipoOperacion = 2)\n"; //DELETE
                    strScript += "BEGIN\n";
                    
                    strScript += "END\n";
                strScript += "END";
                return true;
            }
            catch (Exception e){
                return false;
            }
        }
    }
}
