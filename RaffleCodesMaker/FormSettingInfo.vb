Imports System.ComponentModel

Public Class FormSettingInfo
    Public IV As Boolean = False
    Public Sub InfoVerifier()
        If ((RadioButtonPorLote.Checked = False) And (RadioButtonUnoAUno.Checked = False)) Then
            ErrorProviderST.SetError(RadioButtonUnoAUno, "Debe escoger una de las dos Opciones Disponibles")
            IV = False
        ElseIf (MaskedTextBoxCantRif.Text().Equals("")) Then
            ErrorProviderST.SetError(MaskedTextBoxCantRif, "Debe llenar los campos obligatorios marcados con *, el valor de este campo solo pueden ser números naturales (Enteros Positivos; en este campo NO se permite el 0)")
            MaskedTextBoxCantRif.Focus()
        ElseIf (MaskedTextBoxNumRif.Text().Equals("")) Then
            ErrorProviderST.SetError(MaskedTextBoxNumRif, "Debe llenar los campos obligatorios marcados con *,  el valor de este campo pueden ser números naturales o 0 (Enteros Positivos; en este campo se permite también el 0)")
            MaskedTextBoxNumRif.Focus()
        Else
            IV = True
        End If
    End Sub

    Private Sub FormSettingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MaskedTextBoxCantRif_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxCantRif.TextChanged
        If (MaskedTextBoxCantRif.Text().Equals("")) Then
            Label3.Font = New Font(Label3.Font, FontStyle.Bold)
        Else
            Label3.Font = New Font(Label3.Font, FontStyle.Regular)
            ErrorProviderST.SetError(MaskedTextBoxCantRif, "")
        End If
    End Sub

    Private Sub MaskedTextBoxNumRif_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxNumRif.TextChanged
        If (MaskedTextBoxNumRif.Text().Equals("")) Then
            Label4.Font = New Font(Label4.Font, FontStyle.Bold)
        Else
            Label4.Font = New Font(Label4.Font, FontStyle.Regular)
            ErrorProviderST.SetError(MaskedTextBoxNumRif, "")
        End If
    End Sub

    Private Sub RadioButtonPorLote_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPorLote.CheckedChanged
        ErrorProviderST.SetError(RadioButtonUnoAUno, "")
    End Sub

    Private Sub RadioButtonUnoAUno_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUnoAUno.CheckedChanged
        ErrorProviderST.SetError(RadioButtonUnoAUno, "")
    End Sub

    Private Sub MaskedTextBoxCantRif_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBoxCantRif.LostFocus
        If (MaskedTextBoxCantRif.Text = 0) Then
            MaskedTextBoxCantRif.Text = ""
            ErrorProviderST.SetError(MaskedTextBoxCantRif, "Debe llenar los campos obligatorios marcados con *, el valor de este campo solo pueden ser números naturales (Enteros Positivos; en este campo NO se permite el 0)")
            MaskedTextBoxCantRif.Focus()
        End If
    End Sub
End Class