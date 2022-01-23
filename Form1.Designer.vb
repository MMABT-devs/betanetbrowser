<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BetaNetBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BetaNetBrowser))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.forwardBtn = New System.Windows.Forms.Button()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.goBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 40)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(796, 409)
        Me.WebBrowser1.TabIndex = 0
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(12, 11)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(33, 23)
        Me.backBtn.TabIndex = 1
        Me.backBtn.Text = "<"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'forwardBtn
        '
        Me.forwardBtn.Location = New System.Drawing.Point(51, 11)
        Me.forwardBtn.Name = "forwardBtn"
        Me.forwardBtn.Size = New System.Drawing.Size(33, 23)
        Me.forwardBtn.TabIndex = 2
        Me.forwardBtn.Text = ">"
        Me.forwardBtn.UseVisualStyleBackColor = True
        '
        'refreshBtn
        '
        Me.refreshBtn.Location = New System.Drawing.Point(90, 11)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(61, 23)
        Me.refreshBtn.TabIndex = 3
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'homeBtn
        '
        Me.homeBtn.Location = New System.Drawing.Point(157, 11)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(61, 23)
        Me.homeBtn.TabIndex = 4
        Me.homeBtn.Text = "Home"
        Me.homeBtn.UseVisualStyleBackColor = True
        '
        'goBtn
        '
        Me.goBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.goBtn.Location = New System.Drawing.Point(707, 11)
        Me.goBtn.Name = "goBtn"
        Me.goBtn.Size = New System.Drawing.Size(81, 23)
        Me.goBtn.TabIndex = 5
        Me.goBtn.Text = "Go!"
        Me.goBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(224, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(477, 22)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Type / Paste URL"
        '
        'BetaNetBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.goBtn)
        Me.Controls.Add(Me.homeBtn)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.forwardBtn)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BetaNetBrowser"
        Me.Text = "BetaNetBrowser b1.01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents backBtn As Button
    Friend WithEvents forwardBtn As Button
    Friend WithEvents refreshBtn As Button
    Friend WithEvents homeBtn As Button
    Friend WithEvents goBtn As Button
    Friend WithEvents TextBox1 As TextBox
End Class
