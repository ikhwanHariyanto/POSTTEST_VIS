<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        PanelHeader = New Panel()
        LblFormTitle = New Label()
        LblFormSub = New Label()
        PanelForm = New Panel()
        LblNama = New Label()
        TxtNama = New TextBox()
        LblSeri = New Label()
        TxtSeri = New TextBox()
        LblTipe = New Label()
        CmbTipe = New ComboBox()
        LblHarga = New Label()
        TxtHarga = New TextBox()
        LblKondisi = New Label()
        CmbKondisi = New ComboBox()
        LblStatus = New Label()
        CmbStatus = New ComboBox()
        LblTahun = New Label()
        NudTahun = New NumericUpDown()
        LblDeskripsi = New Label()
        TxtDeskripsi = New RichTextBox()
        PanelBottom = New Panel()
        BtnSimpan = New Button()
        BtnBatal = New Button()
        PanelHeader.SuspendLayout()
        PanelForm.SuspendLayout()
        CType(NudTahun, ComponentModel.ISupportInitialize).BeginInit()
        PanelBottom.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        PanelHeader.Controls.Add(LblFormTitle)
        PanelHeader.Controls.Add(LblFormSub)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(540, 80)
        PanelHeader.TabIndex = 2
        ' 
        ' LblFormTitle
        ' 
        LblFormTitle.AutoSize = True
        LblFormTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        LblFormTitle.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblFormTitle.Location = New Point(18, 9)
        LblFormTitle.Name = "LblFormTitle"
        LblFormTitle.Size = New Size(307, 37)
        LblFormTitle.TabIndex = 0
        LblFormTitle.Text = "⚡ Tambah / Edit Item"
        ' 
        ' LblFormSub
        ' 
        LblFormSub.AutoSize = True
        LblFormSub.Font = New Font("Segoe UI", 9F)
        LblFormSub.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(200))
        LblFormSub.Location = New Point(68, 46)
        LblFormSub.Name = "LblFormSub"
        LblFormSub.Size = New Size(293, 20)
        LblFormSub.TabIndex = 1
        LblFormSub.Text = "Isi data item koleksi DX Kamen Rider kamu"
        ' 
        ' PanelForm
        ' 
        PanelForm.BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        PanelForm.Controls.Add(LblNama)
        PanelForm.Controls.Add(TxtNama)
        PanelForm.Controls.Add(LblSeri)
        PanelForm.Controls.Add(TxtSeri)
        PanelForm.Controls.Add(LblTipe)
        PanelForm.Controls.Add(CmbTipe)
        PanelForm.Controls.Add(LblHarga)
        PanelForm.Controls.Add(TxtHarga)
        PanelForm.Controls.Add(LblKondisi)
        PanelForm.Controls.Add(CmbKondisi)
        PanelForm.Controls.Add(LblStatus)
        PanelForm.Controls.Add(CmbStatus)
        PanelForm.Controls.Add(LblTahun)
        PanelForm.Controls.Add(NudTahun)
        PanelForm.Controls.Add(LblDeskripsi)
        PanelForm.Controls.Add(TxtDeskripsi)
        PanelForm.Dock = DockStyle.Fill
        PanelForm.Location = New Point(0, 80)
        PanelForm.Name = "PanelForm"
        PanelForm.Padding = New Padding(20, 15, 20, 10)
        PanelForm.Size = New Size(540, 420)
        PanelForm.TabIndex = 0
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblNama.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblNama.Location = New Point(20, 15)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(112, 23)
        LblNama.TabIndex = 0
        LblNama.Text = "Nama Item *"
        ' 
        ' TxtNama
        ' 
        TxtNama.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtNama.BorderStyle = BorderStyle.FixedSingle
        TxtNama.Font = New Font("Segoe UI", 10F)
        TxtNama.ForeColor = Color.White
        TxtNama.Location = New Point(20, 38)
        TxtNama.MaxLength = 100
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(200, 30)
        TxtNama.TabIndex = 1
        ' 
        ' LblSeri
        ' 
        LblSeri.AutoSize = True
        LblSeri.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblSeri.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblSeri.Location = New Point(20, 15)
        LblSeri.Name = "LblSeri"
        LblSeri.Size = New Size(119, 23)
        LblSeri.TabIndex = 2
        LblSeri.Text = "Seri / Series *"
        ' 
        ' TxtSeri
        ' 
        TxtSeri.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtSeri.BorderStyle = BorderStyle.FixedSingle
        TxtSeri.Font = New Font("Segoe UI", 10F)
        TxtSeri.ForeColor = Color.White
        TxtSeri.Location = New Point(20, 38)
        TxtSeri.Name = "TxtSeri"
        TxtSeri.Size = New Size(200, 30)
        TxtSeri.TabIndex = 3
        ' 
        ' LblTipe
        ' 
        LblTipe.AutoSize = True
        LblTipe.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblTipe.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblTipe.Location = New Point(20, 15)
        LblTipe.Name = "LblTipe"
        LblTipe.Size = New Size(100, 23)
        LblTipe.TabIndex = 4
        LblTipe.Text = "Tipe Item *"
        ' 
        ' CmbTipe
        ' 
        CmbTipe.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        CmbTipe.DropDownStyle = ComboBoxStyle.DropDownList
        CmbTipe.FlatStyle = FlatStyle.Flat
        CmbTipe.Font = New Font("Segoe UI", 10F)
        CmbTipe.ForeColor = Color.White
        CmbTipe.Items.AddRange(New Object() {"Belt", "Ride Watch", "Progrise Key", "Gashat", "Lock Seed", "Astro Switch", "Ghost Eyecon", "Sword", "Card", "Figure", "Lainnya"})
        CmbTipe.Location = New Point(20, 38)
        CmbTipe.Name = "CmbTipe"
        CmbTipe.Size = New Size(200, 31)
        CmbTipe.TabIndex = 5
        ' 
        ' LblHarga
        ' 
        LblHarga.AutoSize = True
        LblHarga.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblHarga.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblHarga.Location = New Point(20, 15)
        LblHarga.Name = "LblHarga"
        LblHarga.Size = New Size(111, 23)
        LblHarga.TabIndex = 6
        LblHarga.Text = "Harga (Rp) *"
        ' 
        ' TxtHarga
        ' 
        TxtHarga.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtHarga.BorderStyle = BorderStyle.FixedSingle
        TxtHarga.Font = New Font("Segoe UI", 10F)
        TxtHarga.ForeColor = Color.White
        TxtHarga.Location = New Point(20, 38)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(200, 30)
        TxtHarga.TabIndex = 7
        ' 
        ' LblKondisi
        ' 
        LblKondisi.AutoSize = True
        LblKondisi.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblKondisi.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblKondisi.Location = New Point(290, 15)
        LblKondisi.Name = "LblKondisi"
        LblKondisi.Size = New Size(82, 23)
        LblKondisi.TabIndex = 8
        LblKondisi.Text = "Kondisi *"
        ' 
        ' CmbKondisi
        ' 
        CmbKondisi.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        CmbKondisi.DropDownStyle = ComboBoxStyle.DropDownList
        CmbKondisi.FlatStyle = FlatStyle.Flat
        CmbKondisi.Font = New Font("Segoe UI", 10F)
        CmbKondisi.ForeColor = Color.White
        CmbKondisi.Items.AddRange(New Object() {"Baru", "Bekas - Mulus", "Bekas - Baik", "Bekas - Rusak Ringan", "Rusak"})
        CmbKondisi.Location = New Point(290, 38)
        CmbKondisi.Name = "CmbKondisi"
        CmbKondisi.Size = New Size(200, 31)
        CmbKondisi.TabIndex = 9
        ' 
        ' LblStatus
        ' 
        LblStatus.AutoSize = True
        LblStatus.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblStatus.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblStatus.Location = New Point(290, 15)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(178, 23)
        LblStatus.TabIndex = 10
        LblStatus.Text = "Status Kepemilikan *"
        ' 
        ' CmbStatus
        ' 
        CmbStatus.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.FlatStyle = FlatStyle.Flat
        CmbStatus.Font = New Font("Segoe UI", 10F)
        CmbStatus.ForeColor = Color.White
        CmbStatus.Items.AddRange(New Object() {"Dimiliki", "Wishlist", "Dijual", "Dipesan", "Hilang"})
        CmbStatus.Location = New Point(290, 38)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(200, 31)
        CmbStatus.TabIndex = 11
        ' 
        ' LblTahun
        ' 
        LblTahun.AutoSize = True
        LblTahun.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblTahun.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblTahun.Location = New Point(290, 15)
        LblTahun.Name = "LblTahun"
        LblTahun.Size = New Size(109, 23)
        LblTahun.TabIndex = 12
        LblTahun.Text = "Tahun Rilis *"
        ' 
        ' NudTahun
        ' 
        NudTahun.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        NudTahun.Font = New Font("Segoe UI", 10F)
        NudTahun.ForeColor = Color.White
        NudTahun.Location = New Point(290, 38)
        NudTahun.Maximum = New Decimal(New Integer() {2030, 0, 0, 0})
        NudTahun.Minimum = New Decimal(New Integer() {1971, 0, 0, 0})
        NudTahun.Name = "NudTahun"
        NudTahun.Size = New Size(100, 30)
        NudTahun.TabIndex = 13
        NudTahun.Value = New Decimal(New Integer() {2023, 0, 0, 0})
        ' 
        ' LblDeskripsi
        ' 
        LblDeskripsi.AutoSize = True
        LblDeskripsi.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LblDeskripsi.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(230))
        LblDeskripsi.Location = New Point(20, 15)
        LblDeskripsi.Name = "LblDeskripsi"
        LblDeskripsi.Size = New Size(84, 23)
        LblDeskripsi.TabIndex = 14
        LblDeskripsi.Text = "Deskripsi"
        ' 
        ' TxtDeskripsi
        ' 
        TxtDeskripsi.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        TxtDeskripsi.Font = New Font("Segoe UI", 10F)
        TxtDeskripsi.ForeColor = Color.White
        TxtDeskripsi.Location = New Point(20, 38)
        TxtDeskripsi.Name = "TxtDeskripsi"
        TxtDeskripsi.ScrollBars = RichTextBoxScrollBars.Vertical
        TxtDeskripsi.Size = New Size(470, 85)
        TxtDeskripsi.TabIndex = 15
        TxtDeskripsi.Text = ""
        ' 
        ' PanelBottom
        ' 
        PanelBottom.BackColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        PanelBottom.Controls.Add(BtnSimpan)
        PanelBottom.Controls.Add(BtnBatal)
        PanelBottom.Dock = DockStyle.Bottom
        PanelBottom.Location = New Point(0, 500)
        PanelBottom.Name = "PanelBottom"
        PanelBottom.Size = New Size(540, 60)
        PanelBottom.TabIndex = 1
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        BtnSimpan.FlatAppearance.BorderSize = 0
        BtnSimpan.FlatStyle = FlatStyle.Flat
        BtnSimpan.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        BtnSimpan.ForeColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        BtnSimpan.Location = New Point(250, 12)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(130, 38)
        BtnSimpan.TabIndex = 0
        BtnSimpan.Text = "💾 Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        BtnBatal.FlatAppearance.BorderSize = 0
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        BtnBatal.ForeColor = Color.White
        BtnBatal.Location = New Point(390, 12)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(130, 38)
        BtnBatal.TabIndex = 1
        BtnBatal.Text = "✖ Batal"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        ClientSize = New Size(540, 560)
        Controls.Add(PanelForm)
        Controls.Add(PanelBottom)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterParent
        Text = "Tambah / Edit Item Koleksi"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelForm.ResumeLayout(False)
        PanelForm.PerformLayout()
        CType(NudTahun, ComponentModel.ISupportInitialize).EndInit()
        PanelBottom.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LblFormTitle As System.Windows.Forms.Label
    Friend WithEvents LblFormSub As System.Windows.Forms.Label
    Friend WithEvents PanelForm As System.Windows.Forms.Panel
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents LblSeri As System.Windows.Forms.Label
    Friend WithEvents TxtSeri As System.Windows.Forms.TextBox
    Friend WithEvents LblTipe As System.Windows.Forms.Label
    Friend WithEvents CmbTipe As System.Windows.Forms.ComboBox
    Friend WithEvents LblHarga As System.Windows.Forms.Label
    Friend WithEvents TxtHarga As System.Windows.Forms.TextBox
    Friend WithEvents LblKondisi As System.Windows.Forms.Label
    Friend WithEvents CmbKondisi As System.Windows.Forms.ComboBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LblTahun As System.Windows.Forms.Label
    Friend WithEvents NudTahun As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblDeskripsi As System.Windows.Forms.Label
    Friend WithEvents TxtDeskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
End Class