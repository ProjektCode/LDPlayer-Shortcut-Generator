Public Class Form1
    Dim ImagePath As String
    Dim Desc As String
    Private Sub pb_Close_Click(sender As Object, e As EventArgs) Handles pb_Close.Click
        Me.Close()
    End Sub

    Private Sub pb_Min_Click(sender As Object, e As EventArgs) Handles pb_Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnIcon_Click(sender As Object, e As EventArgs) Handles btnIcon.Click
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        If ofd.ShowDialog = DialogResult.OK Then
            ImagePath = ofd.FileName
            pb1.BackgroundImage = CreateShortcut.ResizeImage(New Bitmap(ImagePath)).Result
        Else
            MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtIndex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIndex.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If pb1.BackgroundImage Is Nothing Or txtName.Text = String.Empty Or txtPackage.Text = String.Empty Or txtIndex.Text = String.Empty Or txtWorking.Text = String.Empty Then
            MessageBox.Show("Please make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If txtDesc.Text = String.Empty Then
            Desc = Nothing
        Else
            Desc = txtDesc.Text
        End If

        Dim shortcut As New ShortCutInfo With {
            .Image = pb1.BackgroundImage,
            .PackageName = txtPackage.Text,
            .Name = txtName.Text,
            .Index = Convert.ToInt32(txtIndex.Text),
            .WorkingDirectory = txtWorking.Text,
            .Description = txtDesc.Text
        }

        CreateShortcut.Create(shortcut)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        If Application.OpenForms.OfType(Of HelpForm).Count = 1 Then
            HelpForm.Close()
        Else
            HelpForm.Show()
        End If
    End Sub

    Private Sub pb_Close_MouseEnter(sender As Object, e As EventArgs) Handles pb_Close.MouseEnter
        pb_Close.BackColor = Color.DarkRed
    End Sub

    Private Sub pb_Close_MouseLeave(sender As Object, e As EventArgs) Handles pb_Close.MouseLeave
        pb_Close.BackColor = Color.Crimson
    End Sub

    Private Sub pb_Min_MouseEnter(sender As Object, e As EventArgs) Handles pb_Min.MouseEnter
        pb_Min.BackColor = Color.DarkRed
    End Sub

    Private Sub pb_Min_MouseLeave(sender As Object, e As EventArgs) Handles pb_Min.MouseLeave
        pb_Min.BackColor = Color.Crimson
    End Sub

End Class
