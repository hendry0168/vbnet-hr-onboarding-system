<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogExport
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
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.rdoExcel = New System.Windows.Forms.RadioButton
        Me.rdoHTML = New System.Windows.Forms.RadioButton
        Me.rdoXML = New System.Windows.Forms.RadioButton
        Me.rdoText = New System.Windows.Forms.RadioButton
        Me.rdoCSV = New System.Windows.Forms.RadioButton
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.sfdExport = New System.Windows.Forms.SaveFileDialog
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(232, 165)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rdoExcel
        '
        Me.rdoExcel.AutoSize = True
        Me.rdoExcel.Checked = True
        Me.rdoExcel.Location = New System.Drawing.Point(12, 12)
        Me.rdoExcel.Name = "rdoExcel"
        Me.rdoExcel.Size = New System.Drawing.Size(96, 17)
        Me.rdoExcel.TabIndex = 1
        Me.rdoExcel.TabStop = True
        Me.rdoExcel.Text = "Export to Excel"
        Me.rdoExcel.UseVisualStyleBackColor = True
        '
        'rdoHTML
        '
        Me.rdoHTML.AutoSize = True
        Me.rdoHTML.Location = New System.Drawing.Point(12, 35)
        Me.rdoHTML.Name = "rdoHTML"
        Me.rdoHTML.Size = New System.Drawing.Size(100, 17)
        Me.rdoHTML.TabIndex = 2
        Me.rdoHTML.Text = "Export to HTML"
        Me.rdoHTML.UseVisualStyleBackColor = True
        '
        'rdoXML
        '
        Me.rdoXML.AutoSize = True
        Me.rdoXML.Location = New System.Drawing.Point(12, 58)
        Me.rdoXML.Name = "rdoXML"
        Me.rdoXML.Size = New System.Drawing.Size(92, 17)
        Me.rdoXML.TabIndex = 3
        Me.rdoXML.Text = "Export to XML"
        Me.rdoXML.UseVisualStyleBackColor = True
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(12, 81)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(91, 17)
        Me.rdoText.TabIndex = 4
        Me.rdoText.Text = "Export to Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoCSV
        '
        Me.rdoCSV.AutoSize = True
        Me.rdoCSV.Location = New System.Drawing.Point(12, 104)
        Me.rdoCSV.Name = "rdoCSV"
        Me.rdoCSV.Size = New System.Drawing.Size(91, 17)
        Me.rdoCSV.TabIndex = 5
        Me.rdoCSV.Text = "Export to CSV"
        Me.rdoCSV.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(72, 136)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(275, 20)
        Me.txtPath.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Target file:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(353, 136)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(25, 20)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'sfdExport
        '
        Me.sfdExport.DefaultExt = "xls"
        '
        'DialogExport
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(390, 206)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.rdoCSV)
        Me.Controls.Add(Me.rdoText)
        Me.Controls.Add(Me.rdoXML)
        Me.Controls.Add(Me.rdoHTML)
        Me.Controls.Add(Me.rdoExcel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogExport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Table"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rdoExcel As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHTML As System.Windows.Forms.RadioButton
    Friend WithEvents rdoXML As System.Windows.Forms.RadioButton
    Friend WithEvents rdoText As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCSV As System.Windows.Forms.RadioButton
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents sfdExport As System.Windows.Forms.SaveFileDialog

End Class
