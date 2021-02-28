Namespace Toolkit.Controls.WinForms.Dialogs
    Public Class COH_XML_Viewer

#Region "Initialize"
        Public Sub New()
            MyBase.New
            InitializeComponent()
            Update_Styles()
        End Sub
#End Region
        Public Sub ViewTex(ByRef Text As String, IsXML As Boolean)
            If IsXML = True Then
                ViewText_XML(Text)
            Else
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                FastColoredTextBox1.Text = Text
            End If
        End Sub
        Public Sub ViewText_XML(ByRef Text As String)
            FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML
            FastColoredTextBox1.Text = Text
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