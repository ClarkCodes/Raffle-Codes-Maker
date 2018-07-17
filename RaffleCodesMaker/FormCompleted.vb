Public Class FormCompleted
    Private Sub ButtonGNSCNew_Click(sender As Object, e As EventArgs) Handles ButtonGNSCNew.Click
        FormRaffleCodesMaker.NuevaSerieDeCódigosToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ButtonGPTSalir_Click(sender As Object, e As EventArgs) Handles ButtonGPTSalir.Click
        FormRaffleCodesMaker.SalirToolStripMenuItem.PerformClick()
    End Sub
End Class