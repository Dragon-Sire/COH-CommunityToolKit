Imports COH.GameContent.Structures.MeshRelated.Textures

Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_TrickList
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "TrickList"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Texture As COH_TextureOptions
            Get
                Return mTexture
            End Get
            Set(value As COH_TextureOptions)
                mTexture = value
            End Set
        End Property
        Property Trick As COH_Trick
            Get
                Return mTrick
            End Get
            Set(value As COH_Trick)
                mTrick = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mTexture As COH_TextureOptions
       Private mTrick As COH_Trick
#End Region

#Region "Create New Instance"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mTexture = New COH_TextureOptions
            mTrick = New COH_Trick
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_TrickList
            Dim Result As COH_TrickList = New COH_TrickList
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mTexture = mTexture.Clone
                .mTrick = mTrick.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '//If CurrentWriter.Write_CrypticS_StructArray(mTexture) = False Then Return False
            '//  If CurrentWriter.Write_CrypticS_StructArray(mTrick) = False Then Return False
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mTexture = New COH_TextureOptions() : If mTexture.Import_From_Stream(CurrentReader) = False Then Return False
            Dim Size1 As UInt32 = CurrentReader.ReadUInt32


            Return True
            'COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
            mTrick = New COH_Trick() : If mTrick.Import_From_Stream(CurrentReader) = False Then Return False
            Return True
        End Function
#End Region

    End Class
End Namespace
