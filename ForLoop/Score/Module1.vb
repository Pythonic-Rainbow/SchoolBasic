Module Module1

    Sub Main()
        Dim average(3), totals(3) As Single
        For j = 1 To 30
            For i = 0 To 2
                Console.Write("Enter score for test " & i + 1 & ": ")
                totals(i) += Console.ReadLine()
            Next
        Next
        For i = 0 To 2
            average(i) = totals(i) / 30
        Next
        Console.WriteLine("Averages: {0}, {1}, {2}, {3}", average(0), average(1), average(2), totals.Sum() / 30)
        Console.WriteLine("Totals: {0}, {1}, {2}, {3}", totals(0), totals(1), totals(2), totals.Sum())
        Console.ReadLine()
    End Sub

End Module
