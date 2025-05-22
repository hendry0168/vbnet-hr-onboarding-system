<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportXGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportXGrid))
        Me.grvItem = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grcReport = New DevExpress.XtraGrid.GridControl
        Me.grdReport = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnExport = New System.Windows.Forms.ToolStripDropDownButton
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnGridSetting = New System.Windows.Forms.ToolStripButton
        Me.btnCancel = New System.Windows.Forms.ToolStripButton
        Me.colTicketNo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPostingDate1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colVehicle1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTransporter1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colVendor1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMaterial1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDocHeader1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOrderNo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDeliveryOrder1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBCNo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBCDate1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLocisNo1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInitialIn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInitialOut1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInitialFFA1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInitialMoisture1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInitialImpurities1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colWeighIn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colWeighOut1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFFA1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMoisture1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colImpurities1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInTime1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colOutTime1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStation1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSLoc1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSBin1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colRemark1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        CType(Me.grvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grvItem
        '
        Me.grvItem.GridControl = Me.grcReport
        Me.grvItem.Name = "grvItem"
        '
        'grcReport
        '
        Me.grcReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcReport.Location = New System.Drawing.Point(0, 39)
        Me.grcReport.MainView = Me.grdReport
        Me.grcReport.Name = "grcReport"
        Me.grcReport.Size = New System.Drawing.Size(792, 527)
        Me.grcReport.TabIndex = 5
        Me.grcReport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdReport, Me.grvItem})
        '
        'grdReport
        '
        Me.grdReport.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdReport.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdReport.GridControl = Me.grcReport
        Me.grdReport.Name = "grdReport"
        Me.grdReport.OptionsBehavior.Editable = False
        Me.grdReport.OptionsPrint.ExpandAllDetails = True
        Me.grdReport.OptionsPrint.PrintDetails = True
        Me.grdReport.OptionsPrint.PrintPreview = True
        Me.grdReport.OptionsPrint.UsePrintStyles = True
        Me.grdReport.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grdReport.OptionsSelection.MultiSelect = True
        Me.grdReport.OptionsView.AllowCellMerge = True
        Me.grdReport.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.grdReport.OptionsView.AutoCalcPreviewLineCount = True
        Me.grdReport.OptionsView.ColumnAutoWidth = False
        Me.grdReport.OptionsView.ShowFooter = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExport, Me.btnGridSetting, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 39)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnExport
        '
        Me.btnExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.ExportToPDFToolStripMenuItem, Me.ExportToTextToolStripMenuItem})
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(85, 36)
        Me.btnExport.Text = "E&xport"
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Image = CType(resources.GetObject("ExportToExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export to Excel"
        '
        'ExportToPDFToolStripMenuItem
        '
        Me.ExportToPDFToolStripMenuItem.Image = CType(resources.GetObject("ExportToPDFToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportToPDFToolStripMenuItem.Name = "ExportToPDFToolStripMenuItem"
        Me.ExportToPDFToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToPDFToolStripMenuItem.Text = "Export to PDF"
        '
        'ExportToTextToolStripMenuItem
        '
        Me.ExportToTextToolStripMenuItem.Image = CType(resources.GetObject("ExportToTextToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportToTextToolStripMenuItem.Name = "ExportToTextToolStripMenuItem"
        Me.ExportToTextToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExportToTextToolStripMenuItem.Text = "Export to Text"
        '
        'btnGridSetting
        '
        Me.btnGridSetting.Image = CType(resources.GetObject("btnGridSetting.Image"), System.Drawing.Image)
        Me.btnGridSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGridSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGridSetting.Name = "btnGridSetting"
        Me.btnGridSetting.Size = New System.Drawing.Size(131, 36)
        Me.btnGridSetting.Text = "XtraGrid Settings"
        Me.btnGridSetting.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = My.Resources.Resources.icoClose
        Me.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 36)
        Me.btnCancel.Text = "&Close"
        '
        'colTicketNo1
        '
        Me.colTicketNo1.Caption = "Ticket No"
        Me.colTicketNo1.FieldName = "Ticket No"
        Me.colTicketNo1.Name = "colTicketNo1"
        Me.colTicketNo1.Visible = True
        '
        'colPostingDate1
        '
        Me.colPostingDate1.Caption = "Posting Date"
        Me.colPostingDate1.FieldName = "Posting Date"
        Me.colPostingDate1.Name = "colPostingDate1"
        Me.colPostingDate1.Visible = True
        '
        'colVehicle1
        '
        Me.colVehicle1.Caption = "Vehicle"
        Me.colVehicle1.FieldName = "Vehicle"
        Me.colVehicle1.Name = "colVehicle1"
        Me.colVehicle1.Visible = True
        '
        'colTransporter1
        '
        Me.colTransporter1.Caption = "Transporter"
        Me.colTransporter1.FieldName = "Transporter"
        Me.colTransporter1.Name = "colTransporter1"
        Me.colTransporter1.Visible = True
        '
        'colVendor1
        '
        Me.colVendor1.Caption = "Vendor"
        Me.colVendor1.FieldName = "Vendor"
        Me.colVendor1.Name = "colVendor1"
        Me.colVendor1.Visible = True
        '
        'colMaterial1
        '
        Me.colMaterial1.Caption = "Material"
        Me.colMaterial1.FieldName = "Material"
        Me.colMaterial1.Name = "colMaterial1"
        Me.colMaterial1.Visible = True
        '
        'colDocHeader1
        '
        Me.colDocHeader1.Caption = "Doc Header"
        Me.colDocHeader1.FieldName = "Doc Header"
        Me.colDocHeader1.Name = "colDocHeader1"
        Me.colDocHeader1.Visible = True
        '
        'colOrderNo1
        '
        Me.colOrderNo1.Caption = "Order No"
        Me.colOrderNo1.FieldName = "Order No"
        Me.colOrderNo1.Name = "colOrderNo1"
        Me.colOrderNo1.Visible = True
        '
        'colDeliveryOrder1
        '
        Me.colDeliveryOrder1.Caption = "Delivery Order"
        Me.colDeliveryOrder1.FieldName = "Delivery Order"
        Me.colDeliveryOrder1.Name = "colDeliveryOrder1"
        Me.colDeliveryOrder1.Visible = True
        '
        'colBCNo1
        '
        Me.colBCNo1.Caption = "BC No"
        Me.colBCNo1.FieldName = "BC No"
        Me.colBCNo1.Name = "colBCNo1"
        Me.colBCNo1.Visible = True
        '
        'colBCDate1
        '
        Me.colBCDate1.Caption = "BC Date"
        Me.colBCDate1.FieldName = "BC Date"
        Me.colBCDate1.Name = "colBCDate1"
        Me.colBCDate1.Visible = True
        '
        'colLocisNo1
        '
        Me.colLocisNo1.Caption = "Locis No"
        Me.colLocisNo1.FieldName = "Locis No"
        Me.colLocisNo1.Name = "colLocisNo1"
        Me.colLocisNo1.Visible = True
        '
        'colInitialIn1
        '
        Me.colInitialIn1.Caption = "Initial In"
        Me.colInitialIn1.FieldName = "Initial In"
        Me.colInitialIn1.Name = "colInitialIn1"
        Me.colInitialIn1.Visible = True
        '
        'colInitialOut1
        '
        Me.colInitialOut1.Caption = "Initial Out"
        Me.colInitialOut1.FieldName = "Initial Out"
        Me.colInitialOut1.Name = "colInitialOut1"
        Me.colInitialOut1.Visible = True
        '
        'colInitialFFA1
        '
        Me.colInitialFFA1.Caption = "Initial FFA"
        Me.colInitialFFA1.FieldName = "Initial FFA"
        Me.colInitialFFA1.Name = "colInitialFFA1"
        Me.colInitialFFA1.OptionsColumn.ReadOnly = True
        Me.colInitialFFA1.Visible = True
        '
        'colInitialMoisture1
        '
        Me.colInitialMoisture1.Caption = "Initial Moisture"
        Me.colInitialMoisture1.FieldName = "Initial Moisture"
        Me.colInitialMoisture1.Name = "colInitialMoisture1"
        Me.colInitialMoisture1.OptionsColumn.ReadOnly = True
        Me.colInitialMoisture1.Visible = True
        '
        'colInitialImpurities1
        '
        Me.colInitialImpurities1.Caption = "Initial Impurities"
        Me.colInitialImpurities1.FieldName = "Initial Impurities"
        Me.colInitialImpurities1.Name = "colInitialImpurities1"
        Me.colInitialImpurities1.OptionsColumn.ReadOnly = True
        Me.colInitialImpurities1.Visible = True
        '
        'colWeighIn1
        '
        Me.colWeighIn1.Caption = "Weigh In"
        Me.colWeighIn1.FieldName = "Weigh In"
        Me.colWeighIn1.Name = "colWeighIn1"
        Me.colWeighIn1.Visible = True
        '
        'colWeighOut1
        '
        Me.colWeighOut1.Caption = "Weigh Out"
        Me.colWeighOut1.FieldName = "Weigh Out"
        Me.colWeighOut1.Name = "colWeighOut1"
        Me.colWeighOut1.Visible = True
        '
        'colFFA1
        '
        Me.colFFA1.Caption = "FFA"
        Me.colFFA1.FieldName = "FFA"
        Me.colFFA1.Name = "colFFA1"
        Me.colFFA1.OptionsColumn.ReadOnly = True
        Me.colFFA1.Visible = True
        '
        'colMoisture1
        '
        Me.colMoisture1.Caption = "Moisture"
        Me.colMoisture1.FieldName = "Moisture"
        Me.colMoisture1.Name = "colMoisture1"
        Me.colMoisture1.OptionsColumn.ReadOnly = True
        Me.colMoisture1.Visible = True
        '
        'colImpurities1
        '
        Me.colImpurities1.Caption = "Impurities"
        Me.colImpurities1.FieldName = "Impurities"
        Me.colImpurities1.Name = "colImpurities1"
        Me.colImpurities1.OptionsColumn.ReadOnly = True
        Me.colImpurities1.Visible = True
        '
        'colInTime1
        '
        Me.colInTime1.Caption = "In Time"
        Me.colInTime1.FieldName = "In Time"
        Me.colInTime1.Name = "colInTime1"
        Me.colInTime1.Visible = True
        '
        'colOutTime1
        '
        Me.colOutTime1.Caption = "Time Out"
        Me.colOutTime1.FieldName = "Time Out"
        Me.colOutTime1.Name = "colOutTime1"
        Me.colOutTime1.Visible = True
        '
        'colStation1
        '
        Me.colStation1.Caption = "Station"
        Me.colStation1.FieldName = "Station"
        Me.colStation1.Name = "colStation1"
        Me.colStation1.Visible = True
        '
        'colSLoc1
        '
        Me.colSLoc1.Caption = "S Loc"
        Me.colSLoc1.FieldName = "S Loc"
        Me.colSLoc1.Name = "colSLoc1"
        Me.colSLoc1.Visible = True
        '
        'colSBin1
        '
        Me.colSBin1.Caption = "S Bin"
        Me.colSBin1.FieldName = "S Bin"
        Me.colSBin1.Name = "colSBin1"
        Me.colSBin1.Visible = True
        '
        'colRemark1
        '
        Me.colRemark1.Caption = "Remark"
        Me.colRemark1.FieldName = "Remark"
        Me.colRemark1.Name = "colRemark1"
        Me.colRemark1.Visible = True
        '
        'FormReportXGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.grcReport)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReportXGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Data in XtraGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents colTicketNo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPostingDate1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVehicle1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTransporter1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVendor1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaterial1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDocHeader1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOrderNo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDeliveryOrder1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBCNo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBCDate1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLocisNo1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInitialIn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInitialOut1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInitialFFA1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInitialMoisture1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInitialImpurities1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWeighIn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWeighOut1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFFA1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMoisture1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colImpurities1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInTime1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOutTime1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStation1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSLoc1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSBin1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemark1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnExport As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGridSetting As System.Windows.Forms.ToolStripButton
    Friend WithEvents grvItem As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents grcReport As DevExpress.XtraGrid.GridControl
    Public WithEvents grdReport As DevExpress.XtraGrid.Views.Grid.GridView
End Class
