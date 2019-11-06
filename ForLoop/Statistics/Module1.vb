Module Module1

    Sub Main()
        Dim nums(10) As Single
        For i = 0 To 9
            Console.Write("Enter a number for position " & i & ": ")
            nums(i) = Console.ReadLine()
        Next
        Console.WriteLine("Mean: " & nums.Average())
        Console.WriteLine("Min: " & nums.Take(10).Min())
        Console.WriteLine("Max: " & nums.Max())
        Console.ReadLine()
    End Sub

End Module
