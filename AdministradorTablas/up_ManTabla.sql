/*
EXEC up_ManTabla
'PruebaTAM',
'<?xml version="1.0" encoding="utf-8"?>
<tabla>
  <datos>
    <nombreCampo>Id</nombreCampo>
    <valor>1</valor>
    <tipo>Int</tipo>
    <ident>1</ident>
    <pk>1</pk>
  </datos>
  <datos>
    <nombreCampo>Nombre</nombreCampo>
    <valor>Wilder Josue</valor>
    <tipo>VarChar</tipo>
    <ident>0</ident>
    <pk>0</pk>
  </datos>
  <datos>
    <nombreCampo>Descrip</nombreCampo>
    <valor>Practicante TAM</valor>
    <tipo>VarChar</tipo>
    <ident>0</ident>
    <pk>0</pk>
  </datos>
</tabla>',
2;
*/

CREATE PROCEDURE up_ManTabla
(	@nombreTabla VARCHAR(100), 
	@vchXML XML, 
	@tipoOperacion INT  
)
AS
Begin

Declare @idoc int
Declare @cadenaEjecucionSELECT VarChar(500)
Declare @cadenaEjecucionSelectAll VarChar(500)
Declare @cadenaEjecucionInsert VarChar(500)
Declare @cadenaEjecucionUpdate VarChar(500)
Declare @cadenaEjecucionDelete VarChar(500)
Declare @cadenaWhere VarChar(500)
Declare @indicador int
Declare @indicadorWhere int
Declare @campoIdentity VarChar(100)
Declare @pk_encontrado int
Declare @contador int

Begin TRAN
Set @cadenaEjecucionSELECT = 'SELECT '
--Set @cadenaEjecucionSELECT = 'SELECT CodEmpresa, CodAFP, CodSecuencia, PorcSegInvalidez, PorcComisionVariable, ' +
--                             '       PorcFondo,  FecInicioVigencia, FecFinVigencia, MontoTopeSeguro, PorcentSeguro ' +
--                             'FROM   AFPComision'
/*LLENAR LOS DATOS PARA EL SELECT*/
Exec sp_xml_preparedocument @idoc output,@vchXML

SELECT nombreCampo,valor,tipo,ident,pk Into #te2 FROM openxml(@idoc,'/tabla/datos',2)
With
(
   nombreCampo VarChar(200),
   valor       VarChar(200),
   tipo        VarChar(50),
   ident       VarChar(2),
   pk          VarChar(2)
)

Declare cu_xml2 Cursor For SELECT nombreCampo,valor,tipo,ident,pk FROM #te2
Declare @nombreCampo2 VarChar(200), @valor2 VarChar(200), @tipo2 VarChar(50), @ident2 VarChar(2), @pk2 VarChar(2)

Open cu_xml2
Fetch cu_xml2 Into @nombreCampo2,@valor2,@tipo2,@ident2,@pk2

set @contador = 0

While (@@Fetch_status = 0)
Begin
	if @contador <> 0
	begin
		set @cadenaEjecucionSELECT	= @cadenaEjecucionSELECT + ', '
	end
	set @cadenaEjecucionSELECT = @cadenaEjecucionSELECT + @nombreCampo2 + ' '
		
	set @contador = @contador + 1
	Fetch cu_xml2 Into @nombreCampo2,@valor2,@tipo2,@ident2,@pk2
End
Close cu_xml2

set @cadenaEjecucionSELECT = @cadenaEjecucionSELECT + ' FROM ' + @nombreTabla

--SELECT @cadenaEjecucionSELECT

/**/
Set @cadenaEjecucionSelectAll = @cadenaEjecucionSELECT
--- Set @cadenaEjecucionSelectAll = 'SELECT * FROM AFPComision'
Set @cadenaEjecucionInsert = 'insert Into ' + @nombreTabla + ' values('
Set @cadenaEjecucionUpdate = 'update ' + @nombreTabla + ' Set '
Set @cadenaEjecucionDelete = 'delete FROM ' + @nombreTabla
Set @cadenaWhere = ' where '
Set @indicador = 0
Set @indicadorWhere = 0

Exec sp_xml_preparedocument @idoc output,@vchXML

SELECT nombreCampo,valor,tipo,ident,pk Into #te FROM openxml(@idoc,'/tabla/datos',2)
With
(
   nombreCampo VarChar(200),
   valor       VarChar(200),
   tipo        VarChar(50),
   ident       VarChar(2),
   pk          VarChar(2)
)

Declare cu_xml Cursor For SELECT nombreCampo,valor,tipo,ident,pk FROM #te
Declare @nombreCampo VarChar(200), @valor VarChar(200), @tipo VarChar(50), @ident VarChar(2), @pk VarChar(2)

Open cu_xml
Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk

If ( @tipoOperacion = 0 )  --- SELECT ALL
Begin
    /*HALLANDO LOS PK PERO QUE NO SON IDENT*/
	Set @pk_encontrado = 0		
	While (@@Fetch_status = 0)
	Begin
		If (@pk = '1' and @ident = '0')
		Begin
            Set @valor =
                CASE 
                   WHEN ( UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' ) THEN '''' + @valor + ''''
                   WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
                   Else @valor
                End
			If @pk_encontrado = 1 Begin			
				Set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '							
			End	
			Else Begin
				Set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '							
				Set @pk_encontrado = 1
			End
		End	
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End	

	If @cadenaWhere = ' where ' Begin
		Set @cadenaWhere = ''
	End

	Set @cadenaEjecucionSelectAll = @cadenaEjecucionSelectAll + @cadenaWhere
	Exec(@cadenaEjecucionSelectAll)	
	Drop Table #te
	Close cu_xml
	Deallocate cu_xml
	Exec sp_xml_removedocument @idoc
End

If ( @tipoOperacion = 1 )  ---- SELECT 
Begin
    /*HALLANDO LOS PK */
	Set @pk_encontrado = 0		
	While (@@Fetch_status = 0)
	Begin
		If (@pk = '1')
		Begin
            Set @valor =
                CASE 
                   WHEN ( UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' ) THEN '''' + @valor + ''''
                   WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
                   Else @valor
                End
			If @pk_encontrado = 1 Begin			
				Set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '							
			End	
			Else Begin
				Set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '							
				Set @pk_encontrado = 1
			End
		End	
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End	

	Set @cadenaEjecucionSELECT = @cadenaEjecucionSELECT + @cadenaWhere
	Exec(@cadenaEjecucionSELECT)	
	Drop Table #te
	Close cu_xml
	Deallocate cu_xml
	Exec sp_xml_removedocument @idoc
End

If ( @tipoOperacion = 2 )  --- INSERT
Begin
	/*DETERMINANDO EL CAMPO QUE SE INCREMENTARA*/
	While (@@Fetch_status = 0)
	Begin
		If @ident = '1' Begin
			Set @campoIdentity = @nombreCampo
			break;
		End	
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End
	Close cu_xml

	/*HALLANDO LOS PK PERO QUE NO SON IDENT*/
	Set @pk_encontrado = 0
	Open cu_xml
	Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	While (@@Fetch_status = 0)
	Begin
		If (@pk = '1' and @ident = '0') Begin
           Set @valor =
               CASE 
                  WHEN ( UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' ) THEN '''' + @valor + ''''
                  WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
                  Else @valor
               End
           If @pk_encontrado = 1 Begin			
              Set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '				
           End
           Else Begin
				Set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '				
				Set @pk_encontrado = 1
           End
		End	
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End
	Close cu_xml

	If @cadenaWhere = ' where ' Begin
		Set @cadenaWhere = ''
	End

	/*INCREMENTANDO EL VALOR DE CAMPO IDENT*/
	Declare @id CHAR(3)
	Declare @Consulta VarChar(1024)
	Declare @Maximo int
	create table #Temporal ( Codigo int )
	
	Set @Consulta = 'INSERT Into #Temporal SELECT ISNULL(MAX(CONVERT(INTEGER,' + @campoIdentity + ')),0) FROM ' + @nombreTabla + ' ' + @cadenaWhere
	Execute (@Consulta)
	Set @Maximo = (SELECT Codigo FROM #Temporal)
	Set @id = REPLICATE('0', 3 - LEN(@Maximo + 1)) + CAST((@Maximo + 1) AS VarChar)

	/*ARMANDO LA CADENA PARA INSERCION */
	Open cu_xml
	Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	While (@@Fetch_status = 0)
	Begin
		If @ident = '1' Begin /*ES EL CAMPO IDENT, NO SE CONSIDERA SU VALOR*/	
           If UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR'
              Set @valor = '''' + @id + ''''			
           Else
              Set @valor = @id 
		End
		Else Begin
           Set @valor =
           CASE 
              WHEN ( UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' ) THEN '''' + @valor + ''''
              WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
              Else @valor
           End
		End

		If ( @indicador = 0 ) Begin
           Set @cadenaEjecucionInsert = @cadenaEjecucionInsert + @valor
           Set @indicador = 1
		End
		Else Begin
           Set @cadenaEjecucionInsert = @cadenaEjecucionInsert + ',' + @valor
		End		
		
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End

	Set @cadenaEjecucionInsert = @cadenaEjecucionInsert + ')'	
	Exec(@cadenaEjecucionInsert)

	Close cu_xml
	Deallocate cu_xml
	Exec sp_xml_removedocument @idoc

	Drop Table #Temporal
	Drop Table #te
End

If ( @tipoOperacion = 3 )  --- UPDATE
Begin
	/*ARMANDO LA ESTRUCTURA DEL UPDATE */
	Set @indicador = 0
	Set @indicadorWhere = 0
	While (@@Fetch_status = 0)
	Begin

		If (@pk = '1' )
		Begin
            Set @valor =
                CASE 
                   WHEN UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' THEN '''' + @valor + ''''
                   WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
                   Else @valor
                End
			If @indicadorWhere = 1 Begin			
               Set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '	
			End	
			Else Begin
               Set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '							
               Set @indicadorWhere = 1
			End
		End	
		Else
		Begin
            Set @valor =
                CASE 
                   WHEN UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' THEN '''' + @valor + ''''
                   WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
                   Else @valor
                End
			If @indicador = 1 Begin			
               Set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + ' , ' + @nombreCampo + '=' + @valor + ' '
			End	
			Else Begin
               Set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + @nombreCampo + '=' + @valor + ' '
               Set @indicador = 1
			End
		End
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End	
	Set @cadenaEjecucionUpdate = @cadenaEjecucionUpdate + @cadenaWhere
	Exec(@cadenaEjecucionUpdate)	

	Drop Table #te
	Close cu_xml
	Deallocate cu_xml
	Exec sp_xml_removedocument @idoc
End

If ( @tipoOperacion = 4 )   --- DELETE
Begin
	/*ARMANDO LA ESTRUCTURA DEL DELETE */
	Set @indicador = 0
	Set @indicadorWhere = 0
	While (@@Fetch_status = 0)
	Begin
		If (@pk = '1' )
		Begin
            Set @valor =
            CASE 
               WHEN ( UPPER(@tipo) = 'VARCHAR' or UPPER(@tipo) = 'CHAR' ) THEN '''' + @valor + ''''
               WHEN UPPER(@tipo) = 'DATETIME' THEN 'convert(datetime,' + '''' + substring(@valor, 1, 10) + '''' + ',103)'
               Else @valor
            End
			If @indicadorWhere = 1
			Begin			
				Set @cadenaWhere = @cadenaWhere + ' AND ' + @nombreCampo + '=' + @valor + ' '							
			End	
			Else
			Begin
				Set @cadenaWhere = @cadenaWhere + @nombreCampo + '=' + @valor + ' '							
				Set @indicadorWhere = 1
			End
		End			
		Fetch cu_xml Into @nombreCampo,@valor,@tipo,@ident,@pk
	End	

	Set @cadenaEjecucionDelete = @cadenaEjecucionDelete + @cadenaWhere
	Exec(@cadenaEjecucionDelete)	
	Drop Table #te
	Close cu_xml
	Deallocate cu_xml
	Exec sp_xml_removedocument @idoc
End

If ( @@ERROR <> 0 ) Begin
   ROLLBACK TRAN
   RAISERROR ('Error al guardar los datos.',16,1)
   RETURN(-1)
End
Else Begin
   COMMIT TRAN
End

End