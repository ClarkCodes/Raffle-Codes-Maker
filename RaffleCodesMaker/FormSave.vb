Public Class FormSave
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSaveSeries.Click
        FormRaffleCodesMaker.GuardarSerieToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ButtonOpenSavedFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenSavedFile.Click
        Process.Start(FormRaffleCodesMaker.SaveFileDialog1.FileName)
    End Sub

    Private Sub ButtonOpenSavedFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenSavedFolder.Click
        Process.Start(IO.Path.GetDirectoryName(FormRaffleCodesMaker.SaveFileDialog1.FileName))
    End Sub

    Private Sub ButtonExportExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportExcel.Click
        FormRaffleCodesMaker.GuardarComo()
    End Sub
End Class