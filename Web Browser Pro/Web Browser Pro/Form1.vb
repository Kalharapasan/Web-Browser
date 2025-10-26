Public Class Form1

    Public Sub AddTab(ByRef URL As String, ByRef TabControl As TabControl)
        Dim NewBrowser As New CustomBrowser
        Dim NewTab As New TabPage
        NewBrowser.Tag = NewTab
        NewTab.Tag = NewBrowser
        TabControl1.TabPages.Add(NewTab)
        NewTab.Controls.Add(NewBrowser)
        NewBrowser.Dock = DockStyle.Fill
        NewBrowser.Navigate(URL)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        AddTab("about:blank", TabControl1)

    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.GoForward()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.GoBack()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.Refresh()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.Stop()
    End Sub

    Private Sub BtnAddTab_Click(sender As Object, e As EventArgs) Handles btnAddTab.Click
        AddTab("about:blank", TabControl1)
    End Sub

    Private Sub TxtURL_TextChange(sender As Object, e As EventArgs) Handles txtURL.TextChange

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.Navigate(Me.txtURL.Text)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        Me.txtURL.Text = WB.Url.ToString
    End Sub

    Private Sub BtnRemoveTab_Click(sender As Object, e As EventArgs) Handles btnRemoveTab.Click
        If TabControl1.TabPages.Count = 1 Then
            Me.Close()
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        End If
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        Bookmarks.Show()
    End Sub

    Private Sub BtnBookmark_Click(sender As Object, e As EventArgs) Handles btnBookmark.Click
        If Bookmarks.ListBox1.Items.Contains(txtURL.Text) Then
            Try
                Bookmarks.ListBox1.Items.Remove(txtURL.Text.ToString)

            Catch ex As Exception
                Bookmarks.ListBox1.Items.Clear()
                MsgBox("Sorry, There was an unexpected Error. All the Bookmarks are Cleard", MsgBoxStyle.Information, "Info")
            End Try
        Else
            Try
                Bookmarks.ListBox1.Items.Add(txtURL.Text.ToString)

            Catch ex As Exception
                Bookmarks.ListBox1.Items.Clear()
                MsgBox("Sorry, There was an unexpected Error. All the Bookmarks are Cleard", MsgBoxStyle.Information, "Info")
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Bookmarks.ListBox1.Items.Contains(txtURL.Text) Then
            btnBookmark.Image = My.Resources.star_512px
        Else
            btnBookmark.Image = My.Resources.star_60px
        End If
    End Sub
End Class

Public Class CustomBrowser
    Inherits WebBrowser

    Public Sub New()
        Me.ScriptErrorsSuppressed = True

    End Sub

    Private Sub DocCompleted() Handles Me.DocumentCompleted
        Dim TP As TabPage = Me.Tag
        If Me.DocumentTitle.Length > 15 Then
            TP.Text = Me.DocumentTitle.Substring(0, 14) & "..."
        Else
            TP.Text = Me.DocumentTitle

        End If
    End Sub
End Class
