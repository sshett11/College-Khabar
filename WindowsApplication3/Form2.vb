Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Form2

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub






    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        Label2.BackColor = Color.LightBlue

        Me.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.BackColor = Color.LightBlue
        Label2.Cursor = Cursors.Hand


    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = Color.WhiteSmoke
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub Label2_CursorChanged(sender As Object, e As EventArgs)


    End Sub






    Private Sub a1_MouseEnter(sender As Object, e As EventArgs) Handles a1.MouseEnter
        Cursor = Cursors.Hand
        a1.ShowDropDown()

    End Sub

    Private Sub a1_MouseLeave(sender As Object, e As EventArgs) Handles a1.MouseLeave
        Cursor = Cursors.Default

    End Sub

    Private Sub a2_MouseEnter(sender As Object, e As EventArgs) Handles a2.MouseEnter
        Cursor = Cursors.Hand
        a2.ShowDropDown()
    End Sub

    Private Sub a3_MouseEnter(sender As Object, e As EventArgs) Handles a3.MouseEnter
        Cursor = Cursors.Hand
        a3.ShowDropDown()
    End Sub

    Private Sub a4_MouseEnter(sender As Object, e As EventArgs) Handles a4.MouseEnter
        Cursor = Cursors.Hand
        a4.ShowDropDown()
    End Sub

    Private Sub a2_MouseLeave(sender As Object, e As EventArgs) Handles a2.MouseLeave
        Cursor = Cursors.Default

    End Sub

    Private Sub a3_MouseLeave(sender As Object, e As EventArgs) Handles a3.MouseLeave
        a3.BackColor = DefaultBackColor
        Cursor = Cursors.Default

    End Sub

    Private Sub a4_MouseLeave(sender As Object, e As EventArgs) Handles a4.MouseLeave
        Cursor = Cursors.Default

    End Sub

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        a1.BackColor = Color.LightBlue
        Me.Show()
        Rtb2.Show()
        Rtb3.Hide()
        RichTextBox2.Hide()
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        a2.BackColor = Color.LightBlue
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click

        RichTextBox3.Show()



        a3.BackColor = Color.LightBlue
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        a4.BackColor = Color.LightBlue
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter

        Label1.Text.Replace("Welcome", "rohit")

    End Sub


    Private Sub EngineeringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EngineeringToolStripMenuItem.Click
        Rtb3.Show()
        Rtb2.Hide()

    End Sub

    Private Sub Rtb3_TextChanged(sender As Object, e As EventArgs) Handles Rtb3.TextChanged

    End Sub

    Private Sub MedicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalToolStripMenuItem.Click
        Rtb3.Hide()
        RichTextBox2.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Text = Form1.TextBox1.Text
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub RichTextBox3_MouseLeave(sender As Object, e As EventArgs) Handles RichTextBox3.MouseLeave
        RichTextBox3.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim pass As String = Trim(tb.Text)
        Dim Un As OleDbDataAdapter
        Dim dt As DataTable
        Try
            Un = New OleDbDataAdapter("select cid from Clg_details where Cname='" & pass & "' ", con)
            dt = New DataTable
            Un.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Form8.Show()
                Me.Hide()
            Else
                MsgBox("COLLEGE NOT FOUND")
                Me.Show()
            End If

            Try
                Un = New OleDbDataAdapter("select Cname,Info from Clg_details where Cname='" & pass & "' ", con)
                dt = New DataTable
                Un.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    Form8.TextBox1.Text = dt.Rows(0).Item(0)
                    Form8.RichTextBox1.Text = dt.Rows(0).Item(1)
                Else
                    Me.Show()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT cname FROM Clg_details WHERE (cid = c1000'", con)

            Dim sdr As OleDbDataReader = cmd.ExecuteReader()

            If (sdr.Read() = True) Then

                Form8.Show()
                Me.Hide()
                tb.Text = sdr.Read()




            Else
                MessageBox.Show("sorry!! no data found")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function cmd() As Object
        Throw New NotImplementedException
    End Function

    Private Sub tb_TextChanged(sender As Object, e As EventArgs) Handles tb.TextChanged

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub
End Class