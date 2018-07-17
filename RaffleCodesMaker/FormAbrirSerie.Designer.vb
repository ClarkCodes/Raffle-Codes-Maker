<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbrirSerie
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBoxOpen = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelNoSeriesSaved = New System.Windows.Forms.Label()
        Me.DataGridViewOpen = New System.Windows.Forms.DataGridView()
        Me.ButtonAbrir = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonByName = New System.Windows.Forms.RadioButton()
        Me.RadioButtonByCode = New System.Windows.Forms.RadioButton()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ErrorProviderOpenS = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingSourceOpen = New System.Windows.Forms.BindingSource(Me.components)
        Me.dDataSetOpenSeries = New System.Data.DataSet()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderOpenS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dDataSetOpenSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxOpen
        '
        Me.TextBoxOpen.AllowDrop = True
        Me.TextBoxOpen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOpen.Location = New System.Drawing.Point(67, 10)
        Me.TextBoxOpen.Name = "TextBoxOpen"
        Me.TextBoxOpen.Size = New System.Drawing.Size(278, 29)
        Me.TextBoxOpen.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelNoSeriesSaved)
        Me.GroupBox1.Controls.Add(Me.DataGridViewOpen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 253)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LabelNoSeriesSaved
        '
        Me.LabelNoSeriesSaved.AutoSize = True
        Me.LabelNoSeriesSaved.BackColor = System.Drawing.Color.Transparent
        Me.LabelNoSeriesSaved.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNoSeriesSaved.Location = New System.Drawing.Point(133, 128)
        Me.LabelNoSeriesSaved.Name = "LabelNoSeriesSaved"
        Me.LabelNoSeriesSaved.Size = New System.Drawing.Size(197, 20)
        Me.LabelNoSeriesSaved.TabIndex = 1
        Me.LabelNoSeriesSaved.Text = "No Existen Series Guardadas"
        Me.LabelNoSeriesSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelNoSeriesSaved.Visible = False
        '
        'DataGridViewOpen
        '
        Me.DataGridViewOpen.AllowUserToDeleteRows = False
        Me.DataGridViewOpen.AllowUserToResizeColumns = False
        Me.DataGridViewOpen.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewOpen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewOpen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewOpen.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewOpen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewOpen.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewOpen.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewOpen.MultiSelect = False
        Me.DataGridViewOpen.Name = "DataGridViewOpen"
        Me.DataGridViewOpen.ReadOnly = True
        Me.DataGridViewOpen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewOpen.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewOpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewOpen.Size = New System.Drawing.Size(453, 228)
        Me.DataGridViewOpen.TabIndex = 0
        '
        'ButtonAbrir
        '
        Me.ButtonAbrir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbrir.Location = New System.Drawing.Point(216, 297)
        Me.ButtonAbrir.Name = "ButtonAbrir"
        Me.ButtonAbrir.Size = New System.Drawing.Size(127, 37)
        Me.ButtonAbrir.TabIndex = 4
        Me.ButtonAbrir.Text = "Abrir"
        Me.ButtonAbrir.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.Location = New System.Drawing.Point(351, 297)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(127, 37)
        Me.ButtonCancelar.TabIndex = 5
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar:"
        '
        'RadioButtonByName
        '
        Me.RadioButtonByName.AutoSize = True
        Me.RadioButtonByName.Checked = True
        Me.RadioButtonByName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonByName.Location = New System.Drawing.Point(392, 1)
        Me.RadioButtonByName.Name = "RadioButtonByName"
        Me.RadioButtonByName.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonByName.TabIndex = 2
        Me.RadioButtonByName.TabStop = True
        Me.RadioButtonByName.Text = "Por Nombre"
        Me.RadioButtonByName.UseVisualStyleBackColor = True
        '
        'RadioButtonByCode
        '
        Me.RadioButtonByCode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonByCode.Location = New System.Drawing.Point(392, 24)
        Me.RadioButtonByCode.Name = "RadioButtonByCode"
        Me.RadioButtonByCode.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonByCode.TabIndex = 3
        Me.RadioButtonByCode.TabStop = True
        Me.RadioButtonByCode.Text = "Por Código"
        Me.RadioButtonByCode.UseVisualStyleBackColor = True
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Image = Global.RaffleCodesMaker.My.Resources.Resources.search_find_locate_13934
        Me.ButtonSearch.Location = New System.Drawing.Point(351, 1)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(35, 43)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ErrorProviderOpenS
        '
        Me.ErrorProviderOpenS.ContainerControl = Me
        Me.ErrorProviderOpenS.RightToLeft = True
        '
        'dDataSetOpenSeries
        '
        Me.dDataSetOpenSeries.DataSetName = "NewDataSet"
        '
        'FormAbrirSerie
        '
        Me.AcceptButton = Me.ButtonAbrir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancelar
        Me.ClientSize = New System.Drawing.Size(490, 346)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.RadioButtonByCode)
        Me.Controls.Add(Me.RadioButtonByName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAbrir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBoxOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(506, 384)
        Me.Name = "FormAbrirSerie"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir Serie..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderOpenS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dDataSetOpenSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxOpen As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonAbrir As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents LabelNoSeriesSaved As Label
    Friend WithEvents DataGridViewOpen As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonByName As RadioButton
    Friend WithEvents RadioButtonByCode As RadioButton
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ErrorProviderOpenS As ErrorProvider
    Friend WithEvents BindingSourceOpen As BindingSource
    Friend WithEvents dDataSetOpenSeries As DataSet
End Class
