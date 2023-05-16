<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidaMateriales
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
        components = New ComponentModel.Container()
        txtSerie = New TextBox()
        ComboDescripcion = New ComboBox()
        ComboMarcaModelo = New ComboBox()
        txtCantidad = New TextBox()
        txtStock = New TextBox()
        txtTicket = New TextBox()
        ComboLegajo = New ComboBox()
        txtApellidoNombre = New TextBox()
        ComboEdificio = New ComboBox()
        txtDireccion = New TextBox()
        txtCentroCosto = New TextBox()
        txtCajas = New TextBox()
        txtFaja = New TextBox()
        txtOblea = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        DataGridView1 = New DataGridView()
        btnAgregar = New Button()
        Label15 = New Label()
        txtValor = New TextBox()
        txtDolar = New TextBox()
        Label16 = New Label()
        BindingSource1 = New BindingSource(components)
        BtnGuardar = New Button()
        Timer1 = New Timer(components)
        lblEdifOrigen = New Label()
        chkFaja = New CheckBox()
        chkOblea = New CheckBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSerie
        ' 
        txtSerie.Location = New Point(152, 63)
        txtSerie.Name = "txtSerie"
        txtSerie.Size = New Size(186, 22)
        txtSerie.TabIndex = 3
        ' 
        ' ComboDescripcion
        ' 
        ComboDescripcion.AutoCompleteMode = AutoCompleteMode.Append
        ComboDescripcion.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboDescripcion.DropDownWidth = 500
        ComboDescripcion.FormattingEnabled = True
        ComboDescripcion.Location = New Point(152, 8)
        ComboDescripcion.Name = "ComboDescripcion"
        ComboDescripcion.Size = New Size(309, 22)
        ComboDescripcion.TabIndex = 1
        ' 
        ' ComboMarcaModelo
        ' 
        ComboMarcaModelo.AutoCompleteMode = AutoCompleteMode.Append
        ComboMarcaModelo.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboMarcaModelo.FormattingEnabled = True
        ComboMarcaModelo.Location = New Point(152, 35)
        ComboMarcaModelo.Name = "ComboMarcaModelo"
        ComboMarcaModelo.Size = New Size(309, 22)
        ComboMarcaModelo.TabIndex = 2
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(152, 90)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(40, 22)
        txtCantidad.TabIndex = 3
        ' 
        ' txtStock
        ' 
        txtStock.Enabled = False
        txtStock.Location = New Point(298, 90)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(40, 22)
        txtStock.TabIndex = 4
        ' 
        ' txtTicket
        ' 
        txtTicket.Location = New Point(152, 117)
        txtTicket.Name = "txtTicket"
        txtTicket.Size = New Size(186, 22)
        txtTicket.TabIndex = 5
        ' 
        ' ComboLegajo
        ' 
        ComboLegajo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboLegajo.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboLegajo.FormattingEnabled = True
        ComboLegajo.Location = New Point(152, 144)
        ComboLegajo.Name = "ComboLegajo"
        ComboLegajo.Size = New Size(186, 22)
        ComboLegajo.TabIndex = 6
        ' 
        ' txtApellidoNombre
        ' 
        txtApellidoNombre.Location = New Point(152, 171)
        txtApellidoNombre.Name = "txtApellidoNombre"
        txtApellidoNombre.Size = New Size(309, 22)
        txtApellidoNombre.TabIndex = 7
        ' 
        ' ComboEdificio
        ' 
        ComboEdificio.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboEdificio.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboEdificio.FormattingEnabled = True
        ComboEdificio.Location = New Point(152, 198)
        ComboEdificio.Name = "ComboEdificio"
        ComboEdificio.Size = New Size(186, 22)
        ComboEdificio.TabIndex = 8
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(152, 225)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.ReadOnly = True
        txtDireccion.Size = New Size(309, 22)
        txtDireccion.TabIndex = 9
        ' 
        ' txtCentroCosto
        ' 
        txtCentroCosto.Location = New Point(152, 252)
        txtCentroCosto.Name = "txtCentroCosto"
        txtCentroCosto.Size = New Size(186, 22)
        txtCentroCosto.TabIndex = 10
        ' 
        ' txtCajas
        ' 
        txtCajas.Location = New Point(152, 279)
        txtCajas.Name = "txtCajas"
        txtCajas.Size = New Size(40, 22)
        txtCajas.TabIndex = 11
        ' 
        ' txtFaja
        ' 
        txtFaja.Location = New Point(152, 306)
        txtFaja.Name = "txtFaja"
        txtFaja.Size = New Size(186, 22)
        txtFaja.TabIndex = 13
        ' 
        ' txtOblea
        ' 
        txtOblea.Location = New Point(152, 333)
        txtOblea.Name = "txtOblea"
        txtOblea.Size = New Size(186, 22)
        txtOblea.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 14)
        Label1.TabIndex = 15
        Label1.Text = "Descripción del material"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 14)
        Label2.TabIndex = 16
        Label2.Text = "Marca y modelo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 14)
        Label3.TabIndex = 17
        Label3.Text = "Número de serie"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(92, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 14)
        Label4.TabIndex = 18
        Label4.Text = "Cantidad"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(198, 92)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 14)
        Label5.TabIndex = 19
        Label5.Text = "Stock disponible"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(105, 120)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 14)
        Label6.TabIndex = 20
        Label6.Text = "Ticket"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 14)
        Label7.TabIndex = 21
        Label7.Text = "Legajo destinatario"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(40, 174)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 14)
        Label8.TabIndex = 22
        Label8.Text = "Apellido y Nombre"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(57, 201)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 14)
        Label9.TabIndex = 23
        Label9.Text = "Edificio Destino"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(90, 228)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 14)
        Label10.TabIndex = 24
        Label10.Text = "Dirección"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(45, 255)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 14)
        Label11.TabIndex = 25
        Label11.Text = "Centro de costos"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(44, 282)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 14)
        Label12.TabIndex = 26
        Label12.Text = "Cantidad de cajas"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(55, 309)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 14)
        Label13.TabIndex = 27
        Label13.Text = "Número de faja"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(45, 336)
        Label14.Name = "Label14"
        Label14.Size = New Size(101, 14)
        Label14.TabIndex = 28
        Label14.Text = "Número de oblea"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.DarkRed
        DataGridView1.Location = New Point(505, 8)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ShowEditingIcon = False
        DataGridView1.Size = New Size(748, 375)
        DataGridView1.TabIndex = 29
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(152, 398)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 31)
        btnAgregar.TabIndex = 30
        btnAgregar.Text = "&Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(56, 361)
        Label15.Name = "Label15"
        Label15.Size = New Size(90, 14)
        Label15.TabIndex = 32
        Label15.Text = "Valor declarado"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(152, 361)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(75, 22)
        txtValor.TabIndex = 31
        ' 
        ' txtDolar
        ' 
        txtDolar.Location = New Point(299, 361)
        txtDolar.Name = "txtDolar"
        txtDolar.Size = New Size(75, 22)
        txtDolar.TabIndex = 33
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(228, 364)
        Label16.Name = "Label16"
        Label16.Size = New Size(65, 14)
        Label16.TabIndex = 34
        Label16.Text = "1 USD = $"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(781, 398)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(196, 31)
        BtnGuardar.TabIndex = 36
        BtnGuardar.Text = "&Guardar pedido"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 5000
        ' 
        ' lblEdifOrigen
        ' 
        lblEdifOrigen.AutoSize = True
        lblEdifOrigen.Location = New Point(344, 92)
        lblEdifOrigen.Name = "lblEdifOrigen"
        lblEdifOrigen.Size = New Size(11, 14)
        lblEdifOrigen.TabIndex = 38
        lblEdifOrigen.Text = "-"
        lblEdifOrigen.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' chkFaja
        ' 
        chkFaja.AutoSize = True
        chkFaja.Location = New Point(344, 308)
        chkFaja.Name = "chkFaja"
        chkFaja.Size = New Size(65, 18)
        chkFaja.TabIndex = 39
        chkFaja.Text = "Sin &faja"
        chkFaja.UseVisualStyleBackColor = True
        ' 
        ' chkOblea
        ' 
        chkOblea.AutoSize = True
        chkOblea.Location = New Point(344, 335)
        chkOblea.Name = "chkOblea"
        chkOblea.Size = New Size(75, 18)
        chkOblea.TabIndex = 40
        chkOblea.Text = "Sin &oblea"
        chkOblea.UseVisualStyleBackColor = True
        ' 
        ' SalidaMateriales
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1265, 441)
        Controls.Add(chkOblea)
        Controls.Add(chkFaja)
        Controls.Add(lblEdifOrigen)
        Controls.Add(BtnGuardar)
        Controls.Add(Label16)
        Controls.Add(txtDolar)
        Controls.Add(Label15)
        Controls.Add(txtValor)
        Controls.Add(btnAgregar)
        Controls.Add(DataGridView1)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtOblea)
        Controls.Add(txtFaja)
        Controls.Add(txtCajas)
        Controls.Add(txtCentroCosto)
        Controls.Add(txtDireccion)
        Controls.Add(ComboEdificio)
        Controls.Add(txtApellidoNombre)
        Controls.Add(ComboLegajo)
        Controls.Add(txtTicket)
        Controls.Add(txtStock)
        Controls.Add(txtCantidad)
        Controls.Add(ComboMarcaModelo)
        Controls.Add(ComboDescripcion)
        Controls.Add(txtSerie)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "SalidaMateriales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salida de materiales"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSerie As TextBox
    Friend WithEvents ComboDescripcion As ComboBox
    Friend WithEvents ComboMarcaModelo As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents ComboLegajo As ComboBox
    Friend WithEvents txtApellidoNombre As TextBox
    Friend WithEvents ComboEdificio As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCentroCosto As TextBox
    Friend WithEvents txtCajas As TextBox
    Friend WithEvents txtFaja As TextBox
    Friend WithEvents txtOblea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDolar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblEdifOrigen As Label
    Friend WithEvents chkFaja As CheckBox
    Friend WithEvents chkOblea As CheckBox
End Class
