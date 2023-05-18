Imports DocumentFormat.OpenXml.Wordprocessing
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ImprimirEtiqueta
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private Sub ImprimirEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from Usuarios where NUsuario = '" & UCase(Environment.UserName) & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        ControlStockMenu.RemitoRemitente = myReader.GetString(1)
        myConn.Close()
        If ControlStockMenu.RemitoTabla <> "" Then
            myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "select * from " & ControlStockMenu.RemitoTabla & " order by Nombre"
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            Do While myReader.Read()
                ComboBox1.Items.Add(myReader.GetString(1))
            Loop
            myConn.Close()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Relevamiento;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * from " & ControlStockMenu.RemitoTabla & " where Nombre = '" & ComboBox1.Text & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Read()
        Try
            Select Case ControlStockMenu.RemitoTabla
                Case "CACs"
                    txtDestinatario.Text = myReader.GetString(7)
                    txtDireccion.Text = myReader.GetString(2)
                    txtLocalidad.Text = myReader.GetString(3)
                    txtProvincia.Text = myReader.GetString(4)
                    txtCP.Text = myReader.GetString(6)
                Case "Edificios"
                    txtDestinatario.Text = ""
                    txtDireccion.Text = myReader.GetString(2)
                    txtLocalidad.Text = myReader.GetString(3)
                    txtProvincia.Text = myReader.GetString(4)
                    txtCP.Text = myReader.GetString(5)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
        myConn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtDestinatario.Text <> "" And txtDireccion.Text <> "" And txtLocalidad.Text <> "" And txtProvincia.Text <> "" And txtCP.Text <> "" And txtCantCajas.Text <> "" Then
            ControlStockMenu.RemitoDestinatario = StrConv(txtDestinatario.Text, vbProperCase)
            ControlStockMenu.RemitoDireccion = txtDireccion.Text
            ControlStockMenu.RemitoLocalidad = txtLocalidad.Text
            ControlStockMenu.RemitoProvincia = txtProvincia.Text
            ControlStockMenu.RemitoCP = txtCP.Text
            ControlStockMenu.NroCaja = txtCantCajas.Text
            Me.Dispose()
        Else
            MsgBox("Se requiere completar todos los campos.", vbExclamation, "Control Stock Microinformática")
        End If
    End Sub

    Private Sub ImprimirEtiqueta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class