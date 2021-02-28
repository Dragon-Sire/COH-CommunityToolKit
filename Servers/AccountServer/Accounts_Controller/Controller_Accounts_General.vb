Imports COH.Accounts

Namespace GameServers.AccountServer
    Partial Public Class Accounts_Controller

#Region "Create Player Account"
        Public Function Create_NewPlayerAccount(ByVal Auth_Id As UInt32, ByVal Auth_Name As String) As PlayerAccount
            Dim CurrentAccount As PlayerAccount = New PlayerAccount(Auth_Id, Auth_Name)
            pOnlineAccounts.Add(Auth_Id, CurrentAccount)
            '//ADD TO DATABASE
            Return CurrentAccount
        End Function
#End Region

#Region "Load Account"
        Public Function LoadAccount(Auth_Id As UInt32, ByRef Result As PlayerAccount) As Boolean
            If Find_OnlineAccount_FromID(Auth_Id, Result) = True Then
                Return True '//ALREADY ONLINE
            End If
            If Find_OfflineAccount_FromID(Auth_Id, Result) = False Then Return False
            Return True
        End Function
        Public Sub LoadAccount_Finished(ByRef Account As PlayerAccount)
            'Debug.Assert(Account.asql)
            '//Populate AuthName From SQL / DATABASE
            'account.Auth_Name = account.asql.name.Substring(0, sizeof(account.Auth_Name))
            If String.IsNullOrEmpty(Account.Auth_Name) Then
                ' Debug.Assert(stashAddPointer(adb.byAuthName, account.Auth_Name, account, True))
            End If

            ' This is difficult to check inside SQL so do the check here
            'devassert(account.asql.loyalty_points_spent >= accountLoyaltyRewardGetNodesBought(account.asql.loyalty_bits))

            'Populate From SQL / DATABASE
            'account.loyaltyPointsEarned = account.asql.last_loyalty_point_count
            'account.loyaltyPointsUnspent = account.loyaltyPointsEarned - account.asql.loyalty_points_spent
            'account.lastEmailTime = timerGetSecondsSince2000FromSQLTimestamp(account.asql.last_email_date)
            'account.lastNumEmailsSent = account.asql.last_num_emails_sent
            'account.freeXferMonths = timerGetMonthsSinceZeroFromSQLTimestamp(account.asql.free_xfer_date)

            ' CSR might be waiting for this account to load
            ' AccountServer_SlashNotifyAccountLoaded(Account)
        End Sub
#End Region

#Region "Lookup"
        Public Function Find_OnlineAccount_FromID(Auth_Id As UInt32, ByRef Result As PlayerAccount) As Boolean
            If pOnlineAccounts.TryGetValue(Auth_Id, Result) = False Then Return False
            '/CHECK IF DATABASE LOADED
            Return True
        End Function
        Public Function Find_OfflineAccount_FromID(Auth_Id As UInt32, ByRef Result As PlayerAccount) As Boolean
            '////asql_search_for_account_async(auth_name_or_id)
        End Function
        Public Function Check_NumberAccounts() As UInteger
            Return pOnlineAccounts.Count
        End Function
#End Region
    End Class
End Namespace
