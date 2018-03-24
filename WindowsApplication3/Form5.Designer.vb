<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.a1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineeringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.a3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Rtb3 = New System.Windows.Forms.RichTextBox()
        Me.Rtb2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(823, 120)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(264, 41)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(687, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 49)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search College"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(901, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(207, 80)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Welcome"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.a1, Me.a2, Me.a3, Me.a4, Me.EditDatabaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 117)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 44)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'a1
        '
        Me.a1.AutoSize = False
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(130, 40)
        Me.a1.Text = "Home"
        '
        'a2
        '
        Me.a2.AutoSize = False
        Me.a2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EngineeringToolStripMenuItem, Me.MedicalToolStripMenuItem})
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(130, 40)
        Me.a2.Text = "Colleges"
        '
        'EngineeringToolStripMenuItem
        '
        Me.EngineeringToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EngineeringToolStripMenuItem.Name = "EngineeringToolStripMenuItem"
        Me.EngineeringToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EngineeringToolStripMenuItem.Text = "Engineering"
        '
        'MedicalToolStripMenuItem
        '
        Me.MedicalToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MedicalToolStripMenuItem.Name = "MedicalToolStripMenuItem"
        Me.MedicalToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.MedicalToolStripMenuItem.Text = "Medical"
        '
        'a3
        '
        Me.a3.AutoSize = False
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(130, 40)
        Me.a3.Text = "Contact us"
        '
        'a4
        '
        Me.a4.AutoSize = False
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(145, 40)
        Me.a4.Text = "Logout"
        '
        'EditDatabaseToolStripMenuItem
        '
        Me.EditDatabaseToolStripMenuItem.AutoSize = False
        Me.EditDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditDatabaseToolStripMenuItem.Name = "EditDatabaseToolStripMenuItem"
        Me.EditDatabaseToolStripMenuItem.Size = New System.Drawing.Size(135, 40)
        Me.EditDatabaseToolStripMenuItem.Text = " Edit Database"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(900, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 38)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Admin"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.LightGray
        Me.RichTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(1, 164)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(1109, 543)
        Me.RichTextBox2.TabIndex = 24
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        Me.RichTextBox2.Visible = False
        '
        'Rtb3
        '
        Me.Rtb3.BackColor = System.Drawing.Color.LightGray
        Me.Rtb3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtb3.Location = New System.Drawing.Point(1, 164)
        Me.Rtb3.Name = "Rtb3"
        Me.Rtb3.Size = New System.Drawing.Size(1100, 520)
        Me.Rtb3.TabIndex = 23
        Me.Rtb3.Text = resources.GetString("Rtb3.Text")
        Me.Rtb3.Visible = False
        '
        'Rtb2
        '
        Me.Rtb2.BackColor = System.Drawing.Color.LightGray
        Me.Rtb2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtb2.Location = New System.Drawing.Point(1, 164)
        Me.Rtb2.Name = "Rtb2"
        Me.Rtb2.Size = New System.Drawing.Size(1101, 532)
        Me.Rtb2.TabIndex = 21
        Me.Rtb2.Text = resources.GetString("Rtb2.Text")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication3.My.Resources.Resources._31_5_2013_17_31_09_6gfeuhi1gbomn16mfl3kiusa63_liq99i2i
        Me.PictureBox3.Location = New System.Drawing.Point(22, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(147, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.header_2
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1100, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RichTextBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(787, 175)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(236, 488)
        Me.RichTextBox3.TabIndex = 25
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        Me.RichTextBox3.Visible = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 661)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Rtb3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Rtb2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents a1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EngineeringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents a4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Rtb3 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Rtb2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
End Class
