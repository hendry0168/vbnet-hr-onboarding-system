

Public Class FormDataVisualizer
    Public DefaultFileName As String = Nothing
    Private FormatTheDataTable As Boolean

    Public Sub New(Optional EnableCSVExport As Boolean = False, Optional FormatTable As Boolean = True)
        FormatTheDataTable = FormatTable

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        btnCSV.Visible = EnableCSVExport
    End Sub

    Private Sub InitComboDataTable(ByVal theDataSet As DataSet)
        cboDataTable.Items.Clear()
        dgvTables.Rows.Clear()
        For Each dt As DataTable In theDataSet.Tables
            cboDataTable.Items.Add(dt.TableName)
            If dt.Rows.Count > 0 Then
                Dim row() = {dt.TableName, dt.Rows.Count}
                dgvTables.Rows.Add(row)
            End If
        Next
        ds = theDataSet
    End Sub

    Public Function UploadData(ByVal theDataSet As DataSet) As Boolean
        InitComboDataTable(theDataSet)
        btnDownload.Visible = False
        btnClose.Visible = False
    End Function

    Public Function DownloadData(ByVal theDataSet As DataSet) As Boolean
        InitComboDataTable(theDataSet)
        btnOK.Visible = False
        btnCancel.Visible = False
    End Function

    Private ds As New DataSet

    Private Sub cboDataTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDataTable.SelectedIndexChanged
        xdgData.ReloadGrid(ds.Tables(cboDataTable.Text), True)
        'dgvDataTable.DataSource = ds.Tables(cboDataTable.Text)
    End Sub

    Private Sub dgvTables_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTables.SelectionChanged
        If dgvTables.SelectedRows.Count > 0 Then
            Dim dt_name As String = dgvTables.SelectedRows(0).Cells(clmTable.Index).Value
            xdgData.ReloadGrid(ds.Tables(dt_name), True, FormatTheDataTable)
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Using dlgExport As New SaveFileDialog
            'dlgExport.FileName = DBPURCHASING.DBServer.ServerName & "_" & Format(Now, "yyyy-MM-dd_hhmmss") & ".phg"
            If DefaultFileName = Nothing Then DefaultFileName = "download"
            dlgExport.FileName = DefaultFileName & ".phg"
            dlgExport.Filter = "PHG Offline Transfer File (*.phg)|*.phg"
            If dlgExport.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Try
                    ds.WriteXml(dlgExport.FileName)
                Catch ex As Exception
                    showError(ex)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        'xdgData.ReloadGrid(ds.Tables(cboDataTable.Text), True)
        xdgData.ExportToCSV()
    End Sub

    Private Sub FormDataVisualizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class