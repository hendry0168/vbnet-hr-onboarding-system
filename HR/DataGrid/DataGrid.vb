Public Module DataGrid
    Public Sub CopyDataGridViewrow(ByVal dgv_from As DataGridView, ByRef dgv_to As DataGridView)
        'Dim dgv_to As DataGridView = New DataGridView()
        Try
            'If dgv_to.Columns.Count = 0 Then
            '    For Each dgvc As DataGridViewColumn In dgv_from.Columns
            '        dgv_to.Columns.Add(TryCast(dgvc.Clone(), DataGridViewColumn))
            '    Next
            'End If

            Dim row As DataGridViewRow = New DataGridViewRow()

            For i As Integer = 0 To dgv_from.Rows.Count - 1
                row = CType(dgv_from.Rows(i).Clone(), DataGridViewRow)
                Dim intColIndex As Integer = 0

                For Each cell As DataGridViewCell In dgv_from.Rows(i).Cells
                    row.Cells(intColIndex).Value = cell.Value
                    intColIndex += 1
                Next

                dgv_to.Rows.Add(row)
            Next

            dgv_to.AllowUserToAddRows = False
            dgv_to.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub CommitDGVEdit(ByRef dgv As DataGridView)
        dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub
    Public Function RemoveDuplicateRows(ByVal dt As DataTable) As DataTable
        Dim strColumnName(dt.Columns.Count - 1) As String
        Dim x As Integer = 0
        For Each col As DataColumn In dt.Columns
            strColumnName(x) = col.ColumnName
            x += 1
        Next
        Return dt.DefaultView.ToTable(True, strColumnName)
    End Function
    Public Sub ChangeRowOrder(ByRef dgv As DataGridView, Up As Boolean, Optional ShowDGVRowNumber As Boolean = False)
        With dgv
            If .SelectedRows.Count = 1 Then
                Dim row As DataGridViewRow = .SelectedRows(0)
                Dim ix As Integer = .SelectedRows(0).Index
                If Up Then
                    If ix > 0 Then
                        .Rows.Remove(row)
                        .Rows.Insert(ix - 1, row)
                        .ClearSelection()
                        .Rows(ix - 1).Selected = True
                    End If
                Else
                    If ix < dgv.RowCount - 1 Then
                        .Rows.Remove(row)
                        .Rows.Insert(ix + 1, row)
                        .ClearSelection()
                        .Rows(ix + 1).Selected = True
                    End If
                End If
            End If
        End With
        If ShowDGVRowNumber Then ShowRowNumber(dgv)
    End Sub

    Public Sub ShowRowNumber(ByRef dgv As DataGridView)
        For Each row As DataGridViewRow In dgv.Rows
            row.HeaderCell.Value = String.Format("{0}", row.Index + 1)
        Next
        dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    End Sub

    Public Enum DataTableDataType As Short
        TypeString
        TypeDecimal
        TypeDate
    End Enum
    Public Sub ChangeColumnType(ByRef dt As DataTable, column_name As String, data_type As DataTableDataType)
        Dim dt_cloned As DataTable = dt.Clone
        Dim strType As String = "System.String"
        Select Case data_type
            Case DataTableDataType.TypeDecimal
                strType = "System.Decimal"
            Case DataTableDataType.TypeDate
                strType = "System.Date"
            Case DataTableDataType.TypeString
                strType = "System.String"
        End Select
        dt_cloned.Columns(column_name).DataType = Type.GetType(strType)

        For Each row As DataRow In dt.Rows
            dt_cloned.ImportRow(row)
        Next
        dt = dt_cloned
    End Sub

    Public Function Convert_DataGridView_To_DataTable(dgv As DataGridView, Optional FormattedValue As Boolean = True, Optional UseColumnName As Boolean = False) As DataTable
        'http://social.msdn.microsoft.com/Forums/en-US/aee54a55-c334-4141-9303-46790883a2cd/convert-datagridview-to-datatable?forum=vblanguage
        Dim dt As New DataTable()
        'If RetainColumnType Then
        '    For i As Integer = 0 To dgv.ColumnCount - 1
        '        dt.Columns.Add(dgv.Columns(i).HeaderText, dgv.Columns(i).GetType)
        '    Next
        '    For j As Integer = 0 To dgv.RowCount - 1
        '        Dim dr As DataRow = dt.NewRow()
        '        For i As Integer = 0 To dgv.ColumnCount - 1
        '            dr.Item(i) = dgv.Rows(j).Cells(i).Value
        '        Next
        '        dt.Rows.Add(dr)
        '    Next
        'Else
        For i As Integer = 0 To dgv.ColumnCount - 1
            Dim ColumnName As String
            If UseColumnName Then
                ColumnName = dgv.Columns(i).Name
            Else
                ColumnName = dgv.Columns(i).HeaderText
            End If
            dt.Columns.Add(ColumnName, System.Type.GetType("System.String"))
        Next
        For j As Integer = 0 To dgv.RowCount - 1
            Dim dr As DataRow = dt.NewRow()
            For i As Integer = 0 To dgv.ColumnCount - 1
                If FormattedValue Then
                    dr.Item(i) = dgv.Rows(j).Cells(i).FormattedValue
                Else
                    dr.Item(i) = dgv.Rows(j).Cells(i).Value
                End If
            Next
            dt.Rows.Add(dr)
        Next
        'End If
        Return dt
    End Function

    'Public Function Convert_DataGridView_To_DataTable(dgv As DataGridView) As DataTable
    '    'http://social.msdn.microsoft.com/Forums/en-US/aee54a55-c334-4141-9303-46790883a2cd/convert-datagridview-to-datatable?forum=vblanguage
    '    Dim dt As New DataTable()

    '    For i As Integer = 0 To dgv.ColumnCount - 1
    '        dt.Columns.Add(dgv.Columns(i).HeaderText, System.Type.GetType("System.String"))
    '    Next
    '    For j As Integer = 0 To dgv.RowCount - 1
    '        Dim dr As DataRow = dt.NewRow()
    '        For i As Integer = 0 To dgv.ColumnCount - 1
    '            dr.Item(i) = dgv.Rows(j).Cells(i).FormattedValue
    '        Next
    '        dt.Rows.Add(dr)
    '    Next
    '    Return dt
    'End Function

    'Public Sub SetGridLayout(ByVal dt As DataTable, ByVal dgv As DataGridView)
    '    Dim x As Integer
    '    For x = 0 To dt.Columns.Count - 1

    '        Dim dtype As String = dt.Columns(x).DataType.ToString
    '        If dtype = "System.Int16" Or dtype = "System.Int32" Or dtype = "System.Int64" Or dtype = "System.Long" Then
    '            If x > 0 Then
    '                dgv.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '                dgv.Columns(x).DefaultCellStyle.Format = "N0"
    '            End If
    '        ElseIf dtype = "System.Double" Or dtype = "System.Decimal" Then
    '            If x > 0 Then
    '                dgv.Columns(x).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '                dgv.Columns(x).DefaultCellStyle.Format = "N3"
    '            End If
    '        ElseIf dtype = "System.DateTime" Then
    '            If dt.Columns(x).ToString.ToLower.Contains("time") Then
    '                dgv.Columns(x).DefaultCellStyle.Format = "dd MMM yyyy HH:mm:ss"
    '            ElseIf dt.Columns(x).ToString.ToLower.Contains("month") Then
    '                dgv.Columns(x).DefaultCellStyle.Format = "MMM yyyy"
    '            Else
    '                dgv.Columns(x).DefaultCellStyle.Format = "dd MMM yyyy"
    '            End If
    '        End If
    '    Next
    '    dgv.AutoResizeRows()
    '    dgv.AutoResizeColumns()
    'End Sub
    Public Sub SetGridLayout(ByVal dt As DataTable, ByVal dgv As DataGridView, Optional ByVal WithOffset As Integer = 0)
        Dim x As Integer
        For x = 0 To dt.Columns.Count - 1 '+ WithOffset
            'For x = WithOffset To dt.Columns.Count - 1 '+ WithOffset
            Dim dtype As String = dt.Columns(x).DataType.ToString
            If dtype = "System.Int16" Or dtype = "System.Int32" Or dtype = "System.Int64" Or dtype = "System.Long" Or dtype = "System.Double" Or dtype = "System.Decimal" Then
                If x > 0 Then
                    dgv.Columns(x + WithOffset).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dgv.Columns(x + WithOffset).DefaultCellStyle.Format = "N"
                End If
            ElseIf dtype = "System.DateTime" Then
                If dt.Columns(x).ToString.ToLower.Contains("time") Then
                    dgv.Columns(x + WithOffset).DefaultCellStyle.Format = "dd MMM yyyy HH:mm:ss"
                ElseIf dt.Columns(x).ToString.ToLower.Contains("month") Then
                    dgv.Columns(x + WithOffset).DefaultCellStyle.Format = "MMM yyyy"
                Else
                    dgv.Columns(x + WithOffset).DefaultCellStyle.Format = "dd MMM yyyy"
                End If
            End If
        Next
    End Sub

    Private Function OS(ByVal Word As String) As String
        Word = RemoveCharFromWord(Word, ".")
        Word = RemoveCharFromWord(Word, " ")
        Return Word
    End Function

    Private Function RemoveCharFromWord(ByVal Word As String, ByVal theChar As String) As String
        Dim i As Integer = Word.IndexOf(theChar)
        While i > -1
            Word = Word.Remove(i, 1)
            i = Word.IndexOf(theChar)
        End While
        Dim arr() As String = Split(Word)
        Word = ""
        For i = 0 To arr.Length - 1
            Word &= arr(i)
        Next
        Return Word
    End Function

    Public Enum FileFormat As Integer
        Excel
        ExcelX
        PDF
        Txt
        CSV
    End Enum

    Public Sub ExportExcel(ByVal Table As DataTable, ByVal Location As String)
        If My.Computer.FileSystem.FileExists(Location) Then My.Computer.FileSystem.DeleteFile(Location)
        Dim CreateString As String = ""
        Dim Columns As String = ""
        Dim Mark As String = ""
        Using Connection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Location & ";Extended Properties=""Excel 8.0;HDR=YES""")
            Connection.Open()
            CreateString = "CREATE TABLE [" & Table.TableName & "] ("
            Columns = "("
            Mark = "("
            For Each Column As DataColumn In Table.Columns
                CreateString &= "[" & OS(Column.ColumnName) & "]"
                Select Case Column.DataType.Name
                    Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                        CreateString &= " Number, "
                    Case "Boolean"
                        CreateString &= " Bit, "
                    Case "Char", "String"
                        CreateString &= " Memo, "
                    Case "DateTime"
                        CreateString &= " DateTime, "
                    Case Else
                        CreateString &= " Text, "
                End Select
                Columns &= "[" & OS(Column.ColumnName) & "], "
                Mark &= "?,"
            Next
            CreateString = CreateString.Remove(CreateString.Length - 2, 2)
            CreateString &= ")"
            Columns = Columns.Remove(Columns.Length - 2, 2)
            Columns &= ")"
            Mark = Mark.Remove(Mark.Length - 1, 1)
            Mark &= ")"
            Using Command As New OleDb.OleDbCommand(CreateString.ToString, Connection)
                Command.ExecuteNonQuery()
            End Using
            Using Adapter As New OleDb.OleDbDataAdapter("SELECT * FROM [" & Table.TableName & "$]", Connection)
                Using ExcelDataset As New DataSet
                    Adapter.Fill(ExcelDataset, Table.TableName)
                    Adapter.InsertCommand = New OleDb.OleDbCommand("INSERT INTO [" & Table.TableName & "] " & Columns.ToString & " VALUES " & Mark.ToString, Connection)
                    For Each Column As DataColumn In Table.Columns
                        Select Case Column.DataType.Name
                            Case "SByte", "Byte", "Int16", "Int32", "Int64", "Decimal", "Double", "Single"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Numeric, 100, OS(Column.ColumnName))
                            Case "Boolean"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Boolean, 100, OS(Column.ColumnName))
                            Case "Char", "String"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Char, 65536, OS(Column.ColumnName))
                            Case "DateTime"
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.DBTimeStamp, 100, OS(Column.ColumnName))
                            Case Else
                                Adapter.InsertCommand.Parameters.Add("@" & OS(Column.ColumnName), OleDb.OleDbType.Char, 65536, OS(Column.ColumnName))
                        End Select
                    Next
                    For Each Row As DataRow In Table.Rows
                        If Row.RowState <> DataRowState.Deleted Then
                            Dim ExcelRow As DataRow = ExcelDataset.Tables(Table.TableName).NewRow
                            For i As Integer = 0 To Table.Columns.Count - 1
                                ExcelRow.Item(i) = Row.Item(i)
                            Next
                            ExcelDataset.Tables(Table.TableName).Rows.Add(ExcelRow)
                        End If
                    Next
                    Adapter.Update(ExcelDataset, Table.TableName)
                End Using
            End Using
        End Using
    End Sub

    Public Sub ExportXML(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.Xml.XmlTextWriter(Location, System.Text.Encoding.UTF8)
            Writer.WriteStartDocument()
            Table.WriteXml(Writer, XmlWriteMode.WriteSchema)
            Writer.WriteEndDocument()
            Writer.Close()
        End Using
    End Sub

    Public Sub ExportHTML(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.IO.StreamWriter(Location)
            Writer.WriteLine("<HTML>")
            Writer.WriteLine(" <HEAD>")
            Writer.WriteLine("  <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>")
            Writer.WriteLine(" </HEAD>")
            Writer.WriteLine(" <BODY>")
            Writer.WriteLine("<TABLE border='1'>")
            Writer.WriteLine(" <TR>")
            For Each Column As DataColumn In Table.Columns
                Writer.WriteLine("  <TD>" & Column.ColumnName & "</td>")
            Next
            Writer.WriteLine(" </TR>")
            For Each Row As DataRow In Table.Rows
                Writer.WriteLine(" <TR>")
                For Each Column As DataColumn In Table.Columns
                    Writer.WriteLine("  <TD>" & Row.Item(Column).ToString & "</TD>")
                Next
                Writer.WriteLine(" </TR>")
            Next
            Writer.WriteLine("</TABLE>")
            Writer.WriteLine(" </BODY>")
            Writer.WriteLine("</HTML>")
        End Using
    End Sub

    Public Sub ExportText(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.IO.StreamWriter(Location)
            Writer.WriteLine("Executed: " + DateTime.Now.ToString)
            For i As Integer = 0 To 99
                Writer.Write("*")
            Next
            Writer.WriteLine("")
            For Each Column As DataColumn In Table.Columns
                Writer.WriteLine("")
                Writer.WriteLine(Column.ColumnName)
                For i As Integer = 0 To 99
                    Writer.Write("-")
                Next
                Writer.WriteLine("")
                For Each Row As DataRow In Table.Rows
                    Writer.WriteLine(Row(Column).ToString)
                Next
            Next
            For i As Integer = 0 To 99
                Writer.Write("*")
            Next
            Writer.Close()
        End Using
    End Sub

    Public Sub ExportCSV(ByVal Table As DataTable, ByVal Location As String)
        Using Writer As New System.IO.StreamWriter(Location)
            For Each Row As DataRow In Table.Rows
                For Each Column As DataColumn In Table.Columns
                    If Row.Item(Column).GetType Is GetType(DateTime) Then
                        Writer.Write(CType(Row.Item(Column), DateTime).ToString(My.Computer.Info.InstalledUICulture.DateTimeFormat.SortableDateTimePattern))
                    Else
                        Dim Value As String = Row.Item(Column).ToString
                        If Value.Contains(Chr(13)) Then
                            Writer.Write(Chr(34) & Row.Item(Column).ToString & Chr(34))
                        Else
                            Writer.Write(Row.Item(Column).ToString)
                        End If
                    End If
                    If Column.Ordinal + 1 < Table.Columns.Count Then Writer.Write(";")
                Next
                Writer.WriteLine()
            Next
            Writer.Close()
        End Using
    End Sub

    Public Function HasZeroQuantity(ByVal dgv As DataGridView, ByVal QuantityFieldName As String) As Boolean
        For Each row As DataGridViewRow In dgv.Rows
            If Not IsDBNull(row.Cells(QuantityFieldName).Value) Then
                If row.Cells(QuantityFieldName).Value = 0 Then Return True
            End If
        Next
        Return False
    End Function

    Public Function DoesItemExistInDataGridView(ByVal id As Object, ByVal index As Integer, ByVal dgv As DataGridView) As Integer
        For Each row As DataGridViewRow In dgv.Rows
            If Not IsDBNull(row.Cells(index).Value) Then
                If row.Cells(index).Value = id Then Return row.Index
            End If
        Next
        Return -1
    End Function
    Public Function DoesItemExistInDataGridView(ByVal id1 As Object, ByVal id2 As Object, ByVal index1 As Integer, ByVal index2 As Integer, ByVal dgv As DataGridView) As Integer
        Dim x As Integer
        For x = 0 To dgv.Rows.Count - 1
            Dim a As Object = dgv.Rows(x).Cells(index1).Value
            Dim b As Object = dgv.Rows(x).Cells(index2).Value
            If a = id1 And b = id2 Then Return x
        Next
        Return -1
    End Function

    Public Function DoesItemExistInDataTable(ByVal id As Object, ByVal IndexName As Object, ByVal dt As DataTable) As Integer
        For Each row As DataRow In dt.Rows
            If Not IsDBNull(row(IndexName)) Then
                If row(IndexName) = id Then Return 1
            End If
        Next
        Return -1
    End Function

    'Public Function DoesItemExistInDataGridViewStringType(ByVal id As Object, ByVal index As Integer, ByVal dgv As DataGridView) As String
    '    For Each row As DataGridViewRow In dgv.Rows
    '        If Not IsDBNull(row.Cells(index).Value) Then
    '            If row.Cells(index).Value.ToString = id Then Return row.Index
    '        End If
    '    Next
    '    Return -1
    'End Function
End Module