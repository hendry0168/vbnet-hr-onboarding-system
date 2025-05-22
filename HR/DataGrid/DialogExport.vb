Imports System.Windows.Forms

Public Class DialogExport
    Private theTable As DataTable

    Public Sub ExportTable(ByVal theTable As DataTable)
        Me.theTable = theTable
        Me.ShowDialog()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If txtPath.Text.Length > 0 Then
                If rdoExcel.Checked Then ExportExcel(theTable, txtPath.Text)
                If rdoHTML.Checked Then ExportHTML(theTable, txtPath.Text)
                If rdoText.Checked Then ExportText(theTable, txtPath.Text)
                If rdoCSV.Checked Then ExportCSV(theTable, txtPath.Text)
                If rdoXML.Checked Then ExportXML(theTable, txtPath.Text)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot export the data!", "Error Export", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click, txtPath.DoubleClick
        BrowsePath()
    End Sub

    Private Sub BrowsePath()
        GetFilter()
        If sfdExport.ShowDialog() = DialogResult.OK Then
            txtPath.Text = sfdExport.FileName
            txtPath.SelectAll()
            OK_Button.Enabled = True
        End If

    End Sub

    Private Sub GetFilter()
        If rdoExcel.Checked Then sfdExport.Filter = "Excel Workbooks|*.xls"
        If rdoHTML.Checked Then sfdExport.Filter = "HTML File|*.html"
        If rdoText.Checked Then sfdExport.Filter = "Text File|*.txt"
        If rdoCSV.Checked Then sfdExport.Filter = "CSV File|*.csv"
        If rdoXML.Checked Then sfdExport.Filter = "XML File|*.xml"
    End Sub

    Private Sub DialogExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BrowsePath()
    End Sub
End Class
