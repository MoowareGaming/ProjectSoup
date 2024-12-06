Imports System.IO
Imports System.Media

Public Class Form1
    ' Declare arrays to hold paths or indexes
    Private imageFiles As String()
    Private currentImageIndex As Integer = 0
    Private currentDialogIndex As Integer = 0
    ' Booleans
    Private IngredientA As Boolean = False
    Private IngredientB As Boolean = False

    ' Dialog stuff
    Private Dialogs As List(Of String)
    Private dialogText As String ' The full dialog text
    Private currentIndex As Integer ' Current position in the text
    Private isWriting As Boolean ' Tracks if the writing animation is in progress
    Private Speednormal As Integer = 50
    Private Speedfast As Integer = 5

    Public MyUiDirectory As String = Path.Combine(Application.StartupPath, "Soup_Data\ui")
    Public MyImageDirectory As String = Path.Combine(Application.StartupPath, "Soup_Data\scene")
    Public MyAudioDirectory As String = Path.Combine(Application.StartupPath, "Soup_Data\audio")
    Public MyDialogDirectory As String = Path.Combine(Application.StartupPath, "Soup_Data\text")
    Public ClickPath As String = MyAudioDirectory + "\click.wav"
    Public MyWindowSize As New Size(1280, 720)
    Public MyBackgroundColor As Color = Color.FromArgb(184, 132, 88)
    Public MyForeColor As Color = Color.FromArgb(235, 145, 68)
    Public MyOtherColor As Color = Color.FromArgb(66, 38, 56) ' Dark Purple

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeMyPropeties()
        LoadDialogs() ' Create dialog array from file
        LoadSceneImages() ' Load Images
        DisplayImage(imageFiles(1)) ' Display first image
        ResetIngredients() 'Set all Ingredients to False
        PanelStart.Visible = True 'Start panel visable
    End Sub

    ' ### START
    Private Sub PlayClickSound()
        Dim player As New SoundPlayer(ClickPath)
        player.Play()
    End Sub

    ' ### END 
    Private Sub InitializeMyPropeties()
        'Form1 Resize
        Me.Size = New Size(MyWindowSize)

        ' Start Panel Properties
        PanelStart.BackColor = MyBackgroundColor
        PanelStart.Top = 0
        PanelStart.Left = 0
        PanelStart.Size = New Size(MyWindowSize)
        PanelStart.ForeColor = MyForeColor

        ' Start Panel Picture Box Properties
        PictureBoxStart.BackColor = MyBackgroundColor
        PictureBoxStart.Top = 0
        PictureBoxStart.Left = 0
        PictureBoxStart.Size = MyWindowSize
        PanelStart.ForeColor = MyForeColor

        ' Start Button Properties
        LabelStartButton.Size = New Size(Image.FromFile(MyUiDirectory + "\start_button_smaller.png").Size)
        LabelStartButton.Top = (720 - LabelStartButton.Height) - 75
        LabelStartButton.Left = (1280 - LabelStartButton.Width) - 75
        LabelStartButton.Text = ""

        ' Title Picture Box Properties
        PictureBoxTitle.BackColor = System.Drawing.Color.Transparent
        PictureBoxTitle.Size = New Size(Image.FromFile(MyUiDirectory + "\title.png").Size)
        PictureBoxTitle.Top = 0
        PictureBoxTitle.Left = 640 - (PictureBoxTitle.Width / 2)

        ' Main Picture Box Properties
        PictureBoxMain.BackColor = MyBackgroundColor
        PictureBoxMain.Top = -30
        PictureBoxMain.Left = 0
        PictureBoxMain.Size = New Size(1280, 720)

        ' Dialog Box
        LabelDialogBox.Height = 35 ' Height * Set this before end sybol height 
        LabelDialogBox.Width = 650 ' Width
        LabelDialogBox.Top = 640 ' Top
        LabelDialogBox.Left = 640 - (LabelDialogBox.Width / 2)
        LabelDialogBox.BackColor = MyOtherColor
        LabelDialogBox.ForeColor = MyForeColor
        LabelDialogBox.Text = ""

        ' Dialog Box End Symbol
        LabelDialogEnd.Left = LabelDialogBox.Right - 40
        LabelDialogEnd.Top = LabelDialogBox.Top
        LabelDialogEnd.ForeColor = MyForeColor
        LabelDialogEnd.BackColor = MyOtherColor
        LabelDialogEnd.ForeColor = MyForeColor
        LabelDialogEnd.Height = LabelDialogBox.Height

        ' Options Menu Button
        ButtonMainMenu.Top = 20
        ButtonMainMenu.Left = 1130
        ButtonMainMenu.ForeColor = MyForeColor
        ButtonMainMenu.AutoSize = True

        ' Options Panel 
        PanelOptionsMenu.Left = (ButtonMainMenu.Left - PanelOptionsMenu.Width) - 10
        PanelOptionsMenu.Top = ButtonMainMenu.Top
        PanelOptionsMenu.ForeColor = MyForeColor

        ' Ingredient Buttons
        ButtonIngredientA.Top = 430 ' A Top
        ButtonIngredientB.Top = 430 ' B Top
        ButtonIngredientA.ForeColor = MyForeColor
        ButtonIngredientA.BackColor = MyOtherColor

        ButtonIngredientA.Left = 410 ' A Left
        ButtonIngredientB.Left = 790 ' B Left
        ButtonIngredientB.ForeColor = MyForeColor
        ButtonIngredientB.BackColor = MyOtherColor
        ButtonIngredientA.Visible = False
        ButtonIngredientB.Visible = False






    End Sub

    ' Method to start animated writing
    Private Sub StartDialogAnimation(text As String)
        If isWriting Then Return ' Prevent overlapping animations
        LabelDialogEnd.Visible = False ' Make dialog X hidden when writing
        dialogText = text ' Set the full text
        currentIndex = 0 ' Reset the index
        LabelDialogBox.Text = "" ' Clear the label
        isWriting = True
        TimerDialogAnimation.Start() ' Start the Timer
        TimerDialogAnimation.Interval = Speednormal ' Reset speed to normal
    End Sub

    ' Timer tick event for animating the writing
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerDialogAnimation.Tick
        If dialogText IsNot Nothing Then
            If currentIndex < dialogText.Length Then
                ' Append the next character to the label
                LabelDialogBox.Text &= dialogText(currentIndex)
                currentIndex += 1
            Else
                ' Stop the animation when all text is displayed
                TimerDialogAnimation.Stop()
                isWriting = False
                LabelDialogEnd.Visible = True ' Make X appear for dialog box
            End If
        End If
    End Sub


    Private Sub LoadSceneImages()
        ' Scene Image Array creation
        ' Check if image directory exists
        If Directory.Exists(MyImageDirectory) Then
            ' Load all PNG files in the folder
            imageFiles = Directory.GetFiles(MyImageDirectory, "*.png").
                              OrderBy(Function(file) file).
                              ToArray()
        Else
            MessageBox.Show("image folder not found: " & MyImageDirectory)
        End If

        ' Add image to start panel picture box
        PictureBoxStart.Image = Image.FromFile(imageFiles(0))

        ' Add image to start title image
        PictureBoxTitle.Image = Image.FromFile(MyUiDirectory + "\title.png")
        PictureBoxTitle.BackColor = System.Drawing.Color.Transparent

        ' Start Button texture
        LabelStartButton.BackgroundImage = Image.FromFile(MyUiDirectory + "\start_button_smaller.png")
    End Sub

    ' Method to display an image in PictureBox1
    Private Sub DisplayImage(imagePath As String)
        If IO.File.Exists(imagePath) Then
            PictureBoxMain.Image = Image.FromFile(imagePath)
        Else
            MessageBox.Show("Error loading image.")
        End If
    End Sub

    ' Button to toggle options menu visibility
    Private Sub OptionsButton_Click(sender As Object, e As EventArgs) Handles ButtonMainMenu.Click

        PanelOptionsMenu.Visible = Not PanelOptionsMenu.Visible
        Update()
    End Sub


    'Click Event Handler
    Private Sub ClickEvent()

        If isWriting Then ' If the dialog box is still writing, speed it up, and skip rest of method.
            TimerDialogAnimation.Interval = Speedfast
            Return
        End If

        AdvanceScene()

    End Sub

    Private Sub AdvanceScene()
        ' BEFORE
        ' Get file name before scene advancement to see if anything should happen 
        Dim fileNameBefore As String = IO.Path.GetFileName(imageFiles(currentImageIndex))

        ' If Ingredients are false but the Ingredient buttons are still visable, Return to wait for user to click buttons.
        If ButtonIngredientA.Visible = True And IngredientA = False And IngredientB = False Then
            Return
        End If

        ' Scene 8
        If fileNameBefore = "i8.png" Then
            ResetIngredients()
        End If

        ' Scene 6
        If fileNameBefore = "i6.png" Then
            currentImageIndex += 1 ' +1 to index so we skip i7
        End If

        ' Scene 5
        If fileNameBefore = "i5.png" And IngredientA = True Then
            currentImageIndex += 0 ' placeholder. Not changing index since desired image is next anyways. 
        End If
        If fileNameBefore = "i5.png" And IngredientB = True Then
            currentImageIndex += 1 ' +1 to index so we skip i6 
        End If

        ' ADVANCE
        ' Check if there are images in the array
        If imageFiles IsNot Nothing AndAlso imageFiles.Length > 0 Then
            ' Increment the index to display the next image
            currentImageIndex = (currentImageIndex + 1) Mod imageFiles.Length
            DisplayImage(imageFiles(currentImageIndex))
        End If

        StartDialogAnimation(GetDialog(currentImageIndex)) ' Start dialog animation 

        ' AFTER
        'Get file name after scene advancement to see if anything special needs to happen
        Dim fileNameAfter As String = IO.Path.GetFileName(imageFiles(currentImageIndex))

        'if new-scene #, do stuff
        If fileNameAfter = "i3.png" Then
            ButtonIngredientA.Visible = True
            ButtonIngredientB.Visible = True
        End If

        If fileNameAfter = "i4.png" Then
            ButtonIngredientA.Visible = False
            ButtonIngredientB.Visible = False
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxMain.Click
        If isWriting Then
            TimerDialogAnimation.Interval = Speedfast
            Return
        End If

        If ButtonIngredientA.Visible Then Return

        ClickEvent()
    End Sub

    Private Sub LabelDialog_Click(sender As Object, e As EventArgs) Handles LabelDialogBox.Click
        If isWriting Then
            TimerDialogAnimation.Interval = Speedfast
            Return
        End If

        If ButtonIngredientA.Visible Then Return

        ClickEvent()
    End Sub

    Private Sub LabelDialogEnd_Click(sender As Object, e As EventArgs) Handles LabelDialogEnd.Click
        If isWriting Then
            TimerDialogAnimation.Interval = Speedfast
            Return
        End If

        If ButtonIngredientA.Visible Then Return

        ClickEvent()
    End Sub


    Private Sub ButtonIngredientA_Click(sender As Object, e As EventArgs) Handles ButtonIngredientA.Click
        If isWriting = True Then
            ClickEvent()
            Return
        Else
            IngredientA = True

            ClickEvent()
        End If
        PlayClickSound()
    End Sub

    Private Sub ButtonIngredientB_Click(sender As Object, e As EventArgs) Handles ButtonIngredientB.Click
        If isWriting = True Then
            ClickEvent()
            Return
        Else
            IngredientB = True

            ClickEvent()
        End If
        PlayClickSound()
    End Sub

    ' Start Button Logic 

    Private Sub LabelStartButton_Click(sender As Object, e As EventArgs) Handles LabelStartButton.Click

        '+1 to image index since the first one was used on start panel
        currentImageIndex += 1

        'Make dialog box visable
        LabelDialogBox.Visible = True

        'Hide start panel
        PanelStart.Visible = False

        StartDialogAnimation(GetDialog(currentImageIndex)) 'Start dialog animation
        PlayClickSound()
    End Sub

    Private Sub ResetIngredients()
        IngredientA = False
        IngredientB = False
    End Sub

    ' Ensure proper disposal of resources
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        'StopBackgroundMusic()
    End Sub



    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub LoadDialogs()
        Dim dialogpath As String = MyDialogDirectory + "\dialogs.txt"

        If File.Exists(dialogpath) Then
            ' Read all the dialog content
            Dim dialogContent As String = File.ReadAllText(dialogpath)

            ' Split the content into sections using '###' as the delimiter
            Dialogs = dialogContent.Split(New String() {"###"}, StringSplitOptions.RemoveEmptyEntries).
                                         Select(Function(s) s.Trim()).ToList()
        Else
            MessageBox.Show("Dialog file not found in the data folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Get dialog by index
    Private Function GetDialog(index As Integer) As String
        If index >= 0 AndAlso index < Dialogs.Count Then
            Return Dialogs(index)
        Else
            Return "Dialog not found."
        End If
    End Function

    ' Total number of dialogs
    Private Function GetTotalDialogs() As Integer
        Return Dialogs.Count
    End Function


End Class
