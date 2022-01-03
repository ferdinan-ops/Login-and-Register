Imports MySql.Data.MySqlClient
Public Class sign_in

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        register.Show()
    End Sub

    Private Sub login_atau_sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If GunaTextBox1.Text = "" Or GunaTextBox2.Text = "" Then
            MessageBox.Show("Password and Username are still empty")
        Else
            Call koneksi()
            Cmd = New MySqlCommand("select * from tbl_user where username = '" & GunaTextBox1.Text & "' and password = '" & GunaTextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = True Then
                MessageBox.Show("Your Account is linked, Thank you")
            Else
                MessageBox.Show("Your Password and Username is wrong")
            End If
        End If
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
End Class