Namespace GameContent.MessageStores.LanguageFiles.Folders
    <HideModuleName> Public Module COH_RebuildFolders

        Public Sub Rebuild_FolderStructure()

        End Sub


        'Private cmdMessages As COH_MessageStore
        ' Private texWordsMessages As COH_MessageStore
        'Private loadingTipMessages As COH_MessageStore

        Private Sub reloadClientMessageStores(ByVal localeID As Integer)
            Static inited As Boolean = False

            Dim ppchMessageFiles() As String = Nothing
            Dim ppchMessageDirs() As String = Nothing
            Dim ppchTexWordsFiles() As String = Nothing
            Dim ppchLoadingTipFiles() As String = Nothing
            Dim pchCmdMessageFile As String = Nothing
            Dim idPrepend As String = Nothing
            '   Dim flags As MessageStoreLoadFlags = If(game_state.create_bins, MSLOAD_FORCEBINS, MSLOAD_DEFAULT)
            'C++ TO VB CONVERTER TODO TASK: VB does not have an equivalent for pointers to value types:
            'ORIGINAL LINE: SByte *loc_name = locGetName(localeID);
            '  Dim loc_name As SByte = locGetName(localeID)

            '            If game_state.skin = UISKIN_VILLAINS Then
            ''           idPrepend = "v_"
            '           ElseIf game_state.skin = UISKIN_PRAETORIANS Then
            '           idPrepend = "p_"
            '          End If

            ' generate the list of files/folders
            'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
            'ORIGINAL LINE: #define estr_print(dst,src) estrPrintf(&dst,"texts\%s\%s",loc_name,src)
#Const estr_print = True
            'C++ TO VB CONVERTER NOTE: The following #define macro was replaced in-line:
            'ORIGINAL LINE: #define push_estr(ea,str) { char *temp_str = NULL; estrPrintf(&temp_str,"texts\%s\%s",loc_name,str); eaPush(&ea,temp_str); }
#Const push_estr = True

            '        Dim temp_str As String = Nothing
            '       estrPrintf(temp_str, "texts\%s\%s", loc_name, "menuMessages.ms")
            ''       eaPush(ppchMessageFiles, temp_str)
            '       eaPush(ppchMessageFiles, estrCloneCharString("texts\menuMessages.types"))
            '       Dim temp_str As String = Nothing
            ''      estrPrintf(temp_str, "texts\%s\%s", loc_name, "v_menuMessages.ms")
            '      eaPush(ppchMessageFiles, temp_str)
            '      eaPush(ppchMessageFiles, estrCloneCharString("texts" & ControlChars.VerticalTab & "_menuMessages.types"))
            ''     Dim temp_str As String = Nothing
            '     estrPrintf(temp_str, "texts\%s\%s", loc_name, "Inventions\Salvage.xls.ms")
            '    eaPush(ppchMessageFiles, temp_str)
            ''    eaPush(ppchMessageFiles, Nothing)
            '   Dim temp_str As String = Nothing
            '   estrPrintf(temp_str, "texts\%s\%s", loc_name, "Inventions\Salvage_rewards.xls.ms")
            ''       eaPush(ppchMessageFiles, temp_str)
            '       eaPush(ppchMessageFiles, Nothing)
            '      Dim temp_str As String = Nothing
            ''      estrPrintf(temp_str, "texts\%s\%s", loc_name, "powerThemes.ms")
            '      eaPush(ppchMessageFiles, temp_str)
            ''      eaPush(ppchMessageFiles, Nothing)
            '
            'If Not IsUsingCider() Then
            '       ' PC versions
            ''      ' For creating ENGLIGH bins, load both UK and NA EULAs and NDAs
            '      If game_state.create_bins AndAlso localeID = LOCALE_ID_ENGLISH Then
            '     Dim temp_str As String = Nothing
            ''     estrPrintf(temp_str, "texts\%s\%s", loc_name, "eula-uk.ms")
            ''    eaPush(ppchMessageFiles, temp_str)
            '   eaPush(ppchMessageFiles, Nothing)
            '''   Dim temp_str As String = Nothing
            '  estrPrintf(temp_str, "texts\%s\%s", loc_name, "nda-uk.ms")
            '' eaPush(ppchMessageFiles, temp_str)
            '' eaPush(ppchMessageFiles, Nothing)
            '        Dim temp_str As String = Nothing
            '        estrPrintf(temp_str, "texts\%s\%s", loc_name, "eula.ms")
            '       eaPush(ppchMessageFiles, temp_str)
            ''       eaPush(ppchMessageFiles, Nothing)
            '       Dim temp_str As String = Nothing
            ''      estrPrintf(temp_str, "texts\%s\%s", loc_name, "nda.ms")
            '     eaPush(ppchMessageFiles, temp_str)
            ''     eaPush(ppchMessageFiles, Nothing)
            ''    ElseIf locIsBritish(localeID) Then
            '    ' Handle UK specific EULA/NDA
            '   Dim temp_str As String = Nothing
            ''   estrPrintf(temp_str, "texts\%s\%s", loc_name, "eula-uk.ms")
            '''  eaPush(ppchMessageFiles, temp_str)
            '  eaPush(ppchMessageFiles, Nothing)
            ' Dim temp_str As String = Nothing
            '    estrPrintf(temp_str, "texts\%s\%s", loc_name, "nda-uk.ms")
            '    eaPush(ppchMessageFiles, temp_str)
            '    eaPush(ppchMessageFiles, Nothing)
            ''   Else
            ''   Dim temp_str As String = Nothing
            ' estrPrintf(temp_str, "texts\%s\%s", loc_name, "eula.ms")
            '' eaPush(ppchMessageFiles, temp_str)
            '          eaPush(ppchMessageFiles, Nothing)
            '          Dim temp_str As String = Nothing
            ''         estrPrintf(temp_str, "texts\%s\%s", loc_name, "nda.ms")
            '         eaPush(ppchMessageFiles, temp_str)
            ''        eaPush(ppchMessageFiles, Nothing)
            '        End If
            ''       Else
            '       ' Mac versions
            '      ' We should not be creating bins on the Mac so we don't need the extra logic from above
            ''      devassert((Not game_state.create_bins))
            '    '      If locIsBritish(localeID) Then
            '          ' Handle UK specific EULA/NDA
            '          Dim temp_str As String = Nothing
            '          estrPrintf(temp_str, "texts\%s\%s", loc_name, "eula-uk-mac.ms")
            '         eaPush(ppchMessageFiles, temp_str)
            ''         eaPush(ppchMessageFiles, Nothing)
            '        Dim temp_str As String = Nothing
            ''        estrPrintf(temp_str, "texts\%s\%s", loc_name, "nda-uk-mac.ms")
            '        eaPush(ppchMessageFiles, temp_str)
            '       eaPush(ppchMessageFiles, Nothing)
            ''       Else
            '       Dim temp_str As String = Nothing
            '''      estrPrintf(temp_str, "texts\%s\%s", loc_name, "eula-mac.ms")
            '     eaPush(ppchMessageFiles, temp_str)
            '     eaPush(ppchMessageFiles, Nothing)
            ''     Dim temp_str As String = Nothing
            '     estrPrintf(temp_str, "texts\%s\%s", loc_name, "nda-mac.ms")
            '    eaPush(ppchMessageFiles, temp_str)
            ''    eaPush(ppchMessageFiles, Nothing)
            ''    End If
            '    End If
            '
            '            eaPush(ppchMessageFiles, Nothing)
            '
            ''            Dim temp_str As String = Nothing
            '           estrPrintf(temp_str, "texts\%s\%s", loc_name, "powers")
            '           eaPush(ppchMessageDirs, temp_str)
            ''           Dim temp_str As String = Nothing
            '          estrPrintf(temp_str, "texts\%s\%s", loc_name, "badges")
            '          eaPush(ppchMessageDirs, temp_str)
            '          Dim temp_str As String = Nothing
            '          estrPrintf(temp_str, "texts\%s\%s", loc_name, "PopHelp")
            '          eaPush(ppchMessageDirs, temp_str)
            '          Dim temp_str As String = Nothing
            '          estrPrintf(temp_str, "texts\%s\%s", loc_name, "classes")
            '          eaPush(ppchMessageDirs, temp_str)
            '         Dim temp_str As String = Nothing
            ''         estrPrintf(temp_str, "texts\%s\%s", loc_name, "origins")
            '         eaPush(ppchMessageDirs, temp_str)
            '         Dim temp_str As String = Nothing
            '        estrPrintf(temp_str, "texts\%s\%s", loc_name, "boostset")
            '        eaPush(ppchMessageDirs, temp_str)
            '        Dim temp_str As String = Nothing
            '         estrPrintf(temp_str, "texts\%s\%s", loc_name, "attribs")
            '         eaPush(ppchMessageDirs, temp_str)
            '        Dim temp_str As String = Nothing
            '        estrPrintf(temp_str, "texts\%s\%s", loc_name, "costume")
            ''        eaPush(ppchMessageDirs, temp_str)
            '      Dim temp_str As String = Nothing
            ''      estrPrintf(temp_str, "texts\%s\%s", loc_name, "bases")
            '      eaPush(ppchMessageDirs, temp_str)
            '     Dim temp_str As String = Nothing
            '      estrPrintf(temp_str, "texts\%s\%s", loc_name, "defs")
            '        ''      eaPush(ppchMessageDirs, temp_str)
            '        Dim temp_str As String = Nothing
            ''       estrPrintf(temp_str, "texts\%s\%s", loc_name, "cards")
            '       eaPush(ppchMessageDirs, temp_str)
            '       Dim temp_str As String = Nothing
            '       estrPrintf(temp_str, "texts\%s\%s", loc_name, "villains")
            '       eaPush(ppchMessageDirs, temp_str)
            ''
            'D 'im temp_str As String = Nothing
            ''          estrPrintf(temp_str, "texts\%s\%s", loc_name, "Player_Created")
            '         eaPush(ppchMessageDirs, temp_str)
            '         eaPush(ppchMessageDirs, Nothing)

            '            Dim temp_str As String = Nothing
            ''           estrPrintf(temp_str, "texts\%s\%s", loc_name, "textureWords.ms")
            '           eaPush(ppchTexWordsFiles, temp_str)
            ''          eaPush(ppchTexWordsFiles, Nothing)
            '          Dim temp_str As String = Nothing
            '         estrPrintf(temp_str, "texts\%s\%s", loc_name, "v_textureWords.ms")
            ''         eaPush(ppchTexWordsFiles, temp_str)
            ''        eaPush(ppchTexWordsFiles, Nothing)
            ''       eaPush(ppchTexWordsFiles, Nothing)

            ''            Dim temp_str As String = Nothing
            '      estrPrintf(temp_str, "texts\%s\%s", loc_name, "loadingTips.ms")
            '     '         eaPush(ppchLoadingTipFiles, temp_str)
            '    '        eaPush(ppchLoadingTipFiles, Nothing)
            '       eaPush(ppchLoadingTipFiles, Nothing)
            '
            '         estrPrintf(pchCmdMessageFile, "texts\%s\%s", loc_name, "cmdMessagesClient.ms")
            '
            '
            ' do the actu'al loading
            ''         LoadMessageStore(menuMessages, ppchMessageFiles, ppchMessageDirs, localeID, idPrepend, "clientmessages", Nothing, flags)
            ''         installCustomMessageStoreHandlers(menuMessages)
            '
            '        LoadMessageStore(texWordsMessages, ppchTexWordsFiles, Nothing, localeID, idPrepend, Nothing, Nothing, MSLOAD_EXTENDED)
            ''       LoadMessageStore(loadingTipMessages, ppchLoadingTipFiles, Nothing, localeID, idPrepend, "loadingtipmessages", Nothing, flags)
            '
            '            msCreateCmdMessageStore(pchCmdMessageFile, localeID)
            '
            ''
            ' cleanup
            ' eaDestroyEx(ppchMessageFiles, estrDestroyUnsafe)
            ' eaDestroyEx(ppchMessageDirs, estrDestroyUnsafe)
            ''eaDestroyEx(ppchTexWordsFiles, estrDestroyUnsafe)
            'e 'aDestroyEx(ppchLoadingTipFiles, estrDestroyUnsafe)
            'estrDestroy(pchCmdMessageFile)


            '      ' setup reloading
            '      If (Not inited) AndAlso (Not game_state.texWordEdit) Then
            ''     Dim localePath As New String(New Char(1999) {})
            '     inited = True
            '     localePath = String.Format("texts/{0}/*.ms", loc_name)
            '    FolderCacheSetCallback(FOLDER_CACHE_CALLBACK_UPDATE, localePath, reloadTextCallback)
            ''    FolderCacheSetCallback(FOLDER_CACHE_CALLBACK_UPDATE, "texts/*.types", reloadTextCallback)
            '   End If
        End Sub


        Private Sub reloadTextCallback(ByVal relpath As String, ByVal [when] As Integer)
            '      Dim [loop] As Boolean
            '      Dim count As Integer = 0
            '      Do
            ''     [loop] = False
            '     fileWaitForExclusiveAccess(relpath)
            '    errorLogFileIsBeingReloaded(relpath)
            ''    If Not fileExists(relpath) Then
            '    [loop] = True
            ''   count += 1
            '   Sleep(10)
            '   End If
            '   Loop While [loop] AndAlso count < 25
            '   reloadClientMessageStores(getCurrentLocale())
        End Sub







    End Module
End Namespace