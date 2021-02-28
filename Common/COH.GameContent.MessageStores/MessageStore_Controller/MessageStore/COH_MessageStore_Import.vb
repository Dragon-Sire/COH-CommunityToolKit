Namespace GameContent.MessageStores.Structures.LanguageFiles
    Partial Public NotInheritable Class COH_MessageStore

#Region "Import MessageStore"
        Public Function Import_and_Compare(ByRef ImportSource As COH_MessageStore) As Boolean
            COH_LibraryEventController.ShowProgressUpdate(Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Begin, ImportSource.mMessageDetails.Count, "Importing MessageStore")
            Dim SaveRequired As Boolean = False
            Dim UpdateRequired As Boolean = False
            For Each Entry In ImportSource.mMessageDetails
                Dim OriginolEntry = RetrieveEntry(Entry.Key)
                Dim Message1 As String = ""
                Dim Message2 As String = ""
                If OriginolEntry Is Nothing Then
                    If COH_LibraryEventController.ShowPrompt_Override("(" & Entry.Value.MessageID & ") Message Does Not Exist!" & Environment.NewLine & " Do you want to Add this Entry?", "[NOT FOUND]", Message2) = True Then
                        OriginolEntry = AddNew_Entry_Message(Message2, Entry.Value.HelpMessage, Entry.Value.MessageID)
                        SaveRequired = True
                    End If
                Else
                    ImportSource.Update_ReferenceMap(Entry.Value)
                    Message1 = OriginolEntry.Message
                    Message2 = Entry.Value.Message
                    UpdateRequired = False
                    If Not Message1 = Message2 Then
                        If COH_LibraryEventController.ShowPrompt_Override("(" & Entry.Value.MessageID & ") Message already Exists!" & Environment.NewLine & " Do you want to replace existing Entry?", Message1, Message2) = True Then
                            OriginolEntry.Message = Message2
                            UpdateRequired = True
                        End If
                    End If
                    Message1 = OriginolEntry.HelpMessage
                    Message2 = Entry.Value.HelpMessage
                    If Not Message1 = Message2 Then
                        If COH_LibraryEventController.ShowPrompt_Override("(" & Entry.Value.MessageID & ") Help already Exists!" & Environment.NewLine & " Do you want to replace existing Entry?", Message1, Message2) = True Then
                            OriginolEntry.Message = Message2
                            UpdateRequired = True
                        End If
                    End If
                    If UpdateRequired = True Then
                        UpdateEntry(OriginolEntry.MessageID, OriginolEntry)
                        SaveRequired = True
                    End If
                End If
                COH_LibraryEventController.ShowProgressUpdate(Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Update, 1)
            Next
            If SaveRequired = True Then Save()
            COH_LibraryEventController.ShowProgressUpdate(Internal.Events.COH_Event_ProgressUpdate.COH_ProgressEvent.Finish)
            Return True
        End Function
#End Region

    End Class
End Namespace