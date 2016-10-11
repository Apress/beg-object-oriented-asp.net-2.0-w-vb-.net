Public Class UserAuth
    Public Function IsUserAdmin(ByVal UserName As String) As Boolean
        If UserName = "Mickey" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function IsUserValid(ByVal UserName As String) As Boolean
        If UserName = "Mickey" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
