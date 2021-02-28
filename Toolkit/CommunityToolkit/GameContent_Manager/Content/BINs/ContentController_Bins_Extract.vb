Imports COH.GameContent.Internal.Events
Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Storage.Serialization.Configuration.COH_Serialization_Settings
Imports COH.Tools.Internal.Enums
Imports COH.Toolkit.Enums
Imports COH.Utilities

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Private Properties"
        Private WithEvents mEventController As COH_LibraryEventControl
        Private mBinTool_CrypticS As COH_BinTool_CrypticS
        Private mBinTool_MessageStore As COH_BinTool_MessageStore
#End Region

#Region "Extract - Contents for Modding (Specified Bins)"
        Public Function ExtractBin_CharacterClasses(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.CharacterClasses_PlayerClasses)
        End Function
        Public Function ExtractBin_EnemyClasses(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.CharacterClasses_EnemyClass)
        End Function
        Public Function ExtractBin_Origins(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.CharacterClasses_PlayerClasses_Origins)
        End Function
        Public Function ExtractBin_Origins_Enemy(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.CharacterClasses_EnemyClass_Origins)
        End Function
        Public Function ExtractBin_Powers(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.Powers)
        End Function
        Public Function ExtractBin_PowerCategories(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.PowerCategory)
        End Function
        Public Function ExtractBin_PowerSets(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.PowerSets)
        End Function
        Public Function ExtractBin_AttribNames(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.CharacterClasses_Attrib_Names)
        End Function
        Public Function ExtractBin_AttribDescriptions(ShowMessage As Boolean) As Boolean
            Return ExtractBin(ShowMessage, COH_ProjectContent.CharacterClasses_Attrib_Descriptions)
        End Function
#End Region

#Region "Extract BINs - CrypticS (MultipleRoot)"
        Public Function ExtractBin_TricksANDTextureOptions(ShowMessage As Boolean) As Boolean
            Dim Destination As COH_ProjectContent() = New COH_ProjectContent(1) {COH_ProjectContent.TextureOptions, COH_ProjectContent.Tricks}
            Return ExtractBin(ShowMessage, COH_ProjectContent.Tricks_AND_TextureOptions, Destination)
        End Function
#End Region

#Region "Extract Grouped"
        Public Function ExtractBins_All(Optional ShowMessage As Boolean = False, Optional ExtractMessageStores As Boolean = True, Optional ExtractContent As Boolean = True) As Boolean
            Dim Result As Boolean = True
            If ExtractMessageStores = True Then
                SplashScreen_Update("Extracting Language Maps", 5, False)
                If ExtractBin_AllMessagesStores(False) = False Then Result = False
                If Prepare_MessageStoreController() = False Then Result = False
            End If
            If ExtractContent = True Then
                SplashScreen_Update("Extracting Origins", 5, False)
                If ExtractBin_AllOrigins(False) = False Then Result = False
                SplashScreen_Update("Extracting Attributes", 5, False)
                If ExtractBin_AllAttribs(False) = False Then Result = False
                SplashScreen_Update("Extracting Powers", 20, False)
                If ExtractBin_Powers(False) = False Then Result = False
                SplashScreen_Update("Extracting Power Categories", 5, False)
                If ExtractBin_PowerCategories(False) = False Then Result = False
                SplashScreen_Update("Extracting PowerSets", 5, False)
                If ExtractBin_PowerSets(False) = False Then Result = False
                SplashScreen_Update("Extracting Character Classes", 5, False)
                If ExtractBin_AllCharacterClasses(False) = False Then Result = False
                SplashScreen_Update("Extracting Tricks & Texture Options", 5, False)
                ' If ExtractBin_TricksANDTextureOptions(False) = False Then Result = False
            End If
            If Result = False Then
                ShowMessage_SimpleError("Extract All Failed **Need Log")
                Return False
            Else
                If ShowMessage = True Then ShowMessage_Simple("Extract All Bins Complete")
                Return True
            End If
        End Function
        Public Function ExtractBin_AllCharacterClasses(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If ExtractBin_CharacterClasses(False) = False Then Result = False
            If ExtractBin_EnemyClasses(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Extract All Supported Character Classes BINs")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Extracted All Supported Character Classes BINs")
            End If
            Return Result
        End Function
        Public Function ExtractBin_AllOrigins(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If ExtractBin_Origins(False) = False Then Result = False
            If ExtractBin_Origins_Enemy(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Extract All Supported Origin BINs")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Extracted All Supported Origin BINs")
            End If
            Return Result
        End Function
        Public Function ExtractBin_AllAttribs(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If ExtractBin_AttribNames(False) = False Then Result = False
            If ExtractBin_AttribDescriptions(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Extract All Supported Attribute BINs")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Extracted All Supported Attribute BINs")
            End If
            Return Result
        End Function
#End Region

#Region "Extract - Contents"
        Private Function ExtractBin_CrypticS(FileSource As String, ByRef Result As COH_FileStructure(), ByRef Info As COH_CrypticS) As Boolean
            If IO.File.Exists(FileSource) = False Then
                If LocateFile(IO.Path.GetFileName(FileSource), FileSource) = False Then
                    ShowMessage_SimpleError("File Not Found : " & IO.Path.GetFileName(FileSource))
                    Return False
                End If
            End If
            mBinTool_CrypticS = New COH_BinTool_CrypticS(TheController_Localize, Structures_Controller)
            mBinTool_CrypticS.OpenExisting_BinFile(FileSource, New COH_CrypticS_Settings(mSettings.Option_BINs_UpdateTimeStamps, False), True)
            Dim ExtractResult As Boolean = mBinTool_CrypticS.ExtractFromBin_Items(FileSource, Result, 0, True)
            Info = mBinTool_CrypticS.Content
            mBinTool_CrypticS.Dispose()
            mBinTool_CrypticS = Nothing
            Return ExtractResult
        End Function
        Private Function ExtractBin_CrypticS(FileSource As String, ByRef Result As COH_FileStructure()(), ByRef Info As COH_CrypticS) As Boolean
            If IO.File.Exists(FileSource) = False Then
                If LocateFile(IO.Path.GetFileName(FileSource), FileSource) = False Then
                    ShowMessage_SimpleError("File Not Found : " & IO.Path.GetFileName(FileSource))
                    Return False
                End If
            End If
            mBinTool_CrypticS = New COH_BinTool_CrypticS(TheController_Localize, Structures_Controller)
            mBinTool_CrypticS.OpenExisting_BinFile(FileSource, New COH_CrypticS_Settings(mSettings.Option_BINs_UpdateTimeStamps, False), True)
            Dim ExtractResult As Boolean = mBinTool_CrypticS.ExtractFromBin_Items(FileSource, Result, True)
            Info = mBinTool_CrypticS.Content
            mBinTool_CrypticS.Dispose()
            mBinTool_CrypticS = Nothing
            Return ExtractResult
        End Function
#End Region

#Region "Extract - Contents for Modding"
        Public Function ExtractBin(ShowMessage As Boolean, SelectedType As COH_ProjectContent) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(SelectedType)
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(SelectedType)
            Dim Results As COH_FileStructure() = Nothing
            Dim Info As COH_CrypticS = Nothing
            If ExtractBin_CrypticS(FileSource, Results, Info) = False Then Return False

            Dim ModType As Type = Nothing
            Retrieve_MapToModType(SelectedType, ModType)

            If WriteModdingFile(FileSource, Destination, Info, Results, ModType) = False Then Return False
            If ShowMessage = True Then ShowMessage_Simple("Extract " & SelectedType.ToString & " Complete")
            Return True
        End Function
        Public Function ExtractBin(ShowMessage As Boolean, SelectedType As COH_ProjectContent, SubTypes As COH_ProjectContent()) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(SelectedType)
            Dim Results As COH_FileStructure()() = Nothing
            Dim Info As COH_CrypticS = Nothing
            If ExtractBin_CrypticS(FileSource, Results, Info) = False Then Return False
            Dim ModType As Type = Nothing
            Dim WriteIndex As Boolean = True
            Dim Destination As String = ""
            For X = 0 To SubTypes.Count - 1
                Retrieve_MapToModType(SubTypes(X), ModType)
                Destination = ProgramFolders.LookupFolder_ProjectFile(SubTypes(X))
                If WriteModdingFile(FileSource, Destination, Info, Results(X), ModType, WriteIndex) = False Then Return False
                WriteIndex = False
            Next
            If ShowMessage = True Then ShowMessage_Simple("Extract " & SelectedType.ToString & " Complete")
            Return True
        End Function
        Private Function WriteModdingFile(FileSource As String, Destination As String, ByRef Info As COH_CrypticS, ByRef Structs As COH_FileStructure(), TheType As Type, Optional WriteIndex As Boolean = True) As Boolean
            ProgressDisplay_Create("Writing Modable Content", 0, Structs.Count, 0)
            For X = 0 To Structs.Count - 1
                Dim NFO As New COH_ModableContent
                NFO.Content = Structs(X)
                NFO.RelativePath_Current = Info.Files(0).Details(X).XML_RelativePath
                NFO.RelativePath_Originol = Structs(0).Retrieve_OriginolSourceReference
                Dim XMLPath As String = Destination & NFO.RelativePath_Current
                Me.ProgressDisplay_Update(IO.Path.GetFileName(XMLPath), 1)
                Structs(X).Export_To_File(IO.Path.GetFileName(XMLPath), IO.Path.GetDirectoryName(XMLPath), COH_ExportFormat.XML)
                '//COH.Tools.Modding.COH_ModableContent.Export_ToXMLFile(XMLPath.Replace(".XML", ".PF"), NewItem)
            Next
            ProgressDisplay_Destroy()
            If WriteIndex = True Then
                Dim MasterListPath As String = Destination & "Index_" & Info.Name & ".XML"
                Return COH.Helperfunctions.XML.Export_XMLFile(MasterListPath, Info)
            Else
                Return True
            End If
        End Function
#End Region








#Region "Extract BINs - Multiple - Same Types"
        Public Function ExtractBin_AllMessagesStores(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If ExtractBin_ClientMessages(False) = False Then Result = False
            If ExtractBin_ServerMessages(False) = False Then Result = False
            If ExtractBin_StoryArcMessages(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Extract All Supported Message Stores")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Extracted All Supported Message Stores")
            End If
            Return Result
        End Function
#End Region

#Region "Extract BINs - Message Stores"
        Public Function ExtractBin_ClientMessages(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "\bin\clientmessages-en.bin"
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.LanguageFiles)
            If ExtractBin_MessageStore(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted Client Messages BIN")
            Return True
        End Function
        Public Function ExtractBin_ServerMessages(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "\bin\messages-en.bin"
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.LanguageFiles)
            If ExtractBin_MessageStore(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted Server Messages BIN")
            Return True
        End Function
        Public Function ExtractBin_StoryArcMessages(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "\bin\storyarcmsg-en.bin"
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.LanguageFiles)
            If ExtractBin_MessageStore(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted Story-Arc Messages BIN")
            Return True
        End Function
#End Region

#Region "Extract & Compare BINs - Message Stores"
        Public Function Extract_CompareBin_ClientMessages(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Temporary) & "clientmessages-en.bin"
            Dim Destination As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Temporary)
            If IO.File.Exists(FileSource) = True Then IO.File.Delete(FileSource)
            If ExtractBin_MessageStore(FileSource, Destination) = False Then
                Return False
            End If
            Dim NewStore As COH_MessageStore = Nothing
            If COH_MessageStore.Import_XMLFile(FileSource & ".xml", NewStore) = False Then Return False
            MessageStore_Controller.MessageStores(0).Value.Import_and_Compare(NewStore)
            If ShowMessage = True Then ShowMessage_Simple("Import Complete")
            Return True
        End Function
        Public Function Extract_CompareBin_ServerMessages(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Temporary) & "messages-en.bin"
            Dim Destination As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Temporary)
            If IO.File.Exists(FileSource) = True Then IO.File.Delete(FileSource)
            If ExtractBin_MessageStore(FileSource, Destination) = False Then
                Return False
            End If
            Dim NewStore As COH_MessageStore = Nothing
            If COH_MessageStore.Import_XMLFile(FileSource & ".xml", NewStore) = False Then Return False
            MessageStore_Controller.MessageStores(1).Value.Import_and_Compare(NewStore)
            If ShowMessage = True Then ShowMessage_Simple("Import Complete")
            Return True
        End Function
        Public Function Extract_CompareBin_StoryArcMessages(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Temporary) & "storyarcmsg-en.bin"
            Dim Destination As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Temporary)
            If IO.File.Exists(FileSource) = True Then IO.File.Delete(FileSource)
            If ExtractBin_MessageStore(FileSource, Destination) = False Then
                Return False
            End If
            Dim NewStore As COH_MessageStore = Nothing
            If COH_MessageStore.Import_XMLFile(FileSource & ".xml", NewStore) = False Then Return False
            MessageStore_Controller.MessageStores(1).Value.Import_and_Compare(NewStore)
            If ShowMessage = True Then ShowMessage_Simple("Import Complete")
            Return True
        End Function
#End Region

#Region "Extract BINs - CrypticS"
        Public Function ExtractBin_ProductCatalog(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(COH_ProjectContent.Store_ProductCatalog)
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.Store_ProductCatalog)
            If ExtractBin_CrypticS(FileSource, Destination, COH_CombineStructs_Option.AllCombined) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted ProductCatalog BIN")
            Return True
        End Function
        Public Function ExtractBin_ContactList(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(COH_ProjectContent.Contacts_List)
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.Contacts_List)
            If ExtractBin_CrypticS(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted Contact List BIN")
            Return True
        End Function
        Public Function ExtractBin_NPC(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(COH_ProjectContent.Contacts_NPC)
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.Contacts_NPC)
            If ExtractBin_CrypticS(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted NPC (Client) BIN")
            Return True
        End Function
        Public Function ExtractBin_Entities(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(COH_ProjectContent.Entities)
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.Entities)
            If ExtractBin_CrypticS(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted Entities BIN")
            Return True
        End Function
        Public Function ExtractBin_AnimationSeq(ShowMessage As Boolean) As Boolean
            Dim FileSource As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Bins_i24) & "bin\" & Retrieve_FileName(COH_ProjectContent.AnimationSequences)
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.AnimationSequences)
            If ExtractBin_CrypticS(FileSource, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Extracted Animation Sequences BIN")
            Return True
        End Function
#End Region

#Region "Handle Progress - Extraction"
        Private Function ExtractBin_CrypticS(FileSource As String, Destination As String, Optional OptionCombine As COH_CombineStructs_Option = COH_CombineStructs_Option.SeperateFiles) As Boolean
            Dim MasterListPath As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Index) & IO.Path.GetFileNameWithoutExtension(FileSource) & "_Index.xml"
            If IO.File.Exists(FileSource) = False Then
                If LocateFile(IO.Path.GetFileName(FileSource), FileSource) = False Then
                    ShowMessage_SimpleError("File Not Found : " & IO.Path.GetFileName(FileSource))
                    Return False
                End If
            End If
            mBinTool_CrypticS = New COH_BinTool_CrypticS(TheController_Localize, Structures_Controller)
            mBinTool_CrypticS.OpenExisting_BinFile(FileSource, New COH_CrypticS_Settings(mSettings.Option_BINs_UpdateTimeStamps, OptionCombine), True)
            Dim Result As Boolean = mBinTool_CrypticS.ExtractFromBin_WriteXML(FileSource, Destination, 0, True)
            mBinTool_CrypticS.Dispose()
            mBinTool_CrypticS = Nothing
            Return Result
        End Function
        Private Function ExtractBin_CrypticS(FileSource As String, RootFolder As String, Destination As String()) As Boolean
            Dim MasterListPath As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Index) & IO.Path.GetFileNameWithoutExtension(FileSource) & "_Index.xml"
            If IO.File.Exists(FileSource) = False Then
                If LocateFile(IO.Path.GetFileName(FileSource), FileSource) = False Then
                    ShowMessage_SimpleError("File Not Found : " & IO.Path.GetFileName(FileSource))
                    Return False
                End If
            End If
            mBinTool_CrypticS = New COH_BinTool_CrypticS(TheController_Localize, Structures_Controller)
            mBinTool_CrypticS.OpenExisting_BinFile(FileSource, New COH_CrypticS_Settings(mSettings.Option_BINs_UpdateTimeStamps, COH_CombineStructs_Option.SeperateFiles), True)
            Dim Result As Boolean = mBinTool_CrypticS.ExtractFromBin_WriteXML(FileSource, RootFolder, Destination, True)
            mBinTool_CrypticS.Dispose()
            mBinTool_CrypticS = Nothing
            Return Result
        End Function
        Private Function ExtractBin_MessageStore(FileSource As String, Destination As String) As Boolean
            Dim MasterListPath As String = ProgramFolders.LookupFolder(COH_ProgramPaths.Resources_Import_Index) & IO.Path.GetFileNameWithoutExtension(FileSource) & "_Index.xml"
            If IO.File.Exists(FileSource) = False Then
                If LocateFile(IO.Path.GetFileName(FileSource), FileSource) = False Then
                    ShowMessage_SimpleError("File Not Found : " & IO.Path.GetFileName(FileSource))
                    Return False
                End If
            End If
            mBinTool_MessageStore = New COH_BinTool_MessageStore(FileSource, True)
            Dim Result As Boolean = mBinTool_MessageStore.ExtractFromBin_WriteXML(Destination)
            mBinTool_MessageStore.Dispose()
            mBinTool_MessageStore = Nothing
            Return Result
        End Function
#End Region

#Region "Private Functions"
        Private Sub Delete_AllFiles_InDirectory(Folder As String, Optional ShowMessage As Boolean = True, Optional Search As IO.SearchOption = IO.SearchOption.TopDirectoryOnly)
            If IO.Directory.Exists(Folder) = False Then Exit Sub
            For Each File In IO.Directory.GetFiles(Folder, "*.xml", IO.SearchOption.AllDirectories)
                Try
                    IO.File.Delete(File)
                Catch ex As Exception
                    If ShowMessage = True Then ShowMessage_SimpleError(ex.ToString)
                End Try
            Next
        End Sub
#End Region
    End Class
End Namespace