<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenericMasterDataEntry
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
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.chkLinkLabel = New System.Windows.Forms.CheckBox()
        Me.lnkParent = New System.Windows.Forms.LinkLabel()
        Me.chkNumeric = New System.Windows.Forms.CheckBox()
        Me.txtAltName = New System.Windows.Forms.TextBox()
        Me.lblAltName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCombobox = New System.Windows.Forms.Label()
        Me.cboToStatus = New HR.SysComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudTemp = New HR.SysNumericUpDown()
        Me.tbpRemark = New System.Windows.Forms.TabPage()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.ucRecordInfo = New HR.ucRecordInformation()
        Me.tspMain.SuspendLayout()
        Me.tbc.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        CType(Me.nudTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpRemark.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspMain
        '
        Me.tspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose, Me.btnSave, Me.btnCancel})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(499, 39)
        Me.tspMain.TabIndex = 1
        Me.tspMain.Text = "ToolStrip1"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.HR.My.Resources.Resources.icoClose
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 36)
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.HR.My.Resources.Resources.icoSave
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 36)
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.HR.My.Resources.Resources.icoCancel
        Me.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 36)
        Me.btnCancel.Text = "&Cancel"
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.tbpHeader)
        Me.tbc.Controls.Add(Me.tbpRemark)
        Me.tbc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbc.Location = New System.Drawing.Point(0, 39)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(499, 377)
        Me.tbc.TabIndex = 2
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.chkLinkLabel)
        Me.tbpHeader.Controls.Add(Me.lnkParent)
        Me.tbpHeader.Controls.Add(Me.chkNumeric)
        Me.tbpHeader.Controls.Add(Me.txtAltName)
        Me.tbpHeader.Controls.Add(Me.lblAltName)
        Me.tbpHeader.Controls.Add(Me.txtName)
        Me.tbpHeader.Controls.Add(Me.Label2)
        Me.tbpHeader.Controls.Add(Me.lblCombobox)
        Me.tbpHeader.Controls.Add(Me.cboToStatus)
        Me.tbpHeader.Controls.Add(Me.txtID)
        Me.tbpHeader.Controls.Add(Me.Label1)
        Me.tbpHeader.Controls.Add(Me.nudTemp)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(491, 351)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'chkLinkLabel
        '
        Me.chkLinkLabel.AutoSize = True
        Me.chkLinkLabel.Enabled = False
        Me.chkLinkLabel.Location = New System.Drawing.Point(8, 72)
        Me.chkLinkLabel.Name = "chkLinkLabel"
        Me.chkLinkLabel.Size = New System.Drawing.Size(75, 17)
        Me.chkLinkLabel.TabIndex = 57
        Me.chkLinkLabel.Text = "Link Label"
        Me.chkLinkLabel.UseVisualStyleBackColor = True
        '
        'lnkParent
        '
        Me.lnkParent.AutoSize = True
        Me.lnkParent.Enabled = False
        Me.lnkParent.Location = New System.Drawing.Point(120, 73)
        Me.lnkParent.Name = "lnkParent"
        Me.lnkParent.Size = New System.Drawing.Size(104, 13)
        Me.lnkParent.TabIndex = 56
        Me.lnkParent.TabStop = True
        Me.lnkParent.Text = "Select Action Parent"
        Me.lnkParent.Visible = False
        '
        'chkNumeric
        '
        Me.chkNumeric.AutoSize = True
        Me.chkNumeric.Enabled = False
        Me.chkNumeric.Location = New System.Drawing.Point(8, 95)
        Me.chkNumeric.Name = "chkNumeric"
        Me.chkNumeric.Size = New System.Drawing.Size(65, 17)
        Me.chkNumeric.TabIndex = 50
        Me.chkNumeric.Text = "Numeric"
        Me.chkNumeric.UseVisualStyleBackColor = True
        '
        'txtAltName
        '
        Me.txtAltName.Enabled = False
        Me.txtAltName.Location = New System.Drawing.Point(123, 48)
        Me.txtAltName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtAltName.MaxLength = 1000
        Me.txtAltName.Name = "txtAltName"
        Me.txtAltName.Size = New System.Drawing.Size(362, 20)
        Me.txtAltName.TabIndex = 49
        Me.txtAltName.Visible = False
        '
        'lblAltName
        '
        Me.lblAltName.AutoSize = True
        Me.lblAltName.Location = New System.Drawing.Point(8, 51)
        Me.lblAltName.Name = "lblAltName"
        Me.lblAltName.Size = New System.Drawing.Size(80, 13)
        Me.lblAltName.TabIndex = 48
        Me.lblAltName.Text = "Alternate Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(123, 26)
        Me.txtName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtName.MaxLength = 1000
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(362, 20)
        Me.txtName.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Name"
        '
        'lblCombobox
        '
        Me.lblCombobox.AutoSize = True
        Me.lblCombobox.Location = New System.Drawing.Point(8, 119)
        Me.lblCombobox.Name = "lblCombobox"
        Me.lblCombobox.Size = New System.Drawing.Size(53, 13)
        Me.lblCombobox.TabIndex = 20
        Me.lblCombobox.Text = "To Status"
        Me.lblCombobox.Visible = False
        '
        'cboToStatus
        '
        Me.cboToStatus.BackColor = System.Drawing.SystemColors.Control
        Me.cboToStatus.DisplayMember = "statusid"
        Me.cboToStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboToStatus.Enabled = False
        Me.cboToStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboToStatus.FormattingEnabled = True
        Me.cboToStatus.Location = New System.Drawing.Point(123, 116)
        Me.cboToStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.cboToStatus.Name = "cboToStatus"
        Me.cboToStatus.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboToStatus.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboToStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboToStatus.TabIndex = 17
        Me.cboToStatus.ValueMember = "statusid"
        Me.cboToStatus.Visible = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(123, 4)
        Me.txtID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'nudTemp
        '
        Me.nudTemp.DecimalTreatment = HR.SysNumericUpDown.DecimalTreatmentMode.Truncate
        Me.nudTemp.Enabled = False
        Me.nudTemp.Location = New System.Drawing.Point(123, 94)
        Me.nudTemp.Margin = New System.Windows.Forms.Padding(1)
        Me.nudTemp.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudTemp.Minimum = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.nudTemp.Name = "nudTemp"
        Me.nudTemp.Size = New System.Drawing.Size(121, 20)
        Me.nudTemp.TabIndex = 45
        Me.nudTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTemp.ThousandsSeparator = True
        Me.nudTemp.Visible = False
        '
        'tbpRemark
        '
        Me.tbpRemark.Controls.Add(Me.txtRemark)
        Me.tbpRemark.Location = New System.Drawing.Point(4, 22)
        Me.tbpRemark.Name = "tbpRemark"
        Me.tbpRemark.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRemark.Size = New System.Drawing.Size(491, 351)
        Me.tbpRemark.TabIndex = 2
        Me.tbpRemark.Text = "Header Remark"
        Me.tbpRemark.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRemark.Location = New System.Drawing.Point(3, 3)
        Me.txtRemark.MaxLength = 1000
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(485, 345)
        Me.txtRemark.TabIndex = 2
        '
        'ucRecordInfo
        '
        Me.ucRecordInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucRecordInfo.Location = New System.Drawing.Point(0, 417)
        Me.ucRecordInfo.Name = "ucRecordInfo"
        Me.ucRecordInfo.ShowNoRecordInfo = False
        Me.ucRecordInfo.Size = New System.Drawing.Size(499, 70)
        Me.ucRecordInfo.TabIndex = 6
        '
        'FormGenericMasterDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 487)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.tspMain)
        Me.Controls.Add(Me.ucRecordInfo)
        Me.Name = "FormGenericMasterDataEntry"
        Me.Text = "Master Data Entry"
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.tbc.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpHeader.PerformLayout()
        CType(Me.nudTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpRemark.ResumeLayout(False)
        Me.tbpRemark.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tspMain As ToolStrip
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents ucRecordInfo As ucRecordInformation
    Friend WithEvents cboToStatus As SysComboBox
    Friend WithEvents tbc As TabControl
    Friend WithEvents tbpHeader As TabPage
    Friend WithEvents lblCombobox As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbpRemark As TabPage
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents chkNumeric As CheckBox
    Friend WithEvents txtAltName As TextBox
    Friend WithEvents lblAltName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nudTemp As SysNumericUpDown
    Friend WithEvents chkLinkLabel As CheckBox
    Friend WithEvents lnkParent As LinkLabel
End Class
