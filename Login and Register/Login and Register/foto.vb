Public Class foto

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub foto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class