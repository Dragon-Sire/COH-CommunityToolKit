Namespace GameContent.Structures.Costumes.Cloth
    Public NotInheritable Class COH_Costume_ClothBone
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return BoneName
            End Get
        End Property
#End Region

#Region "Properties"
        Property BoneName As String
            Get
                Return mBoneName
            End Get
            Set(value As String)
                mBoneName = value
            End Set
        End Property
        Property NextBone As String
            Get
                Return mNextBone
            End Get
            Set(value As String)
                mNextBone = value
            End Set
        End Property
        Property Type As COH_Enum_ClothCollisionShape
            Get
                Return mType
            End Get
            Set(value As COH_Enum_ClothCollisionShape)
                mType = value
            End Set
        End Property
        Property Radius As Single
            Get
                Return mRadius
            End Get
            Set(value As Single)
                mRadius = value
            End Set
        End Property
        Property Exten1 As Single
            Get
                Return mExten1
            End Get
            Set(value As Single)
                mExten1 = value
            End Set
        End Property
        Property Exten2 As Single
            Get
                Return mExten2
            End Get
            Set(value As Single)
                mExten2 = value
            End Set
        End Property
        Property Offset As COH_Struct_Vector3
            Get
                Return mOffset
            End Get
            Set(value As COH_Struct_Vector3)
                mOffset = value
            End Set
        End Property
        Property Direction As COH_Struct_Vector3
            Get
                Return mDirection
            End Get
            Set(value As COH_Struct_Vector3)
                mDirection = value
            End Set
        End Property
        Property DirX As COH_Struct_Vector3
            Get
                Return mDirX
            End Get
            Set(value As COH_Struct_Vector3)
                mDirX = value
            End Set
        End Property
        Property DirY As COH_Struct_Vector3
            Get
                Return mDirY
            End Get
            Set(value As COH_Struct_Vector3)
                mDirY = value
            End Set
        End Property
        Property SameAs As String
            Get
                Return mSameAs
            End Get
            Set(value As String)
                mSameAs = value
            End Set
        End Property
        Property SpecialBackwardsFlag As Boolean
            Get
                Return mSpecialBackwardsFlag
            End Get
            Set(value As Boolean)
                mSpecialBackwardsFlag = value
            End Set
        End Property
        Property SpecialForwardsFlag As Boolean
            Get
                Return mSpecialForwardsFlag
            End Get
            Set(value As Boolean)
                mSpecialForwardsFlag = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mBoneName As String
       Private mNextBone As String
       Private mType As COH_Enum_ClothCollisionShape
       Private mRadius As Single
       Private mExten1 As Single
       Private mExten2 As Single
       Private mOffset As COH_Struct_Vector3
       Private mDirection As COH_Struct_Vector3
       Private mDirX As COH_Struct_Vector3
       Private mDirY As COH_Struct_Vector3
       Private mSameAs As String
       Private mSpecialBackwardsFlag As Boolean
       Private mSpecialForwardsFlag As Boolean
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
            mBoneName = String.Empty
            mNextBone = String.Empty
            mType = 0
            mOffset = New COH_Struct_Vector3
            mDirection = New COH_Struct_Vector3
            mDirX = New COH_Struct_Vector3
            mDirY = New COH_Struct_Vector3
            mSameAs = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Costume_ClothBone
            Dim Result As COH_Costume_ClothBone = New COH_Costume_ClothBone
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mBoneName = String.Copy(mBoneName)
                .mNextBone = String.Copy(mNextBone)
                .mType = mType
                .mRadius = mRadius
                .mExten1 = mExten1
                .mExten2 = mExten2
                .mOffset = mOffset
                .mDirection = mDirection
                .mDirX = mDirX
                .mDirY = mDirY
                .mSameAs = String.Copy(mSameAs)
                .mSpecialBackwardsFlag = mSpecialBackwardsFlag
                .mSpecialForwardsFlag = mSpecialForwardsFlag
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mBoneName)
            CurrentWriter.Write_CrypticS_String(mNextBone)
            CurrentWriter.Write(CInt(mType))
            CurrentWriter.Write(mRadius)
            CurrentWriter.Write(mExten1)
            CurrentWriter.Write(mExten2)
            CurrentWriter.Write_CrypticS_Vector3(mOffset)
            CurrentWriter.Write_CrypticS_Vector3(mDirection)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Vector3(mDir)
            CurrentWriter.Write_CrypticS_Vector3(mDirX)
            CurrentWriter.Write_CrypticS_Vector3(mDirY)
            CurrentWriter.Write_CrypticS_String(mSameAs)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Boolean(mSpecialFlag)
            CurrentWriter.Write_CrypticS_Boolean(mSpecialBackwardsFlag)
            CurrentWriter.Write_CrypticS_Boolean(mSpecialForwardsFlag)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mBoneName = CurrentReader.Read_CrypticS_String

            mNextBone = CurrentReader.Read_CrypticS_String
            mType = CurrentReader.ReadInt32
            '/  If mType >1000 Then COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)

            mRadius = CurrentReader.ReadSingle
            mExten1 = CurrentReader.ReadSingle
            mExten2 = CurrentReader.ReadSingle
            mOffset = CurrentReader.Read_CrypticS_Vector3
            mDirection = CurrentReader.Read_CrypticS_Vector3
            '!!REDUNDENT!!mDir = CurrentReader.Read_CrypticS_Vector3
            mDirX = CurrentReader.Read_CrypticS_Vector3
            mDirY = CurrentReader.Read_CrypticS_Vector3
            mSameAs = CurrentReader.Read_CrypticS_String
            'COH_LibraryEventControl.Instance.Trigger_InspectStream("Model", CurrentReader)
            '!!REDUNDENT!!mSpecialFlag = CurrentReader.Read_CrypticS_Boolean
            mSpecialBackwardsFlag = CurrentReader.Read_CrypticS_Boolean
            mSpecialForwardsFlag = CurrentReader.Read_CrypticS_Boolean
            Return True
        End Function
#End Region

    End Class
End Namespace
