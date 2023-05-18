<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirEtiqueta
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
        ComboBox1 = New ComboBox()
        txtDestinatario = New TextBox()
        txtDireccion = New TextBox()
        txtLocalidad = New TextBox()
        txtProvincia = New TextBox()
        txtCP = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        txtCantCajas = New TextBox()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(99, 6)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(211, 22)
        ComboBox1.TabIndex = 0
        ' 
        ' txtDestinatario
        ' 
        txtDestinatario.Location = New Point(99, 34)
        txtDestinatario.Name = "txtDestinatario"
        txtDestinatario.Size = New Size(211, 22)
        txtDestinatario.TabIndex = 1
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(99, 62)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(211, 22)
        txtDireccion.TabIndex = 2
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.Location = New Point(99, 90)
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.Size = New Size(104, 22)
        txtLocalidad.TabIndex = 3
        ' 
        ' txtProvincia
        ' 
        txtProvincia.Location = New Point(99, 118)
        txtProvincia.Name = "txtProvincia"
        txtProvincia.Size = New Size(104, 22)
        txtProvincia.TabIndex = 4
        ' 
        ' txtCP
        ' 
        txtCP.Location = New Point(99, 146)
        txtCP.Name = "txtCP"
        txtCP.Size = New Size(72, 22)
        txtCP.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 14)
        Label1.TabIndex = 6
        Label1.Text = "Destino"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 14)
        Label2.TabIndex = 7
        Label2.Text = "Destinatario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 14)
        Label3.TabIndex = 8
        Label3.Text = "Dirección"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 14)
        Label4.TabIndex = 9
        Label4.Text = "Localidad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 14)
        Label5.TabIndex = 10
        Label5.Text = "Provincia"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 14)
        Label6.TabIndex = 11
        Label6.Text = "Código Postal"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(122, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "&Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 14)
        Label7.TabIndex = 14
        Label7.Text = "Cant. de cajas"
        ' 
        ' txtCantCajas
        ' 
        txtCantCajas.Location = New Point(99, 173)
        txtCantCajas.Name = "txtCantCajas"
        txtCantCajas.Size = New Size(33, 22)
        txtCantCajas.TabIndex = 15
        txtCantCajas.Text = "1"
        ' 
        ' ImprimirEtiqueta
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 231)
        Controls.Add(txtCantCajas)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCP)
        Controls.Add(txtProvincia)
        Controls.Add(txtLocalidad)
        Controls.Add(txtDireccion)
        Controls.Add(txtDestinatario)
        Controls.Add(ComboBox1)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ImprimirEtiqueta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Imprimir etiqueta de envío"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtDestinatario As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCantCajas As TextBox
End Class
