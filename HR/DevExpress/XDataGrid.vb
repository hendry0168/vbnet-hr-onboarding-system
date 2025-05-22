Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class XDataGrid
    Public dt As DataTable = Nothing
    Public Event DoubleClicked()
    Public Event SelectionChanged()
    Public Event FocusedRowChanged()
    Public LoadStructure As Boolean = True
    Public Event KeyEntered()
    Public GridTitle As String = ""
    Private regKey As String = "HKEY_CURRENT_USER\PHG\GridLayout\"

    Public Function GetDataTable() As DataTable
        Return dt
    End Function

    Public Sub ClearDataSource()
        dt = Nothing
        grcData.DataSource = Nothing
    End Sub

    Public Sub ReloadGrid(ByVal theData As DataTable, Optional ByVal LoadTableStructure As Boolean = False, Optional FormatTable As Boolean = True)
        SaveGridLayout()
        If LoadStructure = False Then
            Me.LoadStructure = LoadTableStructure
        Else
            Me.LoadStructure = True
        End If
        dt = theData
        Try
            If LoadStructure Then
                Dim filter As String = txtFilter.Text
                txtFilter.Clear()
                If FormatTable Then
                    SetXGridDisplay(grdData, dt)
                    grdData.OptionsDetail.ShowDetailTabs = False
                Else
                    grdData.GridControl.DataSource = Nothing
                    grdData.Columns.Clear()
                    grdData.GridControl.DataSource = dt
                End If
                txtFilter.Text = filter
            Else
                grcData.DataSource = dt
            End If
            LoadStructure = False
            grdData.ClearSelection()
            RunLocalFilter()
            LoadGridLayout()
            CellMultiLine = _AllowMultiLine
        Catch ex As Exception

        End Try

    End Sub

    Public Property CellMultiLine As Boolean
        Get
            Return _AllowMultiLine
        End Get
        Set(value As Boolean)
            Dim RepoMemo As New RepositoryItemMemoEdit
            RepoMemo.AutoHeight = value
            grcData.RepositoryItems.Add(RepoMemo)
            grdData.OptionsView.RowAutoHeight = value
            For Each column As GridColumn In grdData.Columns
                column.ColumnEdit = RepoMemo
            Next
            AllowMultiLineToolStripMenuItem.Checked = value
            _AllowMultiLine = value
        End Set
    End Property

    Public Property ColumnDisplayFormat(ByVal ColumnName As String) As String
        Get
            Return grdData.Columns(ColumnName).DisplayFormat.FormatString
        End Get
        Set(ByVal value As String)
            Try
                grdData.Columns(ColumnName).DisplayFormat.FormatString = value
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public Property ColumnDisplayFormat(ByVal ColumnIndex As Integer) As String
        Get
            Return grdData.Columns(ColumnIndex).DisplayFormat.FormatString
        End Get
        Set(ByVal value As String)
            Try
                grdData.Columns(ColumnIndex).DisplayFormat.FormatString = value
            Catch ex As Exception

            End Try
        End Set
    End Property

    Private ListOfHiddenColumn As New List(Of String)

    Private Sub HideColumn(ColumnName As String)
        For Each field As String In ListOfHiddenColumn
            If field = ColumnName Then Exit Sub
        Next
        ListOfHiddenColumn.Add(ColumnName)
    End Sub

    Private Sub UnHideColumn(ColumnName As String)
        For Each field As String In ListOfHiddenColumn
            If field = ColumnName Then
                ListOfHiddenColumn.Remove(field)
                Exit Sub
            End If
        Next
    End Sub

    Public Property ColumnVisible(ByVal ColumnName As String) As Boolean
        Get
            Return grdData.Columns(ColumnName).Visible
        End Get
        Set(ByVal value As Boolean)
            Try
                If Not grdData.Columns(ColumnName) Is Nothing Then
                    grdData.Columns(ColumnName).Visible = value
                End If
                If value Then
                    UnHideColumn(ColumnName)
                Else
                    HideColumn(ColumnName)
                End If
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public Property ColumnVisible(ByVal ColumnIndex As Integer) As Boolean
        Get
            Return grdData.Columns(ColumnIndex).Visible
        End Get
        Set(ByVal value As Boolean)
            Try
                grdData.Columns(ColumnIndex).Visible = value
                Dim ColumnName As String = grdData.Columns(ColumnIndex).FieldName
                If value Then
                    UnHideColumn(ColumnName)
                Else
                    HideColumn(ColumnName)
                End If
            Catch ex As Exception

            End Try
        End Set
    End Property

    Public Property AllowMultiSelection() As Boolean
        Get
            Return grdData.OptionsSelection.MultiSelect
        End Get
        Set(ByVal value As Boolean)
            grdData.OptionsSelection.MultiSelect = value
        End Set
    End Property

    Public Sub ExportToCSV()
        XGrid.ExportData(grcData, FileFormat.CSV)
    End Sub

    Public Sub ExportToExcel(Optional UseLegacyExcel As Boolean = False)
        If UseLegacyExcel Then
            XGrid.ExportData(grcData, FileFormat.Excel)
        Else
            XGrid.ExportData(grcData, FileFormat.ExcelX)
        End If
    End Sub

    Public Sub ExportToPDF()
        XGrid.ExportData(grcData, FileFormat.PDF)
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        ExportToExcel()
    End Sub

    Private Sub PDFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDFToolStripMenuItem.Click
        ExportToPDF()
    End Sub

    Public Sub ExpandAllGroups()
        grdData.ExpandAllGroups()
        ExpandORCollapseAllRows(True)
    End Sub

    Public Sub ExpandORCollapseAllRows(Expand As Boolean)
        Try
            For Each dview As DevExpress.XtraGrid.Views.Grid.GridView In grdData.GridControl.ViewCollection
                dview.BeginUpdate()

                Dim dataRowCount As Integer = dview.DataRowCount
                Dim rHandle As Integer
                For rHandle = 0 To dataRowCount - 1
                    dview.SetMasterRowExpanded(rHandle, Expand)
                Next
                dview.EndUpdate()
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CollapseAllGroups()
        grdData.CollapseAllGroups()
        ExpandORCollapseAllRows(False)
    End Sub

    Private Sub ExpandAllGroupsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpandAllGroupsToolStripMenuItem.Click
        ExpandAllGroups()
    End Sub

    Private Sub CollapseAllGroupsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollapseAllGroupsToolStripMenuItem.Click
        CollapseAllGroups()
    End Sub

    Public Property MergeIdenticalCells() As Boolean
        Get
            Return grdData.OptionsView.AllowCellMerge
        End Get
        Set(ByVal value As Boolean)
            If value Then grdData.ClearSelection()
            grdData.OptionsView.AllowCellMerge = value
            AllowCellMergeToolStripMenuItem.Checked = value
        End Set
    End Property

    Public Property ShowGroupPanel() As Boolean
        Get
            Return grdData.OptionsView.ShowGroupPanel
        End Get
        Set(ByVal value As Boolean)
            grdData.OptionsView.ShowGroupPanel = value
            ShowGroupFooter = value
        End Set
    End Property

    Public Property ShowFilterPanel() As Boolean
        Get
            Return tspSearch.Visible
        End Get
        Set(ByVal value As Boolean)
            If value Then
                If dt Is Nothing Then Exit Property
            End If
            tspSearch.Visible = value
            grdData.ActiveFilter.Clear()
            If value Then
                ActiveControl = txtFilter.Control
                grdData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                grdData.OptionsFilter.AllowFilterEditor = False
            Else
                txtFilter.Clear()
                grdData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                grdData.OptionsFilter.AllowFilterEditor = True
            End If
            ShowFilterPanelToolStripMenuItem.Checked = value
        End Set
    End Property

    Public Property ShowGroupFooter() As Boolean
        Get
            Return ShowGroupFooterToolStripMenuItem.Checked
        End Get
        Set(ByVal value As Boolean)
            If value Then
                grdData.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
            Else
                grdData.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
            End If
            ShowGroupFooterToolStripMenuItem.Checked = value
        End Set
    End Property

    Public Property ShowRowCountFooter As Boolean
        Get
            Return ShowRowsCountToolStripMenuItem.Checked
        End Get
        Set(value As Boolean)
            tspRowCount.Visible = value
            ShowRowsCountToolStripMenuItem.Checked = value
        End Set
    End Property

    Private Sub ShowGroupFooterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowGroupFooterToolStripMenuItem.Click
        ShowGroupFooter = ShowGroupFooterToolStripMenuItem.Checked
    End Sub

    Private Sub ShowGroupPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowGroupPanelToolStripMenuItem.Click
        ShowGroupPanel = ShowGroupPanelToolStripMenuItem.Checked
    End Sub

    Private Sub AllowCellMergeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllowCellMergeToolStripMenuItem.Click
        MergeIdenticalCells = AllowCellMergeToolStripMenuItem.Checked
    End Sub

    Private Sub ShowFilterPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowFilterPanelToolStripMenuItem.Click
        ShowFilterPanel = ShowFilterPanelToolStripMenuItem.Checked
    End Sub

    Private Sub txtFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Escape Then Me.ShowFilterPanel = False ' txtFilter.Text = ""
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        RunLocalFilter()
    End Sub

    Private Sub RunLocalFilter()
        Try
            If txtFilter.Text.Length > 0 Then
                Dim strActiveFilter As String = ""
                Dim x As Short = 1
                For Each col As DataColumn In dt.Columns
                    strActiveFilter &= " [" & col.ColumnName & "] LIKE '%" & txtFilter.Text & "%' "
                    If x < dt.Columns.Count Then strActiveFilter &= " OR "
                    x = x + 1
                Next
                grdData.ActiveFilterString = strActiveFilter
            Else
                grdData.ActiveFilter.Clear()
            End If
            grdData.BestFitColumns()
            lblTotalRecordsDisplayed.Text = grdData.RowCount & " row(s) displayed. "
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdData_EndGrouping(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdData.EndGrouping
        grdData.BestFitColumns()
        grdData.ClearSelection()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ShowFilterPanel = False
        txtFilter.Text = ""
    End Sub

    Private Sub grcData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdData.DoubleClick
        RaiseEvent DoubleClicked()
    End Sub

    Private Sub grdData_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grdData.SelectionChanged
        RaiseEvent SelectionChanged()
        Try
            lblTotalRecordsSelected.Text = Me.GetSelectedRows.Count & " row(s) selected."
        Catch ex As Exception
        End Try
    End Sub


    Private Sub grdData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles grdData.FocusedRowChanged
        RaiseEvent FocusedRowChanged()
    End Sub

    Public Sub AddBandSummary(ByVal SummaryField As String, ByVal FormatString As String, Optional ByVal calcMethod As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)
        Try
            If grdData.Columns.Count > 0 Then
                If ColumnNameExists(dt, SummaryField) Then
                    grdData.GroupSummary.Add(calcMethod, SummaryField, grdData.Columns(SummaryField), FormatString)
                    grdData.Columns(SummaryField).SummaryItem.SummaryType = calcMethod
                    grdData.Columns(SummaryField).SummaryItem.DisplayFormat = FormatString
                End If
            End If

        Catch ex As NullReferenceException

        Catch ex As Exception
        End Try
    End Sub

    Public Sub AddGrouping(ByVal SummaryField As String, Optional ByVal XOrderBy As DevExpress.Data.ColumnSortOrder = DevExpress.Data.ColumnSortOrder.Ascending, Optional DoShowGroupPanel As Boolean = False)
        grdData.GroupCount += 1
        grdData.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(grdData.Columns(SummaryField), XOrderBy)})
        ShowGroupPanel = DoShowGroupPanel
    End Sub

    ''' <summary>
    ''' Gets the value.
    ''' </summary>
    ''' <param name="ColumnName">Name of the column.</param>
    ''' <param name="RowIndex">Index of the row.</param>
    ''' <returns></returns>
    Public Function GetValue(ByVal ColumnName As String, ByVal RowIndex As Integer) As Object
        Try
            Return grdData.GetRowCellValue(RowIndex, ColumnName)
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
        If ColumnIndex < 0 Then Return Nothing
        Try
            Return grdData.GetRowCellValue(RowIndex, dt.Columns(ColumnIndex).ColumnName)
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
        If grdData.SelectedRowsCount > 0 Then
            Dim ix() As Integer = grdData.GetSelectedRows
            If ix(0) < 0 Then
                Return Nothing
            Else
                Return grdData.GetRowCellValue(ix(0), ColumnName)
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Gets the selected value.
    ''' </summary>
    ''' <param name="ColumnIndex">Index of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValue(Optional ByVal ColumnIndex As Integer = 0) As Object
        If ColumnIndex < 0 Then Return Nothing
        If grdData.SelectedRowsCount > 0 Then
            Dim ix() As Integer = grdData.GetSelectedRows
            If ix(0) < 0 Then
                Return Nothing
            Else
                Return grdData.GetRowCellValue(ix(0), dt.Columns(ColumnIndex).ColumnName)
            End If
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Gets the selected values.
    ''' </summary>
    ''' <param name="ColumnIndex">Index of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValues(Optional ByVal ColumnIndex As Short = 0) As Object
        If ColumnIndex < 0 Then Return Nothing
        If grdData.SelectedRowsCount > 0 Then
            Dim ix() As Integer = grdData.GetSelectedRows
            Dim arr As New ArrayList
            For Each x As Integer In ix
                If x >= 0 Then arr.Add(grdData.GetRowCellValue(x, dt.Columns(ColumnIndex).ColumnName))
            Next
            Return arr
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Gets the selected values.
    ''' </summary>
    ''' <param name="ColumnName">Name of the column.</param>
    ''' <returns></returns>
    Public Function GetSelectedValues(ByVal ColumnName As String) As ArrayList
        If grdData.SelectedRowsCount > 0 Then
            Dim ix() As Integer = grdData.GetSelectedRows
            Dim arr As New ArrayList
            For Each x As Integer In ix
                If x >= 0 Then arr.Add(grdData.GetRowCellValue(x, ColumnName))
            Next
            Return arr
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Gets the selected rows.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetSelectedRows() As DataRowCollection
        If dt Is Nothing Then Return Nothing
        Dim dtSearch As DataTable = dt.Clone  'grcData.DataSource
        'Dim dt As DataTable = dtSearch.Clone
        Dim x As Integer
        For x = 0 To grdData.SelectedRowsCount - 1
            Dim dr As DataRow = grdData.GetDataRow(grdData.GetSelectedRows(x))
            dtSearch.ImportRow(dr)
        Next
        Return dtSearch.Rows
    End Function

    ''' <summary>
    ''' Gets the total rows.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRowCount() As Integer
        If dt Is Nothing Then
            Return 0
        Else
            Return dt.Rows.Count
        End If
    End Function

    Private _AllowMultiLine As Boolean = False
    Private ContextMenuEnabled As Boolean = True

    ' ReadOnly property
    ''' <summary>
    ''' Gets or sets a value indicating whether context menu is enabled or disabled.
    ''' </summary>
    ''' <value></value>
    ''' <returns>true for context menu is enabled; otherwise, false. The default value is true.
    ''' </returns>
    Public Overloads Property EnableContextMenu() As Boolean
        Get
            Return Me.ContextMenuEnabled
        End Get
        Set(ByVal value As Boolean)
            Me.ContextMenuEnabled = value
            If value Then
                Me.ContextMenuStrip = cmsXDataGrid
            Else
                Me.ContextMenuStrip = Nothing
            End If
        End Set
    End Property

    Private Sub grdData_MasterRowExpanded(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles grdData.MasterRowExpanded
        Dim dview As DevExpress.XtraGrid.Views.Grid.GridView = grdData.GetDetailView(e.RowHandle, e.RelationIndex)
        dview.OptionsView.ShowFooter = False
        For Each field As String In ListOfHiddenColumn
            Try
                dview.Columns(field).Visible = False
            Catch ex As Exception

            End Try
        Next
        FormatColumn(dview)
    End Sub

    'Private Sub grdData_ViewRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles grcData.ViewRemoved
    '    Dim dview As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(e.View, DevExpress.XtraGrid.Views.Grid.GridView)
    '    For Each field As String In ListOfHiddenColumn
    '        Try
    '            dview.Columns(field).Visible = False
    '        Catch ex As Exception

    '        End Try
    '    Next
    'End Sub

    Private Sub grdData_ViewRegistered(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles grcData.ViewRegistered
        Dim dview As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(e.View, DevExpress.XtraGrid.Views.Grid.GridView)
        For Each field As String In ListOfHiddenColumn
            Try
                dview.Columns(field).Visible = False
            Catch ex As Exception

            End Try
        Next
        FormatColumn(dview)
    End Sub

    Private Sub CopySelectedCellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectedCellToolStripMenuItem.Click
        If grdData.FocusedRowHandle > 0 And grdData.FocusedRowHandle > 0 Then
            If grdData.GetRowCellValue(grdData.FocusedRowHandle, grdData.FocusedColumn) IsNot Nothing AndAlso grdData.GetRowCellValue(grdData.FocusedRowHandle, grdData.FocusedColumn).ToString() <> [String].Empty Then
                Dim TextToBeCopied As String = grdData.GetRowCellValue(grdData.FocusedRowHandle, grdData.FocusedColumn).ToString()
                Clipboard.SetText(TextToBeCopied)
                'MessageBox.Show(TextToBeCopied)

            Else
                'MessageBox.Show("The value in the selected cell is null or empty!")
            End If
        End If

    End Sub

    Private Sub AllowMultiLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllowMultiLineToolStripMenuItem.Click
        CellMultiLine = AllowMultiLineToolStripMenuItem.Checked
    End Sub

    Private Sub ShowRowsCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowRowsCountToolStripMenuItem.Click
        ShowRowCountFooter = ShowRowsCountToolStripMenuItem.Checked
    End Sub

    Private layoutStream As System.IO.Stream

    Public Sub SaveGridLayout()
        layoutStream = New System.IO.MemoryStream
        grdData.SaveLayoutToStream(layoutStream)
        layoutStream.Seek(0, System.IO.SeekOrigin.Begin)
    End Sub
    Public Sub LoadGridLayout()
        If Not layoutStream Is Nothing Then
            grdData.RestoreLayoutFromStream(layoutStream)
            layoutStream.Seek(0, System.IO.SeekOrigin.Begin)
        End If
    End Sub

    Private Sub grdData_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        If e.KeyCode = Keys.Enter Then
            RaiseEvent KeyEntered()
        End If
    End Sub

    Private Sub SaveLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLayoutToolStripMenuItem.Click
        grdData.OptionsLayout.StoreAllOptions = True
        grdData.SaveLayoutToRegistry(regKey & GridTitle, DevExpress.Utils.OptionsLayoutBase.FullLayout)
    End Sub

    Private Sub RestoreLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreLayoutToolStripMenuItem.Click
        grdData.RestoreLayoutFromRegistry(regKey & GridTitle, DevExpress.Utils.OptionsLayoutBase.FullLayout)
    End Sub

    Private totalValue As Decimal = 0
    Private Sub gridView1_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles grdData.CustomSummaryCalculate
        If e.IsGroupSummary Then
            If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then
                e.TotalValue = CDec(e.FieldValue)
                totalValue += CDec(e.FieldValue)
            End If
        Else
            e.TotalValue = totalValue
        End If
    End Sub

End Class
