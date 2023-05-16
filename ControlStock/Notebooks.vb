Public Class Notebooks
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Dim ModeloAnterior, SerieAnterior, ModeloNuevo, SerieNuevo, Legajo, ApellidoNombre As String
    Dim SeQuedaElEquipo As Integer
    Private Sub Notebooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboTipo.Items.Add("Recambio")
        ComboTipo.Items.Add("Asignación")
        ComboTipo.Items.Add("Excepción")
        ComboTipo.Items.Add("Préstamo")
        ComboModeloAnterior.Items.Add("Latitude E6420")
        ComboModeloAnterior.Items.Add("Latitude E6430")
        ComboModeloAnterior.Items.Add("Latitude E5450")
        ComboModeloAnterior.Items.Add("Latitude E5470")
        ComboModeloAnterior.Items.Add("Latitude 5480")
        ComboModeloAnterior.Items.Add("Latitude 5490")
        ComboModeloAnterior.Items.Add("Latitude 5410")
        ComboModeloAnterior.Items.Add("Latitude 5420")

    End Sub

    Private Sub ComboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipo.SelectedIndexChanged
        If ComboTipo.Text <> "Recambio" Then
            CheckBox1.Checked = False
            CheckBox1.Enabled = False
        Else
            CheckBox1.Enabled = True
        End If
        If ComboTipo.Text = "Asignación" Or ComboTipo.Text = "Préstamo" Then
            ComboModeloAnterior.Text = "-"
            ComboModeloAnterior.Enabled = False
            txtSerieAnterior.Text = "-"
            txtSerieAnterior.Enabled = False
        Else
            ComboModeloAnterior.Text = ""
            ComboModeloAnterior.Enabled = True
            txtSerieAnterior.Text = ""
            txtSerieAnterior.Text = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModeloAnterior = txtLegajo.Text
        ModeloNuevo = ComboModeloAnterior.Text
        SerieAnterior = txtSerieAnterior.Text
        SerieNuevo = txtSerieNuevo.Text
        Legajo = txtLegajo.Text
        ApellidoNombre = txtApellidoNombre.Text
        If CheckBox1.Checked Then
            SeQuedaElEquipo = 1
        Else
            SeQuedaElEquipo = 0
        End If
        myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "insert into Notebooks values('" & Legajo & "', '" & ApellidoNombre & "', '" & ComboTipo.Text & "', '" & ModeloAnterior & "', '" & SerieAnterior & "', '" & ModeloNuevo & "', '" & SerieNuevo & "', " & SeQuedaElEquipo & ")"
        myCmd.ExecuteNonQuery()
        myConn.Close()
        Me.Close()
    End Sub
End Class