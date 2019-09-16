Module Module1

    Sub Main()
        'code for runner program'
        'by Howard Wong on 16/09/19'

        Dim runners_name, which_event As String
        Dim average, time_1, time_2, time_3 As Single
        Dim squad_number As Integer

        Console.Write("Enter the runner's name... ")
        runners_name = Console.ReadLine()

        Console.Write("Enter the runner's number... ")
        squad_number = Console.ReadLine()

        Console.Write("Which event? ")
        which_event = Console.ReadLine()

        Console.Write("Time in first race... ")
        time_1 = Console.ReadLine()

        Console.Write("Time in 2nd race... ")
        time_2 = Console.ReadLine()

        Console.Write("Time in 3rd race... ")
        time_3 = Console.ReadLine()

        average = (time_1 + time_2 + time_3) / 3

        Console.WriteLine()

        Console.WriteLine("Name " & runners_name)
        Console.WriteLine("Number " & squad_number)
        Console.WriteLine("Event " & which_event)
        Console.WriteLine("Average time " & Format(average, ".00") & "s")

        Console.ReadLine()
    End Sub

End Module
