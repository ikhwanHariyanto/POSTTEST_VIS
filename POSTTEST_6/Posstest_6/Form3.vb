' ===========================================================
'  Form3 - Manajemen Transaksi
'  Tabel: tbtransaksi (berelasi dengan tbkoleksi)
'  Tema Warna: #021024 / #052659 / #5483B3 / #7DA0CA / #C1E8FF
' ===========================================================
Public Class Form3

    Private _dtTransaksi As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        MuatKoleksiCombo()
        MuatData()
    End Sub

    Private Sub SetupDataGridView()
        DgvTransaksi.Columns.Clear()
        DgvTransaksi.AutoGenerateColumns = False

        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "id"
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.Width = 45
        colID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTransaksi.Columns.Add(colID)

        Dim colItem As New DataGridViewTextBoxColumn()
        colItem.DataPropertyName = "nama_item"
        colItem.HeaderText = "Nama Item Koleksi"
        colItem.Name = "colItem"
        colItem.Width = 210
        DgvTransaksi.Columns.Add(colItem)

        Dim colJenis As New DataGridViewTextBoxColumn()
        colJenis.DataPropertyName = "jenis_transaksi"
        colJenis.HeaderText = "Jenis"
        colJenis.Name = "colJenis"
        colJenis.Width = 70
        colJenis.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTransaksi.Columns.Add(colJenis)

        Dim colHarga As New DataGridViewTextBoxColumn()
        colHarga.DataPropertyName = "harga_transaksi"
        colHarga.HeaderText = "Harga (Rp)"
        colHarga.Name = "colHarga"
        colHarga.Width = 120
        colHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colHarga.DefaultCellStyle.Format = "N0"
        DgvTransaksi.Columns.Add(colHarga)

        Dim colTgl As New DataGridViewTextBoxColumn()
        colTgl.DataPropertyName = "tanggal"
        colTgl.HeaderText = "Tanggal"
        colTgl.Name = "colTanggal"
        colTgl.Width = 100
        colTgl.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTgl.DefaultCellStyle.Format = "dd/MM/yyyy"
        DgvTransaksi.Columns.Add(colTgl)

        Dim colPenjual As New DataGridViewTextBoxColumn()
        colPenjual.DataPropertyName = "nama_penjual"
        colPenjual.HeaderText = "Penjual"
        colPenjual.Name = "colPenjual"
        colPenjual.Width = 140
        DgvTransaksi.Columns.Add(colPenjual)

        Dim colPembeli As New DataGridViewTextBoxColumn()
        colPembeli.DataPropertyName = "nama_pembeli"
        colPembeli.HeaderText = "Pembeli"
        colPembeli.Name = "colPembeli"
        colPembeli.Width = 140
        DgvTransaksi.Columns.Add(colPembeli)

        Dim colCatatan As New DataGridViewTextBoxColumn()
        colCatatan.DataPropertyName = "catatan"
        colCatatan.HeaderText = "Catatan"
        colCatatan.Name = "colCatatan"
        colCatatan.Width = 180
        DgvTransaksi.Columns.Add(colCatatan)
    End Sub

    Private Sub MuatKoleksiCombo()
        Dim dtCombo As DataTable = GetKoleksiForCombo()
        CmbKoleksi.DataSource = dtCombo
        CmbKoleksi.DisplayMember = "nama_item"
        CmbKoleksi.ValueMember = "id"
        CmbKoleksi.SelectedIndex = -1
    End Sub

    Private Sub MuatData()
        _dtTransaksi = GetAllTransaksi()
        DgvTransaksi.DataSource = _dtTransaksi
        UpdateInfo()
    End Sub

    Private Sub UpdateInfo()
        Dim total As Integer = If(_dtTransaksi IsNot Nothing, _dtTransaksi.Rows.Count, 0)
        LblInfo.Text = "Total Transaksi: " & total & " record"
    End Sub

    Private Function GetSelectedID() As Integer
        If DgvTransaksi.SelectedRows.Count = 0 Then Return -1
        Dim val As Object = DgvTransaksi.SelectedRows(0).Cells("colID").Value
        If val Is Nothing OrElse val Is DBNull.Value Then Return -1
        Return Convert.ToInt32(val)
    End Function

    Private Function ValidasiInput() As Boolean
        If CmbKoleksi.SelectedIndex < 0 Then
            MsgBox("Pilih item koleksi terlebih dahulu!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If
        Dim harga As Long
        If Not Long.TryParse(TxtHarga.Text.Trim(), harga) OrElse harga < 0 Then
            MsgBox("Harga harus berupa angka valid!" & vbNewLine & "Contoh: 350000", MsgBoxStyle.Exclamation, "Validasi")
            TxtHarga.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Not ValidasiInput() Then Return

        Dim koleksiId As Integer = Convert.ToInt32(CmbKoleksi.SelectedValue)
        Dim jenis As String = CmbJenis.SelectedItem.ToString()
        Dim harga As Long = Long.Parse(TxtHarga.Text.Trim())
        Dim tanggal As Date = DtpTanggal.Value.Date
        Dim penjual As String = TxtPenjual.Text.Trim()
        Dim pembeli As String = TxtPembeli.Text.Trim()
        Dim catatan As String = TxtCatatan.Text.Trim()

        If SimpanTransaksi(koleksiId, jenis, harga, tanggal, penjual, pembeli, catatan) Then
            MsgBox("Transaksi berhasil dicatat! 💰", MsgBoxStyle.Information, "Sukses")
            BersihkanForm()
            MuatData()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim id As Integer = GetSelectedID()
        If id = -1 Then
            MsgBox("Pilih transaksi yang ingin dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If
        Dim konfirmasi As MsgBoxResult = MsgBox(
            "Yakin ingin menghapus transaksi ini?",
            MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Hapus")
        If konfirmasi = MsgBoxResult.Yes Then
            If HapusTransaksi(id) Then
                MsgBox("Transaksi berhasil dihapus!", MsgBoxStyle.Information, "Sukses")
                MuatData()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        CmbKoleksi.SelectedIndex = -1
        CmbJenis.SelectedIndex = 0
        TxtHarga.Text = ""
        DtpTanggal.Value = DateTime.Now
        TxtPenjual.Text = ""
        TxtPembeli.Text = ""
        TxtCatatan.Text = ""
    End Sub

    Private Sub TxtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub DgvTransaksi_SelectionChanged(sender As Object, e As EventArgs) Handles DgvTransaksi.SelectionChanged
        ' Isi form dari baris yang dipilih untuk keperluan referensi/edit mudah
        If DgvTransaksi.SelectedRows.Count = 0 Then Return
        Dim row As DataGridViewRow = DgvTransaksi.SelectedRows(0)
        Try
            ' Set combo koleksi berdasarkan koleksi_id tersimpan di row
            Dim kid As Object = row.Cells("colID").Value ' gunakan sebagai referensi saja
        Catch
        End Try
    End Sub

End Class
