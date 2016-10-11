Imports Microsoft.VisualBasic

Public Class Employee
    Private strFirstName As String
    Private strLastName As String
    Private dteDateOfBirth As Date

    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property
    Public Property DateOfBirth() As Date
        Get
            Return dteDateOfBirth
        End Get
        Set(ByVal value As Date)
            dteDateOfBirth = value
        End Set
    End Property
End Class
