<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCategoria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAgregarCategoria = New System.Windows.Forms.TextBox()
        Me.btnAceptarCategoria = New System.Windows.Forms.Button()
        Me.lblInformacionCategoria = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(533, 55)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(448, 11)
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
        Me.lblAgregarCategoria.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarCategoria.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAgregarCategoria.Location = New System.Drawing.Point(12, 10)
        Me.lblAgregarCategoria.Name = "lblAgregarCategoria"
        Me.lblAgregarCategoria.Size = New System.Drawing.Size(252, 40)
        Me.lblAgregarCategoria.TabIndex = 13
        Me.lblAgregarCategoria.Text = "Agregar Categoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(195, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Escriba Categoría"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAgregarCategoria
        '
        Me.txtAgregarCategoria.BackColor = System.Drawing.Color.White
        Me.txtAgregarCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgregarCategoria.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgregarCategoria.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtAgregarCategoria.Location = New System.Drawing.Point(119, 104)
        Me.txtAgregarCategoria.Name = "txtAgregarCategoria"
        Me.txtAgregarCategoria.Size = New System.Drawing.Size(304, 27)
        Me.txtAgregarCategoria.TabIndex = 17
        Me.txtAgregarCategoria.TabStop = False
        '
        'btnAceptarCategoria
        '
        Me.btnAceptarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptarCategoria.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAceptarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptarCategoria.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarCategoria.ForeColor = System.Drawing.Color.White
        Me.btnAceptarCategoria.Location = New System.Drawing.Point(198, 166)
        Me.btnAceptarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarCategoria.Name = "btnAceptarCategoria"
        Me.btnAceptarCategoria.Size = New System.Drawing.Size(148, 34)
        Me.btnAceptarCategoria.TabIndex = 15
        Me.btnAceptarCategoria.TabStop = False
        Me.btnAceptarCategoria.Text = "Aceptar"
        Me.btnAceptarCategoria.UseVisualStyleBackColor = False
        '
        'lblInformacionCategoria
        '
        Me.lblInformacionCategoria.AutoSize = True
        Me.lblInformacionCategoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacionCategoria.ForeColor = System.Drawing.Color.White
        Me.lblInformacionCategoria.Location = New System.Drawing.Point(105, 212)
        Me.lblInformacionCategoria.Name = "lblInformacionCategoria"
        Me.lblInformacionCategoria.Size = New System.Drawing.Size(337, 42)
        Me.lblInformacionCategoria.TabIndex = 16
        Me.lblInformacionCategoria.Text = "Si necesita eliminar o editar una categoría, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "porfavor dirigirse a la sección de" &
    " configuración." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInformacionCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstado.Location = New System.Drawing.Point(115, 134)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(56, 21)
        Me.lblEstado.TabIndex = 19
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstado.Visible = False
        '
        'AgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(533, 266)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAgregarCategoria)
        Me.Controls.Add(Me.btnAceptarCategoria)
        Me.Controls.Add(Me.lblInformacionCategoria)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarCategoria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblAgregarCategoria As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAgregarCategoria As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarCategoria As System.Windows.Forms.Button
    Friend WithEvents lblInformacionCategoria As System.Windows.Forms.Label
    Friend WithEvents lblEstado As Label
End Class
