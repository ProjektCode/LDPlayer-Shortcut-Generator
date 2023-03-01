<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pb_Min = New System.Windows.Forms.PictureBox()
        Me.pb_Close = New System.Windows.Forms.PictureBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btnHelp = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.btnIcon = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.txtDesc = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektCode_Separator4 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.txtWorking = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektCode_Separator3 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.txtIndex = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektCode_Separator2 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.txtPackage = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektCode_Separator1 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.txtName = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.Btn_Submit = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.ProjektDrag_Component1 = New LDPlayer_Shortcut_Generator.ProjektDrag_Component()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        CType(Me.pb_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Crimson
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.pb_Min)
        Me.pnlTop.Controls.Add(Me.pb_Close)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(428, 40)
        Me.pnlTop.TabIndex = 3
        '
        'pb_Min
        '
        Me.pb_Min.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_Min.BackgroundImage = CType(resources.GetObject("pb_Min.BackgroundImage"), System.Drawing.Image)
        Me.pb_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Min.Location = New System.Drawing.Point(355, 5)
        Me.pb_Min.Name = "pb_Min"
        Me.pb_Min.Size = New System.Drawing.Size(32, 32)
        Me.pb_Min.TabIndex = 5
        Me.pb_Min.TabStop = False
        '
        'pb_Close
        '
        Me.pb_Close.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_Close.BackgroundImage = CType(resources.GetObject("pb_Close.BackgroundImage"), System.Drawing.Image)
        Me.pb_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Close.Location = New System.Drawing.Point(393, 5)
        Me.pb_Close.Name = "pb_Close"
        Me.pb_Close.Size = New System.Drawing.Size(32, 32)
        Me.pb_Close.TabIndex = 6
        Me.pb_Close.TabStop = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.txtDesc)
        Me.gb1.Controls.Add(Me.ProjektCode_Separator4)
        Me.gb1.Controls.Add(Me.txtWorking)
        Me.gb1.Controls.Add(Me.ProjektCode_Separator3)
        Me.gb1.Controls.Add(Me.txtIndex)
        Me.gb1.Controls.Add(Me.ProjektCode_Separator2)
        Me.gb1.Controls.Add(Me.txtPackage)
        Me.gb1.Controls.Add(Me.ProjektCode_Separator1)
        Me.gb1.Controls.Add(Me.txtName)
        Me.gb1.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.ForeColor = System.Drawing.Color.White
        Me.gb1.Location = New System.Drawing.Point(12, 46)
        Me.gb1.Name = "gb1"
        Me.gb1.Padding = New System.Windows.Forms.Padding(10)
        Me.gb1.Size = New System.Drawing.Size(269, 283)
        Me.gb1.TabIndex = 6
        Me.gb1.TabStop = False
        Me.gb1.Text = "Information"
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Crimson
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(287, 54)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(128, 128)
        Me.pb1.TabIndex = 17
        Me.pb1.TabStop = False
        '
        'ofd
        '
        Me.ofd.FileName = "Select Image"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Crimson
        Me.btnHelp.BackgroundColor = System.Drawing.Color.Crimson
        Me.btnHelp.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnHelp.BorderRadius = 20
        Me.btnHelp.BorderSize = 0
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(288, 335)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(128, 28)
        Me.btnHelp.TabIndex = 19
        Me.btnHelp.Text = "H E L P"
        Me.btnHelp.TextColor = System.Drawing.Color.White
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnIcon
        '
        Me.btnIcon.BackColor = System.Drawing.Color.Crimson
        Me.btnIcon.BackgroundColor = System.Drawing.Color.Crimson
        Me.btnIcon.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnIcon.BorderRadius = 20
        Me.btnIcon.BorderSize = 0
        Me.btnIcon.FlatAppearance.BorderSize = 0
        Me.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIcon.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIcon.ForeColor = System.Drawing.Color.White
        Me.btnIcon.Location = New System.Drawing.Point(287, 188)
        Me.btnIcon.Name = "btnIcon"
        Me.btnIcon.Size = New System.Drawing.Size(128, 28)
        Me.btnIcon.TabIndex = 18
        Me.btnIcon.Text = "I M A G E"
        Me.btnIcon.TextColor = System.Drawing.Color.White
        Me.btnIcon.UseVisualStyleBackColor = False
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.BorderColor = System.Drawing.Color.White
        Me.txtDesc.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtDesc.BorderRadius = 0
        Me.txtDesc.BorderSize = 0
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDesc.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.DimGray
        Me.txtDesc.IsPasswordChar = False
        Me.txtDesc.IsPlaceHolder = True
        Me.txtDesc.Location = New System.Drawing.Point(10, 238)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesc.MultiLine = False
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Padding = New System.Windows.Forms.Padding(7)
        Me.txtDesc.PasswordChar = False
        Me.txtDesc.PlaceHolderColor = System.Drawing.Color.Crimson
        Me.txtDesc.PlaceHolderText = "Description"
        Me.txtDesc.Size = New System.Drawing.Size(249, 30)
        Me.txtDesc.TabIndex = 16
        Me.txtDesc.UnderlineStyle = False
        '
        'ProjektCode_Separator4
        '
        Me.ProjektCode_Separator4.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator4.isVertical = False
        Me.ProjektCode_Separator4.Location = New System.Drawing.Point(10, 215)
        Me.ProjektCode_Separator4.Name = "ProjektCode_Separator4"
        Me.ProjektCode_Separator4.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator4.TabIndex = 15
        Me.ProjektCode_Separator4.Text = "ProjektCode_Separator4"
        Me.ProjektCode_Separator4.Thickness = 1
        '
        'txtWorking
        '
        Me.txtWorking.BackColor = System.Drawing.SystemColors.Window
        Me.txtWorking.BorderColor = System.Drawing.Color.White
        Me.txtWorking.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtWorking.BorderRadius = 0
        Me.txtWorking.BorderSize = 0
        Me.txtWorking.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtWorking.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorking.ForeColor = System.Drawing.Color.DimGray
        Me.txtWorking.IsPasswordChar = False
        Me.txtWorking.IsPlaceHolder = True
        Me.txtWorking.Location = New System.Drawing.Point(10, 185)
        Me.txtWorking.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWorking.MultiLine = False
        Me.txtWorking.Name = "txtWorking"
        Me.txtWorking.Padding = New System.Windows.Forms.Padding(7)
        Me.txtWorking.PasswordChar = False
        Me.txtWorking.PlaceHolderColor = System.Drawing.Color.Crimson
        Me.txtWorking.PlaceHolderText = "Working Directory"
        Me.txtWorking.Size = New System.Drawing.Size(249, 30)
        Me.txtWorking.TabIndex = 14
        Me.txtWorking.UnderlineStyle = False
        '
        'ProjektCode_Separator3
        '
        Me.ProjektCode_Separator3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator3.isVertical = False
        Me.ProjektCode_Separator3.Location = New System.Drawing.Point(10, 162)
        Me.ProjektCode_Separator3.Name = "ProjektCode_Separator3"
        Me.ProjektCode_Separator3.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator3.TabIndex = 13
        Me.ProjektCode_Separator3.Text = "ProjektCode_Separator3"
        Me.ProjektCode_Separator3.Thickness = 1
        '
        'txtIndex
        '
        Me.txtIndex.BackColor = System.Drawing.SystemColors.Window
        Me.txtIndex.BorderColor = System.Drawing.Color.White
        Me.txtIndex.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtIndex.BorderRadius = 0
        Me.txtIndex.BorderSize = 0
        Me.txtIndex.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtIndex.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndex.ForeColor = System.Drawing.Color.DimGray
        Me.txtIndex.IsPasswordChar = False
        Me.txtIndex.IsPlaceHolder = True
        Me.txtIndex.Location = New System.Drawing.Point(10, 132)
        Me.txtIndex.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIndex.MultiLine = False
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.Padding = New System.Windows.Forms.Padding(7)
        Me.txtIndex.PasswordChar = False
        Me.txtIndex.PlaceHolderColor = System.Drawing.Color.Crimson
        Me.txtIndex.PlaceHolderText = "Index"
        Me.txtIndex.Size = New System.Drawing.Size(249, 30)
        Me.txtIndex.TabIndex = 12
        Me.txtIndex.UnderlineStyle = False
        '
        'ProjektCode_Separator2
        '
        Me.ProjektCode_Separator2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator2.isVertical = False
        Me.ProjektCode_Separator2.Location = New System.Drawing.Point(10, 109)
        Me.ProjektCode_Separator2.Name = "ProjektCode_Separator2"
        Me.ProjektCode_Separator2.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator2.TabIndex = 11
        Me.ProjektCode_Separator2.Text = "ProjektCode_Separator2"
        Me.ProjektCode_Separator2.Thickness = 1
        '
        'txtPackage
        '
        Me.txtPackage.BackColor = System.Drawing.SystemColors.Window
        Me.txtPackage.BorderColor = System.Drawing.Color.White
        Me.txtPackage.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtPackage.BorderRadius = 0
        Me.txtPackage.BorderSize = 0
        Me.txtPackage.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPackage.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackage.ForeColor = System.Drawing.Color.DimGray
        Me.txtPackage.IsPasswordChar = False
        Me.txtPackage.IsPlaceHolder = True
        Me.txtPackage.Location = New System.Drawing.Point(10, 79)
        Me.txtPackage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPackage.MultiLine = False
        Me.txtPackage.Name = "txtPackage"
        Me.txtPackage.Padding = New System.Windows.Forms.Padding(7)
        Me.txtPackage.PasswordChar = False
        Me.txtPackage.PlaceHolderColor = System.Drawing.Color.Crimson
        Me.txtPackage.PlaceHolderText = "Package Name"
        Me.txtPackage.Size = New System.Drawing.Size(249, 30)
        Me.txtPackage.TabIndex = 10
        Me.txtPackage.UnderlineStyle = False
        '
        'ProjektCode_Separator1
        '
        Me.ProjektCode_Separator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator1.isVertical = False
        Me.ProjektCode_Separator1.Location = New System.Drawing.Point(10, 56)
        Me.ProjektCode_Separator1.Name = "ProjektCode_Separator1"
        Me.ProjektCode_Separator1.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator1.TabIndex = 9
        Me.ProjektCode_Separator1.Text = "ProjektCode_Separator1"
        Me.ProjektCode_Separator1.Thickness = 1
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BorderColor = System.Drawing.Color.White
        Me.txtName.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtName.BorderRadius = 0
        Me.txtName.BorderSize = 0
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtName.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DimGray
        Me.txtName.IsPasswordChar = False
        Me.txtName.IsPlaceHolder = True
        Me.txtName.Location = New System.Drawing.Point(10, 26)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MultiLine = False
        Me.txtName.Name = "txtName"
        Me.txtName.Padding = New System.Windows.Forms.Padding(7)
        Me.txtName.PasswordChar = False
        Me.txtName.PlaceHolderColor = System.Drawing.Color.Crimson
        Me.txtName.PlaceHolderText = "Shortcut Name"
        Me.txtName.Size = New System.Drawing.Size(249, 30)
        Me.txtName.TabIndex = 4
        Me.txtName.UnderlineStyle = False
        '
        'Btn_Submit
        '
        Me.Btn_Submit.BackColor = System.Drawing.Color.Crimson
        Me.Btn_Submit.BackgroundColor = System.Drawing.Color.Crimson
        Me.Btn_Submit.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Submit.BorderRadius = 20
        Me.Btn_Submit.BorderSize = 0
        Me.Btn_Submit.FlatAppearance.BorderSize = 0
        Me.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Submit.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Submit.ForeColor = System.Drawing.Color.White
        Me.Btn_Submit.Location = New System.Drawing.Point(12, 335)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(269, 28)
        Me.Btn_Submit.TabIndex = 0
        Me.Btn_Submit.Text = "S U B M I T"
        Me.Btn_Submit.TextColor = System.Drawing.Color.White
        Me.Btn_Submit.UseVisualStyleBackColor = False
        '
        'ProjektDrag_Component1
        '
        Me.ProjektDrag_Component1.SelectedControl = Me.pnlTop
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Cn", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LDPLAYER SHORTCUT GENERATOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 384)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnIcon)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pb_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pb_Min As PictureBox
    Friend WithEvents pb_Close As PictureBox
    Friend WithEvents Btn_Submit As ProjektCode_RoundButton
    Friend WithEvents txtName As ProjektCode_TextBox
    Friend WithEvents ProjektDrag_Component1 As ProjektDrag_Component
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents txtDesc As ProjektCode_TextBox
    Friend WithEvents ProjektCode_Separator4 As ProjektCode_Separator
    Friend WithEvents txtWorking As ProjektCode_TextBox
    Friend WithEvents ProjektCode_Separator3 As ProjektCode_Separator
    Friend WithEvents txtIndex As ProjektCode_TextBox
    Friend WithEvents ProjektCode_Separator2 As ProjektCode_Separator
    Friend WithEvents txtPackage As ProjektCode_TextBox
    Friend WithEvents ProjektCode_Separator1 As ProjektCode_Separator
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents btnIcon As ProjektCode_RoundButton
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents btnHelp As ProjektCode_RoundButton
    Friend WithEvents Label1 As Label
End Class
