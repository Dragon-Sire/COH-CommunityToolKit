Imports COH.CodeManagement.Enums.Pigg
Imports COH.Storage.Serialization

Namespace Storage.Containers.PIGG.Structures.Contents
    Public Class PIGG_SlotEntry_UNKNOWN
        Inherits COH_PIGG_SlotTableEntry

#Region "Properties"
        Public Overrides ReadOnly Property SlotType As PIGG_Container_SlotTypes
            Get
                Return PIGG_Container_SlotTypes.Unknown
            End Get
        End Property
#End Region

#Region "Private Properties"
        Private mRawBytes As Byte()
#End Region

#Region "Create New Instance"
        Public Sub New()
        End Sub
        Sub New(ByRef CurrentReader As COH_BinaryReader)
            MyBase.New(CurrentReader)
        End Sub
        Public Overrides Function Extract_EntryInfo(ByRef CurrentReader As COH_BinaryReader, ExpectedSize As Integer) As Boolean
            mRawBytes = CurrentReader.ReadBytes(ExpectedSize)
            Return True
        End Function
        Public Overrides Function WriteToStream(ByRef CurrentWriter As COH_BinaryWriter) As Boolean
            CurrentWriter.Write(mRawBytes)
            Return True
        End Function
#End Region
    End Class
End Namespace