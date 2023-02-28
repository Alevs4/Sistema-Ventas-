<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenedorMarcaCategoria
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
        Me.lblAgregarCategoria = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificarCat = New System.Windows.Forms.Button()
        Me.btnEliminarCat = New System.Windows.Forms.Button()
        Me.btnEliminarMarca = New System.Windows.Forms.Button()
        Me.btnModifcarMarca = New System.Windows.Forms.Button()
        Me.txtModCat = New System.Windows.Forms.TextBox()
        Me.txtModMar = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblAgregarCategoria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 55)
        Me.Panel1.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(512, 11)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(74, 34)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAgregarCategoria
        '
        Me.lblAgregarCategoria.AutoSize = True
        Me.lblAgregarCategoria.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarCategoria.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAgregarCategoria.Location = New System.Drawing.Point(12, 20)
        Me.lblAgregarCategoria.Name = "lblAgregarCategoria"
        Me.lblAgregarCategoria.Size = New System.Drawing.Size(317, 25)
        Me.lblAgregarCategoria.TabIndex = 13
        Me.lblAgregarCategoria.Text = "Mantenedor de Marcas y Categorías"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(19, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(259, 229)
        Me.ListBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categorías"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ListBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Location = New System.Drawing.Point(316, 91)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(259, 229)
        Me.ListBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(311, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Marcas"
        '
        'btnModificarCat
        '
        Me.btnModificarCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarCat.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnModificarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModificarCat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCat.ForeColor = System.Drawing.Color.White
        Me.btnModificarCat.Location = New System.Drawing.Point(19, 351)
        Me.btnModificarCat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarCat.Name = "btnModificarCat"
        Me.btnModificarCat.Size = New System.Drawing.Size(114, 34)
        Me.btnModificarCat.TabIndex = 15
        Me.btnModificarCat.TabStop = False
        Me.btnModificarCat.Text = "Modificar"
        Me.btnModificarCat.UseVisualStyleBackColor = False
        '
        'btnEliminarCat
        '
        Me.btnEliminarCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarCat.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarCat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCat.ForeColor = System.Drawing.Color.White
        Me.btnEliminarCat.Location = New System.Drawing.Point(204, 351)
        Me.btnEliminarCat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarCat.Name = "btnEliminarCat"
        Me.btnEliminarCat.Size = New System.Drawing.Size(74, 34)
        Me.btnEliminarCat.TabIndex = 17
        Me.btnEliminarCat.TabStop = False
        Me.btnEliminarCat.Text = "Eliminar"
        Me.btnEliminarCat.UseVisualStyleBackColor = False
        '
        'btnEliminarMarca
        '
        Me.btnEliminarMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarMarca.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminarMarca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarMarca.ForeColor = System.Drawing.Color.White
        Me.btnEliminarMarca.Location = New System.Drawing.Point(501, 351)
        Me.btnEliminarMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarMarca.Name = "btnEliminarMarca"
        Me.btnEliminarMarca.Size = New System.Drawing.Size(74, 34)
        Me.btnEliminarMarca.TabIndex = 18
        Me.btnEliminarMarca.TabStop = False
        Me.btnEliminarMarca.Text = "Eliminar"
        Me.btnEliminarMarca.UseVisualStyleBackColor = False
        '
        'btnModifcarMarca
        '
        Me.btnModifcarMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifcarMarca.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnModifcarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifcarMarca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifcarMarca.ForeColor = System.Drawing.Color.White
        Me.btnModifcarMarca.Location = New System.Drawing.Point(316, 351)
        Me.btnModifcarMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModifcarMarca.Name = "btnModifcarMarca"
        Me.btnModifcarMarca.Size = New System.Drawing.Size(114, 34)
        Me.btnModifcarMarca.TabIndex = 19
        Me.btnModifcarMarca.TabStop = False
        Me.btnModifcarMarca.Text = "Modificar"
        Me.btnModifcarMarca.UseVisualStyleBackColor = False
        '
        'txtModCat
        '
        Me.txtModCat.Location = New System.Drawing.Point(19, 326)
        Me.txtModCat.Name = "txtModCat"
        Me.txtModCat.Size = New System.Drawing.Size(150, 20)
        Me.txtModCat.TabIndex = 20
        '
        'txtModMar
        '
        Me.txtModMar.Location = New System.Drawing.Point(316, 326)
        Me.txtModMar.Name = "txtModMar"
        Me.txtModMar.Size = New System.Drawing.Size(150, 20)
        Me.txtModMar.TabIndex = 21
        '
        'MantenedorMarcaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 397)
        Me.Controls.Add(Me.txtModMar)
        Me.Controls.Add(Me.txtModCat)
        Me.Controls.Add(Me.btnModifcarMarca)
        Me.Controls.Add(Me.btnEliminarMarca)
        Me.Controls.Add(Me.btnEliminarCat)
        Me.Controls.Add(Me.btnModificarCat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MantenedorMarcaCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantenedorMarcaCategoria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblAgregarCategoria As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificarCat As Button
    Friend WithEvents btnEliminarCat As Button
    Friend WithEvents btnEliminarMarca As Button
    Friend WithEvents btnModifcarMarca As Button
    Friend WithEvents txtModCat As TextBox
    Friend WithEvents txtModMar As TextBox
End Class
