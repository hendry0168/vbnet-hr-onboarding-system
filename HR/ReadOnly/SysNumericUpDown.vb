'http://www.codeproject.com/useritems/Fixed_NumericUpDown.asp?df=100&forumid=357070&exp=0&select=1761507


''' <summary>
''' Numeric Up Down control with read only property
''' </summary>
Public Class SysNumericUpDown
    Inherits NumericUpDown

    'Private AutoRoundValue As Boolean = True
    Public SelectValueOnFocus As Boolean = True

    'Private CurrentDecimalLength As Integer = 0
    'Private DefaultDecimalLength As Integer = 0
    'Private EnforceDecimalLength As Boolean = False
    'Private InitDecimalLength As Boolean = False

    'Public Overloads Property DecimalPlaces As Integer
    '    Get
    '        Return CurrentDecimalLength
    '    End Get
    '    Set(value As Integer)
    '        CurrentDecimalLength = value
    '        MyBase.DecimalPlaces = value
    '        If Not InitDecimalLength Then
    '            DefaultDecimalLength = value
    '            InitDecimalLength = True
    '        End If
    '    End Set
    'End Property

    Public Sub New()

        MyBase.TextAlign = HorizontalAlignment.Right
        MyBase.ThousandsSeparator = True
    End Sub

    Public Overloads Overrides Sub DownButton()
        If [ReadOnly] Then
            Return
        End If
        MyBase.DownButton()
    End Sub

    Public Overloads Overrides Sub UpButton()
        If [ReadOnly] Then
            Return
        End If
        MyBase.UpButton()
    End Sub

    ' ReadOnly property
    ''' <summary>
    ''' Gets or sets a value indicating whether the text can be changed by the use of the up or down buttons only.
    ''' </summary>
    ''' <value></value>
    ''' <returns>true if the text can be changed by the use of the up or down buttons only; otherwise, false. The default value is false.
    ''' </returns>
    Public Overloads Property [ReadOnly]() As Boolean
        Get
            Return MyBase.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            If MyBase.ReadOnly <> value Then
                MyBase.ReadOnly = value
                MyBase.Controls(0).Enabled = Not value
            End If
        End Set
    End Property

    Public Enum DecimalTreatmentMode As Short
        Rounding = 1
        Truncate = 2
    End Enum

    Private CurrentDecimalTreatement As DecimalTreatmentMode = DecimalTreatmentMode.Truncate

    ' ReadOnly property
    ''' <summary>
    ''' Gets or sets a value indicating whether the value will be rounded when the value is changed.
    ''' </summary>
    ''' <value></value>
    ''' <returns>true if the value is to be rounded; otherwise, false. The default value is true.
    ''' </returns>
    Public Overloads Property DecimalTreatment() As DecimalTreatmentMode
        Get
            Return Me.CurrentDecimalTreatement
        End Get
        Set(ByVal value As DecimalTreatmentMode)
            Me.CurrentDecimalTreatement = value
        End Set
    End Property

    Private Sub SysNumericUpDown_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus, Me.Click
        If SelectValueOnFocus Then Me.Select(0, Me.Text.Length)
    End Sub

    Private Sub SysNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Me.ValueChanged
        Select Case CurrentDecimalTreatement
            Case DecimalTreatmentMode.Rounding
                Me.Value = RoundNumber(Me.Value, Me.DecimalPlaces)
            Case DecimalTreatmentMode.Truncate
                Me.Value = TruncateNumber(Me.Value, Me.DecimalPlaces)
            Case Else

        End Select
    End Sub

    'Private Sub RoundNumber(ByRef nud As NumericUpDown, DecimalPoint As Short, Optional RoundingType As MidpointRounding = MidpointRounding.AwayFromZero)
    '    nud.Value = RoundNumber(nud.Value, DecimalPoint, RoundingType)
    'End Sub


End Class