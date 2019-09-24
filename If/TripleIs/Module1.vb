Module Module1

    Sub Main()
        Console.Write("Enter a key. ")
        Dim ch As Char = Console.ReadKey().KeyChar
        Console.WriteLine()
        Dim o As String = "You have entered a "
        If Char.IsDigit(ch) Then
            Console.WriteLine(o & "digit")
        ElseIf Char.IsLetter(ch) Then
            Console.WriteLine(o & "letter")
            Console.WriteLine("Is letter lowercase? " & Char.IsLower(ch))
        Else : Console.WriteLine(o & "symbol")
        End If
        Console.ReadLine()
    End Sub

End Module
