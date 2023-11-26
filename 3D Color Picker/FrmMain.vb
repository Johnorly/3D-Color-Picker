Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL
Public Class FrmMain
    Dim xTrue As Boolean = False
    Dim yTrue As Boolean = False
    Dim SelColorBox, CorBox1, CorBox2 As Color
    Dim iPick, iCurPick As Integer
    Dim iSpeed As Integer
    Dim cIndx As Integer = 0

    Private Sub GlControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GlControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            End
        ElseIf e.KeyCode = Keys.Space Then
            BtnStart.PerformClick()
        End If
    End Sub

    Private Sub GlControl1_Load(sender As Object, e As EventArgs) Handles GlControl1.Load
        GL.ClearColor(Color.Black)
        SelColorBox = Color.FromName("Red")
        CorBox1 = Color.FromName("DarkRed")
        CorBox2 = Color.FromName("IndianRed")
    End Sub

    Dim sTrColor As String

    Private Sub Tmr3D_Tick(sender As Object, e As EventArgs) Handles Tmr3D.Tick
        'first clear buffers
        GL.Clear(ClearBufferMask.ColorBufferBit)
        GL.Clear(ClearBufferMask.DepthBufferBit)

        'basic setup for viewing
        'Dim perspective As Matrix4 = Matrix4.CreatePerspectiveFieldOfView(1.04, 4 / 3, 1, 10000) 'setup perspective
        'Dim lookAt1 As Matrix4 = Matrix4.LookAt(350, 130, 0, 0, 0, 0, 0, 1, 0) 'setup camera
        Dim perspective As Matrix4 = Matrix4.CreatePerspectiveFieldOfView(1.04, 4 / 3, 1, 10000) 'setup perspective
        'Dim lookAt1 As Matrix4 = Matrix4.LookAt(numEx.Value, numEy.Value, numEz.Value, numtX.Value, numty.Value, numtZ.Value, numUX.Value, numUY.Value, numUZ.Value) 'setup camera
        'Dim lookAt2 As Matrix4 = Matrix4.LookAt(350, 130, 0, 0, 0, 0, 5, 1, 70) 'setup camera

        NumPosX.Value = (GlControl1.Width - 100.0F) * 0.1
        NumPosY.Value = (GlControl1.Height - 100.0F) * 0.1


        Dim x = numtX.Value
        Dim y = numtY.Value


        'We get the position of the mouse cursor, so that we can move the box accordingly
        'Dim x = MousePosition.X * 200.0F / GlControl1.Width - 100.0F
        'Dim y = -MousePosition.Y * 200.0F / GlControl1.Height + 100.0F
        'numtX.Value = x
        'numtY.Value = y

        GL.MatrixMode(MatrixMode.Projection) ' load perspective 
        GL.LoadIdentity()
        GL.LoadMatrix(perspective)
        GL.MatrixMode(MatrixMode.Modelview) 'load Camera
        GL.LoadIdentity()
        'GL.LoadMatrix(lookAt1)
        GL.Translate(x, y, numtZ.Value)


        GL.Viewport(0, 0, GlControl1.Width, GlControl1.Height) 'size of window
        GL.Enable(EnableCap.DepthTest) ' enable correct Z drawing
        GL.DepthFunc(DepthFunction.Less) ' enable correct Z drawing


        ''Rotating using mouse
        'GL.Rotate(MousePosition.X, 0, 0, 1)
        'GL.Rotate(MousePosition.Y, 0, 1, 0)

        'Rotating
        GL.Rotate(NumericUpDown1.Value, 0, 0, 1)
        GL.Rotate(NumericUpDown2.Value, 0, 1, 0)

        'Auto Rotate
        NumericUpDown1.Value = NumericUpDown1.Value + 2
        NumericUpDown2.Value = NumericUpDown2.Value + 2

        QuadFace()

        'finish the begin mode with "end"
        GL.End()

        'finally
        GraphicsContext.CurrentContext.ErrorChecking = True 'caps frame rate as to not over run GPU
        GlControl1.SwapBuffers() 'takes from the GL and puts into control
    End Sub


    Public Sub QuadFace()
        'draw pyramid Y is up Z is towards you, X is left n right
        'vertex goes (X,Y,Z)
        GL.Begin(BeginMode.Quads)

        'face up
        GL.Color3(SelColorBox)
        GL.Vertex3(-50, 70, 0)
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 70, -50)
        GL.Color3(SelColorBox)
        GL.Vertex3(50, 70, 0)
        GL.Color3(CorBox1)
        GL.Vertex3(0, 70, 50)

        'face down
        GL.Color3(SelColorBox)
        GL.Vertex3(-50, 0, 0)
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 0, -50)
        GL.Color3(SelColorBox)
        GL.Vertex3(50, 0, 0)
        GL.Color3(CorBox2)
        GL.Vertex3(0, 0, 50)

        'face Side 1
        GL.Color3(SelColorBox)
        GL.Vertex3(50, 70, 0)
        GL.Color3(SelColorBox)
        GL.Vertex3(50, 0, 0)
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 0, -50)
        GL.Color3(CorBox1)
        GL.Vertex3(0, 70, -50)

        'face Side 2
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 70, 50)
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 0, 50)
        GL.Color3(SelColorBox)
        GL.Vertex3(50, 0, 0)
        GL.Color3(CorBox2)
        GL.Vertex3(50, 70, 0)

        'face Side 3
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 70, 50)
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 0, 50)
        GL.Color3(SelColorBox)
        GL.Vertex3(-50, 0, 0)
        GL.Color3(CorBox1)
        GL.Vertex3(-50, 70, 0)

        'face Side 4
        GL.Color3(SelColorBox)
        GL.Vertex3(-50, 70, 0)
        GL.Color3(SelColorBox)
        GL.Vertex3(-50, 0, 0)
        GL.Color3(SelColorBox)
        GL.Vertex3(0, 0, -50)
        GL.Color3(CorBox2)
        GL.Vertex3(0, 70, -50)

    End Sub


    Public Sub LoadColorList()
        DgvColor.Rows.Clear()
        Try
            Dim filename As String = Application.StartupPath & "\ColorList.txt"
            Dim TxtLine1 As String
            Dim TxtLineS(3) As String


            If System.IO.File.Exists(filename) = True Then

                Dim ReadAline As New System.IO.StreamReader(filename)

                Do While ReadAline.Peek() <> -1
                    TxtLine1 = ReadAline.ReadLine.Replace(" ", "")
                    TxtLineS = Split(TxtLine1, ",")
                    DgvColor.Rows.Add(TxtLineS(0), TxtLineS(1), TxtLineS(2), TxtLineS(3))
                Loop
                'sDatabase = TextLine & "Database.accdb"

                ReadAline.Close()

            Else
                MsgBox("File Does Not Exist.")
                End
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'DgvColor.Rows.Add("Red", "Red", "DarkRed", "IndianRed")
        'DgvColor.Rows.Add("Orange", "OrangeRed", "DarkOrange", "Orange")
        'DgvColor.Rows.Add("Yellow", "Yellow", "Goldenrod", "Gold")
        'DgvColor.Rows.Add("Green", "Green", "DarkGreen", "LimeGreen")
        ''DgvColor.Rows.Add("Blue", "Blue", "DarkBlue", "LightSkyBlue")
        ''DgvColor.Rows.Add("Violet", "Purple", "DarkMagenta", "Violet")
        ''DgvColor.Rows.Add("Pink", "HotPink", "DeepPink", "Pink")

        'Red, Red, DarkRed, IndianRed
        'Orange, OrangeRed, DarkOrange, Orange
        'Yellow, Yellow, Goldenrod, Gold
        'Green, Green, DarkGreen, LimeGreen
        'Blue, Blue, DarkBlue, LightSkyBlue
        'Violet, Purple, DarkMagenta, Violet
    End Sub

    Public Sub GetColor()
        If DgvColor.Rows.Count = 0 Then
            StopPicking()
            MsgBox("List of Colors has been Picked!")
            LoadColorList()
        End If
        ' Dim iRnd As Integer = Rnd(DgvColor.Rows.Count)
        If iCurPick = iPick And DgvColor.Rows.Count > 1 Then
            If DgvColor.Rows.Count - 1 <= iPick Then
                iPick -= 1
            Else
                iPick += 1
            End If
        End If
        iCurPick = iPick
        My.Computer.Audio.Play(Application.StartupPath & "\bounce 1.wav")

        With DgvColor.Rows(iCurPick)
            sTrColor = .Cells(0).Value
            SelColorBox = Color.FromName(.Cells(1).Value)
            CorBox1 = Color.FromName(.Cells(2).Value)
            CorBox2 = Color.FromName(.Cells(3).Value)
        End With

    End Sub

    Public Sub StartPicking()
        BtnStart.Text = "Stop"
        BtnStart.BackColor = Color.Red
        TmrColorPick.Enabled = True
        TmrTop.Enabled = True
        TmrLeft.Enabled = True
    End Sub

    Public Sub StopPicking()
        BtnStart.Text = "Start"
        BtnStart.BackColor = Color.Green
        TmrBottom.Enabled = False
        TmrTop.Enabled = False
        TmrLeft.Enabled = False
        TmrRight.Enabled = False
        TmrColorPick.Enabled = False

    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        numtX.Value -= iSpeed
        If numtX.Value < -NumPosX.Value Then
            numtX.Value = -NumPosX.Value + 5
            TmrRight.Enabled = True
            TmrLeft.Enabled = False
            GetColor()
        End If

    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        numtX.Value += iSpeed
        If numtX.Value > NumPosX.Value Then
            numtX.Value = NumPosX.Value - 5
            TmrRight.Enabled = False
            TmrLeft.Enabled = True
            GetColor()
        End If
    End Sub

    Private Sub TmrTop_Tick(sender As Object, e As EventArgs) Handles TmrTop.Tick
        numtY.Value += iSpeed
        If numtY.Value > NumPosY.Value Then
            numtY.Value = NumPosY.Value - 5
            TmrTop.Enabled = False
            TmrBottom.Enabled = True
            GetColor()
        End If
    End Sub

    Private Sub TmrBottom_Tick(sender As Object, e As EventArgs) Handles TmrBottom.Tick
        numtY.Value -= iSpeed
        If numtY.Value < -NumPosY.Value Then
            numtY.Value = -NumPosY.Value + 5
            TmrTop.Enabled = True
            TmrBottom.Enabled = False
            GetColor()
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If BtnStart.Text = "Start" Then
            LblColor.Visible = False
            StartPicking()
        ElseIf BtnStart.Text = "Stop" Then
            StopPicking()
            LblColor.BackColor = SelColorBox
            LblColor.Text = "You Picked Color " & sTrColor & "!"
            LblColor.Visible = True
            numtX.Value = 0
            numtY.Value = 0
            My.Computer.Audio.Play(Application.StartupPath & "\Tada 1.wav")
            DgvColor.Rows.RemoveAt(iCurPick)
        End If
    End Sub

    Private Sub TxtZoom_TextChanged(sender As Object, e As EventArgs) Handles TxtZoom.TextChanged
        If IsNumeric(TxtZoom.Text) = True Then
            numtZ.Value = TxtZoom.Text
            TBzoom.Value = TxtZoom.Text
        End If
    End Sub

    Private Sub TBzoom_Scroll(sender As Object, e As EventArgs) Handles TBzoom.Scroll
        TxtZoom.Text = TBzoom.Value
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        numtX.Value = 0
        numtY.Value = 0
        LblColor.Visible = False
        LoadColorList()
        iPick = 0
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlControl1.Width = Me.Width
        GlControl1.Height = Me.Height
        NumWidth.Value = GlControl1.Width
        NumHeight.Value = GlControl1.Height

        LoadColorList()
        iPick = 0
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub FrmMain_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin

        GlControl1.Width = Me.Width
        GlControl1.Height = Me.Height
        NumWidth.Value = GlControl1.Width
        NumHeight.Value = GlControl1.Height
    End Sub

    Private Sub TmrColorPick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrColorPick.Tick
        iPick += 1
        If iPick >= DgvColor.Rows.Count Then
            iPick = 0
        End If
    End Sub

    Private Sub TxtSpeed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSpeed.TextChanged
        If IsNumeric(TxtSpeed.Text) Then
            iSpeed = TxtSpeed.Text
            TBSpeed.Value = TxtSpeed.Text
        Else
            iSpeed = 10
        End If

    End Sub

    Private Sub BtnColorList_Click(sender As Object, e As EventArgs) Handles BtnColorList.Click
        PnlColorList.Visible = True
        PnlColorList.Left = 100

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PnlColorList.Visible = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            DgvColor.Rows.RemoveAt(cIndx)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        DgvColor.Rows.Add(" ", " ", " ", " ")
    End Sub

    Private Sub DgvColor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvColor.CellContentClick

    End Sub

    Private Sub TBSpeed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBSpeed.KeyDown
        If e.KeyData = Keys.Space Then
            BtnStart.PerformClick()
        End If
    End Sub

    Private Sub TBSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSpeed.Scroll
        TxtSpeed.Text = TBSpeed.Value
    End Sub

    Private Sub TBzoom_KeyDown(sender As Object, e As KeyEventArgs) Handles TBzoom.KeyDown
        If e.KeyData = Keys.Space Then
            BtnStart.PerformClick()
        End If
    End Sub

    Private Sub DgvColor_Click(sender As Object, e As EventArgs) Handles DgvColor.Click, DgvColor.KeyUp
        On Error Resume Next
        cIndx = DgvColor.SelectedRows.Item(0).Index
    End Sub
End Class
