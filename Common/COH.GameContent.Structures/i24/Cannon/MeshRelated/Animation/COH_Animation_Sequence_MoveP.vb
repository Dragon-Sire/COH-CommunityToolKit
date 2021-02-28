Imports COH.GameContent.Structures.Shared

Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Sequence_MoveP
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
        Property MoveRate As Single
            Get
                Return mMoveRate
            End Get
            Set(value As Single)
                mMoveRate = value
            End Set
        End Property
        Property Interpolate As Int32
            Get
                Return mInterpolate
            End Get
            Set(value As Int32)
                mInterpolate = value
            End Set
        End Property
        Property Priority As Int32
            Get
                Return mPriority
            End Get
            Set(value As Int32)
                mPriority = value
            End Set
        End Property
        Property Scale As Single
            Get
                Return mScale
            End Get
            Set(value As Single)
                mScale = value
            End Set
        End Property
        Property NextMove As COH_Generic_StringClass()
            Get
                Return mNextMove
            End Get
            Set(value As COH_Generic_StringClass())
                mNextMove = value
            End Set
        End Property
        Property CycleMove As COH_Generic_StringClass()
            Get
                Return mCycleMove
            End Get
            Set(value As COH_Generic_StringClass())
                mCycleMove = value
            End Set
        End Property
        Property Type As COH_Animation_GFX()
            Get
                Return mType
            End Get
            Set(value As COH_Animation_GFX())
                mType = value
            End Set
        End Property
        Property Wind As String
            Get
                Return mWind
            End Get
            Set(value As String)
                mWind = value
            End Set
        End Property
        Property Member As String()
            Get
                Return mMember
            End Get
            Set(value As String())
                mMember = value
            End Set
        End Property
        Property Interrupts As String()
            Get
                Return mInterrupts
            End Get
            Set(value As String())
                mInterrupts = value
            End Set
        End Property
        Property SticksOnChild As String()
            Get
                Return mSticksOnChild
            End Get
            Set(value As String())
                mSticksOnChild = value
            End Set
        End Property
        Property SetsOnChild As String()
            Get
                Return mSetsOnChild
            End Get
            Set(value As String())
                mSetsOnChild = value
            End Set
        End Property
        Property SetsOnReactor As String()
            Get
                Return mSetsOnReactor
            End Get
            Set(value As String())
                mSetsOnReactor = value
            End Set
        End Property
        Property Sets As String()
            Get
                Return mSets
            End Get
            Set(value As String())
                mSets = value
            End Set
        End Property
        Property Requires As String()
            Get
                Return mRequires
            End Get
            Set(value As String())
                mRequires = value
            End Set
        End Property
        Property Flags As COH_EnumFlags_MoveSequence
            Get
                Return mFlags
            End Get
            Set(value As COH_EnumFlags_MoveSequence)
                mFlags = value
            End Set
        End Property
        Property Raw As COH_Animation_Sequence_Raw
            Get
                Return mRaw
            End Get
            Set(value As COH_Animation_Sequence_Raw)
                mRaw = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mMoveRate As Single
       Private mInterpolate As Int32
       Private mPriority As Int32
       Private mScale As Single
       Private mNextMove As COH_Generic_StringClass()
       Private mCycleMove As COH_Generic_StringClass()
       Private mType As COH_Animation_GFX()
       Private mWind As String
       Private mMember As String()
       Private mInterrupts As String()
       Private mSticksOnChild As String()
       Private mSetsOnChild As String()
       Private mSetsOnReactor As String()
       Private mSets As String()
       Private mRequires As String()
       Private mFlags As COH_EnumFlags_MoveSequence
       Private mRaw As COH_Animation_Sequence_Raw
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
            mName = ""
            mNextMove = New COH_Generic_StringClass() {}
            mCycleMove = New COH_Generic_StringClass() {}
            mType = New COH_Animation_GFX() {}
            mWind = String.Empty
            mMember = New String() {}
            mInterrupts = New String() {}
            mSticksOnChild = New String() {}
            mSetsOnChild = New String() {}
            mSetsOnReactor = New String() {}
            mSets = New String() {}
            mRequires = New String() {}
            mRaw = New COH_Animation_Sequence_Raw
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Sequence_MoveP
            Dim Result As COH_Animation_Sequence_MoveP = New COH_Animation_Sequence_MoveP
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mMoveRate = mMoveRate
                .mInterpolate = mInterpolate
                .mPriority = mPriority
                .mScale = mScale
                .mNextMove = New COH_Generic_StringClass(mNextMove.Count - 1) {}
                For X = 0 To mNextMove.Count - 1
                    .mNextMove(X) = mNextMove(X).Clone
                Next
                .mCycleMove = New COH_Generic_StringClass(mCycleMove.Count - 1) {}
                For X = 0 To mCycleMove.Count - 1
                    .mCycleMove(X) = mCycleMove(X).Clone
                Next
                .mType = New COH_Animation_GFX(mType.Count - 1) {}
                For X = 0 To mType.Count - 1
                    .mType(X) = mType(X).Clone
                Next
                .mWind = String.Copy(mWind)
                .mMember = mMember.CloneTheStrings
                .mInterrupts = mInterrupts.CloneTheStrings
                .mSticksOnChild = mSticksOnChild.CloneTheStrings
                .mSetsOnChild = mSetsOnChild.CloneTheStrings
                .mSetsOnReactor = mSetsOnReactor.CloneTheStrings
                .mSets = mSets.CloneTheStrings
                .mRequires = mRequires.CloneTheStrings
                .mFlags = mFlags
                .mRaw = mRaw.Clone
                Return Result
            End With
        End Function
#End Region

        Const BONEID_COUNT = 99
        Const MAX_CYCLE_MOVES = 5
        Const MAX_NEXT_MOVES = 4
        Const MAX_IRQ_ARRAY_SIZE = 14
        Const MAX_SPARSE_BITS = 12
        Const MAX_BONE_BITFIELD = ((BONEID_COUNT + 31) / 32)

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mMoveRate)
            CurrentWriter.Write(mInterpolate)
            CurrentWriter.Write(mPriority)
            CurrentWriter.Write(mScale)
            If CurrentWriter.Write_CrypticS_StructArray(mNextMove) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mCycleMove) = False Then Return False
            If CurrentWriter.Write_CrypticS_StructArray(mType) = False Then Return False
            CurrentWriter.Write_CrypticS_String(mWind)
            CurrentWriter.Write_CrypticS_StringArray(mMember)
            CurrentWriter.Write_CrypticS_StringArray(mInterrupts)
            CurrentWriter.Write_CrypticS_StringArray(mSticksOnChild)
            CurrentWriter.Write_CrypticS_StringArray(mSetsOnChild)
            CurrentWriter.Write_CrypticS_StringArray(mSetsOnReactor)
            CurrentWriter.Write_CrypticS_StringArray(mSets)
            CurrentWriter.Write_CrypticS_StringArray(mRequires)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            mRaw.Export_To_Stream(CurrentWriter)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mMoveRate = CurrentReader.ReadSingle
            mInterpolate = CurrentReader.ReadInt32
            mPriority = CurrentReader.ReadInt32
            mScale = CurrentReader.ReadSingle


            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Generic_StringClass), mNextMove) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Generic_StringClass), mCycleMove) = False Then Return False
            If CurrentReader.Read_CrypticS_StructArray(GetType(COH_Animation_GFX), mType) = False Then Return False


            mWind = CurrentReader.Read_CrypticS_String
            mMember = CurrentReader.Read_CrypticS_StringArray()
            mInterrupts = CurrentReader.Read_CrypticS_StringArray()
            mSticksOnChild = CurrentReader.Read_CrypticS_StringArray()
            mSetsOnChild = CurrentReader.Read_CrypticS_StringArray()
            mSetsOnReactor = CurrentReader.Read_CrypticS_StringArray()
            mSets = CurrentReader.Read_CrypticS_StringArray()
            mRequires = CurrentReader.Read_CrypticS_StringArray()
            mFlags = CurrentReader.Read_CrypticS_Flags

            'typedef struct SeqMoveRaw
            mRaw = New COH_Animation_Sequence_Raw(CurrentReader)
            Return True
        End Function
#End Region

    End Class
End Namespace
