Imports SchoolBasic.api
Module HashTableImpl
    Sub Main()
        Dim hashTable As HashTable = New HashTable()
        Dim key As Char = ""
        Do Until key = "n" Or key = "N"
            Console.Write("Enter name: ")
            Dim input As String = Console.ReadLine()
            hashTable.Add(input)
            Console.Write("Continue? (Y/N)")
            key = Console.ReadKey().KeyChar
            Console.WriteLine()
        Loop
        For Each k In hashTable.GetHashTable().Keys
            Console.WriteLine(k + ":")
            For Each value In hashTable.GetHashTable()(k)
                Console.WriteLine("    " + value)
            Next
        Next
        Console.ReadLine()
    End Sub

End Module
