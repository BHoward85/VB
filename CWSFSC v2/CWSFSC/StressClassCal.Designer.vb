<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StressClassCal
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
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarLable = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCtrlSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfFightersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetStressClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataViewer = New System.Windows.Forms.DataGridView()
        Me.ListOfSystemLable = New System.Windows.Forms.Label()
        Me.ListOfSystems = New System.Windows.Forms.ListBox()
        Me.UseSystemButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NameOfFighterLable = New System.Windows.Forms.Label()
        Me.SetNameButton = New System.Windows.Forms.Button()
        Me.ListOfFighterTypesCheckBox = New System.Windows.Forms.CheckedListBox()
        Me.FighterTypeLable = New System.Windows.Forms.Label()
        Me.StatusBar.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        CType(Me.DataViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarLable})
        Me.StatusBar.Location = New System.Drawing.Point(0, 490)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(884, 22)
        Me.StatusBar.TabIndex = 0
        Me.StatusBar.Text = "Status Bar"
        '
        'StatusBarLable
        '
        Me.StatusBarLable.Name = "StatusBarLable"
        Me.StatusBarLable.Size = New System.Drawing.Size(39, 17)
        Me.StatusBarLable.Text = "Status"
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataSetToolStripMenuItem, Me.CalculatToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(884, 24)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "Menu Bar"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveCtrlSToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveCtrlSToolStripMenuItem
        '
        Me.SaveCtrlSToolStripMenuItem.Name = "SaveCtrlSToolStripMenuItem"
        Me.SaveCtrlSToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveCtrlSToolStripMenuItem.Text = "&Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "&Load"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'DataSetToolStripMenuItem
        '
        Me.DataSetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfSystemToolStripMenuItem, Me.ListOfFightersToolStripMenuItem})
        Me.DataSetToolStripMenuItem.Name = "DataSetToolStripMenuItem"
        Me.DataSetToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.DataSetToolStripMenuItem.Text = "&DataSet"
        '
        'ListOfSystemToolStripMenuItem
        '
        Me.ListOfSystemToolStripMenuItem.Name = "ListOfSystemToolStripMenuItem"
        Me.ListOfSystemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListOfSystemToolStripMenuItem.Text = "List of S&ystems"
        '
        'ListOfFightersToolStripMenuItem
        '
        Me.ListOfFightersToolStripMenuItem.Name = "ListOfFightersToolStripMenuItem"
        Me.ListOfFightersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListOfFightersToolStripMenuItem.Text = "List of Fi&ghters"
        '
        'CalculatToolStripMenuItem
        '
        Me.CalculatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetStressClassToolStripMenuItem})
        Me.CalculatToolStripMenuItem.Name = "CalculatToolStripMenuItem"
        Me.CalculatToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalculatToolStripMenuItem.Text = "&Calculat"
        '
        'GetStressClassToolStripMenuItem
        '
        Me.GetStressClassToolStripMenuItem.Name = "GetStressClassToolStripMenuItem"
        Me.GetStressClassToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GetStressClassToolStripMenuItem.Text = "Get S&tress Class"
        '
        'DataViewer
        '
        Me.DataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataViewer.Location = New System.Drawing.Point(12, 191)
        Me.DataViewer.Name = "DataViewer"
        Me.DataViewer.Size = New System.Drawing.Size(860, 287)
        Me.DataViewer.TabIndex = 2
        '
        'ListOfSystemLable
        '
        Me.ListOfSystemLable.AutoSize = True
        Me.ListOfSystemLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListOfSystemLable.Location = New System.Drawing.Point(8, 87)
        Me.ListOfSystemLable.Name = "ListOfSystemLable"
        Me.ListOfSystemLable.Size = New System.Drawing.Size(117, 20)
        Me.ListOfSystemLable.TabIndex = 5
        Me.ListOfSystemLable.Text = "List of Systems"
        '
        'ListOfSystems
        '
        Me.ListOfSystems.FormattingEnabled = True
        Me.ListOfSystems.Location = New System.Drawing.Point(12, 116)
        Me.ListOfSystems.Name = "ListOfSystems"
        Me.ListOfSystems.Size = New System.Drawing.Size(215, 69)
        Me.ListOfSystems.TabIndex = 6
        '
        'UseSystemButton
        '
        Me.UseSystemButton.Location = New System.Drawing.Point(127, 87)
        Me.UseSystemButton.Name = "UseSystemButton"
        Me.UseSystemButton.Size = New System.Drawing.Size(100, 23)
        Me.UseSystemButton.TabIndex = 7
        Me.UseSystemButton.Text = "Use System"
        Me.UseSystemButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 20)
        Me.TextBox1.TabIndex = 8
        '
        'NameOfFighterLable
        '
        Me.NameOfFighterLable.AutoSize = True
        Me.NameOfFighterLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOfFighterLable.Location = New System.Drawing.Point(8, 32)
        Me.NameOfFighterLable.Name = "NameOfFighterLable"
        Me.NameOfFighterLable.Size = New System.Drawing.Size(105, 20)
        Me.NameOfFighterLable.TabIndex = 10
        Me.NameOfFighterLable.Text = "Fighter Name"
        '
        'SetNameButton
        '
        Me.SetNameButton.Location = New System.Drawing.Point(127, 32)
        Me.SetNameButton.Name = "SetNameButton"
        Me.SetNameButton.Size = New System.Drawing.Size(100, 23)
        Me.SetNameButton.TabIndex = 11
        Me.SetNameButton.Text = "Set Name"
        Me.SetNameButton.UseVisualStyleBackColor = True
        '
        'ListOfFighterTypesCheckBox
        '
        Me.ListOfFighterTypesCheckBox.AllowDrop = True
        Me.ListOfFighterTypesCheckBox.FormattingEnabled = True
        Me.ListOfFighterTypesCheckBox.Location = New System.Drawing.Point(233, 61)
        Me.ListOfFighterTypesCheckBox.Name = "ListOfFighterTypesCheckBox"
        Me.ListOfFighterTypesCheckBox.Size = New System.Drawing.Size(189, 124)
        Me.ListOfFighterTypesCheckBox.TabIndex = 12
        '
        'FighterTypeLable
        '
        Me.FighterTypeLable.AutoSize = True
        Me.FighterTypeLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FighterTypeLable.Location = New System.Drawing.Point(233, 32)
        Me.FighterTypeLable.Name = "FighterTypeLable"
        Me.FighterTypeLable.Size = New System.Drawing.Size(152, 20)
        Me.FighterTypeLable.TabIndex = 13
        Me.FighterTypeLable.Text = "List of Fighter Types"
        '
        'StressClassCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.FighterTypeLable)
        Me.Controls.Add(Me.ListOfFighterTypesCheckBox)
        Me.Controls.Add(Me.SetNameButton)
        Me.Controls.Add(Me.NameOfFighterLable)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UseSystemButton)
        Me.Controls.Add(Me.ListOfSystems)
        Me.Controls.Add(Me.ListOfSystemLable)
        Me.Controls.Add(Me.DataViewer)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuBar
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StressClassCal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Stress Class Calculator"
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.DataViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents StatusBarLable As ToolStripStatusLabel
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfFightersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetStressClassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataViewer As DataGridView
    Friend WithEvents ListOfSystemLable As Label
    Friend WithEvents ListOfSystems As ListBox
    Friend WithEvents UseSystemButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NameOfFighterLable As Label
    Friend WithEvents SetNameButton As Button
    Friend WithEvents ListOfFighterTypesCheckBox As CheckedListBox
    Friend WithEvents FighterTypeLable As Label
End Class
