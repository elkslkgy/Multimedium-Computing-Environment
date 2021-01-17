Public Class Form1
    Dim loop_or_not As Boolean
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        TextBox1.Text = System.IO.Path.GetDirectoryName(ListBox2.SelectedItem)
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        loop_or_not = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        TextBox1.Text = ListBox2.SelectedItem
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonResume.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonPre.Click
        If ListBox1.SelectedIndex <= 0 Then
            MsgBox("No song", MsgBoxStyle.OkOnly, "Error")
            'AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            Try
                ListBox1.SelectedIndex += -1
                ListBox2.SelectedIndex += -1
                AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
                TextBox1.Text = System.IO.Path.GetFileName(ListBox1.SelectedItem)
                Timer1.Stop()

            Catch ex As Exception

            End Try
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Timer1.Start()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonNex.Click
        Try
            ListBox1.SelectedIndex += +1
            ListBox2.SelectedIndex += +1
            AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
            TextBox1.Text = System.IO.Path.GetFileName(ListBox1.SelectedItem)
            Timer1.Stop()

        Catch ex As Exception
            MsgBox("No song", MsgBoxStyle.OkOnly, "Error")

        End Try
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        Timer1.Start()

    End Sub

    Private Sub ButtonLoop_Click_1(sender As Object, e As EventArgs) Handles ButtonLoop.Click
        If loop_or_not = True Then
            ButtonLoop.Text = "單曲播放"
            AxWindowsMediaPlayer1.settings.setMode("loop", False)
            loop_or_not = False
        Else
            ButtonLoop.Text = "單曲循環"
            AxWindowsMediaPlayer1.settings.setMode("loop", True)
            loop_or_not = True
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar2.Value
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each track In OpenFileDialog1.FileNames
            ListBox2.Items.Add(System.IO.Path.GetFileName(track))
        Next
        For Each track In OpenFileDialog1.FileNames
            ListBox1.Items.Add(track)
        Next
        ListBox2.SelectedIndex = -1
        ListBox1.SelectedIndex = -1
        TextBox1.Text = System.IO.Path.GetFileName(ListBox1.SelectedItem)
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If AxWindowsMediaPlayer1.currentMedia Is Nothing Then
            Return
        End If
        TrackBar2.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
        Dim elt As TimeSpan = New TimeSpan(0, 0, AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)
        Dim elt2 As TimeSpan = New TimeSpan(0, 0, AxWindowsMediaPlayer1.currentMedia.duration)
        Label3.Text = elt.Minutes & ":" & elt.Seconds & "/" & elt2.Minutes & ":" & elt2.Seconds
        TrackBar2.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
        TextBox1.Text = ListBox2.SelectedItem
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
        Dim elt As TimeSpan = New TimeSpan(0, 0, AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)
        Dim elt2 As TimeSpan = New TimeSpan(0, 0, AxWindowsMediaPlayer1.currentMedia.duration)
        Label3.Text = elt.Minutes & ":" & elt.Seconds & "/" & elt2.Minutes & ":" & elt2.Seconds
    End Sub

End Class
