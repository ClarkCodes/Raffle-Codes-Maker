Public Class FormUnoAUno
    Private Sub FormUnoAUno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewCodigoUAU.MultiSelect = True
        DataGridViewCodigoUAU.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCodigoUAU.ContextMenuStrip = FormPorLote.ContextMenuStripDGVs
    End Sub

    Private Sub ButtonCodigoAnterior_Click(sender As Object, e As EventArgs) Handles ButtonCodigoAnterior.Click
        ButtonSiguienteCodigo.Enabled = True
        FormRaffleCodesMaker.MinusTester = False
        'Tope Inferior. Valida si el registro actual es el primero del arreglo, cuyo Número de Rifa es igual a Nrif.
        If (FormRaffleCodesMaker.CountMinus = 1) Then
            FormRaffleCodesMaker.CountMinus -= 1
            FormRaffleCodesMaker.UnoAUno()
            ButtonCodigoAnterior.Enabled = False
            'Tope Superior y Parte Central. Valida si el registro actual es el último o si esta en el medio, esencialmente si CountMonus es menor o igual a CountFUAU
        ElseIf (FormRaffleCodesMaker.CountMinus <= formRaffleCodesMaker.CountFUAU And formRaffleCodesMaker.CountMinus > 1) Then
            FormRaffleCodesMaker.CountMinus -= 1
            FormRaffleCodesMaker.UnoAUno()
        End If
    End Sub

    Private Sub ButtonSiguienteCodigo_Click(sender As Object, e As EventArgs) Handles ButtonSiguienteCodigo.Click
        ButtonCodigoAnterior.Enabled = True 'La Codificación del Botón Siguiente consiste en primero habilitar el Botón Atrás porque siempre que se de click en Siguiente habrá al menos un registro anterior al que se pueda regresar.
        'Llegó al Último y Deshabilita. Verifica Si se ha llegado al tope de lo requerido para ya no generar más códigos nuevos y solo moverse entre los existentes.
        If (((FormRaffleCodesMaker.CountFUAU = (FormRaffleCodesMaker.Cantrif - 1)) And (FormRaffleCodesMaker.CountMinus = FormRaffleCodesMaker.Cantrif - 1) And (FormRaffleCodesMaker.RTT = False))) Then 'Se Evalúa Si CountFUAU llegó a la cantidad requeridad, de ser verdadero se setea en Verdadero RTT que indica que ya se ha llegado a la Meta y será el indicador a la vez de que no genere más codigos porque ya se cumplió con lo requerido.
            FormRaffleCodesMaker.MinusTester = False
            FormRaffleCodesMaker.UnoAUno()
            FormRaffleCodesMaker.RTT = True
            ButtonSiguienteCodigo.Enabled = False 'Ademas también se deshabilita el Botón Siguiente indicando que ya no se puede generar más códigos, que ya no se puede avanzar a un siguiente.
            ButtonMostrarTodos.Enabled = True 'También habilita el botón Mostrar todos una vez que se llega, para que se pueda ver todos los códigos de una vez si se desea.
            FormRaffleCodesMaker.GuardarSerieToolStripMenuItem.Enabled = True
            FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Listo"
            FormRaffleCodesMaker.TimerProgressBarGlobal.Enabled = True
        Else
            'Nuevo Código. Verifica si es Igual para Generar el Nuevo Código Aleatorio
            If ((FormRaffleCodesMaker.CountMinus = FormRaffleCodesMaker.CountFUAU) And (FormRaffleCodesMaker.RTT = False)) Then 'Verifica si CountMinus es igual a CountFUAU, o sea, que no se este regresando al ultimo número generado sino que efectivamente se esta en el ultimo generado y se quiere generar uno nuevo
                FormRaffleCodesMaker.MinusTester = False
                FormRaffleCodesMaker.UnoAUno() 'Se invoca el Método UnoAUno, enviandole el parámetro requerido para generar el nuevo código.
                If (FormRaffleCodesMaker.CountFUAU < FormRaffleCodesMaker.Cantrif - 1) Then
                    FormRaffleCodesMaker.CountFUAU += 1
                    FormRaffleCodesMaker.CountMinus = FormRaffleCodesMaker.CountFUAU
                    FormRaffleCodesMaker.Progress()
                End If
                'Regresa. Verifica que la cuenta del numero actual sea menor que por donde se va para regresar e igualarse y seguir con un código nuevo.
            ElseIf (FormRaffleCodesMaker.CountMinus < FormRaffleCodesMaker.CountFUAU) Then 'Verifica si CountMinus es menor que CountFUAU, de ser así significa que se ha presionado el Botón Atrás anteriormente y se esta regresando al último código generado, o sea se esta pretendiendo igualar de a poco con CountFUAU.
                FormRaffleCodesMaker.MinusTester = True 'Entonces se setea MinusTester en Verdadero para indicar que se está regresando.
                FormRaffleCodesMaker.CountMinus += 1
                FormRaffleCodesMaker.UnoAUno()
                If (((FormRaffleCodesMaker.CountFUAU = FormRaffleCodesMaker.Cantrif - 1) And (FormRaffleCodesMaker.CountMinus = FormRaffleCodesMaker.Cantrif - 1) And (FormRaffleCodesMaker.RTT = True))) Then
                    ButtonSiguienteCodigo.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMostrarTodos_Click(sender As Object, e As EventArgs) Handles ButtonMostrarTodos.Click
        FormRaffleCodesMaker.MostrarTodos()
    End Sub
End Class