Imports System.IO
Imports System.Diagnostics
Public Class formMain
    Declare Function GetTickCount Lib "kernel32" Alias "GetTickCount" () As Long

    Private TimeNextRecharge(0 To 5) As Long
    Dim Random As New Random

    Dim RechargeDelayUpperLimit As Integer = 250
    Dim RechargeDelayLowerLimit As Integer = 600
    Dim RechargeDelayRandomVariation As Integer = 25

    Dim maxHealthX As Integer = 0
    Dim minHealthX As Integer = 0
    Dim maxManaX As Integer = 0
    Dim minManaX As Integer = 0
    Dim yOffset As Integer = 0

    Dim maximumX As Integer = 1920
    Dim windowCaption As String = Nothing '"Tibia Flash Client - Google Chrome"

    Dim maxHealth As New Point
    Dim minHealth As New Point

    Dim maxMana As New Point
    Dim minMana As New Point

    Dim PlayerHealthPercentage As Integer = 0
    Dim PlayerManaPercentage As Integer = 0

    Dim SAPI As Object


    Public Sub findHealthPercentage(ByVal precision As Integer)
        Dim Point As New Point
        Point.X = LocateHeathPercentageXCoord(100)
        Point.Y = yOffset

        If GetPixelColorRGB(Point, "G") > 50 Then
            PlayerHealthPercentage = 100
        Else
            Dim i As Integer = 100
            i -= precision

            Do Until i = 0
                Point.X = LocateHeathPercentageXCoord(i)

                If GetPixelColorRGB(Point, "G") > 50 Then
                    PlayerHealthPercentage = i
                    Exit Do
                Else
                    i -= precision
                End If
            Loop
        End If

        debugPlayerHealthPercentage.Text = PlayerHealthPercentage
        ProgressBar1.Value = PlayerHealthPercentage
    End Sub

    Public Sub findManaPercentage(ByVal precision As Integer)
        Dim Point As New Point
        Point.X = LocateManaPercentageXCoord(100)
        Point.Y = yOffset

        If GetPixelColorRGB(Point, "B") > 50 Then
            PlayerManaPercentage = 100
        Else
            Dim i As Integer = 100
            i -= precision

            Do Until i = 0
                Point.X = LocateManaPercentageXCoord(i)

                If GetPixelColorRGB(Point, "B") > 50 Then
                    PlayerManaPercentage = i
                    Exit Do
                Else
                    i -= precision
                End If
            Loop
        End If

        TextBox8.Text = PlayerManaPercentage
        ProgressBar2.Value = PlayerManaPercentage
    End Sub

    Private Function LocateHeathPercentageXCoord(ByVal Percent As Integer)
        Dim healthDistance As Integer = maxHealthX - minHealthX
        Dim xOffset As Integer = minHealthX
        Dim multiplier As Double = healthDistance / 100

        Return Percent * multiplier + xOffset
    End Function

    Private Function LocateManaPercentageXCoord(ByVal Percent As Integer)
        Dim manaDistance As Integer = minManaX - maxManaX
        Dim xOffset As Integer = maxManaX
        Dim multiplier As Double = manaDistance / 100

        Return maximumX - (maximumX - minManaX) - Percent * multiplier
    End Function

    Private Function GetPixelColor(ByVal Location As Point) As Color
        Dim b As New Bitmap(1, 1)
        Dim g As Graphics = Graphics.FromImage(b)

        g.CopyFromScreen(Location, Point.Empty, New Size(1, 1))

        Return b.GetPixel(0, 0)
    End Function

    Private Function GetPixelColorRGB(ByVal Location As Point, ByVal RGB As String) As Byte
        Dim b As New Bitmap(1, 1)
        Dim g As Graphics = Graphics.FromImage(b)

        Try
            g.CopyFromScreen(Location, Point.Empty, New Size(1, 1))
        Catch
            debugErrorCount.Text += 1
            Return 0
        End Try

        Dim result As Color = b.GetPixel(0, 0)

        Select Case RGB
            Case "R"
                Return result.R
            Case "G"
                Return result.G
            Case "B"
                Return result.B
        End Select
        Return result.R
    End Function

    Private Sub checkboxHealerEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxHealerEnabled.CheckedChanged
        If checkboxHealerEnabled.Checked = True Then
            checkboxHealerEnabled.ForeColor = Color.Green

            timerHeal.Start()
        Else
            checkboxHealerEnabled.ForeColor = Color.Red

            timerHeal.Stop()
        End If
    End Sub

    Private Sub timerHeal_Tick(sender As Object, e As EventArgs) Handles timerHeal.Tick
        If GetCaption() = windowCaption Then
            findHealthPercentage(2)
            findManaPercentage(2)

            DoRecharges()
        End If
    End Sub

    Private Sub DoRecharges()
        Dim comboRecharge() As ComboBox = {comboRecharge0, comboRecharge1, comboRecharge2, comboRecharge3}
        Dim comboHotkey() As ComboBox = {comboHotkey0, comboHotkey1, comboHotkey2, comboHotkey3}

        Dim RechargeLimit(0 To 3) As Long
        Dim longGetTickCount As Long
        Dim RechargeFactor As Long
        Dim stringRechargeAction As String
        Dim RechargeAction As String
        Dim theLevel As Long
        Dim BestHealthRecharge As Long
        Dim BestManaRecharge As Long
        Dim am As Long
        longGetTickCount = GetTickCount()

        am = 150
        For i = 0 To 2
            RechargeLimit(i) = CLng(comboRecharge(i).Text)
            If (PlayerHealthPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
                If comboHotkey(i).Text <> "--" Then
                    If RechargeLimit(i) < am Then
                        BestHealthRecharge = i
                        am = RechargeLimit(i)
                    End If
                End If
            End If
        Next
        am = 150
        For i = 3 To 3
            RechargeLimit(i) = CLng(comboRecharge(i).Text)
            If (PlayerManaPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
                If comboHotkey(i).Text <> "--" Then
                    If RechargeLimit(i) < am Then
                        BestManaRecharge = i
                        am = RechargeLimit(i)
                    End If
                End If
            End If
        Next

        For i = 0 To 2 'Health
            If i = BestHealthRecharge Then
                RechargeLimit(i) = CLng(comboRecharge(i).Text)
                If (PlayerHealthPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
                    If comboHotkey(i).Text <> "--" Then
                        If TimeNextRecharge(i) = 0 Then
                            RechargeFactor = CLng((RechargeDelayLowerLimit * RechargeDelayRandomVariation) / 100)
                            TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayLowerLimit - RechargeFactor), RechargeDelayLowerLimit + RechargeFactor)
                        End If
                    End If
                End If
            End If
        Next
        For i = 3 To 3 'Mana
            If i = BestManaRecharge Then
                RechargeLimit(i) = CLng(comboRecharge(i).Text)
                If (PlayerManaPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
                    If comboHotkey(i).Text <> "--" Then
                        If TimeNextRecharge(i) = 0 Then
                            RechargeFactor = CLng((RechargeDelayLowerLimit * RechargeDelayRandomVariation) / 100)
                            TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayLowerLimit - RechargeFactor), RechargeDelayLowerLimit + RechargeFactor)
                        End If
                    End If
                End If
            End If
        Next

        RechargeAction = ""
        theLevel = 150
        For i = 0 To 2
            If i = BestHealthRecharge Then
                If (TimeNextRecharge(i) <= longGetTickCount) And (TimeNextRecharge(i) > 0) Then
                    If (PlayerHealthPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
                        If comboHotkey(i).Text <> "--" Then
                            RechargeFactor = CLng((RechargeDelayUpperLimit * RechargeDelayRandomVariation) / 100)
                            TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayUpperLimit - RechargeFactor), RechargeDelayUpperLimit + RechargeFactor)
                            stringRechargeAction = "{" & comboHotkey(i).Text & "}"
                            'Debug.Print "[" & longGetTickCount & "] action " & i
                            If RechargeLimit(i) < theLevel Then
                                RechargeAction = stringRechargeAction
                                theLevel = RechargeLimit(i)
                            End If
                        End If
                    Else
                        TimeNextRecharge(i) = 0
                    End If
                End If
            End If
        Next
        If RechargeAction <> "" Then
            SendKeys.Send(RechargeAction)
            Application.DoEvents()
            Exit Sub
        End If

        RechargeAction = ""
        theLevel = 150
        For i = 3 To 3
            If i = BestManaRecharge Then
                If (TimeNextRecharge(i) <= longGetTickCount) And (TimeNextRecharge(i) > 0) Then
                    If (PlayerManaPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
                        If comboHotkey(i).Text <> "--" Then
                            RechargeFactor = CLng((RechargeDelayUpperLimit * RechargeDelayRandomVariation) / 100)
                            TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayUpperLimit - RechargeFactor), RechargeDelayUpperLimit + RechargeFactor)
                            stringRechargeAction = "{" & comboHotkey(i).Text & "}"
                            'Debug.Print "[" & longGetTickCount & "] action " & i
                            If RechargeLimit(i) < theLevel Then
                                RechargeAction = stringRechargeAction
                                theLevel = RechargeLimit(i)
                            End If
                        End If
                    Else
                        TimeNextRecharge(i) = 0
                    End If
                End If
            End If
        Next

        If RechargeAction <> "" Then
            SendKeys.Send(RechargeAction)
            Application.DoEvents()
            Exit Sub
        End If


        debugBestRecharge.Text = RechargeAction

    End Sub

    Public Function MaxValue(ByVal Value1 As Long, ByVal Value2 As Long) As Long
        If Value1 >= Value2 Then
            MaxValue = Value1
        Else
            MaxValue = Value2
        End If
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub timerEatFood_Tick(sender As Object, e As EventArgs) Handles timerEatFood.Tick
        If comboAutoEatHotkey.Text <> "--" Then
            If GetCaption() = windowCaption Then
                SendKeys.Send("{" + comboAutoEatHotkey.Text + "}")
                timerEatFood.Interval = Random.Next(60000, 180000)
            End If
        End If
    End Sub

    Private Sub timerManaTrain_Tick(sender As Object, e As EventArgs) Handles timerManaTrain.Tick
        If comboManaTrain.Text <> "--" Then
            If GetCaption() = windowCaption Then
                If checkboxHealerEnabled.Checked = True Then
                    If (PlayerManaPercentage >= (100 - (Random.Next(1, 6)))) Then
                        SendKeys.Send("{" + comboManaTrain.Text + "}")
                    End If
                Else
                    findManaPercentage(2)

                    If (PlayerManaPercentage >= (100 - (Random.Next(1, 6)))) Then
                        SendKeys.Send("{" + comboManaTrain.Text + "}")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub LoadMouseWindowSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadMouseWindowSettingsToolStripMenuItem.Click

    End Sub

    Private Sub LoadHealerEtcSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadHealerEtcSettingsToolStripMenuItem.Click

    End Sub

    Private Sub SaveHealerEtcSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHealerEtcSettingsToolStripMenuItem.Click

    End Sub

    Private Sub ClearAllSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllSettingsToolStripMenuItem.Click

    End Sub

    Private Sub SetupMouseAndWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupMouseAndWindowToolStripMenuItem.Click

    End Sub

    Private Sub timerDEBUG_Tick(sender As Object, e As EventArgs) Handles timerDEBUG.Tick
        debugMaxHeathX.Text = maxHealthX
        debugMinHealthX.Text = minHealthX
        debugMaxManaX.Text = maxManaX
        debugMinManaX.Text = minManaX
        debugYOffset.Text = yOffset
        debugWindowCaption.Text = windowCaption

        debugPlayerHealthPercentage.Text = PlayerHealthPercentage
        TextBox8.Text = PlayerManaPercentage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If File.Exists(Application.StartupPath & "\Default.ini") Then
            Dim comboRecharge() As ComboBox = {comboRecharge0, comboRecharge1, comboRecharge2, comboRecharge3}
            Dim comboHotkey() As ComboBox = {comboHotkey0, comboHotkey1, comboHotkey2, comboHotkey3}

            Dim location As String = (Application.StartupPath & "\Default.ini")

            For i = 0 To 3
                comboRecharge(i).SelectedIndex = ReadIni_SAFE(location, CTE_SECTION_NAME, comboRecharge(i).Name, Nothing)
                comboHotkey(i).SelectedIndex = ReadIni_SAFE(location, CTE_SECTION_NAME, comboHotkey(i).Name, Nothing)
            Next

            comboAutoEatHotkey.SelectedIndex = ReadIni_SAFE(location, CTE_SECTION_NAME, comboAutoEatHotkey.Name, Nothing)
            comboManaTrain.SelectedIndex = ReadIni_SAFE(location, CTE_SECTION_NAME, comboManaTrain.Name, Nothing)
        End If

        If File.Exists(Application.StartupPath & "\Default.XY") = True Then
            Dim location1 As String = (Application.StartupPath & "\Default.XY")

            maxHealthX = ReadIni_SAFE(location1, CTE_SECTION_NAME, "maxHealthX", Nothing)
            minHealthX = ReadIni_SAFE(location1, CTE_SECTION_NAME, "minHealthX", Nothing)
            maxManaX = ReadIni_SAFE(location1, CTE_SECTION_NAME, "maxManaX", Nothing)
            minManaX = ReadIni_SAFE(location1, CTE_SECTION_NAME, "minManaX", Nothing)
            yOffset = ReadIni_SAFE(location1, CTE_SECTION_NAME, "yOffset", Nothing)
        End If
    End Sub

    Private Sub buttonSaveHealer_Click(sender As Object, e As EventArgs) Handles buttonSaveHealer.Click
        Dim comboRecharge() As ComboBox = {comboRecharge0, comboRecharge1, comboRecharge2, comboRecharge3}
        Dim comboHotkey() As ComboBox = {comboHotkey0, comboHotkey1, comboHotkey2, comboHotkey3}


        Dim SaveFile As New SaveFileDialog
        SaveFile.Filter = "Configuration Files (*.ini)|*.ini"

        SaveFile.ShowDialog()

        If SaveFile.FileName <> "" Then
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, comboAutoEatHotkey.Name, comboAutoEatHotkey.SelectedIndex)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, comboManaTrain.Name, comboManaTrain.SelectedIndex)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, comboHasteHotkey.Name, comboHasteHotkey.SelectedIndex)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, comboRecoveryHotkey.Name, comboRecoveryHotkey.SelectedIndex)
        End If

        For i = 0 To 3
            If SaveFile.FileName <> "" Then
                WriteIni(SaveFile.FileName, CTE_SECTION_NAME, comboRecharge(i).Name, comboRecharge(i).SelectedIndex)
                WriteIni(SaveFile.FileName, CTE_SECTION_NAME, comboHotkey(i).Name, comboHotkey(i).SelectedIndex)
            End If
        Next

        buttonLoadHealer.BackColor = Color.Green
    End Sub

    Private Sub buttonLoadHealer_Click(sender As Object, e As EventArgs) Handles buttonLoadHealer.Click
        Dim comboRecharge() As ComboBox = {comboRecharge0, comboRecharge1, comboRecharge2, comboRecharge3}
        Dim comboHotkey() As ComboBox = {comboHotkey0, comboHotkey1, comboHotkey2, comboHotkey3}
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Configuration Files (*.ini)|*.ini"

        OpenFile.ShowDialog()

        If OpenFile.FileName <> "" Then
            For i = 0 To 3
                comboRecharge(i).SelectedIndex = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, comboRecharge(i).Name, Nothing)
                comboHotkey(i).SelectedIndex = ReadIni(OpenFile.FileName, CTE_SECTION_NAME, comboHotkey(i).Name, Nothing)
            Next
        End If

        If OpenFile.FileName <> "" Then
            'Load field data
            comboAutoEatHotkey.SelectedIndex = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, comboAutoEatHotkey.Name, Nothing)
            comboManaTrain.SelectedIndex = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, comboManaTrain.Name, Nothing)

            comboHasteHotkey.SelectedIndex = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, comboHasteHotkey.Name, Nothing)
            comboRecoveryHotkey.SelectedIndex = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, comboRecoveryHotkey.Name, Nothing)
        End If

        buttonLoadHealer.BackColor = Color.Green
    End Sub

    Private Sub buttonSetupMouse_Click(sender As Object, e As EventArgs) Handles buttonSetupMouse.Click

        SAPI = CreateObject("SAPI.spvoice")


        ' SAPI.speak("Tib E Uh. Manner. Safest Tib E AN.")

        SAPI.speak("Please open Tib E Uh and place the mouse cursor over the maximum health.")
        Delay(3)
        maxHealthX = GetMouseX()
        yOffset = GetMouseY()
        SAPI.speak("OKay")
        '        My.Computer.Audio.Play(My.Resources.Red_Alert_Whirl, AudioPlayMode.WaitToComplete)



        SAPI.speak("Now go to minimum health.")

        Delay(2)
        minHealthX = GetMouseX()
        SAPI.speak("OKay")

        'My.Computer.Audio.Play(My.Resources.Red_Alert_Whirl, AudioPlayMode.WaitToComplete)

        SAPI = CreateObject("SAPI.spvoice")

        SAPI.speak("Now go to maximum Manner.")

        Delay(2)
        maxManaX = GetMouseX()
        SAPI.speak("OKay")
        'My.Computer.Audio.Play(My.Resources.Red_Alert_Whirl, AudioPlayMode.WaitToComplete)

        SAPI = CreateObject("SAPI.spvoice")

        SAPI.speak("Now go to minimum Manner.")

        Delay(2)
        minManaX = GetMouseX()
        SAPI.speak("OKay")
        'My.Computer.Audio.Play(My.Resources.Red_Alert_Whirl, AudioPlayMode.WaitToComplete)
        SAPI.speak("Now please go back to Safest Tib E AN.")

        'crashes if u press cancel, cant be bothered to fix right now
        maximumX = InputBox("What is your monitor's maximum horizontal (X) resolution in pixels? eg. 1920", "Maximum X Value Needed", "1920")
        windowCaption = InputBox("What is the EXACT name of the Tibia window? eg. Tibia Flash Client - Google Chrome", "Window Title Needed", "Tibia Flash Client - ")

        If MessageBox.Show("Would you like to save these results?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            buttonSaveMouse.PerformClick()
            labelMouseSettings.Text = "Mouse settings loaded."
            labelMouseSettings.ForeColor = Color.Green
            buttonLoadMouse.BackColor = Color.Green
        Else
            maxHealthX = 0
            minHealthX = 0
            maxManaX = 0
            minManaX = 0
            yOffset = 0
            maximumX = 0
            windowCaption = Nothing

            MessageBox.Show("The results have been discarded. Don't forget to either get new ones, or to load some previously saved ones.", "Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)
            labelMouseSettings.Text = "No mouse settings loaded!"
            labelMouseSettings.ForeColor = Color.Red
            buttonLoadMouse.BackColor = Color.Red
        End If
    End Sub
    Private Function ReadIni_SAFE(filename As String, section As String, thing As String, Optional parDefault As String = "") As Integer
        Dim res As String = ""
        Dim intres As Integer
        Try
            res = ReadIni(filename, section, thing, parDefault)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("(1) Failure trying to read " & filename & " thing = " & thing)
            res = ""
        End Try
        If (res = "") Then
            intres = 0
        Else

            Try
                intres = CLng(res)
            Catch ex2 As Exception
                System.Diagnostics.Debug.WriteLine("(2) Failure trying to read " & filename & " thing = " & thing)
                intres = 0
            End Try
        End If

        Return intres
    End Function
    Private Function ReadIni_SAFE_STRING(filename As String, section As String, thing As String, Optional parDefault As String = "") As String
        Dim res As String = ""

        Try
            res = ReadIni(filename, section, thing, parDefault)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("(1) Failure trying to read " & filename & " thing = " & thing)
            res = ""
        End Try

        Return res
    End Function

    Private Sub buttonLoadMouse_Click(sender As Object, e As EventArgs) Handles buttonLoadMouse.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Mouse XY Files (*.XY)|*.XY"

        OpenFile.ShowDialog()

        If OpenFile.FileName <> "" Then

            maxHealthX = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "maxHealthX", Nothing)
            minHealthX = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "minHealthX", Nothing)
            maxManaX = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "maxManaX", Nothing)
            minManaX = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "minManaX", Nothing)
            yOffset = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "yOffset", Nothing)
            windowCaption = ReadIni_SAFE_STRING(OpenFile.FileName, CTE_SECTION_NAME, "windowCaption", Nothing)
            NumericUpDown1.Value = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "RechargeDelayUpperLimit", Nothing)
            NumericUpDown2.Value = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "RechargeDelayLowerLimit", Nothing)
            NumericUpDown3.Value = ReadIni_SAFE(OpenFile.FileName, CTE_SECTION_NAME, "RechargeDelayRandomVariation", Nothing)

            labelMouseSettings.Text = "Mouse settings loaded."
            buttonLoadMouse.BackColor = Color.Green
            labelMouseSettings.ForeColor = Color.Green
        Else
            labelMouseSettings.Text = "No mouse settings loaded!"
            buttonLoadMouse.BackColor = Color.Red
            labelMouseSettings.ForeColor = Color.Red
        End If


    End Sub

    Private Sub buttonClearAll_Click(sender As Object, e As EventArgs) Handles buttonClearAll.Click
        Dim comboRecharge() As ComboBox = {comboRecharge0, comboRecharge1, comboRecharge2, comboRecharge3}
        Dim comboHotkey() As ComboBox = {comboHotkey0, comboHotkey1, comboHotkey2, comboHotkey3}

        For i = 0 To 3
            comboRecharge(i).SelectedIndex = 20
            comboHotkey(i).SelectedIndex = 12
        Next

        comboManaTrain.SelectedIndex = 12
        comboAutoEatHotkey.SelectedIndex = 12

        maxHealthX = 0
        minHealthX = 0
        maxManaX = 0
        minManaX = 0
        yOffset = 0
        maximumX = 0
        windowCaption = Nothing

        labelMouseSettings.Text = "No mouse settings loaded!"

        labelMouseSettings.ForeColor = Color.Red
        buttonLoadMouse.BackColor = Color.Red
        buttonLoadHealer.BackColor = Color.Red

        checkboxEatFoodEnabled.Checked = False
        checkboxHealerEnabled.Checked = False
        checkboxManaTrainEnabled.Checked = False
    End Sub

    Private Sub buttonSaveMouse_Click(sender As Object, e As EventArgs) Handles buttonSaveMouse.Click
        Dim SaveFile As New SaveFileDialog
        SaveFile.Filter = "Mouse XY Files (*.XY)|*.XY"

        SaveFile.ShowDialog()

        If SaveFile.FileName <> "" Then
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "maxHealthX", maxHealthX)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "minHealthX", minHealthX)

            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "maxManaX", maxManaX)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "minManaX", minManaX)

            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "yOffset", yOffset)

            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "maximumX", maximumX)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "windowCaption", windowCaption)

            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "RechargeDelayUpperLimit", NumericUpDown1.Value)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "RechargeDelayLowerLimit", NumericUpDown2.Value)
            WriteIni(SaveFile.FileName, CTE_SECTION_NAME, "RechargeDelayRandomVariation", NumericUpDown3.Value)
        End If
    End Sub

    Private Sub buttonAbout_Click_1(sender As Object, e As EventArgs) Handles buttonAbout.Click
        MessageBox.Show("Many thanks to BlackD of www.blackdtools.com, for his code is responsible for the healing logic." & vbCrLf _
                       & "It was however my code that detects the players health from the flash client.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        End
    End Sub

    Private Sub timerHaste_Tick(sender As Object, e As EventArgs) Handles timerHaste.Tick
        If comboHasteHotkey.Text <> "--" Then
            If GetCaption() = windowCaption Then
                SAPI = CreateObject("SAPI.spvoice")

                SAPI.speak("Haste")

                SendKeys.Send("{" + comboHasteHotkey.Text + "}")
                timerHaste.Interval = Random.Next(29000, 31000)
            End If
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        RechargeDelayUpperLimit = NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        RechargeDelayLowerLimit = NumericUpDown2.Value
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        RechargeDelayRandomVariation = NumericUpDown3.Value
    End Sub

    Private Sub Debug_CheckedChanged(sender As Object, e As EventArgs) Handles Debug.CheckedChanged
        If Debug.Checked = True Then
            Me.Width = 710
            timerDEBUG.Start()
        Else
            Me.Width = 330
            timerDEBUG.Stop()
        End If
    End Sub

    Private Sub timerRecovery_Tick(sender As Object, e As EventArgs) Handles timerRecovery.Tick
        If comboRecoveryHotkey.Text <> "--" Then
            If GetCaption() = windowCaption Then
                SAPI = CreateObject("SAPI.spvoice")

                SAPI.speak("Recovery")

                SendKeys.Send("{" + comboRecoveryHotkey.Text + "}")
                timerRecovery.Interval = Random.Next(58000, 60000)
            End If
        End If
    End Sub

    Private Sub checkboxManaTrainEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxManaTrainEnabled.CheckedChanged
        If checkboxManaTrainEnabled.Checked = True Then
            checkboxManaTrainEnabled.ForeColor = Color.Green

            timerManaTrain.Start()
        Else
            checkboxManaTrainEnabled.ForeColor = Color.Red

            timerManaTrain.Stop()
        End If
    End Sub

    Private Sub checkboxEatFoodEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxEatFoodEnabled.CheckedChanged
        If checkboxEatFoodEnabled.Checked = True Then
            checkboxEatFoodEnabled.ForeColor = Color.Green

            timerEatFood.Start()
        Else
            checkboxEatFoodEnabled.ForeColor = Color.Red

            timerEatFood.Stop()
        End If
    End Sub

    Private Sub checkboxHasteEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxHasteEnabled.CheckedChanged
        If checkboxHasteEnabled.Checked = True Then
            checkboxHasteEnabled.ForeColor = Color.Green

            timerHaste.Start()
        Else
            checkboxHasteEnabled.ForeColor = Color.Red

            timerHaste.Stop()
        End If
    End Sub

    Private Sub checkboxRecoveryEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxRecoveryEnabled.CheckedChanged
        If checkboxRecoveryEnabled.Checked = True Then
            checkboxRecoveryEnabled.ForeColor = Color.Green

            timerRecovery.Start()
        Else
            checkboxRecoveryEnabled.ForeColor = Color.Red

            timerRecovery.Stop()
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        If Debug.Checked = False Then
            Debug.Checked = True
        Else
            Debug.Checked = False
        End If
    End Sub
End Class
