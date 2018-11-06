Public Class Form1

    Private Sub btnIntMath_Click(sender As Object, e As EventArgs) Handles btnIntMath.Click
        'Set number , divide numbers, and display results
        Dim intNumber = 12
        intNumber += 6
        MessageBox.Show("Division test." & intNumber.ToString, "Interger Math")
    End Sub
End Class
