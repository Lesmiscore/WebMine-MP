Imports System.Text

Public Class CredentialEditor
    Dim config As WMMPConfigEditor = WMMPConfigEditor.GetDefaultConfig

    Private Sub CredentialEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Boolean.TryParse(config("AvaliableWMMPInfo"), WMMPLoginEnabled.Checked) Then
            WMMPLoginEnabled.Checked = False
        End If
        CredentialGroup.Enabled = WMMPLoginEnabled.Checked
        If config.Keys.Contains("WMMP_ID") Then 'IDがあれば取得
            WMMPID.Text = dec(config("WMMP_ID"))
        End If
        If config.Keys.Contains("WMMP_PASS") Then 'パスワードがあれば取得
            WMMPPW.Text = dec(config("WMMP_PASS"))
        End If
    End Sub
    Function dec(s As String) As String
        Return Encoding.UTF8.GetString(Convert.FromBase64String(s))
    End Function
    Function enc(s As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(s))
    End Function
    Private Sub WMMPLoginEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles WMMPLoginEnabled.CheckedChanged
        CredentialGroup.Enabled = WMMPLoginEnabled.Checked
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        config("AvaliableWMMPInfo") = WMMPLoginEnabled.Checked
        config("WMMP_ID") = enc(WMMPID.Text)
        config("WMMP_PASS") = enc(WMMPPW.Text)
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class