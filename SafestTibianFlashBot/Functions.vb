Public Module Functions
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer

    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32


    Public Const CTE_SECTION_NAME As String = "Settings"
    'Private Sub DoRecharges()
    '    Dim comboRecharge() As ComboBox = {comboRecharge0, comboRecharge1, comboRecharge2, comboRecharge3, comboRecharge4, comboRecharge5}
    '    Dim comboHotkey() As ComboBox = {comboHotkey0, comboHotkey1, comboHotkey2, comboHotkey3, comboHotkey4, comboHotkey5}

    '    Dim RechargeLimit(0 To 5) As Long
    '    Dim longGetTickCount As Long
    '    Dim RechargeFactor As Long
    '    Dim stringRechargeAction As String
    '    Dim RechargeAction As String
    '    Dim theLevel As Long
    '    Dim BestHealthRecharge As Long
    '    Dim BestManaRecharge As Long
    '    Dim am As Long
    '    longGetTickCount = GetTickCount()

    '    am = 150
    '    For i = 0 To 2
    '        RechargeLimit(i) = CLng(comboRecharge(i).Text)
    '        If (PlayerHealthPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
    '            If comboHotkey(i).Text <> "--" Then
    '                If RechargeLimit(i) < am Then
    '                    BestHealthRecharge = i
    '                    am = RechargeLimit(i)
    '                End If
    '            End If
    '        End If
    '    Next
    '    am = 150
    '    For i = 3 To 5
    '        RechargeLimit(i) = CLng(comboRecharge(i).Text)
    '        If (PlayerManaPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
    '            If comboHotkey(i).Text <> "--" Then
    '                If RechargeLimit(i) < am Then
    '                    BestManaRecharge = i
    '                    am = RechargeLimit(i)
    '                End If
    '            End If
    '        End If
    '    Next

    '    For i = 0 To 2 'Health
    '        If i = BestHealthRecharge Then
    '            RechargeLimit(i) = CLng(comboRecharge(i).Text)
    '            If (PlayerHealthPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
    '                If comboHotkey(i).Text <> "--" Then
    '                    If TimeNextRecharge(i) = 0 Then
    '                        RechargeFactor = CLng((RechargeDelayLowerLimit * RechargeDelayRandomVariation) / 100)
    '                        TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayLowerLimit - RechargeFactor), RechargeDelayLowerLimit + RechargeFactor)
    '                    End If
    '                End If
    '            End If
    '        End If
    '    Next
    '    For i = 3 To 5 'Mana
    '        If i = BestManaRecharge Then
    '            RechargeLimit(i) = CLng(comboRecharge(i).Text)
    '            If (PlayerManaPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
    '                If comboHotkey(i).Text <> "--" Then
    '                    If TimeNextRecharge(i) = 0 Then
    '                        RechargeFactor = CLng((RechargeDelayLowerLimit * RechargeDelayRandomVariation) / 100)
    '                        TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayLowerLimit - RechargeFactor), RechargeDelayLowerLimit + RechargeFactor)
    '                    End If
    '                End If
    '            End If
    '        End If
    '    Next

    '    RechargeAction = ""
    '    theLevel = 150
    '    For i = 0 To 2
    '        If i = BestHealthRecharge Then
    '            If (TimeNextRecharge(i) <= longGetTickCount) And (TimeNextRecharge(i) > 0) Then
    '                If (PlayerHealthPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
    '                    If comboHotkey(i).Text <> "--" Then
    '                        RechargeFactor = CLng((RechargeDelayUpperLimit * RechargeDelayRandomVariation) / 100)
    '                        TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayUpperLimit - RechargeFactor), RechargeDelayUpperLimit + RechargeFactor)
    '                        stringRechargeAction = "{" & comboHotkey(i).Text & "}"
    '                        'Debug.Print "[" & longGetTickCount & "] action " & i
    '                        If RechargeLimit(i) < theLevel Then
    '                            RechargeAction = stringRechargeAction
    '                            theLevel = RechargeLimit(i)
    '                        End If
    '                    End If
    '                Else
    '                    TimeNextRecharge(i) = 0
    '                End If
    '            End If
    '        End If
    '    Next
    '    If RechargeAction <> "" Then
    '        SendKeys.Send(RechargeAction)
    '        Application.DoEvents()
    '        Exit Sub
    '    End If

    '    RechargeAction = ""
    '    theLevel = 150
    '    For i = 3 To 5
    '        If i = BestManaRecharge Then
    '            If (TimeNextRecharge(i) <= longGetTickCount) And (TimeNextRecharge(i) > 0) Then
    '                If (PlayerManaPercentage <= RechargeLimit(i)) And (RechargeLimit(i) > 0) Then
    '                    If comboHotkey(i).Text <> "--" Then
    '                        RechargeFactor = CLng((RechargeDelayUpperLimit * RechargeDelayRandomVariation) / 100)
    '                        TimeNextRecharge(i) = longGetTickCount + Random.Next(MaxValue(0, RechargeDelayUpperLimit - RechargeFactor), RechargeDelayUpperLimit + RechargeFactor)
    '                        stringRechargeAction = "{" & comboHotkey(i).Text & "}"
    '                        'Debug.Print "[" & longGetTickCount & "] action " & i
    '                        If RechargeLimit(i) < theLevel Then
    '                            RechargeAction = stringRechargeAction
    '                            theLevel = RechargeLimit(i)
    '                        End If
    '                    End If
    '                Else
    '                    TimeNextRecharge(i) = 0
    '                End If
    '            End If
    '        End If
    '    Next

    '    If RechargeAction <> "" Then
    '        SendKeys.Send(RechargeAction)
    '        Application.DoEvents()
    '        Exit Sub
    '    End If
    'End Sub



    Public Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function

    Public Sub WriteIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer
        Result = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String
        Dim LenParamVal As Long

        ParamVal = Space$(1024)
        LenParamVal = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)

        ReadIni = Left$(ParamVal, LenParamVal)
    End Function

    Public Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

    Public Function GetMouseX()
        Dim CursorPosition As Point
        CursorPosition = Cursor.Position

        Return CursorPosition.X
    End Function

    Public Function GetMouseY()
        Dim CursorPosition As Point
        CursorPosition = Cursor.Position

        Return CursorPosition.Y
    End Function
End Module
