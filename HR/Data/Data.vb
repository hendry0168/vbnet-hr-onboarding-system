Imports System.Data.SqlClient

Public Module Data
    Public Function GetDataTableCellValue(dt As DataTable, IDFieldName As String, ID As Object, ValueFieldName As String) As Object
        If Not ColumnNameExists(dt, IDFieldName) Then Return Nothing
        If Not ColumnNameExists(dt, ValueFieldName) Then Return Nothing
        For Each row As DataRow In dt.Rows
            If row(IDFieldName) = ID Then Return row(ValueFieldName)
        Next
        Return Nothing
    End Function

    Public Function GetDataRowValue(row As DataRow, columnName As String) As Object
        If row.Table.Columns.Contains(columnName) Then
            Return row(columnName)
        Else
            Return Nothing
        End If
    End Function

    Public Function ConvertDGVToHTML(dgv As DataGridView) As String
        'Table start.
        Dim html As String
        'html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>"
        html = "<table>"

        'Adding HeaderRow.
        html &= "<tr>"

        For Each column As DataGridViewColumn In dgv.Columns
            'html &= "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" & column.HeaderText & "</th>"
            html &= "<th>" & column.HeaderText & "</th>"
        Next
        html &= "</tr>"

        'Adding DataRow.
        For Each row As DataGridViewRow In dgv.Rows
            html &= "<tr>"

            For Each cell As DataGridViewCell In row.Cells
                'html &= "<td style='width:120px;border: 1px solid #ccc'>" & cell.Value.ToString() & "</td>"
                html &= "<td>" & cell.FormattedValue.ToString() & "</td>"
            Next

            html &= "</tr>"
        Next

        'Table end.
        html &= "</table>"
        Return html
    End Function

    Public Function ColumnNameExists(dt_view_structure As DataTable, ColumnName As String) As Boolean
        If dt_view_structure Is Nothing Then Return False
        For Each col As DataColumn In dt_view_structure.Columns
            If col.ColumnName = ColumnName Then Return True
        Next
        Return False
    End Function

    Public Sub DeleteRecords(ByVal TableName As String, TableFieldKey As String, PrimaryKeyValue As Object, ByRef cmd As SqlCommand, Optional bgw As System.ComponentModel.BackgroundWorker = Nothing, Optional ByRef strSQL As String = Nothing, Optional AdditionalFilter As String = "")
        strSQL = "DELETE FROM " & TableName
        strSQL &= " WHERE [" & TableFieldKey & "] = @" & TableFieldKey.Replace(" ", "")
        If AdditionalFilter.Length > 0 Then strSQL &= AdditionalFilter
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@" & TableFieldKey.Replace(" ", ""), PrimaryKeyValue)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub DeleteRecords(ByVal TableName As String, TableFieldKey As String, ListOfKeyID As List(Of String), ByRef cmd As SqlCommand, Optional bgw As System.ComponentModel.BackgroundWorker = Nothing, Optional ByRef strSQL As String = Nothing, Optional AdditionalFilter As String = "")
        If ListOfKeyID Is Nothing Then Exit Sub
        If ListOfKeyID.Count = 0 Then Exit Sub
        Dim strSQLFilterIN As String = ""
        Dim x As Integer = 0
        If ListOfKeyID.Count > 0 Then
            strSQLFilterIN = " IN ("
            x = 0
            For Each RecordID As String In ListOfKeyID
                strSQLFilterIN &= "'" & RecordID & "'"
                x += 1
                If x < ListOfKeyID.Count Then strSQLFilterIN &= ", "
            Next
            strSQLFilterIN &= ")"
        End If

        strSQL = "DELETE FROM " & TableName
        strSQL &= " WHERE [" & TableFieldKey & "] " & strSQLFilterIN


        If AdditionalFilter.Length > 0 Then strSQL &= AdditionalFilter
        cmd.CommandText = strSQL
        cmd.Parameters.Clear()
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub UpdateRecords(ByVal theDataTable As DataTable, PrimaryKeyField As String, ByRef cmd As SqlCommand, Optional bgw As System.ComponentModel.BackgroundWorker = Nothing, Optional ByRef strSQL As String = Nothing, Optional AdditionalFilter As String = "")
        strSQL = "UPDATE " & theDataTable.TableName & " SET "
        Dim x As Integer = 1
        For Each col As DataColumn In theDataTable.Columns
            If col.ColumnName <> PrimaryKeyField Then
                strSQL &= "[" & col.ColumnName & "] = @" & col.ColumnName.Replace(" ", "")
                If x < theDataTable.Columns.Count Then strSQL &= ", "
            End If
            x += 1
        Next
        strSQL &= " WHERE [" & PrimaryKeyField & "] = @" & PrimaryKeyField.Replace(" ", "")
        If AdditionalFilter.Length > 0 Then strSQL &= " AND " & AdditionalFilter

        Dim Processed As Long = 0
        For Each row As DataRow In theDataTable.Rows
            cmd.Parameters.Clear()
            For Each col As DataColumn In theDataTable.Columns
                If IsDBNull(row(col.ColumnName)) Then
                    cmd.Parameters.AddWithValue("@" & col.ColumnName.Replace(" ", ""), DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@" & col.ColumnName.Replace(" ", ""), row(col.ColumnName))
                End If
            Next
            cmd.CommandText = strSQL
            cmd.ExecuteNonQuery()
            Processed += 1
            If Not bgw Is Nothing Then bgw.ReportProgress(Processed / theDataTable.Rows.Count * 100)
        Next
    End Sub
    Public Function InsertRecords(ByVal theDataTable As DataTable, cnDest As SqlConnection, Optional ByRef strSQL As String = Nothing) As Boolean
        InsertRecords = False
        If theDataTable Is Nothing Then Return False
        strSQL = "INSERT INTO " & theDataTable.TableName & " ("
        Dim x As Integer = 1
        For Each col As DataColumn In theDataTable.Columns
            strSQL &= "[" & col.ColumnName & "]"
            If x < theDataTable.Columns.Count Then strSQL &= ", "
            x += 1
        Next
        strSQL &= ") VALUES ("
        x = 1
        For Each col As DataColumn In theDataTable.Columns
            strSQL &= "@" & col.ColumnName.Replace(" ", "")
            If x < theDataTable.Columns.Count Then strSQL &= ", "
            x += 1
        Next
        strSQL &= ")"
        Using cmdDest As New SqlCommand(strSQL, cnDest)
            For Each row As DataRow In theDataTable.Rows
                cmdDest.Parameters.Clear()
                For Each col As DataColumn In theDataTable.Columns
                    Dim ParameterColumnName As String = col.ColumnName.Replace(" ", "")
                    If IsDBNull(row(col.ColumnName)) Then
                        cmdDest.Parameters.AddWithValue("@" & ParameterColumnName, DBNull.Value)
                    Else
                        If col.DataType.ToString = "System.DateTime" Then
                            If row(col.ColumnName) < SqlTypes.SqlDateTime.MinValue.Value Or row(col.ColumnName) > SqlTypes.SqlDateTime.MaxValue.Value Then
                                cmdDest.Parameters.AddWithValue("@" & ParameterColumnName, DBNull.Value)
                            Else
                                cmdDest.Parameters.AddWithValue("@" & ParameterColumnName, row(col.ColumnName))
                            End If
                        Else
                            cmdDest.Parameters.AddWithValue("@" & ParameterColumnName, row(col.ColumnName))
                        End If
                    End If
                Next
                cmdDest.ExecuteNonQuery()
            Next
        End Using
        Return True
    End Function

    Public Function InsertRecords(ByVal theDataTable As DataTable, ByRef cmd As SqlCommand, Optional bgw As System.ComponentModel.BackgroundWorker = Nothing, Optional ByRef strSQL As String = Nothing) As Boolean
        InsertRecords = False
        If theDataTable Is Nothing Then Return False
        strSQL = "INSERT INTO " & theDataTable.TableName & " ("
        Dim x As Integer = 1
        For Each col As DataColumn In theDataTable.Columns
            strSQL &= "[" & col.ColumnName & "]"
            If x < theDataTable.Columns.Count Then strSQL &= ", "
            x += 1
        Next
        strSQL &= ") VALUES ("
        x = 1
        For Each col As DataColumn In theDataTable.Columns
            strSQL &= "@" & col.ColumnName.Replace(" ", "")
            If x < theDataTable.Columns.Count Then strSQL &= ", "
            x += 1
        Next
        strSQL &= ")"
        cmd.CommandText = strSQL
        Dim Processed As Long = 0
        For Each row As DataRow In theDataTable.Rows
            cmd.Parameters.Clear()
            For Each col As DataColumn In theDataTable.Columns
                Dim ParameterColumnName As String = col.ColumnName.Replace(" ", "")
                If IsDBNull(row(col.ColumnName)) Then
                    cmd.Parameters.AddWithValue("@" & col.ColumnName.Replace(" ", ""), DBNull.Value)
                Else
                    If col.DataType.ToString = "System.DateTime" Then
                        If row(col.ColumnName) < SqlTypes.SqlDateTime.MinValue.Value Or row(col.ColumnName) > SqlTypes.SqlDateTime.MaxValue.Value Then
                            cmd.Parameters.AddWithValue("@" & ParameterColumnName, DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@" & ParameterColumnName, row(col.ColumnName))
                        End If
                    Else
                        cmd.Parameters.AddWithValue("@" & ParameterColumnName, row(col.ColumnName))
                    End If
                End If
            Next
            Dim inserted_records As Integer = cmd.ExecuteNonQuery()
            Processed += 1
            If Not bgw Is Nothing Then bgw.ReportProgress(Processed / theDataTable.Rows.Count * 100)
        Next
        InsertRecords = True
    End Function

    Public Function InsertBulkRecords(ByVal theDataTable As DataTable, ByRef cmd As SqlCommand, Optional bgw As System.ComponentModel.BackgroundWorker = Nothing, Optional ByRef strSQL As String = Nothing) As Boolean
        InsertBulkRecords = False

        If theDataTable Is Nothing Then Return False

        Dim TableName As String = Nothing

        ' Ensure no existing transaction by starting a new transaction
        Using connection As New SqlConnection(cmd.Connection.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction()
                Using bulk As New SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction)
                    If theDataTable.TableName = "t_access_control_log1" Then
                        TableName = "t_access_control_log"
                    Else
                        TableName = theDataTable.TableName
                    End If

                    bulk.DestinationTableName = TableName
                    bulk.BulkCopyTimeout = 5000

                    Try
                        bulk.WriteToServer(theDataTable)
                        transaction.Commit()
                        InsertBulkRecords = True
                    Catch ex As Exception
                        ' Handle exception and rollback transaction if needed
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        End Using

    End Function

#Region "Add Parameter"
    Public Sub AddParameter(ByRef cmd As SqlCommand, ParameterName As String, ParameterValue As String, NullIfNothing As Boolean)
        Dim AddNull As Boolean = False
        If String.IsNullOrEmpty(ParameterValue) Then
            AddNull = True
        Else
            If NullIfNothing Then
                If ParameterValue = Nothing Then
                    AddNull = True
                Else
                    If ParameterValue.Trim.Length = 0 Then
                        AddNull = True
                    End If
                End If
            End If
        End If
        If AddNull Then
            cmd.Parameters.AddWithValue(ParameterName, DBNull.Value)
        Else
            cmd.Parameters.AddWithValue(ParameterName, ParameterValue)
        End If
    End Sub

    Public Sub AddParameter(ByRef cmd As SqlCommand, ParameterName As String, ParameterValue As Date?, InsertNull As Boolean)
        Dim AddNull As Boolean = False
        If InsertNull Then
            AddNull = True
        Else
            If Not ParameterValue.HasValue Then
                If ParameterValue Is Nothing Then AddNull = True
            Else
                AddNull = True
            End If
        End If

        If AddNull Then
            cmd.Parameters.AddWithValue(ParameterName, DBNull.Value)
        Else
            cmd.Parameters.AddWithValue(ParameterName, ParameterValue)
        End If
    End Sub

    Public Sub AddParameter(ByRef cmd As SqlCommand, ParameterName As String, ParameterValue As Decimal?, InsertNull As Boolean)
        Dim AddNull As Boolean = False
        If InsertNull Then
            AddNull = True
        Else
            If Not ParameterValue.HasValue Then
                AddNull = True
            End If
        End If

        If AddNull Then
            cmd.Parameters.AddWithValue(ParameterName, DBNull.Value)
        Else
            cmd.Parameters.AddWithValue(ParameterName, ParameterValue)
        End If
    End Sub
#End Region

End Module
