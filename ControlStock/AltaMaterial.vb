Public Class AltaMaterial
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Dim Seriado, ID_Nuevo As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Seriado = 1
        Else
            Seriado = 0
        End If
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select top(1) ID_Material from Materiales order by ID_Material DESC"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        ID_Nuevo = myReader.GetValue(0) + 1
        myConn.Close()

        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into materiales values(" & ID_Nuevo & ",'" & txtDescripcion.Text & "','" & txtMarcaModelo.Text & "'," & Seriado & ",0,0,0,0,'" & txtValor.Text & "','" & txtCodSAP.Text & "')"
        myCmd.ExecuteNonQuery()
        myConn.Close()
        MsgBox("Datos guardados correctamente.", vbInformation + vbOKOnly, "Alta de inventario")
        Me.Close()
    End Sub
End Class