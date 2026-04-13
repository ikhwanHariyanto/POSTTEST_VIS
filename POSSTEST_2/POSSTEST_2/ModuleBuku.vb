Public Module ModuleBuku

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    Public Sub HapusBuku(ByRef judulBuku As String, ByRef berhasilDihapus As Boolean)
        berhasilDihapus = False
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judulBuku.ToLower() Then
                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)
                Next j

                daftarBuku(jumlahBuku - 1, 0) = ""
                daftarBuku(jumlahBuku - 1, 1) = ""

                jumlahBuku -= 1
                berhasilDihapus = True
                Exit For
            End If
        Next i
    End Sub

    Public Function FormatBuku(ByVal judul As String, ByVal genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    Public Function CekBukuAda(ByVal judul As String) As Boolean
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return True
            End If
        Next i
        Return False
    End Function

End Module