Public Class IngresarCompra
#Region "......................FUNCIONES"

    Sub ObtenerProveedor() ' Obtener al proveedor
        Try
            SQL51("CALL SP_PROVEEDORES")
            If DS51.Tables(DT51.TableName).Rows.Count > 0 Then
                Me.cmbProveedores.Items.Clear()
                Dim fila As DataRow
                For Each fila In DS51.Tables(DT51.TableName).Rows
                    cmbProveedores.Items.Add(fila("rut_proveedor"))
                Next
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Sub numero_de_compra() ' Funcion para obtener el ultimo numero de factura y obtener el lote siguiente
        Try
            SQL48("SP_OBTENER_NUMERO_COMPRA()")
            If TypeOf (DS48.Tables(DT48.TableName).Rows(0).Item("MAX(compras.id_compra)")) Is DBNull Then
                lblNCompra.Text = 1
            Else
                lblNCompra.Text = DS48.Tables(DT48.TableName).Rows(0).Item("MAX(compras.id_compra)") + 1
            End If

            SQL25("CALL SP_OBTENER_CODIGO_LOTE_SIGUIENTE")
            If TypeOf (DS25.Tables(DT25.TableName).Rows(0).Item("MAX(id_lote)")) Is DBNull Then
                txtLote.Text = 1
            Else
                txtLote.Text = DS25.Tables(DT25.TableName).Rows(0).Item("MAX(id_lote)")
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

    Sub calcular_totales() 'Funcion para recalcular los valores de la grilla
        Try
            Dim totalgrilla As Integer
            txtTotal.Text = 0
            For i = 0 To grillaCompra.Rows.Count - 1
                totalgrilla = CInt(grillaCompra.Item(4, i).Value)
                txtTotal.Text = CInt(txtTotal.Text) + CInt(totalgrilla)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Sub SumarProductos() ' Funcion para restar stock a los productos cuando se grabe la venta
        Try
            For Each fila As DataGridViewRow In grillaCompra.Rows
                Dim Codigo As Integer = CInt((fila.Cells("Codigo").Value))
                Dim Cantidad As Integer = CInt(fila.Cells("Cantidad").Value)
                SQL49("CALL SP_ACTUALIZAR_STOCK_SUMAR('" & (Codigo) & "','" & (Cantidad) & "')")
            Next
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

#End Region

#Region ".....................LOAD (carga de formulario"

    Private Sub IngresarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Ejecutar funciones al inicio del formulario
        numero_de_compra()
        txtCodigoBarras.Focus()
        ObtenerProveedor()
    End Sub

#End Region

#Region "..................BOTONES"

    ' La funcion de este boton es agregar productos a la grilla de compras, si el producto ya se encuentra en la grilla
    ' en vez de agregar un fila mas, sumara los valores correspondientes al producto que ya se encuentra en grilla
    Private Sub btnAgregarGrilla_Click(sender As Object, e As EventArgs) Handles btnAgregarGrilla.Click
        If txtCodigoProducto.Text <> "" Then ' Si el textbox codigo de producto es disinto a vacio........
            If txtCantidadAgregar.Text = "" Then ' Si la cantidad a agregar es iguala nada.......
                txtCantidadAgregar.Text = 0 ' Entonces el textbox toma el valor de 0
            End If
            Try
                ' Se declaran variables
                Dim total As Double
                Dim varCodigo As Integer
                Dim VarCantidad As Integer

                If grillaCompra.Rows.Count > 0 Then ' Si la cuenta en grilla compras es mayor a 0....

                    ' Entonces se iniciará un contador que recorrerá la grilla, estableciendo a la variable "VarCodigo"
                    ' con el dato de la columna 0 en cada pasada...
                    For i = 0 To grillaCompra.Rows.Count - 1
                        varCodigo = grillaCompra.Item(0, i).Value

                        ' Con cada pasada por la grilla hecha, el contador evalua si varCodigo es igual al codigo de producto
                        ' que se está ingresando, esto lo hace con el fin de definir si es un producto nuevo y se debe
                        ' agregar por separado o bien es el mismo producto pero que solo se están añadiendo mas items
                        ' al mismo

                        If varCodigo = txtCodigoProducto.Text Then ' Si varCodigo coincide con el codigo que se esta agregando....

                            ' La variable varCantidad toma la cantidad que se está agregando, mas
                            ' el numero en la posicion 3 de la fila evaluada
                            VarCantidad = txtCantidadAgregar.Text + CInt(grillaCompra.Item(3, i).Value)

                            ' Luego la variable total, es igual a la nueva cantidad * el precio de compra
                            ' esto es para establecer cuanto se esta comprando en total pero por producto
                            total = CInt(VarCantidad * txtPrecioCompra.Text)

                            ' Items en la grilla se actualizan con la nueva cantidad y total
                            grillaCompra.Item(3, i).Value = VarCantidad
                            grillaCompra.Item(4, i).Value = total


                            ' Una vez finalizada la tarea se reestablecen parametros y se ejecutan funciones
                            grillaCompra.Text = 0
                            calcular_totales()
                            txtCodigoBarras.Text = ""
                            txtCodigoBarras.Focus()
                            txtCantidadAgregar.Text = 1
                            Exit Sub

                        End If
                    Next
                End If

                ' La segunda parte se asegura de que el campo de cantidad sea ni vacio ni 0
                If txtCantidadAgregar.Text <> "" And txtCantidadAgregar.Text <> 0 Then

                    ' La variable total es igual a cantidad agregada * precio compra
                    total = CInt(txtCantidadAgregar.Text * txtPrecioCompra.Text)
                    ' Se agregan las filas correspondientes a la grilla
                    grillaCompra.Rows.Add(txtCodigoProducto.Text, txtProducto.Text, txtPrecioCompra.Text, txtCantidadAgregar.Text, total, (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd")), (Convert.ToDateTime(calendario2.Text).ToString("yyyy-MM-dd")), txtPrecio.Text)
                    ' Se establece la cantidad inicial
                    txtCantidadAgregar.Text = 1
                    ' Se calculan los totales
                    calcular_totales()

                Else ' ... sino, indica que se debe agregar una cantidad mediante un message box
                    MsgBox("Se debe agregar una cantidad", MsgBoxStyle.Exclamation, "ERROR")
                End If
            Catch ex As Exception ' En caso de existir algun error se mostrará en pantalla
                MsgBox(ex.Message.ToString)
            End Try

            ' Al agregar a la grilla, se limpian textbox de codigo de barras y se establece este control con el foco
            txtCodigoBarras.Text = ""
            txtCodigoBarras.Focus()
        Else ' .... si no, muestra un mensaje indicando que no se encuentra en la base de datos
            lblEstado.Text = "Sin resultado en la base de datos"
            txtCodigoBarras.Text = ""
            txtCodigoBarras.Focus()
        End If

        ' Si se desea agregar una fecha de vencimiento a la compra
        If grillaCompra.Rows.Count > 0 Then

            ' Si el chkVencimiento esta marcado, entonces pone un "Sí" en la celda 8, de lo contrario un "No"
            If chkVencimiento.Checked = True Then
                Me.grillaCompra.Rows(Me.grillaCompra.Rows.Count - 1).Cells(8).Value = "Sí"
            Else
                Me.grillaCompra.Rows(Me.grillaCompra.Rows.Count - 1).Cells(8).Value = "No"
            End If

            ' Junto a esto se agrega el N° de lote correspondiente, indiferente si se agrega o no fecha de vencimiento
            Me.grillaCompra.Rows(Me.grillaCompra.Rows.Count - 1).Cells(9).Value = Me.grillaCompra.Rows.Count + txtLote.Text
            ' https://www.lawebdelprogramador.com/foros/Visual-Basic.NET/967856-Numerar-Celdas-Datagridview.html

        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        ' Se cierra el formulario y a su vez limpia los controles y los inicia de nuevo
        ' esto para que una vez que se vuelva a abrir el formulario nos aseguremos que todos los controles parten desde 0
        Me.Close()
        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub btnBuscarBD_Click(sender As Object, e As EventArgs) Handles btnBuscarBD.Click

        ' Simple condicion que dice que si se pincha el boton y el panel de buscar producto no se ve, se vea, de lo contrario
        ' que se oculte
        If panelBuscarProducto.Visible = False Then
            panelBuscarProducto.Visible = True
        Else
            panelBuscarProducto.Visible = False
        End If
        grillaBuscarProducto.DataSource = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Boton para salir de panel de busqueda de productos, oculta el panel, limpia el textbox y deja sin
        ' DataSource a la grilla
        panelBuscarProducto.Visible = False
        txtBuscarProducto.Clear()
        grillaBuscarProducto.DataSource = ""
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click

        'Abre el formulario para agregar producto en caso de que el producto que se agrega a la compra no se encuentre
        ' en la base de datos
        AgregarProducto.ShowDialog()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click

        ' Con este control, podemos suprimir filas de nustra grilla de ventas y se calculan los totales al terminar la tarea
        ' de no existir registros, envia mensaje
        If grillaCompra.Rows.Count > 0 Then
            grillaCompra.Rows.Remove(grillaCompra.CurrentRow)
            calcular_totales()
        Else
            MsgBox("No hay registros para eliminar")
        End If

        ' Al quitar algun registro, el lote se debe reasignar al elemento siguiente del retirado, para no perderlo y
        ' evitar incongruencias
        If grillaCompra.Rows.Count > 0 Then
            Me.grillaCompra.Rows(Me.grillaCompra.Rows.Count - 1).Cells(8).Value = Me.grillaCompra.Rows.Count + txtLote.Text
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        ' La funcion principal de este botón es buscar en la base de datos el codigo de barras ingresado, y cargar
        ' los datos a los diferentes campos


        If txtCodigoBarras.Text <> "" Then
            Try
                SQL23("CALL SP_CARGAR_DATOS_PRODUCTO_DESDE_BOTON('" & (txtCodigoBarras.Text) & "')")
                If DT23.Rows.Count >= 1 Then
                    For i = 0 To DS23.Tables(DT23.TableName).Rows.Count - 1

                        ' Nuestro contador "i" recorre las filas de la tabla devuelta por la DB, en este caso deberia
                        ' ser una sola fila, ya que los codigos de barras son unicos
                        ' Luego se procede a llenar los campos de texto con el item entre comillas, que representan
                        ' los campos de la tabla devuelta, en este caso la DB devuelve las columnas con nombres personalizados

                        txtCodigoBarras.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Código de Barras")
                        txtProducto.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Producto")
                        txtDescripcion.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Descripcion")
                        txtPrecioVenta.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Precio")
                        txtCodigoProducto.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Código de Producto")
                        txtCantidadActual.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Cantidad en Stock")
                        txtPrecioCompra.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Precio Compra")
                        txtCantidadAgregar.Focus()
                        lblEstado.Text = ""
                    Next
                    conexion.Close() ' Se cierra conexion por seguridad
                Else
                    ' Si en la base de datos no se encuentran resultados se limpian los campos de texto y un label de 
                    ' estado indica que no exiten resultados
                    txtCodigoBarras.Text = ""
                    txtProducto.Text = ""
                    txtPrecioVenta.Text = ""
                    txtDescripcion.Text = ""
                    txtCodigoProducto.Text = ""
                    txtCantidadActual.Text = ""
                    txtPrecioCompra.Text = ""
                    lblEstado.Text = "Sin resultados"
                    conexion.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString()) ' De existir algun error mas serio se presenta con un MSGBOX
                conexion.Close()
            End Try
        Else ' Si no se ingresa un codigo de barras y se quiere buscar, enviara un mensaje pidiendo el codigo de barras
            ' valido
            lblEstado.Text = "Debe ingresar un código válido"
        End If
    End Sub

    Private Sub btnBuscar_GotFocus(sender As Object, e As EventArgs) Handles btnBuscar.GotFocus

        ' El boton Buscar está programado para que cuando reciba el foco en el formulario, actue...

        ' Lo primero al recibir el foco es: Ejecutar el Click
        Call btnBuscar.PerformClick()

        ' Se estableció un pequeño retraso en la respuesta del programa con el fin de dar tiempo a la consulta de
        ' ejecutarse en forma correcta
        System.Threading.Thread.Sleep(300)

        ' Al terminar la accion anterior, se agrega automaticamente a la grilla mediante PerformClick pero del boton
        ' AgregarGrilla
        Call btnAgregarGrilla.PerformClick()
    End Sub

    Private Sub btnGuardarCompra_Click(sender As Object, e As EventArgs) Handles btnGuardarCompra.Click


        'Este boton tiene por objetivo guardar la compra y el detalle de la misma en la DB

        ' Si se cumplen las siguientes condiciones se ejecutará el codigo
        If txtCantidadAgregar.Text <> "" And grillaCompra.Rows.Count > 0 And cmbProveedores.Text <> "" And txtNfactura.Text <> "" Then

            ' Comenzamos ejecutando el ingreso de la compra con los parametros de entrada
            Try
                SQL50("CALL SP_GUARDAR_COMPRA('" & (txtNfactura.Text) & "','" & (cmbProveedores.Text) & "','" & (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd")) & "','" & (txtTotal.Text) & "')")

                ' Luego recorremos la grilla con una variable de tipo DatagridviewRow
                For Each Fila As DataGridViewRow In grillaCompra.Rows

                    ' Se declaran variables en cada pasada
                    Dim numero_compra As Integer
                    Dim codigo As Integer
                    Dim precio As String
                    Dim cantidad As Integer
                    Dim total As String
                    Dim venta As String
                    Dim lote As Integer

                    ' Estas variables se llenan con la celda especificada en que se encuentra en ese momento el contador "Fila"
                    numero_compra = lblNCompra.Text
                    codigo = Fila.Cells(0).Value
                    precio = Fila.Cells(2).Value
                    cantidad = Fila.Cells(3).Value
                    total = Fila.Cells(4).Value
                    venta = Fila.Cells(7).Value
                    lote = Fila.Cells(9).Value

                    ' Despues de establecer las variables, se procede a guardar el detalle de la compra
                    Try
                        ' Primero se actualiza el valor del producto en caso de haber habido modificaciones
                        SQL50("CALL SP_ACTUALIZAR_VALOR_PRODUCTO('" & (codigo) & "','" & (venta) & "','" & (precio) & "')")

                        ' Se guarda el detalle en la tabla detalle_compra
                        SQL27("CALL SP_GUARDAR_DETALLE_COMPRA('" & (numero_compra) & "','" & (txtNfactura.Text) & "','" & (codigo) & "','" & (precio) & "','" & (cantidad) & "','" & (total) & "')")


                        ' Si el producto ingresado tiene fecha de vencimiento, esta condicion determina si en la pasada
                        ' por la fila, la respuesta es Si o no
                        If Fila.Cells(8).Value = "No" Then
                            ' De ser no, se guarda sin fecha de vencimiento ni compra, para que no se despliegue
                            ' en los lotes por vencer
                            SQL25("CALL SP_VENCIMIENTO_LOTE('""','""')")
                            SQL37("CALL SP_GUARDAR_DETALLE_VENCIMIENTO_LOTE('" & (codigo) & "','" & (lote) & "')")
                        ElseIf Fila.Cells(8).Value = "Sí" Then
                            ' De ser si, se guardan las fechas especificadas y se visualizará en el detalle de vencimientos
                            SQL25("CALL SP_VENCIMIENTO_LOTE('" & (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd")) & "','" & (Convert.ToDateTime(calendario2.Text).ToString("yyyy-MM-dd")) & "')")
                            SQL37("CALL SP_GUARDAR_DETALLE_VENCIMIENTO_LOTE('" & (codigo) & "','" & (lote) & "')")
                        End If
                    Catch ex As Exception ' En caso de existir un error mayor se puede visualizar aqui
                        MsgBox(ex.Message.ToString())
                        conexion.Close()
                    End Try
                Next

                ' Se ejecutan funciones para agregar los productos al stock y crear un nuevo numero de compra
                SumarProductos()
                numero_de_compra()

                MsgBox("Compra guardada", MsgBoxStyle.Information, "Compra")
                Try

                    ' Finalizamos listando las compras
                    SQL16("CALL SP_LISTAR_COMPRAS")
                    If DT16.Rows.Count >= 1 Then
                        Ventas.grillaVentas.DataSource = DS16.Tables(DT16.TableName)
                        conexion.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
            conexion.Close()
        Else ' De no existir productos, fecha ni proveedor al guardar la venta nos indicara con un MSGBOX
            MsgBox("Recuerde indicar productos a comprar, fecha de compra y proveedor como datos mínimos")
        End If
    End Sub

#End Region

#Region "..............................TEXTBOXES Y ACCIONES DE LOS MISMOS"

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged

        ' Este textbox ejecutara la consulta SQL cada vez que sus caracteres cambien, esto es utilizado para agilizar las
        ' busquedas
        Try
            SQL18("CALL SP_BUSCAR_PRODUCTO_PARA_VENTA('" & (txtBuscarProducto.Text) & "')")
            conexion.Close()
            If DT18.Rows.Count >= 1 Then
                For i = 0 To DS18.Tables(DT18.TableName).Rows.Count - 1
                    grillaBuscarProducto.DataSource = DS18.Tables(DT18.TableName)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub txtCodigoBarras_Enter(sender As Object, e As EventArgs)

        'Si el textbox es pulsado para escribir en él, su texto cambia a vacio
        txtCodigoBarras.Text = ""
    End Sub

    Private Sub txtCantidadAgregar_Enter(sender As Object, e As EventArgs) Handles txtCantidadAgregar.Enter

        ' Cuando el cursor este posicionado en el textbox cantidad, este cambiará de color y podra ser editado

        txtCantidadAgregar.BackColor = Color.FromArgb(191, 255, 0)
        If txtCantidadAgregar.Text = 0 Then
            txtCantidadAgregar.Text = 1
        End If

        ' Ademas al entrar, se seleccionará todo el texto para una rapida eliminacion en caso de ser necesario
        txtCantidadAgregar.SelectAll()
    End Sub

    Private Sub txtCantidadAgregar_Leave(sender As Object, e As EventArgs) Handles txtCantidadAgregar.Leave

        ' Cuando este control pierda el foco, vuelve asu color normal y en caso de que el numero ingresado sea 0
        ' el textbox quedará con 1
        txtCantidadAgregar.BackColor = Color.White
        If txtCantidadAgregar.Text = "" Then
            txtCantidadAgregar.Text = 0
        End If
    End Sub

    Private Sub txtCantidadAgregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadAgregar.KeyPress

        ' Validación solo numeros

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidadAgregar.KeyDown

        ' Al presionar la tecla ENTER en el textbox cantidad agregar, se habilita el textbox de codigo de barras y
        ' adquiere el foco
        If e.KeyCode = Keys.Enter Then
            txtCodigoBarras.Enabled = True
            txtCodigoBarras.Focus()
        End If
    End Sub

    Private Sub txtCantidadAgregar_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadAgregar.TextChanged

        ' Si la cantidad a agregar es 0 entonces pasará a ser 1

        Try
            If txtCantidadAgregar.Text = 0 Then
                txtCantidadAgregar.Text = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCompra.TextChanged

        ' Cuando el precio de compra cambie, a medida que hace esta acción se calculara el valor sugerido para venta
        ' en relacion al porcentaje de ganancia que se haya especificado
        Dim precio_venta As Double
        Dim porcentaje As Double
        Try
            If txtPrecioCompra.Text <> "" Then
                porcentaje = txtPrecioCompra.Text * (NUM1.Value / 100)
                precio_venta = txtPrecioCompra.Text + porcentaje
                sugerido.Text = precio_venta
                txtPrecio.Text = sugerido.Text
            Else
                sugerido.Text = 0
                txtPrecio.Text = 0
            End If
        Catch
        End Try
    End Sub

#End Region

#Region ".........................COMBOBOX Y VARIOS"

    Private Sub cmbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProveedores.SelectedIndexChanged

        ' Se ejecutará una consulta SQL cuando el indice del combobox cambie, dicha consulta nos buscará la razon social
        ' del rut que se esta ingresando, en el parametro de entrada de la consulta
        Try
            SQL52("CALL SP_BUSCAR_PROVEEDOR_POR_RUT('" & (cmbProveedores.Text) & "')")
            If DT52.Rows.Count >= 1 Then
                For i = 0 To DS52.Tables(DT52.TableName).Rows.Count - 1
                    lblProveedor.Text = DS52.Tables(DT52.TableName).Rows(0).Item("razon_social")
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub chkVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkVencimiento.CheckedChanged

        ' Condicional para cambiar color de textxbox txtlote
        If chkVencimiento.Checked = True Then
            calendario2.Enabled = True
            txtLote.BackColor = Color.White
            txtLote.ForeColor = Color.Black
        Else
            calendario2.Enabled = False
            txtLote.BackColor = Color.Gray
            txtLote.ForeColor = Color.Black

        End If
    End Sub

    Private Sub IngresarCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' Cuando se presiona la tecla FIN en nuestro teclado, tenemos la posibilidad de irnos inmediatamente al
        ' textbox de cantidad, escribir el numero a ingresar, y volver a presionar FIN para pasar el foco al 
        ' control textbox codigo de barras
        If e.KeyCode = Keys.End Then
            If txtCantidadAgregar.Enabled = False Then
                txtCantidadAgregar.Enabled = True
                txtCantidadAgregar.Focus()
                txtCantidadAgregar.SelectAll()
            Else
                txtCantidadAgregar.Enabled = False
                txtCodigoBarras.Focus()
            End If
        End If
    End Sub

    Private Sub NUM1_ValueChanged(sender As Object, e As EventArgs) Handles NUM1.ValueChanged

        ' Similar al control de txtPrecioCompra, pero en esta ocacion, si nuestro porcentaje de ganancia cambia
        ' tambien lo hara el sugerido
        Dim precio_venta As Double
        Dim porcentaje As Double
        Try
            If txtPrecioCompra.Text <> "" Then
                porcentaje = txtPrecioCompra.Text * (NUM1.Value / 100)
                precio_venta = txtPrecioCompra.Text + porcentaje
                sugerido.Text = precio_venta
                txtPrecio.Text = sugerido.Text
            Else
                sugerido.Text = 0
                txtPrecio.Text = 0
            End If
        Catch
        End Try
    End Sub

#End Region

#Region "....................EVENTOS DE GRILLA"

    ' En esta grilla tenemos la posibildad de buscar productos, mediante el textbox asociado

    Private Sub grillaBuscarProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaBuscarProducto.CellDoubleClick

        ' Al hacer doble click en el registro que queramos, se ejecutará una consulta SQL, obteniendo los datos del
        ' producto

        Try
            SQL19("SP_CARGAR_DATOS_PRODUCTO_DESDE_DGV('" & (grillaBuscarProducto.CurrentRow.Cells(0).Value) & "')")
            conexion.Close()
            For i = 0 To DS19.Tables(DT19.TableName).Rows.Count - 1
                txtCodigoBarras.Text = DS19.Tables(DT19.TableName).Rows(0).Item("barrasopcional")
                txtProducto.Text = DS19.Tables(DT19.TableName).Rows(0).Item("nombre")
                txtDescripcion.Text = DS19.Tables(DT19.TableName).Rows(0).Item("descripcion")
                txtPrecioVenta.Text = DS19.Tables(DT19.TableName).Rows(0).Item("precio")
                txtCodigoProducto.Text = DS19.Tables(DT19.TableName).Rows(0).Item("cod_prod")
                txtCantidadActual.Text = DS19.Tables(DT19.TableName).Rows(0).Item("cantidad")
                txtPrecioCompra.Text = DS19.Tables(DT19.TableName).Rows(0).Item("precio_compra")
                txtCantidadAgregar.Focus()
                lblEstado.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
        grillaBuscarProducto.DataSource = ""
        panelBuscarProducto.Visible = False
        conexion.Close()
    End Sub

    Private Sub grillaBuscarProducto_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaBuscarProducto.DataBindingComplete

        ' Con las siguientes lineas de codigo, evitamos poder ordenar las columnas de la grilla
        Dim i As Integer
        For i = 0 To grillaBuscarProducto.Columns.Count - 1
            grillaBuscarProducto.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        ' https://social.msdn.microsoft.com/Forums/en-US/9d407f32-6b33-4044-8872-54c6318912bf/how-to-disable-the-column-sorting-in-datagridview?forum=Vsexpressvcs
    End Sub

    Private Sub grillaCompra_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaCompra.DataBindingComplete

        ' Con las siguientes lineas de codigo, la grilla mantiene el orden de las condiciones SI Y NO cuando eliminamos
        ' un producto
        If grillaCompra.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In grillaCompra.Rows
                Me.grillaCompra.Rows(Me.grillaCompra.Rows.Count - 1).Cells(9).Value = Me.grillaCompra.Rows.Count + txtLote.Text
                ' https://www.lawebdelprogramador.com/foros/Visual-Basic.NET/967856-Numerar-Celdas-Datagridview.html
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

#End Region


End Class