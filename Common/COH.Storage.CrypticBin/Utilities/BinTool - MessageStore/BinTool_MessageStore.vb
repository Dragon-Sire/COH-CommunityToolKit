Imports COH.GameContent.MessageStores.Structures.LanguageFiles
Imports COH.Storage.Serialization
Imports COH.Storage.Structures

Namespace Utilities
    Public NotInheritable Class COH_BinTool_MessageStore
        Implements IDisposable

#Region "Properties"
        Property MessageStore As COH_MessageStore
            Get
                Return mMessageStore
            End Get
            Set(value As COH_MessageStore)
                mMessageStore = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mMessageStore As COH_MessageStore
        Private mCurrentReader As COH_BinaryReader
        Private mValid As Boolean
#End Region

#Region "Create New Instance"
        Sub New()
        End Sub
        Sub New(FilePath As String, Optional ShowProgress As Boolean = False)
            Dim CurrentStream As New IO.FileStream(FilePath, IO.FileMode.Open)
            mCurrentReader = New COH_BinaryReader(CurrentStream, Text.Encoding.UTF8)
            mValid = Create_FromStream(IO.Path.GetFileName(FilePath), mCurrentReader, mMessageStore, ShowProgress)
        End Sub
        Sub New(Name As String, ByRef CurrentReader As COH_BinaryReader, Optional ShowProgress As Boolean = False)
            mCurrentReader = CurrentReader
            mValid = Create_FromStream(Name, CurrentReader, mMessageStore, ShowProgress)
        End Sub
        Public Function OpenExisting_MessageStore(Name As String, ByRef Bytes As Byte(), Optional ShowProgress As Boolean = False) As Boolean
            Dim CurrentStream As New IO.MemoryStream(Bytes)
            mCurrentReader = New COH_BinaryReader(CurrentStream, Text.Encoding.UTF8)
            mValid = Create_FromStream(Name, mCurrentReader, mMessageStore, ShowProgress)
            Return mValid
        End Function
#End Region

#Region "Export"
        Public Function ExtractFromBin_WriteXML(Folder As String, Optional ShowProgress As Boolean = True) As Boolean
            Return mMessageStore.Export_To_XMLFile(Folder & mMessageStore.Name & ".xml")
        End Function
#End Region


        Public Function RebuildBin(ByRef CurrentWriter As COH_BinaryWriter, ByRef Sources() As COH_FileStructure) As Boolean
            Throw New NotImplementedException()
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    If Not (mCurrentReader Is Nothing) Then mCurrentReader.Dispose()
                End If
                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            ' TODO: uncomment the following line if Finalize() is overridden above.
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region


    End Class
End Namespace