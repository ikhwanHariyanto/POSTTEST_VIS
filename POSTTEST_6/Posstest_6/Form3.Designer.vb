' Form3.Designer.vb - Transaksi Form
' Tema Warna: #021024 / #052659 / #5483B3 / #7DA0CA / #C1E8FF

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim csDgv1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim csDgv2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim csDgv3 As DataGridViewCellStyle = New DataGridViewCellStyle()

        PanelHeader = New Panel()
        LblTitle = New Label()
        LblSub = New Label()
        PanelInput = New Panel()
        LblKoleksi = New Label()
        CmbKoleksi = New ComboBox()
        LblJenis = New Label()
        CmbJenis = New ComboBox()
        LblHarga = New Label()
        TxtHarga = New TextBox()
        LblTanggal = New Label()
        DtpTanggal = New DateTimePicker()
        LblPenjual = New Label()
        TxtPenjual = New TextBox()
        LblPembeli = New Label()
        TxtPembeli = New TextBox()
        LblCatatan = New Label()
        TxtCatatan = New TextBox()
        PanelBtn = New Panel()
        BtnSimpan = New Button()
        BtnHapus = New Button()
        BtnBersih = New Button()
        BtnBatal = New Button()
        LblInfo = New Label()
        PanelGrid = New Panel()
        DgvTransaksi = New DataGridView()

        PanelHeader.SuspendLayout()
        PanelInput.SuspendLayout()
        PanelBtn.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(DgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ── PanelHeader (#021024) ──────────────────────────────
        PanelHeader.BackColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        PanelHeader.Controls.Add(LblTitle)
        PanelHeader.Controls.Add(LblSub)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Size = New Size(1000, 80)

        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblTitle.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblTitle.Location = New Point(20, 10)
        LblTitle.Text = "💰 MANAJEMEN TRANSAKSI KOLEKSI"

        LblSub.AutoSize = True
        LblSub.Font = New Font("Segoe UI", 9.0F)
        LblSub.ForeColor = Color.FromArgb(CByte(125), CByte(160), CByte(202))
        LblSub.Location = New Point(24, 44)
        LblSub.Text = "Catat riwayat pembelian dan penjualan item koleksi DX Kamen Rider"

        ' ── PanelInput (#052659) ──────────────────────────────
        PanelInput.BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        PanelInput.Controls.Add(LblKoleksi)
        PanelInput.Controls.Add(CmbKoleksi)
        PanelInput.Controls.Add(LblJenis)
        PanelInput.Controls.Add(CmbJenis)
        PanelInput.Controls.Add(LblHarga)
        PanelInput.Controls.Add(TxtHarga)
        PanelInput.Controls.Add(LblTanggal)
        PanelInput.Controls.Add(DtpTanggal)
        PanelInput.Controls.Add(LblPenjual)
        PanelInput.Controls.Add(TxtPenjual)
        PanelInput.Controls.Add(LblPembeli)
        PanelInput.Controls.Add(TxtPembeli)
        PanelInput.Controls.Add(LblCatatan)
        PanelInput.Controls.Add(TxtCatatan)
        PanelInput.Dock = DockStyle.Top
        PanelInput.Location = New Point(0, 80)
        PanelInput.Size = New Size(1000, 170)
        PanelInput.Padding = New Padding(10)

        ' Row 1: Koleksi | Jenis | Harga | Tanggal
        LblKoleksi.AutoSize = True
        LblKoleksi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblKoleksi.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblKoleksi.Location = New Point(14, 14)
        LblKoleksi.Text = "Item Koleksi"

        CmbKoleksi.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        CmbKoleksi.Font = New Font("Segoe UI", 9.0F)
        CmbKoleksi.ForeColor = Color.White
        CmbKoleksi.DropDownStyle = ComboBoxStyle.DropDownList
        CmbKoleksi.Location = New Point(14, 34)
        CmbKoleksi.Size = New Size(260, 28)

        LblJenis.AutoSize = True
        LblJenis.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblJenis.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblJenis.Location = New Point(285, 14)
        LblJenis.Text = "Jenis Transaksi"

        CmbJenis.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        CmbJenis.Font = New Font("Segoe UI", 9.0F)
        CmbJenis.ForeColor = Color.White
        CmbJenis.DropDownStyle = ComboBoxStyle.DropDownList
        CmbJenis.Items.AddRange(New Object() {"Beli", "Jual"})
        CmbJenis.SelectedIndex = 0
        CmbJenis.Location = New Point(285, 34)
        CmbJenis.Size = New Size(120, 28)

        LblHarga.AutoSize = True
        LblHarga.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblHarga.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblHarga.Location = New Point(420, 14)
        LblHarga.Text = "Harga (Rp)"

        TxtHarga.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtHarga.BorderStyle = BorderStyle.FixedSingle
        TxtHarga.Font = New Font("Segoe UI", 9.0F)
        TxtHarga.ForeColor = Color.White
        TxtHarga.Location = New Point(420, 34)
        TxtHarga.Size = New Size(160, 28)

        LblTanggal.AutoSize = True
        LblTanggal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblTanggal.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblTanggal.Location = New Point(595, 14)
        LblTanggal.Text = "Tanggal"

        DtpTanggal.CalendarForeColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        DtpTanggal.Font = New Font("Segoe UI", 9.0F)
        DtpTanggal.Format = DateTimePickerFormat.Short
        DtpTanggal.Location = New Point(595, 34)
        DtpTanggal.Size = New Size(150, 28)

        ' Row 2: Penjual | Pembeli | Catatan
        LblPenjual.AutoSize = True
        LblPenjual.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblPenjual.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblPenjual.Location = New Point(14, 75)
        LblPenjual.Text = "Nama Penjual"

        TxtPenjual.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtPenjual.BorderStyle = BorderStyle.FixedSingle
        TxtPenjual.Font = New Font("Segoe UI", 9.0F)
        TxtPenjual.ForeColor = Color.White
        TxtPenjual.Location = New Point(14, 95)
        TxtPenjual.Size = New Size(200, 28)

        LblPembeli.AutoSize = True
        LblPembeli.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblPembeli.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblPembeli.Location = New Point(225, 75)
        LblPembeli.Text = "Nama Pembeli"

        TxtPembeli.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtPembeli.BorderStyle = BorderStyle.FixedSingle
        TxtPembeli.Font = New Font("Segoe UI", 9.0F)
        TxtPembeli.ForeColor = Color.White
        TxtPembeli.Location = New Point(225, 95)
        TxtPembeli.Size = New Size(200, 28)

        LblCatatan.AutoSize = True
        LblCatatan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblCatatan.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        LblCatatan.Location = New Point(440, 75)
        LblCatatan.Text = "Catatan"

        TxtCatatan.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        TxtCatatan.BorderStyle = BorderStyle.FixedSingle
        TxtCatatan.Font = New Font("Segoe UI", 9.0F)
        TxtCatatan.ForeColor = Color.White
        TxtCatatan.Location = New Point(440, 95)
        TxtCatatan.Size = New Size(400, 28)

        ' ── PanelBtn (#021024) ──────────────────────────────
        PanelBtn.BackColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        PanelBtn.Controls.Add(BtnSimpan)
        PanelBtn.Controls.Add(BtnHapus)
        PanelBtn.Controls.Add(BtnBersih)
        PanelBtn.Controls.Add(BtnBatal)
        PanelBtn.Controls.Add(LblInfo)
        PanelBtn.Dock = DockStyle.Top
        PanelBtn.Location = New Point(0, 250)
        PanelBtn.Size = New Size(1000, 52)

        BtnSimpan.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        BtnSimpan.FlatAppearance.BorderSize = 0
        BtnSimpan.FlatStyle = FlatStyle.Flat
        BtnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnSimpan.ForeColor = Color.White
        BtnSimpan.Location = New Point(10, 10)
        BtnSimpan.Size = New Size(140, 34)
        BtnSimpan.Text = "💾 Simpan Transaksi"

        BtnHapus.BackColor = Color.FromArgb(CByte(140), CByte(30), CByte(50))
        BtnHapus.FlatAppearance.BorderSize = 0
        BtnHapus.FlatStyle = FlatStyle.Flat
        BtnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(160, 10)
        BtnHapus.Size = New Size(130, 34)
        BtnHapus.Text = "🗑️ Hapus"

        BtnBersih.BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        BtnBersih.FlatAppearance.BorderSize = 0
        BtnBersih.FlatStyle = FlatStyle.Flat
        BtnBersih.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnBersih.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        BtnBersih.Location = New Point(300, 10)
        BtnBersih.Size = New Size(110, 34)
        BtnBersih.Text = "↺ Bersih"

        BtnBatal.BackColor = Color.FromArgb(CByte(125), CByte(160), CByte(202))
        BtnBatal.FlatAppearance.BorderSize = 0
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnBatal.ForeColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        BtnBatal.Location = New Point(420, 10)
        BtnBatal.Size = New Size(110, 34)
        BtnBatal.Text = "✖ Tutup"

        LblInfo.AutoSize = True
        LblInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblInfo.ForeColor = Color.FromArgb(CByte(125), CByte(160), CByte(202))
        LblInfo.Location = New Point(560, 18)
        LblInfo.Text = "Total Transaksi: 0 record"

        ' ── PanelGrid (#052659) ──────────────────────────────
        PanelGrid.BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        PanelGrid.Controls.Add(DgvTransaksi)
        PanelGrid.Dock = DockStyle.Fill
        PanelGrid.Padding = New Padding(8)

        ' ── DgvTransaksi ──────────────────────────────────────
        DgvTransaksi.AllowUserToAddRows = False
        DgvTransaksi.AllowUserToDeleteRows = False
        csDgv1.BackColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        DgvTransaksi.AlternatingRowsDefaultCellStyle = csDgv1
        DgvTransaksi.BackgroundColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        DgvTransaksi.BorderStyle = BorderStyle.None
        DgvTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        csDgv2.BackColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        csDgv2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        csDgv2.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        csDgv2.SelectionBackColor = SystemColors.Highlight
        csDgv2.SelectionForeColor = SystemColors.HighlightText
        DgvTransaksi.ColumnHeadersDefaultCellStyle = csDgv2
        DgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        csDgv3.BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        csDgv3.Font = New Font("Segoe UI", 9.0F)
        csDgv3.ForeColor = Color.FromArgb(CByte(193), CByte(232), CByte(255))
        csDgv3.SelectionBackColor = Color.FromArgb(CByte(125), CByte(160), CByte(202))
        csDgv3.SelectionForeColor = Color.FromArgb(CByte(2), CByte(16), CByte(36))
        DgvTransaksi.DefaultCellStyle = csDgv3
        DgvTransaksi.Dock = DockStyle.Fill
        DgvTransaksi.EnableHeadersVisualStyles = False
        DgvTransaksi.Font = New Font("Segoe UI", 9.0F)
        DgvTransaksi.GridColor = Color.FromArgb(CByte(84), CByte(131), CByte(179))
        DgvTransaksi.MultiSelect = False
        DgvTransaksi.ReadOnly = True
        DgvTransaksi.RowHeadersVisible = False
        DgvTransaksi.RowTemplate.Height = 32
        DgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' ── Form3 ──────────────────────────────────────────────
        BackColor = Color.FromArgb(CByte(5), CByte(38), CByte(89))
        ClientSize = New Size(1000, 600)
        Controls.Add(PanelGrid)
        Controls.Add(PanelBtn)
        Controls.Add(PanelInput)
        Controls.Add(PanelHeader)
        MinimumSize = New Size(1000, 600)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Transaksi - DX Kamen Rider Collector"

        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelInput.ResumeLayout(False)
        PanelInput.PerformLayout()
        PanelBtn.ResumeLayout(False)
        PanelBtn.PerformLayout()
        PanelGrid.ResumeLayout(False)
        CType(DgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblSub As Label
    Friend WithEvents PanelInput As Panel
    Friend WithEvents LblKoleksi As Label
    Friend WithEvents CmbKoleksi As ComboBox
    Friend WithEvents LblJenis As Label
    Friend WithEvents CmbJenis As ComboBox
    Friend WithEvents LblHarga As Label
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents LblTanggal As Label
    Friend WithEvents DtpTanggal As DateTimePicker
    Friend WithEvents LblPenjual As Label
    Friend WithEvents TxtPenjual As TextBox
    Friend WithEvents LblPembeli As Label
    Friend WithEvents TxtPembeli As TextBox
    Friend WithEvents LblCatatan As Label
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents PanelBtn As Panel
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents DgvTransaksi As DataGridView
End Class
