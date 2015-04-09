Imports AnythingTools.Servers
Imports System.Text
Imports AnythingTools
Imports AnythingTools.Streams
Imports System.IO

Public Class WMMPHttpServer_self
    Inherits HttpServer
    Dim wr As New WeakReference(Of UTF8Encoding)(New UTF8Encoding(False))
    Dim rndInt As UInteger = AdvancedStream.ConvertToAdvancedStream(StrictRandomStream.Instance).ReadUInt
    Dim form As Main
    Public Sub New(f As Main)
        form = f
    End Sub
    Public Overrides Sub OnRespose(sender As Object, e As HttpServer.OnResponseEventArgs)
        Dim path = e.Request.RawUrl.Split("/"c).Last.Split("?"c).First
        Dim queries = qtd(e.Request.RawUrl)
        If path = "" Then
            Select Case queries("wrong")
                Case "invalid"
                    e.SendToClient(enc.GetBytes(My.Resources.Login_InvalidSession))
                Case "wrong"
                    e.SendToClient(enc.GetBytes(My.Resources.Login_Wrong))
                Case Else
                    e.SendToClient(enc.GetBytes(My.Resources.Login))
            End Select
        ElseIf path = "login" Then
            Dim cfg = WMMPConfigEditor.GetDefaultConfig
            If cfg("AvaliableWMMPInfo") = "True" Then
                If dec(cfg("WMMP_ID")) = queries("id") And dec(cfg("WMMP_PASS")) = queries("pass") Then
                    e.Response.RedirectLocation = "/main.html?page=1&rand=" & rndInt
                End If
            Else
                e.Response.RedirectLocation = "/?type=wrong"
            End If
        ElseIf path = "main.html" Then
            Check(queries, e)
            Select Case Integer.Parse(queries("page"))
                Case 1
                    e.SendToClient(enc.GetBytes(My.Resources.Main_1.Replace("*RAND*", rndInt)))
                Case 2
                    e.SendToClient(enc.GetBytes(My.Resources.Main_2.Replace("*RAND*", rndInt)))
                Case 3
                    Dim xd As XDocument = XDocument.Parse(My.Resources.Main_3.Replace("*RAND*", rndInt))
                    Dim node = (From i In xd.<html>.<body>.<div>.<div> Where i.@id = "console").First
                    For Each i In form.sideload
                        node.Add(Function(s As String) As XNode
                                     Dim doc As XDocument = XDocument.Parse(s)
                                     Dim element = doc.Root
                                     element.Remove()
                                     Return element
                                 End Function(i))
                    Next
                    e.SendToClient(enc.GetBytes(xd.ToString))
            End Select
        ElseIf path = "command" Then
            Check(queries, e)

        End If
    End Sub
    Function qtd(s As String) As IDictionary(Of String, String)
        s = s.Split("?"c).Last
        Dim dic As New DictionaryImpl(Of String, String)
        For Each i In s.Split("&"c)
            dic.Add(i.Split("=")(0), i.Split("=")(1))
        Next
        Return dic
    End Function
    Function dec(s As String) As String
        Return enc.GetString(Convert.FromBase64String(s))
    End Function
    Function enc() As UTF8Encoding
        enc = Nothing
        wr.TryGetTarget(enc)
        If enc Is Nothing Then
            wr.SetTarget(New UTF8Encoding(False))
            wr.TryGetTarget(enc)
        End If
        Return enc
    End Function
    Public Sub ResetRnd()
        Static strm = AdvancedStream.ConvertToAdvancedStream(New BufferedStream(StrictRandomStream.Instance))
        rndInt = strm.ReadUInt
    End Sub
    Function CheckValid(d As IDictionary(Of String, String)) As Boolean
        Return d("rand") = rndInt
    End Function
    Sub Check(d As IDictionary(Of String, String), e As HttpServer.OnResponseEventArgs)
        If Not CheckValid(d) Then
            e.Response.RedirectLocation = "/?type=wrong"
            AbortResponse()
        End If
    End Sub
End Class
