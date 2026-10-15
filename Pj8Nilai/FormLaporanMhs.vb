Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class FormLaporanMhs

    Private Sub DataJurusan()
        Call koneksi()
        CommandMgr = New OdbcCommand("select * FROM tb_jurusan WHERE status_jurusan ='Aktif' ", conMgr)
        objReader = CommandMgr.ExecuteReader
        ComboBox1.Items.Clear()
        Do While objReader.Read
            ComboBox1.Items.Add(objReader.Item(0) & Space(3) & "-" & Space(3) & objReader.Item(1))
        Loop
    End Sub

    Private Sub FormLaporanMhs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        Call DataJurusan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = "" Then
                MsgBox("Jurusan harus dipilih!")
                ComboBox1.Focus()
            Else
                Laporan.CrystalReportViewer1.SelectionFormula = "{tb_mhs.id_jurusan}='" & Trim(Strings.Left(ComboBox1.Text, 3)) & "'" & _
                "And {tb_mhs.status_mhs}='Aktif'"
                Laporan.CrystalReportViewer1.RefreshReport()
                Laporan.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class