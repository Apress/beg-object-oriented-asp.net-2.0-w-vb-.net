Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

<WebService(Namespace:="http://localhost/UserInformation", Description:="Retrieve User Information")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class UserInformation
    Inherits System.Web.Services.WebService

    <WebMethod(Description:="Get the first name of the user")> _
    Public Function GetFirstName(ByVal UserLogin As String) As Boolean
        If UserLogin = "Brian" Then
            Return "Brian"
        Else
            Return ""
        End If
    End Function

    <WebMethod(Description:="Get the last name of the user")> _
    Public Function GetLastName(ByVal UserLogin As String) As Boolean
        If UserLogin = "Brian" Then
            Return "Myers"
        Else
            Return ""
        End If
    End Function
    <WebMethod(Description:="Get the phone number of the user")> _
    Public Function GetPhoneNumber(ByVal UserLogin As String) As Boolean
        If UserLogin = "Brian" Then
            Return "555-5555"
        Else
            Return ""
        End If
    End Function
    <WebMethod(Description:="Get the email address of the user")> _
Public Function GetEmailAddress(ByVal UserLogin As String) As Boolean
        If UserLogin = "Brian" Then
            Return "email@company.com"
        Else
            Return ""
        End If
    End Function
    <WebMethod(Description:="Get the location id of the user")> _
Public Function GetLocation(ByVal UserLogin As String) As Boolean
        If UserLogin = "Brian" Then
            Return 2
        Else
            Return 0
        End If
    End Function
End Class
