Imports AnythingTools
Imports System.IO
Imports System.Xml

Public Class WMMPConfigEditor
    Inherits DictionaryImpl(Of String, String)
    Shared default_ As WMMPConfigEditor = _OpenDefaultSettings()
    Private Sub New()

    End Sub
    Public Shared Function Load(xdoc As XDocument) As WMMPConfigEditor
        Dim result = CreateNew()
        For Each i In xdoc.<WebMine-MP>.Nodes.Cast(Of XElement)()
            result.Add(i.Name.LocalName, i.Value)
        Next
        Return result
    End Function
    Public Shared Function Load(strm As Stream) As WMMPConfigEditor
        Return Load(XDocument.Load(strm))
    End Function
    Public Shared Function Load(strm As TextReader) As WMMPConfigEditor
        Return Load(XDocument.Load(strm))
    End Function
    Public Shared Function Parse(xml As String) As WMMPConfigEditor
        Return Load(XDocument.Parse(xml))
    End Function
    Public Shared Function Load(uri As String) As WMMPConfigEditor
        Return Load(XDocument.Load(uri))
    End Function
    Public Shared Function GetDefaultConfig() As WMMPConfigEditor
        Return default_
    End Function
    Public Shared Sub SaveDefaultConfig()
        default_.Save()
    End Sub
    Public Shared Function CreateNew() As WMMPConfigEditor
        Return New WMMPConfigEditor
    End Function
    Private Shared Function _OpenDefaultSettings() As WMMPConfigEditor
        Try
            Return Load("config.xml")
        Catch ex As Exception
            Return CreateNew()
        End Try
    End Function
    Public Sub Save()
        Save("config.xml")
    End Sub
    Public Sub Save(path As String)
        CreateInternal.Save(path)
    End Sub
    Public Sub Save(strm As Stream)
        CreateInternal.Save(strm)
    End Sub
    Public Sub Save(strm As TextWriter)
        CreateInternal.Save(strm)
    End Sub
    Public Sub Save(strm As XmlWriter)
        CreateInternal.Save(strm)
    End Sub
    Private Function CreateInternal() As XDocument
        Dim xdoc As XDocument = XDocument.Parse("<WebMine-MP></WebMine-MP>")
        For Each i In Me
            xdoc.Root.Add(CreateNodeInternal(String.Format("<{0}>{1}</{0}>", i.Key, i.Value)))
        Next
        Return xdoc
    End Function
    Friend Shared Function CreateNodeInternal(s As String) As XNode
        Dim xd As XDocument = XDocument.Parse(s)
        Dim element = xd.Root
        element.Remove()
        Return element
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        If Me Is default_ Then
            Me.Save("config.xml")
        End If
    End Sub
End Class