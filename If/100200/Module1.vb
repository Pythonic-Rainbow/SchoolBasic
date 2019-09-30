Module Module1

    Sub Main()
        Console.Write("Input number a. ")
        Dim a As Integer = Console.ReadLine()
        Console.Write("Input number b. ")
        Dim b As Integer = Console.ReadLine()
        If a = 100 And b = 200 Then Console.WriteLine("The value of a is 100 and b is 200")
        Console.WriteLine("A: {0}, B: {1}", a, b)
        Console.ReadLine()
    End Sub

End Module
