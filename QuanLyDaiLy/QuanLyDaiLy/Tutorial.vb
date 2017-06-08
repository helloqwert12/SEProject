
Public Class Tutorial
    Dim index As Integer
    Public Sub New()
        InitializeComponent()
        index = 0
        Panel1.BackgroundImage = Imagelist.Images(index)

    End Sub

    Private Sub btnSau_Click(sender As Object, e As EventArgs) Handles btnSau.Click
        If (index = Imagelist.Images.Count - 1) Then
            btnSau.Enabled = False
        Else
            index = index + 1
        End If
        Panel1.BackgroundImage = Imagelist.Images(index)
    End Sub

    Private Sub btnTruoc_Click(sender As Object, e As EventArgs) Handles btnTruoc.Click
        If (index = 0) Then
            btnTruoc.Enabled = False
        Else
            index = index - 1
        End If
        Panel1.BackgroundImage = Imagelist.Images(index)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Application.Exit()
    End Sub
End Class