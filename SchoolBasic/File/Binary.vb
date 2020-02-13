Imports System.IO

Public Module Binary
    Sub Name()
        Dim path As String = "testBin.bin"
        Dim fs As FileStream = Nothing
        Try
            fs = New FileStream(path, FileMode.CreateNew)
        Catch ex As ArgumentException
            Console.WriteLine("Invalid file path")
        Catch ex As IOException
            If ex.Message.Contains("exists") Then
                fs = New FileStream(path, FileMode.Create)
            ElseIf ex.Message.Contains("open") Then
                Console.WriteLine("The file is already opened. Please close it first.")
            End If
        End Try
        Dim bw As BinaryWriter = New BinaryWriter(fs)

        Dim initial, sur As String
        Dim age As Integer

        Console.WriteLine("Data Entry")
        Console.WriteLine()
        Console.WriteLine("Enter the initial: ")
        initial = Console.ReadLine()
        Console.WriteLine("Enter the surname: ")
        sur = Console.ReadLine()
        Console.WriteLine("Enter the age: ")
        age = Console.ReadLine()

        bw.Write(initial)
        bw.Write(sur)
        bw.Write(age)

        bw.Close()
        fs.Close()
        Console.WriteLine()
        Console.WriteLine("Data Entry Complete.Press Enter To Continue")
        Console.ReadLine()

        Dim fs1 As FileStream = New FileStream(path, FileMode.Open)
        Dim br As BinaryReader = New BinaryReader(fs1)
        initial = br.ReadString()
        Console.WriteLine("Initial: {0}", initial)

        sur = br.ReadString()
        Console.WriteLine("Surname: {0}", sur)

        age = br.ReadInt32()
        Console.WriteLine("Age: {0}", age)

        br.Close()
        fs.Close()
        Console.WriteLine("All Data Read.")
        Console.ReadLine()
    End Sub

    Sub CSVToBin()
        Const path = "9.1.1 NewTable.csv"
        Dim reader As StreamReader = New StreamReader(path)
        Dim writer As BinaryWriter = New BinaryWriter(New FileStream("NewTable.bin", FileMode.OpenOrCreate))
        Do While Not reader.EndOfStream
            Dim record As String = reader.ReadLine()
            Dim table As NewTable = New NewTable(record)
            writer.Write(record)
        Loop
        writer.Close()
        Using br As BinaryReader = New BinaryReader(New FileStream("NewTable.bin", FileMode.Open))
            Do While (br.BaseStream.Position <> br.BaseStream.Length)
                Dim table As NewTable = New NewTable(br.ReadString())
                Console.WriteLine("Firstname: " & table.FirstName)
                Console.WriteLine("Surname: " & table.Surname)
                Console.WriteLine("Address: " & table.Address)
                Console.WriteLine("Postcode: " & table.Postcode & vbCrLf)
            Loop
        End Using
    End Sub

    Friend Class NewTable
        Property FirstName As String
        Property Surname As String
        Property Address As String
        Property Postcode As String

        Sub New(ByVal record As String)
            Dim props() = record.Split(",")
            FirstName = props(0)
            Surname = props(1)
            Address = props(2)
            Postcode = props(3)
        End Sub
    End Class

End Module

