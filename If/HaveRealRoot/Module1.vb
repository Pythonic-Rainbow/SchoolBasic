Module Module1

    Sub Main()
        Console.Write("Number A: ")
        Dim a As Single = Console.ReadLine()
        Console.Write("Number B: ")
        Dim b As Single = Console.ReadLine()
        If a > b Then
            Console.WriteLine("A is greater than B.")
        ElseIf a < b Then
            Console.WriteLine("B is greter than A.")
        Else : Console.WriteLine("A and B are equal.")
        End If
        Console.ReadLine()
    End Sub

End Module
