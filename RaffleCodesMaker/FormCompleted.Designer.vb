<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompleted
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonGNSCNew = New System.Windows.Forms.Button()
        Me.ButtonGPTSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("28 Days Later", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Completado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(584, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Listo!, Ya esta... Códigos Generados con Exito."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(584, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "¿Qué quieres hacer Ahora?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonGNSCNew
        '
        Me.ButtonGNSCNew.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGNSCNew.Location = New System.Drawing.Point(11, 172)
        Me.ButtonGNSCNew.Name = "ButtonGNSCNew"
        Me.ButtonGNSCNew.Size = New System.Drawing.Size(272, 29)
        Me.ButtonGNSCNew.TabIndex = 3
        Me.ButtonGNSCNew.Text = "Generar Nueva Serie de Códigos"
        Me.ButtonGNSCNew.UseVisualStyleBackColor = True
        '
        'ButtonGPTSalir
        '
        Me.ButtonGPTSalir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGPTSalir.Location = New System.Drawing.Point(300, 172)
        Me.ButtonGPTSalir.Name = "ButtonGPTSalir"
        Me.ButtonGPTSalir.Size = New System.Drawing.Size(272, 29)
        Me.ButtonGPTSalir.TabIndex = 4
        Me.ButtonGPTSalir.Text = "Gracias por Todo, Salir"
        Me.ButtonGPTSalir.UseVisualStyleBackColor = True
        '
        'FormCompleted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 220)
        Me.Controls.Add(Me.ButtonGPTSalir)
        Me.Controls.Add(Me.ButtonGNSCNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCompleted"
        Me.Text = "FormCompleted"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonGNSCNew As Button
    Friend WithEvents ButtonGPTSalir As Button
End Class
