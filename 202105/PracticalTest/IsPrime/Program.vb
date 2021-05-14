Module Program
    Sub Main()
        Dim cont = True

        Do While cont
            Console.Write("Enter a number: ")
            Dim num As UInt64 = Console.ReadLine()
            If num <= 1 Then
                Console.WriteLine("Not greater than 1")
            Else
                Dim isPrime = True
                For index = 2 To num - 1
                    If num Mod index = 0 Then
                        Console.WriteLine("Is not prime")
                        isPrime = False
                        Exit For
                    End If
                Next
                If isPrime Then
                    Console.WriteLine("Is prime")
                End If
            End If
            Console.Write("Continue? (Y/N) ")
            Dim ContInput = Console.ReadLine()
            If ContInput.ToUpper() = "N" Then
                cont = False
            End If
        Loop
    End Sub
End Module
