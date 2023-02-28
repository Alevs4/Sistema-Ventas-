Public Class MantenedorMarcaCategoria
    Private Sub MantenedorMarcaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SQL4("CALL SP_CATEGORIAS()")
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                Me.ListBox1.Items.Clear()
                Dim fila As DataRow
                For Each fila In DS4.Tables(DT4.TableName).Rows
                    ListBox1.Items.Add(fila("categoria"))
                Next
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
        Try
            SQL3("CALL SP_MARCAS()")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Me.ListBox2.Items.Clear()
                Dim fila As DataRow
                For Each fila In DS3.Tables(DT3.TableName).Rows
                    ListBox2.Items.Add(fila("marca"))
                Next
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificarCat_Click(sender As Object, e As EventArgs) Handles btnModificarCat.Click
        If txtModCat.Text <> "" And ListBox1.SelectedItem IsNot Nothing Then
            Try
                SQL53("CALL SP_MODIFICAR_CATEGORIA('" & (ListBox1.SelectedItem) & "','" & (txtModCat.Text) & "')")
                MsgBox("Categoría modificada exitosamente")
                conexion.Close()
                Try
                    SQL4("CALL SP_CATEGORIAS()")
                    If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                        Me.ListBox1.Items.Clear()
                        Dim fila As DataRow
                        For Each fila In DS4.Tables(DT4.TableName).Rows
                            ListBox1.Items.Add(fila("categoria"))
                        Next
                        conexion.Close()
                    End If
                    txtModCat.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()

                End Try
            Catch ex As Exception
                MsgBox("Ocurrió un error al modificar la categoria.")
                conexion.Close()
            End Try
        Else
            MsgBox("Debe seleccionar una categoría y escribir el nuevo nombre de ella")
        End If
    End Sub

    Private Sub btnEliminarCat_Click(sender As Object, e As EventArgs) Handles btnEliminarCat.Click

        If ListBox1.SelectedItem IsNot Nothing Then
            Try
                SQL54("CALL SP_ELIMINAR_CATEGORIA('" & (ListBox1.SelectedItem) & "')")
                MsgBox("Categoría eliminada exitosamente")
                conexion.Close()
                Try
                    SQL4("CALL SP_CATEGORIAS()")
                    If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                        Me.ListBox1.Items.Clear()
                        Dim fila As DataRow
                        For Each fila In DS4.Tables(DT4.TableName).Rows
                            ListBox1.Items.Add(fila("categoria"))
                        Next
                        conexion.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            Catch ex As Exception
                MsgBox("Imposible borrar categoría. Uno o varios productos se encuentran includos en esta categoría.")
                conexion.Close()
            End Try
        Else
            MsgBox("Debe seleccionar una categoría")
        End If

    End Sub

    Private Sub btnModifcarMarca_Click(sender As Object, e As EventArgs) Handles btnModifcarMarca.Click
        If txtModMar.Text <> "" And ListBox2.SelectedItem IsNot Nothing Then
            Try
                SQL53("CALL SP_MODIFICAR_MARCA('" & (ListBox2.SelectedItem) & "','" & (txtModMar.Text) & "')")
                MsgBox("Marca modificada exitosamente")
                conexion.Close()
                Try
                    SQL3("CALL SP_MARCAS()")
                    If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                        Me.ListBox2.Items.Clear()
                        Dim fila As DataRow
                        For Each fila In DS3.Tables(DT3.TableName).Rows
                            ListBox2.Items.Add(fila("marca"))
                        Next
                        conexion.Close()
                    End If
                    txtModMar.Clear()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()

                End Try
            Catch ex As Exception
                MsgBox("Ocurrió un error al modificar la marca.")
                conexion.Close()
            End Try
        Else
            MsgBox("Debe seleccionar una marca y escribir el nuevo nombre de ella")
        End If
    End Sub

    Private Sub btnEliminarMarca_Click(sender As Object, e As EventArgs) Handles btnEliminarMarca.Click
        If ListBox2.SelectedItem IsNot Nothing Then
            Try
                SQL54("CALL SP_ELIMINAR_MARCA('" & (ListBox2.SelectedItem) & "')")
                MsgBox("Marca eliminada exitosamente")
                conexion.Close()
                Try
                    SQL3("CALL SP_MARCAS()")
                    If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                        Me.ListBox2.Items.Clear()
                        Dim fila As DataRow
                        For Each fila In DS3.Tables(DT3.TableName).Rows
                            ListBox2.Items.Add(fila("marca"))
                        Next
                        conexion.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            Catch ex As Exception
                MsgBox("Imposible borrar Marca. Uno o varios productos se encuentran includos en esta Marca.")
                conexion.Close()
            End Try
        Else
            MsgBox("Debe seleccionar una marca")
        End If
    End Sub
End Class