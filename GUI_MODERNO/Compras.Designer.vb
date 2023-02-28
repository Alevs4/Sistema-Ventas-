<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.calendario1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grillaDetalle = New System.Windows.Forms.DataGridView()
        Me.btnCargarNuevamente = New System.Windows.Forms.Button()
        Me.btnAnularCompra = New System.Windows.Forms.Button()
        Me.grillaCompras = New System.Windows.Forms.DataGridView()
        Me.radioFecha = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioNumFactura = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCerrarCompras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioProveedor = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.grillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillaCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.calendario1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.grillaDetalle)
        Me.Panel1.Controls.Add(Me.btnCargarNuevamente)
        Me.Panel1.Controls.Add(Me.btnAnularCompra)
        Me.Panel1.Controls.Add(Me.grillaCompras)
        Me.Panel1.Controls.Add(Me.radioFecha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.radioNumFactura)
        Me.Panel1.Controls.Add(Me.radioProveedor)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 564)
        Me.Panel1.TabIndex = 6
        '
        'calendario1
        '
        Me.calendario1.CalendarForeColor = System.Drawing.Color.DarkGray
        Me.calendario1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calendario1.Location = New System.Drawing.Point(170, 64)
        Me.calendario1.Name = "calendario1"
        Me.calendario1.Size = New System.Drawing.Size(304, 33)
        Me.calendario1.TabIndex = 38
        Me.calendario1.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(612, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(358, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Detalle de Compra seleccionada"
        '
        'grillaDetalle
        '
        Me.grillaDetalle.AllowUserToAddRows = False
        Me.grillaDetalle.AllowUserToDeleteRows = False
        Me.grillaDetalle.AllowUserToResizeColumns = False
        Me.grillaDetalle.AllowUserToResizeRows = False
        Me.grillaDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaDetalle.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaDetalle.EnableHeadersVisualStyles = False
        Me.grillaDetalle.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaDetalle.Location = New System.Drawing.Point(571, 111)
        Me.grillaDetalle.MultiSelect = False
        Me.grillaDetalle.Name = "grillaDetalle"
        Me.grillaDetalle.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grillaDetalle.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaDetalle.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grillaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaDetalle.Size = New System.Drawing.Size(444, 389)
        Me.grillaDetalle.TabIndex = 36
        '
        'btnCargarNuevamente
        '
        Me.btnCargarNuevamente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCargarNuevamente.BackColor = System.Drawing.Color.Tomato
        Me.btnCargarNuevamente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnCargarNuevamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarNuevamente.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarNuevamente.ForeColor = System.Drawing.Color.White
        Me.btnCargarNuevamente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarNuevamente.Location = New System.Drawing.Point(11, 506)
        Me.btnCargarNuevamente.Name = "btnCargarNuevamente"
        Me.btnCargarNuevamente.Size = New System.Drawing.Size(375, 48)
        Me.btnCargarNuevamente.TabIndex = 35
        Me.btnCargarNuevamente.Text = "Presione aquí para volver a cargar tabla completa"
        Me.btnCargarNuevamente.UseVisualStyleBackColor = False
        Me.btnCargarNuevamente.Visible = False
        '
        'btnAnularCompra
        '
        Me.btnAnularCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnularCompra.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAnularCompra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnAnularCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnularCompra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularCompra.ForeColor = System.Drawing.Color.White
        Me.btnAnularCompra.Image = Global.GUI_MODERNO.My.Resources.Resources.editar__1_
        Me.btnAnularCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnularCompra.Location = New System.Drawing.Point(780, 506)
        Me.btnAnularCompra.Name = "btnAnularCompra"
        Me.btnAnularCompra.Size = New System.Drawing.Size(235, 48)
        Me.btnAnularCompra.TabIndex = 34
        Me.btnAnularCompra.Text = "Anular Compra Seleccionada"
        Me.btnAnularCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnularCompra.UseVisualStyleBackColor = False
        '
        'grillaCompras
        '
        Me.grillaCompras.AllowUserToAddRows = False
        Me.grillaCompras.AllowUserToDeleteRows = False
        Me.grillaCompras.AllowUserToResizeColumns = False
        Me.grillaCompras.AllowUserToResizeRows = False
        Me.grillaCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaCompras.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grillaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaCompras.EnableHeadersVisualStyles = False
        Me.grillaCompras.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaCompras.Location = New System.Drawing.Point(11, 111)
        Me.grillaCompras.MultiSelect = False
        Me.grillaCompras.Name = "grillaCompras"
        Me.grillaCompras.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grillaCompras.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaCompras.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.grillaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaCompras.Size = New System.Drawing.Size(533, 389)
        Me.grillaCompras.TabIndex = 33
        '
        'radioFecha
        '
        Me.radioFecha.AutoSize = True
        Me.radioFecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFecha.Location = New System.Drawing.Point(263, 37)
        Me.radioFecha.Name = "radioFecha"
        Me.radioFecha.Size = New System.Drawing.Size(59, 21)
        Me.radioFecha.TabIndex = 32
        Me.radioFecha.TabStop = True
        Me.radioFecha.Text = "Fecha"
        Me.radioFecha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Buscar compra por:"
        '
        'radioNumFactura
        '
        Me.radioNumFactura.AutoSize = True
        Me.radioNumFactura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNumFactura.Location = New System.Drawing.Point(176, 37)
        Me.radioNumFactura.Name = "radioNumFactura"
        Me.radioNumFactura.Size = New System.Drawing.Size(87, 21)
        Me.radioNumFactura.TabIndex = 30
        Me.radioNumFactura.TabStop = True
        Me.radioNumFactura.Text = "N° Factura"
        Me.radioNumFactura.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.GUI_MODERNO.My.Resources.Resources.lupa_herramienta
        Me.btnBuscar.Location = New System.Drawing.Point(480, 64)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 33)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBuscar.Location = New System.Drawing.Point(170, 64)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(304, 33)
        Me.txtBuscar.TabIndex = 27
        Me.txtBuscar.Text = "Buscar"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.GUI_MODERNO.My.Resources.Resources.carrito_de_la_compra
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.Location = New System.Drawing.Point(11, 31)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 66)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "Nueva Compra"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCerrarCompras
        '
        Me.btnCerrarCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarCompras.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrarCompras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnCerrarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarCompras.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarCompras.ForeColor = System.Drawing.Color.White
        Me.btnCerrarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarCompras.Location = New System.Drawing.Point(875, 12)
        Me.btnCerrarCompras.Name = "btnCerrarCompras"
        Me.btnCerrarCompras.Size = New System.Drawing.Size(165, 44)
        Me.btnCerrarCompras.TabIndex = 13
        Me.btnCerrarCompras.Text = "Cerrar ventana Compras"
        Me.btnCerrarCompras.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 50)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Listado de Compras"
        '
        'radioProveedor
        '
        Me.radioProveedor.AutoSize = True
        Me.radioProveedor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioProveedor.Location = New System.Drawing.Point(328, 37)
        Me.radioProveedor.Name = "radioProveedor"
        Me.radioProveedor.Size = New System.Drawing.Size(87, 21)
        Me.radioProveedor.TabIndex = 29
        Me.radioProveedor.TabStop = True
        Me.radioProveedor.Text = "Proveedor"
        Me.radioProveedor.UseVisualStyleBackColor = True
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1050, 638)
        Me.Controls.Add(Me.btnCerrarCompras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Compras"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillaCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents calendario1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents grillaDetalle As DataGridView
    Friend WithEvents btnCargarNuevamente As Button
    Friend WithEvents btnAnularCompra As Button
    Friend WithEvents grillaCompras As DataGridView
    Friend WithEvents radioFecha As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents radioNumFactura As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCerrarCompras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents radioProveedor As RadioButton
End Class
