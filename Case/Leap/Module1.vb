Module Module1

    Sub Main()
        Console.Write("Enter a year: ")
        Dim year As Integer = Console.ReadLine()
        Select Case year Mod 4
            Case 0
                Select Case year Mod 400
                    Case 0
                        Console.WriteLine("400 leap")
                    Case Else
                        Console.WriteLine("4 leap")
                End Select
            Case Else
                Console.WriteLine("Not leap")
        End Select

        Console.ReadLine()
    End Sub

End Module
