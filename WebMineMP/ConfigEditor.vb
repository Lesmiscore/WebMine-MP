Public Class ConfigEditor
    Dim config As WMMPConfigEditor = WMMPConfigEditor.GetDefaultConfig
    Private Sub ConfigEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CfgEditGrid.Rows.Clear()
        For Each i As DataGridViewRow In DeleteLast(CfgEditGrid.Rows)
            CfgEditGrid.Rows.Remove(i)
            i.Dispose()
        Next
        For Each i In config
            CfgEditGrid.Rows.Add(i.Key, i.Value)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        For Each i As DataGridViewRow In DeleteLast(CfgEditGrid.Rows)
              config(i.Cells(0).Value.ToString) = i.Cells(1).Value.ToString
        Next
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDimiss.Click
        Me.Close()
    End Sub

    Private Iterator Function DeleteLast(col As ICollection) As IEnumerable(Of DataGridViewRow)
        Dim typed = col.OfType(Of DataGridViewRow)()
        For Each i In typed
            If i IsNot typed.Last Then
                Yield i
            End If
        Next
    End Function
End Class