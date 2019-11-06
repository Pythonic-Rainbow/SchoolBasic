Module Module1

    Sub Main()
        Dim input As Integer
        Do
            Console.Write("Are we there yet (1=Yes/0=No)? ")
            input = Console.ReadLine()
        Loop While input <> 1
        Console.WriteLine("Wonderful, we have arrived")
        Console.ReadLine()
    End Sub

End Module
