Namespace GameContent.Structures.Costumes.Mesh
    Public NotInheritable Class COH_CostumeFaceScale
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return DisplayName
            End Get
        End Property
#End Region

#Region "Properties"
        Property DisplayName As String
            Get
                Return mDisplayName
            End Get
            Set(value As String)
                mDisplayName = value
            End Set
        End Property
        Property Head As COH_Struct_Vector3
            Get
                Return mHead
            End Get
            Set(value As COH_Struct_Vector3)
                mHead = value
            End Set
        End Property
        Property Brow As COH_Struct_Vector3
            Get
                Return mBrow
            End Get
            Set(value As COH_Struct_Vector3)
                mBrow = value
            End Set
        End Property
        Property Cheek As COH_Struct_Vector3
            Get
                Return mCheek
            End Get
            Set(value As COH_Struct_Vector3)
                mCheek = value
            End Set
        End Property
        Property Chin As COH_Struct_Vector3
            Get
                Return mChin
            End Get
            Set(value As COH_Struct_Vector3)
                mChin = value
            End Set
        End Property
        Property Cranium As COH_Struct_Vector3
            Get
                Return mCranium
            End Get
            Set(value As COH_Struct_Vector3)
                mCranium = value
            End Set
        End Property
        Property Jaw As COH_Struct_Vector3
            Get
                Return mJaw
            End Get
            Set(value As COH_Struct_Vector3)
                mJaw = value
            End Set
        End Property
        Property Nose As COH_Struct_Vector3
            Get
                Return mNose
            End Get
            Set(value As COH_Struct_Vector3)
                mNose = value
            End Set
        End Property
        Property COV As Int32
            Get
                Return mCOV
            End Get
            Set(value As Int32)
                mCOV = value
            End Set
        End Property
        Property COH As Int32
            Get
                Return mCOH
            End Get
            Set(value As Int32)
                mCOH = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
        Property DisplayNameKey As String
            Get
                Return mDisplayNameKey
            End Get
            Set(value As String)
                mDisplayNameKey = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mDisplayName As String
       Private mDisplayNameKey As String
       Private mHead As COH_Struct_Vector3
       Private mBrow As COH_Struct_Vector3
       Private mCheek As COH_Struct_Vector3
       Private mChin As COH_Struct_Vector3
       Private mCranium As COH_Struct_Vector3
       Private mJaw As COH_Struct_Vector3
       Private mNose As COH_Struct_Vector3
       Private mCOV As Int32
       Private mCOH As Int32
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
            mDisplayName = String.Empty
            mDisplayNameKey = String.Empty
            mHead = New COH_Struct_Vector3  ' No Default Defined
            mBrow = New COH_Struct_Vector3 ' No Default Defined
            mCheek = New COH_Struct_Vector3 ' No Default Defined
            mChin = New COH_Struct_Vector3 ' No Default Defined
            mCranium = New COH_Struct_Vector3 ' No Default Defined
            mJaw = New COH_Struct_Vector3 ' No Default Defined
            mNose = New COH_Struct_Vector3 ' No Default Defined
            mCOV = 0
            mCOH = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
            mDisplayName = LocalizeController.RetrieveLocalizedString(mDisplayNameKey)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeFaceScale
            Dim Result As COH_CostumeFaceScale = New COH_CostumeFaceScale
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mDisplayName = String.Copy(mDisplayName)
                .mHead = mHead
                .mBrow = mBrow
                .mCheek = mCheek
                .mChin = mChin
                .mCranium = mCranium
                .mJaw = mJaw
                .mNose = mNose
                .mCOV = mCOV
                .mCOH = mCOH
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mDisplayNameKey)
            CurrentWriter.Write_CrypticS_Vector3(mHead)
            CurrentWriter.Write_CrypticS_Vector3(mBrow)
            CurrentWriter.Write_CrypticS_Vector3(mCheek)
            CurrentWriter.Write_CrypticS_Vector3(mChin)
            CurrentWriter.Write_CrypticS_Vector3(mCranium)
            CurrentWriter.Write_CrypticS_Vector3(mJaw)
            CurrentWriter.Write_CrypticS_Vector3(mNose)
            CurrentWriter.Write(mCOV)
            CurrentWriter.Write(mCOH)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mDisplayNameKey = CurrentReader.Read_CrypticS_String
            mHead = CurrentReader.Read_CrypticS_Vector3
            mBrow = CurrentReader.Read_CrypticS_Vector3
            mCheek = CurrentReader.Read_CrypticS_Vector3
            mChin = CurrentReader.Read_CrypticS_Vector3
            mCranium = CurrentReader.Read_CrypticS_Vector3
            mJaw = CurrentReader.Read_CrypticS_Vector3
            mNose = CurrentReader.Read_CrypticS_Vector3
            mCOV = CurrentReader.ReadInt32
            mCOH = CurrentReader.ReadInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
