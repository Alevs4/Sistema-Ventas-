<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteCompras
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFechaHoy = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCostos = New System.Windows.Forms.Label()
        Me.aaa = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cal2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkRango = New System.Windows.Forms.CheckBox()
        Me.cal1 = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 46)
        Me.Panel1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de Compras"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(713, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 34)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(763, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "_________________________________________________________________________________" &
    "_____________________________________________"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblUsuario)
        Me.Panel2.Controls.Add(Me.lblFechaHasta)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblFechaInicio)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblVentas)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblFechaHoy)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblCostos)
        Me.Panel2.Controls.Add(Me.aaa)
        Me.Panel2.Location = New System.Drawing.Point(12, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 420)
        Me.Panel2.TabIndex = 33
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(593, 40)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(59, 17)
        Me.lblUsuario.TabIndex = 45
        Me.lblUsuario.Text = "(usuario)"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHasta.Location = New System.Drawing.Point(372, 194)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(55, 20)
        Me.lblFechaHasta.TabIndex = 44
        Me.lblFechaHasta.Text = "(fecha)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(277, 194)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 20)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Hasta: "
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.Location = New System.Drawing.Point(372, 165)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(55, 20)
        Me.lblFechaInicio.TabIndex = 42
        Me.lblFechaInicio.Text = "(fecha)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(273, 165)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Desde: "
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.Location = New System.Drawing.Point(372, 245)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(108, 21)
        Me.lblVentas.TabIndex = 39
        Me.lblVentas.Text = "(Nº Compras)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(176, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 20)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Cantidad de Compras:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI_MODERNO.My.Resources.Resources.libreriasofia
        Me.PictureBox1.Location = New System.Drawing.Point(11, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(507, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Usuario/a: "
        '
        'lblFechaHoy
        '
        Me.lblFechaHoy.AutoSize = True
        Me.lblFechaHoy.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHoy.Location = New System.Drawing.Point(507, 13)
        Me.lblFechaHoy.Name = "lblFechaHoy"
        Me.lblFechaHoy.Size = New System.Drawing.Size(47, 17)
        Me.lblFechaHoy.TabIndex = 34
        Me.lblFechaHoy.Text = "(fecha)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Reporte de Compras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LIBRERIA SOFIA"
        '
        'lblCostos
        '
        Me.lblCostos.AutoSize = True
        Me.lblCostos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostos.Location = New System.Drawing.Point(372, 277)
        Me.lblCostos.Name = "lblCostos"
        Me.lblCostos.Size = New System.Drawing.Size(61, 21)
        Me.lblCostos.TabIndex = 31
        Me.lblCostos.Text = "(costo)"
        '
        'aaa
        '
        Me.aaa.AutoSize = True
        Me.aaa.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aaa.Location = New System.Drawing.Point(276, 278)
        Me.aaa.Name = "aaa"
        Me.aaa.Size = New System.Drawing.Size(56, 20)
        Me.aaa.TabIndex = 29
        Me.aaa.Text = "Costos:"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(327, 212)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(139, 36)
        Me.btnImprimir.TabIndex = 31
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.ForeColor = System.Drawing.Color.White
        Me.btnCargar.Location = New System.Drawing.Point(572, 116)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(162, 38)
        Me.btnCargar.TabIndex = 34
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha Inicial"
        '
        'cal2
        '
        Me.cal2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cal2.Location = New System.Drawing.Point(150, 145)
        Me.cal2.Name = "cal2"
        Me.cal2.Size = New System.Drawing.Size(352, 29)
        Me.cal2.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Fecha Final"
        '
        'chkRango
        '
        Me.chkRango.AutoSize = True
        Me.chkRango.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRango.Location = New System.Drawing.Point(43, 79)
        Me.chkRango.Name = "chkRango"
        Me.chkRango.Size = New System.Drawing.Size(146, 25)
        Me.chkRango.TabIndex = 39
        Me.chkRango.Text = "Rango de Fechas"
        Me.chkRango.UseVisualStyleBackColor = True
        '
        'cal1
        '
        Me.cal1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cal1.Location = New System.Drawing.Point(150, 110)
        Me.cal1.Name = "cal1"
        Me.cal1.Size = New System.Drawing.Size(352, 29)
        Me.cal1.TabIndex = 35
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ReporteCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.cal1)
        Me.Controls.Add(Me.chkRango)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cal2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteCompras"
        Me.Text = "ReporteCompras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFechaHoy As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents lblFechaHasta As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblVentas As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCostos As Label
    Friend WithEvents aaa As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cal2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents chkRango As CheckBox
    Friend WithEvents cal1 As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
