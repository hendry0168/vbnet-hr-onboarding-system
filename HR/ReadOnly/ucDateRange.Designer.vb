<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDateRange
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucDateRange))
        Me.chkTo = New System.Windows.Forms.CheckBox()
        Me.dtpFinish = New DevExpress.XtraEditors.DateEdit()
        Me.cmsDateFilter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UseDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpStart = New DevExpress.XtraEditors.DateEdit()
        CType(Me.dtpFinish.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFinish.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDateFilter.SuspendLayout()
        CType(Me.dtpStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkTo
        '
        Me.chkTo.AutoSize = True
        Me.chkTo.Location = New System.Drawing.Point(140, 2)
        Me.chkTo.Name = "chkTo"
        Me.chkTo.Size = New System.Drawing.Size(35, 17)
        Me.chkTo.TabIndex = 8
        Me.chkTo.Text = "&to"
        Me.chkTo.UseVisualStyleBackColor = True
        Me.chkTo.Visible = False
        '
        'dtpFinish
        '
        Me.dtpFinish.EditValue = New Date(2008, 8, 5, 11, 20, 38, 125)
        Me.dtpFinish.Location = New System.Drawing.Point(179, 0)
        Me.dtpFinish.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpFinish.Name = "dtpFinish"
        Me.dtpFinish.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFinish.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFinish.Properties.ContextMenuStrip = Me.cmsDateFilter
        Me.dtpFinish.Properties.DisplayFormat.FormatString = "dd MMM yyyy HH:mm"
        Me.dtpFinish.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpFinish.Properties.Mask.BeepOnError = True
        Me.dtpFinish.Properties.Mask.EditMask = "dd MMM yyyy HH:mm"
        Me.dtpFinish.Size = New System.Drawing.Size(136, 20)
        Me.dtpFinish.TabIndex = 9
        Me.dtpFinish.Visible = False
        '
        'cmsDateFilter
        '
        Me.cmsDateFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseDateToolStripMenuItem, Me.UseMonthToolStripMenuItem, Me.UseYearToolStripMenuItem})
        Me.cmsDateFilter.Name = "cmsDateFilter"
        Me.cmsDateFilter.Size = New System.Drawing.Size(149, 118)
        '
        'UseDateToolStripMenuItem
        '
        Me.UseDateToolStripMenuItem.Image = CType(resources.GetObject("UseDateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UseDateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UseDateToolStripMenuItem.Name = "UseDateToolStripMenuItem"
        Me.UseDateToolStripMenuItem.Size = New System.Drawing.Size(148, 38)
        Me.UseDateToolStripMenuItem.Text = "Use date"
        '
        'UseMonthToolStripMenuItem
        '
        Me.UseMonthToolStripMenuItem.Image = CType(resources.GetObject("UseMonthToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UseMonthToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UseMonthToolStripMenuItem.Name = "UseMonthToolStripMenuItem"
        Me.UseMonthToolStripMenuItem.Size = New System.Drawing.Size(148, 38)
        Me.UseMonthToolStripMenuItem.Text = "Use month"
        '
        'UseYearToolStripMenuItem
        '
        Me.UseYearToolStripMenuItem.Image = CType(resources.GetObject("UseYearToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UseYearToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UseYearToolStripMenuItem.Name = "UseYearToolStripMenuItem"
        Me.UseYearToolStripMenuItem.Size = New System.Drawing.Size(148, 38)
        Me.UseYearToolStripMenuItem.Text = "Use year"
        Me.UseYearToolStripMenuItem.Visible = False
        '
        'dtpStart
        '
        Me.dtpStart.EditValue = New Date(2008, 8, 5, 11, 20, 30, 46)
        Me.dtpStart.Location = New System.Drawing.Point(0, 0)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(1)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpStart.Properties.ContextMenuStrip = Me.cmsDateFilter
        Me.dtpStart.Properties.DisplayFormat.FormatString = "dd MMM yyyy HH:mm"
        Me.dtpStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtpStart.Properties.Mask.BeepOnError = True
        Me.dtpStart.Properties.Mask.EditMask = "dd MMM yyyy HH:mm"
        Me.dtpStart.Size = New System.Drawing.Size(136, 20)
        Me.dtpStart.TabIndex = 7
        '
        'ucDateRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkTo)
        Me.Controls.Add(Me.dtpFinish)
        Me.Controls.Add(Me.dtpStart)
        Me.Name = "ucDateRange"
        Me.Size = New System.Drawing.Size(316, 20)
        CType(Me.dtpFinish.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFinish.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDateFilter.ResumeLayout(False)
        CType(Me.dtpStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFinish As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmsDateFilter As ContextMenuStrip
    Friend WithEvents UseDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UseMonthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UseYearToolStripMenuItem As ToolStripMenuItem
    Public WithEvents chkTo As CheckBox
End Class
