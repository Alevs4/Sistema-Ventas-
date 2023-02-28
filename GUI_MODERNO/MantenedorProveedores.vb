Imports System.Text.RegularExpressions

Public Class MantenedorProveedores
    Dim posicion As Integer

    Sub consultaProveedores()

        SQL43("CALL SP_CARGAR_PROVEEDORES")

    End Sub

    Sub mostrarProveedores(ByVal i As Integer)

        txtRut.Text = DS43.Tables(DT43.TableName).Rows(i).Item("rut_proveedor")
        txtRazonSocial.Text = DS43.Tables(DT43.TableName).Rows(i).Item("razon_social")
        txtDireccion.Text = DS43.Tables(DT43.TableName).Rows(i).Item("direccion")
        txtTelefono.Text = DS43.Tables(DT43.TableName).Rows(i).Item("telefono")
        txtEmail.Text = DS43.Tables(DT43.TableName).Rows(i).Item("email")
        txtCiudad.Text = DS43.Tables(DT43.TableName).Rows(i).Item("ciudad")
        txtGiro.Text = DS43.Tables(DT43.TableName).Rows(i).Item("giro")
        txtEstado.Text = DS43.Tables(DT43.TableName).Rows(i).Item("estado")
        If txtEstado.Text = "Activo" Then
            btnEliminar.Visible = True
            btnActivar.Visible = False
        ElseIf txtEstado.Text = "Inactivo" Then
            btnEliminar.Visible = False
            btnActivar.Visible = True
        End If

    End Sub

    Private Sub MantenedorUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaProveedores()
        mostrarProveedores(0)
        btnAgregar.Enabled = False

    End Sub

    Sub limpiarCampos()

        txtRut.Clear()
        txtRazonSocial.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCiudad.Clear()
        txtGiro.Clear()

    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        limpiarCampos()
        btnNuevoProveedor.Enabled = False
        btnAgregar.Enabled = True
        btnBuscar.Enabled = False
        btnBuscarMas.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
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
                SQL44("Call SP_MODIFICA_PROVEEDOR('" & (txtRut.Text) & "','" & (txtRazonSocial.Text) & "','" & (txtDireccion.Text) & "','" & (txtTelefono.Text) & "','" & (txtEmail.Text) & "','" & (txtCiudad.Text) & "','" & (txtGiro.Text) & "')")
                lblEstado.Visible = True
                lblEstado.Text = "Datos Actualizados"
                conexion.Close()
                consultaProveedores()
            Catch ex As Exception
                lblEstado.Visible = True
                lblEstado.Text = "Ha ocurrido un error al modificar al proveedor"
                conexion.Close()
            End Try
        Else
            lblEstado.Text = "Rut no válido"
            lblEstado.Visible = True
            txtRut.Clear()
        End If
        consultaProveedores()
        conexion.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtRazonSocial.Text <> "" And txtDireccion.Text <> "" And txtRut.Text <> "" And txtTelefono.Text <> "" And txtEmail.Text <> "" And txtCiudad.Text <> "" And txtGiro.Text <> "" Then
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
                    SQL45("Call SP_BUSCAR_PROVEEDOR_POR_RUT('" & (txtRut.Text) & "')")
                    If DT45.Rows.Count = 0 Then
                        SQL46("Call SP_AGREGAR_PROVEEDORES('" & (txtRut.Text) & "','" & (txtRazonSocial.Text) & "','" & (txtDireccion.Text) & "','" & (txtTelefono.Text) & "','" & (txtEmail.Text) & "','" & (txtCiudad.Text) & "','" & (txtGiro.Text) & "')")
                        lblEstado.Visible = True
                        lblEstado.Text = "Proveedor Agregado"
                        conexion.Close()
                        limpiarCampos()
                        consultaProveedores()
                        mostrarProveedores(0)
                        btnNuevoProveedor.Enabled = True
                        btnAgregar.Enabled = False
                        btnBuscar.Enabled = True
                        btnBuscarMas.Enabled = True
                        btnEditar.Enabled = True
                        btnEliminar.Enabled = True
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
                    lblEstado.Text = "Ha ocurrido un error al ingresar al proveedor"
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
                SQL45("Call SP_BUSCAR_PROVEEDOR_POR_RUT('" & (txtRut.Text) & "')")
                If DT45.Rows.Count >= 1 Then

                    btnAgregar.Enabled = False
                    btnBuscar.Enabled = True
                    btnBuscarMas.Enabled = True
                    btnEditar.Enabled = True
                    btnEliminar.Enabled = True
                    txtRut.Text = DS45.Tables(DT45.TableName).Rows(0).Item("rut_proveedor")
                    txtRazonSocial.Text = DS45.Tables(DT45.TableName).Rows(0).Item("razon_social")
                    txtDireccion.Text = DS45.Tables(DT45.TableName).Rows(0).Item("direccion")
                    txtTelefono.Text = DS45.Tables(DT45.TableName).Rows(0).Item("telefono")
                    txtEmail.Text = DS45.Tables(DT45.TableName).Rows(0).Item("email")
                    txtCiudad.Text = DS45.Tables(DT45.TableName).Rows(0).Item("ciudad")
                    txtGiro.Text = DS45.Tables(DT45.TableName).Rows(0).Item("giro")
                    txtEstado.Text = DS32.Tables(DT32.TableName).Rows(0).Item("estado")

                    lblEstado.Visible = False
                    lblEstado.Text = ""
                    conexion.Close()
                Else
                    lblEstado.Visible = True
                    lblEstado.Text = "No se encuentra proveedor"
                    limpiarCampos()
                    btnAgregar.Enabled = False
                    btnBuscar.Enabled = True
                    btnBuscarMas.Enabled = True
                    btnEditar.Enabled = False
                    btnEliminar.Enabled = False
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

        consultaProveedores()
        conexion.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""
        If txtRut.Text <> "" Then


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
                If MessageBox.Show("Con esta acción desactivará al proveedor seleccionado" & (vbNewLine) & "¿Desea continuar?", "Desactivar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        SQL47("CALL SP_DESACTIVAR_PROVEEDOR('" & (txtRut.Text) & "')")
                        conexion.Close()
                        lblEstado.Visible = True
                        lblEstado.Text = "Proveedor desactivado con éxito"
                        consultaProveedores()
                        mostrarProveedores(0)
                    Catch ex As Exception
                        'lblEstado.Visible = True
                        'lblEstado.Text = "No puede borrar un proveedor que tenga compras asociadas"
                        'conexion.Close()
                        'consultaProveedores()
                        'mostrarProveedores(0)
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
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarCampos()
        consultaProveedores()
        mostrarProveedores(0)
        btnNuevoProveedor.Enabled = True
        btnAgregar.Enabled = False
        btnBuscar.Enabled = True
        btnBuscarMas.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If posicion > 0 Then
            posicion = 0
            mostrarProveedores(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If posicion > 0 Then
            posicion = posicion - 1
            mostrarProveedores(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If posicion < DT43.Rows.Count - 1 Then
            posicion = posicion + 1
            mostrarProveedores(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If posicion < DT43.Rows.Count - 1 Then
            posicion = DT43.Rows.Count - 1
            mostrarProveedores(posicion)
        End If
        lblEstado.Visible = False
        lblEstado.Text = ""
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiarCampos()
        btnNuevoProveedor.Enabled = True
        btnAgregar.Enabled = False
        btnBuscar.Enabled = True
        btnBuscarMas.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnPrimero.Enabled = True
        btnAnterior.Enabled = True
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        lblEstado.Visible = False
        lblEstado.Text = ""
        Me.Close()
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

    Private Sub txtRut_Enter(sender As Object, e As EventArgs) Handles txtRut.Enter
        txtRut.Clear()
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        lblEstado.Visible = False
        lblEstado.Text = ""
        If txtRut.Text <> "" Then
            If MessageBox.Show("Con esta acción activará al proveedor seleccionado" & (vbNewLine) & "¿Desea continuar?", "Activar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    SQL47("CALL SP_ACTIVAR_PROVEEDOR('" & (txtRut.Text) & "')")
                    conexion.Close()
                    lblEstado.Visible = True
                    lblEstado.Text = "Proveedor activado con éxito"
                    consultaProveedores()
                    mostrarProveedores(0)
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

    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
        Dim digitos As New regex("[^K0-9\b]")
        e.Handled = digitos.ismatch(e.KeyChar)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Dim digitos As New Regex("[^0-9\b]")
        e.Handled = digitos.IsMatch(e.KeyChar)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class