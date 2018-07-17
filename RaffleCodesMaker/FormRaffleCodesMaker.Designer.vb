<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRaffleCodesMaker
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRaffleCodesMaker))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaSerieDeCódigosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirSerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarSerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VistaPreliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropiedadesDeLaImpresoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.PanelDinamicReceptor = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ProgressBarGlobal = New System.Windows.Forms.ProgressBar()
        Me.TimerProgressBarGlobal = New System.Windows.Forms.Timer(Me.components)
        Me.LabelProgressBarGlobal = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dDataSet = New System.Data.DataSet()
        Me.ErrorProviderRCM = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TimerSCTemp = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderRCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFile, Me.EdiciónToolStripMenuItemEdit, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemFile
        '
        Me.ToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaSerieDeCódigosToolStripMenuItem, Me.ToolStripSeparator1, Me.AbrirSerieToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarSerieToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripSeparator2, Me.VistaPreliminarToolStripMenuItem, Me.PropiedadesDeLaImpresoraToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ToolStripSeparator3, Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile"
        Me.ToolStripMenuItemFile.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItemFile.Text = "&Archivo"
        '
        'NuevaSerieDeCódigosToolStripMenuItem
        '
        Me.NuevaSerieDeCódigosToolStripMenuItem.Enabled = False
        Me.NuevaSerieDeCódigosToolStripMenuItem.Name = "NuevaSerieDeCódigosToolStripMenuItem"
        Me.NuevaSerieDeCódigosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevaSerieDeCódigosToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.NuevaSerieDeCódigosToolStripMenuItem.Text = "&Nueva Serie de Códigos"
        Me.NuevaSerieDeCódigosToolStripMenuItem.ToolTipText = "Configura una Nueva serie de Códigos para generarla"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(239, 6)
        '
        'AbrirSerieToolStripMenuItem
        '
        Me.AbrirSerieToolStripMenuItem.Name = "AbrirSerieToolStripMenuItem"
        Me.AbrirSerieToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirSerieToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AbrirSerieToolStripMenuItem.Text = "Abrir &Serie..."
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir Archiv&o de Excel..."
        Me.AbrirToolStripMenuItem.ToolTipText = "Abre un Archivo de Excel Generado por esta Aplicación unicamente que no haya sido" &
    " alterado"
        '
        'GuardarSerieToolStripMenuItem
        '
        Me.GuardarSerieToolStripMenuItem.Enabled = False
        Me.GuardarSerieToolStripMenuItem.Name = "GuardarSerieToolStripMenuItem"
        Me.GuardarSerieToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarSerieToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.GuardarSerieToolStripMenuItem.Text = "&Guardar Serie"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Enabled = False
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.GuardarComoToolStripMenuItem.Text = "&Exportar como Excel"
        Me.GuardarComoToolStripMenuItem.ToolTipText = "Guarda el documento de Excel generado por la Aplicación al Obtener la Tabla de Có" &
    "digos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(239, 6)
        '
        'VistaPreliminarToolStripMenuItem
        '
        Me.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem"
        Me.VistaPreliminarToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.VistaPreliminarToolStripMenuItem.Text = "Vista Preliminar..."
        '
        'PropiedadesDeLaImpresoraToolStripMenuItem
        '
        Me.PropiedadesDeLaImpresoraToolStripMenuItem.Name = "PropiedadesDeLaImpresoraToolStripMenuItem"
        Me.PropiedadesDeLaImpresoraToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.PropiedadesDeLaImpresoraToolStripMenuItem.Text = "Propiedades de la Impresora"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Enabled = False
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ImprimirToolStripMenuItem.Text = "Im&primir"
        Me.ImprimirToolStripMenuItem.ToolTipText = "Imprime los documentos que se generan al Obtener la Tabla de Códigos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(239, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        Me.SalirToolStripMenuItem.ToolTipText = "Cierra la Aplicación"
        '
        'EdiciónToolStripMenuItemEdit
        '
        Me.EdiciónToolStripMenuItemEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarTodoToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ToolStripSeparator4, Me.PreferenciasToolStripMenuItem})
        Me.EdiciónToolStripMenuItemEdit.Name = "EdiciónToolStripMenuItemEdit"
        Me.EdiciónToolStripMenuItemEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EdiciónToolStripMenuItemEdit.Size = New System.Drawing.Size(58, 20)
        Me.EdiciónToolStripMenuItemEdit.Text = "&Edición"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Enabled = False
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "S&eleccionar Todo"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Enabled = False
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("28 Days Later", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Raffle Codes Maker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "by Clark"
        '
        'ButtonNext
        '
        Me.ButtonNext.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.Location = New System.Drawing.Point(468, 321)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(104, 29)
        Me.ButtonNext.TabIndex = 3
        Me.ButtonNext.Text = "Siguiente"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Enabled = False
        Me.ButtonBack.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.Location = New System.Drawing.Point(358, 321)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(104, 29)
        Me.ButtonBack.TabIndex = 4
        Me.ButtonBack.Text = "Atrás"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'PanelDinamicReceptor
        '
        Me.PanelDinamicReceptor.Location = New System.Drawing.Point(0, 95)
        Me.PanelDinamicReceptor.Name = "PanelDinamicReceptor"
        Me.PanelDinamicReceptor.Size = New System.Drawing.Size(584, 220)
        Me.PanelDinamicReceptor.TabIndex = 5
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.xlsx"
        Me.SaveFileDialog1.FileName = "Codigos Aleatorios Unicos de Rifas"
        Me.SaveFileDialog1.Filter = "Libro de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
        Me.SaveFileDialog1.Title = "Guardar como... - Archivo de Códigos Únicos de Rifas"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ProgressBarGlobal
        '
        Me.ProgressBarGlobal.Location = New System.Drawing.Point(200, 18)
        Me.ProgressBarGlobal.Name = "ProgressBarGlobal"
        Me.ProgressBarGlobal.Size = New System.Drawing.Size(200, 23)
        Me.ProgressBarGlobal.TabIndex = 6
        Me.ProgressBarGlobal.Visible = False
        '
        'TimerProgressBarGlobal
        '
        Me.TimerProgressBarGlobal.Interval = 2000
        '
        'LabelProgressBarGlobal
        '
        Me.LabelProgressBarGlobal.BackColor = System.Drawing.Color.Transparent
        Me.LabelProgressBarGlobal.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProgressBarGlobal.ForeColor = System.Drawing.Color.Indigo
        Me.LabelProgressBarGlobal.Location = New System.Drawing.Point(133, 9)
        Me.LabelProgressBarGlobal.Name = "LabelProgressBarGlobal"
        Me.LabelProgressBarGlobal.Size = New System.Drawing.Size(65, 36)
        Me.LabelProgressBarGlobal.TabIndex = 7
        Me.LabelProgressBarGlobal.Text = "0%"
        Me.LabelProgressBarGlobal.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.LabelProgressBarGlobal.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.xlsx"
        Me.OpenFileDialog1.Filter = "Libro de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Abrir... - Archivo de Códigos Únicos de Rifas"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 352)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(32, 17)
        Me.ToolStripStatusLabel1.Text = "Listo"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'dDataSet
        '
        Me.dDataSet.DataSetName = "NewDataSet"
        '
        'ErrorProviderRCM
        '
        Me.ErrorProviderRCM.ContainerControl = Me
        '
        'TimerSCTemp
        '
        Me.TimerSCTemp.Interval = 3000
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(202, 6)
        '
        'PreferenciasToolStripMenuItem
        '
        Me.PreferenciasToolStripMenuItem.Name = "PreferenciasToolStripMenuItem"
        Me.PreferenciasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.PreferenciasToolStripMenuItem.Text = "&Preferencias"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "A&yuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca &de..."
        '
        'FormRaffleCodesMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 374)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBarGlobal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelDinamicReceptor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LabelProgressBarGlobal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormRaffleCodesMaker"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raffle Codes Maker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderRCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItemFile As ToolStripMenuItem
    Friend WithEvents NuevaSerieDeCódigosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItemEdit As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents PanelDinamicReceptor As Panel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ProgressBarGlobal As ProgressBar
    Friend WithEvents TimerProgressBarGlobal As Timer
    Friend WithEvents LabelProgressBarGlobal As Label
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents VistaPreliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropiedadesDeLaImpresoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirSerieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarSerieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dDataSet As DataSet
    Friend WithEvents ErrorProviderRCM As ErrorProvider
    Friend WithEvents TimerSCTemp As Timer
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PreferenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
End Class
