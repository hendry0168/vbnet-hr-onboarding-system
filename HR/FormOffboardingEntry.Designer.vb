<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOffboardingEntry
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
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ucRecordInfo = New HR.ucRecordInformation()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboRemark2 = New HR.SysComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPersonnelID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPersonID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lnkPersonnel = New System.Windows.Forms.LinkLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboLevel = New HR.SysComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboEmploymentType = New HR.SysComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboRemark1 = New HR.SysComboBox()
        Me.dtpEffectiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDocDate = New System.Windows.Forms.Label()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New HR.SysComboBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpRemark = New System.Windows.Forms.TabPage()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.tspMain.SuspendLayout()
        Me.tbc.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpRemark.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspMain
        '
        Me.tspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose, Me.btnSave, Me.btnCancel})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(800, 39)
        Me.tspMain.TabIndex = 2
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
        'ucRecordInfo
        '
        Me.ucRecordInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucRecordInfo.Location = New System.Drawing.Point(0, 282)
        Me.ucRecordInfo.Name = "ucRecordInfo"
        Me.ucRecordInfo.ShowNoRecordInfo = False
        Me.ucRecordInfo.Size = New System.Drawing.Size(800, 70)
        Me.ucRecordInfo.TabIndex = 7
        '
        'tbc
        '
        Me.tbc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbc.Controls.Add(Me.tbpHeader)
        Me.tbc.Controls.Add(Me.tbpRemark)
        Me.tbc.Location = New System.Drawing.Point(0, 37)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(800, 239)
        Me.tbc.TabIndex = 8
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.Label4)
        Me.tbpHeader.Controls.Add(Me.cboRemark2)
        Me.tbpHeader.Controls.Add(Me.Label19)
        Me.tbpHeader.Controls.Add(Me.txtPersonnelID)
        Me.tbpHeader.Controls.Add(Me.Label18)
        Me.tbpHeader.Controls.Add(Me.txtPersonID)
        Me.tbpHeader.Controls.Add(Me.Label17)
        Me.tbpHeader.Controls.Add(Me.lnkPersonnel)
        Me.tbpHeader.Controls.Add(Me.Label16)
        Me.tbpHeader.Controls.Add(Me.cboLevel)
        Me.tbpHeader.Controls.Add(Me.Label15)
        Me.tbpHeader.Controls.Add(Me.cboEmploymentType)
        Me.tbpHeader.Controls.Add(Me.Label14)
        Me.tbpHeader.Controls.Add(Me.cboRemark1)
        Me.tbpHeader.Controls.Add(Me.dtpEffectiveDate)
        Me.tbpHeader.Controls.Add(Me.Label3)
        Me.tbpHeader.Controls.Add(Me.dtpDocDate)
        Me.tbpHeader.Controls.Add(Me.lblDocDate)
        Me.tbpHeader.Controls.Add(Me.txtHeader)
        Me.tbpHeader.Controls.Add(Me.Label2)
        Me.tbpHeader.Controls.Add(Me.lblStatus)
        Me.tbpHeader.Controls.Add(Me.cboStatus)
        Me.tbpHeader.Controls.Add(Me.txtDocNo)
        Me.tbpHeader.Controls.Add(Me.Label1)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(792, 213)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Exit Details"
        '
        'cboRemark2
        '
        Me.cboRemark2.BackColor = System.Drawing.SystemColors.Control
        Me.cboRemark2.DisplayMember = "statusid"
        Me.cboRemark2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemark2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark2.FormattingEnabled = True
        Me.cboRemark2.Location = New System.Drawing.Point(125, 161)
        Me.cboRemark2.Margin = New System.Windows.Forms.Padding(1)
        Me.cboRemark2.Name = "cboRemark2"
        Me.cboRemark2.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboRemark2.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark2.Size = New System.Drawing.Size(121, 21)
        Me.cboRemark2.TabIndex = 106
        Me.cboRemark2.ValueMember = "statusid"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(550, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Personnel ID"
        '
        'txtPersonnelID
        '
        Me.txtPersonnelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPersonnelID.Location = New System.Drawing.Point(665, 48)
        Me.txtPersonnelID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPersonnelID.MaxLength = 10
        Me.txtPersonnelID.Name = "txtPersonnelID"
        Me.txtPersonnelID.ReadOnly = True
        Me.txtPersonnelID.Size = New System.Drawing.Size(121, 20)
        Me.txtPersonnelID.TabIndex = 97
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(550, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "Person ID"
        '
        'txtPersonID
        '
        Me.txtPersonID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPersonID.Location = New System.Drawing.Point(665, 26)
        Me.txtPersonID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPersonID.MaxLength = 10
        Me.txtPersonID.Name = "txtPersonID"
        Me.txtPersonID.ReadOnly = True
        Me.txtPersonID.Size = New System.Drawing.Size(121, 20)
        Me.txtPersonID.TabIndex = 95
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "Personnel"
        '
        'lnkPersonnel
        '
        Me.lnkPersonnel.AutoSize = True
        Me.lnkPersonnel.Location = New System.Drawing.Point(122, 73)
        Me.lnkPersonnel.Name = "lnkPersonnel"
        Me.lnkPersonnel.Size = New System.Drawing.Size(87, 13)
        Me.lnkPersonnel.TabIndex = 91
        Me.lnkPersonnel.TabStop = True
        Me.lnkPersonnel.Text = "Select Personnel"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Personnel Level"
        '
        'cboLevel
        '
        Me.cboLevel.BackColor = System.Drawing.SystemColors.Control
        Me.cboLevel.DisplayMember = "statusid"
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(125, 115)
        Me.cboLevel.Margin = New System.Windows.Forms.Padding(1)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboLevel.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboLevel.TabIndex = 89
        Me.cboLevel.ValueMember = "statusid"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Employment Type"
        '
        'cboEmploymentType
        '
        Me.cboEmploymentType.BackColor = System.Drawing.SystemColors.Control
        Me.cboEmploymentType.DisplayMember = "statusid"
        Me.cboEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmploymentType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEmploymentType.FormattingEnabled = True
        Me.cboEmploymentType.Location = New System.Drawing.Point(125, 92)
        Me.cboEmploymentType.Margin = New System.Windows.Forms.Padding(1)
        Me.cboEmploymentType.Name = "cboEmploymentType"
        Me.cboEmploymentType.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboEmploymentType.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEmploymentType.Size = New System.Drawing.Size(121, 21)
        Me.cboEmploymentType.TabIndex = 87
        Me.cboEmploymentType.ValueMember = "statusid"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Exit Reason"
        '
        'cboRemark1
        '
        Me.cboRemark1.BackColor = System.Drawing.SystemColors.Control
        Me.cboRemark1.DisplayMember = "statusid"
        Me.cboRemark1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemark1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark1.FormattingEnabled = True
        Me.cboRemark1.Location = New System.Drawing.Point(125, 138)
        Me.cboRemark1.Margin = New System.Windows.Forms.Padding(1)
        Me.cboRemark1.Name = "cboRemark1"
        Me.cboRemark1.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboRemark1.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark1.Size = New System.Drawing.Size(121, 21)
        Me.cboRemark1.TabIndex = 85
        Me.cboRemark1.ValueMember = "statusid"
        '
        'dtpEffectiveDate
        '
        Me.dtpEffectiveDate.CustomFormat = "dd.MM.yyyy"
        Me.dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEffectiveDate.Location = New System.Drawing.Point(124, 48)
        Me.dtpEffectiveDate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpEffectiveDate.Name = "dtpEffectiveDate"
        Me.dtpEffectiveDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpEffectiveDate.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Effective Date"
        '
        'dtpDocDate
        '
        Me.dtpDocDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDocDate.CustomFormat = "dd.MM.yyyy"
        Me.dtpDocDate.Enabled = False
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDocDate.Location = New System.Drawing.Point(666, 4)
        Me.dtpDocDate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpDocDate.TabIndex = 59
        '
        'lblDocDate
        '
        Me.lblDocDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocDate.AutoSize = True
        Me.lblDocDate.Location = New System.Drawing.Point(550, 7)
        Me.lblDocDate.Name = "lblDocDate"
        Me.lblDocDate.Size = New System.Drawing.Size(82, 13)
        Me.lblDocDate.TabIndex = 58
        Me.lblDocDate.Text = "Document Date"
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(123, 26)
        Me.txtHeader.Margin = New System.Windows.Forms.Padding(1)
        Me.txtHeader.MaxLength = 1000
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(362, 20)
        Me.txtHeader.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Header"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(10, 188)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboStatus.BackColor = System.Drawing.SystemColors.Control
        Me.cboStatus.DisplayMember = "statusid"
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Enabled = False
        Me.cboStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(125, 185)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboStatus.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 17
        Me.cboStatus.ValueMember = "statusid"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(123, 4)
        Me.txtDocNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDocNo.MaxLength = 10
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.ReadOnly = True
        Me.txtDocNo.Size = New System.Drawing.Size(121, 20)
        Me.txtDocNo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Document No"
        '
        'tbpRemark
        '
        Me.tbpRemark.Controls.Add(Me.txtRemark)
        Me.tbpRemark.Location = New System.Drawing.Point(4, 22)
        Me.tbpRemark.Name = "tbpRemark"
        Me.tbpRemark.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRemark.Size = New System.Drawing.Size(792, 213)
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
        Me.txtRemark.Size = New System.Drawing.Size(786, 207)
        Me.txtRemark.TabIndex = 2
        '
        'FormOffboardingEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 352)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.ucRecordInfo)
        Me.Controls.Add(Me.tspMain)
        Me.Name = "FormOffboardingEntry"
        Me.Text = "Offboarding Entry"
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.tbc.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpHeader.PerformLayout()
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
    Friend WithEvents tbc As TabControl
    Friend WithEvents tbpHeader As TabPage
    Friend WithEvents dtpEffectiveDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDocDate As DateTimePicker
    Friend WithEvents lblDocDate As Label
    Friend WithEvents txtHeader As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As SysComboBox
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbpRemark As TabPage
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cboLevel As SysComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboEmploymentType As SysComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboRemark1 As SysComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lnkPersonnel As LinkLabel
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPersonnelID As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPersonID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboRemark2 As SysComboBox
End Class
