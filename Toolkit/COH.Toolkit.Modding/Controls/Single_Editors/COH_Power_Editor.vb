Imports COH.CodeManagement.Enums
Imports COH.CodeManagement.Enums.Structures
Imports COH.GameContent.Structures.Characters.Powers
Imports COH.GameContent.Structures.Resources.Textures
Imports COH.Storage.Structures
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Toolkit.Modding.Editors
    Public Class COH_Power_Editor

#Region "Properties"
        Protected Overrides ReadOnly Property Current_Struct As COH_FileStructure
            Get
                Return mCurrent
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private WithEvents mCurrent As COH_Power
        Private mIcon As Image
#End Region

#Region "Initialize"
        Public Sub New()
            Me.New(Nothing)
        End Sub
        Public Sub New(ByRef TheContentController As ISupport_MasterController)
            MyBase.New(TheContentController)
            InitializeComponent()
            ConfigureUI()
        End Sub
#End Region

#Region "Configure UI"
        Public Overrides Sub ConfigureUI()
            MyBase.ConfigureUI()
            Changes_Locked = True
            ConfigureUI_Enums()
            ConfigureUI_Tooltips()
            Changes_Locked = False
        End Sub
        Private Sub ConfigureUI_Enums()
            Select_PowerSystem.DataSource = [Enum].GetValues(GetType(COH_Enum_PowerSystem))
            Select_PowerType.DataSource = [Enum].GetValues(GetType(COH_Enum_PowerType))
            Select_Cast_Death.DataSource = [Enum].GetValues(GetType(COH_Enum_DeathCastableSetting))
            Select_Target.DataSource = [Enum].GetValues(GetType(COH_Enum_TargetType))
            Select_TargetSecondary.DataSource = [Enum].GetValues(GetType(COH_Enum_TargetType))
            Select_TargetVisibility.DataSource = [Enum].GetValues(GetType(COH_Enum_TargetVisibility))
            Select_EffectArea.DataSource = [Enum].GetValues(GetType(COH_Enum_EffectArea))
            Select_ShowInventory.DataSource = [Enum].GetValues(GetType(COH_Enum_ShowPowerSetting))
            Select_AIReport.DataSource = [Enum].GetValues(GetType(COH_Enum_AIReport))
        End Sub
        Private Sub ConfigureUI_Tooltips()
            With FormToolTip
                '//.SetToolTip(Select_Allowed_Origins, "This determins what origins can be picked by the player")
            End With
        End Sub
#End Region

#Region "Configure UI Enabled/Disabled"
        Public Overrides Sub ConfigureUI_EnabledDisabled()
            MyBase.ConfigureUI_EnabledDisabled()
        End Sub
#End Region

#Region "Load Content"
        Overrides Function LoadContent(ClassType As COH_ProjectContent, FileName As String) As Boolean
            Cursor.Current = Cursors.WaitCursor
            Current_Content = ContentController.Retrieve_ModableContent(FileName, COH_ProjectContent.Powers)
            Return DisplayContent()
        End Function
#End Region

#Region "Display"
        Private Function DisplayContent() As Boolean
            Cursor.Current = Cursors.WaitCursor
            If (Current_Content Is Nothing) = False Then
                mCurrent = TryCast(Current_Content.Content, COH_Power).Clone
                Display_CurrentStruct()
                Display_Power()
                ConfigureUI_EnabledDisabled()
                Cursor.Current = Cursors.Default
                Return True
            Else
                Clear_CurrentStruct()
                ConfigureUI_EnabledDisabled()
                Cursor.Current = Cursors.Default
                Return False
            End If
        End Function
        Private Sub Display_Power()
            Cursor.Current = Cursors.WaitCursor
            Changes_Locked = True
            Display_Power_General()
            Display_Power_Icon()
            Display_Power_Visual()
            Display_Power_Target()
            Display_Power_Messages()
            Display_Power_Usage()
            Display_Power_Requirements()
            Display_Validation()
            Display_Power_AI()
            Display_Power_Variables()
            ButtonPressed_Preview()
            Changes_Locked = False
            Cursor.Current = Cursors.Default
        End Sub
        Private Sub Display_Power_General()
            Edit_IsCustom.Checked = Current_Content.IsCustom
            Edit_WasModified.Checked = Current_Content.WasModified_FromSource
            Edit_FullName.Text = mCurrent.FullName
            Edit_FullNameCRC.Text = mCurrent.CRCFullName.ToString("X8")
            Edit_SourceFile.Text = mCurrent.SourceFile
            Edit_SourceName.Text = mCurrent.SourceName
            Edit_ClassName.Text = mCurrent.Name
            Edit_DisplayName.Text = mCurrent.DisplayName.DisplayText
            Edit_DisplayNameKey.Text = mCurrent.DisplayName.Key
            Edit_Help.Text = mCurrent.DisplayHelp.DisplayText
            Edit_HelpKey.Text = mCurrent.DisplayHelp.Key
            Edit_Tooltip.Text = mCurrent.DisplayShortHelp.DisplayText
            Edit_ToolTipKey.Text = mCurrent.DisplayShortHelp.Key
            Edit_Icon.Text = mCurrent.IconName
        End Sub
        Private Sub Display_Power_Icon()
            Dim FileNAme = ContentController.TheController_Assets.RetrieveAsset_FilePath(IO.Path.GetFileNameWithoutExtension(mCurrent.IconName), COH_Supported_ContentType.Unknown)
            If String.IsNullOrEmpty(FileNAme) = False Then
                Dim theResource As COH_FileStructure = ContentController.TheController_Assets.RetrieveAsset_ImageStruct(FileNAme)
                If TypeOf theResource Is COH_Resource_Texture Then
                    mIcon = New Bitmap(TryCast(theResource, COH_Resource_Texture).Extract_Resource_Texture)
                ElseIf TypeOf theResource Is COH_Resource_TGA Then
                    mIcon = New Bitmap(TryCast(theResource, COH_Resource_TGA).Extract_Resource_Texture)
                End If
                PictureBox1.BackgroundImage = mIcon
            Else
                PictureBox1.BackgroundImage = Nothing
            End If
        End Sub
        Private Sub Display_Power_Messages()
            Edit_Target_Help.Text = mCurrent.DisplayTargetHelp.DisplayText : Edit_Target_Help_Key.Text = mCurrent.DisplayTargetHelp.Key
            Edit_Target_Tooltip.Text = mCurrent.DisplayTargetShortHelp.DisplayText : Edit_Target_Tooltip_Key.Text = mCurrent.DisplayTargetShortHelp.Key

            Edit_Attacker_Attack.Text = mCurrent.DisplayAttackerAttack.DisplayText : Edit_Attacker_Attack_Key.Text = mCurrent.DisplayAttackerAttack.Key
            Edit_Attacker_AttackF.Text = mCurrent.DisplayAttackerAttackFloater.DisplayText : Edit_Attacker_AttackF_Key.Text = mCurrent.DisplayAttackerAttackFloater.Key

            Edit_Attacker_Hit.Text = mCurrent.DisplayAttackerHit.DisplayText : Edit_Attacker_Hit_Key.Text = mCurrent.DisplayAttackerHit.Key
            Edit_Victim_Hit.Text = mCurrent.DisplayVictimHit.DisplayText : Edit_Victim_Hit_Key.Text = mCurrent.DisplayVictimHit.Key

            Edit_Confirm.Text = mCurrent.DisplayConfirm.DisplayText : Edit_Confirm_Key.Text = mCurrent.DisplayConfirm.Key
            Edit_Float_Defense.Text = mCurrent.DisplayPowerDefenseFloat.DisplayText : Edit_Float_DefenseKey.Text = mCurrent.DisplayPowerDefenseFloat.Key
            Edit_Float_Rewarded.Text = mCurrent.FloatRewarded.DisplayText : Edit_Float_RewardedKey.Text = mCurrent.FloatRewarded.Key
        End Sub
        Private Sub Display_Power_Visual()
            Select_ShowInventory.Text = mCurrent.ShowInInventory
            Check_Show_Info.Checked = mCurrent.ShowInInfo
            Check_Show_Manage.Checked = mCurrent.ShowInManage
            Check_Show_Buff.Checked = mCurrent.ShowBuffIcon
            CoH_ColorSelection1.Select_Color(mCurrent.HighlightRing.Convert_To_Color)
            Check_RefreshPlayerChange.Checked = mCurrent.RefreshesOnActivePlayerChange
            Edit_HilightIcon.Text = mCurrent.HighlightIcon
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(EditList_HighlightEval, Array.ConvertAll(mCurrent.HighlightEval, Function(e) e.ToString()))
            '//Animation
            Check_DontSetStance.Checked = mCurrent.DontSetStance
            Check_AnimateMain.Checked = mCurrent.AnimMainTargetOnly
            Check_ProcMain.Checked = mCurrent.ProcMainTargetOnly
            Check_FaceTarget.Checked = mCurrent.FaceTarget
            Edit_Pos_Centre.Value = mCurrent.PositionCenter
            Edit_Pos_Distance.Value = mCurrent.PositionDistance
            Edit_Pos_Height.Value = mCurrent.PositionHeight
            Edit_Pos_Yaw.Value = mCurrent.PositionYaw
            Edit_VisualFX.Text = mCurrent.VisualFX
            Edit_BoxSize_X.Value = mCurrent.BoxOffset.X : Edit_BoxSize_Y.Value = mCurrent.BoxOffset.Y : Edit_BoxSize_Z.Value = mCurrent.BoxOffset.Z
            Edit_Box_X.Value = mCurrent.BoxSize.X : Edit_Box_Y.Value = mCurrent.BoxSize.Y : Edit_Box_Z.Value = mCurrent.BoxSize.Z
        End Sub
        Private Sub Display_Power_Target()
            '//TARGET
            Select_Target.Text = mCurrent.Target
            Select_TargetSecondary.Text = mCurrent.TargetSecondary
            Select_TargetVisibility.Text = mCurrent.TargetVisibility
            Check_Target_NearGround.Checked = mCurrent.TargetNearGround
            Check_Target_Shuffle.Checked = mCurrent.ShuffleTargets
            Check_EviromentHit.Checked = mCurrent.IsEnvironmentHit
            Check_ThroughUntouch.Checked = mCurrent.ShootThroughUntouchable
            Edit_Target_Radius.Value = mCurrent.Radius
            Edit_Target_Arc.Value = mCurrent.Arc
            Edit_Range.Value = mCurrent.Range
            Edit_Range_Secondary.Value = mCurrent.RangeSecondary
            Edit_Target_MaxHit.Value = mCurrent.MaxTargetsHit
            Select_EffectArea.Text = mCurrent.EffectArea
            Check_Target_VisionPhase.Checked = mCurrent.TargetsThroughVisionPhase
            Edit_Accuracy.Value = mCurrent.Accuracy
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Ents_Auto, Array.ConvertAll(mCurrent.EntsAutoHit, Function(e) e.ToString()))
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Ents_Affected, Array.ConvertAll(mCurrent.EntsAffected, Function(e) e.ToString()))
        End Sub
        Private Sub Display_Power_Usage()
            Check_AbusiveBuff.Checked = mCurrent.AbusiveBuff
            Check_InstanceLocked.Checked = mCurrent.InstanceLocked
            Select_PowerSystem.Text = mCurrent.System.ToString
            Select_PowerType.Text = mCurrent.Type.ToString
            Edit_NumAllowed.Value = mCurrent.NumAllowed
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_AttackTypes, Array.ConvertAll(mCurrent.AttackTypes, Function(e) e.ToString()))
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_PowerGroup, Array.ConvertAll(mCurrent.GroupMembership, Function(e) e.ToString()))
            Edit_ChainPower.Text = mCurrent.ChainIntoPower
            Edit_StoreProduct.Text = mCurrent.StoreProduct
            Edit_Slot_Min.Value = mCurrent.MinSlotLevel
            Edit_Slot_Max.Value = mCurrent.MaxSlotLevel
            Edit_ServerTray.Value = mCurrent.ServerTrayPriority
            Edit_RewardFallback.Text = mCurrent.RewardFallback
            Check_Trade.Checked = mCurrent.Tradeable
            Check_Delete.Checked = mCurrent.Deletable
            '//CASTABLE
            Check_Cast_Hold.Checked = mCurrent.CastThroughHold
            Check_Cast_Sleep.Checked = mCurrent.CastThroughSleep
            Check_Cast_Stun.Checked = mCurrent.CastThroughStun
            Check_Cast_Terrorize.Checked = mCurrent.CastThroughTerrorize
            Select_Cast_Death.Text = mCurrent.CastableAfterDeath.ToString
            Check_CanCancel.Checked = mCurrent.Cancelable
            Check_NearGround.Checked = mCurrent.NearGround
            '//CHARGES
            Edit_NumberCharges.Value = mCurrent.NumCharges
            Edit_NumberChargesMax.Value = mCurrent.MaxNumCharges
            '//TOGGLES
            Check_Toggle_Hold.Checked = mCurrent.ToggleIgnoreHold
            Check_Toggle_Sleep.Checked = mCurrent.ToggleIgnoreSleep
            Check_Toggle_Stun.Checked = mCurrent.ToggleIgnoreStun
            Check_Toggle_Droppable.Checked = mCurrent.ToggleDroppable
            Check_Toggle_IgnoreDisatance.Checked = mCurrent.IgnoreToggleMaxDistance
            Check_StackingUsage.Checked = mCurrent.StackingUsage
            Check_DestroyLimit.Checked = mCurrent.DestroyOnLimit
            Check_IgnoreLevelBought.Checked = mCurrent.IgnoreLevelBought
            Check_InterruptableSleep.Checked = mCurrent.InterruptLikeSleep
            Check_IgnoreStrength.Checked = mCurrent.IgnoreStrength
            Check_TravelSuppress.Checked = mCurrent.TravelSuppression
            '//ACTIVATION
            Edit_Time_Activate.Value = mCurrent.TimeToActivate
            Edit_Time_ActivatePeriod.Value = mCurrent.ActivatePeriod
            Edit_Time_Recharge.Value = mCurrent.RechargeTime
            Edit_Time_Confirm.Value = mCurrent.TimeToConfirm
            Edit_Time_SelfConfirm.Value = mCurrent.SelfConfirm
            Edit_Time_Interrupt.Value = mCurrent.InterruptTime
            '//COST
            Edit_Cost_Endurance.Value = mCurrent.EnduranceCost
            Edit_Cost_Idea.Value = mCurrent.IdeaCost
            '//USAGE TIME
            Edit_Usage_Time.Value = mCurrent.UsageTime
            Edit_Usage_TimeMax.Value = mCurrent.MaxUsageTime
            Edit_Usage_Lifetime.Value = mCurrent.Lifetime
            Edit_Usage_LifetimeMax.Value = mCurrent.MaxLifetime
            Edit_Usage_LifetimeGame.Value = mCurrent.LifetimeInGame
            Edit_Usage_LifetimeGameMax.Value = mCurrent.MaxLifetimeInGame
            '//BOOSTS
            Edit_Boost_Catalyst.Text = mCurrent.BoostCatalystConversion
            Check_Boost_AccountBound.Checked = mCurrent.BoostAccountBound
            Check_Boost_AccountSet.Checked = mCurrent.BoostAlwaysCountForSet
            Check_Boost_Combines.Checked = mCurrent.BoostCombinable
            Check_Boost_DontSave.Checked = mCurrent.DoNotSave
            Check_Boost_IgnoreEffectiveness.Checked = mCurrent.BoostIgnoreEffectiveness
            Check_Boost_Trade.Checked = mCurrent.BoostTradeable
            Check_Boost_UsePlayerLevel.Checked = mCurrent.BoostUsePlayerLevel
            Edit_Boost_License.Value = mCurrent.BoostLicenseLevel
            Edit_Boost_MaxLevel.Value = mCurrent.MaxBoostLevel
            Check_Boost_Boostable.Checked = mCurrent.BoostBoostable
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(EditList_BoostsAllowed, Array.ConvertAll(mCurrent.BoostsAllowed, Function(e) e.ToString()))
        End Sub
        Private Sub Display_Power_AI()
            Edit_AI_Point.Value = mCurrent.PointValue
            Edit_AI_Multiplier.Value = mCurrent.PointMultiplier
            Check_PowerRedirect.Checked = mCurrent.PowerRedirector
            Edit_ForceLevelBought.Value = mCurrent.ForceLevelBought
            Select_AIReport.Text = mCurrent.AIReport
            Edit_PreferenceMulti.Value = mCurrent.PreferenceMultiplier
        End Sub
        Private Sub Display_Power_Requirements()
            Check_Free.Checked = mCurrent.Free
            Check_AutoIssue.Checked = mCurrent.AutoIssue
            Check_AutoIssueSaveLevel.Checked = mCurrent.AutoIssueSaveLevel
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Activate, mCurrent.ActivateRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Auction, mCurrent.AuctionRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Buy, mCurrent.BuyRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Confirm, mCurrent.ConfirmRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Reward, mCurrent.RewardRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Slot, mCurrent.SlotRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(Edit_Requires_Target, mCurrent.TargetRequires)
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(EditList_Modes_Required, Array.ConvertAll(mCurrent.ModesRequired, Function(e) e.ToString()))
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(EditList_Modes_Disallowed, Array.ConvertAll(mCurrent.ModesDisallowed, Function(e) e.ToString()))
            Helperfunctions.Toolkit.Controls.Lists.Fill_ListBox(EditList_StrengthDis, Array.ConvertAll(mCurrent.StrengthsDisallowed, Function(e) e.ToString()))
        End Sub
        Private Sub Display_Power_Variables()
            With View_Variables
                .BeginUpdate()
                .Items.Clear()
                For Each item In mCurrent.Var
                    Dim NewItem As New ListViewItem(item.Index)
                    NewItem.Name = item.Index
                    NewItem.SubItems.Add(item.Name)
                    NewItem.SubItems.Add(item.Min)
                    NewItem.SubItems.Add(item.Max)
                    .Items.Add(NewItem)
                Next
                .EndUpdate()
            End With
        End Sub
        Private Sub Display_Validation()
            Dim FoundValue As String = ""
            If mCurrent.CheckValid_CRC32c(FoundValue) = True Then
                Label_Valid.Text = "Valid Check : PASSED"
                Label_Valid.ForeColor = Me.Parent.ForeColor
            Else
                Label_Valid.Text = "Valid Check : FAILED" & Environment.NewLine & FoundValue
                Label_Valid.ForeColor = Color.Red
            End If
        End Sub

        Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

        End Sub

        Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

        End Sub

        Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

        End Sub
#End Region


#Region "Search"
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Cursor.Current = Cursors.WaitCursor
            Dim PropertyName As String = "CostumeName"
            For Each Cat In Me.ContentController.Retrieve_ModableContent(COH_ProjectContent.Powers)
                Dim ThePower As COH_Power = Cat.Content
                ' If ThePower.AIGroups.Count > 0 Then
                'MsgBox("Found : " & ThePower.SourceName & " : " & ThePower.AIGroups.Count)
                'End If
                ' For X = 0 To ThePower.AttribMod.Count - 1
                ' If String.IsNullOrEmpty(ThePower.AttribMod(0).ConditionalFX) = False Then
                If String.IsNullOrEmpty(ThePower.AttribMod(0).CostumeName) = False Then


                    MsgBox("Found : " & ThePower.SourceName & " : " & ThePower.AttribMod(0).ConditionalFX)
                End If
                'End If
                'Next
            Next
            Cursor.Current = DefaultCursor
        End Sub
#End Region

    End Class
End Namespace