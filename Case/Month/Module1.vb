Module Module1

    Sub Main()
        Console.Write("Input month. ")
        Dim m As Integer = Console.ReadLine()
        Select Case m
            Case Is > 0, Is < 13
                Console.WriteLine(MonthName(m))
                Console.WriteLine("There are {0} days in this month.", Date.DaysInMonth(Year(DateAndTime.Now), m))
            Case Else
                Console.WriteLine("Out of range")
        End Select

        Console.ReadLine()
    End Sub

End Module
