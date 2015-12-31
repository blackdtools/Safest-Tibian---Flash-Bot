<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.checkboxHealerEnabled = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboRecharge2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comboRecharge1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboRecharge0 = New System.Windows.Forms.ComboBox()
        Me.comboHotkey2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboHotkey1 = New System.Windows.Forms.ComboBox()
        Me.comboHotkey3 = New System.Windows.Forms.ComboBox()
        Me.comboHotkey0 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboRecharge3 = New System.Windows.Forms.ComboBox()
        Me.timerHeal = New System.Windows.Forms.Timer(Me.components)
        Me.comboAutoEatHotkey = New System.Windows.Forms.ComboBox()
        Me.checkboxEatFoodEnabled = New System.Windows.Forms.CheckBox()
        Me.checkboxManaTrainEnabled = New System.Windows.Forms.CheckBox()
        Me.comboManaTrain = New System.Windows.Forms.ComboBox()
        Me.groupFood = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupHeal = New System.Windows.Forms.GroupBox()
        Me.OptionMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetupMouseAndWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadMouseWindowSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveHealerEtcSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadHealerEtcSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerManaTrain = New System.Windows.Forms.Timer(Me.components)
        Me.timerEatFood = New System.Windows.Forms.Timer(Me.components)
        Me.groupDEBUG = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.debugBestRecharge = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.debugPlayerHealthPercentage = New System.Windows.Forms.TextBox()
        Me.debugErrorCount = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.debugPlayerManaPercentage = New System.Windows.Forms.Label()
        Me.debugWindowCaption = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.debugYOffset = New System.Windows.Forms.TextBox()
        Me.debugMinManaX = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.debugMaxManaX = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.debugMinHealthX = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.debugMaxHeathX = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.timerDEBUG = New System.Windows.Forms.Timer(Me.components)
        Me.buttonSaveHealer = New System.Windows.Forms.Button()
        Me.buttonSetupMouse = New System.Windows.Forms.Button()
        Me.buttonLoadMouse = New System.Windows.Forms.Button()
        Me.buttonLoadHealer = New System.Windows.Forms.Button()
        Me.buttonClearAll = New System.Windows.Forms.Button()
        Me.buttonSaveMouse = New System.Windows.Forms.Button()
        Me.buttonAbout = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.timerHaste = New System.Windows.Forms.Timer(Me.components)
        Me.checkboxHasteEnabled = New System.Windows.Forms.CheckBox()
        Me.comboHasteHotkey = New System.Windows.Forms.ComboBox()
        Me.labelMouseSettings = New System.Windows.Forms.Label()
        Me.checkboxRecoveryEnabled = New System.Windows.Forms.CheckBox()
        Me.comboRecoveryHotkey = New System.Windows.Forms.ComboBox()
        Me.groupHaste = New System.Windows.Forms.GroupBox()
        Me.groupUtura = New System.Windows.Forms.GroupBox()
        Me.groupMouse = New System.Windows.Forms.GroupBox()
        Me.Debug = New System.Windows.Forms.CheckBox()
        Me.timerRecovery = New System.Windows.Forms.Timer(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.groupFood.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupHeal.SuspendLayout()
        Me.OptionMenu.SuspendLayout()
        Me.groupDEBUG.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupHaste.SuspendLayout()
        Me.groupUtura.SuspendLayout()
        Me.groupMouse.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkboxHealerEnabled
        '
        Me.checkboxHealerEnabled.AutoSize = True
        Me.checkboxHealerEnabled.ForeColor = System.Drawing.Color.Red
        Me.checkboxHealerEnabled.Location = New System.Drawing.Point(110, 125)
        Me.checkboxHealerEnabled.Name = "checkboxHealerEnabled"
        Me.checkboxHealerEnabled.Size = New System.Drawing.Size(65, 17)
        Me.checkboxHealerEnabled.TabIndex = 0
        Me.checkboxHealerEnabled.Text = "Enabled"
        Me.checkboxHealerEnabled.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Press key:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Press key:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Press key:"
        '
        'comboRecharge2
        '
        Me.comboRecharge2.FormattingEnabled = True
        Me.comboRecharge2.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "05", "00"})
        Me.comboRecharge2.Location = New System.Drawing.Point(114, 69)
        Me.comboRecharge2.Name = "comboRecharge2"
        Me.comboRecharge2.Size = New System.Drawing.Size(46, 21)
        Me.comboRecharge2.TabIndex = 57
        Me.comboRecharge2.Text = "00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(166, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Press key:"
        '
        'comboRecharge1
        '
        Me.comboRecharge1.FormattingEnabled = True
        Me.comboRecharge1.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "05", "00"})
        Me.comboRecharge1.Location = New System.Drawing.Point(114, 41)
        Me.comboRecharge1.Name = "comboRecharge1"
        Me.comboRecharge1.Size = New System.Drawing.Size(46, 21)
        Me.comboRecharge1.TabIndex = 56
        Me.comboRecharge1.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "If mana is below:"
        '
        'comboRecharge0
        '
        Me.comboRecharge0.FormattingEnabled = True
        Me.comboRecharge0.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "05", "00"})
        Me.comboRecharge0.Location = New System.Drawing.Point(114, 13)
        Me.comboRecharge0.Name = "comboRecharge0"
        Me.comboRecharge0.Size = New System.Drawing.Size(46, 21)
        Me.comboRecharge0.TabIndex = 55
        Me.comboRecharge0.Text = "00"
        '
        'comboHotkey2
        '
        Me.comboHotkey2.FormattingEnabled = True
        Me.comboHotkey2.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboHotkey2.Location = New System.Drawing.Point(231, 69)
        Me.comboHotkey2.Name = "comboHotkey2"
        Me.comboHotkey2.Size = New System.Drawing.Size(52, 21)
        Me.comboHotkey2.TabIndex = 54
        Me.comboHotkey2.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "If health is below: "
        '
        'comboHotkey1
        '
        Me.comboHotkey1.FormattingEnabled = True
        Me.comboHotkey1.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboHotkey1.Location = New System.Drawing.Point(231, 41)
        Me.comboHotkey1.Name = "comboHotkey1"
        Me.comboHotkey1.Size = New System.Drawing.Size(52, 21)
        Me.comboHotkey1.TabIndex = 52
        Me.comboHotkey1.Text = "--"
        '
        'comboHotkey3
        '
        Me.comboHotkey3.FormattingEnabled = True
        Me.comboHotkey3.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboHotkey3.Location = New System.Drawing.Point(230, 97)
        Me.comboHotkey3.Name = "comboHotkey3"
        Me.comboHotkey3.Size = New System.Drawing.Size(52, 21)
        Me.comboHotkey3.TabIndex = 61
        Me.comboHotkey3.Text = "--"
        '
        'comboHotkey0
        '
        Me.comboHotkey0.FormattingEnabled = True
        Me.comboHotkey0.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboHotkey0.Location = New System.Drawing.Point(231, 13)
        Me.comboHotkey0.Name = "comboHotkey0"
        Me.comboHotkey0.Size = New System.Drawing.Size(52, 21)
        Me.comboHotkey0.TabIndex = 51
        Me.comboHotkey0.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "If health is below: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "If health is below: "
        '
        'comboRecharge3
        '
        Me.comboRecharge3.FormattingEnabled = True
        Me.comboRecharge3.Items.AddRange(New Object() {"100", "95", "90", "85", "80", "75", "70", "65", "60", "55", "50", "45", "40", "35", "30", "25", "20", "15", "10", "05", "00"})
        Me.comboRecharge3.Location = New System.Drawing.Point(114, 97)
        Me.comboRecharge3.Name = "comboRecharge3"
        Me.comboRecharge3.Size = New System.Drawing.Size(46, 21)
        Me.comboRecharge3.TabIndex = 63
        Me.comboRecharge3.Text = "00"
        '
        'timerHeal
        '
        Me.timerHeal.Interval = 10
        '
        'comboAutoEatHotkey
        '
        Me.comboAutoEatHotkey.FormattingEnabled = True
        Me.comboAutoEatHotkey.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboAutoEatHotkey.Location = New System.Drawing.Point(47, 16)
        Me.comboAutoEatHotkey.Name = "comboAutoEatHotkey"
        Me.comboAutoEatHotkey.Size = New System.Drawing.Size(46, 21)
        Me.comboAutoEatHotkey.TabIndex = 74
        Me.comboAutoEatHotkey.Text = "--"
        '
        'checkboxEatFoodEnabled
        '
        Me.checkboxEatFoodEnabled.AutoSize = True
        Me.checkboxEatFoodEnabled.ForeColor = System.Drawing.Color.Red
        Me.checkboxEatFoodEnabled.Location = New System.Drawing.Point(47, 43)
        Me.checkboxEatFoodEnabled.Name = "checkboxEatFoodEnabled"
        Me.checkboxEatFoodEnabled.Size = New System.Drawing.Size(65, 17)
        Me.checkboxEatFoodEnabled.TabIndex = 75
        Me.checkboxEatFoodEnabled.Text = "Enabled"
        Me.checkboxEatFoodEnabled.UseVisualStyleBackColor = True
        '
        'checkboxManaTrainEnabled
        '
        Me.checkboxManaTrainEnabled.AutoSize = True
        Me.checkboxManaTrainEnabled.ForeColor = System.Drawing.Color.Red
        Me.checkboxManaTrainEnabled.Location = New System.Drawing.Point(32, 43)
        Me.checkboxManaTrainEnabled.Name = "checkboxManaTrainEnabled"
        Me.checkboxManaTrainEnabled.Size = New System.Drawing.Size(65, 17)
        Me.checkboxManaTrainEnabled.TabIndex = 78
        Me.checkboxManaTrainEnabled.Text = "Enabled"
        Me.checkboxManaTrainEnabled.UseVisualStyleBackColor = True
        '
        'comboManaTrain
        '
        Me.comboManaTrain.FormattingEnabled = True
        Me.comboManaTrain.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboManaTrain.Location = New System.Drawing.Point(40, 16)
        Me.comboManaTrain.Name = "comboManaTrain"
        Me.comboManaTrain.Size = New System.Drawing.Size(52, 21)
        Me.comboManaTrain.TabIndex = 77
        Me.comboManaTrain.Text = "--"
        '
        'groupFood
        '
        Me.groupFood.Controls.Add(Me.comboAutoEatHotkey)
        Me.groupFood.Controls.Add(Me.checkboxEatFoodEnabled)
        Me.groupFood.Location = New System.Drawing.Point(156, 167)
        Me.groupFood.Name = "groupFood"
        Me.groupFood.Size = New System.Drawing.Size(149, 65)
        Me.groupFood.TabIndex = 79
        Me.groupFood.TabStop = False
        Me.groupFood.Text = "Eat Food"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.comboManaTrain)
        Me.GroupBox2.Controls.Add(Me.checkboxManaTrainEnabled)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 65)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mana Train"
        '
        'groupHeal
        '
        Me.groupHeal.Controls.Add(Me.Label1)
        Me.groupHeal.Controls.Add(Me.checkboxHealerEnabled)
        Me.groupHeal.Controls.Add(Me.comboRecharge3)
        Me.groupHeal.Controls.Add(Me.Label2)
        Me.groupHeal.Controls.Add(Me.comboHotkey0)
        Me.groupHeal.Controls.Add(Me.comboHotkey3)
        Me.groupHeal.Controls.Add(Me.comboHotkey1)
        Me.groupHeal.Controls.Add(Me.Label3)
        Me.groupHeal.Controls.Add(Me.comboHotkey2)
        Me.groupHeal.Controls.Add(Me.comboRecharge0)
        Me.groupHeal.Controls.Add(Me.Label6)
        Me.groupHeal.Controls.Add(Me.comboRecharge1)
        Me.groupHeal.Controls.Add(Me.Label12)
        Me.groupHeal.Controls.Add(Me.comboRecharge2)
        Me.groupHeal.Controls.Add(Me.Label7)
        Me.groupHeal.Controls.Add(Me.Label8)
        Me.groupHeal.Controls.Add(Me.Label9)
        Me.groupHeal.Location = New System.Drawing.Point(12, 12)
        Me.groupHeal.Name = "groupHeal"
        Me.groupHeal.Size = New System.Drawing.Size(293, 149)
        Me.groupHeal.TabIndex = 0
        Me.groupHeal.TabStop = False
        Me.groupHeal.Text = "Heal"
        '
        'OptionMenu
        '
        Me.OptionMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupMouseAndWindowToolStripMenuItem, Me.LoadMouseWindowSettingsToolStripMenuItem, Me.SaveHealerEtcSettingsToolStripMenuItem, Me.LoadHealerEtcSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearAllSettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionMenu.Name = "OptionMenu"
        Me.OptionMenu.Size = New System.Drawing.Size(247, 164)
        '
        'SetupMouseAndWindowToolStripMenuItem
        '
        Me.SetupMouseAndWindowToolStripMenuItem.Name = "SetupMouseAndWindowToolStripMenuItem"
        Me.SetupMouseAndWindowToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.SetupMouseAndWindowToolStripMenuItem.Text = "Setup Mouse + Window Settings"
        '
        'LoadMouseWindowSettingsToolStripMenuItem
        '
        Me.LoadMouseWindowSettingsToolStripMenuItem.Name = "LoadMouseWindowSettingsToolStripMenuItem"
        Me.LoadMouseWindowSettingsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.LoadMouseWindowSettingsToolStripMenuItem.Text = "Load Mouse + Window Settings"
        '
        'SaveHealerEtcSettingsToolStripMenuItem
        '
        Me.SaveHealerEtcSettingsToolStripMenuItem.Name = "SaveHealerEtcSettingsToolStripMenuItem"
        Me.SaveHealerEtcSettingsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.SaveHealerEtcSettingsToolStripMenuItem.Text = "Save Healer etc Settings"
        '
        'LoadHealerEtcSettingsToolStripMenuItem
        '
        Me.LoadHealerEtcSettingsToolStripMenuItem.Name = "LoadHealerEtcSettingsToolStripMenuItem"
        Me.LoadHealerEtcSettingsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.LoadHealerEtcSettingsToolStripMenuItem.Text = "Load Healer etc Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(243, 6)
        '
        'ClearAllSettingsToolStripMenuItem
        '
        Me.ClearAllSettingsToolStripMenuItem.Name = "ClearAllSettingsToolStripMenuItem"
        Me.ClearAllSettingsToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ClearAllSettingsToolStripMenuItem.Text = "Clear All Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'timerManaTrain
        '
        Me.timerManaTrain.Interval = 2000
        '
        'timerEatFood
        '
        Me.timerEatFood.Interval = 5000
        '
        'groupDEBUG
        '
        Me.groupDEBUG.Controls.Add(Me.NumericUpDown1)
        Me.groupDEBUG.Controls.Add(Me.NumericUpDown2)
        Me.groupDEBUG.Controls.Add(Me.NumericUpDown3)
        Me.groupDEBUG.Controls.Add(Me.debugBestRecharge)
        Me.groupDEBUG.Controls.Add(Me.TextBox8)
        Me.groupDEBUG.Controls.Add(Me.debugPlayerHealthPercentage)
        Me.groupDEBUG.Controls.Add(Me.debugErrorCount)
        Me.groupDEBUG.Controls.Add(Me.Label24)
        Me.groupDEBUG.Controls.Add(Me.debugPlayerManaPercentage)
        Me.groupDEBUG.Controls.Add(Me.debugWindowCaption)
        Me.groupDEBUG.Controls.Add(Me.Label19)
        Me.groupDEBUG.Controls.Add(Me.debugYOffset)
        Me.groupDEBUG.Controls.Add(Me.debugMinManaX)
        Me.groupDEBUG.Controls.Add(Me.Label21)
        Me.groupDEBUG.Controls.Add(Me.debugMaxManaX)
        Me.groupDEBUG.Controls.Add(Me.Label20)
        Me.groupDEBUG.Controls.Add(Me.debugMinHealthX)
        Me.groupDEBUG.Controls.Add(Me.Label18)
        Me.groupDEBUG.Controls.Add(Me.debugMaxHeathX)
        Me.groupDEBUG.Controls.Add(Me.Label17)
        Me.groupDEBUG.Controls.Add(Me.Label16)
        Me.groupDEBUG.Controls.Add(Me.ProgressBar1)
        Me.groupDEBUG.Controls.Add(Me.ProgressBar2)
        Me.groupDEBUG.Location = New System.Drawing.Point(311, 12)
        Me.groupDEBUG.Name = "groupDEBUG"
        Me.groupDEBUG.Size = New System.Drawing.Size(374, 426)
        Me.groupDEBUG.TabIndex = 82
        Me.groupDEBUG.TabStop = False
        Me.groupDEBUG.Text = "DEBUG"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(234, 79)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 97
        Me.NumericUpDown1.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(234, 99)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 98
        Me.NumericUpDown2.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(234, 118)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown3.TabIndex = 99
        Me.NumericUpDown3.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'debugBestRecharge
        '
        Me.debugBestRecharge.AutoSize = True
        Me.debugBestRecharge.Location = New System.Drawing.Point(30, 295)
        Me.debugBestRecharge.Name = "debugBestRecharge"
        Me.debugBestRecharge.Size = New System.Drawing.Size(13, 13)
        Me.debugBestRecharge.TabIndex = 97
        Me.debugBestRecharge.Text = "0"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(8, 220)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(23, 20)
        Me.TextBox8.TabIndex = 7
        '
        'debugPlayerHealthPercentage
        '
        Me.debugPlayerHealthPercentage.Location = New System.Drawing.Point(8, 191)
        Me.debugPlayerHealthPercentage.Name = "debugPlayerHealthPercentage"
        Me.debugPlayerHealthPercentage.Size = New System.Drawing.Size(23, 20)
        Me.debugPlayerHealthPercentage.TabIndex = 6
        '
        'debugErrorCount
        '
        Me.debugErrorCount.AutoSize = True
        Me.debugErrorCount.Location = New System.Drawing.Point(30, 267)
        Me.debugErrorCount.Name = "debugErrorCount"
        Me.debugErrorCount.Size = New System.Drawing.Size(13, 13)
        Me.debugErrorCount.TabIndex = 94
        Me.debugErrorCount.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(300, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 13)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "windowCaption"
        '
        'debugPlayerManaPercentage
        '
        Me.debugPlayerManaPercentage.AutoSize = True
        Me.debugPlayerManaPercentage.Location = New System.Drawing.Point(244, 224)
        Me.debugPlayerManaPercentage.Name = "debugPlayerManaPercentage"
        Me.debugPlayerManaPercentage.Size = New System.Drawing.Size(118, 13)
        Me.debugPlayerManaPercentage.TabIndex = 105
        Me.debugPlayerManaPercentage.Text = "PlayerManaPercentage"
        '
        'debugWindowCaption
        '
        Me.debugWindowCaption.Location = New System.Drawing.Point(8, 161)
        Me.debugWindowCaption.Name = "debugWindowCaption"
        Me.debugWindowCaption.Size = New System.Drawing.Size(286, 20)
        Me.debugWindowCaption.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(244, 195)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 13)
        Me.Label19.TabIndex = 101
        Me.Label19.Text = "PlayerHealthPercentage"
        '
        'debugYOffset
        '
        Me.debugYOffset.Location = New System.Drawing.Point(8, 135)
        Me.debugYOffset.Name = "debugYOffset"
        Me.debugYOffset.Size = New System.Drawing.Size(100, 20)
        Me.debugYOffset.TabIndex = 4
        '
        'debugMinManaX
        '
        Me.debugMinManaX.Location = New System.Drawing.Point(8, 109)
        Me.debugMinManaX.Name = "debugMinManaX"
        Me.debugMinManaX.Size = New System.Drawing.Size(100, 20)
        Me.debugMinManaX.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(124, 135)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 103
        Me.Label21.Text = "yOffset"
        '
        'debugMaxManaX
        '
        Me.debugMaxManaX.Location = New System.Drawing.Point(8, 83)
        Me.debugMaxManaX.Name = "debugMaxManaX"
        Me.debugMaxManaX.Size = New System.Drawing.Size(100, 20)
        Me.debugMaxManaX.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(107, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "minManaX"
        '
        'debugMinHealthX
        '
        Me.debugMinHealthX.Location = New System.Drawing.Point(6, 57)
        Me.debugMinHealthX.Name = "debugMinHealthX"
        Me.debugMinHealthX.Size = New System.Drawing.Size(100, 20)
        Me.debugMinHealthX.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(108, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 100
        Me.Label18.Text = "maxManaX"
        '
        'debugMaxHeathX
        '
        Me.debugMaxHeathX.Location = New System.Drawing.Point(7, 32)
        Me.debugMaxHeathX.Name = "debugMaxHeathX"
        Me.debugMaxHeathX.Size = New System.Drawing.Size(100, 20)
        Me.debugMaxHeathX.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(112, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "minHealthX"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(113, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "maxHealthX"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 189)
        Me.ProgressBar1.MarqueeAnimationSpeed = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(232, 23)
        Me.ProgressBar1.TabIndex = 84
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(6, 218)
        Me.ProgressBar2.MarqueeAnimationSpeed = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(232, 23)
        Me.ProgressBar2.TabIndex = 85
        '
        'timerDEBUG
        '
        '
        'buttonSaveHealer
        '
        Me.buttonSaveHealer.Location = New System.Drawing.Point(12, 307)
        Me.buttonSaveHealer.Name = "buttonSaveHealer"
        Me.buttonSaveHealer.Size = New System.Drawing.Size(138, 32)
        Me.buttonSaveHealer.TabIndex = 86
        Me.buttonSaveHealer.Text = "Save Healer"
        Me.buttonSaveHealer.UseVisualStyleBackColor = True
        '
        'buttonSetupMouse
        '
        Me.buttonSetupMouse.Location = New System.Drawing.Point(6, 17)
        Me.buttonSetupMouse.Name = "buttonSetupMouse"
        Me.buttonSetupMouse.Size = New System.Drawing.Size(97, 23)
        Me.buttonSetupMouse.TabIndex = 87
        Me.buttonSetupMouse.Text = "Setup Mouse"
        Me.buttonSetupMouse.UseVisualStyleBackColor = True
        '
        'buttonLoadMouse
        '
        Me.buttonLoadMouse.BackColor = System.Drawing.Color.Red
        Me.buttonLoadMouse.Location = New System.Drawing.Point(202, 17)
        Me.buttonLoadMouse.Name = "buttonLoadMouse"
        Me.buttonLoadMouse.Size = New System.Drawing.Size(88, 23)
        Me.buttonLoadMouse.TabIndex = 88
        Me.buttonLoadMouse.Text = "Load Mouse"
        Me.buttonLoadMouse.UseVisualStyleBackColor = False
        '
        'buttonLoadHealer
        '
        Me.buttonLoadHealer.BackColor = System.Drawing.Color.Red
        Me.buttonLoadHealer.Location = New System.Drawing.Point(156, 307)
        Me.buttonLoadHealer.Name = "buttonLoadHealer"
        Me.buttonLoadHealer.Size = New System.Drawing.Size(149, 32)
        Me.buttonLoadHealer.TabIndex = 89
        Me.buttonLoadHealer.Text = "Load Healer"
        Me.buttonLoadHealer.UseVisualStyleBackColor = False
        '
        'buttonClearAll
        '
        Me.buttonClearAll.Location = New System.Drawing.Point(12, 415)
        Me.buttonClearAll.Name = "buttonClearAll"
        Me.buttonClearAll.Size = New System.Drawing.Size(97, 23)
        Me.buttonClearAll.TabIndex = 90
        Me.buttonClearAll.Text = "Clear All"
        Me.buttonClearAll.UseVisualStyleBackColor = True
        '
        'buttonSaveMouse
        '
        Me.buttonSaveMouse.Location = New System.Drawing.Point(104, 17)
        Me.buttonSaveMouse.Name = "buttonSaveMouse"
        Me.buttonSaveMouse.Size = New System.Drawing.Size(97, 23)
        Me.buttonSaveMouse.TabIndex = 91
        Me.buttonSaveMouse.Text = "Save Mouse"
        Me.buttonSaveMouse.UseVisualStyleBackColor = True
        '
        'buttonAbout
        '
        Me.buttonAbout.Location = New System.Drawing.Point(112, 415)
        Me.buttonAbout.Name = "buttonAbout"
        Me.buttonAbout.Size = New System.Drawing.Size(92, 23)
        Me.buttonAbout.TabIndex = 92
        Me.buttonAbout.Text = "About"
        Me.buttonAbout.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Location = New System.Drawing.Point(210, 415)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(95, 23)
        Me.buttonExit.TabIndex = 93
        Me.buttonExit.Text = "Exit"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'timerHaste
        '
        Me.timerHaste.Interval = 5000
        '
        'checkboxHasteEnabled
        '
        Me.checkboxHasteEnabled.AutoSize = True
        Me.checkboxHasteEnabled.ForeColor = System.Drawing.Color.Red
        Me.checkboxHasteEnabled.Location = New System.Drawing.Point(32, 41)
        Me.checkboxHasteEnabled.Name = "checkboxHasteEnabled"
        Me.checkboxHasteEnabled.Size = New System.Drawing.Size(65, 17)
        Me.checkboxHasteEnabled.TabIndex = 95
        Me.checkboxHasteEnabled.Text = "Enabled"
        Me.checkboxHasteEnabled.UseVisualStyleBackColor = True
        '
        'comboHasteHotkey
        '
        Me.comboHasteHotkey.FormattingEnabled = True
        Me.comboHasteHotkey.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboHasteHotkey.Location = New System.Drawing.Point(46, 14)
        Me.comboHasteHotkey.Name = "comboHasteHotkey"
        Me.comboHasteHotkey.Size = New System.Drawing.Size(46, 21)
        Me.comboHasteHotkey.TabIndex = 96
        Me.comboHasteHotkey.Text = "--"
        '
        'labelMouseSettings
        '
        Me.labelMouseSettings.AutoSize = True
        Me.labelMouseSettings.ForeColor = System.Drawing.Color.Red
        Me.labelMouseSettings.Location = New System.Drawing.Point(86, 43)
        Me.labelMouseSettings.Name = "labelMouseSettings"
        Me.labelMouseSettings.Size = New System.Drawing.Size(132, 13)
        Me.labelMouseSettings.TabIndex = 97
        Me.labelMouseSettings.Text = "No mouse settings loaded!"
        '
        'checkboxRecoveryEnabled
        '
        Me.checkboxRecoveryEnabled.AutoSize = True
        Me.checkboxRecoveryEnabled.ForeColor = System.Drawing.Color.Red
        Me.checkboxRecoveryEnabled.Location = New System.Drawing.Point(40, 41)
        Me.checkboxRecoveryEnabled.Name = "checkboxRecoveryEnabled"
        Me.checkboxRecoveryEnabled.Size = New System.Drawing.Size(65, 17)
        Me.checkboxRecoveryEnabled.TabIndex = 107
        Me.checkboxRecoveryEnabled.Text = "Enabled"
        Me.checkboxRecoveryEnabled.UseVisualStyleBackColor = True
        '
        'comboRecoveryHotkey
        '
        Me.comboRecoveryHotkey.FormattingEnabled = True
        Me.comboRecoveryHotkey.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "--"})
        Me.comboRecoveryHotkey.Location = New System.Drawing.Point(46, 16)
        Me.comboRecoveryHotkey.Name = "comboRecoveryHotkey"
        Me.comboRecoveryHotkey.Size = New System.Drawing.Size(46, 21)
        Me.comboRecoveryHotkey.TabIndex = 108
        Me.comboRecoveryHotkey.Text = "--"
        '
        'groupHaste
        '
        Me.groupHaste.Controls.Add(Me.checkboxHasteEnabled)
        Me.groupHaste.Controls.Add(Me.comboHasteHotkey)
        Me.groupHaste.Location = New System.Drawing.Point(12, 238)
        Me.groupHaste.Name = "groupHaste"
        Me.groupHaste.Size = New System.Drawing.Size(138, 63)
        Me.groupHaste.TabIndex = 100
        Me.groupHaste.TabStop = False
        Me.groupHaste.Text = "Haste"
        '
        'groupUtura
        '
        Me.groupUtura.Controls.Add(Me.checkboxRecoveryEnabled)
        Me.groupUtura.Controls.Add(Me.comboRecoveryHotkey)
        Me.groupUtura.Location = New System.Drawing.Point(157, 238)
        Me.groupUtura.Name = "groupUtura"
        Me.groupUtura.Size = New System.Drawing.Size(148, 63)
        Me.groupUtura.TabIndex = 109
        Me.groupUtura.TabStop = False
        Me.groupUtura.Text = "Recovery"
        '
        'groupMouse
        '
        Me.groupMouse.Controls.Add(Me.buttonSetupMouse)
        Me.groupMouse.Controls.Add(Me.buttonLoadMouse)
        Me.groupMouse.Controls.Add(Me.buttonSaveMouse)
        Me.groupMouse.Controls.Add(Me.labelMouseSettings)
        Me.groupMouse.Location = New System.Drawing.Point(12, 346)
        Me.groupMouse.Name = "groupMouse"
        Me.groupMouse.Size = New System.Drawing.Size(293, 63)
        Me.groupMouse.TabIndex = 110
        Me.groupMouse.TabStop = False
        Me.groupMouse.Text = "Mouse"
        '
        'Debug
        '
        Me.Debug.AutoSize = True
        Me.Debug.Location = New System.Drawing.Point(112, 444)
        Me.Debug.Name = "Debug"
        Me.Debug.Size = New System.Drawing.Size(58, 17)
        Me.Debug.TabIndex = 111
        Me.Debug.Text = "Debug"
        Me.Debug.UseVisualStyleBackColor = True
        Me.Debug.Visible = False
        '
        'timerRecovery
        '
        Me.timerRecovery.Interval = 7500
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(12, 442)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 19)
        Me.Label15.TabIndex = 112
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 466)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Debug)
        Me.Controls.Add(Me.groupFood)
        Me.Controls.Add(Me.groupHeal)
        Me.Controls.Add(Me.groupUtura)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupHaste)
        Me.Controls.Add(Me.groupMouse)
        Me.Controls.Add(Me.buttonSaveHealer)
        Me.Controls.Add(Me.buttonLoadHealer)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonAbout)
        Me.Controls.Add(Me.buttonClearAll)
        Me.Controls.Add(Me.groupDEBUG)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SafestTibian"
        Me.groupFood.ResumeLayout(False)
        Me.groupFood.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupHeal.ResumeLayout(False)
        Me.groupHeal.PerformLayout()
        Me.OptionMenu.ResumeLayout(False)
        Me.groupDEBUG.ResumeLayout(False)
        Me.groupDEBUG.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupHaste.ResumeLayout(False)
        Me.groupHaste.PerformLayout()
        Me.groupUtura.ResumeLayout(False)
        Me.groupUtura.PerformLayout()
        Me.groupMouse.ResumeLayout(False)
        Me.groupMouse.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkboxHealerEnabled As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents comboRecharge2 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents comboRecharge1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents comboRecharge0 As ComboBox
    Friend WithEvents comboHotkey2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents comboHotkey1 As ComboBox
    Friend WithEvents comboHotkey3 As ComboBox
    Friend WithEvents comboHotkey0 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboRecharge3 As ComboBox
    Friend WithEvents timerHeal As Timer
    Friend WithEvents comboAutoEatHotkey As ComboBox
    Friend WithEvents checkboxEatFoodEnabled As CheckBox
    Friend WithEvents checkboxManaTrainEnabled As CheckBox
    Friend WithEvents comboManaTrain As ComboBox
    Friend WithEvents groupFood As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents groupHeal As GroupBox
    Friend WithEvents OptionMenu As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents timerManaTrain As Timer
    Friend WithEvents timerEatFood As Timer
    Friend WithEvents SetupMouseAndWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadMouseWindowSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveHealerEtcSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadHealerEtcSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents groupDEBUG As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents debugPlayerHealthPercentage As TextBox
    Friend WithEvents debugWindowCaption As TextBox
    Friend WithEvents debugYOffset As TextBox
    Friend WithEvents debugMinManaX As TextBox
    Friend WithEvents debugMaxManaX As TextBox
    Friend WithEvents debugMinHealthX As TextBox
    Friend WithEvents debugMaxHeathX As TextBox
    Friend WithEvents timerDEBUG As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents buttonSaveHealer As Button
    Friend WithEvents buttonSetupMouse As Button
    Friend WithEvents buttonLoadMouse As Button
    Friend WithEvents buttonLoadHealer As Button
    Friend WithEvents buttonClearAll As Button
    Friend WithEvents buttonSaveMouse As Button
    Friend WithEvents buttonAbout As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents debugErrorCount As Label
    Friend WithEvents timerHaste As Timer
    Friend WithEvents checkboxHasteEnabled As CheckBox
    Friend WithEvents comboHasteHotkey As ComboBox
    Friend WithEvents debugBestRecharge As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents labelMouseSettings As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents debugPlayerManaPercentage As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents checkboxRecoveryEnabled As CheckBox
    Friend WithEvents comboRecoveryHotkey As ComboBox
    Friend WithEvents groupHaste As GroupBox
    Friend WithEvents groupUtura As GroupBox
    Friend WithEvents groupMouse As GroupBox
    Friend WithEvents Debug As CheckBox
    Friend WithEvents timerRecovery As Timer
    Friend WithEvents Label15 As Label
End Class
