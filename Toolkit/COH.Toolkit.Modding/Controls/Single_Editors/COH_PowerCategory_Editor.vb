Imports COH.GameContent.Enums
Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Characters.Powers
Imports COH.GameContent.Structures.Powers
Imports COH.Storage.Structures
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums

Namespace Toolkit.Modding.Editors
    Public Class COH_CategoryEditor

#Region "Properties"
        Protected Overrides ReadOnly Property Current_Struct As COH_FileStructure
            Get
                Return mCurrent
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private WithEvents mCurrent As COH_PowerCategory
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

#Region "Load Content"
        Overrides Function LoadContent(ClassType As COH_ProjectContent, FileName As String) As Boolean
            Cursor.Current = Cursors.WaitCursor
            Current_Content = ContentController.Retrieve_ModableContent(FileName, COH_ProjectContent.PowerCategory)
            Return DisplayContent()
        End Function
#End Region

#Region "Configure UI Enabled/Disabled"
        Public Overrides Sub ConfigureUI_EnabledDisabled()
            MyBase.ConfigureUI_EnabledDisabled()
            Dim AllowEdit As Boolean = True
            If Current_Content Is Nothing Then AllowEdit = False
            If AdvancedEditLocked = True Then
                Image_Locked.BackgroundImage = My.Resources.Button_Locked
            Else
                Image_Locked.BackgroundImage = My.Resources.Button_Unlocked
            End If
            If AllowEdit = True Then
                Button_Refresh_DisplayName.Enabled = (AdvancedEditLocked = False)
                Edit_DisplayNameKey.ReadOnly = AdvancedEditLocked
            Else
                Edit_ClassName.ReadOnly = True
            End If
            If AllowEdit = True AndAlso Current_Content.IsCustom = True Then
                Edit_ClassName.ReadOnly = False
            Else
                Edit_ClassName.ReadOnly = True
            End If
        End Sub
#End Region


#Region "Display"
        Private Function DisplayContent() As Boolean
            Cursor.Current = Cursors.WaitCursor
            If (Current_Content Is Nothing) = False Then
                mCurrent = TryCast(Current_Content.Content, COH_PowerCategory).Clone
                Display_CurrentStruct()
                DisplayPowerCategory()
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
        Private Function DisplayPowerCategory() As Boolean
            Cursor.Current = Cursors.WaitCursor
            Changes_Locked = True
            Edit_ClassName.Text = mCurrent.Name
            Edit_DisplayName.Text = mCurrent.DisplayName.DisplayText
            Edit_DisplayNameKey.Text = mCurrent.DisplayName.Key
            Edit_List_Powers.BeginUpdate()
            For Each item In mCurrent.PowerSets
                Edit_List_Powers.Items.Add(item)
            Next
            Edit_List_Powers.EndUpdate()
            ButtonPressed_Preview()
            Changes_Locked = False
            Cursor.Current = Cursors.Default
            Return True
        End Function
#End Region
    End Class
End Namespace