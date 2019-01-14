Option Explicit On
Imports System
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient


Public Class FormRaffleCodesMaker
    Public PBGElements As Double
    Public MinusTester As Boolean, RTT As Boolean, LimitSaveToExit As Boolean = False, SavedAlready As Boolean = False, ContentToSave As Boolean = False, ShowAll As Boolean = False, FileOpened As Boolean = False 'MinusTester es la variable booleana que se hará verdadera al presionar el Botón Atrás dentro del JPanelUnoAUno para mostar el registro anterior y que al llamar al Método UnoAUno que es el que realiza la Mecanica de esta forma de generación, este sepa que debe mostrar el registro anterior, al presionar el Botón Siguiente del JPanelUnoAUno, se vuelve Falsa.
    Public Randnum As String(,) 'Arreglo donde se almacenaran los Códigos Aleatorios y Finales con su respectivos números de Rifas, es decir, aquí se almacenará lo que obtendremos.
    Public Cantrif As Integer, Nrif As Integer, CountFUAU As Integer = 0, CountMinus As Integer, OpenedNumRif As Integer = 0 'CantRif contiene el número de la caja de Texto correspondiente a la Cantidad de Rifas solicitadas, es decir la logitud de la serie que se va a generar; por otro lado Nrif Contiene el número de la caja de Texto correspondiente al número donde se va a iniciar la serie de rifas a generar.
    'CountFUAU es un contador que lleva la cantidad de códigos generados hasta el momento, para que la Aplicación sepa por donde va y no pierda esta cuenta, cuanto llega al maximo de la longitud de la serie, entonces termina la generación de Códigos nuevos; por otro lado CountMinus Servirá para verificar si el registro que se esta mostrando actualmente en el jTable del JPanelUnoAUno es el último generado o se ha presionado el Botón Atrás y después si se quiere regresar al último generado y seguir generando el siguiente hasta terminar. Será igual a CountFUAU hasta presionar el Botón Atras donde ira disminuyendo de uno en uno cada vez que presinemos Atras y se mostrará el registro correspondiente a esta posición en el arreglo, cuando presionemos Siguiente aumentará de uno en uno hasta se igual nuevamente a CoutFUAU y generar el nuevo código, es decir es la que permite que no se genere un nuevo codigo si se va hacia atras y solo navegar entre los códigos ya generados, y así hasta terminar con la serie.
    Public tModel As DataTable() 'Declaración del DefaultTableModel para armar el jTable
    Dim ConnSTR As String = "server=localhost;uid=user;pwd=password;database=pruebas;port=0000"
    Public dConnection As New MySqlConnection(ConnSTR)
    Public dDataAdapter As MySqlDataAdapter

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Saliendo... Cerrando la Aplicación..."
        If ContentToSave = True Then
            Dim Result As MsgBoxResult
            If (SavedAlready = False) Then
                Result = MsgBox("¡Todavía no ha Guardado! Advertencia: Si Sale de la Aplicación sin Guardar los Datos se perderán, ¿Desea Guardar Ahora?", vbYesNoCancel + vbExclamation, "Datos sin Guardar")
                If Result = MsgBoxResult.Yes Then
                    GuardarComo()
                    Exit Sub
                ElseIf Result = MsgBoxResult.No Then
                    EffectOut()
                    FormDespedida.Show()
                End If
            Else
                EffectOut()
                FormDespedida.Show()
            End If
        End If
    End Sub

    Private Sub FormRaffleCodesMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EffectIn()
        FormWelcome.TopLevel = False
        FormSettingInfo.TopLevel = False
        FormStartToGenerate.TopLevel = False
        FormPorLote.TopLevel = False
        FormUnoAUno.TopLevel = False
        FormSave.TopLevel = False
        FormCompleted.TopLevel = False
        Me.PanelDinamicReceptor.Controls.Add(FormWelcome)
        Me.PanelDinamicReceptor.Controls.Add(FormSettingInfo)
        Me.PanelDinamicReceptor.Controls.Add(FormStartToGenerate)
        Me.PanelDinamicReceptor.Controls.Add(FormPorLote)
        Me.PanelDinamicReceptor.Controls.Add(FormUnoAUno)
        Me.PanelDinamicReceptor.Controls.Add(FormSave)
        Me.PanelDinamicReceptor.Controls.Add(FormCompleted)
        FormWelcome.Show()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If (FormWelcome.Visible) Then 'Serie de Bloques If que evaluan que JPanel esta visible en el momento de presionar el Botón Siguiente y deciden cual mostrar después.
            FormSettingInfo.Show()
            FormWelcome.Hide()
            ButtonBack.Enabled = True
            ToolStripStatusLabel1.Text = "Usuario Estableciendo Parámetros, Esperando..."
            FormSettingInfo.MaskedTextBoxCantRif.Focus()
        ElseIf (FormSettingInfo.Visible) Then
            FormUnoAUno.ButtonMostrarTodos.Enabled = False 'En esta parte se llama al método que valida si los datos de SettingInfo necesarios han sido llenados o estan vacios, si estan vacios se pide que se los llene y no se avanza hasta que eso pase.
            FormSettingInfo.InfoVerifier()
            If (FormSettingInfo.IV) Then 'Si los datos han sido llenados la Variable booleana IV será verdadera, de lo contrario será Falsa, si es verdadera entonces avanza al siguiente JPanel, de lo contrario muestra un mensaje de aviso y no avanza.
                Cantrif = CInt(FormSettingInfo.MaskedTextBoxCantRif.Text())
                Nrif = CInt(FormSettingInfo.MaskedTextBoxNumRif.Text())
                FormStartToGenerate.Show()
                FormSettingInfo.Hide()
                ToolStripStatusLabel1.Text = "Listo"
                ButtonNext.Enabled = False 'Si se llega a JPanelStartToGenerate se deshabilita el Botón Siguiente ya que solo se podrá presionar el Botón Start para empezar a generar los códigos o ir hacia atrás.                
            End If
        ElseIf (FormPorLote.Visible) Then
            FormSave.Show()
            FormPorLote.Hide()
            ButtonBack.Enabled = True
            ToolStripStatusLabel1.Text = "Listo"
        ElseIf (FormUnoAUno.Visible) Then
            FormSave.Show()
            FormUnoAUno.Hide()
            ButtonBack.Enabled = True
            ToolStripStatusLabel1.Text = "Listo"
        ElseIf (FormSave.Visible) Then
            FormCompleted.Show()
            FormSave.Hide()
            ButtonNext.Enabled = False
            ToolStripStatusLabel1.Text = "Completado"
        End If
        'Activo los Menus de Copiar y Seleccionar Todo de la Pestaña Edición
        If (FormPorLote.Visible OrElse FormUnoAUno.Visible) Then
            CopiarToolStripMenuItem.Enabled = True
            SeleccionarTodoToolStripMenuItem.Enabled = True
        Else
            CopiarToolStripMenuItem.Enabled = False
            SeleccionarTodoToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        If (FormSettingInfo.Visible) Then 'Al Igual que en el Bloque If del Botón Siguiente, esta serie de instrucciones If deciden cual JPanel mostrar y ocultar em función del que se este mostrando actualmente.
            FormWelcome.Show()
            FormSettingInfo.Hide()
            ButtonBack.Enabled = False
            ToolStripStatusLabel1.Text = "Listo"
        ElseIf (FormStartToGenerate.Visible) Then
            FormSettingInfo.Show()
            FormStartToGenerate.Hide()
            FormSettingInfo.IV = False
            ButtonNext.Enabled = True
            ToolStripStatusLabel1.Text = "Usuario Estableciendo Parámetros, Esperando..."
        ElseIf (FormSave.Visible) Then
            FormPorLote.Show()
            FormSave.Hide()
            ButtonBack.Enabled = False
            ToolStripStatusLabel1.Text = "Listo"
        ElseIf (FormCompleted.Visible) Then
            FormSave.Show()
            FormCompleted.Hide()
            ButtonNext.Enabled = True
            ToolStripStatusLabel1.Text = "Listo"
        End If
        'Activo los Menus de Copiar y Seleccionar Todo de la Pestaña Edición
        If (FormPorLote.Visible OrElse FormUnoAUno.Visible) Then
            CopiarToolStripMenuItem.Enabled = True
            SeleccionarTodoToolStripMenuItem.Enabled = True
        Else
            CopiarToolStripMenuItem.Enabled = False
            SeleccionarTodoToolStripMenuItem.Enabled = False
        End If
    End Sub

    Public Sub PorLote()
        Progress(Cantrif)
        For fan As Integer = 0 To Cantrif - 1 'FillArrayFilas, Bucle For para que se llene el Arreglo con las Filas correspondiente al número de Rifa y los códigos, es donde se llama al Método Motor que va a obtener los códigos y llenar el arreglo con ellos, este es el núcleo del programa
            KernelEngine(fan)
            Progress()
        Next
        ArmarTabla(Cantrif) 'Se llama al Método que Arma la Tabla. Se Llena el jTable con este Bucle For, se llena fila por fila hasta terminar
        For nRow As Integer = 0 To Cantrif - 1 'fan2 se utiliza para recorrer las filas del DataGridViewCodigoPorLote
            For mColumn As Integer = 0 To 2 'fan3 es el incremento de 0 a 2 que se utiliza para recorrer las columnas y llenarlas
                FormPorLote.DataGridViewCodigoPorLote.Item(mColumn, nRow).Value = Randnum(nRow, mColumn)
            Next
        Next
        TimerProgressBarGlobal.Enabled = True
        ToolStripStatusLabel1.Text = "Listo"
    End Sub

    Public Sub UnoAUno() 'Count es un Contador que llega hasta la Cantidad de Rifa, como en UnoAUno no hay un bloque If como en PorLote, se precisa de un contador para que llene la tabla y se sepa por donde va, es decir cual tiene que asignar para llenar el arreglo y luego llenar la tabla
        'Bloque que Generá el Nuevo Código
        If (CountMinus = CountFUAU And RTT = False) Then 'CountMinus es un Contador que normalmente vale lo mismo que CountFUAU, pero que se usa en caso de que se Presione el Boton Atras en JPanelUnoAUno, se presiona el Boton Siguiente y los valores de CountFUAU y CountMinus son iguales significa que se quiere generar el nuevo número aleatorio
            KernelEngine(CountFUAU)
            For UAUColumnIncrementer As Integer = 0 To 2
                FormUnoAUno.DataGridViewCodigoUAU.Item(UAUColumnIncrementer, 0).Value = Randnum(CountFUAU, UAUColumnIncrementer)
            Next
            'Registro Anterior. Se Presiona el Botón Anterior y este es el bloque que le provee.
        ElseIf (CountMinus < CountFUAU And MinusTester = False) Then 'Si se presiona el Boton Atras entonces CountMinus disminuira en uno y será menor que CountFUAU y esto servirá para que muestre el valor una posicion atras en el array, pudiendo el usuario asi navegar por los valores del array hacia adelante y hacia atras
            For UAUColumnIncrementer As Integer = 0 To 2
                FormUnoAUno.DataGridViewCodigoUAU.Item(UAUColumnIncrementer, 0).Value = Randnum(CountMinus, UAUColumnIncrementer)
            Next
        ElseIf (MinusTester) Then 'Regresa y se iguala. Si MinusTester es Verdadero Significa que el valor de Count Minus sigue siendo menor que CountFUAU, pero esta vez se presionó el Botón Siguiente, es decir que se quiere volver donde se quedó el último número generado para generar el siguiente.
            For UAUColumnIncrementer As Integer = 0 To 2
                FormUnoAUno.DataGridViewCodigoUAU.Item(UAUColumnIncrementer, 0).Value = Randnum(CountMinus, UAUColumnIncrementer)
            Next
        End If
    End Sub

    Public Sub KernelEngine(fan As Integer) 'Llamado de esta manera porque este método es el Motor de la App, es el Núcleo de toda la aplicación, Aquí es donde sucede lo más importante, donde se invoca a métodos fundamentales y se génera el Código Único de Rifa, Llamado FinalCode.
        Dim nal As Integer
        Dim dia As String, mes As String, año As String, StrRndCode As String = "", ReadyCode As String = "" 'op1 significa Option1, StrRndCode significa StringRandomCode y hace referencia al código aleatorio convertido en cadena de Texto, Ready Code es el Código con los 0 añadidos si es necesario para que siempre sean 6 digitos es el código aleatorio ya listo para fusionarlo con la fecha, FinalCode es el código aleatorio con la fecha fusionada o sea es ya el Código Único de Rifa Final
        Dim looper As Boolean = True, sfan As Boolean = False
        Dim FechaActual As Date = Now() 'It will Get the System Date Right Now
        dia = FechaActual.ToString("dd")
        mes = FechaActual.ToString("MM")
        año = FechaActual.ToString("yy")
        Do
            ReadyCode = ""
            nal = Randomizer() 'nal: Variable que significa "Número Aleatorio"
            StrRndCode = CStr(nal)
            For zcount As Integer = 0 To (6 - StrRndCode.Length) - 1
                ReadyCode &= "0"
            Next
            ReadyCode &= StrRndCode
            If (Nrif >= 10) Then 'Agrego un cero a la izquierda si el número de Rifa es menor que 10, para que siempre hayan al menos dos digitos.
                Randnum(fan, 0) = CStr(Nrif)
            Else
                Randnum(fan, 0) = "0" + CStr(Nrif)
            End If
            Randnum(fan, 1) = ReadyCode
            For j As Integer = 0 To fan - 1 'Recorro el arreglo buscando en los codigos anteriores si el nuevo no se repite, si ya esta, se genera otro.
                If (Randnum(j, 1).Equals(ReadyCode)) Then
                    sfan = True 'Si se repite, sfan se vuelve verdadera, si no se repite sfan es falsa y sale del bucle.
                    Exit For
                Else
                    sfan = False
                End If
            Next
        Loop Until (sfan = False) 'Si sfan es Verdadera repite de nuevo el proceso para generar otro código.
        If (FormSettingInfo.CheckBoxTCIP.Checked()) Then 'Verifica si CheckBoxTCIP fue seleccionado y efectua la estructura correspondiente para cada caso.
            Randnum(fan, 2) = String.Format("x.{0}{1}{2}{3}{4}{5}", dia, ReadyCode.Substring(0, 2), mes, ReadyCode.Substring(2, 2), año, ReadyCode.Substring(4, 2))
        Else
            Randnum(fan, 2) = String.Format("x.{0}{1}{2}{3}{4}{5}", dia, mes, año, ReadyCode.Substring(0, 2), ReadyCode.Substring(2, 2), ReadyCode.Substring(4, 2))
        End If
        Nrif += 1
    End Sub

    Public Sub ArmarTabla(CantidadRows As Integer) 'CantidadRows es el parámetro que recibe este método que corresponde a CantRif
        If FormPorLote.DataGridViewCodigoPorLote.DisplayedColumnCount(True) = 0 Then 'Valida si el DatagridView no tiene columnas aún y agrega las 3 Principales.
            FormPorLote.DataGridViewCodigoPorLote.Columns.Add("RifNum", "Número de Rifa")
            FormPorLote.DataGridViewCodigoPorLote.Columns.Add("RandomNumber", "Número Aleatorio")
            FormPorLote.DataGridViewCodigoPorLote.Columns.Add("UniqueCode", "Código Único de Rifa")
        End If
        If (FormPorLote.DataGridViewCodigoPorLote.Rows.Count < CantidadRows) Then 'Valida si la cantidad de las filas del DataGridView es menor que CantRif, si es así, añade las filas faltantes para completar dicha cantidad.
            For nRowsDataGridViewAdder As Integer = 0 To (CantidadRows - FormPorLote.DataGridViewCodigoPorLote.Rows.Count) - 1
                FormPorLote.DataGridViewCodigoPorLote.Rows.Add()
            Next
        ElseIf (FormPorLote.DataGridViewCodigoPorLote.Rows.Count > CantidadRows) Then 'Valida si la cantidad de Filas del DataGridView es mayor que CantRif, si es así, elimina las filas sobrantes para solo tener las requeridas.
            For nRowsDataGridViewRemover As Integer = FormPorLote.DataGridViewCodigoPorLote.Rows.Count To CantidadRows + 1 Step -1
                FormPorLote.DataGridViewCodigoPorLote.Rows.RemoveAt(0)
            Next
        End If
    End Sub
    Public Sub MostrarTodos()
        FormPorLote.Visible = True
        FormUnoAUno.Visible = False
        ButtonNext.Enabled = True
        ButtonBack.Enabled = False
        GuardarComoToolStripMenuItem.ToolTipText = "Guarda el documento de Excel generado por la Aplicación al Obtener la Tabla de Códigos"
        GuardarComoToolStripMenuItem.Enabled = True 'Ya que a partir de Aquí empiezan a haber códigos, es decir, datos para manipular, esntonces Se Habilitan los Menús para que puedan seleccionarse.
        ImprimirToolStripMenuItem.Enabled = True
        ToolStripStatusLabel1.Text = "Todos los Códigos Mostrados"
        If (ShowAll = False) Then
            'nRows se utiliza para recorrer las filas del DataGridViewCodigoPorLote
            'mColumns es el incremento de 0 a 2 que se utiliza para recorrer las columnas y llenarlas
            ArmarTabla(Cantrif) 'Se llama al Método que Arma la Tabla. Se Llena el jTable con este Bucle For, se llena fila por fila hasta terminar
            For nRow As Integer = 0 To Cantrif - 1 'fan2 se utiliza para recorrer las filas del DataGridViewCodigoPorLote
                For mColumn As Integer = 0 To 2 'fan3 es el incremento de 0 a 2 que se utiliza para recorrer las columnas y llenarlas
                    FormPorLote.DataGridViewCodigoPorLote.Item(mColumn, nRow).Value = Randnum(nRow, mColumn)
                Next
            Next
            ShowAll = True
        End If
    End Sub

    Public Function Randomizer() As Integer
        Dim rnal As Integer
        Dim Rnd As New Random()
        rnal = Rnd.Next(0, 1000000)
        Return rnal
    End Function

    Public Sub DataProvider(sqlSearcher As String, Table As String)
        Try
            dConnection.Open()
            dDataAdapter = New MySqlDataAdapter(sqlSearcher, dConnection)
            dDataAdapter.Fill(dDataSet, Table)
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
            dConnection.Close()
        End Try
    End Sub

    Private Sub NuevaSerieDeCódigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaSerieDeCódigosToolStripMenuItem.Click
        If (SavedAlready) Then
            NewCodeSerie()
        Else
            Dim op As MsgBoxResult = MsgBox("Va a Iniciar una Nueva Secuencia de Códigos Aleatorios Únicos, ¿Seguro que desea hacerlo Ahora?, No ha guardado todavia, le recomendamos Guardar antes, de lo contrario los Datos se perderán.", vbYesNo + vbQuestion, "Nueva Serie de Códigos")
            Select Case op
                Case MsgBoxResult.No
                    Exit Select
                Case MsgBoxResult.Yes
                    NewCodeSerie()
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End If
    End Sub

    Public Sub NewCodeSerie()
        GuardarSerieToolStripMenuItem.Enabled = True
        FormSave.ButtonSaveSeries.Enabled = True
        ToolStripStatusLabel1.Text = "Nueva Serie de Códigos en Curso"
        ContentToSave = False
        FormSettingInfo.Visible = True 'Aquí se dejará unicamente un JPanelSettingInfo visible, y se ocultan todos los demás, para que se genere una nueva Serie de Códigos.
        FormPorLote.Visible = False
        FormUnoAUno.Visible = False
        FormSave.Visible = False
        FormCompleted.Visible = False
        NuevaSerieDeCódigosToolStripMenuItem.Enabled = False
        GuardarComoToolStripMenuItem.Enabled = False
        GuardarSerieToolStripMenuItem.Enabled = False
        ImprimirToolStripMenuItem.Enabled = False
        SeleccionarTodoToolStripMenuItem.Enabled = False
        CopiarToolStripMenuItem.Enabled = False
        FormUnoAUno.ButtonSiguienteCodigo.Enabled = True
        FormUnoAUno.ButtonCodigoAnterior.Enabled = False
        FormSettingInfo.MaskedTextBoxCantRif.Text = ""
        FormSettingInfo.MaskedTextBoxNumRif.Text = ""
        FormSettingInfo.RadioButtonPorLote.Checked = False
        FormSettingInfo.RadioButtonUnoAUno.Checked = False
        FormSave.ButtonOpenSavedFile.Enabled = False
        FormSave.ButtonOpenSavedFolder.Enabled = False
        ButtonNext.Enabled = True
        ButtonBack.Enabled = True
        FormSave.ButtonSaveSeries.Enabled = True
        CountFUAU = 0
        CountMinus = 0
        MinusTester = False
        RTT = False
        LimitSaveToExit = False
        FormSettingInfo.IV = False
        SavedAlready = False
        ShowAll = False
        FileOpened = False
        FormPorLote.LabelSeriesCode.Text = ""
        FormPorLote.LabelSeriesName.Text = ""
        FormSettingInfo.MaskedTextBoxCantRif.Focus()
        TimerSCTemp.Enabled = True
    End Sub
    Public Sub RandnumResizer()
        ReDim Randnum(Cantrif, 3) 'Se Redimensiona el Arreglo que va a servir de Contenedor para los Códigos con las Nuevas Dimensiones Solicitadas
    End Sub
    Public Sub EffectIn()
        For Effect As Double = 0.0 To 1.1 Step 0.1
            Me.Opacity = Effect
            Me.Refresh()
            Threading.Thread.Sleep(9)
        Next
    End Sub

    Private Sub AbrirSerieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirSerieToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Abriendo Serie Guardada, Espere Por Favor..."
        FormAbrirSerie.ShowDialog()
    End Sub

    Private Sub GuardarSerieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarSerieToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Configurando Parámetros... Establezca el Nombre de la Serie por favor"
        FormGuardarSerie.ShowDialog()
        FormGuardarSerie.TextBoxGuardarSerie.Focus()
    End Sub

    Private Sub TimerSCTemp_Tick(sender As Object, e As EventArgs) Handles TimerSCTemp.Tick
        ToolStripStatusLabel1.Text = "Listo"
        TimerSCTemp.Enabled = False
    End Sub

    Public Sub EffectOut()
        For Effect As Double = 1.1 To 0.0 Step -0.1
            Me.Opacity = Effect
            Me.Refresh()
            Threading.Thread.Sleep(5)
        Next
        Me.Opacity = 0
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        GuardarComo()
    End Sub

    Public Sub GuardarComo()
        Dim Path As String = ""
        Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
        Dim LibroRifa = ExcelApp.Workbooks.Add
        Dim Fila As Integer = 2, Columna As Integer = 2, Number As Integer = 0 'Fila y Columna donde voy a empezar a escribir en el Archivo de Excel

        If (FormSettingInfo.MaskedTextBoxNumRif.Text = "" And FileOpened = True) Then 'Comparación que determina si los códigos provienen de una serie recién generada o una serie deun archivo guardado. 
            Number = OpenedNumRif 'OpenedNumRif es el número en el que empieza la serie de la rifa en el archivo guardado, es el equivalente a NumRif.
        Else
            Number = FormSettingInfo.MaskedTextBoxNumRif.Text
        End If

        Try
            ToolStripStatusLabel1.Text = "Exportando a Excel..."
            SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            'Muestro el Cuadro de Diálogo GuardarComo
            If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
                Progress(16 + ((FormPorLote.DataGridViewCodigoPorLote.Rows.Count - 1) * 3) + ((Cantrif - 1) * 2)) 'Seteo de la Barra de Progreso Global

                'Hoja1 del Libro que despues será llamado Lista de Códigos - Título
                With LibroRifa.Worksheets("Hoja1")
                    .tab.color = 49407 'Cambio el Color del Libro a Naranja en RGB
                    .cells(1, 2) = "Códigos Aleatorios Únicos de Rifas"

                    .cells(1, 2).font.size = 20
                    .cells(1, 2).horizontalalignment = 3
                    .cells(1, 2).columnwidth = 20

                    .Range(LibroRifa.Worksheets("Hoja1").Cells(1, 2), LibroRifa.Worksheets("Hoja1").Cells(1, 4)).Merge
                    .cells(1, 3).columnwidth = 20
                    .cells(1, 4).columnwidth = 20
                End With
                'Libro.Worksheets("Hoja1").Range("B1:D1").merge -> Forma mas facil y directa de hacerlo, pero con celdas constantes y tal vez mas vieja y que se mantiene por compatibilidad, o como parte de VBA a la que tenemos acceso por medio de la referencia de Excel agregada al proyecto necesaria para manejarlo.
                Progress() 'Suma del Progreso

                'Hoja1 - Encabezados
                For ColumnHeaderText As Integer = 0 To 2 'Inserto en el Archivo de Excel a partir de la celda (Fila,Columna) el título encabezado del DataGridViewCodigoPorLote que son los tres encabezados de la tabla y aumento Columna en 1, para insertar en la siguiente celda de Excel el siguiente título que también incrementa.
                    With LibroRifa.Worksheets("Hoja1")
                        .cells(Fila, Columna) = FormPorLote.DataGridViewCodigoPorLote.Columns(ColumnHeaderText).HeaderText
                        .cells(Fila, Columna).font.bold = True
                        .cells(Fila, Columna).horizontalalignment = 3
                    End With
                    Columna += 1
                    Progress()
                Next

                'Bucles For para recorrer el Arreglo Randnum e insertar su contenido en el Archivo de Excel.
                'Hoja1 - Contenido
                Fila = 3
                For nFila As Integer = 0 To FormPorLote.DataGridViewCodigoPorLote.Rows.Count - 1
                    Columna = 2
                    For nColumna As Integer = 0 To 2
                        LibroRifa.Worksheets("Hoja1").cells(Fila, Columna) = FormPorLote.DataGridViewCodigoPorLote(nColumna, nFila).Value
                        With LibroRifa.Worksheets("Hoja1").cells(Fila, Columna)
                            .horizontalalignment = 3
                            .verticalalignment = 3
                            .font.size = 12
                        End With
                        Columna += 1
                        Progress()
                    Next
                    Fila += 1
                Next

                'Hoja1: Escribo el Pie de Firma de la Aplicación dos celdas después de los códigos
                Fila += 1
                With LibroRifa.Worksheets("Hoja1")
                    .cells(Fila, 3) = "Raffle Codes Maker"
                    .cells(Fila, 3).font.name = "28 Days Later"
                    .cells(Fila, 3).font.size = 14
                    .Range(LibroRifa.Worksheets("Hoja1").Cells(Fila, 2), LibroRifa.Worksheets("Hoja1").Cells(Fila, 4)).Merge
                End With
                Fila += 1
                LibroRifa.Worksheets("Hoja1").cells(Fila, 3) = "by Clark"
                LibroRifa.Worksheets("Hoja1").cells(Fila, 3).font.size = 8
                Fila += 1
                LibroRifa.Worksheets("Hoja1").cells(Fila, 3) = "Guayaquil - Ecuador"
                LibroRifa.Worksheets("Hoja1").cells(Fila, 3).font.bold = True
                Fila += 1
                LibroRifa.Worksheets("Hoja1").cells(Fila, 3) = "2017"
                For Counter As Integer = Fila - 3 To Fila 'Centro Horizontalmente todas las celdas del Pie de Firma
                    LibroRifa.Worksheets("Hoja1").cells(Counter, 3).horizontalalignment = 3
                Next
                LibroRifa.Worksheets("Hoja1").name = "Lista de Códigos" 'Cambio el Nombre del Libro a Lista de Códigos.
                Progress()

                'Hoja 2 del Libro que después será llamdo Participantes
                'Encabezado
                LibroRifa.Worksheets.Add() 'Elimina la Hoja3 del Libro ya que no se la ocupa
                With LibroRifa.Worksheets("Hoja2")
                    .tab.color = "6299648" 'Cambio el Color del Libro a Azul Oscuro en RGB 
                    .cells(1, 1) = "Gran Rifa: Tu Guitarra"
                    .cells(1, 1).font.size = 30
                    .cells(1, 1).horizontalalignment = 3
                    .cells(1, 1).columnwidth = 16
                    .Range(LibroRifa.Worksheets("Hoja2").Cells(1, 1), LibroRifa.Worksheets("Hoja2").cells(1, 3)).Merge
                    .cells(1, 2).columnwidth = 55
                    .cells(1, 3).columnwidth = 30

                    .cells(2, 1) = "Participantes"
                    .cells(2, 1).font.size = 18
                    .cells(2, 1).font.name = "Segoe UI Light"
                    .cells(2, 1).horizontalalignment = 3
                    .Range(LibroRifa.Worksheets("Hoja2").cells(2, 1), LibroRifa.Worksheets("Hoja2").cells(2, 3)).Merge

                    'Hoja2 - Column Headers
                    .cells(3, 1) = "Número de Rifa Tomado"
                    .cells(3, 2) = "Apellidos y Nombres Completos"
                    .cells(3, 3) = "Firma"
                End With
                Progress()

                For Formatting As Integer = 1 To 3 'Doy formato a las celdas del encabezado de la tabla
                    With LibroRifa.Worksheets("Hoja2").cells(3, Formatting)
                        .font.size = 11
                        .font.bold = True
                        .horizontalalignment = 3
                        .verticalalignment = 2
                        .wraptext = True
                    End With
                    Progress()
                Next
                LibroRifa.Worksheets("Hoja2").cells(3, 1).rowheight = 32

                'Hoja2 - Contenido
                For Numbers As Integer = 4 To Cantrif + 3
                    LibroRifa.Worksheets("Hoja2").cells(Numbers, 1) = Number
                    Number += 1
                    Progress()
                Next
                For FormattingRows As Integer = 4 To Cantrif + 3 'Recorro las celdas del contenido de la tabla dandoles formato
                    With LibroRifa.Worksheets("Hoja2").cells(FormattingRows, 1)
                        .font.bold = True
                        .rowheight = 35
                        .horizontalalignment = 3
                        .verticalalignment = 2
                    End With
                    Progress()
                Next

                'Hoja2: Escribo el Pie de Firma de la Aplicación dos celdas después de la tabla
                Fila = 5 + Cantrif
                With LibroRifa.Worksheets("Hoja2")
                    .cells(Fila, 3) = "Raffle Codes Maker"
                    .cells(Fila, 3).font.name = "28 Days Later"
                    .cells(Fila, 3).font.size = 14
                    .Range(LibroRifa.Worksheets("Hoja2").Cells(Fila, 1), LibroRifa.Worksheets("Hoja2").Cells(Fila, 3)).Merge
                End With
                Progress()
                Fila += 1
                With LibroRifa.Worksheets("Hoja2")
                    .cells(Fila, 3) = "by Clark"
                    .cells(Fila, 3).font.size = 8
                    .Range(LibroRifa.Worksheets("Hoja2").Cells(Fila, 1), LibroRifa.Worksheets("Hoja2").Cells(Fila, 3)).Merge
                End With
                Progress()
                Fila += 1
                With LibroRifa.Worksheets("Hoja2")
                    .cells(Fila, 3) = "Guayaquil - Ecuador"
                    .cells(Fila, 3).font.bold = True
                    .Range(LibroRifa.Worksheets("Hoja2").Cells(Fila, 1), LibroRifa.Worksheets("Hoja2").Cells(Fila, 3)).Merge
                End With
                Progress()
                Fila += 1
                With LibroRifa.Worksheets("Hoja2")
                    .cells(Fila, 3) = "2017"
                    .Range(LibroRifa.Worksheets("Hoja2").Cells(Fila, 1), LibroRifa.Worksheets("Hoja2").Cells(Fila, 3)).Merge
                End With
                Progress()

                For Counter As Integer = Fila - 3 To Fila 'Centro Horizontalmente el todas las celdas del Pie de Firma
                    LibroRifa.Worksheets("Hoja2").cells(Counter, 1).horizontalalignment = 3
                    Progress()
                Next
                LibroRifa.Worksheets("Hoja2").name = "Participantes" 'Cambio el Nombre de a Hoja2 del Libro a Participantes.


                'Acciones Finales tras generar el Archivo de Excel y finalmente guardarlo.
                SavedAlready = True
                FormSave.ButtonSaveSeries.Enabled = False
                FormSave.ButtonSaveSeries.Tag = "Ya has guardado, puedes saltarte este Paso"
                LibroRifa.SaveAs(SaveFileDialog1.FileName) 'Justo Aquí es donde se guarda el archivo
                ToolStripStatusLabel1.Text = "¡Guardado como Excel!"
                Path = IO.Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
                MsgBox("Exportación Completa." & vbNewLine & "El Archivo de Excel se Guardó Satisfactoriamente" & vbNewLine & "Ubicación de Guardado: " & IO.Path.GetDirectoryName(SaveFileDialog1.FileName) & vbNewLine & "Nombre del Archivo: " & IO.Path.GetFileName(SaveFileDialog1.FileName), vbOKOnly + vbInformation, "Archivo Guardado")
                TimerProgressBarGlobal.Enabled = True
                TimerSCTemp.Enabled = True
                FormSave.ButtonOpenSavedFile.Enabled = True
                FormSave.ButtonOpenSavedFolder.Enabled = True
                GuardarComoToolStripMenuItem.ToolTipText = "Exporta a Microsoft Excel la documentación de Usuario de la Serie de Rifas Actual generada por la Aplicación"
            Else 'Acciones al cancelar el guardado.
                TimerProgressBarGlobal.Enabled = True
                TimerSCTemp.Enabled = True
                LibroRifa.Saved = True
            End If
        Catch ex As System.IO.IOException
            MsgBox(ex.Message)
            ToolStripStatusLabel1.Text = "Error"
        Catch ex2 As System.Runtime.InteropServices.COMException
            MsgBox("Hubo un error con el Archivo." & vbNewLine & "Excepción: " & ex2.Message & vbNewLine & "Cierre toda instancia del archivo e intentelo nuevamente." & vbNewLine, vbCritical + vbOKOnly, "Error al Guardar")
            TimerProgressBarGlobal.Enabled = True
            ToolStripStatusLabel1.Text = "Error al Exportar"
        Finally
            ExcelApp.Quit()
            LibroRifa = Nothing
            ExcelApp = Nothing
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Try
            Dim ExcelAppOpen = New Microsoft.Office.Interop.Excel.Application
            Dim LibroRifa = ExcelAppOpen
            Dim CEquiv As String = ""
            Dim ColumnResult As Integer = 0, RowResult As Integer = 0, CodesCant As Integer = 1, RowsCodesSearcher As Integer = 0, dtbColumn As Integer = 0, dtbRow As Integer = 0 'dtbColumn: DataGridViewColumn, dtb significa DataTaBle
            ToolStripStatusLabel1.Text = "Abriendo Códigos desde Excel..."
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                Progress(4)
                LibroRifa.Workbooks.Open(OpenFileDialog1.FileName)
                For CSearcher As Integer = 1 To 5 'RSearcher y CSearcher buscan la celda que dice "Número de Rifa", es decir el primero de los encabezados de la tabla
                    For RSearcher As Integer = 1 To 5 'Entonces recorren el archivo columna por columna hasta un máximo de 5, y fila por fila hasta un máximo de 5 filas por columna hasta que encuentre 
                        'esta cadena y así hallar el inicio de la tabla para tener una referencia de donde empezar a leer los códigos, y cargarlos al DataGridView, de no hallarlo manda el mensaje El archivo ha sido modificado en exceso y no se encuentran los datos.
                        Select Case CSearcher 'Este Bloque Select convierte el número de Columna en una Letra para enviar como referencia a la propiedad Range del Worksheet y así poder comparar el contenido de la celda porque con cells no se puede
                            Case 1
                                CEquiv = "A"
                            Case 2
                                CEquiv = "B"
                            Case 3
                                CEquiv = "C"
                            Case 4
                                CEquiv = "D"
                            Case 5
                                CEquiv = "E"
                        End Select
                        If (LibroRifa.Worksheets("Lista de Códigos").range(CEquiv & RSearcher).value = "Número de Rifa") Then
                            ColumnResult = CSearcher 'ColumnResult captura el número de columna de referencia en la que inicia la tabla.
                            RowResult = RSearcher + 1 'RowResult captura el número de fila donde se encontró la cadena y a esta le suma 1 ya que los códigos a cargar en el DataGridView inician desde la siguiente celda
                            Exit For
                        End If
                    Next
                    If Not (ColumnResult = 0) Then
                        Exit For
                    End If
                Next
                Progress()
                RowsCodesSearcher = RowResult
                If Not (String.IsNullOrEmpty(LibroRifa.Worksheets("Lista de Códigos").range(CEquiv & RowResult).value)) Then 'Verifica si la celda donde debe estar el primer código no esta vacía, si lo está no lleva a cabo el resto del código y presenta un mensaje de error.
                    OpenedNumRif = LibroRifa.Worksheets("Lista de Códigos").range(CEquiv & RowResult).value 'OpenedNumRif es el número en el que empieza la serie de la rifa en el archivo guardado, es el equivalente a NumRif.
                    Do Until ("Raffle Codes Maker".Equals(LibroRifa.Worksheets("Lista de Códigos").range(CEquiv & RowsCodesSearcher).value)) 'Recorre la tabla contando cuantos códigos hay para poder armar la tabla y cargarlos.
                        CodesCant += 1
                        RowsCodesSearcher += 1
                    Loop
                    Progress()
                    CodesCant -= 2
                    Cantrif = CodesCant
                    ArmarTabla(CodesCant) 'Se llama al Método que Arma la Tabla. Se Llena el DataGridView con el parámetro CodesCant que es la cantidad de códigos existentes
                    'Bloque For para Recorrer el Archivo y Llenar el DataGridView
                    For FilenRow As Integer = RowResult To RowResult + CodesCant - 1 'FilenRow se utiliza para recorrer las filas del DataGridViewCodigoPorLote
                        For FilemColumn As Integer = ColumnResult To ColumnResult + 2 'FilemColumn es el incremento de 0 a 2 que se utiliza para recorrer las columnas y llenarlas
                            FormPorLote.DataGridViewCodigoPorLote.Item(dtbColumn, dtbRow).Value = LibroRifa.Worksheets("Lista de Códigos").cells(FilenRow, FilemColumn).value
                            dtbColumn += 1
                        Next
                        dtbRow += 1
                        dtbColumn = 0
                    Next
                    Progress()

                    If (FormWelcome.Visible) Then 'Oculto los Formularios que se encuentres Visibles y muestro el FormPorLote donde se van a cargar los códigos
                        FormPorLote.Visible = True
                        FormWelcome.Visible = False
                    ElseIf (FormSettingInfo.Visible) Then
                        FormPorLote.Visible = True
                        FormSettingInfo.Visible = False
                    ElseIf (FormStartToGenerate.Visible) Then
                        FormPorLote.Visible = True
                        FormStartToGenerate.Visible = False
                    ElseIf (FormUnoAUno.Visible) Then
                        FormPorLote.Visible = True
                        FormUnoAUno.Visible = False
                    ElseIf (FormSave.Visible) Then
                        FormPorLote.Visible = True
                        FormSave.Visible = False
                    ElseIf (FormCompleted.Visible) Then
                        FormPorLote.Visible = True
                        FormCompleted.Visible = False
                    End If
                    FileOpened = True
                    ButtonNext.Enabled = True
                    ButtonBack.Enabled = False
                    GuardarComoToolStripMenuItem.Enabled = True 'Ya que a partir de Aquí empiezan a haber códigos, es decir, datos para manipular, esntonces Se Habilitan los Menús para que puedan seleccionarse.
                    NuevaSerieDeCódigosToolStripMenuItem.Enabled = True
                    ImprimirToolStripMenuItem.Enabled = True
                    CopiarToolStripMenuItem.Enabled = True
                    SeleccionarTodoToolStripMenuItem.Enabled = True
                    ToolStripStatusLabel1.Text = "Listo"

                    ContentToSave = False
                    SavedAlready = True
                    LibroRifa = Nothing
                    Progress()
                Else
                    ToolStripStatusLabel1.Text = "Archivo inválido"
                    MsgBox("El primer Código de la Tabla no existe o no hay datos que cargar, puede que el archivo haya sido modificado en exceso." & vbNewLine & "Solo se permite cargar Archivos generados por esta Aplicación y que NO hayan sido modificados en su contenido en cuanto a códigos o Firma de la Aplicación." & vbNewLine & "En base a estas características verifique que todo este en correcto estado y vuelva a intentar por favor.", vbOKOnly + vbExclamation, "Oops... Datos Incorrectos")
                    TimerSCTemp.Enabled = True
                End If
            Else
                ToolStripStatusLabel1.Text = "Listo"
            End If
            ExcelAppOpen.Quit()
            ExcelAppOpen = Nothing
        Catch ex As System.IO.IOException
            ToolStripStatusLabel1.Text = "Error"
            MsgBox(ex.Message)
            TimerSCTemp.Enabled = True
        Catch ex2 As System.Runtime.InteropServices.COMException
            ToolStripStatusLabel1.Text = "Error"
            MsgBox("Se produjo un error al Abrir o Guardar el archivo, puede que un archivo con este nombre ya se encuentre abierto en este momento." & vbNewLine & "Excepción: " & ex2.Message & vbNewLine & "Si hay un archivo abierto con este mismo nombre, cierre el archivo abierto e intentelo nuevamente." & vbNewLine & "Link de Ayuda: " & ex2.HelpLink, vbCritical + vbOKOnly, "Error al Abrir o Guardar")
            TimerSCTemp.Enabled = True
        Finally
            TimerProgressBarGlobal.Enabled = True
        End Try
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        If (FormPorLote.Visible) Then
            Clipboard.SetDataObject(FormPorLote.DataGridViewCodigoPorLote.GetClipboardContent())
        ElseIf (FormUnoAUno.Visible) Then
            Clipboard.SetDataObject(FormUnoAUno.DataGridViewCodigoUAU.GetClipboardContent())
        End If
        ToolStripStatusLabel1.Text = "Celdas Seleccionadas Copiadas"
        TimerSCTemp.Enabled = True
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        If (FormPorLote.Visible) Then
            FormPorLote.DataGridViewCodigoPorLote.SelectAll()
        ElseIf (FormUnoAUno.Visible) Then
            FormUnoAUno.DataGridViewCodigoUAU.SelectAll()
        End If
        ToolStripStatusLabel1.Text = "Todas las Celdas Seleccionadas"
        TimerSCTemp.Enabled = True
    End Sub

    Private Sub TimerProgressBarGlobal_Tick(sender As Object, e As EventArgs) Handles TimerProgressBarGlobal.Tick
        LabelProgressBarGlobal.Visible = False
        ProgressBarGlobal.Visible = False
        ProgressBarGlobal.Value = 0
        TimerProgressBarGlobal.Enabled = False
    End Sub

    Private Sub FormRaffleCodesMaker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SalirToolStripMenuItem.PerformClick()
    End Sub

    Private Sub VistaPreliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistaPreliminarToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        'PrintPreviewDialog1.ShowDialog()
        'PrintDocument1.Print()
        Dim PageSetup As New PageSettings
        If (FileOpened) Then
            If (PrintDialog1.ShowDialog = DialogResult.OK) Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                'With PageSetup
                '    .Margins.Left = 50
                '    .Margins.Right = 50
                '    .Margins.Top = 50
                '    .Margins.Bottom = 50
                '    .Landscape = False

                'End With
                'PrintDocument1.DefaultPageSettings = PageSetup
                PrintDocument1.DocumentName = IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)


                PrintDocument1.Print()

            End If

        ElseIf (ContentToSave) Then
            If (SavedAlready = False) Then
                If (MsgBox("No ha Guardado Todavia." & vbNewLine & "Se requiere Guardar primero para Imprimir, Guarda el Documento e intenta nuevamente por favor." & "¿Desea Guardar Ahora?", vbYesNo + vbInformation, "Imprimir...") = MsgBoxResult.Yes) Then
                    GuardarComoToolStripMenuItem.PerformClick()
                End If
            Else

            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim BlackPen As New Pen(Brushes.Black)
        '' Set the pen's width.
        'BlackPen.Width = 8.0F
        '' Set the LineJoin property.
        'BlackPen.LineJoin = Drawing2D.LineJoin.Bevel



    End Sub

    Public Sub Progress(Elements As Integer)
        ProgressBarGlobal.Visible = True
        ProgressBarGlobal.Value = 0
        LabelProgressBarGlobal.Visible = True
        PBGElements = 100 / Elements
    End Sub

    Public Sub Progress()
        Dim value As Double
        If (ProgressBarGlobal.Value < 100) Then
            value = ProgressBarGlobal.Value + PBGElements
            If (value <= 100) Then
                ProgressBarGlobal.Value += PBGElements
                LabelProgressBarGlobal.Text = String.Format("{0:###}%", ProgressBarGlobal.Value)
            End If
        End If
    End Sub
End Class