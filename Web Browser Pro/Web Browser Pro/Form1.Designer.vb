<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRemoveTab = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAddTab = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnStop = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnBookmark = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtURL = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnForward = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SqlabC_Theme1 = New SQLABC_ModernUI.SQLABC_Theme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CreateYourOwnWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Sidebar1 = New Web_Browser_Pro.sidebar()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemoveTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBookmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SqlabC_Theme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.btnRemoveTab)
        Me.Panel1.Controls.Add(Me.btnAddTab)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnBookmark)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.txtURL)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnForward)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.SqlabC_Theme1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1177, 102)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.Web_Browser_Pro.My.Resources.Resources.search_filled_100px1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1080, 51)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 9
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnRemoveTab
        '
        Me.btnRemoveTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnRemoveTab.Image = Global.Web_Browser_Pro.My.Resources.Resources.minus_52px1
        Me.btnRemoveTab.ImageActive = Nothing
        Me.btnRemoveTab.Location = New System.Drawing.Point(151, 51)
        Me.btnRemoveTab.Name = "btnRemoveTab"
        Me.btnRemoveTab.Size = New System.Drawing.Size(25, 25)
        Me.btnRemoveTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRemoveTab.TabIndex = 8
        Me.btnRemoveTab.TabStop = False
        Me.btnRemoveTab.Zoom = 10
        '
        'btnAddTab
        '
        Me.btnAddTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnAddTab.Image = Global.Web_Browser_Pro.My.Resources.Resources.add_60px1
        Me.btnAddTab.ImageActive = Nothing
        Me.btnAddTab.Location = New System.Drawing.Point(124, 51)
        Me.btnAddTab.Name = "btnAddTab"
        Me.btnAddTab.Size = New System.Drawing.Size(25, 25)
        Me.btnAddTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddTab.TabIndex = 7
        Me.btnAddTab.TabStop = False
        Me.btnAddTab.Zoom = 10
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnStop.Image = Global.Web_Browser_Pro.My.Resources.Resources.stop_circled_60px1
        Me.btnStop.ImageActive = Nothing
        Me.btnStop.Location = New System.Drawing.Point(95, 51)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(25, 25)
        Me.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnStop.TabIndex = 6
        Me.btnStop.TabStop = False
        Me.btnStop.Zoom = 10
        '
        'btnBookmark
        '
        Me.btnBookmark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBookmark.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBookmark.Image = Global.Web_Browser_Pro.My.Resources.Resources.star_60px
        Me.btnBookmark.ImageActive = Nothing
        Me.btnBookmark.Location = New System.Drawing.Point(1113, 51)
        Me.btnBookmark.Name = "btnBookmark"
        Me.btnBookmark.Size = New System.Drawing.Size(25, 25)
        Me.btnBookmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBookmark.TabIndex = 4
        Me.btnBookmark.TabStop = False
        Me.btnBookmark.Zoom = 10
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnMenu.Image = Global.Web_Browser_Pro.My.Resources.Resources.squared_menu_filled_100px1
        Me.btnMenu.ImageActive = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(1146, 51)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(25, 25)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.TabStop = False
        Me.btnMenu.Zoom = 10
        '
        'txtURL
        '
        Me.txtURL.AcceptsReturn = False
        Me.txtURL.AcceptsTab = False
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtURL.BackColor = System.Drawing.Color.Transparent
        Me.txtURL.BackgroundImage = CType(resources.GetObject("txtURL.BackgroundImage"), System.Drawing.Image)
        Me.txtURL.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtURL.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtURL.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtURL.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtURL.BorderRadius = 1
        Me.txtURL.BorderThickness = 2
        Me.txtURL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtURL.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtURL.DefaultText = ""
        Me.txtURL.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtURL.ForeColor = System.Drawing.Color.White
        Me.txtURL.HideSelection = True
        Me.txtURL.IconLeft = Global.Web_Browser_Pro.My.Resources.Resources.search_filled_100px11
        Me.txtURL.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.txtURL.IconPadding = 10
        Me.txtURL.IconRight = Nothing
        Me.txtURL.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.txtURL.Location = New System.Drawing.Point(180, 44)
        Me.txtURL.MaxLength = 32767
        Me.txtURL.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtURL.Modified = False
        Me.txtURL.Name = "txtURL"
        Me.txtURL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtURL.ReadOnly = False
        Me.txtURL.SelectedText = ""
        Me.txtURL.SelectionLength = 0
        Me.txtURL.SelectionStart = 0
        Me.txtURL.ShortcutsEnabled = True
        Me.txtURL.Size = New System.Drawing.Size(898, 38)
        Me.txtURL.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtURL.TabIndex = 1
        Me.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtURL.TextMarginLeft = 5
        Me.txtURL.TextPlaceholder = "Enter Search or Web Adress"
        Me.txtURL.UseSystemPasswordChar = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnRefresh.Image = Global.Web_Browser_Pro.My.Resources.Resources.recurring_appointment_52px1
        Me.btnRefresh.ImageActive = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(65, 51)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 23)
        Me.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Zoom = 10
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnForward.Image = Global.Web_Browser_Pro.My.Resources.Resources.forward_52px1
        Me.btnForward.ImageActive = Nothing
        Me.btnForward.Location = New System.Drawing.Point(36, 47)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(30, 30)
        Me.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnForward.TabIndex = 1
        Me.btnForward.TabStop = False
        Me.btnForward.Zoom = 10
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBack.Image = Global.Web_Browser_Pro.My.Resources.Resources.back_52px1
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(5, 47)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 30)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 0
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'SqlabC_Theme1
        '
        Me.SqlabC_Theme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.SqlabC_Theme1.Controls.Add(Me.PictureBox1)
        Me.SqlabC_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SqlabC_Theme1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.SqlabC_Theme1.Location = New System.Drawing.Point(0, 0)
        Me.SqlabC_Theme1.Name = "SqlabC_Theme1"
        Me.SqlabC_Theme1.Size = New System.Drawing.Size(1177, 102)
        Me.SqlabC_Theme1.TabIndex = 10
        Me.SqlabC_Theme1.Text = "         Node3 Browser Pro"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Web_Browser_Pro.My.Resources.Resources.globe_96px
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.Black
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1, Me.ToolStripDropDownButton1})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 751)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1177, 22)
        Me.StatusStrip2.TabIndex = 1
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(85, 17)
        Me.ToolStripStatusLabel1.Text = "Loading Status"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Value = 100
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateYourOwnWebsiteToolStripMenuItem, Me.BookmarksToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripDropDownButton1.Image = Global.Web_Browser_Pro.My.Resources.Resources.add_60px1
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'CreateYourOwnWebsiteToolStripMenuItem
        '
        Me.CreateYourOwnWebsiteToolStripMenuItem.Name = "CreateYourOwnWebsiteToolStripMenuItem"
        Me.CreateYourOwnWebsiteToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CreateYourOwnWebsiteToolStripMenuItem.Text = "Create your Own Website"
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.BookmarksToolStripMenuItem.Text = "Bookmarks"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem1.Text = "Set Time and Date"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem2.Text = "Set Default HomePage"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem3.Text = "Set Backgroud Image"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem4.Text = "Clear Cookies"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(208, 22)
        Me.ToolStripMenuItem5.Text = "Settings"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(57, 102)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1120, 649)
        Me.TabControl1.TabIndex = 2
        '
        'Sidebar1
        '
        Me.Sidebar1.BackColor = System.Drawing.Color.Black
        Me.Sidebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar1.Location = New System.Drawing.Point(0, 102)
        Me.Sidebar1.Name = "Sidebar1"
        Me.Sidebar1.Size = New System.Drawing.Size(59, 649)
        Me.Sidebar1.TabIndex = 3
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem6.Text = "Themes"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 773)
        Me.Controls.Add(Me.Sidebar1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nod3 Browser Pro"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemoveTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBookmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SqlabC_Theme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnForward As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtURL As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnStop As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRemoveTab As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAddTab As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnBookmark As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SqlabC_Theme1 As SQLABC_ModernUI.SQLABC_Theme
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Sidebar1 As sidebar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents CreateYourOwnWebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
