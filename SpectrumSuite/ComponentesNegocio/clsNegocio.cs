using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using ComponentesDatos;

namespace ComponentesNegocio
{
    public class clsNegocio
    {
        public static DataTable CargarFormulario(string strNombreFormulario)
        {
           return clsDatos.Consultar("SELECT * FROM Formulario_Control_Metadata WHERE Parent = '" + strNombreFormulario + "'");
        }
    }
}
