
Imports System.Data.SqlClient
Public Class FormGenericMasterDataEntry
    Private CurrentSystemID As HRSystemID
    Private CurrentTask As DocumentTask
    Private CurrentDocNo As String
    Private ServerName As String = Connection.ServerName

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        cboToStatus.ValueMember = "ID"
        cboToStatus.DisplayMember = "Name"
        cboToStatus.DataSource = GetDataforComboBox("v_record_status")
        cboToStatus.SelectedIndex = -1
    End Sub

    Public Function NewRecord(ByVal SelectedSystemID As Integer)
        CurrentTask = DocumentTask.NewRecord
        CurrentSystemID = SelectedSystemID
        Me.Text = GetSystemName(CurrentSystemID)
        LockDetail = False

        Me.ShowDialog()
    End Function

    Public Sub ViewRecord(DocNo As String, Editable As Boolean, SelectedSystemID As Integer)
        CurrentSystemID = SelectedSystemID
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

            Select Case CurrentSystemID
                Case HRSystemID.EducationEntry
                    tbc.TabPages.Remove(tbpRemark)
                    txtAltName.Visible = True
                    txtAltName.Enabled = True
                    chkNumeric.Text = "Seq"
                    chkNumeric.Checked = True
                    nudTemp.Visible = True
                    nudTemp.Enabled = True

                    txtAltName.ReadOnly = locked
                    nudTemp.ReadOnly = locked
                Case HRSystemID.GenderEntry
                    txtID.Enabled = Not locked
                    txtID.ReadOnly = locked
                    tbc.TabPages.Remove(tbpRemark)
                Case HRSystemID.ReligionEntry
                    tbc.TabPages.Remove(tbpRemark)
                Case HRSystemID.PersonnelLevelEntry
                    tbc.TabPages.Remove(tbpRemark)
                Case HRSystemID.PersonnelTypeEntry
                    tbc.TabPages.Remove(tbpRemark)
                Case HRSystemID.PersonnelActionEntry
                    tbc.TabPages.Remove(tbpRemark)
                    chkLinkLabel.Text = "Action Parent"
                    chkLinkLabel.Checked = True
                    lnkParent.Visible = True
                    lnkParent.Enabled = True
                    lnkParent.Text = "Select Action Parent"
                    chkNumeric.Text = "Level"
                    chkNumeric.Checked = True
                    nudTemp.Visible = True
                    nudTemp.Enabled = True
                    lblCombobox.Visible = True
                    cboToStatus.Visible = True

                    lnkParent.Enabled = Not locked
                    nudTemp.ReadOnly = locked
                    cboToStatus.Enabled = Not locked
            End Select

            txtName.ReadOnly = locked
            txtRemark.ReadOnly = locked

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

        Select Case CurrentSystemID
            Case HRSystemID.EducationEntry
                StrSql = "SELECT id, name, alternate_name, seq FROM DBHR.dbo.s_education_level WHERE id = @id"
            Case HRSystemID.GenderEntry
                StrSql = "SELECT id, name FROM DBHR.dbo.s_gender WHERE id = @id"
            Case HRSystemID.ReligionEntry
                StrSql = "SELECT id, name FROM DBHR.dbo.s_religion WHERE id = @id"
            Case HRSystemID.EmploymentTypeEntry
                StrSql = "SELECT id, name, remark FROM DBHR.dbo.s_employment_type WHERE id = @id"
            Case HRSystemID.PersonnelLevelEntry
                StrSql = "SELECT id, name FROM DBHR.dbo.s_personnel_level WHERE id = @id"
            Case HRSystemID.DocStatusEntry
                StrSql = "SELECT statusid AS id, statusname AS name, statusremark AS remark FROM DBHR.dbo.s_doc_status WHERE statusid = @id"
            Case HRSystemID.PersonnelStatusEntry
                StrSql = "SELECT statusid AS id, statusname AS name, statusremark AS remark FROM DBHR.dbo.s_record_status WHERE statusid = @id"
            Case HRSystemID.PersonnelTypeEntry
                StrSql = "SELECT id, name FROM DBHR.dbo.s_personnel_type WHERE id = @id"
            Case HRSystemID.PersonnelActionEntry
                StrSql = "SELECT id, name, parentid, lvl, to_status FROM DBHR.dbo.s_personnel_action WHERE id = @id"
        End Select

        cmd.CommandTimeout = 1000
        cmd.CommandText = StrSql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", key)
        reader = cmd.ExecuteReader
        Try
            If reader.Read Then
                txtID.Text = reader("id")
                txtName.Text = reader("name")

                Select Case CurrentSystemID
                    Case HRSystemID.EducationEntry
                        If Not IsDBNull(reader("alternate_name")) Then txtAltName.Text = reader("alternate_name")
                        If Not IsDBNull(reader("seq")) Then nudTemp.Value = reader("seq")
                    Case HRSystemID.EmploymentTypeEntry
                        If Not IsDBNull(reader("remark")) Then txtRemark.Text = reader("remark")
                    Case HRSystemID.DocStatusEntry
                        If Not IsDBNull(reader("remark")) Then txtRemark.Text = reader("remark")
                    Case HRSystemID.PersonnelStatusEntry
                        If Not IsDBNull(reader("remark")) Then txtRemark.Text = reader("remark")
                    Case HRSystemID.PersonnelActionEntry
                        If Not IsDBNull(reader("parentid")) Then ParentID = reader("parentid")
                        If Not IsDBNull(reader("lvl")) Then nudTemp.Value = reader("lvl")
                        If Not IsDBNull(reader("to_status")) Then cboToStatus.SelectedValue = reader("to_status")
                End Select
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
        With txtName
            If Trim(.Text).Length < 1 Then
                strMSG &= "Name must be specified." & Environment.NewLine
                ValidateInput = False
                .SelectAll()
                .Focus()
            End If
        End With

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
            If Not CurrentSystemID = HRSystemID.GenderEntry Then
                txtID.Text = GetRunningNumber(CurrentSystemID)
                If txtID.Text = Nothing Then Return False
            End If

            Select Case CurrentSystemID
                Case HRSystemID.EducationEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_education_level " &
                             " (id, name, alternate_name, seq) VALUES " &
                             " (@id, @name, @alternate_name, @nud)"
                Case HRSystemID.GenderEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_gender " &
                             " (id, name) VALUES (@id, @name)"
                Case HRSystemID.ReligionEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_religion " &
                             " (id, name) VALUES (@id, @name)"
                Case HRSystemID.EmploymentTypeEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_employment_type " &
                             " (id, name, remark) VALUES (@id, @name, @remark)"
                Case HRSystemID.PersonnelLevelEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_personnel_level " &
                             " (id, name) VALUES (@id, @name)"
                Case HRSystemID.DocStatusEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_doc_status " &
                             " (statusid, statusname, statusremark) VALUES (@id, @name, @remark)"
                Case HRSystemID.PersonnelStatusEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_record_status " &
                             " (statusid, statusname, statusremark) VALUES (@id, @name, @remark)"
                Case HRSystemID.PersonnelTypeEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_personnel_type " &
                             " (id, name) VALUES (@id, @name)"
                Case HRSystemID.PersonnelActionEntry
                    strSQL = "INSERT INTO DBHR.dbo.s_personnel_action " &
                             " (id, name, parentid, lvl, to_status) VALUES " &
                             " (@id, @name, @parentid, @nud, @to_status)"
            End Select
        ElseIf CurrentTask = DocumentTask.EditRecord Then
            Select Case CurrentSystemID
                Case HRSystemID.EducationEntry
                    strSQL = "UPDATE DBHR.dbo.s_education_level SET " &
                             " name = @name, alternate_name = @alternate_name, seq = @nud " &
                             " WHERE id = @id"
                Case HRSystemID.GenderEntry
                    strSQL = "UPDATE DBHR.dbo.s_gender SET name = @name WHERE id = @id"
                Case HRSystemID.ReligionEntry
                    strSQL = "UPDATE DBHR.dbo.s_religion SET name = @name WHERE id = @id"
                Case HRSystemID.EmploymentTypeEntry
                    strSQL = "UPDATE DBHR.dbo.s_employment_type SET name = @name, remark = @remark WHERE id = @id"
                Case HRSystemID.PersonnelLevelEntry
                    strSQL = "UPDATE DBHR.dbo.s_personnel_level SET name = @name WHERE id = @id"
                Case HRSystemID.DocStatusEntry
                    strSQL = "UPDATE DBHR.dbo.s_doc_status SET statusname = @name, statusremark = @remark WHERE statusid = @id"
                Case HRSystemID.PersonnelStatusEntry
                    strSQL = "UPDATE DBHR.dbo.s_record_status SET statusname = @name, statusremark = @remark WHERE statusid = @id"
                Case HRSystemID.PersonnelTypeEntry
                    strSQL = "UPDATE DBHR.dbo.s_personnel_type SET name = @name WHERE id = @id"
                Case HRSystemID.PersonnelActionEntry
                    strSQL = "UPDATE DBHR.dbo.s_personnel_action SET " &
                             " name = @name, parentid = @parentid, lvl = @nud, to_status = @to_status " &
                             " WHERE id = @id"
            End Select
        Else
            Exit Function
        End If

        Try
            Using cmd As New SqlCommand(strSQL, cn, theTrans)
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("id", txtID.Text)
                    .AddWithValue("name", txtName.Text)
                    AddParameter(cmd, "remark", txtRemark.Text, True)
                    .AddWithValue("alternate_name", txtAltName.Text)
                    If ParentID = Nothing Then .AddWithValue("parentid", DBNull.Value) Else .AddWithValue("parentid", ParentID)
                    If nudTemp.Value = 0 Then .AddWithValue("nud", 1) Else .AddWithValue("nud", nudTemp.Value)
                    If cboToStatus.SelectedIndex = -1 Then .AddWithValue("to_status", DBNull.Value) Else .AddWithValue("to_status", cboToStatus.SelectedValue)
                End With
                cmd.ExecuteNonQuery()

                theTrans.Commit()
                CommitOK = True
            End Using
        Catch ex As SqlException
            theTrans.Rollback()
            CommitOK = False
            MessageBox.Show("Save Failed")
        End Try
    End Function

    Private ActionParent As Integer
    Public Property ParentID() As Integer
        Get
            Return ActionParent
        End Get
        Set(ByVal value As Integer)
            ActionParent = value
            If value = Nothing Then
                lnkParent.Text = "Select Action Parent"
            Else
                lnkParent.Text = GetValue("DBHR", "v_personnel_action", "ID", "Name", value)
            End If
        End Set
    End Property

    Private Sub lnkParent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkParent.LinkClicked
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
        strSql = "SELECT ID, Name, [Parent ID], [Level], [To Status ID], [To Status] FROM DBHR.dbo.v_personnel_action "
        cmd.CommandText = strSql
        cmd.Parameters.Clear()
        da.Fill(dt)

        Using dlg As New FormXDataGrid
            dlg.SelectFromData(dt, "Select Action Parent")
            dlg.Size = New Size(300, 400)
            dlg.StartPosition = FormStartPosition.CenterParent
            dlg.WindowState = FormWindowState.Normal
            dlg.ShowDialog()
            If dlg.Result_Click = True Then
                ParentID = dlg.XDataGrid.GetSelectedValue("ID")
            End If
        End Using
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
End Class