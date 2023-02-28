<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrarConfig = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProveedores = New System.Windows.Forms.PictureBox()
        Me.btnCatMarcas = New System.Windows.Forms.PictureBox()
        Me.btnUsuarios = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCatMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnCerrarConfig)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Configuración"
        '
        'btnCerrarConfig
        '
        Me.btnCerrarConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarConfig.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrarConfig.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnCerrarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarConfig.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarConfig.ForeColor = System.Drawing.Color.White
        Me.btnCerrarConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarConfig.Location = New System.Drawing.Point(577, 6)
        Me.btnCerrarConfig.Name = "btnCerrarConfig"
        Me.btnCerrarConfig.Size = New System.Drawing.Size(152, 44)
        Me.btnCerrarConfig.TabIndex = 10
        Me.btnCerrarConfig.Text = "Cerrar ventana Configuración"
        Me.btnCerrarConfig.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(167, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Marcas y Categorías"
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.Gray
        Me.btnProveedores.Image = Global.GUI_MODERNO.My.Resources.Resources.hotel_supplier
        Me.btnProveedores.Location = New System.Drawing.Point(6, 19)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(128, 128)
        Me.btnProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnProveedores.TabIndex = 3
        Me.btnProveedores.TabStop = False
        '
        'btnCatMarcas
        '
        Me.btnCatMarcas.BackColor = System.Drawing.Color.Gray
        Me.btnCatMarcas.Image = Global.GUI_MODERNO.My.Resources.Resources.lista
        Me.btnCatMarcas.Location = New System.Drawing.Point(6, 19)
        Me.btnCatMarcas.Name = "btnCatMarcas"
        Me.btnCatMarcas.Size = New System.Drawing.Size(128, 128)
        Me.btnCatMarcas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCatMarcas.TabIndex = 2
        Me.btnCatMarcas.TabStop = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Gray
        Me.btnUsuarios.Image = Global.GUI_MODERNO.My.Resources.Resources.reanudar
        Me.btnUsuarios.Location = New System.Drawing.Point(6, 19)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(128, 128)
        Me.btnUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(137, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Proveedores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(33, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(537, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Esta sección podrá administrar Usuarios, Marcas y Categorías y Proveedores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUsuarios)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 161)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCatMarcas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 161)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnProveedores)
        Me.GroupBox3.Location = New System.Drawing.Point(37, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 161)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(741, 492)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCatMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUsuarios As System.Windows.Forms.PictureBox
    Friend WithEvents btnCatMarcas As System.Windows.Forms.PictureBox
    Friend WithEvents btnProveedores As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrarConfig As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
