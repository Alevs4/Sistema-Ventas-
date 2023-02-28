Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class ReporteDiario

    Dim y As Integer
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            grillaVentas.Height += y
            Try
                PrintDocument1.Print()
            Catch ex As Exception
                MsgBox("Error al imprimir. Otro proceso está utilizando el archivo especificado. (Sugerencia) Cambie el nombre al archivo a guardar.")
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub ReporteDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lblfecha.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub grillaVentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grillaVentas.CellMouseClick

    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                ExportarDatosPDF(DOCUMENTO)
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView. 
        Dim datatable As New PdfPTable(grillaVentas.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(grillaVentas) ' Aqui se realiza una llamada a la funcion GetColumnasSize y le pasamos como parametro nuestro datagridview
        datatable.SetWidths(headerwidths) 'Pasamos como parametro el array que contiene los ancho de columna, a la propiedad "SetWidths"
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF. 
        Dim encabezado As New Paragraph("LIBRERIA SOFIA", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte Ventas:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))

        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To grillaVentas.ColumnCount - 1
            datatable.AddCell(grillaVentas.Columns(i).HeaderText)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        'Se generan las columnas del DataGridView. 
        For i As Integer = 0 To grillaVentas.RowCount - 1 'Recorre la filas del datagridview
            For j As Integer = 0 To grillaVentas.ColumnCount - 1 'Recorre las columnas del datagridview


                datatable.AddCell(grillaVentas(j, i).Value.ToString())


            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single() 'Se obtiene el ancho de las columnas del Datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {} 'Se declara un array vacio de tipo "Single" cuyo tamaño sera el numero de columnas del datagridview
        For i As Integer = 0 To dg.ColumnCount - 1 'Con un ciclo for recorremos las columnas del datagridview
            values(i) = CSng(dg.Columns(i).Width) 'Se obtiene y se convierte el ancho de la columna a tipo "Single" para cargarlo en el array "values"
        Next
        Return values 'Y por ultimo nos retorna un array, que contiene el ancho de cada columna del datagridview.
    End Function
    Private Sub AltoFila() 'Para configurar el alto de la fila del datagridview
        For Each row As DataGridViewRow In grillaVentas.Rows
            'Se asigna el alto de la fila para poder ver la imagen correctamente
            row.Height = 120
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click


        If RadioCheque.Checked = True Then
            RadioCredito.Checked = False
            RadioDevito.Checked = False
            RadioEfectivo.Checked = False
            Try
                SQL29("CALL SP_CARGAR_DETALLE_DE_VENTA_REALIZADA_CHEQUE")
                If DT29.Rows.Count >= 1 Then
                    grillaVentas.DataSource = ""
                    grillaVentas.DataSource = DS29.Tables(DT29.TableName)
                    conexion.Close()

                Else
                    MsgBox("No se encuentran registros con este Número de Boleta", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        ElseIf RadioCredito.Checked = True Then
            RadioCheque.Checked = False
            RadioDevito.Checked = False
            RadioEfectivo.Checked = False
            Try
                SQL30("CALL SP_CREDITO")
                If DT30.Rows.Count >= 1 Then
                    grillaVentas.DataSource = ""
                    grillaVentas.DataSource = DS30.Tables(DT30.TableName)
                    conexion.Close()

                Else
                    MsgBox("No se encuentran registros", MsgBoxStyle.Information, "Buscar Producto")
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try

        ElseIf RadioDevito.Checked = True Then
            RadioCheque.Checked = False
            RadioCredito.Checked = False
            RadioEfectivo.Checked = False

            Try
                SQL13("CALL SP_DEBITO")
                If DT13.Rows.Count >= 1 Then
                    grillaVentas.DataSource = ""
                    grillaVentas.DataSource = DS13.Tables(DT13.TableName)
                    conexion.Close()

                Else
                    MsgBox("No se encuentran registros", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        ElseIf RadioEfectivo.Checked = True Then
            RadioCheque.Checked = False
            RadioCredito.Checked = False
            RadioDevito.Checked = False

            Try
                SQL13("CALL SP_EFECTIVO")
                If DT13.Rows.Count >= 1 Then
                    grillaVentas.DataSource = ""
                    grillaVentas.DataSource = DS13.Tables(DT13.TableName)
                    conexion.Close()

                Else
                    MsgBox("No se encuentran registros", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
                conexion.Close()
            End Try
        End If


    End Sub

End Class