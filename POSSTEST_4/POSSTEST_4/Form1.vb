
Imports System.Reflection.PortableExecutable

Public Class Form1

    Private fotoPath As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Komunitas Hub  Pembuatan Kartu Digital"
        Me.BackColor = Color.FromArgb(13, 17, 30)
        Me.ForeColor = Color.White
        Me.MinimumSize = New Size(900, 700)

        ' Isi ComboBox komunitas
        cboKomunitas.Items.AddRange(New String() {
            "Divisi Desain Kreatif",
            "Divisi Teknologi & IT",
            "Divisi Fotografi",
            "Divisi Musik & Seni",
            "Divisi Olahraga",
            "Divisi Literasi & Riset",
            "Divisi Lingkungan Hidup",
            "Divisi Teater & Drama"
        })
        cboKomunitas.SelectedIndex = 0

        ' Warnai komponen
        ApplyTheme()
    End Sub

    Private Sub ApplyTheme()
        Dim accent As Color = Color.FromArgb(99, 102, 241)   ' Indigo
        Dim surface As Color = Color.FromArgb(22, 27, 46)
        Dim cardBg As Color = Color.FromArgb(30, 36, 60)
        Dim textPrimary As Color = Color.White
        Dim textMuted As Color = Color.FromArgb(148, 163, 184)

        ' Panel header
        pnlHeader.BackColor = Color.FromArgb(15, 20, 40)

        ' TabControl
        tabMain.BackColor = surface
        tabMain.ForeColor = textPrimary

        ' Tab 1
        Dim tab1Controls() As Control = {txtNama, txtID, mskTelepon,
                                          txtEmail, txtAlamat, cboKomunitas}
        For Each ctrl In tab1Controls
            ctrl.BackColor = cardBg
            ctrl.ForeColor = textPrimary
        Next

        ' Buttons
        Dim buttons() As Button = {btnSimpanCetak, btnBrowseFoto}
        For Each btn In buttons
            btn.BackColor = accent
            btn.ForeColor = Color.White
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
        Next

        ' GroupBox roles
        grpPeran.BackColor = surface
        grpPeran.ForeColor = textPrimary
        grpHobby.BackColor = surface
        grpHobby.ForeColor = textPrimary

        ' PictureBox profil border
        picFoto.BackColor = cardBg
        picHeader.BackColor = Color.Transparent
    End Sub

    Private Function ValidasiInput() As Boolean

        '  Tab 1: Data Utama 
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Nama",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabDataUtama
            txtNama.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: ID Anggota",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabDataUtama
            txtID.Focus()
            Return False
        End If

        If rdLakiLaki.Checked = False AndAlso rdPerempuan.Checked = False Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Jenis Kelamin",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabDataUtama
            Return False
        End If

        '  Tab 2: Kontak & Info 
        If mskTelepon.Text.Trim().Replace("-", "").Replace(" ", "").Length < 8 Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Nomor Telepon (format: 0812-3456-7890)",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabKontak
            mskTelepon.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Email",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabKontak
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Alamat",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabKontak
            txtAlamat.Focus()
            Return False
        End If

        '  Tab 3: Profil & Aktivitas 
        ' Cek minimal 1 peran dipilih
        Dim peranDipilih As Boolean = False
        For Each ctrl As Control In grpPeran.Controls
            If TypeOf ctrl Is RadioButton Then
                If DirectCast(ctrl, RadioButton).Checked Then
                    peranDipilih = True
                    Exit For
                End If
            End If
        Next
        If Not peranDipilih Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Peran / Jabatan",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabProfil
            Return False
        End If

        ' Cek minimal 1 hobby dipilih
        Dim hobbyDipilih As Boolean = False
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If DirectCast(ctrl, CheckBox).Checked Then
                    hobbyDipilih = True
                    Exit For
                End If
            End If
        Next
        If Not hobbyDipilih Then
            MessageBox.Show("Inputan tidak boleh kosong!" & vbCrLf & "Field: Hobby/Aktivitas (pilih minimal 1)",
                            "⚠ Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tabMain.SelectedTab = tabProfil
            Return False
        End If

        Return True
    End Function

    ' 
    '  VALIDASI NAMA  Hanya huruf dan spasi
    ' 
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ' Izinkan: huruf (a-z, A-Z), spasi, backspace
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
            MessageBox.Show("Nama hanya boleh berisi huruf!", "⚠ Input Tidak Valid",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    '  VALIDASI ID  Hanya angka

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    '  BROWSE FOTO
    Private Sub btnBrowseFoto_Click(sender As Object, e As EventArgs) Handles btnBrowseFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Pilih Foto Profil"
            ofd.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            If ofd.ShowDialog() = DialogResult.OK Then
                fotoPath = ofd.FileName
                picFoto.Image = Image.FromFile(fotoPath)
                picFoto.SizeMode = PictureBoxSizeMode.Zoom
                lblFotoStatus.Text = "✔ Foto dipilih: " & IO.Path.GetFileName(fotoPath)
                lblFotoStatus.ForeColor = Color.FromArgb(52, 211, 153)
            End If
        End Using
    End Sub


    Private Function GetHobbyList() As String
        Dim hobbies As New List(Of String)
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    ' Hapus emoji prefix untuk teks bersih
                    hobbies.Add(chk.Text)
                End If
            End If
        Next
        Return String.Join(", ", hobbies)
    End Function

    '  KUMPULKAN PERAN YANG DIPILIH
    Private Function GetPeran() As String
        For Each ctrl As Control In grpPeran.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rd = DirectCast(ctrl, RadioButton)
                If rd.Checked Then Return rd.Text
            End If
        Next
        Return ""
    End Function

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidasiInput() Then Return

        Dim konfirmasi = MessageBox.Show(
            "Apakah data sudah benar dan ingin dicetak sebagai Kartu Komunitas?",
            "🎴 Konfirmasi Cetak Kartu",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            ' Buka Form Kartu dan kirim data
            Dim formKartu As New FormKartu()

            formKartu.SetData(
                nama:=txtNama.Text.Trim(),
                idAnggota:=txtID.Text.Trim(),
                tglLahir:=dtpTanggalLahir.Value.ToString("dd MMMM yyyy"),
                jenisKelamin:=If(rdLakiLaki.Checked, "Laki-laki", "Perempuan"),
                komunitas:=cboKomunitas.Text,
                telepon:=mskTelepon.Text,
                email:=txtEmail.Text.Trim(),
                alamat:=txtAlamat.Text.Trim(),
                peran:=GetPeran(),
                hobby:=GetHobbyList(),
                foto:=fotoPath
            )

            formKartu.Show()
        End If
    End Sub

    '  MENU  INPUT DATA
    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
        tabMain.SelectedTab = tabDataUtama
    End Sub

    '  MENU  LIHAT KARTU
    Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click
        If Not ValidasiInput() Then Return
        btnSimpanCetak.PerformClick()
    End Sub

    '  MENU  SIMPAN DATA
    Private Sub mnuSimpanData_Click(sender As Object, e As EventArgs) Handles mnuSimpanData.Click
        If Not ValidasiInput() Then Return

        Using sfd As New SaveFileDialog()
            sfd.Title = "Simpan Data Anggota"
            sfd.Filter = "File Teks|*.txt|File CSV|*.csv"
            sfd.FileName = "KartuKomunitas_" & txtNama.Text.Trim().Replace(" ", "_")
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim lines() As String = {
                    "=== DATA KARTU KOMUNITAS ===",
                    "Nama          : " & txtNama.Text,
                    "ID Anggota    : " & txtID.Text,
                    "Tanggal Lahir : " & dtpTanggalLahir.Value.ToString("dd MMMM yyyy"),
                    "Jenis Kelamin : " & If(rdLakiLaki.Checked, "Laki-laki", "Perempuan"),
                    "Komunitas     : " & cboKomunitas.Text,
                    "Telepon       : " & mskTelepon.Text,
                    "Email         : " & txtEmail.Text,
                    "Alamat        : " & txtAlamat.Text,
                    "Peran         : " & GetPeran(),
                    "Hobby/Aktivitas : " & GetHobbyList(),
                    "Tanggal Cetak : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                }
                IO.File.WriteAllLines(sfd.FileName, lines, System.Text.Encoding.UTF8)
                MessageBox.Show("✅ Data berhasil disimpan ke:" & vbCrLf & sfd.FileName,
                                "Simpan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    '  MENU  BUKA DATA
    Private Sub mnuBukaData_Click(sender As Object, e As EventArgs) Handles mnuBukaData.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Buka File Data Anggota"
            ofd.Filter = "File Teks|*.txt|File CSV|*.csv|Semua File|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim content = IO.File.ReadAllText(ofd.FileName)
                MessageBox.Show(content, "📂 Data Tersimpan  " & IO.Path.GetFileName(ofd.FileName),
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    '  MENU  KELUAR
    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil = MessageBox.Show(
            "Apakah Anda yakin ingin keluar dari aplikasi?" & vbCrLf & "Data yang belum disimpan akan hilang.",
            "🚪 Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    '  FORM CLOSING
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim hasil = MessageBox.Show(
                "Keluar dari aplikasi Kartu Komunitas?",
                "🚪 Konfirmasi Keluar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If hasil = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub lblJudul_Click(sender As Object, e As EventArgs) Handles lblJudul.Click

    End Sub
End Class