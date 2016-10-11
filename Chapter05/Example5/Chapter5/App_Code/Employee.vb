Imports Microsoft.VisualBasic

Public MustInherit Class Employee
    Private strFirstName As String
    Private strLastName As String
    Private dteDateOfBirth As Date

    Public MustOverride Sub ConCatName(ByVal FirstName As String, ByVal LastName As String, ByRef FullName As String)

    Public MustOverride Function DetermineBenefits() As String

    Public MustOverride Function CalculatePay() As Decimal

End Class
