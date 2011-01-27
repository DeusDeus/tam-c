using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AdministradorTablas
{
    public class clsGestorBD
    {
        private const string strServidor = "192.168.9.4";
        private const string strCatalogo = "riesgos";
        private const string strUsuario = "sa";
        private const string strContrasena = "sa";

        private static SqlConnection Conectar(string pstrUsuario, string pstrContrasena)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server = " + strServidor + "; initial catalog = " + strCatalogo + "; user id = " + pstrUsuario + "; password = " + pstrContrasena + "; Trusted_Connection = FALSE";
            return cnn;
        }

        public static DataTable Consultar(string pstrComandoSql)
        {
            try
            {
                SqlConnection cnn = Conectar("sa", "sa");
                SqlCommand sqlComando = new SqlCommand(pstrComandoSql, cnn);
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlComando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cnn.Close();

                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un Error \n" + e, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable CargarMetadata(string strCadena)
        {
            DataTable dt = new DataTable();
            string strQuery; 

            if (strCadena == null)
            {
                strQuery = "SELECT * FROM MetadataTabla";
                dt = Consultar(strQuery);
            }
            else
            {
                strQuery = "SELECT * FROM MetadataTabla WHERE NombreTabla like '%" + strCadena + "%'";
                dt = Consultar(strQuery);
            }
            return dt;
        }

        public static bool BorrarTabla(string pstrNombreTabla)
        {
            try
            {
                string strQuery = "DROP TABLE " + pstrNombreTabla;

                SqlConnection cnn = Conectar("sa", "sa");
                SqlCommand sqlComando = new SqlCommand(strQuery, cnn);
                cnn.Open();

                sqlComando.ExecuteNonQuery();

                strQuery = "DELETE FROM MetadataTabla WHERE NombreTabla = '" + pstrNombreTabla + "'";

                sqlComando = new SqlCommand(strQuery, cnn);

                sqlComando.ExecuteNonQuery();

                cnn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool BorrarStoredProcedure(string pstrNombreSP)
        {
            try
            {
                string strQuery = "DROP PROCEDURE " + pstrNombreSP;
                
                SqlConnection cnn = Conectar("sa", "sa");
                SqlCommand sqlComando = new SqlCommand(strQuery, cnn);
                cnn.Open();

                sqlComando.ExecuteNonQuery();

                strQuery = "UPDATE MetadataTabla SET NombreSP = '' WHERE NombreSP = '" + pstrNombreSP + "'";

                sqlComando = new SqlCommand(strQuery, cnn);

                sqlComando.ExecuteNonQuery();

                cnn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool BorrarTrigger(string pstrNombreTrigger)
        {
            try
            {
                string strQuery = "DROP TRIGGER " + pstrNombreTrigger;
                
                SqlConnection cnn = Conectar("sa", "sa");
                SqlCommand sqlComando = new SqlCommand(strQuery, cnn);
                cnn.Open();

                sqlComando.ExecuteNonQuery();

                strQuery = "UPDATE MetadataTabla SET NombreTrigger = '' WHERE NombreTrigger = '" + pstrNombreTrigger + "'";

                sqlComando = new SqlCommand(strQuery, cnn);

                sqlComando.ExecuteNonQuery();

                cnn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
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

        public static bool CrearStoredProcedure(string pstrNombreStoredProcedure, string strNombreTabla)
        {
            try
            {
                string strScript = "";

                strScript += " CREATE PROCEDURE " + pstrNombreStoredProcedure +"\n";
                strScript += " ( @vchXML XML,\n";
                strScript += " @tipoOperacion INT\n";
                strScript += " )\n";
                strScript += " AS\n";
                strScript += " BEGIN\n\n";
                strScript += "declare @idoc int\n";
                strScript += "declare @cadenaEjecucion varchar(500)\n";
                strScript += "declare @cadenaEjecucionUpdate varchar(500)\n";
                strScript += "declare @cadenaEjecucionDelete varchar(500)\n";
                strScript += "declare @cadenaWhere varchar(500)\n";
                strScript += "declare @indicador int\n";
                strScript += "declare @indicadorWhere int\n";
                strScript += "BEGIN TRAN\n";
                    strScript += "set @cadenaEjecucion = 'insert into " + strNombreTabla + " values('\n";
                    strScript += "set @cadenaEjecucionUpdate = 'update " + strNombreTabla + " set '\n";
                    strScript += "set @cadenaEjecucionDelete = 'delete from "+ strNombreTabla +"'\n";
                    strScript += "set @cadenaWhere = ' where '\n";
                    strScript += "set @indicador = 0\n";
                    strScript += "set @indicadorWhere = 0\n\n";

                    strScript += "exec sp_xml_preparedocument @idoc output,@vchXML\n\n";

                    strScript += "select nombreCampo,valor,tipo,ident,pk into #te from openxml(@idoc,'/tabla/datos',2)\n";
                    strScript += "with\n";
                    strScript += "(\n";
                        strScript += "nombreCampo varchar(200),\n";
                        strScript += "valor varchar(200),\n";
                        strScript += "tipo varchar(50),\n";
                        strScript += "ident varchar(2),\n";
                        strScript += "pk varchar(2)\n";
                    strScript += ")\n\n";

                    strScript += "select * from #te\n\n";

                    strScript += "declare cu_xml cursor for select nombreCampo,valor,tipo,ident,pk from #te\n";
                    strScript += "declare @nombreCampo varchar(200), @valor varchar(200), @tipo varchar(50), @ident varchar(2), @pk varchar(2)\n\n";

                    strScript += "open cu_xml\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n";

                    strScript += "IF(@tipoOperacion=1)\n";
                    strScript += "BEGIN\n\n";

                    strScript += "if @tipo = 'varchar' or @tipo = 'char'\n";
                    strScript += "begin\n";
                    strScript += "set @valor = '''' + @valor + ''''\n";
                    strScript += "end\n\n";

                    strScript += "if @ident = '0'\n";
                    strScript += "begin\n";
                    strScript += "set @indicador = 1\n";
                    strScript += "set @cadenaEjecucion = @cadenaEjecucion + @valor\n";
                    strScript += "end\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n\n";

                    strScript += "while (@@fetch_status = 0)\n";
                    strScript += "begin\n";
                    strScript += "if @tipo = 'varchar' or @tipo = 'char'\n";
                    strScript += "begin\n";
                    strScript += "set @valor = '''' + @valor + ''''\n";
                    strScript += "end\n";

                    strScript += "if @indicador = 0\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaEjecucion = @cadenaEjecucion + @valor\n";
                    strScript += "set @indicador = 1\n";
                    strScript += "end\n";
                    strScript += "else\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaEjecucion = @cadenaEjecucion + ',' + @valor\n";
                    strScript += "end\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n";
                    strScript += "end\n\n";

                    strScript += "set @cadenaEjecucion = @cadenaEjecucion + ')'\n\n";

                    strScript += "exec(@cadenaEjecucion)\n\n";

                    strScript += "Close cu_xml\n";
                    strScript += "deallocate cu_xml\n";
                    strScript += "EXEC sp_xml_removedocument @idoc\n";
                    strScript += "END\n\n";

                    strScript += "IF(@tipoOperacion=2)\n";
                    strScript += "BEGIN\n";
                    strScript += "if @tipo = 'varchar' or @tipo = 'char'\n";
                    strScript += "begin\n";
                    strScript += "set @valor = '''' + @valor + ''''\n";
                    strScript += "end\n\n";

                    strScript += "if @pk = '0'\n";
                    strScript += "begin\n";
                    strScript += "set @indicador = 1\n";
                    strScript += "set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "end\n";
                    strScript += "else\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "set @indicadorWhere = 1\n";
                    strScript += "end\n\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n\n";

                    strScript += "while (@@fetch_status = 0)\n";
                    strScript += "begin\n";
                    strScript += "if @tipo = 'varchar' or @tipo = 'char'\n";
                    strScript += "begin\n";
                    strScript += "set @valor = '''' + @valor + ''''\n";
                    strScript += "end\n\n";

                    strScript += "if @pk = 0\n";
                    strScript += "begin\n";
                    strScript += "if @indicador = 1\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + ' , ' + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "end\n";
                    strScript += "else\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "set @indicador = 1\n";
                    strScript += "end\n";
                    strScript += "end\n";
                    strScript += "else\n";
                    strScript += "begin\n";
                    strScript += "if @indicadorWhere = 1\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "end\n";
                    strScript += "else\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "set @indicadorWhere = 1\n";
                    strScript += "end\n";
                    strScript += "end\n\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n";
                    strScript += "end\n\n";

                    strScript += "set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + @cadenaWhere\n\n";

                    strScript += "exec(@cadenaEjecucionUpdate)\n\n";

                    strScript += "Close cu_xml\n";
                    strScript += "deallocate cu_xml\n";
                    strScript += "EXEC sp_xml_removedocument @idoc\n";
                    strScript += "END\n\n";

                    strScript += "IF(@tipoOperacion=3)\n";
                    strScript += "BEGIN\n";
                    strScript += "if @tipo = 'varchar' or @tipo = 'char'\n";
                    strScript += "begin\n";
                    strScript += "set @valor = '''' + @valor + ''''\n";
                    strScript += "end\n\n";

                    strScript += "if @pk = '1'\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "set @indicadorWhere = 1\n";
                    strScript += "end\n\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n\n";

                    strScript += "while (@@fetch_status = 0)\n";
                    strScript += "begin\n";
                    strScript += "if @tipo = 'varchar' or @tipo = 'char'\n";
                    strScript += "begin\n";
                    strScript += "set @valor = '''' + @valor + ''''\n";
                    strScript += "end\n\n";

                    strScript += "if @pk = '1'\n";
                    strScript += "begin\n";
                    strScript += "if @indicadorWhere = 1\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "end\n";
                    strScript += "else\n";
                    strScript += "begin\n";
                    strScript += "set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '\n";
                    strScript += "set @indicadorWhere = 1\n";
                    strScript += "end\n";
                    strScript += "end\n\n";

                    strScript += "fetch cu_xml into @nombreCampo,@valor,@tipo,@ident,@pk\n";
                    strScript += "end\n\n";

                    strScript += "set @cadenaEjecucionDelete = @cadenaEjecucionDelete + @cadenaWhere\n\n";

                    strScript += "exec(@cadenaEjecucionDelete)\n\n";

                    strScript += "Close cu_xml\n";
                    strScript += "deallocate cu_xml\n";
                    strScript += "EXEC sp_xml_removedocument @idoc\n";
                    strScript += "END\n";
                    strScript += "IF @@ERROR<>0\n";
                    strScript += "BEGIN\n";
                    strScript += "ROLLBACK TRAN\n";
                    strScript += "RAISERROR ('Error al guardar los datos.',16,1)\n";
                    strScript += "RETURN(-1)\n";
                    strScript += "END\n";
                    strScript += "ELSE\n";
                    strScript += "BEGIN\n";
                    strScript += "COMMIT TRAN\n";
                    strScript += "END\n";
		        strScript += " END";
               
                try
                {
                    SqlConnection cnn = Conectar("sa", "sa");
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
            catch (Exception e){
                return false;
            }
        }

        public static bool CrearTriggerTabla(string strNombreTabla)
        {
            try
            {
                string strScript = "";
                strScript += "SET QUOTED_IDENTIFIER OFF\n";
                strScript += "SET ANSI_NULLS ON\n";
                strScript += "SET NOCOUNT ON\n\n";

                strScript += "DECLARE @TABLENAME VARCHAR(50)DECLARE @SQLCMD VARCHAR(2000)\n";
                strScript += "DECLARE TABLES_CURSOR CURSOR FOR\n";
                strScript += "SELECT name from dbo.sysobjects\n";
                strScript += "where xtype = 'U' and\n";
                strScript += "name = '" + strNombreTabla + "'\n\n";

                strScript += "OPEN TABLES_CURSOR\n\n";

                strScript += "FETCH NEXT FROM TABLES_CURSOR INTO @TABLENAME\n";
                strScript += "WHILE (@@FETCH_STATUS = 0)\n";
                strScript += "BEGIN\n\n";

                strScript += "SET @SQLCMD = (SELECT 'CREATE TRIGGER tA_') \n";
                strScript += "SET @SQLCMD = @SQLCMD + @TABLENAME + ' ON dbo.' + @TABLENAME \n";
                strScript += "SET @SQLCMD = @SQLCMD + ' AFTER INSERT, UPDATE, DELETE AS ' + CHAR(13)\n";
                strScript += "SET @SQLCMD = @SQLCMD + ' BEGIN ' + CHAR(13)\n";
                strScript += "SET @SQLCMD = @SQLCMD + ' DECLARE @tblname varchar(128)' + CHAR(13)\n";
                strScript += "SET @SQLCMD = @SQLCMD + ' SET @tblname = ''' + @TABLENAME + '''' + CHAR(13)\n";
                strScript += "SET @SQLCMD = @SQLCMD + ' SELECT * INTO #td from deleted ' + CHAR(13) \n";
                strScript += "SET @SQLCMD = @SQLCMD + ' SELECT * INTO #ti from inserted ' + CHAR(13)\n";
                strScript += "SET @SQLCMD = @SQLCMD + ' EXEC up_AD_LogTableChanges @tblname' + CHAR(13)\n";
                strScript += "SET @SQLCMD = @SQLCMD + ' END ' + CHAR(13)\n\n";

                strScript += "SELECT (@SQLCMD)\n\n";

                strScript += "EXEC (@SQLCMD)\n";
                strScript += "FETCH NEXT FROM TABLES_CURSOR INTO @TABLENAME\n";
                strScript += "END\n\n";

                strScript += "CLOSE TABLES_CURSOR\n";
                strScript += "DEALLOCATE TABLES_CURSOR\n\n";

                strScript += "SET NOCOUNT OFF\n";

                try
                {
                    SqlConnection cnn = Conectar("sa", "sa");
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
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool ActualizarMetadata(string strNombreTabla, string strNombreSP, string strNombreTrigger)
        {
            try
            {
                string strScript = "UPDATE MetadataTabla SET NombreSP = '" + strNombreSP + "', NombreTrigger = '" + strNombreTrigger + "' WHERE NombreTabla = '" + strNombreTabla + "'";
                SqlConnection cnn = Conectar("sa", "sa");
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

        public static bool GuardarMetadata(string strNombreTabla, string strNombreSP, string strNombreTrigger)
        {
            try
            {
                string strScript = "INSERT INTO MetadataTabla VALUES ('" + strNombreTabla + "', '" + strNombreSP + "', '" + strNombreTrigger + "')";
                SqlConnection cnn = Conectar("sa", "sa");
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
    }
}
