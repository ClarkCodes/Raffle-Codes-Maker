Public Class FormPorLote
    Private Sub FormPorLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        FormRaffleCodesMaker.CopiarToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        FormRaffleCodesMaker.SeleccionarTodoToolStripMenuItem.PerformClick()
    End Sub
End Class