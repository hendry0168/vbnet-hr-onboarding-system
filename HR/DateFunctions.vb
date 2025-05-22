Public Module DateFunctions
    Public Function ConvertSecondsToReadableTime(Seconds As Int64) As String

        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(Seconds)

        'lblHours.Text = iSpan.Hours.ToString.PadLeft(2, "0"c)
        'lblMinutes.Text = iSpan.Minutes.ToString.PadLeft(2, "0"c)
        'lblSeconds.Text = iSpan.Seconds.ToString.PadLeft(2, "0"c)

        Return iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Seconds.ToString.PadLeft(2, "0"c)
        'Dim Hours, Minutes As Integer
        'Hours = Seconds / 3600
        'Seconds = Seconds Mod 3600
        'Minutes = Seconds / 60
        'Seconds = Seconds Mod 60

        ''lblHours.Text = Hours.ToString.PadLeft(2, "0"c)
        ''lblMinutes.Text = Minutes.ToString.PadLeft(2, "0"c)
        ''lblSeconds.Text = Seconds.ToString.PadLeft(2, "0"c)

        'Return Hours.ToString.PadLeft(2, "0"c) & ":" & Minutes.ToString.PadLeft(2, "0"c) & ":" & Seconds.ToString.PadLeft(2, "0"c)
    End Function

    Public Function ChangeDateFilter(ByVal f As DateFilterMode,
                                 ByRef UseDateToolStripMenuItem As ToolStripMenuItem,
                                 ByRef UseMonthToolStripMenuItem As ToolStripMenuItem,
                                 ByRef UseYearToolStripMenuItem As ToolStripMenuItem,
                                 ByRef dtpDate As DateTimePicker,
                                 Optional ByRef dtpDate2 As DateTimePicker = Nothing,
                                 Optional ByRef chkTo As CheckBox = Nothing)
        ChangeDateFilter = f
        UseDateToolStripMenuItem.Checked = False
        UseMonthToolStripMenuItem.Checked = False
        UseYearToolStripMenuItem.Checked = False
        dtpDate.CustomFormat = GetDateFormat(f)
        Select Case f
            Case DateFilterMode.SAPDate
                UseDateToolStripMenuItem.Checked = True
                If Not chkTo Is Nothing Then chkTo.Visible = True
            Case DateFilterMode.Month
                dtpDate.Value = New Date(dtpDate.Value.Year, dtpDate.Value.Month, 1)
                UseMonthToolStripMenuItem.Checked = True
                If Not chkTo Is Nothing Then
                    chkTo.Checked = False
                    chkTo.Visible = False
                End If
                If Not dtpDate2 Is Nothing Then dtpDate2.Visible = False
            Case DateFilterMode.Year
                dtpDate.Value = New Date(dtpDate.Value.Year, 1, 1)
                UseYearToolStripMenuItem.Checked = True
                If Not chkTo Is Nothing Then
                    chkTo.Visible = False
                    chkTo.Checked = False
                End If
                If Not dtpDate2 Is Nothing Then dtpDate2.Visible = False
            Case Else
                Exit Function
        End Select
    End Function

    Public Enum DateFilterMode As Short
        SAPDate = 0
        Month = 1

        Year = 2

        SAPDateTimeMinute = 3
        SAPDateTimeSecond = 4

        ShortDate = 5

        ShortDateTimeMinute = 6
        ShortDateTimeSecond = 7
    End Enum

    Public Function GetDateFormat(FilterMode As DateFilterMode) As String
        Select Case FilterMode
            Case DateFilterMode.SAPDate
                Return "dd.MM.yyyy"
            Case DateFilterMode.ShortDate
                Return "dd MMM yyyy"
            Case DateFilterMode.Month
                Return "MMMM yyyy"
            Case DateFilterMode.Year
                Return "yyyy"
            Case DateFilterMode.SAPDateTimeMinute
                Return "dd.MM.yyyy HH:mm"
            Case DateFilterMode.SAPDateTimeSecond
                Return "dd.MM.yyyy HH:mm:ss"
            Case DateFilterMode.ShortDateTimeMinute
                Return "dd MMM yyyy HH:mm"
            Case DateFilterMode.ShortDateTimeSecond
                Return "dd MMM yyyy HH:mm:ss"

            Case Else
                Return "dd.MM.yyyy"
        End Select
    End Function

    Private Structure SYSTEMTIME
        Public Year As Short
        Public Month As Short
        Public DayOfWeek As Short
        Public Day As Short
        Public Hour As Short
        Public Minute As Short
        Public Second As Short
        Public Milliseconds As Short
    End Structure

    '<DllImport("coredll.dll")> _
    'Private Function SetSystemTime(ByRef time As SYSTEMTIME) As Boolean
    'End Function

    Private Declare Function SetSystemTime Lib "kernel32" (ByRef lpSystemTime As SYSTEMTIME) As Long

    Public Function SetCurrentComputerTime(ByVal time As DateTime) As Boolean
        Dim s As New SYSTEMTIME
        s.Year = time.Year
        s.Month = time.Month
        s.DayOfWeek = time.DayOfWeek
        s.Day = time.Day
        s.Hour = time.Hour
        s.Minute = time.Minute
        s.Second = time.Second
        s.Milliseconds = time.Millisecond
        If SetSystemTime(s) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function GetFirstDayOfYear(ByVal year As Integer) As Date
        Return New Date(year, 1, 1)
    End Function

    Public Function GetLastDayOfYear(ByVal year As Integer) As Date
        Return New Date(year, 12, 31)
    End Function

#Region "Monthly Dates"
    ''' <summary>
    ''' Get the first day of the month for
    ''' any full date submitted
    ''' </summary>
    ''' <param name="dtDate"></param>
    ''' <returns></returns>
    Public Function GetFirstDayOfMonth(ByVal dtDate As DateTime) As DateTime
        ' set return value to the first day of the month
        ' for any date passed in to the method
        ' create a datetime variable set to the passed in date
        Dim dtFrom As DateTime = dtDate
        ' remove all of the days in the month
        ' except the first day and set the
        ' variable to hold that date
        dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1))
        ' return the first day of the month
        Return dtFrom.Date
    End Function

    ''' <summary>
    ''' Get the first day of the month for a
    ''' month passed by it's integer value
    ''' </summary>
    ''' <param name="iMonth"></param>
    ''' <returns></returns>
    Public Function GetFirstDayOfMonth(ByVal iMonth As Integer) As DateTime
        ' set return value to the last day of the month
        ' for any date passed in to the method
        ' create a datetime variable set to the passed in date
        Dim dtFrom As New DateTime(DateTime.Now.Year, iMonth, 1)
        ' remove all of the days in the month
        ' except the first day and set the
        ' variable to hold that date
        dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1))
        ' return the first day of the month
        Return dtFrom.Date
    End Function

    ''' <summary>
    ''' Get the last day of the month for any
    ''' full date
    ''' </summary>
    ''' <param name="dtDate"></param>
    ''' <returns></returns>
    Public Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        ' set return value to the last day of the month
        ' for any date passed in to the method
        ' create a datetime variable set to the passed in date
        Dim dtTo As DateTime = dtDate
        ' overshoot the date by a month
        dtTo = dtTo.AddMonths(1)
        ' remove all of the days in the next month
        ' to get bumped down to the last day of the
        ' previous month
        dtTo = dtTo.AddDays(-(dtTo.Day))
        ' return the last day of the month
        Return dtTo.Date
    End Function

    ''' <summary>
    ''' Get the last day of a month expressed by it's
    ''' integer value
    ''' </summary>
    ''' <param name="iMonth"></param>
    ''' <returns></returns>
    Public Function GetLastDayOfMonth(ByVal iMonth As Integer) As DateTime
        ' set return value to the last day of the month
        ' for any date passed in to the method
        ' create a datetime variable set to the passed in date
        Dim dtTo As New DateTime(DateTime.Now.Year, iMonth, 1)
        ' overshoot the date by a month
        dtTo = dtTo.AddMonths(1)
        ' remove all of the days in the next month
        ' to get bumped down to the last day of the
        ' previous month
        dtTo = dtTo.AddDays(-(dtTo.Day))
        ' return the last day of the month
        Return dtTo.Date
    End Function
#End Region

    Public Enum DateFormat As Short
        Original_Date = 0
        PHG_ShortDate = 1
        SAP_Date = 2
        SQL = 3
    End Enum

    Public Function FormatDate(ByVal dt As Date, ByVal dtFormat As DateFormat, Optional ByVal WithTime As Boolean = False) As String
        Dim strFormat As String
        Select Case dtFormat
            Case DateFormat.PHG_ShortDate
                strFormat = "dd MMM yyyy"
            Case DateFormat.SAP_Date
                strFormat = "dd.MM.yyyy"
            Case DateFormat.SQL
                strFormat = "yyyy-MM-dd"
            Case Else
                Return dt.ToString
        End Select
        If WithTime Then
            strFormat &= " HH:mm:ss"
        End If
        Return Format(dt, strFormat)
    End Function

#Region "DateTimeSpan"
    'https://stackoverflow.com/questions/27902973/get-years-months-days-for-an-elapsed-span-of-time-datetime
    Public Structure DateTimeSpan

        Private _Years As Integer
        Public ReadOnly Property Years As Integer
            Get
                Return _Years
            End Get
        End Property

        Private _Months As Integer
        Public ReadOnly Property Months As Integer
            Get
                Return _Months
            End Get
        End Property

        Private _Days As Integer
        Public ReadOnly Property Days As Integer
            Get
                Return _Days
            End Get
        End Property

        Private _Hours As Integer
        Public ReadOnly Property Hours As Integer
            Get
                Return _Hours
            End Get
        End Property

        Private _Minutes As Integer
        Public ReadOnly Property Minutes As Integer
            Get
                Return _Minutes
            End Get
        End Property

        Private _Seconds As Integer
        Public ReadOnly Property Seconds As Integer
            Get
                Return _Seconds
            End Get
        End Property

        Private _MilliSeconds As Integer
        Public ReadOnly Property MilliSeconds As Integer
            Get
                Return _MilliSeconds
            End Get
        End Property

        ' the ctor for the result
        Private Sub New(y As Integer, mm As Integer, d As Integer,
                    h As Integer, m As Integer, s As Integer,
                    ms As Integer)
            _Years = y
            _Months = mm
            _Days = d
            _Hours = h
            _Minutes = m
            _Seconds = s
            _MilliSeconds = ms
        End Sub

        ' private time unit tracker when counting
        Private Enum Unit
            Year
            Month
            Day
            Complete
        End Enum

        Public Shared Function DateSpan(dt1 As DateTime,
                                    dt2 As DateTime) As DateTimeSpan
            ' we dont do negatives
            If dt2 < dt1 Then
                Dim tmp = dt1
                dt1 = dt2
                dt2 = tmp
            End If

            Dim thisDT As DateTime = dt1
            Dim years As Integer = 0
            Dim months As Integer = 0
            Dim days As Integer = 0

            Dim level As Unit = Unit.Year
            Dim span As New DateTimeSpan()

            While level <> Unit.Complete
                Select Case level
                ' add a year until it is larger;
                ' then change the "level" to month
                    Case Unit.Year
                        If thisDT.AddYears(years + 1) > dt2 Then
                            level = Unit.Month
                            thisDT = thisDT.AddYears(years)
                        Else
                            years += 1
                        End If

                    Case Unit.Month
                        If thisDT.AddMonths(months + 1) > dt2 Then
                            level = Unit.Day
                            thisDT = thisDT.AddMonths(months)
                        Else
                            months += 1
                        End If

                    Case Unit.Day
                        If thisDT.AddDays(days + 1) > dt2 Then
                            thisDT = thisDT.AddDays(days)
                            Dim thisTS = dt2 - thisDT
                            ' create a new DTS from the values caluclated
                            span = New DateTimeSpan(years, months, days, thisTS.Hours,
                                                thisTS.Minutes, thisTS.Seconds,
                                    thisTS.Milliseconds)
                            level = Unit.Complete
                        Else
                            days += 1
                        End If
                End Select
            End While

            Return span

        End Function

    End Structure

    Public Function SpellTimeSpanToWords(ByVal l As MoneyLanguage, FromDate As Date, ToDate As Date, IncludeTime As Boolean, Optional TrimZeroes As Boolean = False, Optional PrefixText As String = "", Optional PostfixText As String = "") As String
        If FromDate = Nothing Or ToDate = Nothing Then Return ""
        Dim dts As DateTimeSpan = DateTimeSpan.DateSpan(FromDate, ToDate)
        Return SpellTimeSpanToWords(l, dts, IncludeTime, TrimZeroes, PrefixText, PostfixText)
    End Function

    ''' <summary>
    ''' Spells the money to words.
    ''' </summary>
    ''' <param name="l">Language of the returned string.</param>
    ''' <param name="money">Money value.</param>
    ''' <param name="currency">The currency.</param>
    ''' <returns></returns>
    Public Function SpellTimeSpanToWords(ByVal l As MoneyLanguage, ByVal dts As DateTimeSpan, IncludeTime As Boolean, Optional TrimZeroes As Boolean = False, Optional PrefixText As String = "", Optional PostfixText As String = "") As String
        Select Case l
            Case MoneyLanguage.English

            Case MoneyLanguage.Indonesian

            Case Else
                Return "<Invalid language selection>"
        End Select

        Dim strYear As String = ""
        Dim strMonth As String = ""
        Dim strDay As String = ""
        Dim strHour As String = ""
        Dim strMinute As String = ""
        Dim strSecond As String = ""

        Dim strDatePeriod As String = ""

        Select Case dts.Years
            Case 0
                If TrimZeroes Then strYear = ""
            Case 1
                strYear = dts.Years.ToString & " year"
            Case > 1
                strYear = dts.Years.ToString & " years"
        End Select
        If strYear.Length > 0 Then
            If strDatePeriod.Length > 0 Then
                strDatePeriod &= ", " & strYear
            Else
                strDatePeriod &= strYear
            End If
        End If

        Select Case dts.Months
            Case 0
                If TrimZeroes Then strMonth = ""
            Case 1
                strMonth = dts.Months.ToString & " month"
            Case > 1
                strMonth = dts.Months.ToString & " months"
        End Select
        If strMonth.Length > 0 Then
            If strDatePeriod.Length > 0 Then
                strDatePeriod &= ", " & strMonth
            Else
                strDatePeriod &= strMonth
            End If
        End If

        Select Case dts.Days
            Case 0
                If TrimZeroes Then strDay = ""
            Case 1
                strDay = dts.Days.ToString & " day"
            Case > 1
                strDay = dts.Days.ToString & " days"
        End Select
        If strDay.Length > 0 Then
            If strDatePeriod.Length > 0 Then
                strDatePeriod &= ", " & strDay
            Else
                strDatePeriod &= strDay
            End If
        End If

        If IncludeTime Then
            Select Case dts.Hours
                Case 0
                    If TrimZeroes Then strHour = ""
                Case 1
                    strHour = dts.Hours.ToString & " hour"
                Case > 1
                    strHour = dts.Hours.ToString & " hours"
            End Select
            If strHour.Length > 0 Then
                If strDatePeriod.Length > 0 Then
                    strDatePeriod &= ", " & strHour
                Else
                    strDatePeriod &= strHour
                End If
            End If

            Select Case dts.Minutes
                Case 0
                    If TrimZeroes Then strMinute = ""
                Case 1
                    strMinute = dts.Minutes.ToString & " minute"
                Case > 1
                    strMinute = dts.Minutes.ToString & " minutes"
            End Select
            If strMinute.Length > 0 Then
                If strDatePeriod.Length > 0 Then
                    strDatePeriod &= ", " & strMinute
                Else
                    strDatePeriod &= strMinute
                End If
            End If

            Select Case dts.Seconds
                Case 0
                    If TrimZeroes Then strSecond = ""
                Case 1
                    strSecond = dts.Seconds.ToString & " second"
                Case > 1
                    strSecond = dts.Seconds.ToString & " seconds"
            End Select
            If strSecond.Length > 0 Then
                If strDatePeriod.Length > 0 Then
                    strDatePeriod &= ", " & strSecond
                Else
                    strDatePeriod &= strSecond
                End If
            End If
        End If

        If l = MoneyLanguage.Indonesian Then
            strDatePeriod.Replace("year", "tahun")
            strDatePeriod.Replace("years", "tahun")
            strDatePeriod.Replace("month", "bulan")
            strDatePeriod.Replace("months", "bulan")
            strDatePeriod.Replace("day", "hari")
            strDatePeriod.Replace("days", "hari")

            strDatePeriod.Replace("hour", "jam")
            strDatePeriod.Replace("hours", "jam")
            strDatePeriod.Replace("minute", "menit")
            strDatePeriod.Replace("minutes", "menit")
            strDatePeriod.Replace("second", "detik")
            strDatePeriod.Replace("seconds", "detik")
        End If

        If Not Right(PrefixText, 1) = " " Then PrefixText = PrefixText & " "
        If Not Left(PostfixText, 1) = " " Then PostfixText = " " & PostfixText
        Return PrefixText & strDatePeriod & PostfixText
    End Function
#End Region
End Module
