Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class FormLogin

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtIdUser.Focus()
        txtIdUser.Text = ""
        txtPW.Text = ""
    End Sub

    Private Sub txtIdUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdUser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtIdUser.Text = "" Then
                MsgBox("Id User harus diisi!")
                txtIdUser.Focus()
            Else
                txtPW.Focus()
            End If
        End If
    End Sub

    Private Sub txtPW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPW.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtPW.Text = "" Then
                MsgBox("Password harus diisi!")
                txtPW.Focus()
            Else
                btnLogin.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtIdUser.Text = ""
        txtPW.Text = ""
        txtIdUser.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtIdUser.Text = "" Then
            MsgBox("Id User harus diisi!")
            txtIdUser.Focus()
        ElseIf txtPW.Text = "" Then
            MsgBox("Password harus diisi!")
            txtPW.Focus()
        Else
            Call koneksi()
            StrSQL = "select * from tb_user where id_user='" & txtIdUser.Text & "' " & _
            "and pass_user='" & txtPW.Text & "' "
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            objReader = CommandMgr.ExecuteReader()
            objReader.Read()
            If objReader.HasRows Then
                ' MenuUtama.Show()
                MenuUtama.StIdUser.Text = objReader.GetString(0)
                MenuUtama.StNamaUser.Text = objReader.GetString(1)
                MenuUtama.StLevel.Text = objReader.GetString(3)
                MenuUtama.Show()
                Me.Hide()
            Else
                MessageBox.Show("Kombinasi ID User & Password salah!", "Informasi")
                txtIdUser.Text = ""
                txtPW.Text = ""
                txtIdUser.Focus()
            End If
        End If
    End Sub

End Class