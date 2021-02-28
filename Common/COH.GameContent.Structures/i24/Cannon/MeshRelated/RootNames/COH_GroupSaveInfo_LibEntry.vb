Namespace GameContent.Structures.MeshRelated
    Public NotInheritable Class COH_GroupSaveInfo_LibEntry
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
        Property InitialValue As UInt32
            Get
                Return mInitialValue
            End Get
            Set(value As UInt32)
                mInitialValue = value
            End Set
        End Property
        Property DirectoryIndex As UInt16
            Get
                Dim Temp = BitConverter.GetBytes(mInitialValue)
                Return BitConverter.ToUInt16(Temp, 0)
            End Get
            Set(value As UInt16)
                Dim Temp = BitConverter.GetBytes(mInitialValue)
                Dim Temp2 = BitConverter.GetBytes(value)
                Array.ConstrainedCopy(Temp2, 0, Temp, 0, 2)
                mInitialValue = BitConverter.ToUInt32(Temp, 0)
            End Set
        End Property
        Property IsRootName As Boolean
            Get
                Dim Temp = BitConverter.GetBytes(mInitialValue)
                If Temp(2) = 0 Then Return True
                Return False
            End Get
            Set(value As Boolean)
                Dim Temp = BitConverter.GetBytes(mInitialValue)
                Temp(2) = If(value = True, 1, 0)
                mInitialValue = BitConverter.ToUInt32(Temp, 0)
            End Set
        End Property
#End Region

#Region "Properties - Localized"
#End Region

#Region "Private Properties"
       Private mName As String
       Private mInitialValue As Int32
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
            mInitialValue = 0
        End Sub
#End Region

#Region "Update From MAP"
        Public Overrides Sub UpdateLocalizations(ByRef LocalizeController As ISupport_COH_LocalizeContent)
        End Sub
#End Region

#Region "Clone"
        Public Function Clone() As COH_GroupSaveInfo_LibEntry
            Dim Result As COH_GroupSaveInfo_LibEntry = New COH_GroupSaveInfo_LibEntry
            'MyBase.CloneTo(TryCast(Result, COH_FileStructure))
            With Result
                .mName = String.Copy(mName)
                .mInitialValue = mInitialValue
                Return Result
            End With
        End Function
#End Region

#Region "Import/Export - CrypticS"
      Protected Overrides Function Write_ToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write_CrypticS_String(mName)
            CurrentWriter.Write(mInitialValue)
            Return True
        End Function
        Protected Overrides Function Read_FromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mName = CurrentReader.Read_CrypticS_String
            mInitialValue = CurrentReader.ReadUInt32
            Return True
        End Function
#End Region

    End Class
End Namespace
