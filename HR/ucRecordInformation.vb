
Imports System.Data.SqlClient
Public Class ucRecordInformation
    Public DTCreate, DTUpdate As Date
    Private CanViewUser As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ShowNoRecordInfo = True
    End Sub

    Public Property ShowNoRecordInfo() As Boolean
        Get
            Return pnlNoRecord.Visible
        End Get
        Set(ByVal value As Boolean)
            If value Then
                DTCreate = Nothing
                DTUpdate = Nothing
                txtIDCreate.Clear()
                txtDTCreate.Clear()
                txtIDUpdate.Clear()
                txtDTUpdate.Clear()
            End If
            pnlNoRecord.Visible = value
            'Me.Visible = Not value
        End Set
    End Property

    Public Sub LoadRecordInformation(idcreate As String, dtcreate As Date, Optional idupdate As String = Nothing, Optional dtupdate As Date? = Nothing)
        ShowNoRecordInfo = False
        txtIDCreate.Text = idcreate
        If dtcreate = Nothing Then
            Me.DTCreate = Nothing
            txtDTCreate.Clear()
        Else
            Me.DTCreate = dtcreate
            txtDTCreate.Text = FormatDate(dtcreate, DateFunctions.DateFormat.SAP_Date, True)
        End If

        If Not idupdate = Nothing Then
            txtIDUpdate.Text = idupdate
        End If
        If Not dtupdate = Nothing Then
            Me.DTUpdate = dtupdate
            txtDTUpdate.Text = FormatDate(dtupdate, DateFunctions.DateFormat.SAP_Date, True)
        End If
    End Sub

    Public Sub LoadRecordInformation(reader As SqlDataReader)
        ShowNoRecordInfo = False
        txtIDCreate.Text = getStringReader(reader("idcreate"))
        If IsDBNull(reader("dtcreate")) Then
            DTCreate = Nothing
            txtDTCreate.Clear()
        Else
            DTCreate = reader("dtcreate")
            txtDTCreate.Text = FormatDate(DTCreate, DateFunctions.DateFormat.SAP_Date, True)
        End If

        If Not IsDBNull(reader("idupdate")) Then
            txtIDUpdate.Text = reader("idupdate")
        End If
        If Not IsDBNull(reader("dtupdate")) Then
            DTUpdate = reader("dtupdate")
            txtDTUpdate.Text = FormatDate(DTUpdate, DateFunctions.DateFormat.SAP_Date, True)
        End If
    End Sub

    Public Sub LoadRecordInformation(reader As DataRow)
        ShowNoRecordInfo = False
        txtIDCreate.Text = getStringReader(reader("idcreate"))
        If IsDBNull(reader("dtcreate")) Then
            DTCreate = Nothing
            txtDTCreate.Clear()
        Else
            DTCreate = reader("dtcreate")
            txtDTCreate.Text = FormatDate(DTCreate, DateFunctions.DateFormat.SAP_Date, True)
        End If

        If Not IsDBNull(reader("idupdate")) Then
            txtIDUpdate.Text = reader("idupdate")
        End If
        If Not IsDBNull(reader("dtupdate")) Then
            DTUpdate = reader("dtupdate")
            txtDTUpdate.Text = FormatDate(DTUpdate, DateFunctions.DateFormat.SAP_Date, True)
        End If
    End Sub

    Private Sub txtIDCreate_DoubleClick(sender As Object, e As EventArgs) Handles txtIDCreate.DoubleClick
        ViewUser(txtIDCreate.Text)
    End Sub

    Private Sub txtIDUpdate_DoubleClick(sender As Object, e As EventArgs) Handles txtIDUpdate.DoubleClick
        ViewUser(txtIDUpdate.Text)
    End Sub

    Private Sub ViewUser(UserID As String)

    End Sub
End Class
