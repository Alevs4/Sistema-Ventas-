<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrarVentas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.calendario1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grillaDetalle = New System.Windows.Forms.DataGridView()
        Me.btnCargarNuevamente = New System.Windows.Forms.Button()
        Me.btnAnularVenta = New System.Windows.Forms.Button()
        Me.grillaVentas = New System.Windows.Forms.DataGridView()
        Me.radioFecha = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioNumBoleta = New System.Windows.Forms.RadioButton()
        Me.radioTotal = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.grillaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarVentas
        '
        Me.btnCerrarVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarVentas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnCerrarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarVentas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarVentas.ForeColor = System.Drawing.Color.White
        Me.btnCerrarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarVentas.Location = New System.Drawing.Point(886, 12)
        Me.btnCerrarVentas.Name = "btnCerrarVentas"
        Me.btnCerrarVentas.Size = New System.Drawing.Size(152, 44)
        Me.btnCerrarVentas.TabIndex = 11
        Me.btnCerrarVentas.Text = "Cerrar ventana Ventas"
        Me.btnCerrarVentas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 50)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Listado de Ventas"
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
        Me.Panel1.Controls.Add(Me.btnAnularVenta)
        Me.Panel1.Controls.Add(Me.grillaVentas)
        Me.Panel1.Controls.Add(Me.radioFecha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.radioNumBoleta)
        Me.Panel1.Controls.Add(Me.radioTotal)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 564)
        Me.Panel1.TabIndex = 12
        '
        'calendario1
        '
        Me.calendario1.CalendarForeColor = System.Drawing.Color.DarkGray
        Me.calendario1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calendario1.Location = New System.Drawing.Point(168, 69)
        Me.calendario1.Name = "calendario1"
        Me.calendario1.Size = New System.Drawing.Size(304, 33)
        Me.calendario1.TabIndex = 25
        Me.calendario1.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(635, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 32)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Detalle de Venta seleccionada"
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
        Me.grillaDetalle.Location = New System.Drawing.Point(569, 116)
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
        Me.grillaDetalle.Size = New System.Drawing.Size(444, 389)
        Me.grillaDetalle.TabIndex = 23
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
        Me.btnCargarNuevamente.Location = New System.Drawing.Point(9, 511)
        Me.btnCargarNuevamente.Name = "btnCargarNuevamente"
        Me.btnCargarNuevamente.Size = New System.Drawing.Size(375, 48)
        Me.btnCargarNuevamente.TabIndex = 22
        Me.btnCargarNuevamente.Text = "Presione aquí para volver a cargar tabla completa"
        Me.btnCargarNuevamente.UseVisualStyleBackColor = False
        Me.btnCargarNuevamente.Visible = False
        '
        'btnAnularVenta
        '
        Me.btnAnularVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnularVenta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAnularVenta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnularVenta.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularVenta.ForeColor = System.Drawing.Color.White
        Me.btnAnularVenta.Image = Global.GUI_MODERNO.My.Resources.Resources.editar__1_
        Me.btnAnularVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnularVenta.Location = New System.Drawing.Point(795, 511)
        Me.btnAnularVenta.Name = "btnAnularVenta"
        Me.btnAnularVenta.Size = New System.Drawing.Size(218, 48)
        Me.btnAnularVenta.TabIndex = 21
        Me.btnAnularVenta.Text = "Anular Venta Seleccionada"
        Me.btnAnularVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnularVenta.UseVisualStyleBackColor = False
        '
        'grillaVentas
        '
        Me.grillaVentas.AllowUserToAddRows = False
        Me.grillaVentas.AllowUserToDeleteRows = False
        Me.grillaVentas.AllowUserToResizeColumns = False
        Me.grillaVentas.AllowUserToResizeRows = False
        Me.grillaVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaVentas.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaVentas.EnableHeadersVisualStyles = False
        Me.grillaVentas.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaVentas.Location = New System.Drawing.Point(9, 116)
        Me.grillaVentas.MultiSelect = False
        Me.grillaVentas.Name = "grillaVentas"
        Me.grillaVentas.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grillaVentas.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaVentas.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.grillaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaVentas.Size = New System.Drawing.Size(533, 389)
        Me.grillaVentas.TabIndex = 19
        '
        'radioFecha
        '
        Me.radioFecha.AutoSize = True
        Me.radioFecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFecha.Location = New System.Drawing.Point(261, 42)
        Me.radioFecha.Name = "radioFecha"
        Me.radioFecha.Size = New System.Drawing.Size(59, 21)
        Me.radioFecha.TabIndex = 18
        Me.radioFecha.TabStop = True
        Me.radioFecha.Text = "Fecha"
        Me.radioFecha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Buscar venta por:"
        '
        'radioNumBoleta
        '
        Me.radioNumBoleta.AutoSize = True
        Me.radioNumBoleta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNumBoleta.Location = New System.Drawing.Point(174, 42)
        Me.radioNumBoleta.Name = "radioNumBoleta"
        Me.radioNumBoleta.Size = New System.Drawing.Size(77, 21)
        Me.radioNumBoleta.TabIndex = 16
        Me.radioNumBoleta.TabStop = True
        Me.radioNumBoleta.Text = "N° Venta"
        Me.radioNumBoleta.UseVisualStyleBackColor = True
        '
        'radioTotal
        '
        Me.radioTotal.AutoSize = True
        Me.radioTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioTotal.Location = New System.Drawing.Point(326, 42)
        Me.radioTotal.Name = "radioTotal"
        Me.radioTotal.Size = New System.Drawing.Size(54, 21)
        Me.radioTotal.TabIndex = 15
        Me.radioTotal.TabStop = True
        Me.radioTotal.Text = "Total"
        Me.radioTotal.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.GUI_MODERNO.My.Resources.Resources.lupa_herramienta
        Me.btnBuscar.Location = New System.Drawing.Point(478, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 33)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBuscar.Location = New System.Drawing.Point(168, 69)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(304, 33)
        Me.txtBuscar.TabIndex = 13
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
        Me.btnNuevo.Location = New System.Drawing.Point(9, 44)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(153, 66)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nueva Venta"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1050, 638)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrarVentas)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Formulario 2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grillaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarVentas As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents radioFecha As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioNumBoleta As System.Windows.Forms.RadioButton
    Friend WithEvents radioTotal As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents grillaVentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAnularVenta As System.Windows.Forms.Button
    Friend WithEvents btnCargarNuevamente As Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grillaDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents calendario1 As System.Windows.Forms.DateTimePicker
End Class
