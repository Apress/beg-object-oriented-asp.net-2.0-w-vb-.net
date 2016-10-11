Imports Microsoft.VisualBasic

Public Class SalaryEmployee
    Inherits Employee
    Private intSalary As Integer
    Public Property Salary() As Integer
        Get
            Return intSalary
        End Get
        Set(ByVal value As Integer)
            intSalary = value
        End Set
    End Property
    Public Overrides Sub ConCatName(ByVal FirstName As String, ByVal LastName As String, ByRef FullName As String)

    End Sub
    Public Overrides Function DetermineBenefits() As String

    End Function

    Public Overrides Function CalculatePay() As Decimal
        Return CDec(intSalary) / 52
    End Function
End Class
