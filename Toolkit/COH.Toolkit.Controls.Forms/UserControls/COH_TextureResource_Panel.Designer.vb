Namespace Toolkit.Controls.WinForms.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class COH_TextureResource_Panel
        Inherits UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.MaterialList = New System.Windows.Forms.FlowLayoutPanel()
            Me.SuspendLayout()
            '
            'MaterialList
            '
            Me.MaterialList.AutoScroll = True
            Me.MaterialList.BackColor = System.Drawing.Color.White
            Me.MaterialList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MaterialList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.MaterialList.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaterialList.Location = New System.Drawing.Point(0, 0)
            Me.MaterialList.Name = "MaterialList"
            Me.MaterialList.Size = New System.Drawing.Size(390, 111)
            Me.MaterialList.TabIndex = 0
            Me.MaterialList.WrapContents = False
            '
            'COH_TextureResource_Panel
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.MaterialList)
            Me.Name = "COH_TextureResource_Panel"
            Me.Size = New System.Drawing.Size(390, 111)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MaterialList As FlowLayoutPanel
    End Class
End Namespace