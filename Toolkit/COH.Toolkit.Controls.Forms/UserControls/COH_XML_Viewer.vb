Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_XML_Viewer

#Region "Properties"
        Public ReadOnly Property Content As String
            Get
                If TextBox1.Visible = True Then
                    Return TextBox1.Text
                Else
                    Return FastColoredTextBox1.Text
                End If
            End Get
        End Property
#End Region

#Region "Initialize"
        Public Sub New()
            MyBase.New
            InitializeComponent()
            Update_Styles()
        End Sub
#End Region

        Public Sub ViewText(ByRef Text As String)
            If Text.Length > 5000000 AndAlso Me.TextBox1.Visible = False Then
                Select Case MsgBox("Text is Quite Large do you want to view as text instead?", MsgBoxStyle.YesNo, "City of Heroes PortalCorp Toolkit")
                    Case MsgBoxResult.No
                        FastColoredTextBox1.Text = Text
                        Exit Sub
                    Case Else
                        TextBox1.Visible = True
                        TextBox1.Dock = DockStyle.Fill
                        TextBox1.Text = Text
                End Select
            ElseIf TextBox1.Visible = True Then
                TextBox1.Text = Text
            Else
                FastColoredTextBox1.Text = Text
            End If
        End Sub
        Private Sub Update_Styles()
            FastColoredTextBox1.SyntaxHighlighter.KeywordStyle = FastColoredTextBox1.SyntaxHighlighter.BlueBoldStyle
            FastColoredTextBox1.SyntaxHighlighter.ClassNameStyle = FastColoredTextBox1.SyntaxHighlighter.BlueBoldStyle
            FastColoredTextBox1.SyntaxHighlighter.StringStyle = FastColoredTextBox1.SyntaxHighlighter.BlueBoldStyle
            FastColoredTextBox1.SyntaxHighlighter.NumberStyle = FastColoredTextBox1.SyntaxHighlighter.RedStyle
            FastColoredTextBox1.SyntaxHighlighter.CommentStyle = FastColoredTextBox1.SyntaxHighlighter.BlueBoldStyle

            FastColoredTextBox1.SyntaxHighlighter.XmlAttributeStyle = FastColoredTextBox1.SyntaxHighlighter.RedStyle
            FastColoredTextBox1.SyntaxHighlighter.XmlAttributeValueStyle = FastColoredTextBox1.SyntaxHighlighter.BlueStyle

            FastColoredTextBox1.SyntaxHighlighter.XmlTagBracketStyle = FastColoredTextBox1.SyntaxHighlighter.BlackStyle
            FastColoredTextBox1.SyntaxHighlighter.XmlTagNameStyle = FastColoredTextBox1.SyntaxHighlighter.BlueStyle

            FastColoredTextBox1.SyntaxHighlighter.XmlCDataStyle = FastColoredTextBox1.SyntaxHighlighter.RedStyle

            FastColoredTextBox1.SyntaxHighlighter.XmlEntityStyle = FastColoredTextBox1.SyntaxHighlighter.RedStyle '//Special Characters
        End Sub
    End Class
End Namespace