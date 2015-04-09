<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CredentialEditor
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
        Me.WMMPLoginEnabled = New System.Windows.Forms.CheckBox()
        Me.CredentialGroup = New System.Windows.Forms.GroupBox()
        Me.WMMPPW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WMMPID = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.CredentialGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'WMMPLoginEnabled
        '
        Me.WMMPLoginEnabled.AutoSize = True
        Me.WMMPLoginEnabled.Location = New System.Drawing.Point(13, 13)
        Me.WMMPLoginEnabled.Name = "WMMPLoginEnabled"
        Me.WMMPLoginEnabled.Size = New System.Drawing.Size(175, 16)
        Me.WMMPLoginEnabled.TabIndex = 0
        Me.WMMPLoginEnabled.Text = "WMMPへのログインを可能にする"
        Me.WMMPLoginEnabled.UseVisualStyleBackColor = True
        '
        'CredentialGroup
        '
        Me.CredentialGroup.Controls.Add(Me.WMMPPW)
        Me.CredentialGroup.Controls.Add(Me.Label2)
        Me.CredentialGroup.Controls.Add(Me.Label1)
        Me.CredentialGroup.Controls.Add(Me.WMMPID)
        Me.CredentialGroup.Location = New System.Drawing.Point(13, 36)
        Me.CredentialGroup.Name = "CredentialGroup"
        Me.CredentialGroup.Size = New System.Drawing.Size(201, 80)
        Me.CredentialGroup.TabIndex = 1
        Me.CredentialGroup.TabStop = False
        Me.CredentialGroup.Text = "認証情報"
        '
        'WMMPPW
        '
        Me.WMMPPW.Location = New System.Drawing.Point(75, 41)
        Me.WMMPPW.Name = "WMMPPW"
        Me.WMMPPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.WMMPPW.Size = New System.Drawing.Size(100, 19)
        Me.WMMPPW.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "パスワード:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'WMMPID
        '
        Me.WMMPID.Location = New System.Drawing.Point(75, 16)
        Me.WMMPID.Name = "WMMPID"
        Me.WMMPID.Size = New System.Drawing.Size(100, 19)
        Me.WMMPID.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(13, 123)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 23)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "保存"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(121, 123)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "キャンセル"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'CredentialEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CredentialGroup)
        Me.Controls.Add(Me.WMMPLoginEnabled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CredentialEditor"
        Me.Text = "認証情報の編集"
        Me.CredentialGroup.ResumeLayout(False)
        Me.CredentialGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WMMPLoginEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents CredentialGroup As System.Windows.Forms.GroupBox
    Friend WithEvents WMMPPW As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WMMPID As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
