Public Class Menu
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        rmMenu.ShowPopup(btnMenu.Location)
    End Sub
End Class