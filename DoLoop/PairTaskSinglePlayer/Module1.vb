Module Module1

    Sub Main()
        Dim fevers(6) As Single
        Dim ir As Boolean
        Dim over As Integer
        For i = 0 To 5
            Do
                Console.Write("Enter patient temperature: ")
                fevers(i) = Console.ReadLine()
                ir = (fevers(i) >= 30) And (fevers(i) <= 44)
                If ir Then
                    If ir > 37 Then over += 1
                Else
                    Console.WriteLine("PATIENT TEMPERATURE OUT OF RANGE!!")
                End If
            Loop Until ir
        Next
        Console.WriteLine("Incidence of fever: {0}, average temperature: {1}", over, fevers.Average())
        Console.ReadLine()
    End Sub

End Module
