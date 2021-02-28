Namespace GameContent.Structures.UI
    Public NotInheritable Class COH_Map_ComponentPlace
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Placement"
            End Get
        End Property
#End Region

#Region "Properties"
        Property X As Single
            Get
                Return mX
            End Get
            Set(value As Single)
                mX = value
            End Set
        End Property
        Property Y As Single
            Get
                Return mY
            End Get
            Set(value As Single)
                mY = value
            End Set
        End Property
        Property Z As Single
            Get
                Return mZ
            End Get
            Set(value As Single)
                mZ = value
            End Set
        End Property
        Property XScale As Single
            Get
                Return mXScale
            End Get
            Set(value As Single)
                mXScale = value
            End Set
        End Property
        Property YScale As Single
            Get
                Return mYScale
            End Get
            Set(value As Single)
                mYScale = value
            End Set
        End Property
        Property Angle As Single
            Get
                Return mAngle
            End Get
            Set(value As Single)
                mAngle = value
            End Set
        End Property
        Property Color As Int32
            Get
                Return mColor
            End Get
            Set(value As Int32)
                mColor = value
            End Set
        End Property
        Property TextBackgroundColor As Int32
            Get
                Return mTextBackgroundColor
            End Get
            Set(value As Int32)
                mTextBackgroundColor = value
            End Set
        End Property
        'Property Additive As Byte
        'Get
        ' Return mAngle
        ' End Get
        '' Set(value As Byte)
        '        mAngle = value
        ' End Set
        'End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mX As Single
       Private mY As Single
       Private mZ As Single
       Private mXScale As Single
       Private mYScale As Single
       Private mAngle As Single
       Private mColor As Int32
       Private mTextBackgroundColor As Int32
        '  Private mAdditive As Byte '//BITFIELD
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Sub New(ByRef Buffer As Byte(), Optional Settings as COH_Serialization_Settings = Nothing)
            MyBase.New(Buffer, Settings)
        End Sub
        Public Sub New(ByRef Stream As IO.MemoryStream, Optional Settings as COH_Serialization_Settings = Nothing)
             MyBase.New(Stream, Settings)
        End Sub
        Public Sub New(ByRef CurrentReader As COH_BinaryReader)
             MyBase.New(CurrentReader)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Map_ComponentPlace
            Dim Result As COH_Map_ComponentPlace = New COH_Map_ComponentPlace
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mX = mX
                .mY = mY
                .mZ = mZ
                .mXScale = mXScale
                .mYScale = mYScale
                .mAngle = mAngle
                .mColor = mColor
                .mTextBackgroundColor = mTextBackgroundColor
                ' .mAdditive = mAdditive
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mArchitectMapComponentPlace)
            CurrentWriter.Write(mX)
            CurrentWriter.Write(mY)
            CurrentWriter.Write(mZ)
            CurrentWriter.Write(mXScale)
            CurrentWriter.Write(mYScale)
            CurrentWriter.Write(mAngle)
            CurrentWriter.Write(mColor)
            CurrentWriter.Write(mTextBackgroundColor)
            ' CurrentWriter.Write_CrypticS_Byte_Aligned4(mAdditive)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mArchitectMapComponentPlace = 
            mX = CurrentReader.ReadSingle
            mY = CurrentReader.ReadSingle
            mZ = CurrentReader.ReadSingle
            mXScale = CurrentReader.ReadSingle
            mYScale = CurrentReader.ReadSingle
            mAngle = CurrentReader.ReadSingle
            mColor = CurrentReader.ReadInt32
            mTextBackgroundColor = CurrentReader.ReadInt32
            'mAdditive = CurrentReader.Read_CrypticS_Byte_Aligned4
            Return True
        End Function
#End Region

    End Class
End Namespace
