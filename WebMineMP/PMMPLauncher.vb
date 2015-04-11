Imports System.Text
Imports System.IO

Public Class PMMPLauncher
    Dim info As PMMPInfo
    Dim proc As Process
    Private Sub New(info As PMMPInfo)
        If info Is Nothing Then
            Throw New ArgumentNullException("info")
        End If
        Me.info = info
    End Sub
    Public Shared Function Create(info As PMMPInfo) As PMMPLauncher
        Return New PMMPLauncher(info)
    End Function
    Public ReadOnly Property PMMPInfo As PMMPInfo
        Get
            Return info
        End Get
    End Property
    Public Sub Prepare()
        Dim psi As New ProcessStartInfo
        psi.StandardOutputEncoding = New UTF8Encoding
        psi.StandardErrorEncoding = New UTF8Encoding
        psi.RedirectStandardError = True
        psi.RedirectStandardInput = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = True
        psi.UseShellExecute = False

        psi.FileName = ""
        psi.Arguments = info.PhpPath & " -c bin\php """ & info.PMMPPharPath & """"
        proc = New Process()
        proc.StartInfo = psi
        AddHandler proc.Exited, Sub()
                                    RaiseEvent OnStopped()
                                End Sub
    End Sub
    Public Sub Start()
        If Not IsPrepared Then
            Prepare()
        End If
        proc.Start()
        'RaiseEvent OnStarted()
    End Sub
    Public Sub [Stop]()
        SendCommand("stop")
        proc.WaitForExit()
    End Sub
    Public Sub SendCommand(s As String)
        Writer.WriteLine(s)
    End Sub
    Public ReadOnly Property Writer As TextWriter
        Get
            Return proc.StandardInput
        End Get
    End Property
    Public ReadOnly Property Reader As TextReader
        Get
            Return proc.StandardOutput
        End Get
    End Property
    Public ReadOnly Property ErrReader As TextReader
        Get
            Return proc.StandardError
        End Get
    End Property
    Public ReadOnly Property Title As String
        Get
            Return proc.MainWindowTitle
        End Get
    End Property
    Public ReadOnly Property IsPrepared As Boolean
        Get
            Return proc IsNot Nothing AndAlso proc.StartInfo IsNot Nothing
        End Get
    End Property
    Public ReadOnly Property Process As Process
        Get
            Return proc
        End Get
    End Property
    Public ReadOnly Property IsRunning As Boolean
        Get
            If IsPrepared Then
                Return False
            End If
            Return Not proc.HasExited
        End Get
    End Property
    Public Event OnStopped()
    Public Event OnStarted()
End Class
