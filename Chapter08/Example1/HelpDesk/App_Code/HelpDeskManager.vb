Imports Microsoft.VisualBasic

Public Class HelpDeskManager
    Inherits HelpDeskUser
    Private strUserName As String
    Public Sub New(ByVal UserLogin As String)
        strUserName = UserLogin
    End Sub
    Public Function RetrieveTicketsForLocation(ByVal Location As String) As Data.DataSet

    End Function
    Public Function RetrieveTicketsForTechnician(ByVal Technician As String) As Data.DataSet

    End Function
End Class
