Module Module1

    Sub Main()
        Console.Write("Employee number? ")
        Dim num As Integer = Console.ReadLine()
        Console.Write("Hourly rate? ")
        Dim rate As Single = Console.ReadLine()
        Console.Write("Hours worked in the week? ")
        Dim h As Single = Console.ReadLine()
        Dim wage As Single = rate * h
        If h > 40 Then wage *= 1.5
        Console.WriteLine("Employee {0}'s wage: ${1}", num, wage)
        Console.ReadLine()
    End Sub

End Module
