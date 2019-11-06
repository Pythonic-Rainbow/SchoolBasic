Module Module1

    Sub Main()
        Dim random As Random = New Random()
        Dim range(9) As Integer
        For i As Integer = 1 To 100
            range(random.Next(100) \ 10) += 1
        Next
        For i As Integer = 0 To 9
            Console.WriteLine("{0}-{1}: {2}", i * 10 + 1, i * 10 + 10, range(i))
        Next
        Console.ReadLine()

    End Sub

End Module
