Imports MySql.Data.MySqlClient
Public Class FormGuardarSerie
    Private Sub ButtonGuardarSerie_Click(sender As Object, e As EventArgs) Handles ButtonGuardarSerie.Click
        Dim MsqlCmd As New MySqlCommand
        Dim ParamDeclared As Boolean = False
        Dim MsqlCmdResult As String = ""

        'Declaración de Cadenas Query que se le pasa por parámetro al MySQLCommand para su ejecución
        Dim InsertQueryCodes As String = "INSERT INTO pruebas.rafflerdb (id_numero_rifa,random_code,raffler_unique_code,serie_code) VALUES (@numrifa, @rndcode,@rnducode,@idseries)",
        InsertQuerySeries As String = "INSERT INTO pruebas.rafflersaves (id_saved_series,series_name) VALUES (@idseries, @seriesname)",
        VerifExist As String = "SELECT series_name FROM pruebas.rafflersaves WHERE series_name=@seriesname",
        VerifSeriesCode As String = "SELECT id_saved_series FROM pruebas.rafflersaves WHERE id_saved_series=@idseries"
        'Declaración e Inicialización de Variables a utilizar
        Dim SeriesCode As Integer = FormRaffleCodesMaker.Randomizer 'Se crea un nuevo Número aleatorio para el Código de la Serie
        MsqlCmd.Connection = FormRaffleCodesMaker.dConnection 'Asigno la conexion a MySQLCommand
        Try
            If Not (ParamDeclared) Then
                With MsqlCmd.Parameters 'Adición de Variables Parámetros del MySQL Command
                    .AddWithValue("@idseries", SeriesCode)
                    .AddWithValue("@seriesname", TextBoxGuardarSerie.Text)
                    .AddWithValue("@numrifa", "")
                    .AddWithValue("@rndcode", "")
                    .AddWithValue("@rnducode", "")
                End With
                ParamDeclared = True
            End If

            'Verifico si el nombre de serie introducido ya existe
            MsqlCmd.CommandText = VerifExist
            FormRaffleCodesMaker.dConnection.Open() 'Abro la Conexión a la Base de Datos para guadrar el contenido del arrelgo en ella
            MsqlCmd.Prepare()

            MsqlCmdResult = CStr(MsqlCmd.ExecuteScalar)
            If Not (MsqlCmdResult = Nothing) Then
                ErrorProviderGuardarSerie.SetError(ButtonGuardarSerie, "El Nombre de Serie introducido ya existe en otra serie, por favor ingrese un nombre diferente.")
                TextBoxGuardarSerie.Clear()
                TextBoxGuardarSerie.Focus()
                MsqlCmd.Dispose()
                ParamDeclared = False
            Else
                ErrorProviderGuardarSerie.SetError(ButtonGuardarSerie, "")
                FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Guardando Serie..."
                FormRaffleCodesMaker.Progress(FormRaffleCodesMaker.Randnum.GetUpperBound(0) - 1)

                'Verifico si el Código de Serie Generado ya existe para no repetirlo
                MsqlCmd.CommandText = VerifSeriesCode
                MsqlCmdResult = CStr(MsqlCmd.ExecuteScalar)

                'Si el código de serie ya existe, este bloque va a volver a llamar al Método Randomizer para asignar un nuevo número de código aleatorio.
                While Not (MsqlCmdResult = Nothing)
                    SeriesCode = FormRaffleCodesMaker.Randomizer
                End While
                'Establezco la Query para Insertar el Código de Serie y el nombre el la Tabla respectiva
                MsqlCmd.CommandText = InsertQuerySeries
                MsqlCmdResult = CStr(MsqlCmd.ExecuteNonQuery) 'Ejecuto el Comando SQL que me permite grabar el nombre de la Serie y su código en la Tabla correspondiente.

                'Se establece Query para guardar los códigos
                MsqlCmd.CommandText = InsertQueryCodes
                'Bloque For que Inserta fila por fila o registro por registro el contenido del Array RandNum en la Base de Datos, recorriendo el número de Rifas
                For saveIndex As Integer = 0 To CInt(FormRaffleCodesMaker.Randnum.GetUpperBound(0)) - 1
                    With MsqlCmd
                        .Parameters("@numrifa").Value = FormRaffleCodesMaker.Randnum(saveIndex, 0)
                        .Parameters("@rndcode").Value = FormRaffleCodesMaker.Randnum(saveIndex, 1)
                        .Parameters("@rnducode").Value = FormRaffleCodesMaker.Randnum(saveIndex, 2)
                    End With
                    MsqlCmdResult = CStr(MsqlCmd.ExecuteNonQuery)
                    FormRaffleCodesMaker.Progress() 'Método que muestra el progreso en la Barra Global

                    If (CInt(MsqlCmdResult) = 0) Then
                        FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Error al Guardar"
                        MsgBox("Hubo un Problema al Guardar, consulte con el Administrador.", vbCritical + vbOKOnly, "Error al Guardar")
                        FormRaffleCodesMaker.Cursor = Cursors.Default
                        FormRaffleCodesMaker.UseWaitCursor = False
                        FormPorLote.Cursor = Cursors.Default
                        FormPorLote.UseWaitCursor = False
                        FormRaffleCodesMaker.TimerProgressBarGlobal.Enabled = True
                        FormRaffleCodesMaker.TimerSCTemp.Enabled = True
                        Exit For
                        Me.Close()
                    End If
                Next

            If (CInt(MsqlCmdResult) > 0) Then
                FormRaffleCodesMaker.GuardarSerieToolStripMenuItem.Enabled = False
                FormSave.ButtonSaveSeries.Enabled = False
                FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Serie Guardada"
                FormRaffleCodesMaker.SavedAlready = True
                FormPorLote.LabelSeriesName.Text = TextBoxGuardarSerie.Text
                FormPorLote.LabelSeriesCode.Text = SeriesCode
                TextBoxGuardarSerie.Clear()
                MsgBox("Se ha Guardado la Serie", vbInformation + vbOKOnly, "Guardado")
                FormRaffleCodesMaker.Cursor = Cursors.Default
                FormRaffleCodesMaker.UseWaitCursor = False
                FormPorLote.Cursor = Cursors.Default
                FormPorLote.UseWaitCursor = False
                FormRaffleCodesMaker.TimerProgressBarGlobal.Enabled = True
                FormRaffleCodesMaker.TimerSCTemp.Enabled = True
                Me.Close()
            End If
        End If
        Catch exMSql As MySqlException
        Select Case exMSql.Number
            Case 0
                MessageBox.Show("Imposible conectar con el Servidor. Contacte al Administrator.")
            Case 1045
                MessageBox.Show("Nombre de Usuario o Contraseña Invalidos, por favor vuelva a intentarlo.")
            Case Else
                MsgBox("Hubo un Error, Imposible establecer la Conexión: " + vbNewLine + exMSql.Message)
        End Select
        Finally
            FormRaffleCodesMaker.dConnection.Close()
        End Try
    End Sub

    Private Sub ButtonCancelGS_Click(sender As Object, e As EventArgs) Handles ButtonCancelGS.Click
        FormRaffleCodesMaker.Cursor = Cursors.Default
        FormRaffleCodesMaker.UseWaitCursor = False
        FormRaffleCodesMaker.ToolStripStatusLabel1.Text = "Listo"
        FormRaffleCodesMaker.Cursor = Cursors.Default
        FormRaffleCodesMaker.UseWaitCursor = False
        FormPorLote.Cursor = Cursors.Default
        FormPorLote.UseWaitCursor = False
        FormRaffleCodesMaker.TimerProgressBarGlobal.Enabled = True
        Me.Dispose()
    End Sub
End Class