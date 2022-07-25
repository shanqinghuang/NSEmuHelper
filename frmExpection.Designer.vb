<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpection
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialMultiLineTextBox21 = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MaterialMultiLineTextBox21)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.Panel1.Size = New System.Drawing.Size(644, 323)
        Me.Panel1.TabIndex = 0
        '
        'MaterialMultiLineTextBox21
        '
        Me.MaterialMultiLineTextBox21.AnimateReadOnly = False
        Me.MaterialMultiLineTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialMultiLineTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialMultiLineTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaterialMultiLineTextBox21.Depth = 0
        Me.MaterialMultiLineTextBox21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialMultiLineTextBox21.HideSelection = True
        Me.MaterialMultiLineTextBox21.Location = New System.Drawing.Point(10, 0)
        Me.MaterialMultiLineTextBox21.MaxLength = 32767
        Me.MaterialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialMultiLineTextBox21.Name = "MaterialMultiLineTextBox21"
        Me.MaterialMultiLineTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialMultiLineTextBox21.ReadOnly = False
        Me.MaterialMultiLineTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MaterialMultiLineTextBox21.SelectedText = ""
        Me.MaterialMultiLineTextBox21.SelectionLength = 0
        Me.MaterialMultiLineTextBox21.SelectionStart = 0
        Me.MaterialMultiLineTextBox21.ShortcutsEnabled = True
        Me.MaterialMultiLineTextBox21.Size = New System.Drawing.Size(624, 313)
        Me.MaterialMultiLineTextBox21.TabIndex = 0
        Me.MaterialMultiLineTextBox21.TabStop = False
        Me.MaterialMultiLineTextBox21.Text = "dotnet炸妈现场.jpg"
        Me.MaterialMultiLineTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialMultiLineTextBox21.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(9, 73)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(490, 21)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "抱歉，NS 模拟器助手发生了错误，请把如下报错信息反馈给开发者。"
        '
        'frmExpection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 434)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmExpection"
        Me.Text = "发生错误"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialMultiLineTextBox21 As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
