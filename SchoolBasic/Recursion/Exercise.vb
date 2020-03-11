Public Class Exercise
    Public Function SumTo(ByVal n As UInteger) As UInteger
        If n = 1 Then
            Return 1
        End If
        Return n + SumTo(n - 1)
    End Function

    Function IsPalindrome(ByVal s As String) As Boolean
        If s.Count = 1 Then
            Return True
        ElseIf s.Count = 2 Then
            Return s(0) = s.Last()
        Else
            Return s(0) = s.Last() And IsPalindrome(s.Substring(1, s.Count - 2))
        End If
    End Function

    Function PyramidCount(ByVal n As UInteger) As UInteger
        Dim triangle = n ^ 2
        If n > 2 Then
            triangle += PyramidCount(n - 2)
        End If
        Return triangle
    End Function
End Class
