Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class MasterUser
    Private Sub NonAktif()
        txtId.Enabled = False
        txtNamaUser.Enabled = False
        txtPass.Enabled = False
        cmbLevel.Enabled = False
        btnDelete.Enabled = True
        btnClose.Enabled = True
        btnEdit.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub Aktif()
        txtId.Enabled = True
        txtNamaUser.Enabled = True
        txtPass.Enabled = True
        cmbLevel.Enabled = True
    End Sub

    Private Sub Kosong()
        txtId.Text = ""
        txtNamaUser.Text = ""
        txtPass.Text = ""
        cmbLevel.Text = ""
    End Sub
    Private Sub AturGrid()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(0).HeaderText = "ID User"
            DataGridView1.Columns(1).HeaderText = "Nama"
            DataGridView1.Columns(2).HeaderText = "Level"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListGrid()
        Try
            Call koneksi()
            objAdapter = New OdbcDataAdapter("select id_user, nama_user, level_user from tb_user order by id_user asc", conMgr)
            objDataset = New DataSet
            objAdapter.Fill(objDataset, "tb_user")
            DataGridView1.DataSource = objDataset.Tables("tb_user")
            DataGridView1.ReadOnly = True
            Call AturGrid()
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub MasterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NonAktif()
        Call Kosong()
        Call ListGrid()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "&Add" Then
            Call Aktif()
            txtId.Focus()
            btnAdd.Enabled = True
            btnAdd.Text = "&Simpan"
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnClose.Enabled = True
            btnClose.Text = "&Cancel"
            Call Kosong()
        ElseIf txtId.Text = "" Then
            MsgBox("ID User harus diisi..!")
            txtId.Focus()
        ElseIf txtNamaUser.Text = "" Then
            MsgBox("Nama harus diisi..!")
            txtNamaUser.Focus()
        ElseIf txtPass.Text = "" Then
            MsgBox("Password harus diisi...!")
            txtPass.Focus()
        ElseIf cmbLevel.Text = "" Then
            MsgBox("Level User harus dipilih...!")
            cmbLevel.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan disimpan?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "select * from tb_user where id_user = '" & txtId.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    MsgBox("Id User sudah terdaftar!")
                    txtId.Focus()
                Else
                    'SIMPAN KE TABEL USER'
                    CommandMgr.Dispose()
                    StrSQL = "insert into tb_user(id_user, nama_user, pass_user, level_user) " & _
                    "VALUES('" & txtId.Text & "','" & txtNamaUser.Text & "', " & _
                    "'" & txtPass.Text & "','" & cmbLevel.Text & "')"
                    CommandMgr = New OdbcCommand(StrSQL, conMgr)
                    If CommandMgr.ExecuteNonQuery Then
                        MsgBox("Data berhasil di simpan!")
                    Else
                        MsgBox("Data gagal di simpan!")
                    End If
                    objReader.Close()
                End If
            Catch ex As Exception
            Finally
                conMgr.Close()
                CommandMgr = Nothing
                objReader = Nothing
                conMgr = Nothing
                Call ListGrid()
                Call Kosong()
                Call NonAktif()
                btnAdd.Text = "&Add"
                btnClose.Text = "&Close"
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            Call Aktif()
            txtId.Focus()
            btnEdit.Enabled = True
            btnEdit.Text = "&Update"
            btnAdd.Enabled = False
            btnDelete.Enabled = False
            btnClose.Enabled = True
            btnClose.Text = "&Cancel"
            Call Kosong()
        ElseIf txtId.Text = "" Then
            MsgBox("ID User harus diisi..!")
            txtId.Focus()
        ElseIf txtNamaUser.Text = "" Then
            MsgBox("Nama harus diisi..!")
            txtNamaUser.Focus()
        ElseIf txtPass.Text = "" Then
            MsgBox("Password harus diisi...!")
            txtPass.Focus()
        ElseIf cmbLevel.Text = "" Then
            MsgBox("Level User harus dipilih...!")
            cmbLevel.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan diupdate?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "update tb_user set nama_user = '" & txtNamaUser.Text & "', " & _
                "pass_user='" & txtPass.Text & "', " & _
                "level_user ='" & cmbLevel.Text & "' where id_user = '" & txtId.Text & "'"

                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                If CommandMgr.ExecuteNonQuery Then
                    MsgBox("Data berhasil di update!")
                Else
                    MsgBox("Data gagal diupdate!")
                End If
            Catch ex As Exception
            Finally
                conMgr.Close()
                CommandMgr = Nothing
                objReader = Nothing
                conMgr = Nothing
                Call ListGrid()
                Call Kosong()
                Call NonAktif()
                btnEdit.Text = "&Edit"
                btnClose.Text = "&Close"
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            txtId.Enabled = True
            txtId.Focus()
            btnDelete.Enabled = True
            btnDelete.Text = "&Hapus"
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnClose.Enabled = True
            btnClose.Text = "&Cancel"
            Call Kosong()
        ElseIf txtId.Text = "" Then
            MsgBox("ID User harus diisi")
            txtId.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "Delete from tb_user where id_user = '" & txtId.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                If CommandMgr.ExecuteNonQuery Then
                    MsgBox("Data berhasil dihapus!")
                Else
                    MsgBox("Data gagal di hapus!")
                End If
            Catch ex As Exception
            Finally
                conMgr.Close()
                CommandMgr = Nothing
                objReader = Nothing
                conMgr = Nothing
                Call ListGrid()
                Call Kosong()
                Call NonAktif()
                btnDelete.Text = "&Delete"
                btnClose.Text = "&Close"
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If btnClose.Text = "&Cancel" Then
            Call Kosong()
            Call NonAktif()
            btnClose.Text = "&Close"
            btnAdd.Text = "&Add"
            btnEdit.Text = "&Edit"
            btnDelete.Text = "&Delete"
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtId.Text = "" Then
                MsgBox("ID User harus diisi!")
                txtId.Focus()
            Else
                Call CariData()
            End If
        End If
    End Sub

    Private Sub CariData()
        Try
            Call koneksi()
            StrSQL = "select * from tb_user where id_user = '" & txtId.Text & "'"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
            objReader.Read()
            If objReader.HasRows = True And btnEdit.Enabled = True Then
                txtId.Text = objReader("id_user")
                txtNamaUser.Text = objReader("nama_user")
                txtPass.Text = objReader("pass_user")
                cmbLevel.Text = objReader("level_user")
                txtId.Enabled = False
                txtNamaUser.Focus()
            ElseIf objReader.HasRows = True And btnDelete.Enabled = True Then
                txtId.Text = objReader("id_user")
                txtNamaUser.Text = objReader("nama_user")
                txtPass.Text = objReader("pass_user")
                cmbLevel.Text = objReader("level_user")
                txtId.Enabled = False
                btnDelete.Focus()
            ElseIf objReader.HasRows = True And btnAdd.Enabled = True Then
                txtNamaUser.Text = objReader("nama_user")
                txtPass.Text = objReader("pass_user")
                cmbLevel.Text = objReader("level_user")
                MsgBox("ID User sudah ada!")
                Call Kosong()
                Call Aktif()
                txtId.Focus()
            ElseIf objReader.HasRows = False And btnDelete.Enabled = True Or btnEdit.Enabled = True Then
                MsgBox("ID User tidak ditemukan!")
                Call Kosong()
                txtId.Focus()
            Else
                objReader.Read()
                txtNamaUser.Text = ""
                txtNamaUser.Focus()
                txtId.Enabled = False
            End If
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub txtNamaUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaUser.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNamaUser.Text = "" Then
                MsgBox("Nama User harus diisi!")
                txtNamaUser.Focus()
            Else
                cmbLevel.Focus()
            End If
        End If
    End Sub

    Private Sub cmbLevel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbLevel.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbLevel.Text = "" Then
                MsgBox("Level User harus diisi!")
                cmbLevel.Focus()
            Else
                txtPass.Focus()
            End If
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtPass.Text = "" Then
                MsgBox("Password User harus diisi!")
                txtPass.Focus()
            Else
                btnClose.Focus()
            End If
        End If
    End Sub
End Class