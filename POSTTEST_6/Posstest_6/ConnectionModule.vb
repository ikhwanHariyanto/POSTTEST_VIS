Imports MySqlConnector

Module ConnectionModule

    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=dbkamenrider;User ID=root;Password=;"

    ''' <summary>
    ''' Mengembalikan objek MySqlConnection baru.
    ''' Selalu gunakan dalam blok Using agar koneksi otomatis ditutup.
    ''' </summary>
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    ''' <summary>
    ''' Mengecek apakah koneksi ke database berhasil.
    ''' Berguna untuk test koneksi saat Form_Load.
    ''' </summary>
    Public Function TestKoneksi() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            MsgBox("Gagal terhubung ke database!" & vbNewLine & vbNewLine &
                   "Pastikan:" & vbNewLine &
                   "  1. XAMPP sudah dijalankan (Apache + MySQL)" & vbNewLine &
                   "  2. Database 'dbkamenrider' sudah dibuat" & vbNewLine & vbNewLine &
                   "Detail error: " & ex.Message,
                   MsgBoxStyle.Critical, "Koneksi Gagal")
            Return False
        End Try
    End Function

End Module