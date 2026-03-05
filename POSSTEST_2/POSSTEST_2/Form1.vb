Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahBuku("Harry Potterr", "Fantasi")
        TambahBuku("Sherlock Holmes", "Misteri")
        TambahBuku("Pandora Hearts", "Fantasi")


        TampilkanDaftarBuku()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudulBuku.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()


        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul Buku dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If CekBukuAda(judul) Then
            MessageBox.Show("Buku dengan judul tersebut sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        TambahBuku(judul, genre)


        TampilkanDaftarBuku()


        txtJudulBuku.Clear()
        txtGenre.Clear()
        txtJudulBuku.Focus()

        MessageBox.Show("Buku berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtJudulBukuHapus.Text.Trim()


        If judul = "" Then
            MessageBox.Show("Masukkan Judul Buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim berhasil As Boolean = False
        HapusBuku(judul, berhasil)

        If berhasil Then

            TampilkanDaftarBuku()


            txtJudulBukuHapus.Clear()
            txtJudulBukuHapus.Focus()

            MessageBox.Show("Buku berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Buku dengan judul tersebut tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TampilkanDaftarBuku()
        lstDaftarBuku.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            Dim bukuFormat As String = FormatBuku(daftarBuku(i, 0), daftarBuku(i, 1))
            lstDaftarBuku.Items.Add(bukuFormat)
        Next i
    End Sub

End Class