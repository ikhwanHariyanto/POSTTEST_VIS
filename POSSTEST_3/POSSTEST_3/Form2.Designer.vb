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
        picProfilHasil = New PictureBox()
        lblNamaKey = New Label()
        lblNamaValue = New Label()
        lblUmurKey = New Label()
        lblUmurValue = New Label()
        lblTanggalLahirKey = New Label()
        lblTanggalLahirValue = New Label()
        lblJenisKelaminKey = New Label()
        lblJenisKelaminValue = New Label()
        lblNoTelponKey = New Label()
        lblNoTelponValue = New Label()
        lblHobbyKey = New Label()
        lblHobbyValue = New Label()
        lblAlamatKey = New Label()
        lblAlamatValue = New Label()
        panelGaris = New Panel()
        btnKembali = New Button()
        lblMember = New Label()
        CType(picProfilHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProfilHasil
        ' 
        picProfilHasil.BackColor = Color.Transparent
        picProfilHasil.BorderStyle = BorderStyle.FixedSingle
        picProfilHasil.Location = New Point(54, 100)
        picProfilHasil.Name = "picProfilHasil"
        picProfilHasil.Size = New Size(174, 226)
        picProfilHasil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfilHasil.TabIndex = 0
        picProfilHasil.TabStop = False
        ' 
        ' lblNamaKey
        ' 
        lblNamaKey.BackColor = Color.Transparent
        lblNamaKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNamaKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblNamaKey.Location = New Point(450, 105)
        lblNamaKey.Name = "lblNamaKey"
        lblNamaKey.Size = New Size(130, 18)
        lblNamaKey.TabIndex = 5
        lblNamaKey.Text = "Nama"
        ' 
        ' lblNamaValue
        ' 
        lblNamaValue.BackColor = Color.Transparent
        lblNamaValue.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNamaValue.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblNamaValue.Location = New Point(590, 105)
        lblNamaValue.Name = "lblNamaValue"
        lblNamaValue.Size = New Size(170, 18)
        lblNamaValue.TabIndex = 6
        ' 
        ' lblUmurKey
        ' 
        lblUmurKey.BackColor = Color.Transparent
        lblUmurKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUmurKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblUmurKey.Location = New Point(450, 143)
        lblUmurKey.Name = "lblUmurKey"
        lblUmurKey.Size = New Size(130, 18)
        lblUmurKey.TabIndex = 7
        lblUmurKey.Text = "Umur"
        ' 
        ' lblUmurValue
        ' 
        lblUmurValue.BackColor = Color.Transparent
        lblUmurValue.Font = New Font("Segoe UI", 9F)
        lblUmurValue.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblUmurValue.Location = New Point(590, 143)
        lblUmurValue.Name = "lblUmurValue"
        lblUmurValue.Size = New Size(170, 18)
        lblUmurValue.TabIndex = 8
        ' 
        ' lblTanggalLahirKey
        ' 
        lblTanggalLahirKey.BackColor = Color.Transparent
        lblTanggalLahirKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTanggalLahirKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblTanggalLahirKey.Location = New Point(450, 181)
        lblTanggalLahirKey.Name = "lblTanggalLahirKey"
        lblTanggalLahirKey.Size = New Size(130, 18)
        lblTanggalLahirKey.TabIndex = 9
        lblTanggalLahirKey.Text = "Tanggal Lahir"
        ' 
        ' lblTanggalLahirValue
        ' 
        lblTanggalLahirValue.BackColor = Color.Transparent
        lblTanggalLahirValue.Font = New Font("Segoe UI", 9F)
        lblTanggalLahirValue.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblTanggalLahirValue.Location = New Point(590, 181)
        lblTanggalLahirValue.Name = "lblTanggalLahirValue"
        lblTanggalLahirValue.Size = New Size(170, 18)
        lblTanggalLahirValue.TabIndex = 10
        ' 
        ' lblJenisKelaminKey
        ' 
        lblJenisKelaminKey.BackColor = Color.Transparent
        lblJenisKelaminKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJenisKelaminKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblJenisKelaminKey.Location = New Point(450, 219)
        lblJenisKelaminKey.Name = "lblJenisKelaminKey"
        lblJenisKelaminKey.Size = New Size(130, 18)
        lblJenisKelaminKey.TabIndex = 11
        lblJenisKelaminKey.Text = "Jenis Kelamin"
        ' 
        ' lblJenisKelaminValue
        ' 
        lblJenisKelaminValue.BackColor = Color.Transparent
        lblJenisKelaminValue.Font = New Font("Segoe UI", 9F)
        lblJenisKelaminValue.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblJenisKelaminValue.Location = New Point(590, 219)
        lblJenisKelaminValue.Name = "lblJenisKelaminValue"
        lblJenisKelaminValue.Size = New Size(170, 18)
        lblJenisKelaminValue.TabIndex = 12
        ' 
        ' lblNoTelponKey
        ' 
        lblNoTelponKey.BackColor = Color.Transparent
        lblNoTelponKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNoTelponKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblNoTelponKey.Location = New Point(450, 257)
        lblNoTelponKey.Name = "lblNoTelponKey"
        lblNoTelponKey.Size = New Size(130, 18)
        lblNoTelponKey.TabIndex = 13
        lblNoTelponKey.Text = "No. Telepon"
        ' 
        ' lblNoTelponValue
        ' 
        lblNoTelponValue.BackColor = Color.Transparent
        lblNoTelponValue.Font = New Font("Segoe UI", 9F)
        lblNoTelponValue.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblNoTelponValue.Location = New Point(590, 257)
        lblNoTelponValue.Name = "lblNoTelponValue"
        lblNoTelponValue.Size = New Size(170, 18)
        lblNoTelponValue.TabIndex = 14
        ' 
        ' lblHobbyKey
        ' 
        lblHobbyKey.BackColor = Color.Transparent
        lblHobbyKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblHobbyKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblHobbyKey.Location = New Point(450, 295)
        lblHobbyKey.Name = "lblHobbyKey"
        lblHobbyKey.Size = New Size(130, 18)
        lblHobbyKey.TabIndex = 15
        lblHobbyKey.Text = "Hobby"
        ' 
        ' lblHobbyValue
        ' 
        lblHobbyValue.BackColor = Color.Transparent
        lblHobbyValue.Font = New Font("Segoe UI", 8F)
        lblHobbyValue.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblHobbyValue.Location = New Point(590, 295)
        lblHobbyValue.Name = "lblHobbyValue"
        lblHobbyValue.Size = New Size(170, 36)
        lblHobbyValue.TabIndex = 16
        ' 
        ' lblAlamatKey
        ' 
        lblAlamatKey.BackColor = Color.Transparent
        lblAlamatKey.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAlamatKey.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        lblAlamatKey.Location = New Point(450, 343)
        lblAlamatKey.Name = "lblAlamatKey"
        lblAlamatKey.Size = New Size(130, 18)
        lblAlamatKey.TabIndex = 17
        lblAlamatKey.Text = "Alamat"
        ' 
        ' lblAlamatValue
        ' 
        lblAlamatValue.BackColor = Color.Transparent
        lblAlamatValue.Font = New Font("Segoe UI", 8F)
        lblAlamatValue.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblAlamatValue.Location = New Point(590, 343)
        lblAlamatValue.Name = "lblAlamatValue"
        lblAlamatValue.Size = New Size(170, 36)
        lblAlamatValue.TabIndex = 18
        ' 
        ' panelGaris
        ' 
        panelGaris.BackColor = Color.FromArgb(CByte(220), CByte(30), CByte(30))
        panelGaris.Location = New Point(453, 101)
        panelGaris.Name = "panelGaris"
        panelGaris.Size = New Size(310, 2)
        panelGaris.TabIndex = 4
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderColor = Color.White
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(67, 335)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(140, 36)
        btnKembali.TabIndex = 19
        btnKembali.Text = "← Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' lblMember
        ' 
        lblMember.BackColor = Color.FromArgb(CByte(180), CByte(0), CByte(0))
        lblMember.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblMember.ForeColor = Color.White
        lblMember.Location = New Point(60, 49)
        lblMember.Name = "lblMember"
        lblMember.Size = New Size(157, 41)
        lblMember.TabIndex = 1
        lblMember.Text = "MEMBER"
        lblMember.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(picProfilHasil)
        Controls.Add(lblMember)
        Controls.Add(panelGaris)
        Controls.Add(lblNamaKey)
        Controls.Add(lblNamaValue)
        Controls.Add(lblUmurKey)
        Controls.Add(lblUmurValue)
        Controls.Add(lblTanggalLahirKey)
        Controls.Add(lblTanggalLahirValue)
        Controls.Add(lblJenisKelaminKey)
        Controls.Add(lblJenisKelaminValue)
        Controls.Add(lblNoTelponKey)
        Controls.Add(lblNoTelponValue)
        Controls.Add(lblHobbyKey)
        Controls.Add(lblHobbyValue)
        Controls.Add(lblAlamatKey)
        Controls.Add(lblAlamatValue)
        Controls.Add(btnKembali)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Anggota Komunitas"
        CType(picProfilHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' Deklarasi semua kontrol
    Friend WithEvents picProfilHasil As System.Windows.Forms.PictureBox
    Friend WithEvents lblNamaKey As System.Windows.Forms.Label
    Friend WithEvents lblNamaValue As System.Windows.Forms.Label
    Friend WithEvents lblUmurKey As System.Windows.Forms.Label
    Friend WithEvents lblUmurValue As System.Windows.Forms.Label
    Friend WithEvents lblTanggalLahirKey As System.Windows.Forms.Label
    Friend WithEvents lblTanggalLahirValue As System.Windows.Forms.Label
    Friend WithEvents lblJenisKelaminKey As System.Windows.Forms.Label
    Friend WithEvents lblJenisKelaminValue As System.Windows.Forms.Label
    Friend WithEvents lblNoTelponKey As System.Windows.Forms.Label
    Friend WithEvents lblNoTelponValue As System.Windows.Forms.Label
    Friend WithEvents lblHobbyKey As System.Windows.Forms.Label
    Friend WithEvents lblHobbyValue As System.Windows.Forms.Label
    Friend WithEvents lblAlamatKey As System.Windows.Forms.Label
    Friend WithEvents lblAlamatValue As System.Windows.Forms.Label
    Friend WithEvents panelGaris As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents lblMember As System.Windows.Forms.Label

End Class