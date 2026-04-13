

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mnuStrip = New MenuStrip()
        mnuInputData = New ToolStripMenuItem()
        mnuLihatKartu = New ToolStripMenuItem()
        mnuSimpanData = New ToolStripMenuItem()
        mnuBukaData = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        pnlHeader = New Panel()
        picHeader = New PictureBox()
        lblJudul = New Label()
        lblSubjudul = New Label()
        tabMain = New TabControl()
        tabDataUtama = New TabPage()
        lblNama = New Label()
        txtNama = New TextBox()
        lblID = New Label()
        txtID = New TextBox()
        lblTglLahir = New Label()
        dtpTanggalLahir = New DateTimePicker()
        lblJK = New Label()
        rdLakiLaki = New RadioButton()
        rdPerempuan = New RadioButton()
        lblKomunitas = New Label()
        cboKomunitas = New ComboBox()
        tabKontak = New TabPage()
        lblTelepon = New Label()
        mskTelepon = New MaskedTextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        tabProfil = New TabPage()
        picFoto = New PictureBox()
        btnBrowseFoto = New Button()
        lblFotoStatus = New Label()
        grpPeran = New GroupBox()
        rdKetua = New RadioButton()
        rdWakil = New RadioButton()
        rdSekretaris = New RadioButton()
        rdBendahara = New RadioButton()
        rdAdmin = New RadioButton()
        rdAnggota = New RadioButton()
        grpHobby = New GroupBox()
        chkDesain = New CheckBox()
        chkProgramming = New CheckBox()
        chkFotografi = New CheckBox()
        chkMusik = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMembaca = New CheckBox()
        chkGaming = New CheckBox()
        chkMasak = New CheckBox()
        btnSimpanCetak = New Button()
        mnuStrip.SuspendLayout()
        pnlHeader.SuspendLayout()
        CType(picHeader, ComponentModel.ISupportInitialize).BeginInit()
        tabMain.SuspendLayout()
        tabDataUtama.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpPeran.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuStrip
        ' 
        mnuStrip.BackColor = Color.FromArgb(CByte(10), CByte(14), CByte(26))
        mnuStrip.Font = New Font("Segoe UI", 10.0F)
        mnuStrip.ForeColor = Color.White
        mnuStrip.ImageScalingSize = New Size(20, 20)
        mnuStrip.Items.AddRange(New ToolStripItem() {mnuInputData, mnuLihatKartu, mnuSimpanData, mnuBukaData, mnuKeluar})
        mnuStrip.Location = New Point(0, 0)
        mnuStrip.Name = "mnuStrip"
        mnuStrip.RenderMode = ToolStripRenderMode.Professional
        mnuStrip.Size = New Size(900, 31)
        mnuStrip.TabIndex = 2
        ' 
        ' mnuInputData
        ' 
        mnuInputData.ForeColor = Color.White
        mnuInputData.Name = "mnuInputData"
        mnuInputData.Size = New Size(134, 27)
        mnuInputData.Text = "📋 Input Data"
        ' 
        ' mnuLihatKartu
        ' 
        mnuLihatKartu.ForeColor = Color.White
        mnuLihatKartu.Name = "mnuLihatKartu"
        mnuLihatKartu.Size = New Size(135, 27)
        mnuLihatKartu.Text = "🎴 Lihat Kartu"
        ' 
        ' mnuSimpanData
        ' 
        mnuSimpanData.ForeColor = Color.White
        mnuSimpanData.Name = "mnuSimpanData"
        mnuSimpanData.Size = New Size(150, 27)
        mnuSimpanData.Text = "💾 Simpan Data"
        ' 
        ' mnuBukaData
        ' 
        mnuBukaData.ForeColor = Color.White
        mnuBukaData.Name = "mnuBukaData"
        mnuBukaData.Size = New Size(130, 27)
        mnuBukaData.Text = "📂 Buka Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.ForeColor = Color.FromArgb(CByte(252), CByte(165), CByte(165))
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(100, 27)
        mnuKeluar.Text = "🚪 Keluar"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(40))
        pnlHeader.Controls.Add(picHeader)
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(lblSubjudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 31)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(900, 90)
        pnlHeader.TabIndex = 1
        ' 
        ' picHeader
        ' 
        picHeader.BackColor = Color.Transparent
        picHeader.Location = New Point(16, 8)
        picHeader.Name = "picHeader"
        picHeader.Size = New Size(70, 70)
        picHeader.SizeMode = PictureBoxSizeMode.Zoom
        picHeader.TabIndex = 0
        picHeader.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(CByte(165), CByte(180), CByte(252))
        lblJudul.Location = New Point(92, 8)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(315, 46)
        lblJudul.TabIndex = 1
        lblJudul.Text = " KOMUNITAS HUB"
        ' 
        ' lblSubjudul
        ' 
        lblSubjudul.AutoSize = True
        lblSubjudul.Font = New Font("Segoe UI", 10.0F)
        lblSubjudul.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblSubjudul.Location = New Point(92, 54)
        lblSubjudul.Name = "lblSubjudul"
        lblSubjudul.Size = New Size(359, 23)
        lblSubjudul.TabIndex = 2
        lblSubjudul.Text = "Sistem Pembuatan Kartu Keanggotaan Digital"
        ' 
        ' tabMain
        ' 
        tabMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabMain.Controls.Add(tabDataUtama)
        tabMain.Controls.Add(tabKontak)
        tabMain.Controls.Add(tabProfil)
        tabMain.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        tabMain.Location = New Point(12, 130)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(870, 490)
        tabMain.TabIndex = 0
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = Color.FromArgb(CByte(22), CByte(27), CByte(46))
        tabDataUtama.Controls.Add(lblNama)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Controls.Add(lblID)
        tabDataUtama.Controls.Add(txtID)
        tabDataUtama.Controls.Add(lblTglLahir)
        tabDataUtama.Controls.Add(dtpTanggalLahir)
        tabDataUtama.Controls.Add(lblJK)
        tabDataUtama.Controls.Add(rdLakiLaki)
        tabDataUtama.Controls.Add(rdPerempuan)
        tabDataUtama.Controls.Add(lblKomunitas)
        tabDataUtama.Controls.Add(cboKomunitas)
        tabDataUtama.Location = New Point(4, 32)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Size = New Size(862, 454)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "  📋 Data Utama  "
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.0F)
        lblNama.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblNama.Location = New Point(24, 24)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(125, 23)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Lengkap"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.Location = New Point(200, 20)
        txtNama.MaxLength = 60
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(360, 30)
        txtNama.TabIndex = 1
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 10.0F)
        lblID.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblID.Location = New Point(24, 74)
        lblID.Name = "lblID"
        lblID.Size = New Size(98, 23)
        lblID.TabIndex = 2
        lblID.Text = "ID Anggota"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI", 10.0F)
        txtID.Location = New Point(200, 70)
        txtID.MaxLength = 20
        txtID.Name = "txtID"
        txtID.Size = New Size(360, 30)
        txtID.TabIndex = 3
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Font = New Font("Segoe UI", 10.0F)
        lblTglLahir.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblTglLahir.Location = New Point(24, 124)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(111, 23)
        lblTglLahir.TabIndex = 4
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Font = New Font("Segoe UI", 10.0F)
        dtpTanggalLahir.Location = New Point(200, 120)
        dtpTanggalLahir.MaxDate = New Date(2026, 4, 6, 0, 0, 0, 0)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(360, 30)
        dtpTanggalLahir.TabIndex = 5
        dtpTanggalLahir.Value = New Date(2026, 4, 6, 0, 0, 0, 0)
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("Segoe UI", 10.0F)
        lblJK.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblJK.Location = New Point(24, 174)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(112, 23)
        lblJK.TabIndex = 6
        lblJK.Text = "Jenis Kelamin"
        ' 
        ' rdLakiLaki
        ' 
        rdLakiLaki.AutoSize = True
        rdLakiLaki.BackColor = Color.Transparent
        rdLakiLaki.Font = New Font("Segoe UI", 10.0F)
        rdLakiLaki.ForeColor = Color.White
        rdLakiLaki.Location = New Point(200, 170)
        rdLakiLaki.Name = "rdLakiLaki"
        rdLakiLaki.Size = New Size(92, 27)
        rdLakiLaki.TabIndex = 7
        rdLakiLaki.Text = "Laki-laki"
        rdLakiLaki.UseVisualStyleBackColor = False
        ' 
        ' rdPerempuan
        ' 
        rdPerempuan.AutoSize = True
        rdPerempuan.BackColor = Color.Transparent
        rdPerempuan.Font = New Font("Segoe UI", 10.0F)
        rdPerempuan.ForeColor = Color.White
        rdPerempuan.Location = New Point(330, 170)
        rdPerempuan.Name = "rdPerempuan"
        rdPerempuan.Size = New Size(118, 27)
        rdPerempuan.TabIndex = 8
        rdPerempuan.Text = "Perempuan"
        rdPerempuan.UseVisualStyleBackColor = False
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Font = New Font("Segoe UI", 10.0F)
        lblKomunitas.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblKomunitas.Location = New Point(24, 224)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(147, 23)
        lblKomunitas.TabIndex = 9
        lblKomunitas.Text = "Divisi / Komunitas"
        ' 
        ' cboKomunitas
        ' 
        cboKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cboKomunitas.Font = New Font("Segoe UI", 10.0F)
        cboKomunitas.Location = New Point(200, 220)
        cboKomunitas.Name = "cboKomunitas"
        cboKomunitas.Size = New Size(360, 31)
        cboKomunitas.TabIndex = 10
        ' 
        ' tabKontak
        ' 
        tabKontak.BackColor = Color.FromArgb(CByte(22), CByte(27), CByte(46))
        tabKontak.Controls.Add(lblTelepon)
        tabKontak.Controls.Add(mskTelepon)
        tabKontak.Controls.Add(lblEmail)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(lblAlamat)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Location = New Point(4, 32)
        tabKontak.Name = "tabKontak"
        tabKontak.Size = New Size(862, 454)
        tabKontak.TabIndex = 1
        tabKontak.Text = "  📱 Kontak & Info  "
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Font = New Font("Segoe UI", 10.0F)
        lblTelepon.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblTelepon.Location = New Point(24, 24)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(128, 23)
        lblTelepon.TabIndex = 0
        lblTelepon.Text = "Nomor Telepon"
        ' 
        ' mskTelepon
        ' 
        mskTelepon.BackColor = Color.FromArgb(CByte(30), CByte(36), CByte(60))
        mskTelepon.Font = New Font("Segoe UI", 10.0F)
        mskTelepon.ForeColor = Color.White
        mskTelepon.Location = New Point(200, 20)
        mskTelepon.Mask = "0000-0000-00000"
        mskTelepon.Name = "mskTelepon"
        mskTelepon.Size = New Size(360, 30)
        mskTelepon.TabIndex = 1
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10.0F)
        lblEmail.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblEmail.Location = New Point(24, 74)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(51, 23)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(200, 70)
        txtEmail.MaxLength = 100
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(360, 30)
        txtEmail.TabIndex = 3
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 10.0F)
        lblAlamat.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblAlamat.Location = New Point(24, 124)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(64, 23)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Segoe UI", 10.0F)
        txtAlamat.Location = New Point(200, 120)
        txtAlamat.MaxLength = 300
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.ScrollBars = ScrollBars.Vertical
        txtAlamat.Size = New Size(360, 90)
        txtAlamat.TabIndex = 5
        ' 
        ' tabProfil
        ' 
        tabProfil.BackColor = Color.FromArgb(CByte(22), CByte(27), CByte(46))
        tabProfil.Controls.Add(picFoto)
        tabProfil.Controls.Add(btnBrowseFoto)
        tabProfil.Controls.Add(lblFotoStatus)
        tabProfil.Controls.Add(grpPeran)
        tabProfil.Controls.Add(grpHobby)
        tabProfil.Controls.Add(btnSimpanCetak)
        tabProfil.Location = New Point(4, 32)
        tabProfil.Name = "tabProfil"
        tabProfil.Size = New Size(862, 454)
        tabProfil.TabIndex = 2
        tabProfil.Text = "  👤 Profil & Aktivitas  "
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.FromArgb(CByte(30), CByte(36), CByte(60))
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(24, 20)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(120, 130)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowseFoto
        ' 
        btnBrowseFoto.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBrowseFoto.Location = New Point(24, 160)
        btnBrowseFoto.Name = "btnBrowseFoto"
        btnBrowseFoto.Size = New Size(120, 34)
        btnBrowseFoto.TabIndex = 1
        btnBrowseFoto.Text = "Browse Foto"
        ' 
        ' lblFotoStatus
        ' 
        lblFotoStatus.Font = New Font("Segoe UI", 8.0F)
        lblFotoStatus.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblFotoStatus.Location = New Point(24, 200)
        lblFotoStatus.Name = "lblFotoStatus"
        lblFotoStatus.Size = New Size(180, 40)
        lblFotoStatus.TabIndex = 2
        lblFotoStatus.Text = "Belum ada foto dipilih"
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(rdKetua)
        grpPeran.Controls.Add(rdWakil)
        grpPeran.Controls.Add(rdSekretaris)
        grpPeran.Controls.Add(rdBendahara)
        grpPeran.Controls.Add(rdAdmin)
        grpPeran.Controls.Add(rdAnggota)
        grpPeran.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        grpPeran.Location = New Point(160, 20)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(220, 200)
        grpPeran.TabIndex = 3
        grpPeran.TabStop = False
        grpPeran.Text = " Peran / Jabatan "
        ' 
        ' rdKetua
        ' 
        rdKetua.AutoSize = True
        rdKetua.BackColor = Color.Transparent
        rdKetua.Font = New Font("Segoe UI", 9.0F)
        rdKetua.ForeColor = Color.White
        rdKetua.Location = New Point(14, 30)
        rdKetua.Name = "rdKetua"
        rdKetua.Size = New Size(93, 24)
        rdKetua.TabIndex = 0
        rdKetua.Text = "👑 Ketua"
        rdKetua.UseVisualStyleBackColor = False
        ' 
        ' rdWakil
        ' 
        rdWakil.AutoSize = True
        rdWakil.BackColor = Color.Transparent
        rdWakil.Font = New Font("Segoe UI", 9.0F)
        rdWakil.ForeColor = Color.White
        rdWakil.Location = New Point(14, 60)
        rdWakil.Name = "rdWakil"
        rdWakil.Size = New Size(133, 24)
        rdWakil.TabIndex = 1
        rdWakil.Text = ChrW(55358) & ChrW(56648) & " Wakil Ketua"
        rdWakil.UseVisualStyleBackColor = False
        ' 
        ' rdSekretaris
        ' 
        rdSekretaris.AutoSize = True
        rdSekretaris.BackColor = Color.Transparent
        rdSekretaris.Font = New Font("Segoe UI", 9.0F)
        rdSekretaris.ForeColor = Color.White
        rdSekretaris.Location = New Point(14, 90)
        rdSekretaris.Name = "rdSekretaris"
        rdSekretaris.Size = New Size(119, 24)
        rdSekretaris.TabIndex = 2
        rdSekretaris.Text = "📝 Sekretaris"
        rdSekretaris.UseVisualStyleBackColor = False
        ' 
        ' rdBendahara
        ' 
        rdBendahara.AutoSize = True
        rdBendahara.BackColor = Color.Transparent
        rdBendahara.Font = New Font("Segoe UI", 9.0F)
        rdBendahara.ForeColor = Color.White
        rdBendahara.Location = New Point(14, 120)
        rdBendahara.Name = "rdBendahara"
        rdBendahara.Size = New Size(126, 24)
        rdBendahara.TabIndex = 3
        rdBendahara.Text = "💰 Bendahara"
        rdBendahara.UseVisualStyleBackColor = False
        ' 
        ' rdAdmin
        ' 
        rdAdmin.AutoSize = True
        rdAdmin.BackColor = Color.Transparent
        rdAdmin.Font = New Font("Segoe UI", 9.0F)
        rdAdmin.ForeColor = Color.White
        rdAdmin.Location = New Point(14, 150)
        rdAdmin.Name = "rdAdmin"
        rdAdmin.Size = New Size(99, 24)
        rdAdmin.TabIndex = 4
        rdAdmin.Text = "⚙ Admin"
        rdAdmin.UseVisualStyleBackColor = False
        ' 
        ' rdAnggota
        ' 
        rdAnggota.AutoSize = True
        rdAnggota.BackColor = Color.Transparent
        rdAnggota.Font = New Font("Segoe UI", 9.0F)
        rdAnggota.ForeColor = Color.White
        rdAnggota.Location = New Point(110, 30)
        rdAnggota.Name = "rdAnggota"
        rdAnggota.Size = New Size(113, 24)
        rdAnggota.TabIndex = 5
        rdAnggota.Text = "🙋 Anggota"
        rdAnggota.UseVisualStyleBackColor = False
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chkDesain)
        grpHobby.Controls.Add(chkProgramming)
        grpHobby.Controls.Add(chkFotografi)
        grpHobby.Controls.Add(chkMusik)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Controls.Add(chkMasak)
        grpHobby.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        grpHobby.Location = New Point(390, 20)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(460, 220)
        grpHobby.TabIndex = 4
        grpHobby.TabStop = False
        grpHobby.Text = " Hobby & Aktivitas "
        ' 
        ' chkDesain
        ' 
        chkDesain.AutoSize = True
        chkDesain.BackColor = Color.Transparent
        chkDesain.Font = New Font("Segoe UI", 9.0F)
        chkDesain.ForeColor = Color.White
        chkDesain.Location = New Point(14, 28)
        chkDesain.Name = "chkDesain"
        chkDesain.Size = New Size(143, 24)
        chkDesain.TabIndex = 0
        chkDesain.Text = "🎨 Desain Grafis"
        chkDesain.UseVisualStyleBackColor = False
        ' 
        ' chkProgramming
        ' 
        chkProgramming.AutoSize = True
        chkProgramming.BackColor = Color.Transparent
        chkProgramming.Font = New Font("Segoe UI", 9.0F)
        chkProgramming.ForeColor = Color.White
        chkProgramming.Location = New Point(14, 58)
        chkProgramming.Name = "chkProgramming"
        chkProgramming.Size = New Size(147, 24)
        chkProgramming.TabIndex = 1
        chkProgramming.Text = "💻 Programming"
        chkProgramming.UseVisualStyleBackColor = False
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.BackColor = Color.Transparent
        chkFotografi.Font = New Font("Segoe UI", 9.0F)
        chkFotografi.ForeColor = Color.White
        chkFotografi.Location = New Point(14, 88)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(117, 24)
        chkFotografi.TabIndex = 2
        chkFotografi.Text = "📸 Fotografi"
        chkFotografi.UseVisualStyleBackColor = False
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.BackColor = Color.Transparent
        chkMusik.Font = New Font("Segoe UI", 9.0F)
        chkMusik.ForeColor = Color.White
        chkMusik.Location = New Point(14, 118)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(94, 24)
        chkMusik.TabIndex = 3
        chkMusik.Text = "🎵 Musik"
        chkMusik.UseVisualStyleBackColor = False
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.BackColor = Color.Transparent
        chkOlahraga.Font = New Font("Segoe UI", 9.0F)
        chkOlahraga.ForeColor = Color.White
        chkOlahraga.Location = New Point(14, 148)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(117, 24)
        chkOlahraga.TabIndex = 4
        chkOlahraga.Text = "⚽ Olahraga"
        chkOlahraga.UseVisualStyleBackColor = False
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.BackColor = Color.Transparent
        chkMembaca.Font = New Font("Segoe UI", 9.0F)
        chkMembaca.ForeColor = Color.White
        chkMembaca.Location = New Point(14, 178)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(122, 24)
        chkMembaca.TabIndex = 5
        chkMembaca.Text = "📚 Membaca"
        chkMembaca.UseVisualStyleBackColor = False
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.BackColor = Color.Transparent
        chkGaming.Font = New Font("Segoe UI", 9.0F)
        chkGaming.ForeColor = Color.White
        chkGaming.Location = New Point(230, 28)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(108, 24)
        chkGaming.TabIndex = 6
        chkGaming.Text = "🎮 Gaming"
        chkGaming.UseVisualStyleBackColor = False
        ' 
        ' chkMasak
        ' 
        chkMasak.AutoSize = True
        chkMasak.BackColor = Color.Transparent
        chkMasak.Font = New Font("Segoe UI", 9.0F)
        chkMasak.ForeColor = Color.White
        chkMasak.Location = New Point(230, 58)
        chkMasak.Name = "chkMasak"
        chkMasak.Size = New Size(119, 24)
        chkMasak.TabIndex = 7
        chkMasak.Text = "🍳 Memasak"
        chkMasak.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.FromArgb(CByte(99), CByte(102), CByte(241))
        btnSimpanCetak.Cursor = Cursors.Hand
        btnSimpanCetak.FlatAppearance.BorderSize = 0
        btnSimpanCetak.FlatStyle = FlatStyle.Flat
        btnSimpanCetak.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(24, 260)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(820, 50)
        btnSimpanCetak.TabIndex = 5
        btnSimpanCetak.Text = "SIMPAN DAN CETAK KARTU"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        BackColor = Color.FromArgb(CByte(13), CByte(17), CByte(30))
        ClientSize = New Size(900, 660)
        Controls.Add(tabMain)
        Controls.Add(pnlHeader)
        Controls.Add(mnuStrip)
        MainMenuStrip = mnuStrip
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "✦ Komunitas Hub — Kartu Digital"
        mnuStrip.ResumeLayout(False)
        mnuStrip.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(picHeader, ComponentModel.ISupportInitialize).EndInit()
        tabMain.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    '  Deklarasi variabel komponen 
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuInputData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLihatKartu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSimpanData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBukaData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKeluar As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSubjudul As System.Windows.Forms.Label
    Friend WithEvents picHeader As System.Windows.Forms.PictureBox

    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabDataUtama As System.Windows.Forms.TabPage
    Friend WithEvents tabKontak As System.Windows.Forms.TabPage
    Friend WithEvents tabProfil As System.Windows.Forms.TabPage

    ' Tab 1
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblTglLahir As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJK As System.Windows.Forms.Label
    Friend WithEvents rdLakiLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rdPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents lblKomunitas As System.Windows.Forms.Label
    Friend WithEvents cboKomunitas As System.Windows.Forms.ComboBox

    ' Tab 2
    Friend WithEvents lblTelepon As System.Windows.Forms.Label
    Friend WithEvents mskTelepon As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox

    ' Tab 3
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowseFoto As System.Windows.Forms.Button
    Friend WithEvents lblFotoStatus As System.Windows.Forms.Label
    Friend WithEvents grpPeran As System.Windows.Forms.GroupBox
    Friend WithEvents rdKetua As System.Windows.Forms.RadioButton
    Friend WithEvents rdWakil As System.Windows.Forms.RadioButton
    Friend WithEvents rdSekretaris As System.Windows.Forms.RadioButton
    Friend WithEvents rdBendahara As System.Windows.Forms.RadioButton
    Friend WithEvents rdAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rdAnggota As System.Windows.Forms.RadioButton
    Friend WithEvents grpHobby As System.Windows.Forms.GroupBox
    Friend WithEvents chkDesain As System.Windows.Forms.CheckBox
    Friend WithEvents chkProgramming As System.Windows.Forms.CheckBox
    Friend WithEvents chkFotografi As System.Windows.Forms.CheckBox
    Friend WithEvents chkMusik As System.Windows.Forms.CheckBox
    Friend WithEvents chkOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents chkMembaca As System.Windows.Forms.CheckBox
    Friend WithEvents chkGaming As System.Windows.Forms.CheckBox
    Friend WithEvents chkMasak As System.Windows.Forms.CheckBox
    Friend WithEvents btnSimpanCetak As System.Windows.Forms.Button

End Class