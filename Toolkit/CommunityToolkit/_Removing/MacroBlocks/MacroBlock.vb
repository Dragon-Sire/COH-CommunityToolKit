Namespace MacroBlocks
    Partial Public NotInheritable Class COH_MacroBlock

#Region "Properties"
        Public Property MenuName As String
            Get
                Return mMenuName
            End Get
            Set(value As String)
                mMenuName = value
            End Set
        End Property
        Public Property BarName As String
            Get
                Return mBarName
            End Get
            Set(value As String)
                mBarName = value
            End Set
        End Property
        Public Property Details As List(Of MacroBlock_Detail)
            Get
                Return mDetails
            End Get
            Set(value As List(Of MacroBlock_Detail))
                mDetails = value
            End Set
        End Property
#End Region

#Region "Private Properties"
        Private mMenuName As String
        Private mBarName As String
        Private mDetails As List(Of MacroBlock_Detail)
#End Region

#Region "Create New Instance"
        Public Sub New()
            Me.New("NewMenu", "NewBarName")
        End Sub
        Public Sub New(Menu_Name As String, Bar_Name As String)
            ResetDefaults()
            mMenuName = Menu_Name
            mBarName = Bar_Name
        End Sub
#End Region

#Region "Initialize"
        Public Sub ResetDefaults()
            mDetails = New List(Of MacroBlock_Detail)
        End Sub
        Public Overrides Function ToString() As String
            Return mMenuName
        End Function
#End Region

    End Class
End Namespace

