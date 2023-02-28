<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteDiario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnPDF = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.grillaVentas = New System.Windows.Forms.DataGridView()
        Me.RadioCheque = New System.Windows.Forms.RadioButton()
        Me.RadioEfectivo = New System.Windows.Forms.RadioButton()
        Me.RadioDevito = New System.Windows.Forms.RadioButton()
        Me.RadioCredito = New System.Windows.Forms.RadioButton()
        Me.Lblfecha = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 46)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte Diario"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(1028, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 34)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI_MODERNO.My.Resources.Resources.libreriasofia
        Me.PictureBox1.Location = New System.Drawing.Point(12, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label2.Location = New System.Drawing.Point(382, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 32)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Detalle Ventas"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(964, 184)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(139, 36)
        Me.btnImprimir.TabIndex = 40
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnPDF
        '
        Me.BtnPDF.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPDF.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPDF.ForeColor = System.Drawing.Color.White
        Me.BtnPDF.Location = New System.Drawing.Point(793, 184)
        Me.BtnPDF.Name = "BtnPDF"
        Me.BtnPDF.Size = New System.Drawing.Size(139, 36)
        Me.BtnPDF.TabIndex = 43
        Me.BtnPDF.Text = "Generar PDF"
        Me.BtnPDF.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(383, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Filtros de Pago"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(388, 196)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(139, 36)
        Me.BtnBuscar.TabIndex = 49
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaVentas.EnableHeadersVisualStyles = False
        Me.grillaVentas.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaVentas.Location = New System.Drawing.Point(12, 234)
        Me.grillaVentas.MultiSelect = False
        Me.grillaVentas.Name = "grillaVentas"
        Me.grillaVentas.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grillaVentas.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaVentas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grillaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaVentas.Size = New System.Drawing.Size(1075, 330)
        Me.grillaVentas.TabIndex = 42
        '
        'RadioCheque
        '
        Me.RadioCheque.AutoSize = True
        Me.RadioCheque.Location = New System.Drawing.Point(259, 173)
        Me.RadioCheque.Name = "RadioCheque"
        Me.RadioCheque.Size = New System.Drawing.Size(62, 17)
        Me.RadioCheque.TabIndex = 50
        Me.RadioCheque.TabStop = True
        Me.RadioCheque.Text = "Cheque"
        Me.RadioCheque.UseVisualStyleBackColor = True
        '
        'RadioEfectivo
        '
        Me.RadioEfectivo.AutoSize = True
        Me.RadioEfectivo.Location = New System.Drawing.Point(350, 173)
        Me.RadioEfectivo.Name = "RadioEfectivo"
        Me.RadioEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.RadioEfectivo.TabIndex = 51
        Me.RadioEfectivo.TabStop = True
        Me.RadioEfectivo.Text = "Efectivo"
        Me.RadioEfectivo.UseVisualStyleBackColor = True
        '
        'RadioDevito
        '
        Me.RadioDevito.AutoSize = True
        Me.RadioDevito.Location = New System.Drawing.Point(435, 173)
        Me.RadioDevito.Name = "RadioDevito"
        Me.RadioDevito.Size = New System.Drawing.Size(107, 17)
        Me.RadioDevito.TabIndex = 52
        Me.RadioDevito.TabStop = True
        Me.RadioDevito.Text = "Tarjeta de Devito"
        Me.RadioDevito.UseVisualStyleBackColor = True
        '
        'RadioCredito
        '
        Me.RadioCredito.AutoSize = True
        Me.RadioCredito.Location = New System.Drawing.Point(549, 173)
        Me.RadioCredito.Name = "RadioCredito"
        Me.RadioCredito.Size = New System.Drawing.Size(109, 17)
        Me.RadioCredito.TabIndex = 53
        Me.RadioCredito.TabStop = True
        Me.RadioCredito.Text = "Tarjeta de Credito"
        Me.RadioCredito.UseVisualStyleBackColor = True
        '
        'Lblfecha
        '
        Me.Lblfecha.AutoSize = True
        Me.Lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfecha.Location = New System.Drawing.Point(678, 89)
        Me.Lblfecha.Name = "Lblfecha"
        Me.Lblfecha.Size = New System.Drawing.Size(66, 24)
        Me.Lblfecha.TabIndex = 54
        Me.Lblfecha.Text = "Label3"
        '
        'ReporteDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 593)
        Me.Controls.Add(Me.Lblfecha)
        Me.Controls.Add(Me.RadioCredito)
        Me.Controls.Add(Me.RadioDevito)
        Me.Controls.Add(Me.RadioEfectivo)
        Me.Controls.Add(Me.RadioCheque)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnPDF)
        Me.Controls.Add(Me.grillaVentas)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteDiario"
        Me.Text = "ReporteDiario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnPDF As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents grillaVentas As DataGridView
    Friend WithEvents RadioCheque As RadioButton
    Friend WithEvents RadioEfectivo As RadioButton
    Friend WithEvents RadioDevito As RadioButton
    Friend WithEvents RadioCredito As RadioButton
    Friend WithEvents Lblfecha As Label
End Class
