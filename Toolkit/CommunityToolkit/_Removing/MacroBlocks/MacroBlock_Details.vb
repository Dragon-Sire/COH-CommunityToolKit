Namespace MacroBlocks
    Public NotInheritable Class MacroBlock_Detail

#Region "Properties"
        Property Name_Class As String
        Property Name_SubClass As String
        Property Name_SubClass2 As String
        Property Menu As Boolean
        Property Right As Boolean
        Property Bar As Boolean
        Property Range As String
        Property RangeName As String
        Property SpecialFunction As String
        Property ToolTip As String
#End Region

#Region "Create New Instance"
        Public Sub New()
            Me.New("New Class", "New Function", "")
        End Sub
        Public Sub New(Name As String, FunctionName As String, Tool_Tip As String)
            ResetDefaults()
            Name_Class = Name
            SpecialFunction = FunctionName
            ToolTip = Tool_Tip
        End Sub
#End Region

#Region "Initialize"
        Public Sub ResetDefaults()
            Menu = True
            Right = True
            Bar = False
            Name_SubClass = String.Empty
            Name_SubClass2 = String.Empty
            Range = String.Empty
            RangeName = String.Empty
            SpecialFunction = String.Empty
            ToolTip = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            Return Name_Class
        End Function
#End Region

    End Class
End Namespace
