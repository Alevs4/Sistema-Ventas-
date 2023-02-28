Imports System.Runtime.InteropServices


Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' A la variable conexion, en su metodo de connectionString asignamos base de datos, server, usuario y password
        conexion.ConnectionString = "database=bd_inventario; Data Source = localhost; User Id=root; Password=root"

    End Sub

    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter

        ' Si cuando al entrar al control, el texto que contiene es "USUARIO" entonces el texto sera vacio, y tomará un color
        ' diferente
        If txtUsuario.Text = "Usuario" Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave

        ' Si cuando al dejar el control, el texto que contiene es vacio entonces el texto sera "USUARIO", y volverá al color
        ' original
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "Usuario"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter

        ' Si cuando al entrar al control, el texto que contiene es "Contraseña" entonces el texto sera vacio, y tomará un color
        ' diferente
        If txtPass.Text = "Contraseña" Then
            txtPass.Text = ""
            txtPass.ForeColor = Color.LightGray
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave

        ' Si cuando al dejar el control, el texto que contiene es vacio entonces el texto sera "CONTRASEÑA", y volverá al color
        ' original
        If txtPass.Text = "" Then
            txtPass.Text = "Contraseña"
            txtPass.ForeColor = Color.DimGray
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        ' Cierra el programa
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        ' Boton minimizar
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Condicional para inicar el codigo
        If txtUsuario.Text <> "Usuario" Then

            ' Consultamos por el usuario y contraseña ingresados
            Try
                ' Si la consulta es exitosa...
                SQL31("SELECT * FROM usuarios WHERE user_name = '" & txtUsuario.Text & "'and clave ='" & txtPass.Text & "'")
                If DT31.Rows.Count >= 1 Then
                    Me.Hide() ' Se oculta formulario Login
                    Form_Principal.Show() ' Se muestra formulario Principal

                    ' Se genera un contador que recorrera la tabla que ha devuelto la BD con el objetivo de trasladar
                    ' estos datos a labels en el formulario principal
                    For i = 0 To DS31.Tables(DT31.TableName).Rows.Count - 1
                        Form_Principal.lblRutOc.Text = DS31.Tables(DT31.TableName).Rows(0).Item("rut_usuario")
                        Form_Principal.lblUsuario.Text = DS31.Tables(DT31.TableName).Rows(0).Item("usuario")
                        Form_Principal.lblTipo.Text = DS31.Tables(DT31.TableName).Rows(0).Item("perfil")
                    Next
                    txtUsuario.Text = "" ' Se limpian campos de login
                    txtPass.Text = ""
                Else

                    'Si la consulta devuelve nada, un label de estado indica que usuario o contraseña son incorrectos
                    ' se limpian campos, y se resetean sus valores
                    lblEstado.Text = "Usuario o contraseña incorrectos o fue desactivado"
                    lblEstado.Visible = True
                    txtUsuario.Text = ""
                    txtPass.Text = ""
                    If txtPass.Text = "" And txtUsuario.Text = "" Then
                        txtPass.Text = "Contraseña"
                        txtUsuario.Text = "Usuario"
                        txtPass.ForeColor = Color.DimGray
                        txtUsuario.ForeColor = Color.DimGray
                        txtPass.UseSystemPasswordChar = False
                    End If
                End If
            Catch ex As Exception
            End Try
        Else ' .... Si el usuario no ha ingresado su usuario o contraseña, el programa las pedirá
            lblEstado.Visible = True
            lblEstado.Text = "Ingrese su Usuario y Contraseña"
        End If


        If Form_Principal.lblTipo.Text = "Normal" Then
            Form_Principal.Panel3.Visible = False
            Form_Principal.btnConfiguracion.Visible = False
        ElseIf Form_Principal.lblTipo.Text = "Administrador" Then
            Form_Principal.Panel3.Visible = True
            Form_Principal.btnConfiguracion.Visible = True
        End If
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        lblEstado.Text = ""
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        lblEstado.Text = ""
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class