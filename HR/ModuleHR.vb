Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Module ModuleHR
    Private ServerName As String = Connection.ServerName
    Public Enum HRSystemID As Short
        EducationEntry = 1
        GenderEntry = 2
        ReligionEntry = 3
        EmploymentTypeEntry = 4
        PersonnelLevelEntry = 5
        DocStatusEntry = 6
        PersonnelStatusEntry = 7
        PersonnelTypeEntry = 8
        PersonnelActionEntry = 9
        OnboardingEntry = 10
        OffboardingEntry = 11
        EmployeeReport = 12
        OnboardingReport = 13
        OffboardingReport = 14
        PersonID = 15
        PersonnelID = 16
    End Enum

    Public Function GetSystemName(ByVal SystemID As Integer) As String
        Dim SystemName As String = ""
        Select Case SystemID
            Case HRSystemID.EducationEntry
                SystemName = "Education Entry"
            Case HRSystemID.GenderEntry
                SystemName = "Gender Entry"
            Case HRSystemID.ReligionEntry
                SystemName = "Religion Entry"
            Case HRSystemID.EmploymentTypeEntry
                SystemName = "Employment Type Entry"
            Case HRSystemID.PersonnelLevelEntry
                SystemName = "Personnel Level Entry"
            Case HRSystemID.DocStatusEntry
                SystemName = "Document Status Entry"
            Case HRSystemID.PersonnelStatusEntry
                SystemName = "Personnel Status Entry"
            Case HRSystemID.PersonnelTypeEntry
                SystemName = "Personnel Type Entry"
            Case HRSystemID.PersonnelActionEntry
                SystemName = "Personnel Action Entry"
            Case HRSystemID.OnboardingEntry
                SystemName = "Onboarding Entry"
            Case HRSystemID.OffboardingEntry
                SystemName = "Offboarding Entry"
            Case HRSystemID.EmployeeReport
                SystemName = "Employee Report"
            Case HRSystemID.OnboardingReport
                SystemName = "Onboarding Report"
            Case HRSystemID.OffboardingReport
                SystemName = "Offboarding Report"
        End Select

        Return SystemName
    End Function

    Public Enum DocumentTask As Short
        ViewOnly = 0 'can only view, no other
        NewRecord = 1 'only new record
        EditRecord = 2 'only edit record
        ProcessRecord = 3 'cannot save, only print and change status
    End Enum

    Public Function GetDataforComboBox(ByVal ViewName As String) As DataTable
        Dim dt As New DataTable
        Dim strSql As String = ""
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return Nothing
        Dim cmd As New SqlCommand(strSql, cn)
        Dim da As New SqlDataAdapter(cmd)

        dt = New DataTable
        strSql = "SELECT ID, Name FROM DBHR.dbo." & ViewName
        cmd.CommandText = strSql
        cmd.Parameters.Clear()
        da.Fill(dt)

        Return dt
    End Function

    Public Function GetSeparationRemarkforComboBox(ByVal ParentID As Integer) As DataTable
        Dim dt As New DataTable
        Dim strSql As String = ""
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return Nothing
        Dim cmd As New SqlCommand(strSql, cn)
        Dim da As New SqlDataAdapter(cmd)

        dt = New DataTable
        strSql = "SELECT ID, Name FROM DBHR.dbo.s_personnel_action WHERE parentid = " & ParentID
        cmd.CommandText = strSql
        cmd.Parameters.Clear()
        da.Fill(dt)

        Return dt
    End Function

    Public Function GetRunningNumber(ByVal CurrentSystemID As Integer) As Integer
        Dim strSql As String = ""
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return Nothing
        Dim cmd As New SqlCommand(strSql, cn)
        Dim reader As SqlDataReader

        Select Case CurrentSystemID
            Case HRSystemID.EducationEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_education_level ORDER BY id DESC"
            Case HRSystemID.GenderEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_gender ORDER BY id DESC"
            Case HRSystemID.ReligionEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_religion ORDER BY id DESC"
            Case HRSystemID.EmploymentTypeEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_employment_type ORDER BY id DESC"
            Case HRSystemID.PersonnelLevelEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_personnel_level ORDER BY id DESC"
            Case HRSystemID.DocStatusEntry
                strSql = "SELECT TOP 1 statusid AS id FROM DBHR.dbo.s_doc_status ORDER BY statusid DESC"
            Case HRSystemID.PersonnelStatusEntry
                strSql = "SELECT TOP 1 statusid AS id FROM DBHR.dbo.s_record_status ORDER BY statusid DESC"
            Case HRSystemID.PersonnelTypeEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_personnel_type ORDER BY id DESC"
            Case HRSystemID.PersonnelActionEntry
                strSql = "SELECT TOP 1 id FROM DBHR.dbo.s_personnel_action ORDER BY id DESC"
            Case HRSystemID.PersonID
                strSql = "SELECT TOP 1 personid AS id FROM DBHR.dbo.m_person ORDER BY CAST(personid AS integer) DESC"
            Case HRSystemID.PersonnelID
                strSql = "SELECT TOP 1 personnelid AS id FROM DBHR.dbo.m_personnel ORDER BY CAST(personnelid AS integer) DESC"
        End Select

        cmd.CommandTimeout = 1000
        cmd.CommandText = strSql
        cmd.Parameters.Clear()
        reader = cmd.ExecuteReader
        Try
            If reader.Read Then
                If Not IsDBNull(reader("id")) Then
                    GetRunningNumber = reader("id") + 1
                Else
                    GetRunningNumber = 1
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Retrieve Data Failed")
        End Try
    End Function

    Public Function GetRunningDocNo(ByVal CurrentSystemID As Integer) As String
        Dim strSql As String = ""
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return Nothing
        Dim cmd As New SqlCommand(strSql, cn)
        Dim reader As SqlDataReader

        Select Case CurrentSystemID
            Case HRSystemID.OnboardingEntry
                strSql = "SELECT TOP 1 docno FROM DBHR.dbo.t_hiring ORDER BY docno DESC"
            Case HRSystemID.OffboardingEntry
                strSql = "SELECT TOP 1 docno FROM DBHR.dbo.t_separation ORDER BY docno DESC"
        End Select

        cmd.CommandTimeout = 1000
        cmd.CommandText = strSql
        cmd.Parameters.Clear()
        reader = cmd.ExecuteReader
        Try
            If reader.Read Then
                If Not IsDBNull(reader("docno")) Then
                    GetRunningDocNo = reader("docno") + 1
                End If
            Else
                GetRunningDocNo = 1
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Retrieve Data Failed")
        End Try
    End Function

    Public Function GetValue(DB As String, TableName As String, IDField As String, NameField As String, FieldKey As String) As Object
        GetValue = Nothing
        Dim strSQL As String = "SELECT [" & NameField & "] FROM [" & TableName & "] WHERE [" & IDField & "] = @key"
        Dim cn As New SqlConnection
        Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=" & DB & ";Integrated Security=True"
        cn.ConnectionString = ConnectionString
        cn.Open()
        If cn Is Nothing Then Return Nothing
        Using cmd As New SqlCommand(strSQL, cn)
            cmd.Parameters.AddWithValue("key", FieldKey)
            Dim reader As SqlDataReader
            Try
                reader = cmd.ExecuteReader
                If reader.Read Then
                    If IsDBNull(reader(NameField)) Then
                        GetValue = Nothing
                    Else
                        GetValue = reader(NameField)
                    End If
                Else
                    GetValue = Nothing
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Retrieve Data Failed")
            End Try
        End Using
    End Function
End Module
