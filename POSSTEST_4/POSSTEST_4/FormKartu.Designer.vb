' ============================================================
'  FormKartu.Designer.vb — Layout ID Card Komunitas
' ============================================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
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
        pnlKartu = New Panel()
        pnlFooter = New Panel()
        lblFooterDate = New Label()
        lblFooterTag = New Label()
        pnlBody = New Panel()
        picProfil = New PictureBox()
        pnlInfo = New Panel()
        lblNamaVal = New Label()
        lblIDVal = New Label()
        lblPeranVal = New Label()
        lblKomunitasVal = New Label()
        lblTglLahirVal = New Label()
        lblSepLine1 = New Label()
        lblTeleponVal = New Label()
        lblEmailVal = New Label()
        lblAlamatVal = New Label()
        lblSepLine2 = New Label()
        lblHobbyTitle = New Label()
        lblHobbyVal = New Label()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        pnlButtons = New Panel()
        btnKembali = New Button()
        btnSimpanGambar = New Button()
        pnlKartu.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        pnlInfo.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.FromArgb(CByte(22), CByte(27), CByte(46))
        pnlKartu.Controls.Add(pnlFooter)
        pnlKartu.Controls.Add(pnlBody)
        pnlKartu.Controls.Add(pnlHeader)
        pnlKartu.Location = New Point(30, 20)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(580, 400)
        pnlKartu.TabIndex = 1
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(40))
        pnlFooter.Controls.Add(lblFooterDate)
        pnlFooter.Controls.Add(lblFooterTag)
        pnlFooter.Location = New Point(0, 362)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(580, 38)
        pnlFooter.TabIndex = 0
        ' 
        ' lblFooterDate
        ' 
        lblFooterDate.AutoSize = True
        lblFooterDate.Font = New Font("Segoe UI", 8.0F)
        lblFooterDate.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFooterDate.Location = New Point(12, 10)
        lblFooterDate.Name = "lblFooterDate"
        lblFooterDate.Size = New Size(158, 19)
        lblFooterDate.TabIndex = 0
        lblFooterDate.Text = "Diterbitkan: 03/04/2026"
        ' 
        ' lblFooterTag
        ' 
        lblFooterTag.AutoSize = True
        lblFooterTag.Font = New Font("Segoe UI", 8.0F)
        lblFooterTag.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFooterTag.Location = New Point(380, 10)
        lblFooterTag.Name = "lblFooterTag"
        lblFooterTag.Size = New Size(217, 19)
        lblFooterTag.TabIndex = 1
        lblFooterTag.Text = "komunitas-hub.id  ·  Valid 1 Tahun"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.Transparent
        pnlBody.Controls.Add(picProfil)
        pnlBody.Controls.Add(pnlInfo)
        pnlBody.Location = New Point(0, 72)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(580, 290)
        pnlBody.TabIndex = 1
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.FromArgb(CByte(99), CByte(102), CByte(241))
        picProfil.Location = New Point(16, 14)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(110, 120)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BackColor = Color.Transparent
        pnlInfo.Controls.Add(lblNamaVal)
        pnlInfo.Controls.Add(lblIDVal)
        pnlInfo.Controls.Add(lblPeranVal)
        pnlInfo.Controls.Add(lblKomunitasVal)
        pnlInfo.Controls.Add(lblTglLahirVal)
        pnlInfo.Controls.Add(lblSepLine1)
        pnlInfo.Controls.Add(lblTeleponVal)
        pnlInfo.Controls.Add(lblEmailVal)
        pnlInfo.Controls.Add(lblAlamatVal)
        pnlInfo.Controls.Add(lblSepLine2)
        pnlInfo.Controls.Add(lblHobbyTitle)
        pnlInfo.Controls.Add(lblHobbyVal)
        pnlInfo.Location = New Point(140, 10)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(425, 270)
        pnlInfo.TabIndex = 1
        ' 
        ' lblNamaVal
        ' 
        lblNamaVal.AutoSize = True
        lblNamaVal.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblNamaVal.ForeColor = Color.White
        lblNamaVal.Location = New Point(-8, -7)
        lblNamaVal.Name = "lblNamaVal"
        lblNamaVal.Size = New Size(212, 37)
        lblNamaVal.TabIndex = 0
        lblNamaVal.Text = "Nama Anggota"
        ' 
        ' lblIDVal
        ' 
        lblIDVal.AutoSize = True
        lblIDVal.Font = New Font("Segoe UI", 9.0F)
        lblIDVal.ForeColor = Color.FromArgb(CByte(165), CByte(180), CByte(252))
        lblIDVal.Location = New Point(2, 28)
        lblIDVal.Name = "lblIDVal"
        lblIDVal.Size = New Size(79, 20)
        lblIDVal.TabIndex = 1
        lblIDVal.Text = "ID: 000000"
        ' 
        ' lblPeranVal
        ' 
        lblPeranVal.AutoSize = True
        lblPeranVal.BackColor = Color.FromArgb(CByte(52), CByte(211), CByte(153))
        lblPeranVal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPeranVal.ForeColor = Color.White
        lblPeranVal.Location = New Point(2, 52)
        lblPeranVal.Name = "lblPeranVal"
        lblPeranVal.Padding = New Padding(4, 2, 4, 2)
        lblPeranVal.Size = New Size(86, 24)
        lblPeranVal.TabIndex = 2
        lblPeranVal.Text = " Anggota "
        ' 
        ' lblKomunitasVal
        ' 
        lblKomunitasVal.AutoSize = True
        lblKomunitasVal.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        lblKomunitasVal.ForeColor = Color.FromArgb(CByte(196), CByte(181), CByte(253))
        lblKomunitasVal.Location = New Point(2, 80)
        lblKomunitasVal.Name = "lblKomunitasVal"
        lblKomunitasVal.Size = New Size(124, 23)
        lblKomunitasVal.TabIndex = 3
        lblKomunitasVal.Text = "Divisi Teknologi"
        ' 
        ' lblTglLahirVal
        ' 
        lblTglLahirVal.AutoSize = True
        lblTglLahirVal.Font = New Font("Segoe UI", 9.0F)
        lblTglLahirVal.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblTglLahirVal.Location = New Point(2, 104)
        lblTglLahirVal.Name = "lblTglLahirVal"
        lblTglLahirVal.Size = New Size(194, 20)
        lblTglLahirVal.TabIndex = 4
        lblTglLahirVal.Text = "01 Januari 2000   |   Laki-laki"
        ' 
        ' lblSepLine1
        ' 
        lblSepLine1.BorderStyle = BorderStyle.Fixed3D
        lblSepLine1.Location = New Point(0, 128)
        lblSepLine1.Name = "lblSepLine1"
        lblSepLine1.Size = New Size(420, 2)
        lblSepLine1.TabIndex = 5
        ' 
        ' lblTeleponVal
        ' 
        lblTeleponVal.AutoSize = True
        lblTeleponVal.Font = New Font("Segoe UI", 9.0F)
        lblTeleponVal.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblTeleponVal.Location = New Point(2, 136)
        lblTeleponVal.Name = "lblTeleponVal"
        lblTeleponVal.Size = New Size(117, 20)
        lblTeleponVal.TabIndex = 6
        lblTeleponVal.Text = "0812-3456-7890"
        ' 
        ' lblEmailVal
        ' 
        lblEmailVal.AutoSize = True
        lblEmailVal.Font = New Font("Segoe UI", 9.0F)
        lblEmailVal.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblEmailVal.Location = New Point(2, 158)
        lblEmailVal.Name = "lblEmailVal"
        lblEmailVal.Size = New Size(149, 20)
        lblEmailVal.TabIndex = 7
        lblEmailVal.Text = "email@example.com"
        ' 
        ' lblAlamatVal
        ' 
        lblAlamatVal.AutoSize = True
        lblAlamatVal.Font = New Font("Segoe UI", 9.0F)
        lblAlamatVal.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblAlamatVal.Location = New Point(2, 180)
        lblAlamatVal.Name = "lblAlamatVal"
        lblAlamatVal.Size = New Size(204, 20)
        lblAlamatVal.TabIndex = 8
        lblAlamatVal.Text = "Samarinda, Kalimantan Timur"
        ' 
        ' lblSepLine2
        ' 
        lblSepLine2.BorderStyle = BorderStyle.Fixed3D
        lblSepLine2.Location = New Point(0, 205)
        lblSepLine2.Name = "lblSepLine2"
        lblSepLine2.Size = New Size(420, 2)
        lblSepLine2.TabIndex = 9
        ' 
        ' lblHobbyTitle
        ' 
        lblHobbyTitle.AutoSize = True
        lblHobbyTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblHobbyTitle.ForeColor = Color.FromArgb(CByte(99), CByte(102), CByte(241))
        lblHobbyTitle.Location = New Point(2, 214)
        lblHobbyTitle.Name = "lblHobbyTitle"
        lblHobbyTitle.Size = New Size(135, 19)
        lblHobbyTitle.TabIndex = 10
        lblHobbyTitle.Text = "HOBBY & AKTIVITAS"
        ' 
        ' lblHobbyVal
        ' 
        lblHobbyVal.AutoEllipsis = True
        lblHobbyVal.Font = New Font("Segoe UI", 9.0F)
        lblHobbyVal.ForeColor = Color.FromArgb(CByte(209), CByte(213), CByte(219))
        lblHobbyVal.Location = New Point(2, 232)
        lblHobbyVal.Name = "lblHobbyVal"
        lblHobbyVal.Size = New Size(420, 36)
        lblHobbyVal.TabIndex = 11
        lblHobbyVal.Text = "Gaming, Desain Grafis, Programming"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(67), CByte(56), CByte(202))
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(580, 72)
        pnlHeader.TabIndex = 2
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(16, 3)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(243, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "KOMUNITAS HUB"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 9.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(196), CByte(181), CByte(253))
        lblHeaderSub.Location = New Point(18, 40)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(221, 20)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "KARTU KEANGGOTAAN DIGITAL"
        ' 
        ' pnlButtons
        ' 
        pnlButtons.BackColor = Color.Transparent
        pnlButtons.Controls.Add(btnKembali)
        pnlButtons.Controls.Add(btnSimpanGambar)
        pnlButtons.Location = New Point(30, 432)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(580, 50)
        pnlButtons.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10.0F)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(0, 8)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(140, 36)
        btnKembali.TabIndex = 0
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanGambar
        ' 
        btnSimpanGambar.BackColor = Color.FromArgb(CByte(52), CByte(211), CByte(153))
        btnSimpanGambar.Cursor = Cursors.Hand
        btnSimpanGambar.FlatAppearance.BorderSize = 0
        btnSimpanGambar.FlatStyle = FlatStyle.Flat
        btnSimpanGambar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSimpanGambar.ForeColor = Color.FromArgb(CByte(6), CByte(78), CByte(59))
        btnSimpanGambar.Location = New Point(300, 8)
        btnSimpanGambar.Name = "btnSimpanGambar"
        btnSimpanGambar.Size = New Size(280, 36)
        btnSimpanGambar.TabIndex = 1
        btnSimpanGambar.Text = "💾 Simpan sebagai Gambar"
        btnSimpanGambar.UseVisualStyleBackColor = False
        ' 
        ' FormKartu
        ' 
        BackColor = Color.FromArgb(CByte(13), CByte(17), CByte(30))
        ClientSize = New Size(640, 500)
        Controls.Add(pnlButtons)
        Controls.Add(pnlKartu)
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "🎴 Kartu Komunitas"
        pnlKartu.ResumeLayout(False)
        pnlFooter.ResumeLayout(False)
        pnlFooter.PerformLayout()
        pnlBody.ResumeLayout(False)
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    ' ── Deklarasi variabel ────────────────────────────────────
    Friend WithEvents pnlKartu As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSub As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents picProfil As System.Windows.Forms.PictureBox
    Friend WithEvents pnlInfo As System.Windows.Forms.Panel
    Friend WithEvents lblNamaVal As System.Windows.Forms.Label
    Friend WithEvents lblIDVal As System.Windows.Forms.Label
    Friend WithEvents lblPeranVal As System.Windows.Forms.Label
    Friend WithEvents lblKomunitasVal As System.Windows.Forms.Label
    Friend WithEvents lblTglLahirVal As System.Windows.Forms.Label
    Friend WithEvents lblSepLine1 As System.Windows.Forms.Label
    Friend WithEvents lblTeleponVal As System.Windows.Forms.Label
    Friend WithEvents lblEmailVal As System.Windows.Forms.Label
    Friend WithEvents lblAlamatVal As System.Windows.Forms.Label
    Friend WithEvents lblSepLine2 As System.Windows.Forms.Label
    Friend WithEvents lblHobbyTitle As System.Windows.Forms.Label
    Friend WithEvents lblHobbyVal As System.Windows.Forms.Label
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblFooterDate As System.Windows.Forms.Label
    Friend WithEvents lblFooterTag As System.Windows.Forms.Label
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnSimpanGambar As System.Windows.Forms.Button

End Class