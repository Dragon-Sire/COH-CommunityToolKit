Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_FormWrapped_Bin_View
        Inherits Internal.COH_FormTemplate

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.CoH_Control_ViewBin1 = New UserControls.COH_Control_ViewBin(Me.ContentController)
            Me.SuspendLayout()
            '
            'CoH_Control_ViewBin1
            '
            Me.CoH_Control_ViewBin1.BackColor = System.Drawing.Color.CornflowerBlue
            Me.CoH_Control_ViewBin1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CoH_Control_ViewBin1.Location = New System.Drawing.Point(0, 0)
            Me.CoH_Control_ViewBin1.Name = "CoH_Control_ViewBin1"
            Me.CoH_Control_ViewBin1.Size = New System.Drawing.Size(1140, 484)
            Me.CoH_Control_ViewBin1.TabIndex = 0
            '
            'COH_BIN_View
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1140, 484)
            Me.Controls.Add(Me.CoH_Control_ViewBin1)
            Me.Name = "COH_BIN_View"
            Me.Text = "City of Heroes Tool Kit Bin Viewer"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents CoH_Control_ViewBin1 As UserControls.COH_Control_ViewBin
    End Class
End Namespace
