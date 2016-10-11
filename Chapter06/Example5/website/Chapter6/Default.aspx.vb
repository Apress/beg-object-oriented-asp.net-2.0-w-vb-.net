Imports MyCompany.math
Partial Class _Default
    Inherits System.Web.UI.Page
    Private clsIntegers As Integers
    Private clsDecimals As Decimals

    Protected Sub btnAddIntegers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegers.Click
        clsIntegers = New Integers
        txtAnswer.Text = clsIntegers.AddIntegers(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub btnAddDecimals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddDecimals.Click
        clsDecimals = New Decimals
        txtAnswer.Text = clsDecimals.AddDecimal(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub btnMultiplyDecimals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiplyDecimals.Click
        clsDecimals = New Decimals
        txtAnswer.Text = clsDecimals.MultiplyDecimal(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub btnMultiplyIntegers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiplyIntegers.Click
        clsIntegers = New Integers
        txtAnswer.Text = clsIntegers.MultiplyIntegers(txtFirst.Text, txtSecond.Text)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblLogin.Text = "Login: " & My.User.Name
    End Sub
End Class
