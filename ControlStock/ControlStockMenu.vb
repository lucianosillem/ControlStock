Imports System.IO
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports DocumentFormat.OpenXml.Office2010.ExcelAc
Imports OfficeOpenXml

Public Class ControlStockMenu
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim IDSesion As Integer
    Dim random As New Random()
    Dim Ahora, SQLValues As String
    Dim FilaSesiones As String()
    Dim Compilation As String
    Public RemitoTabla, RemitoRemitente, RemitoDestinatario, RemitoDireccion, RemitoLocalidad, RemitoProvincia, RemitoCP, RemitoNro As String
    Public CurPage, NroCaja As Integer
    Public UsrRemitente As String
    Private Sub SalidaDeMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeMaterialesToolStripMenuItem.Click
        Dim frmSalidaMateriales As New SalidaMateriales With {.MdiParent = Me}
        frmSalidaMateriales.Show()
    End Sub

    Private Sub VerInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerInventarioToolStripMenuItem.Click
        Dim frmMovimientoEntreEdificios As New MovimientoEntreEdificios With {.MdiParent = Me}
        frmMovimientoEntreEdificios.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim frmAltaMaterial As New AltaMaterial With {.MdiParent = Me}
        frmAltaMaterial.Show()
    End Sub

    Private Sub EntregaDeMaterialAUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaDeMaterialAUsuarioToolStripMenuItem.Click
        Dim frmEntregaMaterial As New EntregaMaterial With {.MdiParent = Me}
        frmEntregaMaterial.Show()
    End Sub

    Private Sub ControlStockMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Usuario"
        DataGridView1.Columns(1).Name = "Nombre"
        DataGridView1.Columns(2).Name = "Edificio"
        DataGridView1.Columns(3).Name = "Fecha de inicio"

        IDSesion = random.Next(1, 1000)
        Ahora = Now().ToString("yyyy-MM-dd HH:mm:ss")
        SQLValues = "'" & UCase(Environment.UserName) & "','" & Ahora & "'," & IDSesion

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into Sesiones values(" & SQLValues & ")"
        myCmd.ExecuteNonQuery()
        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select * from Usuarios where NUsuario = '" & UCase(Environment.UserName) & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader
        myReader.Read()
        UsrRemitente = myReader.GetValue(1)
        myConn.Close()

        Compilation = "Última compilación: " & IO.File.GetLastWriteTime(Application.ExecutablePath).ToShortDateString & " " & IO.File.GetLastWriteTime(Application.ExecutablePath).ToShortTimeString
        ToolStripStatusLabel1.Text = Compilation

        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        With PrintDocument1.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 50
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With

        CurPage = 1

    End Sub

    Private Sub ControlStockMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "delete from Sesiones where IDSesion = " & IDSesion
        myCmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DataGridView1.Rows.Clear()
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Username,DisplayName,Edificio,FechaInicio FROM Sesiones INNER JOIN Relevamiento.dbo.Usuarios ON Sesiones.Username = Usuarios.NUsuario"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            FilaSesiones = {myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3)}
            DataGridView1.Rows.Add(FilaSesiones)
        Loop
        myConn.Close()
    End Sub

    Private Sub IngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoToolStripMenuItem.Click
        Dim frmIngresoMaterial As New IngresoMaterial With {.MdiParent = Me}
        frmIngresoMaterial.Show()
    End Sub

    Private Sub VerÚltimosMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerÚltimosMovimientosToolStripMenuItem.Click
        Dim frmConsultaMovimientos As New ConsultaMovimientos With {.MdiParent = Me}
        frmConsultaMovimientos.Show()
    End Sub

    Private Sub ActualizarNóminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarNóminaToolStripMenuItem.Click
        Dim msgImport, FilasInsertadas As Integer
        msgImport = MsgBox("El libro de Excel a importar debe contener el siguiente formato: " & vbCrLf _
        & "Una sola hoja." & vbCrLf _
        & "Solamente estos campos:" & vbCrLf _
        & "- Usuario SAP" & vbCrLf _
        & "- Legajo" & vbCrLf _
        & "- Apellido y Nombre" & vbCrLf _
        & "- Teletrabajable" & vbCrLf _
        & "- Pais" & vbCrLf _
        & "- Sociedad" & vbCrLf _
        & "- Dirección" & vbCrLf _
        & "- Jefatura" & vbCrLf _
        & "- Descripcion de Función" & vbCrLf _
        & "- Descripcion de Posición" & vbCrLf _
        & "- Descripcion Edificio" & vbCrLf _
        & "- Centro de Costos" & vbCrLf _
        & "- Apellido y Nombre Superior" & vbCrLf _
        & "- Email" & vbCrLf _
        & "" & vbCrLf _
        & "¿Desea continuar?", vbYesNo + vbInformation, "Control de Stock Microinformática")

        If msgImport = vbYes Then
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = OpenFileDialog1.FileName
                FilasInsertadas = 0
                Using package As New ExcelPackage(New FileInfo(filePath))
                    Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(1)
                    Dim range As ExcelRange = worksheet.Dimension
                    Dim connectionString As String = "Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True"
                    Dim connection As New SqlConnection(connectionString)
                    connection.Open()

                    For row As Integer = 2 To range.Rows
                        Dim UsuarioSAP As String = worksheet.Cells(row, 1).Value.ToString()
                        Dim Legajo As String = worksheet.Cells(row, 2).Value.ToString()
                        Dim ApellidoNombre As String = worksheet.Cells(row, 3).Value.ToString()
                        Dim Teletrabajable As String = worksheet.Cells(row, 4).Value.ToString()
                        Dim Pais As String = worksheet.Cells(row, 5).Value.ToString()
                        Dim Sociedad As String = worksheet.Cells(row, 6).Value.ToString()
                        Dim Direccion As String = worksheet.Cells(row, 7).Value.ToString()
                        Dim Jefatura As String = worksheet.Cells(row, 8).Value.ToString()
                        Dim DescripcionFuncion As String = worksheet.Cells(row, 9).Value.ToString()
                        Dim DescripcionPosicion As String = worksheet.Cells(row, 10).Value.ToString()
                        Dim DescripcionEdificio As String = worksheet.Cells(row, 11).Value.ToString()
                        Dim CentrodeCostos As String = worksheet.Cells(row, 12).Value.ToString()
                        Dim ApellidoNombreSuperior As String = worksheet.Cells(row, 13).Value.ToString()
                        Dim Email As String = worksheet.Cells(row, 14).Value.ToString()

                        Dim ConsultaUsuarioSAP As String = "SELECT COUNT(*) FROM Nomina WHERE UsuarioSAP = @UsuarioSAP"
                        Dim command As New SqlCommand(ConsultaUsuarioSAP, connection)

                        Dim count As Integer = CInt(command.ExecuteScalar())

                        If count = 0 Then
                            ' Agregar la fila a la base de datos si no existe
                            Dim query As String = "INSERT INTO Nomina (UsuarioSAP, Legajo, ApellidoNombre, Teletrabajable, Pais, Sociedad, Direccion, Jefatura, DescripcionFuncion, DescripcionPosicion, DescripcionEdificio, CentrodeCostos, ApellidoNombreSuperior, Email) VALUES (@UsuarioSAP, @Legajo, @ApellidoNombre, @Teletrabajable, @Pais, @Sociedad, @Direccion, @Jefatura, @DescripcionFuncion, @DescripcionPosicion, @DescripcionEdificio, @CentrodeCostos, @ApellidoNombreSuperior, @Email)"
                            Try
                                command = New SqlCommand(query, connection)
                                command.Parameters.AddWithValue("@UsuarioSAP", UsuarioSAP)
                                command.Parameters.AddWithValue("@Legajo", Legajo)
                                command.Parameters.AddWithValue("@ApellidoNombre", ApellidoNombre)
                                command.Parameters.AddWithValue("@Teletrabajable", Teletrabajable)
                                command.Parameters.AddWithValue("@Pais", Pais)
                                command.Parameters.AddWithValue("@Sociedad", Sociedad)
                                command.Parameters.AddWithValue("@Direccion", Direccion)
                                command.Parameters.AddWithValue("@Jefatura", Jefatura)
                                command.Parameters.AddWithValue("@DescripcionFuncion", DescripcionFuncion)
                                command.Parameters.AddWithValue("@DescripcionPosicion", DescripcionPosicion)
                                command.Parameters.AddWithValue("@DescripcionEdificio", DescripcionEdificio)
                                command.Parameters.AddWithValue("@CentrodeCostos", CentrodeCostos)
                                command.Parameters.AddWithValue("@ApellidoNombreSuperior", ApellidoNombreSuperior)
                                command.Parameters.AddWithValue("@Email", Email)
                                command.ExecuteNonQuery()
                                FilasInsertadas += 1
                            Catch ex As Exception
                                MsgBox(ex.Message, vbExclamation)
                            End Try
                        End If
                    Next
                End Using
            End If
            MsgBox("Se insertaron " & FilasInsertadas & " filas.", vbInformation, "Control de Stock Microinformática")
        End If
    End Sub

    Private Sub VerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem1.Click
        Dim frmVerNomina As New ConsultaNomina With {.MdiParent = Me}
        frmVerNomina.Show()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Dim frmConsultaMateriales As New ConsultaMateriales With {.MdiParent = Me}
        frmConsultaMateriales.Show()
    End Sub

    Private Sub DestinoCACsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinoCACsToolStripMenuItem.Click
        RemitoTabla = "CACs"
        ImprimirEtiqueta.ComboBox1.Enabled = True
        ImprimirEtiqueta.ShowDialog()

        If RemitoDestinatario <> "" And RemitoDireccion <> "" And RemitoLocalidad <> "" And RemitoProvincia <> "" And RemitoCP <> "" Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
    Private Sub DestinoEdificioCorporativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinoEdificioCorporativoToolStripMenuItem.Click
        RemitoTabla = "Edificios"
        ImprimirEtiqueta.ComboBox1.Enabled = True
        ImprimirEtiqueta.ShowDialog()

        If RemitoDestinatario <> "" And RemitoDireccion <> "" And RemitoLocalidad <> "" And RemitoProvincia <> "" And RemitoCP <> "" Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub DestinoDomicilioParticularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinoDomicilioParticularToolStripMenuItem.Click
        RemitoTabla = ""
        ImprimirEtiqueta.ComboBox1.Enabled = False
        ImprimirEtiqueta.ShowDialog()

        If RemitoDestinatario <> "" And RemitoDireccion <> "" And RemitoLocalidad <> "" And RemitoProvincia <> "" And RemitoCP <> "" Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        CurPage = 1
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
#Disable Warning CA1416 ' Validate platform compatibility
        Dim FontFace As String = "Gotham Light"
        Dim fntLabel As New Font(FontFace, 36, FontStyle.Bold)
        Dim fntText As New Font(FontFace, 36, FontStyle.Regular)
        Dim fntDireccion As New Font(FontFace, 36, FontStyle.Regular)
        Dim fntCaja As New Font(FontFace, 24, FontStyle.Bold)
        Dim fntRemito As New Font(FontFace, 12, FontStyle.Bold)
        Dim fntRemitoNro As New Font(FontFace, 12, FontStyle.Regular)
        Dim LineSpace As Integer = 140
        Dim LeftMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim RightMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Right
        Dim TopMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim PageWidth As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width - LeftMargin - RightMargin
        Dim Format As New StringFormat With {
            .Alignment = StringAlignment.Center
        }
        Dim StringSize1 As SizeF = e.Graphics.MeasureString(RemitoDestinatario, fntText)
        Dim StringSize2 As SizeF '= e.Graphics.MeasureString(RemitoDireccion, fntText)
        Dim StringSize3 As SizeF = e.Graphics.MeasureString(RemitoLocalidad, fntText)
        Dim StringSize4 As SizeF = e.Graphics.MeasureString(RemitoProvincia, fntText)
        Dim StringSize5 As SizeF = e.Graphics.MeasureString(RemitoCP, fntText)
        Dim RemitoRect As New Rectangle()
        Dim Hoy As Date = Today.ToShortDateString

        For i = 36 To 20 Step -1
            fntDireccion = New Font(FontFace, i, FontStyle.Regular)
            StringSize2 = e.Graphics.MeasureString(RemitoDireccion, fntDireccion)
            If StringSize2.Width < 1100 Then
                Exit For
            End If
        Next

        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)

        e.Graphics.DrawString("Destinatario:", fntLabel, Brushes.Black, 585, TopMargin, Format)
        e.Graphics.DrawString(RemitoDestinatario, fntText, Brushes.Black, 585, TopMargin + StringSize1.Height - 5, Format)

        e.Graphics.DrawString("Dirección:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace, Format)
        e.Graphics.DrawString(RemitoDireccion, fntDireccion, Brushes.Black, 585, TopMargin + LineSpace + StringSize1.Height - 5, Format)

        e.Graphics.DrawString("Localidad:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace * 2, Format)
        e.Graphics.DrawString(RemitoLocalidad, fntText, Brushes.Black, 585, TopMargin + LineSpace * 2 + StringSize3.Height - 5, Format)

        e.Graphics.DrawString("Provincia:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace * 3, Format)
        e.Graphics.DrawString(RemitoProvincia, fntText, Brushes.Black, 585, TopMargin + LineSpace * 3 + StringSize4.Height - 5, Format)

        e.Graphics.DrawString("CP:", fntLabel, Brushes.Black, 585, TopMargin + LineSpace * 4, Format)
        e.Graphics.DrawString(RemitoCP, fntText, Brushes.Black, 585, TopMargin + LineSpace * 4 + StringSize5.Height - 5, Format)

        RemitoRect.X = 752
        RemitoRect.Y = 720
        RemitoRect.Width = 365
        RemitoRect.Height = 40
        e.Graphics.DrawRectangle(Pens.Black, RemitoRect)
        e.Graphics.DrawLine(Pens.Black, 900, 720, 900, 760)

        e.Graphics.DrawString("Remitente", fntRemito, Brushes.Black, 808, 720)
        e.Graphics.DrawString(RemitoRemitente, fntRemitoNro, Brushes.Black, 900, 720)

        e.Graphics.DrawString("Fecha", fntRemito, Brushes.Black, 843, 740)
        e.Graphics.DrawString(Hoy, fntRemitoNro, Brushes.Black, 900, 740)

        e.Graphics.DrawString("Caja " & CurPage & "/" & NroCaja, fntLabel, Brushes.Black, 60, 720)

        If NroCaja > 1 Then
            CurPage += 1
            e.HasMorePages = CurPage <= NroCaja
        End If
#Enable Warning CA1416 ' Validate platform compatibility
    End Sub
End Class