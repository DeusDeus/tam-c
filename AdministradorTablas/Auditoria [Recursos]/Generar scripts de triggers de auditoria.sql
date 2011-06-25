-- for each table in database generate audit trigger-- except dba_audit_table, dtproperties 
SET QUOTED_IDENTIFIER OFF    
SET ANSI_NULLS ON 
SET NOCOUNT ON

DECLARE @TABLENAME VARCHAR(50)DECLARE @SQLCMD VARCHAR(2000)
DECLARE TABLES_CURSOR CURSOR FOR 
     SELECT name from dbo.sysobjects 
        where xtype = 'U' and
		name = 'Pais'
/*  
        AND name <> 'dtproperties' 
        AND name <> 'LogAudit'
	AND name <> 'PartidaContableMayor'
	AND name <> 'PartidaContableAuxiliar'
	AND name NOT LIKE '%Tmp%'
	AND name NOT LIKE '%TMP%' 
	AND name NOT LIKE '%Temporal%'
*/

OPEN TABLES_CURSOR

FETCH NEXT FROM TABLES_CURSOR INTO @TABLENAME
WHILE (@@FETCH_STATUS = 0)
BEGIN

 -- BUILD CREATE TRIGGER STATEMENT
 SET @SQLCMD = (SELECT 'CREATE TRIGGER tA_') 
 SET @SQLCMD = @SQLCMD + @TABLENAME + ' ON dbo.' + @TABLENAME 
 SET @SQLCMD = @SQLCMD + ' AFTER INSERT, UPDATE, DELETE AS ' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' BEGIN ' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' DECLARE @tblname varchar(128)' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' SET @tblname = ''' + @TABLENAME + '''' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' SELECT * INTO #td from deleted ' + CHAR(13) 
 SET @SQLCMD = @SQLCMD + ' SELECT * INTO #ti from inserted ' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' EXEC up_AD_LogTableChanges @tblname' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' END ' + CHAR(13)
/* 
 SET @SQLCMD = @SQLCMD + ' ' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' GO ' + CHAR(13)
 SET @SQLCMD = @SQLCMD + ' ' + CHAR(13)
 */


 --EXEC (@SQLCMD) 
 
 --SET @SQLCMD = ' sp_settriggerorder @triggername= ''' + 'tA_' + @TABLENAME + ''', @order=''LAST'', @stmttype = ''INSERT''' + CHAR(13)
 --SET @SQLCMD = @SQLCMD + 'GO '	+ CHAR(13)
 --SET @SQLCMD = @SQLCMD + ' sp_settriggerorder @triggername= ''' + 'tA_' + @TABLENAME + ''', @order=''LAST'', @stmttype = ''UPDATE''' + CHAR(13)
 --SET @SQLCMD = @SQLCMD + 'GO '	+ CHAR(13)
 --SET @SQLCMD = @SQLCMD + ' sp_settriggerorder @triggername= ''' + 'tA_' + @TABLENAME + ''', @order=''LAST'', @stmttype = ''DELETE''' + CHAR(13)
 --SET @SQLCMD = @SQLCMD + 'GO '	+ CHAR(13)
 --SET @SQLCMD = @SQLCMD + ''

 -- EXEC (@SQLCMD) 

 SELECT (@SQLCMD)

 -- EXECUTE CREATE TRIGGER STATEMENT 
 EXEC (@SQLCMD) 
 FETCH NEXT FROM TABLES_CURSOR INTO @TABLENAME
END 

CLOSE TABLES_CURSOR  
DEALLOCATE TABLES_CURSOR

SET NOCOUNT OFF


/**UPDATE PaisSETDescripPais = 'Perú'WHERE CodPais = '001'**/