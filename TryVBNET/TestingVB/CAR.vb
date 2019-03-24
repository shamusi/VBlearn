Public Class CAR

    Public Property make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property color As String

    Public Function makevalue(year As Integer) As Decimal

        Dim carvalue As Decimal
        If year > 1990 Then
            carvalue = 1000.0
        Else
            carvalue = 20000.0
        End If
        Return carvalue
    End Function


    Public Sub New()
        make = "NiSSAN"
    End Sub

    Public Sub New(ByVal makevalue As String,
                   ByVal modelvalue As String,
                   ByVal yearvalue As Integer,
                   ByVal colorvalue As String)

        make = makevalue
        Model = modelvalue
        Year = yearvalue
        color = colorvalue
    End Sub



End Class
Public Class carlot
    Public Shared Sub Addtoinv(ByVal newcar As CAR)


    End Sub
End Class