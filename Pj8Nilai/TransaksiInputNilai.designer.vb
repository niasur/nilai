<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiInputNilai
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbKat = New System.Windows.Forms.ComboBox
        Me.cmbJurusan = New System.Windows.Forms.ComboBox
        Me.lblTgl = New System.Windows.Forms.Label
        Me.lblNo = New System.Windows.Forms.Label
        Me.cmbMK = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblNama = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblNPM = New System.Windows.Forms.Label
        Me.txtJmlData = New System.Windows.Forms.TextBox
        Me.lblJmlData = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnDeleteNilai = New System.Windows.Forms.Button
        Me.btnAddNilai = New System.Windows.Forms.Button
        Me.txtNilai = New System.Windows.Forms.TextBox
        Me.txtNPM = New System.Windows.Forms.TextBox
        Me.lblNilai = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnInput = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DATA INPUT NILAI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbKat)
        Me.GroupBox1.Controls.Add(Me.cmbJurusan)
        Me.GroupBox1.Controls.Add(Me.lblTgl)
        Me.GroupBox1.Controls.Add(Me.lblNo)
        Me.GroupBox1.Controls.Add(Me.cmbMK)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 94)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Header"
        '
        'cmbKat
        '
        Me.cmbKat.AutoCompleteCustomSource.AddRange(New String() {"TUGAS", "UTS", "UAS"})
        Me.cmbKat.FormattingEnabled = True
        Me.cmbKat.Items.AddRange(New Object() {"TUGAS", "UTS", "UAS"})
        Me.cmbKat.Location = New System.Drawing.Point(159, 64)
        Me.cmbKat.Name = "cmbKat"
        Me.cmbKat.Size = New System.Drawing.Size(174, 21)
        Me.cmbKat.TabIndex = 9
        '
        'cmbJurusan
        '
        Me.cmbJurusan.AutoCompleteCustomSource.AddRange(New String() {"Aktif", "Tidak Aktif"})
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(159, 10)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(174, 21)
        Me.cmbJurusan.TabIndex = 12
        '
        'lblTgl
        '
        Me.lblTgl.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblTgl.ForeColor = System.Drawing.Color.White
        Me.lblTgl.Location = New System.Drawing.Point(500, 55)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(126, 20)
        Me.lblTgl.TabIndex = 11
        Me.lblTgl.Text = "TGL"
        Me.lblTgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNo
        '
        Me.lblNo.BackColor = System.Drawing.SystemColors.Desktop
        Me.lblNo.ForeColor = System.Drawing.Color.White
        Me.lblNo.Location = New System.Drawing.Point(500, 20)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(126, 21)
        Me.lblNo.TabIndex = 10
        Me.lblNo.Text = "NO"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMK
        '
        Me.cmbMK.AutoCompleteCustomSource.AddRange(New String() {"Aktif", "Tidak Aktif"})
        Me.cmbMK.FormattingEnabled = True
        Me.cmbMK.Location = New System.Drawing.Point(159, 39)
        Me.cmbMK.Name = "cmbMK"
        Me.cmbMK.Size = New System.Drawing.Size(272, 21)
        Me.cmbMK.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Kategori"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Jurusan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mata Kuliah"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNama)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblNPM)
        Me.GroupBox2.Controls.Add(Me.txtJmlData)
        Me.GroupBox2.Controls.Add(Me.lblJmlData)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.btnDeleteNilai)
        Me.GroupBox2.Controls.Add(Me.btnAddNilai)
        Me.GroupBox2.Controls.Add(Me.txtNilai)
        Me.GroupBox2.Controls.Add(Me.txtNPM)
        Me.GroupBox2.Controls.Add(Me.lblNilai)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 291)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'lblNama
        '
        Me.lblNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNama.Location = New System.Drawing.Point(351, 13)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(138, 20)
        Me.lblNama.TabIndex = 17
        Me.lblNama.Text = "LABEL NAMA"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AccessibleName = "lblNama"
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 16
        '
        'lblNPM
        '
        Me.lblNPM.BackColor = System.Drawing.Color.Black
        Me.lblNPM.ForeColor = System.Drawing.Color.White
        Me.lblNPM.Location = New System.Drawing.Point(23, 15)
        Me.lblNPM.Name = "lblNPM"
        Me.lblNPM.Size = New System.Drawing.Size(97, 19)
        Me.lblNPM.TabIndex = 15
        Me.lblNPM.Text = "NPM"
        Me.lblNPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtJmlData
        '
        Me.txtJmlData.Location = New System.Drawing.Point(421, 257)
        Me.txtJmlData.MaxLength = 20
        Me.txtJmlData.Name = "txtJmlData"
        Me.txtJmlData.Size = New System.Drawing.Size(68, 20)
        Me.txtJmlData.TabIndex = 14
        '
        'lblJmlData
        '
        Me.lblJmlData.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJmlData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlData.ForeColor = System.Drawing.Color.White
        Me.lblJmlData.Location = New System.Drawing.Point(303, 259)
        Me.lblJmlData.Name = "lblJmlData"
        Me.lblJmlData.Size = New System.Drawing.Size(100, 18)
        Me.lblJmlData.TabIndex = 13
        Me.lblJmlData.Text = "Jumlah Data"
        Me.lblJmlData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(466, 161)
        Me.DataGridView1.TabIndex = 12
        '
        'btnDeleteNilai
        '
        Me.btnDeleteNilai.Location = New System.Drawing.Point(408, 39)
        Me.btnDeleteNilai.Name = "btnDeleteNilai"
        Me.btnDeleteNilai.Size = New System.Drawing.Size(81, 23)
        Me.btnDeleteNilai.TabIndex = 9
        Me.btnDeleteNilai.Text = "&Delete Nilai"
        Me.btnDeleteNilai.UseVisualStyleBackColor = True
        '
        'btnAddNilai
        '
        Me.btnAddNilai.Location = New System.Drawing.Point(306, 37)
        Me.btnAddNilai.Name = "btnAddNilai"
        Me.btnAddNilai.Size = New System.Drawing.Size(84, 23)
        Me.btnAddNilai.TabIndex = 8
        Me.btnAddNilai.Text = "&Add Nilai"
        Me.btnAddNilai.UseVisualStyleBackColor = True
        '
        'txtNilai
        '
        Me.txtNilai.Location = New System.Drawing.Point(159, 39)
        Me.txtNilai.MaxLength = 20
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Size = New System.Drawing.Size(119, 20)
        Me.txtNilai.TabIndex = 6
        '
        'txtNPM
        '
        Me.txtNPM.Location = New System.Drawing.Point(159, 13)
        Me.txtNPM.MaxLength = 10
        Me.txtNPM.Name = "txtNPM"
        Me.txtNPM.Size = New System.Drawing.Size(174, 20)
        Me.txtNPM.TabIndex = 5
        '
        'lblNilai
        '
        Me.lblNilai.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNilai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNilai.ForeColor = System.Drawing.Color.White
        Me.lblNilai.Location = New System.Drawing.Point(23, 39)
        Me.lblNilai.Name = "lblNilai"
        Me.lblNilai.Size = New System.Drawing.Size(97, 18)
        Me.lblNilai.TabIndex = 4
        Me.lblNilai.Text = "Nilai"
        Me.lblNilai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnInput)
        Me.GroupBox3.Location = New System.Drawing.Point(570, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(116, 291)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(20, 160)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(20, 112)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "&Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'TransaksiInputNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(698, 462)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TransaksiInputNilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransaksiInputNilai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMK As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents cmbKat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNilai As System.Windows.Forms.TextBox
    Friend WithEvents txtNPM As System.Windows.Forms.TextBox
    Friend WithEvents lblNilai As System.Windows.Forms.Label
    Friend WithEvents btnAddNilai As System.Windows.Forms.Button
    Friend WithEvents btnDeleteNilai As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtJmlData As System.Windows.Forms.TextBox
    Friend WithEvents lblJmlData As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblNPM As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
End Class
