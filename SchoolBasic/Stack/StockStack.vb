Public Class StockStack
    Private ReadOnly stocks As Dictionary(Of UInteger, Stack(Of String)) = New Dictionary(Of UInteger, Stack(Of String))

    Private Function EnterItemID()
        Console.Write("Enter item ID: ")
        Return UInteger.Parse(Console.ReadLine())
    End Function

    Sub AddStock()
        Dim id As UInteger = EnterItemID()
        Console.Write("Enter serial number: ")
        Dim serial As String = Console.ReadLine()
        If Not stocks.ContainsKey(id) Then stocks.Add(id, New Stack(Of String))
        stocks(id).Push(serial)
        Console.WriteLine("Registered the item. Stock available: " & stocks(id).Count)
    End Sub
    Sub RemoveStock()
        Dim id As UInteger
        Do
            id = EnterItemID()
            If Not stocks.ContainsKey(id) Then Console.WriteLine("There is no such item!")
        Loop Until stocks.ContainsKey(id)
        Dim serial As String = stocks(id).Peek()
        stocks(id).Pop()
        Console.WriteLine("{0} is sold. Remaining stock of item {1}: {2}", serial, id, stocks(id).Count)
    End Sub
End Class
