Imports COH.Accounts
Imports COH.CodeManagement.Enums.Accounts

Namespace GameServers.AccountServer
    Partial Public Class Accounts_Controller


        Friend Shared Sub AccountDb_Send(ByRef Account As PlayerAccount)
            ' Dim pak_out As Packet
            Dim i As Integer
            Dim size As Integer

            'If Not SAFE_MEMBER(Account.shard, link.connected) Then
            'Return
            'E 'nd If

            ' send back account and inventory information
            'pak_out = pktCreateEx(Account.shard.link, ACCOUNT_SVR_INVENTORY)
            'pktSendBitsAuto(pak_out, account.Auth_ID)

            'size = eaSize(Account.invSet.invArr)
            'pktSendBitsAuto(pak_out, size)
            For i = 0 To size - 1
                '    AccountInventorySendItem(pak_out, Account.invSet.invArr(i))
            Next i

            'pktSendBits(pak_out, 1, If(g_accountServerState.cfg.bFreeShardXfersOnlyEnabled, 1, 0))
            'pktSendBitsAuto(pak_out, updateShardXferTokenCount(account))
            'pktSendBitsArray(pak_out, LOYALTY_BITS, AccountDb_GetLoyaltyBits(account))
            'pktSendBitsAuto(pak_out, account.loyaltyPointsUnspent)
            'pktSendBitsAuto(pak_out, account.loyaltyPointsEarned)
            'pktSendBitsAuto(pak_out, account.virtualCurrencyBal)
            'pktSendBitsAuto(pak_out, account.lastEmailTime)
            'pktSendBitsAuto(pak_out, account.lastNumEmailsSent)
            'pktSend(pak_out, account.shard.link)
        End Sub
        Public Shared Function AccountDb_Tick() As Boolean
            Dim prev As PlayerAccount = Nothing
            Dim [next] As PlayerAccount = Nothing
            Dim account As PlayerAccount = Accounts_Controller.Instance.NextAccount
            Do
                [next] = account.NextUpdate

                If (account.NextUpdate_Flags And AccountUpdateFlags.ACCOUNTDB_UPDATE_SQL_ACCOUNT) <> 0 Then
                    AccountDb_CommitAsync(account)
                    account.NextUpdate_Flags = account.NextUpdate_Flags And Not AccountUpdateFlags.ACCOUNTDB_UPDATE_SQL_ACCOUNT
                End If

                If (account.NextUpdate_Flags And AccountUpdateFlags.ACCOUNTDB_UPDATE_NETWORK) <> 0 AndAlso AccountDb_IsDataLoaded(account) Then
                    AccountDb_Send(account)
                    account.NextUpdate_Flags = account.NextUpdate_Flags And Not AccountUpdateFlags.ACCOUNTDB_UPDATE_NETWORK
                End If

                If Not account.NextUpdate_Flags Then
                    ' remove from dirty list
                    account.PrepareNextUpdate(Nothing)
                    If prev Is Nothing Then
                        Accounts_Controller.Instance.NextAccount = [next]
                    Else
                        account.PrepareNextUpdate([next])
                    End If
                Else
                    prev = account
                End If
                account = [next]
                If account Is Nothing Then Exit Do
            Loop
            Return (Accounts_Controller.Instance.NextAccount Is Nothing)
        End Function
        Public Shared Function AccountDb_IsDataLoaded(ByRef Account As PlayerAccount) As Boolean
            Return Account.StorageAccount IsNot Nothing
        End Function
        Public Shared Sub AccountDb_WaitFor(ByRef Account As PlayerAccount)
            'devassertmsg(Account.asql, "Performance Warning: AccountDb_WaitFor is going to block because the account data has not arrived yet")
            'Do While Not Account.asql
            'asql_wait_for_tick()
            'Loop
        End Sub
        Public Shared Function AccountDb_GetLoyaltyBits(ByRef Account As PlayerAccount) As Byte
            AccountDb_WaitFor(Account)
            'Return Account.asql.loyalty_bits
        End Function
        Public Shared Sub AccountDb_MarkUpdate(ByRef Account As PlayerAccount, ByVal addFlags As AccountUpdateFlags)
            Debug.Assert(addFlags)

            ' It is invalid to update the account before it has been retrieved
            If addFlags.HasFlag(AccountUpdateFlags.ACCOUNTDB_UPDATE_SQL_ACCOUNT) Then
                'Debug.Assert(Account.asql)
            End If

            If Not Account.NextUpdate_Flags Then
                ' Insert at linked list head
                Account.PrepareNextUpdate(Accounts_Controller.Instance.NextAccount)
                Accounts_Controller.Instance.NextAccount = Account
            End If

            Account.NextUpdate_Flags = (Account.NextUpdate_Flags Or addFlags)
        End Sub
        Public Shared Sub AccountDb_CommitAsync(ByRef Account As PlayerAccount)
            'Debug.Assert(Account.asql)
            'Account.asql.last_loyalty_point_count = Account.loyaltyPointsEarned
            'Account.asql.loyalty_points_spent = Account.loyaltyPointsEarned - Account.loyaltyPointsUnspent
            'timerMakeSQLTimestampFromSecondsSince2000(Account.lastEmailTime, Account.asql.last_email_date)
            'Account.asql.last_num_emails_sent = Account.lastNumEmailsSent
            'timerMakeSQLTimestampFromMonthsSinceZero(Account.freeXferMonths, Account.asql.free_xfer_date)

            ' This is difficult to check inside SQL so do the check here
            'devassert(Account.asql.loyalty_points_spent >= accountLoyaltyRewardGetNodesBought(Account.asql.loyalty_bits))
            'asql_update_account_async(Account)
        End Sub
    End Class
End Namespace
