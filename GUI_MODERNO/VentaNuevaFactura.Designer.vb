<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaNuevaFactura
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblAgregarProducto = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCantidadAgregar = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.grillaVenta = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.panelBuscarProducto = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grillaBuscarProducto = New System.Windows.Forms.DataGridView()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbCondicionesPago = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblNFactura = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnBuscarCodBarras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPagaCon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVuelto = New System.Windows.Forms.TextBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEstadoBusqueda = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorCompra = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grillaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBuscarProducto.SuspendLayout()
        CType(Me.grillaBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblAgregarProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1485, 47)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(1371, 11)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(99, 31)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAgregarProducto
        '
        Me.lblAgregarProducto.AutoSize = True
        Me.lblAgregarProducto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarProducto.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAgregarProducto.Location = New System.Drawing.Point(16, 7)
        Me.lblAgregarProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgregarProducto.Name = "lblAgregarProducto"
        Me.lblAgregarProducto.Size = New System.Drawing.Size(74, 32)
        Me.lblAgregarProducto.TabIndex = 1
        Me.lblAgregarProducto.Text = "Venta"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(247, 94)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 23)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Ingresar o Escanear:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 126)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 32)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Cantidad:"
        '
        'txtCantidadAgregar
        '
        Me.txtCantidadAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadAgregar.Enabled = False
        Me.txtCantidadAgregar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAgregar.Location = New System.Drawing.Point(155, 124)
        Me.txtCantidadAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadAgregar.Name = "txtCantidadAgregar"
        Me.txtCantidadAgregar.Size = New System.Drawing.Size(63, 34)
        Me.txtCantidadAgregar.TabIndex = 0
        Me.txtCantidadAgregar.Text = "1"
        Me.txtCantidadAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(804, 190)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(205, 41)
        Me.btnAgregar.TabIndex = 32
        Me.btnAgregar.TabStop = False
        Me.btnAgregar.Text = "Agregar a Venta"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(481, 225)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 23)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Categoría:"
        '
        'txtCategoria
        '
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Enabled = False
        Me.txtCategoria.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(580, 220)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(187, 32)
        Me.txtCategoria.TabIndex = 30
        Me.txtCategoria.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(481, 190)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Marca:"
        '
        'txtMarca
        '
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(580, 185)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(187, 32)
        Me.txtMarca.TabIndex = 24
        Me.txtMarca.TabStop = False
        '
        'txtPrecio
        '
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(128, 220)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(187, 32)
        Me.txtPrecio.TabIndex = 22
        Me.txtPrecio.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 190)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(128, 185)
        Me.txtProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(321, 32)
        Me.txtProducto.TabIndex = 16
        Me.txtProducto.TabStop = False
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.ForeColor = System.Drawing.Color.DimGray
        Me.txtCodigoBarras.Location = New System.Drawing.Point(247, 119)
        Me.txtCodigoBarras.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(267, 39)
        Me.txtCodigoBarras.TabIndex = 1
        '
        'grillaVenta
        '
        Me.grillaVenta.AllowUserToAddRows = False
        Me.grillaVenta.AllowUserToResizeColumns = False
        Me.grillaVenta.AllowUserToResizeRows = False
        Me.grillaVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grillaVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaVenta.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Precio, Me.Cantidad, Me.Total, Me.Precio_Compra})
        Me.grillaVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaVenta.EnableHeadersVisualStyles = False
        Me.grillaVenta.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaVenta.Location = New System.Drawing.Point(13, 269)
        Me.grillaVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.grillaVenta.MultiSelect = False
        Me.grillaVenta.Name = "grillaVenta"
        Me.grillaVenta.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grillaVenta.RowHeadersVisible = False
        Me.grillaVenta.RowHeadersWidth = 51
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaVenta.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grillaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaVenta.Size = New System.Drawing.Size(1441, 396)
        Me.grillaVenta.TabIndex = 21
        Me.grillaVenta.TabStop = False
        '
        'Codigo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Codigo.Width = 58
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Producto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 6
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Precio
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Precio.Width = 54
        '
        'Cantidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cantidad.Width = 70
        '
        'Total
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Total.DefaultCellStyle = DataGridViewCellStyle6
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.Width = 46
        '
        'Precio_Compra
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Precio_Compra.DefaultCellStyle = DataGridViewCellStyle7
        Me.Precio_Compra.HeaderText = "Precio Compra x Producto"
        Me.Precio_Compra.MinimumWidth = 6
        Me.Precio_Compra.Name = "Precio_Compra"
        Me.Precio_Compra.ReadOnly = True
        Me.Precio_Compra.Width = 132
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(274, 730)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 28)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(372, 724)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(167, 34)
        Me.txtTotal.TabIndex = 35
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 23)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Precio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 50)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(238, 32)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Productos a ingresar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(432, 69)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(136, 46)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.Text = "Buscar en Base de Datos"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'panelBuscarProducto
        '
        Me.panelBuscarProducto.BackColor = System.Drawing.Color.DarkGray
        Me.panelBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelBuscarProducto.Controls.Add(Me.Button1)
        Me.panelBuscarProducto.Controls.Add(Me.grillaBuscarProducto)
        Me.panelBuscarProducto.Controls.Add(Me.txtBuscarProducto)
        Me.panelBuscarProducto.Location = New System.Drawing.Point(639, 50)
        Me.panelBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.panelBuscarProducto.Name = "panelBuscarProducto"
        Me.panelBuscarProducto.Size = New System.Drawing.Size(833, 211)
        Me.panelBuscarProducto.TabIndex = 41
        Me.panelBuscarProducto.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(749, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 31)
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaBuscarProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grillaBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaBuscarProducto.EnableHeadersVisualStyles = False
        Me.grillaBuscarProducto.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaBuscarProducto.Location = New System.Drawing.Point(12, 46)
        Me.grillaBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.grillaBuscarProducto.MultiSelect = False
        Me.grillaBuscarProducto.Name = "grillaBuscarProducto"
        Me.grillaBuscarProducto.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaBuscarProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grillaBuscarProducto.RowHeadersVisible = False
        Me.grillaBuscarProducto.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaBuscarProducto.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.grillaBuscarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaBuscarProducto.Size = New System.Drawing.Size(805, 156)
        Me.grillaBuscarProducto.TabIndex = 42
        Me.grillaBuscarProducto.TabStop = False
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.BackColor = System.Drawing.Color.White
        Me.txtBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProducto.ForeColor = System.Drawing.Color.DimGray
        Me.txtBuscarProducto.Location = New System.Drawing.Point(12, 7)
        Me.txtBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(365, 26)
        Me.txtBuscarProducto.TabIndex = 0
        Me.txtBuscarProducto.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(679, 60)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 23)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Codigo de Producto:"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Enabled = False
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(860, 52)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(79, 32)
        Me.txtCodigoProducto.TabIndex = 42
        Me.txtCodigoProducto.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(796, 101)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 23)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(860, 92)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(79, 32)
        Me.txtStock.TabIndex = 44
        Me.txtStock.TabStop = False
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.Location = New System.Drawing.Point(9, 714)
        Me.btnVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(184, 105)
        Me.btnVenta.TabIndex = 46
        Me.btnVenta.TabStop = False
        Me.btnVenta.Text = "Generar Venta"
        Me.btnVenta.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(345, 730)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 28)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "$"
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaVenta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaVenta.Location = New System.Drawing.Point(9, 826)
        Me.btnNuevaVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(184, 41)
        Me.btnNuevaVenta.TabIndex = 51
        Me.btnNuevaVenta.TabStop = False
        Me.btnNuevaVenta.Text = "Nueva Venta"
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(581, 730)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(125, 23)
        Me.Label24.TabIndex = 54
        Me.Label24.Text = "Medio de Pago"
        '
        'cmbCondicionesPago
        '
        Me.cmbCondicionesPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCondicionesPago.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondicionesPago.FormattingEnabled = True
        Me.cmbCondicionesPago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarjeta Crédito", "Tarjeta Débito"})
        Me.cmbCondicionesPago.Location = New System.Drawing.Point(721, 729)
        Me.cmbCondicionesPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCondicionesPago.MaxLength = 1
        Me.cmbCondicionesPago.Name = "cmbCondicionesPago"
        Me.cmbCondicionesPago.Size = New System.Drawing.Size(200, 28)
        Me.cmbCondicionesPago.TabIndex = 28
        Me.cmbCondicionesPago.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 690)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(103, 19)
        Me.Label27.TabIndex = 57
        Me.Label27.Text = "N° Documento:"
        '
        'lblNFactura
        '
        Me.lblNFactura.AutoSize = True
        Me.lblNFactura.Location = New System.Drawing.Point(132, 690)
        Me.lblNFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNFactura.Name = "lblNFactura"
        Me.lblNFactura.Size = New System.Drawing.Size(12, 16)
        Me.lblNFactura.TabIndex = 58
        Me.lblNFactura.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(10, 669)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 19)
        Me.Label28.TabIndex = 59
        Me.Label28.Text = "Fecha Venta:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(132, 669)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(12, 16)
        Me.lblFecha.TabIndex = 60
        Me.lblFecha.Text = "*"
        '
        'btnBuscarCodBarras
        '
        Me.btnBuscarCodBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarCodBarras.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscarCodBarras.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarCodBarras.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCodBarras.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCodBarras.Image = Global.GUI_MODERNO.My.Resources.Resources.lupa_herramienta
        Me.btnBuscarCodBarras.Location = New System.Drawing.Point(539, 119)
        Me.btnBuscarCodBarras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscarCodBarras.Name = "btnBuscarCodBarras"
        Me.btnBuscarCodBarras.Size = New System.Drawing.Size(55, 41)
        Me.btnBuscarCodBarras.TabIndex = 2
        Me.btnBuscarCodBarras.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 770)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 28)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 770)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 28)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Paga con:"
        '
        'txtPagaCon
        '
        Me.txtPagaCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagaCon.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagaCon.Location = New System.Drawing.Point(372, 767)
        Me.txtPagaCon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPagaCon.Name = "txtPagaCon"
        Me.txtPagaCon.Size = New System.Drawing.Size(167, 34)
        Me.txtPagaCon.TabIndex = 61
        Me.txtPagaCon.TabStop = False
        Me.txtPagaCon.Text = "0"
        Me.txtPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(688, 770)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 28)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(602, 770)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 28)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Vuelto:"
        '
        'txtVuelto
        '
        Me.txtVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVuelto.Enabled = False
        Me.txtVuelto.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVuelto.Location = New System.Drawing.Point(721, 767)
        Me.txtVuelto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(201, 34)
        Me.txtVuelto.TabIndex = 64
        Me.txtVuelto.TabStop = False
        Me.txtVuelto.Text = "0"
        Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.White
        Me.btnQuitar.Location = New System.Drawing.Point(1249, 678)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(205, 41)
        Me.btnQuitar.TabIndex = 67
        Me.btnQuitar.TabStop = False
        Me.btnQuitar.Text = "Quitar de la Lista"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 23)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "X"
        '
        'lblEstadoBusqueda
        '
        Me.lblEstadoBusqueda.AutoSize = True
        Me.lblEstadoBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoBusqueda.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstadoBusqueda.Location = New System.Drawing.Point(247, 164)
        Me.lblEstadoBusqueda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoBusqueda.Name = "lblEstadoBusqueda"
        Me.lblEstadoBusqueda.Size = New System.Drawing.Size(0, 20)
        Me.lblEstadoBusqueda.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(643, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 23)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Valor de compra unitario:"
        '
        'txtValorCompra
        '
        Me.txtValorCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorCompra.Enabled = False
        Me.txtValorCompra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorCompra.Location = New System.Drawing.Point(860, 128)
        Me.txtValorCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorCompra.Name = "txtValorCompra"
        Me.txtValorCompra.Size = New System.Drawing.Size(149, 32)
        Me.txtValorCompra.TabIndex = 70
        Me.txtValorCompra.TabStop = False
        '
        'VentaNuevaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1485, 871)
        Me.Controls.Add(Me.panelBuscarProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValorCompra)
        Me.Controls.Add(Me.lblEstadoBusqueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVuelto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPagaCon)
        Me.Controls.Add(Me.btnBuscarCodBarras)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lblNFactura)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cmbCondicionesPago)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnNuevaVenta)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCantidadAgregar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grillaVenta)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VentaNuevaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaNueva"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grillaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBuscarProducto.ResumeLayout(False)
        Me.panelBuscarProducto.PerformLayout()
        CType(Me.grillaBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAgregarProducto As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents grillaVenta As System.Windows.Forms.DataGridView
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadAgregar As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents panelBuscarProducto As System.Windows.Forms.Panel
    Friend WithEvents grillaBuscarProducto As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnVenta As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaVenta As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbCondicionesPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblNFactura As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCodBarras As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPagaCon As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVuelto As System.Windows.Forms.TextBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEstadoBusqueda As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValorCompra As TextBox
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Compra As DataGridViewTextBoxColumn
End Class
