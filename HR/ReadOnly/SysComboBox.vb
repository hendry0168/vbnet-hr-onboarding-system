'http://www.codeproject.com/cs/miscctrl/ReadOnlyComboBox.asp

Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Drawing

''' <summary>
''' Combo box with read only property
''' </summary>
Public Class SysComboBox
    Inherits System.Windows.Forms.ComboBox

    Private m_readOnly As Boolean
    Private CharCasing As Windows.Forms.CharacterCasing
    Private tBackColor As Color
    Private tForeColor As Color
    Private cmnuEmpty As ContextMenu
    Private m_dropDownStyle As ComboBoxStyle = ComboBoxStyle.DropDown
    Private m_readOnlyBackColor As Color = SystemColors.Control
    Private m_readOnlyForeColor As Color = SystemColors.WindowText

    Public Sub New()
        cmnuEmpty = New ContextMenu()
    End Sub

    ' CharacterCasing property
    ''' <summary>
    ''' Gets or sets the character casing.
    ''' </summary>
    ''' <value>The character casing.</value>
    <Description("Character casing"), Category("Behavior"), DefaultValue(Windows.Forms.CharacterCasing.Normal)> _
    Public Property [CharacterCasing]() As Windows.Forms.CharacterCasing
        Get
            Return CharCasing
        End Get
        Set(ByVal value As Windows.Forms.CharacterCasing)
            CharCasing = value
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        If Me.SelectionStart >= 0 Then
            Dim start As Integer = Me.SelectionStart
            Select Case CharCasing
                Case Windows.Forms.CharacterCasing.Lower
                    Me.Text = Me.Text.ToLower
                Case Windows.Forms.CharacterCasing.Upper
                    Me.Text = Me.Text.ToUpper
            End Select
            Try
                Me.SelectionStart = start
            Catch ex As Exception

            End Try

        End If
    End Sub

    ' ReadOnly property
    ''' <summary>
    ''' Gets or sets a value indicating whether [read only].
    ''' </summary>
    ''' <value><c>true</c> if [read only]; otherwise, <c>false</c>.</value>
    <Description("Read only"), Category("Behavior"), DefaultValue(False)> _
    Public Property [ReadOnly]() As Boolean
        Get
            Return m_readOnly
        End Get
        Set(ByVal value As Boolean)
            Dim t As String = Me.Text
            If m_readOnly <> value Then
                m_readOnly = value
                If value Then
                    Dim tempHeight As Integer
                    Me.ContextMenu = cmnuEmpty
                    tempHeight = MyBase.Height
                    MyBase.DropDownStyle = ComboBoxStyle.Simple
                    MyBase.Height = tempHeight
                    Me.tBackColor = Me.BackColor
                    Me.tForeColor = Me.ForeColor
                    If MyBase.BackColor = tBackColor Then MyBase.BackColor = Me.ReadOnlyBackColor
                    MyBase.ForeColor = Me.ReadOnlyForeColor
                Else
                    Me.ContextMenu = Nothing
                    MyBase.DropDownStyle = m_dropDownStyle
                    MyBase.BackColor = tBackColor
                    MyBase.ForeColor = tForeColor
                End If
            End If
            Me.Text = t
        End Set
    End Property

    <Description("Back color when read only"), Category("Appearance")> _
    Public Property ReadOnlyBackColor() As Color
        Get
            Return m_readOnlyBackColor
        End Get
        Set(ByVal value As Color)
            m_readOnlyBackColor = value
        End Set
    End Property

    <Description("Fore color when read only"), Category("Appearance")> _
    Public Property ReadOnlyForeColor() As Color
        Get
            Return m_readOnlyForeColor
        End Get
        Set(ByVal value As Color)
            m_readOnlyForeColor = value
        End Set
    End Property

    Public Shadows Property DropDownStyle() As ComboBoxStyle
        Get
            Return m_dropDownStyle
        End Get
        Set(ByVal value As ComboBoxStyle)
            If m_dropDownStyle <> value Then
                m_dropDownStyle = value
                If Me.ReadOnly Then
                    MyBase.DropDownStyle = ComboBoxStyle.Simple
                Else
                    MyBase.DropDownStyle = value
                End If
            End If
        End Set
    End Property

    Protected Overloads Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If Me.[ReadOnly] AndAlso (e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Delete) Then
            e.Handled = True
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub

    Protected Overloads Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        If Me.[ReadOnly] Then
            e.Handled = True
        Else
            MyBase.OnKeyPress(e)
        End If
    End Sub

    Private Sub SysComboBox_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.StyleChanged
        If Me.ReadOnly Then
            MyBase.DropDownStyle = ComboBoxStyle.Simple
        End If
    End Sub
End Class