Module Module1

    Sub Main()
        Const ans As Char = "c"
        Dim input As Char = "y"
        Do While input = "y"
            Console.WriteLine("What is the command keyword to exit a loop in VB.NET?")
            Console.WriteLine("a. int")
            Console.WriteLine("b. continue")
            Console.WriteLine("c. break")
            Console.WriteLine("d. Exit For/Exit While/Exit Do While")
            Console.Write("Enter your choice:")
            input = LCase(Console.ReadKey().KeyChar)
            Console.WriteLine()
            If input = ans Then
                Console.WriteLine("Correct!")
            Else Console.WriteLine("Incorrect!")
            End If
            Console.Write("Again? Press y to conitnue: ")
            input = LCase(Console.ReadKey().KeyChar)
            Console.WriteLine()
        Loop
    End Sub

End Module
