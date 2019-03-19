Public Class Form1

    Private Sub btnsubString_Click(sender As Object, e As EventArgs) Handles btnsubString.Click
        'declear varable
        'Dim strResult As String
        '' Get the text from the textbox
        'strResult = txtString.Text

        ''dispaly the first three characters
        'MessageBox.Show(strResult.Substring(0, 3), "strings")

        ''display the middle 3 characters
        'MessageBox.Show(strResult.Substring(3, 3), "string")

        ''display the last 3 characters
        'MessageBox.Show(strResult.Substring(strResult.Length - 3), "string")
        '********************************************************
        '' declsear varable
        'Dim dblnumbers As Double
        'Dim secdblnumber As Double
        ''set numbers, divide nu, and dispaly resultd
        'secdblnumber = 34.567776
        'dblnumbers = 12
        'dblnumbers /= 7
        ''display the resultts witout formating
        'MessageBox.Show("division" & dblnumbers.ToString, "floting point")

        ''display string in format
        'MessageBox.Show("division" & String.Format("{1:n3}", secdblnumber, dblnumbers), "floting point")
        '***********************************************************
        ''declear varable
        'Dim strData As String
        'Dim strresult As String

        ''get the text from the textbox
        'strData = txtString.Text

        ''replace the string
        'strresult = strData.Replace("Hello", "Goodbye")

        ''display
        'MessageBox.Show(strresult, "string")

        '**************************************************************************

        ' delcear variable
        'Dim dteresult As Date
        ''get the current date and time
        'dteresult = #2/28/2018#


        'display the result
        'MessageBox.Show(dteresult.AddMonths(6))

        ''display the result
        'MessageBox.Show(dteresult.Month, "Date demo")
        ''display the result
        'MessageBox.Show(dteresult.Day, "Date demo")
        ''display the result
        'MessageBox.Show(dteresult.Year, "Date demo")
        ''display the result
        'MessageBox.Show(dteresult.Hour, "Date demo")
        'MessageBox.Show(dteresult.Minute, "Date demo")
        ''display the result
        'MessageBox.Show(dteresult.Second, "Date demo")
        'MessageBox.Show(dteresult.DayOfWeek, "Date demo")
        ''display the result
        'MessageBox.Show(dteresult.DayOfYear, "Date demo")
        '*************************************************************
        ''declare varable
        'Dim intNumber As Integer

        'Try
        '    'get the number from the textbox
        '    'intNumber = CType(txtString.Text, Integer)
        '    intNumber = txtString.Text
        'Catch ex As Exception
        '    Exit Sub
        'End Try

        ''is less than 27
        'If intNumber < 27 Then
        '    MessageBox.Show("yes it less")
        'Else
        '    MessageBox.Show("it more than 27")
        'End If
        '*********************************
        'caculate raduis

        'Dim dblarea As Double

        ''calculate the area of the circle
        'dblarea = CalculateAreaFromRaduis(100)

        ''displayu box
        'MessageBox.Show(dblarea.ToString, "Area of 100")


        '' Declare Varable
        'Dim strName As String

        ''Get the Name
        'strName = txtString.Text

        ''compare the name
        'If String.Compare(strName, "BRYAN", True) = 0 Then
        '    MessageBox.Show("Hello bryan")
        'End If

        ' Declear varable
        Dim intCount As Integer

        'clear the list
        clearlist()

        'perform a loop
        For intCount = 15 To 1 Step -2
            'add the item to the list
            lstData.Items.Add("i am item" & intCount.ToString & " in the list")
        Next

    End Sub
    Private Sub clearlist()
        'clear lsit
        lstData.Items.Clear()
    End Sub

    Private Sub lstData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged

        '' delcare varable

        'Dim strName As String

        'Dim strFC As String

        ''get the selected name\
        'strName = lstData.Items(lstData.SelectedIndex).ToString

        'Select Case strName
        '    Case "BRYAN", "John", "Max"
        '        strFC = "Red"
        '    Case "Samson", "Sola"
        '        strFC = "yellow"
        '    Case "Jennifer"
        '        strFC = "pink"
        '    Case Else
        '        MessageBox.Show("I dont know this person color")

        'End Select
        'MessageBox.Show(strName & "favorite coloe is" & strFC, "Select Demo")
    End Sub

    'calculate radius
    'Private Function CalculateAreaFromRaduis(ByRef raduis As Double) As Double
    '    'declear
    '    Dim dblRaduis As Double
    '    Dim dblresult As Double

    '    'square thge reduis
    '    dblRaduis = raduis * raduis

    '    'Multyply it pi
    '    dblresult = dblRaduis * Math.PI

    '    'retuen result
    '    Return dblresult

    'End Function



End Class
