Module Module1

    Sub Main()
        Dim input As Integer = 0
        Do Until input = 1
            Console.Write("Are we there yet (1=Yes/0=No)? ")
            input = Console.ReadLine()
        Loop
        Console.WriteLine("Wonderful, we have arrived")
        Console.ReadLine()
    End Sub

End Module
