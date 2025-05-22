<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.btnMainOnboarding = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnOnboardingEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOnboardingReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMainOffboarding = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnOffboardingEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOffboardingReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmployeeReport = New System.Windows.Forms.ToolStripButton()
        Me.btnMasterData = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnEducation = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGender = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReligion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmploymentType = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPersonnelLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDocStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPersonnelStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPersonnelType = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPersonnelAction = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tspMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspMain
        '
        Me.tspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMainOnboarding, Me.btnMainOffboarding, Me.btnEmployeeReport, Me.btnMasterData})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(732, 25)
        Me.tspMain.TabIndex = 1
        Me.tspMain.Text = "ToolStrip1"
        '
        'btnMainOnboarding
        '
        Me.btnMainOnboarding.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOnboardingEntry, Me.btnOnboardingReport})
        Me.btnMainOnboarding.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMainOnboarding.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMainOnboarding.Name = "btnMainOnboarding"
        Me.btnMainOnboarding.Size = New System.Drawing.Size(108, 22)
        Me.btnMainOnboarding.Text = "Doc Onboarding"
        '
        'btnOnboardingEntry
        '
        Me.btnOnboardingEntry.Name = "btnOnboardingEntry"
        Me.btnOnboardingEntry.Size = New System.Drawing.Size(176, 22)
        Me.btnOnboardingEntry.Text = "Onboarding Entry"
        '
        'btnOnboardingReport
        '
        Me.btnOnboardingReport.Name = "btnOnboardingReport"
        Me.btnOnboardingReport.Size = New System.Drawing.Size(176, 22)
        Me.btnOnboardingReport.Text = "Onboarding Report"
        '
        'btnMainOffboarding
        '
        Me.btnMainOffboarding.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOffboardingEntry, Me.btnOffboardingReport})
        Me.btnMainOffboarding.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMainOffboarding.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMainOffboarding.Name = "btnMainOffboarding"
        Me.btnMainOffboarding.Size = New System.Drawing.Size(109, 22)
        Me.btnMainOffboarding.Text = "Doc Offboarding"
        '
        'btnOffboardingEntry
        '
        Me.btnOffboardingEntry.Name = "btnOffboardingEntry"
        Me.btnOffboardingEntry.Size = New System.Drawing.Size(177, 22)
        Me.btnOffboardingEntry.Text = "Offboarding Entry"
        '
        'btnOffboardingReport
        '
        Me.btnOffboardingReport.Name = "btnOffboardingReport"
        Me.btnOffboardingReport.Size = New System.Drawing.Size(177, 22)
        Me.btnOffboardingReport.Text = "Offboarding Report"
        '
        'btnEmployeeReport
        '
        Me.btnEmployeeReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEmployeeReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployeeReport.Name = "btnEmployeeReport"
        Me.btnEmployeeReport.Size = New System.Drawing.Size(101, 22)
        Me.btnEmployeeReport.Text = "&Employee Report"
        '
        'btnMasterData
        '
        Me.btnMasterData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEducation, Me.btnGender, Me.btnReligion, Me.btnEmploymentType, Me.btnPersonnelLevel, Me.btnDocStatus, Me.btnPersonnelStatus, Me.btnPersonnelType, Me.btnPersonnelAction})
        Me.btnMasterData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMasterData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMasterData.Name = "btnMasterData"
        Me.btnMasterData.Size = New System.Drawing.Size(83, 22)
        Me.btnMasterData.Text = "Master Data"
        '
        'btnEducation
        '
        Me.btnEducation.Name = "btnEducation"
        Me.btnEducation.Size = New System.Drawing.Size(199, 22)
        Me.btnEducation.Text = "Education Entry"
        '
        'btnGender
        '
        Me.btnGender.Name = "btnGender"
        Me.btnGender.Size = New System.Drawing.Size(199, 22)
        Me.btnGender.Text = "Gender Entry"
        '
        'btnReligion
        '
        Me.btnReligion.Name = "btnReligion"
        Me.btnReligion.Size = New System.Drawing.Size(199, 22)
        Me.btnReligion.Text = "Religion Entry"
        '
        'btnEmploymentType
        '
        Me.btnEmploymentType.Name = "btnEmploymentType"
        Me.btnEmploymentType.Size = New System.Drawing.Size(199, 22)
        Me.btnEmploymentType.Text = "Employment Type Entry"
        '
        'btnPersonnelLevel
        '
        Me.btnPersonnelLevel.Name = "btnPersonnelLevel"
        Me.btnPersonnelLevel.Size = New System.Drawing.Size(199, 22)
        Me.btnPersonnelLevel.Text = "Personnel Level Entry"
        '
        'btnDocStatus
        '
        Me.btnDocStatus.Name = "btnDocStatus"
        Me.btnDocStatus.Size = New System.Drawing.Size(199, 22)
        Me.btnDocStatus.Text = "Document Status Entry"
        '
        'btnPersonnelStatus
        '
        Me.btnPersonnelStatus.Name = "btnPersonnelStatus"
        Me.btnPersonnelStatus.Size = New System.Drawing.Size(199, 22)
        Me.btnPersonnelStatus.Text = "Personnel Status Entry"
        '
        'btnPersonnelType
        '
        Me.btnPersonnelType.Name = "btnPersonnelType"
        Me.btnPersonnelType.Size = New System.Drawing.Size(199, 22)
        Me.btnPersonnelType.Text = "Personnel Type Entry"
        '
        'btnPersonnelAction
        '
        Me.btnPersonnelAction.Name = "btnPersonnelAction"
        Me.btnPersonnelAction.Size = New System.Drawing.Size(199, 22)
        Me.btnPersonnelAction.Text = "Personnel Action Entry"
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(528, 4)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(192, 20)
        Me.txtServerName.TabIndex = 2
        Me.txtServerName.Text = "LAPTOP-U55QS3H6\LIVE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Server Name :"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 36)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.tspMain)
        Me.Name = "FormMain"
        Me.Text = "Main Form"
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tspMain As ToolStrip
    Friend WithEvents btnMainOnboarding As ToolStripDropDownButton
    Friend WithEvents btnOnboardingEntry As ToolStripMenuItem
    Friend WithEvents btnOnboardingReport As ToolStripMenuItem
    Friend WithEvents btnMainOffboarding As ToolStripDropDownButton
    Friend WithEvents btnOffboardingEntry As ToolStripMenuItem
    Friend WithEvents btnOffboardingReport As ToolStripMenuItem
    Friend WithEvents btnEmployeeReport As ToolStripButton
    Friend WithEvents btnMasterData As ToolStripDropDownButton
    Friend WithEvents btnEducation As ToolStripMenuItem
    Friend WithEvents btnEmploymentType As ToolStripMenuItem
    Friend WithEvents btnGender As ToolStripMenuItem
    Friend WithEvents btnReligion As ToolStripMenuItem
    Friend WithEvents btnDocStatus As ToolStripMenuItem
    Friend WithEvents btnPersonnelStatus As ToolStripMenuItem
    Friend WithEvents btnPersonnelLevel As ToolStripMenuItem
    Friend WithEvents btnPersonnelType As ToolStripMenuItem
    Friend WithEvents btnPersonnelAction As ToolStripMenuItem
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents Label1 As Label
End Class
