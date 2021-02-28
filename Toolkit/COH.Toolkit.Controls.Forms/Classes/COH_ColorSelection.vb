Imports System.Reflection
Imports COH.GameContent.HelperClasses.Wrappers
Imports COH.HelperClasses.Wrappers

Namespace Toolkit.Controls.WinForms
    Public Class COH_ColorSelection
        Inherits ComboBox

#Region "Properties"
        Public ReadOnly Property SelectedColor As Color
            Get
                Return mSelectedColor
            End Get
        End Property
#End Region

#Region "Initialize"
        Public Sub New()
            MyBase.New
            DropDownStyle = ComboBoxStyle.DropDownList
            DrawMode = DrawMode.OwnerDrawFixed
            Items.Clear()
            ItemHeight = 20
            FillCombo()
        End Sub
        Private Sub FillCombo()
            BeginUpdate()
            Dim colType As Type = GetType(Color)
            Items.Add("Custom")
            For Each prop As PropertyInfo In colType.GetProperties()
                If prop.PropertyType Is GetType(Color) Then Items.Add(prop.Name)
            Next
            EndUpdate()
        End Sub
#End Region

#Region "Private Properties"
        Private mSelectedColor As Color
        Private mCustomColor As Color
#End Region

#Region "Usage"
        Public Sub Select_Color(TheColor As Color)
            For x = 0 To Items.Count - 1
                If Items(x).ToString = TheColor.Name Then
                    SelectedIndex = x
                End If
            Next
        End Sub
        Public Sub Select_Color(TheColor As COH_XML_Color)
            For x = 0 To Items.Count - 1
                If Items(x).ToString = TheColor.Color.Name Then
                    SelectedIndex = x
                    Exit Sub
                End If
            Next
            mCustomColor = TheColor
            For x = 0 To Items.Count - 1
                If Items(x).ToString = "Custom" Then
                    SelectedIndex = x
                    Exit Sub
                End If
            Next
        End Sub
#End Region

#Region "Drawing Events"
        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            Invalidate()
        End Sub
        Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
            If e.Index < 0 Then
                MyBase.OnDrawItem(e)
                Exit Sub
            End If
            e.DrawBackground()
            e.DrawFocusRectangle()
            Dim TheBrush As Brush
            If TypeOf (Items(e.Index)) Is COH_XML_Color Then
                TheBrush = New SolidBrush(mCustomColor)
                e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 25, e.Bounds.Height - 5)
                e.Graphics.FillRectangle(TheBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 24, e.Bounds.Height - 6)
                e.Graphics.DrawString("Custom", Font, Brushes.Black, 32, e.Bounds.Top + 2)
            Else
                TheBrush = New SolidBrush(Color.FromName(DirectCast(Items(e.Index), String)))
                e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 25, e.Bounds.Height - 5)
                e.Graphics.FillRectangle(TheBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 24, e.Bounds.Height - 6)
                e.Graphics.DrawString(Items(e.Index).ToString, Font, Brushes.Black, 32, e.Bounds.Top + 2)
            End If
        End Sub
        Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
            MyBase.OnSelectedIndexChanged(e)
            If Items(SelectedIndex) = "Custom " Then

            Else
                mSelectedColor = Color.FromName(Items(SelectedIndex))
            End If
        End Sub
#End Region
    End Class
End Namespace
