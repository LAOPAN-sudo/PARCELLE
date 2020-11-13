Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RedemptionProgressBar1.Value = RedemptionProgressBar1.Value + 3
        FlatLabel4.Text = RedemptionProgressBar1.Value & " %"
        If (RedemptionProgressBar1.Value = 100) Then
            Timer1.Enabled = False
            Form11.Show()
            Form2.Show()
            Me.Hide()

        End If
    End Sub
End Class
