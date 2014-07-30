<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.boxEdit = New System.Windows.Forms.ComboBox()
        Me.boxUser = New System.Windows.Forms.ComboBox()
        Me.boxSystem = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomEntry = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEditSystem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEditSystem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtReplace)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFind)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boxSystem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boxUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.boxEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtCustomEntry)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(884, 462)
        Me.SplitContainer1.SplitterDistance = 405
        Me.SplitContainer1.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"this", "is", "a", "test"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 107)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(405, 355)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(0, 107)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(475, 355)
        Me.ListBox2.TabIndex = 1
        '
        'boxEdit
        '
        Me.boxEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxEdit.FormattingEnabled = True
        Me.boxEdit.Location = New System.Drawing.Point(51, 55)
        Me.boxEdit.Name = "boxEdit"
        Me.boxEdit.Size = New System.Drawing.Size(121, 21)
        Me.boxEdit.TabIndex = 0
        '
        'boxUser
        '
        Me.boxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxUser.FormattingEnabled = True
        Me.boxUser.Items.AddRange(New Object() {"Brandan", "Corey", "Miah"})
        Me.boxUser.Location = New System.Drawing.Point(50, 12)
        Me.boxUser.Name = "boxUser"
        Me.boxUser.Size = New System.Drawing.Size(100, 21)
        Me.boxUser.TabIndex = 1
        '
        'boxSystem
        '
        Me.boxSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxSystem.FormattingEnabled = True
        Me.boxSystem.Location = New System.Drawing.Point(218, 13)
        Me.boxSystem.Name = "boxSystem"
        Me.boxSystem.Size = New System.Drawing.Size(100, 21)
        Me.boxSystem.TabIndex = 2
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(50, 55)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 20)
        Me.txtFind.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Find:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Replace:"
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(218, 55)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(100, 20)
        Me.txtReplace.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Custom Entry:"
        '
        'txtCustomEntry
        '
        Me.txtCustomEntry.Location = New System.Drawing.Point(84, 13)
        Me.txtCustomEntry.Name = "txtCustomEntry"
        Me.txtCustomEntry.Size = New System.Drawing.Size(379, 20)
        Me.txtCustomEntry.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(388, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "System:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Find & Replace, Case matters, only edits items in the list below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Changes are no" & _
            "t saved"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 26)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Deletes items from the list below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "changes are saved with the save button"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Edit:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(388, 78)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEditSystem
        '
        Me.btnEditSystem.Location = New System.Drawing.Point(324, 13)
        Me.btnEditSystem.Name = "btnEditSystem"
        Me.btnEditSystem.Size = New System.Drawing.Size(31, 23)
        Me.btnEditSystem.TabIndex = 10
        Me.btnEditSystem.Text = "..."
        Me.btnEditSystem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Notes V2"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnEditSystem As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents boxSystem As System.Windows.Forms.ComboBox
    Friend WithEvents boxUser As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents boxEdit As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomEntry As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
