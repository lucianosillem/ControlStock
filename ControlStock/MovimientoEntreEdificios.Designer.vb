<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientoEntreEdificios
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ComboOrigen = New ComboBox()
        ComboDestino = New ComboBox()
        ComboDescripcion = New ComboBox()
        ComboMarcaModelo = New ComboBox()
        txtCantidad = New TextBox()
        txtSerie = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        btnAgregar = New Button()
        Label13 = New Label()
        Label12 = New Label()
        txtFaja = New TextBox()
        txtCajas = New TextBox()
        BtnGuardar = New Button()
        Label7 = New Label()
        txtStock = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboOrigen
        ' 
        ComboOrigen.FormattingEnabled = True
        ComboOrigen.Location = New Point(166, 12)
        ComboOrigen.Name = "ComboOrigen"
        ComboOrigen.Size = New Size(121, 22)
        ComboOrigen.TabIndex = 0
        ' 
        ' ComboDestino
        ' 
        ComboDestino.FormattingEnabled = True
        ComboDestino.Location = New Point(166, 40)
        ComboDestino.Name = "ComboDestino"
        ComboDestino.Size = New Size(121, 22)
        ComboDestino.TabIndex = 1
        ' 
        ' ComboDescripcion
        ' 
        ComboDescripcion.FormattingEnabled = True
        ComboDescripcion.Location = New Point(166, 68)
        ComboDescripcion.Name = "ComboDescripcion"
        ComboDescripcion.Size = New Size(312, 22)
        ComboDescripcion.TabIndex = 2
        ' 
        ' ComboMarcaModelo
        ' 
        ComboMarcaModelo.FormattingEnabled = True
        ComboMarcaModelo.Location = New Point(166, 96)
        ComboMarcaModelo.Name = "ComboMarcaModelo"
        ComboMarcaModelo.Size = New Size(312, 22)
        ComboMarcaModelo.TabIndex = 3
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(166, 124)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(44, 22)
        txtCantidad.TabIndex = 4
        ' 
        ' txtSerie
        ' 
        txtSerie.Location = New Point(166, 152)
        txtSerie.Name = "txtSerie"
        txtSerie.Size = New Size(121, 22)
        txtSerie.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 14)
        Label1.TabIndex = 6
        Label1.Text = "Edificio Origen"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 14)
        Label2.TabIndex = 7
        Label2.Text = "Edificio Destino"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 14)
        Label3.TabIndex = 8
        Label3.Text = "Descripción del material"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 14)
        Label4.TabIndex = 9
        Label4.Text = "Marca y modelo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(103, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 14)
        Label5.TabIndex = 10
        Label5.Text = "Cantidad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(60, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 14)
        Label6.TabIndex = 11
        Label6.Text = "Número de serie"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(499, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(658, 218)
        DataGridView1.TabIndex = 12
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(182, 236)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 31)
        btnAgregar.TabIndex = 31
        btnAgregar.Text = "&Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(66, 211)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 14)
        Label13.TabIndex = 35
        Label13.Text = "Número de faja"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(55, 183)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 14)
        Label12.TabIndex = 34
        Label12.Text = "Cantidad de cajas"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtFaja
        ' 
        txtFaja.Location = New Point(166, 208)
        txtFaja.Name = "txtFaja"
        txtFaja.Size = New Size(120, 22)
        txtFaja.TabIndex = 33
        ' 
        ' txtCajas
        ' 
        txtCajas.Location = New Point(166, 180)
        txtCajas.Name = "txtCajas"
        txtCajas.Size = New Size(40, 22)
        txtCajas.TabIndex = 32
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(730, 237)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(196, 31)
        BtnGuardar.TabIndex = 37
        BtnGuardar.Text = "&Guardar pedido"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(216, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 14)
        Label7.TabIndex = 39
        Label7.Text = "Stock disponible"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtStock
        ' 
        txtStock.Enabled = False
        txtStock.Location = New Point(316, 125)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(40, 22)
        txtStock.TabIndex = 38
        ' 
        ' MovimientoEntreEdificios
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1169, 280)
        Controls.Add(Label7)
        Controls.Add(txtStock)
        Controls.Add(BtnGuardar)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(txtFaja)
        Controls.Add(txtCajas)
        Controls.Add(btnAgregar)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSerie)
        Controls.Add(txtCantidad)
        Controls.Add(ComboMarcaModelo)
        Controls.Add(ComboDescripcion)
        Controls.Add(ComboDestino)
        Controls.Add(ComboOrigen)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "MovimientoEntreEdificios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Movimiento entre edificios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboOrigen As ComboBox
    Friend WithEvents ComboDestino As ComboBox
    Friend WithEvents ComboDescripcion As ComboBox
    Friend WithEvents ComboMarcaModelo As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFaja As TextBox
    Friend WithEvents txtCajas As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStock As TextBox
End Class
