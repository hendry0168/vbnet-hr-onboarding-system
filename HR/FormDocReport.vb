
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FormDocReport
    Private Periode As Date
    Private Remark1 As Integer
    Private Remark2 As Integer
    Private dt_reporting As New DataTable
    Private CurrentSystemID As HRSystemID
    Private ServerName As String = Connection.ServerName
    Public Sub New(SelectedSystemID As HRSystemID)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        cboRemark1.ValueMember = "ID"
        cboRemark1.DisplayMember = "Name"
        cboRemark1.DataSource = GetSeparationRemarkforComboBox(11)
        cboRemark1.SelectedIndex = -1

        cboRemark2.ValueMember = "ID"
        cboRemark2.DisplayMember = "Name"
        cboRemark2.DataSource = GetSeparationRemarkforComboBox(11)
        cboRemark2.SelectedIndex = -1

        CurrentSystemID = SelectedSystemID

        Select Case CurrentSystemID
            Case HRSystemID.OffboardingReport
                chkRemark1.Enabled = True
                chkRemark2.Enabled = True
        End Select

        Me.Text = GetSystemName(CurrentSystemID)
        Me.ShowDialog()
    End Sub

    Private Sub cboRemark1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRemark1.SelectedValueChanged
        Remark1 = cboRemark1.SelectedValue
        cboRemark2.ValueMember = "ID"
        cboRemark2.DisplayMember = "Name"
        cboRemark2.DataSource = GetSeparationRemarkforComboBox(cboRemark1.SelectedValue)
        cboRemark2.SelectedIndex = -1
    End Sub

    Private Sub cboRemark2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRemark2.SelectedValueChanged
        Remark1 = cboRemark1.SelectedValue
    End Sub

    Private Sub dtpPostingDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If Not bgw.IsBusy Then
            Periode = GetLastDayOfMonth(dtpDate.Value.Date)
        End If
    End Sub

    Private Sub chkRemark1_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemark1.CheckedChanged
        If chkRemark1.Checked = True Then
            cboRemark1.Visible = True
        ElseIf chkRemark1.Checked = False Then
            cboRemark1.Visible = False
        End If
        Remark1 = cboRemark1.SelectedValue
    End Sub

    Private Sub chkRemark2_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemark2.CheckedChanged
        If chkRemark2.Checked = True Then
            cboRemark2.Visible = True
        ElseIf chkRemark2.Checked = False Then
            cboRemark2.Visible = False
        End If
        Remark2 = cboRemark2.SelectedValue
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        pnlProgress.Visible = True
        tspMain.Enabled = False
        btnRefresh.Enabled = False
        If Not bgw.IsBusy Then
            bgw.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork
        ReloadGrid()
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw.ProgressChanged
        If e.ProgressPercentage = -1 Then
            progressBar.Value = 0
        Else
            progressBar.Value = e.ProgressPercentage
        End If
        lblPercentage.Text = CStr(e.ProgressPercentage) & "% " & e.UserState.ToString
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        progressBar.Value = 100
        tspMain.Enabled = True
        btnRefresh.Enabled = True

        Display_DataGrid()
    End Sub

    Private Sub ReloadGrid()
        Dim strSQL As String = ""
        Dim dv As DataView
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Exit Sub
        Dim cmd As New SqlCommand(strSQL, cn)
        Dim da As New SqlDataAdapter(cmd)
        Dim reader As SqlDataReader

        Try
            bgw.ReportProgress(100, "Load Data: Retrieving...")

            Dim SelectedTable As String = ""
            Dim FilterString As String = ""
            Select Case CurrentSystemID
                Case HRSystemID.OnboardingReport
                    SelectedTable = "DBHR.dbo.v_hiring"
                    If Not Periode = Nothing Then
                        FilterString = " WHERE YEAR([Hiring Date]) = @yer AND MONTH([Hiring Date]) = @mon "
                    End If

                Case HRSystemID.OffboardingReport
                    SelectedTable = "DBHR.dbo.v_separation"
                    If Not Periode = Nothing Then
                        FilterString = " WHERE YEAR([Effective Date]) = @yer AND MONTH([Effective Date]) = @mon "
                    End If

                    If chkRemark1.Checked Then
                        If FilterString = "" Then FilterString = " WHERE " Else FilterString &= " AND "
                        FilterString &= " [Remark 1 ID] = " & Remark1
                    End If

                    If chkRemark2.Checked Then
                        If FilterString = "" Then FilterString = " WHERE " Else FilterString &= " AND "
                        FilterString &= " [Remark 2 ID] = " & Remark2
                    End If
            End Select

            dt_reporting = New DataTable
            strSQL = "SELECT * FROM " & SelectedTable & " " & FilterString &
                     " ORDER BY [Document Date], CAST([Document No] AS integer)"
            cmd.CommandTimeout = 1000
            cmd.CommandText = strSQL
            cmd.Parameters.Clear()
            If Not Periode = Nothing Then
                cmd.Parameters.AddWithValue("yer", Periode.Year)
                cmd.Parameters.AddWithValue("mon", Periode.Month)
            End If
            da.Fill(dt_reporting)

            bgw.ReportProgress(100, "Load Data: Done...")
        Catch ex As Exception
            MessageBox.Show("Retrieve Report Failed")
        End Try
    End Sub

    Private Sub Display_DataGrid()
        If dt_reporting Is Nothing Then Exit Sub
        xdgReporting.ReloadGrid(dt_reporting)

        SetTabPagesRowCount(tbpSSAReporting, dt_reporting, Me.Text)

        xdgReporting.ColumnVisible("Status ID") = False

        Select Case CurrentSystemID
            Case HRSystemID.OffboardingReport
                xdgReporting.ColumnVisible("Remark 1 ID") = False
                xdgReporting.ColumnVisible("Remark 2 ID") = False
        End Select

        xdgReporting.grdData.BestFitColumns()

        pnlProgress.Visible = False
        tspMain.Enabled = True
        btnRefresh.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If bgw.IsBusy Then
            bgw.CancelAsync()
        End If

        Me.Close()
    End Sub
End Class