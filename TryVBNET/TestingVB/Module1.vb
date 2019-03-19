Module Module1

    Sub Main()
        ' this is my first
        Dim mytest As String = "My name is Shamusi"

        Dim CA() As Char = mytest.ToCharArray
        Array.Reverse(CA)

        For i = 0 To CA.Length - 1
            Console.WriteLine(CA(i))
        Next

        Console.Read()
    End Sub

End Module
