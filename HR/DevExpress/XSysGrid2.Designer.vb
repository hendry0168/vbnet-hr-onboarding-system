<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XSysGrid2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
            cn.Close()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XSysGrid2))
        Me.bgwProcess = New System.ComponentModel.BackgroundWorker()
        Me.tspSearch = New System.Windows.Forms.ToolStrip()
        Me.lblSearch = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSetting = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExactStringSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pctViewReport = New System.Windows.Forms.PictureBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblLoading = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblMax = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFilter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmsFind = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlInitialize = New System.Windows.Forms.Panel()
        Me.lblInitialize = New System.Windows.Forms.Label()
        Me.XDataGrid = New XDataGrid()
        Me.tspSearch.SuspendLayout()
        CType(Me.pctViewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.cmsFind.SuspendLayout()
        Me.pnlInitialize.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgwProcess
        '
        Me.bgwProcess.WorkerReportsProgress = True
        Me.bgwProcess.WorkerSupportsCancellation = True
        '
        'tspSearch
        '
        resources.ApplyResources(Me.tspSearch, "tspSearch")
        Me.tspSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSearch, Me.txtSearch, Me.btnSearch, Me.btnSetting})
        Me.tspSearch.Name = "tspSearch"
        '
        'lblSearch
        '
        Me.lblSearch.Name = "lblSearch"
        resources.ApplyResources(Me.lblSearch, "lblSearch")
        '
        'txtSearch
        '
        Me.txtSearch.Name = "txtSearch"
        resources.ApplyResources(Me.txtSearch, "txtSearch")
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'btnSetting
        '
        Me.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExactStringSearchToolStripMenuItem, Me.ShowAllRecordsToolStripMenuItem})
        Me.btnSetting.Image = My.Resources.Resources.icoSetting
        resources.ApplyResources(Me.btnSetting, "btnSetting")
        Me.btnSetting.Name = "btnSetting"
        '
        'ExactStringSearchToolStripMenuItem
        '
        Me.ExactStringSearchToolStripMenuItem.Checked = True
        Me.ExactStringSearchToolStripMenuItem.CheckOnClick = True
        Me.ExactStringSearchToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExactStringSearchToolStripMenuItem.Image = My.Resources.Resources.icoSearch
        resources.ApplyResources(Me.ExactStringSearchToolStripMenuItem, "ExactStringSearchToolStripMenuItem")
        Me.ExactStringSearchToolStripMenuItem.Name = "ExactStringSearchToolStripMenuItem"
        '
        'ShowAllRecordsToolStripMenuItem
        '
        Me.ShowAllRecordsToolStripMenuItem.CheckOnClick = True
        resources.ApplyResources(Me.ShowAllRecordsToolStripMenuItem, "ShowAllRecordsToolStripMenuItem")
        Me.ShowAllRecordsToolStripMenuItem.Name = "ShowAllRecordsToolStripMenuItem"
        '
        'pctViewReport
        '
        resources.ApplyResources(Me.pctViewReport, "pctViewReport")
        Me.pctViewReport.Name = "pctViewReport"
        Me.pctViewReport.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLoading, Me.lblMax, Me.lblFilter})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        '
        'lblLoading
        '
        Me.lblLoading.Name = "lblLoading"
        resources.ApplyResources(Me.lblLoading, "lblLoading")
        '
        'lblMax
        '
        Me.lblMax.Name = "lblMax"
        resources.ApplyResources(Me.lblMax, "lblMax")
        '
        'lblFilter
        '
        Me.lblFilter.Name = "lblFilter"
        resources.ApplyResources(Me.lblFilter, "lblFilter")
        '
        'cmsFind
        '
        Me.cmsFind.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem})
        Me.cmsFind.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.cmsFind, "cmsFind")
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        resources.ApplyResources(Me.FindToolStripMenuItem, "FindToolStripMenuItem")
        '
        'pnlInitialize
        '
        Me.pnlInitialize.Controls.Add(Me.lblInitialize)
        resources.ApplyResources(Me.pnlInitialize, "pnlInitialize")
        Me.pnlInitialize.Name = "pnlInitialize"
        '
        'lblInitialize
        '
        resources.ApplyResources(Me.lblInitialize, "lblInitialize")
        Me.lblInitialize.Name = "lblInitialize"
        '
        'XDataGrid
        '
        Me.XDataGrid.AllowMultiSelection = True
        Me.XDataGrid.CellMultiLine = False
        resources.ApplyResources(Me.XDataGrid, "XDataGrid")
        Me.XDataGrid.EnableContextMenu = True
        Me.XDataGrid.MergeIdenticalCells = False
        Me.XDataGrid.Name = "XDataGrid"
        Me.XDataGrid.ShowFilterPanel = False
        Me.XDataGrid.ShowGroupFooter = False
        Me.XDataGrid.ShowGroupPanel = False
        Me.XDataGrid.ShowRowCountFooter = True
        '
        'XSysGrid2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlInitialize)
        Me.Controls.Add(Me.pctViewReport)
        Me.Controls.Add(Me.XDataGrid)
        Me.Controls.Add(Me.tspSearch)
        Me.Controls.Add(Me.StatusStrip)
        Me.Name = "XSysGrid2"
        Me.tspSearch.ResumeLayout(False)
        Me.tspSearch.PerformLayout()
        CType(Me.pctViewReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.cmsFind.ResumeLayout(False)
        Me.pnlInitialize.ResumeLayout(False)
        Me.pnlInitialize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents lblSearch As System.Windows.Forms.ToolStripLabel
    Public WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tspSearch As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents pctViewReport As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblMax As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFilter As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSetting As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ShowAllRecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsFind As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblLoading As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExactStringSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents XDataGrid As XDataGrid
    Public WithEvents bgwProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlInitialize As Panel
    Friend WithEvents lblInitialize As Label
End Class
