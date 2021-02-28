Imports System.Drawing

Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_CostumePart
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
        Property SourceFile As String
            Get
                Return mSourceFile
            End Get
            Set(value As String)
                mSourceFile = value
            End Set
        End Property
        Property Fx As String
            Get
                Return mFx
            End Get
            Set(value As String)
                mFx = value
            End Set
        End Property
        Property Geometry As String
            Get
                Return mGeometry
            End Get
            Set(value As String)
                mGeometry = value
            End Set
        End Property
        Property Texture1 As String
            Get
                Return mTexture1
            End Get
            Set(value As String)
                mTexture1 = value
            End Set
        End Property
        Property Texture2 As String
            Get
                Return mTexture2
            End Get
            Set(value As String)
                mTexture2 = value
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
        Property RegionName As String
            Get
                Return mRegionName
            End Get
            Set(value As String)
                mRegionName = value
            End Set
        End Property
        Property BodySetName As String
            Get
                Return mBodySetName
            End Get
            Set(value As String)
                mBodySetName = value
            End Set
        End Property
        Property CostumeNum As Int32
            Get
                Return mCostumeNum
            End Get
            Set(value As Int32)
                mCostumeNum = value
            End Set
        End Property
        Property Color1 As COH_XML_Color
            Get
                Return mColor1
            End Get
            Set(value As COH_XML_Color)
                mColor1 = value
            End Set
        End Property
        Property Color2 As COH_XML_Color
            Get
                Return mColor2
            End Get
            Set(value As COH_XML_Color)
                mColor2 = value
            End Set
        End Property
        Property Color3 As COH_XML_Color
            Get
                Return mColor3
            End Get
            Set(value As COH_XML_Color)
                mColor3 = value
            End Set
        End Property
        Property Color4 As COH_XML_Color
            Get
                Return mColor4
            End Get
            Set(value As COH_XML_Color)
                mColor4 = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mSourceFile As String
       Private mFx As String
       Private mGeometry As String
       Private mTexture1 As String
       Private mTexture2 As String
       Private mDisplayName As String
       Private mRegionName As String
       Private mBodySetName As String
       Private mCostumeNum As Int32
       Private mColor1 As Color
       Private mColor2 As Color
       Private mColor3 As Color
       Private mColor4 As Color
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
            mSourceFile = String.Empty
            mFx = String.Empty
            mGeometry = String.Empty
            mTexture1 = String.Empty
            mTexture2 = String.Empty
            mDisplayName = String.Empty
            mRegionName = String.Empty
            mBodySetName = String.Empty
            mCostumeNum = 0
            mColor1 = New Color  ' No Default Defined
            mColor2 = New Color   ' No Default Defined
            mColor3 = New Color   ' No Default Defined
            mColor4 = New Color   ' No Default Defined
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_CostumePart
            Dim Result As COH_CostumePart = New COH_CostumePart
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mSourceFile = String.Copy(mSourceFile)
                .mFx = String.Copy(mFx)
                .mGeometry = String.Copy(mGeometry)
                .mTexture1 = String.Copy(mTexture1)
                .mTexture2 = String.Copy(mTexture2)
                .mDisplayName = String.Copy(mDisplayName)
                .mRegionName = String.Copy(mRegionName)
                .mBodySetName = String.Copy(mBodySetName)
                .mCostumeNum = mCostumeNum
                .mColor1 = mColor1
                .mColor2 = mColor2
                .mColor3 = mColor3
                .mColor4 = mColor4
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_String(mSourceFile)
            CurrentWriter.Write_CrypticS_String(mFx)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mFxName)
            CurrentWriter.Write_CrypticS_String(mGeometry)
            CurrentWriter.Write_CrypticS_String(mTexture1)
            CurrentWriter.Write_CrypticS_String(mTexture2)
            CurrentWriter.Write_CrypticS_String(mDisplayName)
            CurrentWriter.Write_CrypticS_String(mRegionName)
            CurrentWriter.Write_CrypticS_String(mBodySetName)
            CurrentWriter.Write(mCostumeNum)
            CurrentWriter.Write_CrypticS_RGB(mColor1)
            CurrentWriter.Write_CrypticS_RGB(mColor2)
            CurrentWriter.Write_CrypticS_RGB(mColor3)
            CurrentWriter.Write_CrypticS_RGB(mColor4)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mSourceFile = CurrentReader.Read_CrypticS_String
            mFx = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mFxName = CurrentReader.Read_CrypticS_String
            mGeometry = CurrentReader.Read_CrypticS_String
            mTexture1 = CurrentReader.Read_CrypticS_String
            mTexture2 = CurrentReader.Read_CrypticS_String
            mDisplayName = CurrentReader.Read_CrypticS_String
            mRegionName = CurrentReader.Read_CrypticS_String
            mBodySetName = CurrentReader.Read_CrypticS_String
            mCostumeNum = CurrentReader.ReadInt32
            mColor1 = CurrentReader.Read_CrypticS_RGB
            mColor2 = CurrentReader.Read_CrypticS_RGB
            mColor3 = CurrentReader.Read_CrypticS_RGB
            mColor4 = CurrentReader.Read_CrypticS_RGB
            Return True
        End Function
#End Region

    End Class
End Namespace
