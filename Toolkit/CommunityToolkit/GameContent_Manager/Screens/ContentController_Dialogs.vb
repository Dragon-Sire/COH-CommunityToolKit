Imports COH.GameContent.Internal.Events
Imports COH.Toolkit.Controls.WinForms.Dialogs

Namespace Internal.ContentController
    Partial Public NotInheritable Class COH_ContentController

#Region "Private Properties"
        Private mLastLocated As String = ""
#End Region


#Region "Simple Notifications"
        Public Sub HandleMessage(ByRef e As COH_Event_Message) Handles mEventController.MessageEvent
            If e.IsLargeMessage = True Then
                If e.IsXML = True Then
                    ViewXML(e.Message)
                Else
                    ViewText(e.Message)
                End If
            Else
                ShowMessage_Simple(e.Message)
            End If
        End Sub
        Public Sub ShowMessage_Simple(ByRef Message As String)
            MsgBox(Message, MsgBoxStyle.Information, "City of Heroes Community Toolkit (Alpha)")
        End Sub
        Public Sub ShowMessage_SimpleError(ByRef Message As String)
            MsgBox(Message, MsgBoxStyle.Exclamation, "City of Heroes Community Toolkit (Alpha)")
        End Sub
        Public Function ShowMessage_SimpleErrorException(ByRef Message As String, ByRef MessageException As Exception, Optional AllowContinue As Boolean = False) As Boolean
            Dim TheStyle As MsgBoxStyle = MsgBoxStyle.OkCancel
            If AllowContinue = False Then TheStyle = MsgBoxStyle.Exclamation
            If MessageException Is Nothing Then
                ShowMessage_Simple(Message)
                Return True
            Else
                Select Case MsgBox(Message & Environment.NewLine & MessageException.Message.ToString, TheStyle, "City of Heroes Community Toolkit (Alpha)")
                    Case MsgBoxResult.Ok
                        Return True
                    Case Else
                        Return False
                End Select
            End If
        End Function
        Public Function ShowQuestion_Simple(ByRef Message As String) As MsgBoxResult
            Return MsgBox(Message, MsgBoxStyle.YesNo, "City of Heroes Community Toolkit (Alpha)")
        End Function
#End Region

#Region "Other"
        Private Function LocateFile(FileName As String, Destination As String) As Boolean
            Dim Dialog = New OpenFileDialog()
            With Dialog
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "bin"
                .FileName = FileName
                .Filter = FileName & "|" & FileName 'Text files (*.txt)|*.txt|All files (*.*)|*.*"
                .FilterIndex = 0
                If String.IsNullOrEmpty(mLastLocated) = True Then
                    .InitialDirectory = IO.Path.GetDirectoryName(Destination)
                Else
                    .InitialDirectory = mLastLocated
                End If
                .Title = "Select File to Continue"
            End With
            Do
                Select Case Dialog.ShowDialog()
                    Case DialogResult.OK
                        If IO.Path.GetFileName(Dialog.FileName) = FileName Then
                            If IO.File.Exists(Dialog.FileName) = True Then
                                IO.File.Copy(Dialog.FileName, Destination)
                                mLastLocated = IO.Path.GetDirectoryName(Dialog.FileName)
                                Exit Do
                            End If
                        End If
                    Case Else
                        Return False
                End Select
            Loop
            Return True
        End Function
        Private Function OpenFile_PIGG(ByRef FileName As String) As Boolean
            Dim Dialog = New OpenFileDialog()
            With Dialog
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "pigg"
                .FileName = FileName
                .Filter = "PIGG (*.pigg)|*.pigg"
                .FilterIndex = 0
                '/.InitialDirectory = IO.Path.GetDirectoryName(Destination)
                .Title = "Select File to Continue"
            End With
            Do
                Select Case Dialog.ShowDialog()
                    Case DialogResult.OK
                        If IO.File.Exists(Dialog.FileName) Then
                            If IO.File.Exists(Dialog.FileName) = True Then
                                FileName = Dialog.FileName
                                Return True
                                Exit Do
                            End If
                        End If
                    Case Else
                        Return False
                End Select
            Loop
            Return True
        End Function
        Private Function OpenFile_BIN(ByRef FileName As String) As Boolean
            Dim Dialog = New OpenFileDialog()
            With Dialog
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "bin"
                .FileName = FileName
                .Filter = "BIN (*.bin)|*.bin"
                .FilterIndex = 0
                '/.InitialDirectory = IO.Path.GetDirectoryName(Destination)
                .Title = "Select File to Continue"
            End With
            Do
                Select Case Dialog.ShowDialog()
                    Case DialogResult.OK
                        If IO.File.Exists(Dialog.FileName) Then
                            If IO.File.Exists(Dialog.FileName) = True Then
                                FileName = Dialog.FileName
                                Return True
                                Exit Do
                            End If
                        End If
                    Case Else
                        Return False
                End Select
            Loop
            Return True
        End Function
        Private Function OpenFile_GEO(ByRef FileName As String) As Boolean
            Dim Dialog = New OpenFileDialog()
            With Dialog
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "geo"
                .FileName = FileName
                .Filter = "GEO (*.geo)|*.geo"
                .FilterIndex = 0
                .Title = "Select File to Continue"
            End With
            Do
                Select Case Dialog.ShowDialog()
                    Case DialogResult.OK
                        If IO.File.Exists(Dialog.FileName) Then
                            If IO.File.Exists(Dialog.FileName) = True Then
                                FileName = Dialog.FileName
                                Return True
                                Exit Do
                            End If
                        End If
                    Case Else
                        Return False
                End Select
            Loop
            Return True
        End Function
        Private Function OpenFile_Texture(ByRef FileName As String) As Boolean
            Dim Dialog = New OpenFileDialog()
            With Dialog
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "Textue"
                .FileName = FileName
                .Filter = "Texture (*.Texture)|*.texture"
                .FilterIndex = 0
                .Title = "Select File to Continue"
            End With
            Do
                Select Case Dialog.ShowDialog()
                    Case DialogResult.OK
                        If IO.File.Exists(Dialog.FileName) Then
                            If IO.File.Exists(Dialog.FileName) = True Then
                                FileName = Dialog.FileName
                                Return True
                                Exit Do
                            End If
                        End If
                    Case Else
                        Return False
                End Select
            Loop
            Return True
        End Function
#End Region

#Region "Prompts"
        Public Sub OpenDialog_Compare2Strings(ByRef e As GameContent.Internal.Events.COH_EventResponse_Compare2Items) Handles mEventController.Prompt_Compare2Items
            If Not mCurrentProgressForm Is Nothing Then
                mCurrentProgressForm.TopMost = False
            End If
            Dim NewEditor As New Dialog_Compare2Strings(Nothing)
            NewEditor.PrepareDialog(e.Prompt, e.Message1, e.Message2)
            If ShowWindow(NewEditor, True) = DialogResult.Yes Then
                e.Result = GameContent.Internal.Events.COH_EventResponse_Compare2Items.COH_ResponseEnum.Yes
            Else
                e.Result = GameContent.Internal.Events.COH_EventResponse_Compare2Items.COH_ResponseEnum.No
            End If
            If Not mCurrentProgressForm Is Nothing Then
                mCurrentProgressForm.TopMost = True
            End If
        End Sub
#End Region

#Region "Errors"
        Public Sub HandleError(ByRef e As COH_Event_Error) Handles mEventController.ErrorOccuredEvent
            Select Case e.ErrorLevel
                Case GameContent.Internal.Events.COH_Event_Error.COH_ErrorEvent.Debug
                    ShowMessage_SimpleError(e.Message)
                    e.AllowContinue = True
                    e.ThrowException = False
                Case GameContent.Internal.Events.COH_Event_Error.COH_ErrorEvent.ControlledError
                    'Controls.WinForms.Dialogs.COH_ErrorDialog.ShowErrorMessage(e)
                    e.AllowContinue = True
                    e.ThrowException = False
                Case GameContent.Internal.Events.COH_Event_Error.COH_ErrorEvent.FatalError
                    'Controls.WinForms.Dialogs.COH_ErrorDialog.ShowErrorMessage(e)
                    e.AllowContinue = False
                    e.ThrowException = False
            End Select
        End Sub
#End Region

    End Class
End Namespace