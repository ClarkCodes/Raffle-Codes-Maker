<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSplash))
        Me.PictureBoxSplash = New System.Windows.Forms.PictureBox()
        Me.TimerSplash = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarSplash = New System.Windows.Forms.ProgressBar()
        Me.TimerSplashComplete = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxSplash
        '
        Me.PictureBoxSplash.Image = CType(resources.GetObject("PictureBoxSplash.Image"), System.Drawing.Image)
        Me.PictureBoxSplash.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxSplash.Name = "PictureBoxSplash"
        Me.PictureBoxSplash.Size = New System.Drawing.Size(300, 300)
        Me.PictureBoxSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxSplash.TabIndex = 0
        Me.PictureBoxSplash.TabStop = False
        '
        'TimerSplash
        '
        Me.TimerSplash.Enabled = True
        Me.TimerSplash.Interval = 500
        '
        'ProgressBarSplash
        '
        Me.ProgressBarSplash.Location = New System.Drawing.Point(19, 258)
        Me.ProgressBarSplash.Name = "ProgressBarSplash"
        Me.ProgressBarSplash.Size = New System.Drawing.Size(262, 23)
        Me.ProgressBarSplash.TabIndex = 1
        '
        'TimerSplashComplete
        '
        '
        'FormSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 300)
        Me.Controls.Add(Me.ProgressBarSplash)
        Me.Controls.Add(Me.PictureBoxSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSplash"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RaffleCodesMakerSplash"
        CType(Me.PictureBoxSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxSplash As PictureBox
    Friend WithEvents TimerSplash As Timer
    Friend WithEvents ProgressBarSplash As ProgressBar
    Friend WithEvents TimerSplashComplete As Timer
End Class
