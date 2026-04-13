Imports MySqlConnector

Module DataModule

    ''' <summary>
    ''' Mengambil semua data koleksi dari database.
    ''' </summary>
    Public Function GetAllKoleksi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, nama_item, seri, tipe, harga, kondisi, status, tahun_rilis, deskripsi " &
                "FROM tbkoleksi ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message,
                   MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' Mencari koleksi berdasarkan keyword dan kolom tertentu.
    ''' </summary>
    Public Function SearchKoleksi(keyword As String, searchBy As String) As DataTable
        Dim dt As New DataTable()
        Try
            ' Mapping nama kolom dari UI ke nama kolom di database
            Dim kolomDB As String
            Select Case searchBy
                Case "Nama Item" : kolomDB = "nama_item"
                Case "Seri" : kolomDB = "seri"
                Case "Tipe" : kolomDB = "tipe"
                Case "Kondisi" : kolomDB = "kondisi"
                Case "Status" : kolomDB = "status"
                Case Else : kolomDB = "nama_item"
            End Select

            Dim query As String =
                "SELECT id, nama_item, seri, tipe, harga, kondisi, status, tahun_rilis, deskripsi " &
                "FROM tbkoleksi " &
                "WHERE " & kolomDB & " LIKE @keyword " &
                "ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal mencari data: " & ex.Message,
                   MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' Mengambil satu baris data berdasarkan ID.
    ''' </summary>
    Public Function GetKoleksiByID(id As Integer) As DataRow
        Try
            Dim query As String =
                "SELECT id, nama_item, seri, tipe, harga, kondisi, status, tahun_rilis, deskripsi " &
                "FROM tbkoleksi WHERE id = @id"

            Dim dt As New DataTable()
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

            If dt.Rows.Count > 0 Then Return dt.Rows(0)

        Catch ex As Exception
            MsgBox("Gagal mengambil data: " & ex.Message,
                   MsgBoxStyle.Critical, "Error")
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Menyimpan data koleksi baru ke database.
    ''' Mengembalikan True jika berhasil.
    ''' </summary>
    Public Function SimpanKoleksi(nama As String, seri As String, tipe As String,
                                   harga As Long, kondisi As String, status As String,
                                   tahun As Integer, deskripsi As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbkoleksi (nama_item, seri, tipe, harga, kondisi, status, tahun_rilis, deskripsi) " &
                "VALUES (@nama, @seri, @tipe, @harga, @kondisi, @status, @tahun, @deskripsi)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@seri", seri)
                    cmd.Parameters.AddWithValue("@tipe", tipe)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@kondisi", kondisi)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message,
                   MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Mengubah data koleksi yang sudah ada berdasarkan ID.
    ''' Mengembalikan True jika berhasil.
    ''' </summary>
    Public Function UbahKoleksi(id As Integer, nama As String, seri As String, tipe As String,
                                 harga As Long, kondisi As String, status As String,
                                 tahun As Integer, deskripsi As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbkoleksi SET " &
                "nama_item = @nama, seri = @seri, tipe = @tipe, harga = @harga, " &
                "kondisi = @kondisi, status = @status, tahun_rilis = @tahun, deskripsi = @deskripsi " &
                "WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@seri", seri)
                    cmd.Parameters.AddWithValue("@tipe", tipe)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@kondisi", kondisi)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal mengubah data: " & ex.Message,
                   MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Menghapus data koleksi berdasarkan ID.
    ''' Mengembalikan True jika berhasil.
    ''' </summary>
    Public Function HapusKoleksi(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbkoleksi WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal menghapus data: " & ex.Message,
                   MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function HitungTotal() As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbkoleksi", conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch
            Return 0
        End Try
    End Function

End Module