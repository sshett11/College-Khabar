Imports System.Data.OleDb

Public Class Form8

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = Form2.tb.Text
        
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        Dim pass As String = Trim(Me.TextBox1.Text)
        Dim Un As OleDbDataAdapter
        Dim dt As DataTable
        Try
            Un = New OleDbDataAdapter("select courses from Clg_details where Cname='" & pass & "' ", con)
            dt = New DataTable
            Un.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Form9.RichTextBox1.Text = dt.Rows(0).Item(0)
            Else
                MsgBox("NOT COURSES AVAILABLE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub SportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportsToolStripMenuItem.Click
        Dim pass As String = Trim(Me.TextBox1.Text)
        Dim Un As OleDbDataAdapter
        Dim dt As DataTable
        Try
            Un = New OleDbDataAdapter("select sports from Clg_details where Cname='" & pass & "' ", con)
            dt = New DataTable
            Un.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Form11.RichTextBox1.Text = dt.Rows(0).Item(0)
            Else
                MsgBox("NO Sports data AVAILABLE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub HostelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostelToolStripMenuItem.Click
        Dim pass As String = Trim(Me.TextBox1.Text)
        Dim Un As OleDbDataAdapter
        Dim dt As DataTable
        Try
            Un = New OleDbDataAdapter("select hostel from Clg_details where Cname='" & pass & "' ", con)
            dt = New DataTable
            Un.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Form12.RichTextBox1.Text = dt.Rows(0).Item(0)
            Else
                MsgBox("NO Hostel data AVAILABLE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Form12.Show()
        Me.Hide()
    End Sub

    'Private (sender As Object, e As EventArgs)
    'Dim ab As String
    '    ab = Form2.tb.Text
   



    'Dim cmd As OleDbCommand = New OleDbCommand("SELECT Info FROM Clg_details WHERE (Cname=NMAMIT)", con)

    'im sdr As OleDbDataReader = cmd.ExecuteReader()

    '        If (sdr.Read() = True) Then




    'End If
        
    ' End Sub


    Private Function cmd() As Object
        Throw New NotImplementedException
    End Function

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub MyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyProfileToolStripMenuItem.Click
        RichTextBox2.Show()
        RichTextBox1.Hide()
    End Sub

    Private Sub RichTextBox2_MouseLeave(sender As Object, e As EventArgs) Handles RichTextBox2.MouseLeave
        RichTextBox1.Show()
        RichTextBox2.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click

    End Sub

    Private Sub MyProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MyProfileToolStripMenuItem1.Click

    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click

    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        Dim pass As String = Trim(Me.TextBox1.Text)
        Dim Un As OleDbDataAdapter
        Dim dt As DataTable
        Try
            Un = New OleDbDataAdapter("select plcmnt from Clg_details where Cname='" & pass & "' ", con)
            dt = New DataTable
            Un.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Form10.RichTextBox1.Text = dt.Rows(0).Item(0)
            Else
                MsgBox("NO placement data AVAILABLE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Form10.Show()
        Me.Hide()
    End Sub

    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MedicalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub RichTextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class