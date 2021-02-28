Namespace Toolkit.Controls.WinForms.Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_3D_View
        Inherits WinForms.Internal.COH_FormTemplate

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COH_3D_View))
            Me.CoH_GeoModelViewer1 = New COH_GeoModelViewer(Me.ContentController)
            Me.SuspendLayout()
            '
            'CoH_GeoModelViewer1
            '
            Me.CoH_GeoModelViewer1.BackColor = System.Drawing.SystemColors.ControlText
            Me.CoH_GeoModelViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CoH_GeoModelViewer1.Location = New System.Drawing.Point(0, 0)
            Me.CoH_GeoModelViewer1.Name = "CoH_GeoModelViewer1"
            Me.CoH_GeoModelViewer1.Size = New System.Drawing.Size(1075, 641)
            Me.CoH_GeoModelViewer1.TabIndex = 0
            '
            'COH_3D_View
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1075, 641)
            Me.Controls.Add(Me.CoH_GeoModelViewer1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "COH_3D_View"
            Me.Text = "City of Heroes Community Toolkit - 3D Viewer"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents CoH_GeoModelViewer1 As COH_GeoModelViewer
    End Class
End Namespace