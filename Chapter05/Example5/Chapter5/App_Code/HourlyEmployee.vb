Imports Microsoft.VisualBasic

Public Class HourlyEmployee : Inherits Employee
    Private decHours As Decimal
    Private decRate As Decimal
    Public Property Hours() As Decimal
        Get
            Return decHours
        End Get
        Set(ByVal value As Decimal)
            decHours = value
        End Set
    End Property
    Public Property Rate() As Decimal
        Get
            Return decRate
        End Get
        Set(ByVal value As Decimal)
            decRate = value
        End Set
    End Property
    Public Overrides Function CalculatePay() As Decimal
        Return decHours * decRate
    End Function
    Public Overrides Sub ConCatName(ByVal FirstName As String, ByVal LastName As String, ByRef FullName As String)

    End Sub
    Public Overrides Function DetermineBenefits() As String

    End Function
End Class
