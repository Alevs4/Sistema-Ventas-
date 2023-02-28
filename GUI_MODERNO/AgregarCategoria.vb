Public Class AgregarCategoria

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' Botón Cerrar: Limpia el textbox para agregar categoría y luego cierra el formulario
        txtAgregarCategoria.Text = ""
        Me.Close()
    End Sub

    Private Sub btnAceptarCategoria_Click(sender As Object, e As EventArgs) Handles btnAceptarCategoria.Click
        'Si el textbox categoría es distinto a vacío, continua....
        If txtAgregarCategoria.Text <> "" Then

            ' Consulta si la categoría existe en sistema
            SQL8("CALL SP_CONSULTAR_CATEGORIAS('" & (txtAgregarCategoria.Text) & "')")
            conexion.Close()

            'Si se devuelven datos, indica que la categoría ya se encuentra en sistema....
            If DT8.Rows.Count >= 1 Then
                lblEstado.Text = "Esta categoría ya se encuentra en sistema"
                lblEstado.Visible = True
                txtAgregarCategoria.Text = ""
                txtAgregarCategoria.Focus()
            Else '.... si no hay datos en sistema, procede a ingresar la categoría a la tabla "CATEGORIAS"

                ' Intenta agregar la categoría, de existir algun error, se mostrará en pantalla
                Try
                    SQL7("CALL SP_AGREGAR_CATEGORIA('" & (txtAgregarCategoria.Text) & "')")
                    conexion.Close()
                    MsgBox("Categoría agregada correctamente", MsgBoxStyle.Information)
                    txtAgregarCategoria.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            End If

        Else '.... si no, pide escribir la categoria a agregar
            MsgBox("Debe escribir una Categoría a agregar", MsgBoxStyle.Exclamation)
            txtAgregarCategoria.Text = ""
        End If
    End Sub

End Class