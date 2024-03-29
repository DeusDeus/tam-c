USE [fondos]
GO
/****** Object:  StoredProcedure [dbo].[up_AD_ColInfo]    Script Date: 01/26/2011 10:33:58 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[up_AD_ColInfo](@tblname VARCHAR(128))

AS

--Inserta todos los campos de la tabla a ser auditada
INSERT INTO #colinfo(colname, datatype, coltype, orderpos)
SELECT 
a.COLUMN_NAME, 
a.DATA_TYPE, 
COLUMN_TYPE = ISNULL((SELECT ISNULL(c.CONSTRAINT_TYPE,'') FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE b, INFORMATION_SCHEMA.TABLE_CONSTRAINTS c
	              WHERE
	              a.TABLE_NAME      = b.TABLE_NAME		AND
	              a.COLUMN_NAME     = b.COLUMN_NAME		AND
	              b.TABLE_NAME      = c.TABLE_NAME  	AND
	              b.CONSTRAINT_NAME = c.CONSTRAINT_NAME     AND
                      c.CONSTRAINT_TYPE   = 'PRIMARY KEY'),''),
a.ORDINAL_POSITION
FROM INFORMATION_SCHEMA.COLUMNS a
WHERE
a.TABLE_NAME = @tblname
ORDER BY COLUMN_TYPE DESC

--borra los campos que no fueron modificados, excepto los campos que participan en la primary key 
DELETE #colinfo  
WHERE
coltype NOT IN ('PRIMARY KEY') 	AND
colsupdated > 0 		AND   
CASE
WHEN (SUBSTRING(colsupdated, 1 + ROUND(((orderpos - 1)) / 8, 0), 1) & POWER (2, ((orderpos - 1)) % 8) <> 0 )
	THEN 1
	ELSE 0
END = 0