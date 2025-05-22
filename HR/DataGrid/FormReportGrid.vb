Imports System.Data.SqlClient

Public Class FormReportGrid
    Public Sub DisplayReport(ByVal dt As DataTable, Optional ByVal Title As String = "View Report", Optional ByVal MaximizeForm As Boolean = True, Optional ByVal ShowAsDialog As Boolean = False, Optional ByVal HideFirstColumn As Boolean = False)
        Me.dgvReport.DataSource = dt
        SetGridLayout(dt, dgvReport)
        Me.Text = Title
        If HideFirstColumn Then dgvReport.Columns(0).Visible = False
        If MaximizeForm Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
        If ShowAsDialog Then
            Me.ShowDialog()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class