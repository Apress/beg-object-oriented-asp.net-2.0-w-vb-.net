Imports Microsoft.VisualBasic

Public Class Ticket
    Private strUserLogin As String
    Private strFirstName As String
    Private strLastName As String
    Private strPhoneNumber As String
    Private intLocation As Integer
    Private strEmailAddress As String
    Private strProblemDescription As String
    Private strCategory As String
    Private strCreatedByLogin As String
    Private strStatus As String
    Private strImportance As String
    Private strAdditionalComments As String
    Private strAssignedTo As String
    Private strResolution As String
    Private decTimeSpent As Decimal
    Private dteDateResolved As Date
    Private intTicketID As Integer
    Private dteDateClosed As Date
#Region "Public Propeties"
    Public Property UserLoginName() As String
        Get
            Return strUserLogin
        End Get
        Set(ByVal value As String)
            strUserLogin = value
        End Set
    End Property
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
    Public Property PhoneNumber() As String
        Get
            Return strPhoneNumber
        End Get
        Set(ByVal value As String)
            strPhoneNumber = value
        End Set
    End Property
    Public Property Location() As Integer
        Get
            Return intLocation
        End Get
        Set(ByVal value As Integer)
            intLocation = value
        End Set
    End Property
    Public Property EmailAddress() As String
        Get
            Return strEmailAddress
        End Get
        Set(ByVal value As String)
            strEmailAddress = value
        End Set
    End Property
    Public Property ProblemDescription() As String
        Get
            Return strProblemDescription
        End Get
        Set(ByVal value As String)
            strProblemDescription = value
        End Set
    End Property
    Public Property Category() As String
        Get
            Return strCategory
        End Get
        Set(ByVal value As String)
            strCategory = value
        End Set
    End Property
    Public Property CreatedByLogin() As String
        Get
            Return strCreatedByLogin
        End Get
        Set(ByVal value As String)
            strCreatedByLogin = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return strStatus
        End Get
        Set(ByVal value As String)
            strStatus = value
        End Set
    End Property
    Public Property Importance() As String
        Get
            Return strImportance
        End Get
        Set(ByVal value As String)
            strImportance = value
        End Set
    End Property
    Public Property AdditionalComments() As String
        Get
            Return strAdditionalComments
        End Get
        Set(ByVal value As String)
            strAdditionalComments = value
        End Set
    End Property
    Public Property AssignedTo() As String
        Get
            Return strAssignedTo
        End Get
        Set(ByVal value As String)
            strAssignedTo = value
        End Set
    End Property
    Public Property Resolution() As String
        Get
            Return strResolution
        End Get
        Set(ByVal value As String)
            strResolution = value
        End Set
    End Property
    Public Property TimeSpent() As Decimal
        Get
            Return decTimeSpent
        End Get
        Set(ByVal value As Decimal)
            decTimeSpent = value
        End Set
    End Property
    Public Property DateResolved() As Date
        Get
            Return dteDateResolved
        End Get
        Set(ByVal value As Date)
            dteDateResolved = value
        End Set
    End Property
    Public Property TicketID() As Integer
        Get
            Return intTicketID
        End Get
        Set(ByVal value As Integer)
            intTicketID = value
        End Set
    End Property
    Public Property DateClosed() As Date
        Get
            Return dteDateClosed
        End Get
        Set(ByVal value As Date)
            dteDateClosed = value
        End Set
    End Property
#End Region
    Public Function NewTicket() As Boolean
        Try
            If ValidateTicket() Then
                intTicketID = 10
                Return True
            End If
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function
    Public Function AssignTicket(ByVal TicketID As Integer) As Boolean
        Try
            If strAssignedTo.Length = 0 Then
                Throw New Exception("Assigned To not provided")
            End If
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function
    Public Function UpdateTicket(ByVal TicketID As Integer) As Boolean

    End Function
    Private Function ValidateTicket() As Boolean
        Dim strErrors As String
        If strUserLogin.Length = 0 Then
            strErrors = strErrors & "User Login not provided,"
        End If
        If strFirstName.Length = 0 Then
            strErrors = strErrors & "First Name not provided,"
        End If
        If strLastName.Length = 0 Then
            strErrors = strErrors & "Last Name not provided,"
        End If
        If strEmailAddress.Length = 0 Then
            strErrors = strErrors & "Email Address not provided,"
        End If
        If intLocation = 0 Then
            strErrors = strErrors & "Location not provided,"
        End If
        If strCategory.Length = 0 Then
            strErrors = strErrors & "Category not provided,"
        End If
        If strProblemDescription.Length = 0 Then
            strErrors = strErrors & "Problem Description not provided,"
        End If
        If strErrors.Length > 0 Then
            strErrors = Mid(strErrors, 1, strErrors.Length - 1)
            Throw New Exception("Errors have occured: " & strErrors)
        Else
            Return True
        End If
    End Function
    Public Function ChangeStatus(ByVal TicketID As Integer, ByVal StatusID As Integer) As Boolean

    End Function
    Public Function ResolveTicket(ByVal TicketID As Integer) As Boolean

    End Function
    Public Function NotificationOfResolved(ByVal TicketID As Integer, ByVal EmailAddress As String) As Boolean

    End Function
    Public Function NotificationOfNotResolved(ByVal TicketID As Integer, ByVal EmailAddress As String) As Boolean

    End Function
End Class
