Imports MySqlConnector

Module DataModule

    ' ===========================================================
    '  TBKOLEKSI - CRUD
    ' ===========================================================

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
            MsgBox("Gagal menampilkan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

    Public Function SearchKoleksi(keyword As String, searchBy As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim kolomDB As String
            Select Case searchBy
                Case "Nama Item" : kolomDB = "nama_item"
                Case "Seri"      : kolomDB = "seri"
                Case "Tipe"      : kolomDB = "tipe"
                Case "Kondisi"   : kolomDB = "kondisi"
                Case "Status"    : kolomDB = "status"
                Case Else        : kolomDB = "nama_item"
            End Select
            Dim query As String =
                "SELECT id, nama_item, seri, tipe, harga, kondisi, status, tahun_rilis, deskripsi " &
                "FROM tbkoleksi WHERE " & kolomDB & " LIKE @keyword ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal mencari data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

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
            MsgBox("Gagal mengambil data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Nothing
    End Function

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
            MsgBox("Gagal menyimpan data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

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
            MsgBox("Gagal mengubah data: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

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
            MsgBox("Gagal menghapus data: " & ex.Message, MsgBoxStyle.Critical, "Error")
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

    ' ===========================================================
    '  TBTRANSAKSI - CRUD (Tabel Relasi dengan tbkoleksi)
    ' ===========================================================

    Public Function GetAllTransaksi() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.id, k.nama_item, t.jenis_transaksi, t.harga_transaksi, " &
                "t.tanggal, t.nama_penjual, t.nama_pembeli, t.catatan, t.koleksi_id " &
                "FROM tbtransaksi t " &
                "INNER JOIN tbkoleksi k ON t.koleksi_id = k.id " &
                "ORDER BY t.tanggal DESC, t.id DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal menampilkan transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

    Public Function GetTransaksiByKoleksi(koleksiId As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT t.id, k.nama_item, t.jenis_transaksi, t.harga_transaksi, " &
                "t.tanggal, t.nama_penjual, t.nama_pembeli, t.catatan " &
                "FROM tbtransaksi t " &
                "INNER JOIN tbkoleksi k ON t.koleksi_id = k.id " &
                "WHERE t.koleksi_id = @kid ORDER BY t.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kid", koleksiId)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

    Public Function SimpanTransaksi(koleksiId As Integer, jenis As String, harga As Long,
                                     tanggal As Date, penjual As String, pembeli As String,
                                     catatan As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbtransaksi (koleksi_id, jenis_transaksi, harga_transaksi, " &
                "tanggal, nama_penjual, nama_pembeli, catatan) " &
                "VALUES (@kid, @jenis, @harga, @tgl, @penjual, @pembeli, @catatan)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kid", koleksiId)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@penjual", penjual)
                    cmd.Parameters.AddWithValue("@pembeli", pembeli)
                    cmd.Parameters.AddWithValue("@catatan", catatan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Gagal menyimpan transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function UbahTransaksi(id As Integer, koleksiId As Integer, jenis As String,
                                   harga As Long, tanggal As Date, penjual As String,
                                   pembeli As String, catatan As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbtransaksi SET koleksi_id=@kid, jenis_transaksi=@jenis, " &
                "harga_transaksi=@harga, tanggal=@tgl, nama_penjual=@penjual, " &
                "nama_pembeli=@pembeli, catatan=@catatan WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@kid", koleksiId)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@penjual", penjual)
                    cmd.Parameters.AddWithValue("@pembeli", pembeli)
                    cmd.Parameters.AddWithValue("@catatan", catatan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengubah transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function HapusTransaksi(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tbtransaksi WHERE id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal menghapus transaksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function GetKoleksiForCombo() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT id, nama_item FROM tbkoleksi ORDER BY nama_item ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal memuat data koleksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function

End Module
