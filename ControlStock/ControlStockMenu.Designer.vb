<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlStockMenu
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ControlStockMenu))
        MenuStrip = New MenuStrip()
        InventarioToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem = New ToolStripMenuItem()
        BajaToolStripMenuItem = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        IngresoToolStripMenuItem = New ToolStripMenuItem()
        MenúToolStripMenuItem = New ToolStripMenuItem()
        EnvíoPorCorreoArgentinoToolStripMenuItem = New ToolStripMenuItem()
        VerInventarioToolStripMenuItem = New ToolStripMenuItem()
        EntregaDeMaterialAUsuarioToolStripMenuItem = New ToolStripMenuItem()
        VerÚltimosMovimientosToolStripMenuItem = New ToolStripMenuItem()
        CompletarSLMovimientoExistenteToolStripMenuItem = New ToolStripMenuItem()
        NóminaToolStripMenuItem = New ToolStripMenuItem()
        ActualizarNóminaToolStripMenuItem = New ToolStripMenuItem()
        VerToolStripMenuItem1 = New ToolStripMenuItem()
        ImprimirEtiquetaDeEnvíoToolStripMenuItem = New ToolStripMenuItem()
        DestinoCACsToolStripMenuItem = New ToolStripMenuItem()
        DestinoEdificioCorporativoToolStripMenuItem = New ToolStripMenuItem()
        DestinoDomicilioParticularToolStripMenuItem = New ToolStripMenuItem()
        ToolTip = New ToolTip(components)
        Timer1 = New Timer(components)
        DataGridView1 = New DataGridView()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        MenuStrip.Items.AddRange(New ToolStripItem() {InventarioToolStripMenuItem, MenúToolStripMenuItem, NóminaToolStripMenuItem, ImprimirEtiquetaDeEnvíoToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(737, 24)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' InventarioToolStripMenuItem
        ' 
        InventarioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem, BajaToolStripMenuItem, VerToolStripMenuItem, IngresoToolStripMenuItem})
        InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        InventarioToolStripMenuItem.Size = New Size(72, 20)
        InventarioToolStripMenuItem.Text = "&Materiales"
        ' 
        ' AltaToolStripMenuItem
        ' 
        AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        AltaToolStripMenuItem.Size = New Size(132, 22)
        AltaToolStripMenuItem.Text = "&Alta..."
        ' 
        ' BajaToolStripMenuItem
        ' 
        BajaToolStripMenuItem.Enabled = False
        BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        BajaToolStripMenuItem.Size = New Size(132, 22)
        BajaToolStripMenuItem.Text = "&Baja..."
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.Enabled = False
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(132, 22)
        VerToolStripMenuItem.Text = "&Consulta..."
        ' 
        ' IngresoToolStripMenuItem
        ' 
        IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        IngresoToolStripMenuItem.Size = New Size(132, 22)
        IngresoToolStripMenuItem.Text = "&Ingreso..."
        ' 
        ' MenúToolStripMenuItem
        ' 
        MenúToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EnvíoPorCorreoArgentinoToolStripMenuItem, VerInventarioToolStripMenuItem, EntregaDeMaterialAUsuarioToolStripMenuItem, VerÚltimosMovimientosToolStripMenuItem, CompletarSLMovimientoExistenteToolStripMenuItem})
        MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        MenúToolStripMenuItem.Size = New Size(86, 20)
        MenúToolStripMenuItem.Text = "&Movimientos"
        ' 
        ' EnvíoPorCorreoArgentinoToolStripMenuItem
        ' 
        EnvíoPorCorreoArgentinoToolStripMenuItem.Name = "EnvíoPorCorreoArgentinoToolStripMenuItem"
        EnvíoPorCorreoArgentinoToolStripMenuItem.Size = New Size(280, 22)
        EnvíoPorCorreoArgentinoToolStripMenuItem.Text = "&Salida de materiales..."
        ' 
        ' VerInventarioToolStripMenuItem
        ' 
        VerInventarioToolStripMenuItem.Name = "VerInventarioToolStripMenuItem"
        VerInventarioToolStripMenuItem.Size = New Size(280, 22)
        VerInventarioToolStripMenuItem.Text = "&Movimiento entre edificios..."
        ' 
        ' EntregaDeMaterialAUsuarioToolStripMenuItem
        ' 
        EntregaDeMaterialAUsuarioToolStripMenuItem.Name = "EntregaDeMaterialAUsuarioToolStripMenuItem"
        EntregaDeMaterialAUsuarioToolStripMenuItem.Size = New Size(280, 22)
        EntregaDeMaterialAUsuarioToolStripMenuItem.Text = "E&ntrega de material en sitio..."
        ' 
        ' VerÚltimosMovimientosToolStripMenuItem
        ' 
        VerÚltimosMovimientosToolStripMenuItem.Name = "VerÚltimosMovimientosToolStripMenuItem"
        VerÚltimosMovimientosToolStripMenuItem.Size = New Size(280, 22)
        VerÚltimosMovimientosToolStripMenuItem.Text = "&Ver últimos movimientos..."
        ' 
        ' CompletarSLMovimientoExistenteToolStripMenuItem
        ' 
        CompletarSLMovimientoExistenteToolStripMenuItem.Enabled = False
        CompletarSLMovimientoExistenteToolStripMenuItem.Name = "CompletarSLMovimientoExistenteToolStripMenuItem"
        CompletarSLMovimientoExistenteToolStripMenuItem.Size = New Size(280, 22)
        CompletarSLMovimientoExistenteToolStripMenuItem.Text = "&Completar SL movimiento existente..."
        ' 
        ' NóminaToolStripMenuItem
        ' 
        NóminaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActualizarNóminaToolStripMenuItem, VerToolStripMenuItem1})
        NóminaToolStripMenuItem.Name = "NóminaToolStripMenuItem"
        NóminaToolStripMenuItem.Size = New Size(59, 20)
        NóminaToolStripMenuItem.Text = "&Nómina"
        ' 
        ' ActualizarNóminaToolStripMenuItem
        ' 
        ActualizarNóminaToolStripMenuItem.Name = "ActualizarNóminaToolStripMenuItem"
        ActualizarNóminaToolStripMenuItem.Size = New Size(180, 22)
        ActualizarNóminaToolStripMenuItem.Text = "&Actualizar nómina..."
        ' 
        ' VerToolStripMenuItem1
        ' 
        VerToolStripMenuItem1.Name = "VerToolStripMenuItem1"
        VerToolStripMenuItem1.Size = New Size(180, 22)
        VerToolStripMenuItem1.Text = "&Ver..."
        ' 
        ' ImprimirEtiquetaDeEnvíoToolStripMenuItem
        ' 
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DestinoCACsToolStripMenuItem, DestinoEdificioCorporativoToolStripMenuItem, DestinoDomicilioParticularToolStripMenuItem})
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Name = "ImprimirEtiquetaDeEnvíoToolStripMenuItem"
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Size = New Size(163, 20)
        ImprimirEtiquetaDeEnvíoToolStripMenuItem.Text = "&Imprimir etiqueta de envío"
        ' 
        ' DestinoCACsToolStripMenuItem
        ' 
        DestinoCACsToolStripMenuItem.Enabled = False
        DestinoCACsToolStripMenuItem.Name = "DestinoCACsToolStripMenuItem"
        DestinoCACsToolStripMenuItem.Size = New Size(233, 22)
        DestinoCACsToolStripMenuItem.Text = "Destino &CACs..."
        ' 
        ' DestinoEdificioCorporativoToolStripMenuItem
        ' 
        DestinoEdificioCorporativoToolStripMenuItem.Enabled = False
        DestinoEdificioCorporativoToolStripMenuItem.Name = "DestinoEdificioCorporativoToolStripMenuItem"
        DestinoEdificioCorporativoToolStripMenuItem.Size = New Size(233, 22)
        DestinoEdificioCorporativoToolStripMenuItem.Text = "Destino &Edificio corporativo..."
        ' 
        ' DestinoDomicilioParticularToolStripMenuItem
        ' 
        DestinoDomicilioParticularToolStripMenuItem.Enabled = False
        DestinoDomicilioParticularToolStripMenuItem.Name = "DestinoDomicilioParticularToolStripMenuItem"
        DestinoDomicilioParticularToolStripMenuItem.Size = New Size(233, 22)
        DestinoDomicilioParticularToolStripMenuItem.Text = "Destino &Domicilio particular..."
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 2000
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Enabled = False
        DataGridView1.Location = New Point(12, 42)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(457, 150)
        DataGridView1.TabIndex = 7
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 466)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(737, 22)
        StatusStrip1.TabIndex = 11
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(119, 17)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ControlStockMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(737, 488)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip)
        Controls.Add(DataGridView1)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "ControlStockMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Control de Stock Microinformática"
        WindowState = FormWindowState.Maximized
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvíoPorCorreoArgentinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregaDeMaterialAUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerÚltimosMovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NóminaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IngresoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletarSLMovimientoExistenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirEtiquetaDeEnvíoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinoCACsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinoEdificioCorporativoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinoDomicilioParticularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ActualizarNóminaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
