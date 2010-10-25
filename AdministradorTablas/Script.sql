IF EXISTS (SELECT name FROM sysobjects WHERE TYPE = 'P' AND NAME = 'NoMbRe')
  DROP PROCEDURE NoMbRe
ELSE
  CREATE PROCEDURE [dbo].[up_WISelProcedimiento]
  ( @TipoOperacion INT,
    @vchXML XML
  )
  AS
  BEGIN
  	IF (@TipoOperacion = 1)
	BEGIN
		INSERT
	END
	IF (@TipoOperacion = 2)
	BEGIN
		UPDATE
	END
	IF (@TipoOperacion = 3)
	BEGIN
		DELETE
	END	
  END
