Imports Microsoft.VisualBasic

Public Class ExecutiveEmployee : Inherits Employee
    Public Overrides Function DetermineBenefits() As String
        Return "20% bonus, country club membership" & MyBase.DetermineBenefits
    End Function
End Class
