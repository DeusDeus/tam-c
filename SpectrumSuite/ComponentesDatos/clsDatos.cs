using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text;

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
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + "; user id = " + pstrUsuario + "; password = " + pstrContrasena + "; Trusted_Connection = FALSE";
            return cnn;
        }

        public static DataSet Consultar(string pstrComandoSql)
        {
            try
            {
                SqlConnection cnn = Conectar();
                SqlCommand sqlComando = new SqlCommand(pstrComandoSql, cnn);
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

        public static bool Ejecutar(string pstrComandoSql)
        {
            try
            {
                SqlConnection cnn = Conectar();
                SqlCommand sqlComando = new SqlCommand(pstrComandoSql, cnn);
                cnn.Open();

                sqlComando.ExecuteNonQuery();
                cnn.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un Error \n" + e, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataSet Consultar(String pstrNombreStoredProcedure, XmlDocument pxmlArchivo)
        {
            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParametro = new SqlParameter();

                XmlNodeList lstParametros = pxmlArchivo.GetElementsByTagName("Parametros");
                XmlNodeList lstParametro = ((XmlElement)lstParametros[0]).GetElementsByTagName("Parametro");

                foreach (XmlElement nodo in lstParametro)
                {
                    int i = 0;
                    XmlNodeList xmlNodoNombre = nodo.GetElementsByTagName("Nombre");
                    XmlNodeList xmlNodoTipo = nodo.GetElementsByTagName("Tipo");
                    XmlNodeList xmlNodoValor = nodo.GetElementsByTagName("Valor");
                    XmlNodeList xmlNodoPrecision = nodo.GetElementsByTagName("Precision");
                    XmlNodeList xmlNodoLongitud = nodo.GetElementsByTagName("Longitud");
                    XmlNodeList xmlNodoIO = nodo.GetElementsByTagName("IO");

                    switch (xmlNodoTipo[i].InnerText)
                    {
                        case "int":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = Int32.Parse(xmlNodoValor[i].InnerText);
                            break;
                        case "double":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = Double.Parse(xmlNodoValor[i].InnerText);
                            sqlParametro.Precision = Byte.Parse(xmlNodoPrecision[i].InnerText);
                            break;
                        case "date":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = DateTime.Parse(xmlNodoValor[i].InnerText);
                            break;
                        case "frm":
                            //No hace nada
                            break;
                        case "xml":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            string strRutaXML = xmlNodoValor[i].InnerText;
                            XmlDocument xmlDocumento = new XmlDocument();
                            xmlDocumento.Load(strRutaXML);
                            sqlParametro.Value = xmlDocumento;
                            break;
                        default:
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = xmlNodoValor[i].InnerText;
                            break;
                    }

                    if (xmlNodoIO[i].InnerText.CompareTo("I ") == 0)
                    {
                        sqlParametro.Direction = System.Data.ParameterDirection.Input;
                    }
                    else
                    {
                        if (xmlNodoIO[i].InnerText.CompareTo("O ") == 0)
                        {
                            sqlParametro.Direction = System.Data.ParameterDirection.Output;
                        }
                        else
                        {
                            sqlParametro.Direction = System.Data.ParameterDirection.InputOutput;
                        }
                    }

                    sqlComando.Parameters.Add(sqlParametro);
                    i++;
                }

                SqlDataAdapter da = new SqlDataAdapter(sqlComando);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                cnn.Close();
                
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool Ejecutar(String pstrNombreStoredProcedure, XmlDocument pxmlArchivo)
        {
            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParametro = new SqlParameter();

                XmlNodeList lstParametros = pxmlArchivo.GetElementsByTagName("Parametros");
                XmlNodeList lstParametro = ((XmlElement)lstParametros[0]).GetElementsByTagName("Parametro");

                foreach (XmlElement nodo in lstParametro)
                {
                    int i = 0;
                    XmlNodeList xmlNodoNombre = nodo.GetElementsByTagName("Nombre");
                    XmlNodeList xmlNodoTipo = nodo.GetElementsByTagName("Tipo");
                    XmlNodeList xmlNodoValor = nodo.GetElementsByTagName("Valor");
                    XmlNodeList xmlNodoPrecision = nodo.GetElementsByTagName("Precision");
                    XmlNodeList xmlNodoLongitud = nodo.GetElementsByTagName("Longitud");
                    XmlNodeList xmlNodoIO = nodo.GetElementsByTagName("IO");

                    switch (xmlNodoTipo[i].InnerText)
                    {
                        case "int":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = Int32.Parse(xmlNodoValor[i].InnerText);
                            break;
                        case "double":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = Double.Parse(xmlNodoValor[i].InnerText);
                            sqlParametro.Precision = Byte.Parse(xmlNodoPrecision[i].InnerText);
                            break;
                        case "date":
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = DateTime.Parse(xmlNodoValor[i].InnerText);
                            break;
                        case "frm":
                            //No hace nada
                            break;
                        case "xml":
                            sqlParametro = new SqlParameter();
                            string strRutaXML = xmlNodoValor[i].InnerText;
                            XmlDocument xmlDocumento = new XmlDocument();
                            xmlDocumento.Load(strRutaXML);
                            CambiarXmlEncoding(xmlDocumento, "UTF-16");
                            StringWriter sr = new StringWriter();
                            XmlTextWriter xmltr = new XmlTextWriter(sr);
                            xmlDocumento.WriteTo(xmltr);
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = sr.ToString();
                            sr.Close();
                            xmltr.Close();
                            break;
                        default:
                            sqlParametro = new SqlParameter();
                            sqlParametro.ParameterName = xmlNodoNombre[i].InnerText;
                            sqlParametro.Value = xmlNodoValor[i].InnerText;
                            break;
                    }

                    if (xmlNodoIO[i].InnerText.CompareTo("I ") == 0)
                    {
                        sqlParametro.Direction = System.Data.ParameterDirection.Input;
                    }
                    else
                    {
                        if (xmlNodoIO[i].InnerText.CompareTo("O ") == 0)
                        {
                            sqlParametro.Direction = System.Data.ParameterDirection.Output;
                        }
                        else
                        {
                            sqlParametro.Direction = System.Data.ParameterDirection.InputOutput;
                        }
                    }

                    sqlComando.Parameters.Add(sqlParametro);
                    i++;
                }

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

        private static XmlDocument CambiarXmlEncoding(XmlDocument pxmlDocumento, string pstrEncoding)
        {
            if (pxmlDocumento.FirstChild.NodeType == XmlNodeType.XmlDeclaration)
            {
                XmlDeclaration xmlDeclaration = (XmlDeclaration)pxmlDocumento.FirstChild;
                xmlDeclaration.Encoding = pstrEncoding;
            }
            return pxmlDocumento;
        }
    }
}
