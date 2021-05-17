Module Program
    Sub Main()
        Console.Write("Enter a decimal integer: ")
        Dim dec As Integer = Console.ReadLine()

        Do While dec > 1
            Dim remainder = dec >> 1
            Console.Write(dec - (remainder << 1))
            dec = remainder
        Loop
        Console.WriteLine(dec)
    End Sub
End Module
