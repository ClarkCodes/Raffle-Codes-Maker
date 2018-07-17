<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettingInfo
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
        Me.GroupBoxParametros = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxNumRif = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxCantRif = New System.Windows.Forms.MaskedTextBox()
        Me.CheckBoxTCIP = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxMetodoGeneracion = New System.Windows.Forms.GroupBox()
        Me.RadioButtonUnoAUno = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPorLote = New System.Windows.Forms.RadioButton()
        Me.ErrorProviderST = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBoxParametros.SuspendLayout()
        Me.GroupBoxMetodoGeneracion.SuspendLayout()
        CType(Me.ErrorProviderST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxParametros
        '
        Me.GroupBoxParametros.Controls.Add(Me.MaskedTextBoxNumRif)
        Me.GroupBoxParametros.Controls.Add(Me.MaskedTextBoxCantRif)
        Me.GroupBoxParametros.Controls.Add(Me.CheckBoxTCIP)
        Me.GroupBoxParametros.Controls.Add(Me.Label2)
        Me.GroupBoxParametros.Controls.Add(Me.Label1)
        Me.GroupBoxParametros.Controls.Add(Me.Label3)
        Me.GroupBoxParametros.Controls.Add(Me.Label4)
        Me.GroupBoxParametros.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxParametros.Location = New System.Drawing.Point(11, 70)
        Me.GroupBoxParametros.Name = "GroupBoxParametros"
        Me.GroupBoxParametros.Size = New System.Drawing.Size(560, 138)
        Me.GroupBoxParametros.TabIndex = 3
        Me.GroupBoxParametros.TabStop = False
        Me.GroupBoxParametros.Text = "Parámetros"
        '
        'MaskedTextBoxNumRif
        '
        Me.MaskedTextBoxNumRif.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxNumRif.Location = New System.Drawing.Point(228, 60)
        Me.MaskedTextBoxNumRif.Mask = "999 999"
        Me.MaskedTextBoxNumRif.Name = "MaskedTextBoxNumRif"
        Me.MaskedTextBoxNumRif.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxNumRif.Size = New System.Drawing.Size(61, 25)
        Me.MaskedTextBoxNumRif.TabIndex = 3
        Me.MaskedTextBoxNumRif.Tag = "Número en que desea que se empiece, pueden entre 1 y 999 999"
        Me.MaskedTextBoxNumRif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBoxNumRif.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'MaskedTextBoxCantRif
        '
        Me.MaskedTextBoxCantRif.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxCantRif.Location = New System.Drawing.Point(135, 24)
        Me.MaskedTextBoxCantRif.Mask = "999 999"
        Me.MaskedTextBoxCantRif.Name = "MaskedTextBoxCantRif"
        Me.MaskedTextBoxCantRif.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxCantRif.Size = New System.Drawing.Size(61, 25)
        Me.MaskedTextBoxCantRif.TabIndex = 2
        Me.MaskedTextBoxCantRif.Tag = "Cantidad de Rifas necesarias, pueden entre 1 y 999 999"
        Me.MaskedTextBoxCantRif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBoxCantRif.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'CheckBoxTCIP
        '
        Me.CheckBoxTCIP.AutoSize = True
        Me.CheckBoxTCIP.Checked = True
        Me.CheckBoxTCIP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTCIP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTCIP.Location = New System.Drawing.Point(9, 97)
        Me.CheckBoxTCIP.Name = "CheckBoxTCIP"
        Me.CheckBoxTCIP.Size = New System.Drawing.Size(341, 21)
        Me.CheckBoxTCIP.TabIndex = 4
        Me.CheckBoxTCIP.Text = "Combinar Código con las Fecha Actual utilizando TCIP"
        Me.CheckBoxTCIP.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número en que comienza la serie:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de Rifas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "*"
        '
        'GroupBoxMetodoGeneracion
        '
        Me.GroupBoxMetodoGeneracion.Controls.Add(Me.RadioButtonUnoAUno)
        Me.GroupBoxMetodoGeneracion.Controls.Add(Me.RadioButtonPorLote)
        Me.GroupBoxMetodoGeneracion.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxMetodoGeneracion.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxMetodoGeneracion.Name = "GroupBoxMetodoGeneracion"
        Me.GroupBoxMetodoGeneracion.Size = New System.Drawing.Size(559, 52)
        Me.GroupBoxMetodoGeneracion.TabIndex = 2
        Me.GroupBoxMetodoGeneracion.TabStop = False
        Me.GroupBoxMetodoGeneracion.Text = "Método de Generación"
        '
        'RadioButtonUnoAUno
        '
        Me.RadioButtonUnoAUno.AutoSize = True
        Me.RadioButtonUnoAUno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonUnoAUno.Location = New System.Drawing.Point(88, 18)
        Me.RadioButtonUnoAUno.Name = "RadioButtonUnoAUno"
        Me.RadioButtonUnoAUno.Size = New System.Drawing.Size(90, 21)
        Me.RadioButtonUnoAUno.TabIndex = 1
        Me.RadioButtonUnoAUno.TabStop = True
        Me.RadioButtonUnoAUno.Text = "Uno A Uno"
        Me.RadioButtonUnoAUno.UseVisualStyleBackColor = True
        '
        'RadioButtonPorLote
        '
        Me.RadioButtonPorLote.AutoSize = True
        Me.RadioButtonPorLote.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPorLote.Location = New System.Drawing.Point(7, 18)
        Me.RadioButtonPorLote.Name = "RadioButtonPorLote"
        Me.RadioButtonPorLote.Size = New System.Drawing.Size(75, 21)
        Me.RadioButtonPorLote.TabIndex = 0
        Me.RadioButtonPorLote.TabStop = True
        Me.RadioButtonPorLote.Text = "Por Lote"
        Me.RadioButtonPorLote.UseVisualStyleBackColor = True
        '
        'ErrorProviderST
        '
        Me.ErrorProviderST.ContainerControl = Me
        '
        'FormSettingInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 220)
        Me.Controls.Add(Me.GroupBoxParametros)
        Me.Controls.Add(Me.GroupBoxMetodoGeneracion)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSettingInfo"
        Me.Text = "FormSettingInfo"
        Me.GroupBoxParametros.ResumeLayout(False)
        Me.GroupBoxParametros.PerformLayout()
        Me.GroupBoxMetodoGeneracion.ResumeLayout(False)
        Me.GroupBoxMetodoGeneracion.PerformLayout()
        CType(Me.ErrorProviderST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxParametros As GroupBox
    Friend WithEvents MaskedTextBoxNumRif As MaskedTextBox
    Friend WithEvents MaskedTextBoxCantRif As MaskedTextBox
    Friend WithEvents CheckBoxTCIP As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxMetodoGeneracion As GroupBox
    Friend WithEvents RadioButtonUnoAUno As RadioButton
    Friend WithEvents RadioButtonPorLote As RadioButton
    Friend WithEvents ErrorProviderST As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
