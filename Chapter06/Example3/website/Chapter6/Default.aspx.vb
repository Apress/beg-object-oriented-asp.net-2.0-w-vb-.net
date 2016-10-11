Imports MyCompany
Partial Class _Default
    Inherits System.Web.UI.Page
    Private clsmath As Math

    Protected Sub btnAddIntegers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegers.Click
        clsmath = New Math
        txtAnswer.Text = clsmath.AddIntegers(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub btnAddDecimals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddDecimals.Click
        clsmath = New Math
        txtAnswer.Text = clsmath.AddDecimal(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub btnMultiplyDecimals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiplyDecimals.Click
        clsmath = New Math
        txtAnswer.Text = clsmath.MultiplyDecimal(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub btnMultiplyIntegers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiplyIntegers.Click
        clsmath = New Math
        txtAnswer.Text = clsmath.MultiplyIntegers(txtFirst.Text, txtSecond.Text)
    End Sub
End Class
