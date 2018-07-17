<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUnoAUno
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewCodigoUAU = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonCodigoAnterior = New System.Windows.Forms.Button()
        Me.ButtonSiguienteCodigo = New System.Windows.Forms.Button()
        Me.ButtonMostrarTodos = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCodigoUAU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tabla de Códigos:"
        '
        'DataGridViewCodigoUAU
        '
        Me.DataGridViewCodigoUAU.AllowUserToDeleteRows = False
        Me.DataGridViewCodigoUAU.AllowUserToResizeColumns = False
        Me.DataGridViewCodigoUAU.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewCodigoUAU.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCodigoUAU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCodigoUAU.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCodigoUAU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCodigoUAU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridViewCodigoUAU.Location = New System.Drawing.Point(12, 41)
        Me.DataGridViewCodigoUAU.Name = "DataGridViewCodigoUAU"
        Me.DataGridViewCodigoUAU.ReadOnly = True
        Me.DataGridViewCodigoUAU.Size = New System.Drawing.Size(560, 51)
        Me.DataGridViewCodigoUAU.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Número de Rifa"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Código Aleatorio"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Código Único de Rifa"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'ButtonCodigoAnterior
        '
        Me.ButtonCodigoAnterior.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCodigoAnterior.Location = New System.Drawing.Point(12, 108)
        Me.ButtonCodigoAnterior.Name = "ButtonCodigoAnterior"
        Me.ButtonCodigoAnterior.Size = New System.Drawing.Size(178, 33)
        Me.ButtonCodigoAnterior.TabIndex = 3
        Me.ButtonCodigoAnterior.Text = "Código Anterior"
        Me.ButtonCodigoAnterior.UseVisualStyleBackColor = True
        '
        'ButtonSiguienteCodigo
        '
        Me.ButtonSiguienteCodigo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSiguienteCodigo.Location = New System.Drawing.Point(394, 108)
        Me.ButtonSiguienteCodigo.Name = "ButtonSiguienteCodigo"
        Me.ButtonSiguienteCodigo.Size = New System.Drawing.Size(178, 33)
        Me.ButtonSiguienteCodigo.TabIndex = 4
        Me.ButtonSiguienteCodigo.Text = "Siguiente Código"
        Me.ButtonSiguienteCodigo.UseVisualStyleBackColor = True
        '
        'ButtonMostrarTodos
        '
        Me.ButtonMostrarTodos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMostrarTodos.Location = New System.Drawing.Point(111, 155)
        Me.ButtonMostrarTodos.Name = "ButtonMostrarTodos"
        Me.ButtonMostrarTodos.Size = New System.Drawing.Size(355, 49)
        Me.ButtonMostrarTodos.TabIndex = 5
        Me.ButtonMostrarTodos.Text = "Mostrar Todos los Códigos Generados"
        Me.ButtonMostrarTodos.UseVisualStyleBackColor = True
        '
        'FormUnoAUno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 220)
        Me.Controls.Add(Me.ButtonMostrarTodos)
        Me.Controls.Add(Me.ButtonSiguienteCodigo)
        Me.Controls.Add(Me.ButtonCodigoAnterior)
        Me.Controls.Add(Me.DataGridViewCodigoUAU)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUnoAUno"
        Me.Text = "FormUnoAUno"
        CType(Me.DataGridViewCodigoUAU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewCodigoUAU As DataGridView
    Friend WithEvents ButtonCodigoAnterior As Button
    Friend WithEvents ButtonSiguienteCodigo As Button
    Friend WithEvents ButtonMostrarTodos As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
