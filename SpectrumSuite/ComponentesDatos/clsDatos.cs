﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ComponentesDatos
{
    public class clsDatos
    {
        private const string strServidor = "192.168.9.4";
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

        public static DataTable Consultar(String pstrNombreStoredProcedure, XmlDocument pxmlArchivo)
        {
            string strRutaXML = "";
            bool blnIndicador = false;

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
                            strRutaXML = xmlNodoValor[i].InnerText;
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
                            blnIndicador = true;
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
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                cnn.Close();

                if (blnIndicador)
                {
                    File.Delete(strRutaXML);
                }
                
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool Ejecutar(String pstrNombreStoredProcedure, XmlDocument pxmlArchivo)
        {
            string strRutaXML = "";
            bool blnIndicador = false;

            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;
                SqlCommand sqlComandoAux = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComandoAux.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParametro = new SqlParameter();

                SqlCommandBuilder.DeriveParameters(sqlComandoAux);

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
                            strRutaXML = xmlNodoValor[i].InnerText;
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
                            blnIndicador = true;
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

                    for (int k = 1; k <= sqlComandoAux.Parameters.Count; k++)
                    {
                        if (sqlParametro.ParameterName.ToString().CompareTo(sqlComandoAux.Parameters[k].ParameterName) == 0)
                        {
                            sqlComando.Parameters.Add(sqlParametro);
                            break;
                        }
                    }
                    
                    i++;
                }

                sqlComando.ExecuteNonQuery();

                cnn.Close();

                if (blnIndicador)
                {
                    File.Delete(strRutaXML);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*Stored Procedures Estandarizados:*/
        public static bool Ejecutar(String pstrNombreStoredProcedure, String pstrRutaXML, int pnumTipoOperacion)
        {
            try
            {
                SqlParameter sqlParametro;
                SqlConnection cnn = Conectar("sa", "sa");
                cnn.Open();

                SqlCommand sqlComando = new SqlCommand(pstrNombreStoredProcedure, cnn);
                sqlComando.CommandType = CommandType.StoredProcedure;

                sqlParametro = new SqlParameter();
                
                XmlDocument xmlDocumento = new XmlDocument();
                xmlDocumento.Load(pstrRutaXML);
                CambiarXmlEncoding(xmlDocumento, "UTF-16");
                StringWriter sr = new StringWriter();
                XmlTextWriter xmltr = new XmlTextWriter(sr);
                xmlDocumento.WriteTo(xmltr);
                
                sqlParametro.ParameterName = "@vchXML";
                sqlParametro.Value = sr.ToString();
                sqlParametro.Direction = System.Data.ParameterDirection.Input;
                sr.Close();
                xmltr.Close();

                sqlComando.Parameters.Add(sqlParametro);

                sqlParametro = new SqlParameter();
                sqlParametro.ParameterName = "@tipoOperacion";
                sqlParametro.Value = pnumTipoOperacion.ToString();
                sqlParametro.Direction = System.Data.ParameterDirection.Input;

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
