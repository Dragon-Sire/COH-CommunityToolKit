Imports COH.Storage.Serialization

Namespace Internal.Events
    Public Class COH_EventResponse_StreamInspect
        Inherits EventArgs

#Region "Properties"
        Public ReadOnly Property Title As String
            Get
                Return mPrompt
            End Get
        End Property
        Public ReadOnly Property StreamReader As COH_BinaryReader
            Get
                Return mCurrentReader
            End Get
        End Property
        Public ReadOnly Property StartPosition As Long
            Get
                Return mStart
            End Get
        End Property
#End Region

#Region "Private Usage"
       Private mPrompt As String
       Private mCurrentReader As COH_BinaryReader
       Private mStart As Long
#End Region

#Region "Initialize"
        Public Sub New()
            mPrompt = ""
        End Sub
        Public Sub New(Title As String, ByRef CurrentReader As COH_BinaryReader)
            mPrompt = Title
            mCurrentReader = CurrentReader
            mStart = mCurrentReader.Position
        End Sub
#End Region

#Region "Create Events"
        Public Shared Function CreateEvent(Title As String, ByRef CurrentReader As COH_BinaryReader) As COH_EventResponse_StreamInspect
            Return New COH_EventResponse_StreamInspect(Title, CurrentReader)
        End Function
#End Region
    End Class
End Namespace