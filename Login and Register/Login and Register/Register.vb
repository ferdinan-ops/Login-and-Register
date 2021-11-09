Imports System.Data.Odbc
Public Class register
    Sub otomatis()
        Call koneksi()
        Dim hitung As Long
        Dim urutan As String
        Cmd = New OdbcCommand("select id_user from tbl_user order by id_user desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            urutan = "U" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "U" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        GunaTextBox3.Text = urutan
    End Sub
    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call otomatis()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
    Sub bersih()
        GunaTextBox1.Clear()
        GunaTextBox2.Clear()
        GunaTextBox3.Clear()
        Label1.Text = ""
        GunaCirclePictureBox1.ImageLocation = ""
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If GunaTextBox1.Text = "" Or GunaTextBox2.Text = "" Or GunaTextBox3.Text = "" Or Label1.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi !!")
        Else
            Call koneksi()
            Cmd = New OdbcCommand("select * from tbl_user where id_user='" & GunaTextBox3.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = False Then
                Cmd = New OdbcCommand("insert into tbl_user values('" & GunaTextBox3.Text & _
                                       "','" & GunaTextBox1.Text & _
                                       "','" & GunaTextBox2.Text & _
                                       "','" & foto.GunaTextBox4.Text & _
                                       "','" & Label1.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                Me.Hide()
                Sign_in.Show()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click
        Dim pathfile As String = Nothing
        BukaFile.ShowDialog()
        BukaFile.Filter = "JPG Files(*.jpg)|*.jpg"
        GunaCirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pathfile = BukaFile.FileName

        Label1.Text = pathfile.Substring(pathfile.LastIndexOf("\") + 1)
        foto.GunaTextBox4.Text = BukaFile.FileName

        GunaCirclePictureBox1.Image = Image.FromFile(foto.GunaTextBox4.Text)

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        foto.Show()
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