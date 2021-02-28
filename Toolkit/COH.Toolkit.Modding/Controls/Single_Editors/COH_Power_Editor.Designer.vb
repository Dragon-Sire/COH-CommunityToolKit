Imports COH.Tools.Controls
Namespace Toolkit.Modding.Editors
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_Power_Editor
        Inherits COH_ModdableContent_Editor

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
            Me.TabControl_Powers = New System.Windows.Forms.TabControl()
            Me.TabPage3 = New System.Windows.Forms.TabPage()
            Me.Label_Valid = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Edit_SourceName = New System.Windows.Forms.TextBox()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.Edit_FullNameCRC = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Edit_SourceFile = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Edit_FullName = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Edit_DisplayNameKey = New System.Windows.Forms.TextBox()
            Me.Edit_DisplayName = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Edit_ClassName = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Edit_Tooltip = New System.Windows.Forms.TextBox()
            Me.Edit_Help = New System.Windows.Forms.TextBox()
            Me.Edit_Icon = New System.Windows.Forms.TextBox()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Edit_ToolTipKey = New System.Windows.Forms.TextBox()
            Me.Edit_HelpKey = New System.Windows.Forms.TextBox()
            Me.TabPage5 = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label72 = New System.Windows.Forms.Label()
            Me.Edit_VisualFX = New System.Windows.Forms.TextBox()
            Me.Label91 = New System.Windows.Forms.Label()
            Me.Edit_BoxSize_Z = New System.Windows.Forms.NumericUpDown()
            Me.Label71 = New System.Windows.Forms.Label()
            Me.Edit_BoxSize_Y = New System.Windows.Forms.NumericUpDown()
            Me.Select_ShowInventory = New System.Windows.Forms.ComboBox()
            Me.Edit_BoxSize_X = New System.Windows.Forms.NumericUpDown()
            Me.Check_Show_Manage = New System.Windows.Forms.CheckBox()
            Me.Label96 = New System.Windows.Forms.Label()
            Me.Check_Show_Info = New System.Windows.Forms.CheckBox()
            Me.Edit_Box_Z = New System.Windows.Forms.NumericUpDown()
            Me.Label79 = New System.Windows.Forms.Label()
            Me.Edit_Box_Y = New System.Windows.Forms.NumericUpDown()
            Me.CoH_ColorSelection1 = New COH.Toolkit.Controls.WinForms.COH_ColorSelection()
            Me.Edit_Box_X = New System.Windows.Forms.NumericUpDown()
            Me.Check_Show_Buff = New System.Windows.Forms.CheckBox()
            Me.Label95 = New System.Windows.Forms.Label()
            Me.Check_RefreshPlayerChange = New System.Windows.Forms.CheckBox()
            Me.Label84 = New System.Windows.Forms.Label()
            Me.Edit_HilightIcon = New System.Windows.Forms.TextBox()
            Me.Edit_Pos_Yaw = New System.Windows.Forms.NumericUpDown()
            Me.Check_ProcMain = New System.Windows.Forms.CheckBox()
            Me.Label89 = New System.Windows.Forms.Label()
            Me.Label85 = New System.Windows.Forms.Label()
            Me.Edit_Pos_Height = New System.Windows.Forms.NumericUpDown()
            Me.Check_AnimateMain = New System.Windows.Forms.CheckBox()
            Me.Label90 = New System.Windows.Forms.Label()
            Me.EditList_HighlightEval = New System.Windows.Forms.ListBox()
            Me.Check_FaceTarget = New System.Windows.Forms.CheckBox()
            Me.Label86 = New System.Windows.Forms.Label()
            Me.Label88 = New System.Windows.Forms.Label()
            Me.Edit_Pos_Centre = New System.Windows.Forms.NumericUpDown()
            Me.Label87 = New System.Windows.Forms.Label()
            Me.Edit_Pos_Distance = New System.Windows.Forms.NumericUpDown()
            Me.Check_DontSetStance = New System.Windows.Forms.CheckBox()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
            Me.Edit_Boost_MaxLevel = New System.Windows.Forms.NumericUpDown()
            Me.ListBox1 = New System.Windows.Forms.ListBox()
            Me.View_Variables = New System.Windows.Forms.ListView()
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Label103 = New System.Windows.Forms.Label()
            Me.Check_Boost_Combines = New System.Windows.Forms.CheckBox()
            Me.Edit_Boost_License = New System.Windows.Forms.NumericUpDown()
            Me.Check_Boost_AccountSet = New System.Windows.Forms.CheckBox()
            Me.Check_Boost_AccountBound = New System.Windows.Forms.CheckBox()
            Me.Check_Boost_IgnoreEffectiveness = New System.Windows.Forms.CheckBox()
            Me.Label82 = New System.Windows.Forms.Label()
            Me.Check_Toggle_Droppable = New System.Windows.Forms.CheckBox()
            Me.Check_Toggle_Stun = New System.Windows.Forms.CheckBox()
            Me.Check_Boost_UsePlayerLevel = New System.Windows.Forms.CheckBox()
            Me.Check_Boost_Trade = New System.Windows.Forms.CheckBox()
            Me.Check_Boost_Boostable = New System.Windows.Forms.CheckBox()
            Me.Check_TravelSuppress = New System.Windows.Forms.CheckBox()
            Me.Check_Toggle_Sleep = New System.Windows.Forms.CheckBox()
            Me.EditList_BoostsAllowed = New System.Windows.Forms.ListBox()
            Me.Label92 = New System.Windows.Forms.Label()
            Me.Edit_Boost_Catalyst = New System.Windows.Forms.TextBox()
            Me.Check_Toggle_IgnoreDisatance = New System.Windows.Forms.CheckBox()
            Me.Check_InterruptableSleep = New System.Windows.Forms.CheckBox()
            Me.Label81 = New System.Windows.Forms.Label()
            Me.Check_Toggle_Hold = New System.Windows.Forms.CheckBox()
            Me.Check_NearGround = New System.Windows.Forms.CheckBox()
            Me.Label83 = New System.Windows.Forms.Label()
            Me.Check_CanCancel = New System.Windows.Forms.CheckBox()
            Me.Check_IgnoreStrength = New System.Windows.Forms.CheckBox()
            Me.Check_IgnoreLevelBought = New System.Windows.Forms.CheckBox()
            Me.Edit_Usage_LifetimeGameMax = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Usage_LifetimeMax = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Usage_TimeMax = New System.Windows.Forms.NumericUpDown()
            Me.Check_Cast_Terrorize = New System.Windows.Forms.CheckBox()
            Me.Check_Cast_Sleep = New System.Windows.Forms.CheckBox()
            Me.Check_DestroyLimit = New System.Windows.Forms.CheckBox()
            Me.Check_StackingUsage = New System.Windows.Forms.CheckBox()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.Edit_Time_SelfConfirm = New System.Windows.Forms.NumericUpDown()
            Me.Check_Cast_Stun = New System.Windows.Forms.CheckBox()
            Me.Check_Cast_Hold = New System.Windows.Forms.CheckBox()
            Me.Label46 = New System.Windows.Forms.Label()
            Me.Edit_NumberCharges = New System.Windows.Forms.NumericUpDown()
            Me.Label57 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Select_Cast_Death = New System.Windows.Forms.ComboBox()
            Me.Edit_NumberChargesMax = New System.Windows.Forms.NumericUpDown()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.Label56 = New System.Windows.Forms.Label()
            Me.Edit_Cost_Idea = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Time_Recharge = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Time_ActivatePeriod = New System.Windows.Forms.NumericUpDown()
            Me.Label40 = New System.Windows.Forms.Label()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Edit_Usage_LifetimeGame = New System.Windows.Forms.NumericUpDown()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Edit_Usage_Lifetime = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Usage_Time = New System.Windows.Forms.NumericUpDown()
            Me.Label_Time_SelfConfirm = New System.Windows.Forms.Label()
            Me.Label42 = New System.Windows.Forms.Label()
            Me.Edit_Time_Activate = New System.Windows.Forms.NumericUpDown()
            Me.Label45 = New System.Windows.Forms.Label()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label51 = New System.Windows.Forms.Label()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.Edit_Time_Confirm = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Cost_Endurance = New System.Windows.Forms.NumericUpDown()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.Edit_Time_Interrupt = New System.Windows.Forms.NumericUpDown()
            Me.Edit_AttackTypes = New System.Windows.Forms.ListBox()
            Me.Check_Trade = New System.Windows.Forms.CheckBox()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Check_Delete = New System.Windows.Forms.CheckBox()
            Me.Check_AutoIssue = New System.Windows.Forms.CheckBox()
            Me.Check_AutoIssueSaveLevel = New System.Windows.Forms.CheckBox()
            Me.Check_Free = New System.Windows.Forms.CheckBox()
            Me.Check_AbusiveBuff = New System.Windows.Forms.CheckBox()
            Me.Check_InstanceLocked = New System.Windows.Forms.CheckBox()
            Me.Edit_ServerTray = New System.Windows.Forms.NumericUpDown()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label97 = New System.Windows.Forms.Label()
            Me.Select_PowerSystem = New System.Windows.Forms.ComboBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Select_PowerType = New System.Windows.Forms.ComboBox()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.Label64 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Edit_NumAllowed = New System.Windows.Forms.NumericUpDown()
            Me.Label75 = New System.Windows.Forms.Label()
            Me.Edit_Slot_Min = New System.Windows.Forms.NumericUpDown()
            Me.Edit_RewardFallback = New System.Windows.Forms.TextBox()
            Me.Label76 = New System.Windows.Forms.Label()
            Me.Label77 = New System.Windows.Forms.Label()
            Me.Edit_Slot_Max = New System.Windows.Forms.NumericUpDown()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label69 = New System.Windows.Forms.Label()
            Me.Edit_ChainPower = New System.Windows.Forms.TextBox()
            Me.Edit_StoreProduct = New System.Windows.Forms.TextBox()
            Me.Label74 = New System.Windows.Forms.Label()
            Me.Edit_PowerGroup = New System.Windows.Forms.ListBox()
            Me.Check_Boost_DontSave = New System.Windows.Forms.CheckBox()
            Me.Label80 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.TabPage7 = New System.Windows.Forms.TabPage()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label52 = New System.Windows.Forms.Label()
            Me.Edit_Ents_Affected = New System.Windows.Forms.ListBox()
            Me.Label102 = New System.Windows.Forms.Label()
            Me.Edit_Ents_Auto = New System.Windows.Forms.ListBox()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.Select_Target = New System.Windows.Forms.ComboBox()
            Me.Label101 = New System.Windows.Forms.Label()
            Me.Select_TargetVisibility = New System.Windows.Forms.ComboBox()
            Me.Label54 = New System.Windows.Forms.Label()
            Me.Label100 = New System.Windows.Forms.Label()
            Me.Label63 = New System.Windows.Forms.Label()
            Me.Check_Target_VisionPhase = New System.Windows.Forms.CheckBox()
            Me.Check_PowerRedirect = New System.Windows.Forms.CheckBox()
            Me.Check_ThroughUntouch = New System.Windows.Forms.CheckBox()
            Me.Edit_Range = New System.Windows.Forms.NumericUpDown()
            Me.Edit_Accuracy = New System.Windows.Forms.NumericUpDown()
            Me.Label61 = New System.Windows.Forms.Label()
            Me.Check_Target_Shuffle = New System.Windows.Forms.CheckBox()
            Me.Label65 = New System.Windows.Forms.Label()
            Me.Check_EviromentHit = New System.Windows.Forms.CheckBox()
            Me.Edit_Target_Radius = New System.Windows.Forms.NumericUpDown()
            Me.Check_Target_NearGround = New System.Windows.Forms.CheckBox()
            Me.Select_TargetSecondary = New System.Windows.Forms.ComboBox()
            Me.Edit_Target_MaxHit = New System.Windows.Forms.NumericUpDown()
            Me.Select_EffectArea = New System.Windows.Forms.ComboBox()
            Me.Label59 = New System.Windows.Forms.Label()
            Me.Label55 = New System.Windows.Forms.Label()
            Me.Edit_Target_Arc = New System.Windows.Forms.NumericUpDown()
            Me.Label58 = New System.Windows.Forms.Label()
            Me.Label60 = New System.Windows.Forms.Label()
            Me.Label62 = New System.Windows.Forms.Label()
            Me.Edit_Range_Secondary = New System.Windows.Forms.NumericUpDown()
            Me.TabPage4 = New System.Windows.Forms.TabPage()
            Me.Label98 = New System.Windows.Forms.Label()
            Me.EditList_AIGroups = New System.Windows.Forms.ListBox()
            Me.Edit_PreferenceMulti = New System.Windows.Forms.NumericUpDown()
            Me.Label78 = New System.Windows.Forms.Label()
            Me.Select_AIReport = New System.Windows.Forms.ComboBox()
            Me.Label73 = New System.Windows.Forms.Label()
            Me.Edit_ForceLevelBought = New System.Windows.Forms.NumericUpDown()
            Me.Label70 = New System.Windows.Forms.Label()
            Me.Label66 = New System.Windows.Forms.Label()
            Me.Edit_AI_Multiplier = New System.Windows.Forms.NumericUpDown()
            Me.Label67 = New System.Windows.Forms.Label()
            Me.Edit_AI_Point = New System.Windows.Forms.NumericUpDown()
            Me.Label68 = New System.Windows.Forms.Label()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.EditList_StrengthDis = New System.Windows.Forms.ListBox()
            Me.Label99 = New System.Windows.Forms.Label()
            Me.EditList_Modes_Disallowed = New System.Windows.Forms.ListBox()
            Me.Label93 = New System.Windows.Forms.Label()
            Me.EditList_Modes_Required = New System.Windows.Forms.ListBox()
            Me.Label94 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Confirm = New System.Windows.Forms.ListBox()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Auction = New System.Windows.Forms.ListBox()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Reward = New System.Windows.Forms.ListBox()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Target = New System.Windows.Forms.ListBox()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Slot = New System.Windows.Forms.ListBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Activate = New System.Windows.Forms.ListBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Edit_Requires_Buy = New System.Windows.Forms.ListBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.TabPage6 = New System.Windows.Forms.TabPage()
            Me.Edit_Confirm = New System.Windows.Forms.TextBox()
            Me.Button12 = New System.Windows.Forms.Button()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Edit_Confirm_Key = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Edit_Float_Defense = New System.Windows.Forms.TextBox()
            Me.Button13 = New System.Windows.Forms.Button()
            Me.Edit_Float_DefenseKey = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Edit_Float_Rewarded = New System.Windows.Forms.TextBox()
            Me.Button14 = New System.Windows.Forms.Button()
            Me.Edit_Float_RewardedKey = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Edit_Attacker_AttackF = New System.Windows.Forms.TextBox()
            Me.Button10 = New System.Windows.Forms.Button()
            Me.Edit_Attacker_Attack_Key = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Edit_Attacker_Attack = New System.Windows.Forms.TextBox()
            Me.Button11 = New System.Windows.Forms.Button()
            Me.Edit_Attacker_AttackF_Key = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Edit_Target_Help = New System.Windows.Forms.TextBox()
            Me.Button7 = New System.Windows.Forms.Button()
            Me.Edit_Target_Help_Key = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Edit_Target_Tooltip = New System.Windows.Forms.TextBox()
            Me.Button9 = New System.Windows.Forms.Button()
            Me.Edit_Target_Tooltip_Key = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Edit_Victim_Hit = New System.Windows.Forms.TextBox()
            Me.Button6 = New System.Windows.Forms.Button()
            Me.Edit_Victim_Hit_Key = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Edit_Attacker_Hit = New System.Windows.Forms.TextBox()
            Me.Button8 = New System.Windows.Forms.Button()
            Me.Edit_Attacker_Hit_Key = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.Label104 = New System.Windows.Forms.Label()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.TabPage12.SuspendLayout()
            Me.TabControl_Powers.SuspendLayout()
            Me.TabPage3.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage5.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            CType(Me.Edit_BoxSize_Z, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_BoxSize_Y, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_BoxSize_X, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Box_Z, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Box_Y, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Box_X, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Pos_Yaw, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Pos_Height, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Pos_Centre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Pos_Distance, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            Me.TableLayoutPanel6.SuspendLayout()
            CType(Me.Edit_Boost_MaxLevel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Boost_License, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Usage_LifetimeGameMax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Usage_LifetimeMax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Usage_TimeMax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Time_SelfConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_NumberCharges, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_NumberChargesMax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Cost_Idea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Time_Recharge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Time_ActivatePeriod, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Usage_LifetimeGame, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Usage_Lifetime, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Usage_Time, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Time_Activate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Time_Confirm, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Cost_Endurance, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Time_Interrupt, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_ServerTray, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_NumAllowed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Slot_Min, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Slot_Max, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage7.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.Edit_Range, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Accuracy, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Target_Radius, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Target_MaxHit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Target_Arc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_Range_Secondary, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage4.SuspendLayout()
            CType(Me.Edit_PreferenceMulti, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_ForceLevelBought, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_AI_Multiplier, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Edit_AI_Point, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage1.SuspendLayout()
            Me.TabPage6.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabPage12
            '
            Me.TabPage12.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
            Me.TabPage12.Controls.Add(Me.Panel2)
            Me.TabPage12.Controls.Add(Me.TabControl_Powers)
            Me.TabPage12.Size = New System.Drawing.Size(877, 473)
            '
            'TabControl_Powers
            '
            Me.TabControl_Powers.Controls.Add(Me.TabPage3)
            Me.TabControl_Powers.Controls.Add(Me.TabPage5)
            Me.TabControl_Powers.Controls.Add(Me.TabPage2)
            Me.TabControl_Powers.Controls.Add(Me.TabPage7)
            Me.TabControl_Powers.Controls.Add(Me.TabPage4)
            Me.TabControl_Powers.Controls.Add(Me.TabPage1)
            Me.TabControl_Powers.Controls.Add(Me.TabPage6)
            Me.TabControl_Powers.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl_Powers.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl_Powers.Location = New System.Drawing.Point(3, 3)
            Me.TabControl_Powers.Name = "TabControl_Powers"
            Me.TabControl_Powers.SelectedIndex = 0
            Me.TabControl_Powers.Size = New System.Drawing.Size(871, 467)
            Me.TabControl_Powers.TabIndex = 46
            '
            'TabPage3
            '
            Me.TabPage3.Controls.Add(Me.Label_Valid)
            Me.TabPage3.Controls.Add(Me.Label3)
            Me.TabPage3.Controls.Add(Me.Edit_SourceName)
            Me.TabPage3.Controls.Add(Me.Button4)
            Me.TabPage3.Controls.Add(Me.Edit_FullNameCRC)
            Me.TabPage3.Controls.Add(Me.Label2)
            Me.TabPage3.Controls.Add(Me.Edit_SourceFile)
            Me.TabPage3.Controls.Add(Me.Label1)
            Me.TabPage3.Controls.Add(Me.Edit_FullName)
            Me.TabPage3.Controls.Add(Me.Label6)
            Me.TabPage3.Controls.Add(Me.PictureBox1)
            Me.TabPage3.Controls.Add(Me.Label21)
            Me.TabPage3.Controls.Add(Me.Label12)
            Me.TabPage3.Controls.Add(Me.Button5)
            Me.TabPage3.Controls.Add(Me.Label15)
            Me.TabPage3.Controls.Add(Me.Edit_DisplayNameKey)
            Me.TabPage3.Controls.Add(Me.Edit_DisplayName)
            Me.TabPage3.Controls.Add(Me.Label5)
            Me.TabPage3.Controls.Add(Me.Edit_ClassName)
            Me.TabPage3.Controls.Add(Me.Label19)
            Me.TabPage3.Controls.Add(Me.Edit_Tooltip)
            Me.TabPage3.Controls.Add(Me.Edit_Help)
            Me.TabPage3.Controls.Add(Me.Edit_Icon)
            Me.TabPage3.Controls.Add(Me.Button3)
            Me.TabPage3.Controls.Add(Me.Button2)
            Me.TabPage3.Controls.Add(Me.Edit_ToolTipKey)
            Me.TabPage3.Controls.Add(Me.Edit_HelpKey)
            Me.TabPage3.Location = New System.Drawing.Point(4, 25)
            Me.TabPage3.Name = "TabPage3"
            Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage3.Size = New System.Drawing.Size(863, 438)
            Me.TabPage3.TabIndex = 0
            Me.TabPage3.Text = "General Information"
            Me.TabPage3.UseVisualStyleBackColor = True
            '
            'Label_Valid
            '
            Me.Label_Valid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label_Valid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label_Valid.Location = New System.Drawing.Point(713, 72)
            Me.Label_Valid.Name = "Label_Valid"
            Me.Label_Valid.Size = New System.Drawing.Size(114, 52)
            Me.Label_Valid.TabIndex = 58
            Me.Label_Valid.Text = "Valid Check : N/A"
            Me.Label_Valid.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(28, 101)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(94, 16)
            Me.Label3.TabIndex = 56
            Me.Label3.Text = "Source Name :"
            '
            'Edit_SourceName
            '
            Me.Edit_SourceName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_SourceName.Location = New System.Drawing.Point(129, 101)
            Me.Edit_SourceName.Name = "Edit_SourceName"
            Me.Edit_SourceName.Size = New System.Drawing.Size(579, 23)
            Me.Edit_SourceName.TabIndex = 57
            '
            'Button4
            '
            Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button4.Location = New System.Drawing.Point(832, 48)
            Me.Button4.Name = "Button4"
            Me.Button4.Size = New System.Drawing.Size(22, 22)
            Me.Button4.TabIndex = 55
            Me.Button4.UseVisualStyleBackColor = True
            '
            'Edit_FullNameCRC
            '
            Me.Edit_FullNameCRC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_FullNameCRC.Location = New System.Drawing.Point(713, 48)
            Me.Edit_FullNameCRC.Name = "Edit_FullNameCRC"
            Me.Edit_FullNameCRC.ReadOnly = True
            Me.Edit_FullNameCRC.Size = New System.Drawing.Size(115, 23)
            Me.Edit_FullNameCRC.TabIndex = 54
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(41, 75)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(81, 16)
            Me.Label2.TabIndex = 52
            Me.Label2.Text = "Source File :"
            '
            'Edit_SourceFile
            '
            Me.Edit_SourceFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_SourceFile.Location = New System.Drawing.Point(129, 75)
            Me.Edit_SourceFile.Name = "Edit_SourceFile"
            Me.Edit_SourceFile.Size = New System.Drawing.Size(579, 23)
            Me.Edit_SourceFile.TabIndex = 53
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(48, 51)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(74, 16)
            Me.Label1.TabIndex = 50
            Me.Label1.Text = "Full Name :"
            '
            'Edit_FullName
            '
            Me.Edit_FullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_FullName.Location = New System.Drawing.Point(128, 48)
            Me.Edit_FullName.Name = "Edit_FullName"
            Me.Edit_FullName.Size = New System.Drawing.Size(579, 23)
            Me.Edit_FullName.TabIndex = 51
            '
            'Label6
            '
            Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.BackColor = System.Drawing.Color.Black
            Me.Label6.ForeColor = System.Drawing.Color.White
            Me.Label6.Location = New System.Drawing.Point(0, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(906, 18)
            Me.Label6.TabIndex = 47
            Me.Label6.Text = "General Details :"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(128, 156)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
            Me.PictureBox1.TabIndex = 46
            Me.PictureBox1.TabStop = False
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(28, 131)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(94, 16)
            Me.Label21.TabIndex = 39
            Me.Label21.Text = "Display Name :"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(81, 159)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(41, 16)
            Me.Label12.TabIndex = 11
            Me.Label12.Text = "Icon :"
            '
            'Button5
            '
            Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button5.Location = New System.Drawing.Point(832, 129)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(22, 22)
            Me.Button5.TabIndex = 42
            Me.Button5.UseVisualStyleBackColor = True
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(80, 240)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(42, 16)
            Me.Label15.TabIndex = 14
            Me.Label15.Text = "Help :"
            '
            'Edit_DisplayNameKey
            '
            Me.Edit_DisplayNameKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_DisplayNameKey.Location = New System.Drawing.Point(713, 128)
            Me.Edit_DisplayNameKey.Name = "Edit_DisplayNameKey"
            Me.Edit_DisplayNameKey.ReadOnly = True
            Me.Edit_DisplayNameKey.Size = New System.Drawing.Size(115, 23)
            Me.Edit_DisplayNameKey.TabIndex = 41
            '
            'Edit_DisplayName
            '
            Me.Edit_DisplayName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_DisplayName.Location = New System.Drawing.Point(128, 128)
            Me.Edit_DisplayName.Name = "Edit_DisplayName"
            Me.Edit_DisplayName.Size = New System.Drawing.Size(579, 23)
            Me.Edit_DisplayName.TabIndex = 40
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(21, 188)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(101, 16)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Mouse ToolTip :"
            '
            'Edit_ClassName
            '
            Me.Edit_ClassName.Location = New System.Drawing.Point(128, 21)
            Me.Edit_ClassName.Name = "Edit_ClassName"
            Me.Edit_ClassName.ReadOnly = True
            Me.Edit_ClassName.Size = New System.Drawing.Size(329, 23)
            Me.Edit_ClassName.TabIndex = 35
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(75, 24)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(47, 16)
            Me.Label19.TabIndex = 34
            Me.Label19.Text = "Class :"
            '
            'Edit_Tooltip
            '
            Me.Edit_Tooltip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Tooltip.Location = New System.Drawing.Point(128, 185)
            Me.Edit_Tooltip.Multiline = True
            Me.Edit_Tooltip.Name = "Edit_Tooltip"
            Me.Edit_Tooltip.Size = New System.Drawing.Size(579, 50)
            Me.Edit_Tooltip.TabIndex = 22
            '
            'Edit_Help
            '
            Me.Edit_Help.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Help.Location = New System.Drawing.Point(128, 240)
            Me.Edit_Help.Multiline = True
            Me.Edit_Help.Name = "Edit_Help"
            Me.Edit_Help.Size = New System.Drawing.Size(580, 133)
            Me.Edit_Help.TabIndex = 23
            '
            'Edit_Icon
            '
            Me.Edit_Icon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_Icon.Location = New System.Drawing.Point(156, 156)
            Me.Edit_Icon.Name = "Edit_Icon"
            Me.Edit_Icon.Size = New System.Drawing.Size(552, 23)
            Me.Edit_Icon.TabIndex = 24
            '
            'Button3
            '
            Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button3.Location = New System.Drawing.Point(832, 240)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(22, 22)
            Me.Button3.TabIndex = 30
            Me.Button3.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Button2.Location = New System.Drawing.Point(832, 187)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(22, 22)
            Me.Button2.TabIndex = 29
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Edit_ToolTipKey
            '
            Me.Edit_ToolTipKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_ToolTipKey.Location = New System.Drawing.Point(713, 186)
            Me.Edit_ToolTipKey.Name = "Edit_ToolTipKey"
            Me.Edit_ToolTipKey.ReadOnly = True
            Me.Edit_ToolTipKey.Size = New System.Drawing.Size(115, 23)
            Me.Edit_ToolTipKey.TabIndex = 25
            '
            'Edit_HelpKey
            '
            Me.Edit_HelpKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Edit_HelpKey.Location = New System.Drawing.Point(713, 240)
            Me.Edit_HelpKey.Name = "Edit_HelpKey"
            Me.Edit_HelpKey.ReadOnly = True
            Me.Edit_HelpKey.Size = New System.Drawing.Size(115, 23)
            Me.Edit_HelpKey.TabIndex = 26
            '
            'TabPage5
            '
            Me.TabPage5.AutoScroll = True
            Me.TabPage5.Controls.Add(Me.TableLayoutPanel2)
            Me.TabPage5.Location = New System.Drawing.Point(4, 25)
            Me.TabPage5.Name = "TabPage5"
            Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage5.Size = New System.Drawing.Size(863, 438)
            Me.TabPage5.TabIndex = 7
            Me.TabPage5.Text = "Display"
            Me.TabPage5.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel2.ColumnCount = 4
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel2.Controls.Add(Me.Label72, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_VisualFX, 1, 12)
            Me.TableLayoutPanel2.Controls.Add(Me.Label91, 0, 12)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_BoxSize_Z, 3, 11)
            Me.TableLayoutPanel2.Controls.Add(Me.Label71, 0, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_BoxSize_Y, 2, 11)
            Me.TableLayoutPanel2.Controls.Add(Me.Select_ShowInventory, 1, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_BoxSize_X, 1, 11)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_Show_Manage, 2, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.Label96, 0, 11)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_Show_Info, 3, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Box_Z, 3, 10)
            Me.TableLayoutPanel2.Controls.Add(Me.Label79, 0, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Box_Y, 2, 10)
            Me.TableLayoutPanel2.Controls.Add(Me.CoH_ColorSelection1, 1, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Box_X, 1, 10)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_Show_Buff, 2, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.Label95, 0, 10)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_RefreshPlayerChange, 3, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.Label84, 0, 3)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_HilightIcon, 1, 3)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Pos_Yaw, 1, 9)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_ProcMain, 3, 7)
            Me.TableLayoutPanel2.Controls.Add(Me.Label89, 0, 9)
            Me.TableLayoutPanel2.Controls.Add(Me.Label85, 0, 4)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Pos_Height, 1, 8)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_AnimateMain, 3, 6)
            Me.TableLayoutPanel2.Controls.Add(Me.Label90, 0, 8)
            Me.TableLayoutPanel2.Controls.Add(Me.EditList_HighlightEval, 1, 4)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_FaceTarget, 2, 7)
            Me.TableLayoutPanel2.Controls.Add(Me.Label86, 0, 5)
            Me.TableLayoutPanel2.Controls.Add(Me.Label88, 0, 6)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Pos_Centre, 1, 6)
            Me.TableLayoutPanel2.Controls.Add(Me.Label87, 0, 7)
            Me.TableLayoutPanel2.Controls.Add(Me.Edit_Pos_Distance, 1, 7)
            Me.TableLayoutPanel2.Controls.Add(Me.Check_DontSetStance, 2, 6)
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 13
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(745, 443)
            Me.TableLayoutPanel2.TabIndex = 264
            '
            'Label72
            '
            Me.Label72.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel2.SetColumnSpan(Me.Label72, 4)
            Me.Label72.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label72.ForeColor = System.Drawing.Color.White
            Me.Label72.Location = New System.Drawing.Point(3, 0)
            Me.Label72.Name = "Label72"
            Me.Label72.Size = New System.Drawing.Size(739, 19)
            Me.Label72.TabIndex = 228
            Me.Label72.Text = "Display Options :"
            '
            'Edit_VisualFX
            '
            Me.TableLayoutPanel2.SetColumnSpan(Me.Edit_VisualFX, 3)
            Me.Edit_VisualFX.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_VisualFX.Location = New System.Drawing.Point(203, 415)
            Me.Edit_VisualFX.Name = "Edit_VisualFX"
            Me.Edit_VisualFX.Size = New System.Drawing.Size(539, 23)
            Me.Edit_VisualFX.TabIndex = 255
            '
            'Label91
            '
            Me.Label91.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label91.Location = New System.Drawing.Point(3, 412)
            Me.Label91.Name = "Label91"
            Me.Label91.Size = New System.Drawing.Size(194, 56)
            Me.Label91.TabIndex = 254
            Me.Label91.Text = "Visual FX :"
            Me.Label91.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Edit_BoxSize_Z
            '
            Me.Edit_BoxSize_Z.DecimalPlaces = 6
            Me.Edit_BoxSize_Z.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_BoxSize_Z.Location = New System.Drawing.Point(565, 378)
            Me.Edit_BoxSize_Z.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_BoxSize_Z.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_BoxSize_Z.Name = "Edit_BoxSize_Z"
            Me.Edit_BoxSize_Z.Size = New System.Drawing.Size(177, 23)
            Me.Edit_BoxSize_Z.TabIndex = 263
            '
            'Label71
            '
            Me.Label71.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label71.Location = New System.Drawing.Point(3, 19)
            Me.Label71.Name = "Label71"
            Me.Label71.Size = New System.Drawing.Size(194, 34)
            Me.Label71.TabIndex = 229
            Me.Label71.Text = "Show In Inventory :"
            Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_BoxSize_Y
            '
            Me.Edit_BoxSize_Y.DecimalPlaces = 6
            Me.Edit_BoxSize_Y.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_BoxSize_Y.Location = New System.Drawing.Point(384, 378)
            Me.Edit_BoxSize_Y.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_BoxSize_Y.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_BoxSize_Y.Name = "Edit_BoxSize_Y"
            Me.Edit_BoxSize_Y.Size = New System.Drawing.Size(175, 23)
            Me.Edit_BoxSize_Y.TabIndex = 262
            '
            'Select_ShowInventory
            '
            Me.Select_ShowInventory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_ShowInventory.FormattingEnabled = True
            Me.Select_ShowInventory.Location = New System.Drawing.Point(203, 22)
            Me.Select_ShowInventory.Name = "Select_ShowInventory"
            Me.Select_ShowInventory.Size = New System.Drawing.Size(175, 24)
            Me.Select_ShowInventory.TabIndex = 230
            '
            'Edit_BoxSize_X
            '
            Me.Edit_BoxSize_X.DecimalPlaces = 6
            Me.Edit_BoxSize_X.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_BoxSize_X.Location = New System.Drawing.Point(203, 378)
            Me.Edit_BoxSize_X.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_BoxSize_X.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_BoxSize_X.Name = "Edit_BoxSize_X"
            Me.Edit_BoxSize_X.Size = New System.Drawing.Size(175, 23)
            Me.Edit_BoxSize_X.TabIndex = 261
            '
            'Check_Show_Manage
            '
            Me.Check_Show_Manage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Show_Manage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Show_Manage.Location = New System.Drawing.Point(384, 22)
            Me.Check_Show_Manage.Name = "Check_Show_Manage"
            Me.Check_Show_Manage.Size = New System.Drawing.Size(175, 28)
            Me.Check_Show_Manage.TabIndex = 232
            Me.Check_Show_Manage.Text = "Show In Manage :"
            Me.Check_Show_Manage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Show_Manage.UseVisualStyleBackColor = True
            '
            'Label96
            '
            Me.Label96.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label96.Location = New System.Drawing.Point(3, 375)
            Me.Label96.Name = "Label96"
            Me.Label96.Size = New System.Drawing.Size(194, 37)
            Me.Label96.TabIndex = 260
            Me.Label96.Text = "Box Offset :"
            Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_Show_Info
            '
            Me.Check_Show_Info.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Show_Info.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Show_Info.Location = New System.Drawing.Point(565, 22)
            Me.Check_Show_Info.Name = "Check_Show_Info"
            Me.Check_Show_Info.Size = New System.Drawing.Size(177, 28)
            Me.Check_Show_Info.TabIndex = 233
            Me.Check_Show_Info.Text = "Show In Info :"
            Me.Check_Show_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Show_Info.UseVisualStyleBackColor = True
            '
            'Edit_Box_Z
            '
            Me.Edit_Box_Z.DecimalPlaces = 6
            Me.Edit_Box_Z.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Box_Z.Location = New System.Drawing.Point(565, 347)
            Me.Edit_Box_Z.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Box_Z.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Box_Z.Name = "Edit_Box_Z"
            Me.Edit_Box_Z.Size = New System.Drawing.Size(177, 23)
            Me.Edit_Box_Z.TabIndex = 259
            '
            'Label79
            '
            Me.Label79.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label79.Location = New System.Drawing.Point(3, 53)
            Me.Label79.Name = "Label79"
            Me.Label79.Size = New System.Drawing.Size(194, 31)
            Me.Label79.TabIndex = 235
            Me.Label79.Text = "Highlight Ring :"
            Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Box_Y
            '
            Me.Edit_Box_Y.DecimalPlaces = 6
            Me.Edit_Box_Y.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Box_Y.Location = New System.Drawing.Point(384, 347)
            Me.Edit_Box_Y.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Box_Y.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Box_Y.Name = "Edit_Box_Y"
            Me.Edit_Box_Y.Size = New System.Drawing.Size(175, 23)
            Me.Edit_Box_Y.TabIndex = 258
            '
            'CoH_ColorSelection1
            '
            Me.CoH_ColorSelection1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CoH_ColorSelection1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.CoH_ColorSelection1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CoH_ColorSelection1.FormattingEnabled = True
            Me.CoH_ColorSelection1.ItemHeight = 20
            Me.CoH_ColorSelection1.Items.AddRange(New Object() {"Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen", "Custom", "CornflowerBlue", "White", "Transparent", "Black", "DimGray", "Yellow", "DodgerBlue", "Magenta", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "YellowGreen", "Custom", "CornflowerBlue", "White", "Transparent", "Black", "DimGray", "Yellow", "DodgerBlue", "Magenta", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "YellowGreen", "Custom", "CornflowerBlue", "White", "Transparent", "Black", "DimGray", "Yellow", "DodgerBlue", "Magenta", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "YellowGreen", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "Custom", "YellowGreen", "OliveDrab", "CornflowerBlue", "Black", "White", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "CornflowerBlue", "Black", "White", "DimGray", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "YellowGreen", "CornflowerBlue", "Black", "White", "DimGray", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "YellowGreen", "CornflowerBlue", "Black", "White", "DimGray", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "WhiteSmoke", "Yellow", "YellowGreen", "Transparent", "AliceBlue", "AntiqueWhite", "Aqua", "Aquamarine", "Azure", "Beige", "Bisque", "Black", "BlanchedAlmond", "Blue", "BlueViolet", "Brown", "BurlyWood", "CadetBlue", "Chartreuse", "Chocolate", "Coral", "CornflowerBlue", "Cornsilk", "Crimson", "Cyan", "DarkBlue", "DarkCyan", "DarkGoldenrod", "DarkGray", "DarkGreen", "DarkKhaki", "DarkMagenta", "DarkOliveGreen", "DarkOrange", "DarkOrchid", "DarkRed", "DarkSalmon", "DarkSeaGreen", "DarkSlateBlue", "DarkSlateGray", "DarkTurquoise", "DarkViolet", "DeepPink", "DeepSkyBlue", "DimGray", "DodgerBlue", "Firebrick", "FloralWhite", "ForestGreen", "Fuchsia", "Gainsboro", "GhostWhite", "Gold", "Goldenrod", "Gray", "Green", "GreenYellow", "Honeydew", "HotPink", "IndianRed", "Indigo", "Ivory", "Khaki", "Lavender", "LavenderBlush", "LawnGreen", "LemonChiffon", "LightBlue", "LightCoral", "LightCyan", "LightGoldenrodYellow", "LightGreen", "LightGray", "LightPink", "LightSalmon", "LightSeaGreen", "LightSkyBlue", "LightSlateGray", "LightSteelBlue", "LightYellow", "Lime", "LimeGreen", "Linen", "Magenta", "Maroon", "MediumAquamarine", "MediumBlue", "MediumOrchid", "MediumPurple", "MediumSeaGreen", "MediumSlateBlue", "MediumSpringGreen", "MediumTurquoise", "MediumVioletRed", "MidnightBlue", "MintCream", "MistyRose", "Moccasin", "NavajoWhite", "Navy", "OldLace", "Olive", "OliveDrab", "Orange", "OrangeRed", "Orchid", "PaleGoldenrod", "PaleGreen", "PaleTurquoise", "PaleVioletRed", "PapayaWhip", "PeachPuff", "Peru", "Pink", "Plum", "PowderBlue", "Purple", "Red", "RosyBrown", "RoyalBlue", "SaddleBrown", "Salmon", "SandyBrown", "SeaGreen", "SeaShell", "Sienna", "Silver", "SkyBlue", "SlateBlue", "SlateGray", "Snow", "SpringGreen", "SteelBlue", "Tan", "Teal", "Thistle", "Tomato", "Turquoise", "Violet", "Wheat", "White", "WhiteSmoke", "Yellow", "YellowGreen"})
            Me.CoH_ColorSelection1.Location = New System.Drawing.Point(203, 56)
            Me.CoH_ColorSelection1.Name = "CoH_ColorSelection1"
            Me.CoH_ColorSelection1.Size = New System.Drawing.Size(175, 26)
            Me.CoH_ColorSelection1.TabIndex = 234
            '
            'Edit_Box_X
            '
            Me.Edit_Box_X.DecimalPlaces = 6
            Me.Edit_Box_X.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Box_X.Location = New System.Drawing.Point(203, 347)
            Me.Edit_Box_X.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Box_X.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Box_X.Name = "Edit_Box_X"
            Me.Edit_Box_X.Size = New System.Drawing.Size(175, 23)
            Me.Edit_Box_X.TabIndex = 257
            '
            'Check_Show_Buff
            '
            Me.Check_Show_Buff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Show_Buff.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Show_Buff.Location = New System.Drawing.Point(384, 56)
            Me.Check_Show_Buff.Name = "Check_Show_Buff"
            Me.Check_Show_Buff.Size = New System.Drawing.Size(175, 25)
            Me.Check_Show_Buff.TabIndex = 231
            Me.Check_Show_Buff.Text = "Show Buff Icon :"
            Me.Check_Show_Buff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Show_Buff.UseVisualStyleBackColor = True
            '
            'Label95
            '
            Me.Label95.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label95.Location = New System.Drawing.Point(3, 344)
            Me.Label95.Name = "Label95"
            Me.Label95.Size = New System.Drawing.Size(194, 31)
            Me.Label95.TabIndex = 256
            Me.Label95.Text = "Box Offset :"
            Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_RefreshPlayerChange
            '
            Me.Check_RefreshPlayerChange.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_RefreshPlayerChange.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_RefreshPlayerChange.Location = New System.Drawing.Point(565, 56)
            Me.Check_RefreshPlayerChange.Name = "Check_RefreshPlayerChange"
            Me.Check_RefreshPlayerChange.Size = New System.Drawing.Size(177, 25)
            Me.Check_RefreshPlayerChange.TabIndex = 236
            Me.Check_RefreshPlayerChange.Text = "Refreshes on Active Player Change :"
            Me.Check_RefreshPlayerChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_RefreshPlayerChange.UseVisualStyleBackColor = True
            '
            'Label84
            '
            Me.Label84.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label84.Location = New System.Drawing.Point(3, 84)
            Me.Label84.Name = "Label84"
            Me.Label84.Size = New System.Drawing.Size(194, 30)
            Me.Label84.TabIndex = 237
            Me.Label84.Text = "Highlight Icon :"
            Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_HilightIcon
            '
            Me.TableLayoutPanel2.SetColumnSpan(Me.Edit_HilightIcon, 2)
            Me.Edit_HilightIcon.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_HilightIcon.Location = New System.Drawing.Point(203, 87)
            Me.Edit_HilightIcon.Name = "Edit_HilightIcon"
            Me.Edit_HilightIcon.Size = New System.Drawing.Size(356, 23)
            Me.Edit_HilightIcon.TabIndex = 238
            '
            'Edit_Pos_Yaw
            '
            Me.Edit_Pos_Yaw.DecimalPlaces = 6
            Me.Edit_Pos_Yaw.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Pos_Yaw.Location = New System.Drawing.Point(203, 316)
            Me.Edit_Pos_Yaw.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Pos_Yaw.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Pos_Yaw.Name = "Edit_Pos_Yaw"
            Me.Edit_Pos_Yaw.Size = New System.Drawing.Size(175, 23)
            Me.Edit_Pos_Yaw.TabIndex = 250
            '
            'Check_ProcMain
            '
            Me.Check_ProcMain.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_ProcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_ProcMain.Location = New System.Drawing.Point(565, 255)
            Me.Check_ProcMain.Name = "Check_ProcMain"
            Me.Check_ProcMain.Size = New System.Drawing.Size(177, 26)
            Me.Check_ProcMain.TabIndex = 253
            Me.Check_ProcMain.Text = "Proc Main Target Only :"
            Me.Check_ProcMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_ProcMain.UseVisualStyleBackColor = True
            '
            'Label89
            '
            Me.Label89.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label89.Location = New System.Drawing.Point(3, 313)
            Me.Label89.Name = "Label89"
            Me.Label89.Size = New System.Drawing.Size(194, 31)
            Me.Label89.TabIndex = 249
            Me.Label89.Text = "Position Yaw :"
            Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label85
            '
            Me.Label85.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label85.Location = New System.Drawing.Point(3, 114)
            Me.Label85.Name = "Label85"
            Me.Label85.Size = New System.Drawing.Size(194, 90)
            Me.Label85.TabIndex = 240
            Me.Label85.Text = "Highlight Eval :"
            Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Pos_Height
            '
            Me.Edit_Pos_Height.DecimalPlaces = 6
            Me.Edit_Pos_Height.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Pos_Height.Location = New System.Drawing.Point(203, 287)
            Me.Edit_Pos_Height.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Pos_Height.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Pos_Height.Name = "Edit_Pos_Height"
            Me.Edit_Pos_Height.Size = New System.Drawing.Size(175, 23)
            Me.Edit_Pos_Height.TabIndex = 248
            '
            'Check_AnimateMain
            '
            Me.Check_AnimateMain.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AnimateMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_AnimateMain.Location = New System.Drawing.Point(565, 227)
            Me.Check_AnimateMain.Name = "Check_AnimateMain"
            Me.Check_AnimateMain.Size = New System.Drawing.Size(177, 22)
            Me.Check_AnimateMain.TabIndex = 252
            Me.Check_AnimateMain.Text = "Animate Main Target Only :"
            Me.Check_AnimateMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AnimateMain.UseVisualStyleBackColor = True
            '
            'Label90
            '
            Me.Label90.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label90.Location = New System.Drawing.Point(3, 284)
            Me.Label90.Name = "Label90"
            Me.Label90.Size = New System.Drawing.Size(194, 29)
            Me.Label90.TabIndex = 247
            Me.Label90.Text = "Position Height :"
            Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'EditList_HighlightEval
            '
            Me.TableLayoutPanel2.SetColumnSpan(Me.EditList_HighlightEval, 2)
            Me.EditList_HighlightEval.Dock = System.Windows.Forms.DockStyle.Fill
            Me.EditList_HighlightEval.FormattingEnabled = True
            Me.EditList_HighlightEval.ItemHeight = 16
            Me.EditList_HighlightEval.Location = New System.Drawing.Point(203, 117)
            Me.EditList_HighlightEval.Name = "EditList_HighlightEval"
            Me.EditList_HighlightEval.Size = New System.Drawing.Size(356, 84)
            Me.EditList_HighlightEval.TabIndex = 239
            '
            'Check_FaceTarget
            '
            Me.Check_FaceTarget.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_FaceTarget.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_FaceTarget.Location = New System.Drawing.Point(384, 255)
            Me.Check_FaceTarget.Name = "Check_FaceTarget"
            Me.Check_FaceTarget.Size = New System.Drawing.Size(175, 26)
            Me.Check_FaceTarget.TabIndex = 251
            Me.Check_FaceTarget.Text = "Face Target :"
            Me.Check_FaceTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_FaceTarget.UseVisualStyleBackColor = True
            '
            'Label86
            '
            Me.Label86.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel2.SetColumnSpan(Me.Label86, 4)
            Me.Label86.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label86.ForeColor = System.Drawing.Color.White
            Me.Label86.Location = New System.Drawing.Point(3, 204)
            Me.Label86.Name = "Label86"
            Me.Label86.Size = New System.Drawing.Size(739, 20)
            Me.Label86.TabIndex = 241
            Me.Label86.Text = "FX / Animation Options :"
            '
            'Label88
            '
            Me.Label88.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label88.Location = New System.Drawing.Point(3, 224)
            Me.Label88.Name = "Label88"
            Me.Label88.Size = New System.Drawing.Size(194, 28)
            Me.Label88.TabIndex = 243
            Me.Label88.Text = "Position Centre :"
            Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Pos_Centre
            '
            Me.Edit_Pos_Centre.DecimalPlaces = 6
            Me.Edit_Pos_Centre.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Pos_Centre.Location = New System.Drawing.Point(203, 227)
            Me.Edit_Pos_Centre.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Pos_Centre.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Pos_Centre.Name = "Edit_Pos_Centre"
            Me.Edit_Pos_Centre.Size = New System.Drawing.Size(175, 23)
            Me.Edit_Pos_Centre.TabIndex = 244
            '
            'Label87
            '
            Me.Label87.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label87.Location = New System.Drawing.Point(3, 252)
            Me.Label87.Name = "Label87"
            Me.Label87.Size = New System.Drawing.Size(194, 32)
            Me.Label87.TabIndex = 245
            Me.Label87.Text = "Position Distance :"
            Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Pos_Distance
            '
            Me.Edit_Pos_Distance.DecimalPlaces = 6
            Me.Edit_Pos_Distance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Pos_Distance.Location = New System.Drawing.Point(203, 255)
            Me.Edit_Pos_Distance.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Pos_Distance.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Pos_Distance.Name = "Edit_Pos_Distance"
            Me.Edit_Pos_Distance.Size = New System.Drawing.Size(175, 23)
            Me.Edit_Pos_Distance.TabIndex = 246
            '
            'Check_DontSetStance
            '
            Me.Check_DontSetStance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_DontSetStance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_DontSetStance.Location = New System.Drawing.Point(384, 227)
            Me.Check_DontSetStance.Name = "Check_DontSetStance"
            Me.Check_DontSetStance.Size = New System.Drawing.Size(175, 22)
            Me.Check_DontSetStance.TabIndex = 242
            Me.Check_DontSetStance.Text = "Don't Set Stance :"
            Me.Check_DontSetStance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_DontSetStance.UseVisualStyleBackColor = True
            '
            'TabPage2
            '
            Me.TabPage2.AutoScroll = True
            Me.TabPage2.Controls.Add(Me.TableLayoutPanel6)
            Me.TabPage2.Controls.Add(Me.Label33)
            Me.TabPage2.Location = New System.Drawing.Point(4, 25)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Size = New System.Drawing.Size(863, 438)
            Me.TabPage2.TabIndex = 5
            Me.TabPage2.Text = "Usage Options"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel6
            '
            Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel6.ColumnCount = 4
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Boost_MaxLevel, 1, 34)
            Me.TableLayoutPanel6.Controls.Add(Me.ListBox1, 3, 34)
            Me.TableLayoutPanel6.Controls.Add(Me.View_Variables, 0, 37)
            Me.TableLayoutPanel6.Controls.Add(Me.Label103, 0, 36)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_Combines, 2, 32)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Boost_License, 1, 35)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_AccountSet, 0, 33)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_AccountBound, 2, 33)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_IgnoreEffectiveness, 0, 32)
            Me.TableLayoutPanel6.Controls.Add(Me.Label82, 0, 34)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Toggle_Droppable, 3, 27)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Toggle_Stun, 2, 27)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_UsePlayerLevel, 1, 33)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_Trade, 1, 32)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_Boostable, 3, 33)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_TravelSuppress, 2, 28)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Toggle_Sleep, 1, 27)
            Me.TableLayoutPanel6.Controls.Add(Me.EditList_BoostsAllowed, 1, 31)
            Me.TableLayoutPanel6.Controls.Add(Me.Label92, 0, 31)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Boost_Catalyst, 1, 30)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Toggle_IgnoreDisatance, 0, 28)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_InterruptableSleep, 1, 28)
            Me.TableLayoutPanel6.Controls.Add(Me.Label81, 0, 30)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Toggle_Hold, 0, 27)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_NearGround, 3, 25)
            Me.TableLayoutPanel6.Controls.Add(Me.Label83, 0, 29)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_CanCancel, 2, 25)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_IgnoreStrength, 1, 25)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_IgnoreLevelBought, 0, 25)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Usage_LifetimeGameMax, 3, 19)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Usage_LifetimeMax, 3, 18)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Usage_TimeMax, 3, 17)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Cast_Terrorize, 3, 24)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Cast_Sleep, 2, 24)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_DestroyLimit, 1, 24)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_StackingUsage, 0, 24)
            Me.TableLayoutPanel6.Controls.Add(Me.Label37, 0, 26)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Time_SelfConfirm, 3, 15)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Cast_Stun, 1, 23)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Cast_Hold, 0, 23)
            Me.TableLayoutPanel6.Controls.Add(Me.Label46, 2, 18)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_NumberCharges, 1, 22)
            Me.TableLayoutPanel6.Controls.Add(Me.Label57, 0, 22)
            Me.TableLayoutPanel6.Controls.Add(Me.Label50, 2, 17)
            Me.TableLayoutPanel6.Controls.Add(Me.Label43, 2, 19)
            Me.TableLayoutPanel6.Controls.Add(Me.Select_Cast_Death, 1, 21)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_NumberChargesMax, 3, 22)
            Me.TableLayoutPanel6.Controls.Add(Me.Label35, 0, 21)
            Me.TableLayoutPanel6.Controls.Add(Me.Label56, 2, 22)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Cost_Idea, 3, 14)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Time_Recharge, 3, 13)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Time_ActivatePeriod, 3, 12)
            Me.TableLayoutPanel6.Controls.Add(Me.Label40, 2, 12)
            Me.TableLayoutPanel6.Controls.Add(Me.Label38, 2, 13)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Usage_LifetimeGame, 1, 19)
            Me.TableLayoutPanel6.Controls.Add(Me.Label34, 0, 20)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Usage_Lifetime, 1, 18)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Usage_Time, 1, 17)
            Me.TableLayoutPanel6.Controls.Add(Me.Label_Time_SelfConfirm, 2, 15)
            Me.TableLayoutPanel6.Controls.Add(Me.Label42, 2, 14)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Time_Activate, 1, 12)
            Me.TableLayoutPanel6.Controls.Add(Me.Label45, 0, 19)
            Me.TableLayoutPanel6.Controls.Add(Me.Label48, 0, 18)
            Me.TableLayoutPanel6.Controls.Add(Me.Label51, 0, 17)
            Me.TableLayoutPanel6.Controls.Add(Me.Label36, 0, 12)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Time_Confirm, 1, 15)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Cost_Endurance, 1, 14)
            Me.TableLayoutPanel6.Controls.Add(Me.Label47, 0, 16)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Time_Interrupt, 1, 13)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_AttackTypes, 1, 3)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Trade, 0, 8)
            Me.TableLayoutPanel6.Controls.Add(Me.Label44, 0, 15)
            Me.TableLayoutPanel6.Controls.Add(Me.Label39, 0, 14)
            Me.TableLayoutPanel6.Controls.Add(Me.Label49, 0, 13)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Delete, 0, 9)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_AutoIssue, 0, 10)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_AutoIssueSaveLevel, 1, 10)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Free, 3, 10)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_AbusiveBuff, 3, 9)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_InstanceLocked, 3, 8)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_ServerTray, 3, 7)
            Me.TableLayoutPanel6.Controls.Add(Me.Label17, 0, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.Label97, 2, 7)
            Me.TableLayoutPanel6.Controls.Add(Me.Select_PowerSystem, 1, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.Label18, 0, 1)
            Me.TableLayoutPanel6.Controls.Add(Me.Select_PowerType, 1, 1)
            Me.TableLayoutPanel6.Controls.Add(Me.Label41, 0, 11)
            Me.TableLayoutPanel6.Controls.Add(Me.Label64, 2, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.Label24, 0, 2)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_NumAllowed, 1, 2)
            Me.TableLayoutPanel6.Controls.Add(Me.Label75, 2, 2)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Slot_Min, 1, 7)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_RewardFallback, 1, 6)
            Me.TableLayoutPanel6.Controls.Add(Me.Label76, 0, 7)
            Me.TableLayoutPanel6.Controls.Add(Me.Label77, 0, 6)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_Slot_Max, 3, 2)
            Me.TableLayoutPanel6.Controls.Add(Me.Label23, 0, 3)
            Me.TableLayoutPanel6.Controls.Add(Me.Label69, 0, 4)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_ChainPower, 1, 4)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_StoreProduct, 1, 5)
            Me.TableLayoutPanel6.Controls.Add(Me.Label74, 0, 5)
            Me.TableLayoutPanel6.Controls.Add(Me.Edit_PowerGroup, 3, 0)
            Me.TableLayoutPanel6.Controls.Add(Me.Check_Boost_DontSave, 3, 32)
            Me.TableLayoutPanel6.Controls.Add(Me.Label80, 0, 35)
            Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 20)
            Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
            Me.TableLayoutPanel6.RowCount = 38
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
            Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
            Me.TableLayoutPanel6.Size = New System.Drawing.Size(619, 1345)
            Me.TableLayoutPanel6.TabIndex = 241
            '
            'Edit_Boost_MaxLevel
            '
            Me.Edit_Boost_MaxLevel.DecimalPlaces = 6
            Me.Edit_Boost_MaxLevel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Boost_MaxLevel.Location = New System.Drawing.Point(203, 1096)
            Me.Edit_Boost_MaxLevel.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Boost_MaxLevel.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Boost_MaxLevel.Name = "Edit_Boost_MaxLevel"
            Me.Edit_Boost_MaxLevel.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Boost_MaxLevel.TabIndex = 221
            '
            'ListBox1
            '
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.ItemHeight = 16
            Me.ListBox1.Location = New System.Drawing.Point(481, 1096)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(135, 20)
            Me.ListBox1.TabIndex = 94
            '
            'View_Variables
            '
            Me.View_Variables.BackColor = System.Drawing.Color.SlateGray
            Me.View_Variables.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
            Me.TableLayoutPanel6.SetColumnSpan(Me.View_Variables, 4)
            Me.View_Variables.Dock = System.Windows.Forms.DockStyle.Fill
            Me.View_Variables.FullRowSelect = True
            Me.View_Variables.GridLines = True
            Me.View_Variables.HideSelection = False
            Me.View_Variables.Location = New System.Drawing.Point(3, 1177)
            Me.View_Variables.Name = "View_Variables"
            Me.View_Variables.Size = New System.Drawing.Size(613, 165)
            Me.View_Variables.TabIndex = 234
            Me.View_Variables.UseCompatibleStateImageBehavior = False
            Me.View_Variables.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Index"
            Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader2.Width = 90
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Name"
            Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader1.Width = 271
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Min"
            Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader3.Width = 75
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Max"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader4.Width = 70
            '
            'Label103
            '
            Me.Label103.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel6.SetColumnSpan(Me.Label103, 4)
            Me.Label103.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label103.ForeColor = System.Drawing.Color.White
            Me.Label103.Location = New System.Drawing.Point(3, 1155)
            Me.Label103.Name = "Label103"
            Me.Label103.Size = New System.Drawing.Size(613, 19)
            Me.Label103.TabIndex = 235
            Me.Label103.Text = "Vars :"
            '
            'Check_Boost_Combines
            '
            Me.Check_Boost_Combines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_Combines.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_Combines.Location = New System.Drawing.Point(342, 1019)
            Me.Check_Boost_Combines.Name = "Check_Boost_Combines"
            Me.Check_Boost_Combines.Size = New System.Drawing.Size(133, 42)
            Me.Check_Boost_Combines.TabIndex = 204
            Me.Check_Boost_Combines.Text = "Boost Combine :"
            Me.Check_Boost_Combines.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_Combines.UseVisualStyleBackColor = True
            '
            'Edit_Boost_License
            '
            Me.Edit_Boost_License.DecimalPlaces = 6
            Me.Edit_Boost_License.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Boost_License.Location = New System.Drawing.Point(203, 1128)
            Me.Edit_Boost_License.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Boost_License.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Boost_License.Name = "Edit_Boost_License"
            Me.Edit_Boost_License.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Boost_License.TabIndex = 223
            '
            'Check_Boost_AccountSet
            '
            Me.Check_Boost_AccountSet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_AccountSet.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_AccountSet.Location = New System.Drawing.Point(3, 1067)
            Me.Check_Boost_AccountSet.Name = "Check_Boost_AccountSet"
            Me.Check_Boost_AccountSet.Size = New System.Drawing.Size(194, 23)
            Me.Check_Boost_AccountSet.TabIndex = 209
            Me.Check_Boost_AccountSet.Text = "Always Count For Set :"
            Me.Check_Boost_AccountSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_AccountSet.UseVisualStyleBackColor = True
            '
            'Check_Boost_AccountBound
            '
            Me.Check_Boost_AccountBound.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_AccountBound.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_AccountBound.Location = New System.Drawing.Point(342, 1067)
            Me.Check_Boost_AccountBound.Name = "Check_Boost_AccountBound"
            Me.Check_Boost_AccountBound.Size = New System.Drawing.Size(133, 23)
            Me.Check_Boost_AccountBound.TabIndex = 210
            Me.Check_Boost_AccountBound.Text = "Account Bound :"
            Me.Check_Boost_AccountBound.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_AccountBound.UseVisualStyleBackColor = True
            '
            'Check_Boost_IgnoreEffectiveness
            '
            Me.Check_Boost_IgnoreEffectiveness.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_IgnoreEffectiveness.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_IgnoreEffectiveness.Location = New System.Drawing.Point(3, 1019)
            Me.Check_Boost_IgnoreEffectiveness.Name = "Check_Boost_IgnoreEffectiveness"
            Me.Check_Boost_IgnoreEffectiveness.Size = New System.Drawing.Size(194, 42)
            Me.Check_Boost_IgnoreEffectiveness.TabIndex = 201
            Me.Check_Boost_IgnoreEffectiveness.Text = "Ignore Effectiveness :"
            Me.Check_Boost_IgnoreEffectiveness.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_IgnoreEffectiveness.UseVisualStyleBackColor = True
            '
            'Label82
            '
            Me.Label82.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label82.Location = New System.Drawing.Point(3, 1093)
            Me.Label82.Name = "Label82"
            Me.Label82.Size = New System.Drawing.Size(194, 32)
            Me.Label82.TabIndex = 220
            Me.Label82.Text = "Max Boost :"
            Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_Toggle_Droppable
            '
            Me.Check_Toggle_Droppable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Droppable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Toggle_Droppable.Location = New System.Drawing.Point(481, 819)
            Me.Check_Toggle_Droppable.Name = "Check_Toggle_Droppable"
            Me.Check_Toggle_Droppable.Size = New System.Drawing.Size(135, 21)
            Me.Check_Toggle_Droppable.TabIndex = 138
            Me.Check_Toggle_Droppable.Text = "Droppable :"
            Me.Check_Toggle_Droppable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Droppable.UseVisualStyleBackColor = True
            '
            'Check_Toggle_Stun
            '
            Me.Check_Toggle_Stun.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Stun.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Toggle_Stun.Location = New System.Drawing.Point(342, 819)
            Me.Check_Toggle_Stun.Name = "Check_Toggle_Stun"
            Me.Check_Toggle_Stun.Size = New System.Drawing.Size(133, 21)
            Me.Check_Toggle_Stun.TabIndex = 93
            Me.Check_Toggle_Stun.Text = "Ignore Stun :"
            Me.Check_Toggle_Stun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Stun.UseVisualStyleBackColor = True
            '
            'Check_Boost_UsePlayerLevel
            '
            Me.Check_Boost_UsePlayerLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_UsePlayerLevel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_UsePlayerLevel.Location = New System.Drawing.Point(203, 1067)
            Me.Check_Boost_UsePlayerLevel.Name = "Check_Boost_UsePlayerLevel"
            Me.Check_Boost_UsePlayerLevel.Size = New System.Drawing.Size(133, 23)
            Me.Check_Boost_UsePlayerLevel.TabIndex = 217
            Me.Check_Boost_UsePlayerLevel.Text = "Use Player Level :"
            Me.Check_Boost_UsePlayerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_UsePlayerLevel.UseVisualStyleBackColor = True
            '
            'Check_Boost_Trade
            '
            Me.Check_Boost_Trade.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_Trade.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_Trade.Location = New System.Drawing.Point(203, 1019)
            Me.Check_Boost_Trade.Name = "Check_Boost_Trade"
            Me.Check_Boost_Trade.Size = New System.Drawing.Size(133, 42)
            Me.Check_Boost_Trade.TabIndex = 216
            Me.Check_Boost_Trade.Text = "Boost Tradeable :"
            Me.Check_Boost_Trade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_Trade.UseVisualStyleBackColor = True
            '
            'Check_Boost_Boostable
            '
            Me.Check_Boost_Boostable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_Boostable.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_Boostable.Location = New System.Drawing.Point(481, 1067)
            Me.Check_Boost_Boostable.Name = "Check_Boost_Boostable"
            Me.Check_Boost_Boostable.Size = New System.Drawing.Size(135, 23)
            Me.Check_Boost_Boostable.TabIndex = 224
            Me.Check_Boost_Boostable.Text = "Boostable :"
            Me.Check_Boost_Boostable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_Boostable.UseVisualStyleBackColor = True
            '
            'Check_TravelSuppress
            '
            Me.Check_TravelSuppress.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_TravelSuppress.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_TravelSuppress.Location = New System.Drawing.Point(342, 846)
            Me.Check_TravelSuppress.Name = "Check_TravelSuppress"
            Me.Check_TravelSuppress.Size = New System.Drawing.Size(133, 21)
            Me.Check_TravelSuppress.TabIndex = 198
            Me.Check_TravelSuppress.Text = "Travel Suppression :"
            Me.Check_TravelSuppress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_TravelSuppress.UseVisualStyleBackColor = True
            '
            'Check_Toggle_Sleep
            '
            Me.Check_Toggle_Sleep.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Sleep.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Toggle_Sleep.Location = New System.Drawing.Point(203, 819)
            Me.Check_Toggle_Sleep.Name = "Check_Toggle_Sleep"
            Me.Check_Toggle_Sleep.Size = New System.Drawing.Size(133, 21)
            Me.Check_Toggle_Sleep.TabIndex = 92
            Me.Check_Toggle_Sleep.Text = "Ignore Sleep :"
            Me.Check_Toggle_Sleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Sleep.UseVisualStyleBackColor = True
            '
            'EditList_BoostsAllowed
            '
            Me.TableLayoutPanel6.SetColumnSpan(Me.EditList_BoostsAllowed, 2)
            Me.EditList_BoostsAllowed.Dock = System.Windows.Forms.DockStyle.Fill
            Me.EditList_BoostsAllowed.FormattingEnabled = True
            Me.EditList_BoostsAllowed.ItemHeight = 16
            Me.EditList_BoostsAllowed.Location = New System.Drawing.Point(203, 923)
            Me.EditList_BoostsAllowed.Name = "EditList_BoostsAllowed"
            Me.EditList_BoostsAllowed.Size = New System.Drawing.Size(272, 90)
            Me.EditList_BoostsAllowed.TabIndex = 225
            '
            'Label92
            '
            Me.Label92.AutoSize = True
            Me.Label92.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label92.Location = New System.Drawing.Point(3, 920)
            Me.Label92.Name = "Label92"
            Me.Label92.Size = New System.Drawing.Size(194, 96)
            Me.Label92.TabIndex = 226
            Me.Label92.Text = "Boosts Allowed :"
            '
            'Edit_Boost_Catalyst
            '
            Me.TableLayoutPanel6.SetColumnSpan(Me.Edit_Boost_Catalyst, 3)
            Me.Edit_Boost_Catalyst.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Boost_Catalyst.Location = New System.Drawing.Point(203, 892)
            Me.Edit_Boost_Catalyst.Name = "Edit_Boost_Catalyst"
            Me.Edit_Boost_Catalyst.Size = New System.Drawing.Size(413, 23)
            Me.Edit_Boost_Catalyst.TabIndex = 219
            '
            'Check_Toggle_IgnoreDisatance
            '
            Me.Check_Toggle_IgnoreDisatance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_IgnoreDisatance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Toggle_IgnoreDisatance.Location = New System.Drawing.Point(3, 846)
            Me.Check_Toggle_IgnoreDisatance.Name = "Check_Toggle_IgnoreDisatance"
            Me.Check_Toggle_IgnoreDisatance.Size = New System.Drawing.Size(194, 21)
            Me.Check_Toggle_IgnoreDisatance.TabIndex = 139
            Me.Check_Toggle_IgnoreDisatance.Text = "Ignore Max Distance :"
            Me.Check_Toggle_IgnoreDisatance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_IgnoreDisatance.UseVisualStyleBackColor = True
            '
            'Check_InterruptableSleep
            '
            Me.Check_InterruptableSleep.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_InterruptableSleep.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_InterruptableSleep.Location = New System.Drawing.Point(203, 846)
            Me.Check_InterruptableSleep.Name = "Check_InterruptableSleep"
            Me.Check_InterruptableSleep.Size = New System.Drawing.Size(133, 21)
            Me.Check_InterruptableSleep.TabIndex = 149
            Me.Check_InterruptableSleep.Text = "Interruptable (Sleep) :"
            Me.Check_InterruptableSleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_InterruptableSleep.UseVisualStyleBackColor = True
            '
            'Label81
            '
            Me.Label81.AutoSize = True
            Me.Label81.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label81.Location = New System.Drawing.Point(3, 889)
            Me.Label81.Name = "Label81"
            Me.Label81.Size = New System.Drawing.Size(194, 31)
            Me.Label81.TabIndex = 218
            Me.Label81.Text = "Catalyst Conversion :"
            '
            'Check_Toggle_Hold
            '
            Me.Check_Toggle_Hold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Hold.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Toggle_Hold.Location = New System.Drawing.Point(3, 819)
            Me.Check_Toggle_Hold.Name = "Check_Toggle_Hold"
            Me.Check_Toggle_Hold.Size = New System.Drawing.Size(194, 21)
            Me.Check_Toggle_Hold.TabIndex = 90
            Me.Check_Toggle_Hold.Text = "Ignore Hold :"
            Me.Check_Toggle_Hold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Toggle_Hold.UseVisualStyleBackColor = True
            '
            'Check_NearGround
            '
            Me.Check_NearGround.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_NearGround.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_NearGround.Location = New System.Drawing.Point(481, 772)
            Me.Check_NearGround.Name = "Check_NearGround"
            Me.Check_NearGround.Size = New System.Drawing.Size(135, 21)
            Me.Check_NearGround.TabIndex = 146
            Me.Check_NearGround.Text = "Near Ground :"
            Me.Check_NearGround.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_NearGround.UseVisualStyleBackColor = True
            '
            'Label83
            '
            Me.Label83.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel6.SetColumnSpan(Me.Label83, 4)
            Me.Label83.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label83.ForeColor = System.Drawing.Color.White
            Me.Label83.Location = New System.Drawing.Point(3, 870)
            Me.Label83.Name = "Label83"
            Me.Label83.Size = New System.Drawing.Size(613, 19)
            Me.Label83.TabIndex = 202
            Me.Label83.Text = "Boost Options :"
            '
            'Check_CanCancel
            '
            Me.Check_CanCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_CanCancel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_CanCancel.Location = New System.Drawing.Point(342, 772)
            Me.Check_CanCancel.Name = "Check_CanCancel"
            Me.Check_CanCancel.Size = New System.Drawing.Size(133, 21)
            Me.Check_CanCancel.TabIndex = 137
            Me.Check_CanCancel.Text = "Cancellable :"
            Me.Check_CanCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_CanCancel.UseVisualStyleBackColor = True
            '
            'Check_IgnoreStrength
            '
            Me.Check_IgnoreStrength.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_IgnoreStrength.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_IgnoreStrength.Location = New System.Drawing.Point(203, 772)
            Me.Check_IgnoreStrength.Name = "Check_IgnoreStrength"
            Me.Check_IgnoreStrength.Size = New System.Drawing.Size(133, 21)
            Me.Check_IgnoreStrength.TabIndex = 165
            Me.Check_IgnoreStrength.Text = "Ignore Strength :"
            Me.Check_IgnoreStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_IgnoreStrength.UseVisualStyleBackColor = True
            '
            'Check_IgnoreLevelBought
            '
            Me.Check_IgnoreLevelBought.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_IgnoreLevelBought.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_IgnoreLevelBought.Location = New System.Drawing.Point(3, 772)
            Me.Check_IgnoreLevelBought.Name = "Check_IgnoreLevelBought"
            Me.Check_IgnoreLevelBought.Size = New System.Drawing.Size(194, 21)
            Me.Check_IgnoreLevelBought.TabIndex = 147
            Me.Check_IgnoreLevelBought.Text = "Ignore Level Bought :"
            Me.Check_IgnoreLevelBought.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_IgnoreLevelBought.UseVisualStyleBackColor = True
            '
            'Edit_Usage_LifetimeGameMax
            '
            Me.Edit_Usage_LifetimeGameMax.DecimalPlaces = 6
            Me.Edit_Usage_LifetimeGameMax.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Usage_LifetimeGameMax.Location = New System.Drawing.Point(481, 604)
            Me.Edit_Usage_LifetimeGameMax.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Usage_LifetimeGameMax.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Usage_LifetimeGameMax.Name = "Edit_Usage_LifetimeGameMax"
            Me.Edit_Usage_LifetimeGameMax.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Usage_LifetimeGameMax.TabIndex = 124
            '
            'Edit_Usage_LifetimeMax
            '
            Me.Edit_Usage_LifetimeMax.DecimalPlaces = 6
            Me.Edit_Usage_LifetimeMax.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Usage_LifetimeMax.Location = New System.Drawing.Point(481, 573)
            Me.Edit_Usage_LifetimeMax.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Usage_LifetimeMax.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Usage_LifetimeMax.Name = "Edit_Usage_LifetimeMax"
            Me.Edit_Usage_LifetimeMax.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Usage_LifetimeMax.TabIndex = 120
            '
            'Edit_Usage_TimeMax
            '
            Me.Edit_Usage_TimeMax.DecimalPlaces = 6
            Me.Edit_Usage_TimeMax.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Usage_TimeMax.Location = New System.Drawing.Point(481, 543)
            Me.Edit_Usage_TimeMax.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Usage_TimeMax.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Usage_TimeMax.Name = "Edit_Usage_TimeMax"
            Me.Edit_Usage_TimeMax.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Usage_TimeMax.TabIndex = 113
            '
            'Check_Cast_Terrorize
            '
            Me.Check_Cast_Terrorize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Terrorize.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Cast_Terrorize.Location = New System.Drawing.Point(481, 747)
            Me.Check_Cast_Terrorize.Name = "Check_Cast_Terrorize"
            Me.Check_Cast_Terrorize.Size = New System.Drawing.Size(135, 19)
            Me.Check_Cast_Terrorize.TabIndex = 87
            Me.Check_Cast_Terrorize.Text = "Cast Through Terrorize :"
            Me.Check_Cast_Terrorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Terrorize.UseVisualStyleBackColor = True
            '
            'Check_Cast_Sleep
            '
            Me.Check_Cast_Sleep.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Sleep.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Cast_Sleep.Location = New System.Drawing.Point(342, 747)
            Me.Check_Cast_Sleep.Name = "Check_Cast_Sleep"
            Me.Check_Cast_Sleep.Size = New System.Drawing.Size(133, 19)
            Me.Check_Cast_Sleep.TabIndex = 85
            Me.Check_Cast_Sleep.Text = "Cast Through Sleep :"
            Me.Check_Cast_Sleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Sleep.UseVisualStyleBackColor = True
            '
            'Check_DestroyLimit
            '
            Me.Check_DestroyLimit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_DestroyLimit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_DestroyLimit.Location = New System.Drawing.Point(203, 747)
            Me.Check_DestroyLimit.Name = "Check_DestroyLimit"
            Me.Check_DestroyLimit.Size = New System.Drawing.Size(133, 19)
            Me.Check_DestroyLimit.TabIndex = 141
            Me.Check_DestroyLimit.Text = "Destroy on Limit :"
            Me.Check_DestroyLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_DestroyLimit.UseVisualStyleBackColor = True
            '
            'Check_StackingUsage
            '
            Me.Check_StackingUsage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_StackingUsage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_StackingUsage.Location = New System.Drawing.Point(3, 747)
            Me.Check_StackingUsage.Name = "Check_StackingUsage"
            Me.Check_StackingUsage.Size = New System.Drawing.Size(194, 19)
            Me.Check_StackingUsage.TabIndex = 140
            Me.Check_StackingUsage.Text = "Stacking Usage :"
            Me.Check_StackingUsage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_StackingUsage.UseVisualStyleBackColor = True
            '
            'Label37
            '
            Me.Label37.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel6.SetColumnSpan(Me.Label37, 4)
            Me.Label37.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label37.ForeColor = System.Drawing.Color.White
            Me.Label37.Location = New System.Drawing.Point(3, 796)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(613, 20)
            Me.Label37.TabIndex = 91
            Me.Label37.Text = "Toggle Options :"
            '
            'Edit_Time_SelfConfirm
            '
            Me.Edit_Time_SelfConfirm.DecimalPlaces = 6
            Me.Edit_Time_SelfConfirm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Time_SelfConfirm.Location = New System.Drawing.Point(481, 493)
            Me.Edit_Time_SelfConfirm.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Time_SelfConfirm.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Time_SelfConfirm.Name = "Edit_Time_SelfConfirm"
            Me.Edit_Time_SelfConfirm.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Time_SelfConfirm.TabIndex = 109
            '
            'Check_Cast_Stun
            '
            Me.Check_Cast_Stun.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Stun.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Cast_Stun.Location = New System.Drawing.Point(203, 720)
            Me.Check_Cast_Stun.Name = "Check_Cast_Stun"
            Me.Check_Cast_Stun.Size = New System.Drawing.Size(133, 21)
            Me.Check_Cast_Stun.TabIndex = 86
            Me.Check_Cast_Stun.Text = "Cast Through Stun :"
            Me.Check_Cast_Stun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Stun.UseVisualStyleBackColor = True
            '
            'Check_Cast_Hold
            '
            Me.Check_Cast_Hold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Hold.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Cast_Hold.Location = New System.Drawing.Point(3, 720)
            Me.Check_Cast_Hold.Name = "Check_Cast_Hold"
            Me.Check_Cast_Hold.Size = New System.Drawing.Size(194, 21)
            Me.Check_Cast_Hold.TabIndex = 82
            Me.Check_Cast_Hold.Text = "Cast Through Hold :"
            Me.Check_Cast_Hold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Cast_Hold.UseVisualStyleBackColor = True
            '
            'Label46
            '
            Me.Label46.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label46.Location = New System.Drawing.Point(342, 570)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(133, 31)
            Me.Label46.TabIndex = 119
            Me.Label46.Text = "Max Lifetime :"
            Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_NumberCharges
            '
            Me.Edit_NumberCharges.DecimalPlaces = 6
            Me.Edit_NumberCharges.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_NumberCharges.Location = New System.Drawing.Point(203, 689)
            Me.Edit_NumberCharges.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_NumberCharges.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_NumberCharges.Name = "Edit_NumberCharges"
            Me.Edit_NumberCharges.Size = New System.Drawing.Size(133, 23)
            Me.Edit_NumberCharges.TabIndex = 143
            '
            'Label57
            '
            Me.Label57.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label57.Location = New System.Drawing.Point(3, 686)
            Me.Label57.Name = "Label57"
            Me.Label57.Size = New System.Drawing.Size(194, 31)
            Me.Label57.TabIndex = 142
            Me.Label57.Text = "Num Charges :"
            Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label50
            '
            Me.Label50.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label50.Location = New System.Drawing.Point(342, 540)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(133, 30)
            Me.Label50.TabIndex = 112
            Me.Label50.Text = "Max Usage Time :"
            Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label43
            '
            Me.Label43.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label43.Location = New System.Drawing.Point(342, 601)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(133, 32)
            Me.Label43.TabIndex = 123
            Me.Label43.Text = "Max Lifetime (Game) :"
            Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Select_Cast_Death
            '
            Me.Select_Cast_Death.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_Cast_Death.FormattingEnabled = True
            Me.Select_Cast_Death.Location = New System.Drawing.Point(203, 656)
            Me.Select_Cast_Death.Name = "Select_Cast_Death"
            Me.Select_Cast_Death.Size = New System.Drawing.Size(133, 24)
            Me.Select_Cast_Death.TabIndex = 89
            '
            'Edit_NumberChargesMax
            '
            Me.Edit_NumberChargesMax.DecimalPlaces = 6
            Me.Edit_NumberChargesMax.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_NumberChargesMax.Location = New System.Drawing.Point(481, 689)
            Me.Edit_NumberChargesMax.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_NumberChargesMax.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_NumberChargesMax.Name = "Edit_NumberChargesMax"
            Me.Edit_NumberChargesMax.Size = New System.Drawing.Size(135, 23)
            Me.Edit_NumberChargesMax.TabIndex = 145
            '
            'Label35
            '
            Me.Label35.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label35.Location = New System.Drawing.Point(3, 653)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(194, 33)
            Me.Label35.TabIndex = 88
            Me.Label35.Text = "Cast After Death :"
            Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label56
            '
            Me.Label56.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label56.Location = New System.Drawing.Point(342, 686)
            Me.Label56.Name = "Label56"
            Me.Label56.Size = New System.Drawing.Size(133, 31)
            Me.Label56.TabIndex = 144
            Me.Label56.Text = "Max Number Charges :"
            Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Cost_Idea
            '
            Me.Edit_Cost_Idea.DecimalPlaces = 6
            Me.Edit_Cost_Idea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Cost_Idea.Location = New System.Drawing.Point(481, 465)
            Me.Edit_Cost_Idea.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Cost_Idea.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Cost_Idea.Name = "Edit_Cost_Idea"
            Me.Edit_Cost_Idea.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Cost_Idea.TabIndex = 105
            '
            'Edit_Time_Recharge
            '
            Me.Edit_Time_Recharge.DecimalPlaces = 6
            Me.Edit_Time_Recharge.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Time_Recharge.Location = New System.Drawing.Point(481, 437)
            Me.Edit_Time_Recharge.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Time_Recharge.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Time_Recharge.Name = "Edit_Time_Recharge"
            Me.Edit_Time_Recharge.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Time_Recharge.TabIndex = 98
            '
            'Edit_Time_ActivatePeriod
            '
            Me.Edit_Time_ActivatePeriod.DecimalPlaces = 6
            Me.Edit_Time_ActivatePeriod.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Time_ActivatePeriod.Location = New System.Drawing.Point(481, 408)
            Me.Edit_Time_ActivatePeriod.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Time_ActivatePeriod.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Time_ActivatePeriod.Name = "Edit_Time_ActivatePeriod"
            Me.Edit_Time_ActivatePeriod.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Time_ActivatePeriod.TabIndex = 100
            '
            'Label40
            '
            Me.Label40.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label40.Location = New System.Drawing.Point(342, 405)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(133, 29)
            Me.Label40.TabIndex = 99
            Me.Label40.Text = "Activate Period :"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label38
            '
            Me.Label38.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label38.Location = New System.Drawing.Point(342, 434)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(133, 28)
            Me.Label38.TabIndex = 97
            Me.Label38.Text = "Recharge Time :"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Usage_LifetimeGame
            '
            Me.Edit_Usage_LifetimeGame.DecimalPlaces = 6
            Me.Edit_Usage_LifetimeGame.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Usage_LifetimeGame.Location = New System.Drawing.Point(203, 604)
            Me.Edit_Usage_LifetimeGame.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Usage_LifetimeGame.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Usage_LifetimeGame.Name = "Edit_Usage_LifetimeGame"
            Me.Edit_Usage_LifetimeGame.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Usage_LifetimeGame.TabIndex = 122
            '
            'Label34
            '
            Me.Label34.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel6.SetColumnSpan(Me.Label34, 4)
            Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label34.ForeColor = System.Drawing.Color.White
            Me.Label34.Location = New System.Drawing.Point(3, 633)
            Me.Label34.Name = "Label34"
            Me.Label34.Size = New System.Drawing.Size(613, 20)
            Me.Label34.TabIndex = 84
            Me.Label34.Text = "Castable Options :"
            '
            'Edit_Usage_Lifetime
            '
            Me.Edit_Usage_Lifetime.DecimalPlaces = 6
            Me.Edit_Usage_Lifetime.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Usage_Lifetime.Location = New System.Drawing.Point(203, 573)
            Me.Edit_Usage_Lifetime.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Usage_Lifetime.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Usage_Lifetime.Name = "Edit_Usage_Lifetime"
            Me.Edit_Usage_Lifetime.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Usage_Lifetime.TabIndex = 117
            '
            'Edit_Usage_Time
            '
            Me.Edit_Usage_Time.DecimalPlaces = 6
            Me.Edit_Usage_Time.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Usage_Time.Location = New System.Drawing.Point(203, 543)
            Me.Edit_Usage_Time.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Usage_Time.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Usage_Time.Name = "Edit_Usage_Time"
            Me.Edit_Usage_Time.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Usage_Time.TabIndex = 111
            '
            'Label_Time_SelfConfirm
            '
            Me.Label_Time_SelfConfirm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label_Time_SelfConfirm.Location = New System.Drawing.Point(342, 490)
            Me.Label_Time_SelfConfirm.Name = "Label_Time_SelfConfirm"
            Me.Label_Time_SelfConfirm.Size = New System.Drawing.Size(133, 32)
            Me.Label_Time_SelfConfirm.TabIndex = 108
            Me.Label_Time_SelfConfirm.Text = "Self Confirm :"
            Me.Label_Time_SelfConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label42
            '
            Me.Label42.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label42.Location = New System.Drawing.Point(342, 462)
            Me.Label42.Name = "Label42"
            Me.Label42.Size = New System.Drawing.Size(133, 28)
            Me.Label42.TabIndex = 104
            Me.Label42.Text = "Idea Cost :"
            Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Time_Activate
            '
            Me.Edit_Time_Activate.DecimalPlaces = 6
            Me.Edit_Time_Activate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Time_Activate.Location = New System.Drawing.Point(203, 408)
            Me.Edit_Time_Activate.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Time_Activate.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Time_Activate.Name = "Edit_Time_Activate"
            Me.Edit_Time_Activate.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Time_Activate.TabIndex = 96
            '
            'Label45
            '
            Me.Label45.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label45.Location = New System.Drawing.Point(3, 601)
            Me.Label45.Name = "Label45"
            Me.Label45.Size = New System.Drawing.Size(194, 32)
            Me.Label45.TabIndex = 121
            Me.Label45.Text = "Max Lifetime (Game) :"
            Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label48
            '
            Me.Label48.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label48.Location = New System.Drawing.Point(3, 570)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(194, 31)
            Me.Label48.TabIndex = 116
            Me.Label48.Text = "Lifetime :"
            Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label51
            '
            Me.Label51.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label51.Location = New System.Drawing.Point(3, 540)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(194, 30)
            Me.Label51.TabIndex = 110
            Me.Label51.Text = "Usage Time :"
            Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label36
            '
            Me.Label36.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label36.Location = New System.Drawing.Point(3, 405)
            Me.Label36.Name = "Label36"
            Me.Label36.Size = New System.Drawing.Size(194, 29)
            Me.Label36.TabIndex = 95
            Me.Label36.Text = "Time to Activate :"
            Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Time_Confirm
            '
            Me.Edit_Time_Confirm.DecimalPlaces = 6
            Me.Edit_Time_Confirm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Time_Confirm.Location = New System.Drawing.Point(203, 493)
            Me.Edit_Time_Confirm.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Time_Confirm.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Time_Confirm.Name = "Edit_Time_Confirm"
            Me.Edit_Time_Confirm.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Time_Confirm.TabIndex = 107
            '
            'Edit_Cost_Endurance
            '
            Me.Edit_Cost_Endurance.DecimalPlaces = 6
            Me.Edit_Cost_Endurance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Cost_Endurance.Location = New System.Drawing.Point(203, 465)
            Me.Edit_Cost_Endurance.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Cost_Endurance.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Cost_Endurance.Name = "Edit_Cost_Endurance"
            Me.Edit_Cost_Endurance.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Cost_Endurance.TabIndex = 102
            '
            'Label47
            '
            Me.Label47.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel6.SetColumnSpan(Me.Label47, 4)
            Me.Label47.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label47.ForeColor = System.Drawing.Color.White
            Me.Label47.Location = New System.Drawing.Point(3, 522)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(613, 18)
            Me.Label47.TabIndex = 118
            Me.Label47.Text = "Usage Time(s) :"
            '
            'Edit_Time_Interrupt
            '
            Me.Edit_Time_Interrupt.DecimalPlaces = 6
            Me.Edit_Time_Interrupt.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Time_Interrupt.Location = New System.Drawing.Point(203, 437)
            Me.Edit_Time_Interrupt.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Time_Interrupt.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Time_Interrupt.Name = "Edit_Time_Interrupt"
            Me.Edit_Time_Interrupt.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Time_Interrupt.TabIndex = 126
            '
            'Edit_AttackTypes
            '
            Me.TableLayoutPanel6.SetColumnSpan(Me.Edit_AttackTypes, 2)
            Me.Edit_AttackTypes.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_AttackTypes.FormattingEnabled = True
            Me.Edit_AttackTypes.ItemHeight = 16
            Me.Edit_AttackTypes.Location = New System.Drawing.Point(203, 97)
            Me.Edit_AttackTypes.Name = "Edit_AttackTypes"
            Me.Edit_AttackTypes.Size = New System.Drawing.Size(272, 89)
            Me.Edit_AttackTypes.TabIndex = 242
            '
            'Check_Trade
            '
            Me.Check_Trade.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Trade.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Trade.Location = New System.Drawing.Point(3, 306)
            Me.Check_Trade.Name = "Check_Trade"
            Me.Check_Trade.Size = New System.Drawing.Size(194, 18)
            Me.Check_Trade.TabIndex = 194
            Me.Check_Trade.Text = "Tradeable :"
            Me.Check_Trade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Trade.UseVisualStyleBackColor = True
            '
            'Label44
            '
            Me.Label44.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label44.Location = New System.Drawing.Point(3, 490)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(194, 32)
            Me.Label44.TabIndex = 106
            Me.Label44.Text = "Time to Confirm :"
            Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label39
            '
            Me.Label39.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label39.Location = New System.Drawing.Point(3, 462)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(194, 28)
            Me.Label39.TabIndex = 101
            Me.Label39.Text = "Endurance Cost :"
            Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label49
            '
            Me.Label49.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label49.Location = New System.Drawing.Point(3, 434)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(194, 28)
            Me.Label49.TabIndex = 125
            Me.Label49.Text = "Interrupt Time :"
            Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_Delete
            '
            Me.Check_Delete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Delete.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Delete.Location = New System.Drawing.Point(3, 330)
            Me.Check_Delete.Name = "Check_Delete"
            Me.Check_Delete.Size = New System.Drawing.Size(194, 24)
            Me.Check_Delete.TabIndex = 195
            Me.Check_Delete.Text = "Deletable :"
            Me.Check_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Delete.UseVisualStyleBackColor = True
            '
            'Check_AutoIssue
            '
            Me.Check_AutoIssue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AutoIssue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_AutoIssue.Location = New System.Drawing.Point(3, 360)
            Me.Check_AutoIssue.Name = "Check_AutoIssue"
            Me.Check_AutoIssue.Size = New System.Drawing.Size(194, 23)
            Me.Check_AutoIssue.TabIndex = 229
            Me.Check_AutoIssue.Text = "Auto Issue :"
            Me.Check_AutoIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AutoIssue.UseVisualStyleBackColor = True
            '
            'Check_AutoIssueSaveLevel
            '
            Me.Check_AutoIssueSaveLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AutoIssueSaveLevel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_AutoIssueSaveLevel.Location = New System.Drawing.Point(203, 360)
            Me.Check_AutoIssueSaveLevel.Name = "Check_AutoIssueSaveLevel"
            Me.Check_AutoIssueSaveLevel.Size = New System.Drawing.Size(133, 23)
            Me.Check_AutoIssueSaveLevel.TabIndex = 230
            Me.Check_AutoIssueSaveLevel.Text = "Auto Issue (Save Level) :"
            Me.Check_AutoIssueSaveLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AutoIssueSaveLevel.UseVisualStyleBackColor = True
            '
            'Check_Free
            '
            Me.Check_Free.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Free.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Free.Location = New System.Drawing.Point(481, 360)
            Me.Check_Free.Name = "Check_Free"
            Me.Check_Free.Size = New System.Drawing.Size(135, 23)
            Me.Check_Free.TabIndex = 231
            Me.Check_Free.Text = "Free :"
            Me.Check_Free.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Free.UseVisualStyleBackColor = True
            '
            'Check_AbusiveBuff
            '
            Me.Check_AbusiveBuff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AbusiveBuff.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_AbusiveBuff.Location = New System.Drawing.Point(481, 330)
            Me.Check_AbusiveBuff.Name = "Check_AbusiveBuff"
            Me.Check_AbusiveBuff.Size = New System.Drawing.Size(135, 24)
            Me.Check_AbusiveBuff.TabIndex = 233
            Me.Check_AbusiveBuff.Text = "Abusive Buff :"
            Me.Check_AbusiveBuff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_AbusiveBuff.UseVisualStyleBackColor = True
            '
            'Check_InstanceLocked
            '
            Me.Check_InstanceLocked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_InstanceLocked.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_InstanceLocked.Location = New System.Drawing.Point(481, 306)
            Me.Check_InstanceLocked.Name = "Check_InstanceLocked"
            Me.Check_InstanceLocked.Size = New System.Drawing.Size(135, 18)
            Me.Check_InstanceLocked.TabIndex = 232
            Me.Check_InstanceLocked.Text = "Instance Locked :"
            Me.Check_InstanceLocked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_InstanceLocked.UseVisualStyleBackColor = True
            '
            'Edit_ServerTray
            '
            Me.Edit_ServerTray.DecimalPlaces = 6
            Me.Edit_ServerTray.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_ServerTray.Location = New System.Drawing.Point(481, 277)
            Me.Edit_ServerTray.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_ServerTray.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_ServerTray.Name = "Edit_ServerTray"
            Me.Edit_ServerTray.Size = New System.Drawing.Size(135, 23)
            Me.Edit_ServerTray.TabIndex = 228
            '
            'Label17
            '
            Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label17.Location = New System.Drawing.Point(3, 0)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(194, 33)
            Me.Label17.TabIndex = 63
            Me.Label17.Text = "Power System :"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label97
            '
            Me.Label97.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label97.Location = New System.Drawing.Point(342, 274)
            Me.Label97.Name = "Label97"
            Me.Label97.Size = New System.Drawing.Size(133, 29)
            Me.Label97.TabIndex = 227
            Me.Label97.Text = "Server Tray Priority :"
            Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Select_PowerSystem
            '
            Me.Select_PowerSystem.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_PowerSystem.FormattingEnabled = True
            Me.Select_PowerSystem.Location = New System.Drawing.Point(203, 3)
            Me.Select_PowerSystem.Name = "Select_PowerSystem"
            Me.Select_PowerSystem.Size = New System.Drawing.Size(133, 24)
            Me.Select_PowerSystem.TabIndex = 64
            '
            'Label18
            '
            Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label18.Location = New System.Drawing.Point(3, 33)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(194, 32)
            Me.Label18.TabIndex = 65
            Me.Label18.Text = "Power Type :"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Select_PowerType
            '
            Me.Select_PowerType.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_PowerType.FormattingEnabled = True
            Me.Select_PowerType.Location = New System.Drawing.Point(203, 36)
            Me.Select_PowerType.Name = "Select_PowerType"
            Me.Select_PowerType.Size = New System.Drawing.Size(133, 24)
            Me.Select_PowerType.TabIndex = 66
            '
            'Label41
            '
            Me.Label41.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel6.SetColumnSpan(Me.Label41, 4)
            Me.Label41.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label41.ForeColor = System.Drawing.Color.White
            Me.Label41.Location = New System.Drawing.Point(3, 386)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(613, 19)
            Me.Label41.TabIndex = 103
            Me.Label41.Text = "Activation Options :"
            '
            'Label64
            '
            Me.Label64.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label64.Location = New System.Drawing.Point(342, 0)
            Me.Label64.Name = "Label64"
            Me.Label64.Size = New System.Drawing.Size(133, 33)
            Me.Label64.TabIndex = 162
            Me.Label64.Text = "Power Group :"
            Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label24
            '
            Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label24.Location = New System.Drawing.Point(3, 65)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(194, 29)
            Me.Label24.TabIndex = 78
            Me.Label24.Text = "Number Allowed :"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_NumAllowed
            '
            Me.Edit_NumAllowed.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_NumAllowed.Location = New System.Drawing.Point(203, 68)
            Me.Edit_NumAllowed.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_NumAllowed.Name = "Edit_NumAllowed"
            Me.Edit_NumAllowed.Size = New System.Drawing.Size(133, 23)
            Me.Edit_NumAllowed.TabIndex = 79
            '
            'Label75
            '
            Me.Label75.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label75.Location = New System.Drawing.Point(342, 65)
            Me.Label75.Name = "Label75"
            Me.Label75.Size = New System.Drawing.Size(133, 29)
            Me.Label75.TabIndex = 190
            Me.Label75.Text = "Max Slot :"
            Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Slot_Min
            '
            Me.Edit_Slot_Min.DecimalPlaces = 6
            Me.Edit_Slot_Min.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Slot_Min.Location = New System.Drawing.Point(203, 277)
            Me.Edit_Slot_Min.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Slot_Min.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Slot_Min.Name = "Edit_Slot_Min"
            Me.Edit_Slot_Min.Size = New System.Drawing.Size(133, 23)
            Me.Edit_Slot_Min.TabIndex = 189
            '
            'Edit_RewardFallback
            '
            Me.Edit_RewardFallback.Location = New System.Drawing.Point(203, 250)
            Me.Edit_RewardFallback.Name = "Edit_RewardFallback"
            Me.Edit_RewardFallback.Size = New System.Drawing.Size(133, 23)
            Me.Edit_RewardFallback.TabIndex = 193
            '
            'Label76
            '
            Me.Label76.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label76.Location = New System.Drawing.Point(3, 274)
            Me.Label76.Name = "Label76"
            Me.Label76.Size = New System.Drawing.Size(194, 29)
            Me.Label76.TabIndex = 188
            Me.Label76.Text = "Min Slot :"
            Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label77
            '
            Me.Label77.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label77.Location = New System.Drawing.Point(3, 247)
            Me.Label77.Name = "Label77"
            Me.Label77.Size = New System.Drawing.Size(194, 27)
            Me.Label77.TabIndex = 192
            Me.Label77.Text = "Reward Fallback :"
            Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Slot_Max
            '
            Me.Edit_Slot_Max.DecimalPlaces = 6
            Me.Edit_Slot_Max.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Slot_Max.Location = New System.Drawing.Point(481, 68)
            Me.Edit_Slot_Max.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Slot_Max.Minimum = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            Me.Edit_Slot_Max.Name = "Edit_Slot_Max"
            Me.Edit_Slot_Max.Size = New System.Drawing.Size(135, 23)
            Me.Edit_Slot_Max.TabIndex = 191
            '
            'Label23
            '
            Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label23.Location = New System.Drawing.Point(3, 94)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(194, 95)
            Me.Label23.TabIndex = 81
            Me.Label23.Text = "Attack Types :"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label69
            '
            Me.Label69.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label69.Location = New System.Drawing.Point(3, 189)
            Me.Label69.Name = "Label69"
            Me.Label69.Size = New System.Drawing.Size(194, 29)
            Me.Label69.TabIndex = 173
            Me.Label69.Text = "Chain Into Power :"
            Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_ChainPower
            '
            Me.Edit_ChainPower.Location = New System.Drawing.Point(203, 192)
            Me.Edit_ChainPower.Name = "Edit_ChainPower"
            Me.Edit_ChainPower.Size = New System.Drawing.Size(133, 23)
            Me.Edit_ChainPower.TabIndex = 174
            '
            'Edit_StoreProduct
            '
            Me.Edit_StoreProduct.Location = New System.Drawing.Point(203, 221)
            Me.Edit_StoreProduct.Name = "Edit_StoreProduct"
            Me.Edit_StoreProduct.Size = New System.Drawing.Size(133, 23)
            Me.Edit_StoreProduct.TabIndex = 187
            '
            'Label74
            '
            Me.Label74.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label74.Location = New System.Drawing.Point(3, 218)
            Me.Label74.Name = "Label74"
            Me.Label74.Size = New System.Drawing.Size(194, 29)
            Me.Label74.TabIndex = 186
            Me.Label74.Text = "Store Product :"
            Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_PowerGroup
            '
            Me.Edit_PowerGroup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_PowerGroup.FormattingEnabled = True
            Me.Edit_PowerGroup.ItemHeight = 16
            Me.Edit_PowerGroup.Location = New System.Drawing.Point(481, 3)
            Me.Edit_PowerGroup.Name = "Edit_PowerGroup"
            Me.TableLayoutPanel6.SetRowSpan(Me.Edit_PowerGroup, 2)
            Me.Edit_PowerGroup.Size = New System.Drawing.Size(135, 59)
            Me.Edit_PowerGroup.TabIndex = 163
            '
            'Check_Boost_DontSave
            '
            Me.Check_Boost_DontSave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_DontSave.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Boost_DontSave.Location = New System.Drawing.Point(481, 1019)
            Me.Check_Boost_DontSave.Name = "Check_Boost_DontSave"
            Me.Check_Boost_DontSave.Size = New System.Drawing.Size(135, 42)
            Me.Check_Boost_DontSave.TabIndex = 215
            Me.Check_Boost_DontSave.Text = "Do No Save :"
            Me.Check_Boost_DontSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Boost_DontSave.UseVisualStyleBackColor = True
            '
            'Label80
            '
            Me.Label80.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label80.Location = New System.Drawing.Point(3, 1125)
            Me.Label80.Name = "Label80"
            Me.Label80.Size = New System.Drawing.Size(194, 30)
            Me.Label80.TabIndex = 222
            Me.Label80.Text = "License Level :"
            Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label33
            '
            Me.Label33.BackColor = System.Drawing.Color.Black
            Me.Label33.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label33.ForeColor = System.Drawing.Color.White
            Me.Label33.Location = New System.Drawing.Point(0, 0)
            Me.Label33.Name = "Label33"
            Me.Label33.Size = New System.Drawing.Size(846, 17)
            Me.Label33.TabIndex = 83
            Me.Label33.Text = "Allowed Options :"
            '
            'TabPage7
            '
            Me.TabPage7.AutoScroll = True
            Me.TabPage7.Controls.Add(Me.TableLayoutPanel1)
            Me.TabPage7.Location = New System.Drawing.Point(4, 25)
            Me.TabPage7.Name = "TabPage7"
            Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage7.Size = New System.Drawing.Size(863, 438)
            Me.TabPage7.TabIndex = 8
            Me.TabPage7.Text = "Target Options"
            Me.TabPage7.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.Controls.Add(Me.Label52, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Ents_Affected, 1, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.Label102, 0, 10)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Ents_Auto, 1, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.Label53, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Select_Target, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Label101, 0, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.Select_TargetVisibility, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label54, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label100, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.Label63, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Check_Target_VisionPhase, 2, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.Check_PowerRedirect, 1, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.Check_ThroughUntouch, 2, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Range, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Accuracy, 3, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label61, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Check_Target_Shuffle, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.Label65, 2, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Check_EviromentHit, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Target_Radius, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Check_Target_NearGround, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.Select_TargetSecondary, 3, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Target_MaxHit, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Select_EffectArea, 3, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label59, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label55, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Target_Arc, 3, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Label58, 2, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label60, 2, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Label62, 2, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Edit_Range_Secondary, 3, 3)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 3)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 12
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(863, 427)
            Me.TableLayoutPanel1.TabIndex = 215
            '
            'Label52
            '
            Me.Label52.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel1.SetColumnSpan(Me.Label52, 4)
            Me.Label52.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label52.ForeColor = System.Drawing.Color.White
            Me.Label52.Location = New System.Drawing.Point(3, 0)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(857, 18)
            Me.Label52.TabIndex = 176
            Me.Label52.Text = "Target Options :"
            '
            'Edit_Ents_Affected
            '
            Me.TableLayoutPanel1.SetColumnSpan(Me.Edit_Ents_Affected, 2)
            Me.Edit_Ents_Affected.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Ents_Affected.FormattingEnabled = True
            Me.Edit_Ents_Affected.ItemHeight = 16
            Me.Edit_Ents_Affected.Location = New System.Drawing.Point(203, 328)
            Me.Edit_Ents_Affected.Name = "Edit_Ents_Affected"
            Me.Edit_Ents_Affected.Size = New System.Drawing.Size(436, 74)
            Me.Edit_Ents_Affected.TabIndex = 213
            '
            'Label102
            '
            Me.Label102.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label102.Location = New System.Drawing.Point(3, 325)
            Me.Label102.Name = "Label102"
            Me.Label102.Size = New System.Drawing.Size(194, 80)
            Me.Label102.TabIndex = 214
            Me.Label102.Text = "Affected :"
            Me.Label102.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Edit_Ents_Auto
            '
            Me.TableLayoutPanel1.SetColumnSpan(Me.Edit_Ents_Auto, 2)
            Me.Edit_Ents_Auto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Ents_Auto.FormattingEnabled = True
            Me.Edit_Ents_Auto.ItemHeight = 16
            Me.Edit_Ents_Auto.Location = New System.Drawing.Point(203, 239)
            Me.Edit_Ents_Auto.Name = "Edit_Ents_Auto"
            Me.Edit_Ents_Auto.Size = New System.Drawing.Size(436, 83)
            Me.Edit_Ents_Auto.TabIndex = 211
            '
            'Label53
            '
            Me.Label53.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label53.Location = New System.Drawing.Point(3, 18)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(194, 29)
            Me.Label53.TabIndex = 177
            Me.Label53.Text = "Target :"
            Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Select_Target
            '
            Me.Select_Target.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_Target.FormattingEnabled = True
            Me.Select_Target.Location = New System.Drawing.Point(203, 21)
            Me.Select_Target.Name = "Select_Target"
            Me.Select_Target.Size = New System.Drawing.Size(215, 24)
            Me.Select_Target.TabIndex = 178
            '
            'Label101
            '
            Me.Label101.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label101.Location = New System.Drawing.Point(3, 236)
            Me.Label101.Name = "Label101"
            Me.Label101.Size = New System.Drawing.Size(194, 89)
            Me.Label101.TabIndex = 212
            Me.Label101.Text = "Auto Hit :"
            Me.Label101.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Select_TargetVisibility
            '
            Me.Select_TargetVisibility.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_TargetVisibility.FormattingEnabled = True
            Me.Select_TargetVisibility.Location = New System.Drawing.Point(203, 50)
            Me.Select_TargetVisibility.Name = "Select_TargetVisibility"
            Me.Select_TargetVisibility.Size = New System.Drawing.Size(215, 24)
            Me.Select_TargetVisibility.TabIndex = 180
            '
            'Label54
            '
            Me.Label54.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label54.Location = New System.Drawing.Point(3, 47)
            Me.Label54.Name = "Label54"
            Me.Label54.Size = New System.Drawing.Size(194, 30)
            Me.Label54.TabIndex = 179
            Me.Label54.Text = "Target Visibility :"
            Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label100
            '
            Me.Label100.BackColor = System.Drawing.Color.Black
            Me.TableLayoutPanel1.SetColumnSpan(Me.Label100, 4)
            Me.Label100.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label100.ForeColor = System.Drawing.Color.White
            Me.Label100.Location = New System.Drawing.Point(3, 216)
            Me.Label100.Name = "Label100"
            Me.Label100.Size = New System.Drawing.Size(857, 20)
            Me.Label100.TabIndex = 203
            Me.Label100.Text = "Ents Options :"
            '
            'Label63
            '
            Me.Label63.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label63.Location = New System.Drawing.Point(3, 77)
            Me.Label63.Name = "Label63"
            Me.Label63.Size = New System.Drawing.Size(194, 28)
            Me.Label63.TabIndex = 187
            Me.Label63.Text = "Range :"
            Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_Target_VisionPhase
            '
            Me.Check_Target_VisionPhase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Target_VisionPhase.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Target_VisionPhase.Location = New System.Drawing.Point(424, 189)
            Me.Check_Target_VisionPhase.Name = "Check_Target_VisionPhase"
            Me.Check_Target_VisionPhase.Size = New System.Drawing.Size(215, 24)
            Me.Check_Target_VisionPhase.TabIndex = 199
            Me.Check_Target_VisionPhase.Text = "Target Through VisionPhase :"
            Me.Check_Target_VisionPhase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Target_VisionPhase.UseVisualStyleBackColor = True
            '
            'Check_PowerRedirect
            '
            Me.Check_PowerRedirect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_PowerRedirect.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_PowerRedirect.Location = New System.Drawing.Point(203, 189)
            Me.Check_PowerRedirect.Name = "Check_PowerRedirect"
            Me.Check_PowerRedirect.Size = New System.Drawing.Size(215, 24)
            Me.Check_PowerRedirect.TabIndex = 202
            Me.Check_PowerRedirect.Text = "Power Redirector :"
            Me.Check_PowerRedirect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_PowerRedirect.UseVisualStyleBackColor = True
            '
            'Check_ThroughUntouch
            '
            Me.Check_ThroughUntouch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_ThroughUntouch.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_ThroughUntouch.Location = New System.Drawing.Point(424, 165)
            Me.Check_ThroughUntouch.Name = "Check_ThroughUntouch"
            Me.Check_ThroughUntouch.Size = New System.Drawing.Size(215, 18)
            Me.Check_ThroughUntouch.TabIndex = 186
            Me.Check_ThroughUntouch.Text = "Shoot Through Untouchable :"
            Me.Check_ThroughUntouch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_ThroughUntouch.UseVisualStyleBackColor = True
            '
            'Edit_Range
            '
            Me.Edit_Range.DecimalPlaces = 6
            Me.Edit_Range.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Range.Location = New System.Drawing.Point(203, 80)
            Me.Edit_Range.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Range.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Range.Name = "Edit_Range"
            Me.Edit_Range.Size = New System.Drawing.Size(215, 23)
            Me.Edit_Range.TabIndex = 188
            '
            'Edit_Accuracy
            '
            Me.Edit_Accuracy.DecimalPlaces = 6
            Me.Edit_Accuracy.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Accuracy.Location = New System.Drawing.Point(645, 135)
            Me.Edit_Accuracy.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Accuracy.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Accuracy.Name = "Edit_Accuracy"
            Me.Edit_Accuracy.Size = New System.Drawing.Size(215, 23)
            Me.Edit_Accuracy.TabIndex = 201
            '
            'Label61
            '
            Me.Label61.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label61.Location = New System.Drawing.Point(3, 105)
            Me.Label61.Name = "Label61"
            Me.Label61.Size = New System.Drawing.Size(194, 27)
            Me.Label61.TabIndex = 191
            Me.Label61.Text = "Radius :"
            Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_Target_Shuffle
            '
            Me.Check_Target_Shuffle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Target_Shuffle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Target_Shuffle.Location = New System.Drawing.Point(203, 165)
            Me.Check_Target_Shuffle.Name = "Check_Target_Shuffle"
            Me.Check_Target_Shuffle.Size = New System.Drawing.Size(215, 18)
            Me.Check_Target_Shuffle.TabIndex = 185
            Me.Check_Target_Shuffle.Text = "Shuffle Targets :"
            Me.Check_Target_Shuffle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Target_Shuffle.UseVisualStyleBackColor = True
            '
            'Label65
            '
            Me.Label65.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label65.Location = New System.Drawing.Point(424, 132)
            Me.Label65.Name = "Label65"
            Me.Label65.Size = New System.Drawing.Size(215, 30)
            Me.Label65.TabIndex = 200
            Me.Label65.Text = "Accuracy :"
            Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Check_EviromentHit
            '
            Me.Check_EviromentHit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_EviromentHit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_EviromentHit.Location = New System.Drawing.Point(3, 189)
            Me.Check_EviromentHit.Name = "Check_EviromentHit"
            Me.Check_EviromentHit.Size = New System.Drawing.Size(194, 24)
            Me.Check_EviromentHit.TabIndex = 184
            Me.Check_EviromentHit.Text = "Is Eviroment Hit :"
            Me.Check_EviromentHit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_EviromentHit.UseVisualStyleBackColor = True
            '
            'Edit_Target_Radius
            '
            Me.Edit_Target_Radius.DecimalPlaces = 6
            Me.Edit_Target_Radius.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Target_Radius.Location = New System.Drawing.Point(203, 108)
            Me.Edit_Target_Radius.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Target_Radius.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Target_Radius.Name = "Edit_Target_Radius"
            Me.Edit_Target_Radius.Size = New System.Drawing.Size(215, 23)
            Me.Edit_Target_Radius.TabIndex = 192
            '
            'Check_Target_NearGround
            '
            Me.Check_Target_NearGround.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Target_NearGround.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Check_Target_NearGround.Location = New System.Drawing.Point(3, 165)
            Me.Check_Target_NearGround.Name = "Check_Target_NearGround"
            Me.Check_Target_NearGround.Size = New System.Drawing.Size(194, 18)
            Me.Check_Target_NearGround.TabIndex = 183
            Me.Check_Target_NearGround.Text = "Target Near Ground :"
            Me.Check_Target_NearGround.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Check_Target_NearGround.UseVisualStyleBackColor = True
            '
            'Select_TargetSecondary
            '
            Me.Select_TargetSecondary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_TargetSecondary.FormattingEnabled = True
            Me.Select_TargetSecondary.Location = New System.Drawing.Point(645, 21)
            Me.Select_TargetSecondary.Name = "Select_TargetSecondary"
            Me.Select_TargetSecondary.Size = New System.Drawing.Size(215, 24)
            Me.Select_TargetSecondary.TabIndex = 182
            '
            'Edit_Target_MaxHit
            '
            Me.Edit_Target_MaxHit.DecimalPlaces = 6
            Me.Edit_Target_MaxHit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Target_MaxHit.Location = New System.Drawing.Point(203, 135)
            Me.Edit_Target_MaxHit.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Target_MaxHit.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Target_MaxHit.Name = "Edit_Target_MaxHit"
            Me.Edit_Target_MaxHit.Size = New System.Drawing.Size(215, 23)
            Me.Edit_Target_MaxHit.TabIndex = 196
            '
            'Select_EffectArea
            '
            Me.Select_EffectArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Select_EffectArea.FormattingEnabled = True
            Me.Select_EffectArea.Location = New System.Drawing.Point(645, 50)
            Me.Select_EffectArea.Name = "Select_EffectArea"
            Me.Select_EffectArea.Size = New System.Drawing.Size(215, 24)
            Me.Select_EffectArea.TabIndex = 198
            '
            'Label59
            '
            Me.Label59.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label59.Location = New System.Drawing.Point(3, 132)
            Me.Label59.Name = "Label59"
            Me.Label59.Size = New System.Drawing.Size(194, 30)
            Me.Label59.TabIndex = 195
            Me.Label59.Text = "Max Targets Hit :"
            Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label55
            '
            Me.Label55.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label55.Location = New System.Drawing.Point(424, 18)
            Me.Label55.Name = "Label55"
            Me.Label55.Size = New System.Drawing.Size(215, 29)
            Me.Label55.TabIndex = 181
            Me.Label55.Text = "Target Secondary :"
            Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Target_Arc
            '
            Me.Edit_Target_Arc.DecimalPlaces = 6
            Me.Edit_Target_Arc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Target_Arc.Location = New System.Drawing.Point(645, 108)
            Me.Edit_Target_Arc.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Target_Arc.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Target_Arc.Name = "Edit_Target_Arc"
            Me.Edit_Target_Arc.Size = New System.Drawing.Size(215, 23)
            Me.Edit_Target_Arc.TabIndex = 194
            '
            'Label58
            '
            Me.Label58.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label58.Location = New System.Drawing.Point(424, 47)
            Me.Label58.Name = "Label58"
            Me.Label58.Size = New System.Drawing.Size(215, 30)
            Me.Label58.TabIndex = 197
            Me.Label58.Text = "Effect Area :"
            Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label60
            '
            Me.Label60.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label60.Location = New System.Drawing.Point(424, 105)
            Me.Label60.Name = "Label60"
            Me.Label60.Size = New System.Drawing.Size(215, 27)
            Me.Label60.TabIndex = 193
            Me.Label60.Text = "Arc :"
            Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label62
            '
            Me.Label62.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label62.Location = New System.Drawing.Point(424, 77)
            Me.Label62.Name = "Label62"
            Me.Label62.Size = New System.Drawing.Size(215, 28)
            Me.Label62.TabIndex = 189
            Me.Label62.Text = "Range Secondary :"
            Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Range_Secondary
            '
            Me.Edit_Range_Secondary.DecimalPlaces = 6
            Me.Edit_Range_Secondary.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Edit_Range_Secondary.Location = New System.Drawing.Point(645, 80)
            Me.Edit_Range_Secondary.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_Range_Secondary.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_Range_Secondary.Name = "Edit_Range_Secondary"
            Me.Edit_Range_Secondary.Size = New System.Drawing.Size(215, 23)
            Me.Edit_Range_Secondary.TabIndex = 190
            '
            'TabPage4
            '
            Me.TabPage4.AutoScroll = True
            Me.TabPage4.Controls.Add(Me.Label98)
            Me.TabPage4.Controls.Add(Me.EditList_AIGroups)
            Me.TabPage4.Controls.Add(Me.Edit_PreferenceMulti)
            Me.TabPage4.Controls.Add(Me.Label78)
            Me.TabPage4.Controls.Add(Me.Select_AIReport)
            Me.TabPage4.Controls.Add(Me.Label73)
            Me.TabPage4.Controls.Add(Me.Edit_ForceLevelBought)
            Me.TabPage4.Controls.Add(Me.Label70)
            Me.TabPage4.Controls.Add(Me.Label66)
            Me.TabPage4.Controls.Add(Me.Edit_AI_Multiplier)
            Me.TabPage4.Controls.Add(Me.Label67)
            Me.TabPage4.Controls.Add(Me.Edit_AI_Point)
            Me.TabPage4.Controls.Add(Me.Label68)
            Me.TabPage4.Location = New System.Drawing.Point(4, 25)
            Me.TabPage4.Name = "TabPage4"
            Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage4.Size = New System.Drawing.Size(863, 438)
            Me.TabPage4.TabIndex = 6
            Me.TabPage4.Text = "AI Related"
            Me.TabPage4.UseVisualStyleBackColor = True
            '
            'Label98
            '
            Me.Label98.AutoSize = True
            Me.Label98.Location = New System.Drawing.Point(60, 103)
            Me.Label98.Name = "Label98"
            Me.Label98.Size = New System.Drawing.Size(73, 16)
            Me.Label98.TabIndex = 210
            Me.Label98.Text = "AI Groups :"
            '
            'EditList_AIGroups
            '
            Me.EditList_AIGroups.FormattingEnabled = True
            Me.EditList_AIGroups.ItemHeight = 16
            Me.EditList_AIGroups.Location = New System.Drawing.Point(140, 105)
            Me.EditList_AIGroups.Name = "EditList_AIGroups"
            Me.EditList_AIGroups.Size = New System.Drawing.Size(501, 164)
            Me.EditList_AIGroups.TabIndex = 209
            '
            'Edit_PreferenceMulti
            '
            Me.Edit_PreferenceMulti.DecimalPlaces = 6
            Me.Edit_PreferenceMulti.Location = New System.Drawing.Point(476, 56)
            Me.Edit_PreferenceMulti.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_PreferenceMulti.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_PreferenceMulti.Name = "Edit_PreferenceMulti"
            Me.Edit_PreferenceMulti.Size = New System.Drawing.Size(180, 23)
            Me.Edit_PreferenceMulti.TabIndex = 208
            '
            'Label78
            '
            Me.Label78.AutoSize = True
            Me.Label78.Location = New System.Drawing.Point(340, 56)
            Me.Label78.Name = "Label78"
            Me.Label78.Size = New System.Drawing.Size(135, 16)
            Me.Label78.TabIndex = 207
            Me.Label78.Text = "Preference Multiplier :"
            '
            'Select_AIReport
            '
            Me.Select_AIReport.FormattingEnabled = True
            Me.Select_AIReport.Location = New System.Drawing.Point(140, 77)
            Me.Select_AIReport.Name = "Select_AIReport"
            Me.Select_AIReport.Size = New System.Drawing.Size(171, 24)
            Me.Select_AIReport.TabIndex = 206
            '
            'Label73
            '
            Me.Label73.AutoSize = True
            Me.Label73.Location = New System.Drawing.Point(48, 78)
            Me.Label73.Name = "Label73"
            Me.Label73.Size = New System.Drawing.Size(86, 16)
            Me.Label73.TabIndex = 205
            Me.Label73.Text = "Report to AI :"
            '
            'Edit_ForceLevelBought
            '
            Me.Edit_ForceLevelBought.DecimalPlaces = 6
            Me.Edit_ForceLevelBought.Location = New System.Drawing.Point(140, 50)
            Me.Edit_ForceLevelBought.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_ForceLevelBought.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_ForceLevelBought.Name = "Edit_ForceLevelBought"
            Me.Edit_ForceLevelBought.Size = New System.Drawing.Size(171, 23)
            Me.Edit_ForceLevelBought.TabIndex = 204
            '
            'Label70
            '
            Me.Label70.AutoSize = True
            Me.Label70.Location = New System.Drawing.Point(15, 50)
            Me.Label70.Name = "Label70"
            Me.Label70.Size = New System.Drawing.Size(125, 16)
            Me.Label70.TabIndex = 203
            Me.Label70.Text = "Force Level Bought :"
            '
            'Label66
            '
            Me.Label66.BackColor = System.Drawing.Color.Black
            Me.Label66.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label66.ForeColor = System.Drawing.Color.White
            Me.Label66.Location = New System.Drawing.Point(3, 3)
            Me.Label66.Name = "Label66"
            Me.Label66.Size = New System.Drawing.Size(857, 17)
            Me.Label66.TabIndex = 202
            Me.Label66.Text = "AI (AE etc) :"
            '
            'Edit_AI_Multiplier
            '
            Me.Edit_AI_Multiplier.DecimalPlaces = 6
            Me.Edit_AI_Multiplier.Location = New System.Drawing.Point(476, 25)
            Me.Edit_AI_Multiplier.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_AI_Multiplier.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_AI_Multiplier.Name = "Edit_AI_Multiplier"
            Me.Edit_AI_Multiplier.Size = New System.Drawing.Size(180, 23)
            Me.Edit_AI_Multiplier.TabIndex = 201
            '
            'Label67
            '
            Me.Label67.AutoSize = True
            Me.Label67.Location = New System.Drawing.Point(369, 25)
            Me.Label67.Name = "Label67"
            Me.Label67.Size = New System.Drawing.Size(101, 16)
            Me.Label67.TabIndex = 200
            Me.Label67.Text = "Point Multiplier :"
            '
            'Edit_AI_Point
            '
            Me.Edit_AI_Point.DecimalPlaces = 6
            Me.Edit_AI_Point.Location = New System.Drawing.Point(140, 23)
            Me.Edit_AI_Point.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            Me.Edit_AI_Point.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.Edit_AI_Point.Name = "Edit_AI_Point"
            Me.Edit_AI_Point.Size = New System.Drawing.Size(171, 23)
            Me.Edit_AI_Point.TabIndex = 199
            '
            'Label68
            '
            Me.Label68.AutoSize = True
            Me.Label68.Location = New System.Drawing.Point(53, 23)
            Me.Label68.Name = "Label68"
            Me.Label68.Size = New System.Drawing.Size(81, 16)
            Me.Label68.TabIndex = 198
            Me.Label68.Text = "Point Value :"
            '
            'TabPage1
            '
            Me.TabPage1.AutoScroll = True
            Me.TabPage1.Controls.Add(Me.EditList_StrengthDis)
            Me.TabPage1.Controls.Add(Me.Label99)
            Me.TabPage1.Controls.Add(Me.EditList_Modes_Disallowed)
            Me.TabPage1.Controls.Add(Me.Label93)
            Me.TabPage1.Controls.Add(Me.EditList_Modes_Required)
            Me.TabPage1.Controls.Add(Me.Label94)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Confirm)
            Me.TabPage1.Controls.Add(Me.Label32)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Auction)
            Me.TabPage1.Controls.Add(Me.Label28)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Reward)
            Me.TabPage1.Controls.Add(Me.Label29)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Target)
            Me.TabPage1.Controls.Add(Me.Label31)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Slot)
            Me.TabPage1.Controls.Add(Me.Label26)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Activate)
            Me.TabPage1.Controls.Add(Me.Label22)
            Me.TabPage1.Controls.Add(Me.Edit_Requires_Buy)
            Me.TabPage1.Controls.Add(Me.Label25)
            Me.TabPage1.Controls.Add(Me.Label27)
            Me.TabPage1.Location = New System.Drawing.Point(4, 25)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(863, 438)
            Me.TabPage1.TabIndex = 4
            Me.TabPage1.Text = "Requirements"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'EditList_StrengthDis
            '
            Me.EditList_StrengthDis.FormattingEnabled = True
            Me.EditList_StrengthDis.ItemHeight = 16
            Me.EditList_StrengthDis.Location = New System.Drawing.Point(132, 906)
            Me.EditList_StrengthDis.Name = "EditList_StrengthDis"
            Me.EditList_StrengthDis.Size = New System.Drawing.Size(416, 84)
            Me.EditList_StrengthDis.TabIndex = 99
            '
            'Label99
            '
            Me.Label99.AutoSize = True
            Me.Label99.Location = New System.Drawing.Point(9, 906)
            Me.Label99.Name = "Label99"
            Me.Label99.Size = New System.Drawing.Size(137, 16)
            Me.Label99.TabIndex = 98
            Me.Label99.Text = "Strengths Disallowed :"
            '
            'EditList_Modes_Disallowed
            '
            Me.EditList_Modes_Disallowed.FormattingEnabled = True
            Me.EditList_Modes_Disallowed.ItemHeight = 16
            Me.EditList_Modes_Disallowed.Location = New System.Drawing.Point(132, 808)
            Me.EditList_Modes_Disallowed.Name = "EditList_Modes_Disallowed"
            Me.EditList_Modes_Disallowed.Size = New System.Drawing.Size(416, 84)
            Me.EditList_Modes_Disallowed.TabIndex = 97
            '
            'Label93
            '
            Me.Label93.AutoSize = True
            Me.Label93.Location = New System.Drawing.Point(25, 808)
            Me.Label93.Name = "Label93"
            Me.Label93.Size = New System.Drawing.Size(119, 16)
            Me.Label93.TabIndex = 96
            Me.Label93.Text = "Modes Disallowed :"
            '
            'EditList_Modes_Required
            '
            Me.EditList_Modes_Required.FormattingEnabled = True
            Me.EditList_Modes_Required.ItemHeight = 16
            Me.EditList_Modes_Required.Location = New System.Drawing.Point(132, 709)
            Me.EditList_Modes_Required.Name = "EditList_Modes_Required"
            Me.EditList_Modes_Required.Size = New System.Drawing.Size(416, 84)
            Me.EditList_Modes_Required.TabIndex = 95
            '
            'Label94
            '
            Me.Label94.AutoSize = True
            Me.Label94.Location = New System.Drawing.Point(33, 709)
            Me.Label94.Name = "Label94"
            Me.Label94.Size = New System.Drawing.Size(109, 16)
            Me.Label94.TabIndex = 94
            Me.Label94.Text = "Modes Required :"
            '
            'Edit_Requires_Confirm
            '
            Me.Edit_Requires_Confirm.FormattingEnabled = True
            Me.Edit_Requires_Confirm.ItemHeight = 16
            Me.Edit_Requires_Confirm.Location = New System.Drawing.Point(132, 611)
            Me.Edit_Requires_Confirm.Name = "Edit_Requires_Confirm"
            Me.Edit_Requires_Confirm.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Confirm.TabIndex = 93
            '
            'Label32
            '
            Me.Label32.AutoSize = True
            Me.Label32.Location = New System.Drawing.Point(24, 611)
            Me.Label32.Name = "Label32"
            Me.Label32.Size = New System.Drawing.Size(120, 16)
            Me.Label32.TabIndex = 92
            Me.Label32.Text = "Comfirm Requires :"
            '
            'Edit_Requires_Auction
            '
            Me.Edit_Requires_Auction.FormattingEnabled = True
            Me.Edit_Requires_Auction.ItemHeight = 16
            Me.Edit_Requires_Auction.Location = New System.Drawing.Point(132, 513)
            Me.Edit_Requires_Auction.Name = "Edit_Requires_Auction"
            Me.Edit_Requires_Auction.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Auction.TabIndex = 91
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(30, 513)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(113, 16)
            Me.Label28.TabIndex = 90
            Me.Label28.Text = "Auction Requires :"
            '
            'Edit_Requires_Reward
            '
            Me.Edit_Requires_Reward.FormattingEnabled = True
            Me.Edit_Requires_Reward.ItemHeight = 16
            Me.Edit_Requires_Reward.Location = New System.Drawing.Point(132, 414)
            Me.Edit_Requires_Reward.Name = "Edit_Requires_Reward"
            Me.Edit_Requires_Reward.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Reward.TabIndex = 89
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(28, 414)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(115, 16)
            Me.Label29.TabIndex = 88
            Me.Label29.Text = "Reward Requires :"
            '
            'Edit_Requires_Target
            '
            Me.Edit_Requires_Target.FormattingEnabled = True
            Me.Edit_Requires_Target.ItemHeight = 16
            Me.Edit_Requires_Target.Location = New System.Drawing.Point(132, 316)
            Me.Edit_Requires_Target.Name = "Edit_Requires_Target"
            Me.Edit_Requires_Target.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Target.TabIndex = 87
            '
            'Label31
            '
            Me.Label31.AutoSize = True
            Me.Label31.Location = New System.Drawing.Point(15, 316)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(109, 16)
            Me.Label31.TabIndex = 86
            Me.Label31.Text = "Target Requires :"
            '
            'Edit_Requires_Slot
            '
            Me.Edit_Requires_Slot.FormattingEnabled = True
            Me.Edit_Requires_Slot.ItemHeight = 16
            Me.Edit_Requires_Slot.Location = New System.Drawing.Point(132, 216)
            Me.Edit_Requires_Slot.Name = "Edit_Requires_Slot"
            Me.Edit_Requires_Slot.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Slot.TabIndex = 85
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(47, 216)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(93, 16)
            Me.Label26.TabIndex = 84
            Me.Label26.Text = "Slot Requires :"
            '
            'Edit_Requires_Activate
            '
            Me.Edit_Requires_Activate.FormattingEnabled = True
            Me.Edit_Requires_Activate.ItemHeight = 16
            Me.Edit_Requires_Activate.Location = New System.Drawing.Point(132, 118)
            Me.Edit_Requires_Activate.Name = "Edit_Requires_Activate"
            Me.Edit_Requires_Activate.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Activate.TabIndex = 83
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(27, 118)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(116, 16)
            Me.Label22.TabIndex = 82
            Me.Label22.Text = "Activate Requires :"
            '
            'Edit_Requires_Buy
            '
            Me.Edit_Requires_Buy.FormattingEnabled = True
            Me.Edit_Requires_Buy.ItemHeight = 16
            Me.Edit_Requires_Buy.Location = New System.Drawing.Point(132, 19)
            Me.Edit_Requires_Buy.Name = "Edit_Requires_Buy"
            Me.Edit_Requires_Buy.Size = New System.Drawing.Size(416, 84)
            Me.Edit_Requires_Buy.TabIndex = 81
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(49, 19)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(91, 16)
            Me.Label25.TabIndex = 67
            Me.Label25.Text = "Buy Requires :"
            '
            'Label27
            '
            Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label27.BackColor = System.Drawing.Color.Black
            Me.Label27.ForeColor = System.Drawing.Color.White
            Me.Label27.Location = New System.Drawing.Point(0, 0)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(0, 17)
            Me.Label27.TabIndex = 64
            Me.Label27.Text = "Aquire Requirements :"
            '
            'TabPage6
            '
            Me.TabPage6.AutoScroll = True
            Me.TabPage6.Controls.Add(Me.Edit_Confirm)
            Me.TabPage6.Controls.Add(Me.Button12)
            Me.TabPage6.Controls.Add(Me.Label13)
            Me.TabPage6.Controls.Add(Me.Edit_Confirm_Key)
            Me.TabPage6.Controls.Add(Me.Label14)
            Me.TabPage6.Controls.Add(Me.Edit_Float_Defense)
            Me.TabPage6.Controls.Add(Me.Button13)
            Me.TabPage6.Controls.Add(Me.Edit_Float_DefenseKey)
            Me.TabPage6.Controls.Add(Me.Label16)
            Me.TabPage6.Controls.Add(Me.Edit_Float_Rewarded)
            Me.TabPage6.Controls.Add(Me.Button14)
            Me.TabPage6.Controls.Add(Me.Edit_Float_RewardedKey)
            Me.TabPage6.Controls.Add(Me.Label10)
            Me.TabPage6.Controls.Add(Me.Edit_Attacker_AttackF)
            Me.TabPage6.Controls.Add(Me.Button10)
            Me.TabPage6.Controls.Add(Me.Edit_Attacker_Attack_Key)
            Me.TabPage6.Controls.Add(Me.Label11)
            Me.TabPage6.Controls.Add(Me.Edit_Attacker_Attack)
            Me.TabPage6.Controls.Add(Me.Button11)
            Me.TabPage6.Controls.Add(Me.Edit_Attacker_AttackF_Key)
            Me.TabPage6.Controls.Add(Me.Label7)
            Me.TabPage6.Controls.Add(Me.Edit_Target_Help)
            Me.TabPage6.Controls.Add(Me.Button7)
            Me.TabPage6.Controls.Add(Me.Edit_Target_Help_Key)
            Me.TabPage6.Controls.Add(Me.Label9)
            Me.TabPage6.Controls.Add(Me.Edit_Target_Tooltip)
            Me.TabPage6.Controls.Add(Me.Button9)
            Me.TabPage6.Controls.Add(Me.Edit_Target_Tooltip_Key)
            Me.TabPage6.Controls.Add(Me.Label4)
            Me.TabPage6.Controls.Add(Me.Edit_Victim_Hit)
            Me.TabPage6.Controls.Add(Me.Button6)
            Me.TabPage6.Controls.Add(Me.Edit_Victim_Hit_Key)
            Me.TabPage6.Controls.Add(Me.Label8)
            Me.TabPage6.Controls.Add(Me.Edit_Attacker_Hit)
            Me.TabPage6.Controls.Add(Me.Button8)
            Me.TabPage6.Controls.Add(Me.Edit_Attacker_Hit_Key)
            Me.TabPage6.Controls.Add(Me.Label20)
            Me.TabPage6.Location = New System.Drawing.Point(4, 25)
            Me.TabPage6.Name = "TabPage6"
            Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage6.Size = New System.Drawing.Size(863, 438)
            Me.TabPage6.TabIndex = 3
            Me.TabPage6.Text = "Messages"
            Me.TabPage6.UseVisualStyleBackColor = True
            '
            'Edit_Confirm
            '
            Me.Edit_Confirm.Location = New System.Drawing.Point(134, 479)
            Me.Edit_Confirm.Multiline = True
            Me.Edit_Confirm.Name = "Edit_Confirm"
            Me.Edit_Confirm.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Confirm.TabIndex = 81
            '
            'Button12
            '
            Me.Button12.Location = New System.Drawing.Point(549, 477)
            Me.Button12.Name = "Button12"
            Me.Button12.Size = New System.Drawing.Size(26, 22)
            Me.Button12.TabIndex = 82
            Me.Button12.UseVisualStyleBackColor = True
            '
            'Label13
            '
            Me.Label13.Location = New System.Drawing.Point(19, 476)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(110, 36)
            Me.Label13.TabIndex = 79
            Me.Label13.Text = "Display Confirm :"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Edit_Confirm_Key
            '
            Me.Edit_Confirm_Key.Location = New System.Drawing.Point(421, 479)
            Me.Edit_Confirm_Key.Name = "Edit_Confirm_Key"
            Me.Edit_Confirm_Key.ReadOnly = True
            Me.Edit_Confirm_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Confirm_Key.TabIndex = 80
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(37, 554)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(107, 16)
            Me.Label14.TabIndex = 75
            Me.Label14.Text = "Float Rewarded :"
            '
            'Edit_Float_Defense
            '
            Me.Edit_Float_Defense.Location = New System.Drawing.Point(134, 631)
            Me.Edit_Float_Defense.Multiline = True
            Me.Edit_Float_Defense.Name = "Edit_Float_Defense"
            Me.Edit_Float_Defense.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Float_Defense.TabIndex = 76
            '
            'Button13
            '
            Me.Button13.Location = New System.Drawing.Point(549, 630)
            Me.Button13.Name = "Button13"
            Me.Button13.Size = New System.Drawing.Size(26, 22)
            Me.Button13.TabIndex = 78
            Me.Button13.UseVisualStyleBackColor = True
            '
            'Edit_Float_DefenseKey
            '
            Me.Edit_Float_DefenseKey.Location = New System.Drawing.Point(421, 631)
            Me.Edit_Float_DefenseKey.Name = "Edit_Float_DefenseKey"
            Me.Edit_Float_DefenseKey.ReadOnly = True
            Me.Edit_Float_DefenseKey.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Float_DefenseKey.TabIndex = 77
            '
            'Label16
            '
            Me.Label16.Location = New System.Drawing.Point(33, 630)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(96, 43)
            Me.Label16.TabIndex = 71
            Me.Label16.Text = "Power Defense Float :"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Edit_Float_Rewarded
            '
            Me.Edit_Float_Rewarded.Location = New System.Drawing.Point(134, 556)
            Me.Edit_Float_Rewarded.Multiline = True
            Me.Edit_Float_Rewarded.Name = "Edit_Float_Rewarded"
            Me.Edit_Float_Rewarded.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Float_Rewarded.TabIndex = 72
            '
            'Button14
            '
            Me.Button14.Location = New System.Drawing.Point(549, 555)
            Me.Button14.Name = "Button14"
            Me.Button14.Size = New System.Drawing.Size(26, 22)
            Me.Button14.TabIndex = 74
            Me.Button14.UseVisualStyleBackColor = True
            '
            'Edit_Float_RewardedKey
            '
            Me.Edit_Float_RewardedKey.Location = New System.Drawing.Point(421, 556)
            Me.Edit_Float_RewardedKey.Name = "Edit_Float_RewardedKey"
            Me.Edit_Float_RewardedKey.ReadOnly = True
            Me.Edit_Float_RewardedKey.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Float_RewardedKey.TabIndex = 73
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(40, 176)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(103, 16)
            Me.Label10.TabIndex = 67
            Me.Label10.Text = "Attacker Attack :"
            '
            'Edit_Attacker_AttackF
            '
            Me.Edit_Attacker_AttackF.Location = New System.Drawing.Point(134, 250)
            Me.Edit_Attacker_AttackF.Multiline = True
            Me.Edit_Attacker_AttackF.Name = "Edit_Attacker_AttackF"
            Me.Edit_Attacker_AttackF.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Attacker_AttackF.TabIndex = 68
            '
            'Button10
            '
            Me.Button10.Location = New System.Drawing.Point(549, 248)
            Me.Button10.Name = "Button10"
            Me.Button10.Size = New System.Drawing.Size(26, 22)
            Me.Button10.TabIndex = 70
            Me.Button10.UseVisualStyleBackColor = True
            '
            'Edit_Attacker_Attack_Key
            '
            Me.Edit_Attacker_Attack_Key.Location = New System.Drawing.Point(421, 174)
            Me.Edit_Attacker_Attack_Key.Name = "Edit_Attacker_Attack_Key"
            Me.Edit_Attacker_Attack_Key.ReadOnly = True
            Me.Edit_Attacker_Attack_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Attacker_Attack_Key.TabIndex = 69
            '
            'Label11
            '
            Me.Label11.Location = New System.Drawing.Point(19, 248)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 36)
            Me.Label11.TabIndex = 63
            Me.Label11.Text = "Attacker Attack Floater :"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Edit_Attacker_Attack
            '
            Me.Edit_Attacker_Attack.Location = New System.Drawing.Point(134, 175)
            Me.Edit_Attacker_Attack.Multiline = True
            Me.Edit_Attacker_Attack.Name = "Edit_Attacker_Attack"
            Me.Edit_Attacker_Attack.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Attacker_Attack.TabIndex = 64
            '
            'Button11
            '
            Me.Button11.Location = New System.Drawing.Point(549, 174)
            Me.Button11.Name = "Button11"
            Me.Button11.Size = New System.Drawing.Size(26, 22)
            Me.Button11.TabIndex = 66
            Me.Button11.UseVisualStyleBackColor = True
            '
            'Edit_Attacker_AttackF_Key
            '
            Me.Edit_Attacker_AttackF_Key.Location = New System.Drawing.Point(421, 249)
            Me.Edit_Attacker_AttackF_Key.Name = "Edit_Attacker_AttackF_Key"
            Me.Edit_Attacker_AttackF_Key.ReadOnly = True
            Me.Edit_Attacker_AttackF_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Attacker_AttackF_Key.TabIndex = 65
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(41, 20)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(102, 16)
            Me.Label7.TabIndex = 59
            Me.Label7.Text = "Target ToolTip :"
            '
            'Edit_Target_Help
            '
            Me.Edit_Target_Help.Location = New System.Drawing.Point(134, 97)
            Me.Edit_Target_Help.Multiline = True
            Me.Edit_Target_Help.Name = "Edit_Target_Help"
            Me.Edit_Target_Help.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Target_Help.TabIndex = 60
            '
            'Button7
            '
            Me.Button7.Location = New System.Drawing.Point(549, 97)
            Me.Button7.Name = "Button7"
            Me.Button7.Size = New System.Drawing.Size(26, 22)
            Me.Button7.TabIndex = 62
            Me.Button7.UseVisualStyleBackColor = True
            '
            'Edit_Target_Help_Key
            '
            Me.Edit_Target_Help_Key.Location = New System.Drawing.Point(421, 97)
            Me.Edit_Target_Help_Key.Name = "Edit_Target_Help_Key"
            Me.Edit_Target_Help_Key.ReadOnly = True
            Me.Edit_Target_Help_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Target_Help_Key.TabIndex = 61
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(57, 97)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(84, 16)
            Me.Label9.TabIndex = 55
            Me.Label9.Text = "Target Help :"
            '
            'Edit_Target_Tooltip
            '
            Me.Edit_Target_Tooltip.Location = New System.Drawing.Point(134, 20)
            Me.Edit_Target_Tooltip.Multiline = True
            Me.Edit_Target_Tooltip.Name = "Edit_Target_Tooltip"
            Me.Edit_Target_Tooltip.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Target_Tooltip.TabIndex = 56
            '
            'Button9
            '
            Me.Button9.Location = New System.Drawing.Point(549, 20)
            Me.Button9.Name = "Button9"
            Me.Button9.Size = New System.Drawing.Size(26, 22)
            Me.Button9.TabIndex = 58
            Me.Button9.UseVisualStyleBackColor = True
            '
            'Edit_Target_Tooltip_Key
            '
            Me.Edit_Target_Tooltip_Key.Location = New System.Drawing.Point(421, 20)
            Me.Edit_Target_Tooltip_Key.Name = "Edit_Target_Tooltip_Key"
            Me.Edit_Target_Tooltip_Key.ReadOnly = True
            Me.Edit_Target_Tooltip_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Target_Tooltip_Key.TabIndex = 57
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(57, 326)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(83, 16)
            Me.Label4.TabIndex = 51
            Me.Label4.Text = "Attacker Hit :"
            '
            'Edit_Victim_Hit
            '
            Me.Edit_Victim_Hit.Location = New System.Drawing.Point(134, 404)
            Me.Edit_Victim_Hit.Multiline = True
            Me.Edit_Victim_Hit.Name = "Edit_Victim_Hit"
            Me.Edit_Victim_Hit.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Victim_Hit.TabIndex = 52
            '
            'Button6
            '
            Me.Button6.Location = New System.Drawing.Point(549, 404)
            Me.Button6.Name = "Button6"
            Me.Button6.Size = New System.Drawing.Size(26, 22)
            Me.Button6.TabIndex = 54
            Me.Button6.UseVisualStyleBackColor = True
            '
            'Edit_Victim_Hit_Key
            '
            Me.Edit_Victim_Hit_Key.Location = New System.Drawing.Point(421, 404)
            Me.Edit_Victim_Hit_Key.Name = "Edit_Victim_Hit_Key"
            Me.Edit_Victim_Hit_Key.ReadOnly = True
            Me.Edit_Victim_Hit_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Victim_Hit_Key.TabIndex = 53
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(68, 403)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(71, 16)
            Me.Label8.TabIndex = 47
            Me.Label8.Text = "Victim Hit :"
            '
            'Edit_Attacker_Hit
            '
            Me.Edit_Attacker_Hit.Location = New System.Drawing.Point(134, 327)
            Me.Edit_Attacker_Hit.Multiline = True
            Me.Edit_Attacker_Hit.Name = "Edit_Attacker_Hit"
            Me.Edit_Attacker_Hit.Size = New System.Drawing.Size(283, 70)
            Me.Edit_Attacker_Hit.TabIndex = 48
            '
            'Button8
            '
            Me.Button8.Location = New System.Drawing.Point(549, 326)
            Me.Button8.Name = "Button8"
            Me.Button8.Size = New System.Drawing.Size(26, 22)
            Me.Button8.TabIndex = 50
            Me.Button8.UseVisualStyleBackColor = True
            '
            'Edit_Attacker_Hit_Key
            '
            Me.Edit_Attacker_Hit_Key.Location = New System.Drawing.Point(421, 326)
            Me.Edit_Attacker_Hit_Key.Name = "Edit_Attacker_Hit_Key"
            Me.Edit_Attacker_Hit_Key.ReadOnly = True
            Me.Edit_Attacker_Hit_Key.Size = New System.Drawing.Size(124, 23)
            Me.Edit_Attacker_Hit_Key.TabIndex = 49
            '
            'Label20
            '
            Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label20.BackColor = System.Drawing.Color.Black
            Me.Label20.ForeColor = System.Drawing.Color.White
            Me.Label20.Location = New System.Drawing.Point(0, 0)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(0, 18)
            Me.Label20.TabIndex = 38
            Me.Label20.Text = "Messages :"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Coral
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Button1)
            Me.Panel2.Controls.Add(Me.TextBox2)
            Me.Panel2.Controls.Add(Me.Label104)
            Me.Panel2.Controls.Add(Me.ComboBox1)
            Me.Panel2.Controls.Add(Me.Label30)
            Me.Panel2.Location = New System.Drawing.Point(0, 45)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(461, 168)
            Me.Panel2.TabIndex = 59
            Me.Panel2.Visible = False
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(338, 116)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(101, 25)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "Search"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'TextBox2
            '
            Me.TextBox2.Location = New System.Drawing.Point(124, 35)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(316, 23)
            Me.TextBox2.TabIndex = 3
            '
            'Label104
            '
            Me.Label104.AutoSize = True
            Me.Label104.Location = New System.Drawing.Point(62, 38)
            Me.Label104.Name = "Label104"
            Me.Label104.Size = New System.Drawing.Size(64, 15)
            Me.Label104.TabIndex = 2
            Me.Label104.Text = "Search  :"
            '
            'ComboBox1
            '
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(124, 7)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(316, 23)
            Me.ComboBox1.TabIndex = 1
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(56, 10)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(71, 15)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "Property :"
            '
            'COH_Power_Editor
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.AutoScroll = True
            Me.Name = "COH_Power_Editor"
            Me.Size = New System.Drawing.Size(885, 551)
            Me.TabPage12.ResumeLayout(False)
            Me.TabControl_Powers.ResumeLayout(False)
            Me.TabPage3.ResumeLayout(False)
            Me.TabPage3.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage5.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            CType(Me.Edit_BoxSize_Z, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_BoxSize_Y, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_BoxSize_X, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Box_Z, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Box_Y, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Box_X, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Pos_Yaw, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Pos_Height, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Pos_Centre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Pos_Distance, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            Me.TableLayoutPanel6.ResumeLayout(False)
            Me.TableLayoutPanel6.PerformLayout()
            CType(Me.Edit_Boost_MaxLevel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Boost_License, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Usage_LifetimeGameMax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Usage_LifetimeMax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Usage_TimeMax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Time_SelfConfirm, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_NumberCharges, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_NumberChargesMax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Cost_Idea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Time_Recharge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Time_ActivatePeriod, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Usage_LifetimeGame, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Usage_Lifetime, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Usage_Time, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Time_Activate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Time_Confirm, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Cost_Endurance, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Time_Interrupt, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_ServerTray, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_NumAllowed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Slot_Min, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Slot_Max, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage7.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.Edit_Range, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Accuracy, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Target_Radius, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Target_MaxHit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Target_Arc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_Range_Secondary, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage4.ResumeLayout(False)
            Me.TabPage4.PerformLayout()
            CType(Me.Edit_PreferenceMulti, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_ForceLevelBought, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_AI_Multiplier, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Edit_AI_Point, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage1.ResumeLayout(False)
            Me.TabPage1.PerformLayout()
            Me.TabPage6.ResumeLayout(False)
            Me.TabPage6.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TabControl_Powers As TabControl
        Friend WithEvents TabPage3 As TabPage
        Friend WithEvents Label6 As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents Label21 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents Button5 As Button
        Friend WithEvents Label15 As Label
        Friend WithEvents Edit_DisplayNameKey As TextBox
        Friend WithEvents Edit_DisplayName As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Edit_ClassName As TextBox
        Friend WithEvents Label19 As Label
        Friend WithEvents Edit_Tooltip As TextBox
        Friend WithEvents Edit_Help As TextBox
        Friend WithEvents Edit_Icon As TextBox
        Friend WithEvents Button3 As Button
        Friend WithEvents Button2 As Button
        Friend WithEvents Edit_ToolTipKey As TextBox
        Friend WithEvents Edit_HelpKey As TextBox
        Friend WithEvents TabPage6 As TabPage
        Friend WithEvents Label20 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Edit_FullName As TextBox
        Friend WithEvents Button4 As Button
        Friend WithEvents Edit_FullNameCRC As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Edit_SourceFile As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Edit_SourceName As TextBox
        Friend WithEvents Label_Valid As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Edit_Attacker_Hit As TextBox
        Friend WithEvents Button8 As Button
        Friend WithEvents Edit_Attacker_Hit_Key As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Edit_Victim_Hit As TextBox
        Friend WithEvents Button6 As Button
        Friend WithEvents Edit_Victim_Hit_Key As TextBox
        Friend WithEvents Label10 As Label
        Friend WithEvents Edit_Attacker_AttackF As TextBox
        Friend WithEvents Button10 As Button
        Friend WithEvents Edit_Attacker_Attack_Key As TextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents Edit_Attacker_Attack As TextBox
        Friend WithEvents Button11 As Button
        Friend WithEvents Edit_Attacker_AttackF_Key As TextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Edit_Target_Help As TextBox
        Friend WithEvents Button7 As Button
        Friend WithEvents Edit_Target_Help_Key As TextBox
        Friend WithEvents Label9 As Label
        Friend WithEvents Edit_Target_Tooltip As TextBox
        Friend WithEvents Button9 As Button
        Friend WithEvents Edit_Target_Tooltip_Key As TextBox
        Friend WithEvents Edit_Confirm As TextBox
        Friend WithEvents Button12 As Button
        Friend WithEvents Label13 As Label
        Friend WithEvents Edit_Confirm_Key As TextBox
        Friend WithEvents Label14 As Label
        Friend WithEvents Edit_Float_Defense As TextBox
        Friend WithEvents Button13 As Button
        Friend WithEvents Edit_Float_DefenseKey As TextBox
        Friend WithEvents Label16 As Label
        Friend WithEvents Edit_Float_Rewarded As TextBox
        Friend WithEvents Button14 As Button
        Friend WithEvents Edit_Float_RewardedKey As TextBox
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents Select_PowerSystem As ComboBox
        Friend WithEvents Label17 As Label
        Friend WithEvents Select_PowerType As ComboBox
        Friend WithEvents Label18 As Label
        Friend WithEvents Edit_NumAllowed As NumericUpDown
        Friend WithEvents Label24 As Label
        Friend WithEvents Label23 As Label
        Friend WithEvents Label25 As Label
        Friend WithEvents Label27 As Label
        Friend WithEvents Edit_Requires_Buy As ListBox
        Friend WithEvents Edit_Requires_Slot As ListBox
        Friend WithEvents Label26 As Label
        Friend WithEvents Edit_Requires_Activate As ListBox
        Friend WithEvents Label22 As Label
        Friend WithEvents Edit_Requires_Auction As ListBox
        Friend WithEvents Label28 As Label
        Friend WithEvents Edit_Requires_Reward As ListBox
        Friend WithEvents Label29 As Label
        Friend WithEvents Edit_Requires_Target As ListBox
        Friend WithEvents Label31 As Label
        Friend WithEvents Edit_Requires_Confirm As ListBox
        Friend WithEvents Label32 As Label
        Friend WithEvents Select_Cast_Death As ComboBox
        Friend WithEvents Label35 As Label
        Friend WithEvents Check_Cast_Terrorize As CheckBox
        Friend WithEvents Check_Cast_Stun As CheckBox
        Friend WithEvents Check_Cast_Sleep As CheckBox
        Friend WithEvents Label34 As Label
        Friend WithEvents Label33 As Label
        Friend WithEvents Check_Cast_Hold As CheckBox
        Friend WithEvents Check_Toggle_Stun As CheckBox
        Friend WithEvents Check_Toggle_Sleep As CheckBox
        Friend WithEvents Label37 As Label
        Friend WithEvents Check_Toggle_Hold As CheckBox
        Friend WithEvents ListBox1 As ListBox
        Friend WithEvents Edit_Cost_Endurance As NumericUpDown
        Friend WithEvents Label39 As Label
        Friend WithEvents Edit_Time_ActivatePeriod As NumericUpDown
        Friend WithEvents Label40 As Label
        Friend WithEvents Edit_Time_Recharge As NumericUpDown
        Friend WithEvents Label38 As Label
        Friend WithEvents Edit_Time_Activate As NumericUpDown
        Friend WithEvents Label41 As Label
        Friend WithEvents Edit_Cost_Idea As NumericUpDown
        Friend WithEvents Label42 As Label
        Friend WithEvents Edit_Time_SelfConfirm As NumericUpDown
        Friend WithEvents Label_Time_SelfConfirm As Label
        Friend WithEvents Edit_Time_Confirm As NumericUpDown
        Friend WithEvents Label44 As Label
        Friend WithEvents Edit_Usage_LifetimeGameMax As NumericUpDown
        Friend WithEvents Label43 As Label
        Friend WithEvents Edit_Usage_LifetimeGame As NumericUpDown
        Friend WithEvents Label45 As Label
        Friend WithEvents Edit_Usage_LifetimeMax As NumericUpDown
        Friend WithEvents Label46 As Label
        Friend WithEvents Label47 As Label
        Friend WithEvents Edit_Usage_Lifetime As NumericUpDown
        Friend WithEvents Label48 As Label
        Friend WithEvents Edit_Usage_TimeMax As NumericUpDown
        Friend WithEvents Label50 As Label
        Friend WithEvents Edit_Usage_Time As NumericUpDown
        Friend WithEvents Label51 As Label
        Friend WithEvents Edit_Time_Interrupt As NumericUpDown
        Friend WithEvents Label49 As Label
        Friend WithEvents Check_CanCancel As CheckBox
        Friend WithEvents Check_Toggle_Droppable As CheckBox
        Friend WithEvents Check_Toggle_IgnoreDisatance As CheckBox
        Friend WithEvents Check_DestroyLimit As CheckBox
        Friend WithEvents Check_StackingUsage As CheckBox
        Friend WithEvents Edit_NumberChargesMax As NumericUpDown
        Friend WithEvents Label56 As Label
        Friend WithEvents Edit_NumberCharges As NumericUpDown
        Friend WithEvents Label57 As Label
        Friend WithEvents Check_NearGround As CheckBox
        Friend WithEvents Check_IgnoreLevelBought As CheckBox
        Friend WithEvents Check_InterruptableSleep As CheckBox
        Friend WithEvents Edit_PowerGroup As ListBox
        Friend WithEvents Label64 As Label
        Friend WithEvents Check_IgnoreStrength As CheckBox
        Friend WithEvents Label69 As Label
        Friend WithEvents Edit_ChainPower As TextBox
        Friend WithEvents Label74 As Label
        Friend WithEvents Edit_StoreProduct As TextBox
        Friend WithEvents Edit_Slot_Max As NumericUpDown
        Friend WithEvents Label75 As Label
        Friend WithEvents Edit_Slot_Min As NumericUpDown
        Friend WithEvents Label76 As Label
        Friend WithEvents Label77 As Label
        Friend WithEvents Edit_RewardFallback As TextBox
        Friend WithEvents Check_Delete As CheckBox
        Friend WithEvents Check_Trade As CheckBox
        Friend WithEvents Check_TravelSuppress As CheckBox
        Friend WithEvents TabPage4 As TabPage
        Friend WithEvents Edit_PreferenceMulti As NumericUpDown
        Friend WithEvents Label78 As Label
        Friend WithEvents Select_AIReport As ComboBox
        Friend WithEvents Label73 As Label
        Friend WithEvents Edit_ForceLevelBought As NumericUpDown
        Friend WithEvents Label70 As Label
        Friend WithEvents Label66 As Label
        Friend WithEvents Edit_AI_Multiplier As NumericUpDown
        Friend WithEvents Label67 As Label
        Friend WithEvents Edit_AI_Point As NumericUpDown
        Friend WithEvents Label68 As Label
        Friend WithEvents Label81 As Label
        Friend WithEvents Edit_Boost_Catalyst As TextBox
        Friend WithEvents Check_Boost_UsePlayerLevel As CheckBox
        Friend WithEvents Check_Boost_Trade As CheckBox
        Friend WithEvents Check_Boost_DontSave As CheckBox
        Friend WithEvents Check_Boost_AccountBound As CheckBox
        Friend WithEvents Check_Boost_AccountSet As CheckBox
        Friend WithEvents Check_Boost_Combines As CheckBox
        Friend WithEvents Label83 As Label
        Friend WithEvents Check_Boost_IgnoreEffectiveness As CheckBox
        Friend WithEvents Edit_Boost_License As NumericUpDown
        Friend WithEvents Label80 As Label
        Friend WithEvents Edit_Boost_MaxLevel As NumericUpDown
        Friend WithEvents Label82 As Label
        Friend WithEvents Check_Boost_Boostable As CheckBox
        Friend WithEvents TabPage5 As TabPage
        Friend WithEvents Label85 As Label
        Friend WithEvents EditList_HighlightEval As ListBox
        Friend WithEvents Label84 As Label
        Friend WithEvents Edit_HilightIcon As TextBox
        Friend WithEvents Check_RefreshPlayerChange As CheckBox
        Friend WithEvents Label79 As Label
        Friend WithEvents CoH_ColorSelection1 As Toolkit.Controls.WinForms.COH_ColorSelection
        Friend WithEvents Check_Show_Info As CheckBox
        Friend WithEvents Check_Show_Manage As CheckBox
        Friend WithEvents Check_Show_Buff As CheckBox
        Friend WithEvents Select_ShowInventory As ComboBox
        Friend WithEvents Label71 As Label
        Friend WithEvents Label72 As Label
        Friend WithEvents Edit_Pos_Yaw As NumericUpDown
        Friend WithEvents Label89 As Label
        Friend WithEvents Edit_Pos_Height As NumericUpDown
        Friend WithEvents Label90 As Label
        Friend WithEvents Edit_Pos_Distance As NumericUpDown
        Friend WithEvents Label87 As Label
        Friend WithEvents Edit_Pos_Centre As NumericUpDown
        Friend WithEvents Label88 As Label
        Friend WithEvents Check_DontSetStance As CheckBox
        Friend WithEvents Label86 As Label
        Friend WithEvents Check_ProcMain As CheckBox
        Friend WithEvents Check_AnimateMain As CheckBox
        Friend WithEvents Check_FaceTarget As CheckBox
        Friend WithEvents Label91 As Label
        Friend WithEvents Edit_VisualFX As TextBox
        Friend WithEvents Label92 As Label
        Friend WithEvents EditList_BoostsAllowed As ListBox
        Friend WithEvents EditList_Modes_Disallowed As ListBox
        Friend WithEvents Label93 As Label
        Friend WithEvents EditList_Modes_Required As ListBox
        Friend WithEvents Label94 As Label
        Friend WithEvents Edit_BoxSize_Z As NumericUpDown
        Friend WithEvents Edit_BoxSize_Y As NumericUpDown
        Friend WithEvents Edit_BoxSize_X As NumericUpDown
        Friend WithEvents Label96 As Label
        Friend WithEvents Edit_Box_Z As NumericUpDown
        Friend WithEvents Edit_Box_Y As NumericUpDown
        Friend WithEvents Edit_Box_X As NumericUpDown
        Friend WithEvents Label95 As Label
        Friend WithEvents Edit_ServerTray As NumericUpDown
        Friend WithEvents Label97 As Label
        Friend WithEvents Label98 As Label
        Friend WithEvents EditList_AIGroups As ListBox
        Friend WithEvents Check_Free As CheckBox
        Friend WithEvents Check_AutoIssueSaveLevel As CheckBox
        Friend WithEvents Check_AutoIssue As CheckBox
        Friend WithEvents EditList_StrengthDis As ListBox
        Friend WithEvents Label99 As Label
        Friend WithEvents TabPage7 As TabPage
        Friend WithEvents Check_PowerRedirect As CheckBox
        Friend WithEvents Edit_Accuracy As NumericUpDown
        Friend WithEvents Label65 As Label
        Friend WithEvents Check_Target_VisionPhase As CheckBox
        Friend WithEvents Select_EffectArea As ComboBox
        Friend WithEvents Label58 As Label
        Friend WithEvents Edit_Target_MaxHit As NumericUpDown
        Friend WithEvents Label59 As Label
        Friend WithEvents Edit_Target_Arc As NumericUpDown
        Friend WithEvents Label60 As Label
        Friend WithEvents Edit_Target_Radius As NumericUpDown
        Friend WithEvents Label61 As Label
        Friend WithEvents Edit_Range_Secondary As NumericUpDown
        Friend WithEvents Label62 As Label
        Friend WithEvents Edit_Range As NumericUpDown
        Friend WithEvents Label63 As Label
        Friend WithEvents Check_ThroughUntouch As CheckBox
        Friend WithEvents Check_Target_Shuffle As CheckBox
        Friend WithEvents Check_EviromentHit As CheckBox
        Friend WithEvents Check_Target_NearGround As CheckBox
        Friend WithEvents Select_TargetSecondary As ComboBox
        Friend WithEvents Label55 As Label
        Friend WithEvents Select_TargetVisibility As ComboBox
        Friend WithEvents Label54 As Label
        Friend WithEvents Select_Target As ComboBox
        Friend WithEvents Label53 As Label
        Friend WithEvents Label52 As Label
        Friend WithEvents Check_InstanceLocked As CheckBox
        Friend WithEvents Check_AbusiveBuff As CheckBox
        Friend WithEvents Label100 As Label
        Friend WithEvents Label102 As Label
        Friend WithEvents Edit_Ents_Affected As ListBox
        Friend WithEvents Label101 As Label
        Friend WithEvents Edit_Ents_Auto As ListBox
        Friend WithEvents Label103 As Label
        Friend WithEvents View_Variables As ListView
        Friend WithEvents ColumnHeader2 As ColumnHeader
        Friend WithEvents ColumnHeader1 As ColumnHeader
        Friend WithEvents ColumnHeader3 As ColumnHeader
        Friend WithEvents ColumnHeader4 As ColumnHeader
        Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
        Friend WithEvents Edit_AttackTypes As ListBox
        Friend WithEvents Label36 As Label
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Button1 As Button
        Friend WithEvents TextBox2 As TextBox
        Friend WithEvents Label104 As Label
        Friend WithEvents ComboBox1 As ComboBox
        Friend WithEvents Label30 As Label
    End Class
End Namespace