
Partial Class ViewTickets
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblCompanyName.Text = Application("CompanyName").ToString
    End Sub
End Class
