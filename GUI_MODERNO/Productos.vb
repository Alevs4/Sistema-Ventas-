Public Class Productos

    Dim vEliminar_Producto As Integer
    Dim vEditar_Producto As Integer

    Private Sub AbrirFormularioEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = Me.Controls.OfType(Of Miform)().FirstOrDefault 'Busca el formulario en la colección
        'Si formulario no fue necontrado / no existe

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Me.Controls.Add(Formulario)
            Me.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub btnCerrarForm1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form_Principal.btnProductos.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscar.Leave
        If txtBuscar.Text = "" Then
            txtBuscar.Text = "Buscar"
            txtBuscar.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtBuscar_Enter(sender As Object, e As EventArgs) Handles txtBuscar.Enter
        If txtBuscar.Text = "Buscar" Then
            txtBuscar.Text = ""
            txtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioCodProd.Checked = True
        Try
            SQL1("CALL SP_LISTAR_PRODUCTOS")
            If DT1.Rows.Count >= 1 Then
                grillaProducto.DataSource = DS1.Tables(DT1.TableName)
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If panelProdMarCat.Visible = False Then
            panelProdMarCat.Visible = True
        Else
            panelProdMarCat.Visible = False
        End If
    End Sub

    Private Sub grillaProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaProducto.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = CType(sender, DataGridView).CurrentRow
        txtProducto.Text = grillaProducto.Item(2, e.RowIndex).Value
        vEliminar_Producto = grillaProducto.Item(0, e.RowIndex).Value
        vEditar_Producto = grillaProducto.Item(0, e.RowIndex).Value
        '.... y demas campos que desees pasar a otros textbox
    End Sub

    Private Sub grillaProducto_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaProducto.DataBindingComplete
        grillaProducto.ClearSelection()
        Dim i As Integer
        For i = 0 To grillaProducto.Columns.Count - 1
            grillaProducto.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub btnCerrarProductos_Click(sender As Object, e As EventArgs) Handles btnCerrarProductos.Click
        Me.Close()
        Form_Principal.btnProductos.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub txtProducto_Click(sender As Object, e As EventArgs) Handles txtProducto.Click
        panelProdMarCat.Visible = False
    End Sub

    Private Sub btnEditarSeleccionado_Click(sender As Object, e As EventArgs) Handles btnEditarSeleccionado.Click
        panelProdMarCat.Visible = False
        If grillaProducto.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un producto a editar")
        Else
            Dim frm As New EditarProducto ' Creamos una instancia del formulario EditarProducto con el fin de pasar los datos de la grilla a este formulario
            frm.txtCodigoEditar.Text = grillaProducto.CurrentRow.Cells(0).Value.ToString()
            frm.txtBarrasEditar.Text = grillaProducto.CurrentRow.Cells(1).Value.ToString()
            frm.txtNombreEditar.Text = grillaProducto.CurrentRow.Cells(2).Value.ToString()
            frm.txtDescripcionEditar.Text = grillaProducto.CurrentRow.Cells(3).Value.ToString()
            frm.txtCantidadEditar.Text = grillaProducto.CurrentRow.Cells(4).Value.ToString()
            frm.txtPrecioEditar.Text = grillaProducto.CurrentRow.Cells(5).Value.ToString()
            frm.cmbCategoriaEditar.Text = grillaProducto.CurrentRow.Cells(6).Value.ToString()
            frm.cmbMarcaEditar.Text = grillaProducto.CurrentRow.Cells(7).Value.ToString()
            frm.ShowDialog()
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        panelProdMarCat.Visible = False
    End Sub

    Private Sub radioNombre_Click(sender As Object, e As EventArgs) Handles radioNombre.Click
        panelProdMarCat.Visible = False
        txtBuscar.ForeColor = Color.DarkGray
        txtBuscar.Text = "Buscar"
    End Sub

    Private Sub radioCodProd_Click(sender As Object, e As EventArgs) Handles radioCodProd.Click
        panelProdMarCat.Visible = False
        txtBuscar.ForeColor = Color.DarkGray
        txtBuscar.Text = "Buscar"
    End Sub

    Private Sub radioCodBarras_Click(sender As Object, e As EventArgs) Handles radioCodBarras.Click
        panelProdMarCat.Visible = False
        txtBuscar.ForeColor = Color.DarkGray
        txtBuscar.Text = "Buscar"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        panelProdMarCat.Visible = False
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        panelProdMarCat.Visible = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        panelProdMarCat.Visible = False
        If txtBuscar.Text = "Buscar" Then
            MsgBox("Escriba lo que desee buscar")
        Else
            If radioNombre.Checked = True Then
                radioCodProd.Checked = False
                radioCodBarras.Checked = False
                Try
                    SQL11("CALL SP_BUSCAR_PRODUCTO_POR_NOMBRE('" & (txtBuscar.Text) & "')")
                    If DT11.Rows.Count >= 1 Then
                        grillaProducto.DataSource = ""
                        grillaProducto.DataSource = DS11.Tables(DT11.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros con este Nombre", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            ElseIf radioCodProd.Checked = True Then
                radioNombre.Checked = False
                radioCodBarras.Checked = False
                If txtBuscar.TextLength > 11 Then
                    MsgBox("Código de producto no válido", MsgBoxStyle.Critical)
                    txtBuscar.Text = ""
                Else
                    Try
                        SQL12("CALL SP_BUSCAR_POR_CODIGO_PRODUCTO('" & (txtBuscar.Text) & "')")
                        If DT12.Rows.Count >= 1 Then
                            grillaProducto.DataSource = ""
                            grillaProducto.DataSource = DS12.Tables(DT12.TableName)
                            conexion.Close()
                            btnCargarNuevamente.Visible = True
                        Else
                            MsgBox("No se encuentran registros con este código de producto", MsgBoxStyle.Information, "Buscar Producto")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString())
                        conexion.Close()
                    End Try
                End If
            ElseIf radioCodBarras.Checked = True Then
                radioNombre.Checked = False
                radioCodProd.Checked = False
                Try
                    SQL13("CALL SP_BUSCAR_POR_CODIGO_BARRAS('" & (txtBuscar.Text) & "')")
                    If DT13.Rows.Count >= 1 Then
                        grillaProducto.DataSource = ""
                        grillaProducto.DataSource = DS13.Tables(DT13.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros con este código de barras", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub grillaProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles grillaProducto.MouseClick
        panelProdMarCat.Visible = False
    End Sub

    Private Sub btnEliminarSeleccionado_Click(sender As Object, e As EventArgs) Handles btnEliminarSeleccionado.Click
        panelProdMarCat.Visible = False
        If grillaProducto.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un producto a eliminar", MsgBoxStyle.Information)
        Else
            Try
                If MessageBox.Show("Con esta acción eliminará el producto seleccionado" & (vbNewLine) & "¿Desea continuar?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Crear respuesta para el MSGBOX

                    SQL6("CALL SP_ELIMINAR_PRODUCTO('" & (vEliminar_Producto) & "')")
                    conexion.Close()
                    MsgBox("Producto eliminado exitosamente", MsgBoxStyle.OkOnly)
                Else
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox("Imposible eliminar registro. El producto seleccionado para eliminación se encuentra ligado a un detalle de venta.", MsgBoxStyle.Critical, "Eliminar Producto")
                conexion.Close()
            End Try
            Try
                SQL1("CALL SP_LISTAR_PRODUCTOS")
                If DT1.Rows.Count >= 1 Then
                    grillaProducto.DataSource = ""
                    grillaProducto.DataSource = DS1.Tables(DT1.TableName)
                    conexion.Close()
                    btnCargarNuevamente.Visible = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        End If
    End Sub


    Private Sub btnPanelProducto_Click(sender As Object, e As EventArgs) Handles btnPanelProducto.Click
        AgregarProducto.Owner = Me
        AgregarProducto.ShowDialog()
        panelProdMarCat.Visible = False
    End Sub

    Private Sub btnPanelMarca_Click(sender As Object, e As EventArgs) Handles btnPanelMarca.Click
        AgregarMarca.Owner = Me
        AgregarMarca.ShowDialog()
        panelProdMarCat.Visible = False
    End Sub

    Private Sub btnPanelCategoria_Click(sender As Object, e As EventArgs) Handles btnPanelCategoria.Click
        AgregarCategoria.Owner = Me
        AgregarCategoria.ShowDialog()
        panelProdMarCat.Visible = False
    End Sub

    Private Sub btnCargarNuevamente_Click(sender As Object, e As EventArgs) Handles btnCargarNuevamente.Click
        Try
            SQL1("CALL SP_LISTAR_PRODUCTOS")
            If DT1.Rows.Count >= 1 Then
                grillaProducto.DataSource = ""
                grillaProducto.DataSource = DS1.Tables(DT1.TableName)
                conexion.Close()
                btnCargarNuevamente.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If radioNombre.Checked = False Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub grillaProducto_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grillaProducto.CellFormatting
        If grillaProducto.Rows(e.RowIndex).Cells("Cantidad en Stock").Value.ToString = 0 Then
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.BackColor = Color.Red
        ElseIf grillaProducto.Rows(e.RowIndex).Cells("Cantidad en Stock").Value.ToString < 5 Then
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.Yellow
        End If

    End Sub


End Class