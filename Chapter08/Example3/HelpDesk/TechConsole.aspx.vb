
Partial Class TechConsole
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsUser As New User(Session("UserLogin").ToString)
        lblCompanyName.Text = Application("CompanyName").ToString
        If Not clsUser.IsHelpDeskManager Then
            If Not clsUser.IsTechnician Then
                Response.Redirect("UserConsole.aspx")
            Else
                btnAdministration.Visible = True
            End If
        Else
            btnAdministration.Visible = True
        End If
    End Sub
End Class
