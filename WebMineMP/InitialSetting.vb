Imports AnythingTools

Public Class InitialSetting
    Dim dir As String = ""
    Dim invctrl As Control
    <Obsolete>
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(invokeCtrl As Control)
        InitializeComponent()
        invctrl = invokeCtrl
    End Sub

    Private Sub InitialSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentDir.Text = CurrentDir.Text.Replace("%dir_cur%", Environment.CurrentDirectory)
    End Sub

    Private Sub CurrentDir_CheckedChanged(sender As Object, e As EventArgs) Handles CurrentDir.CheckedChanged
        SelectDir.Enabled = Not CurrentDir.Checked
    End Sub

    Private Sub SelectMyself_CheckedChanged(sender As Object, e As EventArgs) Handles SelectMyself.CheckedChanged

    End Sub

    Private Sub StartFind_Click(sender As Object, e As EventArgs) Handles StartFind.Click
        Me.Enabled = False
        Dim info As PMMPInfo
        Try
            If CurrentDir.Checked Then
                info = PMMPInfo.Find()
            Else
                info = PMMPInfo.Find(dir)
            End If
            info.Save()
            Me.Close()
        Catch ex As Exception
            Me.Enabled = True
            Tools.PrintException(ex)
        End Try
    End Sub

    Private Sub SelectDir_Click(sender As Object, e As EventArgs) Handles SelectDir.Click
        dir = invctrl.Invoke(Function() Tools.SelectFolder(, IIf(dir = Nothing, "", dir), ))
        SelectDir.Text = dir
    End Sub
End Class