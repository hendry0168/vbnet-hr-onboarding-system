Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading
Public Class FormAdmin
    Private dt As DataTable
    Private CurrentSystemID As HRSystemID
    Private keyfield As String = ""
    Private ServerName As String = Connection.ServerName

    Public Sub New(SelectedSystemID As HRSystemID)
        InitializeComponent()
        CurrentSystemID = SelectedSystemID
        Me.Text = "Document Administration - " & GetSystemName(CurrentSystemID)

        'Select Case CurrentSystemID
        '    Case CurrentSystemID = HRSystemID.OnboardingEntry
        '        btnStatusFilter.Visible = True
        '        cboStatus.Visible = True
        '    Case CurrentSystemID = HRSystemID.OffboardingEntry
        '        btnStatusFilter.Visible = True
        '        cboStatus.Visible = True
        'End Select

        RefreshGrid()
        Me.ShowDialog()
    End Sub

    Private Sub RefreshGrid()
        pctLoading.Visible = True
        Dim StrSql As String = ""
        Dim IsMasterData As Boolean = False
        Select Case CurrentSystemID
            Case HRSystemID.EducationEntry
                StrSql = "SELECT ID, Name, [Alternate Name] FROM DBHR.dbo.v_education_level"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.GenderEntry
                StrSql = "SELECT ID, Name FROM DBHR.dbo.v_gender"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.ReligionEntry
                StrSql = "SELECT ID, Name FROM DBHR.dbo.v_religion"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.EmploymentTypeEntry
                StrSql = "SELECT ID, Name, Remark FROM DBHR.dbo.v_employment_type"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.PersonnelLevelEntry
                StrSql = "SELECT ID, Name FROM DBHR.dbo.v_personnel_level"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.DocStatusEntry
                StrSql = "SELECT ID, Name, Remark FROM DBHR.dbo.v_doc_status"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.PersonnelStatusEntry
                StrSql = "SELECT ID, Name, Remark FROM DBHR.dbo.v_record_status"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.PersonnelTypeEntry
                StrSql = "SELECT ID, Name FROM DBHR.dbo.v_personnel_type"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.PersonnelActionEntry
                StrSql = "SELECT ID, Name, [Parent ID], [Level], [To Status ID], [To Status] FROM DBHR.dbo.v_personnel_action"
                IsMasterData = True
                keyfield = "ID"
            Case HRSystemID.OnboardingEntry
                StrSql = "SELECT [Document No], Header, [Document Date], [Hiring Date], [Person ID], [Personnel ID], [Person Name], [Employment Type], Status " &
                         " FROM DBHR.dbo.v_hiring"
                IsMasterData = False
                keyfield = "Document No"
            Case HRSystemID.OffboardingEntry
                StrSql = "SELECT [Document No], Header, [Document Date], [Effective Date], [Person ID], [Personnel ID], [Person Name], [Remark 1], [Remark 2], Status " &
                         " FROM DBHR.dbo.v_separation"
                IsMasterData = True
                keyfield = "Document No"
            Case Else
                Exit Sub
        End Select

        If IsMasterData Then
            btnStatusFilter.Visible = False
            cboStatus.Visible = False
        Else
            If cboStatus.Visible And cboStatus.ComboBox.SelectedIndex > -1 Then StrSql &= " WHERE [Status ID] = " & cboStatus.ComboBox.SelectedValue
        End If

        Try
            dt = New DataTable
            Dim cn As New SqlConnection
            Dim ConnectionString As String = "Data Source= " & ServerName & ";Initial Catalog=DBHR;Integrated Security=True"
            cn.ConnectionString = ConnectionString
            cn.Open()
            If cn Is Nothing Then Exit Sub
            Dim cmd As New SqlCommand(StrSql, cn)
            Dim da As New SqlDataAdapter(cmd)
            cmd.CommandText = StrSql
            da.Fill(dt)
            pctLoading.Visible = False
            XDataGrid.ReloadGrid(dt, True)
        Catch ex As Exception
            MessageBox.Show("Failed to load data", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Select Case CurrentSystemID
            Case HRSystemID.EducationEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.GenderEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.ReligionEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.EmploymentTypeEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelLevelEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.DocStatusEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelStatusEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelTypeEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelActionEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.NewRecord(CurrentSystemID)
                End Using
            Case HRSystemID.OnboardingEntry
                Using frm As New FormOnboardingEntry
                    frm.NewRecord()
                End Using
            Case HRSystemID.OffboardingEntry
                Using frm As New FormOffboardingEntry
                    frm.NewRecord()
                End Using
        End Select

        RefreshGrid()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim DocID As String = XDataGrid.GetSelectedValue(keyfield)
        If Not DocID = Nothing Then
            ViewDocument(CurrentSystemID, DocID, True)
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim DocID As String = XDataGrid.GetSelectedValue(keyfield)
        If Not DocID = Nothing Then
            ViewDocument(CurrentSystemID, DocID, False)
        End If
    End Sub

    Private Sub XDataGrid_DoubleClicked() Handles XDataGrid.DoubleClicked
        Dim DocID As String = XDataGrid.GetSelectedValue(keyfield)
        If Not DocID = Nothing Then
            ViewDocument(CurrentSystemID, DocID, False)
        End If
    End Sub

    Public Sub ViewDocument(ByVal CurrentSystemID As Integer, ByVal DocID As String, ByVal Editable As Boolean)
        Select Case CurrentSystemID
            Case HRSystemID.EducationEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.GenderEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.ReligionEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.EmploymentTypeEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelLevelEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.DocStatusEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelStatusEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelTypeEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.PersonnelActionEntry
                Using frm As New FormGenericMasterDataEntry
                    frm.ViewRecord(DocID, Editable, CurrentSystemID)
                End Using
            Case HRSystemID.OnboardingEntry
                Using frm As New FormOnboardingEntry
                    frm.ViewRecord(DocID, Editable)
                End Using
            Case HRSystemID.OffboardingEntry
                Using frm As New FormOffboardingEntry
                    frm.ViewRecord(DocID, Editable)
                End Using
        End Select

        RefreshGrid()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshGrid()
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        RefreshGrid()
    End Sub

    Private Sub btnStatusFilter_Click(sender As Object, e As EventArgs) Handles btnStatusFilter.Click
        StatusFiltered = Not cboStatus.Visible
        RefreshGrid()
    End Sub

    Private Property StatusFiltered As Boolean
        Set(value As Boolean)
            cboStatus.Visible = value
            If value Then
                btnStatusFilter.Text = "Status"
            Else
                btnStatusFilter.Text = "All Status"
            End If
        End Set
        Get
            Return cboStatus.Visible
        End Get
    End Property
End Class