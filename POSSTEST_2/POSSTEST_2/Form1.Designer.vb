<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpTambahBuku = New GroupBox()
        btnTambah = New Button()
        txtGenre = New TextBox()
        lblGenre = New Label()
        txtJudulBuku = New TextBox()
        lblJudulBuku1 = New Label()
        grpHapusBuku = New GroupBox()
        btnHapus = New Button()
        txtJudulBukuHapus = New TextBox()
        lblJudulBuku2 = New Label()
        lstDaftarBuku = New ListBox()
        grpTambahBuku.SuspendLayout()
        grpHapusBuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpTambahBuku
        ' 
        grpTambahBuku.Controls.Add(btnTambah)
        grpTambahBuku.Controls.Add(txtGenre)
        grpTambahBuku.Controls.Add(lblGenre)
        grpTambahBuku.Controls.Add(txtJudulBuku)
        grpTambahBuku.Controls.Add(lblJudulBuku1)
        grpTambahBuku.Location = New Point(27, 31)
        grpTambahBuku.Margin = New Padding(4, 5, 4, 5)
        grpTambahBuku.Name = "grpTambahBuku"
        grpTambahBuku.Padding = New Padding(4, 5, 4, 5)
        grpTambahBuku.Size = New Size(480, 369)
        grpTambahBuku.TabIndex = 0
        grpTambahBuku.TabStop = False
        grpTambahBuku.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(160, 185)
        btnTambah.Margin = New Padding(4, 5, 4, 5)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(133, 46)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(160, 118)
        txtGenre.Margin = New Padding(4, 5, 4, 5)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(292, 27)
        txtGenre.TabIndex = 3
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(27, 123)
        lblGenre.Margin = New Padding(4, 0, 4, 0)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(48, 20)
        lblGenre.TabIndex = 2
        lblGenre.Text = "Genre"
        ' 
        ' txtJudulBuku
        ' 
        txtJudulBuku.Location = New Point(160, 57)
        txtJudulBuku.Margin = New Padding(4, 5, 4, 5)
        txtJudulBuku.Name = "txtJudulBuku"
        txtJudulBuku.Size = New Size(292, 27)
        txtJudulBuku.TabIndex = 1
        ' 
        ' lblJudulBuku1
        ' 
        lblJudulBuku1.AutoSize = True
        lblJudulBuku1.Location = New Point(27, 62)
        lblJudulBuku1.Margin = New Padding(4, 0, 4, 0)
        lblJudulBuku1.Name = "lblJudulBuku1"
        lblJudulBuku1.Size = New Size(79, 20)
        lblJudulBuku1.TabIndex = 0
        lblJudulBuku1.Text = "Judul Buku"
        ' 
        ' grpHapusBuku
        ' 
        grpHapusBuku.Controls.Add(btnHapus)
        grpHapusBuku.Controls.Add(txtJudulBukuHapus)
        grpHapusBuku.Controls.Add(lblJudulBuku2)
        grpHapusBuku.Location = New Point(533, 31)
        grpHapusBuku.Margin = New Padding(4, 5, 4, 5)
        grpHapusBuku.Name = "grpHapusBuku"
        grpHapusBuku.Padding = New Padding(4, 5, 4, 5)
        grpHapusBuku.Size = New Size(480, 369)
        grpHapusBuku.TabIndex = 1
        grpHapusBuku.TabStop = False
        grpHapusBuku.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(160, 123)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(133, 46)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtJudulBukuHapus
        ' 
        txtJudulBukuHapus.Location = New Point(160, 57)
        txtJudulBukuHapus.Margin = New Padding(4, 5, 4, 5)
        txtJudulBukuHapus.Name = "txtJudulBukuHapus"
        txtJudulBukuHapus.Size = New Size(292, 27)
        txtJudulBukuHapus.TabIndex = 1
        ' 
        ' lblJudulBuku2
        ' 
        lblJudulBuku2.AutoSize = True
        lblJudulBuku2.Location = New Point(27, 62)
        lblJudulBuku2.Margin = New Padding(4, 0, 4, 0)
        lblJudulBuku2.Name = "lblJudulBuku2"
        lblJudulBuku2.Size = New Size(79, 20)
        lblJudulBuku2.TabIndex = 0
        lblJudulBuku2.Text = "Judul Buku"
        ' 
        ' lstDaftarBuku
        ' 
        lstDaftarBuku.FormattingEnabled = True
        lstDaftarBuku.Location = New Point(27, 431)
        lstDaftarBuku.Margin = New Padding(4, 5, 4, 5)
        lstDaftarBuku.Name = "lstDaftarBuku"
        lstDaftarBuku.Size = New Size(985, 444)
        lstDaftarBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1045, 909)
        Controls.Add(lstDaftarBuku)
        Controls.Add(grpHapusBuku)
        Controls.Add(grpTambahBuku)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Posttest 2 - Perpustakaan"
        grpTambahBuku.ResumeLayout(False)
        grpTambahBuku.PerformLayout()
        grpHapusBuku.ResumeLayout(False)
        grpHapusBuku.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpTambahBuku As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents lblJudulBuku1 As Label
    Friend WithEvents grpHapusBuku As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtJudulBukuHapus As TextBox
    Friend WithEvents lblJudulBuku2 As Label
    Friend WithEvents lstDaftarBuku As ListBox
End Class