Imports Microsoft.VisualBasic

Public Class User
    Private blnIsTechnician As Boolean
    Private blnIsHelpDeskManager As Boolean

    Public ReadOnly Property IsTechnician() As Boolean
        Get
            Return blnIsTechnician
        End Get
    End Property
    Public ReadOnly Property IsHelpDeskManager() As Boolean
        Get
            Return blnIsHelpDeskManager
        End Get
    End Property
    Public Sub New(ByVal UserLogin As String)
        blnIsTechnician = True
        blnIsHelpDeskManager = False
    End Sub
    Public Sub TicketNotResolved(ByVal TicketID As Integer)

    End Sub
    Public Sub CloseTicket(ByVal TicketID As Integer)

    End Sub
    Public Function TicketsCreatedByMe(ByVal UserName As String) As Data.DataSet

    End Function
    Public Function MyResolvedTickets(ByVal UserName As String) As Data.DataSet

    End Function
End Class
