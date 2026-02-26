Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Dim maxSemester As Integer = 14

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double

        If jumlahSemester >= maxSemester Then
            MessageBox.Show("Maksimal 14 semester telah tercapai! Klik Reset untuk mengulang.", "Batas Semester", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIPSemester.Enabled = False
            btnTambah.Enabled = False
            Exit Sub
        End If

        If Double.TryParse(txtIPSemester.Text, ipSemester) Then
            If ipSemester < 0 Or ipSemester > 4 Then
                MessageBox.Show("//IP Semester harus antara 0 dan 4 !!!\\")
                Exit Sub
            End If

            totalIP += ipSemester
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester
            txtIPKumulatif.Text = Math.Round(ipk, 2).ToString("0.00")

            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan (gachor lee)"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan (beh dikit lagi gachor)"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup (waduh)"
            Else
                lblPredikat.Text = "Di Bawah Standar (kebanyakan main ML)"
            End If

            lstHistory.Items.Add("Semester " & jumlahSemester & " | IP: " & ipSemester.ToString("0.00"))

            lstHistory.TopIndex = lstHistory.Items.Count - 1

            If jumlahSemester >= maxSemester Then
                MessageBox.Show("Semester 14 telah diinput. Tidak bisa menambah lagi!", "Batas Tercapai", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtIPSemester.Enabled = False
                btnTambah.Enabled = False
            End If

            txtIPSemester.Clear()
            txtIPSemester.Focus()
        Else
            MessageBox.Show("Input harus berupa angka!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPSemester.Clear()
        txtIPKumulatif.Clear()
        lblPredikat.Text = ""
        lstHistory.Items.Clear()
        txtIPSemester.Enabled = True
        btnTambah.Enabled = True
        txtIPSemester.Focus()
    End Sub
End Class