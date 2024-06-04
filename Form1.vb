Public Class Form1
    Private Sub btnCheckDelievery_Click(sender As Object, e As EventArgs) Handles btnCheckDelievery.Click
        Dim numOfItems As Double

        numOfItems = txtnumber.Text

        If numOfItems <= 20 Then
            MsgBox("Scooter Delivery ")

        ElseIf numOfItems <= 50 Then
            MsgBox("Car Delivery ")


        ElseIf numOfItems <= 100 Then
            MsgBox("Come collect ")
                End If
    End Sub
End Class
