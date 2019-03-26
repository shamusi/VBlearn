Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Threading
Imports System.IO
Module Module1

    Sub Main()

        Dim car1 As CAR = New CAR()
        car1.make = "oldmobile"
        car1.Model = "cutlas supreme"

        Dim car2 As CAR = New CAR()
        car2.make = "geo"
        car2.Model = "Prism"

        Dim b1 As BOOK = New BOOK()
        b1.Author = "Robert Tabor"
        b1.title = "Microsoft book"
        b1.ISBN = "0-000-00000-0"

        'Dim myarraylist As New System.Collections.ArrayList()
        'myarraylist.Add(car1)
        'myarraylist.Add(car2)
        ''myarraylist.Add(b1)
        ''myarraylist.Remove(car2)


        'For Each item In myarraylist
        '    Console.WriteLine(item.make)
        '    Console.WriteLine(item.Model)
        'Next
        '--------------------------------------------

        'Dim mylist As List(Of CAR) = New List(Of CAR)

        'mylist.Add(car1)
        'mylist.Add(car2)

        'For Each items As CAR In mylist
        '    Console.WriteLine(items.make)
        '    Console.WriteLine(items.Model)
        'Next
        '----------------
        'Dim mydic As Dictionary(Of String, CAR) = New Dictionary(Of String, CAR)

        'mydic.Add(car1.make, car1)
        'mydic.Add(car1.Model, car1)

        'Console.WriteLine(mydic("geo").Model)




        'Dim name() As String = {"sam", "john", "lasisi"}

        'Dim mycar As New CAR With
        '    {
        '    .make = "BMW",
        '    .Model = "4584"
        '}

        '----------------------------------
        'Dim mylistofcars As New List(Of CAR) From {
        'New CAR With {.make = "russiacar", .Model = "F56"},
        'New CAR With {.make = "Koreancar", .Model = "I987"},
        'New CAR With {.make = "amerincar", .Model = "HJHG6"}}

        'For Each items As CAR In mylistofcars
        '    Console.WriteLine(items.make)
        'Next

        '---------------------------------



        Console.WriteLine()
        Console.ReadLine()

    End Sub


    'Class Program
    '    Class ThreadParams
    '        Public Property sourceFileName As String
    '        Public Property targetFileName As String
    '    End Class

    '    Private Shared Sub Main(ByVal args As String())
    '        Dim tParams As ThreadParams = New ThreadParams()
    '        tParams.sourceFileName = args(0).ToString()
    '        tParams.targetFileName = args(1).ToString()
    '        ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf copyFileThreadPool), tParams)
    '        Console.ReadKey()
    '    End Sub

    '    Private Shared Sub copyFileThreadPool(ByVal tParams As Object)
    '        Dim tParamsInner As ThreadParams = TryCast(tParams, ThreadParams)
    '        Dim sourceFileName As String = tParamsInner.sourceFileName
    '        Dim targetFileName As String = tParamsInner.targetFileName
    '        Console.WriteLine()
    '        Console.WriteLine("File Copy Operation using the ThreadPool Class")
    '        Console.WriteLine()
    '        Console.WriteLine("File to copy: " & sourceFileName)
    '        Dim sr As StreamReader = New StreamReader(sourceFileName)
    '        Dim totalLines As Single = File.ReadLines(sourceFileName).Count()
    '        sr.Close()
    '        Dim line As String = ""
    '        Dim progress As Single = 0
    '        Console.WriteLine()
    '        Console.WriteLine("Copying file...")
    '        Dim count As Integer = 0

    '        Using reader As StreamReader = New StreamReader(tParamsInner.sourceFileName)
    '            Dim writer As StreamWriter = New StreamWriter(targetFileName)

    '            While (CSharpImpl.__Assign(line, reader.ReadLine())) IsNot Nothing
    '                count += 1

    '                If count <> totalLines Then
    '                    writer.WriteLine(line)
    '                Else
    '                    writer.Write(line)
    '                End If

    '                progress = (count / totalLines) * 100
    '                Console.WriteLine("Progress: " & Math.Round(progress, 2).ToString() & "% (rows copied: " & count.ToString() & ")")
    '            End While

    '            writer.Close()
    '        End Using

    '        Console.WriteLine()
    '        Console.WriteLine("Original File: " & sourceFileName)
    '        Console.WriteLine("New File: " & targetFileName)
    '        Console.WriteLine()
    '        Console.WriteLine("press any key to exit...")
    '    End Sub

    '    Private Class CSharpImpl
    '        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
    '        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
    '            target = value
    '            Return value
    '        End Function
    '    End Class
    'End Class

End Module
