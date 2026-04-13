Public Class Form2

    Private Const BACKGROUND_PATH As String = "C:\Users\Lenovo-GK\source\repos\POSSTEST_3\POSSTEST_3\Creative Modern Business Card.png"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Kartu Anggota Komunitas"
        TerapkanBackground()
        IsiDataKartu()
    End Sub

    Private Sub TerapkanBackground()
        If BACKGROUND_PATH <> "" AndAlso IO.File.Exists(BACKGROUND_PATH) Then
            Try
                Me.BackgroundImage = Image.FromFile(BACKGROUND_PATH)
                Me.BackgroundImageLayout = ImageLayout.Stretch
            Catch ex As Exception
                Me.BackColor = Color.White
            End Try
        Else
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub IsiDataKartu()

        lblNamaValue.Text = DataModule.Nama
        lblUmurValue.Text = DataModule.Umur & " tahun"
        lblTanggalLahirValue.Text = DataModule.TanggalLahir
        lblJenisKelaminValue.Text = DataModule.JenisKelamin
        lblNoTelponValue.Text = DataModule.NoTelpon
        lblHobbyValue.Text = DataModule.Hobby
        lblAlamatValue.Text = DataModule.Alamat

        If DataModule.FotoPath <> "" AndAlso IO.File.Exists(DataModule.FotoPath) Then
            picProfilHasil.Image = Image.FromFile(DataModule.FotoPath)
            picProfilHasil.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub picProfilHasil_Click(sender As Object, e As EventArgs) Handles picProfilHasil.Click

    End Sub
End Class