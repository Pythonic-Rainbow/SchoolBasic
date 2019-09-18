Module Module1

    Sub Main()
        Console.Write("Breadth? ")
        Dim b As Single = Console.ReadLine()
        Console.Write("Height? ")
        Dim h As Single = Console.ReadLine()
        Console.Write("Resolution? ")
        Dim r As Integer = Console.ReadLine()
        Console.Write("Color depth? ")
        Dim d As Integer = Console.ReadLine()

        Console.WriteLine("Storage requirements: " & (b * h * r * d) / 1024 ^ 2 & " MiB")

        Console.ReadLine()
    End Sub

End Module
