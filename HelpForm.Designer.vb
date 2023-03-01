<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProjektCode_Separator5 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator4 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator3 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator2 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator1 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektDrag_Component1 = New LDPlayer_Shortcut_Generator.ProjektDrag_Component()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Crimson
        Me.pnlTop.Controls.Add(Me.Label6)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(410, 43)
        Me.pnlTop.TabIndex = 0
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblImage.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImage.ForeColor = System.Drawing.Color.White
        Me.lblImage.Location = New System.Drawing.Point(0, 43)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Padding = New System.Windows.Forms.Padding(3, 7, 0, 0)
        Me.lblImage.Size = New System.Drawing.Size(286, 25)
        Me.lblImage.TabIndex = 1
        Me.lblImage.Text = "IMAGE - Select an image to be your desired icon"
        Me.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(410, 66)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PACKAGENAME - The name of the package you're trying to launch. ex) com.YoStarEN.A" &
    "rknights (Look in the File Manager > Android > Data)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(273, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME - The name you want the shortcut to be"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(410, 46)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "INDEX - The ID of the LDPlayer(Look at the ID in the multi-instance manager)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(333, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "WORKING DIRECTORY - Where your LDPlayer is located"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(410, 46)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DESCRIPTION - The description of the shortcut, this field is optional so does not" &
    " need to be filled out"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProjektCode_Separator5
        '
        Me.ProjektCode_Separator5.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator5.ForeColor = System.Drawing.Color.White
        Me.ProjektCode_Separator5.isVertical = False
        Me.ProjektCode_Separator5.Location = New System.Drawing.Point(0, 318)
        Me.ProjektCode_Separator5.Name = "ProjektCode_Separator5"
        Me.ProjektCode_Separator5.Size = New System.Drawing.Size(410, 23)
        Me.ProjektCode_Separator5.TabIndex = 10
        Me.ProjektCode_Separator5.Text = "ProjektCode_Separator5"
        Me.ProjektCode_Separator5.Thickness = 1
        '
        'ProjektCode_Separator4
        '
        Me.ProjektCode_Separator4.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator4.ForeColor = System.Drawing.Color.White
        Me.ProjektCode_Separator4.isVertical = False
        Me.ProjektCode_Separator4.Location = New System.Drawing.Point(0, 272)
        Me.ProjektCode_Separator4.Name = "ProjektCode_Separator4"
        Me.ProjektCode_Separator4.Size = New System.Drawing.Size(410, 23)
        Me.ProjektCode_Separator4.TabIndex = 8
        Me.ProjektCode_Separator4.Text = "ProjektCode_Separator4"
        Me.ProjektCode_Separator4.Thickness = 1
        '
        'ProjektCode_Separator3
        '
        Me.ProjektCode_Separator3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator3.ForeColor = System.Drawing.Color.White
        Me.ProjektCode_Separator3.isVertical = False
        Me.ProjektCode_Separator3.Location = New System.Drawing.Point(0, 203)
        Me.ProjektCode_Separator3.Name = "ProjektCode_Separator3"
        Me.ProjektCode_Separator3.Size = New System.Drawing.Size(410, 23)
        Me.ProjektCode_Separator3.TabIndex = 6
        Me.ProjektCode_Separator3.Text = "ProjektCode_Separator3"
        Me.ProjektCode_Separator3.Thickness = 1
        '
        'ProjektCode_Separator2
        '
        Me.ProjektCode_Separator2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator2.ForeColor = System.Drawing.Color.White
        Me.ProjektCode_Separator2.isVertical = False
        Me.ProjektCode_Separator2.Location = New System.Drawing.Point(0, 157)
        Me.ProjektCode_Separator2.Name = "ProjektCode_Separator2"
        Me.ProjektCode_Separator2.Size = New System.Drawing.Size(410, 23)
        Me.ProjektCode_Separator2.TabIndex = 4
        Me.ProjektCode_Separator2.Text = "ProjektCode_Separator2"
        Me.ProjektCode_Separator2.Thickness = 1
        '
        'ProjektCode_Separator1
        '
        Me.ProjektCode_Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator1.ForeColor = System.Drawing.Color.White
        Me.ProjektCode_Separator1.isVertical = False
        Me.ProjektCode_Separator1.Location = New System.Drawing.Point(0, 68)
        Me.ProjektCode_Separator1.Name = "ProjektCode_Separator1"
        Me.ProjektCode_Separator1.Size = New System.Drawing.Size(410, 23)
        Me.ProjektCode_Separator1.TabIndex = 2
        Me.ProjektCode_Separator1.Text = "ProjektCode_Separator1"
        Me.ProjektCode_Separator1.Thickness = 1
        '
        'ProjektDrag_Component1
        '
        Me.ProjektDrag_Component1.SelectedControl = Me.pnlTop
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Cn", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "HELP FORM"
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 398)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProjektCode_Separator5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProjektCode_Separator4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProjektCode_Separator3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProjektCode_Separator2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProjektCode_Separator1)
        Me.Controls.Add(Me.lblImage)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HelpForm"
        Me.Text = "HelpForm"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents ProjektDrag_Component1 As ProjektDrag_Component
    Friend WithEvents lblImage As Label
    Friend WithEvents ProjektCode_Separator1 As ProjektCode_Separator
    Friend WithEvents ProjektCode_Separator2 As ProjektCode_Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents ProjektCode_Separator3 As ProjektCode_Separator
    Friend WithEvents Label2 As Label
    Friend WithEvents ProjektCode_Separator4 As ProjektCode_Separator
    Friend WithEvents Label3 As Label
    Friend WithEvents ProjektCode_Separator5 As ProjektCode_Separator
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
