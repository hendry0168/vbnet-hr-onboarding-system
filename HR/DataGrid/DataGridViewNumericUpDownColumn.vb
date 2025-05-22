Public Class DataGridViewNumericUpDownColumn_0DecimalPlaces
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewNumericUpDownCell_0DecimalPlaces())
        MyBase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MyBase.DefaultCellStyle.Format = "N0"
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_0DecimalPlaces)) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_4DecimalPlaces)) Then
                Throw New InvalidCastException("Must be a DataGridViewNumericUpDownCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class DataGridViewNumericUpDownColumn_2DecimalPlaces
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewNumericUpDownCell_2DecimalPlaces())
        MyBase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MyBase.DefaultCellStyle.Format = "N2"
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_2DecimalPlaces)) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_4DecimalPlaces)) Then
                Throw New InvalidCastException("Must be a DataGridViewNumericUpDownCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class DataGridViewNumericUpDownColumn_4DecimalPlaces
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewNumericUpDownCell_4DecimalPlaces())
        MyBase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MyBase.DefaultCellStyle.Format = "N4"
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_4DecimalPlaces)) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_4DecimalPlaces)) Then
                Throw New InvalidCastException("Must be a DataGridViewNumericUpDownCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class DataGridViewNumericUpDownCell_10DecimalPlaces
    Inherits DataGridViewTextBoxCell
    Public DecimalPlaces As Short = 10

    Public Sub New()
        Me.Style.Format = "N" & DecimalPlaces
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim ctl As DataGridViewNumericUpDownEditingControl = CType(DataGridView.EditingControl, DataGridViewNumericUpDownEditingControl)
        ctl.DecimalPlaces = DecimalPlaces
        ctl.Minimum = Decimal.MinValue
        ctl.Maximum = Decimal.MaxValue
        Dim v As Decimal = 0
        If IsDBNull(Me.Value) Then
            ctl.Value = 0
        Else
            If Decimal.TryParse(Me.Value, v) Then
                ctl.Value = v
            End If
        End If
        ctl.Select(0, Integer.MaxValue)
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(DataGridViewNumericUpDownEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(Double)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return 0
        End Get
    End Property

End Class

Public Class DataGridViewNumericUpDownColumn_10DecimalPlaces
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewNumericUpDownCell_10DecimalPlaces())
        MyBase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MyBase.DefaultCellStyle.Format = "N10"
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_10DecimalPlaces)) AndAlso Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell_10DecimalPlaces)) Then
                Throw New InvalidCastException("Must be a DataGridViewNumericUpDownCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class DataGridViewNumericUpDownCell_0DecimalPlaces
    Inherits DataGridViewTextBoxCell
    Public DecimalPlaces As Short = 0

    Public Sub New()
        Me.Style.Format = "N" & DecimalPlaces
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim ctl As DataGridViewNumericUpDownEditingControl = CType(DataGridView.EditingControl, DataGridViewNumericUpDownEditingControl)
        ctl.DecimalPlaces = DecimalPlaces
        ctl.Minimum = Decimal.MinValue
        ctl.Maximum = Decimal.MaxValue
        Dim v As Decimal = 0
        If IsDBNull(Me.Value) Then
            ctl.Value = 0
        Else
            If Decimal.TryParse(Me.Value, v) Then
                ctl.Value = v
            End If
        End If
        ctl.Select(0, Integer.MaxValue)
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(DataGridViewNumericUpDownEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(Double)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return 0
        End Get
    End Property

End Class

Public Class DataGridViewNumericUpDownCell_4DecimalPlaces
    Inherits DataGridViewTextBoxCell
    Public DecimalPlaces As Short = 4

    Public Sub New()
        Me.Style.Format = "N" & DecimalPlaces
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim ctl As DataGridViewNumericUpDownEditingControl = CType(DataGridView.EditingControl, DataGridViewNumericUpDownEditingControl)
        ctl.DecimalPlaces = DecimalPlaces
        ctl.Minimum = Decimal.MinValue
        ctl.Maximum = Decimal.MaxValue
        Dim v As Decimal = 0
        If IsDBNull(Me.Value) Then
            ctl.Value = 0
        Else
            If Decimal.TryParse(Me.Value, v) Then
                ctl.Value = v
            End If
        End If
        ctl.Select(0, Integer.MaxValue)
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(DataGridViewNumericUpDownEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(Double)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return 0
        End Get
    End Property

End Class

Public Class DataGridViewNumericUpDownCell_2DecimalPlaces
    Inherits DataGridViewTextBoxCell
    Public DecimalPlaces As Short = 2

    Public Sub New()
        Me.Style.Format = "N" & DecimalPlaces
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim ctl As DataGridViewNumericUpDownEditingControl = CType(DataGridView.EditingControl, DataGridViewNumericUpDownEditingControl)
        ctl.DecimalPlaces = DecimalPlaces
        ctl.Minimum = Decimal.MinValue
        ctl.Maximum = Decimal.MaxValue
        Dim v As Decimal = 0
        If IsDBNull(Me.Value) Then
            ctl.Value = 0
        Else
            If Decimal.TryParse(Me.Value, v) Then
                ctl.Value = v
            End If
        End If
        ctl.Select(0, Integer.MaxValue)
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            Return GetType(DataGridViewNumericUpDownEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(Double)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return 0
        End Get
    End Property

End Class

Class DataGridViewNumericUpDownEditingControl
    Inherits NumericUpDown
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer

    Public Property EditingControlFormattedValue() As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue

        Get
            Return Format(Me.Value, "N" & DecimalPlaces)
            'Return Me.Value.ToString(GetNumberStringFormat(DecimalPlaces))
            'Return Me.Value.ToString("#.##")
            'Return Me.Value.ToString("#" & Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator & "##")
        End Get

        Set(ByVal value As Object)
            If TypeOf value Is Double Then
                Me.Value = Double.Parse(value)
            End If
        End Set

    End Property

    Public Function GetEditingControlFormattedValue(ByVal context _
        As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Format(Me.Value, "N" & DecimalPlaces)
        'Return Me.Value.ToString(GetNumberStringFormat(DecimalPlaces))
        'Return Me.Value.ToString("#.##")
    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As _
        DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Try
            Me.Font = dataGridViewCellStyle.Font
            Me.ForeColor = dataGridViewCellStyle.ForeColor
            Me.BackColor = dataGridViewCellStyle.BackColor
            Me.TextAlign = HorizontalAlignment.Right
        Catch ex As Exception

        End Try
    End Sub

    Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set

    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey

        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

                Return True

            Case Else
                Return False
        End Select

    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

        ' No preparation needs to be done.

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() _
        As Boolean Implements _
        IDataGridViewEditingControl.RepositionEditingControlOnValueChange

        Get
            Return False
        End Get

    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set

    End Property

    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged

        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set

    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor

        Get
            Return MyBase.Cursor
        End Get

    End Property

    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)

        ' Notify the DataGridView that the contents of the cell have changed.
        valueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)

    End Sub

End Class

'Public Class DataGridViewNumericUpDownColumn
'    Inherits DataGridViewColumn

'    Public Sub New()
'        MyBase.New(New DataGridViewNumericUpDownCell())
'    End Sub

'    Public Overrides Property CellTemplate() As DataGridViewCell
'        Get
'            Return MyBase.CellTemplate
'        End Get
'        Set(ByVal value As DataGridViewCell)

'            ' Ensure that the cell used for the template is a CalendarCell.
'            If Not (value Is Nothing) AndAlso _
'                Not value.GetType().IsAssignableFrom(GetType(DataGridViewNumericUpDownCell)) _
'                Then
'                Throw New InvalidCastException("Must be a DataGridViewNumericUpDownCell")
'            End If
'            MyBase.CellTemplate = value

'        End Set
'    End Property

'End Class

'Public Class DataGridViewNumericUpDownCell
'    Inherits DataGridViewTextBoxCell

'    Public Sub New()
'        'If Me.Style.Format = Nothing Then Me.Style.Format = "N2"
'    End Sub

'    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)

'        ' Set the value of the editing control to the current cell value.
'        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

'        Dim ctl As DataGridViewNumericUpDownEditingControl = _
'            CType(DataGridView.EditingControl, DataGridViewNumericUpDownEditingControl)
'        ctl.Minimum = Decimal.MinValue
'        ctl.Maximum = Decimal.MaxValue
'        ctl.Value = CType(Me.Value, Decimal)

'        'Dim strValue As String = Format(ctl.Value, Me.Style.Format)
'        'ctl.Select(0, strValue.Length - 1)
'    End Sub

'    Public Overrides ReadOnly Property EditType() As Type
'        Get
'            Return GetType(DataGridViewNumericUpDownEditingControl)
'        End Get
'    End Property

'    Public Overrides ReadOnly Property ValueType() As Type
'        Get
'            Return GetType(Double)
'        End Get
'    End Property

'    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
'        Get
'            ' Use the current date and time as the default value.
'            Return 0
'        End Get
'    End Property


'End Class

'Class DataGridViewNumericUpDownEditingControl
'    Inherits NumericUpDown
'    Implements IDataGridViewEditingControl

'    Private dataGridViewControl As DataGridView
'    Private valueIsChanged As Boolean = False
'    Private rowIndexNum As Integer

'    Public Shadows DecimalPlaces As Integer

'    Public Sub New()
'        Me.DecimalPlaces = 2
'    End Sub

'    Private Function GetFormat(dp As Integer) As String
'        Return "N" & dp
'        'GetFormat = "#"
'        'Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
'        'If dp > 0 Then GetFormat &= decimalSeparator
'        'While dp > 0
'        '    GetFormat &= "#"
'        '    dp -= 1
'        'End While
'    End Function

'    Public Property EditingControlFormattedValue() As Object _
'        Implements IDataGridViewEditingControl.EditingControlFormattedValue

'        Get
'            Dim fm As String = GetFormat(Me.DecimalPlaces)
'            Return Me.Value.ToString(fm)
'        End Get

'        Set(ByVal value As Object)
'            If TypeOf value Is Double Then
'                Me.Value = Double.Parse(value)
'            End If
'        End Set

'    End Property

'    Public Function GetEditingControlFormattedValue(ByVal context _
'        As DataGridViewDataErrorContexts) As Object _
'        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
'        Dim fm As String = GetFormat(Me.DecimalPlaces)
'        Return Format(Me.Value, fm) 'Me.Value.ToString(fm)

'    End Function

'    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As  _
'        DataGridViewCellStyle) _
'        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

'        Me.Font = dataGridViewCellStyle.Font
'        Me.ForeColor = dataGridViewCellStyle.ForeColor
'        Me.BackColor = dataGridViewCellStyle.BackColor
'        Me.TextAlign = HorizontalAlignment.Right
'        Dim fm As String = GetFormat(Me.DecimalPlaces)
'        Me.Select(0, Format(Me.Value, fm).ToString.Length)

'    End Sub

'    Public Property EditingControlRowIndex() As Integer _
'        Implements IDataGridViewEditingControl.EditingControlRowIndex

'        Get
'            Return rowIndexNum
'        End Get
'        Set(ByVal value As Integer)
'            rowIndexNum = value
'        End Set

'    End Property

'    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
'        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
'        Implements IDataGridViewEditingControl.EditingControlWantsInputKey

'        ' Let the DateTimePicker handle the keys listed.
'        Select Case key And Keys.KeyCode
'            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
'                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

'                Return True

'            Case Else
'                Return False
'        End Select

'    End Function

'    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
'        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

'        ' No preparation needs to be done.

'    End Sub

'    Public ReadOnly Property RepositionEditingControlOnValueChange() _
'        As Boolean Implements _
'        IDataGridViewEditingControl.RepositionEditingControlOnValueChange

'        Get
'            Return False
'        End Get

'    End Property

'    Public Property EditingControlDataGridView() As DataGridView _
'        Implements IDataGridViewEditingControl.EditingControlDataGridView

'        Get
'            Return dataGridViewControl
'        End Get
'        Set(ByVal value As DataGridView)
'            dataGridViewControl = value
'        End Set

'    End Property

'    Public Property EditingControlValueChanged() As Boolean _
'        Implements IDataGridViewEditingControl.EditingControlValueChanged

'        Get
'            Return valueIsChanged
'        End Get
'        Set(ByVal value As Boolean)
'            valueIsChanged = value
'        End Set

'    End Property

'    Public ReadOnly Property EditingControlCursor() As Cursor _
'        Implements IDataGridViewEditingControl.EditingPanelCursor

'        Get
'            Return MyBase.Cursor
'        End Get

'    End Property

'    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)

'        ' Notify the DataGridView that the contents of the cell have changed.
'        valueIsChanged = True
'        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
'        MyBase.OnValueChanged(eventargs)

'    End Sub

'End Class