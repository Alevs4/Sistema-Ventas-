Public Class Compras

    Dim vAnularCompra As String ' Variable global para anular compra


    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Cargamos las compras realizadas mediante la siguiente consulta en el evento Load del formulario
        radioNumFactura.Checked = True ' Inicializamos el formulario con radioNumFactura marcado
        Try
            SQL38("CALL SP_LISTAR_COMPRAS()") ' Se realiza la consulta SQL, sin parametros de entrada
            If DT38.Rows.Count >= 1 Then ' Si la consulta devolvio resultados, se presentaran en la grilla Compras
                grillaCompras.DataSource = DS38.Tables(DT38.TableName) ' Se carga la grilla
                conexion.Close() ' Se cierra la conexion por seguridad
            End If
        Catch ex As Exception ' En caso de haber un error se muestra en base de datos
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub grillaCompras_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles grillaCompras.DataBindingComplete

        ' Con las siguientes lineas de codigo evitamos el ordenamiento por columnas de la grilla
        grillaCompras.ClearSelection()
        Dim i As Integer
        For i = 0 To grillaCompras.Columns.Count - 1
            grillaCompras.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub btnCerrarCompras_Click(sender As Object, e As EventArgs) Handles btnCerrarCompras.Click
        ' Cerramos formulario y regresamos el boton "Compras" a su color normal
        Me.Close()
        Form_Principal.btnCompras.BackColor = Color.DarkSlateGray
    End Sub


    Private Sub txtBuscar_Enter(sender As Object, e As EventArgs) Handles txtBuscar.Enter

        ' Al entrar la caja de texto, si la palabra escrita es "Buscar", esta se borrará y el texto a escribir sera de color negro
        If txtBuscar.Text = "Buscar" Then
            txtBuscar.Text = ""
            txtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub grillaCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaCompras.CellContentClick
        ' Traspasamos el item 0 de la fila que seleccionemos para efectos de anulación de compra
        ' este item contiene el código de la compra para luego realizar la consulta SQL y proceder a borrar
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = CType(sender, DataGridView).CurrentRow
        vAnularCompra = grillaCompras.Item(0, e.RowIndex).Value
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ' Formularios secundario que se abre como cuadro de dialogo
        IngresarCompra.ShowDialog()
    End Sub

    Private Sub grillaCompras_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles grillaCompras.ColumnAdded
        'Alineacion del contenido de la grilla al centro
        e.Column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub grillaCompras_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grillaCompras.CellMouseClick
        ' Al pinchar en alguna fila del listado de compras, se mostrara el detalle de productos en la grilla derecha
        Try
            Dim codigo As Integer ' Se declara variable entera
            codigo = grillaCompras.CurrentRow.Cells(0).Value ' La variable toma el valor de la celda 0 en la fila marcada
            ' Se realiza la consulta SQL con parametro de entrada "codigo"
            SQL39("CALL SP_CARGAR_DETALLE_DE_COMPRA_REALIZADA('" & (codigo) & "')")
            If DT39.Rows.Count >= 1 Then ' Si se encuentran resultados se procede a ejecutar el codigo
                grillaDetalle.DataSource = DS39.Tables(DT39.TableName) ' Se llena la grilla con los datos de la tabla
            End If
        Catch ex As Exception ' En caso de algun error se mostrara un mensaje
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text = "Buscar" Or txtBuscar.Text = "" Then
            MsgBox("Escriba lo que desee buscar")
        Else
            If radioNumFactura.Checked = True Then
                radioFecha.Checked = False
                radioProveedor.Checked = False
                txtBuscar.Visible = True
                calendario1.Visible = False
                Try
                    SQL40("CALL SP_BUSCAR_COMPRA_POR_NUM_FACTURA('" & (txtBuscar.Text) & "')")
                    If DT40.Rows.Count >= 1 Then
                        grillaCompras.DataSource = ""
                        grillaCompras.DataSource = DS40.Tables(DT40.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros con este Número de Factura", MsgBoxStyle.Information, "Buscar Compras")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            ElseIf radioFecha.Checked = True Then
                txtBuscar.Text = Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd")
                radioNumFactura.Checked = False
                radioProveedor.Checked = False
                txtBuscar.Visible = True
                calendario1.Visible = True
                Try
                    SQL41("CALL SP_BUSCAR_COMPRA_POR_FECHA('" & (txtBuscar.Text) & "')")
                    If DT41.Rows.Count >= 1 Then
                        grillaCompras.DataSource = ""
                        grillaCompras.DataSource = DS41.Tables(DT41.TableName)
                        conexion.Close()
                        btnCargarNuevamente.Visible = True
                    Else
                        MsgBox("No se encuentran registros el día seleccionado", MsgBoxStyle.Information, "Buscar Compras")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                    conexion.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        ' Mediante el evento textchanged del control texbox de busqueda, si el radiobutton "Prooveedores" está 
        ' marcado, se ejecutara una busqueda en la base de datos a medida que el usuario vaya escribiendo lo que 
        ' necesita

        If radioProveedor.Checked = True Then
            radioNumFactura.Checked = False
            radioFecha.Checked = False
            txtBuscar.Visible = True
            calendario1.Visible = False

            Try
                SQL42("CALL SP_BUSCAR_COMPRA_POR_PROVEEDOR('" & (txtBuscar.Text) & "')")
                If DT42.Rows.Count >= 1 Then
                    grillaCompras.DataSource = ""
                    grillaCompras.DataSource = DS42.Tables(DT42.TableName)
                    conexion.Close()
                    btnCargarNuevamente.Visible = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub radioNumFactura_CheckedChanged(sender As Object, e As EventArgs) Handles radioNumFactura.CheckedChanged

        ' Si radioNumFactura esta checkado, los demas radiobuttons se desmarcaran

        If radioNumFactura.Checked = True Then
            radioFecha.Checked = False
            radioProveedor.Checked = False
            txtBuscar.Visible = True
            calendario1.Visible = False
            If radioFecha.Checked = True Then
                txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
            Else
                txtBuscar.ForeColor = Color.DarkGray
                txtBuscar.Text = "Buscar"
            End If
        End If
    End Sub

    Private Sub radioFecha_CheckedChanged(sender As Object, e As EventArgs) Handles radioFecha.CheckedChanged

        ' Si el radiobutton radioFecha está marcado, se desmarcaran los demas, se ocultará el textbox y se mostrará un calendario
        If radioFecha.Checked = True Then
            radioNumFactura.Checked = False
            radioProveedor.Checked = False
            txtBuscar.Visible = False
            calendario1.Visible = True
            txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
        End If
    End Sub

    Private Sub radioProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles radioProveedor.CheckedChanged

        ' Si el radiobutton proveedor está marcado, los demas se desmarcaran

        If radioProveedor.Checked = True Then
            radioNumFactura.Checked = False
            radioFecha.Checked = False
            txtBuscar.Visible = True
            calendario1.Visible = False
            If radioFecha.Checked = True Then
                txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
            Else
                txtBuscar.ForeColor = Color.DarkGray
                txtBuscar.Text = "Buscar"
            End If
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress

        ' Evento keypress se inicia si es que el radiobutton radioNumFactura esta activo, para admitir solo numeros
        If radioNumFactura.Checked = True Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCargarNuevamente_Click(sender As Object, e As EventArgs) Handles btnCargarNuevamente.Click

        ' Boton que se habilita cuando se realiza alguna busqueda, y que permita cargar la grilla de compras otra vez

        Try
            SQL16("CALL SP_LISTAR_COMPRAS")
            If DT16.Rows.Count >= 1 Then
                grillaCompras.DataSource = DS16.Tables(DT16.TableName)
                conexion.Close()
                btnCargarNuevamente.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
            conexion.Close()
        End Try
    End Sub

    Private Sub calendario1_ValueChanged(sender As Object, e As EventArgs) Handles calendario1.ValueChanged
        ' Cuando se cambia el valor del calendario se pasa el texto del calendario al textbox de busqueda,
        ' en formato YYYY-MM-DD
        txtBuscar.Text = (Convert.ToDateTime(calendario1.Text).ToString("yyyy-MM-dd"))
    End Sub

    Private Sub btnAnularCompra_Click(sender As Object, e As EventArgs) Handles btnAnularCompra.Click

        ' Boton que permite la anulacion de una compra
        If MessageBox.Show("Con esta acción anulará la compra seleccionada" & (vbNewLine) & "¿Desea continuar?", "Anular Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                SQL56("CALL SP_ANULAR_COMPRA('" & (vAnularCompra) & "')")
                MsgBox("Compra Anulada exitosamente")

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        End If
    End Sub
End Class