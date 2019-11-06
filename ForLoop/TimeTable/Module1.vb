Module Module1

    Sub Main()
        Console.Write("Enter a number: ")
        Dim num As Integer = Console.ReadLine()
        Console.Write("How many times do u want me to yell? ")
        Dim yell As Integer = Console.ReadLine()
        For i = 1 To yell
            Console.WriteLine("{0} x {1} = {2}", num, i, num * i)
        Next
        Console.ReadLine()
    End Sub

End Module
