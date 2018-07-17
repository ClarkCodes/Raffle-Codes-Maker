Public Class FormStartToGenerate
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Try
            FormRaffleCodesMaker.RandnumResizer()
            FormRaffleCodesMaker.ContentToSave = True
            If (FormSettingInfo.RadioButtonPorLote.Checked) Then 'Se evalua cual de los dos Botones de Opcion esta seleccionado para entonces mostrar el JPanel respectivo con la tabla adecuada.
                FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Generando Códigos..."
                FormPorLote.Show() 'Se muestra el jPanel correspondiente y se oculta este.
                Me.Hide()
                FormRaffleCodesMaker.ButtonNext.Enabled = True
                FormRaffleCodesMaker.ButtonBack.Enabled = False
                FormRaffleCodesMaker.LimitSaveToExit = True
                FormRaffleCodesMaker.GuardarComoToolStripMenuItem.Enabled = True 'Ya que a partir de Aquí empiezan a haber códigos, es decir, datos para manipular, esntonces Se Habilitan los Menús para que puedan seleccionarse.
                FormRaffleCodesMaker.GuardarSerieToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.NuevaSerieDeCódigosToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.ImprimirToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.CopiarToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.SeleccionarTodoToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.ContentToSave = True
                FormRaffleCodesMaker.PorLote()
            ElseIf (FormSettingInfo.RadioButtonUnoAUno.Checked) Then
                FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Generando Códigos..."
                FormRaffleCodesMaker.Progress(FormRaffleCodesMaker.Cantrif)
                ReDim FormRaffleCodesMaker.Randnum(FormRaffleCodesMaker.Cantrif, 3) 'Se Instancia el Arreglo que va a servir de Contenedor para los Códigos;
                FormUnoAUno.Show()
                Me.Hide()
                FormRaffleCodesMaker.ButtonNext.Enabled = False
                FormRaffleCodesMaker.ButtonBack.Enabled = False
                FormRaffleCodesMaker.NuevaSerieDeCódigosToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.CopiarToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.SeleccionarTodoToolStripMenuItem.Enabled = True
                FormRaffleCodesMaker.CountFUAU = 0
                FormRaffleCodesMaker.CountMinus = 0
                FormRaffleCodesMaker.RTT = False
                FormRaffleCodesMaker.LimitSaveToExit = True
                FormRaffleCodesMaker.ContentToSave = True
                FormRaffleCodesMaker.UseWaitCursor = False
                FormRaffleCodesMaker.GuardarComoToolStripMenuItem.ToolTipText = "Necesitas llegar al final de la Serie y presionar el botón Mostrar Todos para ver todos los códigos generados y poder Guardar"
                FormRaffleCodesMaker.UnoAUno()
                FormRaffleCodesMaker.CountFUAU += 1
                FormRaffleCodesMaker.CountMinus = FormRaffleCodesMaker.CountFUAU
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class