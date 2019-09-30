Module Module1

    Sub Main()
        Console.Write("Enter a message: ")
        Dim msg As String = Console.ReadLine()
        Console.Write("Enter a number: ")
        Dim index As Integer = Console.ReadLine()
        For i = 1 To index
            Console.WriteLine(msg)
        Next
        Console.ReadLine()
    End Sub

End Module
