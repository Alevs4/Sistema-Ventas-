<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grillaProducto = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCargarNuevamente = New System.Windows.Forms.Button()
        Me.panelProdMarCat = New System.Windows.Forms.Panel()
        Me.btnPanelCategoria = New System.Windows.Forms.Button()
        Me.btnPanelMarca = New System.Windows.Forms.Button()
        Me.btnPanelProducto = New System.Windows.Forms.Button()
        Me.radioCodBarras = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radioCodProd = New System.Windows.Forms.RadioButton()
        Me.radioNombre = New System.Windows.Forms.RadioButton()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnEliminarSeleccionado = New System.Windows.Forms.Button()
        Me.btnEditarSeleccionado = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCerrarProductos = New System.Windows.Forms.Button()
        CType(Me.grillaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelProdMarCat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Productos"
        '
        'grillaProducto
        '
        Me.grillaProducto.AllowUserToAddRows = False
        Me.grillaProducto.AllowUserToDeleteRows = False
        Me.grillaProducto.AllowUserToResizeColumns = False
        Me.grillaProducto.AllowUserToResizeRows = False
        Me.grillaProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grillaProducto.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grillaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grillaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grillaProducto.EnableHeadersVisualStyles = False
        Me.grillaProducto.GridColor = System.Drawing.Color.SteelBlue
        Me.grillaProducto.Location = New System.Drawing.Point(14, 116)
        Me.grillaProducto.MultiSelect = False
        Me.grillaProducto.Name = "grillaProducto"
        Me.grillaProducto.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grillaProducto.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.grillaProducto.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grillaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaProducto.Size = New System.Drawing.Size(999, 391)
        Me.grillaProducto.TabIndex = 0
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBuscar.Location = New System.Drawing.Point(667, 69)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(282, 33)
        Me.txtBuscar.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCargarNuevamente)
        Me.Panel1.Controls.Add(Me.panelProdMarCat)
        Me.Panel1.Controls.Add(Me.radioCodBarras)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.radioCodProd)
        Me.Panel1.Controls.Add(Me.radioNombre)
        Me.Panel1.Controls.Add(Me.txtProducto)
        Me.Panel1.Controls.Add(Me.btnEliminarSeleccionado)
        Me.Panel1.Controls.Add(Me.btnEditarSeleccionado)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.grillaProducto)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 564)
        Me.Panel1.TabIndex = 5
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
        Me.btnCargarNuevamente.Location = New System.Drawing.Point(14, 513)
        Me.btnCargarNuevamente.Name = "btnCargarNuevamente"
        Me.btnCargarNuevamente.Size = New System.Drawing.Size(375, 48)
        Me.btnCargarNuevamente.TabIndex = 14
        Me.btnCargarNuevamente.Text = "Presione aquí para volver a cargar tabla completa"
        Me.btnCargarNuevamente.UseVisualStyleBackColor = False
        Me.btnCargarNuevamente.Visible = False
        '
        'panelProdMarCat
        '
        Me.panelProdMarCat.Controls.Add(Me.btnPanelCategoria)
        Me.panelProdMarCat.Controls.Add(Me.btnPanelMarca)
        Me.panelProdMarCat.Controls.Add(Me.btnPanelProducto)
        Me.panelProdMarCat.Location = New System.Drawing.Point(107, 15)
        Me.panelProdMarCat.Name = "panelProdMarCat"
        Me.panelProdMarCat.Size = New System.Drawing.Size(142, 124)
        Me.panelProdMarCat.TabIndex = 13
        Me.panelProdMarCat.Visible = False
        '
        'btnPanelCategoria
        '
        Me.btnPanelCategoria.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPanelCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnPanelCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanelCategoria.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanelCategoria.ForeColor = System.Drawing.Color.White
        Me.btnPanelCategoria.Location = New System.Drawing.Point(8, 84)
        Me.btnPanelCategoria.Name = "btnPanelCategoria"
        Me.btnPanelCategoria.Size = New System.Drawing.Size(126, 32)
        Me.btnPanelCategoria.TabIndex = 7
        Me.btnPanelCategoria.Text = "Categoría"
        Me.btnPanelCategoria.UseVisualStyleBackColor = False
        '
        'btnPanelMarca
        '
        Me.btnPanelMarca.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPanelMarca.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnPanelMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanelMarca.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanelMarca.ForeColor = System.Drawing.Color.White
        Me.btnPanelMarca.Location = New System.Drawing.Point(8, 46)
        Me.btnPanelMarca.Name = "btnPanelMarca"
        Me.btnPanelMarca.Size = New System.Drawing.Size(126, 32)
        Me.btnPanelMarca.TabIndex = 6
        Me.btnPanelMarca.Text = "Marca"
        Me.btnPanelMarca.UseVisualStyleBackColor = False
        '
        'btnPanelProducto
        '
        Me.btnPanelProducto.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPanelProducto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnPanelProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanelProducto.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanelProducto.ForeColor = System.Drawing.Color.White
        Me.btnPanelProducto.Location = New System.Drawing.Point(8, 8)
        Me.btnPanelProducto.Name = "btnPanelProducto"
        Me.btnPanelProducto.Size = New System.Drawing.Size(126, 32)
        Me.btnPanelProducto.TabIndex = 5
        Me.btnPanelProducto.Text = "Producto"
        Me.btnPanelProducto.UseVisualStyleBackColor = False
        '
        'radioCodBarras
        '
        Me.radioCodBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioCodBarras.AutoSize = True
        Me.radioCodBarras.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioCodBarras.Location = New System.Drawing.Point(802, 42)
        Me.radioCodBarras.Name = "radioCodBarras"
        Me.radioCodBarras.Size = New System.Drawing.Size(113, 21)
        Me.radioCodBarras.TabIndex = 12
        Me.radioCodBarras.Text = "Cod. de Barras"
        Me.radioCodBarras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(663, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Buscar producto por:"
        '
        'radioCodProd
        '
        Me.radioCodProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioCodProd.AutoSize = True
        Me.radioCodProd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioCodProd.Location = New System.Drawing.Point(667, 42)
        Me.radioCodProd.Name = "radioCodProd"
        Me.radioCodProd.Size = New System.Drawing.Size(129, 21)
        Me.radioCodProd.TabIndex = 10
        Me.radioCodProd.Text = "Cod. de Producto"
        Me.radioCodProd.UseVisualStyleBackColor = True
        '
        'radioNombre
        '
        Me.radioNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radioNombre.AutoSize = True
        Me.radioNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNombre.Location = New System.Drawing.Point(917, 42)
        Me.radioNombre.Name = "radioNombre"
        Me.radioNombre.Size = New System.Drawing.Size(79, 21)
        Me.radioNombre.TabIndex = 9
        Me.radioNombre.Text = "Producto"
        Me.radioNombre.UseVisualStyleBackColor = True
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(14, 73)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(332, 29)
        Me.txtProducto.TabIndex = 8
        '
        'btnEliminarSeleccionado
        '
        Me.btnEliminarSeleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarSeleccionado.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminarSeleccionado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnEliminarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarSeleccionado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarSeleccionado.ForeColor = System.Drawing.Color.White
        Me.btnEliminarSeleccionado.Image = Global.GUI_MODERNO.My.Resources.Resources.boton_eliminar__1_
        Me.btnEliminarSeleccionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarSeleccionado.Location = New System.Drawing.Point(816, 511)
        Me.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado"
        Me.btnEliminarSeleccionado.Size = New System.Drawing.Size(197, 48)
        Me.btnEliminarSeleccionado.TabIndex = 6
        Me.btnEliminarSeleccionado.Text = "Eliminar Seleccionado"
        Me.btnEliminarSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminarSeleccionado.UseVisualStyleBackColor = False
        '
        'btnEditarSeleccionado
        '
        Me.btnEditarSeleccionado.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEditarSeleccionado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnEditarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarSeleccionado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarSeleccionado.ForeColor = System.Drawing.Color.White
        Me.btnEditarSeleccionado.Image = Global.GUI_MODERNO.My.Resources.Resources.editar__1_
        Me.btnEditarSeleccionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarSeleccionado.Location = New System.Drawing.Point(352, 62)
        Me.btnEditarSeleccionado.Name = "btnEditarSeleccionado"
        Me.btnEditarSeleccionado.Size = New System.Drawing.Size(178, 48)
        Me.btnEditarSeleccionado.TabIndex = 5
        Me.btnEditarSeleccionado.Text = "Editar Seleccionado"
        Me.btnEditarSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditarSeleccionado.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.GUI_MODERNO.My.Resources.Resources.anadir__1_
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(14, 15)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 48)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Agregar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.GUI_MODERNO.My.Resources.Resources.lupa_herramienta
        Me.btnBuscar.Location = New System.Drawing.Point(949, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(64, 33)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCerrarProductos
        '
        Me.btnCerrarProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarProductos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText
        Me.btnCerrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarProductos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarProductos.ForeColor = System.Drawing.Color.White
        Me.btnCerrarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarProductos.Location = New System.Drawing.Point(886, 12)
        Me.btnCerrarProductos.Name = "btnCerrarProductos"
        Me.btnCerrarProductos.Size = New System.Drawing.Size(152, 44)
        Me.btnCerrarProductos.TabIndex = 9
        Me.btnCerrarProductos.Text = "Cerrar ventana Productos"
        Me.btnCerrarProductos.UseVisualStyleBackColor = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1050, 638)
        Me.Controls.Add(Me.btnCerrarProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Formulario 1"
        CType(Me.grillaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelProdMarCat.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grillaProducto As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditarSeleccionado As System.Windows.Forms.Button
    Friend WithEvents btnEliminarSeleccionado As System.Windows.Forms.Button
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrarProductos As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radioCodProd As System.Windows.Forms.RadioButton
    Friend WithEvents radioNombre As System.Windows.Forms.RadioButton
    Friend WithEvents radioCodBarras As System.Windows.Forms.RadioButton
    Friend WithEvents panelProdMarCat As System.Windows.Forms.Panel
    Friend WithEvents btnPanelCategoria As System.Windows.Forms.Button
    Friend WithEvents btnPanelMarca As System.Windows.Forms.Button
    Friend WithEvents btnPanelProducto As System.Windows.Forms.Button
    Friend WithEvents btnCargarNuevamente As System.Windows.Forms.Button
End Class
