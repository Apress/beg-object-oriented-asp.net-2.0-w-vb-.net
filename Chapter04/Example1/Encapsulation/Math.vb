Public Class Math
    Private intValue As Integer
    Public Property InValue() As Integer
        Get
            Return intValue
        End Get
        Set(ByVal value As Integer)
            If intValue > 0 Then
                intValue = value
            Else
                Throw New Exception("InValue can not be less than 1")
            End If
        End Set
    End Property
    Public Function MultiplyBySelf() As Integer
        Return Multiply(intValue, intValue)
    End Function
    Private Function Multiply(ByVal FirstValue As Integer, ByVal SecondValue As Integer)
        Return FirstValue * SecondValue
    End Function
End Class
