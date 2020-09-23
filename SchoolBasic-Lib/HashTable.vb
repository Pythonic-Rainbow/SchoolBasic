Public Class HashTable
    Private table As Dictionary(Of String, List(Of String))

    Public Sub New()
        table = New Dictionary(Of String, List(Of String))
    End Sub

    Public Sub Add(ByVal value As String)
        Dim num As Double = 1
        For Each c In value
            num *= Asc(c)
        Next
        Dim hash As String = Math.Log(num ^ value.Length, value.Length)
        If Not table.ContainsKey(hash) Then
            table.Add(hash, New List(Of String))
        End If
        table(hash).Add(value)
    End Sub

    Public Function GetHashTable() As Dictionary(Of String, List(Of String))
        Return table
    End Function

End Class
