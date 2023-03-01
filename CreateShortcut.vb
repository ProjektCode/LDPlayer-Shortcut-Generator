Imports System.Drawing.Drawing2D
Imports System.IO
Imports ImageMagick
Imports IWshRuntimeLibrary

Partial Public Class ShortCutInfo
    Public Property Image As Image
    Public Property PackageName As String
    Public Property Name As String
    Public Property Index As Integer
    Public Property WorkingDirectory As String
    Public Property Description As String
End Class

''' <summary>
''' Creates a desktop shortcut for a LD Player application
''' </summary>
Public NotInheritable Class CreateShortcut

    Public Shared Async Sub Create(s As ShortCutInfo)

        Try

            If Not Directory.Exists(s.WorkingDirectory) Then
                Throw New DirectoryNotFoundException
            End If

            Dim im = Await ResizeImage(s.Image)
            Dim i = New Bitmap(im)
            Dim ImgPath = AppDomain.CurrentDomain.BaseDirectory + "temp.png"
            Dim path = CreateFolder(s.PackageName) 'Change this to packagename param
            Dim IconPath = path + "\Icon.ico" 'Change this to the name the user selects

            i.Save(ImgPath)
            i.Dispose()

            Using imge = New MagickImage(ImgPath)
                imge.Write(IconPath)
                s.Image.Dispose()
            End Using

            If s.Description = Nothing Then
                s.Description = "LDPlayer Shortcut"
            End If

            Dim wsh As New WshShell()
            Dim shortcut As IWshShortcut = TryCast(wsh.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\{s.Name}.lnk"), IWshShortcut) 'Change shortcut.lnk to nameparam.lnk
            'Make each attribute its own param
            shortcut.Arguments = $"launchex --index {s.Index} --packagename {s.PackageName}"
            shortcut.TargetPath = $"{s.WorkingDirectory}\ldconsole.exe"
            shortcut.Description = s.Description
            shortcut.WorkingDirectory = s.WorkingDirectory
            shortcut.IconLocation = IconPath
            shortcut.Save()

            IO.File.Delete(ImgPath)
            MessageBox.Show($"Shortcut for {s.Name} has been created", "Shortcut Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Shared Async Function ResizeImage(img As Image) As Task(Of Bitmap)
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
        Dim dir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + $"\LD Player\{FolderName}"
        If Directory.Exists(dir.ToString) Then
            Return dir
        Else
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + $"\LD Player\{FolderName}")
            Return dir
        End If
    End Function

End Class