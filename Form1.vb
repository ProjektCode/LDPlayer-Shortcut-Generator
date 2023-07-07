Imports System.Net.Http
Imports System.IO
Imports HtmlAgilityPack
Imports Microsoft.Win32
Imports System.Threading

Public Class Form1
    ReadOnly AppList As New List(Of String)
    ReadOnly AppNameList As New List(Of String)
    ReadOnly ImageList As New List(Of String)

    Dim AppText As String

    Dim AppName As String
    Dim AppDir As String
    Dim AppPackage As String
    Dim AppIndex As Integer

    'Dim ImageSet As Boolean
    'Dim ImageURL As String
    Dim ImagePath As String

    Dim dir As String

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim installDir As String = If(Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\XuanZhi\LDPlayer9", "InstallDir", String.Empty), String.Empty)
        If installDir Is String.Empty Then
            MessageBox.Show("LDPlayer Can not be found")
        Else
            txtWorking.Text = installDir
            txtWorking.Enabled = False
            txtIndex.Enabled = False
            txtName.Enabled = False
            txtPackage.Enabled = False

            AppDir = installDir
            AppIndex = 0

            AppText = File.ReadAllText(installDir + "AppNames.text")
            txtIndex.Text = AppIndex.ToString
            GrabGames()

            'cbGames.SelectedIndex = 0
            'pb1.Load(GrabGoogleImage(AppList(cbGames.SelectedIndex)))

            Await DownloadGoogleImages()
        End If

    End Sub


    Private Sub pb_Close_Click(sender As Object, e As EventArgs) Handles pb_Close.Click
        pb1.BackgroundImage = Nothing
        For Each i In ImageList
            File.Delete(i)
        Next

        Me.Close()
    End Sub

    Private Sub pb_Min_Click(sender As Object, e As EventArgs) Handles pb_Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Async Sub btnIcon_ClickAsync(sender As Object, e As EventArgs) Handles btnIcon.Click
        pb1.ImageLocation = Nothing
        pb1.Image = Nothing
        pb1.BackgroundImage = Nothing

        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        If ofd.ShowDialog = DialogResult.OK Then
            ImagePath = ofd.FileName
            pb1.BackgroundImage = Await CreateShortcut.ResizeImage(New Bitmap(ImagePath))
            'pb1.Image = Await CreateShortcut.ResizeImage(New Bitmap(ImagePath))
            'ImageSet = True
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

        'If ImageSet = True Then
        '    'Await SaveImage(ImageURL)
        '    If pb1.BackgroundImage Is Nothing Then
        '        pb1.BackgroundImage = Await CreateShortcut.ResizeImage(New Bitmap(Await FetchImageAsync(ImageURL)))
        '    Else
        '        pb1.Image = Nothing
        '    End If
        '    'File.Delete(ImagePath)
        'Else
        '    MessageBox.Show("An image has not been set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        Thread.Sleep(1500)

        If cbDebug.Checked = True Then
            If AppName = Nothing Then
                MessageBox.Show("Shortcut Name Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If AppPackage = Nothing Then
                MessageBox.Show("Package Name Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If AppDir = Nothing Then
                MessageBox.Show("Working Directory Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return
        Else
            If pb1.BackgroundImage Is Nothing Or AppName = String.Empty Or AppPackage = String.Empty Or AppDir = String.Empty Then
                MessageBox.Show("Please make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        Dim Desc As String = String.Empty
        If Not txtDesc.Text = String.Empty Then
            Desc = txtDesc.Text
        End If

        Dim shortcut As New GameInfo With {
            .Image = pb1.BackgroundImage,
            .PackageName = AppPackage,
            .Name = AppName,
            .Index = AppIndex,
            .WorkingDirectory = AppDir,
            .Description = Desc
        }

        CreateShortcut.Create(shortcut)

        If CreateShortcut.Status = True Then
            MessageBox.Show(CreateShortcut.Desc, "Shortcut Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(CreateShortcut.Desc, "Shortcut Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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

    Private Sub cbWorking_CheckedChanged(sender As Object, e As EventArgs)
        If cbWorking.Checked = True Then
            txtWorking.Enabled = True
        Else
            txtWorking.Enabled = False
        End If
    End Sub

    Private Sub GrabGames()

        Dim t_AppList = AppText.Split("|").ToList()
        t_AppList.RemoveAll(Function(x) x.Contains("�"))
        Dim _Applist = t_AppList.GroupBy(Function(x) x.ToLower).Select(Function(d) d.First).ToList

        'For Each a In _AppList
        '    Dim index As Integer = a.IndexOf(":")
        '    If index >= 0 Then
        '        If Not a.Contains("android") And Not a.Contains("filemanager") Then
        '            AppList.Add(a.Substring(0, index))
        '        End If
        '    End If
        'Next

        'For Each _name In _AppList
        '    AppNameList.Add(_name.Substring(_name.IndexOf(":") + 1))
        'Next

        For Each app In _Applist
            If Not app.Contains("android") And Not app.Contains("filemanager") And Not app.Contains("com.google") Then
                If Not app = String.Empty Then

                    AppNameList.Add(app.Substring(app.IndexOf(":") + 1))

                    Dim index As Integer = app.IndexOf(":")
                    If index >= 0 Then
                        AppList.Add(app.Substring(0, index))
                    End If

                End If
            End If
        Next

        For Each a In AppNameList
            cbGames.Items.Add(a)
        Next
    End Sub

    'Private Function GrabGoogleImage(package As String)
    '    Dim web As New HtmlWeb
    '    Dim doc = web.Load($"https://play.google.com/store/apps/details?id={package}")
    '    Dim rootNode = doc.DocumentNode
    '    Dim nodes = rootNode.SelectNodes("//img")
    '    Dim img As String = String.Empty
    '    For Each i In nodes
    '        If i.Attributes("src").Value.Contains("=s48") Then
    '            'Dim list As New List(Of String)
    '            Dim _img As String = i.Attributes("src").Value
    '            img = _img.Replace("=s48", "=s128")
    '        End If
    '        'List.Add(i.Attributes("src").Value)
    '    Next
    '    ImageURL = img
    '    Return img
    'End Function

    Private Sub cbGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGames.SelectedIndexChanged
        'Dim u = GrabGoogleImage(AppList(cbGames.SelectedIndex))

        'Try
        '    pb1.Load(u)
        '    ImageSet = True
        'Catch ex As Exception
        '    ImageSet = False
        '    pb1.Load("https://i.imgur.com/Kl2Qrd2.png")
        'End Try

        Try
            pb1.BackgroundImage = Image.FromFile(dir + AppList(cbGames.SelectedIndex) + ".png")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'If ImageSet = False Then
        '    lbl_Warning.ForeColor = Color.Crimson
        '    lbl_Warning.Text = "Package Check Needed! If Okay Image Couldn't Be Found."
        '    If Not cbPackage.Checked = True Then
        '        cbPackage.Checked = True
        '    End If
        'Else
        '    lbl_Warning.ForeColor = Color.Lime
        '    lbl_Warning.Text = "Package Check Passed!"
        '    'ImageURL = u
        '    If Not cbPackage.Checked = False Then
        '        cbPackage.Checked = False
        '    End If
        'End If

        Dim _AppName = cbGames.SelectedItem.ToString
        Dim _AppPackage = AppList(cbGames.SelectedIndex)

        txtName.Text = _AppName
        txtPackage.Text = _AppPackage
        AppName = _AppName
        AppPackage = _AppPackage
    End Sub

    'Private Async Function SaveImage(_url As String) As Task
    '    Using client As New HttpClient
    '        Dim url As New Uri(_url, UriKind.Absolute)

    '        'Create file path
    '        Dim dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"temp.png")
    '        'Download image and write to file
    '        Dim ImageBytes = Await client.GetByteArrayAsync(url)
    '        File.WriteAllBytes(dir, ImageBytes)
    '        ImagePath = dir
    '    End Using
    'End Function

    Private Async Function FetchImageAsync(url As String) As Task(Of Image)
        Using client As New HttpClient
            Dim response = Await client.GetAsync(url)
            ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"temp.png")
            Dim img As Image
            If Not response.IsSuccessStatusCode Then
                Dim backupResponse = Await client.GetAsync("https://i.imgur.com/Kl2Qrd2.png")
                Dim backupStream = Await backupResponse.Content.ReadAsStreamAsync
                'Return Image.FromStream(backupStream)
                img = Image.FromStream(backupStream)
                img.Save(ImagePath)
                'ImageSet = True
                Return img
            End If

            Dim stream = Await response.Content.ReadAsStreamAsync
            'Return Image.FromStream(stream)
            img = Image.FromStream(stream)
            img.Save(ImagePath)
            'ImageSet = True
            Return img
        End Using
    End Function

    Private Async Function DownloadGoogleImages() As Task

        If Not Directory.Exists($"{AppDomain.CurrentDomain.BaseDirectory}Images\") Then
            dir = $"{AppDomain.CurrentDomain.BaseDirectory}Images\"
            Directory.CreateDirectory(dir)
        Else
            dir = $"{AppDomain.CurrentDomain.BaseDirectory}Images\"
        End If

        Try

            For Each package In AppList

                Dim web As New HtmlWeb
                Dim doc = web.Load($"https://play.google.com/store/apps/details?id={package}")
                Dim rootNode = doc.DocumentNode
                Dim nodes = rootNode.SelectNodes("//img")
                Dim img As String = String.Empty
                For Each i In nodes
                    If i.Attributes("src").Value.Contains("=s48") Then
                        'Dim list As New List(Of String)
                        Dim _img As String = i.Attributes("src").Value
                        img = _img.Replace("=s48", "=s128")
                        Exit For
                    End If
                Next

                If img = String.Empty Then
                    img = "https://i.imgur.com/Kl2Qrd2.png"
                End If

                'ImagePath = Path.Combine(dir, $"{package}.png")
                ImagePath = $"{dir}/{package}.png"
                If Not File.Exists(ImagePath) Then

                    Using client As New HttpClient
                        Dim response = Await client.GetAsync(img)
                        Dim i As Image
                        If Not response.IsSuccessStatusCode Then
                            Dim backupResponse = Await client.GetAsync("https://i.imgur.com/Kl2Qrd2.png")
                            Dim backupStream = Await backupResponse.Content.ReadAsStreamAsync
                            i = Image.FromStream(backupStream)
                            i.Save(ImagePath)
                            'ImageSet = True
                        End If

                        Dim stream = Await response.Content.ReadAsStreamAsync
                        'Return Image.FromStream(stream)
                        i = Image.FromStream(stream)
                        i.Save(ImagePath)
                        'ImageSet = True
                    End Using

                End If
                ImageList.Add(ImagePath)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AppName = txtName.Text
    End Sub

    Private Sub txtWorking_TextChanged(sender As Object, e As EventArgs) Handles txtWorking.TextChanged
        AppDir = txtWorking.Text
    End Sub

    Private Sub txtPackage_TextChanged(sender As Object, e As EventArgs) Handles txtPackage.TextChanged
        AppPackage = txtPackage.Text
    End Sub

    Private Sub txtIndex_TextChanged(sender As Object, e As EventArgs) Handles txtIndex.TextChanged
        Integer.TryParse(txtIndex.Text, AppIndex)
    End Sub

    Private Sub cbName_CheckedChanged(sender As Object, e As EventArgs) Handles cbName.CheckedChanged
        If cbName.Checked = True Then
            txtName.Enabled = True
        Else
            txtName.Enabled = False
        End If
    End Sub

    Private Sub cbIndex_CheckedChanged(sender As Object, e As EventArgs) Handles cbIndex.CheckedChanged
        If cbIndex.Checked = True Then
            txtIndex.Enabled = True
        Else
            txtIndex.Enabled = False
        End If
    End Sub

    Private Sub cbWorking_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbWorking.CheckedChanged
        If cbWorking.Checked = True Then
            txtWorking.Enabled = True
        Else
            txtWorking.Enabled = False
        End If
    End Sub

    Private Sub cbPackage_CheckedChanged(sender As Object, e As EventArgs) Handles cbPackage.CheckedChanged
        If cbPackage.Checked = True Then
            txtPackage.Enabled = True
        Else
            txtPackage.Enabled = False
        End If
    End Sub

    Private Sub btnSetImage_Click(sender As Object, e As EventArgs) Handles btnSetImage.Click
        pb1.BackgroundImage = Nothing
    End Sub

    Private Sub txtIndex_KeyPress(sender As Object, e As EventArgs) Handles txtIndex.KeyPress

    End Sub
End Class
