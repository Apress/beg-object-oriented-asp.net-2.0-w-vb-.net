
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsMy As New MyFirstClass
        Dim strReturn As String
        strReturn = clsMy.ReturnString
    End Sub
End Class
