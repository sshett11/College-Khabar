<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.a1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.a3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb = New System.Windows.Forms.RichTextBox()
        Me.Rtb2 = New System.Windows.Forms.RichTextBox()
        Me.Rtb3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(753, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(591, 161)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 166)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 44)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'a1
        '
        Me.a1.AutoSize = False
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(160, 40)
        Me.a1.Text = "Home"
        '
        'a2
        '
        Me.a2.AutoSize = False
        Me.a2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EngineeringToolStripMenuItem, Me.MedicalToolStripMenuItem})
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(165, 40)
        Me.a2.Text = "Colleges"
        '
        'EngineeringToolStripMenuItem
        '
        Me.EngineeringToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EngineeringToolStripMenuItem.Name = "EngineeringToolStripMenuItem"
        Me.EngineeringToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.EngineeringToolStripMenuItem.Text = "Engineering"
        '
        'MedicalToolStripMenuItem
        '
        Me.MedicalToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MedicalToolStripMenuItem.Name = "MedicalToolStripMenuItem"
        Me.MedicalToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.MedicalToolStripMenuItem.Text = "Medical"
        '
        'a3
        '
        Me.a3.AutoSize = False
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(165, 40)
        Me.a3.Text = "Contact us"
        '
        'a4
        '
        Me.a4.AutoSize = False
        Me.a4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(175, 40)
        Me.a4.Text = "My Profile"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(133, 26)
        Me.EditToolStripMenuItem1.Text = "Update"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(904, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Search College"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb
        '
        Me.tb.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb.Location = New System.Drawing.Point(1101, 170)
        Me.tb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(224, 50)
        Me.tb.TabIndex = 4
        Me.tb.Text = ""
        '
        'Rtb2
        '
        Me.Rtb2.BackColor = System.Drawing.Color.LightGray
        Me.Rtb2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtb2.Location = New System.Drawing.Point(3, 224)
        Me.Rtb2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rtb2.Name = "Rtb2"
        Me.Rtb2.Size = New System.Drawing.Size(1353, 484)
        Me.Rtb2.TabIndex = 7
        Me.Rtb2.Text = resources.GetString("Rtb2.Text")
        '
        'Rtb3
        '
        Me.Rtb3.BackColor = System.Drawing.Color.LightGray
        Me.Rtb3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtb3.Location = New System.Drawing.Point(3, 228)
        Me.Rtb3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rtb3.Name = "Rtb3"
        Me.Rtb3.Size = New System.Drawing.Size(1367, 456)
        Me.Rtb3.TabIndex = 9
        Me.Rtb3.Text = resources.GetString("Rtb3.Text")
        Me.Rtb3.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.LightGray
        Me.RichTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 228)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(1353, 452)
        Me.RichTextBox2.TabIndex = 10
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        Me.RichTextBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(16, 242)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(195, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1343, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Crimson
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox1.Location = New System.Drawing.Point(1164, 53)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 46)
        Me.TextBox1.TabIndex = 11
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTextBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(1012, 254)
        Me.RichTextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(313, 217)
        Me.RichTextBox3.TabIndex = 12
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        Me.RichTextBox3.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1353, 674)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Rtb3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Rtb2)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents a1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EngineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb As System.Windows.Forms.RichTextBox
    Friend WithEvents Rtb2 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Rtb3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
End Class
