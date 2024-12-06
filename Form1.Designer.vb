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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelStart = New Panel()
        LabelStartButton = New Label()
        PictureBoxTitle = New PictureBox()
        Label2 = New Label()
        PictureBoxStart = New PictureBox()
        ButtonIngredientA = New Button()
        ButtonIngredientB = New Button()
        PictureBoxMain = New PictureBox()
        ButtonMainMenu = New Button()
        LabelDialogBox = New Label()
        LabelDialogEnd = New Label()
        TimerDialogAnimation = New Timer(components)
        PanelOptionsMenu = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        ButtonMusicOff = New Button()
        ButtonMusicOn = New Button()
        Label1 = New Label()
        Label3 = New Label()
        PanelStart.SuspendLayout()
        CType(PictureBoxTitle, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxStart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxMain, ComponentModel.ISupportInitialize).BeginInit()
        PanelOptionsMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelStart
        ' 
        PanelStart.BackColor = Color.Gray
        PanelStart.Controls.Add(LabelStartButton)
        PanelStart.Controls.Add(PictureBoxTitle)
        PanelStart.Controls.Add(Label2)
        PanelStart.Controls.Add(PictureBoxStart)
        PanelStart.Location = New Point(302, 27)
        PanelStart.Name = "PanelStart"
        PanelStart.Size = New Size(210, 195)
        PanelStart.TabIndex = 0
        ' 
        ' LabelStartButton
        ' 
        LabelStartButton.Location = New Point(121, 135)
        LabelStartButton.Name = "LabelStartButton"
        LabelStartButton.Size = New Size(38, 15)
        LabelStartButton.TabIndex = 10
        LabelStartButton.Text = "START"
        ' 
        ' PictureBoxTitle
        ' 
        PictureBoxTitle.BackColor = Color.DarkGray
        PictureBoxTitle.Location = New Point(75, 40)
        PictureBoxTitle.Name = "PictureBoxTitle"
        PictureBoxTitle.Size = New Size(60, 20)
        PictureBoxTitle.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBoxTitle.TabIndex = 0
        PictureBoxTitle.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Green
        Label2.Location = New Point(52, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 25)
        Label2.TabIndex = 8
        Label2.Text = "' Start Panel"
        Label2.Visible = False
        ' 
        ' PictureBoxStart
        ' 
        PictureBoxStart.BackColor = Color.RosyBrown
        PictureBoxStart.Location = New Point(24, 24)
        PictureBoxStart.Name = "PictureBoxStart"
        PictureBoxStart.Size = New Size(160, 142)
        PictureBoxStart.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxStart.TabIndex = 2
        PictureBoxStart.TabStop = False
        ' 
        ' ButtonIngredientA
        ' 
        ButtonIngredientA.AutoSize = True
        ButtonIngredientA.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ButtonIngredientA.BackColor = Color.Tan
        ButtonIngredientA.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonIngredientA.Location = New Point(35, 438)
        ButtonIngredientA.Name = "ButtonIngredientA"
        ButtonIngredientA.Size = New Size(134, 42)
        ButtonIngredientA.TabIndex = 1
        ButtonIngredientA.Text = "Ingredient"
        ButtonIngredientA.UseVisualStyleBackColor = False
        ButtonIngredientA.Visible = False
        ' 
        ' ButtonIngredientB
        ' 
        ButtonIngredientB.AutoSize = True
        ButtonIngredientB.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ButtonIngredientB.BackColor = Color.Tan
        ButtonIngredientB.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonIngredientB.Location = New Point(35, 390)
        ButtonIngredientB.Name = "ButtonIngredientB"
        ButtonIngredientB.Size = New Size(134, 42)
        ButtonIngredientB.TabIndex = 2
        ButtonIngredientB.Text = "Ingredient"
        ButtonIngredientB.UseVisualStyleBackColor = False
        ButtonIngredientB.Visible = False
        ' 
        ' PictureBoxMain
        ' 
        PictureBoxMain.BackColor = Color.RosyBrown
        PictureBoxMain.Location = New Point(35, 27)
        PictureBoxMain.Name = "PictureBoxMain"
        PictureBoxMain.Size = New Size(231, 195)
        PictureBoxMain.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBoxMain.TabIndex = 3
        PictureBoxMain.TabStop = False
        ' 
        ' ButtonMainMenu
        ' 
        ButtonMainMenu.BackColor = Color.Gray
        ButtonMainMenu.BackgroundImageLayout = ImageLayout.None
        ButtonMainMenu.FlatAppearance.BorderSize = 0
        ButtonMainMenu.FlatStyle = FlatStyle.Flat
        ButtonMainMenu.Font = New Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonMainMenu.ForeColor = Color.DarkGray
        ButtonMainMenu.Location = New Point(203, 54)
        ButtonMainMenu.Name = "ButtonMainMenu"
        ButtonMainMenu.Size = New Size(41, 41)
        ButtonMainMenu.TabIndex = 4
        ButtonMainMenu.Text = "Menu"
        ButtonMainMenu.UseVisualStyleBackColor = False
        ' 
        ' LabelDialogBox
        ' 
        LabelDialogBox.BackColor = SystemColors.ActiveCaption
        LabelDialogBox.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDialogBox.Location = New Point(52, 162)
        LabelDialogBox.Name = "LabelDialogBox"
        LabelDialogBox.Padding = New Padding(2)
        LabelDialogBox.Size = New Size(128, 41)
        LabelDialogBox.TabIndex = 5
        LabelDialogBox.Visible = False
        ' 
        ' LabelDialogEnd
        ' 
        LabelDialogEnd.BackColor = SystemColors.ActiveCaption
        LabelDialogEnd.Font = New Font("Wingdings", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        LabelDialogEnd.ForeColor = Color.SaddleBrown
        LabelDialogEnd.Location = New Point(203, 162)
        LabelDialogEnd.Name = "LabelDialogEnd"
        LabelDialogEnd.Size = New Size(39, 38)
        LabelDialogEnd.TabIndex = 6
        LabelDialogEnd.Text = "û"
        ' 
        ' TimerDialogAnimation
        ' 
        ' 
        ' PanelOptionsMenu
        ' 
        PanelOptionsMenu.BackColor = Color.Gray
        PanelOptionsMenu.Controls.Add(Label5)
        PanelOptionsMenu.Controls.Add(Label4)
        PanelOptionsMenu.Controls.Add(ButtonMusicOff)
        PanelOptionsMenu.Controls.Add(ButtonMusicOn)
        PanelOptionsMenu.Controls.Add(Label1)
        PanelOptionsMenu.Location = New Point(552, 27)
        PanelOptionsMenu.Name = "PanelOptionsMenu"
        PanelOptionsMenu.Size = New Size(265, 287)
        PanelOptionsMenu.TabIndex = 7
        PanelOptionsMenu.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(59, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 25)
        Label5.TabIndex = 11
        Label5.Text = "Nothing here yet"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Green
        Label4.Location = New Point(103, 1)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 25)
        Label4.TabIndex = 10
        Label4.Text = "' Options Panel"
        Label4.Visible = False
        ' 
        ' ButtonMusicOff
        ' 
        ButtonMusicOff.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonMusicOff.Location = New Point(142, 177)
        ButtonMusicOff.Name = "ButtonMusicOff"
        ButtonMusicOff.Size = New Size(55, 37)
        ButtonMusicOff.TabIndex = 2
        ButtonMusicOff.Text = "Off"
        ButtonMusicOff.UseVisualStyleBackColor = True
        ButtonMusicOff.Visible = False
        ' 
        ' ButtonMusicOn
        ' 
        ButtonMusicOn.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonMusicOn.Location = New Point(79, 177)
        ButtonMusicOn.Name = "ButtonMusicOn"
        ButtonMusicOn.Size = New Size(55, 37)
        ButtonMusicOn.TabIndex = 1
        ButtonMusicOn.Text = "On"
        ButtonMusicOn.UseVisualStyleBackColor = True
        ButtonMusicOn.Visible = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Tan
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(90, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 40)
        Label1.TabIndex = 0
        Label1.Text = "Menu"
        Label1.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.RosyBrown
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Green
        Label3.Location = New Point(61, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 25)
        Label3.TabIndex = 9
        Label3.Text = "' Main Picture"
        Label3.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1264, 681)
        Controls.Add(ButtonMainMenu)
        Controls.Add(Label3)
        Controls.Add(PanelOptionsMenu)
        Controls.Add(ButtonIngredientB)
        Controls.Add(ButtonIngredientA)
        Controls.Add(PanelStart)
        Controls.Add(LabelDialogEnd)
        Controls.Add(LabelDialogBox)
        Controls.Add(PictureBoxMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "Form1"
        Text = "Form1"
        PanelStart.ResumeLayout(False)
        PanelStart.PerformLayout()
        CType(PictureBoxTitle, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxStart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxMain, ComponentModel.ISupportInitialize).EndInit()
        PanelOptionsMenu.ResumeLayout(False)
        PanelOptionsMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PanelStart As Panel
    Friend WithEvents PictureBoxStart As PictureBox
    Friend WithEvents PictureBoxTitle As PictureBox
    Friend WithEvents ButtonIngredientA As Button
    Friend WithEvents ButtonIngredientB As Button
    Friend WithEvents PictureBoxMain As PictureBox
    Friend WithEvents ButtonMainMenu As Button
    Friend WithEvents LabelDialogBox As Label
    Friend WithEvents LabelDialogEnd As Label
    Friend WithEvents TimerDialogAnimation As Timer
    Friend WithEvents PanelOptionsMenu As Panel
    Friend WithEvents ButtonMusicOff As Button
    Friend WithEvents ButtonMusicOn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelStartButton As Label
    Friend WithEvents Label5 As Label
End Class
