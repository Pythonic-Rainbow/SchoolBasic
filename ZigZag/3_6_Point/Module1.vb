Module Module1

    Sub Main()
        Console.Write("Enter the wins of the team ")
        Dim wins As Integer = Console.ReadLine()
        Console.Write("Enter the draws of the team ")
        Dim draws As Integer = Console.ReadLine()
        Console.Write("Enter the loses of the team")
        Dim loses As Integer = Console.ReadLine()

        Console.WriteLine("The points of the team is " & (wins * 3 + draws))

        Console.ReadLine()
    End Sub

End Module
