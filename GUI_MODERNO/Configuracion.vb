Public Class Configuracion


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        ' Establece al formulario como propio al formulario configuracion y 
        ' lo abre como cuadro de dialogo
        MantenedorUsuarios.Owner = Me
        MantenedorUsuarios.ShowDialog()
    End Sub

    Private Sub btnCerrarProductos_Click(sender As Object, e As EventArgs) Handles btnCerrarConfig.Click

        'Cierra el formulario y de vuelve el botont Configuracion a su color normal
        Me.Close()
        Form_Principal.btnConfiguracion.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click

        ' Establece al formulario como propio al formulario configuracion y 
        ' lo abre como cuadro de dialogo
        MantenedorProveedores.Owner = Me
        MantenedorProveedores.ShowDialog()
    End Sub

    Private Sub btnCatMarcas_Click(sender As Object, e As EventArgs) Handles btnCatMarcas.Click

        ' Establece al formulario como propio al formulario configuracion y 
        ' lo abre como cuadro de dialogo
        MantenedorMarcaCategoria.Owner = Me
        MantenedorMarcaCategoria.ShowDialog()
    End Sub
End Class