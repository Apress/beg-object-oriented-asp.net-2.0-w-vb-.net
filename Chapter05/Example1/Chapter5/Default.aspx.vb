
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsSalaryEmployee As SalaryEmployee
        clsSalaryEmployee.ConCatName()
    End Sub
End Class
