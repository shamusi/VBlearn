
Module Module1

    Sub Main()

        'Dim MyCar As New CAR()

        'Dim mymake As String
        'mymake = Console.ReadLine()
        'MyCar.make = "KIA"

        'MyCar.Model = "SUV"
        'MyCar.color = "Blue"
        'MyCar.Year = 1920

        Dim myCar As New CAR("Hyndia ", "4 runner", 2010, "white")
        carlot.Addtoinv(myCar)

        Console.WriteLine("{0} {1} {2}", myCar.make.ToString, dMv("ll"), myCar.color)
        Console.WriteLine("{0} {1} {2}", MyCar.make.ToString, dMv("ll"), MyCar.makevalue(2000))
        'Console.WriteLine(MyCar.Year)
        Console.ReadLine()
    End Sub

    Function dMv(ByVal mycarw As Char) As Decimal

        Return 100.0
    End Function




End Module
