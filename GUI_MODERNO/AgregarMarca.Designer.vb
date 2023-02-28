<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMarca
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
        Me.lblAgregarMarca = New System.Windows.Forms.Label()
        Me.lblInformacionMarca = New System.Windows.Forms.Label()
        Me.btnAceptarMarca = New System.Windows.Forms.Button()
        Me.txtAgregarMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblAgregarMarca)
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
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblAgregarMarca
        '
        Me.lblAgregarMarca.AutoSize = True
        Me.lblAgregarMarca.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarMarca.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblAgregarMarca.Location = New System.Drawing.Point(12, 11)
        Me.lblAgregarMarca.Name = "lblAgregarMarca"
        Me.lblAgregarMarca.Size = New System.Drawing.Size(207, 40)
        Me.lblAgregarMarca.TabIndex = 8
        Me.lblAgregarMarca.Text = "Agregar Marca"
        '
        'lblInformacionMarca
        '
        Me.lblInformacionMarca.AutoSize = True
        Me.lblInformacionMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacionMarca.ForeColor = System.Drawing.Color.White
        Me.lblInformacionMarca.Location = New System.Drawing.Point(106, 211)
        Me.lblInformacionMarca.Name = "lblInformacionMarca"
        Me.lblInformacionMarca.Size = New System.Drawing.Size(337, 42)
        Me.lblInformacionMarca.TabIndex = 10
        Me.lblInformacionMarca.Text = "Si necesita eliminar o editar una marca, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "porfavor dirigirse a la sección de con" &
    "figuración." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInformacionMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptarMarca
        '
        Me.btnAceptarMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptarMarca.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAceptarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptarMarca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarMarca.ForeColor = System.Drawing.Color.White
        Me.btnAceptarMarca.Location = New System.Drawing.Point(199, 165)
        Me.btnAceptarMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarMarca.Name = "btnAceptarMarca"
        Me.btnAceptarMarca.Size = New System.Drawing.Size(148, 34)
        Me.btnAceptarMarca.TabIndex = 10
        Me.btnAceptarMarca.TabStop = False
        Me.btnAceptarMarca.Text = "Aceptar"
        Me.btnAceptarMarca.UseVisualStyleBackColor = False
        '
        'txtAgregarMarca
        '
        Me.txtAgregarMarca.BackColor = System.Drawing.Color.White
        Me.txtAgregarMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgregarMarca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgregarMarca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtAgregarMarca.Location = New System.Drawing.Point(120, 105)
        Me.txtAgregarMarca.Name = "txtAgregarMarca"
        Me.txtAgregarMarca.Size = New System.Drawing.Size(304, 27)
        Me.txtAgregarMarca.TabIndex = 11
        Me.txtAgregarMarca.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(210, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Escriba Marca"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Yellow
        Me.lblEstado.Location = New System.Drawing.Point(116, 135)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(56, 21)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstado.Visible = False
        '
        'AgregarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(533, 266)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAgregarMarca)
        Me.Controls.Add(Me.btnAceptarMarca)
        Me.Controls.Add(Me.lblInformacionMarca)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarMarca"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblAgregarMarca As System.Windows.Forms.Label
    Friend WithEvents lblInformacionMarca As System.Windows.Forms.Label
    Friend WithEvents btnAceptarMarca As System.Windows.Forms.Button
    Friend WithEvents txtAgregarMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As Label
End Class
