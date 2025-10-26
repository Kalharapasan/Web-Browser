<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bookmarks
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
        Me.SqlabC_Theme1 = New SQLABC_ModernUI.SQLABC_Theme()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SqlabC_ButtonB2 = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlabC_ButtonB1 = New SQLABC_ModernUI.SQLABC_ButtonB()
        Me.SqlabC_Theme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlabC_Theme1
        '
        Me.SqlabC_Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SqlabC_Theme1.Controls.Add(Me.ListBox1)
        Me.SqlabC_Theme1.Controls.Add(Me.SqlabC_ButtonB2)
        Me.SqlabC_Theme1.Controls.Add(Me.Label1)
        Me.SqlabC_Theme1.Controls.Add(Me.SqlabC_ButtonB1)
        Me.SqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlabC_Theme1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.SqlabC_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.SqlabC_Theme1.Name = "SqlabC_Theme1"
        Me.SqlabC_Theme1.Size = New System.Drawing.Size(463, 471)
        Me.SqlabC_Theme1.TabIndex = 0
        Me.SqlabC_Theme1.Text = "SqlabC_Theme1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(13, 77)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(438, 328)
        Me.ListBox1.TabIndex = 4
        '
        'SqlabC_ButtonB2
        '
        Me.SqlabC_ButtonB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SqlabC_ButtonB2.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.SqlabC_ButtonB2.ForeColor = System.Drawing.Color.Red
        Me.SqlabC_ButtonB2.GlowColor = System.Drawing.Color.Red
        Me.SqlabC_ButtonB2.Image = Nothing
        Me.SqlabC_ButtonB2.Location = New System.Drawing.Point(311, 423)
        Me.SqlabC_ButtonB2.Name = "SqlabC_ButtonB2"
        Me.SqlabC_ButtonB2.Size = New System.Drawing.Size(140, 36)
        Me.SqlabC_ButtonB2.TabIndex = 3
        Me.SqlabC_ButtonB2.Text = "Open Link"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BOOKMARKS"
        '
        'SqlabC_ButtonB1
        '
        Me.SqlabC_ButtonB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SqlabC_ButtonB1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.SqlabC_ButtonB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SqlabC_ButtonB1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SqlabC_ButtonB1.Image = Nothing
        Me.SqlabC_ButtonB1.Location = New System.Drawing.Point(12, 421)
        Me.SqlabC_ButtonB1.Name = "SqlabC_ButtonB1"
        Me.SqlabC_ButtonB1.Size = New System.Drawing.Size(140, 36)
        Me.SqlabC_ButtonB1.TabIndex = 0
        Me.SqlabC_ButtonB1.Text = "Clear List"
        '
        'Bookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 471)
        Me.Controls.Add(Me.SqlabC_Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bookmarks"
        Me.Text = "Bookmarks"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SqlabC_Theme1.ResumeLayout(False)
        Me.SqlabC_Theme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlabC_Theme1 As SQLABC_ModernUI.SQLABC_Theme
    Friend WithEvents SqlabC_ButtonB2 As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents Label1 As Label
    Friend WithEvents SqlabC_ButtonB1 As SQLABC_ModernUI.SQLABC_ButtonB
    Friend WithEvents ListBox1 As ListBox
End Class
