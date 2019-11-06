Module Module1

    Sub Main()
        Dim names() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
        Array.Reverse(names)
        For Each name As String In names
            Console.WriteLine(name)
        Next
        Console.ReadLine()
    End Sub

End Module
