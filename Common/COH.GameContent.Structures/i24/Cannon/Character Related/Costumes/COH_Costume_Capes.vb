Imports COH.GameContent.Structures.Shared.Drawing

Namespace GameContent.Structures.Costumes
    Public NotInheritable Class COH_Costume_Capes
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
        Property Timestamp As Int32
            Get
                Return mTimestamp
            End Get
            Set(value As Int32)
                mTimestamp = value
            End Set
        End Property
        Property GeoName As String
            Get
                Return mGeoName
            End Get
            Set(value As String)
                mGeoName = value
            End Set
        End Property
        Property GeoFile As String
            Get
                Return mGeoFile
            End Get
            Set(value As String)
                mGeoFile = value
            End Set
        End Property
        Property HarnessName As String
            Get
                Return mHarnessName
            End Get
            Set(value As String)
                mHarnessName = value
            End Set
        End Property
        Property HarnessFile As String
            Get
                Return mHarnessFile
            End Get
            Set(value As String)
                mHarnessFile = value
            End Set
        End Property
        Property Trick As String
            Get
                Return mTrick
            End Get
            Set(value As String)
                mTrick = value
            End Set
        End Property
        Property Color1 As COH_Color_RGB
            Get
                Return mColor1
            End Get
            Set(value As COH_Color_RGB)
                mColor1 = value
            End Set
        End Property
        Property Color2 As COH_Color_RGB
            Get
                Return mColor2
            End Get
            Set(value As COH_Color_RGB)
                mColor2 = value
            End Set
        End Property
        Property Color3 As COH_Color_RGB
            Get
                Return mColor3
            End Get
            Set(value As COH_Color_RGB)
                mColor3 = value
            End Set
        End Property
        Property Color4 As COH_Color_RGB
            Get
                Return mColor4
            End Get
            Set(value As COH_Color_RGB)
                mColor4 = value
            End Set
        End Property
        Property Tex1 As String
            Get
                Return mTex1
            End Get
            Set(value As String)
                mTex1 = value
            End Set
        End Property
        Property Tex2 As String
            Get
                Return mTex2
            End Get
            Set(value As String)
                mTex2 = value
            End Set
        End Property
        Property Tex3 As String
            Get
                Return mTex3
            End Get
            Set(value As String)
                mTex3 = value
            End Set
        End Property
        Property Tex4 As String
            Get
                Return mTex4
            End Get
            Set(value As String)
                mTex4 = value
            End Set
        End Property
        Property Stiffness As Single
            Get
                Return mStiffness
            End Get
            Set(value As Single)
                mStiffness = value
            End Set
        End Property
        Property Drag As Single
            Get
                Return mDrag
            End Get
            Set(value As Single)
                mDrag = value
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
        Property ScaleXY As COH_Struct_Vector2
            Get
                Return mScaleXY
            End Get
            Set(value As COH_Struct_Vector2)
                mScaleXY = value
            End Set
        End Property
        Property LODBias As Single
            Get
                Return mLODBias
            End Get
            Set(value As Single)
                mLODBias = value
            End Set
        End Property
        Property PointYScale As Single
            Get
                Return mPointYScale
            End Get
            Set(value As Single)
                mPointYScale = value
            End Set
        End Property
        Property ColRad As Single
            Get
                Return mColRad
            End Get
            Set(value As Single)
                mColRad = value
            End Set
        End Property
        Property IsFlag As Boolean
            Get
                Return mIsFlag
            End Get
            Set(value As Boolean)
                mIsFlag = value
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
        Property Collision As String
            Get
                Return mCollision
            End Get
            Set(value As String)
                mCollision = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mTimestamp As Int32
       Private mGeoName As String
       Private mGeoFile As String
       Private mHarnessName As String
       Private mHarnessFile As String
       Private mTrick As String
       Private mColor1 As COH_Color_RGB
       Private mColor2 As COH_Color_RGB
       Private mColor3 As COH_Color_RGB
       Private mColor4 As COH_Color_RGB
       Private mTex1 As String
       Private mTex2 As String
       Private mTex3 As String
       Private mTex4 As String
       Private mStiffness As Single
       Private mDrag As Single
       Private mScale As Single
       Private mScaleXY As COH_Struct_Vector2
       Private mLODBias As Single
       Private mPointYScale As Single
       Private mColRad As Single
       Private mIsFlag As Boolean
       Private mWind As String
       Private mCollision As String
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
            mGeoName = String.Empty
            mGeoFile = String.Empty
            mHarnessName = String.Empty
            mHarnessFile = String.Empty
            mTrick = String.Empty
            mTex1 = String.Empty
            mTex2 = String.Empty
            mTex3 = String.Empty
            mTex4 = String.Empty
            mScaleXY = New COH_Struct_Vector2
            mWind = String.Empty
            mCollision = String.Empty
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_Costume_Capes
            Dim Result As COH_Costume_Capes = New COH_Costume_Capes
            ''MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mTimestamp = mTimestamp
                .mGeoName = String.Copy(mGeoName)
                .mGeoFile = String.Copy(mGeoFile)
                .mHarnessName = String.Copy(mHarnessName)
                .mHarnessFile = String.Copy(mHarnessFile)
                .mTrick = String.Copy(mTrick)
                .mColor1 = mColor1
                .mColor2 = mColor2
                .mColor3 = mColor3
                .mColor4 = mColor4
                .mTex1 = String.Copy(mTex1)
                .mTex2 = String.Copy(mTex2)
                .mTex3 = String.Copy(mTex3)
                .mTex4 = String.Copy(mTex4)
                .mStiffness = mStiffness
                .mDrag = mDrag
                .mScale = mScale
                .mScaleXY = mScaleXY
                .mLODBias = mLODBias
                .mPointYScale = mPointYScale
                .mColRad = mColRad
                .mIsFlag = mIsFlag
                .mWind = String.Copy(mWind)
                .mCollision = String.Copy(mCollision)
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            '!!IGNORED!! mCape)
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write_CrypticS_TimeStamp(mTimestamp)
            CurrentWriter.Write_CrypticS_String(mGeoName)
            CurrentWriter.Write_CrypticS_String(mGeoFile)
            CurrentWriter.Write_CrypticS_String(mHarnessName)
            CurrentWriter.Write_CrypticS_String(mHarnessFile)
            CurrentWriter.Write_CrypticS_String(mTrick)
            mColor1.Export_To_Stream(CurrentWriter)
            mColor2.Export_To_Stream(CurrentWriter)
            mColor3.Export_To_Stream(CurrentWriter)
            mColor4.Export_To_Stream(CurrentWriter)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_RGB(mInnerColor1)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_RGB(mInnerColor2)
            CurrentWriter.Write_CrypticS_String(mTex1)
            CurrentWriter.Write_CrypticS_String(mTex2)
            CurrentWriter.Write_CrypticS_String(mTex3)
            CurrentWriter.Write_CrypticS_String(mTex4)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mInnerTex1)
            '!!REDUNDENT!!CurrentWriter.Write_CrypticS_String(mInnerTex2)
            CurrentWriter.Write(mStiffness)
            CurrentWriter.Write(mDrag)
            CurrentWriter.Write(mScale)
            CurrentWriter.Write_CrypticS_Vector2(mScaleXY)
            CurrentWriter.Write(mLODBias)
            CurrentWriter.Write(mPointYScale)
            CurrentWriter.Write(mColRad)
            CurrentWriter.Write_CrypticS_Boolean(mIsFlag)
            CurrentWriter.Write_CrypticS_String(mWind)
            CurrentWriter.Write_CrypticS_String(mCollision)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            '!!IGNORED!! mCape = 
            mName = CurrentReader.Read_CrypticS_String
            mTimestamp = CurrentReader.Read_CrypticS_TimeStamp
            mGeoName = CurrentReader.Read_CrypticS_String
            mGeoFile = CurrentReader.Read_CrypticS_String
            mHarnessName = CurrentReader.Read_CrypticS_String
            mHarnessFile = CurrentReader.Read_CrypticS_String
            mTrick = CurrentReader.Read_CrypticS_String
            mColor1 = New COH_Color_RGB(CurrentReader)
            mColor2 = New COH_Color_RGB(CurrentReader)
            mColor3 = New COH_Color_RGB(CurrentReader)
            mColor4 = New COH_Color_RGB(CurrentReader)
            '!!REDUNDENT!!mInnerColor1 = CurrentReader.Read_CrypticS_RGB
            '!!REDUNDENT!!mInnerColor2 = CurrentReader.Read_CrypticS_RGB
            mTex1 = CurrentReader.Read_CrypticS_String
            mTex2 = CurrentReader.Read_CrypticS_String
            mTex3 = CurrentReader.Read_CrypticS_String
            mTex4 = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mInnerTex1 = CurrentReader.Read_CrypticS_String
            '!!REDUNDENT!!mInnerTex2 = CurrentReader.Read_CrypticS_String
            mStiffness = CurrentReader.ReadSingle
            mDrag = CurrentReader.ReadSingle
            mScale = CurrentReader.ReadSingle
            mScaleXY = CurrentReader.Read_CrypticS_Vector2
            mLODBias = CurrentReader.ReadSingle
            mPointYScale = CurrentReader.ReadSingle
            mColRad = CurrentReader.ReadSingle
            mIsFlag = CurrentReader.Read_CrypticS_Boolean
            mWind = CurrentReader.Read_CrypticS_String
            mCollision = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region

    End Class
End Namespace
