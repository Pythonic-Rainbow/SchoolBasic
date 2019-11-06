Module Module1

    Sub Main()
        For i = 1 To 122
            Console.Write(Chr(i))
            If i Mod 10 = 0 Then Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
