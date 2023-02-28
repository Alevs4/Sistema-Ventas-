<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProducto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblAgregarProducto = New System.Windows.Forms.Label()
        Me.btnEditarProducto = New System.Windows.Forms.Button()
        Me.txtBarrasEditar = New System.Windows.Forms.TextBox()
        Me.cmbMarcaEditar = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidadEditar = New System.Windows.Forms.TextBox()
        Me.txtPrecioEditar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcionEditar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreEditar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCategoriaEditar = New System.Windows.Forms.ComboBox()
        Me.txtCodigoEditar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.calendario2 = New System.Windows.Forms.DateTimePicker()
        Me.chkVencimiento = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblAgregarProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 55)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(368, 15)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(74, 34)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAgregarProducto
        '
        Me.lblAgregarProducto.AutoSize = True
        Me.lblAgregarProducto.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarProducto.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAgregarProducto.Location = New System.Drawing.Point(12, 9)
        Me.lblAgregarProducto.Name = "lblAgregarProducto"
        Me.lblAgregarProducto.Size = New System.Drawing.Size(215, 40)
        Me.lblAgregarProducto.TabIndex = 8
        Me.lblAgregarProducto.Text = "Editar Producto"
        '
        'btnEditarProducto
        '
        Me.btnEditarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditarProducto.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditarProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarProducto.ForeColor = System.Drawing.Color.White
        Me.btnEditarProducto.Location = New System.Drawing.Point(258, 364)
        Me.btnEditarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Size = New System.Drawing.Size(172, 36)
        Me.btnEditarProducto.TabIndex = 33
        Me.btnEditarProducto.Text = "Editar Producto"
        Me.btnEditarProducto.UseVisualStyleBackColor = False
        '
        'txtBarrasEditar
        '
        Me.txtBarrasEditar.BackColor = System.Drawing.Color.White
        Me.txtBarrasEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarrasEditar.Enabled = False
        Me.txtBarrasEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarrasEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtBarrasEditar.Location = New System.Drawing.Point(203, 92)
        Me.txtBarrasEditar.Name = "txtBarrasEditar"
        Me.txtBarrasEditar.Size = New System.Drawing.Size(202, 27)
        Me.txtBarrasEditar.TabIndex = 0
        Me.txtBarrasEditar.TabStop = False
        '
        'cmbMarcaEditar
        '
        Me.cmbMarcaEditar.BackColor = System.Drawing.Color.White
        Me.cmbMarcaEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarcaEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmbMarcaEditar.FormattingEnabled = True
        Me.cmbMarcaEditar.Location = New System.Drawing.Point(25, 252)
        Me.cmbMarcaEditar.Name = "cmbMarcaEditar"
        Me.cmbMarcaEditar.Size = New System.Drawing.Size(177, 28)
        Me.cmbMarcaEditar.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(118, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "$"
        '
        'txtCantidadEditar
        '
        Me.txtCantidadEditar.BackColor = System.Drawing.Color.White
        Me.txtCantidadEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCantidadEditar.Location = New System.Drawing.Point(328, 198)
        Me.txtCantidadEditar.Name = "txtCantidadEditar"
        Me.txtCantidadEditar.Size = New System.Drawing.Size(53, 27)
        Me.txtCantidadEditar.TabIndex = 29
        '
        'txtPrecioEditar
        '
        Me.txtPrecioEditar.BackColor = System.Drawing.Color.White
        Me.txtPrecioEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtPrecioEditar.Location = New System.Drawing.Point(141, 198)
        Me.txtPrecioEditar.Name = "txtPrecioEditar"
        Me.txtPrecioEditar.Size = New System.Drawing.Size(104, 27)
        Me.txtPrecioEditar.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Precio Venta"
        '
        'txtDescripcionEditar
        '
        Me.txtDescripcionEditar.BackColor = System.Drawing.Color.White
        Me.txtDescripcionEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtDescripcionEditar.Location = New System.Drawing.Point(24, 308)
        Me.txtDescripcionEditar.Multiline = True
        Me.txtDescripcionEditar.Name = "txtDescripcionEditar"
        Me.txtDescripcionEditar.Size = New System.Drawing.Size(204, 94)
        Me.txtDescripcionEditar.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(81, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(89, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Marca"
        '
        'txtNombreEditar
        '
        Me.txtNombreEditar.BackColor = System.Drawing.Color.White
        Me.txtNombreEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNombreEditar.Location = New System.Drawing.Point(23, 153)
        Me.txtNombreEditar.Name = "txtNombreEditar"
        Me.txtNombreEditar.Size = New System.Drawing.Size(382, 27)
        Me.txtNombreEditar.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Código de Producto"
        '
        'cmbCategoriaEditar
        '
        Me.cmbCategoriaEditar.BackColor = System.Drawing.Color.White
        Me.cmbCategoriaEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmbCategoriaEditar.FormattingEnabled = True
        Me.cmbCategoriaEditar.Location = New System.Drawing.Point(208, 252)
        Me.cmbCategoriaEditar.Name = "cmbCategoriaEditar"
        Me.cmbCategoriaEditar.Size = New System.Drawing.Size(222, 28)
        Me.cmbCategoriaEditar.TabIndex = 31
        '
        'txtCodigoEditar
        '
        Me.txtCodigoEditar.BackColor = System.Drawing.Color.White
        Me.txtCodigoEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoEditar.Enabled = False
        Me.txtCodigoEditar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoEditar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCodigoEditar.Location = New System.Drawing.Point(25, 92)
        Me.txtCodigoEditar.Name = "txtCodigoEditar"
        Me.txtCodigoEditar.Size = New System.Drawing.Size(140, 27)
        Me.txtCodigoEditar.TabIndex = 34
        Me.txtCodigoEditar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(281, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Categoría"
        '
        'txtLote
        '
        Me.txtLote.Enabled = False
        Me.txtLote.Location = New System.Drawing.Point(295, 339)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(135, 20)
        Me.txtLote.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(255, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Lote: "
        '
        'calendario2
        '
        Me.calendario2.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.calendario2.Enabled = False
        Me.calendario2.Location = New System.Drawing.Point(258, 309)
        Me.calendario2.Name = "calendario2"
        Me.calendario2.Size = New System.Drawing.Size(172, 20)
        Me.calendario2.TabIndex = 38
        '
        'chkVencimiento
        '
        Me.chkVencimiento.AutoSize = True
        Me.chkVencimiento.ForeColor = System.Drawing.Color.White
        Me.chkVencimiento.Location = New System.Drawing.Point(258, 289)
        Me.chkVencimiento.Name = "chkVencimiento"
        Me.chkVencimiento.Size = New System.Drawing.Size(168, 17)
        Me.chkVencimiento.TabIndex = 37
        Me.chkVencimiento.Text = "Agregar fecha de vencimiento"
        Me.chkVencimiento.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(199, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Código de Barras"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(266, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Stock"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(453, 449)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBarrasEditar)
        Me.Controls.Add(Me.calendario2)
        Me.Controls.Add(Me.chkVencimiento)
        Me.Controls.Add(Me.btnEditarProducto)
        Me.Controls.Add(Me.cmbMarcaEditar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCantidadEditar)
        Me.Controls.Add(Me.txtPrecioEditar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescripcionEditar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombreEditar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCategoriaEditar)
        Me.Controls.Add(Me.txtCodigoEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblAgregarProducto As System.Windows.Forms.Label
    Friend WithEvents btnEditarProducto As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarrasEditar As System.Windows.Forms.TextBox
    Friend WithEvents cmbMarcaEditar As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidadEditar As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioEditar As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionEditar As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreEditar As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategoriaEditar As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoEditar As System.Windows.Forms.TextBox
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents calendario2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkVencimiento As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
