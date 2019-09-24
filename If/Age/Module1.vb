Module Module1

    Sub Main()
        Console.Write("Enter your age. ")
        Dim age As Integer = Integer.Parse(Console.ReadLine())
        If age > 17 Then Console.WriteLine("You are eligible to vote.")
        Console.ReadLine()
    End Sub

End Module
