Public Class Reporte

    Dim y As Integer

    Private Sub ReporteDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = Date.Today
        lblFechaHoy.Text = Date.Today
        lblFechaInicio.Text = ""
        lblFechaHasta.Text = ""
        lblVentas.Text = ""
        lblIngresos.Text = ""
        lblCostos.Text = ""
        lblIngresos.Text = ""
        lblGanancias.Text = ""
        lblUsuario.Text = Form_Principal.lblUsuario.Text
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If chkHoy.Checked = True Then
            SQL55("CALL SP_REPORTE_DIARIO('" & (Convert.ToDateTime(Date.Today).ToString("yyyy-MM-dd")) & "')")
            conexion.Close()
            Try
                If DT55.Rows.Count >= 1 Then
                    For i = 0 To DS55.Tables(DT55.TableName).Rows.Count - 1
                        lblCostos.Text = ""
                        lblIngresos.Text = ""
                        lblCostos.Text = DS55.Tables(DT55.TableName).Rows(0).Item("Costo")
                        lblIngresos.Text = DS55.Tables(DT55.TableName).Rows(0).Item("Total")
                    Next

                    SQL55("SP_CUENTA_VENTAS('" & (Convert.ToDateTime(Date.Today).ToString("yyyy-MM-dd")) & "')")
                    conexion.Close()
                    If DT55.Rows.Count >= 1 Then
                        For i = 0 To DS55.Tables(DT55.TableName).Rows.Count - 1
                            lblFechaInicio.Text = (Convert.ToDateTime(Date.Today).ToString("yyyy-MM-dd"))
                            lblFechaHasta.Text = (Convert.ToDateTime(Date.Today).ToString("yyyy-MM-dd"))
                            lblVentas.Text = ""
                            lblVentas.Text = DS55.Tables(DT55.TableName).Rows(0).Item("Ventas")
                        Next

                    End If

                End If
                lblGanancias.Text = lblIngresos.Text - lblCostos.Text
            Catch ex As Exception
                MsgBox("No hay registros para mostrar con la fecha de hoy")
            End Try

        ElseIf chkRango.Checked = True Then
            Try
                SQL55("CALL SP_REPORTE_RANGO('" & (Convert.ToDateTime(cal1.Text).ToString("yyyy-MM-dd")) & "','" & (Convert.ToDateTime(cal2.Text).ToString("yyyy-MM-dd")) & "')")
                conexion.Close()
                If DT55.Rows.Count >= 1 Then
                    For i = 0 To DS55.Tables(DT55.TableName).Rows.Count - 1
                        lblCostos.Text = ""
                        lblIngresos.Text = ""
                        lblCostos.Text = DS55.Tables(DT55.TableName).Rows(0).Item("Costo")
                        lblIngresos.Text = DS55.Tables(DT55.TableName).Rows(0).Item("Total")
                    Next
                    SQL55("SP_CUENTA_VENTAS_RANGO('" & (Convert.ToDateTime(cal1.Text).ToString("yyyy-MM-dd")) & "','" & (Convert.ToDateTime(cal2.Text).ToString("yyyy-MM-dd")) & "')")
                    conexion.Close()
                    If DT55.Rows.Count >= 1 Then
                        For i = 0 To DS55.Tables(DT55.TableName).Rows.Count - 1
                            lblFechaInicio.Text = (Convert.ToDateTime(cal1.Text).ToString("yyyy-MM-dd"))
                            lblFechaHasta.Text = (Convert.ToDateTime(cal2.Text).ToString("yyyy-MM-dd"))
                            lblVentas.Text = ""
                            lblVentas.Text = DS55.Tables(DT55.TableName).Rows(0).Item("Ventas")
                        Next
                    End If
                End If

                lblGanancias.Text = lblIngresos.Text - lblCostos.Text
            Catch ex As Exception
                MsgBox("No hay registros para mostrar con el rango de fecha seleccionado")
            End Try
        End If
    End Sub

    Private Sub chkHoy_CheckedChanged(sender As Object, e As EventArgs) Handles chkHoy.CheckedChanged
        If chkHoy.Checked = True Then
            chkRango.Checked = False
        End If
    End Sub

    Private Sub chkRango_CheckedChanged(sender As Object, e As EventArgs) Handles chkRango.CheckedChanged
        If chkRango.Checked = True Then
            chkHoy.Checked = False
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel2.Width, Me.Panel2.Height)

        Panel2.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel2.Height += y
            Try
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox("Error al imprimir. Otro proceso está utilizando el archivo especificado. (Sugerencia) Cambie el nombre al archivo a guardar.")
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class