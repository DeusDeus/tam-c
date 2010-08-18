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
