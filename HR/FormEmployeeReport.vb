
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FormEmployeeReport
    Private HireDate As Date
    Private GenderID As String
    Private ReligionID As Integer
    Private PersonnelTypeID As Integer
    Private LevelID As Integer
    Private EmploymentTypeID As Integer
    Private StatusID As Integer
    Private dt_reporting As New DataTable
    Private CurrentSystemID As HRSystemID
    Private ServerName As String = Connection.ServerName
    Dim FilterString As String = ""
    Public Sub New(SelectedSystemID As HRSystemID)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        cboGender.ValueMember = "ID"
        cboGender.DisplayMember = "Name"
        cboGender.DataSource = GetDataforComboBox("v_gender")
        cboGender.SelectedIndex = -1

        cboReligion.ValueMember = "ID"
        cboReligion.DisplayMember = "Name"
        cboReligion.DataSource = GetDataforComboBox("v_religion")
        cboReligion.SelectedIndex = -1

        cboPersonnelType.ValueMember = "ID"
        cboPersonnelType.DisplayMember = "Name"
        cboPersonnelType.DataSource = GetDataforComboBox("v_personnel_type")
        cboPersonnelType.SelectedIndex = -1

        cboEmploymentType.ValueMember = "ID"
        cboEmploymentType.DisplayMember = "Name"
        cboEmploymentType.DataSource = GetDataforComboBox("v_employment_type")
        cboEmploymentType.SelectedIndex = -1

        cboLevel.ValueMember = "ID"
        cboLevel.DisplayMember = "Name"
        cboLevel.DataSource = GetDataforComboBox("v_personnel_level")
        cboLevel.SelectedIndex = -1

        cboStatus.ValueMember = "ID"
        cboStatus.DisplayMember = "Name"
        cboStatus.DataSource = GetDataforComboBox("v_record_status")
        cboStatus.SelectedIndex = -1

        CurrentSystemID = SelectedSystemID

        Me.Text = GetSystemName(CurrentSystemID)
        Me.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        pnlProgress.Visible = True
        tspMain.Enabled = False
        btnRefresh.Enabled = False

        If chkHireDate.Checked Then HireDate = dtpHireDate.Value.Date Else HireDate = Nothing
        If chkGender.Checked Then GenderID = cboGender.SelectedValue Else GenderID = Nothing
        If chkReligion.Checked Then ReligionID = cboReligion.SelectedValue Else ReligionID = Nothing
        If chkPersonnelType.Checked Then PersonnelTypeID = cboPersonnelType.SelectedValue Else PersonnelTypeID = Nothing
        If chkLevel.Checked Then LevelID = cboLevel.SelectedValue Else LevelID = Nothing
        If chkEmploymentType.Checked Then EmploymentTypeID = cboEmploymentType.SelectedValue Else EmploymentTypeID = Nothing

        FilterString = " WHERE split = 00"
        If Not HireDate = Nothing Then FilterString &= " AND YEAR([Hire Date]) = " & HireDate.Year & " AND MONTH([Hire Date]) = " & HireDate.Month
        If Not GenderID = Nothing Then FilterString &= " AND [Gender ID] = '" & GenderID & "' "
        If Not ReligionID = Nothing Then FilterString &= " AND [Religion ID] = " & ReligionID
        If Not PersonnelTypeID = Nothing Then FilterString &= " AND [Personnel Type ID] = " & PersonnelTypeID
        If Not LevelID = Nothing Then FilterString &= " AND [Personnel Level ID] = " & LevelID
        If Not EmploymentTypeID = Nothing Then FilterString &= " AND [Employment Type ID] = " & EmploymentTypeID
        If chkStatus.Checked Then FilterString &= " AND [Status ID] = " & StatusID

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

            dt_reporting = New DataTable
            strSQL = "SELECT * FROM DBHR.dbo.v_personnel" & FilterString &
                     " ORDER BY CAST([Person ID] AS integer), CAST([Personnel ID] AS integer)"
            cmd.CommandTimeout = 1000
            cmd.CommandText = strSQL
            cmd.Parameters.Clear()
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

        xdgReporting.ColumnVisible("Gender ID") = False
        xdgReporting.ColumnVisible("Religion ID") = False
        xdgReporting.ColumnVisible("Personnel Type ID") = False
        xdgReporting.ColumnVisible("Personnel Level ID") = False
        xdgReporting.ColumnVisible("Employment Type ID") = False
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

    Private Sub chkHireDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkHireDate.CheckedChanged
        dtpHireDate.Visible = chkHireDate.Checked
    End Sub

    Private Sub chkGender_CheckedChanged(sender As Object, e As EventArgs) Handles chkGender.CheckedChanged
        cboGender.Visible = chkGender.Checked
    End Sub

    Private Sub chkReligion_CheckedChanged(sender As Object, e As EventArgs) Handles chkReligion.CheckedChanged
        cboReligion.Visible = chkReligion.Checked
    End Sub

    Private Sub chkPersonnelType_CheckedChanged(sender As Object, e As EventArgs) Handles chkPersonnelType.CheckedChanged
        cboPersonnelType.Visible = chkPersonnelType.Checked
    End Sub

    Private Sub chkLevel_CheckedChanged(sender As Object, e As EventArgs) Handles chkLevel.CheckedChanged
        cboLevel.Visible = chkLevel.Checked
    End Sub

    Private Sub chkEmploymentType_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmploymentType.CheckedChanged
        cboEmploymentType.Visible = chkEmploymentType.Checked
    End Sub

    Private Sub chkStatus_CheckedChanged(sender As Object, e As EventArgs) Handles chkStatus.CheckedChanged
        cboStatus.Visible = chkStatus.Checked
    End Sub
End Class