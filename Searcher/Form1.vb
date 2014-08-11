Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("iexplore", "http://www.google.com/search?hl=en&q=" + TextBox1.Text + "&aq=f&oq=")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("iexplore", "http://www.youtube.com/results?search_type=&search_query=" + TextBox1.Text + "&aq=f")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Searcher enables you to quickly perform searches on Google & YouTube." & vbCrLf & vbCrLf & _
               "Programmed by Victoria." & vbCrLf & vbCrLf & _
               "August 2010")
    End Sub
End Class
