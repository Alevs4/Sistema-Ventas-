Public Class EditarProducto

    Dim valorCMBMarca As String
    Dim valorCMBCategoria As String
    Dim indexMarca As Integer
    Dim indexCategoria As Integer
    Dim ID_cod_prod As Integer
    Dim textoBarras As String
    Dim vCodigoEditar As Integer
    Dim stockActual As Integer

    Sub ObtenerCategorias() ' Funcion que devuelve las categorias
        Try
            SQL3("CALL SP_CATEGORIAS")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Me.cmbCategoriaEditar.Items.Clear()
                Dim fila As DataRow
                For Each fila In DS3.Tables(DT3.TableName).Rows
                    cmbCategoriaEditar.Items.Add(fila("categoria"))
                Next
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Sub ObtenerMarcas() ' Funcion que devuelve las marcas
        Try
            SQL4("CALL SP_MARCAS")
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                Me.cmbMarcaEditar.Items.Clear()
                Dim fila As DataRow
                For Each fila In DS4.Tables(DT4.TableName).Rows
                    cmbMarcaEditar.Items.Add(fila("marca"))
                Next
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        ' Limpiamos campos y cerramos formulario
        txtCodigoEditar.Text = ""
        txtNombreEditar.Text = ""
        txtPrecioEditar.Text = ""
        txtCantidadEditar.Text = ""
        Me.Close()
    End Sub


    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' En el evento LOAD del formulario, establecemos datos, cargamos funciones, y ejecutamos consulta SQL
        cmbCategoriaEditar.Text = "--Elija una Categoria--"
        cmbMarcaEditar.Text = "--Elija una Marca--"
        ObtenerCategorias()
        ObtenerMarcas()
        txtNombreEditar.Focus()
        Dim id_lote As Integer

        ' Obtenemos codigo de lote siguiente, en caso de que queramos editar el producto con lote
        Try
            SQL25("CALL SP_OBTENER_CODIGO_LOTE_SIGUIENTE")
            If TypeOf (DS25.Tables(DT25.TableName).Rows(0).Item("MAX(id_lote)")) Is DBNull Then
                id_lote = 1
            Else
                id_lote = DS25.Tables(DT25.TableName).Rows(0).Item("MAX(id_lote)")
            End If
            'lblContador.Text = "El ultimo código registrado fue " & (ID_cod_prod - 1) & ". El codigo siguiente es:"
            txtLote.Text = id_lote + 1
            conexion.Close() ' Se cierra conexion por seguridad
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close() ' Se cierra conexion por seguridad
        End Try
    End Sub

    Private Sub cmbMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbMarcaEditar.KeyDown

        valorCMBMarca = cmbMarcaEditar.Text
        If e.KeyCode <> Keys.Enter Then
            Me.cmbMarcaEditar.Text = valorCMBMarca
        End If
    End Sub

    Private Sub cmbCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategoriaEditar.KeyDown
        valorCMBCategoria = cmbCategoriaEditar.Text
        If e.KeyCode <> Keys.Enter Then
            Me.cmbCategoriaEditar.Text = valorCMBCategoria
        End If
    End Sub

    Private Sub cmbCategoria_TextChanged(sender As Object, e As EventArgs) Handles cmbCategoriaEditar.TextChanged
        If Len(valorCMBCategoria) > 0 Then
            Me.cmbCategoriaEditar.Text = valorCMBCategoria
        End If
    End Sub

    Private Sub cmbMarca_TextChanged(sender As Object, e As EventArgs) Handles cmbMarcaEditar.TextChanged
        If Len(valorCMBMarca) > 0 Then
            Me.cmbMarcaEditar.Text = valorCMBMarca
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioEditar.KeyPress

        ' Validacion para solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadEditar.KeyPress

        ' Validacion para solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarcaEditar.SelectedIndexChanged
        ' Al seleccionar el item del combobox se suma uno, para hacer coincidir con BD
        indexMarca = cmbMarcaEditar.SelectedIndex
        indexMarca = indexMarca + 1
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoriaEditar.SelectedIndexChanged
        ' Al seleccionar el item del combobox se suma uno, para hacer coincidir con BD
        indexCategoria = cmbCategoriaEditar.SelectedIndex
        indexCategoria = indexCategoria + 1
    End Sub


    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarProducto.Click
        ' Se pregunta por las condiciones siguientes...
        If txtNombreEditar.Text <> "" And txtPrecioEditar.Text <> "" And txtCantidadEditar.Text <> "" And cmbMarcaEditar.Text <> "--Elija una Marca--" And cmbCategoriaEditar.Text <> "--Elija una Categoria--" Then
            Try
                ' Se ingresan los parametros de entrada al procedimiento almacenado para editar el producto segun su codigo
                SQL14("CALL SP_EDITAR_PRODUCTO('" & (txtCodigoEditar.Text) & "','" & (txtBarrasEditar.Text) & "','" & (txtNombreEditar.Text) & "','" & (txtDescripcionEditar.Text) & "','" & (txtCantidadEditar.Text) & "','" & (txtPrecioEditar.Text) & "','" & (indexCategoria) & "','" & (indexMarca) & "')")
                conexion.Close() ' Se cierra conexion por seguridad

                ' Si chkVencimiento esta marcado, se guardara un lote a vencer con el respectivo detalle
                If chkVencimiento.Checked = True Then
                    Try
                        SQL25("CALL SP_VENCIMIENTO_LOTE('" & (Convert.ToDateTime(Date.Today).ToString("yyyy-MM-dd")) & "','" & (Convert.ToDateTime(calendario2.Text).ToString("yyyy-MM-dd")) & "')")
                        SQL37("CALL SP_GUARDAR_DETALLE_VENCIMIENTO_LOTE('" & (txtCodigoEditar.Text) & "','" & (txtLote.Text) & "')")
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString())
                        conexion.Close() ' Se cierra conexion por seguridad
                    End Try
                End If
                Try
                    SQL1("CALL SP_LISTAR_PRODUCTOS()") ' Listamos los productos nuevamente para mostrar los datos editados
                    Productos.grillaProducto.Rows.Clear()
                    If DT1.Rows.Count >= 1 Then
                        Productos.grillaProducto.DataSource = DS1.Tables(DT1.TableName)
                        conexion.Close() ' Se cierra conexion por seguridad
                    End If
                Catch ex As Exception ' En caso de encontrarse algun error se mostrará el mensaje
                    conexion.Close() ' Se cierra conexion por seguridad
                End Try
                Try
                    SQL26("CALL SP_LISTAR_LOTES_POR_VENCER()") ' Listamos los lotes nuevamente para mostrar nuevos cambios en caso de haberlos
                    If DT26.Rows.Count >= 1 Then
                        Form_Principal.grillaVencimientos.DataSource = DS26.Tables(DT26.TableName)
                        conexion.Close() ' Se cierra conexion por seguridad
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString()) ' En caso de encontrarse algun error se mostrará el mensaje
                    conexion.Close() ' Se cierra conexion por seguridad
                End Try
                MsgBox("Producto editado correctamente", MsgBoxStyle.Information)
                Me.Close()
            Catch ex As Exception ' En caso de encontrarse algun error se mostrará el mensaje
                MsgBox(ex.Message.ToString())
                conexion.Close() ' Se cierra conexion por seguridad
            End Try
        Else '... Si alguna condicion no se cumple, pedira revisar y que los campos se completen
            MsgBox("Debe completar todos los campos antes de editar", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub chkVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkVencimiento.CheckedChanged

        ' Condición para definir si calendario está activado o no, dependiendo del estado del chkVencimiento
        If chkVencimiento.Checked = True Then
            calendario2.Enabled = True
        Else
            calendario2.Enabled = False
        End If
    End Sub
End Class