Imports COH.Toolkit.Enums
Imports COH.Tools.Internal.Enums

Namespace Internal.ContentController.Settings
    Public NotInheritable Class COH_ProgramPathsManager

#Region "Properties"
        Public ReadOnly Property Root As String
            Get
                Return mRoot
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mRoot As String
        Private mFolders As Dictionary(Of COH_ProgramPaths, String)
        Private mRelativeFolders As Dictionary(Of COH_ProjectContent, String)
#End Region

#Region "Initialize"
        Public Sub New(Root As String)
            mRoot = CleanFilePath(Root)
            ResetDefaults()
        End Sub
        Public Sub ResetDefaults()
            ResetDefaults_Folders()
            ResetDefaults_RelativeFolders()
            EnsureFoldersExist()
            '//ResetDefaults_Files()
        End Sub
        Private Sub ResetDefaults_Folders()
            mFolders = New Dictionary(Of COH_ProgramPaths, String)
            Dim DataFolder = IO.Path.Combine(mRoot, "Data\")
            mFolders.Add(COH_ProgramPaths.Root, mRoot)
            mFolders.Add(COH_ProgramPaths.SystemFiles, IO.Path.Combine(mRoot, "System\"))
            mFolders.Add(COH_ProgramPaths.SystemFiles_DLL, IO.Path.Combine(mRoot, "System\"))
            mFolders.Add(COH_ProgramPaths.SystemFiles_Languages, (IO.Path.Combine(mRoot, "System\Localization\")))
            mFolders.Add(COH_ProgramPaths.SystemFiles_Logs, (IO.Path.Combine(mRoot, "System\Logs\")))
            mFolders.Add(COH_ProgramPaths.Resources, IO.Path.Combine(mRoot, "Resources\"))
            mFolders.Add(COH_ProgramPaths.Resources_Bones, IO.Path.Combine(mRoot, "Resources\Bones\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_Defs, IO.Path.Combine(mRoot, "Resources\Defs\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_PIGG_i24, IO.Path.Combine(mRoot, "Resources\_PIGG\i24\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_PIGG_i25_Score, IO.Path.Combine(mRoot, "Resources\_PIGG\i25_Score\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_Assets, IO.Path.Combine(mRoot, "Resources\Assets\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_Bins_i24, IO.Path.Combine(mRoot, "Resources\Assets\Bins\i24\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_Bins_i25_Score, IO.Path.Combine(mRoot, "Resources\Assets\Bins\i25_Score\"))
            mFolders.Add(COH_ProgramPaths.Resources_Import_Index, IO.Path.Combine(mRoot, "Resources\Index\"))
            mFolders.Add(COH_ProgramPaths.Resources_Settings, IO.Path.Combine(mRoot, "Resources\Settings\"))
            mFolders.Add(COH_ProgramPaths.Resources_Temporary, IO.Path.Combine(mRoot, "Resources\Temporary\"))
            mFolders.Add(COH_ProgramPaths.ProgramData, DataFolder)
            mFolders.Add(COH_ProgramPaths.Repo, IO.Path.Combine(mRoot, "Repo\"))
            mFolders.Add(COH_ProgramPaths.CurrentProject, IO.Path.Combine(DataFolder, "StandardPackage\"))
        End Sub
        Private Sub ResetDefaults_RelativeFolders()
            mRelativeFolders = New Dictionary(Of COH_ProjectContent, String)
            mRelativeFolders.Add(COH_ProjectContent.BIN, "BIN\")
            mRelativeFolders.Add(COH_ProjectContent.ASSETS, "Assets\")
            mRelativeFolders.Add(COH_ProjectContent.XML, "XML\")

            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses, "XML\CharacterClasses\")
            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_PlayerClasses_Origins, "XML\CharacterClasses\PlayerClasses\Origins\")
            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_PlayerClasses, "XML\CharacterClasses\PlayerClasses\")

            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_EnemyClass, "XML\CharacterClasses\EnemyClasses\")
            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_EnemyClass_Origins, "XML\CharacterClasses\EnemyClasses\Origins\")
            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_Attribs, "XML\CharacterClasses\Attribs")
            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_Attrib_Names, "XML\CharacterClasses\Attribs\Names\")
            mRelativeFolders.Add(COH_ProjectContent.CharacterClasses_Attrib_Descriptions, "XML\CharacterClasses\Attribs\Descriptions\")

            mRelativeFolders.Add(COH_ProjectContent.LanguageFiles, "XML\LanguageFiles\")
            mRelativeFolders.Add(COH_ProjectContent.PowerCategory, "XML\PowerCategory\")
            mRelativeFolders.Add(COH_ProjectContent.PowerSets, "XML\PowerSets\")
            mRelativeFolders.Add(COH_ProjectContent.Powers, "XML\Powers\")
            mRelativeFolders.Add(COH_ProjectContent.Store, "XML\Store\")
            mRelativeFolders.Add(COH_ProjectContent.Store_ProductCatalog, "XML\Store\ProductCatalog\")
            mRelativeFolders.Add(COH_ProjectContent.Contacts, "XML\Story\Contacts\")
            mRelativeFolders.Add(COH_ProjectContent.Contacts_List, "XML\Story\ContactsList\")
            mRelativeFolders.Add(COH_ProjectContent.Contacts_NPC, "XML\Story\NPC\")
            mRelativeFolders.Add(COH_ProjectContent.Entities, "XML\3DModels\Entities\")
            mRelativeFolders.Add(COH_ProjectContent.AnimationSequences, "XML\3DModels\AnimationSequences\")
            mRelativeFolders.Add(COH_ProjectContent.Tricks_AND_TextureOptions, "XML\3DModels\Tricks\")
            mRelativeFolders.Add(COH_ProjectContent.TextureOptions, "XML\3DModels\Tricks\TextureOptions\")
            mRelativeFolders.Add(COH_ProjectContent.Tricks, "XML\3DModels\Tricks\TheTricks\")
        End Sub
        Private Sub EnsureFoldersExist()
            Try
                For Each Path In mFolders
                    If IO.Directory.Exists(Path.Value) = False Then IO.Directory.CreateDirectory(Path.Value)
                Next
            Catch ex As Exception
            End Try
        End Sub
        Public Sub EnsureAllProjectFoldersExist(RootPath As String)
            Try
                For Each Path In mRelativeFolders
                    If IO.Directory.Exists(RootPath & Path.Value) = False Then IO.Directory.CreateDirectory(RootPath & Path.Value)
                Next
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Lookup FolderPaths - System/Standard"
        Public Function LookupFolder(Resource As COH_ProgramPaths) As String
            Dim Result As String = ""
            If LookupFolder_Verify(Resource, Result) = False Then
                'RecordManager.Instance.ThrowError(New Logging.BTC_EventResponse(BTC_ResponseCodeSeverity.ErrorOccured, BTC_ResponseCodes.FolderNotFound, ""))
                Return Nothing
            Else
                Return Result
            End If
        End Function
        Private Function LookupFolder_Verify(Resource As COH_ProgramPaths, ByRef Path As String) As Boolean
            If Resource = COH_ProgramPaths.CurrentProject Then Return COH_ContentController.Instance.Cached_CurrentProject_PathRoot
            Path = mFolders.Item(Resource)
            If String.IsNullOrEmpty(Path) = True Then
                Path = ""
                Return False
            Else
                Return IO.Directory.Exists(Path)
            End If
        End Function
#End Region

#Region "Lookup ProjectFolder - Relative"
        Public Function LookupFolder_ProjectFile(Resource As COH_ProjectContent) As String
            Dim TheRoot As String = COH_ContentController.Instance.Cached_CurrentProject_PathRoot
            Dim Result As String = ""
            If LookupFolder_ProjectFile_Verify(Resource, TheRoot, Result) = False Then
                Return Nothing
            Else
                Return Result
            End If
        End Function
        Private Function LookupFolder_ProjectFile_Verify(Resource As COH_ProjectContent, UserProjectFolder As String, ByRef Path As String) As Boolean
            Path = mRelativeFolders.Item(Resource)
            If String.IsNullOrEmpty(Path) = True Then
                Path = ""
                Return False
            Else
                Path = UserProjectFolder & Path
                Return IO.Directory.Exists(Path)
            End If
        End Function
#End Region

#Region "Additional Functions"
        Public Sub UpdateEnviromentPath_MSBUILD()
            Dim readValue = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0", "MSBuildToolsPath", Nothing)
            Dim PathtoMSBUILD As String = readValue ' & "MSBuild.exe"
            Dim FindPath As String = System.Environment.GetEnvironmentVariable("path", EnvironmentVariableTarget.User)
            If FindPath.Contains("MSBuild") = False Then
                System.Environment.SetEnvironmentVariable("path", FindPath & ";" & PathtoMSBUILD, EnvironmentVariableTarget.User)
                COH_ContentController.Instance.ShowMessage_Simple("Path Updated to : " & Environment.NewLine & PathtoMSBUILD)
            Else
                COH_ContentController.Instance.ShowMessage_SimpleError("Path Already Contains MSBuild")
            End If
        End Sub
        Public Sub Download_Ouroboros_Repo()
            Dim Folder As String = COH_ContentController.Instance.Settings.Ouroboros_RepoPathRoot '/"/e/City of Heroes Tools/Tools/Repo/"
            If Folder Is Nothing Then
                Folder = COH_ContentController.Instance.ProgramFolders.LookupFolder(COH_ProgramPaths.Repo)
                COH_ContentController.Instance.Settings.Ouroboros_RepoPathRoot = Folder
                COH_ContentController.Instance.Settings.Save()
            End If
            'Folder = Chr(34) & "/" & Folder.Substring(0, 1).ToLower & "/" & Folder.Substring(3) & Chr(34)

            Folder = Chr(34) & Replace(Folder, "\", "/") & Chr(34)
            Dim CommandLine As String = "clone --recursive https://git.ourodev.com/CoX/Source.git " & Folder

            Dim p As Process = New Process()
            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = "git"
            psi.Arguments = CommandLine
            p.StartInfo = psi
            p.Start()
            p.WaitForExit()

        End Sub
        Public Sub Rebuild_Ouroboros_RepoPathRoot()
            Dim Folder As String = COH_ContentController.Instance.Settings.Ouroboros_RepoPathRoot & "MasterSolution\"
            Dim BuildFile As String = COH_ContentController.Instance.Settings.Ouroboros_RepoPathRoot & "MasterSolution\Build.PS1"
            If IO.File.Exists(BuildFile) = False Then
                COH_ContentController.Instance.ShowMessage_SimpleError("REPO Not Found at Expected Location, Check Settings")
            Else
                Dim SB As New System.Text.StringBuilder
                SB.AppendLine("@Echo OFF")
                SB.AppendLine("cd " & Folder)
                SB.AppendLine("powershell -Command ""Start-Process powershell \""-ExecutionPolicy Bypass -NoProfile -NoExit -Command `\""cd \`\""" & Folder & "`\""; & \`\"".\Build.ps1\`\""`\""\"" -Verb RunAs""")
                SB.AppendLine("pause")

                Dim file As System.IO.StreamWriter
                If IO.File.Exists(Folder & "Run.bat") = False Then
                    'file = OpenTextFileWriter(Folder & "Run.bat", True)
                    'file.WriteLine(SB.ToString)
                    'file.Close()
                End If

                Dim p As Process = New Process()
                Dim psi As ProcessStartInfo = New ProcessStartInfo()
                psi.WorkingDirectory = Folder
                psi.FileName = "Run.bat"
                psi.Arguments = ""
                p.StartInfo = psi
                'p.StartInfo.Verb = "runas"
                p.Start()
                p.WaitForExit()
            End If

        End Sub 'git clone --recursive https://git.ourodev.com/CoX/Source.git



#End Region

#Region "Public Shared Functions"
        Public Shared Function CleanFilePath(Value As String) As String
            Value = Value.Trim
            If Not Value.Substring(Value.Length - 1, 1) = "\" Then Return (Value & "\") 'Value.Substring(0, Value.Length - 1)
            Return Value
        End Function
#End Region

    End Class
End Namespace