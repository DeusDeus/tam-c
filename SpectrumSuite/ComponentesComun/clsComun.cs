using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentesGUI;
using System.Xml;
using ComponentesDatos;
using System.IO;
using System;

namespace ComponentesComun
{
    public class clsComun
    {
        public static void CargarControl(Control pctr, DataRow pdr)
        {
            if (pdr["Nombre"].ToString().CompareTo(pctr.Name) == 0)
            {
                switch (pdr["Tipo"].ToString())
                {
                    case "cmd":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucButton)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucButton)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucButton)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucButton)pctr).Es_Obligatorio = false;
                            }
                            ((ucButton)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucButton)pctr).Valor = pdr["Valor"].ToString();
                            ((ucButton)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucButton)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucButton)pctr).Precision = pdr["Precision"].ToString();
                            ((ucButton)pctr).IO = pdr["IO"].ToString();
                            ((ucButton)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                    case "cbx":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucCheckBox)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucCheckBox)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucCheckBox)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucCheckBox)pctr).Es_Obligatorio = false;
                            }
                            ((ucCheckBox)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucCheckBox)pctr).Valor = pdr["Valor"].ToString();
                            ((ucCheckBox)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucCheckBox)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucCheckBox)pctr).Precision = pdr["Precision"].ToString();
                            ((ucCheckBox)pctr).IO = pdr["IO"].ToString();
                            ((ucCheckBox)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                    case "cbo":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucComboBox)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucComboBox)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucComboBox)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucComboBox)pctr).Es_Obligatorio = false;
                            }
                            ((ucComboBox)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucComboBox)pctr).Valor = pdr["Valor"].ToString();
                            ((ucComboBox)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucComboBox)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucComboBox)pctr).Precision = pdr["Precision"].ToString();
                            ((ucComboBox)pctr).IO = pdr["IO"].ToString();
                            ((ucComboBox)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                    case "dgv":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucDataGridView)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucDataGridView)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucDataGridView)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucDataGridView)pctr).Es_Obligatorio = false;
                            }
                            ((ucDataGridView)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucDataGridView)pctr).Valor = pdr["Valor"].ToString();
                            ((ucDataGridView)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucDataGridView)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucDataGridView)pctr).Precision = pdr["Precision"].ToString();
                            ((ucDataGridView)pctr).IO = pdr["IO"].ToString();
                            ((ucDataGridView)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                    case "dtp":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucDateTimePicker)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucDateTimePicker)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucDateTimePicker)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucDateTimePicker)pctr).Es_Obligatorio = false;
                            }
                            ((ucDateTimePicker)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucDateTimePicker)pctr).Valor = pdr["Valor"].ToString();
                            ((ucDateTimePicker)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucDateTimePicker)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucDateTimePicker)pctr).Precision = pdr["Precision"].ToString();
                            ((ucDateTimePicker)pctr).IO = pdr["IO"].ToString();
                            ((ucDateTimePicker)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                    case "lbl":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucLabel)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucLabel)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucLabel)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucLabel)pctr).Es_Obligatorio = false;
                            }
                            ((ucLabel)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucLabel)pctr).Valor = pdr["Valor"].ToString();
                            ((ucLabel)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucLabel)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucLabel)pctr).Precision = pdr["Precision"].ToString();
                            ((ucLabel)pctr).IO = pdr["IO"].ToString();
                            ((ucLabel)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                    case "txt":
                        {
                            if (pdr["IndVisible"].ToString().CompareTo("X") == 0)
                            {
                                ((ucTextBox)pctr).Visible = true;
                            }
                            else
                            {
                                ((ucTextBox)pctr).Visible = false;
                            }
                            if (pdr["IndObligatorio"].ToString().CompareTo("X") == 0)
                            {
                                ((ucTextBox)pctr).Es_Obligatorio = true;
                            }
                            else
                            {
                                ((ucTextBox)pctr).Es_Obligatorio = false;
                            }
                            ((ucTextBox)pctr).Nombre_Campo = pdr["NombreCampoBD"].ToString();
                            ((ucTextBox)pctr).Valor = pdr["Valor"].ToString();
                            ((ucTextBox)pctr).Tipo_Dato = pdr["TipoDato"].ToString();
                            ((ucTextBox)pctr).Longitud = pdr["Longitud"].ToString();
                            ((ucTextBox)pctr).Precision = pdr["Precision"].ToString();
                            ((ucTextBox)pctr).IO = pdr["IO"].ToString();
                            ((ucTextBox)pctr).NombreTagXML = pdr["TagXML"].ToString();
                            break;
                        }
                }
            }

            if (pctr.HasChildren)
            {
                foreach (Control ctr in pctr.Controls)
                {
                    CargarControl(ctr, pdr);
                }
            }
        }

        public static void DesactivarControl(Control pctr)
        {
            if (pctr is ucButton)
            {
                ((ucButton)pctr).Indicador = false;
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    ((ucCheckBox)pctr).Indicador = false;
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        ((ucComboBox)pctr).Indicador = false;
                    }
                    else
                    {
                        if (pctr is DataGridView)
                        {
                            ((ucDataGridView)pctr).Indicador = false;
                        }
                        else
                        {
                            if (pctr is ucDateTimePicker)
                            {
                                ((ucDateTimePicker)pctr).Indicador = false;
                            }
                            else
                            {
                                if (pctr is ucLabel)
                                {
                                    ((ucLabel)pctr).Indicador = false;
                                }
                                else
                                {
                                    if (pctr is ucTextBox)
                                    {
                                        ((ucTextBox)pctr).Indicador = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void ActivarControl(Control pctr)
        {
            if (pctr is ucButton)
            {
                ((ucButton)pctr).Indicador = true;
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    ((ucCheckBox)pctr).Indicador = true;
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        ((ucComboBox)pctr).Indicador = true;
                    }
                    else
                    {
                        if (pctr is DataGridView)
                        {
                            ((ucDataGridView)pctr).Indicador = true;
                        }
                        else
                        {
                            if (pctr is ucDateTimePicker)
                            {
                                ((ucDateTimePicker)pctr).Indicador = true;
                            }
                            else
                            {
                                if (pctr is ucLabel)
                                {
                                    ((ucLabel)pctr).Indicador = true;
                                }
                                else
                                {
                                    if (pctr is ucTextBox)
                                    {
                                        ((ucTextBox)pctr).Indicador = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void CrearListaControles(Control pctr, List<Control> pstrControles)
        {
            if (pctr is ucButton)
            {
                if (((ucButton)pctr).Indicador)
                {
                    pstrControles.Add(pctr);
                }
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    if (((ucCheckBox)pctr).Indicador)
                    {
                        pstrControles.Add(pctr);
                    }
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        if (((ucComboBox)pctr).Indicador)
                        {
                            pstrControles.Add(pctr);
                        }
                    }
                    else
                    {
                        if (pctr is ucDateTimePicker)
                        {
                            if (((ucDateTimePicker)pctr).Indicador)
                            {
                                pstrControles.Add(pctr);
                            }
                        }
                        else
                        {
                            if (pctr is ucLabel)
                            {
                                if (((ucLabel)pctr).Indicador)
                                {
                                    pstrControles.Add(pctr);
                                }
                            }
                            else
                            {
                                if (pctr is ucTextBox)
                                {
                                    if (((ucTextBox)pctr).Indicador)
                                    {
                                        pstrControles.Add(pctr);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (pctr.HasChildren)
            {
                foreach (Control ctr in pctr.Controls)
                {
                    CrearListaControles(ctr, pstrControles);
                }
            }
        }

        public static void DesactivarControlXML(Control pctr)
        {
            if (pctr is ucButton)
            {
                ((ucButton)pctr).IndicadorXML = false;
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    ((ucCheckBox)pctr).IndicadorXML = false;
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        ((ucComboBox)pctr).IndicadorXML = false;
                    }
                    else
                    {
                        if (pctr is DataGridView)
                        {
                            ((ucDataGridView)pctr).IndicadorXML = false;
                        }
                        else
                        {
                            if (pctr is ucDateTimePicker)
                            {
                                ((ucDateTimePicker)pctr).IndicadorXML = false;
                            }
                            else
                            {
                                if (pctr is ucLabel)
                                {
                                    ((ucLabel)pctr).IndicadorXML = false;
                                }
                                else
                                {
                                    if (pctr is ucTextBox)
                                    {
                                        ((ucTextBox)pctr).IndicadorXML = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void ActivarControlXML(Control pctr)
        {
            if (pctr is ucButton)
            {
                ((ucButton)pctr).IndicadorXML = true;
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    ((ucCheckBox)pctr).IndicadorXML = true;
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        ((ucComboBox)pctr).IndicadorXML = true;
                    }
                    else
                    {
                        if (pctr is DataGridView)
                        {
                            ((ucDataGridView)pctr).IndicadorXML = true;
                        }
                        else
                        {
                            if (pctr is ucDateTimePicker)
                            {
                                ((ucDateTimePicker)pctr).IndicadorXML = true;
                            }
                            else
                            {
                                if (pctr is ucLabel)
                                {
                                    ((ucLabel)pctr).IndicadorXML = true;
                                }
                                else
                                {
                                    if (pctr is ucTextBox)
                                    {
                                        ((ucTextBox)pctr).IndicadorXML = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void CrearListaControlesXML(Control pctr, List<Control> pstrControles)
        {
            if (pctr is ucButton)
            {
                if (((ucButton)pctr).IndicadorXML)
                {
                    pstrControles.Add(pctr);
                }
            }
            else
            {
                if (pctr is ucCheckBox)
                {
                    if (((ucCheckBox)pctr).IndicadorXML)
                    {
                        pstrControles.Add(pctr);
                    }
                }
                else
                {
                    if (pctr is ucComboBox)
                    {
                        if (((ucComboBox)pctr).IndicadorXML)
                        {
                            pstrControles.Add(pctr);
                        }
                    }
                    else
                    {
                        if (pctr is ucDataGridView)
                        {
                            if (((ucDataGridView)pctr).IndicadorXML)
                            {
                                pstrControles.Add(pctr);
                            }
                        }
                        else
                        {
                            if (pctr is ucDateTimePicker)
                            {
                                if (((ucDateTimePicker)pctr).IndicadorXML)
                                {
                                    pstrControles.Add(pctr);
                                }
                            }
                            else
                            {
                                if (pctr is ucLabel)
                                {
                                    if (((ucLabel)pctr).IndicadorXML)
                                    {
                                        pstrControles.Add(pctr);
                                    }
                                }
                                else
                                {
                                    if (pctr is ucTextBox)
                                    {
                                        if (((ucTextBox)pctr).IndicadorXML)
                                        {
                                            pstrControles.Add(pctr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (pctr.HasChildren)
            {
                foreach (Control ctr in pctr.Controls)
                {
                    CrearListaControlesXML(ctr, pstrControles);
                }
            }
        }

        public static string RutaXML(List<Control> plstControles, string pstrNombreCabecera)
        {
            XmlDocument xmlDocumento = new XmlDocument();
            XmlNode Cabecera = xmlDocumento.CreateElement(pstrNombreCabecera);
            XmlNode Elemento;

            xmlDocumento.AppendChild(Cabecera);

            for (int i = 0; i < plstControles.Count; i++)
            {
                if (plstControles[i] is ucButton)
                {
                    Elemento = xmlDocumento.CreateElement(((ucButton)plstControles[i]).NombreTagXML);
                    Elemento.InnerText = ((ucButton)plstControles[i]).Valor;
                    Cabecera.AppendChild(Elemento);
                }
                else
                {
                    if (plstControles[i] is ucCheckBox)
                    {
                        Elemento = xmlDocumento.CreateElement(((ucCheckBox)plstControles[i]).NombreTagXML);
                        Elemento.InnerText = ((ucCheckBox)plstControles[i]).Valor;
                        Cabecera.AppendChild(Elemento);
                    }
                    else
                    {
                        if (plstControles[i] is ucComboBox)
                        {
                            Elemento = xmlDocumento.CreateElement(((ucComboBox)plstControles[i]).NombreTagXML);
                            Elemento.InnerText = ((ucComboBox)plstControles[i]).Valor;
                            Cabecera.AppendChild(Elemento);
                        }
                        else
                        {
                            if (plstControles[i] is ucDataGridView)
                            {

                                Elemento = xmlDocumento.CreateElement(((ucDataGridView)plstControles[i]).NombreTagXML);
                                Cabecera.AppendChild(Elemento);
                                DataTable dt = clsDatos.Consultar("SELECT D.Cabecera, D.Tag FROM Metadata M, MetadataDetalle D WHERE M.IdObjeto = D.IdObjeto AND M.Nombre = '" + ((ucDataGridView)plstControles[i]).Name + "'");

                                for (int k = 0; k < ((ucDataGridView)plstControles[i]).Rows.Count; k++)
                                {
                                    XmlNode CabeceraInterna = xmlDocumento.CreateElement(dt.Rows[0]["Cabecera"].ToString());
                                    Elemento.AppendChild(CabeceraInterna);

                                    for (int j = 0; j < dt.Rows.Count; j++)
                                    {
                                        XmlNode SubElemento = xmlDocumento.CreateElement(dt.Rows[j]["Tag"].ToString());
                                        SubElemento.InnerText = ((ucDataGridView)plstControles[i]).Rows[k].Cells[j].Value.ToString();
                                        CabeceraInterna.AppendChild(SubElemento);
                                    }
                                } 
                            }
                            else
                            {
                                if (plstControles[i] is ucDateTimePicker)
                                {
                                    Elemento = xmlDocumento.CreateElement(((ucDateTimePicker)plstControles[i]).NombreTagXML);
                                    Elemento.InnerText = ((ucDateTimePicker)plstControles[i]).Valor;
                                    Cabecera.AppendChild(Elemento);
                                }
                                else
                                {
                                    if (plstControles[i] is ucLabel)
                                    {
                                        Elemento = xmlDocumento.CreateElement(((ucLabel)plstControles[i]).NombreTagXML);
                                        Elemento.InnerText = ((ucLabel)plstControles[i]).Valor;
                                        Cabecera.AppendChild(Elemento);
                                    }
                                    else
                                    {
                                        if (plstControles[i] is ucTextBox)
                                        {
                                            Elemento = xmlDocumento.CreateElement(((ucTextBox)plstControles[i]).NombreTagXML);
                                            Elemento.InnerText = ((ucTextBox)plstControles[i]).Valor;
                                            Cabecera.AppendChild(Elemento);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string strRutaArchivoXML;

            strRutaArchivoXML = "C:\\TEMP\\" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".xml";
           
            StreamWriter sw = new StreamWriter(strRutaArchivoXML);
            
            xmlDocumento.Save(sw);

            sw.Close();

            return strRutaArchivoXML;
        }

        public static string RutaXMLEstandarizado(List<Control> plstControles)
        {
            XmlDocument xmlDocumento = new XmlDocument();

            XmlNode tabla = xmlDocumento.CreateElement("tabla");
            XmlNode datos, nombreCampo, valor, tipo, ident, pk;

            xmlDocumento.AppendChild(tabla);

            for (int i = 0; i < plstControles.Count; i++)
            {
                if (plstControles[i] is ucButton)
                {
                    datos = xmlDocumento.CreateElement("datos");
                    nombreCampo = xmlDocumento.CreateElement("nombreCampo");
                    valor = xmlDocumento.CreateElement("valor");
                    tipo = xmlDocumento.CreateElement("tipo");
                    ident = xmlDocumento.CreateElement("ident");
                    pk = xmlDocumento.CreateElement("pk");

                    tabla.AppendChild(datos);
                    nombreCampo.InnerText = ((ucButton)plstControles[i]).Nombre_Campo;
                    datos.AppendChild(nombreCampo);
                    valor.InnerText = ((ucButton)plstControles[i]).Valor;
                    datos.AppendChild(valor);
                    tipo.InnerText = ((ucButton)plstControles[i]).Tipo_Dato;
                    datos.AppendChild(tipo);
                    ident.InnerText = ((ucButton)plstControles[i]).IndicadorIdentity;
                    datos.AppendChild(ident);
                    pk.InnerText = ((ucButton)plstControles[i]).IndicadorPK;
                    datos.AppendChild(pk);
                }
                else
                {
                    if (plstControles[i] is ucCheckBox)
                    {
                        datos = xmlDocumento.CreateElement("datos");
                        nombreCampo = xmlDocumento.CreateElement("nombreCampo");
                        valor = xmlDocumento.CreateElement("valor");
                        tipo = xmlDocumento.CreateElement("tipo");
                        ident = xmlDocumento.CreateElement("ident");
                        pk = xmlDocumento.CreateElement("pk");

                        tabla.AppendChild(datos);
                        nombreCampo.InnerText = ((ucCheckBox)plstControles[i]).Nombre_Campo;
                        datos.AppendChild(nombreCampo);
                        valor.InnerText = ((ucCheckBox)plstControles[i]).Valor;
                        datos.AppendChild(valor);
                        tipo.InnerText = ((ucCheckBox)plstControles[i]).Tipo_Dato;
                        datos.AppendChild(tipo);
                        ident.InnerText = ((ucCheckBox)plstControles[i]).IndicadorIdentity;
                        datos.AppendChild(ident);
                        pk.InnerText = ((ucCheckBox)plstControles[i]).IndicadorPK;
                        datos.AppendChild(pk);
                    }
                    else
                    {
                        if (plstControles[i] is ucComboBox)
                        {
                            datos = xmlDocumento.CreateElement("datos");
                            nombreCampo = xmlDocumento.CreateElement("nombreCampo");
                            valor = xmlDocumento.CreateElement("valor");
                            tipo = xmlDocumento.CreateElement("tipo");
                            ident = xmlDocumento.CreateElement("ident");
                            pk = xmlDocumento.CreateElement("pk");

                            tabla.AppendChild(datos);
                            nombreCampo.InnerText = ((ucComboBox)plstControles[i]).Nombre_Campo;
                            datos.AppendChild(nombreCampo);
                            valor.InnerText = ((ucComboBox)plstControles[i]).Valor;
                            datos.AppendChild(valor);
                            tipo.InnerText = ((ucComboBox)plstControles[i]).Tipo_Dato;
                            datos.AppendChild(tipo);
                            ident.InnerText = ((ucComboBox)plstControles[i]).IndicadorIdentity;
                            datos.AppendChild(ident);
                            pk.InnerText = ((ucComboBox)plstControles[i]).IndicadorPK;
                            datos.AppendChild(pk);
                        }
                        else
                        {
                            if (plstControles[i] is ucDateTimePicker)
                            {
                                datos = xmlDocumento.CreateElement("datos");
                                nombreCampo = xmlDocumento.CreateElement("nombreCampo");
                                valor = xmlDocumento.CreateElement("valor");
                                tipo = xmlDocumento.CreateElement("tipo");
                                ident = xmlDocumento.CreateElement("ident");
                                pk = xmlDocumento.CreateElement("pk");

                                tabla.AppendChild(datos);
                                nombreCampo.InnerText = ((ucDateTimePicker)plstControles[i]).Nombre_Campo;
                                datos.AppendChild(nombreCampo);
                                valor.InnerText = ((ucDateTimePicker)plstControles[i]).Valor;
                                datos.AppendChild(valor);
                                tipo.InnerText = ((ucDateTimePicker)plstControles[i]).Tipo_Dato;
                                datos.AppendChild(tipo);
                                ident.InnerText = ((ucDateTimePicker)plstControles[i]).IndicadorIdentity;
                                datos.AppendChild(ident);
                                pk.InnerText = ((ucDateTimePicker)plstControles[i]).IndicadorPK;
                                datos.AppendChild(pk);
                            }
                            else
                            {
                                if (plstControles[i] is ucLabel)
                                {
                                    datos = xmlDocumento.CreateElement("datos");
                                    nombreCampo = xmlDocumento.CreateElement("nombreCampo");
                                    valor = xmlDocumento.CreateElement("valor");
                                    tipo = xmlDocumento.CreateElement("tipo");
                                    ident = xmlDocumento.CreateElement("ident");
                                    pk = xmlDocumento.CreateElement("pk");

                                    tabla.AppendChild(datos);
                                    nombreCampo.InnerText = ((ucLabel)plstControles[i]).Nombre_Campo;
                                    datos.AppendChild(nombreCampo);
                                    valor.InnerText = ((ucLabel)plstControles[i]).Valor;
                                    datos.AppendChild(valor);
                                    tipo.InnerText = ((ucLabel)plstControles[i]).Tipo_Dato;
                                    datos.AppendChild(tipo);
                                    ident.InnerText = ((ucLabel)plstControles[i]).IndicadorIdentity;
                                    datos.AppendChild(ident);
                                    pk.InnerText = ((ucLabel)plstControles[i]).IndicadorPK;
                                    datos.AppendChild(pk);
                                }
                                else
                                {
                                    if (plstControles[i] is ucTextBox)
                                    {
                                        datos = xmlDocumento.CreateElement("datos");
                                        nombreCampo = xmlDocumento.CreateElement("nombreCampo");
                                        valor = xmlDocumento.CreateElement("valor");
                                        tipo = xmlDocumento.CreateElement("tipo");
                                        ident = xmlDocumento.CreateElement("ident");
                                        pk = xmlDocumento.CreateElement("pk");

                                        tabla.AppendChild(datos);
                                        nombreCampo.InnerText = ((ucTextBox)plstControles[i]).Nombre_Campo;
                                        datos.AppendChild(nombreCampo);
                                        valor.InnerText = ((ucTextBox)plstControles[i]).Valor;
                                        datos.AppendChild(valor);
                                        tipo.InnerText = ((ucTextBox)plstControles[i]).Tipo_Dato;
                                        datos.AppendChild(tipo);
                                        ident.InnerText = ((ucTextBox)plstControles[i]).IndicadorIdentity;
                                        datos.AppendChild(ident);
                                        pk.InnerText = ((ucTextBox)plstControles[i]).IndicadorPK;
                                        datos.AppendChild(pk);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            string strRutaArchivoXML;

            strRutaArchivoXML = "C:\\TEMP\\" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".xml";

            StreamWriter sw = new StreamWriter(strRutaArchivoXML);

            xmlDocumento.Save(sw);

            sw.Close();

            return strRutaArchivoXML;
        }
    }
}
