<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoMaterial
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
        Label2 = New Label()
        Label1 = New Label()
        ComboMarcaModelo = New ComboBox()
        ComboDescripcion = New ComboBox()
        Label3 = New Label()
        txtOlleros = New TextBox()
        Label4 = New Label()
        txtMayo = New TextBox()
        Label5 = New Label()
        txtPaseoColon = New TextBox()
        Label6 = New Label()
        txtSabattini = New TextBox()
        BtnAceptar = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 14)
        Label2.TabIndex = 20
        Label2.Text = "Marca y modelo"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 14)
        Label1.TabIndex = 19
        Label1.Text = "Descripción del material"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboMarcaModelo
        ' 
        ComboMarcaModelo.AutoCompleteMode = AutoCompleteMode.Append
        ComboMarcaModelo.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboMarcaModelo.FormattingEnabled = True
        ComboMarcaModelo.Location = New Point(152, 31)
        ComboMarcaModelo.Name = "ComboMarcaModelo"
        ComboMarcaModelo.Size = New Size(309, 22)
        ComboMarcaModelo.TabIndex = 18
        ' 
        ' ComboDescripcion
        ' 
        ComboDescripcion.AutoCompleteMode = AutoCompleteMode.Append
        ComboDescripcion.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboDescripcion.DropDownWidth = 500
        ComboDescripcion.FormattingEnabled = True
        ComboDescripcion.Location = New Point(152, 6)
        ComboDescripcion.Name = "ComboDescripcion"
        ComboDescripcion.Size = New Size(309, 22)
        ComboDescripcion.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(54, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 14)
        Label3.TabIndex = 32
        Label3.Text = "Ingreso Olleros"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtOlleros
        ' 
        txtOlleros.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOlleros.Location = New Point(152, 58)
        txtOlleros.Name = "txtOlleros"
        txtOlleros.Size = New Size(69, 22)
        txtOlleros.TabIndex = 31
        txtOlleros.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(22, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 14)
        Label4.TabIndex = 34
        Label4.Text = "Ingreso Av. de Mayo"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtMayo
        ' 
        txtMayo.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtMayo.Location = New Point(152, 86)
        txtMayo.Name = "txtMayo"
        txtMayo.Size = New Size(69, 22)
        txtMayo.TabIndex = 33
        txtMayo.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(24, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 14)
        Label5.TabIndex = 36
        Label5.Text = "Ingreso Paseo Colón"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtPaseoColon
        ' 
        txtPaseoColon.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPaseoColon.Location = New Point(152, 114)
        txtPaseoColon.Name = "txtPaseoColon"
        txtPaseoColon.Size = New Size(69, 22)
        txtPaseoColon.TabIndex = 35
        txtPaseoColon.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(43, 145)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 14)
        Label6.TabIndex = 38
        Label6.Text = "Ingreso Sabattini"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtSabattini
        ' 
        txtSabattini.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtSabattini.Location = New Point(152, 142)
        txtSabattini.Name = "txtSabattini"
        txtSabattini.Size = New Size(69, 22)
        txtSabattini.TabIndex = 37
        txtSabattini.Text = "0"
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.Location = New Point(202, 183)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(75, 31)
        BtnAceptar.TabIndex = 50
        BtnAceptar.Text = "&Aceptar"
        BtnAceptar.UseVisualStyleBackColor = True
        ' 
        ' IngresoMaterial
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 226)
        Controls.Add(BtnAceptar)
        Controls.Add(Label6)
        Controls.Add(txtSabattini)
        Controls.Add(Label5)
        Controls.Add(txtPaseoColon)
        Controls.Add(Label4)
        Controls.Add(txtMayo)
        Controls.Add(Label3)
        Controls.Add(txtOlleros)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboMarcaModelo)
        Controls.Add(ComboDescripcion)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "IngresoMaterial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ingreso de material"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboMarcaModelo As ComboBox
    Friend WithEvents ComboDescripcion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOlleros As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMayo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPaseoColon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSabattini As TextBox
    Friend WithEvents BtnAceptar As Button
End Class
