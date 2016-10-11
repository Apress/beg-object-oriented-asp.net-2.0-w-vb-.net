
Partial Class _Default
    Inherits System.Web.UI.Page
    Private clsMath As Encapsulation.Math
   
    Protected Sub btnMultiply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        clsMath = New Encapsulation.Math
        clsMath.InValue = CInt(txtInbound.Text)
        txtResult.Text = clsMath.MultiplyBySelf
    End Sub
End Class
