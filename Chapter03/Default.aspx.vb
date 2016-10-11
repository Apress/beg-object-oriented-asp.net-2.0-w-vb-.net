
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim clsEmployee As New Employee
        Dim StrConCatName As String
        Dim StrFirstName As String
        Dim StrLastName As String

        clsEmployee.FirstName = "Brian"
        clsEmployee.LastName = "Myers"
        clsEmployee.DateOfBirth = "1/1/1900"

        StrFirstName = "Brian"
        StrLastName = "Myers"
        StrConCatName = clsEmployee.ConCatNames(StrFirstName, StrLastName)
    End Sub
End Class
