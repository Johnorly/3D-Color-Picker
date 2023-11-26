<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.GlControl1 = New OpenTK.GLControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtZoom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBzoom = New System.Windows.Forms.TrackBar()
        Me.TBSpeed = New System.Windows.Forms.TrackBar()
        Me.TxtSpeed = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnColorList = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrTop = New System.Windows.Forms.Timer(Me.components)
        Me.TmrBottom = New System.Windows.Forms.Timer(Me.components)
        Me.TmrCenterPlus = New System.Windows.Forms.Timer(Me.components)
        Me.TmrCenterMinus = New System.Windows.Forms.Timer(Me.components)
        Me.TmrColorPick = New System.Windows.Forms.Timer(Me.components)
        Me.DgvColor = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tmr3D = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumPosY = New System.Windows.Forms.NumericUpDown()
        Me.NumPosX = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumHeight = New System.Windows.Forms.NumericUpDown()
        Me.NumWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numEz = New System.Windows.Forms.NumericUpDown()
        Me.numEy = New System.Windows.Forms.NumericUpDown()
        Me.numEx = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUZ = New System.Windows.Forms.NumericUpDown()
        Me.numUY = New System.Windows.Forms.NumericUpDown()
        Me.numUX = New System.Windows.Forms.NumericUpDown()
        Me.numtZ = New System.Windows.Forms.NumericUpDown()
        Me.numtY = New System.Windows.Forms.NumericUpDown()
        Me.numtX = New System.Windows.Forms.NumericUpDown()
        Me.PnlColorList = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.TBzoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumPosY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPosX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numtZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numtY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numtX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlColorList.SuspendLayout()
        Me.SuspendLayout()
        '
        'GlControl1
        '
        Me.GlControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GlControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GlControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GlControl1.Location = New System.Drawing.Point(0, 0)
        Me.GlControl1.Name = "GlControl1"
        Me.GlControl1.Size = New System.Drawing.Size(1008, 637)
        Me.GlControl1.TabIndex = 0
        Me.GlControl1.VSync = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.TxtZoom)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TBzoom)
        Me.Panel1.Controls.Add(Me.TBSpeed)
        Me.Panel1.Controls.Add(Me.TxtSpeed)
        Me.Panel1.Controls.Add(Me.BtnReset)
        Me.Panel1.Controls.Add(Me.BtnColorList)
        Me.Panel1.Controls.Add(Me.BtnStart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 563)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 74)
        Me.Panel1.TabIndex = 1
        '
        'TxtZoom
        '
        Me.TxtZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtZoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZoom.Location = New System.Drawing.Point(619, 23)
        Me.TxtZoom.Name = "TxtZoom"
        Me.TxtZoom.Size = New System.Drawing.Size(78, 31)
        Me.TxtZoom.TabIndex = 18
        Me.TxtZoom.Text = "-250"
        Me.TxtZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(355, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(258, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "- Speed +"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(703, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(293, 23)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "- Zoom +"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBzoom
        '
        Me.TBzoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBzoom.Location = New System.Drawing.Point(703, 23)
        Me.TBzoom.Maximum = 1000
        Me.TBzoom.Minimum = -1000
        Me.TBzoom.Name = "TBzoom"
        Me.TBzoom.Size = New System.Drawing.Size(293, 45)
        Me.TBzoom.TabIndex = 15
        Me.TBzoom.TickFrequency = 50
        Me.TBzoom.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TBzoom.Value = -250
        '
        'TBSpeed
        '
        Me.TBSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBSpeed.Location = New System.Drawing.Point(355, 23)
        Me.TBSpeed.Maximum = 30
        Me.TBSpeed.Name = "TBSpeed"
        Me.TBSpeed.Size = New System.Drawing.Size(258, 45)
        Me.TBSpeed.TabIndex = 14
        Me.TBSpeed.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TBSpeed.Value = 1
        '
        'TxtSpeed
        '
        Me.TxtSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSpeed.Location = New System.Drawing.Point(302, 23)
        Me.TxtSpeed.Name = "TxtSpeed"
        Me.TxtSpeed.Size = New System.Drawing.Size(57, 31)
        Me.TxtSpeed.TabIndex = 13
        Me.TxtSpeed.Text = "1"
        Me.TxtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.BackColor = System.Drawing.Color.DarkRed
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.Location = New System.Drawing.Point(172, 42)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(114, 26)
        Me.BtnReset.TabIndex = 12
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnColorList
        '
        Me.BtnColorList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnColorList.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnColorList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnColorList.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnColorList.ForeColor = System.Drawing.Color.White
        Me.BtnColorList.Location = New System.Drawing.Point(172, 10)
        Me.BtnColorList.Name = "BtnColorList"
        Me.BtnColorList.Size = New System.Drawing.Size(114, 26)
        Me.BtnColorList.TabIndex = 11
        Me.BtnColorList.Text = "Color List"
        Me.BtnColorList.UseVisualStyleBackColor = False
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnStart.BackColor = System.Drawing.Color.Green
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnStart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(9, 10)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(157, 59)
        Me.BtnStart.TabIndex = 10
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'LblColor
        '
        Me.LblColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblColor.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColor.Location = New System.Drawing.Point(12, 9)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(984, 61)
        Me.LblColor.TabIndex = 25
        Me.LblColor.Text = "You Picked Color Violet"
        Me.LblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblColor.Visible = False
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 1
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 1
        '
        'TmrTop
        '
        Me.TmrTop.Interval = 1
        '
        'TmrBottom
        '
        Me.TmrBottom.Interval = 1
        '
        'TmrCenterPlus
        '
        Me.TmrCenterPlus.Interval = 1
        '
        'TmrCenterMinus
        '
        Me.TmrCenterMinus.Interval = 1
        '
        'TmrColorPick
        '
        Me.TmrColorPick.Interval = 10
        '
        'DgvColor
        '
        Me.DgvColor.AllowUserToAddRows = False
        Me.DgvColor.AllowUserToDeleteRows = False
        Me.DgvColor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvColor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4})
        Me.DgvColor.Location = New System.Drawing.Point(4, 41)
        Me.DgvColor.Name = "DgvColor"
        Me.DgvColor.Size = New System.Drawing.Size(422, 177)
        Me.DgvColor.TabIndex = 26
        '
        'Column2
        '
        Me.Column2.HeaderText = "Color Name"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Color1"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Color2"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Color3"
        Me.Column4.Name = "Column4"
        '
        'Tmr3D
        '
        Me.Tmr3D.Enabled = True
        Me.Tmr3D.Interval = 10
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(7, 410)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 28
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(7, 384)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NumPosY)
        Me.Panel2.Controls.Add(Me.NumericUpDown2)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.NumPosX)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.NumHeight)
        Me.Panel2.Controls.Add(Me.NumWidth)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.numEz)
        Me.Panel2.Controls.Add(Me.numEy)
        Me.Panel2.Controls.Add(Me.numEx)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.numUZ)
        Me.Panel2.Controls.Add(Me.numUY)
        Me.Panel2.Controls.Add(Me.numUX)
        Me.Panel2.Controls.Add(Me.numtZ)
        Me.Panel2.Controls.Add(Me.numtY)
        Me.Panel2.Controls.Add(Me.numtX)
        Me.Panel2.Location = New System.Drawing.Point(9, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(154, 441)
        Me.Panel2.TabIndex = 29
        Me.Panel2.Visible = False
        '
        'NumPosY
        '
        Me.NumPosY.Location = New System.Drawing.Point(57, 351)
        Me.NumPosY.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.NumPosY.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.NumPosY.Name = "NumPosY"
        Me.NumPosY.Size = New System.Drawing.Size(76, 20)
        Me.NumPosY.TabIndex = 25
        Me.NumPosY.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumPosX
        '
        Me.NumPosX.Location = New System.Drawing.Point(57, 325)
        Me.NumPosX.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.NumPosX.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.NumPosX.Name = "NumPosX"
        Me.NumPosX.Size = New System.Drawing.Size(76, 20)
        Me.NumPosX.TabIndex = 24
        Me.NumPosX.Value = New Decimal(New Integer() {720, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Height"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Width"
        '
        'NumHeight
        '
        Me.NumHeight.Location = New System.Drawing.Point(57, 288)
        Me.NumHeight.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.NumHeight.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.NumHeight.Name = "NumHeight"
        Me.NumHeight.Size = New System.Drawing.Size(76, 20)
        Me.NumHeight.TabIndex = 21
        '
        'NumWidth
        '
        Me.NumWidth.Location = New System.Drawing.Point(57, 262)
        Me.NumWidth.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.NumWidth.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.NumWidth.Name = "NumWidth"
        Me.NumWidth.Size = New System.Drawing.Size(76, 20)
        Me.NumWidth.TabIndex = 20
        Me.NumWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "EyeZ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "EyeY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "EyeX"
        '
        'numEz
        '
        Me.numEz.Location = New System.Drawing.Point(57, 55)
        Me.numEz.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numEz.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numEz.Name = "numEz"
        Me.numEz.Size = New System.Drawing.Size(76, 20)
        Me.numEz.TabIndex = 16
        '
        'numEy
        '
        Me.numEy.Location = New System.Drawing.Point(57, 29)
        Me.numEy.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numEy.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numEy.Name = "numEy"
        Me.numEy.Size = New System.Drawing.Size(76, 20)
        Me.numEy.TabIndex = 15
        Me.numEy.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numEx
        '
        Me.numEx.Location = New System.Drawing.Point(57, 3)
        Me.numEx.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numEx.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numEx.Name = "numEx"
        Me.numEx.Size = New System.Drawing.Size(76, 20)
        Me.numEx.TabIndex = 14
        Me.numEx.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "UpZ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "UpY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "UpX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "targetZ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "targetY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "targetX"
        '
        'numUZ
        '
        Me.numUZ.Location = New System.Drawing.Point(57, 211)
        Me.numUZ.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numUZ.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numUZ.Name = "numUZ"
        Me.numUZ.Size = New System.Drawing.Size(76, 20)
        Me.numUZ.TabIndex = 7
        '
        'numUY
        '
        Me.numUY.Location = New System.Drawing.Point(57, 185)
        Me.numUY.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numUY.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numUY.Name = "numUY"
        Me.numUY.Size = New System.Drawing.Size(76, 20)
        Me.numUY.TabIndex = 6
        Me.numUY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numUX
        '
        Me.numUX.Location = New System.Drawing.Point(57, 159)
        Me.numUX.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numUX.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numUX.Name = "numUX"
        Me.numUX.Size = New System.Drawing.Size(76, 20)
        Me.numUX.TabIndex = 5
        '
        'numtZ
        '
        Me.numtZ.Location = New System.Drawing.Point(57, 133)
        Me.numtZ.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numtZ.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numtZ.Name = "numtZ"
        Me.numtZ.Size = New System.Drawing.Size(76, 20)
        Me.numtZ.TabIndex = 4
        Me.numtZ.Value = New Decimal(New Integer() {250, 0, 0, -2147483648})
        '
        'numtY
        '
        Me.numtY.Location = New System.Drawing.Point(57, 107)
        Me.numtY.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numtY.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numtY.Name = "numtY"
        Me.numtY.Size = New System.Drawing.Size(76, 20)
        Me.numtY.TabIndex = 3
        '
        'numtX
        '
        Me.numtX.Location = New System.Drawing.Point(57, 81)
        Me.numtX.Maximum = New Decimal(New Integer() {1241513983, 370409800, 542101, 0})
        Me.numtX.Minimum = New Decimal(New Integer() {1569325055, 23283064, 0, -2147483648})
        Me.numtX.Name = "numtX"
        Me.numtX.Size = New System.Drawing.Size(76, 20)
        Me.numtX.TabIndex = 2
        '
        'PnlColorList
        '
        Me.PnlColorList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlColorList.Controls.Add(Me.BtnDelete)
        Me.PnlColorList.Controls.Add(Me.BtnAdd)
        Me.PnlColorList.Controls.Add(Me.BtnClose)
        Me.PnlColorList.Controls.Add(Me.DgvColor)
        Me.PnlColorList.Location = New System.Drawing.Point(184, 335)
        Me.PnlColorList.Name = "PnlColorList"
        Me.PnlColorList.Size = New System.Drawing.Size(429, 221)
        Me.PnlColorList.TabIndex = 30
        Me.PnlColorList.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(67, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(57, 32)
        Me.BtnDelete.TabIndex = 28
        Me.BtnDelete.Text = "-"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.BackColor = System.Drawing.Color.Green
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(4, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(57, 32)
        Me.BtnAdd.TabIndex = 28
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(312, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(114, 32)
        Me.BtnClose.TabIndex = 27
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 637)
        Me.Controls.Add(Me.PnlColorList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblColor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GlControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3D Color Picker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TBzoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumPosY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPosX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numtZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numtY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numtX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlColorList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GlControl1 As OpenTK.GLControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBSpeed As TrackBar
    Friend WithEvents TxtSpeed As TextBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnColorList As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents LblColor As Label
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrRight As Timer
    Friend WithEvents TmrTop As Timer
    Friend WithEvents TmrBottom As Timer
    Friend WithEvents TmrCenterPlus As Timer
    Friend WithEvents TmrCenterMinus As Timer
    Friend WithEvents TmrColorPick As Timer
    Friend WithEvents DgvColor As DataGridView
    Friend WithEvents Tmr3D As Timer
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumPosY As NumericUpDown
    Friend WithEvents NumPosX As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents NumHeight As NumericUpDown
    Friend WithEvents NumWidth As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents numEz As NumericUpDown
    Friend WithEvents numEy As NumericUpDown
    Friend WithEvents numEx As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numUZ As NumericUpDown
    Friend WithEvents numUY As NumericUpDown
    Friend WithEvents numUX As NumericUpDown
    Friend WithEvents numtZ As NumericUpDown
    Friend WithEvents numtY As NumericUpDown
    Friend WithEvents numtX As NumericUpDown
    Friend WithEvents TxtZoom As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TBzoom As TrackBar
    Friend WithEvents PnlColorList As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnAdd As Button
End Class
