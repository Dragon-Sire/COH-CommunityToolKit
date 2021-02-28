Namespace Toolkit.Controls.WinForms.UserControls
    Public Class COH_ProgressBar

#Region "Properties"
        Public Property ProgressBarColor() As Color
            Get
                Return mProgressBarColor
            End Get
            Set(ByVal Value As Color)
                mProgressBarColor = Value
                Invalidate()
            End Set
        End Property
        Public Property Maximum() As ULong
            Get
                Return mMaximumValue
            End Get
            Set(ByVal Value As ULong)
                Update_MaxValue(Value)
            End Set
        End Property
        Public Property Minimum() As ULong
            Get
                Return mMinimumValue
            End Get
            Set(ByVal Value As ULong)
                Update_MinValue(Value)
            End Set
        End Property
        Public Property Value() As ULong
            Get
                Return mCurrentValue
            End Get
            Set(ByVal Value As ULong)
                Update_CurrentValue(Value)
            End Set
        End Property
        Public Property [Step]() As ULong
            Get
                Return mStep
            End Get
            Set(ByVal Value As ULong)
                mStep = Value
            End Set
        End Property
#End Region

#Region "Private Properties"
       Private mStep As ULong = 0
       Private mMinimumValue As ULong = 0
       Private mMaximumValue As ULong = 100
       Private mCurrentValue As ULong = 0
       Private mProgressBarColor As Color = Color.Blue
#End Region

#Region "Update"
        Public Sub Increment(Amount As ULong)
            Update_CurrentValue(mCurrentValue + Amount)
        End Sub
        Public Sub StepIncrement()
            Update_CurrentValue(mCurrentValue + mStep)
        End Sub
        Private Sub Update_MaxValue(Value As ULong)
            If (Value < mMinimumValue) Then mMinimumValue = Value
            mMaximumValue = Value
            If (mCurrentValue > mMaximumValue) Then mCurrentValue = mMaximumValue
            Invalidate()
        End Sub
        Private Sub Update_MinValue(Value As ULong)
            If (Value < 0) Then mMinimumValue = 0
            If (Value > mMaximumValue) Then
                mMinimumValue = Value
                mMinimumValue = Value
            End If
            If (mCurrentValue < mMinimumValue) Then mCurrentValue = mMinimumValue
            Invalidate()
        End Sub
        Private Sub Update_CurrentValue(Value As ULong)
            Dim oldValue As Integer = mCurrentValue
            If (Value < mMinimumValue) Then
                mCurrentValue = mMinimumValue
            ElseIf (Value > mMaximumValue) Then
                mCurrentValue = mMaximumValue
            Else
                mCurrentValue = Value
            End If
            Dim percent As Decimal
            Dim newValueRect As Rectangle = Me.ClientRectangle
            Dim oldValueRect As Rectangle = Me.ClientRectangle
            percent = (mCurrentValue - mMinimumValue) / (mMaximumValue - mMinimumValue)
            newValueRect.Width = newValueRect.Width * percent
            percent = (oldValue - mMinimumValue) / (mMaximumValue - mMinimumValue)
            oldValueRect.Width = oldValueRect.Width * percent
            Dim updateRect As Rectangle = New Rectangle()
            If (newValueRect.Width > oldValueRect.Width) Then
                updateRect.X = oldValueRect.Size.Width
                updateRect.Width = newValueRect.Width - oldValueRect.Width
            Else
                updateRect.X = newValueRect.Size.Width
                updateRect.Width = oldValueRect.Width - newValueRect.Width
            End If
            updateRect.Height = Me.Height
            Invalidate(updateRect)
        End Sub
#End Region

#Region "Drawing Events"
        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            Invalidate()
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Dim CurrentGraphics As Graphics = e.Graphics
            Using TheBrush As SolidBrush = New SolidBrush(mProgressBarColor)
                Dim percent As Decimal = (mCurrentValue - mMinimumValue) / (mMaximumValue - mMinimumValue)
                Dim rect As Rectangle = ClientRectangle
                rect.Width = rect.Width * percent
                CurrentGraphics.FillRectangle(TheBrush, rect)
                Draw3DBorder(CurrentGraphics)
            End Using
            CurrentGraphics.Dispose()
        End Sub
        Private Sub Draw3DBorder(ByVal g As Graphics)
            Dim PenWidth As Integer = Pens.White.Width
            g.DrawLine(Pens.DarkGray,
            New Point(ClientRectangle.Left, ClientRectangle.Top),
            New Point(ClientRectangle.Width - PenWidth, ClientRectangle.Top))
            g.DrawLine(Pens.DarkGray,
            New Point(ClientRectangle.Left, ClientRectangle.Top),
            New Point(ClientRectangle.Left, ClientRectangle.Height - PenWidth))
            g.DrawLine(Pens.White,
            New Point(ClientRectangle.Left, ClientRectangle.Height - PenWidth),
            New Point(ClientRectangle.Width - PenWidth, ClientRectangle.Height - PenWidth))
            g.DrawLine(Pens.White,
            New Point(ClientRectangle.Width - PenWidth, ClientRectangle.Top),
            New Point(ClientRectangle.Width - PenWidth, ClientRectangle.Height - PenWidth))
        End Sub
#End Region
    End Class
End Namespace