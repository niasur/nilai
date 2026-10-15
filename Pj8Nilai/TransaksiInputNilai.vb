Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class TransaksiInputNilai

    Private Sub Otomatis()
        Call koneksi()
        CommandMgr = New OdbcCommand("Select * from tb_nilai_header " & _
                    "where no_input in (select max(no_input) from tb_nilai_header) order by no_input desc", conMgr)
        Dim urutan As String
        Dim hitung As Long
        objReader = CommandMgr.ExecuteReader
        objReader.Read()
        If Not objReader.HasRows Then
            urutan = "NM" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(objReader.GetString(0), 3, 6) <> Format(Now, "yyMMdd") Then
                urutan = "NM" + Format(Now, "yyMMdd") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(objReader.GetString(0), 2) + 1
                urutan = "NM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
        End If
        lblNo.Text = urutan
    End Sub

    Private Sub Aktif()
        cmbMK.Enabled = True
        cmbKat.Enabled = True
        cmbJurusan.Enabled = True
        txtNPM.Enabled = True
        txtNilai.Enabled = True
        btnAddNilai.Enabled = True
        btnDeleteNilai.Enabled = True

        txtJmlData.Text = 0
    End Sub

    Private Sub NonAktif()
        cmbMK.Enabled = False
        cmbKat.Enabled = False
        cmbJurusan.Enabled = False
        btnInput.Enabled = True
        btnClose.Enabled = True
        txtNPM.Enabled = False
        txtNilai.Enabled = False
        btnAddNilai.Enabled = False
        btnDeleteNilai.Enabled = False
    End Sub

    Private Sub KosongHeader()
        cmbKat.Text = ""
        cmbMK.Text = ""
        cmbJurusan.Text = ""
    End Sub

    Private Sub KosongDetail()
        lblNama.Text = ""
        txtNPM.Text = ""
        txtNilai.Text = ""
        txtJmlData.Text = ""
    End Sub

    Private Sub AturGrid()
        Try
            DataGridView1.Columns(0).Width = 130
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(0).HeaderText = "NPM"
            DataGridView1.Columns(1).HeaderText = "Nama"
            DataGridView1.Columns(2).HeaderText = "Nilai"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListGrid()
        Try
            Call koneksi()
            objAdapter = New OdbcDataAdapter("select * from tb_nilai_tmp", conMgr)
            objDataset = New DataSet
            objAdapter.Fill(objDataset, "tb_nilai_tmp")
            DataGridView1.DataSource = objDataset.Tables("tb_nilai_tmp")
            DataGridView1.ReadOnly = True
            Call AturGrid()
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
        DataGridView1.Refresh()
    End Sub

    Private Sub HapusGrid()
        Call koneksi()
        Try
            StrSQL = "Delete from tb_nilai_tmp"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            CommandMgr.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            conMgr.Close()
            CommandMgr = Nothing
            objReader = Nothing
            conMgr = Nothing
        End Try
        DataGridView1.Refresh()
    End Sub
    Private Sub DataJurusan()
        Call koneksi()
        CommandMgr = New OdbcCommand("SELECT id_jurusan, nama_jurusan FROM tb_jurusan WHERE status_jurusan ='Aktif'", conMgr)
        objReader = CommandMgr.ExecuteReader()
        cmbJurusan.Items.Clear()
        Do While objReader.Read()
            cmbJurusan.Items.Add(objReader.Item(0) & Space(3) & "-" & Space(3) & objReader.Item(1))
        Loop
        objReader.Close()
        conMgr.Close()
    End Sub

    Private Sub DataMK()
        Call koneksi()
        CommandMgr = New OdbcCommand("SELECT id_mk, nama_mk FROM tb_mk WHERE status_mk ='Aktif' " & _
                                   "AND id_jurusan = '" & LTrim(Strings.Left(cmbJurusan.Text, 3)) & "'", conMgr)
        objReader = CommandMgr.ExecuteReader()
        cmbMK.Items.Clear()
        Do While objReader.Read()
            cmbMK.Items.Add(objReader.Item(0) & Space(3) & "-" & Space(3) & objReader.Item(1))
        Loop
        objReader.Close()
        conMgr.Close()
    End Sub

    Private Sub CariNPM()
        Try
            Call koneksi()
            StrSQL = "SELECT * FROM tb_mhs WHERE NPM = '" & txtNPM.Text & "' " & _
                     "AND id_jurusan= '" & Strings.Left(cmbJurusan.Text, 3) & "'"
            CommandMgr = New OdbcCommand(StrSQL, conMgr)
            objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
            objReader.Read()
            If objReader.HasRows = True Then
                lblNama.Text = objReader("nama_mhs")
                txtNilai.Focus()
            Else
                MsgBox("NPM tidak ditemukan atau Jurusan salah")
                Call KosongDetail()
                txtJmlData.Text = "0"
                txtNPM.Focus()
            End If
        Catch ex As Exception
            DataGridView1 = Nothing
        End Try
    End Sub

    Private Sub HitungTampung()
        Call koneksi()
        StrSQL = "select count(*) from tb_nilai_tmp"
        CommandMgr = New OdbcCommand(StrSQL, conMgr)
        Dim rs As Integer
        rs = CommandMgr.ExecuteScalar
        txtJmlData.Text = rs
    End Sub

    Private Sub TransaksiInputNilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Otomatis()
        Call HapusGrid()
        Call AturGrid()
        Call ListGrid()
        Call KosongHeader()
        Call KosongDetail()
        Call NonAktif()
        lblTgl.Text = Format(Now.Date, "yyyy-MM-dd")
        txtJmlData.Enabled = False
    End Sub


    Private Sub btnAddNilai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNilai.Click
        If txtNPM.Text = "" Then
            MsgBox("NPM Mahasiswa harus diisi!")
            txtNPM.Focus()
            lblNama.Text = ""
        ElseIf txtNilai.Text = "" Then
            MsgBox("Nilai Mahasiswa harus diisi!")
            txtNilai.Focus()
        ElseIf txtNilai.Text > 100 Then
            MsgBox("Nilai tidak boleh lebih dari 100!")
            txtNilai.Text = ""
            txtNilai.Focus()
        ElseIf Val(txtNilai.Text) = "0" Then
            MsgBox("Nilai tidak boleh 0!")
            txtNilai.Text = ""
            txtNilai.Focus()
        Else
            Try
                Call koneksi()
                Call CariNPM()
                StrSQL = "select * from tb_nilai_tmp where NPM = '" & txtNPM.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    MsgBox("Data sudah ada!")
                Else
                    CommandMgr.Dispose()
                    StrSQL = "insert into tb_nilai_tmp (NPM, nama_mhs, nilai) " & _
                    "values('" & txtNPM.Text & "','" & lblNama.Text & "'," & txtNilai.Text & ")"
                    CommandMgr = New OdbcCommand(StrSQL, conMgr)
                    CommandMgr.ExecuteNonQuery()
                    objReader.Close()
                End If
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
            conMgr.Close()
            CommandMgr = Nothing
            objReader = Nothing
            conMgr = Nothing
            Call ListGrid()
            Call KosongDetail()
            Call HitungTampung()
            txtNPM.Focus()
            cmbJurusan.Enabled = False
            cmbMK.Enabled = False
            cmbKat.Enabled = False
        End If
    End Sub


    Private Sub btnDeleteNilai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteNilai.Click
        If txtNPM.Text = "" Then
            MsgBox("NPM Mahasiswa harus diisi!")
            txtNPM.Focus()
        Else
            Call koneksi()
            Try
                StrSQL = "select * from tb_nilai_tmp where NPM = '" & txtNPM.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
                If Not objReader.HasRows Then
                    MsgBox("Data Tidak ada!")
                Else
                    CommandMgr.Dispose()
                    StrSQL = "delete from tb_nilai_tmp where NPM = '" & txtNPM.Text & "'"
                    CommandMgr = New OdbcCommand(StrSQL, conMgr)
                    CommandMgr.ExecuteNonQuery()
                    objReader.Close()
                End If
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
            conMgr.Close()
            CommandMgr = Nothing
            objReader = Nothing
            conMgr = Nothing
            Call ListGrid()
            Call KosongDetail()
            Call HitungTampung()
            txtNPM.Focus()
        End If
    End Sub

    Private Sub btnInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInput.Click
        If btnInput.Text = "&Input" Then
            btnInput.Text = "&Save"
            btnClose.Text = "&Cancel"
            Call Aktif()
        ElseIf cmbJurusan.Text = "" Then
            MsgBox("Jurusan harus dipilih!")
            cmbJurusan.Focus()
        ElseIf cmbMK.Text = "" Then
            MsgBox("Mata Kuliah harus dipilih!")
            cmbMK.Focus()
        ElseIf cmbKat.Text = "" Then
            MsgBox("Kategori harus dipilih!")
            cmbKat.Focus()
        ElseIf txtJmlData.Text = "0" Then
            MsgBox("Dosen harus menginput nilai minimal 1 data!")
            txtNPM.Focus()
        ElseIf MessageBox.Show("Apakah Data Akan disimpan?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call koneksi()
            Try
                StrSQL = "SELECT * FROM tb_nilai_header WHERE no_input = '" & lblNo.Text & "'"
                CommandMgr = New OdbcCommand(StrSQL, conMgr)
                objReader = CommandMgr.ExecuteReader(CommandBehavior.Default)
                objReader.Close()
                'simpan ke header
                Dim Simpan As String
                Simpan = "insert into tb_nilai_header (no_input, tgl_input, id_mk, kategori_nilai, id_user ) " & _
                         "values ('" & lblNo.Text & "','" & lblTgl.Text & "', " & _
                         "'" & LTrim(Strings.Left(cmbMK.Text, 5)) & "', '" & cmbKat.Text & "', '" & MenuUtama.StIdUser.Text & "')"
                CommandMgr = New OdbcCommand(Simpan, conMgr)
                CommandMgr.ExecuteNonQuery()
                'baca tabel TMP
                objAdapter = New OdbcDataAdapter("select * from tb_nilai_tmp", conMgr)
                objDataset = New DataSet
                objAdapter.Fill(objDataset)
                DataGridView1.DataSource = objDataset.Tables(0)
                Dim TBL As DataTable = objDataset.Tables(0)
                For baris As Integer = 0 To TBL.Rows.Count - 1

                    'simpan data dari tabel TMP ke Tabel Detail
                    Dim SqlSimpanDetailNilai As String
                    SqlSimpanDetailNilai = "insert into tb_nilai_detail(no_input, NPM, nilai)" & _
                                           "values('" & lblNo.Text & "', '" & TBL.Rows(baris)(0) & "', " & TBL.Rows(baris)(2) & ")"
                    CommandMgr = New OdbcCommand(SqlSimpanDetailNilai, conMgr)
                    CommandMgr.ExecuteNonQuery()
                    objReader.Close()
                Next baris
                MsgBox("Data berhasil di simpan!")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Call KosongHeader()
                Call KosongDetail()
                Call HapusGrid()
                DataGridView1.Refresh()
                Call ListGrid()
                Call NonAktif()
                Call Otomatis()
                btnInput.Text = "&Input"
                btnClose.Text = "&Close"
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If btnClose.Text = "&Cancel" Then
            Call NonAktif()
            Call KosongHeader()
            Call KosongDetail()
            Call HapusGrid()
            Call ListGrid()
            btnClose.Text = "&Close"
            btnInput.Text = "&Input"
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cmbJurusan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJurusan.Click
        Call DataJurusan()
        cmbMK.Text = ""
    End Sub

    Private Sub cmbMK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMK.Click
        Call DataMK()
    End Sub

    Private Sub txtNPM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNPM.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            If txtNPM.Text = "" Then
                MsgBox("NPM Mahasiswa harus diisi!")
                txtNPM.Focus()
                lblNPM.Text = ""
            Else
                Call CariNPM()
            End If
        End If
    End Sub

    Private Sub txtNilai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNilai.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = Chr(13) Then
            If txtNilai.Text = "" Then
                MsgBox("Nilai Mahasiswa harus diisi!")
                txtNilai.Focus()
            Else
                btnAddNilai.Focus()
            End If
        End If
    End Sub
End Class