Module Module1

    Sub Main()
        Dim position, maxAge, ageList(3) As Integer
        maxAge = 0
        For index As Integer = 0 To 3
            ageList(index) = Console.ReadLine()
            If ageList(index) > maxAge Then
                maxAge = ageList(index)
                position = index
            End If
        Next
        Console.WriteLine(ageList(position) & " " & position)
    End Sub

End Module
