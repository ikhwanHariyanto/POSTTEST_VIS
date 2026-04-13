
Public Class Form2

    Private _id As Integer
    Private _isReadOnly As Boolean

    Public Sub New(id As Integer, isReadOnly As Boolean)
        InitializeComponent()
        _id = id
        _isReadOnly = isReadOnly
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _isReadOnly Then
            Me.Text = "Detail Item Koleksi"
            LblFormTitle.Text = "📋 Detail Item"
            LblFormSub.Text = "Informasi lengkap item koleksi"
            IsiDataDariDB()
            SetReadOnlyMode()
            BtnSimpan.Visible = False
            BtnBatal.Text = "✖ Tutup"
            BtnBatal.Location = New System.Drawing.Point(200, 12)
            BtnBatal.Width = 140

        ElseIf _id > 0 Then
            Me.Text = "Edit Item Koleksi"
            LblFormTitle.Text = "✏️ Edit Item"
            LblFormSub.Text = "Ubah data item koleksi DX Kamen Rider"
            IsiDataDariDB()

        Else
            Me.Text = "Tambah Item Baru"
            LblFormTitle.Text = "➕ Tambah Item Baru"
            LblFormSub.Text = "Tambahkan item koleksi DX Kamen Rider baru"
            CmbTipe.SelectedIndex = 0
            CmbKondisi.SelectedIndex = 0
            CmbStatus.SelectedIndex = 0
            NudTahun.Value = DateTime.Now.Year
        End If
    End Sub

    Private Sub IsiDataDariDB()
        Dim row As DataRow = GetKoleksiByID(_id)
        If row Is Nothing Then
            MsgBox("Data tidak ditemukan di database!", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
            Return
        End If

        TxtNama.Text = row("nama_item").ToString()
        TxtSeri.Text = row("seri").ToString()
        TxtHarga.Text = row("harga").ToString()
        TxtDeskripsi.Text = row("deskripsi").ToString()
        NudTahun.Value = Convert.ToInt32(row("tahun_rilis"))

        SetComboValue(CmbTipe, row("tipe").ToString())
        SetComboValue(CmbKondisi, row("kondisi").ToString())
        SetComboValue(CmbStatus, row("status").ToString())
    End Sub

    Private Sub SetComboValue(cmb As ComboBox, nilai As String)
        Dim idx As Integer = cmb.Items.IndexOf(nilai)
        If idx < 0 Then
            For i As Integer = 0 To cmb.Items.Count - 1
                If cmb.Items(i).ToString().ToLower().Contains(nilai.ToLower()) Then
                    idx = i
                    Exit For
                End If
            Next
        End If
        cmb.SelectedIndex = If(idx >= 0, idx, 0)
    End Sub

    Private Sub SetReadOnlyMode()
        TxtNama.ReadOnly = True
        TxtSeri.ReadOnly = True
        TxtHarga.ReadOnly = True
        TxtDeskripsi.ReadOnly = True
        CmbTipe.Enabled = False
        CmbKondisi.Enabled = False
        CmbStatus.Enabled = False
        NudTahun.Enabled = False

        Dim roColor As System.Drawing.Color = System.Drawing.Color.FromArgb(38, 38, 60)
        TxtNama.BackColor = roColor
        TxtSeri.BackColor = roColor
        TxtHarga.BackColor = roColor
        TxtDeskripsi.BackColor = roColor
    End Sub

    Private Function ValidasiForm() As Boolean
        If TxtNama.Text.Trim() = "" Then
            MsgBox("Nama item tidak boleh kosong!", MsgBoxStyle.Exclamation, "Validasi")
            TxtNama.Focus()
            Return False
        End If

        If TxtSeri.Text.Trim() = "" Then
            MsgBox("Seri tidak boleh kosong!", MsgBoxStyle.Exclamation, "Validasi")
            TxtSeri.Focus()
            Return False
        End If

        If CmbTipe.SelectedIndex < 0 Then
            MsgBox("Pilih tipe item!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If

        Dim harga As Long
        If Not Long.TryParse(TxtHarga.Text.Trim(), harga) OrElse harga < 0 Then
            MsgBox("Harga harus berupa angka yang valid!" & vbNewLine &
                   "Contoh: 450000 (tanpa titik/koma)",
                   MsgBoxStyle.Exclamation, "Validasi")
            TxtHarga.Focus()
            TxtHarga.SelectAll()
            Return False
        End If

        If CmbKondisi.SelectedIndex < 0 Then
            MsgBox("Pilih kondisi item!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If

        If CmbStatus.SelectedIndex < 0 Then
            MsgBox("Pilih status kepemilikan!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If

        Return True
    End Function

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Not ValidasiForm() Then Return

        ' Ambil nilai dari form
        Dim nama As String = TxtNama.Text.Trim()
        Dim seri As String = TxtSeri.Text.Trim()
        Dim tipe As String = CmbTipe.SelectedItem.ToString()
        Dim harga As Long = Long.Parse(TxtHarga.Text.Trim())
        Dim kondisi As String = CmbKondisi.SelectedItem.ToString()
        Dim status As String = CmbStatus.SelectedItem.ToString()
        Dim tahun As Integer = CInt(NudTahun.Value)
        Dim deskripsi As String = TxtDeskripsi.Text.Trim()

        If _id = 0 Then
            If SimpanKoleksi(nama, seri, tipe, harga, kondisi, status, tahun, deskripsi) Then
                MsgBox("Item berhasil ditambahkan! Henshin! ⚡",
                       MsgBoxStyle.Information, "Sukses")
                Me.Close()
            End If
        Else
            If UbahKoleksi(_id, nama, seri, tipe, harga, kondisi, status, tahun, deskripsi) Then
                MsgBox("Item berhasil diperbarui!", MsgBoxStyle.Information, "Sukses")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub TxtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub LblFormTitle_Click(sender As Object, e As EventArgs) Handles LblFormTitle.Click

    End Sub

    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub
End Class