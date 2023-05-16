Public Class EntregaMaterial
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim results, UsrRemitente, Remitente, EdificioOrigen, ColumnaOrigen, CodigoSAP As String
    Dim Seriado As Integer
    Dim Hoy As Date

    Private Sub EntregaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hoy = Now.Date()

        UsrRemitente = UCase(Environment.UserName)
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Usuarios where NUsuario = '" & UsrRemitente & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Remitente = myReader.GetString(1)
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
        myCmd.CommandText = "Select * from Nomina where Pais = 'AR' order by UsuarioSAP"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            ComboLegajo.Items.Add(results)
        Loop
        myConn.Close()
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

    Private Sub ComboLegajo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLegajo.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Nomina where UsuarioSAP = '" & ComboLegajo.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        txtApellidoNombre.Text = myReader.GetValue(2)
        myConn.Close()
    End Sub

    Private Sub ComboMarcaModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMarcaModelo.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Materiales where DescripcionMaterial = '" & ComboDescripcion.Text & "' And MarcaModelo = '" & ComboMarcaModelo.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Seriado = myReader.GetValue(3)
        CodigoSAP = myReader.GetValue(9)
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

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ComboDescripcion.Text <> "" And ComboMarcaModelo.Text <> "" And txtSerie.Text <> "" And txtTicket.Text <> "" And ComboLegajo.Text <> "" And txtApellidoNombre.Text <> "" Then
            If ComboDescripcion.Text = "Notebook" Then
                Dim frmNotebooks As New Notebooks() With {.MdiParent = ControlStockMenu}
                frmNotebooks.Show()
                frmNotebooks.txtSerieNuevo.Text = txtSerie.Text
                frmNotebooks.txtModeloNuevo.Text = ComboMarcaModelo.Text
                frmNotebooks.txtLegajo.Text = ComboLegajo.Text
                frmNotebooks.txtApellidoNombre.Text = txtApellidoNombre.Text
                Application.DoEvents()
                While Not frmNotebooks.IsDisposed
                    Application.DoEvents()
                End While
            End If

            'Dim Remitente As String = UsrRemitente
            Dim Fecha As Date = Hoy
            Dim Fecha2 As String = Fecha.Year & "-" & Fecha.Month & "-" & Fecha.Day
            'EdifOrigen
            Dim TipoEntrega As String = "Entrega"
            'CodigoSAP
            Dim DescripcionMaterial As String = ComboDescripcion.Text
            Dim MarcaModelo As String = ComboMarcaModelo.Text
            Dim NroSerie As String = txtSerie.Text
            Dim Cantidad As String = 1
            Dim Ticket As String = txtTicket.Text
            Dim UsuarioDestinatario As String = ComboLegajo.Text
            Dim EdificioDestino As String = EdificioOrigen
            Dim NroFaja As String = "-"
            Dim NroOblea As String = "-"

            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "insert into SalidaMateriales values('" & Remitente & "', '" & Fecha2 & "', '" & EdificioOrigen & "', '" & TipoEntrega & "', '" & CodigoSAP & "', '" & DescripcionMaterial & "', '" & MarcaModelo & "', " & Cantidad & ", '" & NroSerie & "', '" & Ticket & "', '" & UsuarioDestinatario & "', '" & EdificioDestino & "', '" & NroFaja & "', '" & NroOblea & "')"
            myCmd.ExecuteNonQuery()
            myConn.Close()

            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "select * from Materiales where DescripcionMaterial = '" & DescripcionMaterial & "' and MarcaModelo = '" & MarcaModelo & "'"
            myReader = myCmd.ExecuteReader()
            myReader.Read()

            Dim CantidadAnterior As Integer

            Select Case ColumnaOrigen
                Case "StockOlleros"
                    CantidadAnterior = myReader.GetValue(4)
                Case "StockMayo"
                    CantidadAnterior = myReader.GetValue(5)
                Case "StockPaseoColon"
                    CantidadAnterior = myReader.GetValue(6)
                Case "StockSabattini"
                    CantidadAnterior = myReader.GetValue(7)
            End Select
            myConn.Close()

            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "update Materiales set " & ColumnaOrigen & "=" & CantidadAnterior - 1 & " where DescripcionMaterial = '" & DescripcionMaterial & "' and MarcaModelo = '" & MarcaModelo & "'"
            myCmd.ExecuteNonQuery()
            myConn.Close()

            Me.Close()
        Else
            MsgBox("Se requiere completar todos los campos.", vbExclamation)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboMarcaModelo.Text <> "" Then
            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Select * from Materiales where DescripcionMaterial = '" & ComboDescripcion.Text & "' And MarcaModelo = '" & ComboMarcaModelo.Text & "'"
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
End Class