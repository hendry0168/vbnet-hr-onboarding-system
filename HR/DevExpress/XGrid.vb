Public Module XGrid

    'Public AccNumberFormat As String = "{0:#,##0;(#,##0);0}"

    Public Function DataTableHasColumn(dt As DataTable, ColumnName As String) As Boolean
        For Each col As DataColumn In dt.Columns
            If col.ColumnName = ColumnName Then Return True
        Next
        Return False
    End Function

    Public Sub SetDisplayFormatQuantityAmount(ByRef xdg As XDataGrid)
        For Each col As DataColumn In xdg.GetDataTable.Columns
            If col.ColumnName.ToLower.Contains("quantity") Or col.ColumnName.ToLower.Contains("amount") Or col.ColumnName.ToLower.Contains("balance") Then
                xdg.ColumnDisplayFormat(col.ColumnName) = "N2"
                xdg.AddBandSummary(col.ColumnName, AccNumberFormatN2, DevExpress.Data.SummaryItemType.Sum)
            End If
        Next
        xdg.grdData.BestFitColumns()
    End Sub

    Public Const AccNumberFormatN0 As String = "{0:N0}" '"{0:#,##0;(#,##0);0}"
    Public Const AccNumberFormatN2 As String = "{0:N2}" '{0.00:#,##0.00;(#,##0.00);0.00}"
    Public Const AccNumberFormatN4 As String = "{0:N4}"

    Public Sub InitDataType()
        fiN0.FormatString = "N0" '"#,##0"
        fiN0.FormatType = DevExpress.Utils.FormatType.Custom
        fiN4.FormatString = "N4" ' "#,##0.###"
        fiN4.FormatType = DevExpress.Utils.FormatType.Custom
        fiN2.FormatString = "N2"
        fiN2.FormatType = DevExpress.Utils.FormatType.Custom
        fiDate.FormatString = "dd MMM yyyy"
        fiDate.FormatType = DevExpress.Utils.FormatType.Custom
        fiMonth.FormatString = "MMMM yyyy"
        fiMonth.FormatType = DevExpress.Utils.FormatType.Custom
        fiDateTime.FormatString = "dd MMM yyyy HH:mm:ss"
        fiDateTime.FormatType = DevExpress.Utils.FormatType.Custom
    End Sub

    Public fiN0 As New DevExpress.Utils.FormatInfo
    Public fiN2 As New DevExpress.Utils.FormatInfo

    Public fiN4 As New DevExpress.Utils.FormatInfo
    Public fiDate As New DevExpress.Utils.FormatInfo
    Public fiMonth As New DevExpress.Utils.FormatInfo
    Public fiDateTime As New DevExpress.Utils.FormatInfo

    ''' <summary>
    ''' Sets the XGrid Layout to accomodate the table's datatype.
    ''' </summary>
    ''' <param name="grd">The XGridView GridView Control.</param>
    ''' <param name="dt">The DataTable.</param>
    ''' <param name="AssignDataSource">if set to <c>true</c> [assign data source].</param>
    Public Sub SetXGridDisplay(ByVal bnd As DevExpress.XtraGrid.Views.Grid.GridView, ByVal dt As DataTable, Optional ByVal AssignDataSource As Boolean = True)
        InitDataType()

        With bnd
            If AssignDataSource Then
                .GridControl.DataSource = Nothing
                .Columns.Clear()
                .GridControl.DataSource = dt
            End If
            FormatColumn(bnd)
        End With
    End Sub

    Public Sub FormatColumnDate(ByRef dview As DevExpress.XtraGrid.Views.Grid.GridView)
        dview.OptionsView.ColumnAutoWidth = False
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In dview.Columns
            Dim dtype As String = col.ColumnType.ToString()
            Dim colName As String = col.GetCaption
            If colName.Contains("ID") Or colName.ToLower.Contains("year") Then

            Else
                Select Case dtype
                    Case "System.DateTime"
                        If colName.ToLower.Contains("time") Then
                            col.DisplayFormat.Assign(fiDateTime)
                        ElseIf colName.ToLower.Contains("month") Then
                            col.DisplayFormat.Assign(fiMonth)
                        Else
                            col.DisplayFormat.Assign(fiDate)
                        End If
                End Select
            End If
        Next
        dview.BestFitColumns()
    End Sub

    Public Sub FormatColumn(ByRef dview As DevExpress.XtraGrid.Views.Grid.GridView)
        dview.OptionsView.ColumnAutoWidth = False
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In dview.Columns
            Dim dtype As String = col.ColumnType.ToString()
            Dim colName As String = col.GetCaption
            If colName.Contains("ID") Or colName.ToLower.Contains("year") Then

            Else
                Select Case dtype
                    Case "System.Int16", "System.Int32", "System.Int64", "System.Long"
                        col.DisplayFormat.Assign(fiN0)
                    Case "System.Decimal"
                        col.DisplayFormat.Assign(fiN2)
                    Case "System.Double"
                        col.DisplayFormat.Assign(fiN4)
                    Case "System.DateTime"
                        If colName.ToLower.Contains("time") Then
                            col.DisplayFormat.Assign(fiDateTime)
                        ElseIf colName.ToLower.Contains("month") Then
                            col.DisplayFormat.Assign(fiMonth)
                        Else
                            col.DisplayFormat.Assign(fiDate)
                        End If
                End Select
            End If
        Next
        dview.BestFitColumns()
    End Sub

    'Private Sub BestFit(dview As DevExpress.XtraGrid.Views.Grid.GridView)
    '    If dview Is Nothing Then
    '        Return
    '    End If

    'End Sub

    ''' <summary>
    ''' Sets the XGrid Layout to accomodate the table's datatype.
    ''' </summary>
    ''' <param name="grd">The XGridView BandedGridView Control.</param>
    ''' <param name="dt">The DataTable.</param>
    ''' <param name="AssignDataSource">if set to <c>true</c> [assign data source].</param>
    Public Sub SetXGridDisplay(ByVal bnd As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView, ByVal dt As DataTable, Optional ByVal AssignDataSource As Boolean = True)
        With bnd
            If AssignDataSource Then
                .GridControl.DataSource = Nothing
                .Columns.Clear()
                .GridControl.DataSource = dt
            End If

            For Each col As DevExpress.XtraGrid.Columns.GridColumn In .Columns
                Dim dtype As String = col.ColumnType.ToString()
                Dim colName As String = col.GetCaption
                If dtype = "System.Int16" Or dtype = "System.Int32" Or dtype = "System.Int64" Or dtype = "System.Long" Then
                    If colName.ToLower.Contains("id") Then

                    Else
                        col.DisplayFormat.Assign(fiN0)
                    End If
                    col.DisplayFormat.Assign(fiN0)
                ElseIf dtype = "System.Double" Or dtype = "System.Decimal" Then
                    col.DisplayFormat.Assign(fiN4)
                ElseIf dtype = "System.DateTime" Then
                    If colName.ToLower.Contains("time") Then
                        col.DisplayFormat.Assign(fiDateTime)
                    ElseIf colName.ToLower.Contains("month") Then
                        col.DisplayFormat.Assign(fiMonth)
                    Else
                        col.DisplayFormat.Assign(fiDate)
                    End If
                End If
            Next
        End With
        bnd.BestFitColumns()
    End Sub

    Public Sub AddBandSummary(ByVal bnd As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView, ByVal SummaryField As String, ByVal FormatString As String, Optional ByVal calcMethod As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)
        Try
            bnd.GroupSummary.Add(calcMethod, SummaryField, bnd.Columns(SummaryField), FormatString)
            bnd.Columns(SummaryField).SummaryItem.SummaryType = calcMethod
            bnd.Columns(SummaryField).SummaryItem.DisplayFormat = FormatString
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AddBandSummary(ByVal bnd As DevExpress.XtraGrid.Views.Grid.GridView, ByVal SummaryField As String, ByVal FormatString As String, Optional ByVal calcMethod As DevExpress.Data.SummaryItemType = DevExpress.Data.SummaryItemType.Sum)
        Try
            bnd.GroupSummary.Add(calcMethod, SummaryField, bnd.Columns(SummaryField), FormatString)
            bnd.Columns(SummaryField).SummaryItem.SummaryType = calcMethod
            bnd.Columns(SummaryField).SummaryItem.DisplayFormat = FormatString
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Exports the data.
    ''' </summary>
    ''' <param name="grc">The XtraGrid GridControl</param>
    ''' <param name="f">The file format</param>
    Public Sub ExportData(ByVal grc As DevExpress.XtraGrid.GridControl, ByVal f As FileFormat)
        Using dlgSave As New SaveFileDialog
            Select Case f
                Case FileFormat.CSV
                    dlgSave.Filter = "Comma Separated Value Files|*.csv"
                Case FileFormat.Excel
                    dlgSave.Filter = "Excel Workbooks|*.xls"
                Case FileFormat.ExcelX
                    dlgSave.Filter = "Excel Workbooks|*.xlsx"
                Case FileFormat.PDF
                    dlgSave.Filter = "Portable Document Format Files|*.pdf"
                Case FileFormat.Txt
                    dlgSave.Filter = "Text Files|*.txt"
                Case Else
                    Exit Sub
            End Select
            If dlgSave.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Select Case f
                        Case FileFormat.CSV
                            'Dim o As DevExpress.XtraPrinting.
                            grc.ExportToCsv(dlgSave.FileName)
                        Case FileFormat.Excel
                            grc.ExportToXls(dlgSave.FileName)
                        Case FileFormat.ExcelX
                            grc.ExportToXlsx(dlgSave.FileName)
                        Case FileFormat.PDF
                            grc.ExportToPdf(dlgSave.FileName)
                        Case FileFormat.Txt
                            grc.ExportToText(dlgSave.FileName)
                    End Select
                Catch ex As System.IO.IOException
                    MessageBox.Show("Cannot write to path. Please ensure the target folder is writable or the file is not in use.", "File IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using

    End Sub

    Public Function GetGridInfoCount(ByVal bnd As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView) As String
        Dim RowCount As Integer = 0
        Dim SelectedRowCount As Integer = 0
        Dim dt As DataTable = bnd.GridControl.DataSource
        If Not dt Is Nothing Then
            RowCount = dt.Rows.Count
            For Each xHandle As Integer In bnd.GetSelectedRows
                If xHandle >= 0 Then SelectedRowCount += 1
            Next
        End If
        Return RowCount & " record(s) displayed, " & SelectedRowCount & " selected."
    End Function

    Public Function GetSelectedRowCount(ByVal bnd As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView) As Integer
        GetSelectedRowCount = 0
        For Each xHandle As Integer In bnd.GetSelectedRows
            If xHandle >= 0 Then GetSelectedRowCount += 1
        Next
    End Function
End Module
