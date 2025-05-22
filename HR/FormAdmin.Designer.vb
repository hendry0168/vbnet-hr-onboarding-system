<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.tspMenu = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnView = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnStatusFilter = New System.Windows.Forms.ToolStripButton()
        Me.cboStatus = New System.Windows.Forms.ToolStripComboBox()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.XDataGrid = New HR.XDataGrid()
        Me.pctLoading = New System.Windows.Forms.PictureBox()
        Me.tspMenu.SuspendLayout()
        CType(Me.pctLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tspMenu
        '
        Me.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnEdit, Me.btnView, Me.btnClose, Me.btnStatusFilter, Me.cboStatus, Me.btnRefresh})
        Me.tspMenu.Location = New System.Drawing.Point(0, 0)
        Me.tspMenu.Name = "tspMenu"
        Me.tspMenu.Size = New System.Drawing.Size(800, 39)
        Me.tspMenu.TabIndex = 3
        Me.tspMenu.Text = "ToolStrip2"
        '
        'btnNew
        '
        Me.btnNew.Image = Global.HR.My.Resources.Resources.icoNew
        Me.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(67, 36)
        Me.btnNew.Text = "&New"
        Me.btnNew.ToolTipText = "New document"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.HR.My.Resources.Resources.icoEdit
        Me.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(63, 36)
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.ToolTipText = "Edit selected document"
        '
        'btnView
        '
        Me.btnView.Image = Global.HR.My.Resources.Resources.icoAuth
        Me.btnView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(113, 36)
        Me.btnView.Text = "&View/Process"
        Me.btnView.ToolTipText = "View/Process selected document"
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
        'btnStatusFilter
        '
        Me.btnStatusFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnStatusFilter.Image = CType(resources.GetObject("btnStatusFilter.Image"), System.Drawing.Image)
        Me.btnStatusFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStatusFilter.Name = "btnStatusFilter"
        Me.btnStatusFilter.Size = New System.Drawing.Size(43, 36)
        Me.btnStatusFilter.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 39)
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.HR.My.Resources.Resources.icoRefresh
        Me.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(82, 36)
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.ToolTipText = "Refresh data"
        '
        'XDataGrid
        '
        Me.XDataGrid.AllowMultiSelection = True
        Me.XDataGrid.CellMultiLine = False
        Me.XDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XDataGrid.EnableContextMenu = True
        Me.XDataGrid.Location = New System.Drawing.Point(0, 39)
        Me.XDataGrid.MergeIdenticalCells = False
        Me.XDataGrid.Name = "XDataGrid"
        Me.XDataGrid.ShowFilterPanel = False
        Me.XDataGrid.ShowGroupFooter = False
        Me.XDataGrid.ShowGroupPanel = False
        Me.XDataGrid.ShowRowCountFooter = True
        Me.XDataGrid.Size = New System.Drawing.Size(800, 411)
        Me.XDataGrid.TabIndex = 0
        '
        'pctLoading
        '
        Me.pctLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctLoading.Image = Global.HR.My.Resources.Resources.gifLoading
        Me.pctLoading.Location = New System.Drawing.Point(0, 39)
        Me.pctLoading.Name = "pctLoading"
        Me.pctLoading.Size = New System.Drawing.Size(800, 411)
        Me.pctLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctLoading.TabIndex = 25
        Me.pctLoading.TabStop = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pctLoading)
        Me.Controls.Add(Me.XDataGrid)
        Me.Controls.Add(Me.tspMenu)
        Me.Name = "FormAdmin"
        Me.Text = "Form Admin"
        Me.tspMenu.ResumeLayout(False)
        Me.tspMenu.PerformLayout()
        CType(Me.pctLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tspMenu As ToolStrip
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnView As ToolStripButton
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents XDataGrid As XDataGrid
    Friend WithEvents btnStatusFilter As ToolStripButton
    Friend WithEvents cboStatus As ToolStripComboBox
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents pctLoading As PictureBox
End Class
