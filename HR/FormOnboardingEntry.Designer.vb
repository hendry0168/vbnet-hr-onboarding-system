<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOnboardingEntry
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboEducation = New HR.SysComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPersonnelID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPersonID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lnkSuperior = New System.Windows.Forms.LinkLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboLevel = New HR.SysComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboEmploymentType = New HR.SysComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboPersonnelType = New HR.SysComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboReligion = New HR.SysComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboGender = New HR.SysComboBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNickName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpHiringDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDocDate = New System.Windows.Forms.Label()
        Me.lblAltName = New System.Windows.Forms.Label()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New HR.SysComboBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpRemark = New System.Windows.Forms.TabPage()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.ucRecordInfo = New HR.ucRecordInformation()
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
        Me.tbc.Size = New System.Drawing.Size(800, 478)
        Me.tbc.TabIndex = 8
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.Label20)
        Me.tbpHeader.Controls.Add(Me.cboEducation)
        Me.tbpHeader.Controls.Add(Me.Label19)
        Me.tbpHeader.Controls.Add(Me.txtPersonnelID)
        Me.tbpHeader.Controls.Add(Me.Label18)
        Me.tbpHeader.Controls.Add(Me.txtPersonID)
        Me.tbpHeader.Controls.Add(Me.Label17)
        Me.tbpHeader.Controls.Add(Me.lnkSuperior)
        Me.tbpHeader.Controls.Add(Me.Label16)
        Me.tbpHeader.Controls.Add(Me.cboLevel)
        Me.tbpHeader.Controls.Add(Me.Label15)
        Me.tbpHeader.Controls.Add(Me.cboEmploymentType)
        Me.tbpHeader.Controls.Add(Me.Label14)
        Me.tbpHeader.Controls.Add(Me.cboPersonnelType)
        Me.tbpHeader.Controls.Add(Me.Label13)
        Me.tbpHeader.Controls.Add(Me.cboReligion)
        Me.tbpHeader.Controls.Add(Me.Label12)
        Me.tbpHeader.Controls.Add(Me.cboGender)
        Me.tbpHeader.Controls.Add(Me.dtpBirthDate)
        Me.tbpHeader.Controls.Add(Me.Label11)
        Me.tbpHeader.Controls.Add(Me.txtBirthPlace)
        Me.tbpHeader.Controls.Add(Me.Label10)
        Me.tbpHeader.Controls.Add(Me.txtNickName)
        Me.tbpHeader.Controls.Add(Me.Label8)
        Me.tbpHeader.Controls.Add(Me.txtFullName)
        Me.tbpHeader.Controls.Add(Me.Label9)
        Me.tbpHeader.Controls.Add(Me.txtSuffix)
        Me.tbpHeader.Controls.Add(Me.Label7)
        Me.tbpHeader.Controls.Add(Me.txtLastName)
        Me.tbpHeader.Controls.Add(Me.Label5)
        Me.tbpHeader.Controls.Add(Me.txtMiddleName)
        Me.tbpHeader.Controls.Add(Me.Label6)
        Me.tbpHeader.Controls.Add(Me.txtFirstName)
        Me.tbpHeader.Controls.Add(Me.Label4)
        Me.tbpHeader.Controls.Add(Me.dtpHiringDate)
        Me.tbpHeader.Controls.Add(Me.Label3)
        Me.tbpHeader.Controls.Add(Me.txtPrefix)
        Me.tbpHeader.Controls.Add(Me.dtpDocDate)
        Me.tbpHeader.Controls.Add(Me.lblDocDate)
        Me.tbpHeader.Controls.Add(Me.lblAltName)
        Me.tbpHeader.Controls.Add(Me.txtHeader)
        Me.tbpHeader.Controls.Add(Me.Label2)
        Me.tbpHeader.Controls.Add(Me.lblStatus)
        Me.tbpHeader.Controls.Add(Me.cboStatus)
        Me.tbpHeader.Controls.Add(Me.txtDocNo)
        Me.tbpHeader.Controls.Add(Me.Label1)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(792, 452)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 317)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Education Level"
        '
        'cboEducation
        '
        Me.cboEducation.BackColor = System.Drawing.SystemColors.Control
        Me.cboEducation.DisplayMember = "statusid"
        Me.cboEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEducation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEducation.FormattingEnabled = True
        Me.cboEducation.Location = New System.Drawing.Point(125, 314)
        Me.cboEducation.Margin = New System.Windows.Forms.Padding(1)
        Me.cboEducation.Name = "cboEducation"
        Me.cboEducation.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboEducation.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEducation.Size = New System.Drawing.Size(121, 21)
        Me.cboEducation.TabIndex = 29
        Me.cboEducation.ValueMember = "statusid"
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
        Me.Label17.Location = New System.Drawing.Point(9, 407)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Superior"
        '
        'lnkSuperior
        '
        Me.lnkSuperior.AutoSize = True
        Me.lnkSuperior.Location = New System.Drawing.Point(121, 407)
        Me.lnkSuperior.Name = "lnkSuperior"
        Me.lnkSuperior.Size = New System.Drawing.Size(79, 13)
        Me.lnkSuperior.TabIndex = 37
        Me.lnkSuperior.TabStop = True
        Me.lnkSuperior.Text = "Select Superior"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 385)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Personnel Level"
        '
        'cboLevel
        '
        Me.cboLevel.BackColor = System.Drawing.SystemColors.Control
        Me.cboLevel.DisplayMember = "statusid"
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(124, 382)
        Me.cboLevel.Margin = New System.Windows.Forms.Padding(1)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboLevel.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboLevel.TabIndex = 35
        Me.cboLevel.ValueMember = "statusid"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 362)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Employment Type"
        '
        'cboEmploymentType
        '
        Me.cboEmploymentType.BackColor = System.Drawing.SystemColors.Control
        Me.cboEmploymentType.DisplayMember = "statusid"
        Me.cboEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmploymentType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEmploymentType.FormattingEnabled = True
        Me.cboEmploymentType.Location = New System.Drawing.Point(124, 359)
        Me.cboEmploymentType.Margin = New System.Windows.Forms.Padding(1)
        Me.cboEmploymentType.Name = "cboEmploymentType"
        Me.cboEmploymentType.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboEmploymentType.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEmploymentType.Size = New System.Drawing.Size(121, 21)
        Me.cboEmploymentType.TabIndex = 33
        Me.cboEmploymentType.ValueMember = "statusid"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 339)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Personnel Type"
        '
        'cboPersonnelType
        '
        Me.cboPersonnelType.BackColor = System.Drawing.SystemColors.Control
        Me.cboPersonnelType.DisplayMember = "statusid"
        Me.cboPersonnelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersonnelType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPersonnelType.FormattingEnabled = True
        Me.cboPersonnelType.Location = New System.Drawing.Point(124, 336)
        Me.cboPersonnelType.Margin = New System.Windows.Forms.Padding(1)
        Me.cboPersonnelType.Name = "cboPersonnelType"
        Me.cboPersonnelType.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboPersonnelType.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPersonnelType.Size = New System.Drawing.Size(121, 21)
        Me.cboPersonnelType.TabIndex = 31
        Me.cboPersonnelType.ValueMember = "statusid"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Religion"
        '
        'cboReligion
        '
        Me.cboReligion.BackColor = System.Drawing.SystemColors.Control
        Me.cboReligion.DisplayMember = "statusid"
        Me.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReligion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.Location = New System.Drawing.Point(125, 291)
        Me.cboReligion.Margin = New System.Windows.Forms.Padding(1)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboReligion.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboReligion.Size = New System.Drawing.Size(121, 21)
        Me.cboReligion.TabIndex = 27
        Me.cboReligion.ValueMember = "statusid"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Gender"
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.SystemColors.Control
        Me.cboGender.DisplayMember = "statusid"
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(125, 268)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(1)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboGender.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 25
        Me.cboGender.ValueMember = "statusid"
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.CustomFormat = "dd.MM.yyyy"
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthDate.Location = New System.Drawing.Point(125, 246)
        Me.dtpBirthDate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpBirthDate.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Date of Birth"
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.Location = New System.Drawing.Point(124, 224)
        Me.txtBirthPlace.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBirthPlace.MaxLength = 1000
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(361, 20)
        Me.txtBirthPlace.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Place of Birth"
        '
        'txtNickName
        '
        Me.txtNickName.Location = New System.Drawing.Point(123, 202)
        Me.txtNickName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNickName.MaxLength = 1000
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Size = New System.Drawing.Size(361, 20)
        Me.txtNickName.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nick Name"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(123, 180)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFullName.MaxLength = 1000
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(361, 20)
        Me.txtFullName.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Full Name"
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(124, 158)
        Me.txtSuffix.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSuffix.MaxLength = 1000
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(361, 20)
        Me.txtSuffix.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Name Suffix"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(124, 136)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtLastName.MaxLength = 1000
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(361, 20)
        Me.txtLastName.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Last Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(124, 114)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMiddleName.MaxLength = 1000
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(361, 20)
        Me.txtMiddleName.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(124, 92)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFirstName.MaxLength = 1000
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(361, 20)
        Me.txtFirstName.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "First Name"
        '
        'dtpHiringDate
        '
        Me.dtpHiringDate.CustomFormat = "dd.MM.yyyy"
        Me.dtpHiringDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHiringDate.Location = New System.Drawing.Point(124, 48)
        Me.dtpHiringDate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpHiringDate.Name = "dtpHiringDate"
        Me.dtpHiringDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpHiringDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hiring Date"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(124, 70)
        Me.txtPrefix.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPrefix.MaxLength = 1000
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(361, 20)
        Me.txtPrefix.TabIndex = 7
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
        'lblAltName
        '
        Me.lblAltName.AutoSize = True
        Me.lblAltName.Location = New System.Drawing.Point(8, 73)
        Me.lblAltName.Name = "lblAltName"
        Me.lblAltName.Size = New System.Drawing.Size(64, 13)
        Me.lblAltName.TabIndex = 6
        Me.lblAltName.Text = "Name Prefix"
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(123, 26)
        Me.txtHeader.Margin = New System.Windows.Forms.Padding(1)
        Me.txtHeader.MaxLength = 1000
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(362, 20)
        Me.txtHeader.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Header"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(10, 427)
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
        Me.cboStatus.Location = New System.Drawing.Point(125, 424)
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
        Me.txtDocNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Document No"
        '
        'tbpRemark
        '
        Me.tbpRemark.Controls.Add(Me.txtRemark)
        Me.tbpRemark.Location = New System.Drawing.Point(4, 22)
        Me.tbpRemark.Name = "tbpRemark"
        Me.tbpRemark.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRemark.Size = New System.Drawing.Size(792, 452)
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
        Me.txtRemark.Size = New System.Drawing.Size(786, 446)
        Me.txtRemark.TabIndex = 2
        '
        'ucRecordInfo
        '
        Me.ucRecordInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucRecordInfo.Location = New System.Drawing.Point(0, 531)
        Me.ucRecordInfo.Name = "ucRecordInfo"
        Me.ucRecordInfo.ShowNoRecordInfo = False
        Me.ucRecordInfo.Size = New System.Drawing.Size(800, 70)
        Me.ucRecordInfo.TabIndex = 7
        '
        'FormOnboardingEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.ucRecordInfo)
        Me.Controls.Add(Me.tspMain)
        Me.Name = "FormOnboardingEntry"
        Me.Text = "Onboarding Entry"
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
    Friend WithEvents dtpHiringDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrefix As TextBox
    Friend WithEvents dtpDocDate As DateTimePicker
    Friend WithEvents lblDocDate As Label
    Friend WithEvents lblAltName As Label
    Friend WithEvents txtHeader As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As SysComboBox
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbpRemark As TabPage
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboReligion As SysComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboGender As SysComboBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNickName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSuffix As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cboLevel As SysComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboEmploymentType As SysComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboPersonnelType As SysComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lnkSuperior As LinkLabel
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPersonnelID As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtPersonID As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cboEducation As SysComboBox
End Class
