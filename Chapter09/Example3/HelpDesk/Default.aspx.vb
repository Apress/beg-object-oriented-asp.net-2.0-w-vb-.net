
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsUser As New User(Session("UserLogin").ToString)
        If clsUser.IsTechnician Or clsUser.IsHelpDeskManager Then
            Response.Redirect("TechConsole.aspx")
        Else
            Response.Redirect("UserConsole.aspx")
        End If
    End Sub
End Class
