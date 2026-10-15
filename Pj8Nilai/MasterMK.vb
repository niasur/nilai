Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class MasterMK
    Private Sub NonAktif()
        txtId.Enabled = False
        txtNamaMK.Enabled = False
        cmbJurusan.Enabled = False
        cmbStatus.Enabled = False
        btnDelete.Enabled = True
        btnClose.Enabled = True
        btnEdit.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub Aktif()
        txtId.Enabled = True
        txtNamaMK.Enabled = True
        cmbJurusan.Enabled = True
        cmbStatus.Enabled = True
    End Sub

    Private Sub Kosong()
        txtId.Text = ""
        txtNamaMK.Text = ""
        cmbJurusan.Text = ""
        cmbStatus.Text = ""
    End Sub
    Private Sub DataJurusan()
        Call koneksi()
        CommandMgr = New OdbcCommand("select * FROM tb_jurusan WHERE status_jurusan='Aktif' ", conMgr)
        objReader = CommandMgr.ExecuteReader
        cmbJurusan.Items.Clear()
        Do While objReader.Read
            cmbJurusan.Items.Add(objReader.Item(0) & Space(3) & objReader.Item(1))
        Loop
    End Sub
    Private Sub AturGrid()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 80
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(0).HeaderText = "ID MK"
            DataGridView1.Columns(1).HeaderText = "Nama Mata Kuliah"
            DataGridView1.Columns(2).HeaderText = "Jurusan"
            DataGridView1.Columns(3).HeaderText = "Status"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListGrid()
        Try
            Call koneksi()
            objAdapter = New OdbcDataAdapter("select * from tb_mk order by id_mk asc", conMgr)
            objDataset = New DataSet
            objAdapter.Fill(objDataset, "tb_mk")
            DataGridView1.DataSource = objDataset.Tables("tb_mk")
            DataGridView1.ReadOnly = True
            Call AturGrid()
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub
    Private Sub MasterMK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            MsgBox("ID Mata Kuliah harus diisi..!")
            txtId.Focus()
        ElseIf txtNamaMK.Text = "" Then
            MsgBox("Nama Mata Kuliah harus diisi..!")
            txtNamaMK.Focus()
        ElseIf cmbJurusan.Text = "" Then
            MsgBox("Jurusan harus dipilih...!")
            cmbJurusan.Focus()
        ElseIf cmbStatus.Text = "" Then
            MsgBox("Status Mata Kuliah harus dipilih...!")
            cmbStatus.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan disimpan?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "select * from tb_mk where id_mk = '" & txtId.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    MsgBox("Id MK sudah terdaftar!")
                    txtId.Focus()
                Else
                    'SIMPAN KE TABEL JURUSAN'
                    CommandMgr.Dispose()
                    StrSQL = "insert into tb_mk(id_mk, nama_mk, id_jurusan, status_mk) " & _
                    "VALUES('" & txtId.Text & "','" & txtNamaMK.Text & "', " & _
                    "'" & LTrim(Strings.Left(cmbJurusan.Text, 3)) & "','" & cmbStatus.Text & "')"
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
            MsgBox("ID Mata Kuliah harus diisi..!")
            txtId.Focus()
        ElseIf txtNamaMK.Text = "" Then
            MsgBox("Nama Mata Kuliah harus diisi..!")
            txtNamaMK.Focus()
        ElseIf cmbJurusan.Text = "" Then
            MsgBox("Jurusan harus dipilih...!")
            cmbJurusan.Focus()
        ElseIf cmbStatus.Text = "" Then
            MsgBox("Status Mata Kuliah harus dipilih...!")
            cmbStatus.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan diupdate?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "update tb_mk set nama_mk = '" & txtNamaMK.Text & "', " & _
                "id_jurusan='" & LTrim(Strings.Left(cmbJurusan.Text, 3)) & "', " & _
                "status_mk='" & cmbStatus.Text & " ' where id_mk = '" & txtId.Text & "'"

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
            MsgBox("ID Mata Kuliah harus diisi")
            txtId.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "Delete from tb_mk where id_mk = '" & txtId.Text & "'"
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
                MsgBox("ID Mata Kuliah harus diisi!")
                txtId.Focus()
            Else
                Call CariData()
            End If
        End If
    End Sub
    Private Sub CariData()
        Try
            Call koneksi()
            StrSQL = "select * from tb_mk where id_mk = '" & txtId.Text & "'"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
            objReader.Read()
            If objReader.HasRows = True And btnEdit.Enabled = True Then
                txtId.Text = objReader("id_mk")
                txtNamaMK.Text = objReader("nama_mk")
                cmbJurusan.Text = objReader("id_jurusan")
                cmbStatus.Text = objReader("status_mk")
                txtId.Enabled = False
                txtNamaMK.Focus()
            ElseIf objReader.HasRows = True And btnDelete.Enabled = True Then
                txtId.Text = objReader("id_mk")
                txtNamaMK.Text = objReader("nama_mk")
                cmbJurusan.Text = objReader("id_jurusan")
                cmbStatus.Text = objReader("status_mk")
                txtId.Enabled = False
                btnDelete.Focus()
            ElseIf objReader.HasRows = True And btnAdd.Enabled = True Then
                txtNamaMK.Text = objReader("nama_mk")
                cmbJurusan.Text = objReader("id_jurusan")
                cmbStatus.Text = objReader("status_mk")
                MsgBox("ID Mata Kuliah sudah ada!")
                Call Kosong()
                Call Aktif()
                txtId.Focus()
            ElseIf objReader.HasRows = False And btnDelete.Enabled = True Or btnEdit.Enabled = True Then
                MsgBox("ID Mata Kuliah tidak ditemukan!")
                Call Kosong()
                txtId.Focus()
            Else
                objReader.Read()
                txtNamaMK.Text = ""
                txtNamaMK.Focus()
                txtId.Enabled = False
            End If
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub txtNamaMK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaMK.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtNamaMK.Text = "" Then
                MsgBox("Nama Mata Kuliah harus diisi!")
                txtNamaMK.Focus()
            Else
                cmbJurusan.Focus()
                Call DataJurusan()
            End If
        End If
    End Sub

    Private Sub cmbJurusan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJurusan.Click
        Call DataJurusan()
    End Sub

    Private Sub cmbJurusan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbJurusan.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbJurusan.Text = "" Then
                MsgBox("Jurusan harus diisi!")
                cmbJurusan.Focus()
            Else
                cmbStatus.Focus()
            End If
        End If
    End Sub

    Private Sub cmbStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbStatus.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbStatus.Text = "" Then
                MsgBox("Status harus diisi!")
                cmbStatus.Focus()
            Else
                btnClose.Focus()
            End If
        End If
    End Sub
End Class