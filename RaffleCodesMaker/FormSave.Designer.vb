<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSave
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
        Me.ButtonSaveSeries = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonOpenSavedFolder = New System.Windows.Forms.Button()
        Me.ButtonOpenSavedFile = New System.Windows.Forms.Button()
        Me.ButtonExportExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No olvides Guardar la Lista de Códigos por si no lo has hecho,"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(584, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "es importante."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonSaveSeries
        '
        Me.ButtonSaveSeries.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveSeries.Location = New System.Drawing.Point(179, 80)
        Me.ButtonSaveSeries.Name = "ButtonSaveSeries"
        Me.ButtonSaveSeries.Size = New System.Drawing.Size(226, 44)
        Me.ButtonSaveSeries.TabIndex = 0
        Me.ButtonSaveSeries.Text = "Guardar..."
        Me.ButtonSaveSeries.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(484, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ps.: Si ya guardaste anteriormente puedes saltarte este paso, pero siempre asegúr" &
    "ate."
        '
        'ButtonOpenSavedFolder
        '
        Me.ButtonOpenSavedFolder.Enabled = False
        Me.ButtonOpenSavedFolder.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenSavedFolder.Location = New System.Drawing.Point(411, 142)
        Me.ButtonOpenSavedFolder.Name = "ButtonOpenSavedFolder"
        Me.ButtonOpenSavedFolder.Size = New System.Drawing.Size(161, 23)
        Me.ButtonOpenSavedFolder.TabIndex = 4
        Me.ButtonOpenSavedFolder.Text = "Abrir Ubicación de Guardado"
        Me.ButtonOpenSavedFolder.UseVisualStyleBackColor = True
        '
        'ButtonOpenSavedFile
        '
        Me.ButtonOpenSavedFile.Enabled = False
        Me.ButtonOpenSavedFile.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenSavedFile.Location = New System.Drawing.Point(12, 142)
        Me.ButtonOpenSavedFile.Name = "ButtonOpenSavedFile"
        Me.ButtonOpenSavedFile.Size = New System.Drawing.Size(161, 23)
        Me.ButtonOpenSavedFile.TabIndex = 5
        Me.ButtonOpenSavedFile.Text = "Abrir Archivo Guardado"
        Me.ButtonOpenSavedFile.UseVisualStyleBackColor = True
        '
        'ButtonExportExcel
        '
        Me.ButtonExportExcel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportExcel.Location = New System.Drawing.Point(179, 130)
        Me.ButtonExportExcel.Name = "ButtonExportExcel"
        Me.ButtonExportExcel.Size = New System.Drawing.Size(226, 44)
        Me.ButtonExportExcel.TabIndex = 6
        Me.ButtonExportExcel.Text = "Exportar como Excel"
        Me.ButtonExportExcel.UseVisualStyleBackColor = True
        '
        'FormSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 220)
        Me.Controls.Add(Me.ButtonExportExcel)
        Me.Controls.Add(Me.ButtonOpenSavedFile)
        Me.Controls.Add(Me.ButtonOpenSavedFolder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonSaveSeries)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSave"
        Me.Text = "FormSave"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonSaveSeries As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonOpenSavedFolder As Button
    Friend WithEvents ButtonOpenSavedFile As Button
    Friend WithEvents ButtonExportExcel As Button
End Class
