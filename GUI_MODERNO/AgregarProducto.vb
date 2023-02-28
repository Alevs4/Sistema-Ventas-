Imports System.Runtime.InteropServices

Public Class AgregarProducto

    Dim valorCMBMarca As String
    Dim valorCMBCategoria As String
    Dim indexMarca As Integer
    Dim indexCategoria As Integer
    Dim ID_cod_prod As Integer
    Dim ID_lote As Integer
    Dim textoBarras As String


    Sub ObtenerCategorias() ' Función para retornar las categorías
        Try
            SQL3("CALL SP_CATEGORIAS") ' Realiza la consulta SQL
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then ' Si hay datos continua...
                Me.cmbCategoria.Items.Clear() ' Limpia el combobox Categoría
                Dim fila As DataRow ' Declara una variable para recorrer el la tabla devuelta por la consulta

                ' Por cada fila se que recorra en la tabla, la variable "fila" tomara los items de
                ' la columna "categoria" y los trasparasará al combobox categoría
                For Each fila In DS3.Tables(DT3.TableName).Rows
                    cmbCategoria.Items.Add(fila("categoria"))
                Next
                conexion.Close()
            End If
        Catch ex As Exception ' De existir algun error se mostrará un mensaje
            MsgBox(ex.Message.ToString())
            conexion.Close() ' Se cierra la conexion para seguridad
        End Try
    End Sub

    Sub ObtenerMarcas() ' Función para retornar las marcas
        Try
            SQL4("CALL SP_MARCAS") ' Realiza la consulta SQL
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then ' Si hay datos continua...
                Me.cmbMarca.Items.Clear() ' Limpia el combobox Marcas
                Dim fila As DataRow ' Declara una variable para recorrer el la tabla devuelta por la consulta

                ' Por cada fila se que recorra en la tabla, la variable "fila" tomara los items de
                ' la columna "marca" y los trasparasará al combobox marca
                For Each fila In DS4.Tables(DT4.TableName).Rows
                    cmbMarca.Items.Add(fila("marca"))
                Next
                conexion.Close() ' Se cierra la conexion para seguridad
            End If
        Catch ex As Exception ' De existir algun error se mostrará un mensaje
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Sub obtenerIDProducto() 'Funcion para retornar los códigos autonuméricos
        Try

            ' Realiza la consulta para obtener código de producto
            SQL5("CALL SP_OBTENER_CODIGO_PRODUCTO")

            ' Si la consulta nos da como resultado nada....
            If TypeOf (DS5.Tables(DT5.TableName).Rows(0).Item("MAX(productos.cod_prod)")) Is DBNull Then
                ID_cod_prod = 1 ' ... ID_cod_prod tomará el valor 1....
            Else
                '... de lo ID_cod_prod contrario tomará el valor obtenido y le suma uno
                ID_cod_prod = DS5.Tables(DT5.TableName).Rows(0).Item("MAX(productos.cod_prod)") + 1
            End If

            ' Realiza la consulta para obtener el lote siguiente
            SQL25("CALL SP_OBTENER_CODIGO_LOTE_SIGUIENTE")

            ' Si la consulta nos da como resultado nada....
            If TypeOf (DS25.Tables(DT25.TableName).Rows(0).Item("MAX(id_lote)")) Is DBNull Then
                ID_lote = 1 ' ... ID_lote tomará el valor 1....
            Else
                '... de lo ID_lote contrario tomará el valor obtenido y le suma uno
                ID_lote = DS25.Tables(DT25.TableName).Rows(0).Item("MAX(id_lote)") + 1
            End If
            txtCodigoProducto.Text = ID_cod_prod ' El textbox codigo producto toma el valor de la variable
            txtLote.Text = ID_lote ' El textbox lote toma el valor de la variable
            conexion.Close() ' Se cierra la conexion para seguridad

        Catch ex As Exception ' De existir algun error se mostrará un mensaje
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        ' Limpia los texbox y cierra el formulario
        txtCodigoProducto.Text = ""
        txtNombreProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        Me.Close()
    End Sub


    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Al cargar el formulario, establece los parametros y ejecuta las funciones especificadas
        cmbCategoria.Text = "--Elija una Categoria--"
        cmbMarca.Text = "--Elija una Marca--"
        ObtenerCategorias()
        ObtenerMarcas()
        obtenerIDProducto()
        txtBarras.Focus()
        sugerido.Text = 0
        txtPrecioCompra.Text = 0
    End Sub

    Private Sub cmbMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbMarca.KeyDown

        valorCMBMarca = cmbMarca.Text
        If e.KeyCode <> Keys.Enter Then
            Me.cmbMarca.Text = valorCMBMarca
        End If
    End Sub

    Private Sub cmbCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategoria.KeyDown
        valorCMBCategoria = cmbCategoria.Text
        If e.KeyCode <> Keys.Enter Then
            Me.cmbCategoria.Text = valorCMBCategoria
        End If
    End Sub

    Private Sub cmbCategoria_TextChanged(sender As Object, e As EventArgs) Handles cmbCategoria.TextChanged
        If Len(valorCMBCategoria) > 0 Then
            Me.cmbCategoria.Text = valorCMBCategoria
        End If
    End Sub

    Private Sub cmbMarca_TextChanged(sender As Object, e As EventArgs) Handles cmbMarca.TextChanged
        If Len(valorCMBMarca) > 0 Then
            Me.cmbMarca.Text = valorCMBMarca
        End If
    End Sub

    Private Sub txtPrecioCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        ' Solo admitir dígitos
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress

        ' Solo admitir dígitos
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress

        ' Solo admitir numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
        ' Obtiene el índice del item selecionado en el combobox y le suma uno, para poder ingresarlo en la BD
        indexMarca = cmbMarca.SelectedIndex
        indexMarca = indexMarca + 1
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        ' Obtiene el índice del item selecionado en el combobox y le suma uno, para poder ingresarlo en la BD
        indexCategoria = cmbCategoria.SelectedIndex
        indexCategoria = indexCategoria + 1
    End Sub

    Private Sub txtBarras_LostFocus(sender As Object, e As EventArgs) Handles txtBarras.LostFocus

        'Cuando pierde el foco, el siguiente control en obtenerlo es el textbox de nombre
        txtBarras.Enabled = True
        txtNombreProducto.Focus()
    End Sub


    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        ' De deben cumplir las siguientes condiciones para poder ejecutar el codigo....
        If txtCodigoProducto.Text <> "" And txtNombreProducto.Text <> "" And txtPrecio.Text <> "" And txtPrecioCompra.Text <> "" And txtCantidad.Text <> "" And cmbMarca.Text <> "--Elija una Marca--" And cmbCategoria.Text <> "--Elija una Categoria--" Then
            Try
                ' Si al momento de ingresar el producto el textbox no tiene ningun codigo de barras, se ingresara un string "Sin código de barras"
                If txtBarras.Text = "" Then
                    txtBarras.Text = "Sin código de barras"
                End If

                ' Se toman los parametros y se envian al procedimiento almacenado
                SQL2("CALL SP_AGREGAR_PRODUCTO('" & (txtCodigoProducto.Text) & "','" & (txtBarras.Text) & "','" & (txtNombreProducto.Text) & "','" & (txtDescripcion.Text) & "','" & (txtCantidad.Text) & "','" & (txtPrecio.Text) & "','" & (txtPrecioCompra.Text) & "','" & (indexCategoria) & "','" & (indexMarca) & "')")
                conexion.Close() ' Se cierra conexion por seguridad

                ' Si el checkbox vencimiento esta checkado, entonces se ingresa el lote correspondiente al producto, si no, no
                If chkVencimiento.Checked = True Then
                    Try
                        ' Procedimientos almacenados con sus respectivos parametros de entrada
                        SQL25("CALL SP_VENCIMIENTO_LOTE('" & (Convert.ToDateTime(Date.Today).ToString("yyyy-MM-dd")) & "','" & (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd")) & "')")
                        SQL37("CALL SP_GUARDAR_DETALLE_VENCIMIENTO_LOTE('" & (txtCodigoProducto.Text) & "','" & (txtLote.Text) & "')")
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString())
                        conexion.Close() ' Se cierra conexion por seguridad
                    End Try
                End If

                ' Una vez finalizadas las consultas, se envia un mensaje para aceptar
                ' Se limpian y resetean controles
                ' Se obtienen codigos e ID's
                MsgBox("Producto agregado correctamente", MsgBoxStyle.Information)
                txtCodigoProducto.Text = ""
                txtNombreProducto.Text = ""
                txtBarras.Text = ""
                txtPrecio.Text = ""
                txtPrecioCompra.Text = ""
                txtCantidad.Text = ""
                txtDescripcion.Text = ""
                cmbCategoria.Text = "--Elija una Categoria--"
                cmbMarca.Text = "--Elija una Marca--"
                obtenerIDProducto()

                ' Una vez que termina el paso anterior, refresca la grilla de productos
                Try
                    Productos.grillaProducto.Rows.Clear() ' LImpia la grilla productos
                    SQL1("CALL SP_LISTAR_PRODUCTOS") ' Se realiza la consulta
                    If DT1.Rows.Count >= 1 Then ' Si la consulta devuelve datos
                        ' Se carga la grilla productos con la tabla
                        Productos.grillaProducto.DataSource = DS1.Tables(DT1.TableName)
                        conexion.Close() ' Se cierra conexion por seguridad
                    End If
                Catch
                End Try
            Catch ex As Exception ' De existir algun error en todo el proceso se enviará un mensaje
                MsgBox(ex.Message.ToString())
                conexion.Close() ' Se cierra conexion por seguridad
            End Try
            Try
                SQL26("CALL SP_LISTAR_LOTES_POR_VENCER()")
                If DT26.Rows.Count >= 1 Then
                    Form_Principal.grillaVencimientos.DataSource = DS26.Tables(DT26.TableName)
                    conexion.Close() ' Se cierra conexion por seguridad
                End If
            Catch
            End Try
        Else '.... si no pedirá completar los campos
            MsgBox("Debe completar todos los campos antes de agregar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmbMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMarca.KeyPress
        ' Prohibición para escribir en el combobox
        e.KeyChar = ""
    End Sub

    Private Sub cmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategoria.KeyPress
        ' Prohibición para escribir en el combobox
        e.KeyChar = ""
    End Sub

    Private Sub chkVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkVencimiento.CheckedChanged

        ' Condicional para habilitar o deshabilitar el calendario
        If chkVencimiento.Checked = True Then
            calendario1.Enabled = True
            calendario1.ResetText()
        Else
            calendario1.Enabled = False
            calendario1.Text = ""
        End If
    End Sub

    Private Sub txtBarras_Leave(sender As Object, e As EventArgs) Handles txtBarras.Leave

        ' Para evitar que se ingrese un producto que ya esté en base de datos
        ' realizamos una consulta SQL a la base de datos al dejar el control TXTBARRAS
        ' ademas, en este mismo evento, podemos mandar mensaje sugerente que nos indica que podemos ingresar
        ' un código de barras al producto, en caso de tenerlo

        If txtBarras.Text <> "" Then
            Try
                SQL13("CALL SP_BUSCAR_POR_CODIGO_BARRAS('" & (txtBarras.Text) & "')")
                If DT13.Rows.Count >= 1 Then
                    lblEstado.Text = "Este producto ya se encuentra registrado"
                    btnAgregarProducto.Enabled = False ' Si ya existe codigo, el boton "Agregar Producto" se deshablita
                    conexion.Close()
                ElseIf DT13.Rows.Count = 0 Then
                    btnAgregarProducto.Enabled = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        Else
            lblEstado.Text = "Si su producto tiene código de barras ingréselo."
            btnAgregarProducto.Enabled = True
        End If

    End Sub

    Private Sub txtPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCompra.TextChanged

        ' A medida que ingresemos el precio de compra de producto, podemos dar el porncentaje de ganancia sugerido
        ' el cual se copiara al textbox "Precio de Venta", el cual puede ser modificado para el ingreso manual.

        ' Variables a trabjar
        Dim precio_venta As Double
        Dim porcentaje As Double
        Try
            ' Si el precio de compra distinto a vacio se ejecutará el código
            If txtPrecioCompra.Text <> "" Then
                porcentaje = txtPrecioCompra.Text * (NUM1.Value / 100)
                precio_venta = txtPrecioCompra.Text + porcentaje
                sugerido.Text = precio_venta
                txtPrecio.Text = sugerido.Text
            Else '... Si no, el sugerido es 0 pesos
                sugerido.Text = 0
                txtPrecio.Text = 0
            End If
        Catch
        End Try
    End Sub

    Private Sub NUM1_ValueChanged(sender As Object, e As EventArgs) Handles NUM1.ValueChanged

        ' Si el porcentaje de ganacia cambia, tambien lo hara el precio de venta respecto al precio de compra
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


End Class