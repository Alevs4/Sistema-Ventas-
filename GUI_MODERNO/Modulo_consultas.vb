Module Modulo_consultas

#Region "PRODUCTOS"
    Sub SQL1(ByVal varSql As String) ' Cargar productos a grillaProductos al iniciar el formulario

        DS1.Tables.Clear()
        DT1.Rows.Clear()
        DT1.Columns.Clear()
        DS1.Clear()

        conexion.Open()
        SC1.Connection = conexion
        SC1.CommandText = varSql
        DA1.SelectCommand = SC1
        DA1.Fill(DT1)
        DS1.Tables.Add(DT1)
        conexion.Close()

    End Sub

    Sub SQL2(ByVal varSql As String) ' Agregar Producto

        DS2.Tables.Clear()
        DT2.Rows.Clear()
        DT2.Columns.Clear()
        DS2.Clear()

        conexion.Open()
        SC2.Connection = conexion
        SC2.CommandText = varSql
        DA2.SelectCommand = SC2
        DA2.Fill(DT2)
        DS2.Tables.Add(DT2)
        conexion.Close()

    End Sub

    Sub SQL3(ByVal varSql As String) ' Cargar combo Marcas

        DS3.Tables.Clear()
        DT3.Rows.Clear()
        DT3.Columns.Clear()
        DS3.Clear()

        conexion.Open()
        SC3.Connection = conexion
        SC3.CommandText = varSql
        DA3.SelectCommand = SC3
        DA3.Fill(DT3)
        DS3.Tables.Add(DT3)
        conexion.Close()

    End Sub

    Sub SQL4(ByVal varSql As String) ' Cargar combo Categorias

        DS4.Tables.Clear()
        DT4.Rows.Clear()
        DT4.Columns.Clear()
        DS4.Clear()

        conexion.Open()
        SC4.Connection = conexion
        SC4.CommandText = varSql
        DA4.SelectCommand = SC4
        DA4.Fill(DT4)
        DS4.Tables.Add(DT4)
        conexion.Close()

    End Sub

    Sub SQL5(ByVal varSql As String) ' Obtenemos número del ultimo codigo de productos

        DS5.Tables.Clear()
        DT5.Rows.Clear()
        DT5.Columns.Clear()
        DS5.Clear()

        conexion.Open()
        SC5.Connection = conexion
        SC5.CommandText = varSql
        DA5.SelectCommand = SC5
        DA5.Fill(DT5)
        DS5.Tables.Add(DT5)
        conexion.Close()

    End Sub

    Sub SQL6(ByVal varSql As String) ' Eliminamos productos

        DS6.Tables.Clear()
        DT6.Rows.Clear()
        DT6.Columns.Clear()
        DS6.Clear()

        conexion.Open()
        SC6.Connection = conexion
        SC6.CommandText = varSql
        DA6.SelectCommand = SC6
        DA6.Fill(DT6)
        DS6.Tables.Add(DT6)
        conexion.Close()

    End Sub

    Sub SQL7(ByVal varSql As String) ' Añadimos Categorias

        DS7.Tables.Clear()
        DT7.Rows.Clear()
        DT7.Columns.Clear()
        DS7.Clear()

        conexion.Open()
        SC7.Connection = conexion
        SC7.CommandText = varSql
        DA7.SelectCommand = SC7
        DA7.Fill(DT7)
        DS7.Tables.Add(DT7)
        conexion.Close()

    End Sub

    Sub SQL8(ByVal varSql As String) ' Consultamos por categorias

        DS8.Tables.Clear()
        DT8.Rows.Clear()
        DT8.Columns.Clear()
        DS8.Clear()

        conexion.Open()
        SC8.Connection = conexion
        SC8.CommandText = varSql
        DA8.SelectCommand = SC8
        DA8.Fill(DT8)
        DS8.Tables.Add(DT8)
        conexion.Close()

    End Sub

    Sub SQL9(ByVal varSql As String) ' Consultamos por marcas

        DS9.Tables.Clear()
        DT9.Rows.Clear()
        DT9.Columns.Clear()
        DS9.Clear()

        conexion.Open()
        SC9.Connection = conexion
        SC9.CommandText = varSql
        DA9.SelectCommand = SC9
        DA9.Fill(DT9)
        DS9.Tables.Add(DT9)
        conexion.Close()

    End Sub

    Sub SQL10(ByVal varSql As String) ' Añadimos Marcas

        DS10.Tables.Clear()
        DT10.Rows.Clear()
        DT10.Columns.Clear()
        DS10.Clear()

        conexion.Open()
        SC10.Connection = conexion
        SC10.CommandText = varSql
        DA10.SelectCommand = SC10
        DA10.Fill(DT10)
        DS10.Tables.Add(DT10)
        conexion.Close()

    End Sub

    Sub SQL11(ByVal varSql As String) ' Buscamos por nombre

        DS11.Tables.Clear()
        DT11.Rows.Clear()
        DT11.Columns.Clear()
        DS11.Clear()

        conexion.Open()
        SC11.Connection = conexion
        SC11.CommandText = varSql
        DA11.SelectCommand = SC11
        DA11.Fill(DT11)
        DS11.Tables.Add(DT11)
        conexion.Close()

    End Sub

    Sub SQL12(ByVal varSql As String) ' Buscamos por codigo de producto

        DS12.Tables.Clear()
        DT12.Rows.Clear()
        DT12.Columns.Clear()
        DS12.Clear()

        conexion.Open()
        SC12.Connection = conexion
        SC12.CommandText = varSql
        DA12.SelectCommand = SC12
        DA12.Fill(DT12)
        DS12.Tables.Add(DT12)
        conexion.Close()

    End Sub

    Sub SQL13(ByVal varSql As String) ' Buscamos por codigo de producto

        DS13.Tables.Clear()
        DT13.Rows.Clear()
        DT13.Columns.Clear()
        DS13.Clear()

        conexion.Open()
        SC13.Connection = conexion
        SC13.CommandText = varSql
        DA13.SelectCommand = SC13
        DA13.Fill(DT13)
        DS13.Tables.Add(DT13)
        conexion.Close()

    End Sub

    Sub SQL14(ByVal varSql As String) ' Editar Producto

        DS14.Tables.Clear()
        DT14.Rows.Clear()
        DT14.Columns.Clear()
        DS14.Clear()

        conexion.Open()
        SC14.Connection = conexion
        SC14.CommandText = varSql
        DA14.SelectCommand = SC14
        DA14.Fill(DT14)
        DS14.Tables.Add(DT14)
        conexion.Close()

    End Sub

    Sub SQL15(ByVal varSql As String) ' Cargar producto a editar

        DS15.Tables.Clear()
        DT15.Rows.Clear()
        DT15.Columns.Clear()
        DS15.Clear()

        conexion.Open()
        SC15.Connection = conexion
        SC15.CommandText = varSql
        DA15.SelectCommand = SC15
        DA15.Fill(DT15)
        DS15.Tables.Add(DT15)
        conexion.Close()

    End Sub

    Sub SQL37(ByVal varSql As String) ' Detalle de vencimientos
        DS37.Tables.Clear()
        DT37.Rows.Clear()
        DT37.Columns.Clear()
        DS37.Clear()

        conexion.Open()
        SC37.Connection = conexion
        SC37.CommandText = varSql
        DA37.SelectCommand = SC37
        DA37.Fill(DT37)
        DS37.Tables.Add(DT37)
        conexion.Close()

    End Sub

#End Region

#Region "VENTAS"
    Sub SQL16(ByVal varSql As String) ' Cargar grilla ventas al iniciar formulario

        DS16.Tables.Clear()
        DT16.Rows.Clear()
        DT16.Columns.Clear()
        DS16.Clear()

        conexion.Open()
        SC16.Connection = conexion
        SC16.CommandText = varSql
        DA16.SelectCommand = SC16
        DA16.Fill(DT16)
        DS16.Tables.Add(DT16)
        conexion.Close()

    End Sub

    Sub SQL17(ByVal varSql As String) ' Buscar cliente
        DS17.Tables.Clear()
        DT17.Rows.Clear()
        DT17.Columns.Clear()
        DS17.Clear()

        conexion.Open()
        SC17.Connection = conexion
        SC17.CommandText = varSql
        DA17.SelectCommand = SC17
        DA17.Fill(DT17)
        DS17.Tables.Add(DT17)
        conexion.Close()

    End Sub

    Sub SQL18(ByVal varSql As String) ' Buscar producto para venta
        DS18.Tables.Clear()
        DT18.Rows.Clear()
        DT18.Columns.Clear()
        DS18.Clear()

        conexion.Open()
        SC18.Connection = conexion
        SC18.CommandText = varSql
        DA18.SelectCommand = SC18
        DA18.Fill(DT18)
        DS18.Tables.Add(DT18)
        conexion.Close()

    End Sub


    Sub SQL19(ByVal varSql As String) ' Doble click DGV para cargar datos producto
        DS19.Tables.Clear()
        DT19.Rows.Clear()
        DT19.Columns.Clear()
        DS19.Clear()

        conexion.Open()
        SC19.Connection = conexion
        SC19.CommandText = varSql
        DA19.SelectCommand = SC19
        DA19.Fill(DT19)
        DS19.Tables.Add(DT19)
        conexion.Close()

    End Sub

    Sub SQL20(ByVal varSql As String) ' Actualizar stock / restar
        DS20.Tables.Clear()
        DT20.Rows.Clear()
        DT20.Columns.Clear()
        DS20.Clear()

        conexion.Open()
        SC20.Connection = conexion
        SC20.CommandText = varSql
        DA20.SelectCommand = SC20
        DA20.Fill(DT20)
        DS20.Tables.Add(DT20)
        conexion.Close()

    End Sub

    Sub SQL21(ByVal varSql As String) ' Grabar venta
        DS21.Tables.Clear()
        DT21.Rows.Clear()
        DT21.Columns.Clear()
        DS21.Clear()

        conexion.Open()
        SC21.Connection = conexion
        SC21.CommandText = varSql
        DA21.SelectCommand = SC21
        DA21.Fill(DT21)
        DS21.Tables.Add(DT21)
        conexion.Close()

    End Sub

    Sub SQL22(ByVal varSql As String) ' Crear numero de factura nuevo
        DS22.Tables.Clear()
        DT22.Rows.Clear()
        DT22.Columns.Clear()
        DS22.Clear()

        conexion.Open()
        SC22.Connection = conexion
        SC22.CommandText = varSql
        DA22.SelectCommand = SC22
        DA22.Fill(DT22)
        DS22.Tables.Add(DT22)
        conexion.Close()

    End Sub
    Sub SQL23(ByVal varSql As String) ' Boton buscar código de barras
        DS23.Tables.Clear()
        DT23.Rows.Clear()
        DT23.Columns.Clear()
        DS23.Clear()

        conexion.Open()
        SC23.Connection = conexion
        SC23.CommandText = varSql
        DA23.SelectCommand = SC23
        DA23.Fill(DT23)
        DS23.Tables.Add(DT23)
        conexion.Close()

    End Sub

    Sub SQL24(ByVal varSql As String) ' Cargar lotes a vencer
        DS24.Tables.Clear()
        DT24.Rows.Clear()
        DT24.Columns.Clear()
        DS24.Clear()

        conexion.Open()
        SC24.Connection = conexion
        SC24.CommandText = varSql
        DA24.SelectCommand = SC24
        DA24.Fill(DT24)
        DS24.Tables.Add(DT24)
        conexion.Close()

    End Sub

    Sub SQL25(ByVal varSql As String) ' Ingresar Lote a vencer en caso de ser necesario
        DS25.Tables.Clear()
        DT25.Rows.Clear()
        DT25.Columns.Clear()
        DS25.Clear()

        conexion.Open()
        SC25.Connection = conexion
        SC25.CommandText = varSql
        DA25.SelectCommand = SC25
        DA25.Fill(DT25)
        DS25.Tables.Add(DT25)
        conexion.Close()

    End Sub

    Sub SQL27(ByVal varSql As String) ' Ingresar el Detalle de la venta

        DS27.Tables.Clear()
        DT27.Rows.Clear()
        DT27.Columns.Clear()
        DS27.Clear()

        conexion.Open()
        SC27.Connection = conexion
        SC27.CommandText = varSql
        DA27.SelectCommand = SC27
        DA27.Fill(DT27)
        DS27.Tables.Add(DT27)
        conexion.Close()

    End Sub

    Sub SQL28(ByVal varSql As String) ' Cargar detalle de venta seleccionada

        DS28.Tables.Clear()
        DT28.Rows.Clear()
        DT28.Columns.Clear()
        DS28.Clear()

        conexion.Open()
        SC28.Connection = conexion
        SC28.CommandText = varSql
        DA28.SelectCommand = SC28
        DA28.Fill(DT28)
        DS28.Tables.Add(DT28)
        conexion.Close()

    End Sub

    Sub SQL29(ByVal varSql As String) ' Buscar ventas por Numero de boleta

        DS29.Tables.Clear()
        DT29.Rows.Clear()
        DT29.Columns.Clear()
        DS29.Clear()

        conexion.Open()
        SC29.Connection = conexion
        SC29.CommandText = varSql
        DA29.SelectCommand = SC29
        DA29.Fill(DT29)
        DS29.Tables.Add(DT29)
        conexion.Close()

    End Sub

    Sub SQL30(ByVal varSql As String) ' Buscar ventas por Numero de boleta

        DS30.Tables.Clear()
        DT30.Rows.Clear()
        DT30.Columns.Clear()
        DS30.Clear()

        conexion.Open()
        SC30.Connection = conexion
        SC30.CommandText = varSql
        DA30.SelectCommand = SC30
        DA30.Fill(DT30)
        DS30.Tables.Add(DT30)
        conexion.Close()

    End Sub

    Sub SQL56(ByVal varSql As String) ' 
        DS56.Tables.Clear()
        DT56.Rows.Clear()
        DT56.Columns.Clear()
        DS56.Clear()

        conexion.Open()
        SC56.Connection = conexion
        SC56.CommandText = varSql
        DA56.SelectCommand = SC56
        DA56.Fill(DT56)
        DS56.Tables.Add(DT56)
        conexion.Close()

    End Sub
#End Region

#Region "Formulario principal"
    Sub SQL26(ByVal varSql As String) ' Cargar en formulario principal, productos a vencer
        DS26.Tables.Clear()
        DT26.Rows.Clear()
        DT26.Columns.Clear()
        DS26.Clear()

        conexion.Open()
        SC26.Connection = conexion
        SC26.CommandText = varSql
        DA26.SelectCommand = SC26
        DA26.Fill(DT26)
        DS26.Tables.Add(DT26)
        conexion.Close()

    End Sub
#End Region

#Region "LOGIN"
    Sub SQL31(ByVal varSql As String) ' Login
        DS31.Tables.Clear()
        DT31.Rows.Clear()
        DT31.Columns.Clear()
        DS31.Clear()

        conexion.Open()
        SC31.Connection = conexion
        SC31.CommandText = varSql
        DA31.SelectCommand = SC31
        DA31.Fill(DT31)
        DS31.Tables.Add(DT31)
        conexion.Close()

    End Sub
#End Region

#Region "USUARIOS"
    Sub SQL32(ByVal varSql As String) ' Cargar datos usuarios
        DS32.Tables.Clear()
        DT32.Rows.Clear()
        DT32.Columns.Clear()
        DS32.Clear()

        conexion.Open()
        SC32.Connection = conexion
        SC32.CommandText = varSql
        DA32.SelectCommand = SC32
        DA32.Fill(DT32)
        DS32.Tables.Add(DT32)
        conexion.Close()

    End Sub

    Sub SQL33(ByVal varSql As String) ' Modifica datos
        DS33.Tables.Clear()
        DT33.Rows.Clear()
        DT33.Columns.Clear()
        DS33.Clear()

        conexion.Open()
        SC33.Connection = conexion
        SC33.CommandText = varSql
        DA33.SelectCommand = SC33
        DA33.Fill(DT33)
        DS33.Tables.Add(DT33)
        conexion.Close()

    End Sub

    Sub SQL34(ByVal varSql As String) ' Agrega Usuarios
        DS34.Tables.Clear()
        DT34.Rows.Clear()
        DT34.Columns.Clear()
        DS34.Clear()

        conexion.Open()
        SC34.Connection = conexion
        SC34.CommandText = varSql
        DA34.SelectCommand = SC34
        DA34.Fill(DT34)
        DS34.Tables.Add(DT34)
        conexion.Close()

    End Sub

    Sub SQL35(ByVal varSql As String) ' Busca Usuario
        DS35.Tables.Clear()
        DT35.Rows.Clear()
        DT35.Columns.Clear()
        DS35.Clear()

        conexion.Open()
        SC35.Connection = conexion
        SC35.CommandText = varSql
        DA35.SelectCommand = SC35
        DA35.Fill(DT35)
        DS35.Tables.Add(DT35)
        conexion.Close()

    End Sub

    Sub SQL36(ByVal varSql As String) ' Desactiva o activa usuarios
        DS36.Tables.Clear()
        DT36.Rows.Clear()
        DT36.Columns.Clear()
        DS36.Clear()

        conexion.Open()
        SC36.Connection = conexion
        SC36.CommandText = varSql
        DA36.SelectCommand = SC36
        DA36.Fill(DT36)
        DS36.Tables.Add(DT36)
        conexion.Close()

    End Sub


#End Region

#Region "Compras"

    Sub SQL38(ByVal varSql As String) ' Listar compras
        DS38.Tables.Clear()
        DT38.Rows.Clear()
        DT38.Columns.Clear()
        DS38.Clear()

        conexion.Open()
        SC38.Connection = conexion
        SC38.CommandText = varSql
        DA38.SelectCommand = SC38
        DA38.Fill(DT38)
        DS38.Tables.Add(DT38)
        conexion.Close()

    End Sub

    Sub SQL39(ByVal varSql As String) ' Cargar detalle de venta
        DS39.Tables.Clear()
        DT39.Rows.Clear()
        DT39.Columns.Clear()
        DS39.Clear()

        conexion.Open()
        SC39.Connection = conexion
        SC39.CommandText = varSql
        DA39.SelectCommand = SC39
        DA39.Fill(DT39)
        DS39.Tables.Add(DT39)
        conexion.Close()

    End Sub

    Sub SQL40(ByVal varSql As String) ' Buscar compra por numero de factura
        DS40.Tables.Clear()
        DT40.Rows.Clear()
        DT40.Columns.Clear()
        DS40.Clear()

        conexion.Open()
        SC40.Connection = conexion
        SC40.CommandText = varSql
        DA40.SelectCommand = SC40
        DA40.Fill(DT40)
        DS40.Tables.Add(DT40)
        conexion.Close()

    End Sub

    Sub SQL41(ByVal varSql As String) ' Buscar compra por fecha
        DS41.Tables.Clear()
        DT41.Rows.Clear()
        DT41.Columns.Clear()
        DS41.Clear()

        conexion.Open()
        SC41.Connection = conexion
        SC41.CommandText = varSql
        DA41.SelectCommand = SC41
        DA41.Fill(DT41)
        DS41.Tables.Add(DT41)
        conexion.Close()

    End Sub

    Sub SQL42(ByVal varSql As String) ' Buscar compra por proveedor
        DS42.Tables.Clear()
        DT42.Rows.Clear()
        DT42.Columns.Clear()
        DS42.Clear()

        conexion.Open()
        SC42.Connection = conexion
        SC42.CommandText = varSql
        DA42.SelectCommand = SC42
        DA42.Fill(DT42)
        DS42.Tables.Add(DT42)
        conexion.Close()
    End Sub

    Sub SQL48(ByVal varSql As String) ' NUMERO DE COMPRA
        DS48.Tables.Clear()
        DT48.Rows.Clear()
        DT48.Columns.Clear()
        DS48.Clear()

        conexion.Open()
        SC48.Connection = conexion
        SC48.CommandText = varSql
        DA48.SelectCommand = SC48
        DA48.Fill(DT48)
        DS48.Tables.Add(DT48)
        conexion.Close()

    End Sub

    Sub SQL49(ByVal varSql As String) ' Sumar stock
        DS49.Tables.Clear()
        DT49.Rows.Clear()
        DT49.Columns.Clear()
        DS49.Clear()

        conexion.Open()
        SC49.Connection = conexion
        SC49.CommandText = varSql
        DA49.SelectCommand = SC49
        DA49.Fill(DT49)
        DS49.Tables.Add(DT49)
        conexion.Close()

    End Sub

    Sub SQL50(ByVal varSql As String) ' Guardar Compra
        DS50.Tables.Clear()
        DT50.Rows.Clear()
        DT50.Columns.Clear()
        DS50.Clear()

        conexion.Open()
        SC50.Connection = conexion
        SC50.CommandText = varSql
        DA50.SelectCommand = SC50
        DA50.Fill(DT50)
        DS50.Tables.Add(DT50)
        conexion.Close()

    End Sub

    Sub SQL51(ByVal varSql As String) ' Guardar Compra
        DS51.Tables.Clear()
        DT51.Rows.Clear()
        DT51.Columns.Clear()
        DS51.Clear()

        conexion.Open()
        SC51.Connection = conexion
        SC51.CommandText = varSql
        DA51.SelectCommand = SC51
        DA51.Fill(DT51)
        DS51.Tables.Add(DT51)
        conexion.Close()

    End Sub

    Sub SQL52(ByVal varSql As String) ' Guardar Compra
        DS52.Tables.Clear()
        DT52.Rows.Clear()
        DT52.Columns.Clear()
        DS52.Clear()

        conexion.Open()
        SC52.Connection = conexion
        SC52.CommandText = varSql
        DA52.SelectCommand = SC52
        DA52.Fill(DT52)
        DS52.Tables.Add(DT52)
        conexion.Close()

    End Sub

#End Region

#Region "PROVEEDORES"
    Sub SQL43(ByVal varSql As String) ' Cargar Proveedores
        DS43.Tables.Clear()
        DT43.Rows.Clear()
        DT43.Columns.Clear()
        DS43.Clear()

        conexion.Open()
        SC43.Connection = conexion
        SC43.CommandText = varSql
        DA43.SelectCommand = SC43
        DA43.Fill(DT43)
        DS43.Tables.Add(DT43)
        conexion.Close()

    End Sub

    Sub SQL44(ByVal varSql As String) ' Modificar Proveedores
        DS44.Tables.Clear()
        DT44.Rows.Clear()
        DT44.Columns.Clear()
        DS44.Clear()

        conexion.Open()
        SC44.Connection = conexion
        SC44.CommandText = varSql
        DA44.SelectCommand = SC44
        DA44.Fill(DT44)
        DS44.Tables.Add(DT44)
        conexion.Close()

    End Sub

    Sub SQL45(ByVal varSql As String) ' Buscar Proveedor
        DS45.Tables.Clear()
        DT45.Rows.Clear()
        DT45.Columns.Clear()
        DS45.Clear()

        conexion.Open()
        SC45.Connection = conexion
        SC45.CommandText = varSql
        DA45.SelectCommand = SC45
        DA45.Fill(DT45)
        DS45.Tables.Add(DT45)
        conexion.Close()

    End Sub

    Sub SQL46(ByVal varSql As String) ' Agregar Proveedor
        DS46.Tables.Clear()
        DT46.Rows.Clear()
        DT46.Columns.Clear()
        DS46.Clear()

        conexion.Open()
        SC46.Connection = conexion
        SC46.CommandText = varSql
        DA46.SelectCommand = SC46
        DA46.Fill(DT46)
        DS46.Tables.Add(DT46)
        conexion.Close()

    End Sub

    Sub SQL47(ByVal varSql As String) ' Eliminar proveedor
        DS47.Tables.Clear()
        DT47.Rows.Clear()
        DT47.Columns.Clear()
        DS47.Clear()

        conexion.Open()
        SC47.Connection = conexion
        SC47.CommandText = varSql
        DA47.SelectCommand = SC47
        DA47.Fill(DT47)
        DS47.Tables.Add(DT47)
        conexion.Close()

    End Sub


#End Region

#Region "Marcas y categorias"
    Sub SQL53(ByVal varSql As String) ' 
        DS53.Tables.Clear()
        DT53.Rows.Clear()
        DT53.Columns.Clear()
        DS53.Clear()

        conexion.Open()
        SC53.Connection = conexion
        SC53.CommandText = varSql
        DA53.SelectCommand = SC53
        DA53.Fill(DT53)
        DS53.Tables.Add(DT53)
        conexion.Close()

    End Sub

    Sub SQL54(ByVal varSql As String) ' 
        DS54.Tables.Clear()
        DT54.Rows.Clear()
        DT54.Columns.Clear()
        DS54.Clear()

        conexion.Open()
        SC54.Connection = conexion
        SC54.CommandText = varSql
        DA54.SelectCommand = SC54
        DA54.Fill(DT54)
        DS54.Tables.Add(DT54)
        conexion.Close()

    End Sub
#End Region

#Region "Reportes"
    Sub SQL55(ByVal varSql As String) ' 
        DS55.Tables.Clear()
        DT55.Rows.Clear()
        DT55.Columns.Clear()
        DS55.Clear()

        conexion.Open()
        SC55.Connection = conexion
        SC55.CommandText = varSql
        DA55.SelectCommand = SC55
        DA55.Fill(DT55)
        DS55.Tables.Add(DT55)
        conexion.Close()

    End Sub
#End Region
End Module
