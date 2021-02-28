Namespace GameServers.AccountServer.Transactions
    Public MustInherit Class Transaction

#Region "Properties"
        Public ReadOnly Property PlayerAccount As GameAccount
            Get
                Return pPlayerAccount
            End Get
        End Property
        Public ReadOnly Property Valid As Boolean
            Get
                Return pValidCheck
            End Get
        End Property
        Private pPlayerAccount As GameAccount
        Private pValidCheck As Boolean
#End Region

#Region "Initialize"
        Public Sub New(ByRef SelectedAccount As GameAccount)
            pPlayerAccount = SelectedAccount
        End Sub
        Private Sub SetDefaults()
            pValidCheck = False
        End Sub
#End Region

#Region "Validation"
        Protected Sub CheckValid()
            pValidCheck = PerformCheckValid()
        End Sub
        Protected Sub UpdateValid(IsValid As Boolean, Message As String)

        End Sub
        Protected MustOverride Function PerformCheckValid() As Boolean
#End Region



        Private Shared Sub Transaction_SetTransactionDate(ByRef TransactionTime As SQL_TIMESTAMP_STRUCT)
            Dim CurrentTime As Date = Date.Now
            TransactionTime.year = CurrentTime.Year
            TransactionTime.month = CurrentTime.Month
            TransactionTime.day = CurrentTime.Day
            TransactionTime.hour = CurrentTime.Hour
            TransactionTime.minute = CurrentTime.Minute
            TransactionTime.second = CurrentTime.Second
            TransactionTime.fraction = CurrentTime.Millisecond * 1000000UI
        End Sub
        Private Shared Sub Transaction_SetTransactionDate_FromUnixTimeString(ByRef TransactionTime As SQL_TIMESTAMP_STRUCT, ByVal TimeString As String)
            '//Get Unix String to UINT64 , Convert to Time then Adjust
            'TransactionTime.year = CType(tm.tm_year + 1900, UInt16)
            'TransactionTime.month = CType(tm.tm_mon + 1, UInt16)
            'TransactionTime.day = CType(tm.tm_mday, UInt16)
            'TransactionTime.hour = CType(tm.tm_hour, UInt16)
            'TransactionTime.minute = CType(tm.tm_min, UInt16)
            'TransactionTime.second = CType(tm.tm_sec, UInt16)
            'TransactionTime.fraction = 0
        End Sub



    End Class
End Namespace
