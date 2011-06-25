CREATE FUNCTION fn_FieldDelimiter (@FieldDataType varchar(20))
RETURNS varchar(4)
AS
BEGIN

DECLARE @FieldDelimiter varchar(4)
   

   IF @FieldDataType IN ('varchar','char','text')
	SELECT @FieldDelimiter = ''''''''''
   ELSE
	SELECT @FieldDelimiter = ''''''


    RETURN(@FieldDelimiter)	

END


