<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblAgregarCategoria = New System.Windows.Forms.Label()
        Me.btnAgregarGrilla = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNfactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calendario1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCantidadAgregar = New System.Windows.Forms.TextBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.calendario2 = New System.Windows.Forms.DateTimePicker()
        Me.grillaCompra = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarCompra = New System.Windows.Forms.Button()
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        Me.chkVencimiento = New System.Windows.Forms.CheckBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.panelBuscarProducto = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grillaBuscarProducto = New System.Windows.Forms.DataGridView()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.btnBuscarBD = New System.Windows.Forms.Button()
        Me.txtCantidadActual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNCompra = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sugerido = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NUM1 = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grillaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBuscarProducto.SuspendLayout()
        CType(Me.grillaBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblAgregarCategoria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 55)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(944, 55)
        Me.Panel2.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(859, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 34)
        Me.Button2.TabIndex = 16
        Me.Button2.TabStop = False
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label23.Location = New System.Drawing.Point(12, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(242, 40)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Agregar Compras"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(859, 11)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(74, 34)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAgregarCategoria
        '
        Me.lblAgregarCategoria.AutoSize = True
        Me.lblAgregarCategoria.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarCategoria.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAgregarCategoria.Location = New System.Drawing.Point(12, 8)
        Me.lblAgregarCategoria.Name = "lblAgregarCategoria"
        Me.lblAgregarCategoria.Size = New System.Drawing.Size(242, 40)
        Me.lblAgregarCategoria.TabIndex = 15
        Me.lblAgregarCategoria.Text = "Agregar Compras"
        '
        'btnAgregarGrilla
        '
        Me.btnAgregarGrilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarGrilla.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregarGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarGrilla.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGrilla.ForeColor = System.Drawing.Color.White
        Me.btnAgregarGrilla.Location = New System.Drawing.Point(703, 340)
        Me.btnAgregarGrilla.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarGrilla.Name = "btnAgregarGrilla"
        Me.btnAgregarGrilla.Size = New System.Drawing.Size(211, 44)
        Me.btnAgregarGrilla.TabIndex = 19
        Me.btnAgregarGrilla.TabStop = False
        Me.btnAgregarGrilla.Text = "Ingresar"
        Me.btnAgregarGrilla.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(620, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "N° de Factura:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNfactura
        '
        Me.txtNfactura.BackColor = System.Drawing.Color.White
        Me.txtNfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNfactura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNfactura.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNfactura.Location = New System.Drawing.Point(725, 112)
        Me.txtNfactura.MaxLength = 11
        Me.txtNfactura.Name = "txtNfactura"
        Me.txtNfactura.Size = New System.Drawing.Size(184, 25)
        Me.txtNfactura.TabIndex = 23
        Me.txtNfactura.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(595, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Rut del Proveedor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(569, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Fecha de Compra:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calendario1
        '
        Me.calendario1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario1.Location = New System.Drawing.Point(698, 204)
        Me.calendario1.Name = "calendario1"
        Me.calendario1.Size = New System.Drawing.Size(216, 25)
        Me.calendario1.TabIndex = 28
        Me.calendario1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 50)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Detalle de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la compra"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Producto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.Color.White
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtProducto.Location = New System.Drawing.Point(115, 255)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(249, 25)
        Me.txtProducto.TabIndex = 32
        Me.txtProducto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Descripción:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtDescripcion.Location = New System.Drawing.Point(115, 348)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(249, 56)
        Me.txtDescripcion.TabIndex = 34
        Me.txtDescripcion.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Cantidad Actual:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.White
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Enabled = False
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVenta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPrecioVenta.Location = New System.Drawing.Point(115, 317)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(115, 25)
        Me.txtPrecioVenta.TabIndex = 38
        Me.txtPrecioVenta.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(26, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Cantidad:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCantidadAgregar
        '
        Me.txtCantidadAgregar.BackColor = System.Drawing.Color.White
        Me.txtCantidadAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAgregar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCantidadAgregar.Location = New System.Drawing.Point(29, 155)
        Me.txtCantidadAgregar.Name = "txtCantidadAgregar"
        Me.txtCantidadAgregar.Size = New System.Drawing.Size(60, 29)
        Me.txtCantidadAgregar.TabIndex = 41
        Me.txtCantidadAgregar.TabStop = False
        Me.txtCantidadAgregar.Text = "1"
        Me.txtCantidadAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuitar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.White
        Me.btnQuitar.Location = New System.Drawing.Point(816, 573)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(117, 35)
        Me.btnQuitar.TabIndex = 42
        Me.btnQuitar.TabStop = False
        Me.btnQuitar.Text = "Quitar Elemento"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtTotal.Location = New System.Drawing.Point(725, 579)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(79, 25)
        Me.txtTotal.TabIndex = 43
        Me.txtTotal.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(679, 581)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Total:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(562, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 17)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Caducidad del lote:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calendario2
        '
        Me.calendario2.Enabled = False
        Me.calendario2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario2.Location = New System.Drawing.Point(698, 262)
        Me.calendario2.Name = "calendario2"
        Me.calendario2.Size = New System.Drawing.Size(216, 25)
        Me.calendario2.TabIndex = 47
        Me.calendario2.TabStop = False
        '
        'grillaCompra
        '
        Me.grillaCompra.AllowUserToAddRows = False
        Me.grillaCompra.AllowUserToDeleteRows = False
        Me.grillaCompra.AllowUserToResizeColumns = False
        Me.grillaCompra.AllowUserToResizeRows = False
        Me.grillaCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaCompra.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Precio, Me.Cantidad, Me.Total, Me.fecha_in, Me.fecha_ven, Me.Precio_Venta, Me.vence, Me.lote})
        Me.grillaCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaCompra.EnableHeadersVisualStyles = False
        Me.grillaCompra.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaCompra.Location = New System.Drawing.Point(12, 422)
        Me.grillaCompra.MultiSelect = False
        Me.grillaCompra.Name = "grillaCompra"
        Me.grillaCompra.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grillaCompra.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaCompra.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grillaCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaCompra.Size = New System.Drawing.Size(921, 145)
        Me.grillaCompra.TabIndex = 48
        Me.grillaCompra.TabStop = False
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 65
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio.HeaderText = "Precio Compra"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 93
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Cantidad.HeaderText = "Cant. Compra"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 88
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.HeaderText = "Total Compra"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 87
        '
        'fecha_in
        '
        Me.fecha_in.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_in.HeaderText = "Fecha Ingreso"
        Me.fecha_in.Name = "fecha_in"
        Me.fecha_in.ReadOnly = True
        Me.fecha_in.Width = 92
        '
        'fecha_ven
        '
        Me.fecha_ven.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha_ven.HeaderText = "Fecha Vencimiento"
        Me.fecha_ven.Name = "fecha_ven"
        Me.fecha_ven.ReadOnly = True
        Me.fecha_ven.Width = 113
        '
        'Precio_Venta
        '
        Me.Precio_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio_Venta.HeaderText = "Precio Venta"
        Me.Precio_Venta.Name = "Precio_Venta"
        Me.Precio_Venta.ReadOnly = True
        Me.Precio_Venta.Width = 86
        '
        'vence
        '
        Me.vence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.vence.HeaderText = "¿Vence?"
        Me.vence.Name = "vence"
        Me.vence.ReadOnly = True
        Me.vence.Width = 75
        '
        'lote
        '
        Me.lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.lote.HeaderText = "Nº Lote"
        Me.lote.Name = "lote"
        Me.lote.ReadOnly = True
        Me.lote.Width = 63
        '
        'btnGuardarCompra
        '
        Me.btnGuardarCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarCompra.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnGuardarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarCompra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCompra.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCompra.Location = New System.Drawing.Point(10, 573)
        Me.btnGuardarCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarCompra.Name = "btnGuardarCompra"
        Me.btnGuardarCompra.Size = New System.Drawing.Size(239, 58)
        Me.btnGuardarCompra.TabIndex = 49
        Me.btnGuardarCompra.TabStop = False
        Me.btnGuardarCompra.Text = "Guardar Compra"
        Me.btnGuardarCompra.UseVisualStyleBackColor = False
        '
        'cmbProveedores
        '
        Me.cmbProveedores.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(726, 143)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(184, 25)
        Me.cmbProveedores.TabIndex = 50
        Me.cmbProveedores.TabStop = False
        '
        'chkVencimiento
        '
        Me.chkVencimiento.AutoSize = True
        Me.chkVencimiento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVencimiento.ForeColor = System.Drawing.Color.White
        Me.chkVencimiento.Location = New System.Drawing.Point(697, 239)
        Me.chkVencimiento.Name = "chkVencimiento"
        Me.chkVencimiento.Size = New System.Drawing.Size(192, 19)
        Me.chkVencimiento.TabIndex = 51
        Me.chkVencimiento.TabStop = False
        Me.chkVencimiento.Text = "Ingrear Fecha Vencimiento Lote"
        Me.chkVencimiento.UseVisualStyleBackColor = True
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.Color.White
        Me.lblProveedor.Location = New System.Drawing.Point(723, 171)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(77, 17)
        Me.lblProveedor.TabIndex = 54
        Me.lblProveedor.Text = "(Proveedor)"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(435, 280)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(17, 20)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "$"
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.BackColor = System.Drawing.Color.White
        Me.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioCompra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioCompra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPrecioCompra.Location = New System.Drawing.Point(457, 278)
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(86, 27)
        Me.txtPrecioCompra.TabIndex = 56
        Me.txtPrecioCompra.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(454, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 17)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Precio Compra"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAgregarProducto.Location = New System.Drawing.Point(247, 64)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(114, 44)
        Me.btnAgregarProducto.TabIndex = 63
        Me.btnAgregarProducto.TabStop = False
        Me.btnAgregarProducto.Text = "Abrir formulario Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'panelBuscarProducto
        '
        Me.panelBuscarProducto.BackColor = System.Drawing.Color.DarkGray
        Me.panelBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBuscarProducto.Controls.Add(Me.Button1)
        Me.panelBuscarProducto.Controls.Add(Me.grillaBuscarProducto)
        Me.panelBuscarProducto.Controls.Add(Me.txtBuscarProducto)
        Me.panelBuscarProducto.Location = New System.Drawing.Point(335, 77)
        Me.panelBuscarProducto.Name = "panelBuscarProducto"
        Me.panelBuscarProducto.Size = New System.Drawing.Size(357, 134)
        Me.panelBuscarProducto.TabIndex = 65
        Me.panelBuscarProducto.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(294, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.TabStop = False
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'grillaBuscarProducto
        '
        Me.grillaBuscarProducto.AllowUserToAddRows = False
        Me.grillaBuscarProducto.AllowUserToResizeRows = False
        Me.grillaBuscarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaBuscarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grillaBuscarProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaBuscarProducto.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaBuscarProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaBuscarProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grillaBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaBuscarProducto.EnableHeadersVisualStyles = False
        Me.grillaBuscarProducto.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaBuscarProducto.Location = New System.Drawing.Point(9, 34)
        Me.grillaBuscarProducto.MultiSelect = False
        Me.grillaBuscarProducto.Name = "grillaBuscarProducto"
        Me.grillaBuscarProducto.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaBuscarProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grillaBuscarProducto.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaBuscarProducto.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grillaBuscarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaBuscarProducto.Size = New System.Drawing.Size(336, 89)
        Me.grillaBuscarProducto.TabIndex = 42
        Me.grillaBuscarProducto.TabStop = False
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.BackColor = System.Drawing.Color.White
        Me.txtBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProducto.ForeColor = System.Drawing.Color.DimGray
        Me.txtBuscarProducto.Location = New System.Drawing.Point(9, 9)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(275, 22)
        Me.txtBuscarProducto.TabIndex = 0
        Me.txtBuscarProducto.TabStop = False
        '
        'btnBuscarBD
        '
        Me.btnBuscarBD.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarBD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarBD.ForeColor = System.Drawing.Color.White
        Me.btnBuscarBD.Location = New System.Drawing.Point(276, 117)
        Me.btnBuscarBD.Name = "btnBuscarBD"
        Me.btnBuscarBD.Size = New System.Drawing.Size(102, 37)
        Me.btnBuscarBD.TabIndex = 64
        Me.btnBuscarBD.TabStop = False
        Me.btnBuscarBD.Text = "Buscar en Base de Datos"
        Me.btnBuscarBD.UseVisualStyleBackColor = False
        '
        'txtCantidadActual
        '
        Me.txtCantidadActual.BackColor = System.Drawing.Color.White
        Me.txtCantidadActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadActual.Enabled = False
        Me.txtCantidadActual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadActual.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCantidadActual.Location = New System.Drawing.Point(115, 286)
        Me.txtCantidadActual.Name = "txtCantidadActual"
        Me.txtCantidadActual.Size = New System.Drawing.Size(115, 25)
        Me.txtCantidadActual.TabIndex = 36
        Me.txtCantidadActual.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(27, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Precio venta:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.ForeColor = System.Drawing.Color.White
        Me.lblcodigo.Location = New System.Drawing.Point(55, 226)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(54, 17)
        Me.lblcodigo.TabIndex = 67
        Me.lblcodigo.Text = "Código:"
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BackColor = System.Drawing.Color.White
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Enabled = False
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCodigoProducto.Location = New System.Drawing.Point(115, 224)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(115, 25)
        Me.txtCodigoProducto.TabIndex = 66
        Me.txtCodigoProducto.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstado.Location = New System.Drawing.Point(16, 197)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 17)
        Me.lblEstado.TabIndex = 68
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(132, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Escanear o Ingresar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(105, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 17)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "X"
        '
        'lblNCompra
        '
        Me.lblNCompra.AutoSize = True
        Me.lblNCompra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNCompra.ForeColor = System.Drawing.Color.White
        Me.lblNCompra.Location = New System.Drawing.Point(726, 79)
        Me.lblNCompra.Name = "lblNCompra"
        Me.lblNCompra.Size = New System.Drawing.Size(110, 17)
        Me.lblNCompra.TabIndex = 71
        Me.lblNCompra.Text = "(numero compra)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(633, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 17)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Nº Compra:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.GUI_MODERNO.My.Resources.Resources.lupa_herramienta
        Me.btnBuscar.Location = New System.Drawing.Point(329, 155)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(49, 29)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(131, 155)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(198, 29)
        Me.txtCodigoBarras.TabIndex = 0
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.Gray
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLote.Enabled = False
        Me.txtLote.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.ForeColor = System.Drawing.Color.White
        Me.txtLote.Location = New System.Drawing.Point(841, 290)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(73, 27)
        Me.txtLote.TabIndex = 76
        Me.txtLote.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(740, 294)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Ultimo lote Nº:"
        Me.Label1.Visible = False
        '
        'sugerido
        '
        Me.sugerido.AutoSize = True
        Me.sugerido.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sugerido.ForeColor = System.Drawing.Color.White
        Me.sugerido.Location = New System.Drawing.Point(375, 389)
        Me.sugerido.Name = "sugerido"
        Me.sugerido.Size = New System.Drawing.Size(62, 20)
        Me.sugerido.TabIndex = 83
        Me.sugerido.Text = "(precio)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(376, 372)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 17)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Precio Venta Sugerido"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(446, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 20)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "%"
        '
        'NUM1
        '
        Me.NUM1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUM1.Location = New System.Drawing.Point(474, 333)
        Me.NUM1.Name = "NUM1"
        Me.NUM1.Size = New System.Drawing.Size(58, 29)
        Me.NUM1.TabIndex = 80
        Me.NUM1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(434, 304)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 17)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "Porcentaje Ganancia"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(542, 391)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 20)
        Me.Label21.TabIndex = 78
        Me.Label21.Text = "$"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPrecio.Location = New System.Drawing.Point(565, 389)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(87, 27)
        Me.txtPrecio.TabIndex = 77
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(569, 367)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 17)
        Me.Label22.TabIndex = 84
        Me.Label22.Text = "Precio Venta"
        '
        'IngresarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(944, 661)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.sugerido)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NUM1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelBuscarProducto)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblNCompra)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.btnBuscarBD)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtPrecioCompra)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.chkVencimiento)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.btnGuardarCompra)
        Me.Controls.Add(Me.grillaCompra)
        Me.Controls.Add(Me.calendario2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.txtCantidadAgregar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCantidadActual)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.calendario1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNfactura)
        Me.Controls.Add(Me.btnAgregarGrilla)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "IngresarCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresarCompra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.grillaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBuscarProducto.ResumeLayout(False)
        Me.panelBuscarProducto.PerformLayout()
        CType(Me.grillaBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblAgregarCategoria As System.Windows.Forms.Label
    Friend WithEvents btnAgregarGrilla As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents calendario1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadAgregar As System.Windows.Forms.TextBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents calendario2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents grillaCompra As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardarCompra As System.Windows.Forms.Button
    Friend WithEvents cmbProveedores As ComboBox
    Friend WithEvents chkVencimiento As CheckBox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents panelBuscarProducto As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents grillaBuscarProducto As DataGridView
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents btnBuscarBD As Button
    Friend WithEvents txtCantidadActual As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblNCompra As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sugerido As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NUM1 As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents fecha_in As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ven As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Venta As DataGridViewTextBoxColumn
    Friend WithEvents vence As DataGridViewTextBoxColumn
    Friend WithEvents lote As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label23 As Label
End Class
