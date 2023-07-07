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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pb_Min = New System.Windows.Forms.PictureBox()
        Me.pb_Close = New System.Windows.Forms.PictureBox()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.cbGames = New System.Windows.Forms.ComboBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cbDebug = New System.Windows.Forms.CheckBox()
        Me.cbPackage = New System.Windows.Forms.CheckBox()
        Me.cbWorking = New System.Windows.Forms.CheckBox()
        Me.cbIndex = New System.Windows.Forms.CheckBox()
        Me.cbName = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSetImage = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.btnIcon = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.Btn_Submit = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.btnHelp = New LDPlayer_Shortcut_Generator.ProjektCode_RoundButton()
        Me.txtDesc = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektCode_Separator5 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator4 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator3 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.txtPackage = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.txtWorking = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.txtIndex = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektCode_Separator2 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.ProjektCode_Separator1 = New LDPlayer_Shortcut_Generator.ProjektCode_Separator()
        Me.txtName = New LDPlayer_Shortcut_Generator.ProjektCode_TextBox()
        Me.ProjektDrag_Component1 = New LDPlayer_Shortcut_Generator.ProjektDrag_Component()
        Me.pnlTop.SuspendLayout()
        CType(Me.pb_Min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfo.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.Crimson
        Me.pnlTop.Controls.Add(Me.lbl_Title)
        Me.pnlTop.Controls.Add(Me.pb_Min)
        Me.pnlTop.Controls.Add(Me.pb_Close)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(640, 40)
        Me.pnlTop.TabIndex = 3
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Roboto Cn", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(4, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(277, 23)
        Me.lbl_Title.TabIndex = 7
        Me.lbl_Title.Text = "LDPLAYER SHORTCUT GENERATOR"
        '
        'pb_Min
        '
        Me.pb_Min.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_Min.BackgroundImage = CType(resources.GetObject("pb_Min.BackgroundImage"), System.Drawing.Image)
        Me.pb_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Min.Location = New System.Drawing.Point(567, 5)
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
        Me.pb_Close.Location = New System.Drawing.Point(605, 5)
        Me.pb_Close.Name = "pb_Close"
        Me.pb_Close.Size = New System.Drawing.Size(32, 32)
        Me.pb_Close.TabIndex = 6
        Me.pb_Close.TabStop = False
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.txtDesc)
        Me.gbInfo.Controls.Add(Me.ProjektCode_Separator5)
        Me.gbInfo.Controls.Add(Me.ProjektCode_Separator4)
        Me.gbInfo.Controls.Add(Me.cbGames)
        Me.gbInfo.Controls.Add(Me.ProjektCode_Separator3)
        Me.gbInfo.Controls.Add(Me.txtPackage)
        Me.gbInfo.Controls.Add(Me.txtWorking)
        Me.gbInfo.Controls.Add(Me.txtIndex)
        Me.gbInfo.Controls.Add(Me.ProjektCode_Separator2)
        Me.gbInfo.Controls.Add(Me.ProjektCode_Separator1)
        Me.gbInfo.Controls.Add(Me.txtName)
        Me.gbInfo.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInfo.ForeColor = System.Drawing.Color.White
        Me.gbInfo.Location = New System.Drawing.Point(12, 46)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Padding = New System.Windows.Forms.Padding(10)
        Me.gbInfo.Size = New System.Drawing.Size(269, 334)
        Me.gbInfo.TabIndex = 6
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Information"
        '
        'cbGames
        '
        Me.cbGames.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGames.FormattingEnabled = True
        Me.cbGames.Location = New System.Drawing.Point(10, 26)
        Me.cbGames.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGames.Name = "cbGames"
        Me.cbGames.Size = New System.Drawing.Size(249, 23)
        Me.cbGames.TabIndex = 17
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Crimson
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb1.Location = New System.Drawing.Point(500, 113)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(128, 128)
        Me.pb1.TabIndex = 17
        Me.pb1.TabStop = False
        '
        'ofd
        '
        Me.ofd.FileName = "Select Image"
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cbDebug)
        Me.gbOptions.Controls.Add(Me.cbPackage)
        Me.gbOptions.Controls.Add(Me.cbWorking)
        Me.gbOptions.Controls.Add(Me.cbIndex)
        Me.gbOptions.Controls.Add(Me.cbName)
        Me.gbOptions.ForeColor = System.Drawing.Color.White
        Me.gbOptions.Location = New System.Drawing.Point(287, 48)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(200, 332)
        Me.gbOptions.TabIndex = 19
        Me.gbOptions.TabStop = False
        Me.gbOptions.Text = "Options"
        '
        'cbDebug
        '
        Me.cbDebug.AutoSize = True
        Me.cbDebug.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbDebug.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDebug.Location = New System.Drawing.Point(3, 84)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(194, 17)
        Me.cbDebug.TabIndex = 5
        Me.cbDebug.Text = "Enable Debug"
        Me.cbDebug.UseVisualStyleBackColor = True
        '
        'cbPackage
        '
        Me.cbPackage.AutoSize = True
        Me.cbPackage.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbPackage.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPackage.Location = New System.Drawing.Point(3, 67)
        Me.cbPackage.Name = "cbPackage"
        Me.cbPackage.Size = New System.Drawing.Size(194, 17)
        Me.cbPackage.TabIndex = 4
        Me.cbPackage.Text = "Enable Packname"
        Me.cbPackage.UseVisualStyleBackColor = True
        '
        'cbWorking
        '
        Me.cbWorking.AutoSize = True
        Me.cbWorking.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbWorking.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWorking.Location = New System.Drawing.Point(3, 50)
        Me.cbWorking.Name = "cbWorking"
        Me.cbWorking.Size = New System.Drawing.Size(194, 17)
        Me.cbWorking.TabIndex = 3
        Me.cbWorking.Text = "Enable Working Directory"
        Me.cbWorking.UseVisualStyleBackColor = True
        '
        'cbIndex
        '
        Me.cbIndex.AutoSize = True
        Me.cbIndex.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbIndex.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIndex.Location = New System.Drawing.Point(3, 33)
        Me.cbIndex.Name = "cbIndex"
        Me.cbIndex.Size = New System.Drawing.Size(194, 17)
        Me.cbIndex.TabIndex = 2
        Me.cbIndex.Text = "Enable Index"
        Me.cbIndex.UseVisualStyleBackColor = True
        '
        'cbName
        '
        Me.cbName.AutoSize = True
        Me.cbName.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbName.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbName.Location = New System.Drawing.Point(3, 16)
        Me.cbName.Name = "cbName"
        Me.cbName.Size = New System.Drawing.Size(194, 17)
        Me.cbName.TabIndex = 1
        Me.cbName.Text = "Enable Shortcut Name"
        Me.cbName.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSetImage, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIcon, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Submit, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHelp, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(500, 247)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(128, 130)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'btnSetImage
        '
        Me.btnSetImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSetImage.BackColor = System.Drawing.Color.Crimson
        Me.btnSetImage.BackgroundColor = System.Drawing.Color.Crimson
        Me.btnSetImage.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnSetImage.BorderRadius = 20
        Me.btnSetImage.BorderSize = 0
        Me.btnSetImage.FlatAppearance.BorderSize = 0
        Me.btnSetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetImage.Font = New System.Drawing.Font("Roboto Cn", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetImage.ForeColor = System.Drawing.Color.White
        Me.btnSetImage.Location = New System.Drawing.Point(3, 35)
        Me.btnSetImage.Name = "btnSetImage"
        Me.btnSetImage.Size = New System.Drawing.Size(122, 26)
        Me.btnSetImage.TabIndex = 20
        Me.btnSetImage.Text = "C L E A R I M A G E"
        Me.btnSetImage.TextColor = System.Drawing.Color.White
        Me.btnSetImage.UseVisualStyleBackColor = False
        '
        'btnIcon
        '
        Me.btnIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIcon.BackColor = System.Drawing.Color.Crimson
        Me.btnIcon.BackgroundColor = System.Drawing.Color.Crimson
        Me.btnIcon.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnIcon.BorderRadius = 20
        Me.btnIcon.BorderSize = 0
        Me.btnIcon.FlatAppearance.BorderSize = 0
        Me.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIcon.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIcon.ForeColor = System.Drawing.Color.White
        Me.btnIcon.Location = New System.Drawing.Point(3, 3)
        Me.btnIcon.Name = "btnIcon"
        Me.btnIcon.Size = New System.Drawing.Size(122, 26)
        Me.btnIcon.TabIndex = 18
        Me.btnIcon.Text = "I M A G E"
        Me.btnIcon.TextColor = System.Drawing.Color.White
        Me.btnIcon.UseVisualStyleBackColor = False
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_Submit.BackColor = System.Drawing.Color.Crimson
        Me.Btn_Submit.BackgroundColor = System.Drawing.Color.Crimson
        Me.Btn_Submit.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Submit.BorderRadius = 14
        Me.Btn_Submit.BorderSize = 0
        Me.Btn_Submit.FlatAppearance.BorderSize = 0
        Me.Btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Submit.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Submit.ForeColor = System.Drawing.Color.White
        Me.Btn_Submit.Location = New System.Drawing.Point(3, 99)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(122, 28)
        Me.Btn_Submit.TabIndex = 0
        Me.Btn_Submit.Text = "S U B M I T"
        Me.Btn_Submit.TextColor = System.Drawing.Color.White
        Me.Btn_Submit.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHelp.BackColor = System.Drawing.Color.Crimson
        Me.btnHelp.BackgroundColor = System.Drawing.Color.Crimson
        Me.btnHelp.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnHelp.BorderRadius = 14
        Me.btnHelp.BorderSize = 0
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.White
        Me.btnHelp.Location = New System.Drawing.Point(3, 67)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(122, 26)
        Me.btnHelp.TabIndex = 19
        Me.btnHelp.Text = "H E L P"
        Me.btnHelp.TextColor = System.Drawing.Color.White
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.BorderColor = System.Drawing.Color.White
        Me.txtDesc.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtDesc.BorderRadius = 0
        Me.txtDesc.BorderSize = 0
        Me.txtDesc.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.ForeColor = System.Drawing.Color.DimGray
        Me.txtDesc.IsPasswordChar = False
        Me.txtDesc.IsPlaceHolder = True
        Me.txtDesc.Location = New System.Drawing.Point(10, 290)
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
        'ProjektCode_Separator5
        '
        Me.ProjektCode_Separator5.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProjektCode_Separator5.isVertical = False
        Me.ProjektCode_Separator5.Location = New System.Drawing.Point(10, 49)
        Me.ProjektCode_Separator5.Name = "ProjektCode_Separator5"
        Me.ProjektCode_Separator5.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator5.TabIndex = 18
        Me.ProjektCode_Separator5.Text = "ProjektCode_Separator5"
        Me.ProjektCode_Separator5.Thickness = 1
        '
        'ProjektCode_Separator4
        '
        Me.ProjektCode_Separator4.isVertical = False
        Me.ProjektCode_Separator4.Location = New System.Drawing.Point(10, 103)
        Me.ProjektCode_Separator4.Name = "ProjektCode_Separator4"
        Me.ProjektCode_Separator4.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator4.TabIndex = 15
        Me.ProjektCode_Separator4.Text = "ProjektCode_Separator4"
        Me.ProjektCode_Separator4.Thickness = 1
        '
        'ProjektCode_Separator3
        '
        Me.ProjektCode_Separator3.isVertical = False
        Me.ProjektCode_Separator3.Location = New System.Drawing.Point(10, 266)
        Me.ProjektCode_Separator3.Name = "ProjektCode_Separator3"
        Me.ProjektCode_Separator3.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator3.TabIndex = 13
        Me.ProjektCode_Separator3.Text = "ProjektCode_Separator3"
        Me.ProjektCode_Separator3.Thickness = 1
        '
        'txtPackage
        '
        Me.txtPackage.BackColor = System.Drawing.SystemColors.Window
        Me.txtPackage.BorderColor = System.Drawing.Color.White
        Me.txtPackage.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtPackage.BorderRadius = 0
        Me.txtPackage.BorderSize = 0
        Me.txtPackage.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackage.ForeColor = System.Drawing.Color.DimGray
        Me.txtPackage.IsPasswordChar = False
        Me.txtPackage.IsPlaceHolder = True
        Me.txtPackage.Location = New System.Drawing.Point(10, 234)
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
        'txtWorking
        '
        Me.txtWorking.BackColor = System.Drawing.SystemColors.Window
        Me.txtWorking.BorderColor = System.Drawing.Color.White
        Me.txtWorking.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtWorking.BorderRadius = 0
        Me.txtWorking.BorderSize = 0
        Me.txtWorking.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorking.ForeColor = System.Drawing.Color.DimGray
        Me.txtWorking.IsPasswordChar = False
        Me.txtWorking.IsPlaceHolder = True
        Me.txtWorking.Location = New System.Drawing.Point(10, 178)
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
        'txtIndex
        '
        Me.txtIndex.BackColor = System.Drawing.SystemColors.Window
        Me.txtIndex.BorderColor = System.Drawing.Color.White
        Me.txtIndex.BorderFocusColor = System.Drawing.Color.Crimson
        Me.txtIndex.BorderRadius = 0
        Me.txtIndex.BorderSize = 0
        Me.txtIndex.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndex.ForeColor = System.Drawing.Color.DimGray
        Me.txtIndex.IsPasswordChar = False
        Me.txtIndex.IsPlaceHolder = True
        Me.txtIndex.Location = New System.Drawing.Point(10, 124)
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
        Me.ProjektCode_Separator2.isVertical = False
        Me.ProjektCode_Separator2.Location = New System.Drawing.Point(10, 154)
        Me.ProjektCode_Separator2.Name = "ProjektCode_Separator2"
        Me.ProjektCode_Separator2.Size = New System.Drawing.Size(249, 23)
        Me.ProjektCode_Separator2.TabIndex = 11
        Me.ProjektCode_Separator2.Text = "ProjektCode_Separator2"
        Me.ProjektCode_Separator2.Thickness = 1
        '
        'ProjektCode_Separator1
        '
        Me.ProjektCode_Separator1.isVertical = False
        Me.ProjektCode_Separator1.Location = New System.Drawing.Point(10, 210)
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
        Me.txtName.Font = New System.Drawing.Font("Roboto Cn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DimGray
        Me.txtName.IsPasswordChar = False
        Me.txtName.IsPlaceHolder = True
        Me.txtName.Location = New System.Drawing.Point(10, 72)
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
        'ProjektDrag_Component1
        '
        Me.ProjektDrag_Component1.SelectedControl = Me.pnlTop
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 389)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.pb_Min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfo.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pb_Min As PictureBox
    Friend WithEvents pb_Close As PictureBox
    Friend WithEvents Btn_Submit As ProjektCode_RoundButton
    Friend WithEvents txtName As ProjektCode_TextBox
    Friend WithEvents ProjektDrag_Component1 As ProjektDrag_Component
    Friend WithEvents gbInfo As GroupBox
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
    Friend WithEvents lbl_Title As Label
    Friend WithEvents ProjektCode_Separator5 As ProjektCode_Separator
    Friend WithEvents cbGames As ComboBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents cbName As CheckBox
    Friend WithEvents cbPackage As CheckBox
    Friend WithEvents cbWorking As CheckBox
    Friend WithEvents cbIndex As CheckBox
    Friend WithEvents btnSetImage As ProjektCode_RoundButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbDebug As CheckBox
End Class
