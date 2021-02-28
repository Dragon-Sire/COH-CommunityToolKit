Namespace GameContent.Structures.Animation
    Public NotInheritable Class COH_Animation_Sequence_Raw
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Raw"
            End Get
        End Property
#End Region

#Region "Properties"
        Property Index As Int32
            Get
                Return mIndex
            End Get
            Set(value As Int32)
                mIndex = value
            End Set
        End Property
        Property NextMove_Count As Byte
            Get
                Return mNextMove_Count
            End Get
            Set(value As Byte)
                mNextMove_Count = value
            End Set
        End Property
        Property CycleMove_Count As Byte
            Get
                Return mCycleMove_Count
            End Get
            Set(value As Byte)
                mCycleMove_Count = value
            End Set
        End Property
        Property NextMoves As Int32()
            Get
                Return mNextMoves
            End Get
            Set(value As Int32())
                mNextMoves = value
            End Set
        End Property
        Property Raw_CycleMoves As Int32()
            Get
                Return mRaw_CycleMoves
            End Get
            Set(value As Int32())
                mRaw_CycleMoves = value
            End Set
        End Property
        Property Raw_Count As Int32
            Get
                Return mRaw_Count
            End Get
            Set(value As Int32)
                mRaw_Count = value
            End Set
        End Property
        Property Raw_Requires_Bits As Int32()
            Get
                Return mRaw_Requires_Bits
            End Get
            Set(value As Int32())
                mRaw_Requires_Bits = value
            End Set
        End Property
        Property Raw_Member_Bits As Int32()
            Get
                Return mRaw_Member_Bits
            End Get
            Set(value As Int32())
                mRaw_Member_Bits = value
            End Set
        End Property
        Property Raw_interrupt_Bits As Int32()
            Get
                Return mRaw_interrupt_Bits
            End Get
            Set(value As Int32())
                mRaw_interrupt_Bits = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mIndex As Int32
       Private mNextMove_Count As UInt32
       Private mCycleMove_Count As UInt32
       Private mNextMoves As Int32()
       Private mRaw_CycleMoves As Int32()
       Private mRaw_Count As Int32
       Private mRaw_Requires_Bits As Int32()
       Private mRaw_Member_Bits As Int32()
       Private mRaw_interrupt_Bits As Int32()
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
            mNextMoves = New Int32() {}
            mRaw_CycleMoves = New Int32() {}
            mRaw_Requires_Bits = New Int32() {}
            mRaw_Member_Bits = New Int32() {}
            mRaw_interrupt_Bits = New Int32() {}
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Animation_Sequence_Raw
            Dim Result As COH_Animation_Sequence_Raw = New COH_Animation_Sequence_Raw
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mIndex = mIndex
                .mNextMove_Count = mNextMove_Count
                .mCycleMove_Count = mCycleMove_Count
                .mNextMoves = New Int32(mNextMoves.Count - 1) {} : mNextMoves.CopyTo(.mNextMoves, 0)
                .mRaw_CycleMoves = New Int32(mRaw_CycleMoves.Count - 1) {} : mRaw_CycleMoves.CopyTo(.mRaw_CycleMoves, 0)
                .mRaw_Count = mRaw_Count
                .mRaw_Requires_Bits = New Int32(mRaw_Requires_Bits.Count - 1) {} : mRaw_Requires_Bits.CopyTo(.mRaw_Requires_Bits, 0)
                .mRaw_Member_Bits = New Int32(mRaw_Member_Bits.Count - 1) {} : mRaw_Member_Bits.CopyTo(.mRaw_Member_Bits, 0)
                .mRaw_interrupt_Bits = New Int32(mRaw_interrupt_Bits.Count - 1) {} : mRaw_interrupt_Bits.CopyTo(.mRaw_interrupt_Bits, 0)
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
            CurrentWriter.Write(mIndex)
            CurrentWriter.Write(mNextMove_Count)
            CurrentWriter.Write(mCycleMove_Count)
            CurrentWriter.Write_CrypticS_IntegerArray(mNextMoves)
            CurrentWriter.Write_CrypticS_IntegerArray(mRaw_CycleMoves)
            CurrentWriter.Write(mRaw_Count)
            CurrentWriter.Write_CrypticS_IntegerArray(mRaw_Requires_Bits)
            CurrentWriter.Write_CrypticS_IntegerArray(mRaw_Member_Bits)
            CurrentWriter.Write_CrypticS_IntegerArray(mRaw_interrupt_Bits)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mIndex = CurrentReader.ReadInt32
            mNextMove_Count = CurrentReader.ReadUInt32
            mCycleMove_Count = CurrentReader.ReadUInt32
            mNextMoves = CurrentReader.Read_CrypticS_IntegerArray(MAX_NEXT_MOVES)
            mRaw_CycleMoves = CurrentReader.Read_CrypticS_IntegerArray(MAX_CYCLE_MOVES)
            mRaw_Count = CurrentReader.ReadInt32
            mRaw_Requires_Bits = CurrentReader.Read_CrypticS_IntegerArray(MAX_SPARSE_BITS)
            mRaw_Member_Bits = CurrentReader.Read_CrypticS_IntegerArray(MAX_IRQ_ARRAY_SIZE)
            mRaw_interrupt_Bits = CurrentReader.Read_CrypticS_IntegerArray(MAX_IRQ_ARRAY_SIZE)
            Return True
        End Function
#End Region

    End Class
End Namespace
