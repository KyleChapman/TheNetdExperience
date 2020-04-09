<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAwesomeness
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblAwesomenessPrompt = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo1 = New System.Windows.Forms.Button()
        Me.btnNo2 = New System.Windows.Forms.Button()
        Me.ttpAwesome = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblAwesomenessPrompt
        '
        Me.lblAwesomenessPrompt.Location = New System.Drawing.Point(10, 11)
        Me.lblAwesomenessPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAwesomenessPrompt.Name = "lblAwesomenessPrompt"
        Me.lblAwesomenessPrompt.Size = New System.Drawing.Size(193, 50)
        Me.lblAwesomenessPrompt.TabIndex = 0
        Me.lblAwesomenessPrompt.Text = "The computer has detected that you are awesome. Is it possible that you are aweso" &
    "me?"
        Me.lblAwesomenessPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(10, 85)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(56, 32)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "&Yes"
        Me.ttpAwesome.SetToolTip(Me.btnYes, "Click if you are awesome")
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo1
        '
        Me.btnNo1.Location = New System.Drawing.Point(78, 85)
        Me.btnNo1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNo1.Name = "btnNo1"
        Me.btnNo1.Size = New System.Drawing.Size(56, 32)
        Me.btnNo1.TabIndex = 2
        Me.btnNo1.Text = "&No"
        Me.ttpAwesome.SetToolTip(Me.btnNo1, "Click if you are not awesome")
        Me.btnNo1.UseVisualStyleBackColor = True
        '
        'btnNo2
        '
        Me.btnNo2.Location = New System.Drawing.Point(146, 85)
        Me.btnNo2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNo2.Name = "btnNo2"
        Me.btnNo2.Size = New System.Drawing.Size(56, 32)
        Me.btnNo2.TabIndex = 3
        Me.btnNo2.Text = "&No"
        Me.ttpAwesome.SetToolTip(Me.btnNo2, "Click if you are not awesome")
        Me.btnNo2.UseVisualStyleBackColor = True
        Me.btnNo2.Visible = False
        '
        'frmAwesomeness
        '
        Me.AcceptButton = Me.btnYes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 133)
        Me.Controls.Add(Me.btnNo2)
        Me.Controls.Add(Me.btnNo1)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblAwesomenessPrompt)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(229, 172)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(229, 172)
        Me.Name = "frmAwesomeness"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Awesomeness"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAwesomenessPrompt As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo1 As Button
    Friend WithEvents btnNo2 As Button
    Friend WithEvents ttpAwesome As ToolTip
End Class
