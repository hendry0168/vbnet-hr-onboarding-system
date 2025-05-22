Imports System.Data.SqlClient
Public Class FormOnboardingEntry
    Private CurrentSystemID As HRSystemID = HRSystemID.OnboardingEntry
    Private CurrentTask As DocumentTask
    Private CurrentDocNo As String
    Private ServerName As String = Connection.ServerName
    Public Sub New()

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

        cboEducation.ValueMember = "ID"
        cboEducation.DisplayMember = "Name"
        cboEducation.DataSource = GetDataforComboBox("v_education_level")
        cboEducation.SelectedIndex = -1

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

            dtpHiringDate.Enabled = Not locked
            dtpBirthDate.Enabled = Not locked

            txtPrefix.ReadOnly = locked
            txtSuffix.ReadOnly = locked

            txtFullName.ReadOnly = locked
            txtFirstName.ReadOnly = locked
            txtMiddleName.ReadOnly = locked
            txtLastName.ReadOnly = locked

            txtNickName.ReadOnly = locked
            txtBirthPlace.ReadOnly = locked

            txtRemark.ReadOnly = locked

            cboGender.Enabled = Not locked
            cboReligion.Enabled = Not locked
            cboEducation.Enabled = Not locked
            cboPersonnelType.Enabled = Not locked
            cboEmploymentType.Enabled = Not locked
            cboLevel.Enabled = Not locked

            lnkSuperior.Enabled = Not locked

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

        StrSql = "SELECT * FROM DBHR.dbo.t_hiring WHERE docno = @docno"
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
                dtpHiringDate.Value = reader("hiringdate")
                txtPersonID.Text = reader("personid")
                txtPersonnelID.Text = reader("personnelid")
                txtRemark.Text = getStringReader(reader("remark"))
                cboStatus.SelectedValue = reader("status")
                ucRecordInfo.LoadRecordInformation(reader)
            End If
            reader.Close()

            StrSql = "SELECT * FROM DBHR.dbo.t_hiring_item WHERE docno = @docno"
            cmd.CommandTimeout = 1000
            cmd.CommandText = StrSql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("docno", key)
            reader = cmd.ExecuteReader
            If reader.Read Then
                If Not IsDBNull(reader("personnel_type_id")) Then cboPersonnelType.SelectedValue = reader("personnel_type_id")
                If Not IsDBNull(reader("contract_id")) Then cboEmploymentType.SelectedValue = reader("contract_id")
                If Not IsDBNull(reader("level_id")) Then cboLevel.SelectedValue = reader("level_id")
                If Not IsDBNull(reader("superior_personnelid")) Then Superior = reader("superior_personnelid") Else lnkSuperior.Text = "Select Superior"
            End If
            reader.Close()

            StrSql = "SELECT * FROM DBHR.dbo.m_person WHERE personid = @personid"
            cmd.CommandTimeout = 1000
            cmd.CommandText = StrSql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("personid", txtPersonID.Text)
            reader = cmd.ExecuteReader
            If reader.Read Then
                If Not IsDBNull(reader("name_prefix")) Then txtPrefix.Text = reader("name_prefix")
                If Not IsDBNull(reader("first_name")) Then txtFirstName.Text = reader("first_name")
                If Not IsDBNull(reader("middle_name")) Then txtMiddleName.Text = reader("middle_name")
                If Not IsDBNull(reader("last_name")) Then txtLastName.Text = reader("last_name")
                If Not IsDBNull(reader("name_suffix")) Then txtSuffix.Text = reader("name_suffix")
                If Not IsDBNull(reader("full_name")) Then txtFullName.Text = reader("full_name")
                If Not IsDBNull(reader("nick_name")) Then txtNickName.Text = reader("nick_name")
                If Not IsDBNull(reader("place_of_birth")) Then txtBirthPlace.Text = reader("place_of_birth")
                dtpBirthDate.Value = reader("date_of_birth")
                If Not IsDBNull(reader("gender")) Then cboGender.SelectedValue = reader("gender")
                If Not IsDBNull(reader("religion")) Then cboReligion.SelectedValue = reader("religion")
                txtRemark.Text = getStringReader(reader("remark"))
            End If
            reader.Close()

            StrSql = "SELECT * FROM DBHR.dbo.m_person_education WHERE personid = @personid"
            cmd.CommandTimeout = 1000
            cmd.CommandText = StrSql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("personid", txtPersonID.Text)
            reader = cmd.ExecuteReader
            If reader.Read Then
                If Not IsDBNull(reader("education_level")) Then cboEducation.SelectedValue = reader("education_level")
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

        With txtFullName
            If Trim(.Text).Length < 1 Then
                strMSG &= "Personnel name must be specified." & Environment.NewLine
                ValidateInput = False
                .SelectAll()
                .Focus()
            End If
        End With

        With txtBirthPlace
            If Trim(.Text).Length < 1 Then
                strMSG &= "Birth Place must be specified." & Environment.NewLine
                ValidateInput = False
                .SelectAll()
                .Focus()
            End If
        End With

        If dtpBirthDate.Value.Date > Today.Date Then
            strMSG &= "Birth Date cannot be larger than today." & Environment.NewLine
            ValidateInput = False
        Else
            Dim age As Integer = DateDiff(DateInterval.Year, dtpBirthDate.Value.Date, Today.Date)
            If age < 18 Then
                strMSG = "The person age cannot less than 18 years old" & Environment.NewLine
                ValidateInput = False
                dtpBirthDate.Focus()
            End If
        End If

        If cboGender.SelectedIndex = -1 Then
            strMSG &= "Gender must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If cboReligion.SelectedIndex = -1 Then
            strMSG &= "Religion must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If cboEducation.SelectedIndex = -1 Then
            strMSG &= "Education must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If cboPersonnelType.SelectedIndex = -1 Then
            strMSG &= "Personnel Type must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If cboEmploymentType.SelectedIndex = -1 Then
            strMSG &= "Employment Type must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If cboLevel.SelectedIndex = -1 Then
            strMSG &= "Level must be specified." & Environment.NewLine
            ValidateInput = False
        End If

        If Superior = Nothing Then
            strMSG &= "Superior must be specified." & Environment.NewLine
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

        Using cmd As New SqlCommand(strSQL, cn, theTrans)
            If CurrentTask = DocumentTask.NewRecord Then
                txtDocNo.Text = GetRunningDocNo(CurrentSystemID)
                If txtDocNo.Text = Nothing Then Return False

                If txtPersonID.Text = Nothing Or txtPersonID.Text = "" Then txtPersonID.Text = GetRunningNumber(HRSystemID.PersonID)
                If txtPersonID.Text = Nothing Then Return False

                SavePerson(cmd)

                If txtPersonnelID.Text = Nothing Or txtPersonnelID.Text = "" Then txtPersonnelID.Text = GetRunningNumber(HRSystemID.PersonnelID)
                If txtPersonnelID.Text = Nothing Then Return False

                SavePersonnel(cmd)

                strSQL = "INSERT INTO DBHR.dbo.t_hiring " &
                     " (docno, docheader, docdate, hiringdate, actionid, personid, personnelid, remark, status, idcreate, dtcreate) VALUES " &
                     " (@docno, @docheader, @docdate, @hiringdate, 01, @personid, @personnelid, @remark, @status, 'hr_recruitment', GETDATE())"
            ElseIf CurrentTask = DocumentTask.EditRecord Then
                strSQL = "UPDATE DBHR.dbo.t_hiring SET " &
                     " docheader = @docheader, hiringdate = @hiringdate, remark = @remark " &
                     " , idupdate = 'hr_admin', dtupdate = GETDATE()" &
                     " WHERE docno = @docno"
            Else
                Exit Function
            End If

            Try
                cmd.CommandText = strSQL
                cmd.Parameters.Clear()
                With cmd.Parameters
                    .Clear()
                    .AddWithValue("docno", txtDocNo.Text)
                    .AddWithValue("docheader", txtHeader.Text)
                    .AddWithValue("docdate", dtpDocDate.Value.Date)
                    .AddWithValue("hiringdate", dtpHiringDate.Value.Date)
                    .AddWithValue("personid", txtPersonID.Text)
                    .AddWithValue("personnelid", txtPersonnelID.Text)
                    AddParameter(cmd, "remark", txtRemark.Text, True)
                    .AddWithValue("status", 2)
                End With
                cmd.ExecuteNonQuery()

                SaveDetail(cmd)

                If CurrentTask = DocumentTask.EditRecord Then
                    SavePerson(cmd)
                    SavePersonnel(cmd)
                End If

                theTrans.Commit()
                CommitOK = True
            Catch ex As SqlException
                theTrans.Rollback()
                CommitOK = False
                MessageBox.Show("Save Failed")
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try
        End Using
    End Function

    Private Sub SaveDetail(ByVal cmd As SqlCommand)
        Dim strSQL As String = ""
        strSQL = "DELETE FROM t_hiring_item WHERE docno = @docno"
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("docno", txtDocNo.Text)
        cmd.ExecuteNonQuery()

        strSQL = "INSERT INTO DBHR.dbo.t_hiring_item " &
                 " (docno, personnel_type_id, contract_id, level_id, superior_personnelid) VALUES " &
                 " (@docno, @personnel_type_id, @contract_id, @level_id, @superior_personnelid)"
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("docno", txtDocNo.Text)
        cmd.Parameters.AddWithValue("personnel_type_id", cboPersonnelType.SelectedValue)
        cmd.Parameters.AddWithValue("contract_id", cboEmploymentType.SelectedValue)
        cmd.Parameters.AddWithValue("level_id", cboLevel.SelectedValue)
        cmd.Parameters.AddWithValue("superior_personnelid", Superior)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub SavePerson(ByVal cmd As SqlCommand)
        Dim strSQL As String = ""
        If CurrentTask = DocumentTask.NewRecord Then
            strSQL = "INSERT INTO DBHR.dbo.m_person " &
                     " (personid, name_prefix, first_name, middle_name, last_name, name_suffix, full_name, nick_name, place_of_birth, date_of_birth, gender, religion, remark, status, idcreate, dtcreate) VALUES " &
                     " (@personid, @name_prefix, @first_name, @middle_name, @last_name, @name_suffix, @full_name, @nick_name, @place_of_birth, @date_of_birth, @gender, @religion, @remark, 00, 'hr_recruitment', GETDATE())"
        ElseIf CurrentTask = DocumentTask.EditRecord Then
            strSQL = "UPDATE DBHR.dbo.m_person SET " &
                     " name_prefix = @name_prefix, first_name = @first_name, middle_name = @middle_name, last_name = @last_name " &
                     " , name_suffix = @name_suffix, full_name = @full_name, nick_name = @nick_name, place_of_birth = @place_of_birth " &
                     " , date_of_birth = @date_of_birth, gender = @gender, religion = @religion, remark = @remark " &
                     " , idupdate = 'hr_admin', dtupdate = GETDATE()" &
                     " WHERE personid = @personid"
        End If
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        With cmd.Parameters
            .Clear()
            .AddWithValue("personid", txtPersonID.Text)
            .AddWithValue("name_prefix", txtPrefix.Text)
            .AddWithValue("first_name", txtFirstName.Text)
            .AddWithValue("middle_name", txtMiddleName.Text)
            .AddWithValue("last_name", txtLastName.Text)
            .AddWithValue("name_suffix", txtSuffix.Text)
            .AddWithValue("full_name", txtFullName.Text)
            .AddWithValue("nick_name", txtNickName.Text)
            .AddWithValue("place_of_birth", txtBirthPlace.Text)
            .AddWithValue("date_of_birth", dtpBirthDate.Value.Date)
            .AddWithValue("gender", cboGender.SelectedValue)
            .AddWithValue("religion", cboReligion.SelectedValue)
            AddParameter(cmd, "remark", txtRemark.Text, True)
        End With
        cmd.ExecuteNonQuery()

        strSQL = "DELETE FROM m_person_education WHERE personid = @personid"
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("personid", txtPersonID.Text)
        cmd.ExecuteNonQuery()

        strSQL = "INSERT INTO DBHR.dbo.m_person_education " &
                 " (personid, seq, education_level) VALUES " &
                 " (@personid, @seq, @education_level)"
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("personid", txtPersonID.Text)
        cmd.Parameters.AddWithValue("seq", 1)
        cmd.Parameters.AddWithValue("education_level", cboEducation.SelectedValue)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub SavePersonnel(ByVal cmd As SqlCommand)
        Dim strSQL As String = ""
        If CurrentTask = DocumentTask.NewRecord Then
            strSQL = "INSERT INTO DBHR.dbo.m_personnel " &
                     " (personnelid, personid, personnel_type, hiredate, employment_type, levelid, superior_personnelid, remark, status, idcreate, dtcreate, split) VALUES " &
                     " (@personnelid, @personid, @personnel_type, @hiredate, @employment_type, @levelid, @superior_personnelid, @remark, 00, 'hr_recruitment', GETDATE(), 00)"
        ElseIf CurrentTask = DocumentTask.EditRecord Then
            strSQL = "UPDATE DBHR.dbo.m_personnel SET " &
                     " personnel_type = @personnel_type, hiredate = @hiredate, employment_type = @employment_type, levelid = @levelid " &
                     " , superior_personnelid = @superior_personnelid, remark = @remark, idupdate = 'hr_admin', dtupdate = GETDATE()" &
                     " WHERE personnelid = @personnelid"
        End If
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        With cmd.Parameters
            .Clear()
            .AddWithValue("personid", txtPersonID.Text)
            .AddWithValue("personnelid", txtPersonnelID.Text)
            .AddWithValue("personnel_type", cboPersonnelType.SelectedValue)
            .AddWithValue("hiredate", dtpHiringDate.Value.Date)
            .AddWithValue("employment_type", cboEmploymentType.SelectedValue)
            .AddWithValue("levelid", cboLevel.SelectedValue)
            .AddWithValue("superior_personnelid", Superior)
            AddParameter(cmd, "remark", txtRemark.Text, True)
        End With
        cmd.ExecuteNonQuery()

        If CurrentTask = DocumentTask.NewRecord Then
            Dim reader As SqlDataReader
            Dim person_personnel_IsExist As Boolean = False

            strSQL = "SELECT * FROM DBHR.dbo.m_person_personnel WHERE personid = @personid"
            cmd.CommandTimeout = 1000
            cmd.CommandText = strSQL
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("personid", txtPersonID.Text)
            reader = cmd.ExecuteReader
            If reader.Read Then person_personnel_IsExist = True
            reader.Close()

            If person_personnel_IsExist Then
                strSQL = "UPDATE DBHR.dbo.m_person_personnel SET personnelid = @personnelid WHERE personid = @personid "
            Else
                strSQL = "INSERT INTO DBHR.dbo.m_person_personnel " &
                        " (personid, personnelid) VALUES (@personid, @personnelid)"
            End If
            cmd.CommandText = strSQL
            cmd.Parameters.Clear()
            With cmd.Parameters
                .Clear()
                .AddWithValue("personid", txtPersonID.Text)
                .AddWithValue("personnelid", txtPersonnelID.Text)
            End With
            cmd.ExecuteNonQuery()
        End If
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

    Private SuperiorID As Integer
    Public Property Superior() As Integer
        Get
            Return SuperiorID
        End Get
        Set(ByVal value As Integer)
            SuperiorID = value
            If value = Nothing Then
                lnkSuperior.Text = "Select Superior"
            Else
                lnkSuperior.Text = GetValue("DBHR", "v_personnel", "Personnel ID", "Person Name", value)
            End If
        End Set
    End Property

    Private Sub lnkSuperior_Click(sender As Object, e As EventArgs) Handles lnkSuperior.LinkClicked
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
        strSql = "SELECT [Personnel ID], [Person ID], [Person Name], [Personnel Type], [Personnel Level], [Employment Type], Status " &
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
                Superior = dlg.XDataGrid.GetSelectedValue("Personnel ID")
            End If
        End Using
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged, txtMiddleName.TextChanged, txtLastName.TextChanged
        txtFullName.Text = txtFirstName.Text & " " & txtMiddleName.Text & " " & txtLastName.Text
    End Sub
End Class