Imports System.ComponentModel

Namespace Internal.Events
    Public Class COH_EventResponse_Compare2Items
        Inherits EventArgs

#Region "Enums"
        Public Enum COH_ResponseEnum
            Yes = 0
            No = 1
            Other = 2
        End Enum
#End Region

#Region "Properties"
        Public ReadOnly Property Prompt As String
            Get
                Return mPrompt
            End Get
        End Property
        Public ReadOnly Property Message1 As String
            Get
                Return mMessage1
            End Get
        End Property
        Public ReadOnly Property Message2 As String
            Get
                Return mMessage2
            End Get
        End Property
        Public Property Result As COH_ResponseEnum
            Get
                Return mResult
            End Get
            Set(value As COH_ResponseEnum)
                mResult = value
            End Set
        End Property
#End Region

#Region "Private Usage"
       Private mResult As COH_ResponseEnum
       Private mPrompt As String
       Private mMessage1 As String
       Private mMessage2 As String
#End Region

#Region "Initialize"
        Public Sub New()
            mPrompt = ""
            mMessage1 = ""
            mMessage2 = ""
        End Sub
        Public Sub New(Title As String, Message1 As String, Message2 As String, Optional DefaultResponse As COH_ResponseEnum = COH_ResponseEnum.Yes)
            mPrompt = Title
            mMessage1 = Message1
            mMessage2 = Message2
            mResult = DefaultResponse
        End Sub
#End Region

#Region "Create Events"
        Public Shared Function CreateEvent(Title As String, Message1 As String, Message2 As String, Optional DefaultResponse As COH_ResponseEnum = COH_ResponseEnum.Yes) As COH_EventResponse_Compare2Items
            Return New COH_EventResponse_Compare2Items(Title, Message1, Message2, DefaultResponse)
        End Function
#End Region
    End Class
End Namespace