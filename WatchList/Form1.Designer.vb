﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WatchList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WatchList))
        Dim WebPreferences9 As Awesomium.Core.WebPreferences = New Awesomium.Core.WebPreferences(True)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelLoggedIn = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AddressBox1 = New Awesomium.Windows.Forms.AddressBox()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkCharCorpValidate = New System.Windows.Forms.CheckBox()
        Me.btnUpdateLabel = New System.Windows.Forms.Button()
        Me.txtUpdateLabel = New System.Windows.Forms.TextBox()
        Me.lblCharactersCount = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblContactLabel = New System.Windows.Forms.Label()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.MembersList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextCharacter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewOnEveGateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOnEveWhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonLookup = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextEntityName = New System.Windows.Forms.TextBox()
        Me.ComboType = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebSessionProvider1 = New Awesomium.Windows.Forms.WebSessionProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextCharacter.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(669, 515)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.LabelLoggedIn)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextPass)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextUser)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(661, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Help"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(495, 65)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 22)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Continue..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Please login to EVE Gate in the EVE Gate tab. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Then select the character whose" & _
    " Contacts you'd like to update." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelLoggedIn
        '
        Me.LabelLoggedIn.AutoSize = True
        Me.LabelLoggedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoggedIn.Location = New System.Drawing.Point(156, 111)
        Me.LabelLoggedIn.Name = "LabelLoggedIn"
        Me.LabelLoggedIn.Size = New System.Drawing.Size(78, 15)
        Me.LabelLoggedIn.TabIndex = 5
        Me.LabelLoggedIn.Text = "Please login:"
        Me.LabelLoggedIn.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextPass
        '
        Me.TextPass.Location = New System.Drawing.Point(204, 179)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPass.Size = New System.Drawing.Size(201, 21)
        Me.TextPass.TabIndex = 3
        Me.TextPass.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pass:"
        Me.Label2.Visible = False
        '
        'TextUser
        '
        Me.TextUser.Location = New System.Drawing.Point(204, 142)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(201, 21)
        Me.TextUser.TabIndex = 1
        Me.TextUser.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User:"
        Me.Label1.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AddressBox1)
        Me.TabPage3.Controls.Add(Me.WebControl1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(661, 489)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "EVE Gate"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AddressBox1
        '
        Me.AddressBox1.AcceptsReturn = True
        Me.AddressBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AddressBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AddressBox1.Location = New System.Drawing.Point(1, 3)
        Me.AddressBox1.Name = "AddressBox1"
        Me.AddressBox1.Size = New System.Drawing.Size(657, 21)
        Me.AddressBox1.TabIndex = 1
        Me.AddressBox1.URL = Nothing
        Me.AddressBox1.WebControl = Me.WebControl1
        '
        'WebControl1
        '
        Me.WebControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebControl1.Location = New System.Drawing.Point(3, 30)
        Me.WebControl1.Size = New System.Drawing.Size(655, 456)
        Me.WebControl1.Source = New System.Uri("https://login.eveonline.com/Account/LogOn", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.chkCharCorpValidate)
        Me.TabPage2.Controls.Add(Me.btnUpdateLabel)
        Me.TabPage2.Controls.Add(Me.txtUpdateLabel)
        Me.TabPage2.Controls.Add(Me.lblCharactersCount)
        Me.TabPage2.Controls.Add(Me.btnCancel)
        Me.TabPage2.Controls.Add(Me.lblContactLabel)
        Me.TabPage2.Controls.Add(Me.btnAddAll)
        Me.TabPage2.Controls.Add(Me.MembersList)
        Me.TabPage2.Controls.Add(Me.ButtonLookup)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextEntityName)
        Me.TabPage2.Controls.Add(Me.ComboType)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPage2.Size = New System.Drawing.Size(661, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Watch List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.WatchList.My.Resources.Resources.legend1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(460, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 21)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'chkCharCorpValidate
        '
        Me.chkCharCorpValidate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkCharCorpValidate.AutoSize = True
        Me.chkCharCorpValidate.Location = New System.Drawing.Point(13, 411)
        Me.chkCharCorpValidate.Name = "chkCharCorpValidate"
        Me.chkCharCorpValidate.Size = New System.Drawing.Size(330, 17)
        Me.chkCharCorpValidate.TabIndex = 12
        Me.chkCharCorpValidate.Text = "Add Character only if they're still in this corp/alliance"
        Me.chkCharCorpValidate.UseVisualStyleBackColor = True
        '
        'btnUpdateLabel
        '
        Me.btnUpdateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateLabel.Location = New System.Drawing.Point(229, 444)
        Me.btnUpdateLabel.Name = "btnUpdateLabel"
        Me.btnUpdateLabel.Size = New System.Drawing.Size(43, 28)
        Me.btnUpdateLabel.TabIndex = 11
        Me.btnUpdateLabel.Text = "OK"
        Me.btnUpdateLabel.UseVisualStyleBackColor = True
        Me.btnUpdateLabel.Visible = False
        '
        'txtUpdateLabel
        '
        Me.txtUpdateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUpdateLabel.Location = New System.Drawing.Point(103, 447)
        Me.txtUpdateLabel.Name = "txtUpdateLabel"
        Me.txtUpdateLabel.Size = New System.Drawing.Size(118, 21)
        Me.txtUpdateLabel.TabIndex = 10
        Me.txtUpdateLabel.Visible = False
        '
        'lblCharactersCount
        '
        Me.lblCharactersCount.AutoSize = True
        Me.lblCharactersCount.Location = New System.Drawing.Point(10, 69)
        Me.lblCharactersCount.Name = "lblCharactersCount"
        Me.lblCharactersCount.Size = New System.Drawing.Size(112, 13)
        Me.lblCharactersCount.TabIndex = 9
        Me.lblCharactersCount.Text = "0 characters in list"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(415, 446)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 24)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblContactLabel
        '
        Me.lblContactLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblContactLabel.AutoSize = True
        Me.lblContactLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblContactLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblContactLabel.Location = New System.Drawing.Point(10, 452)
        Me.lblContactLabel.Name = "lblContactLabel"
        Me.lblContactLabel.Size = New System.Drawing.Size(90, 13)
        Me.lblContactLabel.TabIndex = 7
        Me.lblContactLabel.Text = "Contact Label:"
        '
        'btnAddAll
        '
        Me.btnAddAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAll.Location = New System.Drawing.Point(525, 444)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(115, 28)
        Me.btnAddAll.TabIndex = 6
        Me.btnAddAll.Text = "Add to Watch list"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'MembersList
        '
        Me.MembersList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MembersList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.MembersList.ContextMenuStrip = Me.ContextCharacter
        Me.MembersList.FullRowSelect = True
        Me.MembersList.GridLines = True
        Me.MembersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MembersList.HideSelection = False
        Me.MembersList.Location = New System.Drawing.Point(13, 88)
        Me.MembersList.Name = "MembersList"
        Me.MembersList.Size = New System.Drawing.Size(626, 317)
        Me.MembersList.SmallImageList = Me.ImageList1
        Me.MembersList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.MembersList.TabIndex = 5
        Me.MembersList.UseCompatibleStateImageBehavior = False
        Me.MembersList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Character Name"
        Me.ColumnHeader1.Width = 515
        '
        'ContextCharacter
        '
        Me.ContextCharacter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveContactToolStripMenuItem, Me.AddContactToolStripMenuItem, Me.ToolStripSeparator1, Me.ViewOnEveGateToolStripMenuItem, Me.ViewOnEveWhoToolStripMenuItem})
        Me.ContextCharacter.Name = "ContextCharacter"
        Me.ContextCharacter.Size = New System.Drawing.Size(166, 98)
        '
        'RemoveContactToolStripMenuItem
        '
        Me.RemoveContactToolStripMenuItem.Image = Global.WatchList.My.Resources.Resources.remove
        Me.RemoveContactToolStripMenuItem.Name = "RemoveContactToolStripMenuItem"
        Me.RemoveContactToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RemoveContactToolStripMenuItem.Text = "Remove Selected"
        '
        'AddContactToolStripMenuItem
        '
        Me.AddContactToolStripMenuItem.Image = Global.WatchList.My.Resources.Resources.checkbox
        Me.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem"
        Me.AddContactToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AddContactToolStripMenuItem.Text = "Add Selected"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'ViewOnEveGateToolStripMenuItem
        '
        Me.ViewOnEveGateToolStripMenuItem.Name = "ViewOnEveGateToolStripMenuItem"
        Me.ViewOnEveGateToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewOnEveGateToolStripMenuItem.Text = "View on Eve Gate"
        '
        'ViewOnEveWhoToolStripMenuItem
        '
        Me.ViewOnEveWhoToolStripMenuItem.Name = "ViewOnEveWhoToolStripMenuItem"
        Me.ViewOnEveWhoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewOnEveWhoToolStripMenuItem.Text = "View on Eve Who"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "checkbox.png")
        Me.ImageList1.Images.SetKeyName(1, "left-corp.png")
        Me.ImageList1.Images.SetKeyName(2, "legend.png")
        Me.ImageList1.Images.SetKeyName(3, "remove.png")
        '
        'ButtonLookup
        '
        Me.ButtonLookup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLookup.Location = New System.Drawing.Point(538, 26)
        Me.ButtonLookup.Name = "ButtonLookup"
        Me.ButtonLookup.Size = New System.Drawing.Size(101, 27)
        Me.ButtonLookup.TabIndex = 3
        Me.ButtonLookup.Text = "Lookup"
        Me.ButtonLookup.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Corp/Alliance:"
        '
        'TextEntityName
        '
        Me.TextEntityName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEntityName.Location = New System.Drawing.Point(225, 30)
        Me.TextEntityName.Name = "TextEntityName"
        Me.TextEntityName.Size = New System.Drawing.Size(307, 21)
        Me.TextEntityName.TabIndex = 1
        '
        'ComboType
        '
        Me.ComboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Items.AddRange(New Object() {"Alliance", "Corporation"})
        Me.ComboType.Location = New System.Drawing.Point(108, 30)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(111, 21)
        Me.ComboType.Sorted = True
        Me.ComboType.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 559)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(576, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Ready..."
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HelpToolStripMenuItem.Text = "About"
        '
        'WebSessionProvider1
        '
        WebPreferences9.RemoteFonts = False
        Me.WebSessionProvider1.Preferences = WebPreferences9
        Me.WebSessionProvider1.Views.Add(Me.WebControl1)
        '
        'WatchList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 581)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(629, 520)
        Me.Name = "WatchList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WatchList"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextCharacter.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LabelLoggedIn As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboType As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonLookup As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEntityName As System.Windows.Forms.TextBox
    Friend WithEvents MembersList As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAddAll As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents lblContactLabel As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents WebSessionProvider1 As Awesomium.Windows.Forms.WebSessionProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddressBox1 As Awesomium.Windows.Forms.AddressBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCharactersCount As System.Windows.Forms.Label
    Friend WithEvents btnUpdateLabel As System.Windows.Forms.Button
    Friend WithEvents txtUpdateLabel As System.Windows.Forms.TextBox
    Friend WithEvents chkCharCorpValidate As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextCharacter As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewOnEveGateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOnEveWhoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
