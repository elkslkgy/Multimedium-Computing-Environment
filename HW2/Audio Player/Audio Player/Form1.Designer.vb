<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonResume = New System.Windows.Forms.Button()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ButtonPre = New System.Windows.Forms.Button()
        Me.ButtonNex = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonLoop = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(12, 445)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOpen.TabIndex = 0
        Me.ButtonOpen.Text = "Open"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Location = New System.Drawing.Point(14, 41)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPlay.TabIndex = 1
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonResume
        '
        Me.ButtonResume.Location = New System.Drawing.Point(95, 41)
        Me.ButtonResume.Name = "ButtonResume"
        Me.ButtonResume.Size = New System.Drawing.Size(75, 23)
        Me.ButtonResume.TabIndex = 2
        Me.ButtonResume.Text = "Resume"
        Me.ButtonResume.UseVisualStyleBackColor = True
        '
        'ButtonPause
        '
        Me.ButtonPause.Location = New System.Drawing.Point(176, 41)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPause.TabIndex = 3
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(257, 41)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStop.TabIndex = 4
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(388, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Volume"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(379, 443)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(136, 45)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.Value = 50
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "wav|*.wav|MP3 files |*.mp3"
        Me.OpenFileDialog1.Multiselect = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(474, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(40, 34)
        Me.AxWindowsMediaPlayer1.TabIndex = 7
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'ButtonPre
        '
        Me.ButtonPre.Location = New System.Drawing.Point(93, 445)
        Me.ButtonPre.Name = "ButtonPre"
        Me.ButtonPre.Size = New System.Drawing.Size(137, 23)
        Me.ButtonPre.TabIndex = 9
        Me.ButtonPre.Text = "Previous"
        Me.ButtonPre.UseVisualStyleBackColor = True
        '
        'ButtonNex
        '
        Me.ButtonNex.Location = New System.Drawing.Point(236, 445)
        Me.ButtonNex.Name = "ButtonNex"
        Me.ButtonNex.Size = New System.Drawing.Size(137, 23)
        Me.ButtonNex.TabIndex = 10
        Me.ButtonNex.Text = "Next"
        Me.ButtonNex.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(474, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(47, 16)
        Me.ListBox1.TabIndex = 11
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(12, 141)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(361, 292)
        Me.ListBox2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(498, 22)
        Me.TextBox1.TabIndex = 13
        '
        'Timer1
        '
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(12, 95)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(361, 45)
        Me.TrackBar2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Position"
        '
        'ButtonLoop
        '
        Me.ButtonLoop.Location = New System.Drawing.Point(338, 41)
        Me.ButtonLoop.Name = "ButtonLoop"
        Me.ButtonLoop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLoop.TabIndex = 16
        Me.ButtonLoop.Text = "單曲播放"
        Me.ButtonLoop.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 12)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "0:0/0:0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 479)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonLoop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonNex)
        Me.Controls.Add(Me.ButtonPre)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.ButtonResume)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(Me.ButtonOpen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ButtonPlay As Button
    Friend WithEvents ButtonResume As Button
    Friend WithEvents ButtonPause As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ButtonPre As Button
    Friend WithEvents ButtonNex As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonLoop As Button
    Friend WithEvents Label3 As Label
End Class
