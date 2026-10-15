Imports System
Imports System.Data
Imports System.Data.Odbc
Public Class MenuUtama

    Private Sub MasterMahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterMahasiswaToolStripMenuItem.Click
        MasterMhs.ShowDialog()
    End Sub

    Private Sub MasterMataKuliahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterMataKuliahToolStripMenuItem.Click
        MasterMK.ShowDialog()
    End Sub

    Private Sub MasterJurusanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterJurusanToolStripMenuItem.Click
        MasterJurusan.ShowDialog()
    End Sub

    Private Sub MasterUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterUserToolStripMenuItem.Click
        MasterUser.ShowDialog()
    End Sub

    Private Sub INPUTNILAIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INPUTNILAIToolStripMenuItem.Click
        TransaksiInputNilai.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda ingin keluar dari aplikasi ini?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FormLogin.txtIdUser.Text = ""
            FormLogin.txtPW.Text = ""
            FormLogin.Show()
            FormLogin.txtIdUser.Focus()
            Me.Hide()
        End If
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Try
            FormLogin.Hide()
            If StLevel.Text = "Staff" Then
                MASTERToolStripMenuItem.Enabled = True
                INPUTNILAIToolStripMenuItem.Enabled = False
                REPORTToolStripMenuItem.Enabled = True
                ACCOUNTToolStripMenuItem.Enabled = True
            ElseIf StLevel.Text = "Dosen" Then
                MASTERToolStripMenuItem.Enabled = False
                INPUTNILAIToolStripMenuItem.Enabled = True
                REPORTToolStripMenuItem.Enabled = True
                ACCOUNTToolStripMenuItem.Enabled = True
            Else
                MsgBox("Anda harus login terlebih dahulu!")
                FormLogin.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("Error Connection")
            End
        End Try
        conMgr.Close()
    End Sub

    Private Sub ReportDataMahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDataMahasiswaToolStripMenuItem.Click
        FormLaporanMhs.ShowDialog()
    End Sub

    Private Sub ReportDataJurusanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDataJurusanToolStripMenuItem.Click
        FormLaporanJurusan.CrystalReportViewer1.SelectionFormula = "{tb_jurusan.status_jurusan}='Aktif'"
        FormLaporanJurusan.CrystalReportViewer1.RefreshReport()
        FormLaporanJurusan.ShowDialog()
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem1.Click
        FormLaporanMK.ShowDialog()
    End Sub

    Private Sub ReportDataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportDataUserToolStripMenuItem.Click
        FormLaporanUser.CrystalReportViewer1.RefreshReport()
        FormLaporanUser.ShowDialog()
    End Sub
    Private userRole As String = "Dosen" ' atau "Staff"
    Private Sub ProfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilToolStripMenuItem.Click
        If userRole.Trim() = "Dosen" Then
            MessageBox.Show("Anda adalah Dosen")
        ElseIf userRole.Trim() = "Staff" Then
            MessageBox.Show("Anda adalah Staff")
        Else
            MessageBox.Show("Peran pengguna tidak dikenal")
        End If
    End Sub
End Class
