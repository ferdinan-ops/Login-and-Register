Imports MySql.Data.MySqlClient
Imports System.IO
Public Class register
    Sub otomatis()
        Call koneksi()
        Dim hitung As Long
        Dim urutan As String
        Cmd = New MySqlCommand("select id_user from tbl_user order by id_user desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            urutan = "U" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "U" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        Label1.Text = urutan
        Rd.Close()
    End Sub
    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call otomatis()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
    Sub bersih()
        GunaTextBox1.Clear()
        GunaTextBox2.Clear()
        Label3.Text = ""
        Label1.Text = ""
        GunaCirclePictureBox1.ImageLocation = ""
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

        Dim ms As New MemoryStream

        Try
            GunaCirclePictureBox1.Image.Save(ms, GunaCirclePictureBox1.Image.RawFormat)
        Catch ex As Exception
            MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cmd = New MySqlCommand
        Cmd.Connection = Conn
        sql = "INSERT INTO `tbl_user`(`id_user`, `username`, `password`, `photo`) VALUES (@kode,@nama,@password,@foto)"

        Cmd.Parameters.Add("@kode", MySqlDbType.VarChar).Value = Label1.Text
        Cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = GunaTextBox1.Text
        Cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = GunaTextBox2.Text
        Cmd.Parameters.Add("@foto", MySqlDbType.Blob).Value = ms.ToArray()

        Cmd.CommandText = sql

        Try
            Cmd.ExecuteNonQuery()
            MsgBox("DATA ADDED SUCCESFULLY", vbInformation)
        Catch ex As Exception
            MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Call bersih()
    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click
        Dim pathfile As String = Nothing

        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg"
        GunaCirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pathfile = OpenFileDialog1.FileName
        Label5.Text = OpenFileDialog1.FileName

        GunaCirclePictureBox1.Image = Image.FromFile(Label5.Text)
    End Sub

    Private Sub GunaTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaTextBox1.MouseClick
        GunaTextBox1.ForeColor = Color.Black
        GunaTextBox1.Clear()
    End Sub

    Private Sub GunaTextBox1_MouseLeave(sender As Object, e As EventArgs) Handles GunaTextBox1.MouseLeave
        If GunaTextBox1.Text = "Username" Or GunaTextBox1.Text = "" Then
            GunaTextBox1.Text = "Username"
            GunaTextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub GunaTextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaTextBox2.MouseClick
        GunaTextBox2.Clear()
        GunaTextBox2.UseSystemPasswordChar = True
        GunaTextBox2.ForeColor = Color.Black
    End Sub

    Private Sub GunaTextBox2_MouseLeave(sender As Object, e As EventArgs) Handles GunaTextBox2.MouseLeave
        If GunaTextBox2.Text = "Password" Or GunaTextBox2.Text = "" Then
            GunaTextBox2.Text = "Password"
            GunaTextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Sign_in.Show()
    End Sub
End Class