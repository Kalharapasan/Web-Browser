Public Class Bookmarks
    Private Sub SqlabC_ButtonB1_Click(sender As Object, e As EventArgs) Handles SqlabC_ButtonB1.Click
        ListBox1.Items.Clear()

    End Sub

    Private Sub Bookmarks_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim WB As CustomBrowser = Form1.TabControl1.SelectedTab.Tag
        WB.Navigate(ListBox1.SelectedItem)
    End Sub
End Class