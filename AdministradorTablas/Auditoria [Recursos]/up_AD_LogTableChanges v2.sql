USE [fondos]
GO
/****** Object:  StoredProcedure [dbo].[up_AD_LogTableChanges]    Script Date: 01/25/2011 12:17:51 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[up_AD_LogTableChanges] 
   @tblname VARCHAR(128)
as
BEGIN

--declare @tblname VARCHAR(128)

--SELECT @tblname = 'RegistroCompra'

--DROP TABLE #colinfo

CREATE TABLE #colinfo 
(colname varchar(128), 
 datatype varchar(20), 
 coltype varchar(20), 
 orderpos int, 
 colsupdated varbinary(16) default COLUMNS_UPDATED(), 
 cid int identity(1,1))


declare @cnti int, @cntd int, @maxid int, @minid int, @pkcols int, @maxpkcolid int, @cmd nvarchar(4000), @audittblname varchar(128),
	@cmdINSERT nvarchar(4000), @cmdSELECT nvarchar(4000), @cmdSELECTI nvarchar(4000), @cmdWHERE nvarchar(4000),  
        @modif_id bigint, @cmdFROM varchar(250), @AUDITINSERT varchar(255), @DUI varchar(10), 
        @SelectSeparator varchar(10), @InsertSeparator varchar(10), @WhereSeparator varchar(10), @ActionQuery varchar(4000)
	
SET NOCOUNT ON 

SELECT @ActionQuery = ''

-- Get query that fires the trigger
EXEC up_AD_ActionQuery @ActionQuery OUTPUT

--SELECT @ActionQuery = 'aaaa'

-- Get all table columns and column information in #colinfo
EXEC up_AD_ColInfo @tblname 
 
--set @audittblname = 'logaudit.dbo.LogAudit'
set @audittblname = 'LogAudit'


select @cnti = count(*) from #ti
select @cntd = count(*) from #td

--select @cnti = 2
--select @cntd = 1

-- check how many rows changed. If 0 then do nothing
IF (@cnti = 0 and @cntd = 0)
   return 0
 
set @cmdSELECT = ' '''
set @cmdSELECTI = ''

SET @cmdWHERE = ''

set @cmdINSERT = ' INSERT INTO ' + @audittblname + ' ( TableName, TableAction, ActionQuery, OldValues, NewValues ) '

SELECT @SelectSeparator = ' + '';' 
SELECT @InsertSeparator = ','  
SELECT @WhereSeparator = ' AND '

select @maxid = max(cid), @minid = min(cid) from #colinfo

select @maxpkcolid = max(cid), @pkcols = count(*) from #colinfo where coltype = 'PRIMARY KEY'

IF (@cnti = @cntd)
BEGIN

	SELECT
	@cmdWHERE = CASE 
			WHEN coltype = 'PRIMARY KEY' THEN 
				@cmdWHERE + 'd.' + colname + '=' + 'i.' + colname + CASE WHEN cid < @maxpkcolid THEN @WhereSeparator ELSE '' END
			ELSE
				@cmdWHERE + ''
	END,
	@cmdSELECT = CASE 
			WHEN coltype <> 'PRIMARY KEY' THEN 
				@cmdSELECT + colname + '='' + ' + dbo.fn_FieldDelimiter(datatype) + ' + convert(varchar(512),d.' + colname + ') + ' + dbo.fn_FieldDelimiter(datatype) + CASE WHEN cid < @maxid THEN @SelectSeparator ELSE '' END
			ELSE
				@cmdSELECT + ''
	END,
	@cmdSELECTI = CASE 
			WHEN coltype <> 'PRIMARY KEY' THEN 
				@cmdSELECTI + colname + '='' + ' + dbo.fn_FieldDelimiter(datatype) + ' + convert(varchar(512),i.' + colname + ') + ' + dbo.fn_FieldDelimiter(datatype) + CASE WHEN cid < @maxid THEN @SelectSeparator ELSE '' END
			ELSE
				@cmdSELECTI + ''
	END
	FROM  #colinfo

	SELECT @cmdSELECT = @cmdSELECT + ', ''' + @cmdSELECTI

	SELECT @DUI = 'U'
	SELECT @cmdFROM = ' FROM #td d, #ti i '

	IF @pkcols > 0 SELECT @cmdWHERE = ' WHERE ' + @cmdWHERE


END


IF (@cnti < @cntd)
BEGIN

	SELECT
	@cmdSELECT = @cmdSELECT + colname + '='' + ' + dbo.fn_FieldDelimiter(datatype) + ' + convert(varchar(512), d.' + colname + ') + ' + dbo.fn_FieldDelimiter(datatype) + CASE WHEN cid < @maxid THEN @SelectSeparator ELSE '' END
	FROM  #colinfo

	SELECT @cmdSELECT = @cmdSELECT + ','''''
	SELECT @DUI = 'D' 
	SELECT @cmdFROM = ' FROM #td d '

END

IF (@cnti > @cntd)
BEGIN

	SELECT
	@cmdSELECT = @cmdSELECT + colname + '='' + ' + dbo.fn_FieldDelimiter(datatype) + ' + convert(varchar(512), i.' + colname + ') + ' + dbo.fn_FieldDelimiter(datatype) + CASE WHEN cid < @maxid THEN @SelectSeparator ELSE '' END
	FROM #colinfo

	SELECT @cmdSELECT = ''''',' + @cmdSELECT
	SELECT @DUI = 'I' 
	SELECT @cmdFROM = ' FROM #ti i '

END

--SET @cmdSELECT = 'SELECT ' + '''' + @tblname + ''',''' + @DUI + ''',''' + @ActionQuery + ''',' + @cmdSELECT 

--SET @cmd = @cmdINSERT + @cmdSELECT + @cmdFROM + @cmdWHERE

--SELECT @cmdINSERT + @cmdSELECT + @cmdFROM + @cmdWHERE --@cmd 

exec (@cmdINSERT + 'SELECT ' + '''' + @tblname + ''',''' + @DUI + ''',''' + @ActionQuery + ''',' + @cmdSELECT + @cmdFROM + @cmdWHERE) 

SET NOCOUNT OFF 

END