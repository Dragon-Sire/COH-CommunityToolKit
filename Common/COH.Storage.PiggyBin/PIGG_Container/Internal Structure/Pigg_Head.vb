Imports COH.Storage.Serialization

Namespace Storage.Containers.PIGG.Structures
    Public NotInheritable Class COH_PIGG_FileHeader

#Region "Properties"
        ReadOnly Property ID As UInt32
            Get
                Return mIdentifier
            End Get
        End Property
        ReadOnly Property Number_DirectoryEntries As UInt32
            Get
                Return mNumber_DirectoryEntries
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mIdentifier As UInt32
        Private mUnknown1 As UInt16
        Private mUnknown2 As UInt16
        Private mUnknown3 As UInt16
        Private mDirectorySize As UInt16
        Private mNumber_DirectoryEntries As UInt32
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Private Function BuildFromStream(ByRef CurrentReader As COH_BinaryReader) As Boolean
            mIdentifier = CurrentReader.ReadUInt32
            If Not mIdentifier = 291 Then
                Return False
            End If
            mUnknown1 = CurrentReader.ReadUInt16 '2
            mUnknown2 = CurrentReader.ReadUInt16 '2
            mUnknown3 = CurrentReader.ReadUInt16 '16
            mDirectorySize = CurrentReader.ReadUInt16 '48 SIZE OF DIRECTORY INFO
            mNumber_DirectoryEntries = CurrentReader.ReadUInt32
            Return True
        End Function
#End Region

#Region "Shared Function"
        Public Shared Function CreateFromStream(ByRef CurrentReader As COH_BinaryReader, ByRef Result As COH_PIGG_FileHeader) As Boolean
            Dim Valid As Boolean = False
            Result = New COH_PIGG_FileHeader
            Valid = Result.BuildFromStream(CurrentReader)
            If Valid = False Then
                'MsgBox("Invalid/Unknwn Header Structure", MsgBoxStyle.Critical, "COH Tools PigBin")
                Return False
            Else
                Return True
            End If
        End Function
#End Region
    End Class
End Namespace