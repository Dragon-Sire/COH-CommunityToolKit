Namespace GameContent.Structures.Story
    Public Class COH_ContactCategories
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayName As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
        Property Contacts As String()
            Get
                Return mContacts
            End Get
            Set(value As String())
                mContacts = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayNameKey As String
       Private mContacts As String()
#End Region

#Region "Create New Instances"
        Public Sub New()
            ResetDefaults()
        End Sub
        Public Sub New(Name As String)
            ResetDefaults()
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mName = String.Empty
            mDisplayNameKey = String.Empty
            mContacts = New String() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController as ISupport_COH_LocalizeContent)
            DisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_ContactCategories
            Dim Result As COH_ContactCategories = New COH_ContactCategories
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mDisplayNameKey = String.Copy(mDisplayNameKey)
                .mContacts = New String(mContacts.Count - 1) {}
                For X = 0 To mContacts.Count - 1
                    .mContacts(X) = String.Copy(mContacts(X))
                Next
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean

            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            DisplayNameKey = CurrentReader.Read_CrypticS_String
            Dim NumberContacts As Integer = CurrentReader.ReadInt32 '57
            Contacts = New String(NumberContacts - 1) {}
            For X = 0 To NumberContacts - 1
                Dim Size2 As Integer = CurrentReader.ReadInt32 '8
                Contacts(X) = CurrentReader.Read_CrypticS_String
            Next
            Return True
        End Function
#End Region
    End Class
End Namespace