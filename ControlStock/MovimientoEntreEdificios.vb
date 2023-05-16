
Public Class MovimientoEntreEdificios
    Inherits System.Windows.Forms.Form
    Private myConn, TmpConn As SqlConnection
    Private myCmd, TmpCmd As SqlCommand
    Private myReader, TmpReader As SqlDataReader
    Private results As String
    Dim User, EdificioOrigen, EdificioDestino, ColumnaOrigen, ColumnaDestino, NrosDeSerie, CodSAP As String
    Dim Hoy As Date
    Dim Seriado, Cantidad As Integer
    Dim dataObj As New DataObject
    Private Sub MovimientoEntreEdificios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 11
        DataGridView1.Columns(0).Name = "Remitente"
        DataGridView1.Columns(1).Name = "Fecha"
        DataGridView1.Columns(2).Name = "Edificio Origen"
        DataGridView1.Columns(3).Name = "Edificio Destino"
        DataGridView1.Columns(4).Name = "Código SAP"
        DataGridView1.Columns(5).Name = "Descripción del material"
        DataGridView1.Columns(6).Name = "Marca y modelo"
        DataGridView1.Columns(7).Name = "Cantidad"
        DataGridView1.Columns(8).Name = "Número de serie"
        DataGridView1.Columns(9).Name = "Cantidad de cajas"
        DataGridView1.Columns(10).Name = "Número de faja"


        User = UCase(System.Environment.UserName)
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Usuarios where NUsuario = '" & User & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        User = myReader.GetString(1)
        EdificioOrigen = myReader.GetString(2)
        Select Case EdificioOrigen
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

        ComboOrigen.Text = EdificioOrigen
        ComboOrigen.Enabled = False

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM Edificios WHERE Nombre IN ('BA-Av. de Mayo', 'BA-PaseoColon', 'BA-Olleros', 'Cba-Sabattini') AND Nombre != '" & EdificioOrigen & "' order by Nombre"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(1)
            ComboDestino.Items.Add(results)
        Loop
        myConn.Close()

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

        Hoy = Now.Date()

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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        If Cantidad > 1 And Seriado = 1 Then
            For i = 1 To Cantidad
                NrosDeSerie &= InputBox("Número de serie " & i & " de " & Cantidad, "Movimiento entre edificios")
                If i < Cantidad Then
                    NrosDeSerie &= Environment.NewLine
                End If
            Next
        Else
            NrosDeSerie = txtSerie.Text
        End If
        Dim FilaMaterial As String() = New String() {User, Hoy, ComboOrigen.Text, ComboDestino.Text, CodSAP, ComboDescripcion.Text, ComboMarcaModelo.Text, txtCantidad.Text, NrosDeSerie, txtCajas.Text, txtFaja.Text}
        DataGridView1.Rows.Add(FilaMaterial)
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

    Private Sub ComboMarcaModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMarcaModelo.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Materiales where MarcaModelo = '" & ComboMarcaModelo.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Seriado = myReader.GetValue(3)
        CodSAP = myReader.GetValue(9)
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
        If Seriado = 0 Then
            txtSerie.Enabled = False
            txtSerie.Text = "-"
        Else
            txtSerie.Enabled = True
            txtSerie.Text = ""
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim Remitente As String = row.Cells(0).Value.ToString()
            Dim Fecha As Date = row.Cells(1).Value.ToString()
            Dim Fecha2 As String = Fecha.Year & "-" & Fecha.Month & "-" & Fecha.Day
            'Dim EdifOrigen As String = EdifOrigen
            Dim TipoEntrega As String = "Traslado"
            Dim CodigoSAP As String = "-" 'row.Cells(2).Value.ToString 'Agregar al DataGrid
            Dim DescripcionMaterial As String = row.Cells(5).Value.ToString()
            Dim MarcaModelo As String = row.Cells(6).Value.ToString()
            Dim NroSerie As String = row.Cells(8).Value.ToString()
            Dim Cantidad As String = row.Cells(7).Value.ToString()
            Dim Ticket As String = "-"
            Dim UsuarioDestinatario As String = "-"
            Dim EdificioDestino As String = row.Cells(3).Value.ToString()
            Dim NroFaja As String = row.Cells(10).Value.ToString()
            Dim NroOblea As String = "-"

            'DataGridView1.Columns(0).Name = "Remitente"
            'DataGridView1.Columns(1).Name = "Fecha"
            'DataGridView1.Columns(2).Name = "Edificio Origen"
            'DataGridView1.Columns(3).Name = "Edificio Destino"
            'DataGridView1.Columns(4).Name = "Codigo SAP"
            'DataGridView1.Columns(5).Name = "Descripción del material"
            'DataGridView1.Columns(6).Name = "Marca y modelo"
            'DataGridView1.Columns(7).Name = "Cantidad"
            'DataGridView1.Columns(8).Name = "Número de serie"
            'DataGridView1.Columns(9).Name = "Cantidad de cajas"
            'DataGridView1.Columns(10).Name = "Número de faja"

            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "insert into SalidaMateriales values('" & Remitente & "', '" & Fecha2 & "', '" & EdificioOrigen & "', '" & TipoEntrega & "', '" & CodigoSAP & "', '" & DescripcionMaterial & "', '" & MarcaModelo & "', " & Cantidad & ", '" & NroSerie & "', '" & Ticket & "', '" & UsuarioDestinatario & "', '" & EdificioDestino & "', '" & NroFaja & "', '" & NroOblea & "')"
            myCmd.ExecuteNonQuery()
            myConn.Close()

            TmpConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            TmpConn.Open()
            TmpCmd = TmpConn.CreateCommand
            TmpCmd.CommandText = "select * from Materiales where DescripcionMaterial = '" & DescripcionMaterial & "' and MarcaModelo = '" & MarcaModelo & "'"
            TmpReader = TmpCmd.ExecuteReader()
            TmpReader.Read()

            Dim CantidadAnteriorOrigen, CantidadAnteriorDestino As Integer

            Select Case ColumnaOrigen
                Case "StockOlleros"
                    CantidadAnteriorOrigen = TmpReader.GetValue(4)
                Case "StockMayo"
                    CantidadAnteriorOrigen = TmpReader.GetValue(5)
                Case "StockPaseoColon"
                    CantidadAnteriorOrigen = TmpReader.GetValue(6)
                Case "StockSabattini"
                    CantidadAnteriorOrigen = TmpReader.GetValue(7)
            End Select

            Select Case EdificioDestino
                Case "BA-Av. de Mayo"
                    ColumnaDestino = "StockMayo"
                    CantidadAnteriorDestino = TmpReader.GetValue(4)
                Case "BA-PaseoColon"
                    ColumnaDestino = "StockPaseoColon"
                    CantidadAnteriorDestino = TmpReader.GetValue(5)
                Case "BA-Olleros"
                    ColumnaDestino = "StockOlleros"
                    CantidadAnteriorDestino = TmpReader.GetValue(6)
                Case "Cba-Sabattini"
                    ColumnaDestino = "StockSabattini"
                    CantidadAnteriorDestino = TmpReader.GetValue(7)
            End Select
            TmpConn.Close()

            TmpConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            TmpConn.Open()
            TmpCmd = TmpConn.CreateCommand
            TmpCmd.CommandText = "update Materiales set " & ColumnaOrigen & "=" & CantidadAnteriorOrigen - Cantidad & ", " & ColumnaDestino & "=" & CantidadAnteriorDestino + Cantidad & " where DescripcionMaterial = '" & DescripcionMaterial & "' and MarcaModelo = '" & MarcaModelo & "'"
            TmpCmd.ExecuteNonQuery()
            TmpConn.Close()
        Next
        DataGridView1.SelectAll()
        dataObj = DataGridView1.GetClipboardContent()
        Clipboard.SetDataObject(dataObj)
        MsgBox("Datos guardados. Tabla copiada al portapapeles.", vbOKOnly + vbInformation, "Control de stock")
        Me.Close()
    End Sub
End Class