<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogFilter))
        Me.bgwUpdate = New System.ComponentModel.BackgroundWorker
        Me.btnFilter = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pctProgress = New System.Windows.Forms.PictureBox
        Me.pctStatus = New System.Windows.Forms.PictureBox
        Me.txtFilter = New System.Windows.Forms.TextBox
        CType(Me.pctProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgwUpdate
        '
        Me.bgwUpdate.WorkerReportsProgress = True
        Me.bgwUpdate.WorkerSupportsCancellation = True
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.Location = New System.Drawing.Point(158, 36)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(239, 36)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pctProgress
        '
        Me.pctProgress.Image = My.Resources.Resources.icoSearch
        Me.pctProgress.Location = New System.Drawing.Point(10, 10)
        Me.pctProgress.Margin = New System.Windows.Forms.Padding(1)
        Me.pctProgress.Name = "pctProgress"
        Me.pctProgress.Size = New System.Drawing.Size(32, 32)
        Me.pctProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctProgress.TabIndex = 24
        Me.pctProgress.TabStop = False
        '
        'pctStatus
        '
        Me.pctStatus.Location = New System.Drawing.Point(10, 10)
        Me.pctStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.pctStatus.Name = "pctStatus"
        Me.pctStatus.Size = New System.Drawing.Size(32, 32)
        Me.pctStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctStatus.TabIndex = 28
        Me.pctStatus.TabStop = False
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(48, 10)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(266, 20)
        Me.txtFilter.TabIndex = 0
        '
        'DialogFilter
        '
        Me.AcceptButton = Me.btnFilter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(324, 69)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.pctProgress)
        Me.Controls.Add(Me.pctStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DialogFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Filter"
        CType(Me.pctProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bgwUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents pctProgress As System.Windows.Forms.PictureBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents pctStatus As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
End Class
