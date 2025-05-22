Imports System.Data.SqlClient

Public Class FormReportXGrid
    Public Sub DisplayReport(ByVal dt As DataTable, Optional ByVal Title As String = "View Report", Optional ByVal ShowGroupFooter As Boolean = False) ', Optional ByVal ShowDialog As Boolean = True)
        Me.Text = Title
        grcReport.DataSource = dt
        If ShowGroupFooter Then
            Me.grdReport.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Else
            Me.grdReport.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded
        End If
        Me.grdReport.BestFitColumns()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        XGrid.ExportData(grcReport, FileFormat.Excel)
    End Sub

    Private Sub ExportToPDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToPDFToolStripMenuItem.Click
        XGrid.ExportData(grcReport, FileFormat.PDF)
    End Sub

    Private Sub ExportToTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToTextToolStripMenuItem.Click
        XGrid.ExportData(grcReport, FileFormat.Txt)
    End Sub

    Private Sub bndReport_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.grdReport.BestFitColumns()
    End Sub

    Private Sub btnGridSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridSetting.Click

    End Sub

    Private Sub bndReport_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormReportXGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        XGrid.SetXGridDisplay(grdReport, grcReport.DataSource, False)
    End Sub
End Class