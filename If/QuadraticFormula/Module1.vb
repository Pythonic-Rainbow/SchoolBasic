Module Module1

    Sub Main()
        Console.Write("A: ")
        Dim a As Single = Console.ReadLine()
        Console.Write("B: ")
        Dim b As Single = Console.ReadLine()
        Console.Write("C: ")
        Dim c As Single = Console.ReadLine()

        Dim d As Single = b ^ 2 - 4 * a * c
        If d < 0 Then
            Console.WriteLine("No real roots.")
        Else
            Console.Write("Root(s): " & (-b + Math.Sqrt(d)) / 2)
            If d > 0 Then Console.Write(", " & (-b - Math.Sqrt(d)) / 2)
            Console.WriteLine()
        End If

        Console.ReadLine()
    End Sub

End Module
