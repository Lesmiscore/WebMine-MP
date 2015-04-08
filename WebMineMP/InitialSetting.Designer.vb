<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialSetting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CurrentDir = New System.Windows.Forms.RadioButton()
        Me.SelectMyself = New System.Windows.Forms.RadioButton()
        Me.SelectDir = New System.Windows.Forms.Button()
        Me.StartFind = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WebMine-MPへようこそ！" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PocketMine-MPのパスを指定して下さい。"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SelectDir)
        Me.Panel1.Controls.Add(Me.SelectMyself)
        Me.Panel1.Controls.Add(Me.CurrentDir)
        Me.Panel1.Location = New System.Drawing.Point(15, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 89)
        Me.Panel1.TabIndex = 1
        '
        'CurrentDir
        '
        Me.CurrentDir.AutoSize = True
        Me.CurrentDir.Location = New System.Drawing.Point(4, 4)
        Me.CurrentDir.Name = "CurrentDir"
        Me.CurrentDir.Size = New System.Drawing.Size(107, 28)
        Me.CurrentDir.TabIndex = 0
        Me.CurrentDir.TabStop = True
        Me.CurrentDir.Text = "カレントディレクトリ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(%dir_cur%)"
        Me.CurrentDir.UseVisualStyleBackColor = True
        '
        'SelectMyself
        '
        Me.SelectMyself.AutoSize = True
        Me.SelectMyself.Location = New System.Drawing.Point(4, 38)
        Me.SelectMyself.Name = "SelectMyself"
        Me.SelectMyself.Size = New System.Drawing.Size(81, 16)
        Me.SelectMyself.TabIndex = 1
        Me.SelectMyself.TabStop = True
        Me.SelectMyself.Text = "自分で選択"
        Me.SelectMyself.UseVisualStyleBackColor = True
        '
        'SelectDir
        '
        Me.SelectDir.Location = New System.Drawing.Point(4, 60)
        Me.SelectDir.Name = "SelectDir"
        Me.SelectDir.Size = New System.Drawing.Size(339, 23)
        Me.SelectDir.TabIndex = 2
        Me.SelectDir.Text = "未選択"
        Me.SelectDir.UseVisualStyleBackColor = True
        '
        'StartFind
        '
        Me.StartFind.Location = New System.Drawing.Point(286, 136)
        Me.StartFind.Name = "StartFind"
        Me.StartFind.Size = New System.Drawing.Size(75, 23)
        Me.StartFind.TabIndex = 2
        Me.StartFind.Text = "検出"
        Me.StartFind.UseVisualStyleBackColor = True
        '
        'InitialSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.StartFind)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "InitialSetting"
        Me.Text = "初期設定ウィザード"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CurrentDir As System.Windows.Forms.RadioButton
    Friend WithEvents SelectMyself As System.Windows.Forms.RadioButton
    Friend WithEvents SelectDir As System.Windows.Forms.Button
    Friend WithEvents StartFind As System.Windows.Forms.Button
End Class
