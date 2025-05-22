Imports System.Data.SqlClient
Imports DevExpress.XtraCharts

Public Class FormReportXChart
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Public Enum ChartType As Short
    '    Pie3D
    '    StackedBar3D
    'End Enum

    'Public Sub LoadChart(ByVal dt As DataTable, ByVal series As String, ByVal arg As String, ByVal valuemember As String, ByVal t As ChartType)
    '    With crtReport
    '        .DataSource = dt
    '        .SeriesDataMember = series
    '        .SeriesTemplate.ArgumentDataMember = arg
    '        .SeriesTemplate.ArgumentScaleType = ScaleType.Qualitative
    '        .SeriesTemplate.ValueDataMembers.AddRange(New String() {valuemember})
    '        Select Case t
    '            Case ChartType.Pie3D
    '                .SeriesTemplate.View = New Pie3DSeriesView
    '            Case ChartType.StackedBar3D
    '                .SeriesTemplate.View = New StackedBar3DSeriesView
    '        End Select
    '    End With
    '    Me.Show()
    'End Sub

    'Private Function CreateChartData() As DataTable
    '    ' Create an empty table.
    '    Dim Table As New DataTable("Table1")

    '    ' Add three columns to the table.
    '    Table.Columns.Add("Month", GetType([String]))
    '    Table.Columns.Add("Section", GetType([String]))
    '    Table.Columns.Add("Value", GetType(Int32))

    '    ' Add data rows to the table.
    '    Table.Rows.Add(New Object() {"Jan", "Section1", 10})
    '    Table.Rows.Add(New Object() {"Jan", "Section2", 20})
    '    Table.Rows.Add(New Object() {"Feb", "Section1", 20})
    '    Table.Rows.Add(New Object() {"Feb", "Section2", 30})
    '    Table.Rows.Add(New Object() {"March", "Section1", 15})
    '    Table.Rows.Add(New Object() {"March", "Section2", 25})

    '    Return Table
    'End Function

    'Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
    'Handles MyBase.Load
    '    ' Create a chart.
    '    'Dim Chart As New ChartControl()
    '    With crtReport
    '        ' Generate a data table and bind the chart to it.
    '        .DataSource = CreateChartData()

    '        ' Specify data members to bind the chart's series template.
    '        .SeriesDataMember = "Month"
    '        .SeriesTemplate.ArgumentDataMember = "Section"
    '        .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Value"})

    '        ' Specify the template's series view.
    '        .SeriesTemplate.View = New StackedBarSeriesView()

    '        ' Specify the template's name prefix.
    '        .SeriesNameTemplate.BeginText = "Month: "

    '        ' Dock the chart into its parent, and add it to the current form.

    '    End With


    'End Sub

End Class