Module Module1

    Sub Main()
        Dim number, result As Single

        Console.Write("Enter a number... ")
        number = Console.ReadLine()

        result = Math.Sin(number * 3.14128 / 180)
        Console.Write("result is " & result)
        Console.ReadLine()
    End Sub

End Module
