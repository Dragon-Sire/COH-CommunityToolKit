Namespace GameContent.Structures.Powers
    Public Class COH_PowerName
        Inherits COH_FileStructure

#Region "Properties - Override"
        Public Overrides ReadOnly Property InternalDisplayName As String
            Get
                Return "Power Reference"
            End Get
        End Property
#End Region

#Region "Properties"
        Property PowerCategory As String
            Get
                Return mPowerCategory
            End Get
            Set(value As String)
                mPowerCategory = value
            End Set
        End Property
        Property PowerSet As String
            Get
                Return mPowerSet
            End Get
            Set(value As String)
                mPowerSet = value
            End Set
        End Property
        Property Power As String
            Get
                Return mPower
            End Get
            Set(value As String)
                mPower = value
            End Set
        End Property
        Property Level As Int32
            Get
                Return mLevel
            End Get
            Set(value As Int32)
                mLevel = value
            End Set
        End Property
        Property Remove As Int32
            Get
                Return mRemove
            End Get
            Set(value As Int32)
                mRemove = value
            End Set
        End Property
        Property DontSetStance As Int32
            Get
                Return mDontSetStance
            End Get
            Set(value As Int32)
                mDontSetStance = value
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mPowerCategory As String
       Private mPowerSet As String
       Private mPower As String
       Private mLevel As Int32
       Private mRemove As Int32
       Private mDontSetStance As Int32
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
            mPowerCategory = String.Empty
            mPowerSet = String.Empty
            mPower = String.Empty
            mLevel = 0
            mRemove = 0
            mDontSetStance = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_PowerName
            Dim Result As COH_PowerName = New COH_PowerName
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mPowerCategory = String.Copy(mPowerCategory)
                .mPowerSet = String.Copy(mPowerSet)
                .mPower = String.Copy(mPower)
                .mLevel = mLevel
                .mRemove = mRemove
                .mDontSetStance = mDontSetStance
                Return Result
            End With
            Return Result
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mPowerCategory)
            CurrentWriter.Write_CrypticS_String(mPowerSet)
            CurrentWriter.Write_CrypticS_String(mPower)
            CurrentWriter.Write(mLevel)
            CurrentWriter.Write(mRemove)
            CurrentWriter.Write(mDontSetStance)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mPowerCategory = CurrentReader.Read_CrypticS_String
            mPowerSet = CurrentReader.Read_CrypticS_String
            mPower = CurrentReader.Read_CrypticS_String
            mLevel = CurrentReader.ReadInt32
            mRemove = CurrentReader.ReadInt32
            mDontSetStance = CurrentReader.ReadInt32
            Return True
        End Function
#End Region
    End Class
End Namespace