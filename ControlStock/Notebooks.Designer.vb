<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notebooks
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
        ComboTipo = New ComboBox()
        Label1 = New Label()
        txtSerieAnterior = New TextBox()
        Label2 = New Label()
        ComboModeloAnterior = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        txtLegajo = New TextBox()
        Label5 = New Label()
        txtApellidoNombre = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        Label6 = New Label()
        txtSerieNuevo = New TextBox()
        Label7 = New Label()
        txtModeloNuevo = New TextBox()
        SuspendLayout()
        ' 
        ' ComboTipo
        ' 
        ComboTipo.FormattingEnabled = True
        ComboTipo.Location = New Point(174, 68)
        ComboTipo.Name = "ComboTipo"
        ComboTipo.Size = New Size(188, 22)
        ComboTipo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 14)
        Label1.TabIndex = 2
        Label1.Text = "Tipo de recambio/asignación"
        ' 
        ' txtSerieAnterior
        ' 
        txtSerieAnterior.Location = New Point(174, 127)
        txtSerieAnterior.Name = "txtSerieAnterior"
        txtSerieAnterior.Size = New Size(188, 22)
        txtSerieAnterior.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 14)
        Label2.TabIndex = 4
        Label2.Text = "Modelo anterior"
        ' 
        ' ComboModeloAnterior
        ' 
        ComboModeloAnterior.FormattingEnabled = True
        ComboModeloAnterior.Location = New Point(174, 99)
        ComboModeloAnterior.Name = "ComboModeloAnterior"
        ComboModeloAnterior.Size = New Size(188, 22)
        ComboModeloAnterior.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(88, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 14)
        Label3.TabIndex = 6
        Label3.Text = "Serie anterior"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(125, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 14)
        Label4.TabIndex = 8
        Label4.Text = "Legajo"
        ' 
        ' txtLegajo
        ' 
        txtLegajo.Location = New Point(174, 12)
        txtLegajo.Name = "txtLegajo"
        txtLegajo.ReadOnly = True
        txtLegajo.Size = New Size(188, 22)
        txtLegajo.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 14)
        Label5.TabIndex = 10
        Label5.Text = "Apellido y nombre"
        ' 
        ' txtApellidoNombre
        ' 
        txtApellidoNombre.Location = New Point(174, 40)
        txtApellidoNombre.Name = "txtApellidoNombre"
        txtApellidoNombre.ReadOnly = True
        txtApellidoNombre.Size = New Size(188, 22)
        txtApellidoNombre.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(163, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "&Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(174, 211)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(156, 18)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Se queda con el equipo"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(96, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 14)
        Label6.TabIndex = 16
        Label6.Text = "Serie nuevo"
        ' 
        ' txtSerieNuevo
        ' 
        txtSerieNuevo.Location = New Point(174, 183)
        txtSerieNuevo.Name = "txtSerieNuevo"
        txtSerieNuevo.ReadOnly = True
        txtSerieNuevo.Size = New Size(188, 22)
        txtSerieNuevo.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(84, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 14)
        Label7.TabIndex = 14
        Label7.Text = "Modelo nuevo"
        ' 
        ' txtModeloNuevo
        ' 
        txtModeloNuevo.Location = New Point(174, 155)
        txtModeloNuevo.Name = "txtModeloNuevo"
        txtModeloNuevo.ReadOnly = True
        txtModeloNuevo.Size = New Size(188, 22)
        txtModeloNuevo.TabIndex = 13
        ' 
        ' Notebooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(391, 270)
        Controls.Add(Label6)
        Controls.Add(txtSerieNuevo)
        Controls.Add(Label7)
        Controls.Add(txtModeloNuevo)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(txtApellidoNombre)
        Controls.Add(Label4)
        Controls.Add(txtLegajo)
        Controls.Add(Label3)
        Controls.Add(ComboModeloAnterior)
        Controls.Add(Label2)
        Controls.Add(txtSerieAnterior)
        Controls.Add(Label1)
        Controls.Add(ComboTipo)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Notebooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Asignación/Recambio de notebook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSerieAnterior As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboModeloAnterior As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLegajo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidoNombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSerieNuevo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtModeloNuevo As TextBox
End Class
