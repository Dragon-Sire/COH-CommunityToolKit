Imports COH.GameContent.Structures.Characters.Powers

Namespace GameContent.Structures.Powers
    Public Class COH_PowerCustomFX
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return Token
            End Get
        End Property
#End Region

#Region "Properties"
        Property Token As String
            Get
                Return mToken
            End Get
            Set(value As String)
                mToken = value
            End Set
        End Property
        Property AltTheme As String()
            Get
                Return mAltTheme
            End Get
            Set(value As String())
                mAltTheme = value
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
        Property Category As String
            Get
                Return mCategory
            End Get
            Set(value As String)
                mCategory = value
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
        Property Palette As String
            Get
                Return mPalette
            End Get
            Set(value As String)
                mPalette = value
            End Set
        End Property
        Property FX As COH_PowerFX
            Get
                Return mFX
            End Get
            Set(value As COH_PowerFX)
                mFX = value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mToken As String
       Private mAltTheme As String()
       Private mSourceFile As String
       Private mCategory As String
       Private mDisplayName As String
       Private mPalette As String
       Private mFX As COH_PowerFX
#End Region

#Region "Create New Instances"
        Public Sub New()
            MyBase.New
        End Sub
        Public Sub New(SetDefaults As Boolean, Optional Version As Integer = 0, Optional BuildType As COH_BuildType = COH_BuildType.Either)
            MyBase.New(SetDefaults, Version)
        End Sub
        Public Overrides Sub ResetDefaults(Optional Version As Integer = 0)
            MyBase.ResetDefaults()
            mToken = String.Empty
            mAltTheme = New String() {}
            mSourceFile = String.Empty
            mCategory = String.Empty
            mDisplayName = String.Empty
            mPalette = String.Empty
            mFX = New COH_PowerFX
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerCustomFX
            Dim Result As COH_PowerCustomFX = New COH_PowerCustomFX
            With Result
                .mToken = String.Copy(mToken)
                .mAltTheme = mAltTheme
                .mSourceFile = String.Copy(mSourceFile)
                .mCategory = String.Copy(mCategory)
                .mDisplayName = String.Copy(mDisplayName)
                .mPalette = String.Copy(mPalette)
                .mFX = mFX.Clone
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export"
        Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(Token)
            CurrentWriter.Write_CrypticS_StringArray(AltTheme)
            CurrentWriter.Write_CrypticS_String(SourceFile)
            CurrentWriter.Write_CrypticS_String(Category)
            CurrentWriter.Write_CrypticS_String(DisplayName)
            If FX.Export_To_Stream(CurrentWriter) = False Then Return False
            CurrentWriter.Write_CrypticS_String(Palette)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            Token = CurrentReader.Read_CrypticS_String
            AltTheme = CurrentReader.Read_CrypticS_StringArray()
            SourceFile = CurrentReader.Read_CrypticS_String
            Category = CurrentReader.Read_CrypticS_String
            DisplayName = CurrentReader.Read_CrypticS_String
            If FX.Import_From_Stream(CurrentReader) = False Then Return False
            Palette = CurrentReader.Read_CrypticS_String
            Return True
        End Function
#End Region
    End Class
End Namespace