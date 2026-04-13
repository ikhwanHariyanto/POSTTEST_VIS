
Public Class FormKartu

    '  Menyimpan data yang diterima dari Form1 
    Private _nama As String = ""
    Private _id As String = ""
    Private _tglLahir As String = ""
    Private _jk As String = ""
    Private _komunitas As String = ""
    Private _telepon As String = ""
    Private _email As String = ""
    Private _alamat As String = ""
    Private _peran As String = ""
    Private _hobby As String = ""
    Private _fotoPath As String = ""


    '  SET DATA — Dipanggil dari Form1

    Public Sub SetData(nama As String, idAnggota As String, tglLahir As String,
                       jenisKelamin As String, komunitas As String, telepon As String,
                       email As String, alamat As String, peran As String,
                       hobby As String, foto As String)
        _nama = nama
        _id = idAnggota
        _tglLahir = tglLahir
        _jk = jenisKelamin
        _komunitas = komunitas
        _telepon = telepon
        _email = email
        _alamat = alamat
        _peran = peran
        _hobby = hobby
        _fotoPath = foto
    End Sub

    ' 
    '  LOAD FORM — Isi semua data ke tampilan kartu
    ' 
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "🎴 Kartu Komunitas — " & _nama
        Me.BackColor = Color.FromArgb(13, 17, 30)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimumSize = New Size(650, 500)

        ' Isi label
        lblNamaVal.Text = _nama
        lblIDVal.Text = "ID: " & _id
        lblKomunitasVal.Text = _komunitas
        lblPeranVal.Text = _peran
        lblTglLahirVal.Text = _tglLahir & "   |   " & _jk
        lblTeleponVal.Text = "📞 " & _telepon
        lblEmailVal.Text = "✉ " & _email
        lblAlamatVal.Text = "📍 " & _alamat
        lblHobbyVal.Text = _hobby

        ' Foto profil
        If _fotoPath <> "" AndAlso IO.File.Exists(_fotoPath) Then
            picProfil.Image = Image.FromFile(_fotoPath)
            picProfil.SizeMode = PictureBoxSizeMode.Zoom
        Else
            ' Tampilkan placeholder inisial
            picProfil.Image = Nothing
            picProfil.BackColor = Color.FromArgb(99, 102, 241)
            DrawInitial()
        End If
    End Sub

    ' 
    '  GAMBAR INISIAL DI PICTUREBOX
    ' 
    Private Sub DrawInitial()
        Dim bmp As New Bitmap(picProfil.Width, picProfil.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.FromArgb(99, 102, 241))
            Dim inisial As String = If(_nama.Length > 0, _nama.Substring(0, 1).ToUpper(), "?")
            Dim font As New Font("Segoe UI", 40, FontStyle.Bold)
            Dim brush As New SolidBrush(Color.White)
            Dim sz = g.MeasureString(inisial, font)
            g.DrawString(inisial, font, brush,
                         (bmp.Width - sz.Width) / 2,
                         (bmp.Height - sz.Height) / 2)
        End Using
        picProfil.Image = bmp
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ' 
    '  TOMBOL KEMBALI
    ' 
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    ' 
    '  TOMBOL SIMPAN KARTU SEBAGAI GAMBAR
    ' 
    Private Sub btnSimpanGambar_Click(sender As Object, e As EventArgs) Handles btnSimpanGambar.Click
        Using sfd As New SaveFileDialog()
            sfd.Title = "Simpan Kartu sebagai Gambar"
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg"
            sfd.FileName = "KartuKomunitas_" & _nama.Replace(" ", "_")
            If sfd.ShowDialog() = DialogResult.OK Then
                ' Capture panel kartu sebagai gambar
                Dim bmp As New Bitmap(pnlKartu.Width, pnlKartu.Height)
                pnlKartu.DrawToBitmap(bmp, New Rectangle(0, 0, pnlKartu.Width, pnlKartu.Height))
                bmp.Save(sfd.FileName)
                MessageBox.Show("✅ Kartu berhasil disimpan sebagai gambar!" & vbCrLf & sfd.FileName,
                                "Simpan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

End Class