Imports System.Data.SqlClient

Public Module CustomFunctions

    Public Function RoundNumber(v As Decimal, DecimalPoint As Short, Optional RoundingType As MidpointRounding = MidpointRounding.AwayFromZero) As Decimal
        Return Math.Round(v, DecimalPoint, RoundingType)
    End Function

    Public Function TruncateNumber(v As Decimal, DecimalPoint As Short) As Decimal
        'v = 1.12345678
        v = v * Math.Pow(10, DecimalPoint)
        'v = 1123.45678
        v = Math.Floor(v)
        v = v / Math.Pow(10, DecimalPoint)
        Return v
    End Function

    Public Sub SetTabPagesRowCount(ByRef tbp As TabPage, RowCount As Integer, Title As String)
        If tbp Is Nothing Then Exit Sub
        tbp.Text = Title & " (" & RowCount & ")"
    End Sub

    Public Sub SetTabPagesRowCount(ByRef tbp As TabPage, dgv As DataGridView, Title As String)
        If tbp Is Nothing Or dgv Is Nothing Then Exit Sub
        tbp.Text = Title & " (" & dgv.Rows.Count & ")"
    End Sub

    Public Sub SetTabPagesRowCount(ByRef tbp As TabPage, dt As DataTable, Title As String)
        If tbp Is Nothing Or dt Is Nothing Then Exit Sub
        Dim RowCount As Integer = 0
        If Not dt Is Nothing Then RowCount = dt.Rows.Count
        tbp.Text = Title & " (" & RowCount & ")"
    End Sub
    Public Sub RemoveSelectedRows(ByRef dgv As DataGridView)
        Try
            Select Case dgv.SelectionMode
                Case DataGridViewSelectionMode.FullRowSelect
                    For Each row As DataGridViewRow In dgv.SelectedRows
                        dgv.Rows.Remove(row)
                    Next
                Case Else
                    Dim ListOfRows As New List(Of DataGridViewRow)
                    For Each cell As DataGridViewCell In dgv.SelectedCells
                        Dim FoundInList As Boolean = False
                        For Each row As DataGridViewRow In ListOfRows
                            If cell.OwningRow Is row Then FoundInList = True
                        Next
                        If Not FoundInList Then ListOfRows.Add(cell.OwningRow)
                    Next
                    For Each row As DataGridViewRow In ListOfRows
                        dgv.Rows.Remove(row)
                    Next
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RemoveSelectedRows(ByRef dgv As DataGridView, ByRef clmCanEdit As Object)
        Try

            Select Case dgv.SelectionMode
                Case DataGridViewSelectionMode.FullRowSelect
                    For Each row As DataGridViewRow In dgv.SelectedRows
                        If row.Cells(clmCanEdit.Index).Value Then
                            dgv.Rows.Remove(row)
                        End If
                    Next
                Case Else
                    Dim ListOfRows As New List(Of DataGridViewRow)
                    For Each cell As DataGridViewCell In dgv.SelectedCells
                        Dim FoundInList As Boolean = False
                        For Each row As DataGridViewRow In ListOfRows
                            If cell.OwningRow Is row Then FoundInList = True
                        Next
                        If Not FoundInList Then ListOfRows.Add(cell.OwningRow)
                    Next
                    For Each row As DataGridViewRow In ListOfRows
                        dgv.Rows.Remove(row)
                    Next
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Function getMD5Hash(ByVal strToHash As String, Optional ByVal additional_keys As String = "") As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash & additional_keys)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult.ToUpper
    End Function
    '''' <summary>
    '''' Positions the form.
    '''' </summary>
    '''' <param name="theForm">The form.</param>
    '''' <param name="mdiMain">The MDI main.</param>
    '''' <param name="leftOffset">The left offset.</param>
    '''' <param name="MaximiseForm">if set to <c>true</c> [maximise form].</param>
    '''' <param name="ShowAsDialog">if set to <c>true</c> [show as dialog].</param>
    'Public Sub PositionForm(ByVal theForm As Form, ByVal mdiMain As Form, ByVal leftOffset As Integer, Optional ByVal MaximiseForm As Boolean = False, Optional ByVal ShowAsDialog As Boolean = False)
    '    If MaximiseForm Then
    '        theForm.WindowState = FormWindowState.Maximized
    '        theForm.StartPosition = FormStartPosition.CenterScreen
    '    Else
    '        theForm.WindowState = FormWindowState.Normal
    '        theForm.StartPosition = FormStartPosition.Manual
    '        'theForm.MaximizeBox = False
    '        theForm.MinimizeBox = False

    '        theForm.Left = mdiMain.Left + leftOffset + 10
    '        theForm.Width = mdiMain.Width - leftOffset - 20
    '        theForm.Top = mdiMain.Top + 60
    '        theForm.Height = mdiMain.Height - 95
    '    End If
    '    If ShowAsDialog Then
    '        theForm.ShowDialog(mdiMain)
    '    Else
    '        theForm.Show(mdiMain)
    '    End If
    'End Sub

    ''' <summary>
    ''' this function checks if the value is null and pass the string "" if it is
    ''' it simply makes the code much readable by calling txt.Text = getStringReader(reader("field"))
    ''' </summary>
    ''' <param name="fromReader">SqlDataReader("fields")</param>
    ''' <returns></returns>
    Public Function getStringReader(ByVal fromReader As Object) As String
        If IsDBNull(fromReader) Then
            Return ""
        Else
            Return fromReader
        End If
    End Function

    Public Function getReaderValue(ByVal fromReader As Object) As Object
        If IsDBNull(fromReader) Then
            Return Nothing
        Else
            Return fromReader
        End If
    End Function

    ''' <summary>
    ''' this function generates hash values from passed arguments and returns it
    ''' usually used for password encryption
    ''' password cannot be retrieved, resetting new password is the workaround (more security)
    ''' </summary>
    ''' <param name="value">String to be converted to hash.</param>
    ''' <param name="additional_keys">The additional_keys.</param>
    ''' <returns></returns>
    Public Function getHash(ByVal value As String, Optional ByVal additional_keys As String = "") As String
        Dim HashValue As Byte()
        Dim encPassw As String = ""
        Dim UE As New System.Text.UnicodeEncoding()
        Dim MessageBytes As Byte() = UE.GetBytes(value & additional_keys.ToString)
        Dim SHhash As New System.Security.Cryptography.SHA1Managed()

        HashValue = SHhash.ComputeHash(MessageBytes)
        Dim hashVal As Byte
        For Each hashVal In HashValue
            encPassw &= hashVal
        Next hashVal
        Return encPassw
    End Function

    ''' <summary>
    ''' Loads the printer list.
    ''' </summary>
    ''' <param name="cbo">The ComboBox where the list of printer will be loaded into</param>
    Public Sub LoadPrinterList(ByVal cbo As ComboBox)
        Dim prtDoc As New Printing.PrintDocument
        Dim strDefaultPrinter As String = prtDoc.PrinterSettings.PrinterName
        Dim strPrinter As String
        cbo.Items.Clear()
        For Each strPrinter In Printing.PrinterSettings.InstalledPrinters
            cbo.Items.Add(strPrinter)
            If strPrinter = strDefaultPrinter Then
                cbo.SelectedIndex = cbo.Items.IndexOf(strPrinter)
            End If
        Next
    End Sub

End Module
