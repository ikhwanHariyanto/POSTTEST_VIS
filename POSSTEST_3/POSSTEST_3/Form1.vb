Public Class Form1
    Private Const BACKGROUND_PATH As String = "C:\Users\Lenovo-GK\source\repos\POSSTEST_3\POSSTEST_3\Creative Modern Business Card.png"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Form Cetak Kartu Komunitas"
        TerapkanBackground()
    End Sub
    Private Sub TerapkanBackground()
        If BACKGROUND_PATH <> "" AndAlso IO.File.Exists(BACKGROUND_PATH) Then
            Try
                Me.BackgroundImage = Image.FromFile(BACKGROUND_PATH)
                Me.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtNoTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelpon.KeyPress
        HanyaAngka(sender, e)
    End Sub
    Private Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Foto Profil"



        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim folderPath As String = IO.Path.Combine(Application.StartupPath, "Foto")
                If Not IO.Directory.Exists(folderPath) Then
                    IO.Directory.CreateDirectory(folderPath)
                End If

                Dim ext As String = IO.Path.GetExtension(openFileDialog.FileName)
                Dim fileName As String = "profil_temp" & ext
                Dim destPath As String = IO.Path.Combine(folderPath, fileName)

                IO.File.Copy(openFileDialog.FileName, destPath, True)

                DataModule.FotoPath = destPath
                picProfil.Image = Image.FromFile(destPath)
                picProfil.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If txtUmur.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Umur harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return
        End If

        If txtNoTelpon.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nomor Telepon harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNoTelpon.Focus()
            Return
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Alamat harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return
        End If
        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong: Jenis Kelamin harus dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DataModule.FotoPath = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Foto Profil harus diunggah!", "Perigatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim hobbyList As New List(Of String)
        If chkGaming.Checked Then hobbyList.Add("Gaming")
        If chkMembaca.Checked Then hobbyList.Add("Membaca")
        If chkCoding.Checked Then hobbyList.Add("Coding")
        If chkMemancing.Checked Then hobbyList.Add("Memancing")
        If chkTraveling.Checked Then hobbyList.Add("Traveling")
        If chkOlahraga.Checked Then hobbyList.Add("Olahraga")
        If chkMenggambar.Checked Then hobbyList.Add("Menggambar")
        If chkMenyanyi.Checked Then hobbyList.Add("Menyanyi")
        If chkMenulis.Checked Then hobbyList.Add("Menulis")
        If chkMenari.Checked Then hobbyList.Add("Menari")
        If chkMemasak.Checked Then hobbyList.Add("memasak")
        If chkFotografi.Checked Then hobbyList.Add("Fotografi")

        If hobbyList.Count = 0 Then
            MessageBox.Show("Inputan tidak boleh kosong: Hobby harus dipilih minimal 1!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataModule.Nama = txtNama.Text.Trim()
        DataModule.Umur = txtUmur.Text.Trim()
        DataModule.NoTelpon = txtNoTelpon.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")
        DataModule.JenisKelamin = If(rbLakiLaki.Checked, "Laki-Laki", "Perempuan")
        DataModule.Hobby = String.Join(", ", hobbyList)

        Dim frm2 As New Form2()
        frm2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class