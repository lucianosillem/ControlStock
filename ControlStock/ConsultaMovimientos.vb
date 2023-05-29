Imports DocumentFormat.OpenXml.Office.Word

Public Class ConsultaMovimientos
    Dim dataTable As New DataTable()
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private Sub ConsultaMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDataGridView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        FiltrarDataGridView()
        btnFiltrar.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBorrarFiltro.Click
        BorrarFiltroDataGridView()
        btnFiltrar.Enabled = True
        btnFiltrarSinSL.Enabled = True
        btnCompletarSL.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub
    Private Sub LlenarDataGridView()
        Dim connectionString As String = "Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Dim query As String = "select * from SalidaMateriales"
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(dataTable)
        DataGridView1.DataSource = dataTable
    End Sub

    Public Sub FiltrarDataGridView()
        Dim filtro As String = TextBox1.Text.Trim()
        Dim vista As New DataView(DataGridView1.DataSource)
        Try
            If filtro <> "" Then
                vista.RowFilter = $"UsuarioDestinatario LIKE '%{filtro}%'"
                DataGridView1.DataSource = vista
            Else
                DataGridView1.DataSource = dataTable
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub BorrarFiltroDataGridView()
        TextBox1.Text = ""
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnFiltrarSinSL.Click
        btnFiltrar.Enabled = False
        btnFiltrarSinSL.Enabled = False
        Dim vista As New DataView(DataGridView1.DataSource)
        Try
            vista.RowFilter = $"NroOblea LIKE '-' and TipoEntrega LIKE 'Salida' and Remitente LIKE '%{ControlStockMenu.UsrRemitente}%'"
            DataGridView1.DataSource = vista
            If DataGridView1.SelectedRows.Count = 0 Then
                btnCompletarSL.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCompletarSL.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim Remitente As Object = filaSeleccionada.Cells("Remitente").Value
            Dim NroOblea As Object = filaSeleccionada.Cells("NroOblea").Value
            Dim NroTicket As Object = filaSeleccionada.Cells("Ticket").Value
            Dim DescripcionMaterial As Object = filaSeleccionada.Cells("DescripcionMaterial").Value
            Dim MarcaModelo As Object = filaSeleccionada.Cells("MarcaModelo").Value
            Dim NuevaOblea As String = InputBox("Número de oblea:", "Control de Stock Microinformática", NroOblea)

            Try
                myConn = New SqlConnection("Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True")
                myConn.Open()
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "update SalidaMateriales set NroOblea='" & NuevaOblea & "' where Remitente='" & Remitente & "' and Ticket='" & NroTicket & "' and DescripcionMaterial='" & DescripcionMaterial & "' and MarcaModelo='" & MarcaModelo & "'"
                myCmd.ExecuteNonQuery()
                myConn.Close()
                MsgBox("Datos actualizados.", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation)
            End Try
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        btnFiltrar.Enabled = False
        btnFiltrarSinSL.Enabled = False
        DateTimePicker1.Enabled = False
        btnCompletarSL.Enabled = False
        Try
            Dim fechaSeleccionada As DateTime = DateTimePicker1.Value.Date ' Obtiene solo la fecha sin la parte de tiempo
            Dim vista As New DataView(DataGridView1.DataSource)
            If vista IsNot Nothing Then
                vista.RowFilter = $"Convert([Fecha], 'System.DateTime') = '{fechaSeleccionada.ToString("yyyy-MM-dd")}'"
                DataGridView1.DataSource = vista
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class