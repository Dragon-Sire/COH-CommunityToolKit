Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_ScriptDef
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return ScriptName
            End Get
        End Property
#End Region

#Region "Properties"
        Property CurrentFile As String
            Get
                Return mCurrentFile
            End Get
            Set(value As String)
                mCurrentFile = value
            End Set
        End Property
        Property ScriptName As String
            Get
                Return mScriptName
            End Get
            Set(value As String)
                mScriptName = value
            End Set
        End Property
        Property Vars As COH_STD
            Get
                Return mVars
            End Get
            Set(value As COH_STD)
                mVars = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mCurrentFile As String
       Private mScriptName As String
       Private mVars As COH_STD
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings As COH_Serialization_Settings = Nothing)
            MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mCurrentFile = String.Empty
            mScriptName = String.Empty
            mVars = New COH_STD
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ScriptDef
            Dim Result As COH_ScriptDef = New COH_ScriptDef
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mCurrentFile = String.Copy(mCurrentFile)
                .mScriptName = String.Copy(mScriptName)
                .mVars = mVars.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mCurrentFile)
            CurrentWriter.Write_CrypticS_String(mScriptName)
            '//SCRIPTVARS_STD_PARSE(ScriptDef)

            Throw New Exception("NEED TO WRITE VARS")

            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mCurrentFile = CurrentReader.Read_CrypticS_String
            mScriptName = CurrentReader.Read_CrypticS_String

            mVars = New COH_STD(CurrentReader)

            Return True
        End Function
#End Region

    End Class
End Namespace
