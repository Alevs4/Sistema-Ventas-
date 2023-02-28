Public Class Ventas

    Dim vAnularVenta As String

    Private Sub btnCerrarVentas_Click(sender As Object, e As EventArgs) Handles btnCerrarVentas.Click
        Me.Close()
        Form_Principal.btnVentas.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioNumBoleta.Checked = True
        Try
            SQL16("CALL SP_LISTAR_VENTAS")
            If DT16.Rows.Count >= 1 Then
                grillaVentas.DataSource = DS16.Tables(DT16.TableName)
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub


    Private Sub txtBuscar_Enter(sender As Object, e As EventArgs) Handles txtBuscar.Enter
        If txtBuscar.Text = "Buscar" Then
            txtBuscar.Text = ""
            txtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub grillaVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaVentas.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = CType(sender, DataGridView).CurrentRow
        vAnularVenta = grillaVentas.Item(0, e.RowIndex).Value
        '.... y demas campos que desees pasar a otros textbox

    End Sub

    Private Sub grillaVentas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaVentas.DataBindingComplete
        grillaVentas.ClearSelection()
        Dim i As Integer
        For i = 0 To grillaVentas.Columns.Count - 1
            grillaVentas.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        VentaNuevaFactura.ShowDialog()
    End Sub

    Private Sub grillaVentas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles grillaVentas.ColumnAdded
        e.Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Alineacion del contenido
    End Sub

    Private Sub grillaVentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grillaVentas.CellMouseClick
        Try
            Dim codigo As Integer
            codigo = grillaVentas.CurrentRow.Cells(0).Value
            SQL28("SP_CARGAR_DETALLE_DE_VENTA_REALIZADA('" & (codigo) & "')")
            If DT28.Rows.Count >= 1 Then
                grillaDetalle.DataSource = DS28.Tables(DT28.TableName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text = "Buscar" Or txtBuscar.Text = "" Then
            MsgBox("Escriba lo que desee buscar")
        Else
            If radioNumBoleta.Checked = True Then
                radioFecha.Checked = False
                radioTotal.Checked = False
                txtBuscar.Visible = True
                calendario1.Visible = False
                Try
                    SQL29("CALL SP_BUSCAR_VENTA_POR_NUM_BOLETA('" & (txtBuscar.Text) & "')")
                    If DT29.Rows.Count >= 1 Then
                        grillaVentas.DataSource = ""
                        grillaVentas.DataSource = DS29.Tables(DT29.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros con este Número de Boleta", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            ElseIf radioFecha.Checked = True Then
                txtBuscar.Text = Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd")
                radioNumBoleta.Checked = False
                radioTotal.Checked = False
                txtBuscar.Visible = True
                calendario1.Visible = True
                Try
                    SQL30("CALL SP_BUSCAR_VENTA_POR_FECHA('" & (txtBuscar.Text) & "')")
                    If DT30.Rows.Count >= 1 Then
                        grillaVentas.DataSource = ""
                        grillaVentas.DataSource = DS30.Tables(DT30.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros en el día seleccionado", MsgBoxStyle.Information, "Buscar Producto")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try

            ElseIf radioTotal.Checked = True Then
                radioNumBoleta.Checked = False
                radioFecha.Checked = False
                txtBuscar.Visible = True
                calendario1.Visible = False

                Try
                    SQL13("CALL SP_BUSCAR_VENTA_POR_TOTAL('" & (txtBuscar.Text) & "')")
                    If DT13.Rows.Count >= 1 Then
                        grillaVentas.DataSource = ""
                        grillaVentas.DataSource = DS13.Tables(DT13.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros asociados a este precio", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub radioNumBoleta_CheckedChanged(sender As Object, e As EventArgs) Handles radioNumBoleta.CheckedChanged
        If radioNumBoleta.Checked = True Then
            radioFecha.Checked = False
            radioTotal.Checked = False
            txtBuscar.Visible = True
            calendario1.Visible = False
            If radioFecha.Checked = True Then
                txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
            Else
                txtBuscar.ForeColor = Color.DarkGray
                txtBuscar.Text = "Buscar"
            End If
        End If
    End Sub

    Private Sub radioFecha_CheckedChanged(sender As Object, e As EventArgs) Handles radioFecha.CheckedChanged
        If radioFecha.Checked = True Then
            radioNumBoleta.Checked = False
            radioTotal.Checked = False
            txtBuscar.Visible = False
            calendario1.Visible = True
            txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
        End If
    End Sub

    Private Sub radioTotal_CheckedChanged(sender As Object, e As EventArgs) Handles radioTotal.CheckedChanged
        If radioTotal.Checked = True Then
            radioNumBoleta.Checked = False
            radioFecha.Checked = False
            txtBuscar.Visible = True
            calendario1.Visible = False
            If radioFecha.Checked = True Then
                txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
            Else
                txtBuscar.ForeColor = Color.DarkGray
                txtBuscar.Text = "Buscar"
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCargarNuevamente_Click(sender As Object, e As EventArgs) Handles btnCargarNuevamente.Click
        Try
            SQL16("CALL SP_LISTAR_VENTAS")
            If DT16.Rows.Count >= 1 Then
                grillaVentas.DataSource = DS16.Tables(DT16.TableName)
                conexion.Close()
                btnCargarNuevamente.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub calendario1_ValueChanged(sender As Object, e As EventArgs) Handles calendario1.ValueChanged
        txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
    End Sub

    Private Sub grillaDetalle_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaDetalle.DataBindingComplete
        grillaDetalle.ClearSelection()
        Dim i As Integer
        For i = 0 To grillaDetalle.Columns.Count - 1
            grillaDetalle.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub btnAnularVenta_Click(sender As Object, e As EventArgs) Handles btnAnularVenta.Click
        If MessageBox.Show("Con esta acción anulará la venta seleccionada" & (vbNewLine) & "¿Desea continuar?", "Anular Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                SQL56("CALL SP_ANULAR_VENTA('" & (vAnularVenta) & "')")
                MsgBox("Venta Anulada exitosamente")

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        End If
    End Sub


End Class