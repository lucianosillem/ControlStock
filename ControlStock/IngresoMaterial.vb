Public Class IngresoMaterial
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim results As String
    Dim ID_Material, StockOlleros, StockMayo, StockPaseoColon, StockSabattini As Integer
    Private Sub IngresoMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub ComboDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDescripcion.SelectedIndexChanged
        ComboMarcaModelo.Items.Clear()
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
        myCmd.CommandText = "Select * from Materiales where DescripcionMaterial = '" & ComboDescripcion.Text & "' and MarcaModelo = '" & ComboMarcaModelo.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        id_material = myReader.GetValue(0)
        StockOlleros = myReader.GetValue(4)
        StockMayo = myReader.GetValue(5)
        StockPaseoColon = myReader.GetValue(6)
        StockSabattini = myReader.GetValue(7)
        myConn.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        StockOlleros += txtOlleros.Text
        StockMayo += txtMayo.Text
        StockPaseoColon += txtPaseoColon.Text
        StockSabattini += txtSabattini.Text
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE Materiales SET StockOlleros = " & StockOlleros & ", StockMayo =" & StockMayo & ", StockPaseoColon = " & StockPaseoColon & ", StockSabattini = " & StockSabattini & " WHERE ID_Material = " & ID_Material
        myCmd.ExecuteNonQuery()
        myConn.Close()
        Me.Close()
    End Sub
End Class