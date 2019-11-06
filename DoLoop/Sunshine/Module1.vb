Module Module1

    Sub Main()
        Dim sunshine, maxHours, totalSunshine As Integer
        Dim minHours As Integer = 100

        Do
            Console.Write("Enter sunshine: ")
            sunshine = Console.ReadLine()
            If sunshine > maxHours Then maxHours = sunshine
            If (sunshine < minHours) And (sunshine <> -1) Then minHours = sunshine
            totalSunshine += sunshine
        Loop Until sunshine = -1
        Console.WriteLine("Max sunshine hours: " & maxHours)
        Console.WriteLine("Min sunshine hours: " & minHours)
        Console.WriteLine("Total sunshine hours: " & totalSunshine)
        Console.ReadLine()
    End Sub

End Module
