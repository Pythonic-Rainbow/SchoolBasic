Module Program
    Sub Main()
        Console.Write("How far to count? ")
        Dim HowFar As Integer = Console.ReadLine()
        Do While HowFar < 1
            Console.Write("Not a valid number. Please try again.")
            HowFar = Console.ReadLine()
        Loop
        For MyLoop = 1 To HowFar
            If MyLoop Mod 3 = 0 Then
                Console.Write("Fizz")
            ElseIf MyLoop Mod 5 = 0 Then
                Console.Write("Buzz")
                Console.WriteLine()
            End If
        Next
    End Sub
End Module
