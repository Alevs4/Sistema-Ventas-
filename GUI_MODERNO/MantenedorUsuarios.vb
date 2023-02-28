Imports System.Text.RegularExpressions

Public Class MantenedorUsuarios

    Dim posicion As Integer

    Sub consultaUsuarios()

        SQL32("CALL SP_CARGAR_USUARIOS")

    End Sub

    Sub mostrarUsuarios(ByVal i As Integer)


        txtUsuario.Text = DS32.Tables(DT32.TableName).Rows(i).Item("user_name")
        txtPass.Text = DS32.Tables(DT32.TableName).Rows(i).Item("clave")
        txtNombre.Text = DS32.Tables(DT32.TableName).Rows(i).Item("usuario")
        txtRut.Text = DS32.Tables(DT32.TableName).Rows(i).Item("rut_usuario")
        txtEstado.Text = DS32.Tables(DT32.TableName).Rows(i).Item("estado")


        If DS32.Tables(DT32.TableName).Rows(i).Item("perfil") = "Administrador" Then
            cmbPerfil.SelectedIndex = 0
        ElseIf DS32.Tables(DT32.TableName).Rows(i).Item("perfil") = "Normal" Then
            cmbPerfil.SelectedIndex = 1
        End If
        If txtEstado.Text = "Activo" Then
            btnDesactivar.Visible = True
            btnActivar.Visible = False
        ElseIf txtEstado.Text = "Inactivo" Then
            btnDesactivar.Visible = False
            btnActivar.Visible = True
        End If

    End Sub

    Private Sub MantenedorUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaUsuarios()
        mostrarUsuarios(0)
        txtPass.UseSystemPasswordChar = True
        btnAgregar.Enabled = False

    End Sub

    Sub limpiarCampos()

        txtUsuario.Clear()
        txtPass.Clear()
        txtNombre.Clear()
        txtRut.Clear()
        txtUsuario.Focus()
    End Sub

    Private Sub btnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles btnNuevoUsuario.Click
        limpiarCampos()
        btnNuevoUsuario.Enabled = False
        btnAgregar.Enabled = True
        btnBuscar.Enabled = False
        btnBuscarMas.Enabled = False
        btnEditar.Enabled = False
        btnDesactivar.Enabled = False
        btnPrimero.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        btnUltimo.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""

        Dim rut As String

        If txtRut.TextLength < 10 Then
            Dim rut_menor_10 As String = "0" + txtRut.Text
            rut = rut_menor_10
        Else
            rut = txtRut.Text
        End If

        Dim cortar_en As String = "-"
        Dim x As Integer = InStr(rut, cortar_en)

        Dim rut_reducido As String = rut.Substring(0, x - 1)

        If Validador(CInt(rut_reducido)) = rut Then
            lblEstado.Visible = False
            lblEstado.Text = ""

            Try
                SQL33("Call SP_MODIFICA_USUARIO('" & (txtRut.Text) & "','" & (txtNombre.Text) & "','" & (txtUsuario.Text) & "','" & (txtPass.Text) & "','" & (cmbPerfil.Text) & "')")
                lblEstado.Visible = True
                lblEstado.Text = "Datos Actualizados"
                conexion.Close()
                consultaUsuarios()
            Catch ex As Exception
                lblEstado.Visible = True
                lblEstado.Text = "Ha ocurrido un error al modificar el usuario"
                conexion.Close()
            End Try
        Else
            lblEstado.Text = "Rut no válido"
            lblEstado.Visible = True
            txtRut.Clear()
        End If
        consultaUsuarios()
        conexion.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""
        If txtUsuario.Text <> "Usuario" Then
            If txtNombre.Text <> "" And txtPass.Text <> "" And txtRut.Text <> "" And txtUsuario.Text <> "" And cmbPerfil.Text <> "" Then

                Dim rut As String

                If txtRut.TextLength < 10 Then
                    Dim rut_menor_10 As String = "0" + txtRut.Text
                    rut = rut_menor_10
                Else
                    rut = txtRut.Text
                End If

                Dim cortar_en As String = "-"
                Dim x As Integer = InStr(rut, cortar_en)

                Dim rut_reducido As String = rut.Substring(0, x - 1)

                If Validador(CInt(rut_reducido)) = rut Then
                    lblEstado.Visible = False
                    lblEstado.Text = ""

                    Try
                        SQL35("Call SP_BUSCAR_USUARIO_POR_RUT('" & (txtRut.Text) & "')")
                        If DT35.Rows.Count = 0 Then
                            SQL34("Call SP_AGREGAR_USUARIO('" & (txtRut.Text) & "','" & (txtNombre.Text) & "','" & (txtUsuario.Text) & "','" & (txtPass.Text) & "','" & (cmbPerfil.Text) & "')")
                            lblEstado.Visible = True
                            lblEstado.Text = "Usuario Agregado"
                            conexion.Close()
                            limpiarCampos()
                            consultaUsuarios()
                            mostrarUsuarios(0)
                            btnNuevoUsuario.Enabled = True
                            btnAgregar.Enabled = False
                            btnBuscar.Enabled = True
                            btnBuscarMas.Enabled = True
                            btnEditar.Enabled = True
                            btnDesactivar.Enabled = True
                            btnPrimero.Enabled = True
                            btnAnterior.Enabled = True
                            btnSiguiente.Enabled = True
                            btnUltimo.Enabled = True
                            conexion.Close()
                        Else
                            lblEstado.Visible = True
                            lblEstado.Text = "Rut ya es encuentra registrado en sistema"
                        End If
                    Catch ex As Exception
                        lblEstado.Text = "Ha ocurrido un error al ingresar el usuario"
                        conexion.Close()
                    End Try
                Else
                    lblEstado.Text = "Rut no válido"
                    lblEstado.Visible = True
                    txtRut.Clear()
                End If
            Else
                lblEstado.Visible = True
                lblEstado.Text = "Debe completar todos los campos"
            End If
        Else
            lblEstado.Visible = True
            lblEstado.Text = "Error: 'Usuario' está reservado por sistema."
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""

        Dim rut As String

        If txtRut.TextLength < 10 Then
            Dim rut_menor_10 As String = "0" + txtRut.Text
            rut = rut_menor_10
        Else
            rut = txtRut.Text
        End If

        Dim cortar_en As String = "-"
        Dim x As Integer = InStr(rut, cortar_en)

        Dim rut_reducido As String = rut.Substring(0, x - 1)

        If Validador(CInt(rut_reducido)) = rut Then
            lblEstado.Visible = False
            lblEstado.Text = ""

            Try
                SQL35("Call SP_BUSCAR_USUARIO_POR_RUT('" & (txtRut.Text) & "')")
                If DT35.Rows.Count >= 1 Then
                    txtRut.Text = DS35.Tables(DT35.TableName).Rows(0).Item("rut_usuario")
                    txtUsuario.Text = DS35.Tables(DT35.TableName).Rows(0).Item("user_name")
                    txtNombre.Text = DS35.Tables(DT35.TableName).Rows(0).Item("usuario")
                    txtPass.Text = DS35.Tables(DT35.TableName).Rows(0).Item("clave")
                    txtEstado.Text = DS32.Tables(DT32.TableName).Rows(0).Item("estado")
                    If DS35.Tables(DT35.TableName).Rows(0).Item("perfil") = "Administrador" Then
                        cmbPerfil.SelectedIndex = 0
                    ElseIf DS35.Tables(DT35.TableName).Rows(0).Item("perfil") = "Normal" Then
                        cmbPerfil.SelectedIndex = 1
                    End If
                    lblEstado.Visible = False
                    lblEstado.Text = ""
                    conexion.Close()
                Else
                    lblEstado.Visible = True
                    lblEstado.Text = "No se encuentra usuario"
                    limpiarCampos()
                    btnAgregar.Enabled = False
                    btnBuscar.Enabled = True
                    btnBuscarMas.Enabled = True
                    btnEditar.Enabled = False
                    btnDesactivar.Enabled = False
                End If

            Catch ex As Exception
                lblEstado.Visible = True
                lblEstado.Text = "Ha ocurrido un error al buscar el usuario"
                conexion.Close()
            End Try

        Else
            lblEstado.Text = "Rut no válido"
            lblEstado.Visible = True
            txtRut.Clear()
        End If

        consultaUsuarios()
        conexion.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""
        Try


            If txtRut.Text = "" Then
                MsgBox("ingrese rut")
                Dim rut As String

                If txtRut.TextLength < 10 Then
                    Dim rut_menor_10 As String = "0" + txtRut.Text
                    rut = rut_menor_10
                Else
                    rut = txtRut.Text

                End If

                Dim cortar_en As String = "-"
                Dim x As Integer = InStr(rut, cortar_en)

                Dim rut_reducido As String = rut.Substring(0, x - 1)

                If Validador(CInt(rut_reducido)) = rut Then
                    lblEstado.Visible = False
                    lblEstado.Text = ""

                    If MessageBox.Show("Con esta acción eliminará al usuario seleccionado" & (vbNewLine) & "¿Desea continuar?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Try
                            SQL36("CALL SP_DESACTIVAR_USUARIO('" & (txtRut.Text) & "')")
                            lblEstado.Visible = True
                            lblEstado.Text = "Usuario desactivado con éxito"
                            consultaUsuarios()
                            mostrarUsuarios(0)
                        Catch ex As Exception
                            'lblEstado.Visible = True
                            'lblEstado.Text = "No puede borrar un usuario que tenga ventas o compras asociadas"
                            'conexion.Close()
                            'consultaUsuarios()
                            'mostrarUsuarios(0)
                        End Try
                    End If
                Else
                    lblEstado.Text = "Rut no válido"
                    lblEstado.Visible = True
                    txtRut.Clear()
                End If
            Else
                lblEstado.Visible = True
                lblEstado.Text = "Debe escribir Rut a desactivar"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarCampos()
        consultaUsuarios()
        mostrarUsuarios(0)
        btnNuevoUsuario.Enabled = True
        btnAgregar.Enabled = False
        btnBuscar.Enabled = True
        btnBuscarMas.Enabled = True
        btnEditar.Enabled = True
        btnDesactivar.Enabled = True
        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiarCampos()
        btnNuevoUsuario.Enabled = True
        btnAgregar.Enabled = False
        btnBuscar.Enabled = True
        btnBuscarMas.Enabled = True
        btnEditar.Enabled = True
        btnDesactivar.Enabled = True
        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        lblEstado.Visible = False
        lblEstado.Text = ""
        Me.Close()
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If posicion > 0 Then
            posicion = 0
            mostrarUsuarios(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion = posicion - 1
            mostrarUsuarios(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < DT32.Rows.Count - 1 Then
            posicion = posicion + 1
            mostrarUsuarios(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If posicion < DT32.Rows.Count - 1 Then
            posicion = DT32.Rows.Count - 1
            mostrarUsuarios(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub txtRut_LostFocus(sender As Object, e As EventArgs) Handles txtRut.LostFocus
        If txtRut.Text <> "" Then
            Dim primero As Integer = 0
            Integer.TryParse(txtRut.Text.Take(txtRut.TextLength - 1).ToArray, primero)
            If txtRut.Text.Last <> "K" Then
                Dim ultimo As Integer
                Integer.TryParse(txtRut.Text.Last, ultimo)
                txtRut.Text = String.Format("{0:0}-{1}", primero, ultimo)
            Else
                txtRut.Clear()
                txtRut.Text = primero & "-" & "K"

            End If
        End If
    End Sub

    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
        Dim digitos As New regex("[^K0-9\b]")
        e.Handled = digitos.ismatch(e.KeyChar)
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""
        If txtRut.Text <> "" Then
            If MessageBox.Show("Con esta acción activará al usuario seleccionado" & (vbNewLine) & "¿Desea continuar?", "Activar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    SQL36("CALL SP_ACTIVAR_USUARIO('" & (txtRut.Text) & "')")
                    conexion.Close()
                    lblEstado.Visible = True
                    lblEstado.Text = "Usuario activado con éxito"
                    consultaUsuarios()
                    mostrarUsuarios(0)
                Catch ex As Exception
                    'lblEstado.Visible = True
                    'lblEstado.Text = "No puede borrar un proveedor que tenga compras asociadas"
                    'conexion.Close()
                    'consultaProveedores()
                    'mostrarProveedores(0)
                End Try
            End If
        Else
            lblEstado.Visible = True
            lblEstado.Text = "Debe escribir Rut a Activar"
        End If
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

    End Sub

    Private Sub txtRut_Enter(sender As Object, e As EventArgs) Handles txtRut.Enter
        txtRut.Clear()
    End Sub
End Class