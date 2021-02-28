Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Storage.PiggyBin.Utilities
Imports COH.Toolkit.Enums
Imports COH.Tools.Utilities
Imports COH.Utilities

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Rebuild BINs"
        Public Function RebuildBins_All(Optional ShowMessage As Boolean = False) As Boolean
            Dim Result As Boolean = True
            If RebuildBin_AllMessages(False) = False Then Result = False
            If RebuildBin_AllCharacterOrigins(False) = False Then Result = False
            If RebuildBin_AllCharacterClasses(False) = False Then Result = False
            If RebuildBin_AllAttribs(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Rebuild All Failed **Need Log")
                Return False
            Else
                If ShowMessage = True Then ShowMessage_Simple("Rebuild All Bins Complete")
                Return True
            End If
        End Function
#End Region

#Region "Rebuild BINs - Message Stores"
        Public Function RebuildBin_AllMessages(ShowMessage As Boolean) As Boolean
            Dim Result As Boolean = True
            If RebuildBin_ClientMessages(False) = False Then Result = False
            If RebuildBin_ServerMessages(False) = False Then Result = False
            If ShowMessage = True Then
                If Result = True Then
                    ShowMessage_Simple("Rebuilt All Messages BINs")
                Else
                    ShowMessage_Simple("Failed to Rebuid All Messages BINs")
                End If
            End If
            Return Result
        End Function
        Public Function RebuildBin_ClientMessages(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN)
            If RebuildBin_MessageStore(MessageStore_Controller.MessageStores(0).Value, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Rebuilt Client Messages BIN")
            Return True
        End Function
        Public Function RebuildBin_ServerMessages(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN)
            If RebuildBin_MessageStore(MessageStore_Controller.MessageStores(1).Value, Destination) = False Then
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Rebuilt Server Messages BIN")
            Return True
        End Function
#End Region

#Region "Rebuild BINs - Multiple Builds"
        Public Function RebuildBin_AllCharacterClasses(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If RebuildBin_CharacterClasses(False) = False Then Result = False
            If RebuildBin_EnemyClasses(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Rebuild All Supported Character Classes BINs")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Rebuilt All Supported Character Classes BINs")
            End If
            Return Result
        End Function
        Public Function RebuildBin_AllCharacterOrigins(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If RebuildBin_Origins(False) = False Then Result = False
            If RebuildBin_EnemyOrigins(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Rebuild All Supported Origins BINs")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Rebuilt All Supported Origins BINs")
            End If
            Return Result
        End Function
        Public Function RebuildBin_AllAttribs(ShowMessage As Boolean)
            Dim Result As Boolean = True
            If RebuildBin_AttribNames(False) = False Then Result = False
            If RebuildBin_AttribDescriptions(False) = False Then Result = False
            If Result = False Then
                ShowMessage_SimpleError("Unable to Rebuild All Supported Attribs BINs")
            Else
                If ShowMessage = True Then ShowMessage_Simple("Rebuilt All Supported Attribs BINs")
            End If
            Return Result
        End Function
#End Region

#Region "Rebuild BINs - Single File"
        Public Function RebuildBin_Origins(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins)
            Return RebuildBin_CrypticS(Root, "Character Origins", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_EnemyOrigins(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.CharacterClasses_EnemyClass_Origins)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_EnemyClass_Origins)
            Return RebuildBin_CrypticS(Root, "Enemy Origins", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_CharacterClasses(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.CharacterClasses_PlayerClasses)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_PlayerClasses)
            Return RebuildBin_CrypticS(Root, "Character Classes", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_EnemyClasses(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.CharacterClasses_EnemyClass)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_EnemyClass)
            Return RebuildBin_CrypticS(Root, "Enemy Classes", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_AttribDescriptions(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.CharacterClasses_Attrib_Descriptions)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_Attribs)
            Return RebuildBin_CrypticS(Root, "Character Attrib Descriptions", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_AttribNames(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.CharacterClasses_Attrib_Names)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.CharacterClasses_Attribs)
            Return RebuildBin_CrypticS(Root, "Character Attrib Names", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_PowerCategories(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.PowerCategory)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.PowerCategory)
            Return RebuildBin_CrypticS(Root, "Character Power Categories", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_PowerSets(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.PowerSets)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.PowerSets)
            Return RebuildBin_CrypticS(Root, "Character Power Sets", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_Powers(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.Powers)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.Powers)
            Return RebuildBin_CrypticS(Root, "Character Powers", Destination, ShowMessage)
        End Function
        Public Function RebuildBin_ProductCatalog(ShowMessage As Boolean) As Boolean
            Dim Destination As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.BIN) & Retrieve_FileName(COH_ProjectContent.Store_ProductCatalog)
            Dim Root As String = ProgramFolders.LookupFolder_ProjectFile(COH_ProjectContent.Store_ProductCatalog)
            Return RebuildBin_CrypticS(Root, "Product Catalog", Destination, ShowMessage)
        End Function
#End Region

#Region "Handle Progress - Rebuild"
        Private Function RebuildBin_MessageStore(ByRef TheStore As COH_MessageStore, Destination As String) As Boolean
            Dim FilePath As String = Destination & TheStore.Name
            If IO.File.Exists(FilePath) = True Then IO.File.Delete(FilePath)
            Return COH_BinTool_MessageStore.Create_NewFile(TheStore.Name, FilePath, TheStore, True)
        End Function
        Private Function RebuildBin_CrypticS(Root As String, Title As String, Destination As String, Optional ShowMessage As Boolean = True) As Boolean
            Dim SourcePath As String = Root & "Index_" & IO.Path.GetFileName(Destination) & ".xml"
            Dim Source As COH_CrypticS = Nothing
            COH_CrypticS.Import_XMLFile(SourcePath, Source)
            Source.Files(0).Update_RelativePaths(Root)
            Source.Options.Option_BINs_UpdateTimeStamps = mSettings.Option_BINs_UpdateTimeStamps
            If IO.File.Exists(Destination) = True Then IO.File.Delete(Destination)
            mBinTool_CrypticS = New COH_BinTool_CrypticS(TheController_Localize, Structures_Controller)
            If mBinTool_CrypticS.Create_NewFile(Destination, Source, True) = False Then
                ShowMessage_SimpleError("Unable to Rebuild" & Title)
                Return False
            End If
            If ShowMessage = True Then ShowMessage_Simple("Rebuilt" & Title)
            Return True
        End Function
#End Region
    End Class
End Namespace