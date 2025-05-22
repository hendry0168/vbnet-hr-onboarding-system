<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmployeeReport
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
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.tbcDetail = New System.Windows.Forms.TabControl()
        Me.tbpSSAReporting = New System.Windows.Forms.TabPage()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.btnCancelLoading = New System.Windows.Forms.Button()
        Me.pctLoading = New System.Windows.Forms.PictureBox()
        Me.pgbLoading = New System.Windows.Forms.ProgressBar()
        Me.xdgReporting = New HR.XDataGrid()
        Me.tspReportItem = New System.Windows.Forms.ToolStrip()
        Me.progressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPercentage = New System.Windows.Forms.ToolStripLabel()
        Me.tbpFilter = New System.Windows.Forms.TabPage()
        Me.chkEmploymentType = New System.Windows.Forms.CheckBox()
        Me.cboEmploymentType = New HR.SysComboBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.cboStatus = New HR.SysComboBox()
        Me.chkLevel = New System.Windows.Forms.CheckBox()
        Me.cboLevel = New HR.SysComboBox()
        Me.cboPersonnelType = New HR.SysComboBox()
        Me.chkPersonnelType = New System.Windows.Forms.CheckBox()
        Me.cboReligion = New HR.SysComboBox()
        Me.cboGender = New HR.SysComboBox()
        Me.chkReligion = New System.Windows.Forms.CheckBox()
        Me.chkGender = New System.Windows.Forms.CheckBox()
        Me.chkHireDate = New System.Windows.Forms.CheckBox()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.tbcDetail.SuspendLayout()
        Me.tbpSSAReporting.SuspendLayout()
        Me.pnlProgress.SuspendLayout()
        CType(Me.pctLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspReportItem.SuspendLayout()
        Me.tbpFilter.SuspendLayout()
        Me.tbc.SuspendLayout()
        Me.tspMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgw
        '
        Me.bgw.WorkerReportsProgress = True
        Me.bgw.WorkerSupportsCancellation = True
        '
        'tbcDetail
        '
        Me.tbcDetail.Controls.Add(Me.tbpSSAReporting)
        Me.tbcDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcDetail.Location = New System.Drawing.Point(0, 236)
        Me.tbcDetail.Name = "tbcDetail"
        Me.tbcDetail.SelectedIndex = 0
        Me.tbcDetail.Size = New System.Drawing.Size(764, 445)
        Me.tbcDetail.TabIndex = 13
        '
        'tbpSSAReporting
        '
        Me.tbpSSAReporting.Controls.Add(Me.pnlProgress)
        Me.tbpSSAReporting.Controls.Add(Me.xdgReporting)
        Me.tbpSSAReporting.Controls.Add(Me.tspReportItem)
        Me.tbpSSAReporting.Location = New System.Drawing.Point(4, 22)
        Me.tbpSSAReporting.Name = "tbpSSAReporting"
        Me.tbpSSAReporting.Size = New System.Drawing.Size(756, 419)
        Me.tbpSSAReporting.TabIndex = 2
        Me.tbpSSAReporting.Text = "Reporting"
        Me.tbpSSAReporting.UseVisualStyleBackColor = True
        '
        'pnlProgress
        '
        Me.pnlProgress.Controls.Add(Me.txtTask)
        Me.pnlProgress.Controls.Add(Me.btnCancelLoading)
        Me.pnlProgress.Controls.Add(Me.pctLoading)
        Me.pnlProgress.Controls.Add(Me.pgbLoading)
        Me.pnlProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProgress.Location = New System.Drawing.Point(0, 39)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(756, 380)
        Me.pnlProgress.TabIndex = 88
        Me.pnlProgress.Visible = False
        '
        'txtTask
        '
        Me.txtTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTask.Location = New System.Drawing.Point(12, 215)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.ReadOnly = True
        Me.txtTask.Size = New System.Drawing.Size(732, 13)
        Me.txtTask.TabIndex = 27
        Me.txtTask.TabStop = False
        Me.txtTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelLoading
        '
        Me.btnCancelLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancelLoading.Location = New System.Drawing.Point(341, 245)
        Me.btnCancelLoading.Name = "btnCancelLoading"
        Me.btnCancelLoading.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelLoading.TabIndex = 26
        Me.btnCancelLoading.Text = "Cancel"
        Me.btnCancelLoading.UseVisualStyleBackColor = True
        Me.btnCancelLoading.Visible = False
        '
        'pctLoading
        '
        Me.pctLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctLoading.Image = Global.HR.My.Resources.Resources.gifLoading
        Me.pctLoading.Location = New System.Drawing.Point(362, 144)
        Me.pctLoading.Name = "pctLoading"
        Me.pctLoading.Size = New System.Drawing.Size(32, 32)
        Me.pctLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctLoading.TabIndex = 25
        Me.pctLoading.TabStop = False
        '
        'pgbLoading
        '
        Me.pgbLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbLoading.Location = New System.Drawing.Point(12, 182)
        Me.pgbLoading.Name = "pgbLoading"
        Me.pgbLoading.Size = New System.Drawing.Size(732, 27)
        Me.pgbLoading.TabIndex = 0
        '
        'xdgReporting
        '
        Me.xdgReporting.AllowMultiSelection = True
        Me.xdgReporting.CellMultiLine = False
        Me.xdgReporting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xdgReporting.EnableContextMenu = True
        Me.xdgReporting.Location = New System.Drawing.Point(0, 39)
        Me.xdgReporting.MergeIdenticalCells = False
        Me.xdgReporting.Name = "xdgReporting"
        Me.xdgReporting.ShowFilterPanel = False
        Me.xdgReporting.ShowGroupFooter = False
        Me.xdgReporting.ShowGroupPanel = False
        Me.xdgReporting.ShowRowCountFooter = True
        Me.xdgReporting.Size = New System.Drawing.Size(756, 380)
        Me.xdgReporting.TabIndex = 11
        '
        'tspReportItem
        '
        Me.tspReportItem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspReportItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progressBar, Me.lblPercentage})
        Me.tspReportItem.Location = New System.Drawing.Point(0, 0)
        Me.tspReportItem.Name = "tspReportItem"
        Me.tspReportItem.Size = New System.Drawing.Size(756, 39)
        Me.tspReportItem.TabIndex = 87
        Me.tspReportItem.Text = "ToolStrip2"
        '
        'progressBar
        '
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(300, 36)
        '
        'lblPercentage
        '
        Me.lblPercentage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(26, 36)
        Me.lblPercentage.Text = "0%"
        '
        'tbpFilter
        '
        Me.tbpFilter.Controls.Add(Me.chkEmploymentType)
        Me.tbpFilter.Controls.Add(Me.cboEmploymentType)
        Me.tbpFilter.Controls.Add(Me.chkStatus)
        Me.tbpFilter.Controls.Add(Me.cboStatus)
        Me.tbpFilter.Controls.Add(Me.chkLevel)
        Me.tbpFilter.Controls.Add(Me.cboLevel)
        Me.tbpFilter.Controls.Add(Me.cboPersonnelType)
        Me.tbpFilter.Controls.Add(Me.chkPersonnelType)
        Me.tbpFilter.Controls.Add(Me.cboReligion)
        Me.tbpFilter.Controls.Add(Me.cboGender)
        Me.tbpFilter.Controls.Add(Me.chkReligion)
        Me.tbpFilter.Controls.Add(Me.chkGender)
        Me.tbpFilter.Controls.Add(Me.chkHireDate)
        Me.tbpFilter.Controls.Add(Me.dtpHireDate)
        Me.tbpFilter.Location = New System.Drawing.Point(4, 22)
        Me.tbpFilter.Name = "tbpFilter"
        Me.tbpFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFilter.Size = New System.Drawing.Size(756, 171)
        Me.tbpFilter.TabIndex = 0
        Me.tbpFilter.Text = "Filter"
        Me.tbpFilter.UseVisualStyleBackColor = True
        '
        'chkEmploymentType
        '
        Me.chkEmploymentType.AutoSize = True
        Me.chkEmploymentType.Location = New System.Drawing.Point(6, 120)
        Me.chkEmploymentType.Name = "chkEmploymentType"
        Me.chkEmploymentType.Size = New System.Drawing.Size(110, 17)
        Me.chkEmploymentType.TabIndex = 118
        Me.chkEmploymentType.Text = "Employment Type"
        Me.chkEmploymentType.UseVisualStyleBackColor = True
        '
        'cboEmploymentType
        '
        Me.cboEmploymentType.BackColor = System.Drawing.SystemColors.Control
        Me.cboEmploymentType.DisplayMember = "statusid"
        Me.cboEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmploymentType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEmploymentType.FormattingEnabled = True
        Me.cboEmploymentType.Location = New System.Drawing.Point(120, 118)
        Me.cboEmploymentType.Margin = New System.Windows.Forms.Padding(1)
        Me.cboEmploymentType.Name = "cboEmploymentType"
        Me.cboEmploymentType.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboEmploymentType.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEmploymentType.Size = New System.Drawing.Size(121, 21)
        Me.cboEmploymentType.TabIndex = 117
        Me.cboEmploymentType.ValueMember = "statusid"
        Me.cboEmploymentType.Visible = False
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(6, 143)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(106, 17)
        Me.chkStatus.TabIndex = 116
        Me.chkStatus.Text = "Personnel Status"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.Control
        Me.cboStatus.DisplayMember = "statusid"
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(120, 141)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboStatus.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 115
        Me.cboStatus.ValueMember = "statusid"
        Me.cboStatus.Visible = False
        '
        'chkLevel
        '
        Me.chkLevel.AutoSize = True
        Me.chkLevel.Location = New System.Drawing.Point(6, 95)
        Me.chkLevel.Name = "chkLevel"
        Me.chkLevel.Size = New System.Drawing.Size(52, 17)
        Me.chkLevel.TabIndex = 114
        Me.chkLevel.Text = "Level"
        Me.chkLevel.UseVisualStyleBackColor = True
        '
        'cboLevel
        '
        Me.cboLevel.BackColor = System.Drawing.SystemColors.Control
        Me.cboLevel.DisplayMember = "statusid"
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Location = New System.Drawing.Point(120, 95)
        Me.cboLevel.Margin = New System.Windows.Forms.Padding(1)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboLevel.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboLevel.TabIndex = 113
        Me.cboLevel.ValueMember = "statusid"
        Me.cboLevel.Visible = False
        '
        'cboPersonnelType
        '
        Me.cboPersonnelType.BackColor = System.Drawing.SystemColors.Control
        Me.cboPersonnelType.DisplayMember = "statusid"
        Me.cboPersonnelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersonnelType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPersonnelType.FormattingEnabled = True
        Me.cboPersonnelType.Location = New System.Drawing.Point(120, 72)
        Me.cboPersonnelType.Margin = New System.Windows.Forms.Padding(1)
        Me.cboPersonnelType.Name = "cboPersonnelType"
        Me.cboPersonnelType.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboPersonnelType.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPersonnelType.Size = New System.Drawing.Size(121, 21)
        Me.cboPersonnelType.TabIndex = 112
        Me.cboPersonnelType.ValueMember = "statusid"
        Me.cboPersonnelType.Visible = False
        '
        'chkPersonnelType
        '
        Me.chkPersonnelType.AutoSize = True
        Me.chkPersonnelType.Location = New System.Drawing.Point(6, 72)
        Me.chkPersonnelType.Name = "chkPersonnelType"
        Me.chkPersonnelType.Size = New System.Drawing.Size(100, 17)
        Me.chkPersonnelType.TabIndex = 111
        Me.chkPersonnelType.Text = "Personnel Type"
        Me.chkPersonnelType.UseVisualStyleBackColor = True
        '
        'cboReligion
        '
        Me.cboReligion.BackColor = System.Drawing.SystemColors.Control
        Me.cboReligion.DisplayMember = "statusid"
        Me.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReligion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.Location = New System.Drawing.Point(120, 49)
        Me.cboReligion.Margin = New System.Windows.Forms.Padding(1)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboReligion.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboReligion.Size = New System.Drawing.Size(121, 21)
        Me.cboReligion.TabIndex = 108
        Me.cboReligion.ValueMember = "statusid"
        Me.cboReligion.Visible = False
        '
        'cboGender
        '
        Me.cboGender.BackColor = System.Drawing.SystemColors.Control
        Me.cboGender.DisplayMember = "statusid"
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(120, 26)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(1)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboGender.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 107
        Me.cboGender.ValueMember = "statusid"
        Me.cboGender.Visible = False
        '
        'chkReligion
        '
        Me.chkReligion.AutoSize = True
        Me.chkReligion.Location = New System.Drawing.Point(6, 48)
        Me.chkReligion.Name = "chkReligion"
        Me.chkReligion.Size = New System.Drawing.Size(64, 17)
        Me.chkReligion.TabIndex = 64
        Me.chkReligion.Text = "Religion"
        Me.chkReligion.UseVisualStyleBackColor = True
        '
        'chkGender
        '
        Me.chkGender.AutoSize = True
        Me.chkGender.Location = New System.Drawing.Point(6, 26)
        Me.chkGender.Name = "chkGender"
        Me.chkGender.Size = New System.Drawing.Size(61, 17)
        Me.chkGender.TabIndex = 62
        Me.chkGender.Text = "Gender"
        Me.chkGender.UseVisualStyleBackColor = True
        '
        'chkHireDate
        '
        Me.chkHireDate.AutoSize = True
        Me.chkHireDate.Checked = True
        Me.chkHireDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHireDate.Location = New System.Drawing.Point(6, 4)
        Me.chkHireDate.Name = "chkHireDate"
        Me.chkHireDate.Size = New System.Drawing.Size(71, 17)
        Me.chkHireDate.TabIndex = 60
        Me.chkHireDate.Text = "Hire Date"
        Me.chkHireDate.UseVisualStyleBackColor = True
        '
        'dtpHireDate
        '
        Me.dtpHireDate.CustomFormat = "MMM yyyy"
        Me.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHireDate.Location = New System.Drawing.Point(120, 4)
        Me.dtpHireDate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpHireDate.TabIndex = 49
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.tbpFilter)
        Me.tbc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbc.Location = New System.Drawing.Point(0, 39)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(764, 197)
        Me.tbc.TabIndex = 87
        '
        'tspMain
        '
        Me.tspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnClose})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(764, 39)
        Me.tspMain.TabIndex = 10
        Me.tspMain.Text = "ToolStrip1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.HR.My.Resources.Resources.icoRefresh
        Me.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(107, 36)
        Me.btnRefresh.Text = "Load Report"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.HR.My.Resources.Resources.icoClose
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 36)
        Me.btnClose.Text = "Close"
        '
        'FormEmployeeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 681)
        Me.Controls.Add(Me.tbcDetail)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.tspMain)
        Me.Name = "FormEmployeeReport"
        Me.Text = "Document Reporting"
        Me.tbcDetail.ResumeLayout(False)
        Me.tbpSSAReporting.ResumeLayout(False)
        Me.tbpSSAReporting.PerformLayout()
        Me.pnlProgress.ResumeLayout(False)
        Me.pnlProgress.PerformLayout()
        CType(Me.pctLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspReportItem.ResumeLayout(False)
        Me.tspReportItem.PerformLayout()
        Me.tbpFilter.ResumeLayout(False)
        Me.tbpFilter.PerformLayout()
        Me.tbc.ResumeLayout(False)
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbcDetail As TabControl
    Friend WithEvents tbpFilter As TabPage
    Friend WithEvents tbc As TabControl
    Friend WithEvents tbpSSAReporting As TabPage
    Friend WithEvents xdgReporting As XDataGrid
    Friend WithEvents dtpHireDate As DateTimePicker
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents tspMain As ToolStrip
    Friend WithEvents tspReportItem As ToolStrip
    Friend WithEvents progressBar As ToolStripProgressBar
    Friend WithEvents lblPercentage As ToolStripLabel
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents txtTask As TextBox
    Friend WithEvents btnCancelLoading As Button
    Friend WithEvents pctLoading As PictureBox
    Friend WithEvents pgbLoading As ProgressBar
    Friend WithEvents chkHireDate As CheckBox
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents chkReligion As CheckBox
    Friend WithEvents chkGender As CheckBox
    Friend WithEvents cboReligion As SysComboBox
    Friend WithEvents cboGender As SysComboBox
    Friend WithEvents cboPersonnelType As SysComboBox
    Friend WithEvents chkPersonnelType As CheckBox
    Friend WithEvents chkLevel As CheckBox
    Friend WithEvents cboLevel As SysComboBox
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents cboStatus As SysComboBox
    Friend WithEvents chkEmploymentType As CheckBox
    Friend WithEvents cboEmploymentType As SysComboBox
End Class
