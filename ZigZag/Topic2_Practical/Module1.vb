Module Module1

    Sub Main()
        Console.Write("Where is the starting place? ")
        Dim start As String = Console.ReadLine()
        Console.Write("Where are you going to? ")
        Dim dest As String = Console.ReadLine()
        Console.Write("How far are they apart from each other? ")
        Dim distance As Single = Console.ReadLine()
        Console.Write("What's the estimated average speed? ")
        Dim average_speed As Single = Console.ReadLine()

        Dim time_taken As Single = distance / average_speed

        Console.WriteLine("Start: " & start)
        Console.WriteLine("Destination: " & dest)
        Console.WriteLine("Distance: " & distance)
        Console.WriteLine("Average speed: " & average_speed)
        Console.WriteLine("Time: " & Format(time_taken, ".0"))

        Console.ReadLine()
    End Sub

End Module
