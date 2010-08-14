using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Xml;
using System.Data;

namespace ComponentesDatos
{
    class clsDatos
    {
        private static SqlConnection cnn;

        public static bool Ejecutar(string strComandoSql)
        {
            return true;
        }

        public static bool Ejecutar(XmlDocument xmlArchivo, string strNombreStoredProcedure)
        {
            return true;
        }

        public static DataSet Consultar(string strComandoSql)
        {
            return null;
        }

        public static DataSet Consultar(XmlDocument xmlArchivo, string strNombreStoredProcedure)
        {
            return null;
        }
    }
}
