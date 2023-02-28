
Imports System.Text.RegularExpressions
Imports System.ComponentModel

Public Class VentaNuevaFactura

    Dim contadorClicks As Integer = 0
    Dim variable_stock As Integer


    Sub numero_de_factura() ' Funcion para obtener el ultimo numero de factura
        Try
            SQL22("CALL SP_OBTENER_NUMERO_FACTURA()")
            If TypeOf (DS22.Tables(DT22.TableName).Rows(0).Item("MAX(n_factura)")) Is DBNull Then
                lblNFactura.Text = 1
            Else
                lblNFactura.Text = DS22.Tables(DT22.TableName).Rows(0).Item("MAX(n_factura)") + 1
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
            For i = 0 To grillaVenta.Rows.Count - 1
                totalgrilla = CInt(grillaVenta.Item(4, i).Value)
                txtTotal.Text = CInt(txtTotal.Text) + CInt(totalgrilla)
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Sub RestarProductos() ' Funcion para restar stock a los productos cuando se grabe la venta
        Try
            For Each fila As DataGridViewRow In grillaVenta.Rows
                Dim Codigo As Integer = CInt((fila.Cells("Codigo").Value))
                Dim Cantidad As Integer = CInt(fila.Cells("Cantidad").Value)
                SQL20("CALL SP_ACTUALIZAR_STOCK_RESTAR('" & (Codigo) & "','" & (Cantidad) & "')")
            Next
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodigoProducto.Text <> "" Then
            If txtCantidadAgregar.Text = "" Then
                txtCantidadAgregar.Text = 0
            End If
            Try
                Dim total As Double
                Dim varCodigo As Integer
                Dim VarCantidad As Integer
                Dim total_compra As Double

                If grillaVenta.Rows.Count > 0 Then

                    For i = 0 To grillaVenta.Rows.Count - 1
                        varCodigo = grillaVenta.Item(0, i).Value

                        If varCodigo = txtCodigoProducto.Text Then
                            VarCantidad = txtCantidadAgregar.Text + CInt(grillaVenta.Item(3, i).Value)

                            If VarCantidad <= txtStock.Text Then

                                total = CInt(VarCantidad * txtPrecio.Text)
                                total_compra = CInt(VarCantidad * txtValorCompra.Text)

                                grillaVenta.Item(3, i).Value = VarCantidad
                                grillaVenta.Item(4, i).Value = total
                                grillaVenta.Item(5, i).Value = total_compra

                                grillaVenta.Text = 0
                                calcular_totales()
                                txtCodigoBarras.Text = ""
                                txtCodigoBarras.Focus()
                                txtCantidadAgregar.Text = 1
                                Exit Sub
                            Else
                                lblEstadoBusqueda.Text = "La cantidad no puede ser mayor al stock existente"
                                txtCantidadAgregar.Text = 1
                                txtCantidadAgregar.Enabled = True
                                txtCantidadAgregar.Focus()
                                Exit Sub
                            End If
                        End If
                    Next
                End If
                If txtCantidadAgregar.Text <> "" And txtCantidadAgregar.Text <> 0 Then
                    If txtStock.Text <> "" Then
                        If CInt(txtCantidadAgregar.Text) <= CInt(txtStock.Text) Then
                            total = CInt(txtCantidadAgregar.Text * txtPrecio.Text)
                            total_compra = CInt(txtCantidadAgregar.Text * txtValorCompra.Text)
                            grillaVenta.Rows.Add(txtCodigoProducto.Text, txtProducto.Text, txtPrecio.Text, txtCantidadAgregar.Text, total, total_compra)
                            txtCantidadAgregar.Text = 0
                            calcular_totales()

                        Else
                            lblEstadoBusqueda.Text = "La Cantidad a agregar es mayor al stock disponible"
                            txtCantidadAgregar.Text = 1
                            txtCantidadAgregar.Enabled = True
                            txtCantidadAgregar.Focus()
                        End If
                    End If
                Else
                    MsgBox("Se debe agregar una cantidad", MsgBoxStyle.Exclamation, "ERROR")
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                conexion.Close()
            End Try
            txtCodigoBarras.Text = ""
            txtCodigoBarras.Focus()
        Else
            lblEstadoBusqueda.Text = "Sin resultado en la base de datos"
            txtCodigoBarras.Text = ""
            txtCodigoBarras.Focus()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Controls.Clear()
        Me.InitializeComponent()

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If panelBuscarProducto.Visible = False Then
            panelBuscarProducto.Visible = True
        Else
            panelBuscarProducto.Visible = False
        End If
        grillaBuscarProducto.DataSource = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelBuscarProducto.Visible = False
        txtBuscarProducto.Clear()
        grillaBuscarProducto.DataSource = ""
    End Sub

    Private Sub txtBuscarProducto_Enter(sender As Object, e As EventArgs) Handles txtBuscarProducto.Enter
        txtBuscarProducto.Text = ""
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
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


    Private Sub grillaBuscarProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaBuscarProducto.CellDoubleClick
        Try
            SQL19("SP_CARGAR_DATOS_PRODUCTO_DESDE_DGV('" & (grillaBuscarProducto.CurrentRow.Cells(0).Value) & "')")
            'conexion.Close()
            For i = 0 To DS19.Tables(DT19.TableName).Rows.Count - 1
                txtCodigoProducto.Text = DS19.Tables(DT19.TableName).Rows(0).Item("cod_prod")
                txtCodigoBarras.Text = DS19.Tables(DT19.TableName).Rows(0).Item("barrasopcional")
                txtProducto.Text = DS19.Tables(DT19.TableName).Rows(0).Item("nombre")
                txtMarca.Text = DS19.Tables(DT19.TableName).Rows(0).Item("marca")
                txtCategoria.Text = DS19.Tables(DT19.TableName).Rows(0).Item("categoria")
                txtPrecio.Text = DS19.Tables(DT19.TableName).Rows(0).Item("precio")
                txtStock.Text = DS19.Tables(DT19.TableName).Rows(0).Item("cantidad")
                txtValorCompra.Text = DS19.Tables(DT19.TableName).Rows(0).Item("precio_compra")
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
        Dim i As Integer
        For i = 0 To grillaBuscarProducto.Columns.Count - 1
            grillaBuscarProducto.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        If txtCantidadAgregar.Text <> "" And grillaVenta.Rows.Count > 0 Then
            Try
                SQL21("CALL SP_GUARDAR_VENTA('" & (lblNFactura.Text) & "','" & (Convert.ToDateTime(lblFecha.Text).ToString("yyyy-MM-dd")) & "','" & (txtTotal.Text) & "','" & (cmbCondicionesPago.Text) & "','" & (Form_Principal.lblRutOc.Text) & "')")
                For Each Fila As DataGridViewRow In grillaVenta.Rows
                    Dim numero_venta As Integer
                    Dim codigo As Integer
                    Dim precio As String
                    Dim cantidad As Integer
                    Dim total As String
                    Dim total_compra As String
                    numero_venta = lblNFactura.Text
                    codigo = Fila.Cells(0).Value
                    precio = Fila.Cells(2).Value
                    cantidad = Fila.Cells(3).Value
                    total = Fila.Cells(4).Value
                    total_compra = Fila.Cells(5).Value
                    SQL27("CALL SP_GUARDAR_DETALLE_VENTA('" & (numero_venta) & "','" & (codigo) & "','" & (precio) & "','" & (total_compra) & "','" & (cantidad) & "','" & (total) & "')")
                Next
                RestarProductos()
                lblNFactura.Text = lblNFactura.Text + 1
                MsgBox("Venta guardada", MsgBoxStyle.Information, "Venta")
                txtBuscarProducto.Text = ""
                txtProducto.Text = ""
                txtPrecio.Text = ""
                txtMarca.Text = ""
                txtCategoria.Text = ""
                txtCodigoProducto.Text = ""
                txtStock.Text = ""
                txtValorCompra.Text = 0
                txtTotal.Text = 0
                txtPagaCon.Text = 0

                txtVuelto.Text = 0
                lblFecha.Text = ""
                lblNFactura.Text = ""
                grillaVenta.Rows.Clear()
                numero_de_factura()
                lblFecha.Text = Date.Today
                cmbCondicionesPago.SelectedIndex = 0
                txtCodigoBarras.Focus()
                Try
                    SQL16("CALL SP_LISTAR_VENTAS")
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
        Else
            MsgBox("Recuerde productos a vender y cantidad")
        End If
    End Sub

    Private Sub VentaNuevaFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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


    Private Sub VentaNuevaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numero_de_factura()
        lblFecha.Text = Date.Today
        cmbCondicionesPago.SelectedIndex = 0
        txtCodigoBarras.Focus()
    End Sub


    Private Sub btnBuscarCodBarras_Click(sender As Object, e As EventArgs) Handles btnBuscarCodBarras.Click
        If txtCodigoBarras.Text <> "" Then
            Try
                SQL23("CALL SP_CARGAR_DATOS_PRODUCTO_DESDE_BOTON('" & (txtCodigoBarras.Text) & "')")
                If DT23.Rows.Count >= 1 Then

                    conexion.Close()
                    For i = 0 To DS23.Tables(DT23.TableName).Rows.Count - 1
                        txtCodigoBarras.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Código de Barras")
                        txtProducto.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Producto")
                        txtMarca.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Marca")
                        txtCategoria.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Categoría")
                        txtPrecio.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Precio")
                        txtCodigoProducto.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Código de Producto")
                        txtStock.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Cantidad en Stock")
                        txtValorCompra.Text = DS23.Tables(DT23.TableName).Rows(0).Item("Precio Compra")
                        txtCantidadAgregar.Focus()
                        lblEstadoBusqueda.Text = ""
                    Next
                Else
                    txtProducto.Text = ""
                    txtPrecio.Text = ""
                    txtMarca.Text = ""
                    txtCategoria.Text = ""
                    txtCodigoProducto.Text = ""
                    txtStock.Text = ""
                    lblEstadoBusqueda.Text = "Sin resultados"
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        Else
            lblEstadoBusqueda.Text = "Debe ingresar un código válido"
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If grillaVenta.Rows.Count > 0 Then
            grillaVenta.Rows.Remove(grillaVenta.CurrentRow)
            calcular_totales()
        Else
            MsgBox("No hay registros para eliminar")
        End If
    End Sub


    Private Sub txtPagaCon_Enter(sender As Object, e As EventArgs) Handles txtPagaCon.Enter
        If txtPagaCon.Text = 0 Then
            txtPagaCon.Text = ""
        End If
    End Sub

    Private Sub txtPagaCon_Leave(sender As Object, e As EventArgs) Handles txtPagaCon.Leave
        If txtPagaCon.Text = "" Then
            txtPagaCon.Text = 0
        End If
    End Sub

    Private Sub txtPagaCon_TextChanged(sender As Object, e As EventArgs) Handles txtPagaCon.TextChanged

        Dim pagacon As Integer
        If txtPagaCon.Text = "" Then
            pagacon = 0
        Else
            pagacon = txtPagaCon.Text
        End If
        Dim total As Integer = txtTotal.Text
        Dim vuelto As Integer
        vuelto = pagacon - total
        txtVuelto.Text = vuelto

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        Try
            If txtTotal.Text = 0 Then
                txtVuelto.Text = 0
            End If
        Catch
        End Try
    End Sub


    Private Sub txtCantidadAgregar_Enter(sender As Object, e As EventArgs) Handles txtCantidadAgregar.Enter
        txtCantidadAgregar.BackColor = Color.FromArgb(191, 255, 0)
        If txtCantidadAgregar.Text = 0 Then
            txtCantidadAgregar.Text = 1
        End If
        txtCantidadAgregar.SelectAll()
    End Sub

    Private Sub txtCantidadAgregar_Leave(sender As Object, e As EventArgs) Handles txtCantidadAgregar.Leave
        txtCantidadAgregar.BackColor = Color.White
        If txtCantidadAgregar.Text = "" Then
            txtCantidadAgregar.Text = 0
        End If
    End Sub

    Private Sub txtCantidadAgregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadAgregar.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidadAgregar.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCodigoBarras.Enabled = True
            txtCodigoBarras.Focus()
        End If
    End Sub

    Private Sub txtCantidadAgregar_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadAgregar.TextChanged
        Try
            If txtCantidadAgregar.Text = 0 Then
                txtCantidadAgregar.Text = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarCodBarras_GotFocus(sender As Object, e As EventArgs) Handles btnBuscarCodBarras.GotFocus
        Call btnBuscarCodBarras.PerformClick()
        System.Threading.Thread.Sleep(300)
        Call btnAgregar.PerformClick()
    End Sub

    Private Sub txtCodigoBarras_Enter(sender As Object, e As EventArgs) Handles txtCodigoBarras.Enter
        txtCodigoBarras.Text = ""
    End Sub

    Private Sub txtPagaCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagaCon.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        grillaVenta.Rows.Clear()
        txtCantidadAgregar.Text = 1
        txtCodigoBarras.Text = ""
        txtCategoria.Text = ""
        txtCodigoProducto.Text = ""
        txtProducto.Text = ""
        txtStock.Text = 0
        txtPrecio.Text = 0
        txtValorCompra.Text = ""
        txtMarca.Text = ""
        txtCategoria.Text = ""
        txtBuscarProducto.Text = ""
        txtTotal.Text = 0
        txtPagaCon.Text = 0
        cmbCondicionesPago.SelectedIndex = 0
        txtVuelto.Text = 0
    End Sub

    Private Sub panelBuscarProducto_Paint(sender As Object, e As PaintEventArgs) Handles panelBuscarProducto.Paint

    End Sub
End Class