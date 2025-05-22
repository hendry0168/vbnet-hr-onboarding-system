<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XDataGrid
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
        Me.grcData = New DevExpress.XtraGrid.GridControl()
        Me.cmsXDataGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpandAllGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollapseAllGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowGroupPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowGroupFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllowCellMergeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFilterPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllowMultiLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowRowsCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelectedCellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grvItem = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tspSearch = New System.Windows.Forms.ToolStrip()
        Me.lblFilter = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripTextBox()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.tspRowCount = New System.Windows.Forms.StatusStrip()
        Me.lblTotalRecordsDisplayed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalRecordsSelected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RestoreLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grcData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsXDataGrid.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspSearch.SuspendLayout()
        Me.tspRowCount.SuspendLayout()
        Me.SuspendLayout()
        '
        'grcData
        '
        Me.grcData.ContextMenuStrip = Me.cmsXDataGrid
        Me.grcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcData.Location = New System.Drawing.Point(0, 0)
        Me.grcData.MainView = Me.grdData
        Me.grcData.Name = "grcData"
        Me.grcData.Size = New System.Drawing.Size(494, 265)
        Me.grcData.TabIndex = 6
        Me.grcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdData, Me.grvItem})
        '
        'cmsXDataGrid
        '
        Me.cmsXDataGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.ViewToolStripMenuItem, Me.CopySelectedCellToolStripMenuItem})
        Me.cmsXDataGrid.Name = "cmsXDataGrid"
        Me.cmsXDataGrid.Size = New System.Drawing.Size(186, 118)
        Me.cmsXDataGrid.Text = "XDataGrid Options"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.ExportToolStripMenuItem.Image = My.Resources.Resources.icoText
        Me.ExportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(185, 38)
        Me.ExportToolStripMenuItem.Text = "Export to File"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = My.Resources.Resources.icoExcel
        Me.ExcelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(116, 38)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Image = My.Resources.Resources.icoAdobe
        Me.PDFToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(116, 38)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpandAllGroupsToolStripMenuItem, Me.CollapseAllGroupsToolStripMenuItem, Me.ShowGroupPanelToolStripMenuItem, Me.ShowGroupFooterToolStripMenuItem, Me.AllowCellMergeToolStripMenuItem, Me.ShowFilterPanelToolStripMenuItem, Me.AllowMultiLineToolStripMenuItem, Me.ShowRowsCountToolStripMenuItem, Me.SaveLayoutToolStripMenuItem, Me.RestoreLayoutToolStripMenuItem})
        Me.ViewToolStripMenuItem.Image = My.Resources.Resources.icoView
        Me.ViewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(185, 38)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ExpandAllGroupsToolStripMenuItem
        '
        Me.ExpandAllGroupsToolStripMenuItem.Image = My.Resources.Resources.icoPlus
        Me.ExpandAllGroupsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExpandAllGroupsToolStripMenuItem.Name = "ExpandAllGroupsToolStripMenuItem"
        Me.ExpandAllGroupsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExpandAllGroupsToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.ExpandAllGroupsToolStripMenuItem.Text = "Expand All Groups"
        '
        'CollapseAllGroupsToolStripMenuItem
        '
        Me.CollapseAllGroupsToolStripMenuItem.Image = My.Resources.Resources.icoMinus
        Me.CollapseAllGroupsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CollapseAllGroupsToolStripMenuItem.Name = "CollapseAllGroupsToolStripMenuItem"
        Me.CollapseAllGroupsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CollapseAllGroupsToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.CollapseAllGroupsToolStripMenuItem.Text = "Collapse All Groups"
        '
        'ShowGroupPanelToolStripMenuItem
        '
        Me.ShowGroupPanelToolStripMenuItem.CheckOnClick = True
        Me.ShowGroupPanelToolStripMenuItem.Image = My.Resources.Resources.icoMaster
        Me.ShowGroupPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShowGroupPanelToolStripMenuItem.Name = "ShowGroupPanelToolStripMenuItem"
        Me.ShowGroupPanelToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ShowGroupPanelToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.ShowGroupPanelToolStripMenuItem.Text = "Show Group Panel"
        '
        'ShowGroupFooterToolStripMenuItem
        '
        Me.ShowGroupFooterToolStripMenuItem.CheckOnClick = True
        Me.ShowGroupFooterToolStripMenuItem.Image = My.Resources.Resources.icoMaster
        Me.ShowGroupFooterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShowGroupFooterToolStripMenuItem.Name = "ShowGroupFooterToolStripMenuItem"
        Me.ShowGroupFooterToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ShowGroupFooterToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.ShowGroupFooterToolStripMenuItem.Text = "Show Group Footer"
        '
        'AllowCellMergeToolStripMenuItem
        '
        Me.AllowCellMergeToolStripMenuItem.CheckOnClick = True
        Me.AllowCellMergeToolStripMenuItem.Image = My.Resources.Resources.icoMaster
        Me.AllowCellMergeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllowCellMergeToolStripMenuItem.Name = "AllowCellMergeToolStripMenuItem"
        Me.AllowCellMergeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.AllowCellMergeToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.AllowCellMergeToolStripMenuItem.Text = "Merge Identical Cells"
        '
        'ShowFilterPanelToolStripMenuItem
        '
        Me.ShowFilterPanelToolStripMenuItem.CheckOnClick = True
        Me.ShowFilterPanelToolStripMenuItem.Image = My.Resources.Resources.icoSearch
        Me.ShowFilterPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShowFilterPanelToolStripMenuItem.Name = "ShowFilterPanelToolStripMenuItem"
        Me.ShowFilterPanelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ShowFilterPanelToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.ShowFilterPanelToolStripMenuItem.Text = "Show Filter Panel"
        '
        'AllowMultiLineToolStripMenuItem
        '
        Me.AllowMultiLineToolStripMenuItem.CheckOnClick = True
        Me.AllowMultiLineToolStripMenuItem.Image = My.Resources.Resources.icoText
        Me.AllowMultiLineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllowMultiLineToolStripMenuItem.Name = "AllowMultiLineToolStripMenuItem"
        Me.AllowMultiLineToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.AllowMultiLineToolStripMenuItem.Text = "Allow Multi Line"
        '
        'ShowRowsCountToolStripMenuItem
        '
        Me.ShowRowsCountToolStripMenuItem.Checked = True
        Me.ShowRowsCountToolStripMenuItem.CheckOnClick = True
        Me.ShowRowsCountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowRowsCountToolStripMenuItem.Image = My.Resources.Resources.icoText
        Me.ShowRowsCountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShowRowsCountToolStripMenuItem.Name = "ShowRowsCountToolStripMenuItem"
        Me.ShowRowsCountToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.ShowRowsCountToolStripMenuItem.Text = "Show Rows Count"
        '
        'SaveLayoutToolStripMenuItem
        '
        Me.SaveLayoutToolStripMenuItem.Image = My.Resources.Resources.icoSave
        Me.SaveLayoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveLayoutToolStripMenuItem.Name = "SaveLayoutToolStripMenuItem"
        Me.SaveLayoutToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.SaveLayoutToolStripMenuItem.Text = "Save Layout"
        '
        'CopySelectedCellToolStripMenuItem
        '
        Me.CopySelectedCellToolStripMenuItem.Image = My.Resources.Resources.icoCopy
        Me.CopySelectedCellToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopySelectedCellToolStripMenuItem.Name = "CopySelectedCellToolStripMenuItem"
        Me.CopySelectedCellToolStripMenuItem.Size = New System.Drawing.Size(185, 38)
        Me.CopySelectedCellToolStripMenuItem.Text = "Copy selected cell"
        '
        'grdData
        '
        Me.grdData.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grdData.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.grdData.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdData.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grdData.Appearance.FocusedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grdData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.grdData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grdData.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grdData.Appearance.SelectedRow.BackColor = System.Drawing.Color.CornflowerBlue
        Me.grdData.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.grdData.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grdData.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grdData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grdData.GridControl = Me.grcData
        Me.grdData.GroupFormat = "{1}"
        Me.grdData.Name = "grdData"
        Me.grdData.OptionsBehavior.Editable = False
        Me.grdData.OptionsLayout.Columns.AddNewColumns = False
        Me.grdData.OptionsLayout.Columns.RemoveOldColumns = False
        Me.grdData.OptionsLayout.Columns.StoreLayout = False
        Me.grdData.OptionsPrint.ExpandAllDetails = True
        Me.grdData.OptionsPrint.PrintDetails = True
        Me.grdData.OptionsPrint.PrintPreview = True
        Me.grdData.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grdData.OptionsSelection.MultiSelect = True
        Me.grdData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.grdData.OptionsView.AutoCalcPreviewLineCount = True
        Me.grdData.OptionsView.ColumnAutoWidth = False
        Me.grdData.OptionsView.ShowFooter = True
        Me.grdData.OptionsView.ShowGroupPanel = False
        '
        'grvItem
        '
        Me.grvItem.GridControl = Me.grcData
        Me.grvItem.Name = "grvItem"
        '
        'tspSearch
        '
        Me.tspSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFilter, Me.txtFilter, Me.btnClose})
        Me.tspSearch.Location = New System.Drawing.Point(0, 0)
        Me.tspSearch.Name = "tspSearch"
        Me.tspSearch.Size = New System.Drawing.Size(494, 25)
        Me.tspSearch.TabIndex = 8
        Me.tspSearch.Text = "ToolStrip1"
        Me.tspSearch.Visible = False
        '
        'lblFilter
        '
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(33, 22)
        Me.lblFilter.Text = "&Filter"
        '
        'txtFilter
        '
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(200, 25)
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = My.Resources.Resources.icoError
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 22)
        Me.btnClose.Text = "Hide Filter Panel"
        '
        'tspRowCount
        '
        Me.tspRowCount.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTotalRecordsDisplayed, Me.lblTotalRecordsSelected})
        Me.tspRowCount.Location = New System.Drawing.Point(0, 265)
        Me.tspRowCount.Name = "tspRowCount"
        Me.tspRowCount.Size = New System.Drawing.Size(494, 22)
        Me.tspRowCount.TabIndex = 9
        Me.tspRowCount.Text = "StatusStrip1"
        '
        'lblTotalRecordsDisplayed
        '
        Me.lblTotalRecordsDisplayed.Name = "lblTotalRecordsDisplayed"
        Me.lblTotalRecordsDisplayed.Size = New System.Drawing.Size(0, 17)
        '
        'lblTotalRecordsSelected
        '
        Me.lblTotalRecordsSelected.Name = "lblTotalRecordsSelected"
        Me.lblTotalRecordsSelected.Size = New System.Drawing.Size(0, 17)
        '
        'RestoreLayoutToolStripMenuItem
        '
        Me.RestoreLayoutToolStripMenuItem.Image = My.Resources.Resources.icoRefresh
        Me.RestoreLayoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RestoreLayoutToolStripMenuItem.Name = "RestoreLayoutToolStripMenuItem"
        Me.RestoreLayoutToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.RestoreLayoutToolStripMenuItem.Text = "Restore Layout"
        '
        'XDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grcData)
        Me.Controls.Add(Me.tspSearch)
        Me.Controls.Add(Me.tspRowCount)
        Me.Name = "XDataGrid"
        Me.Size = New System.Drawing.Size(494, 287)
        CType(Me.grcData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsXDataGrid.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspSearch.ResumeLayout(False)
        Me.tspSearch.PerformLayout()
        Me.tspRowCount.ResumeLayout(False)
        Me.tspRowCount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents grcData As DevExpress.XtraGrid.GridControl
    Public WithEvents grdData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmsXDataGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowGroupPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpandAllGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollapseAllGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllowCellMergeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowFilterPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tspSearch As System.Windows.Forms.ToolStrip
    Friend WithEvents lblFilter As System.Windows.Forms.ToolStripLabel
    Public WithEvents txtFilter As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ShowGroupFooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopySelectedCellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllowMultiLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tspRowCount As StatusStrip
    Friend WithEvents lblTotalRecordsDisplayed As ToolStripStatusLabel
    Friend WithEvents lblTotalRecordsSelected As ToolStripStatusLabel
    Friend WithEvents ShowRowsCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreLayoutToolStripMenuItem As ToolStripMenuItem
End Class
