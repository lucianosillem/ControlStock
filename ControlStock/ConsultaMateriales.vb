﻿Public Class ConsultaMateriales
    Dim dataTable As New DataTable()
    Private Sub ConsultaMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDataGridView()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FiltrarDataGridView()
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BorrarFiltroDataGridView()
        Button1.Enabled = True
        Button4.Enabled = True
    End Sub
    Private Sub LlenarDataGridView()
        Dim connectionString As String = "Data Source=CORPBA-SQL;Initial Catalog=Stock;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        Dim query As String = "select CodigoSAP, DescripcionMaterial, MarcaModelo, Valor, StockOlleros, StockMayo, StockPaseoColon, StockSabattini from Materiales"
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(DataTable)
        DataGridView1.DataSource = DataTable
    End Sub

    Private Sub FiltrarDataGridView()
        Dim filtro As String = TextBox1.Text.Trim()
        Try
            If filtro <> "" Then
                Dim vista As New DataView(DataGridView1.DataSource) With {
                    .RowFilter = $"CodigoSAP LIKE '%{filtro}%'"
                }
                DataGridView1.DataSource = vista
            Else
                DataGridView1.DataSource = DataTable
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub

    Private Sub BorrarFiltroDataGridView()
        TextBox1.Text = "" ' Borra el texto del TextBox
        DataGridView1.DataSource = DataTable ' Restaura la fuente de datos original
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filtro As String = TextBox2.Text.Trim()
        Try
            If filtro <> "" Then
                Dim vista As New DataView(DataGridView1.DataSource) With {
                    .RowFilter = $"DescripcionMaterial LIKE '%{filtro}%'"
                }
                DataGridView1.DataSource = vista
            Else
                DataGridView1.DataSource = dataTable
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        End Try
    End Sub
End Class