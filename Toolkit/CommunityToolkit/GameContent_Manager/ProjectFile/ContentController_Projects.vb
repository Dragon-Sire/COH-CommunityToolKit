Imports COH.GameContent.Structures
Imports COH.GameContent.Structures.Characters
Imports COH.GameContent.Structures.MeshRelated
Imports COH.GameContent.Structures.Shared
Imports COH.HelperClasses.Wrappers
Imports COH.Storage.Controllers
Imports COH.Toolkit.CodeManagement.Interfaces
Imports COH.Toolkit.Enums
Imports COH.Toolkit.ProjectFiles

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Properties"
        Public ReadOnly Property Cached_CurrentProjectFile As COH_ProjectFile Implements ISupport_MasterController.CurrentProjectFile
            Get
                If mCached_CurrentProjectFile Is Nothing Then Return Nothing
                Return Retrieve_CurrentPoject(False)
            End Get
        End Property
        Public ReadOnly Property Cached_CurrentProject_PathRoot As String
            Get
                Return mSettings.CurrentProject_RootFolder
            End Get
        End Property
        Public ReadOnly Property Cached_CurrentProject_FilePath As String
            Get
                Return mSettings.CurrentProject_FilePath
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mCached_CurrentProjectFile As COH_ProjectFile
        Private mCached_ProjectMapping As COH_XML_Dictionary(Of String, COH_ProjectContent())
        Private mCahced_ModMapping As COH_XML_Dictionary(Of COH_ProjectContent, Type)
#End Region

#Region "Create Standard Project File"
        Public Function Start_FreshProjectFile_Standard(Optional ShowMessage As Boolean = False) As Boolean
            mSettings.Reset_ToDefaultProject()
            mCached_CurrentProjectFile = CreateProjectFile_Standard()
            If COH_ProjectFile.Export_XML_ProjectFolder(mSettings.CurrentProject_FilePath, mCached_CurrentProjectFile) = False Then

            End If
            If ShowMessage = True Then ShowMessage_Simple("Standard Project Created")
            Return True
        End Function
        Private Function CreateProjectFile_Standard() As COH_ProjectFile
            Dim Result As New COH_ProjectFile
            With Result
                .Name = "CityofHeroes_StandardProject"
                .Author = "Crytic/Paragon Studios Revised by Ouroboros"
                .ReleaseDate = "01/01/2020"
                .Version = "1.0.Alpha"
                .Website = ""
            End With
            Result.Index_Update(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins, Retrieve_IndexPath(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins))
            Result.Index_Update(COH_ProjectContent.CharacterClasses_EnemyClass_Origins, Retrieve_IndexPath(COH_ProjectContent.CharacterClasses_EnemyClass_Origins))
            Result.Index_Update(COH_ProjectContent.CharacterClasses_PlayerClasses, Retrieve_IndexPath(COH_ProjectContent.CharacterClasses_PlayerClasses))
            Result.Index_Update(COH_ProjectContent.CharacterClasses_EnemyClass, Retrieve_IndexPath(COH_ProjectContent.CharacterClasses_EnemyClass))
            Result.Index_Update(COH_ProjectContent.PowerCategory, Retrieve_IndexPath(COH_ProjectContent.PowerCategory))
            Result.Index_Update(COH_ProjectContent.PowerSets, Retrieve_IndexPath(COH_ProjectContent.PowerSets))
            Result.Index_Update(COH_ProjectContent.Powers, Retrieve_IndexPath(COH_ProjectContent.Powers))
            Result.Index_Update(COH_ProjectContent.Tricks_AND_TextureOptions, Retrieve_IndexPath(COH_ProjectContent.Tricks_AND_TextureOptions))
            Return Result
        End Function
        Private Function Retrieve_IndexPath(Selected As COH_ProjectContent) As String
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(Selected)
            Dim SourcePath As String = Root & "Index_" & Retrieve_FileName(Selected) & ".xml"
            Return SourcePath
        End Function
        Private Function CreateListProjectMapping() As COH_XML_Dictionary(Of String, COH_ProjectContent())
            Dim Result As New COH_XML_Dictionary(Of String, COH_ProjectContent())
            With Result
                .Add("powercats.bin", New COH_ProjectContent(0) {COH_ProjectContent.PowerCategory})
                .Add("powersets.bin", New COH_ProjectContent(0) {COH_ProjectContent.PowerSets})
                .Add("powers.bin", New COH_ProjectContent(0) {COH_ProjectContent.Powers})
                .Add("classes.bin", New COH_ProjectContent(0) {COH_ProjectContent.CharacterClasses_PlayerClasses})
                .Add("villain_classes.bin", New COH_ProjectContent(0) {COH_ProjectContent.CharacterClasses_EnemyClass})
                .Add("attrib_names.bin", New COH_ProjectContent(0) {COH_ProjectContent.CharacterClasses_Attrib_Names})
                .Add("attrib_descriptions.bin", New COH_ProjectContent(0) {COH_ProjectContent.CharacterClasses_Attrib_Descriptions})
                .Add("origins.bin", New COH_ProjectContent(0) {COH_ProjectContent.CharacterClasses_PlayerClasses_Origins})
                .Add("villain_origins.bin", New COH_ProjectContent(0) {COH_ProjectContent.CharacterClasses_EnemyClass_Origins})
                .Add("product_catalog.bin", New COH_ProjectContent(0) {COH_ProjectContent.Store_ProductCatalog})
                .Add("PC_Def_Contacts.bin", New COH_ProjectContent(0) {COH_ProjectContent.Contacts_List})
                .Add("npcs_client.bin", New COH_ProjectContent(0) {COH_ProjectContent.Contacts_NPC})
                .Add("ent_types.bin", New COH_ProjectContent(0) {COH_ProjectContent.Entities})
                .Add("sequencers.bin", New COH_ProjectContent(0) {COH_ProjectContent.AnimationSequences})
                .Add("tricks.bin", New COH_ProjectContent(2) {COH_ProjectContent.Tricks_AND_TextureOptions, COH_ProjectContent.TextureOptions, COH_ProjectContent.Tricks})
            End With
            Return Result
        End Function
        Private Function CreateListProjectMapping_ModType() As COH_XML_Dictionary(Of COH_ProjectContent, Type)
            Dim Result As New COH_XML_Dictionary(Of COH_ProjectContent, Type)
            With Result
                .Add(COH_ProjectContent.CharacterClasses_PlayerClasses, GetType(COH_CharacterClass))
                .Add(COH_ProjectContent.CharacterClasses_EnemyClass, GetType(COH_CharacterClass))
                .Add(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins, GetType(COH_Origin))
                .Add(COH_ProjectContent.CharacterClasses_EnemyClass_Origins, GetType(COH_Origin))
                .Add(COH_ProjectContent.Powers, GetType(Characters.Powers.COH_Power))
                .Add(COH_ProjectContent.PowerSets, GetType(Characters.Powers.COH_PowerSet))
                .Add(COH_ProjectContent.PowerCategory, GetType(Characters.Powers.COH_PowerCategory))
                .Add(COH_ProjectContent.CharacterClasses_Attrib_Names, GetType(COH_AttributeName))
                .Add(COH_ProjectContent.CharacterClasses_Attrib_Descriptions, GetType(COH_AttributeDescription))
                .Add(COH_ProjectContent.Tricks, GetType(COH_Trick))
                .Add(COH_ProjectContent.TextureOptions, GetType(MeshRelated.Textures.COH_TextureOptions))
            End With
            Return Result
        End Function

        Public Function Retrieve_ProjectPathType(FileName As String) As COH_ProjectContent()
            Return mCached_ProjectMapping.Item(FileName)
        End Function
        Public Function Retrieve_FileName(Selected As COH_ProjectContent) As String
            For Each item In mCached_ProjectMapping
                For Each Entry In item.Value
                    If Entry = Selected Then Return item.Key
                Next
            Next
            Return Nothing
        End Function
        Public Function Retrieve_FileName(Selected As COH_ProjectContent, ByRef FileName As String, ByRef Index As Integer, Optional ByRef RootType As COH_ProjectContent = Nothing) As Boolean
            For Each item In mCached_ProjectMapping
                For X = 0 To item.Value.Count - 1
                    If item.Value(X) = Selected Then
                        FileName = item.Key
                        Index = If(X > 0, X - 1, 0)
                        RootType = item.Value(0)
                        Return True
                    End If
                Next
            Next
            RootType = Selected
            Return False
        End Function
        Public Function Retrieve_MapToType(Selected As COH_ProjectContent, ByRef FileName As String, ByRef Index As Integer, ByRef TheType As Type, Optional ByRef RootType As COH_ProjectContent = Nothing) As Boolean
            If Retrieve_FileName(Selected, FileName, Index, RootType) = False Then Return Nothing
            Dim Found As COH_FSI_Entry = Nothing
            If mStruct_Controller.Retrieve_SupportedType(FileName, Found) Then
                TheType = Found.Sections(Index).SectionType
                Return True
            End If
            Return False
        End Function
        Public Function Retrieve_MapToModType(Selected As COH_ProjectContent, ByRef TheType As Type) As Boolean
            Return mCahced_ModMapping.TryGetValue(Selected, TheType)
        End Function
#End Region

#Region "Retrieve Standard / Official Project File"
        Public Function Retrieve_CurrentPoject(Optional ShowMessage As Boolean = False) As COH_ProjectFile '//THIS WILL HAVE TO CHANGE TO STORE WHAT LAST PROJECT WAS SOMEWHERE, SETTINGS LIKELY
            If Not mCached_CurrentProjectFile Is Nothing Then Return mCached_CurrentProjectFile
            Dim Result As COH_ProjectFile = Nothing
            If IO.File.Exists(mSettings.CurrentProject_FilePath) = False Then
                Start_FreshProjectFile_Standard(False)
            Else
                If COH_ProjectFile.Import_XMLFile(mSettings.CurrentProject_FilePath, Result) = False Then
                End If
            End If
            mCached_CurrentProjectFile = Result
            If ShowMessage = True Then ShowMessage_Simple("Standard Project Retrieved")
            Return Result
        End Function
#End Region
    End Class
End Namespace