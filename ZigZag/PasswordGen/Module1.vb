Module Module1

    Sub Main()
        Console.WriteLine("Password generator")
        Console.Write("Press <Enter> to begin")
        Console.ReadLine()
        Console.Write("First name? ")
        Dim fname As String = Mid(Console.ReadLine(), 1, 1)
        Console.Write("Second name? ")
        Dim sname As String = Mid(Console.ReadLine(), 2)
        Console.Write("Year of birth? ")
        Dim year As Integer = Int(Mid(Console.ReadLine(), 3, 2))
        Console.Write("Favourite colour? ")
        Dim colour As String = Console.ReadLine()
        colour = Mid(colour, Len(colour) - 1, 2)
        Console.Write("Street name? ")
        Dim street As String = Mid(Console.ReadLine(), 1, 3)
        Console.Write("Shoe size? ")
        Dim size As Single = Console.ReadLine()

        Console.WriteLine("Your password is " & fname & sname & year & colour & street & size)

        Console.ReadLine()
    End Sub

End Module
