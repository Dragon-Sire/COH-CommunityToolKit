Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GEO_Group
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
        Property Pos As COH_Struct_Vector3
            Get
                Return mPos
            End Get
            Set(value As COH_Struct_Vector3)
                mPos = value
            End Set
        End Property
        Property PYR As COH_Struct_Degrees
            Get
                Return mPYR
            End Get
            Set(value As COH_Struct_Degrees)
                mPYR = value
            End Set
        End Property
        Property Flags As COH_Group_Flags
            Get
                Return mFlags
            End Get
            Set(value As COH_Group_Flags)
                mFlags = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mPos As COH_Struct_Vector3
       Private mPYR As COH_Struct_Degrees
       Private mFlags As COH_Group_Flags
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
            mName = String.Empty
            mPos = New COH_Struct_Vector3 ' No Default Defined
            mPYR = New COH_Struct_Degrees ' No Default Defined
            mFlags = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GEO_Group
            Dim Result As COH_GEO_Group = New COH_GEO_Group
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mPos = mPos
                .mPYR = mPYR
                .mFlags = mFlags
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_Vector3(mPos)
            CurrentWriter.Write_CrypticS_Degrees(mPYR)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_Vector3(mRot)
            CurrentWriter.Write_CrypticS_Flags(mFlags)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mPos = CurrentReader.Read_CrypticS_Vector3
            mPYR = CurrentReader.Read_CrypticS_Degrees
            '!!REDUNDENT!!mRot = CurrentReader.Read_CrypticS_Vector3
            mFlags = CurrentReader.Read_CrypticS_Flags
            Return True
        End Function
#End Region

    End Class
End Namespace
