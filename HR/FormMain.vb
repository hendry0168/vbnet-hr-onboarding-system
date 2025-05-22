Public Class FormMain
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Connection.ServerName = txtServerName.Text
    End Sub

    Private Sub btnOffboardingEntry_Click(sender As Object, e As EventArgs) Handles btnOffboardingEntry.Click
        Using frm As New FormAdmin(HRSystemID.OffboardingEntry)
        End Using
    End Sub

    Private Sub btnOffboardingReport_Click(sender As Object, e As EventArgs) Handles btnOffboardingReport.Click
        Using frm As New FormDocReport(HRSystemID.OffboardingReport)
        End Using
    End Sub

    Private Sub btnOnboardingEntry_Click(sender As Object, e As EventArgs) Handles btnOnboardingEntry.Click
        Using frm As New FormAdmin(HRSystemID.OnboardingEntry)
        End Using
    End Sub

    Private Sub btnOnboardingReport_Click(sender As Object, e As EventArgs) Handles btnOnboardingReport.Click
        Using frm As New FormDocReport(HRSystemID.OnboardingReport)
        End Using
    End Sub

    Private Sub btnEmployeeReport_Click(sender As Object, e As EventArgs) Handles btnEmployeeReport.Click
        Using frm As New FormEmployeeReport(HRSystemID.EmployeeReport)
        End Using
    End Sub

    Private Sub btnEducation_Click(sender As Object, e As EventArgs) Handles btnEducation.Click
        Using frm As New FormAdmin(HRSystemID.EducationEntry)
        End Using
    End Sub

    Private Sub btnGender_Click(sender As Object, e As EventArgs) Handles btnGender.Click
        Using frm As New FormAdmin(HRSystemID.GenderEntry)
        End Using
    End Sub

    Private Sub btnReligion_Click(sender As Object, e As EventArgs) Handles btnReligion.Click
        Using frm As New FormAdmin(HRSystemID.ReligionEntry)
        End Using
    End Sub

    Private Sub btnEmploymentType_Click(sender As Object, e As EventArgs) Handles btnEmploymentType.Click
        Using frm As New FormAdmin(HRSystemID.EmploymentTypeEntry)
        End Using
    End Sub

    Private Sub btnPersonnelLevel_Click(sender As Object, e As EventArgs) Handles btnPersonnelLevel.Click
        Using frm As New FormAdmin(HRSystemID.PersonnelLevelEntry)
        End Using
    End Sub

    Private Sub btnDocStatus_Click(sender As Object, e As EventArgs) Handles btnDocStatus.Click
        Using frm As New FormAdmin(HRSystemID.DocStatusEntry)
        End Using
    End Sub

    Private Sub btnPersonnelStatus_Click(sender As Object, e As EventArgs) Handles btnPersonnelStatus.Click
        Using frm As New FormAdmin(HRSystemID.PersonnelStatusEntry)
        End Using
    End Sub

    Private Sub btnPersonnelType_Click(sender As Object, e As EventArgs) Handles btnPersonnelType.Click
        Using frm As New FormAdmin(HRSystemID.PersonnelTypeEntry)
        End Using
    End Sub

    Private Sub btnPersonnelAction_Click(sender As Object, e As EventArgs) Handles btnPersonnelAction.Click
        Using frm As New FormAdmin(HRSystemID.PersonnelActionEntry)
        End Using
    End Sub
End Class
