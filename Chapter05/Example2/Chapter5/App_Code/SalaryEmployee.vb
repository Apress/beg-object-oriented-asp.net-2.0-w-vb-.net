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
End Class
