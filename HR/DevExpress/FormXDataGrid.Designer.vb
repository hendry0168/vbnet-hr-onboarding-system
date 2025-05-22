<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormXDataGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormXDataGrid))
        Me.tspMain = New System.Windows.Forms.ToolStrip()
        Me.btnOK = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.XDataGrid = New HR.XDataGrid()
        Me.tspMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspMain
        '
        Me.tspMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOK, Me.btnCancel, Me.btnClose})
        Me.tspMain.Location = New System.Drawing.Point(0, 0)
        Me.tspMain.Name = "tspMain"
        Me.tspMain.Size = New System.Drawing.Size(784, 39)
        Me.tspMain.TabIndex = 4
        Me.tspMain.Text = "ToolStrip1"
        '
        'btnOK
        '
        Me.btnOK.Image = Global.HR.My.Resources.Resources.icoOK
        Me.btnOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(59, 36)
        Me.btnOK.Text = "&OK"
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
        'btnClose
        '
        Me.btnClose.Image = Global.HR.My.Resources.Resources.icoClose
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 36)
        Me.btnClose.Text = "&Close"
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRemark.Location = New System.Drawing.Point(0, 39)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(69, 13)
        Me.lblRemark.TabIndex = 6
        Me.lblRemark.Text = "Remark label"
        Me.lblRemark.Visible = False
        '
        'XDataGrid
        '
        Me.XDataGrid.AllowMultiSelection = True
        Me.XDataGrid.CellMultiLine = False
        Me.XDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XDataGrid.EnableContextMenu = True
        Me.XDataGrid.Location = New System.Drawing.Point(0, 52)
        Me.XDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XDataGrid.MergeIdenticalCells = False
        Me.XDataGrid.Name = "XDataGrid"
        Me.XDataGrid.ShowFilterPanel = False
        Me.XDataGrid.ShowGroupFooter = False
        Me.XDataGrid.ShowGroupPanel = False
        Me.XDataGrid.ShowRowCountFooter = True
        Me.XDataGrid.Size = New System.Drawing.Size(784, 510)
        Me.XDataGrid.TabIndex = 5
        '
        'FormXDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.XDataGrid)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.tspMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormXDataGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tspMain.ResumeLayout(False)
        Me.tspMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tspMain As System.Windows.Forms.ToolStrip
    Public WithEvents XDataGrid As XDataGrid
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Public WithEvents btnClose As ToolStripButton
    Public WithEvents btnOK As ToolStripButton
    Public WithEvents btnCancel As ToolStripButton
End Class
