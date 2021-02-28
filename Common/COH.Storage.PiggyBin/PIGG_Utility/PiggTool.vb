Imports COH.Storage.Containers.PIGG.Structures
Imports COH.Storage.Serialization
Imports COH.Storage.Structures

Namespace Storage.Containers.PIGG.Utilities
    Public Class COH_PiggTool
        Implements IDisposable

#Region "Properties"
        Property Content As COH_Pigg_Info
            Get
                Return mPiggInfo
            End Get
            Set(value As COH_Pigg_Info)
                mPiggInfo = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mPiggInfo As COH_Pigg_Info
        Private mCurrentReader As COH_BinaryReader
        Private mValid As Boolean
#End Region

#Region "Create New Instance"
        Sub New()
            PrepareUsage()
        End Sub
        Public Function OpenExisting_PiggFile(FilePath As String, Optional ShowProgress As Boolean = False) As Boolean
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Open)
            mCurrentReader = New COH_BinaryReader(CurrentStream, Text.Encoding.ASCII)
            mValid = Create_FromStream(IO.Path.GetFileName(FilePath), mCurrentReader, mPiggInfo, ShowProgress)
            Return mValid
        End Function
#End Region

#Region "Initialize"
        Private Sub PrepareUsage()
        End Sub
#End Region

#Region "Extraction"
        Public Function ExtractAllFiles_ToDirectory(RootPath As String, Optional ProcessRecord As Boolean = False, Optional ShowProgress As Boolean = False) As Boolean
            ExtractAllFiles_ToDirectory(mCurrentReader, RootPath, mPiggInfo, ProcessRecord, ShowProgress)
            Return True
        End Function
        Public Function ExtractEntry(Index As Integer, ByRef Result As COH_FileStructure) As Boolean
            Return Extract_Entry(mCurrentReader, mPiggInfo, Index, Result)
        End Function
#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls
        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    mCurrentReader.Close()
                    mCurrentReader = Nothing
                End If
            End If
            Me.disposedValue = True
        End Sub
        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace