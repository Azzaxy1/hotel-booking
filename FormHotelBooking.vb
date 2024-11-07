Public Class FormHotelBooking
    ' Mendeklarasikan variabel untuk menyimpan harga berdasarkan jenis kamar
    Private hargaStandar As Integer = 500000
    Private hargaDeluxe As Integer = 800000
    Private hargaJuniorSuite As Integer = 1200000
    Private hargaExecutive As Integer = 2000000

    ' List untuk menyimpan laporan booking
    Private daftarBooking As New List(Of String)

    ' Event untuk mengisi harga berdasarkan jenis kamar yang dipilih
    Private Sub cboJenisKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenisKamar.SelectedIndexChanged
        ' Cek apakah ComboBox memiliki item yang dipilih
        If cboJenisKamar.SelectedItem IsNot Nothing Then
            Select Case cboJenisKamar.SelectedItem.ToString()
                Case "Standar"
                    txtHarga.Text = hargaStandar.ToString()
                Case "Deluxe"
                    txtHarga.Text = hargaDeluxe.ToString()
                Case "Junior Suite"
                    txtHarga.Text = hargaJuniorSuite.ToString()
                Case "Executive"
                    txtHarga.Text = hargaExecutive.ToString()
                Case Else
                    txtHarga.Text = "" ' Kosongkan jika pilihan tidak valid
            End Select
        Else
            txtHarga.Text = "" ' Kosongkan jika tidak ada pilihan
        End If
    End Sub


    ' Event untuk menghitung total harga
    Private Sub btnHitungTotal_Click(sender As Object, e As EventArgs) Handles btnHitungTotal.Click
        ' Validasi input
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
       String.IsNullOrWhiteSpace(txtNoTelepon.Text) OrElse
       cboJenisKamar.SelectedIndex = -1 OrElse
       String.IsNullOrWhiteSpace(txtNoKamar.Text) OrElse
       String.IsNullOrWhiteSpace(txtHarga.Text) OrElse
       String.IsNullOrWhiteSpace(txtLamaInap.Text) OrElse
       String.IsNullOrWhiteSpace(txtJumlahOrang.Text) Then
            MessageBox.Show("Harap isi semua data dengan lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hargaKamar As Integer
        Dim lamaInap As Integer

        ' Cek apakah input bisa dikonversi ke integer
        If Integer.TryParse(txtHarga.Text, hargaKamar) AndAlso Integer.TryParse(txtLamaInap.Text, lamaInap) Then
            Dim totalHarga = hargaKamar * lamaInap
            txtTotalHarga.Text = totalHarga.ToString
        Else
            MessageBox.Show("Silakan masukkan input yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Event untuk menyimpan data booking
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text <> "" And txtNoTelepon.Text <> "" And cboJenisKamar.SelectedIndex >= 0 And txtNoKamar.Text <> "" And txtTotalHarga.Text <> "" And txtJumlahOrang.Text <> "" And txtLamaInap.Text <> "" Then
            Dim laporan As String = $"Nama: {txtNama.Text}, No Telepon: {txtNoTelepon.Text}, Jenis Kamar: {cboJenisKamar.SelectedItem}, No Kamar: {txtNoKamar.Text}, Jumlah Orang: {txtJumlahOrang.Text}, Lama Inap: {txtLamaInap.Text} malam, Total Harga: Rp {txtTotalHarga.Text}"
            daftarBooking.Add(laporan)
            MessageBox.Show("Data booking berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Harap isi semua data dengan lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    ' Event untuk menampilkan semua data laporan booking
    Private Sub btnLihatLaporan_Click(sender As Object, e As EventArgs) Handles btnLihatLaporan.Click
        Dim laporan = String.Join(Environment.NewLine, daftarBooking)
        If laporan <> "" Then
            MessageBox.Show(laporan, "Laporan Booking", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Belum ada data booking.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, btnClear.Click
        txtNama.Text = ""
        txtNoTelepon.Text = ""
        cboJenisKamar.SelectedIndex = -1
        txtNoKamar.Text = ""
        txtJumlahOrang.Text = ""
        txtLamaInap.Text = ""
        txtHarga.Text = ""
        txtTotalHarga.Text = ""
    End Sub

    ' Event untuk keluar dari aplikasi
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
