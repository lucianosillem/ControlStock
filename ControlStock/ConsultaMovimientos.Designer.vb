<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaMovimientos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        btnFiltrar = New Button()
        btnBorrarFiltro = New Button()
        btnFiltrarSinSL = New Button()
        btnCompletarSL = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(12, 120)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ShowEditingIcon = False
        DataGridView1.Size = New Size(1242, 470)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 14)
        Label1.TabIndex = 1
        Label1.Text = "Filtrar por usuario"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(161, 22)
        TextBox1.TabIndex = 2
        ' 
        ' btnFiltrar
        ' 
        btnFiltrar.Location = New Point(285, 5)
        btnFiltrar.Name = "btnFiltrar"
        btnFiltrar.Size = New Size(46, 23)
        btnFiltrar.TabIndex = 3
        btnFiltrar.Text = "Filtrar"
        btnFiltrar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrarFiltro
        ' 
        btnBorrarFiltro.Location = New Point(12, 91)
        btnBorrarFiltro.Name = "btnBorrarFiltro"
        btnBorrarFiltro.Size = New Size(77, 23)
        btnBorrarFiltro.TabIndex = 4
        btnBorrarFiltro.Text = "Borrar filtro"
        btnBorrarFiltro.UseVisualStyleBackColor = True
        ' 
        ' btnFiltrarSinSL
        ' 
        btnFiltrarSinSL.Location = New Point(12, 62)
        btnFiltrarSinSL.Name = "btnFiltrarSinSL"
        btnFiltrarSinSL.Size = New Size(194, 23)
        btnFiltrarSinSL.TabIndex = 5
        btnFiltrarSinSL.Text = "Filtrar mis movimientos sin oblea"
        btnFiltrarSinSL.UseVisualStyleBackColor = True
        ' 
        ' btnCompletarSL
        ' 
        btnCompletarSL.Location = New Point(212, 62)
        btnCompletarSL.Name = "btnCompletarSL"
        btnCompletarSL.Size = New Size(121, 23)
        btnCompletarSL.TabIndex = 6
        btnCompletarSL.Text = "Completar oblea"
        btnCompletarSL.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(118, 34)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(109, 22)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 14)
        Label2.TabIndex = 8
        Label2.Text = "Filtrar por fecha"
        ' 
        ' ConsultaMovimientos
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1266, 602)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(btnCompletarSL)
        Controls.Add(btnFiltrarSinSL)
        Controls.Add(btnBorrarFiltro)
        Controls.Add(btnFiltrar)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ConsultaMovimientos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consulta de movimientos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents btnBorrarFiltro As Button
    Friend WithEvents btnFiltrarSinSL As Button
    Friend WithEvents btnCompletarSL As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
