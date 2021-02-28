Namespace GameContent.Structures.Story
    Public NotInheritable Class COH_StoryEpisode
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Episode"
            End Get
        End Property
#End Region

#Region "Properties"
        Property TaskDef As COH_StoryTask()
            Get
                Return mTaskDef
            End Get
            Set(value As COH_StoryTask())
                mTaskDef = value
            End Set
        End Property
        Property ReturnSuccess As COH_StoryReward()
            Get
                Return mReturnSuccess
            End Get
            Set(value As COH_StoryReward())
                mReturnSuccess = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mTaskDef As COH_StoryTask()
       Private mReturnSuccess As COH_StoryReward()
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
            mTaskDef = New COH_StoryTask() {}
            mReturnSuccess = New COH_StoryReward() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_StoryEpisode
            Dim Result As COH_StoryEpisode = New COH_StoryEpisode
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTaskDef = New COH_StoryTask(mTaskDef.Count - 1) {}
                For X = 0 To mTaskDef.Count - 1
                    .mTaskDef(X) = mTaskDef(X).Clone
                Next
                .mReturnSuccess = New COH_StoryReward(mReturnSuccess.Count - 1) {}
                For X = 0 To mReturnSuccess.Count - 1
                    .mReturnSuccess(X) = mReturnSuccess(X).Clone
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            If CurrentWriter.Write_CrypticS_StructArray(mTaskDef) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mReturnSuccess) = False Then Return False
            '!!REDUNDENT!! If CurrentWriter.Write_CrypticS_StructArray(mSuccess) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryTask), mTaskDef) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_StoryReward), mReturnSuccess) = False Then Return False
            '!!REDUNDENT!!If CurrentReader.Read_CrypticS_StructArray(GetType('!!REDUNDANTNAME!! - COH_None), mSuccess) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
