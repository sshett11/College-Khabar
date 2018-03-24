<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.a1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProfileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(599, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(470, 131)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Welcome"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.a1, Me.a2, Me.a3, Me.a4, Me.MyProfileToolStripMenuItem, Me.MyProfileToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 132)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(986, 44)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'a1
        '
        Me.a1.AutoSize = False
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(170, 40)
        Me.a1.Text = "Home"
        '
        'a2
        '
        Me.a2.AutoSize = False
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(94, 40)
        Me.a2.Text = "Courses"
        '
        'a3
        '
        Me.a3.AutoSize = False
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(175, 40)
        Me.a3.Text = "Placements"
        '
        'a4
        '
        Me.a4.AutoSize = False
        Me.a4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SportsToolStripMenuItem, Me.HostelToolStripMenuItem})
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(175, 40)
        Me.a4.Text = "Extra "
        '
        'SportsToolStripMenuItem
        '
        Me.SportsToolStripMenuItem.Name = "SportsToolStripMenuItem"
        Me.SportsToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.SportsToolStripMenuItem.Text = "Sports"
        '
        'HostelToolStripMenuItem
        '
        Me.HostelToolStripMenuItem.Name = "HostelToolStripMenuItem"
        Me.HostelToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HostelToolStripMenuItem.Text = "Hostel"
        '
        'MyProfileToolStripMenuItem
        '
        Me.MyProfileToolStripMenuItem.AutoSize = False
        Me.MyProfileToolStripMenuItem.Name = "MyProfileToolStripMenuItem"
        Me.MyProfileToolStripMenuItem.Size = New System.Drawing.Size(180, 40)
        Me.MyProfileToolStripMenuItem.Text = "Contact Details"
        '
        'MyProfileToolStripMenuItem1
        '
        Me.MyProfileToolStripMenuItem1.AutoSize = False
        Me.MyProfileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.DeleteAccountToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MyProfileToolStripMenuItem1.Name = "MyProfileToolStripMenuItem1"
        Me.MyProfileToolStripMenuItem1.Size = New System.Drawing.Size(180, 40)
        Me.MyProfileToolStripMenuItem1.Text = "My Profile"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteAccountToolStripMenuItem
        '
        Me.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem"
        Me.DeleteAccountToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DeleteAccountToolStripMenuItem.Text = "Delete account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 179)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1067, 64)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(359, 239)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(365, 277)
        Me.RichTextBox2.TabIndex = 20
        Me.RichTextBox2.Text = "Contact details:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "NMAMIT" & Global.Microsoft.VisualBasic.ChrW(10) & "nitte,karakala taluk,Udupi district" & Global.Microsoft.VisualBasic.ChrW(10) & "Karnataka" & Global.Microsoft.VisualBasic.ChrW(10) & "574110" & Global.Microsoft.VisualBasic.ChrW(10) & "ph-" & _
    "23489800" & Global.Microsoft.VisualBasic.ChrW(10) & "email-nitte.edu@gmail.com"
        Me.RichTextBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.header_2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1069, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 239)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1067, 306)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(804, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Review"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 528)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents a1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyProfileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HostelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
