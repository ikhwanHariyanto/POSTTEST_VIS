<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picProfil = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelpon = New Label()
        lblTanggalLahir = New Label()
        lblAlamat = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelpon = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        grpJenisKelamin = New GroupBox()
        rbLakiLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        grpHobby = New GroupBox()
        Label1 = New Label()
        chkGaming = New CheckBox()
        chkCoding = New CheckBox()
        chkTraveling = New CheckBox()
        chkMenggambar = New CheckBox()
        chkMenulis = New CheckBox()
        chkMemasak = New CheckBox()
        chkMemancing = New CheckBox()
        chkMembaca = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkMenari = New CheckBox()
        chkFotografi = New CheckBox()
        btnCetakKartu = New Button()
        panelFoto = New Panel()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        grpJenisKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        panelFoto.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        picProfil.Location = New Point(0, 0)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(158, 198)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        btnBrowse.Cursor = Cursors.Hand
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(286, 133)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(160, 38)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = " Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblNama.Location = New Point(558, 100)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(77, 23)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblUmur.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblUmur.Location = New Point(558, 158)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(120, 20)
        lblUmur.TabIndex = 5
        lblUmur.Text = "Umur"
        ' 
        ' lblNoTelpon
        ' 
        lblNoTelpon.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNoTelpon.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblNoTelpon.Location = New Point(558, 218)
        lblNoTelpon.Name = "lblNoTelpon"
        lblNoTelpon.Size = New Size(120, 20)
        lblNoTelpon.TabIndex = 9
        lblNoTelpon.Text = "No. Telepon"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTanggalLahir.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblTanggalLahir.Location = New Point(698, 158)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(120, 20)
        lblTanggalLahir.TabIndex = 7
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblAlamat.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblAlamat.Location = New Point(558, 278)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(120, 20)
        lblAlamat.TabIndex = 11
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.Location = New Point(558, 125)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(480, 30)
        txtNama.TabIndex = 4
        ' 
        ' txtUmur
        ' 
        txtUmur.BorderStyle = BorderStyle.FixedSingle
        txtUmur.Font = New Font("Segoe UI", 10.0F)
        txtUmur.Location = New Point(558, 180)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(120, 30)
        txtUmur.TabIndex = 6
        ' 
        ' txtNoTelpon
        ' 
        txtNoTelpon.BorderStyle = BorderStyle.FixedSingle
        txtNoTelpon.Font = New Font("Segoe UI", 10.0F)
        txtNoTelpon.Location = New Point(558, 240)
        txtNoTelpon.Name = "txtNoTelpon"
        txtNoTelpon.Size = New Size(200, 30)
        txtNoTelpon.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Font = New Font("Segoe UI", 10.0F)
        txtAlamat.Location = New Point(558, 300)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(480, 30)
        txtAlamat.TabIndex = 12
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Font = New Font("Segoe UI", 10.0F)
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Location = New Point(698, 180)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(200, 30)
        dtpTanggalLahir.TabIndex = 8
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.BackColor = Color.Transparent
        grpJenisKelamin.Controls.Add(rbLakiLaki)
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        grpJenisKelamin.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        grpJenisKelamin.Location = New Point(286, 0)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(194, 90)
        grpJenisKelamin.TabIndex = 13
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.BackColor = Color.Transparent
        rbLakiLaki.Font = New Font("Segoe UI", 9.0F)
        rbLakiLaki.Location = New Point(15, 25)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(120, 22)
        rbLakiLaki.TabIndex = 0
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = False
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.BackColor = Color.Transparent
        rbPerempuan.Font = New Font("Segoe UI", 9.0F)
        rbPerempuan.Location = New Point(15, 52)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(120, 22)
        rbPerempuan.TabIndex = 1
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = False
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = Color.Transparent
        grpHobby.Controls.Add(Label1)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Controls.Add(btnBrowse)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkTraveling)
        grpHobby.Controls.Add(chkMenggambar)
        grpHobby.Controls.Add(chkMenulis)
        grpHobby.Controls.Add(chkMemasak)
        grpHobby.Controls.Add(chkMemancing)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkMenyanyi)
        grpHobby.Controls.Add(chkMenari)
        grpHobby.Controls.Add(chkFotografi)
        grpHobby.Controls.Add(grpJenisKelamin)
        grpHobby.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        grpHobby.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        grpHobby.Location = New Point(558, 345)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(480, 190)
        grpHobby.TabIndex = 14
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        Label1.Location = New Point(308, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 16
        Label1.Text = "Pilih Pas Foto "
        ' 
        ' chkGaming
        ' 
        chkGaming.BackColor = Color.Transparent
        chkGaming.Font = New Font("Segoe UI", 9.0F)
        chkGaming.Location = New Point(15, 25)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(110, 22)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = False
        ' 
        ' chkCoding
        ' 
        chkCoding.BackColor = Color.Transparent
        chkCoding.Font = New Font("Segoe UI", 9.0F)
        chkCoding.Location = New Point(15, 52)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(110, 22)
        chkCoding.TabIndex = 1
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = False
        ' 
        ' chkTraveling
        ' 
        chkTraveling.BackColor = Color.Transparent
        chkTraveling.Font = New Font("Segoe UI", 9.0F)
        chkTraveling.Location = New Point(15, 79)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(110, 22)
        chkTraveling.TabIndex = 2
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = False
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.BackColor = Color.Transparent
        chkMenggambar.Font = New Font("Segoe UI", 9.0F)
        chkMenggambar.Location = New Point(15, 106)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(120, 22)
        chkMenggambar.TabIndex = 3
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = False
        ' 
        ' chkMenulis
        ' 
        chkMenulis.BackColor = Color.Transparent
        chkMenulis.Font = New Font("Segoe UI", 9.0F)
        chkMenulis.Location = New Point(15, 133)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(110, 22)
        chkMenulis.TabIndex = 4
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = False
        ' 
        ' chkMemasak
        ' 
        chkMemasak.BackColor = Color.Transparent
        chkMemasak.Font = New Font("Segoe UI", 9.0F)
        chkMemasak.Location = New Point(15, 160)
        chkMemasak.Name = "chkMemasak"
        chkMemasak.Size = New Size(110, 22)
        chkMemasak.TabIndex = 5
        chkMemasak.Text = "Memasak"
        chkMemasak.UseVisualStyleBackColor = False
        ' 
        ' chkMemancing
        ' 
        chkMemancing.BackColor = Color.Transparent
        chkMemancing.Font = New Font("Segoe UI", 9.0F)
        chkMemancing.Location = New Point(160, 25)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(120, 22)
        chkMemancing.TabIndex = 6
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = False
        ' 
        ' chkMembaca
        ' 
        chkMembaca.BackColor = Color.Transparent
        chkMembaca.Font = New Font("Segoe UI", 9.0F)
        chkMembaca.Location = New Point(160, 52)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(120, 22)
        chkMembaca.TabIndex = 7
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = False
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.BackColor = Color.Transparent
        chkOlahraga.Font = New Font("Segoe UI", 9.0F)
        chkOlahraga.Location = New Point(160, 79)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(120, 22)
        chkOlahraga.TabIndex = 8
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = False
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.BackColor = Color.Transparent
        chkMenyanyi.Font = New Font("Segoe UI", 9.0F)
        chkMenyanyi.Location = New Point(160, 106)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(120, 22)
        chkMenyanyi.TabIndex = 9
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = False
        ' 
        ' chkMenari
        ' 
        chkMenari.BackColor = Color.Transparent
        chkMenari.Font = New Font("Segoe UI", 9.0F)
        chkMenari.Location = New Point(160, 133)
        chkMenari.Name = "chkMenari"
        chkMenari.Size = New Size(120, 22)
        chkMenari.TabIndex = 10
        chkMenari.Text = "Menari"
        chkMenari.UseVisualStyleBackColor = False
        ' 
        ' chkFotografi
        ' 
        chkFotografi.BackColor = Color.Transparent
        chkFotografi.Font = New Font("Segoe UI", 9.0F)
        chkFotografi.Location = New Point(160, 160)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(120, 22)
        chkFotografi.TabIndex = 11
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = False
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        btnCetakKartu.Cursor = Cursors.Hand
        btnCetakKartu.FlatAppearance.BorderSize = 0
        btnCetakKartu.FlatStyle = FlatStyle.Flat
        btnCetakKartu.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnCetakKartu.ForeColor = Color.White
        btnCetakKartu.Location = New Point(558, 534)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(480, 50)
        btnCetakKartu.TabIndex = 15
        btnCetakKartu.Text = "  CETAK KARTU"
        btnCetakKartu.UseVisualStyleBackColor = False
        ' 
        ' panelFoto
        ' 
        panelFoto.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        panelFoto.BorderStyle = BorderStyle.FixedSingle
        panelFoto.Controls.Add(picProfil)
        panelFoto.Location = New Point(148, 137)
        panelFoto.Name = "panelFoto"
        panelFoto.Size = New Size(160, 200)
        panelFoto.TabIndex = 1
        ' 
        ' Form1
        ' 
        BackColor = Color.White
        ClientSize = New Size(1050, 600)
        Controls.Add(panelFoto)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblUmur)
        Controls.Add(txtUmur)
        Controls.Add(lblTanggalLahir)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(lblNoTelpon)
        Controls.Add(txtNoTelpon)
        Controls.Add(lblAlamat)
        Controls.Add(txtAlamat)
        Controls.Add(grpHobby)
        Controls.Add(btnCetakKartu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Cetak Kartu Komunitas"
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        grpJenisKelamin.ResumeLayout(False)
        grpHobby.ResumeLayout(False)
        panelFoto.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Deklarasi semua kontrol
    Friend WithEvents picProfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblUmur As System.Windows.Forms.Label
    Friend WithEvents lblNoTelpon As System.Windows.Forms.Label
    Friend WithEvents lblTanggalLahir As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelpon As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpJenisKelamin As System.Windows.Forms.GroupBox
    Friend WithEvents rbLakiLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents grpHobby As System.Windows.Forms.GroupBox
    Friend WithEvents chkGaming As System.Windows.Forms.CheckBox
    Friend WithEvents chkMemancing As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoding As System.Windows.Forms.CheckBox
    Friend WithEvents chkMembaca As System.Windows.Forms.CheckBox
    Friend WithEvents chkTraveling As System.Windows.Forms.CheckBox
    Friend WithEvents chkOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenggambar As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenyanyi As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenulis As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenari As System.Windows.Forms.CheckBox
    Friend WithEvents chkMemasak As System.Windows.Forms.CheckBox
    Friend WithEvents chkFotografi As System.Windows.Forms.CheckBox
    Friend WithEvents btnCetakKartu As System.Windows.Forms.Button
    Friend WithEvents panelFoto As System.Windows.Forms.Panel
    Friend WithEvents Label1 As Label

End Class