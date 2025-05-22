Imports System.Data.SqlClient
Public Class FormOffboardingEntry
    Private CurrentSystemID As HRSystemID = HRSystemID.OffboardingEntry
    Private CurrentTask As DocumentTask
    Private CurrentDocNo As String
    Private ServerName As String = Connection.ServerName
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        cboEmploymentType.ValueMember = "ID"
        cboEmploymentType.DisplayMember = "Name"
        cboEmploymentType.DataSource = GetDataforComboBox("v_employment_type")
        cboEmploymentType.SelectedIndex = -1

        cboLevel.ValueMember = "ID"
        cboLevel.DisplayMember = "Name"
        cboLevel.DataSource = GetDataforComboBox("v_personnel_level")
        cboLevel.SelectedIndex = -1

        cboRemark1.ValueMember = "ID"
        cboRemark1.DisplayMember = "Name"
        cboRemark1.DataSource = GetSeparationRemarkforComboBox(11)
        cboRemark1.SelectedIndex = -1

        cboRemark2.ValueMember = "ID"
        cboRemark2.DisplayMember = "Name"
        cboRemark2.DataSource = GetSeparationRemarkforComboBox(11)
        cboRemark2.SelectedIndex = -1

        cboStatus.ValueMember = "ID"
        cboStatus.DisplayMember = "Name"
        cboStatus.DataSource = GetDataforComboBox("v_doc_status")
        cboStatus.SelectedIndex = -1
    End Sub

    Public Function NewRecord()
        CurrentTask = DocumentTask.NewRecord
        Me.Text = GetSystemName(CurrentSystemID)

        LockDetail = False

        Me.ShowDialog()
    End Function

    Public Sub ViewRecord(DocNo As String, Editable As Boolean)
        If Editable Then
            CurrentTask = DocumentTask.EditRecord
        Else
            CurrentTask = DocumentTask.ViewOnly
        End If

        If Not LoadDetail(DocNo) Then Exit Sub
        CurrentDocNo = DocNo
        LockDetail = Not Editable

        Me.ShowDialog()
    End Sub

    Private IsLocked As Boolean
    Public Property LockDetail() As Boolean
        Get
            Return IsLocked
        End Get
        Set(ByVal locked As Boolean)
            IsLocked = locked

            txtHeader.ReadOnly = locked

            dtpEffectiveDate.Enabled = Not locked

            txtRemark.ReadOnly = locked

            'cboEmploymentType.Enabled = Not locked
            'cboLevel.Enabled = Not locked
            cboRemark1.Enabled = Not locked
            cboRemark2.Enabled = Not locked

            lnkPersonnel.Enabled = Not locked

            btnClose.Visible = locked
            btnSave.Visible = Not locked
            btnCancel.Visible = Not locked
        End Set
    End Property

    Public Function LoadDetail(ByVal key As String) As Boolean
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return False
        Dim StrSql As String = ""
        Dim cmd As New SqlCommand(StrSql, cn)
        Dim reader As SqlDataReader

        StrSql = "SELECT * FROM DBHR.dbo.t_separation WHERE docno = @docno"
        cmd.CommandTimeout = 1000
        cmd.CommandText = StrSql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("docno", key)
        reader = cmd.ExecuteReader
        Try
            If reader.Read Then
                txtDocNo.Text = reader("docno")
                If Not IsDBNull(reader("docheader")) Then txtHeader.Text = reader("docheader")
                dtpDocDate.Value = reader("docdate")
                dtpEffectiveDate.Value = reader("effectivedate")
                Personnel = reader("personnelid")
                txtPersonnelID.Text = reader("personnelid")
                If Not IsDBNull(reader("levelid")) Then cboLevel.SelectedValue = reader("levelid")
                If Not IsDBNull(reader("contractid")) Then cboEmploymentType.SelectedValue = reader("contractid")
                If Not IsDBNull(reader("remark_1")) Then cboRemark1.SelectedValue = reader("remark_1")
                If Not IsDBNull(reader("remark_2")) Then cboRemark2.SelectedValue = reader("remark_2")
                txtRemark.Text = getStringReader(reader("remark"))
                cboStatus.SelectedValue = reader("status")
                ucRecordInfo.LoadRecordInformation(reader)
            End If
            reader.Close()

        Catch ex As Exception
            LoadDetail = False
            MessageBox.Show("Load Data Failed")
        End Try
        LoadDetail = True
    End Function

    Private Function ValidateInput() As Boolean
        ValidateInput = True
        Dim strMSG As String = ""

        If Personnel = Nothing Then
            strMSG &= "Personnel must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        Dim HiringDate As Date = GetValue("DBHR", "v_personnel", "Personnel ID", "Hire Date", Personnel)
        If HiringDate.Date > dtpEffectiveDate.Value.Date Then
            strMSG &= "Effective Date must be larger than Hiring Date (" & Format(HiringDate.Date, "yyyy-MM-dd") & ")." & Environment.NewLine
            ValidateInput = False
        End If

        With txtRemark
            If Trim(.Text).Length < 1 Then
                strMSG &= "Remark must be specified." & Environment.NewLine
                ValidateInput = False
                .SelectAll()
                .Focus()
            End If
        End With

        If cboRemark1.SelectedIndex = -1 Then
            strMSG &= "Exit Reason must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If cboRemark2.SelectedIndex = -1 Then
            strMSG &= "Exit Details must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If ValidateInput = False Then MessageBox.Show(strMSG, "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Function

    Private Function CommitOK() As Boolean
        CommitOK = False
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return False
        Dim theTrans As SqlTransaction = cn.BeginTransaction
        Dim strSQL As String = ""

        If CurrentTask = DocumentTask.NewRecord Then
            txtDocNo.Text = GetRunningDocNo(CurrentSystemID)
            If txtDocNo.Text = Nothing Then Return False

            strSQL = "INSERT INTO DBHR.dbo.t_separation " &
                     " (docno, docheader, docdate, effectivedate, actionid, personnelid, levelid, contractid, remark_1, remark_2, status, remark, idcreate, dtcreate) VALUES " &
                     " (@docno, @docheader, @docdate, @effectivedate, 11, @personnelid, @levelid, @contractid, @remark_1, @remark_2, @status, @remark, 'hr_admin', GETDATE())"
        ElseIf CurrentTask = DocumentTask.EditRecord Then
            strSQL = "UPDATE DBHR.dbo.t_separation SET " &
                     " docheader = @docheader, effectivedate = @effectivedate, remark_1 = @remark_1, remark_2 = @remark_2 " &
                     " , remark = @remark, idupdate = 'hr_admin', dtupdate = GETDATE()" &
                     " WHERE docno = @docno"
        Else
            Exit Function
        End If

        Try
            Using cmd As New SqlCommand(strSQL, cn, theTrans)
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("docno", txtDocNo.Text)
                    .AddWithValue("docheader", txtHeader.Text)
                    .AddWithValue("docdate", dtpDocDate.Value)
                    .AddWithValue("effectivedate", dtpEffectiveDate.Value)
                    .AddWithValue("personnelid", Personnel)
                    .AddWithValue("levelid", cboLevel.SelectedValue)
                    .AddWithValue("contractid", cboEmploymentType.SelectedValue)
                    .AddWithValue("remark_1", cboRemark1.SelectedValue)
                    .AddWithValue("remark_2", cboRemark2.SelectedValue)
                    AddParameter(cmd, "remark", txtRemark.Text, True)
                    .AddWithValue("status", 2)
                End With
                cmd.ExecuteNonQuery()

                UpdatePersonnel(cmd)

                theTrans.Commit()
                CommitOK = True
            End Using
        Catch ex As SqlException
            theTrans.Rollback()
            CommitOK = False
            MessageBox.Show("Save Failed")
        End Try
    End Function

    Private Sub UpdatePersonnel(ByVal cmd As SqlCommand)
        Dim strSQL As String = ""
        Dim ToStatus As Integer = GetValue("DBHR", "s_personnel_action", "id", "to_status", cboRemark2.SelectedValue)
        If ToStatus = Nothing Then ToStatus = 11
        strSQL = "UPDATE DBHR.dbo.m_personnel SET " &
                 " resigndate = @effectivedate, status = @status, idupdate = 'hr_admin', dtupdate = GETDATE()" &
                 " WHERE personnelid = @personnelid"
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        With cmd.Parameters
            .Clear()
            .AddWithValue("personnelid", Personnel)
            .AddWithValue("effectivedate", dtpEffectiveDate.Value.Date)
            .AddWithValue("status", ToStatus)
        End With
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateInput() Then
            If CommitOK() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private PersonnelID As Integer
    Public Property Personnel() As Integer
        Get
            Return PersonnelID
        End Get
        Set(ByVal value As Integer)
            PersonnelID = value
            If value = Nothing Then
                lnkPersonnel.Text = "Select Superior"
            Else
                lnkPersonnel.Text = GetValue("DBHR", "v_personnel", "Personnel ID", "Person Name", value)
                txtPersonID.Text = GetValue("DBHR", "v_personnel", "Personnel ID", "Person ID", value)
            End If
        End Set
    End Property

    Private Sub lnkPersonnel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPersonnel.LinkClicked
        Dim dt As New DataTable
        Dim strSql As String = ""
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Exit Sub
        Dim cmd As New SqlCommand(strSql, cn)
        Dim da As New SqlDataAdapter(cmd)

        dt = New DataTable
        strSql = "SELECT [Personnel ID], [Person ID], [Person Name], [Personnel Type], [Personnel Level ID], [Personnel Level], [Employment Type ID], [Employment Type], Status " &
                 " FROM dbhr.dbo.v_personnel " &
                 " WHERE [Status ID] = 0 AND split = 0 "
        cmd.CommandText = strSql
        cmd.Parameters.Clear()
        da.Fill(dt)

        Using dlg As New FormXDataGrid
            dlg.SelectFromData(dt, "Select Superior")
            dlg.Size = New Size(300, 400)
            dlg.StartPosition = FormStartPosition.CenterParent
            dlg.WindowState = FormWindowState.Normal
            dlg.ShowDialog()
            If dlg.Result_Click = True Then
                Personnel = dlg.XDataGrid.GetSelectedValue("Personnel ID")
                txtPersonID.Text = dlg.XDataGrid.GetSelectedValue("Person ID")
                txtPersonnelID.Text = Personnel
                cboEmploymentType.SelectedValue = dlg.XDataGrid.GetSelectedValue("Employment Type ID")
                cboLevel.SelectedValue = dlg.XDataGrid.GetSelectedValue("Personnel Level ID")
            End If
        End Using
    End Sub

    Private Sub cboRemark1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboRemark1.SelectedValueChanged

        cboRemark2.ValueMember = "ID"
        cboRemark2.DisplayMember = "Name"
        cboRemark2.DataSource = GetSeparationRemarkforComboBox(cboRemark1.SelectedValue)
        cboRemark2.SelectedIndex = -1

    End Sub
End Class