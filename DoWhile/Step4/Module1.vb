Module Module1

    Sub Main()
        Dim i As Integer = 0
        Do While i < 48
            Console.Write(i & " ")
            i += 4
        Loop
        Console.WriteLine(vbCrLf & "Counting Stopped at: " & i)
        Console.ReadLine()
    End Sub

End Module
