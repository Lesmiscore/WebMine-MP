<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigEditor
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
        Me.CfgEditGrid = New System.Windows.Forms.DataGridView()
        Me.Keys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Values = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDimiss = New System.Windows.Forms.Button()
        CType(Me.CfgEditGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CfgEditGrid
        '
        Me.CfgEditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CfgEditGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Keys, Me.Values})
        Me.TableLayoutPanel1.SetColumnSpan(Me.CfgEditGrid, 2)
        Me.CfgEditGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CfgEditGrid.Location = New System.Drawing.Point(3, 3)
        Me.CfgEditGrid.Name = "CfgEditGrid"
        Me.CfgEditGrid.RowTemplate.Height = 21
        Me.CfgEditGrid.Size = New System.Drawing.Size(278, 225)
        Me.CfgEditGrid.TabIndex = 0
        '
        'Keys
        '
        Me.Keys.Frozen = True
        Me.Keys.HeaderText = "キー"
        Me.Keys.Name = "Keys"
        '
        'Values
        '
        Me.Values.Frozen = True
        Me.Values.HeaderText = "値"
        Me.Values.Name = "Values"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CfgEditGrid, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSave, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnDimiss, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 261)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSave.Location = New System.Drawing.Point(3, 234)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(136, 24)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "保存"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDimiss
        '
        Me.BtnDimiss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDimiss.Location = New System.Drawing.Point(145, 234)
        Me.BtnDimiss.Name = "BtnDimiss"
        Me.BtnDimiss.Size = New System.Drawing.Size(136, 24)
        Me.BtnDimiss.TabIndex = 2
        Me.BtnDimiss.Text = "破棄"
        Me.BtnDimiss.UseVisualStyleBackColor = True
        '
        'ConfigEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ConfigEditor"
        Me.Text = "コンフィグエディター"
        CType(Me.CfgEditGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CfgEditGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Keys As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Values As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnDimiss As System.Windows.Forms.Button
End Class
