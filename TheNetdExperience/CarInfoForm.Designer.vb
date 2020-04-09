<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarInfo))
        Me.lbMakePrompt = New System.Windows.Forms.Label()
        Me.cboMake = New System.Windows.Forms.ComboBox()
        Me.lblModelPrompt = New System.Windows.Forms.Label()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.lblYearPrompt = New System.Windows.Forms.Label()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.lblPricePrompt = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCarList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpListTips = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMakePrompt
        '
        Me.lbMakePrompt.Location = New System.Drawing.Point(224, 6)
        Me.lbMakePrompt.Name = "lbMakePrompt"
        Me.lbMakePrompt.Size = New System.Drawing.Size(50, 25)
        Me.lbMakePrompt.TabIndex = 0
        Me.lbMakePrompt.Text = "&Make:"
        Me.lbMakePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboMake
        '
        Me.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMake.FormattingEnabled = True
        Me.cboMake.Items.AddRange(New Object() {"Chevrolet", "Chrysler", "Dodge", "Ford", "GMC", "Honda", "Hyundai", "Kia"})
        Me.cboMake.Location = New System.Drawing.Point(280, 8)
        Me.cboMake.Name = "cboMake"
        Me.cboMake.Size = New System.Drawing.Size(121, 21)
        Me.cboMake.TabIndex = 1
        Me.ttpListTips.SetToolTip(Me.cboMake, "Select a manufacturer for the car")
        '
        'lblModelPrompt
        '
        Me.lblModelPrompt.Location = New System.Drawing.Point(224, 36)
        Me.lblModelPrompt.Name = "lblModelPrompt"
        Me.lblModelPrompt.Size = New System.Drawing.Size(50, 25)
        Me.lblModelPrompt.TabIndex = 2
        Me.lblModelPrompt.Text = "Mode&l:"
        Me.lblModelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(280, 39)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(120, 20)
        Me.tbModel.TabIndex = 3
        Me.ttpListTips.SetToolTip(Me.tbModel, "Enter a model for the car")
        '
        'lblYearPrompt
        '
        Me.lblYearPrompt.Location = New System.Drawing.Point(224, 66)
        Me.lblYearPrompt.Name = "lblYearPrompt"
        Me.lblYearPrompt.Size = New System.Drawing.Size(50, 25)
        Me.lblYearPrompt.TabIndex = 4
        Me.lblYearPrompt.Text = "&Year:"
        Me.lblYearPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(280, 69)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.Size = New System.Drawing.Size(120, 20)
        Me.nudYear.TabIndex = 5
        Me.ttpListTips.SetToolTip(Me.nudYear, "Select or enter the year the car was made")
        Me.nudYear.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(280, 99)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(120, 20)
        Me.tbPrice.TabIndex = 7
        Me.ttpListTips.SetToolTip(Me.tbPrice, "Enter a price for the car")
        '
        'lblPricePrompt
        '
        Me.lblPricePrompt.Location = New System.Drawing.Point(224, 96)
        Me.lblPricePrompt.Name = "lblPricePrompt"
        Me.lblPricePrompt.Size = New System.Drawing.Size(50, 25)
        Me.lblPricePrompt.TabIndex = 6
        Me.lblPricePrompt.Text = "&Price:"
        Me.lblPricePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Checked = True
        Me.chkNew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNew.Location = New System.Drawing.Point(242, 127)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(51, 17)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.ttpListTips.SetToolTip(Me.chkNew, "Check if the car is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCarList
        '
        Me.lvwCarList.CheckBoxes = True
        Me.lvwCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCarList.FullRowSelect = True
        Me.lvwCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarList.Location = New System.Drawing.Point(13, 154)
        Me.lvwCarList.MultiSelect = False
        Me.lvwCarList.Name = "lvwCarList"
        Me.lvwCarList.Size = New System.Drawing.Size(599, 171)
        Me.lvwCarList.TabIndex = 9
        Me.ttpListTips.SetToolTip(Me.lvwCarList, "Displays a list of all entered cars")
        Me.lvwCarList.UseCompatibleStateImageBehavior = False
        Me.lvwCarList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New?"
        '
        'colId
        '
        Me.colId.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 120
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 120
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 120
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(13, 332)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(598, 71)
        Me.lblResult.TabIndex = 10
        Me.ttpListTips.SetToolTip(Me.lblResult, "Outputs validation messages")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(156, 406)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 26)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.ttpListTips.SetToolTip(Me.btnEnter, "Click to validate and enter this car")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(262, 406)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 26)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.ttpListTips.SetToolTip(Me.btnReset, "Click to reset the form for a new entry")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(368, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 26)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.ttpListTips.SetToolTip(Me.btnExit, "Click to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInfo
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwCarList)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.lblPricePrompt)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.lblYearPrompt)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.lblModelPrompt)
        Me.Controls.Add(Me.cboMake)
        Me.Controls.Add(Me.lbMakePrompt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frmCarInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Info"
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMakePrompt As Label
    Friend WithEvents cboMake As ComboBox
    Friend WithEvents lblModelPrompt As Label
    Friend WithEvents tbModel As TextBox
    Friend WithEvents lblYearPrompt As Label
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents lblPricePrompt As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCarList As ListView
    Friend WithEvents lblResult As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpListTips As ToolTip
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
End Class
