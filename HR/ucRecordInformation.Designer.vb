<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRecordInformation
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
        Me.grpRecordInfo = New System.Windows.Forms.GroupBox()
        Me.pnlNoRecord = New System.Windows.Forms.Panel()
        Me.lblNoRecord = New System.Windows.Forms.Label()
        Me.txtDTUpdate = New System.Windows.Forms.TextBox()
        Me.txtDTCreate = New System.Windows.Forms.TextBox()
        Me.txtIDUpdate = New System.Windows.Forms.TextBox()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.txtIDCreate = New System.Windows.Forms.TextBox()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.tlpRecordInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpRecordInfo.SuspendLayout()
        Me.pnlNoRecord.SuspendLayout()
        Me.tlpRecordInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRecordInfo
        '
        Me.grpRecordInfo.Controls.Add(Me.pnlNoRecord)
        Me.grpRecordInfo.Controls.Add(Me.tlpRecordInfo)
        Me.grpRecordInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRecordInfo.Location = New System.Drawing.Point(0, 0)
        Me.grpRecordInfo.Margin = New System.Windows.Forms.Padding(1)
        Me.grpRecordInfo.Name = "grpRecordInfo"
        Me.grpRecordInfo.Size = New System.Drawing.Size(493, 70)
        Me.grpRecordInfo.TabIndex = 3
        Me.grpRecordInfo.TabStop = False
        Me.grpRecordInfo.Text = "Record Information"
        '
        'pnlNoRecord
        '
        Me.pnlNoRecord.Controls.Add(Me.lblNoRecord)
        Me.pnlNoRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNoRecord.Location = New System.Drawing.Point(3, 16)
        Me.pnlNoRecord.Name = "pnlNoRecord"
        Me.pnlNoRecord.Size = New System.Drawing.Size(487, 51)
        Me.pnlNoRecord.TabIndex = 6
        Me.pnlNoRecord.Visible = False
        '
        'lblNoRecord
        '
        Me.lblNoRecord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNoRecord.AutoSize = True
        Me.lblNoRecord.Location = New System.Drawing.Point(167, 19)
        Me.lblNoRecord.Name = "lblNoRecord"
        Me.lblNoRecord.Size = New System.Drawing.Size(153, 13)
        Me.lblNoRecord.TabIndex = 0
        Me.lblNoRecord.Text = "No record information available"
        '
        'txtDTUpdate
        '
        Me.txtDTUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDTUpdate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDTUpdate.Location = New System.Drawing.Point(100, 0)
        Me.txtDTUpdate.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDTUpdate.Name = "txtDTUpdate"
        Me.txtDTUpdate.ReadOnly = True
        Me.txtDTUpdate.Size = New System.Drawing.Size(138, 18)
        Me.txtDTUpdate.TabIndex = 5
        Me.txtDTUpdate.TabStop = False
        '
        'txtDTCreate
        '
        Me.txtDTCreate.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDTCreate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDTCreate.Location = New System.Drawing.Point(100, 0)
        Me.txtDTCreate.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDTCreate.Name = "txtDTCreate"
        Me.txtDTCreate.ReadOnly = True
        Me.txtDTCreate.Size = New System.Drawing.Size(137, 18)
        Me.txtDTCreate.TabIndex = 2
        Me.txtDTCreate.TabStop = False
        '
        'txtIDUpdate
        '
        Me.txtIDUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtIDUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDUpdate.Location = New System.Drawing.Point(100, 0)
        Me.txtIDUpdate.Margin = New System.Windows.Forms.Padding(1)
        Me.txtIDUpdate.MaxLength = 30
        Me.txtIDUpdate.Name = "txtIDUpdate"
        Me.txtIDUpdate.ReadOnly = True
        Me.txtIDUpdate.Size = New System.Drawing.Size(138, 20)
        Me.txtIDUpdate.TabIndex = 4
        Me.txtIDUpdate.TabStop = False
        '
        'lblUpdate
        '
        Me.lblUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblUpdate.Location = New System.Drawing.Point(0, 0)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(100, 20)
        Me.lblUpdate.TabIndex = 3
        Me.lblUpdate.Text = "Last Modified By"
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIDCreate
        '
        Me.txtIDCreate.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtIDCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCreate.Location = New System.Drawing.Point(100, 0)
        Me.txtIDCreate.Margin = New System.Windows.Forms.Padding(1)
        Me.txtIDCreate.MaxLength = 30
        Me.txtIDCreate.Name = "txtIDCreate"
        Me.txtIDCreate.ReadOnly = True
        Me.txtIDCreate.Size = New System.Drawing.Size(137, 20)
        Me.txtIDCreate.TabIndex = 1
        Me.txtIDCreate.TabStop = False
        '
        'lblCreate
        '
        Me.lblCreate.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCreate.Location = New System.Drawing.Point(0, 0)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(100, 20)
        Me.lblCreate.TabIndex = 0
        Me.lblCreate.Text = "Created By"
        Me.lblCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpRecordInfo
        '
        Me.tlpRecordInfo.ColumnCount = 2
        Me.tlpRecordInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRecordInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRecordInfo.Controls.Add(Me.Panel4, 1, 1)
        Me.tlpRecordInfo.Controls.Add(Me.Panel3, 0, 1)
        Me.tlpRecordInfo.Controls.Add(Me.Panel2, 1, 0)
        Me.tlpRecordInfo.Controls.Add(Me.Panel1, 0, 0)
        Me.tlpRecordInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpRecordInfo.Location = New System.Drawing.Point(3, 16)
        Me.tlpRecordInfo.Name = "tlpRecordInfo"
        Me.tlpRecordInfo.RowCount = 2
        Me.tlpRecordInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpRecordInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpRecordInfo.Size = New System.Drawing.Size(487, 51)
        Me.tlpRecordInfo.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtIDCreate)
        Me.Panel1.Controls.Add(Me.lblCreate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 20)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtIDUpdate)
        Me.Panel2.Controls.Add(Me.lblUpdate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(246, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 20)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtDTCreate)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 19)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtDTUpdate)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(246, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(238, 19)
        Me.Panel4.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ucRecordInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpRecordInfo)
        Me.Name = "ucRecordInformation"
        Me.Size = New System.Drawing.Size(493, 70)
        Me.grpRecordInfo.ResumeLayout(False)
        Me.pnlNoRecord.ResumeLayout(False)
        Me.pnlNoRecord.PerformLayout()
        Me.tlpRecordInfo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRecordInfo As System.Windows.Forms.GroupBox
    Public WithEvents txtDTUpdate As System.Windows.Forms.TextBox
    Public WithEvents txtDTCreate As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents lblCreate As System.Windows.Forms.Label
    Friend WithEvents pnlNoRecord As System.Windows.Forms.Panel
    Friend WithEvents lblNoRecord As System.Windows.Forms.Label
    Public WithEvents txtIDUpdate As System.Windows.Forms.TextBox
    Public WithEvents txtIDCreate As System.Windows.Forms.TextBox
    Friend WithEvents tlpRecordInfo As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
