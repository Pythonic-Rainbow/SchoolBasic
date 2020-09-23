Public Class StockStack
    Property Stocks As Dictionary(Of UInteger, Stack(Of String)) = New Dictionary(Of UInteger, Stack(Of String))

    Private Function EnterItemID()
        Console.Write("Enter item ID: ")
        Return UInteger.Parse(Console.ReadLine())
    End Function

    Sub AddStock()
        Dim id As UInteger = EnterItemID()
        Console.Write("Enter serial number: ")
        Dim serial As String = Console.ReadLine()
        If Not Stocks.ContainsKey(id) Then Stocks.Add(id, New Stack(Of String))
        Stocks(id).Push(serial)
        Console.WriteLine("Registered the item. Stock available: " & Stocks(id).Count)
    End Sub
    Sub RemoveStock()
        Dim id As UInteger
        Do
            id = EnterItemID()
            If Not Stocks.ContainsKey(id) Then Console.WriteLine("There is no such item!")
        Loop Until Stocks.ContainsKey(id)
        If Stocks(id).Count = 0 Then
            Console.Error.WriteLine("There is no stock left!")
        Else
            Dim serial As String = Stocks(id).Peek()
            Stocks(id).Pop()
            Console.WriteLine("{0} is sold. Remaining stock of item {1}: {2}", serial, id, Stocks(id).Count)
        End If
    End Sub
End Class
