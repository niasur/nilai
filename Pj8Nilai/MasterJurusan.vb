Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class MasterJurusan
    Private Sub NonAktif()
        txtId.Enabled = False
        txtNamaJurusan.Enabled = False
        cmbStatus.Enabled = False
        btnDelete.Enabled = True
        btnClose.Enabled = True
        btnEdit.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub Aktif()
        txtId.Enabled = True
        txtNamaJurusan.Enabled = True
        cmbStatus.Enabled = True
    End Sub

    Private Sub Kosong()
        txtId.Text = ""
        txtNamaJurusan.Text = ""
        cmbStatus.Text = ""
    End Sub
    Private Sub AturGrid()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(0).HeaderText = "ID Jurusan"
            DataGridView1.Columns(1).HeaderText = "Nama Jurusan"
            DataGridView1.Columns(2).HeaderText = "Status"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListGrid()
        Try
            Call koneksi()
            objAdapter = New OdbcDataAdapter("select * from tb_jurusan order by id_jurusan asc", conMgr)
            objDataset = New DataSet
            objAdapter.Fill(objDataset, "tb_jurusan")
            DataGridView1.DataSource = objDataset.Tables("tb_jurusan")
            DataGridView1.ReadOnly = True
            Call AturGrid()
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub MasterJurusan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            MsgBox("ID Jurusan harus diisi..!")
            txtId.Focus()
        ElseIf txtNamaJurusan.Text = "" Then
            MsgBox("Nama Jurusan harus diisi..!")
            txtNamaJurusan.Focus()
        ElseIf cmbStatus.Text = "" Then
            MsgBox("Status Jurusan harus dipilih...!")
            cmbStatus.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan disimpan?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "select * from tb_jurusan where id_jurusan = '" & txtId.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    MsgBox("Id Jurusan sudah terdaftar!")
                    txtId.Focus()
                Else
                    'SIMPAN KE TABEL JURUSAN'
                    CommandMgr.Dispose()
                    StrSQL = "insert into tb_jurusan(id_jurusan, nama_jurusan, status_jurusan) " & _
                    "VALUES('" & txtId.Text & "','" & txtNamaJurusan.Text & "','" & cmbStatus.Text & "')"
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
            MsgBox("ID Jurusan harus diisi..!")
            txtId.Focus()
        ElseIf txtNamaJurusan.Text = "" Then
            MsgBox("Nama Jurusan harus diisi..!")
            txtNamaJurusan.Focus()
        ElseIf cmbStatus.Text = "" Then
            MsgBox("Status Jurusan harus dipilih...!")
            cmbStatus.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan diupdate?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "update tb_jurusan set nama_jurusan = '" & txtNamaJurusan.Text & "', " & _
                "status_jurusan ='" & cmbStatus.Text & "' where id_jurusan = '" & txtId.Text & "'"

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
            MsgBox("ID Jurusan harus diisi")
            txtId.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "Delete from tb_jurusan where id_jurusan = '" & txtId.Text & "'"
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
                MsgBox("ID Jurusan harus diisi!")
                txtId.Focus()
            Else
                Call CariData()
            End If
        End If
    End Sub
    Private Sub CariData()
        Try
            Call koneksi()
            StrSQL = "select * from tb_jurusan where id_jurusan = '" & txtId.Text & "'"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
            objReader.Read()
            If objReader.HasRows = True And btnEdit.Enabled = True Then
                txtId.Text = objReader("id_jurusan")
                txtNamaJurusan.Text = objReader("nama_jurusan")
                cmbStatus.Text = objReader("status_jurusan")
                txtId.Enabled = False
                txtNamaJurusan.Focus()
            ElseIf objReader.HasRows = True And btnDelete.Enabled = True Then
                txtId.Text = objReader("id_jurusan")
                txtNamaJurusan.Text = objReader("nama_jurusan")
                cmbStatus.Text = objReader("status_jurusan")
                txtId.Enabled = False
                btnDelete.Focus()
            ElseIf objReader.HasRows = True And btnAdd.Enabled = True Then
                txtNamaJurusan.Text = objReader("nama_jurusan")
                cmbStatus.Text = objReader("status_jurusan")
                MsgBox("ID Jurusan sudah ada!")
                Call Kosong()
                Call Aktif()
                txtId.Focus()
            ElseIf objReader.HasRows = False And btnDelete.Enabled = True Or btnEdit.Enabled = True Then
                MsgBox("ID Jurusan tidak ditemukan!")
                Call Kosong()
                txtId.Focus()
            Else
                objReader.Read()
                txtNamaJurusan.Text = ""
                txtNamaJurusan.Focus()
                txtId.Enabled = False
            End If
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub txtNamaJurusan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaJurusan.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNamaJurusan.Text = "" Then
                MsgBox("Nama Jurusan harus diisi!")
                txtNamaJurusan.Focus()
            Else
                cmbStatus.Focus()
            End If
        End If
    End Sub

    Private Sub cmbStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbStatus.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbStatus.Text = "" Then
                MsgBox("Status Jurusan harus diisi!")
                cmbStatus.Focus()
            End If
        End If
    End Sub
End Class