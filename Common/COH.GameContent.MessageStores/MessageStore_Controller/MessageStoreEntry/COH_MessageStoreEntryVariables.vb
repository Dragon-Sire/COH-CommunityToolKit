Imports System.Xml.Serialization

Namespace GameContent.MessageStores.Structures.LanguageFiles
    Public Class COH_MessageStore_EntryVariable

#Region "Properties"
        Property Index As Integer
            Get
                Return mIndex
            End Get
            Set(value As Integer)
                mIndex = value
            End Set
        End Property
#End Region

#Region "Properties - Reference Map"
        <XmlIgnore> Property Variable As String
            Get
                Return mVariable
            End Get
            Set(value As String)
                mVariable = value
            End Set
        End Property
        <XmlIgnore> Property Format As String
            Get
                Return mFormat
            End Get
            Set(value As String)
                mFormat = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        <EditorBrowsable(Global.COH.GameContent.Internal.DeveloperOptions.COH_DeveloperMode_ShowPrivate)> Private mIndex As Integer
        Private mVariable As String
        Private mFormat As String
#End Region

#Region "Properties"
        Public Sub New()
            mIndex = -1
            mVariable = String.Empty
            mFormat = String.Empty
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_MessageStore_EntryVariable
            Dim Result As New COH_MessageStore_EntryVariable
            With Result
                .mIndex = mIndex
                .mVariable = String.Copy(mVariable)
                .mFormat = String.Copy(mFormat)
                Return Result
            End With
        End Function
#End Region

    End Class
End Namespace