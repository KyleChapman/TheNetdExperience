<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWhiteboard
    Inherits System.Windows.Forms.Form

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
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.pbxCanvas = New System.Windows.Forms.PictureBox()
        CType(Me.pbxCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxCanvas
        '
        Me.pbxCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxCanvas.Location = New System.Drawing.Point(0, 0)
        Me.pbxCanvas.Name = "pbxCanvas"
        Me.pbxCanvas.Size = New System.Drawing.Size(384, 261)
        Me.pbxCanvas.TabIndex = 1
        Me.pbxCanvas.TabStop = False
        '
        'frmWhiteboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.pbxCanvas)
        Me.Name = "frmWhiteboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kyle's Whiteboard"
        CType(Me.pbxCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sfdSaveAs As SaveFileDialog
    Friend WithEvents pbxCanvas As PictureBox
End Class
