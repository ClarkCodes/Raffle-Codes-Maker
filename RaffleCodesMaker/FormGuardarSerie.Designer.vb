<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuardarSerie
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
        Me.LabelGuardarSerie = New System.Windows.Forms.Label()
        Me.TextBoxGuardarSerie = New System.Windows.Forms.TextBox()
        Me.ButtonGuardarSerie = New System.Windows.Forms.Button()
        Me.ButtonCancelGS = New System.Windows.Forms.Button()
        Me.ErrorProviderGuardarSerie = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProviderGuardarSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelGuardarSerie
        '
        Me.LabelGuardarSerie.AutoSize = True
        Me.LabelGuardarSerie.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuardarSerie.Location = New System.Drawing.Point(2, 30)
        Me.LabelGuardarSerie.Name = "LabelGuardarSerie"
        Me.LabelGuardarSerie.Size = New System.Drawing.Size(71, 20)
        Me.LabelGuardarSerie.TabIndex = 0
        Me.LabelGuardarSerie.Text = "Nombre: "
        '
        'TextBoxGuardarSerie
        '
        Me.TextBoxGuardarSerie.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGuardarSerie.Location = New System.Drawing.Point(69, 27)
        Me.TextBoxGuardarSerie.Name = "TextBoxGuardarSerie"
        Me.TextBoxGuardarSerie.Size = New System.Drawing.Size(409, 27)
        Me.TextBoxGuardarSerie.TabIndex = 0
        '
        'ButtonGuardarSerie
        '
        Me.ButtonGuardarSerie.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarSerie.Location = New System.Drawing.Point(78, 70)
        Me.ButtonGuardarSerie.Name = "ButtonGuardarSerie"
        Me.ButtonGuardarSerie.Size = New System.Drawing.Size(172, 45)
        Me.ButtonGuardarSerie.TabIndex = 1
        Me.ButtonGuardarSerie.Text = "Guardar"
        Me.ButtonGuardarSerie.UseVisualStyleBackColor = True
        '
        'ButtonCancelGS
        '
        Me.ButtonCancelGS.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelGS.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelGS.Location = New System.Drawing.Point(256, 70)
        Me.ButtonCancelGS.Name = "ButtonCancelGS"
        Me.ButtonCancelGS.Size = New System.Drawing.Size(172, 45)
        Me.ButtonCancelGS.TabIndex = 2
        Me.ButtonCancelGS.Text = "Cancelar"
        Me.ButtonCancelGS.UseVisualStyleBackColor = True
        '
        'ErrorProviderGuardarSerie
        '
        Me.ErrorProviderGuardarSerie.ContainerControl = Me
        Me.ErrorProviderGuardarSerie.RightToLeft = True
        '
        'FormGuardarSerie
        '
        Me.AcceptButton = Me.ButtonGuardarSerie
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancelGS
        Me.ClientSize = New System.Drawing.Size(490, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancelGS)
        Me.Controls.Add(Me.ButtonGuardarSerie)
        Me.Controls.Add(Me.TextBoxGuardarSerie)
        Me.Controls.Add(Me.LabelGuardarSerie)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGuardarSerie"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guardar Serie..."
        CType(Me.ErrorProviderGuardarSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelGuardarSerie As Label
    Friend WithEvents TextBoxGuardarSerie As TextBox
    Friend WithEvents ButtonGuardarSerie As Button
    Friend WithEvents ButtonCancelGS As Button
    Friend WithEvents ErrorProviderGuardarSerie As ErrorProvider
End Class
