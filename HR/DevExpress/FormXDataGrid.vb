Imports System.Data.SqlClient

Public Class FormXDataGrid
    'Private theParentForm As Form
    'Public Sub New(Optional ParentForm As Form = Nothing)

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    theParentForm = ParentForm
    'End Sub
    Public AllowNoSelection As Boolean = False
    Public AllowDoubleClick As Boolean = True

    Public Sub ShowRemark(strRemark As String)
        lblRemark.Text = strRemark
        lblRemark.Visible = True
    End Sub

    Public Sub HideRemark()
        lblRemark.Text = ""
        lblRemark.Visible = False
    End Sub

    Public Sub DisplayReport(ByVal dt As DataTable, Optional ByVal Title As String = "View Report")
        Me.Text = Title
        btnOK.Visible = False
        btnCancel.Visible = False
        btnClose.Visible = True
        XDataGrid.ReloadGrid(dt)
    End Sub

    Public Sub SelectFromData(ByVal dt As DataTable, ByVal Title As String)
        Me.Text = Title
        btnOK.Visible = True
        btnCancel.Visible = True
        btnClose.Visible = False
        XDataGrid.ReloadGrid(dt)
    End Sub

    Public Sub HideCancelAndOKButtonForDashboard(visible As Boolean)
        btnCancel.Visible = Not visible
        btnOK.Visible = Not visible
    End Sub

    Public Result_Click As Boolean
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click, btnCancel.Click
        Result_Click = False
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Result_Click = True
        If AllowNoSelection Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If XDataGrid.GetSelectedRows.Count >= 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub XDataGrid_DoubleClicked() Handles XDataGrid.DoubleClicked
        Result_Click = True
        If Not AllowDoubleClick Then Exit Sub
        If XDataGrid.GetSelectedRows.Count >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class