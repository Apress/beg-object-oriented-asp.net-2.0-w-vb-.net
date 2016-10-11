
Partial Class _Default
    Inherits System.Web.UI.Page
    Private clsSalaryEmployee As SalaryEmployee
    Private clsExecutiveEmployee As ExecutiveEmployee
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
    End Sub

    Protected Sub btnSalaried_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalaried.Click
        clsSalaryEmployee = New SalaryEmployee
        txtsalaried.Text = clsSalaryEmployee.DetermineBenefits
    End Sub

    Protected Sub btnExecutive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExecutive.Click
        clsExecutiveEmployee = New ExecutiveEmployee
        txtexecutive.Text = clsExecutiveEmployee.DetermineBenefits
    End Sub
End Class
