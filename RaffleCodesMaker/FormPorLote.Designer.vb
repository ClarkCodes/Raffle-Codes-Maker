<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPorLote
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewCodigoPorLote = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripDGVs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelNameHeader = New System.Windows.Forms.Label()
        Me.LabelSeriesName = New System.Windows.Forms.Label()
        Me.LabelSeriesCodeHeader = New System.Windows.Forms.Label()
        Me.LabelSeriesCode = New System.Windows.Forms.Label()
        CType(Me.DataGridViewCodigoPorLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripDGVs.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tabla de Códigos:"
        '
        'DataGridViewCodigoPorLote
        '
        Me.DataGridViewCodigoPorLote.AllowUserToDeleteRows = False
        Me.DataGridViewCodigoPorLote.AllowUserToResizeColumns = False
        Me.DataGridViewCodigoPorLote.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewCodigoPorLote.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCodigoPorLote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCodigoPorLote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCodigoPorLote.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCodigoPorLote.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCodigoPorLote.ColumnHeadersHeight = 26
        Me.DataGridViewCodigoPorLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewCodigoPorLote.ContextMenuStrip = Me.ContextMenuStripDGVs
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCodigoPorLote.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewCodigoPorLote.Location = New System.Drawing.Point(12, 40)
        Me.DataGridViewCodigoPorLote.Name = "DataGridViewCodigoPorLote"
        Me.DataGridViewCodigoPorLote.ReadOnly = True
        Me.DataGridViewCodigoPorLote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewCodigoPorLote.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCodigoPorLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridViewCodigoPorLote.Size = New System.Drawing.Size(560, 176)
        Me.DataGridViewCodigoPorLote.TabIndex = 1
        '
        'ContextMenuStripDGVs
        '
        Me.ContextMenuStripDGVs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem})
        Me.ContextMenuStripDGVs.Name = "ContextMenuStripDGVs"
        Me.ContextMenuStripDGVs.ShowImageMargin = False
        Me.ContextMenuStripDGVs.Size = New System.Drawing.Size(141, 48)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo"
        '
        'LabelNameHeader
        '
        Me.LabelNameHeader.AutoSize = True
        Me.LabelNameHeader.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNameHeader.Location = New System.Drawing.Point(171, 4)
        Me.LabelNameHeader.Name = "LabelNameHeader"
        Me.LabelNameHeader.Size = New System.Drawing.Size(105, 17)
        Me.LabelNameHeader.TabIndex = 2
        Me.LabelNameHeader.Text = "Nombre de Serie:"
        '
        'LabelSeriesName
        '
        Me.LabelSeriesName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeriesName.Location = New System.Drawing.Point(276, 4)
        Me.LabelSeriesName.Name = "LabelSeriesName"
        Me.LabelSeriesName.Size = New System.Drawing.Size(296, 17)
        Me.LabelSeriesName.TabIndex = 3
        '
        'LabelSeriesCodeHeader
        '
        Me.LabelSeriesCodeHeader.AutoSize = True
        Me.LabelSeriesCodeHeader.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeriesCodeHeader.Location = New System.Drawing.Point(171, 21)
        Me.LabelSeriesCodeHeader.Name = "LabelSeriesCodeHeader"
        Me.LabelSeriesCodeHeader.Size = New System.Drawing.Size(99, 17)
        Me.LabelSeriesCodeHeader.TabIndex = 4
        Me.LabelSeriesCodeHeader.Text = "Código de Serie:"
        '
        'LabelSeriesCode
        '
        Me.LabelSeriesCode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeriesCode.Location = New System.Drawing.Point(276, 21)
        Me.LabelSeriesCode.Name = "LabelSeriesCode"
        Me.LabelSeriesCode.Size = New System.Drawing.Size(296, 17)
        Me.LabelSeriesCode.TabIndex = 5
        '
        'FormPorLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 220)
        Me.Controls.Add(Me.LabelSeriesCode)
        Me.Controls.Add(Me.LabelSeriesCodeHeader)
        Me.Controls.Add(Me.LabelSeriesName)
        Me.Controls.Add(Me.LabelNameHeader)
        Me.Controls.Add(Me.DataGridViewCodigoPorLote)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPorLote"
        Me.Text = "P"
        CType(Me.DataGridViewCodigoPorLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripDGVs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewCodigoPorLote As DataGridView
    Friend WithEvents ContextMenuStripDGVs As ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelNameHeader As Label
    Friend WithEvents LabelSeriesName As Label
    Friend WithEvents LabelSeriesCodeHeader As Label
    Friend WithEvents LabelSeriesCode As Label
End Class
