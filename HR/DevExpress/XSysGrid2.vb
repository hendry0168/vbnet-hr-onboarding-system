Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Public Class XSysGrid2
    Private DoNotSearch As Boolean = True

    Public cn As SqlConnection
    Public strSQL As String
    Public TableName As String

    Public MaxCount As Int64 = Nothing
    Private DefaultMaxCount As Int64 = 200

    Public FieldKeyIndex As Short = 0

    Private strMaxCount As String
    Private strOrderBy As String

    Public Event RowSelected(ByVal key As Object)
    Public Event DoubleClicked(ByVal key As Object)
    Public Event DataLoaded(ByVal dt As DataTable)

    Private cmd As New SqlCommand()

    Private dlgFilter As New DialogFilter
    Private strDataFilter As String = ""

    Private strSQLFilter As String = ""
    Private DisplayedFields() As String = Nothing
    Private strSQLFields As String = ""

    Public ListOfFieldsToSearch As New ArrayList

    Public Sub LoadTableStructure()
        Dim strSQL As String
        strSQL = "SELECT TOP(0) " & strSQLFields & " FROM " & TableName
        strSQL = "SELECT TOP(0) * FROM " & TableName
        Using da As New SqlDataAdapter(strSQL, cn)
            Try
                da.Fill(dt)
                If DisplayedFields Is Nothing Then
                    strSQLFields = "*"
                Else
                    If DisplayedFields.Length > 0 Then
                        strSQLFields = ""
                        'Dim ListOfColumnsToBeRemoved As New ArrayList

                        For Each displayed_field_name As String In DisplayedFields
                            Dim display_this_column As Boolean = False
                            For Each col As DataColumn In dt.Columns
                                If col.ColumnName = displayed_field_name Then
                                    display_this_column = True
                                    strSQLFields &= "[" & displayed_field_name & "], "
                                    Exit For
                                End If
                            Next
                        Next

                        'For Each col As DataColumn In dt.Columns
                        '    Dim display_this_column As Boolean = False
                        '    For Each displayed_field_name As String In DisplayedFields
                        '        If col.ColumnName = displayed_field_name Then
                        '            display_this_column = True
                        '            strSQLFields &= "[" & displayed_field_name & "], "
                        '            Exit For
                        '        End If
                        '    Next
                        '    If Not display_this_column Then ListOfColumnsToBeRemoved.Add(col)
                        'Next

                        'For Each col As DataColumn In ListOfColumnsToBeRemoved
                        '    dt.Columns.Remove(col)
                        'Next
                        If strSQLFields.Length > 0 Then
                            strSQLFields = Strings.Left(strSQLFields, strSQLFields.Length - 2)
                        Else
                            strSQLFields = "*"
                        End If
                    Else
                        strSQLFields = "*"
                    End If
                End If


            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private UseDISTINCT As Boolean
    Private Const DISTINCT As String = " DISTINCT "

    Public Property WithDISTINCT As Boolean
        Get
            Return UseDISTINCT
        End Get
        Set(value As Boolean)
            UseDISTINCT = value
        End Set
    End Property

    Public UseThreading As Boolean = True


    Public Structure DateFilter
        Public DateField As String
        Public FromDate As Date
        Public ToDate As Date
    End Structure
    ''' <summary>
    ''' Inits the search.
    ''' </summary>
    ''' <param name="Table_Name">Name of the table/view.</param>
    ''' <param name="Displayed_Fields">The array of displayed fields.</param>
    ''' <param name="Max_Count">The maximum number of displayed records.</param>
    ''' <param name="Connection_String">The connection string.</param>
    ''' <param name="SQLFilter_String">The SQL filter string (without WHERE clause).</param>
    ''' <param name="OrderBy_String">Order by string (without ORDER BY clause).</param>
    Public Sub initSearch(ByVal Table_Name As String,
                               ByVal Displayed_Fields() As String,
                               ByVal Max_Count As Int64,
                               ByVal Connection_String As String,
                               Optional ByVal SQLFilter_String As String = Nothing,
                               Optional ByVal OrderBy_String As String = Nothing) ', Optional Date_Filter As DateFilter = Nothing)

        strOrderBy = OrderBy_String
        MaxCount = Max_Count
        If MaxCount = 0 Then
            ShowAllRecordsToolStripMenuItem.Checked = True
        Else
            ShowAllRecordsToolStripMenuItem.Checked = False
        End If
        strSQLFilter = SQLFilter_String
        cn = New SqlConnection(Connection_String)
        TableName = "[" & Table_Name & "]"
        Me.DisplayedFields = Displayed_Fields

        If MaxCount = Nothing Or MaxCount = 0 Then
            strMaxCount = ""
        Else
            strMaxCount = "TOP " & MaxCount.ToString
        End If
        If strSQLFilter = Nothing Then
            strSQLFilter = ""
        Else
            strSQLFilter = " WHERE " & strSQLFilter
        End If

        'If Date_Filter.DateField.Trim.ToString > 0 And Not Date_Filter.FromDate = Nothing Then

        'End If

        If strOrderBy = Nothing Then
            strOrderBy = ""
        Else
            strOrderBy = " ORDER BY " & strOrderBy
        End If

        strSQLFields = "*"

        dt = New DataTable
        LoadTableStructure()
        ConstructSearchSQL()
        cmd = New SqlCommand(strSQL, cn)
        cmd.CommandTimeout = 1000
        da = New SqlDataAdapter(cmd)
        pnlInitialize.Visible = False
        tspSearch.Enabled = True
        RefreshData()
    End Sub

    Public Sub initStructure(ByVal Table_Name As String, ByVal Connection_String As String)
        cn = New SqlConnection(Connection_String)
        TableName = "[" & Table_Name & "]"

        strMaxCount = "TOP 0"

        strSQLFields = "*"

        dt = New DataTable
        LoadTableStructure()
        FillDataFinished()
    End Sub

    'Public Sub AddBandSummary(ByVal bnd As DevExpress.XtraGrid.Views.Grid.GridView, ByVal SummaryField As String, ByVal FormatString As String, Optional ByVal calcMethod As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)
    '    Try
    '        bnd.GroupSummary.Add(calcMethod, SummaryField, bnd.Columns(SummaryField), FormatString)
    '        bnd.Columns(SummaryField).SummaryItem.SummaryType = calcMethod
    '        bnd.Columns(SummaryField).SummaryItem.DisplayFormat = FormatString
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Public Sub AddBandSummary(ByVal SummaryField As String, ByVal FormatString As String, Optional ByVal calcMethod As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)
        Try
            XDataGrid.AddBandSummary(SummaryField, FormatString, calcMethod)
        Catch ex As Exception
        End Try
    End Sub

    Private da As SqlDataAdapter
    Private dt As DataTable

    Public ReadOnly Property GetDataTable() As DataTable
        Get
            Return dt
        End Get
    End Property

    Public Sub ConstructSearchSQL()
        If MaxCount = Nothing Then
            strMaxCount = ""
        Else
            strMaxCount = "TOP " & MaxCount.ToString
        End If
        Dim strWhereSearch As String = ""
        If Not Trim(txtSearch.Text) = "" Then
            If dt.Columns.Count > 0 Then
                If Not strSQLFilter = "" Then
                    strWhereSearch = " AND "
                Else
                    strWhereSearch = " WHERE "
                End If
                strWhereSearch &= "("
                Dim HasFirstFilter As Boolean = False
                For Each col As DataColumn In dt.Columns
                    Dim FieldName As String = col.ColumnName
                    If ExactStringSearchToolStripMenuItem.Checked Then
                        If FieldIsIncludedInSearch(FieldName) Then
                            If HasFirstFilter Then
                                strWhereSearch &= " OR "
                            End If
                            strWhereSearch &= "[" & FieldName & "] LIKE '%" & txtSearch.Text.Replace("'", "''") & "%'"
                            HasFirstFilter = True
                        End If
                    Else
                        If FieldIsIncludedInSearch(FieldName) Then
                            Dim ListOfWords As String() = txtSearch.Text.Split(" ")
                            For Each word As String In ListOfWords
                                word = word.Trim
                                If HasFirstFilter Then
                                    strWhereSearch &= " OR "
                                End If
                                strWhereSearch &= "[" & FieldName & "] LIKE '%" & word.Replace("'", "''") & "%'"
                                HasFirstFilter = True
                            Next
                        End If
                    End If
                Next
                'Dim x As Integer = 0
                'For x = 0 To dt.Columns.Count - 1
                '    Dim FieldName As String = dt.Columns(x).ColumnName
                '    If ExactStringSearchToolStripMenuItem.Checked Then
                '        If FieldIsIncludedInSearch(FieldName) Then
                '            strWhereSearch &= "[" & FieldName & "] LIKE '%" & txtSearch.Text.Replace("'", "''") & "%'"
                '            If x < dt.Columns.Count - 1 Then strWhereSearch &= " OR "
                '        End If
                '    Else
                '        If FieldIsIncludedInSearch(FieldName) Then
                '            Dim ListOfWords As String() = txtSearch.Text.Split(" ")
                '            Dim a As Integer = 0
                '            For Each word As String In ListOfWords
                '                word = word.Trim
                '                strWhereSearch &= "[" & FieldName & "] LIKE '%" & word.Replace("'", "''") & "%'"
                '                If a < ListOfWords.Length - 1 Then strWhereSearch &= " OR "
                '                a += 1
                '            Next
                '            If x < dt.Columns.Count - 1 Then strWhereSearch &= " OR "
                '        End If
                '    End If
                'Next
                strWhereSearch &= ")"
            End If
        End If
        Dim strDISTINCT As String = ""
        If UseDISTINCT Then 'strOrderBy.Trim.Length = 0
            strDISTINCT = DISTINCT
        End If
        strSQL = "SELECT " & strDISTINCT & strMaxCount & " " & strSQLFields & " FROM " & TableName & strSQLFilter & strWhereSearch & strOrderBy
        cmd.CommandText = strSQL
    End Sub

    Private Function FieldIsIncludedInSearch(ByVal FieldName As String) As Boolean
        FieldIsIncludedInSearch = False
        If ListOfFieldsToSearch.Count > 0 Then
            For Each search_fields As String In ListOfFieldsToSearch
                If search_fields = FieldName Then Return True
            Next
        Else
            Return True
        End If
    End Function

    Private Sub SysGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActiveControl = txtSearch.Control
        DoNotSearch = False
    End Sub

    ''' <summary>
    ''' Gets or sets a value indicating whether [allow multi selection].
    ''' </summary>
    ''' <value><c>true</c> if [allow multi selection]; otherwise, <c>false</c>.</value>
    Public Property AllowMultiSelection() As Boolean
        Get
            Return XDataGrid.AllowMultiSelection
        End Get
        Set(ByVal value As Boolean)
            XDataGrid.AllowMultiSelection = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the value.
    ''' </summary>
    ''' <param name="ColumnName">Name of the column.</param>
    ''' <param name="RowIndex">Index of the row.</param>
    ''' <returns></returns>
    Public Function GetValue(ByVal ColumnName As String, ByVal RowIndex As Integer) As Object
        Try
            Return XDataGrid.GetValue(ColumnName, RowIndex)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Gets the value.
    ''' </summary>
    ''' <param name="ColumnIndex">Index of the column.</param>
    ''' <param name="RowIndex">Index of the row.</param>
    ''' <returns></returns>
    Public Function GetValue(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer) As Object
        Try
            Return XDataGrid.GetValue(ColumnIndex, RowIndex)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Gets the selected value.
    ''' </summary>
    ''' <param name="ColumnName">Name of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValue(ByVal ColumnName As String) As Object
        Return XDataGrid.GetSelectedValue(ColumnName)
    End Function

    ''' <summary>
    ''' Gets the selected value.
    ''' </summary>
    ''' <param name="ColumnIndex">Index of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValue(Optional ByVal ColumnIndex As Integer = -1) As Object
        Return XDataGrid.GetSelectedValue(ColumnIndex)
    End Function

    ''' <summary>
    ''' Gets the selected values.
    ''' </summary>
    ''' <param name="ColumnIndex">Index of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValues(Optional ByVal ColumnIndex As Short = -1) As Object
        Return XDataGrid.GetSelectedValues(ColumnIndex)
    End Function

    ''' <summary>
    ''' Gets the selected values.
    ''' </summary>
    ''' <param name="ColumnName">Name of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValues(ByVal ColumnName As String) As ArrayList
        Return XDataGrid.GetSelectedValues(ColumnName)
    End Function

    ''' <summary>
    ''' Gets the selected rows.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetSelectedRows() As DataRowCollection
        Return XDataGrid.GetSelectedRows
    End Function

    Private SelectAfterSearch As Object

    ''' <summary>
    ''' Refreshes the data.
    ''' </summary>    
    Public Sub RefreshData(Optional ByVal SelectedKey As Object = Nothing)
        SelectAfterSearch = SelectedKey
        If DoNotSearch Then Exit Sub
        If MaxCount > 0 Then
            lblMax.Text = "Max " & MaxCount & " records"
        Else
            lblMax.Text = "All records"
        End If

        If ListOfFieldsToSearch.Count > 0 Then
            lblMax.Text &= " in "
            Dim x As Integer = 0
            For Each fields As String In ListOfFieldsToSearch
                x += 1
                lblMax.Text &= fields
                If x < ListOfFieldsToSearch.Count Then lblMax.Text &= ", "
            Next
        End If

        strDataFilter = ""
        lblFilter.Text = "No filter"
        lblLoading.Text = "Loading Data..."
        XDataGrid.ClearDataSource()
        LockControls(True, True)
        ConstructSearchSQL()
        If UseThreading Then
            If Not bgwProcess.IsBusy Then bgwProcess.RunWorkerAsync()
        Else
            FillData()
            FillDataFinished()
        End If
    End Sub

    Public AllowMultiLine As Boolean = False

    Private Sub bgwProcess_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcess.DoWork
        FillData()
    End Sub

    Private Sub FillData()
        dt.Clear()
        dt.Columns.Clear()
        Try
            da.Fill(dt)
        Catch ex As Exception
            'Dim strMsg As String = ex.ToString
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FillDataFinished()
        Try
            lblLoading.Text = "Ready."
            XDataGrid.ReloadGrid(dt, True)
            If Not DisplayedFields Is Nothing Then
                If DisplayedFields.Length > 0 Then
                    For Each col As DataColumn In dt.Columns
                        Dim HideColumn As Boolean = True
                        For Each FieldName As String In DisplayedFields
                            If col.ColumnName = FieldName Then
                                HideColumn = False
                                Exit For
                            End If
                        Next
                        If HideColumn Then XDataGrid.ColumnVisible(col.ColumnName) = False
                    Next
                End If

                'If DisplayedFields.Length > 0 Then
                '    Dim x As Integer = 0
                '    strSQLFields = ""
                '    For x = 0 To DisplayedFields.Length - 1
                '        strSQLFields = strSQLFields & "[" & DisplayedFields(x) & "]"
                '        If x < DisplayedFields.Length - 1 Then strSQLFields = strSQLFields & ", "
                '    Next
                'Else
                '    strSQLFields = "*"
                'End If
            End If
            Dim FirstSummaryField As String = dt.Columns(0).ColumnName

            If Not XDataGrid.grdData.Columns("Equipment Name") Is Nothing Then
                If ParentForm.Text = "IT Equipment Master" Then
                    XDataGrid.ColumnVisible("Equipment Name") = False
                End If
            End If

            XDataGrid.AddBandSummary(FirstSummaryField, "{0:#,##0;(#,##0);0}", DevExpress.Data.SummaryItemType.Count)
            XDataGrid.CellMultiLine = AllowMultiLine
            LockControls(False)
            RaiseEvent DataLoaded(dt)
            If XDataGrid.GetDataTable.Rows.Count > 0 Then
                XDataGrid.grdData.SelectRow(0)
                'Else
                RaiseEvent RowSelected(GetSelectedValue())
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bgwProcess_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcess.RunWorkerCompleted
        If Not bgwProcess.CancellationPending Then FillDataFinished()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click, ExactStringSearchToolStripMenuItem.CheckedChanged
        RefreshData()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            RefreshData()
        End If
    End Sub

    ''' <summary>
    ''' Locks the controls.
    ''' </summary>
    ''' <param name="locked">if set to <c>true</c> disable user inputs.</param>
    ''' <param name="HideGrid">if set to <c>true</c> hide grid and show loading progress circle.</param>
    Public Sub LockControls(ByVal locked As Boolean, Optional ByVal HideGrid As Boolean = False)
        txtSearch.ReadOnly = locked
        btnSearch.Enabled = Not locked
        btnSetting.Enabled = Not locked
        XDataGrid.Enabled = Not locked
        If locked Then
            If HideGrid Then pctViewReport.Visible = True
        Else
            pctViewReport.Visible = locked
        End If
    End Sub

    Private Sub ShowAllRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllRecordsToolStripMenuItem.Click
        MaxCount = 0
        If ShowAllRecordsToolStripMenuItem.Checked Then
            Me.MaxCount = 0
        Else
            Me.MaxCount = Me.DefaultMaxCount
        End If
        RefreshData()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        txtSearch.SelectAll()
        txtSearch.Focus()
        'tspSearch.Focus()
        tspSearch.Select()
    End Sub

    Private Sub XDataGrid_DoubleClicked() Handles XDataGrid.DoubleClicked
        Dim key As Object = GetSelectedValue()
        RaiseEvent DoubleClicked(key)
    End Sub

    Private Sub XDataGrid_SelectionChanged() Handles XDataGrid.SelectionChanged
        Dim key As Object
        If XDataGrid.GetSelectedRows.Count > 0 Then
            key = GetSelectedValue()
        Else
            key = Nothing
        End If
        RaiseEvent RowSelected(key)
    End Sub
End Class
