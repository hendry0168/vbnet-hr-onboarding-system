<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataVisualizer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataVisualizer))
        Me.cboDataTable = New System.Windows.Forms.ComboBox()
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnDownload = New System.Windows.Forms.ToolStripButton()
        Me.btnOK = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.dgvTables = New System.Windows.Forms.DataGridView()
        Me.clmTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRowCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xdgData = New XDataGrid()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.tspMain.SuspendLayout()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDataTable
        '
        Me.cboDataTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboDataTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataTable.FormattingEnabled = True
        Me.cboDataTable.Location = New System.Drawing.Point(0, 39)
        Me.cboDataTable.Name = "cboDataTable"
        Me.cboDataTable.Size = New System.Drawing.Size(752, 21)
        Me.cboDataTable.TabIndex = 0
        Me.cboDataTable.Visible = False
        '
        'tspMain
        '
        Me.tspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDownload, Me.btnOK, Me.btnCancel, Me.btnClose})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(752, 39)
        Me.tspMain.TabIndex = 3
        Me.tspMain.Text = "ToolStrip1"
        '
        'btnDownload
        '
        Me.btnDownload.Image = Global.PHG_System.My.Resources.Resources.icoDownloadHDD
        Me.btnDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(97, 36)
        Me.btnDownload.Text = "&Download"
        '
        'btnOK
        '
        Me.btnOK.Image = Global.PHG_System.My.Resources.Resources.icoOK
        Me.btnOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(59, 36)
        Me.btnOK.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.PHG_System.My.Resources.Resources.icoCancel
        Me.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 36)
        Me.btnCancel.Text = "&Cancel"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.PHG_System.My.Resources.Resources.icoClose
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 36)
        Me.btnClose.Text = "Close"
        '
        'dgvTables
        '
        Me.dgvTables.AllowUserToAddRows = False
        Me.dgvTables.AllowUserToDeleteRows = False
        Me.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTables.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTable, Me.clmRowCount})
        Me.dgvTables.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvTables.Location = New System.Drawing.Point(0, 60)
        Me.dgvTables.MultiSelect = False
        Me.dgvTables.Name = "dgvTables"
        Me.dgvTables.ReadOnly = True
        Me.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTables.Size = New System.Drawing.Size(249, 381)
        Me.dgvTables.TabIndex = 4
        '
        'clmTable
        '
        Me.clmTable.FillWeight = 80.0!
        Me.clmTable.HeaderText = "Table"
        Me.clmTable.Name = "clmTable"
        Me.clmTable.ReadOnly = True
        '
        'clmRowCount
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmRowCount.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmRowCount.FillWeight = 20.0!
        Me.clmRowCount.HeaderText = "Rows"
        Me.clmRowCount.Name = "clmRowCount"
        Me.clmRowCount.ReadOnly = True
        '
        'xdgData
        '
        Me.xdgData.AllowMultiSelection = True
        Me.xdgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xdgData.EnableContextMenu = True
        Me.xdgData.Location = New System.Drawing.Point(249, 103)
        Me.xdgData.MergeIdenticalCells = False
        Me.xdgData.Name = "xdgData"
        Me.xdgData.ShowFilterPanel = False
        Me.xdgData.ShowGroupFooter = False
        Me.xdgData.ShowGroupPanel = False
        Me.xdgData.Size = New System.Drawing.Size(503, 338)
        Me.xdgData.TabIndex = 5
        '
        'btnCSV
        '
        Me.btnCSV.BackgroundImage = Global.PHG_System.My.Resources.Resources.icoDownloadHDD
        Me.btnCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCSV.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCSV.Location = New System.Drawing.Point(249, 60)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(503, 43)
        Me.btnCSV.TabIndex = 6
        Me.btnCSV.Text = "Save CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'FormDataVisualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 441)
        Me.Controls.Add(Me.xdgData)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.dgvTables)
        Me.Controls.Add(Me.cboDataTable)
        Me.Controls.Add(Me.tspMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDataVisualizer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Visualizer"
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDataTable As System.Windows.Forms.ComboBox
    Friend WithEvents tspMain As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDownload As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOK As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvTables As System.Windows.Forms.DataGridView
    Friend WithEvents clmTable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRowCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xdgData As XDataGrid
    Friend WithEvents btnCSV As System.Windows.Forms.Button
End Class
