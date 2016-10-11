
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim clsSalaried As SalaryEmployee
        Dim clsHourly As HourlyEmployee

        clsSalaried = New SalaryEmployee
        clsHourly = New HourlyEmployee

        clsSalaried.Salary = txtSalary.Text
        txtCalculateSalary.Text = clsSalaried.CalculatePay.ToString

        clsHourly.Rate = CDec(Trim(txtRate.Text))
        clsHourly.Hours = CDec(Trim(txtHours.Text))

        txtCalculateHourly.Text = clsHourly.CalculatePay.ToString
    End Sub
End Class
