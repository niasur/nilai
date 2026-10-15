Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class MasterMhs

    Private Sub AturGrid()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(0).HeaderText = "NPM"
            DataGridView1.Columns(1).HeaderText = "Nama Mahasiswa"
            DataGridView1.Columns(2).HeaderText = "Jurusan"
            DataGridView1.Columns(3).HeaderText = "Status"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListGrid()
        Try
            Call koneksi()
            objAdapter = New OdbcDataAdapter _
            ("select NPM, nama_mhs, id_jurusan, status_mhs from tb_mhs order by NPM asc", conMgr)
            objDataset = New DataSet
            objAdapter.Fill(objDataset, "tb_mhs")
            DataGridView1.DataSource = objDataset.Tables("tb_mhs")
            DataGridView1.ReadOnly = True
            Call AturGrid()
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub Kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = "--- Jurusan ---"
        ComboBox2.Text = "--- Status ---"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kosong()
        Call ListGrid()
        Call AturGrid()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call Kosong()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Apakah Data Akan disimpan?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            StrSQL = "select * from tb_mhs where NPM = '" & TextBox1.Text & "'"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                MsgBox("NPM sudah terdaftar")
            Else
                'SIMPAN KE TABEL MAHASISWA
                StrSQL = "insert into tb_mhs (NPM, nama_mhs, id_jurusan, status_mhs) " & _
                "VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & ComboBox1.Text & "','" & ComboBox2.Text & "')"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                If CommandMgr.ExecuteNonQuery Then
                    MsgBox("Data berhasil di simpan!")
                Else
                    MsgBox("Data gagal di simpan!")
                End If
                objReader.Close()
            End If
            Call ListGrid()
            Call Kosong()
        Else
            Call ListGrid()
            Call Kosong()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Apakah Data Akan diupdate?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            StrSQL = "update tb_mhs set nama_mhs = '" & TextBox2.Text & "', " & _
            "id_jurusan='" & ComboBox1.Text & "', " & _
            "status_mhs ='" & ComboBox2.Text & "' where NPM = '" & TextBox1.Text & "'"

            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            If CommandMgr.ExecuteNonQuery Then
                MsgBox("Data berhasil di update!")
            Else
                MsgBox("Data gagal diupdate!")
            End If
            Call ListGrid()
            Call Kosong()
        Else
            Call ListGrid()
            Call Kosong()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Apakah Data Akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            StrSQL = "delete from tb_mhs where NPM = '" & Val(TextBox1.Text) & "'"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            If CommandMgr.ExecuteNonQuery Then
                MsgBox("Data berhasil di hapus!")
            Else
                MsgBox("Data gagal di hapus!")
            End If
            Call ListGrid()
            Call Kosong()
        Else
            Call ListGrid()
            Call Kosong()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "" Then
                MsgBox("Data tidak boleh kosong!")
                TextBox1.Focus()
            Else
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox2.Text = "" Then
                MsgBox("Data tidak boleh kosong!")
                TextBox2.Focus()
            Else
                ComboBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If ComboBox1.Text = "" Then
                MsgBox("Data harus di pilih!")
                ComboBox1.Focus()
            Else
                ComboBox2.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If ComboBox2.Text = "" Then
                MsgBox("Data harus di pilih!")
                ComboBox2.Focus()
            Else
                btnSave.Focus()
            End If
        End If
    End Sub
End Class
