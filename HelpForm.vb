Public Class HelpForm

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X + 650, Form1.Location.Y - 7)
    End Sub

End Class