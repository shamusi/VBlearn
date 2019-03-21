Module Module1

    Sub Main()

        Console.WriteLine("The Name Game")

        Console.Write("what is your name")
        Dim firstname As String = Console.ReadLine()

        Console.Write("what is your last name")
        Dim secondName As String = Console.ReadLine()


        Dim charfirstname As Char()
        charfirstname = firstname.ToCharArray
        Array.Reverse(charfirstname)

        Dim charlastname As Char()
        charlastname = secondName.ToCharArray
        Array.Reverse(charlastname)

        'Console.WriteLine(charfirstname)
        'Console.WriteLine(charlastname)

        For Each items In charfirstname
            Console.WriteLine(items)

        Next




        For index = 0 To charlastname.Length - 1

            Console.WriteLine(charlastname(index))

        Next

        Console.ReadLine()




    End Sub

End Module
