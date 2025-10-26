Public Class sidebar
    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        While (Form1.Sidebar1.Width < 440)
            Form1.Sidebar1.Width += 5
            btnForward.Visible = False
            btnBackward.Visible = True
        End While

    End Sub

    Private Sub BtnBackward_Click(sender As Object, e As EventArgs) Handles btnBackward.Click
        While (Form1.Sidebar1.Width > 59)
            Form1.Sidebar1.Width -= 5
            btnForward.Visible = True
            btnBackward.Visible = False
        End While
    End Sub
End Class
