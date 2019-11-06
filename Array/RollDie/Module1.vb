Module Module1

    Sub Main()
        Dim result(6) As Integer
        Dim random As Random = New Random()
        For i As Integer = 1 To 200
            result(Int(random.Next(7))) += 1
        Next
        For i As Integer = 0 To 6
            Console.WriteLine(i & " " & result(i))
        Next
    End Sub

End Module
