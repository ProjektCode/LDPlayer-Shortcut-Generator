Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text.RegularExpressions
Imports ImageMagick
Imports IWshRuntimeLibrary

''' <summary>
''' Creates a desktop shortcut for a LD Player application
''' </summary>
Public NotInheritable Class CreateShortcut

    Public Shared Status As Boolean
    Public Shared Desc As String

    Public Shared Sub Create(game As GameInfo)

        Try

            If Not Directory.Exists(game.WorkingDirectory) Then
                Throw New DirectoryNotFoundException
            End If

            Dim im = game.Image
            Dim i = New Bitmap(im)
            Dim t_path = AppDomain.CurrentDomain.BaseDirectory + "temp.png"

            i.Save(t_path)
            i.Dispose()

            Dim path = CreateFolder(game.PackageName)
            Dim IconPath = path + "\Icon.ico"

            Using image = New MagickImage(t_path)
                image.Write(IconPath)
                game.Image.Dispose()
                'image.Dispose()
            End Using

            If game.Description = Nothing Then
                game.Description = $"LDPlayer Shortcut for {game.Name}"
            End If

            Dim name = Regex.Replace(game.Name, "[\/?:*""><|]+", "", RegexOptions.Compiled)

            Dim wsh As New WshShell()
            Dim shortcut As IWshShortcut = TryCast(wsh.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\{name}.lnk"), IWshShortcut)

            shortcut.Arguments = $"launchex --index {game.Index} --packagename {game.PackageName}"
            shortcut.TargetPath = $"{game.WorkingDirectory}\ldconsole.exe"
            shortcut.Description = game.Description
            shortcut.WorkingDirectory = game.WorkingDirectory
            shortcut.IconLocation = IconPath
            shortcut.Save()

            IO.File.Delete(t_path)

            'Status = "Shortcut Successful"
            'Desc = $"Shortcut for {name} has been created."
            'Message.Show()

            'Form1.pb1.BackgroundImage = Nothing
            Status = True
            Desc = $"Shortcut for {name} has been created"
        Catch ex As Exception
            Status = False
            Desc = $"An error has occurred: {ex.Message}"
        End Try

    End Sub

    Public Shared Async Function ResizeImage(img As Image) As Task(Of Bitmap)
        If img.Width <= 256 Then
            Return New Bitmap(img)
        End If

        Dim orgWidth = img.Width
        Dim orgHeight = img.Height
        Dim destinationSize = New Size(256, 256)

        Dim heightRatio = Convert.ToDecimal(orgHeight / destinationSize.Height)
        Dim widthRatio = Convert.ToDecimal(orgWidth / destinationSize.Width)
        Dim ratio = Math.Min(heightRatio, widthRatio)

        Dim heightScale = Convert.ToInt32(destinationSize.Height * ratio)
        Dim widthScale = Convert.ToInt32(destinationSize.Width * ratio)
        Dim startX = (orgWidth - widthScale) / 2
        Dim startY = (orgHeight - heightScale) / 2

        Dim sourceRectangle = New Rectangle(startX, startY, widthScale, heightScale)
        Dim bitmap = New Bitmap(destinationSize.Width, destinationSize.Height)
        Dim destinationRectangle = New Rectangle(0, 0, bitmap.Width, bitmap.Height)

        Using g = Graphics.FromImage(bitmap)
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.DrawImage(img, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel)

            Return Await Task.FromResult(bitmap)
        End Using

    End Function

    Private Shared Function FileExists(f As String) As Boolean
        If IO.File.Exists(f) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Shared Function CreateFolder(FolderName As String)
        Dim dir = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)}\LD Player\{FolderName}"
        Directory.CreateDirectory(dir)
        Return dir
    End Function

End Class