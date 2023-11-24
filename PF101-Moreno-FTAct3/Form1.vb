Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Me.IsMdiContainer = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MonthCalendar.SetDate(TextBox1.Text)
    End Sub

End Class
