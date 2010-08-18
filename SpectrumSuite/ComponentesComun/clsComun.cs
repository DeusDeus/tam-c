using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentesGUI;

namespace ComponentesComun
{
    public class clsComun
    {
        public static void CargarControl(Control pctr, DataRow pdr)
        {
            if (pdr["NombreObjeto"].ToString().CompareTo(pctr.Name) == 0)
            {
                switch (pdr["TipoObjeto"].ToString())
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
                            if (pdr["Obligatorio"].ToString().CompareTo("X") == 0)
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
                            if (pdr["Obligatorio"].ToString().CompareTo("X") == 0)
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
                            if (pdr["Obligatorio"].ToString().CompareTo("X") == 0)
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
                            if (pdr["Obligatorio"].ToString().CompareTo("X") == 0)
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
                            if (pdr["Obligatorio"].ToString().CompareTo("X") == 0)
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
                            if (pdr["Obligatorio"].ToString().CompareTo("X") == 0)
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
    }
}
