Namespace GameContent.Structures.[Shared]
    Public Class COH_AttributeDescription
        inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return mName
            End Get
        End Property
#End Region

#Region "Properties"
        Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
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
        Property Tooltip As String
            Get
                Return mTooltip
            End Get
            Set(value As String)
                mTooltip = value
            End Set
        End Property
        Property TooltipKey As String
            Get
                Return mTooltipKey
            End Get
            Set(value As String)
                mTooltipKey = value
            End Set
        End Property
        Property Type As COH_Enum_AttribType
            Get
                Return mType
            End Get
            Set(value As COH_Enum_AttribType)
                mType = value
            End Set
        End Property
        Property Style As COH_Enum_AttribStyle
            Get
                Return mStyle
            End Get
            Set(value As COH_Enum_AttribStyle)
                mStyle = value
            End Set
        End Property
        Property Key As Int32
            Get
                Return mKey
            End Get
            Set(value As Int32)
                mKey = value
            End Set
        End Property
        Property Offset As Int32
            Get
                Return mOffset
            End Get
            Set(value As Int32)
                mOffset = value
            End Set
        End Property
        Property ShowBase As Boolean
            Get
                Return mShowBase
            End Get
            Set(value As Boolean)
                mShowBase = value
            End Set
        End Property


#End Region

#Region "Private Properties"
       Private mName As String
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mTooltip As String
       Private mTooltipKey As String
       Private mType As COH_Enum_AttribType
       Private mStyle As COH_Enum_AttribStyle
       Private mKey As Int32
       Private mOffset As Int32
       Private mShowBase As Boolean
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            If SetDefaults = True Then ResetDefaults()
        End Sub
        Public Sub ResetDefaults()
            mName = String.Empty
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mTooltip = String.Empty
            mTooltipKey = String.Empty
            mType = COH_Enum_AttribType.kAttribType_Cur
            mStyle = COH_Enum_AttribStyle.kAttribStyle_None
            mKey = 0
            mOffset = 0
            mShowBase = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
            mTooltip = LocalizeController.RetrieveLocalizedString(mTooltipKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_AttributeDescription
            Dim Result As COH_AttributeDescription = New COH_AttributeDescription
            With Result
                .mName = String.Copy(mName)
                .mDisplayName = String.Copy(mDisplayName)
                .mTooltip = String.Copy(mTooltip)
                .mTooltipKey = String.Copy(mTooltipKey)
                .mType = mType
                .mStyle = mStyle
                .mKey = mKey
                .mOffset = mOffset
                .mShowBase = mShowBase
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - XML"
        Public Shared Function Export_XML_AttributeDescriptions(Folder As String, Name As String, ByRef Items As COH_AttributeDescription()) As Boolean
            If HelperFunctions.XML.Export_XMLFile(Folder & Name & ".xml", Items) = False Then
                Return False
            End If
            Return True
        End Function
#End Region

#Region "Import/Export"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(Name)
            CurrentWriter.Write_CrypticS_String(DisplayNameKey)
            CurrentWriter.Write_CrypticS_String(TooltipKey)
            CurrentWriter.Write(Type)
            CurrentWriter.Write(Style)
            CurrentWriter.Write(Key)
            CurrentWriter.Write(Offset)
            CurrentWriter.Write(ShowBase)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Name = CurrentReader.Read_CrypticS_String
            DisplayNameKey = CurrentReader.Read_CrypticS_String
            TooltipKey = CurrentReader.Read_CrypticS_String
            Type = CurrentReader.ReadInt32
            Style = CurrentReader.ReadInt32
            Key = CurrentReader.ReadInt32
            Offset = CurrentReader.ReadInt32
            ShowBase = CurrentReader.ReadInt32
            Return True
        End Function

#End Region

    End Class
End Namespace