<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaMaterial
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
        btnAceptar = New Button()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtSerie = New TextBox()
        ComboMarcaModelo = New ComboBox()
        ComboDescripcion = New ComboBox()
        ComboOrigen = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        txtApellidoNombre = New TextBox()
        ComboLegajo = New ComboBox()
        Label2 = New Label()
        txtTicket = New TextBox()
        Timer1 = New Timer(components)
        Label5 = New Label()
        txtStock = New TextBox()
        SuspendLayout()
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(203, 206)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 31)
        btnAceptar.TabIndex = 49
        btnAceptar.Text = "&Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(49, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 15)
        Label6.TabIndex = 47
        Label6.Text = "Número de serie"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 15)
        Label4.TabIndex = 45
        Label4.Text = "Marca y modelo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 15)
        Label3.TabIndex = 44
        Label3.Text = "Descripción del material"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 42
        Label1.Text = "Edificio Origen"
        ' 
        ' txtSerie
        ' 
        txtSerie.Location = New Point(148, 92)
        txtSerie.Name = "txtSerie"
        txtSerie.Size = New Size(121, 23)
        txtSerie.TabIndex = 41
        ' 
        ' ComboMarcaModelo
        ' 
        ComboMarcaModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboMarcaModelo.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboMarcaModelo.FormattingEnabled = True
        ComboMarcaModelo.Location = New Point(148, 63)
        ComboMarcaModelo.Name = "ComboMarcaModelo"
        ComboMarcaModelo.Size = New Size(312, 23)
        ComboMarcaModelo.TabIndex = 39
        ' 
        ' ComboDescripcion
        ' 
        ComboDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboDescripcion.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboDescripcion.FormattingEnabled = True
        ComboDescripcion.Location = New Point(148, 35)
        ComboDescripcion.Name = "ComboDescripcion"
        ComboDescripcion.Size = New Size(312, 23)
        ComboDescripcion.TabIndex = 38
        ' 
        ' ComboOrigen
        ' 
        ComboOrigen.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboOrigen.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboOrigen.FormattingEnabled = True
        ComboOrigen.Location = New Point(148, 6)
        ComboOrigen.Name = "ComboOrigen"
        ComboOrigen.Size = New Size(121, 23)
        ComboOrigen.TabIndex = 36
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(36, 180)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 15)
        Label8.TabIndex = 53
        Label8.Text = "Apellido y Nombre"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 153)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 15)
        Label7.TabIndex = 52
        Label7.Text = "Legajo destinatario"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtApellidoNombre
        ' 
        txtApellidoNombre.Location = New Point(148, 177)
        txtApellidoNombre.Name = "txtApellidoNombre"
        txtApellidoNombre.Size = New Size(309, 23)
        txtApellidoNombre.TabIndex = 51
        ' 
        ' ComboLegajo
        ' 
        ComboLegajo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboLegajo.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboLegajo.FormattingEnabled = True
        ComboLegajo.Location = New Point(148, 150)
        ComboLegajo.Name = "ComboLegajo"
        ComboLegajo.Size = New Size(121, 23)
        ComboLegajo.TabIndex = 50
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 55
        Label2.Text = "Ticket"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtTicket
        ' 
        txtTicket.Location = New Point(148, 121)
        txtTicket.Name = "txtTicket"
        txtTicket.Size = New Size(121, 23)
        txtTicket.TabIndex = 54
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 5000
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(319, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 57
        Label5.Text = "Stock disponible"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txtStock
        ' 
        txtStock.Enabled = False
        txtStock.Location = New Point(419, 93)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(40, 23)
        txtStock.TabIndex = 56
        ' 
        ' EntregaMaterial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 245)
        Controls.Add(Label5)
        Controls.Add(txtStock)
        Controls.Add(Label2)
        Controls.Add(txtTicket)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtApellidoNombre)
        Controls.Add(ComboLegajo)
        Controls.Add(btnAceptar)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(txtSerie)
        Controls.Add(ComboMarcaModelo)
        Controls.Add(ComboDescripcion)
        Controls.Add(ComboOrigen)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "EntregaMaterial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Entrega de material a usuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents ComboMarcaModelo As ComboBox
    Friend WithEvents ComboDescripcion As ComboBox
    Friend WithEvents ComboOrigen As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtApellidoNombre As TextBox
    Friend WithEvents ComboLegajo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStock As TextBox
End Class
