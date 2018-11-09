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
        Dim dteresult As Date
        'get the current date and time
        dteresult = #2/28/2018#


        'display the result
        MessageBox.Show(dteresult.AddMonths(6))

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


    End Sub
End Class
