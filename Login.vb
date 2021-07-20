Public Class Login
    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then
            Menu_Utama.Show()
        Else
            MessageBox.Show("Password yang anda masukan salah",
                            "judul", MessageBoxButtons.OK,
                               MessageBoxIcon.Information)
        End If

    End Sub
End Class