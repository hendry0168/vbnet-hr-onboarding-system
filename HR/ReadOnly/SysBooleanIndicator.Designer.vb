<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SysBooleanIndicator
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.flpYesNo = New System.Windows.Forms.FlowLayoutPanel()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.flpYesNo.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpYesNo
        '
        Me.flpYesNo.Controls.Add(Me.rdoYes)
        Me.flpYesNo.Controls.Add(Me.rdoNo)
        Me.flpYesNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpYesNo.Location = New System.Drawing.Point(0, 0)
        Me.flpYesNo.Name = "flpYesNo"
        Me.flpYesNo.Size = New System.Drawing.Size(198, 22)
        Me.flpYesNo.TabIndex = 16
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(3, 3)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoYes.TabIndex = 0
        Me.rdoYes.TabStop = True
        Me.rdoYes.Text = "&Yes"
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(52, 3)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoNo.TabIndex = 1
        Me.rdoNo.TabStop = True
        Me.rdoNo.Text = "&No"
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'SysBooleanIndicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flpYesNo)
        Me.Name = "SysBooleanIndicator"
        Me.Size = New System.Drawing.Size(198, 22)
        Me.flpYesNo.ResumeLayout(False)
        Me.flpYesNo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpYesNo As FlowLayoutPanel
    Friend WithEvents rdoYes As RadioButton
    Friend WithEvents rdoNo As RadioButton
End Class
