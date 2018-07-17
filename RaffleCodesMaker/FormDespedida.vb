Public Class FormDespedida

    Private Sub FormDespedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EffectIn()
        TimerDespedida.Enabled = True
    End Sub

    Public Sub EffectIn()
        For Effect As Double = 0.0 To 1.1 Step 0.1
            Me.Opacity = Effect
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next
    End Sub

    Public Sub EffectOut()
        For Effect As Double = 1.1 To 0.0 Step -0.1
            Me.Opacity = Effect
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next
        End
    End Sub

    Private Sub TimerDespedida_Tick(sender As Object, e As EventArgs) Handles TimerDespedida.Tick
        EffectOut()
    End Sub
End Class