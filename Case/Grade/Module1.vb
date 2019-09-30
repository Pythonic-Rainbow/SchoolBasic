Module Module1

    Sub Main()
        Console.Write("Input score: ")
        Dim score As Integer = Console.ReadLine()
        Select Case score
            Case Is > 65, Is < 0
                Console.WriteLine("Out of range")
            Case Is > 46
                Console.WriteLine("A")
            Case Is > 41
                Console.WriteLine("B")
            Case Is > 36
                Console.WriteLine("C")
            Case Is > 32
                Console.WriteLine("D")
            Case Is > 28
                Console.WriteLine("E")
            Case Else
                Console.WriteLine("No grade")
        End Select
        Console.ReadLine()
    End Sub

End Module
