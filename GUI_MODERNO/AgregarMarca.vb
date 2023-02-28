Public Class AgregarMarca


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' Botón Cerrar: Limpia el textbox para agregar marca y luego cierra el formulario
        txtAgregarMarca.Text = ""
        Me.Close()
    End Sub

    Private Sub btnAceptarMarca_Click(sender As Object, e As EventArgs) Handles btnAceptarMarca.Click
        'Si el textbox categoría es distinto a vacío, continua....
        If txtAgregarMarca.Text <> "" Then

            ' Consulta si la marca existe en sistema
            SQL9("CALL SP_CONSULTAR_MARCAS('" & (txtAgregarMarca.Text) & "')")
            conexion.Close()
            If DT9.Rows.Count >= 1 Then
                lblEstado.Text = "Esta marca ya se encuentra en sistema"
                lblEstado.Visible = True
                txtAgregarMarca.Text = ""
                txtAgregarMarca.Focus()
            Else '.... si no hay datos en sistema, procede a ingresar la marca a la tabla "MARCAS"

                ' Intenta agregar la marca, de existir algun error, se mostrará en pantalla
                Try
                    SQL10("CALL SP_AGREGAR_MARCA('" & (txtAgregarMarca.Text) & "')")
                    conexion.Close()
                    MsgBox("Marca agregada correctamente", MsgBoxStyle.Information)
                    txtAgregarMarca.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            End If
        Else '.... si no, pide escribir la categoria a agregar
            MsgBox("Debe escribir una Marca a agregar", MsgBoxStyle.Exclamation)
            txtAgregarMarca.Text = ""
        End If
    End Sub
End Class