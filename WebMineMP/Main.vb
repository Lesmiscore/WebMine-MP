Imports AnythingTools.FHCodePack
Imports AnythingTools

Public Class Main
    Dim standard As Button() ' = {DeprivationOP, Pardon, PardonIP, BanIP, BANNormally, GrantOP, ReloadPMMP, KickOut, PrivateChat, HelpCommand, Teleport, StopPMMPForcely, StopPMMPSafety}
    Dim stopedbt As Button() ' = {StartPMMP}
    Dim allowStop As Boolean = False
    Dim info As PMMPInfo
    Dim icCalled As Boolean = False
    Dim html As XDocument = XDocument.Parse(<html>
                                                <head>
                                                    <title></title>
                                                    <style>
                                                        #datetime{
                                                            font-weight: bold;
                                                        }
                                                    </style>
                                                </head>
                                                <body></body>
                                            </html>.ToString)
    Friend sideload As New CollectionImpl(Of String)
    WithEvents lnhr As PMMPLauncher
    <Obsolete>
    Public Sub New()
        InitializeComponent()
        icCalled = True
        Init2()
    End Sub
    Public Sub New(info As PMMPInfo, lnhr As PMMPLauncher)
        Init(info, lnhr)
        Init2()
    End Sub
    Public Sub Init(info As PMMPInfo, lnhr As PMMPLauncher)
        If Not icCalled Then InitializeComponent()
        If lnhr Is Nothing Then
            lnhr = PMMPLauncher.Create(info)
        End If
        Me.info = info
        Me.lnhr = lnhr
        lnhr.Prepare()
        Stopped()
    End Sub
    Public Sub Init2()
        standard = {DeprivationOP, Pardon, PardonIP, BanIP, BANNormally, GrantOP, ReloadPMMP, KickOut, PrivateChat, HelpCommand, Teleport, StopPMMPForcely, StopPMMPSafety}
        stopedbt = {StartPMMP}
    End Sub
    Private Sub DeprivationOP_Click(sender As Object, e As EventArgs) Handles DeprivationOP.Click
        AttentionAndExecute("deop " & New AskString().AskString("OP権限を剥奪するプレイヤー名を入力して下さい。", , ""))
    End Sub
    Private Sub PardonIP_Click(sender As Object, e As EventArgs) Handles PardonIP.Click
        AttentionAndExecute("pardon-ip " & New AskString().AskString("IP永久追放を解除するIPを入力して下さい。", , ""))
    End Sub
    Private Sub Pardon_Click(sender As Object, e As EventArgs) Handles Pardon.Click
        AttentionAndExecute("pardon " & New AskString().AskString("永久追放を解除するプレイヤー名を入力して下さい。", , ""))
    End Sub
    Private Sub BanIP_Click(sender As Object, e As EventArgs) Handles BanIP.Click
        AttentionAndExecute("ban-ip " & New AskString().AskString("IP永久追放するプレイヤー名もしくはIPを入力して下さい。", , ""))
    End Sub
    Private Sub BANNormally_Click(sender As Object, e As EventArgs) Handles BANNormally.Click
        AttentionAndExecute("ban " & New AskString().AskString("永久追放するプレイヤー名を入力して下さい。", , ""))
    End Sub
    Private Sub GrantOP_Click(sender As Object, e As EventArgs) Handles GrantOP.Click
        AttentionAndExecute("op " & New AskString().AskString("OP権限を付与するプレイヤー名を入力して下さい。", , ""))
    End Sub
    Private Sub ReloadPMMP_Click(sender As Object, e As EventArgs) Handles ReloadPMMP.Click
        AttentionAndExecute("reload")
    End Sub
    Private Sub KickOut_Click(sender As Object, e As EventArgs) Handles KickOut.Click
        AttentionAndExecute("kick " & New AskString().AskString("強制退出させるプレイヤー名を入力して下さい。", , ""))
    End Sub
    Private Sub PrivateChat_Click(sender As Object, e As EventArgs) Handles PrivateChat.Click
        AttentionAndExecute("tell " & New AskString().AskString("送信先を入力して下さい。", , "") & " " & New AskString().AskString("メッセージを入力して下さい。"))
    End Sub
    Private Sub HelpCommand_Click(sender As Object, e As EventArgs) Handles HelpCommand.Click
        AttentionAndExecute("help " & New AskString().AskString("helpコマンドのページ番号を入力して下さい。" & vbCrLf & "入力しない場合、1ページ目を表示します。", , ""))
    End Sub
    Private Sub Teleport_Click(sender As Object, e As EventArgs) Handles Teleport.Click
        AttentionAndExecute("tp " & New AskString().AskString("tpコマンドの""tp ""の続きを入力して下さい。", , ""))
    End Sub
    Private Sub StartPMMP_Click(sender As Object, e As EventArgs) Handles StartPMMP.Click
        lnhr.Start()
        Started()
        ConsoleReader.RunWorkerAsync()
    End Sub
    Private Sub StopPMMPSafety_Click(sender As Object, e As EventArgs) Handles StopPMMPSafety.Click
        lnhr.Stop()
        Stopped()
        allowStop = True
        ConsoleReader.CancelAsync()
    End Sub
    Private Sub StopPMMPForcely_Click(sender As Object, e As EventArgs) Handles StopPMMPForcely.Click
        Stopped()
        allowStop = True
        ConsoleReader.CancelAsync()
        Try
            lnhr.Process.Kill()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Started()
        For Each i In standard
            i.Enabled = True
        Next
        For Each i In stopedbt
            i.Enabled = False
        Next
    End Sub
    Private Sub Stopped()
        For Each i In standard
            i.Enabled = False
        Next
        For Each i In stopedbt
            i.Enabled = True
        Next
    End Sub
    Private Sub AttentionAndExecute(cmd As String)
        If MessageBox.Show(cmd & vbCrLf & "を実行しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            lnhr.SendCommand(cmd)
        End If
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Stopped()
        If info Is Nothing Then
            Me.Visible = False
            Init(Splash.StartInit, Nothing)
            Me.Visible = True
        End If
    End Sub

    Private Sub RestartWhenStopped_CheckedChanged(sender As Object, e As EventArgs) Handles RestartWhenStopped.CheckedChanged

    End Sub

    Private Sub lnhr_OnStarted() Handles lnhr.OnStarted

    End Sub

    Private Sub lnhr_OnStopped() Handles lnhr.OnStopped
        If RestartWhenStopped.Checked Then
            If Not allowStop Then
                lnhr.Start()
            Else
                allowStop = False
                Stopped()
            End If
        Else
            Stopped()
        End If
    End Sub

    Private Sub ConsoleReader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ConsoleReader.DoWork
        While lnhr.IsRunning
            Dim line As String = lnhr.Reader.ReadLine
            Dim now = Date.Now
            line = "<p><b>" + _
                now.Hour.ToString.PadLeft(2).Replace(" "c, "0"c) + ":" + _
                now.Minute.ToString.PadLeft(2).Replace(" "c, "0"c) + ":" + _
                now.Second.ToString.PadLeft(2).Replace(" "c, "0"c) + "</b>" + line + "</p>"
            Dim node = WMMPConfigEditor.CreateNodeInternal(line)
            html.<html>.<body>.First.Add(node)
            Invoke(Sub()
                       Console.DocumentText = html.ToString
                   End Sub)
        End While
        Debug.WriteLine("Console reader stopped")
    End Sub

    Private Sub DeleteConsole_Click(sender As Object, e As EventArgs) Handles DeleteConsole.Click
        Console.DocumentText = ""
    End Sub

    Private Sub ConfigChanger_Click(sender As Object, e As EventArgs) Handles ConfigChanger.Click
        ConfigEditor.ShowDialog()
    End Sub
End Class
