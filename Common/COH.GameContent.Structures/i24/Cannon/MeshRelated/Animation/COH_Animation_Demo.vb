Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Demo
        Inherits COH_FileStructure

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
        Property StateBit As String()
            Get
                Return mStateBit
            End Get
            Set(value As String())
                mStateBit = value
            End Set
        End Property
        Property FlashBit As String()
            Get
                Return mFlashBit
            End Get
            Set(value As String())
                mFlashBit = value
            End Set
        End Property
        Property filename As String
            Get
                Return mfilename
            End Get
            Set(value As String)
                mfilename = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mStateBit As String()
       Private mFlashBit As String()
       Private mfilename As String
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
            mName = String.Empty
            mStateBit = New String() {}
            mFlashBit = New String() {}
            mfilename = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Demo
            Dim Result As COH_Animation_Demo = New COH_Animation_Demo
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mStateBit = mStateBit.CloneTheStrings
                .mFlashBit = mFlashBit.CloneTheStrings
                .mfilename = String.Copy(mfilename)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_StringArray(mStateBit)
            CurrentWriter.Write_CrypticS_StringArray(mFlashBit)
            CurrentWriter.Write_CrypticS_String(mfilename)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mStateBit = CurrentReader.Read_CrypticS_StringArray()
            mFlashBit = CurrentReader.Read_CrypticS_StringArray()
            mfilename = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
