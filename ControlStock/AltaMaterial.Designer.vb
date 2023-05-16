<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaMaterial
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
        Label8 = New Label()
        txtDescripcion = New TextBox()
        Label1 = New Label()
        txtMarcaModelo = New TextBox()
        Label3 = New Label()
        txtValor = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        txtCodSAP = New TextBox()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 14)
        Label8.TabIndex = 24
        Label8.Text = "Descripción del material"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(152, 6)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(309, 22)
        txtDescripcion.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 14)
        Label1.TabIndex = 26
        Label1.Text = "Marca y modelo"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtMarcaModelo
        ' 
        txtMarcaModelo.Location = New Point(152, 34)
        txtMarcaModelo.Name = "txtMarcaModelo"
        txtMarcaModelo.Size = New Size(309, 22)
        txtMarcaModelo.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(75, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 14)
        Label3.TabIndex = 30
        Label3.Text = "Valor (USD)"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(152, 114)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(106, 22)
        txtValor.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(197, 142)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 31
        Button1.Text = "&Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(152, 90)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(66, 18)
        CheckBox1.TabIndex = 32
        CheckBox1.Text = "&Seriado"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 14)
        Label2.TabIndex = 34
        Label2.Text = "Código SAP"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCodSAP
        ' 
        txtCodSAP.Location = New Point(152, 62)
        txtCodSAP.Name = "txtCodSAP"
        txtCodSAP.Size = New Size(106, 22)
        txtCodSAP.TabIndex = 33
        ' 
        ' AltaInventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 171)
        Controls.Add(Label2)
        Controls.Add(txtCodSAP)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(txtValor)
        Controls.Add(Label1)
        Controls.Add(txtMarcaModelo)
        Controls.Add(Label8)
        Controls.Add(txtDescripcion)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AltaInventario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta de inventario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMarcaModelo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodSAP As TextBox
End Class
