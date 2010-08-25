using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using ComponentesDatos;
using ComponentesGUI;
using System;

namespace ComponentesNegocio
{
    public class clsNegocio
    {
        public static DataSet CargarFormulario(string pstrNombreFormulario)
        {
            return clsDatos.Consultar("SELECT * FROM Metadata WHERE Parent = '" + pstrNombreFormulario + "'");
        }

        public static DataSet ConsultarServicio(List<Control> plstControles, string pstrNombreServicio)
        {
            DataSet ds = new DataSet();
            string strNombreStoredProcedure = "";
            string strNombreServicio = "";
            string strTipoServicio = "";

            XmlDocument xmlDocumento;

            ds = clsDatos.Consultar("SELECT * FROM Servicio WHERE NombreServicio = '" + pstrNombreServicio + "'");
            strNombreServicio = ds.Tables[0].Rows[0]["NombreServicio"].ToString();
            strTipoServicio = ds.Tables[0].Rows[0]["TipoServicio"].ToString();

            strNombreStoredProcedure = NombreStoredProcedure(pstrNombreServicio);

            xmlDocumento = CrearXML(plstControles);

            return clsDatos.Consultar(strNombreStoredProcedure, xmlDocumento);
        }

        private static string NombreStoredProcedure(string pstrNombreServicio)
        {
            DataSet ds = new DataSet();
            string strNombreStoredProcedure = "";
            string strNombreServicio = "";
            string strTipoServicio = "";

            ds = clsDatos.Consultar("SELECT NombreServicio, TipoServicio FROM Servicio WHERE IdServicio = (SELECT IdServicio2 FROM Servicio C, ServicioDetalle D WHERE C.IdServicio = D.IdServicio AND C.NombreServicio = '" + pstrNombreServicio + "')");
            strNombreServicio = ds.Tables[0].Rows[0]["NombreServicio"].ToString();
            strTipoServicio = ds.Tables[0].Rows[0]["TipoServicio"].ToString();

            if (strTipoServicio.CompareTo("B") == 0)
            {
                strNombreStoredProcedure = strNombreServicio;
            }
            else
            {
                NombreStoredProcedure(strNombreServicio);
            }

            return strNombreStoredProcedure;
        }

        private static XmlDocument CrearXML(List<Control> plstControles)
        {
            //DataRow dr;
            //dr = (clsDatos.Consultar("SELECT D.NombreStoredProcedure FROM Servicio S, Detalle_Servicio D WHERE S.NombreServicio = '" + pstrNombreServicio + "' AND S.IdServicio = D.IdServicio")).Tables[0].Rows[0];
            //pstrNombreStoredProcedure = dr["NombreStoredProcedure"].ToString();

            XmlDocument xmlDocumento = new XmlDocument();

            XmlNode Parametros = xmlDocumento.CreateElement("Parametros");
            XmlNode Parametro, Nombre, Tipo, Valor, Precision, Longitud, IO;

            xmlDocumento.AppendChild(Parametros);
            
            for (int i = 0; i < plstControles.Count; i++)
            {
                if (plstControles[i] is ucButton)
                {
                    Parametro = xmlDocumento.CreateElement("Parametro");
                    Nombre = xmlDocumento.CreateElement("Nombre");
                    Tipo = xmlDocumento.CreateElement("Tipo");
                    Valor = xmlDocumento.CreateElement("Valor");
                    Precision = xmlDocumento.CreateElement("Precision");
                    Longitud = xmlDocumento.CreateElement("Longitud");
                    IO = xmlDocumento.CreateElement("IO");

                    Parametros.AppendChild(Parametro);
                    Nombre.InnerText = ((ucButton)plstControles[i]).Nombre_Campo;
                    Parametro.AppendChild(Nombre);
                    Tipo.InnerText = ((ucButton)plstControles[i]).Tipo_Dato;
                    Parametro.AppendChild(Tipo);
                    Valor.InnerText = ((ucButton)plstControles[i]).Valor;
                    Parametro.AppendChild(Valor);
                    Precision.InnerText = ((ucButton)plstControles[i]).Precision;
                    Parametro.AppendChild(Precision);
                    Longitud.InnerText = ((ucButton)plstControles[i]).Longitud;
                    Parametro.AppendChild(Longitud);
                    IO.InnerText = ((ucButton)plstControles[i]).IO;
                    Parametro.AppendChild(IO);
                }
                else
                {
                    if (plstControles[i] is ucCheckBox)
                    {
                        Parametro = xmlDocumento.CreateElement("Parametro");
                        Nombre = xmlDocumento.CreateElement("Nombre");
                        Tipo = xmlDocumento.CreateElement("Tipo");
                        Valor = xmlDocumento.CreateElement("Valor");
                        Precision = xmlDocumento.CreateElement("Precision");
                        Longitud = xmlDocumento.CreateElement("Longitud");
                        IO = xmlDocumento.CreateElement("IO");

                        Parametros.AppendChild(Parametro);
                        Nombre.InnerText = ((ucCheckBox)plstControles[i]).Nombre_Campo;
                        Parametro.AppendChild(Nombre);
                        Tipo.InnerText = ((ucCheckBox)plstControles[i]).Tipo_Dato;
                        Parametro.AppendChild(Tipo);
                        Valor.InnerText = ((ucCheckBox)plstControles[i]).Valor;
                        Parametro.AppendChild(Valor);
                        Precision.InnerText = ((ucCheckBox)plstControles[i]).Precision;
                        Parametro.AppendChild(Precision);
                        Longitud.InnerText = ((ucCheckBox)plstControles[i]).Longitud;
                        Parametro.AppendChild(Longitud);
                        IO.InnerText = ((ucCheckBox)plstControles[i]).IO;
                        Parametro.AppendChild(IO);
                    }
                    else
                    {
                        if (plstControles[i] is ucComboBox)
                        {
                            Parametro = xmlDocumento.CreateElement("Parametro");
                            Nombre = xmlDocumento.CreateElement("Nombre");
                            Tipo = xmlDocumento.CreateElement("Tipo");
                            Valor = xmlDocumento.CreateElement("Valor");
                            Precision = xmlDocumento.CreateElement("Precision");
                            Longitud = xmlDocumento.CreateElement("Longitud");
                            IO = xmlDocumento.CreateElement("IO");

                            Parametros.AppendChild(Parametro);
                            Nombre.InnerText = ((ucComboBox)plstControles[i]).Nombre_Campo;
                            Parametro.AppendChild(Nombre);
                            Tipo.InnerText = ((ucComboBox)plstControles[i]).Tipo_Dato;
                            Parametro.AppendChild(Tipo);
                            Valor.InnerText = ((ucComboBox)plstControles[i]).Valor;
                            Parametro.AppendChild(Valor);
                            Precision.InnerText = ((ucComboBox)plstControles[i]).Precision;
                            Parametro.AppendChild(Precision);
                            Longitud.InnerText = ((ucComboBox)plstControles[i]).Longitud;
                            Parametro.AppendChild(Longitud);
                            IO.InnerText = ((ucComboBox)plstControles[i]).IO;
                            Parametro.AppendChild(IO);
                        }
                        else
                        {
                            if (plstControles[i] is ucDateTimePicker)
                            {
                                Parametro = xmlDocumento.CreateElement("Parametro");
                                Nombre = xmlDocumento.CreateElement("Nombre");
                                Tipo = xmlDocumento.CreateElement("Tipo");
                                Valor = xmlDocumento.CreateElement("Valor");
                                Precision = xmlDocumento.CreateElement("Precision");
                                Longitud = xmlDocumento.CreateElement("Longitud");
                                IO = xmlDocumento.CreateElement("IO");

                                Parametros.AppendChild(Parametro);
                                Nombre.InnerText = ((ucDateTimePicker)plstControles[i]).Nombre_Campo;
                                Parametro.AppendChild(Nombre);
                                Tipo.InnerText = ((ucDateTimePicker)plstControles[i]).Tipo_Dato;
                                Parametro.AppendChild(Tipo);
                                Valor.InnerText = ((ucDateTimePicker)plstControles[i]).Valor;
                                Parametro.AppendChild(Valor);
                                Precision.InnerText = ((ucDateTimePicker)plstControles[i]).Precision;
                                Parametro.AppendChild(Precision);
                                Longitud.InnerText = ((ucDateTimePicker)plstControles[i]).Longitud;
                                Parametro.AppendChild(Longitud);
                                IO.InnerText = ((ucDateTimePicker)plstControles[i]).IO;
                                Parametro.AppendChild(IO);
                            }
                            else
                            {
                                if (plstControles[i] is ucLabel)
                                {
                                    Parametro = xmlDocumento.CreateElement("Parametro");
                                    Nombre = xmlDocumento.CreateElement("Nombre");
                                    Tipo = xmlDocumento.CreateElement("Tipo");
                                    Valor = xmlDocumento.CreateElement("Valor");
                                    Precision = xmlDocumento.CreateElement("Precision");
                                    Longitud = xmlDocumento.CreateElement("Longitud");
                                    IO = xmlDocumento.CreateElement("IO");

                                    Parametros.AppendChild(Parametro);
                                    Nombre.InnerText = ((ucLabel)plstControles[i]).Nombre_Campo;
                                    Parametro.AppendChild(Nombre);
                                    Tipo.InnerText = ((ucLabel)plstControles[i]).Tipo_Dato;
                                    Parametro.AppendChild(Tipo);
                                    Valor.InnerText = ((ucLabel)plstControles[i]).Valor;
                                    Parametro.AppendChild(Valor);
                                    Precision.InnerText = ((ucLabel)plstControles[i]).Precision;
                                    Parametro.AppendChild(Precision);
                                    Longitud.InnerText = ((ucLabel)plstControles[i]).Longitud;
                                    Parametro.AppendChild(Longitud);
                                    IO.InnerText = ((ucLabel)plstControles[i]).IO;
                                    Parametro.AppendChild(IO);
                                }
                                else
                                {
                                    if (plstControles[i] is ucTextBox)
                                    {
                                        Parametro = xmlDocumento.CreateElement("Parametro");
                                        Nombre = xmlDocumento.CreateElement("Nombre");
                                        Tipo = xmlDocumento.CreateElement("Tipo");
                                        Valor = xmlDocumento.CreateElement("Valor");
                                        Precision = xmlDocumento.CreateElement("Precision");
                                        Longitud = xmlDocumento.CreateElement("Longitud");
                                        IO = xmlDocumento.CreateElement("IO");

                                        Parametros.AppendChild(Parametro);
                                        Nombre.InnerText = ((ucTextBox)plstControles[i]).Nombre_Campo;
                                        Parametro.AppendChild(Nombre);
                                        Tipo.InnerText = ((ucTextBox)plstControles[i]).Tipo_Dato;
                                        Parametro.AppendChild(Tipo);
                                        Valor.InnerText = ((ucTextBox)plstControles[i]).Valor;
                                        Parametro.AppendChild(Valor);
                                        Precision.InnerText = ((ucTextBox)plstControles[i]).Precision;
                                        Parametro.AppendChild(Precision);
                                        Longitud.InnerText = ((ucTextBox)plstControles[i]).Longitud;
                                        Parametro.AppendChild(Longitud);
                                        IO.InnerText = ((ucTextBox)plstControles[i]).IO;
                                        Parametro.AppendChild(IO);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return xmlDocumento;
        }
    }
}
