Module Module1

    Sub Main()
        Dim input As Integer
        Do
            Console.WriteLine("Are we there yet(1=yes/0=No)? ")
            input = Console.ReadLine()
        Loop Until input = 1
        Console.WriteLine("Wonderful, we have arrived")
        Console.ReadLine()
    End Sub

End Module
