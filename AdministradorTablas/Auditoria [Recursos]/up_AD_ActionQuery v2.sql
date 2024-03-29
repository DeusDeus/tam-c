USE [fondos]
GO
/****** Object:  StoredProcedure [dbo].[up_AD_ActionQuery]    Script Date: 01/25/2011 12:23:44 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[up_AD_ActionQuery](@ActionQuery varchar(4000) OUTPUT)
AS

SET NOCOUNT ON 

-- START QUERY CAUSING TRIGGER

--DECLARE @Handle binary(20) 
DECLARE @ExecStr varchar(512)

--SELECT @Handle = sql_handle 
--FROM master.dbo.sysprocesses 
--WHERE spid = @@SPID

SET @ActionQuery = ''


CREATE TABLE #inputbuffer 
 (
  EventType nvarchar(30), 
  Parameters int, 
  EventInfo nvarchar(255)
 )

SET @ExecStr = 'DBCC INPUTBUFFER(' + RTRIM(LTRIM(STR(@@SPID))) + ') WITH NO_INFOMSGS'

--SELECT @ExecStr

INSERT INTO #inputbuffer
EXEC ('DBCC INPUTBUFFER(@@SPID) WITH NO_INFOMSGS')

--EXEC @ExecStr

--SET @ExecStr = 'SELECT * FROM ::fn_get_sql(' + @Handle + ')'

SET @ActionQuery = (SELECT EventInfo FROM #inputbuffer)

--SET @ActionQuery = (SELECT convert(varchar(4000),text) FROM ::fn_get_sql(@Handle))

SET @ActionQuery = REPLACE(@ActionQuery,"'","''")

SET @ActionQuery = REPLACE(@ActionQuery,char(10),"")
SET @ActionQuery = REPLACE(@ActionQuery,char(13)," ")

-- END QUERY CAUSING TRIGGER

SET NOCOUNT OFF