Imports System.Runtime.InteropServices
Public Class Form_Principal
#Region "..................FUNCIONALIDADES DE FORMULARIO"

    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Login.Show()
        If Login.txtPass.Text = "" Then
            Login.txtPass.Text = "Contraseña"
            Login.txtPass.ForeColor = Color.DimGray
            Login.txtPass.UseSystemPasswordChar = False
        End If
        If Login.txtUsuario.Text = "" Then
            Login.txtUsuario.Text = "Usuario"
            Login.txtUsuario.ForeColor = Color.DimGray

        End If
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        'Me.WindowState = FormWindowState.Maximized

        ' Variables para posicion y tamaño
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        Me.WindowState = FormWindowState.Normal
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    'Metodo abrir formulario

    ' Esta función es para determinar la forma en que se abrirán los formularios que especifiquemos

    Private Sub AbrirFormularioEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = panelFormularios.Controls.OfType(Of Miform)().FirstOrDefault 'Busca el formulario en la colección
        'Si formulario no fue necontrado / no existe

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            panelFormularios.Controls.Add(Formulario)
            panelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If


    End Sub
#End Region

#Region "..................BOTONES"
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

        ' Abrimos el formulario en panel Formularios
        AbrirFormularioEnPanel(Of Productos)()
        btnProductos.BackColor = Color.FromArgb(73, 167, 239)
        submenuReportes.Visible = False
        btnReportes.BackColor = Color.DarkSlateGray


    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormularioEnPanel(Of Ventas)()
        btnVentas.BackColor = Color.FromArgb(73, 167, 239)
        btnReportes.BackColor = Color.DarkSlateGray
        submenuReportes.Visible = False
    End Sub



    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormularioEnPanel(Of Compras)()
        btnCompras.BackColor = Color.FromArgb(73, 167, 239)
        btnReportes.BackColor = Color.DarkSlateGray
        submenuReportes.Visible = False
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        If submenuReportes.Visible = False Then
            submenuReportes.Visible = True
            btnReportes.BackColor = Color.FromArgb(73, 167, 239)
        Else
            submenuReportes.Visible = False
            btnReportes.BackColor = Color.DarkSlateGray
        End If
    End Sub

    Private Sub btnRepVentas_Click(sender As Object, e As EventArgs) Handles btnRepVentas.Click
        AbrirFormularioEnPanel(Of Reporte)()
        submenuReportes.Visible = False
        btnReportes.BackColor = Color.FromArgb(126, 161, 188)
        submenuReportes.Visible = False

    End Sub

    Private Sub btnRepCompras_Click(sender As Object, e As EventArgs) Handles btnRepCompras.Click
        AbrirFormularioEnPanel(Of ReporteCompras)()
        submenuReportes.Visible = False
        btnReportes.BackColor = Color.FromArgb(126, 161, 188)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormularioEnPanel(Of ReporteDiario)()
        submenuReportes.Visible = False
        btnReportes.BackColor = Color.FromArgb(126, 161, 188)
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        AbrirFormularioEnPanel(Of Configuracion)()
        btnConfiguracion.BackColor = Color.FromArgb(73, 167, 239)
        submenuReportes.Visible = False
        btnReportes.BackColor = Color.DarkSlateGray
    End Sub

#End Region

#Region "..................RELOJ Y FECHA"
    Private Sub reloj_Tick(sender As Object, e As EventArgs) Handles reloj.Tick

        ' Reloj y fecha actuales
        lblReloj.Text = DateTime.Now.ToLongTimeString
        lblFecha.Text = DateTime.Now.ToLongDateString
    End Sub
#End Region

#Region "..................LOAD (carga inicial)"
    Private Sub Form_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SQL26("CALL SP_LISTAR_LOTES_POR_VENCER()")
            If DT26.Rows.Count >= 1 Then
                grillaVencimientos.DataSource = DS26.Tables(DT26.TableName)
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try

        Me.lblFecha.Parent = PictureBox2
        Me.lblReloj.Parent = PictureBox2
        Me.Label2.Parent = PictureBox2

        Me.lblFecha.BackColor = Color.Transparent
        Me.lblReloj.BackColor = Color.Transparent


    End Sub

#End Region

#Region "..................GRILLAS"
    Private Sub grillaVencimientos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaVencimientos.DataBindingComplete
        grillaVencimientos.ClearSelection()
        Dim i As Integer
        For i = 0 To grillaVencimientos.Columns.Count - 1
            grillaVencimientos.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub



    Private Sub grillaVencimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaVencimientos.CellContentClick
        Try
            Dim lote As Integer
            lote = grillaVencimientos.CurrentRow.Cells(0).Value
            SQL37("SP_CARGAR_DETALLE_VENCIMIENTOS('" & (lote) & "')")
            If DT37.Rows.Count >= 1 Then
                grillaDetalle.DataSource = DS37.Tables(DT37.TableName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub



    Private Sub grillaDetalle_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaDetalle.DataBindingComplete
        grillaDetalle.ClearSelection()
        Dim i As Integer
        For i = 0 To grillaDetalle.Columns.Count - 1
            grillaDetalle.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub grillaVencimientos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grillaVencimientos.CellFormatting
        Try
            ' Función para remarcar productos a punto de vencer (5 días de antelación)
            Dim hoy As String = Convert.ToDateTime(Date.Now.AddDays(5)).ToString("dd-MM-yyyy")
            If grillaVencimientos.Rows(e.RowIndex).Cells("Fecha de Vencimiento").Value.ToString < hoy Then
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.BackColor = Color.Red
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

#End Region


End Class