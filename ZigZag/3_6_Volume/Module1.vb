Module Module1

    Sub Main()
        Console.Write("Radius of tank? ")
        Dim r As Single = Console.ReadLine()
        Console.Write("Height of tank? ")
        Dim h As Single = Console.ReadLine()
        Console.WriteLine("The volume of the tank is " & (Math.PI * r ^ 2 / h))

        Console.ReadLine()
    End Sub

End Module