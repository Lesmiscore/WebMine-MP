<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Onlines = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ReloadPMMP = New System.Windows.Forms.Button()
        Me.DeprivationOP = New System.Windows.Forms.Button()
        Me.GrantOP = New System.Windows.Forms.Button()
        Me.PardonIP = New System.Windows.Forms.Button()
        Me.BanIP = New System.Windows.Forms.Button()
        Me.Pardon = New System.Windows.Forms.Button()
        Me.BANNormally = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.KickOut = New System.Windows.Forms.Button()
        Me.HelpCommand = New System.Windows.Forms.Button()
        Me.PrivateChat = New System.Windows.Forms.Button()
        Me.Teleport = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RestartWhenStopped = New System.Windows.Forms.CheckBox()
        Me.StopPMMPForcely = New System.Windows.Forms.Button()
        Me.StopPMMPSafety = New System.Windows.Forms.Button()
        Me.StartPMMP = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ConfigChanger = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SetCredentials = New System.Windows.Forms.Button()
        Me.StartWMPWhenAppStarted = New System.Windows.Forms.CheckBox()
        Me.StopWMMP = New System.Windows.Forms.Button()
        Me.StartWMMP = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Console = New System.Windows.Forms.WebBrowser()
        Me.DeleteConsole = New System.Windows.Forms.Button()
        Me.ConsoleReader = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(630, 350)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(622, 324)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PocketMine-MP"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Onlines)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(376, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(238, 232)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "稼働状況"
        '
        'Onlines
        '
        Me.Onlines.AutoSize = True
        Me.Onlines.Location = New System.Drawing.Point(134, 18)
        Me.Onlines.Name = "Onlines"
        Me.Onlines.Size = New System.Drawing.Size(0, 12)
        Me.Onlines.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "現在の人数/入れる人数:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ReloadPMMP)
        Me.GroupBox3.Controls.Add(Me.DeprivationOP)
        Me.GroupBox3.Controls.Add(Me.GrantOP)
        Me.GroupBox3.Controls.Add(Me.PardonIP)
        Me.GroupBox3.Controls.Add(Me.BanIP)
        Me.GroupBox3.Controls.Add(Me.Pardon)
        Me.GroupBox3.Controls.Add(Me.BANNormally)
        Me.GroupBox3.Location = New System.Drawing.Point(180, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 309)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "コマンド(重要・危険)"
        '
        'ReloadPMMP
        '
        Me.ReloadPMMP.Location = New System.Drawing.Point(6, 106)
        Me.ReloadPMMP.Name = "ReloadPMMP"
        Me.ReloadPMMP.Size = New System.Drawing.Size(75, 23)
        Me.ReloadPMMP.TabIndex = 7
        Me.ReloadPMMP.Text = "再読み込み"
        Me.ReloadPMMP.UseVisualStyleBackColor = True
        '
        'DeprivationOP
        '
        Me.DeprivationOP.Location = New System.Drawing.Point(97, 78)
        Me.DeprivationOP.Name = "DeprivationOP"
        Me.DeprivationOP.Size = New System.Drawing.Size(87, 23)
        Me.DeprivationOP.TabIndex = 6
        Me.DeprivationOP.Text = "OP権限剥奪"
        Me.DeprivationOP.UseVisualStyleBackColor = True
        '
        'GrantOP
        '
        Me.GrantOP.Location = New System.Drawing.Point(6, 77)
        Me.GrantOP.Name = "GrantOP"
        Me.GrantOP.Size = New System.Drawing.Size(89, 23)
        Me.GrantOP.TabIndex = 5
        Me.GrantOP.Text = "OP権限付与"
        Me.GrantOP.UseVisualStyleBackColor = True
        '
        'PardonIP
        '
        Me.PardonIP.Location = New System.Drawing.Point(84, 48)
        Me.PardonIP.Name = "PardonIP"
        Me.PardonIP.Size = New System.Drawing.Size(100, 23)
        Me.PardonIP.TabIndex = 4
        Me.PardonIP.Text = "永久IP追放解除"
        Me.PardonIP.UseVisualStyleBackColor = True
        '
        'BanIP
        '
        Me.BanIP.Location = New System.Drawing.Point(6, 48)
        Me.BanIP.Name = "BanIP"
        Me.BanIP.Size = New System.Drawing.Size(75, 23)
        Me.BanIP.TabIndex = 3
        Me.BanIP.Text = "永久IP追放"
        Me.BanIP.UseVisualStyleBackColor = True
        '
        'Pardon
        '
        Me.Pardon.Location = New System.Drawing.Point(84, 19)
        Me.Pardon.Name = "Pardon"
        Me.Pardon.Size = New System.Drawing.Size(100, 23)
        Me.Pardon.TabIndex = 2
        Me.Pardon.Text = "永久追放解除"
        Me.Pardon.UseVisualStyleBackColor = True
        '
        'BANNormally
        '
        Me.BANNormally.Location = New System.Drawing.Point(6, 19)
        Me.BANNormally.Name = "BANNormally"
        Me.BANNormally.Size = New System.Drawing.Size(75, 23)
        Me.BANNormally.TabIndex = 1
        Me.BANNormally.Text = "永久追放"
        Me.BANNormally.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.KickOut)
        Me.GroupBox2.Controls.Add(Me.HelpCommand)
        Me.GroupBox2.Controls.Add(Me.PrivateChat)
        Me.GroupBox2.Controls.Add(Me.Teleport)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 202)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "コマンド(基本)"
        '
        'KickOut
        '
        Me.KickOut.Location = New System.Drawing.Point(7, 77)
        Me.KickOut.Name = "KickOut"
        Me.KickOut.Size = New System.Drawing.Size(152, 32)
        Me.KickOut.TabIndex = 3
        Me.KickOut.Text = "プレイヤーを強制的に退出させる"
        Me.KickOut.UseVisualStyleBackColor = True
        '
        'HelpCommand
        '
        Me.HelpCommand.Location = New System.Drawing.Point(84, 19)
        Me.HelpCommand.Name = "HelpCommand"
        Me.HelpCommand.Size = New System.Drawing.Size(75, 23)
        Me.HelpCommand.TabIndex = 2
        Me.HelpCommand.Text = "コマンド一覧"
        Me.HelpCommand.UseVisualStyleBackColor = True
        '
        'PrivateChat
        '
        Me.PrivateChat.Location = New System.Drawing.Point(7, 48)
        Me.PrivateChat.Name = "PrivateChat"
        Me.PrivateChat.Size = New System.Drawing.Size(152, 23)
        Me.PrivateChat.TabIndex = 1
        Me.PrivateChat.Text = "プライベートチャット"
        Me.PrivateChat.UseVisualStyleBackColor = True
        '
        'Teleport
        '
        Me.Teleport.Location = New System.Drawing.Point(7, 19)
        Me.Teleport.Name = "Teleport"
        Me.Teleport.Size = New System.Drawing.Size(75, 23)
        Me.Teleport.TabIndex = 0
        Me.Teleport.Text = "テレポート"
        Me.Teleport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RestartWhenStopped)
        Me.GroupBox1.Controls.Add(Me.StopPMMPForcely)
        Me.GroupBox1.Controls.Add(Me.StopPMMPSafety)
        Me.GroupBox1.Controls.Add(Me.StartPMMP)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本"
        '
        'RestartWhenStopped
        '
        Me.RestartWhenStopped.AutoSize = True
        Me.RestartWhenStopped.Location = New System.Drawing.Point(7, 77)
        Me.RestartWhenStopped.Name = "RestartWhenStopped"
        Me.RestartWhenStopped.Size = New System.Drawing.Size(147, 16)
        Me.RestartWhenStopped.TabIndex = 3
        Me.RestartWhenStopped.Text = "終了した際に自動再起動"
        Me.RestartWhenStopped.UseVisualStyleBackColor = True
        '
        'StopPMMPForcely
        '
        Me.StopPMMPForcely.BackColor = System.Drawing.Color.Red
        Me.StopPMMPForcely.Enabled = False
        Me.StopPMMPForcely.ForeColor = System.Drawing.Color.White
        Me.StopPMMPForcely.Location = New System.Drawing.Point(7, 48)
        Me.StopPMMPForcely.Name = "StopPMMPForcely"
        Me.StopPMMPForcely.Size = New System.Drawing.Size(152, 23)
        Me.StopPMMPForcely.TabIndex = 2
        Me.StopPMMPForcely.Text = "強制的に停止"
        Me.StopPMMPForcely.UseVisualStyleBackColor = False
        '
        'StopPMMPSafety
        '
        Me.StopPMMPSafety.Enabled = False
        Me.StopPMMPSafety.Location = New System.Drawing.Point(84, 19)
        Me.StopPMMPSafety.Name = "StopPMMPSafety"
        Me.StopPMMPSafety.Size = New System.Drawing.Size(75, 23)
        Me.StopPMMPSafety.TabIndex = 1
        Me.StopPMMPSafety.Text = "安全に停止"
        Me.StopPMMPSafety.UseVisualStyleBackColor = True
        '
        'StartPMMP
        '
        Me.StartPMMP.Location = New System.Drawing.Point(7, 19)
        Me.StartPMMP.Name = "StartPMMP"
        Me.StartPMMP.Size = New System.Drawing.Size(75, 23)
        Me.StartPMMP.TabIndex = 0
        Me.StartPMMP.Text = "開始"
        Me.StartPMMP.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ConfigChanger)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(622, 324)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "WebMine-MP"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ConfigChanger
        '
        Me.ConfigChanger.Location = New System.Drawing.Point(356, 6)
        Me.ConfigChanger.Name = "ConfigChanger"
        Me.ConfigChanger.Size = New System.Drawing.Size(97, 23)
        Me.ConfigChanger.TabIndex = 1
        Me.ConfigChanger.Text = "コンフィグの設定"
        Me.ConfigChanger.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SetCredentials)
        Me.GroupBox5.Controls.Add(Me.StartWMPWhenAppStarted)
        Me.GroupBox5.Controls.Add(Me.StopWMMP)
        Me.GroupBox5.Controls.Add(Me.StartWMMP)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(342, 310)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "WebMine-MP(PMMP遠隔操作HTTPサーバー)"
        '
        'SetCredentials
        '
        Me.SetCredentials.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SetCredentials.ForeColor = System.Drawing.Color.White
        Me.SetCredentials.Location = New System.Drawing.Point(6, 48)
        Me.SetCredentials.Name = "SetCredentials"
        Me.SetCredentials.Size = New System.Drawing.Size(187, 23)
        Me.SetCredentials.TabIndex = 3
        Me.SetCredentials.Text = "ログイン情報を設定"
        Me.SetCredentials.UseVisualStyleBackColor = False
        '
        'StartWMPWhenAppStarted
        '
        Me.StartWMPWhenAppStarted.AutoSize = True
        Me.StartWMPWhenAppStarted.Location = New System.Drawing.Point(200, 19)
        Me.StartWMPWhenAppStarted.Name = "StartWMPWhenAppStarted"
        Me.StartWMPWhenAppStarted.Size = New System.Drawing.Size(146, 28)
        Me.StartWMPWhenAppStarted.TabIndex = 2
        Me.StartWMPWhenAppStarted.Text = "アプリケーション開始時に、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WebMine-MPを起動する"
        Me.StartWMPWhenAppStarted.UseVisualStyleBackColor = True
        '
        'StopWMMP
        '
        Me.StopWMMP.Location = New System.Drawing.Point(102, 19)
        Me.StopWMMP.Name = "StopWMMP"
        Me.StopWMMP.Size = New System.Drawing.Size(92, 23)
        Me.StopWMMP.TabIndex = 1
        Me.StopWMMP.Text = "停止"
        Me.StopWMMP.UseVisualStyleBackColor = True
        '
        'StartWMMP
        '
        Me.StartWMMP.Location = New System.Drawing.Point(7, 19)
        Me.StartWMMP.Name = "StartWMMP"
        Me.StartWMMP.Size = New System.Drawing.Size(89, 23)
        Me.StartWMMP.TabIndex = 0
        Me.StartWMMP.Text = "開始"
        Me.StartWMMP.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(622, 324)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PocketMine-MP コンソール出力"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Console, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DeleteConsole, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(622, 324)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Console
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Console, 2)
        Me.Console.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Console.Location = New System.Drawing.Point(3, 33)
        Me.Console.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Console.Name = "Console"
        Me.Console.Size = New System.Drawing.Size(616, 288)
        Me.Console.TabIndex = 0
        '
        'DeleteConsole
        '
        Me.DeleteConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteConsole.Location = New System.Drawing.Point(3, 3)
        Me.DeleteConsole.Name = "DeleteConsole"
        Me.DeleteConsole.Size = New System.Drawing.Size(305, 24)
        Me.DeleteConsole.TabIndex = 1
        Me.DeleteConsole.Text = "コンソール出力を消去"
        Me.DeleteConsole.UseVisualStyleBackColor = True
        '
        'ConsoleReader
        '
        ConsoleReader.WorkerReportsProgress = True
        ConsoleReader.WorkerSupportsCancellation = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 350)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "WebMine-MP"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StopPMMPForcely As System.Windows.Forms.Button
    Friend WithEvents StopPMMPSafety As System.Windows.Forms.Button
    Friend WithEvents StartPMMP As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DeprivationOP As System.Windows.Forms.Button
    Friend WithEvents GrantOP As System.Windows.Forms.Button
    Friend WithEvents PardonIP As System.Windows.Forms.Button
    Friend WithEvents BanIP As System.Windows.Forms.Button
    Friend WithEvents Pardon As System.Windows.Forms.Button
    Friend WithEvents BANNormally As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents KickOut As System.Windows.Forms.Button
    Friend WithEvents HelpCommand As System.Windows.Forms.Button
    Friend WithEvents PrivateChat As System.Windows.Forms.Button
    Friend WithEvents Teleport As System.Windows.Forms.Button
    Friend WithEvents RestartWhenStopped As System.Windows.Forms.CheckBox
    Friend WithEvents Onlines As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReloadPMMP As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents SetCredentials As System.Windows.Forms.Button
    Friend WithEvents StartWMPWhenAppStarted As System.Windows.Forms.CheckBox
    Friend WithEvents StopWMMP As System.Windows.Forms.Button
    Friend WithEvents StartWMMP As System.Windows.Forms.Button
    Friend WithEvents Console As System.Windows.Forms.WebBrowser
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DeleteConsole As System.Windows.Forms.Button
    Friend WithEvents ConsoleReader As System.ComponentModel.BackgroundWorker
    Friend WithEvents ConfigChanger As System.Windows.Forms.Button

End Class
