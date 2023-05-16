
Imports System.IO
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
    Private Sub EnvíoPorCorreoArgentinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvíoPorCorreoArgentinoToolStripMenuItem.Click
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
        Application.EnableVisualStyles()
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Usuario"
        DataGridView1.Columns(1).Name = "Nombre"
        DataGridView1.Columns(2).Name = "Edificio"
        DataGridView1.Columns(3).Name = "Fecha de inicio"

        IDSesion = random.Next(1, 1000)
        Ahora = Now().ToString("yyyy-MM-dd HH:mm:ss")
        SQLValues = "'" & UCase(System.Environment.UserName) & "','" & Ahora & "'," & IDSesion

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into Sesiones values(" & SQLValues & ")"
        myCmd.ExecuteNonQuery()
        myConn.Close()
        Compilation = "Última compilación: " & IO.File.GetLastWriteTime(Application.ExecutablePath).ToShortDateString & " " & IO.File.GetLastWriteTime(Application.ExecutablePath).ToShortTimeString
        ToolStripStatusLabel1.Text = Compilation
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
End Class
