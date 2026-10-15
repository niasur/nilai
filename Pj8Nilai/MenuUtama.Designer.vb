<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterMataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterJurusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.INPUTNILAIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportDataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportDataJurusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportDataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StIdUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.StNamaUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.StLevel = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERToolStripMenuItem, Me.INPUTNILAIToolStripMenuItem, Me.REPORTToolStripMenuItem, Me.ACCOUNTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterMahasiswaToolStripMenuItem, Me.MasterMataKuliahToolStripMenuItem, Me.MasterJurusanToolStripMenuItem, Me.MasterUserToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'MasterMahasiswaToolStripMenuItem
        '
        Me.MasterMahasiswaToolStripMenuItem.Name = "MasterMahasiswaToolStripMenuItem"
        Me.MasterMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MasterMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        '
        'MasterMataKuliahToolStripMenuItem
        '
        Me.MasterMataKuliahToolStripMenuItem.Name = "MasterMataKuliahToolStripMenuItem"
        Me.MasterMataKuliahToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MasterMataKuliahToolStripMenuItem.Text = "Data Mata Kuliah"
        '
        'MasterJurusanToolStripMenuItem
        '
        Me.MasterJurusanToolStripMenuItem.Name = "MasterJurusanToolStripMenuItem"
        Me.MasterJurusanToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MasterJurusanToolStripMenuItem.Text = "Data Jurusan"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MasterUserToolStripMenuItem.Text = "Data User"
        '
        'INPUTNILAIToolStripMenuItem
        '
        Me.INPUTNILAIToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INPUTNILAIToolStripMenuItem.Name = "INPUTNILAIToolStripMenuItem"
        Me.INPUTNILAIToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.INPUTNILAIToolStripMenuItem.Text = "INPUT NILAI"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem1, Me.TransaksiToolStripMenuItem})
        Me.REPORTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.REPORTToolStripMenuItem.Text = "REPORT"
        '
        'MasterToolStripMenuItem1
        '
        Me.MasterToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportDataMahasiswaToolStripMenuItem, Me.ReportToolStripMenuItem1, Me.ReportDataJurusanToolStripMenuItem, Me.ReportDataUserToolStripMenuItem})
        Me.MasterToolStripMenuItem1.Name = "MasterToolStripMenuItem1"
        Me.MasterToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.MasterToolStripMenuItem1.Text = "Master"
        '
        'ReportDataMahasiswaToolStripMenuItem
        '
        Me.ReportDataMahasiswaToolStripMenuItem.Name = "ReportDataMahasiswaToolStripMenuItem"
        Me.ReportDataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReportDataMahasiswaToolStripMenuItem.Text = "Report Data Mahasiswa"
        '
        'ReportToolStripMenuItem1
        '
        Me.ReportToolStripMenuItem1.Name = "ReportToolStripMenuItem1"
        Me.ReportToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ReportToolStripMenuItem1.Text = "Report Data Mata Kuliah"
        '
        'ReportDataJurusanToolStripMenuItem
        '
        Me.ReportDataJurusanToolStripMenuItem.Name = "ReportDataJurusanToolStripMenuItem"
        Me.ReportDataJurusanToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReportDataJurusanToolStripMenuItem.Text = "Report Data Jurusan"
        '
        'ReportDataUserToolStripMenuItem
        '
        Me.ReportDataUserToolStripMenuItem.Name = "ReportDataUserToolStripMenuItem"
        Me.ReportDataUserToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReportDataUserToolStripMenuItem.Text = "Report Data User"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NilaiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NilaiToolStripMenuItem.Text = "Nilai"
        '
        'ACCOUNTToolStripMenuItem
        '
        Me.ACCOUNTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ACCOUNTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACCOUNTToolStripMenuItem.Name = "ACCOUNTToolStripMenuItem"
        Me.ACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ACCOUNTToolStripMenuItem.Text = "ACCOUNT"
        '
        'ProfilToolStripMenuItem
        '
        Me.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        Me.ProfilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfilToolStripMenuItem.Text = "Profil"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StIdUser, Me.StNamaUser, Me.StLevel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 281)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(551, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StIdUser
        '
        Me.StIdUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.StIdUser.Name = "StIdUser"
        Me.StIdUser.Size = New System.Drawing.Size(60, 19)
        Me.StIdUser.Text = "  ID User  "
        '
        'StNamaUser
        '
        Me.StNamaUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.StNamaUser.Name = "StNamaUser"
        Me.StNamaUser.Size = New System.Drawing.Size(81, 19)
        Me.StNamaUser.Tag = ""
        Me.StNamaUser.Text = "  Nama User  "
        '
        'StLevel
        '
        Me.StLevel.Name = "StLevel"
        Me.StLevel.Size = New System.Drawing.Size(46, 19)
        Me.StLevel.Text = "  Level  "
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pj8Nilai.My.Resources.Resources.kampus_unipi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 305)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "--- Aplikasi Nilai Mahasiswa ---"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterMataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterJurusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INPUTNILAIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportDataMahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportDataJurusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportDataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StIdUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StNamaUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StLevel As System.Windows.Forms.ToolStripStatusLabel

End Class
