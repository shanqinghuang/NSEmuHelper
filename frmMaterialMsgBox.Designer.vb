<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterialMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialMsgBox))
        Me.btnYes = New MaterialSkin.Controls.MaterialButton()
        Me.btnNo = New MaterialSkin.Controls.MaterialButton()
        Me.btnOK = New MaterialSkin.Controls.MaterialButton()
        Me.MessageLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnYes.Depth = 0
        Me.btnYes.HighEmphasis = True
        Me.btnYes.Icon = Nothing
        Me.btnYes.Location = New System.Drawing.Point(298, 262)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYes.Name = "btnYes"
        Me.btnYes.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYes.Size = New System.Drawing.Size(64, 36)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Text = "是"
        Me.btnYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnYes.UseAccentColor = False
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnNo.Depth = 0
        Me.btnNo.HighEmphasis = True
        Me.btnNo.Icon = Nothing
        Me.btnNo.Location = New System.Drawing.Point(370, 262)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNo.Name = "btnNo"
        Me.btnNo.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnNo.Size = New System.Drawing.Size(64, 36)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "否"
        Me.btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNo.UseAccentColor = False
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnOK.Depth = 0
        Me.btnOK.HighEmphasis = True
        Me.btnOK.Icon = Nothing
        Me.btnOK.Location = New System.Drawing.Point(370, 262)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnOK.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOK.Name = "btnOK"
        Me.btnOK.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnOK.Size = New System.Drawing.Size(64, 36)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "确定"
        Me.btnOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnOK.UseAccentColor = False
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.Depth = 0
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MessageLabel.Location = New System.Drawing.Point(14, 79)
        Me.MessageLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(415, 165)
        Me.MessageLabel.TabIndex = 3
        Me.MessageLabel.Text = "消息"
        '
        'frmMaterialMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 307)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMaterialMsgBox"
        Me.Text = "NS 模拟器助手"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnYes As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnNo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnOK As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MessageLabel As MaterialSkin.Controls.MaterialLabel
End Class
