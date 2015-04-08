Imports System.Reflection
Imports System.ComponentModel

Public Class Splash
    Dim tmp As PMMPInfo
    Private Sub Loader_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Loader.DoWork
        If Not PMMPInfo.IsConfigAvaliable Then
            Dim a As New InitialSetting(Me)
            a.ShowDialog()
        End If
        e.Result = New With {.info = PMMPInfo.Load}
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim e_ = New DoWorkEventArgs(Nothing)
        'Loader_DoWork(Loader, e_)
        'Loader_RunWorkerCompleted(Loader, New RunWorkerCompletedEventArgs(e_.Result, Nothing, False))
        Loader.RunWorkerAsync()
    End Sub

    Private Sub Loader_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Loader.RunWorkerCompleted
        Try
            tmp = e.Result.info
        Catch
        Finally
            Me.Close()
        End Try
    End Sub

    Public Function StartInit() As PMMPInfo
        tmp = Nothing
        'Invoke(Sub()
        Me.Visible = False
        Me.ShowDialog()
        'End Sub)
        Return tmp
    End Function

    Public Function GetTmp() As PMMPInfo
        Return tmp
    End Function
End Class