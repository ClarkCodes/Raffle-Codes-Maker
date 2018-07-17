Public Class FormSplash
    Dim Count As Integer = 0
    Private Sub TimerSplash_Tick(sender As Object, e As EventArgs) Handles TimerSplash.Tick
        Count += 1
        Select Case Count
            Case 1
                ProgressBarSplash.Increment(20)
                Exit Select
            Case 3
                ProgressBarSplash.Increment(60)
                Exit Select
            Case 4
                ProgressBarSplash.Increment(80)
                Exit Select
            Case 5
                ProgressBarSplash.Increment(95)
                TimerSplashComplete.Enabled = True
                TimerSplash.Enabled = False
                Exit Select
            Case Else
                Exit Select
        End Select
    End Sub

    Private Sub TimerSplashComplete_Tick(sender As Object, e As EventArgs) Handles TimerSplashComplete.Tick
        Count += 1
        If Count = 6 Then
            ProgressBarSplash.Increment(100)
            EffectOut()
            FormRaffleCodesMaker.Show()
            Dispose()
        End If
    End Sub

    Private Sub FormSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EffectIn()
    End Sub

    Public Sub EffectIn()
        For Effect As Double = 0.0 To 1.1 Step 0.05
            Me.Opacity = Effect
            Me.Refresh()
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Public Sub EffectOut()
        For Effect As Double = 1.1 To 0.0 Step -0.05
            Me.Opacity = Effect
            Me.Refresh()
            Threading.Thread.Sleep(20)
        Next
    End Sub
End Class
