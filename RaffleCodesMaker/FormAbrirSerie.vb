Imports MySql.Data.MySqlClient
Public Class FormAbrirSerie
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Listo"
        'BS1SuspendSVerifier()
        Me.Dispose()
    End Sub

    Private Sub ButtonAbrir_Click(sender As Object, e As EventArgs) Handles ButtonAbrir.Click
        Dim HeaderT As String = ""
        Try
            If (DataGridViewOpen.CurrentRow IsNot Nothing) Then
                'FormRaffleCodesMaker.BindingSource1.SuspendBinding()

                Dim recIndex As String = DataGridViewOpen.CurrentRow.Cells(0).Value.ToString 'Agarra el contenido de la celda del Código de Serie del registro seleccionado en el DataGridView para luego Abrir esa serie.
                FormPorLote.LabelSeriesCode.Text = DataGridViewOpen.CurrentRow.Cells(0).Value.ToString
                FormPorLote.LabelSeriesName.Text = DataGridViewOpen.CurrentRow.Cells(1).Value.ToString
                Dim Query As String = "SELECT id_numero_rifa, random_code, raffler_unique_code FROM pruebas.rafflerdb WHERE serie_code='" + recIndex + "'", Table As String = "openCodes"
                FormRaffleCodesMaker.dDataSet.Reset()
                FormRaffleCodesMaker.DataProvider(Query, Table)
                'BS1SuspendSVerifier()
                FormRaffleCodesMaker.BindingSource1.DataSource = FormRaffleCodesMaker.dDataSet.Tables(Table)
                FormRaffleCodesMaker.BindingSource1.Sort = "id_numero_rifa"
                FormPorLote.DataGridViewCodigoPorLote.DataSource = FormRaffleCodesMaker.BindingSource1
                FormPorLote.DataGridViewCodigoPorLote.Columns.Item(0).HeaderText = "Número de Rifa"
                FormPorLote.DataGridViewCodigoPorLote.Columns.Item(1).HeaderText = "Número Aleatorio"
                FormPorLote.DataGridViewCodigoPorLote.Columns.Item(2).HeaderText = "Código Único de Rifa"

                'Acciones Globales que deben suceder al presionar este botón.
                With FormRaffleCodesMaker
                    .FileOpened = True
                    .ButtonNext.Enabled = True
                    .ButtonBack.Enabled = False
                    .GuardarComoToolStripMenuItem.Enabled = True 'Ya que a partir de Aquí empiezan a haber códigos, es decir, datos para manipular, esntonces Se Habilitan los Menús para que puedan seleccionarse.
                    .GuardarSerieToolStripMenuItem.Enabled = False
                    .NuevaSerieDeCódigosToolStripMenuItem.Enabled = True
                    .ImprimirToolStripMenuItem.Enabled = True
                    .CopiarToolStripMenuItem.Enabled = True
                    .SeleccionarTodoToolStripMenuItem.Enabled = True
                    .ToolStripStatusLabel1.Text = "Listo"
                    .ContentToSave = False
                    .SavedAlready = True
                End With
                FormSave.ButtonSaveSeries.Enabled = False

                'Oculto los Formularios que se encuentres Visibles y muestro el FormPorLote donde se van a cargar los códigos
                If (FormWelcome.Visible) Then
                    FormPorLote.Show()
                    FormWelcome.Hide()
                ElseIf (FormSettingInfo.Visible) Then
                    FormPorLote.Show()
                    FormSettingInfo.Hide()
                ElseIf (FormStartToGenerate.Visible) Then
                    FormPorLote.Show()
                    FormStartToGenerate.Hide()
                ElseIf (FormUnoAUno.Visible) Then
                    FormPorLote.Show()
                    FormUnoAUno.Hide()
                ElseIf (FormSave.Visible) Then
                    FormPorLote.Show()
                    FormSave.Hide()
                ElseIf (FormCompleted.Visible) Then
                    FormPorLote.Show()
                    FormCompleted.Hide()
                End If
                Me.Dispose()
            Else
                ErrorProviderOpenS.SetError(ButtonAbrir, "Para poder Abrir una Serie debe seleccionarla antes de la Lista")
            End If
        Catch ex As Exception
            ErrorProviderOpenS.SetError(ButtonAbrir, "Error" + vbNewLine + ex.Message)
        End Try
    End Sub

    Private Sub FormAbrirSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim openSeriesQuery As String = "SELECT * FROM pruebas.rafflersaves", Table As String = "Series"
        DataProviderOpen(openSeriesQuery, Table)
        If (dDataSetOpenSeries.Tables(Table).Rows.Count <> 0) Then
            DataGridViewOpen.DataSource = BindingSourceOpen
            BindingSourceOpen.DataSource = dDataSetOpenSeries.Tables(Table)
            DataGridViewOpen.Columns.Item(0).HeaderText = "Código de Serie"
            DataGridViewOpen.Columns.Item(1).HeaderText = "Nombre de Serie"
        Else
            LabelNoSeriesSaved.Visible = True
            ButtonAbrir.Enabled = False
        End If
        TextBoxOpen.Focus()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Try
            If (TextBoxOpen.Text.Equals("")) Then
                BindingSourceOpen.RemoveFilter()
                ErrorProviderOpenS.SetError(ButtonAbrir, "")
            Else
                If (RadioButtonByName.Checked) Then
                    BindingSourceOpen.Filter = "series_name='" & TextBoxOpen.Text & "'"
                ElseIf (RadioButtonByCode.Checked) Then
                    BindingSourceOpen.Filter = "id_saved_series='" & TextBoxOpen.Text & "'"
                End If
            End If
        Catch ex As System.Data.EvaluateException
            ErrorProviderOpenS.SetError(ButtonAbrir, "Tipo de Dato Incorrecto, por favor asegurese de que el criterio de Búsqueda coincide con el texto que se está introduciendo" + vbNewLine + ex.Message)
            TextBoxOpen.Clear()
            TextBoxOpen.Focus()
        End Try
    End Sub

    Private Sub FormAbrirSerie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BS1SuspendSVerifier()
    End Sub
    Private Sub BS1SuspendSVerifier()
        If (FormRaffleCodesMaker.BindingSource1.IsBindingSuspended) Then
            FormRaffleCodesMaker.BindingSource1.ResumeBinding()
        End If
    End Sub
    Private Sub DataProviderOpen(sqlSearcherOpenSeries As String, Table As String)
        Dim dDataAdapteropen As MySqlDataAdapter
        Try
            FormRaffleCodesMaker.dConnection.Open()
            dDataAdapteropen = New MySqlDataAdapter(sqlSearcherOpenSeries, FormRaffleCodesMaker.dConnection)
            dDataAdapteropen.Fill(dDataSetOpenSeries, Table)
        Catch exMSql As MySqlException
            Select Case exMSql.Number
                Case 0
                    MessageBox.Show("Imposible conectar con el Servidor. Contacte al Administrator.")
                Case 1045
                    MessageBox.Show("Nombre de Usuario o Contraseña Invalidos, por favor vuelva a intentarlo.")
                Case Else
                    MsgBox("Imposible establecer la Conexión: " + vbNewLine + exMSql.Message)
            End Select
        Finally
            FormRaffleCodesMaker.dConnection.Close()
        End Try
    End Sub
End Class