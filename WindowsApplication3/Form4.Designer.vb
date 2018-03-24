<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlcmntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HostelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SportsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClgdetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.College_khabar3DataSet = New WindowsApplication3.college_khabar3DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Clg_detailsTableAdapter = New WindowsApplication3.college_khabar3DataSetTableAdapters.Clg_detailsTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClgdetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.College_khabar3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(592, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(482, 131)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Image = Global.WindowsApplication3.My.Resources.Resources.header_2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1061, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CidDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.InfoDataGridViewTextBoxColumn, Me.PlcmntDataGridViewTextBoxColumn, Me.RankDataGridViewTextBoxColumn, Me.HostelDataGridViewTextBoxColumn, Me.SportsDataGridViewTextBoxColumn, Me.CoursesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClgdetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 273)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1024, 180)
        Me.DataGridView1.TabIndex = 6
        '
        'CidDataGridViewTextBoxColumn
        '
        Me.CidDataGridViewTextBoxColumn.DataPropertyName = "cid"
        Me.CidDataGridViewTextBoxColumn.HeaderText = "cid"
        Me.CidDataGridViewTextBoxColumn.Name = "CidDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "Cname"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "Cname"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'InfoDataGridViewTextBoxColumn
        '
        Me.InfoDataGridViewTextBoxColumn.DataPropertyName = "Info"
        Me.InfoDataGridViewTextBoxColumn.HeaderText = "Info"
        Me.InfoDataGridViewTextBoxColumn.Name = "InfoDataGridViewTextBoxColumn"
        '
        'PlcmntDataGridViewTextBoxColumn
        '
        Me.PlcmntDataGridViewTextBoxColumn.DataPropertyName = "plcmnt"
        Me.PlcmntDataGridViewTextBoxColumn.HeaderText = "plcmnt"
        Me.PlcmntDataGridViewTextBoxColumn.Name = "PlcmntDataGridViewTextBoxColumn"
        '
        'RankDataGridViewTextBoxColumn
        '
        Me.RankDataGridViewTextBoxColumn.DataPropertyName = "rank"
        Me.RankDataGridViewTextBoxColumn.HeaderText = "rank"
        Me.RankDataGridViewTextBoxColumn.Name = "RankDataGridViewTextBoxColumn"
        '
        'HostelDataGridViewTextBoxColumn
        '
        Me.HostelDataGridViewTextBoxColumn.DataPropertyName = "hostel"
        Me.HostelDataGridViewTextBoxColumn.HeaderText = "hostel"
        Me.HostelDataGridViewTextBoxColumn.Name = "HostelDataGridViewTextBoxColumn"
        '
        'SportsDataGridViewTextBoxColumn
        '
        Me.SportsDataGridViewTextBoxColumn.DataPropertyName = "sports"
        Me.SportsDataGridViewTextBoxColumn.HeaderText = "sports"
        Me.SportsDataGridViewTextBoxColumn.Name = "SportsDataGridViewTextBoxColumn"
        '
        'CoursesDataGridViewTextBoxColumn
        '
        Me.CoursesDataGridViewTextBoxColumn.DataPropertyName = "courses"
        Me.CoursesDataGridViewTextBoxColumn.HeaderText = "courses"
        Me.CoursesDataGridViewTextBoxColumn.Name = "CoursesDataGridViewTextBoxColumn"
        '
        'ClgdetailsBindingSource
        '
        Me.ClgdetailsBindingSource.DataMember = "Clg_details"
        Me.ClgdetailsBindingSource.DataSource = Me.College_khabar3DataSet
        '
        'College_khabar3DataSet
        '
        Me.College_khabar3DataSet.DataSetName = "college_khabar3DataSet"
        Me.College_khabar3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(20, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(787, 45)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Delete From Table"
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Black
        Me.delete.ForeColor = System.Drawing.Color.Red
        Me.delete.Location = New System.Drawing.Point(862, 222)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(149, 45)
        Me.delete.TabIndex = 9
        Me.delete.Text = "delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button4.Location = New System.Drawing.Point(992, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button5.Location = New System.Drawing.Point(0, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Clg_detailsTableAdapter
        '
        Me.Clg_detailsTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(700, 235)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 32)
        Me.TextBox1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Label3"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication3.My.Resources.Resources.soSor6PH9kBw42jzFEI5dbbN9rWdALmcPYATEJnyZhiJguXZ1OBzgrsRNEp9jvGx
        Me.ClientSize = New System.Drawing.Size(1073, 465)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClgdetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.College_khabar3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents College_khabar3DataSet As WindowsApplication3.college_khabar3DataSet
    Friend WithEvents ClgdetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Clg_detailsTableAdapter As WindowsApplication3.college_khabar3DataSetTableAdapters.Clg_detailsTableAdapter
    Friend WithEvents CidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlcmntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HostelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SportsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoursesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
