Namespace GameContent.Structures.Costumes.Mesh
    Public NotInheritable Class COH_CostumeGeoData
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
        Property Filename As String
            Get
                Return mFilename
            End Get
            Set(value As String)
                mFilename = value
            End Set
        End Property
        Property ShieldXYZ As COH_Struct_Vector3
            Get
                Return mShieldXYZ
            End Get
            Set(value As COH_Struct_Vector3)
                mShieldXYZ = value
            End Set
        End Property
        Property ShieldPYR As COH_Struct_Vector3
            Get
                Return mShieldPYR
            End Get
            Set(value As COH_Struct_Vector3)
                mShieldPYR = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mFilename As String
       Private mShieldXYZ As COH_Struct_Vector3
       Private mShieldPYR As COH_Struct_Vector3
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
            mFilename = String.Empty
            mShieldXYZ = New COH_Struct_Vector3  ' No Default Defined
            mShieldPYR = New COH_Struct_Vector3  ' No Default Defined
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumeGeoData
            Dim Result As COH_CostumeGeoData = New COH_CostumeGeoData
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mFilename = String.Copy(mFilename)
                .mShieldXYZ = mShieldXYZ
                .mShieldPYR = mShieldPYR
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mFilename)
            CurrentWriter.Write_CrypticS_Vector3(mShieldXYZ)
            CurrentWriter.Write_CrypticS_Vector3(mShieldPYR)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mFilename = CurrentReader.Read_CrypticS_String
            mShieldXYZ = CurrentReader.Read_CrypticS_Vector3
            mShieldPYR = CurrentReader.Read_CrypticS_Vector3
            Return True
        End Function
#End Region

    End Class
End Namespace
