<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDocReport
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
        Me.tspReportItem = New System.Windows.Forms.ToolStrip()
        Me.progressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPercentage = New System.Windows.Forms.ToolStripLabel()
        Me.tbpFilter = New System.Windows.Forms.TabPage()
        Me.chkRemark2 = New System.Windows.Forms.CheckBox()
        Me.chkRemark1 = New System.Windows.Forms.CheckBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.xdgReporting = New HR.XDataGrid()
        Me.cboRemark2 = New HR.SysComboBox()
        Me.cboRemark1 = New HR.SysComboBox()
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
        Me.tbcDetail.Location = New System.Drawing.Point(0, 144)
        Me.tbcDetail.Name = "tbcDetail"
        Me.tbcDetail.SelectedIndex = 0
        Me.tbcDetail.Size = New System.Drawing.Size(764, 537)
        Me.tbcDetail.TabIndex = 13
        '
        'tbpSSAReporting
        '
        Me.tbpSSAReporting.Controls.Add(Me.pnlProgress)
        Me.tbpSSAReporting.Controls.Add(Me.xdgReporting)
        Me.tbpSSAReporting.Controls.Add(Me.tspReportItem)
        Me.tbpSSAReporting.Location = New System.Drawing.Point(4, 22)
        Me.tbpSSAReporting.Name = "tbpSSAReporting"
        Me.tbpSSAReporting.Size = New System.Drawing.Size(756, 511)
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
        Me.pnlProgress.Size = New System.Drawing.Size(756, 472)
        Me.pnlProgress.TabIndex = 88
        Me.pnlProgress.Visible = False
        '
        'txtTask
        '
        Me.txtTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTask.Location = New System.Drawing.Point(12, 261)
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
        Me.btnCancelLoading.Location = New System.Drawing.Point(341, 291)
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
        Me.pctLoading.Location = New System.Drawing.Point(362, 190)
        Me.pctLoading.Name = "pctLoading"
        Me.pctLoading.Size = New System.Drawing.Size(32, 32)
        Me.pctLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctLoading.TabIndex = 25
        Me.pctLoading.TabStop = False
        '
        'pgbLoading
        '
        Me.pgbLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbLoading.Location = New System.Drawing.Point(12, 228)
        Me.pgbLoading.Name = "pgbLoading"
        Me.pgbLoading.Size = New System.Drawing.Size(732, 27)
        Me.pgbLoading.TabIndex = 0
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
        Me.tbpFilter.Controls.Add(Me.cboRemark2)
        Me.tbpFilter.Controls.Add(Me.cboRemark1)
        Me.tbpFilter.Controls.Add(Me.chkRemark2)
        Me.tbpFilter.Controls.Add(Me.chkRemark1)
        Me.tbpFilter.Controls.Add(Me.chkDate)
        Me.tbpFilter.Controls.Add(Me.dtpDate)
        Me.tbpFilter.Location = New System.Drawing.Point(4, 22)
        Me.tbpFilter.Name = "tbpFilter"
        Me.tbpFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFilter.Size = New System.Drawing.Size(756, 79)
        Me.tbpFilter.TabIndex = 0
        Me.tbpFilter.Text = "Filter"
        Me.tbpFilter.UseVisualStyleBackColor = True
        '
        'chkRemark2
        '
        Me.chkRemark2.AutoSize = True
        Me.chkRemark2.Enabled = False
        Me.chkRemark2.Location = New System.Drawing.Point(6, 48)
        Me.chkRemark2.Name = "chkRemark2"
        Me.chkRemark2.Size = New System.Drawing.Size(78, 17)
        Me.chkRemark2.TabIndex = 64
        Me.chkRemark2.Text = "Exit Details"
        Me.chkRemark2.UseVisualStyleBackColor = True
        '
        'chkRemark1
        '
        Me.chkRemark1.AutoSize = True
        Me.chkRemark1.Enabled = False
        Me.chkRemark1.Location = New System.Drawing.Point(6, 26)
        Me.chkRemark1.Name = "chkRemark1"
        Me.chkRemark1.Size = New System.Drawing.Size(83, 17)
        Me.chkRemark1.TabIndex = 62
        Me.chkRemark1.Text = "Exit Reason"
        Me.chkRemark1.UseVisualStyleBackColor = True
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(6, 4)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(49, 17)
        Me.chkDate.TabIndex = 60
        Me.chkDate.Text = "Date"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MMM yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(120, 4)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpDate.TabIndex = 49
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.tbpFilter)
        Me.tbc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbc.Location = New System.Drawing.Point(0, 39)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(764, 105)
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
        Me.xdgReporting.Size = New System.Drawing.Size(756, 472)
        Me.xdgReporting.TabIndex = 11
        '
        'cboRemark2
        '
        Me.cboRemark2.BackColor = System.Drawing.SystemColors.Control
        Me.cboRemark2.DisplayMember = "statusid"
        Me.cboRemark2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemark2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark2.FormattingEnabled = True
        Me.cboRemark2.Location = New System.Drawing.Point(120, 49)
        Me.cboRemark2.Margin = New System.Windows.Forms.Padding(1)
        Me.cboRemark2.Name = "cboRemark2"
        Me.cboRemark2.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboRemark2.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark2.Size = New System.Drawing.Size(274, 21)
        Me.cboRemark2.TabIndex = 108
        Me.cboRemark2.ValueMember = "statusid"
        Me.cboRemark2.Visible = False
        '
        'cboRemark1
        '
        Me.cboRemark1.BackColor = System.Drawing.SystemColors.Control
        Me.cboRemark1.DisplayMember = "statusid"
        Me.cboRemark1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemark1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark1.FormattingEnabled = True
        Me.cboRemark1.Location = New System.Drawing.Point(120, 26)
        Me.cboRemark1.Margin = New System.Windows.Forms.Padding(1)
        Me.cboRemark1.Name = "cboRemark1"
        Me.cboRemark1.ReadOnlyBackColor = System.Drawing.SystemColors.Control
        Me.cboRemark1.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRemark1.Size = New System.Drawing.Size(274, 21)
        Me.cboRemark1.TabIndex = 107
        Me.cboRemark1.ValueMember = "statusid"
        Me.cboRemark1.Visible = False
        '
        'FormDocReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 681)
        Me.Controls.Add(Me.tbcDetail)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.tspMain)
        Me.Name = "FormDocReport"
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
    Friend WithEvents dtpDate As DateTimePicker
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
    Friend WithEvents chkDate As CheckBox
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents chkRemark2 As CheckBox
    Friend WithEvents chkRemark1 As CheckBox
    Friend WithEvents cboRemark2 As SysComboBox
    Friend WithEvents cboRemark1 As SysComboBox
End Class
