Public Class SysBooleanIndicator
    'Public Sub Initialize(Optional theYesText As String = "&Yes", Optional theNoText As String = "&No", Optional InitialValue As Boolean = False)
    '    YesText = theYesText
    '    NoText = theNoText
    '    IndicatorValue = InitialValue
    'End Sub

    Public Property YesText As String
        Get
            Return _YesText
        End Get
        Set(value As String)
            _YesText = value
            rdoYes.Text = value
        End Set
    End Property

    Public Property NoText As String
        Get
            Return _NoText
        End Get
        Set(value As String)
            _NoText = value
            rdoNo.Text = value
        End Set
    End Property

    Private _YesText, _NoText As String
    Private _IsChecked As Boolean = False
    Private _IsLocked As Boolean = False

    Public Property IsLocked As Boolean
        Get
            Return _IsLocked
        End Get
        Set(value As Boolean)
            _IsLocked = value
            rdoYes.Enabled = Not value
            rdoNo.Enabled = Not value
        End Set
    End Property

    Public Property IndicatorValue As Boolean
        Get
            Return _IsChecked
        End Get
        Set(value As Boolean)
            _IsChecked = value
            If value Then
                rdoNo.Checked = False
                rdoYes.Checked = True
            Else
                rdoYes.Checked = False
                rdoNo.Checked = True
            End If
        End Set
    End Property
End Class
