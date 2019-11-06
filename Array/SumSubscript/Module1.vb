Module Module1

    Sub Main()
        Dim numbers(9) As Integer
        For i As Integer = 0 To 9
            numbers(i) = Console.ReadLine()
        Next
        Console.WriteLine("Sum: " & numbers.Sum())
        Console.WriteLine("Lowest subscript: " & numbers.GetLowerBound(0))
        Console.WriteLine("Largest subscript: " & numbers.GetUpperBound(0))
        Array.Sort(numbers)
        Console.WriteLine("Mean: " & (numbers(0) + numbers(numbers.GetLength(0) - 1)) / 2)
        Console.ReadLine()
    End Sub

End Module
