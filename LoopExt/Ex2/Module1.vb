Module Module1

    Sub Main()
        For i = 1 To 7
            For j = 1 To i
                Console.Write(j)
            Next
            For j = 1 To 7 - i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
