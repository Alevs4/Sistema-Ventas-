<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Principal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.lblRutOc = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.submenuReportes = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnRepCompras = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnRepVentas = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.panelFormularios = New System.Windows.Forms.Panel()
        Me.grillaDetalle = New System.Windows.Forms.DataGridView()
        Me.grillaVencimientos = New System.Windows.Forms.DataGridView()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.submenuReportes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitulo.SuspendLayout()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFormularios.SuspendLayout()
        CType(Me.grillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillaVencimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.panelMenu)
        Me.panelContenedor.Controls.Add(Me.panelTitulo)
        Me.panelContenedor.Controls.Add(Me.panelFormularios)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1300, 678)
        Me.panelContenedor.TabIndex = 0
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelMenu.Controls.Add(Me.lblRutOc)
        Me.panelMenu.Controls.Add(Me.lblTipo)
        Me.panelMenu.Controls.Add(Me.lblUsuario)
        Me.panelMenu.Controls.Add(Me.PictureBox3)
        Me.panelMenu.Controls.Add(Me.submenuReportes)
        Me.panelMenu.Controls.Add(Me.Panel7)
        Me.panelMenu.Controls.Add(Me.btnReportes)
        Me.panelMenu.Controls.Add(Me.Panel4)
        Me.panelMenu.Controls.Add(Me.btnCompras)
        Me.panelMenu.Controls.Add(Me.Panel3)
        Me.panelMenu.Controls.Add(Me.btnConfiguracion)
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Controls.Add(Me.btnVentas)
        Me.panelMenu.Controls.Add(Me.Panel2)
        Me.panelMenu.Controls.Add(Me.btnProductos)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(250, 638)
        Me.panelMenu.TabIndex = 1
        '
        'lblRutOc
        '
        Me.lblRutOc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblRutOc.AutoSize = True
        Me.lblRutOc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutOc.ForeColor = System.Drawing.Color.White
        Me.lblRutOc.Location = New System.Drawing.Point(65, 614)
        Me.lblRutOc.Name = "lblRutOc"
        Me.lblRutOc.Size = New System.Drawing.Size(46, 17)
        Me.lblRutOc.TabIndex = 19
        Me.lblRutOc.Text = "Label5"
        '
        'lblTipo
        '
        Me.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(65, 596)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(46, 17)
        Me.lblTipo.TabIndex = 18
        Me.lblTipo.Text = "Label4"
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(65, 579)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 17)
        Me.lblUsuario.TabIndex = 17
        Me.lblUsuario.Text = "Label3"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox3.Image = Global.GUI_MODERNO.My.Resources.Resources.usuario_hombre
        Me.PictureBox3.Location = New System.Drawing.Point(15, 579)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'submenuReportes
        '
        Me.submenuReportes.BackColor = System.Drawing.Color.DarkSlateGray
        Me.submenuReportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.submenuReportes.Controls.Add(Me.Panel5)
        Me.submenuReportes.Controls.Add(Me.Button1)
        Me.submenuReportes.Controls.Add(Me.Panel10)
        Me.submenuReportes.Controls.Add(Me.btnRepCompras)
        Me.submenuReportes.Controls.Add(Me.Panel9)
        Me.submenuReportes.Controls.Add(Me.btnRepVentas)
        Me.submenuReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submenuReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.submenuReportes.Location = New System.Drawing.Point(68, 312)
        Me.submenuReportes.Name = "submenuReportes"
        Me.submenuReportes.Size = New System.Drawing.Size(182, 120)
        Me.submenuReportes.TabIndex = 15
        Me.submenuReportes.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(11, 73)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 28)
        Me.Panel5.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(14, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Reporte Diario"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Location = New System.Drawing.Point(11, 39)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 28)
        Me.Panel10.TabIndex = 19
        '
        'btnRepCompras
        '
        Me.btnRepCompras.BackColor = System.Drawing.Color.Transparent
        Me.btnRepCompras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnRepCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnRepCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepCompras.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRepCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepCompras.Location = New System.Drawing.Point(14, 39)
        Me.btnRepCompras.Name = "btnRepCompras"
        Me.btnRepCompras.Size = New System.Drawing.Size(155, 28)
        Me.btnRepCompras.TabIndex = 18
        Me.btnRepCompras.Text = "Reporte Compras"
        Me.btnRepCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRepCompras.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Location = New System.Drawing.Point(11, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 28)
        Me.Panel9.TabIndex = 17
        '
        'btnRepVentas
        '
        Me.btnRepVentas.BackColor = System.Drawing.Color.Transparent
        Me.btnRepVentas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnRepVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnRepVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepVentas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRepVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepVentas.Location = New System.Drawing.Point(14, 5)
        Me.btnRepVentas.Name = "btnRepVentas"
        Me.btnRepVentas.Size = New System.Drawing.Size(155, 28)
        Me.btnRepVentas.TabIndex = 16
        Me.btnRepVentas.Text = "Reporte Ventas"
        Me.btnRepVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRepVentas.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(12, 273)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 42)
        Me.Panel7.TabIndex = 14
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(15, 273)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(218, 42)
        Me.btnReportes.TabIndex = 13
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.Location = New System.Drawing.Point(12, 225)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 42)
        Me.Panel4.TabIndex = 8
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.Transparent
        Me.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompras.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(15, 225)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(218, 42)
        Me.btnCompras.TabIndex = 7
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.Location = New System.Drawing.Point(12, 531)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 42)
        Me.Panel3.TabIndex = 6
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfiguracion.Image = Global.GUI_MODERNO.My.Resources.Resources.settings_1_
        Me.btnConfiguracion.Location = New System.Drawing.Point(12, 531)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(221, 42)
        Me.btnConfiguracion.TabIndex = 5
        Me.btnConfiguracion.Text = "Configuración"
        Me.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfiguracion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(12, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 42)
        Me.Panel1.TabIndex = 4
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.Transparent
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(15, 177)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(218, 42)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(12, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 42)
        Me.Panel2.TabIndex = 2
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.Transparent
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(15, 129)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(218, 42)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI_MODERNO.My.Resources.Resources.libreriasofia
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.panelTitulo.Controls.Add(Me.Label1)
        Me.panelTitulo.Controls.Add(Me.btnMaximizar)
        Me.panelTitulo.Controls.Add(Me.btnRestaurar)
        Me.panelTitulo.Controls.Add(Me.btnMinimizar)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(1300, 40)
        Me.panelTitulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Punto de venta"
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1241, 9)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(18, 18)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1241, 9)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(18, 18)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1211, 9)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(18, 18)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1270, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(18, 18)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'panelFormularios
        '
        Me.panelFormularios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.panelFormularios.Controls.Add(Me.grillaDetalle)
        Me.panelFormularios.Controls.Add(Me.grillaVencimientos)
        Me.panelFormularios.Controls.Add(Me.lblFecha)
        Me.panelFormularios.Controls.Add(Me.lblReloj)
        Me.panelFormularios.Controls.Add(Me.Label2)
        Me.panelFormularios.Controls.Add(Me.PictureBox2)
        Me.panelFormularios.Location = New System.Drawing.Point(250, 40)
        Me.panelFormularios.Name = "panelFormularios"
        Me.panelFormularios.Size = New System.Drawing.Size(1050, 638)
        Me.panelFormularios.TabIndex = 2
        '
        'grillaDetalle
        '
        Me.grillaDetalle.AllowUserToAddRows = False
        Me.grillaDetalle.AllowUserToDeleteRows = False
        Me.grillaDetalle.AllowUserToResizeRows = False
        Me.grillaDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaDetalle.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaDetalle.EnableHeadersVisualStyles = False
        Me.grillaDetalle.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaDetalle.Location = New System.Drawing.Point(725, 548)
        Me.grillaDetalle.MultiSelect = False
        Me.grillaDetalle.Name = "grillaDetalle"
        Me.grillaDetalle.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grillaDetalle.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaDetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grillaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaDetalle.Size = New System.Drawing.Size(313, 65)
        Me.grillaDetalle.TabIndex = 8
        '
        'grillaVencimientos
        '
        Me.grillaVencimientos.AllowUserToAddRows = False
        Me.grillaVencimientos.AllowUserToDeleteRows = False
        Me.grillaVencimientos.AllowUserToResizeRows = False
        Me.grillaVencimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaVencimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaVencimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaVencimientos.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaVencimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaVencimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVencimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grillaVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaVencimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaVencimientos.EnableHeadersVisualStyles = False
        Me.grillaVencimientos.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaVencimientos.Location = New System.Drawing.Point(623, 417)
        Me.grillaVencimientos.MultiSelect = False
        Me.grillaVencimientos.Name = "grillaVencimientos"
        Me.grillaVencimientos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVencimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grillaVencimientos.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaVencimientos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grillaVencimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaVencimientos.Size = New System.Drawing.Size(415, 122)
        Me.grillaVencimientos.TabIndex = 6
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(21, 548)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(104, 40)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "FECHA"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReloj
        '
        Me.lblReloj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblReloj.AutoSize = True
        Me.lblReloj.BackColor = System.Drawing.Color.Transparent
        Me.lblReloj.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReloj.Location = New System.Drawing.Point(6, 417)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(409, 128)
        Me.lblReloj.TabIndex = 3
        Me.lblReloj.Text = "00:00:00"
        Me.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(673, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 45)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lotes próximos a vencer"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.GUI_MODERNO.My.Resources.Resources.beach_night_sea_sky_88045_1920x1080
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1050, 638)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'reloj
        '
        Me.reloj.Enabled = True
        '
        'Form_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 678)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "Form_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelContenedor.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.submenuReportes.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFormularios.ResumeLayout(False)
        Me.panelFormularios.PerformLayout()
        CType(Me.grillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillaVencimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenedor As System.Windows.Forms.Panel
    Friend WithEvents panelTitulo As System.Windows.Forms.Panel
    Friend WithEvents panelFormularios As System.Windows.Forms.Panel
    Friend WithEvents btnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents submenuReportes As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnRepCompras As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnRepVentas As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reloj As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblReloj As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grillaVencimientos As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRutOc As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox3 As PictureBox
    Public WithEvents panelMenu As Panel
    Friend WithEvents grillaDetalle As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
End Class
