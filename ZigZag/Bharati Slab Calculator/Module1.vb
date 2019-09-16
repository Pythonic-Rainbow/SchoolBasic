Module Module1

    Sub Main()
        'code for Bharatis's Slab Calculator
        'by Howard Wong 16/09/19

        Dim wide, deep, no_of_stabs As Integer
        Dim slab_cost, total_cost As Single

        Console.WriteLine("Bharati's Slab Calculator")
        Console.WriteLine("by Howard Wong, 16/09/19")
        Console.WriteLine("press <ENTER> to continue")
        Console.ReadLine()
        Console.Clear()

        wide = InputBox("How many slabs wide? ")
        deep = InputBox("How many slabs deep? ")
        slab_cost = InputBox("Cost of one slab? ")
        no_of_stabs = wide * deep
        total_cost = no_of_stabs * slab_cost
        Console.WriteLine(no_of_stabs & " slabs required")
        Console.WriteLine("Total cost will be " & Format(total_cost, "currency"))

        Console.ReadLine()
    End Sub

End Module
