Imports System.IO
Public NotInheritable Class PMMPInfo
    Private Sub New(php As String, phar As String)
        pp = php
        ph = phar
        wd = Environment.CurrentDirectory
    End Sub
    Private Sub New(php As String, phar As String, workdir As String)
        pp = php
        ph = phar
        wd = workdir
    End Sub
    Dim pp, ph, wd As String
    Public ReadOnly Property PhpPath As String
        Get
            Return pp
        End Get
    End Property
    Public ReadOnly Property PMMPPharPath As String
        Get
            Return ph
        End Get
    End Property
    Public ReadOnly Property WorkingDir As String
        Get
            Return wd
        End Get
    End Property
    Public Sub Save()
        Dim cfg = WMMPConfigEditor.GetDefaultConfig
        cfg("PHP") = pp
        cfg("PMMPPhar") = ph
        cfg("WorkingDirectory") = wd
        cfg.Save()
    End Sub
    Public Shared Function Find(Optional throwExceptionsIfFilesNotFound As Boolean = True) As PMMPInfo
        Dim a1 As String
        If File.Exists("bin\php\php.exe") Then
            a1 = "bin\php\php.exe"
        Else
            a1 = "php"
        End If
        Dim a2 As String
        If File.Exists("PocketMine-MP.phar") Then
            a2 = "PocketMine-MP.phar"
        ElseIf File.Exists("src\pocketmine\PocketMine.php") Then
            a2 = "src\pocketmine\PocketMine.php"
        Else
            If throwExceptionsIfFilesNotFound Then
                Throw New FileNotFoundException("Couldn't find a valid PocketMine-MP installation")
            Else
                a2 = Nothing
            End If
        End If
        Return New PMMPInfo(a1, a2)
    End Function
    Public Shared Function Find(dir As String, Optional throwExceptionsIfFilesNotFound As Boolean = True) As PMMPInfo
        Dim a1 As String
        If File.Exists(Path.Combine(dir, "bin\php\php.exe")) Then
            a1 = Path.Combine(dir, "bin\php\php.exe")
        Else
            a1 = "php"
        End If
        Dim a2 As String
        If File.Exists(Path.Combine(dir, "PocketMine-MP.phar")) Then
            a2 = Path.Combine(dir, "PocketMine-MP.phar")
        ElseIf File.Exists(Path.Combine(dir, "src\pocketmine\PocketMine.php")) Then
            a2 = Path.Combine(dir, "src\pocketmine\PocketMine.php")
        Else
            If throwExceptionsIfFilesNotFound Then
                Throw New FileNotFoundException("Couldn't find a valid PocketMine-MP installation")
            Else
                a2 = Nothing
            End If
        End If
        Return New PMMPInfo(a1, a2, dir)
    End Function
    Public Shared Function Load() As PMMPInfo
        Dim cfg = WMMPConfigEditor.GetDefaultConfig
        Return New PMMPInfo(cfg("PHP"), cfg("PMMPPhar"), cfg("WorkingDirectory"))
    End Function
    Public Shared Function IsConfigAvaliable() As Boolean
        Return File.Exists("config.xml")
    End Function
End Class
