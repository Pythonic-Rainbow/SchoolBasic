Module Module1

    Sub Main()
        Randomize()
        Dim num As Integer = Int(Rnd() * 10) + 1
        Dim low As Integer = 0
        Dim tries As Integer = 0
        Dim high As Integer = 100
        Dim input As Integer
        Dim finish As Boolean = False
        Do
            Console.Write("Guess a number! ({0}-{1})", low, high)
            input = Console.ReadLine()
            If (input < 0) Or (input > 100) Then
                Console.WriteLine("Out of range!!")
            ElseIf input > num Then
                high = input
            ElseIf input < num Then
                low = input
            Else
                Console.WriteLine("Bingo!")
                finish = True
            End If
            tries += 1
        Loop Until finish
        Console.ReadLine()
    End Sub

End Module
