<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        SplitContainer1 = New SplitContainer()
        Label7 = New Label()
        LinkLabel1 = New LinkLabel()
        CheckBoxSaveSettings = New CheckBox()
        Label6 = New Label()
        CheckBoxWindows = New CheckBox()
        ButtonConnect = New Button()
        ButtonDisconnect = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBoxServer = New TextBox()
        TextBoxUser = New TextBox()
        TextBoxPassword = New TextBox()
        TextBoxDB = New TextBox()
        TabPage2 = New TabPage()
        ToolStripContainer1 = New ToolStripContainer()
        ToolStripContainer2 = New ToolStripContainer()
        DataGridViewResults = New DataGridView()
        SplitContainer2 = New SplitContainer()
        Label5 = New Label()
        SplitContainer3 = New SplitContainer()
        TextBoxSearchItemName = New TextBox()
        ButtonSearchItem = New Button()
        TabPage3 = New TabPage()
        Label8 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        TabPage2.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        ToolStripContainer2.ContentPanel.SuspendLayout()
        ToolStripContainer2.SuspendLayout()
        CType(DataGridViewResults, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel1.SuspendLayout()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.AccessibleName = "Connection"
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(667, 560)
        TabControl1.TabIndex = 99
        TabControl1.Tag = "Connection"
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(SplitContainer1)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(659, 529)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Label7)
        SplitContainer1.Panel1.Controls.Add(LinkLabel1)
        SplitContainer1.Panel1.Controls.Add(CheckBoxSaveSettings)
        SplitContainer1.Panel1.Controls.Add(Label6)
        SplitContainer1.Panel1.Controls.Add(CheckBoxWindows)
        SplitContainer1.Panel1.Controls.Add(ButtonConnect)
        SplitContainer1.Panel1.Controls.Add(ButtonDisconnect)
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(TextBoxServer)
        SplitContainer1.Panel1.Controls.Add(TextBoxUser)
        SplitContainer1.Panel1.Controls.Add(TextBoxPassword)
        SplitContainer1.Panel1.Controls.Add(TextBoxDB)
        SplitContainer1.Size = New Size(653, 523)
        SplitContainer1.SplitterDistance = 610
        SplitContainer1.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(-1, 508)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 15)
        Label7.TabIndex = 16
        Label7.Text = "Tool made by"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(75, 508)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(66, 15)
        LinkLabel1.TabIndex = 15
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Shadoukita"
        ' 
        ' CheckBoxSaveSettings
        ' 
        CheckBoxSaveSettings.AutoSize = True
        CheckBoxSaveSettings.Location = New Point(295, 226)
        CheckBoxSaveSettings.Name = "CheckBoxSaveSettings"
        CheckBoxSaveSettings.Size = New Size(116, 19)
        CheckBoxSaveSettings.TabIndex = 6
        CheckBoxSaveSettings.Text = "Save Information"
        CheckBoxSaveSettings.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(20, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 21)
        Label6.TabIndex = 128
        Label6.Text = "Windows Authentication:"
        ' 
        ' CheckBoxWindows
        ' 
        CheckBoxWindows.AutoSize = True
        CheckBoxWindows.Location = New Point(228, 228)
        CheckBoxWindows.Name = "CheckBoxWindows"
        CheckBoxWindows.Size = New Size(15, 14)
        CheckBoxWindows.TabIndex = 5
        CheckBoxWindows.UseVisualStyleBackColor = True
        ' 
        ' ButtonConnect
        ' 
        ButtonConnect.Location = New Point(20, 268)
        ButtonConnect.Name = "ButtonConnect"
        ButtonConnect.Size = New Size(128, 38)
        ButtonConnect.TabIndex = 7
        ButtonConnect.Text = "Connect"
        ButtonConnect.UseVisualStyleBackColor = True
        ' 
        ' ButtonDisconnect
        ' 
        ButtonDisconnect.Location = New Point(228, 268)
        ButtonDisconnect.Name = "ButtonDisconnect"
        ButtonDisconnect.Size = New Size(128, 38)
        ButtonDisconnect.TabIndex = 8
        ButtonDisconnect.Text = "Disconnect"
        ButtonDisconnect.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 21)
        Label4.TabIndex = 78
        Label4.Text = "DB Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 21)
        Label3.TabIndex = 68
        Label3.Text = "DB Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 588
        Label2.Text = "Database:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 88
        Label1.Text = "Server:"
        ' 
        ' TextBoxServer
        ' 
        TextBoxServer.Location = New Point(228, 28)
        TextBoxServer.Name = "TextBoxServer"
        TextBoxServer.Size = New Size(183, 23)
        TextBoxServer.TabIndex = 0
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.Location = New Point(228, 128)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.Size = New Size(183, 23)
        TextBoxUser.TabIndex = 2
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(228, 178)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.Size = New Size(183, 23)
        TextBoxPassword.TabIndex = 3
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' TextBoxDB
        ' 
        TextBoxDB.Location = New Point(228, 78)
        TextBoxDB.Name = "TextBoxDB"
        TextBoxDB.Size = New Size(183, 23)
        TextBoxDB.TabIndex = 1
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(ToolStripContainer1)
        TabPage2.Location = New Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(659, 529)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Controls.Add(ToolStripContainer2)
        ToolStripContainer1.ContentPanel.Controls.Add(SplitContainer2)
        ToolStripContainer1.ContentPanel.Size = New Size(653, 498)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(3, 3)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(653, 523)
        ToolStripContainer1.TabIndex = 0
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ' 
        ' ToolStripContainer2
        ' 
        ' 
        ' ToolStripContainer2.ContentPanel
        ' 
        ToolStripContainer2.ContentPanel.Controls.Add(DataGridViewResults)
        ToolStripContainer2.ContentPanel.Size = New Size(653, 447)
        ToolStripContainer2.Dock = DockStyle.Fill
        ToolStripContainer2.Location = New Point(0, 26)
        ToolStripContainer2.Name = "ToolStripContainer2"
        ToolStripContainer2.Size = New Size(653, 472)
        ToolStripContainer2.TabIndex = 4
        ToolStripContainer2.Text = "ToolStripContainer2"
        ' 
        ' DataGridViewResults
        ' 
        DataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewResults.Dock = DockStyle.Fill
        DataGridViewResults.Location = New Point(0, 0)
        DataGridViewResults.Name = "DataGridViewResults"
        DataGridViewResults.Size = New Size(653, 447)
        DataGridViewResults.TabIndex = 3
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Top
        SplitContainer2.FixedPanel = FixedPanel.Panel1
        SplitContainer2.ImeMode = ImeMode.NoControl
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(Label5)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(SplitContainer3)
        SplitContainer2.Size = New Size(653, 26)
        SplitContainer2.SplitterDistance = 70
        SplitContainer2.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 21)
        Label5.TabIndex = 144
        Label5.Text = "Search:"
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.Location = New Point(0, 0)
        SplitContainer3.Name = "SplitContainer3"
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.Controls.Add(TextBoxSearchItemName)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(ButtonSearchItem)
        SplitContainer3.Size = New Size(579, 26)
        SplitContainer3.SplitterDistance = 470
        SplitContainer3.TabIndex = 5
        ' 
        ' TextBoxSearchItemName
        ' 
        TextBoxSearchItemName.Dock = DockStyle.Fill
        TextBoxSearchItemName.Location = New Point(0, 0)
        TextBoxSearchItemName.Name = "TextBoxSearchItemName"
        TextBoxSearchItemName.Size = New Size(470, 23)
        TextBoxSearchItemName.TabIndex = 0
        ' 
        ' ButtonSearchItem
        ' 
        ButtonSearchItem.Dock = DockStyle.Fill
        ButtonSearchItem.Location = New Point(0, 0)
        ButtonSearchItem.Name = "ButtonSearchItem"
        ButtonSearchItem.Size = New Size(105, 26)
        ButtonSearchItem.TabIndex = 1
        ButtonSearchItem.Text = "Search"
        ButtonSearchItem.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Label8)
        TabPage3.Location = New Point(4, 27)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(659, 529)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Showcard Gothic", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(109, 118)
        Label8.Name = "Label8"
        Label8.Size = New Size(396, 60)
        Label8.TabIndex = 0
        Label8.Text = "Comming Soon"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(667, 560)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(476, 476)
        Name = "Form1"
        Text = "ODMO DBViewer"
        TransparencyKey = Color.LightSlateGray
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        ToolStripContainer2.ContentPanel.ResumeLayout(False)
        ToolStripContainer2.ResumeLayout(False)
        ToolStripContainer2.PerformLayout()
        CType(DataGridViewResults, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        SplitContainer3.Panel1.ResumeLayout(False)
        SplitContainer3.Panel1.PerformLayout()
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents TextBoxDB As TextBox
    Friend WithEvents TextBoxServer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSearchItemName As TextBox
    Friend WithEvents DataGridViewResults As DataGridView
    Friend WithEvents ButtonSearchItem As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxWindows As CheckBox
    Friend WithEvents CheckBoxSaveSettings As CheckBox
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label8 As Label
End Class
