Public Class Form1

    ' Menyimpan DataTable aktif (untuk akses ID dari baris yang dipilih)
    Private _dtAktif As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Test koneksi dulu sebelum lanjut
        If Not TestKoneksi() Then
            Me.Close()
            Return
        End If

        SetupDataGridView()
        MuatData()
    End Sub

    Private Sub SetupDataGridView()
        DgvData.Columns.Clear()
        DgvData.AutoGenerateColumns = False

        ' Kolom ID (tersembunyi, tetap ada untuk referensi)
        Dim colID As New DataGridViewTextBoxColumn()
        colID.DataPropertyName = "id"
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.Width = 50
        colID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvData.Columns.Add(colID)

        ' Kolom Nama Item
        Dim colNama As New DataGridViewTextBoxColumn()
        colNama.DataPropertyName = "nama_item"
        colNama.HeaderText = "Nama Item"
        colNama.Name = "colNama"
        colNama.Width = 200
        DgvData.Columns.Add(colNama)

        ' Kolom Seri
        Dim colSeri As New DataGridViewTextBoxColumn()
        colSeri.DataPropertyName = "seri"
        colSeri.HeaderText = "Seri / Series"
        colSeri.Name = "colSeri"
        colSeri.Width = 130
        DgvData.Columns.Add(colSeri)

        ' Kolom Tipe
        Dim colTipe As New DataGridViewTextBoxColumn()
        colTipe.DataPropertyName = "tipe"
        colTipe.HeaderText = "Tipe"
        colTipe.Name = "colTipe"
        colTipe.Width = 100
        DgvData.Columns.Add(colTipe)

        ' Kolom Harga (format Rupiah)
        Dim colHarga As New DataGridViewTextBoxColumn()
        colHarga.DataPropertyName = "harga"
        colHarga.HeaderText = "Harga (Rp)"
        colHarga.Name = "colHarga"
        colHarga.Width = 120
        colHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colHarga.DefaultCellStyle.Format = "N0"
        DgvData.Columns.Add(colHarga)

        ' Kolom Kondisi
        Dim colKondisi As New DataGridViewTextBoxColumn()
        colKondisi.DataPropertyName = "kondisi"
        colKondisi.HeaderText = "Kondisi"
        colKondisi.Name = "colKondisi"
        colKondisi.Width = 90
        colKondisi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvData.Columns.Add(colKondisi)

        ' Kolom Status
        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.DataPropertyName = "status"
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.Width = 110
        colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvData.Columns.Add(colStatus)

        ' Kolom Tahun Rilis
        Dim colTahun As New DataGridViewTextBoxColumn()
        colTahun.DataPropertyName = "tahun_rilis"
        colTahun.HeaderText = "Tahun"
        colTahun.Name = "colTahun"
        colTahun.Width = 70
        colTahun.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvData.Columns.Add(colTahun)
    End Sub

    Public Sub MuatData()
        _dtAktif = GetAllKoleksi()
        DgvData.DataSource = _dtAktif
        UpdateLabelTotal()
    End Sub

    Private Sub UpdateLabelTotal()
        Dim total As Integer = If(_dtAktif IsNot Nothing, _dtAktif.Rows.Count, 0)
        LblTotal.Text = "Total Koleksi: " & total & " item"
    End Sub

    Private Function GetSelectedID() As Integer
        If DgvData.SelectedRows.Count = 0 Then Return -1
        Dim val As Object = DgvData.SelectedRows(0).Cells("colID").Value
        If val Is Nothing OrElse val Is DBNull.Value Then Return -1
        Return Convert.ToInt32(val)
    End Function

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim frm As New Form2(0, False) ' ID=0 berarti mode tambah baru
        frm.ShowDialog()
        MuatData()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim id As Integer = GetSelectedID()
        If id = -1 Then
            MsgBox("Pilih data yang ingin diedit!", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Dim frm As New Form2(id, False) ' False = mode edit
        frm.ShowDialog()
        MuatData()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim id As Integer = GetSelectedID()
        If id = -1 Then
            MsgBox("Pilih data yang ingin dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Dim namaItem As String = DgvData.SelectedRows(0).Cells("colNama").Value.ToString()
        Dim konfirmasi As MsgBoxResult = MsgBox(
            "Yakin ingin menghapus item:" & vbNewLine & """" & namaItem & """?",
            MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
            "Konfirmasi Hapus"
        )

        If konfirmasi = MsgBoxResult.Yes Then
            If HapusKoleksi(id) Then
                MsgBox("Item berhasil dihapus!", MsgBoxStyle.Information, "Sukses")
                MuatData()
            End If
        End If
    End Sub

    Private Sub BtnDetail_Click(sender As Object, e As EventArgs) Handles BtnDetail.Click
        Dim id As Integer = GetSelectedID()
        If id = -1 Then
            MsgBox("Pilih data untuk melihat detail!", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        Dim frm As New Form2(id, True) ' True = mode detail/readonly
        frm.ShowDialog()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        CarilahData()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then CarilahData()
    End Sub

    ' Search real-time saat mengetik
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        CarilahData()
    End Sub

    Private Sub CarilahData()
        Dim keyword As String = TxtSearch.Text.Trim()
        Dim searchBy As String = If(CmbSearchBy.SelectedItem IsNot Nothing, CmbSearchBy.SelectedItem.ToString(), "")
git log --oneline
        If keyword = "" Then
            MuatData()
            Return
        End If

        _dtAktif = SearchKoleksi(keyword, searchBy)
        DgvData.DataSource = _dtAktif
        LblTotal.Text = "Hasil pencarian: " & _dtAktif.Rows.Count & " item"
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtSearch.Text = ""
        CmbSearchBy.SelectedIndex = 0
        MuatData()
    End Sub

    Private Sub DgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvData.CellDoubleClick
        If e.RowIndex >= 0 Then BtnDetail_Click(sender, e)
    End Sub

    Private Sub DgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvData.CellContentClick

    End Sub
End Class