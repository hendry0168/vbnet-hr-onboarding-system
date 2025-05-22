Public Class ucDateRange
    Private _CurrentDateFilterMode As DateFilterMode = DateFilterMode.SAPDate
    'Private _StartDate, _FinishDate As Date
    Private _RangeEnabled As Boolean = False
    Private _IsLocked As Boolean = False
    Private _EnableDateFormatChange As Boolean = False

    Public Event ToDateCheckedChanged(ToDateChecked As Boolean)

    'Public Event MandatoryFinishDateChanged(MandatoryFinishDate As Boolean)

    Public Sub InitializeDate(theDate As Date, theDateFilterMode As DateFilterMode)
        DateStart = theDate
        DateFinish = theDate
        CurrentDateFilterMode = theDateFilterMode
    End Sub

    Public Property EnableYear() As Boolean
        Get
            Return UseYearToolStripMenuItem.Visible
        End Get
        Set(ByVal value As Boolean)
            UseYearToolStripMenuItem.Visible = value
        End Set
    End Property

    'Public Sub New()

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    'InitializeDate(Now)
    'End Sub

    Private _MandatoryFinishDate As Boolean
    Public Property MandatoryFinishDate() As Boolean
        Get
            Return _MandatoryFinishDate
        End Get
        Set(ByVal value As Boolean)
            _MandatoryFinishDate = value
            If value Then
                chkTo.Checked = True
                chkTo.Enabled = False
            Else
                chkTo.Enabled = Not IsLocked
            End If
        End Set
    End Property

    Public Property IsLocked As Boolean
        Get
            Return _IsLocked
        End Get
        Set(value As Boolean)
            _IsLocked = value
            dtpStart.ReadOnly = value
            If MandatoryFinishDate Then
                chkTo.Checked = True
                chkTo.Enabled = False
            Else
                chkTo.Enabled = Not value
            End If
            dtpFinish.ReadOnly = value
        End Set
    End Property

    Public Property EnableDateFormatChange As Boolean
        Get
            Return _EnableDateFormatChange
        End Get
        Set(value As Boolean)
            _EnableDateFormatChange = value
            If value Then
                dtpStart.Properties.ContextMenuStrip = cmsDateFilter
                dtpFinish.Properties.ContextMenuStrip = cmsDateFilter
            Else
                dtpStart.Properties.ContextMenuStrip = Nothing
                dtpFinish.Properties.ContextMenuStrip = Nothing
            End If
        End Set
    End Property

    Public Property RangeEnabled As Boolean
        Get
            Return _RangeEnabled
        End Get
        Set(value As Boolean)
            _RangeEnabled = value
            If value Then
                chkTo.Visible = True
                '_FinishDate = dtpFinish.DateTime
            Else
                chkTo.Checked = False
                chkTo.Visible = False
                dtpFinish.Visible = False
                '_FinishDate = dtpStart.DateTime
            End If
        End Set
    End Property

    Public Property CurrentDateFilterMode As DateFilterMode
        Get
            Return _CurrentDateFilterMode
        End Get
        Set(value As DateFilterMode)
            _CurrentDateFilterMode = value
            Dim strDateFormat As String = GetDateFormat(value)
            dtpStart.Properties.DisplayFormat.FormatString = strDateFormat
            dtpStart.Properties.Mask.EditMask = strDateFormat
            dtpFinish.Properties.DisplayFormat.FormatString = strDateFormat
            dtpFinish.Properties.Mask.EditMask = strDateFormat
        End Set
    End Property

    Private Sub chkTo_CheckedChanged(sender As Object, e As EventArgs) Handles chkTo.CheckedChanged
        dtpFinish.Visible = chkTo.Checked
        'If chkTo.Checked Then
        '    _FinishDate = dtpFinish.DateTime
        'Else
        '    _FinishDate = dtpStart.DateTime
        'End If
        RaiseEvent ToDateCheckedChanged(chkTo.Checked)
        RaiseEvent DateChanged(DateStart, DateFinish)
    End Sub

    Public Property DateStart As Date
        Get
            Select Case _CurrentDateFilterMode
                Case DateFilterMode.SAPDateTimeMinute, DateFilterMode.SAPDateTimeSecond, DateFilterMode.ShortDateTimeMinute, DateFilterMode.ShortDateTimeSecond
                    Return dtpStart.DateTime
                Case DateFilterMode.Month
                    Return GetFirstDayOfMonth(dtpStart.DateTime)
                Case DateFilterMode.Year
                    Return New Date(dtpStart.DateTime.Year, 1, 1)
                Case Else
                    Return dtpStart.DateTime.Date
            End Select
        End Get
        Set(value As Date)
            '_StartDate = value
            dtpStart.DateTime = value
            RaiseEvent DateChanged(DateStart, DateFinish)
        End Set
    End Property
    Public Property DateFinish As Date
        Get
            Select Case _CurrentDateFilterMode
                Case DateFilterMode.SAPDateTimeMinute, DateFilterMode.SAPDateTimeSecond, DateFilterMode.ShortDateTimeMinute, DateFilterMode.ShortDateTimeSecond
                    If chkTo.Checked Then
                        Return dtpFinish.DateTime
                    Else
                        Return dtpStart.DateTime
                    End If
                Case DateFilterMode.Month
                    If chkTo.Checked Then
                        Return GetLastDayOfMonth(dtpFinish.DateTime)
                    Else
                        Return GetLastDayOfMonth(dtpStart.DateTime)
                    End If
                Case DateFilterMode.Year
                    If chkTo.Checked Then
                        Return New Date(dtpFinish.DateTime.Year, 12, 31)
                    Else
                        Return New Date(dtpStart.DateTime.Year, 12, 31)
                    End If
                Case Else
                    If chkTo.Checked Then
                        Return dtpFinish.DateTime.Date
                    Else
                        Return dtpStart.DateTime.Date
                    End If
            End Select
        End Get
        Set(value As Date)
            '_FinishDate = value
            If value = Nothing Then
                chkTo.Checked = False
            Else
                dtpFinish.DateTime = value
                If dtpStart.DateTime <> dtpFinish.DateTime Then chkTo.Checked = True
            End If
            RaiseEvent DateChanged(DateStart, DateFinish)
        End Set
    End Property

    Private Sub dtpStart_EditValueChanged(sender As Object, e As EventArgs) Handles dtpStart.EditValueChanged
        DateStart = dtpStart.DateTime
    End Sub

    Private Sub dtpFinish_EditValueChanged(sender As Object, e As EventArgs) Handles dtpFinish.EditValueChanged
        If chkTo.Checked Then
            DateFinish = dtpFinish.DateTime
        Else
            DateFinish = dtpStart.DateTime
        End If
    End Sub

    Public Event DateChanged(StartDate As Date, FinishDate As Date)

    Private Sub UseDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseDateToolStripMenuItem.Click
        CurrentDateFilterMode = DateFilterMode.ShortDate
        RaiseEvent DateChanged(DateStart, DateFinish)
    End Sub

    Private Sub UseMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseMonthToolStripMenuItem.Click
        CurrentDateFilterMode = DateFilterMode.Month
        RaiseEvent DateChanged(DateStart, DateFinish)
    End Sub

    Private Sub UseYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseYearToolStripMenuItem.Click
        CurrentDateFilterMode = DateFilterMode.Year
        RaiseEvent DateChanged(DateStart, DateFinish)
    End Sub

End Class
