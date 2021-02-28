Imports COH.Tools.Internal.ContentController

Public Module Startup

#Region "Properties"
    Public sApplication As COH_Tools_Application
    Public sMainForm As Form
#End Region

#Region "Initialize"
    Sub Main(Arguments As String())
        Process_Arguments(Arguments)
        sApplication = New COH_Tools_Application()
        sApplication.Run(New String() {})
    End Sub
    Public Sub Initialize_Program()
        Configure_DLL_PathsHandler()
        Initialize_Controller()
    End Sub
    Public Sub Initialize_Controller()
        sMainForm = New COH_Tools
        Configure_RecordManager(sMainForm)
        Configure_Interface(sMainForm)
    End Sub
#End Region

#Region "Configuration"
    Private Sub Process_Arguments(ByRef Arguments As String())
        If Arguments.Length >= 1 Then
            For Each Arg In Arguments
            Next
        End If
    End Sub
    Private Function Configure_Interface(ByRef MainForm As Form) As Boolean
        MainForm.WindowState = Windows.Forms.FormWindowState.Maximized
        Return True
    End Function
    Private Function Configure_DLL_PathsHandler() As Boolean
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf Resolve_DLL_PathsHandler
        Return True
    End Function
    Private Function Configure_RecordManager(ByRef sMainForm As Form) As Boolean
        Dim CurrentController As New COH_ContentController(sMainForm, ConfigurePath)
        Return (Not COH_ContentController.Instance Is Nothing)
    End Function
    Private Function ConfigurePath() As String
        Dim DriveLetter As String = IO.Path.GetPathRoot(GetApplicationRoot)
        Dim ProgramDataPath As String = DriveLetter & "City of Heroes Tools\Tools\"
        If IO.Directory.Exists(ProgramDataPath) = False Then ProgramDataPath = DriveLetter & "Tools\"
        If IO.Directory.Exists(ProgramDataPath) = False Then ProgramDataPath = GetApplicationRoot()
        If IO.Directory.Exists(ProgramDataPath) = False Then
            MsgBox("Record System Cannot Be Found!", MsgBoxStyle.Critical, "COH Tools")
            End
        End If
        Return ProgramDataPath
    End Function
#End Region

#Region "Files & Resources"
    Private Function Resolve_DLL_PathsHandler(ByVal sender As Object, ByVal args As ResolveEventArgs) As Reflection.[Assembly]
        If LCase(args.Name).Contains(".resources") And Not LCase(args.Name).Contains("coh.gamecontent.resources") Then
            Return Nothing
        ElseIf LCase(args.Name).Contains(".xmlserializers") Then
            Return Nothing
        End If
        Dim ProgramAssemblies As Reflection.[Assembly] = Reflection.[Assembly].GetExecutingAssembly()
        Dim Referenced_Assemblies() As Reflection.AssemblyName = ProgramAssemblies.GetReferencedAssemblies()
        Dim Search_Argument As String = args.Name.Substring(0, args.Name.IndexOf(","))
        For Each AssemblyName As Reflection.AssemblyName In Referenced_Assemblies
            Dim Compare_Assembly As String = args.Name.Substring(0, args.Name.IndexOf(","))
            If Compare_Assembly = Search_Argument Then
                Dim Assembly_FilePath As String = GetApplicationRoot() & "\System\" & args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll"
                If IO.File.Exists(Assembly_FilePath) = True Then
                    Dim MyAssembly As Reflection.[Assembly]
                    MyAssembly = Reflection.[Assembly].LoadFrom(Assembly_FilePath)
                    Return MyAssembly
                Else
                    MsgBox("Assebly Missing!" & Environment.NewLine & Assembly_FilePath, MsgBoxStyle.Critical, "COH Tools")
                    End
                End If
            End If
        Next
        Return Nothing
    End Function
    Private Function GetApplicationRoot() As String
        Dim Result As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim ResultType As String = Result.Substring(0, 6)
        If ResultType = "file:\" = True Then
            Return Result.Substring(6)
        Else
            Return ""
        End If
    End Function
#End Region
End Module
