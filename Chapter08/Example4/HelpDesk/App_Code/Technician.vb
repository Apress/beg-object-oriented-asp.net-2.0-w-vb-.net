Imports Microsoft.VisualBasic

Public Class Technician
    Inherits HelpDeskUser
    Private strUserName As String

    Public Sub New(ByVal UserLogin As String)
        strUserName = UserLogin
    End Sub
    Public Function AssignedToMe() As Data.DataSet

    End Function
    Public Function ResolvedByMe() As Data.DataSet

    End Function
End Class
