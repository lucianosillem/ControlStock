Imports DocumentFormat.OpenXml.Packaging

Public Class SalidaMateriales
    Private myConn, TmpConn As SqlConnection
    Private myCmd, TmpCmd As SqlCommand
    Private myReader, TmpReader As SqlDataReader
    Dim results, UsrRemitente, Remitente, NrosDeSerie, EdifOrigen, ColumnaOrigen, CodSAP, Faja, Oblea As String
    Dim Cantidad, CantCajas, Seriado, i As Integer
    Dim ValorDeclarado, Dolar, ARS As Decimal
    Dim Hoy As Date
    Dim dataObj As New DataObject
    Public ModeloAnterior, SerieAnterior, Legajo, ApellidoNombre As String

    Private Sub SalidaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 17
        DataGridView1.Columns(0).Name = "Remitente"
        DataGridView1.Columns(1).Name = "Fecha"
        DataGridView1.Columns(2).Name = "Código SAP"
        DataGridView1.Columns(3).Name = "Descripción del material"
        DataGridView1.Columns(4).Name = "Marca y modelo"
        DataGridView1.Columns(5).Name = "Número de serie"
        DataGridView1.Columns(6).Name = "Cantidad"
        DataGridView1.Columns(7).Name = "Ticket"
        DataGridView1.Columns(8).Name = "Legajo"
        DataGridView1.Columns(9).Name = "Apellido y Nombre"
        DataGridView1.Columns(10).Name = "Destino"
        DataGridView1.Columns(11).Name = "Dirección"
        DataGridView1.Columns(12).Name = "Centro de Costos"
        DataGridView1.Columns(13).Name = "Cantidad de cajas"
        DataGridView1.Columns(14).Name = "Número de faja"
        DataGridView1.Columns(15).Name = "Número de oblea"
        DataGridView1.Columns(16).Name = "Valor declarado $"

        txtCantidad.Text = "1"

        Hoy = Now.Date()

        UsrRemitente = UCase(System.Environment.UserName)
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Usuarios where NUsuario = '" & UsrRemitente & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Remitente = myReader.GetString(1)
        EdifOrigen = myReader.GetValue(2)
        lblEdifOrigen.Text = EdifOrigen
        Select Case EdifOrigen
            Case "BA-Av. de Mayo"
                ColumnaOrigen = "StockMayo"
            Case "BA-PaseoColon"
                ColumnaOrigen = "StockPaseoColon"
            Case "BA-Olleros"
                ColumnaOrigen = "StockOlleros"
            Case "Cba-Sabattini"
                ColumnaOrigen = "StockSabattini"
        End Select

        myReader.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select distinct DescripcionMaterial from Materiales order by DescripcionMaterial"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            ComboDescripcion.Items.Add(results)
        Loop
        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Destinos order by Nombre"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            ComboEdificio.Items.Add(results)
        Loop
        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Nomina where Pais = 'AR' order by UsuarioSAP"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            ComboLegajo.Items.Add(results)
        Loop
        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Dolar"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Dolar = myReader.GetValue(0)
        txtDolar.Text = Dolar
        myConn.Close()

        'Dolar = CurrencyConverter.GetExchangeRate("USD", "ARS")
        'txtDolar.Text = Dolar

    End Sub

    Private Sub ComboDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDescripcion.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Materiales where DescripcionMaterial = '" & ComboDescripcion.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        ComboMarcaModelo.Text = ""
        ComboMarcaModelo.Items.Clear()
        Do While myReader.Read()
            results = myReader.GetString(2)
            ComboMarcaModelo.Items.Add(results)
        Loop
        myConn.Close()
    End Sub

    Private Sub ComboMarcaModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMarcaModelo.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Materiales where MarcaModelo = '" & ComboMarcaModelo.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Seriado = myReader.GetValue(3)
        Select Case ColumnaOrigen
            Case "StockOlleros"
                txtStock.Text = myReader.GetValue(4)
            Case "StockMayo"
                txtStock.Text = myReader.GetValue(5)
            Case "StockPaseoColon"
                txtStock.Text = myReader.GetValue(6)
            Case "StockSabattini"
                txtStock.Text = myReader.GetValue(7)
        End Select
        txtValor.Text = myReader.GetValue(8)
        CodSAP = myReader.GetValue(9)
        myConn.Close()
        Timer1.Enabled = True
        If Seriado = 0 Then
            txtSerie.Enabled = False
            txtSerie.Text = "-"
        Else
            txtSerie.Enabled = True
            txtSerie.Text = ""
        End If
    End Sub
    Private Sub ComboLegajo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLegajo.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Nomina where UsuarioSAP = '" & ComboLegajo.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        txtApellidoNombre.Text = myReader.GetValue(2)
        txtCentroCosto.Text = myReader.GetValue(11)
        'ComboEdificio.Text = myReader.GetValue(10)
        'txtDireccion.Text = ""
        myConn.Close()
    End Sub

    Private Sub ComboEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEdificio.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Destinos where Nombre = '" & ComboEdificio.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Try
            txtDireccion.Text = myReader.GetString(1)
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
        myConn.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        If txtDolar.Text = "" Then
            MsgBox("Se requiere completar la cotización del dólar.", vbInformation)
        Else
            If txtStock.Text <= 0 Then
                MsgBox("No hay stock del material seleccionado", vbCritical)
            Else
                If ComboDescripcion.Text <> "" And ComboMarcaModelo.Text <> "" And txtSerie.Text <> "" And txtTicket.Text <> "" And ComboLegajo.Text <> "" And txtApellidoNombre.Text <> "" And ComboEdificio.Text <> "" And txtDireccion.Text <> "" And txtCentroCosto.Text <> "" And txtCajas.Text <> "" And txtFaja.Text <> "" And txtOblea.Text <> "" And txtValor.Text <> "" Then
                    Try
                        Dolar = txtDolar.Text
                        ValorDeclarado = txtValor.Text
                        Cantidad = txtCantidad.Text
                        ARS = ValorDeclarado * Dolar * Cantidad
                        If Cantidad > 1 And Seriado = 1 Then
                            For i = 1 To Cantidad
                                NrosDeSerie &= InputBox("Número de serie " & i & " de " & Cantidad, "Salida de Materiales")
                                If i < Cantidad Then
                                    NrosDeSerie &= Environment.NewLine
                                End If
                            Next
                        Else
                            NrosDeSerie = txtSerie.Text
                        End If

                        If CantCajas > 1 And chkFaja.Checked = False Then
                            For i = 1 To CantCajas
                                Faja &= InputBox("Faja " & i & " de " & CantCajas, "Salida de Materiales")
                                If i < Cantidad Then
                                    Faja &= Environment.NewLine
                                End If
                            Next
                        Else
                            Faja = txtFaja.Text
                        End If

                        If CantCajas > 1 And chkOblea.Checked = False Then
                            For i = 1 To CantCajas
                                Oblea &= InputBox("Oblea " & i & " de " & CantCajas, "Salida de Materiales")
                                If i < Cantidad Then
                                    Oblea &= Environment.NewLine
                                End If
                            Next
                        Else
                            Oblea = txtOblea.Text
                        End If

                        Dim FilaMaterial As String() = New String() {Remitente, Hoy, CodSAP, ComboDescripcion.Text, ComboMarcaModelo.Text, NrosDeSerie, txtCantidad.Text, txtTicket.Text, ComboLegajo.Text, txtApellidoNombre.Text, ComboEdificio.Text, txtDireccion.Text, txtCentroCosto.Text, txtCajas.Text, Faja, Oblea, "$ " & Math.Round(ARS, 2)}
                        DataGridView1.Rows.Add(FilaMaterial)
                    Catch ex As Exception
                        MsgBox(ex.Message, vbExclamation)
                    End Try

                    ComboDescripcion.Text = ""
                    ComboMarcaModelo.Items.Clear()
                    ComboMarcaModelo.Text = ""
                    txtCantidad.Text = "1"
                    txtSerie.Text = ""
                    txtTicket.Text = ""
                    ComboLegajo.Text = ""
                    txtApellidoNombre.Text = ""
                    ComboEdificio.Text = ""
                    txtDireccion.Text = ""
                    txtCentroCosto.Text = ""
                    txtCajas.Text = ""
                    txtFaja.Text = ""
                    txtOblea.Text = ""
                    txtValor.Text = ""
                Else
                    MsgBox("Se requiere completar todos los campos.", vbExclamation)
                End If
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim Remitente As String = row.Cells(0).Value.ToString()
            Dim Fecha As Date = row.Cells(1).Value.ToString()
            Dim Fecha2 As String = Fecha.Year & "-" & Fecha.Month & "-" & Fecha.Day
            'Dim EdifOrigen As String = EdifOrigen
            Dim TipoEntrega As String = "Salida"
            Dim CodigoSAP As String = row.Cells(2).Value.ToString
            Dim DescripcionMaterial As String = row.Cells(3).Value.ToString()
            Dim MarcaModelo As String = row.Cells(4).Value.ToString()
            Dim NroSerie As String = row.Cells(5).Value.ToString()
            Dim Cantidad As String = row.Cells(6).Value.ToString()
            Dim Ticket As String = row.Cells(7).Value.ToString()
            Dim UsuarioDestinatario As String = row.Cells(8).Value.ToString()
            Dim EdificioDestino As String = row.Cells(10).Value.ToString()
            Dim NroFaja As String = row.Cells(14).Value.ToString()
            Dim NroOblea As String = row.Cells(15).Value.ToString()

            '.Columns(0).Name = "Remitente"
            '.Columns(1).Name = "Fecha"
            '.Columns(2).Name = "Código SAP"
            '.Columns(3).Name = "Descripción del material"
            '.Columns(4).Name = "Marca y modelo"
            '.Columns(5).Name = "Número de serie"
            '.Columns(6).Name = "Cantidad"
            '.Columns(7).Name = "Ticket"
            '.Columns(8).Name = "Legajo"
            '.Columns(9).Name = "Apellido y Nombre"
            '.Columns(10).Name = "Destino"
            '.Columns(11).Name = "Dirección"
            '.Columns(12).Name = "Centro de Costos"
            '.Columns(13).Name = "Cantidad de cajas"
            '.Columns(14).Name = "Número de faja"
            '.Columns(15).Name = "Número de oblea"
            '.Columns(16).Name = "Valor declarado $"

            If DescripcionMaterial = "Notebook" Then
                Dim frmNotebooks As New Notebooks() With {.MdiParent = ControlStockMenu}
                frmNotebooks.Show()
                frmNotebooks.txtSerieNuevo.Text = NroSerie
                frmNotebooks.txtModeloNuevo.Text = MarcaModelo
                frmNotebooks.txtLegajo.Text = UsuarioDestinatario
                frmNotebooks.txtApellidoNombre.Text = row.Cells(9).Value.ToString()
                Application.DoEvents()
                While Not frmNotebooks.IsDisposed
                    Application.DoEvents()
                End While
            End If

            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "insert into SalidaMateriales values('" & Remitente & "', '" & Fecha2 & "', '" & EdifOrigen & "', '" & TipoEntrega & "', '" & CodigoSAP & "', '" & DescripcionMaterial & "', '" & MarcaModelo & "', " & Cantidad & ", '" & NroSerie & "', '" & Ticket & "', '" & UsuarioDestinatario & "', '" & EdificioDestino & "', '" & NroFaja & "', '" & NroOblea & "')"
            myCmd.ExecuteNonQuery()
            myConn.Close()

            TmpConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            TmpConn.Open()
            TmpCmd = TmpConn.CreateCommand
            TmpCmd.CommandText = "select * from Materiales where DescripcionMaterial = '" & DescripcionMaterial & "' and MarcaModelo = '" & MarcaModelo & "'"
            TmpReader = TmpCmd.ExecuteReader()
            TmpReader.Read()

            Dim CantidadAnterior As Integer

            Select Case ColumnaOrigen
                Case "StockOlleros"
                    CantidadAnterior = TmpReader.GetValue(4)
                Case "StockMayo"
                    CantidadAnterior = TmpReader.GetValue(5)
                Case "StockPaseoColon"
                    CantidadAnterior = TmpReader.GetValue(6)
                Case "StockSabattini"
                    CantidadAnterior = TmpReader.GetValue(7)
            End Select
            TmpConn.Close()

            TmpConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            TmpConn.Open()
            TmpCmd = TmpConn.CreateCommand
            TmpCmd.CommandText = "update Materiales set " & ColumnaOrigen & "=" & CantidadAnterior - Cantidad & " where DescripcionMaterial = '" & DescripcionMaterial & "' and MarcaModelo = '" & MarcaModelo & "'"
            TmpCmd.ExecuteNonQuery()
            TmpConn.Close()
        Next
        DataGridView1.SelectAll()
        dataObj = DataGridView1.GetClipboardContent()
        Clipboard.SetDataObject(dataObj)
        MsgBox("Datos guardados. Tabla copiada al portapapeles.", vbOKOnly + vbInformation, "Control de stock")
        Me.Close()
        'Process.Start("C:\Program Files\Microsoft Office\root\Office16\outlook.exe", "/c ipm.note /m ""luciano.sillem@claro.com.ar?subject=Envío&body=" & Clipboard.GetText & """")
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Try
            If txtCantidad.Text <> "" Then
                Cantidad = Int(txtCantidad.Text)
                If Cantidad > 1 And Seriado = 1 Then
                    txtSerie.ReadOnly = True
                    txtSerie.Text = "Presionar Agregar para introducir números de serie"
                Else
                    txtSerie.ReadOnly = False
                    If Seriado = 0 Then
                        txtSerie.Text = "-"
                    Else
                        txtSerie.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboMarcaModelo.Text <> "" Then
            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select * from Materiales where MarcaModelo = '" & ComboMarcaModelo.Text & "'"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            myReader.Read()
            Select Case ColumnaOrigen
                Case "StockOlleros"
                    txtStock.Text = myReader.GetValue(4)
                Case "StockMayo"
                    txtStock.Text = myReader.GetValue(5)
                Case "StockPaseoColon"
                    txtStock.Text = myReader.GetValue(6)
                Case "StockSabattini"
                    txtStock.Text = myReader.GetValue(7)
            End Select
            myConn.Close()
        End If
    End Sub

    Private Sub txtCajas_TextChanged(sender As Object, e As EventArgs) Handles txtCajas.TextChanged
        Try
            If txtCajas.Text <> "" Then
                CantCajas = Int(txtCajas.Text)
                If CantCajas > 1 Then
                    If chkFaja.Checked = False Then
                        txtFaja.ReadOnly = True
                        txtFaja.Text = "Presionar Agregar para introducir números de de faja"
                    End If
                    If chkOblea.Checked = False Then
                        txtOblea.ReadOnly = True
                        txtOblea.Text = "Presionar Agregar para introducir números de oblea"
                    End If
                Else
                    txtFaja.ReadOnly = False
                    txtFaja.Text = ""
                    txtOblea.ReadOnly = False
                    txtOblea.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub chkFaja_CheckedChanged(sender As Object, e As EventArgs) Handles chkFaja.CheckedChanged
        If chkFaja.Checked Then
            txtFaja.ReadOnly = True
            txtFaja.Text = "-"
        Else
            txtFaja.ReadOnly = False
        End If
    End Sub

    Private Sub chkOblea_CheckedChanged(sender As Object, e As EventArgs) Handles chkOblea.CheckedChanged
        If chkOblea.Checked Then
            txtOblea.ReadOnly = True
            txtOblea.Text = "-"
        Else
            txtOblea.ReadOnly = False
        End If
    End Sub
End Class