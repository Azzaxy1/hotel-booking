<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHotelBooking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label9 = New Label()
        GroupBox3 = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        txtTotalHarga = New TextBox()
        txtHarga = New TextBox()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        txtLamaInap = New TextBox()
        Label7 = New Label()
        txtJumlahOrang = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtNoKamar = New TextBox()
        cboJenisKamar = New ComboBox()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        txtNoTelepon = New TextBox()
        Label1 = New Label()
        txtNama = New TextBox()
        btnExit = New Button()
        GroupBox4 = New GroupBox()
        btnClear = New Button()
        btnLihatLaporan = New Button()
        btnSimpan = New Button()
        btnHitungTotal = New Button()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(238, 4)
        Label9.Name = "Label9"
        Label9.Size = New Size(325, 32)
        Label9.TabIndex = 24
        Label9.Text = "BOOKING HOTEL HORIZON"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(txtTotalHarga)
        GroupBox3.Controls.Add(txtHarga)
        GroupBox3.Location = New Point(443, 46)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(271, 114)
        GroupBox3.TabIndex = 32
        GroupBox3.TabStop = False
        GroupBox3.Text = "Data Pembelian"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 15
        Label6.Text = "Total Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 14
        Label5.Text = "Harga"
        ' 
        ' txtTotalHarga
        ' 
        txtTotalHarga.Location = New Point(113, 68)
        txtTotalHarga.Name = "txtTotalHarga"
        txtTotalHarga.Size = New Size(140, 23)
        txtTotalHarga.TabIndex = 13
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(113, 39)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(140, 23)
        txtHarga.TabIndex = 12
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtLamaInap)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtJumlahOrang)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtNoKamar)
        GroupBox2.Controls.Add(cboJenisKamar)
        GroupBox2.Location = New Point(66, 149)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(310, 168)
        GroupBox2.TabIndex = 31
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Booking"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(19, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 15)
        Label8.TabIndex = 24
        Label8.Text = "Lama Inap (Hari)"
        ' 
        ' txtLamaInap
        ' 
        txtLamaInap.Location = New Point(121, 119)
        txtLamaInap.Name = "txtLamaInap"
        txtLamaInap.Size = New Size(172, 23)
        txtLamaInap.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 15)
        Label7.TabIndex = 22
        Label7.Text = "Jumlah Orang"
        ' 
        ' txtJumlahOrang
        ' 
        txtJumlahOrang.Location = New Point(121, 90)
        txtJumlahOrang.Name = "txtJumlahOrang"
        txtJumlahOrang.Size = New Size(172, 23)
        txtJumlahOrang.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 13
        Label4.Text = "No Kamar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 12
        Label3.Text = "Jenis Kamar"
        ' 
        ' txtNoKamar
        ' 
        txtNoKamar.Location = New Point(121, 58)
        txtNoKamar.Name = "txtNoKamar"
        txtNoKamar.Size = New Size(172, 23)
        txtNoKamar.TabIndex = 11
        ' 
        ' cboJenisKamar
        ' 
        cboJenisKamar.FormattingEnabled = True
        cboJenisKamar.Items.AddRange(New Object() {"Standar", "Deluxe", "Junior Suite", "Executive"})
        cboJenisKamar.Location = New Point(121, 29)
        cboJenisKamar.Name = "cboJenisKamar"
        cboJenisKamar.Size = New Size(172, 23)
        cboJenisKamar.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNoTelepon)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Location = New Point(66, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(310, 92)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Pembeli"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 10
        Label2.Text = "No Telepon"
        ' 
        ' txtNoTelepon
        ' 
        txtNoTelepon.Location = New Point(117, 56)
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.Size = New Size(176, 23)
        txtNoTelepon.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 8
        Label1.Text = "Nama Pembeli"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(117, 26)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(176, 23)
        txtNama.TabIndex = 7
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(529, 304)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(101, 23)
        btnExit.TabIndex = 27
        btnExit.Text = "Keluar Aplikasi"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnClear)
        GroupBox4.Controls.Add(btnLihatLaporan)
        GroupBox4.Controls.Add(btnSimpan)
        GroupBox4.Controls.Add(btnHitungTotal)
        GroupBox4.Location = New Point(443, 181)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(271, 112)
        GroupBox4.TabIndex = 33
        GroupBox4.TabStop = False
        GroupBox4.Text = "Manage Data"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(172, 61)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(92, 23)
        btnClear.TabIndex = 33
        btnClear.Text = "Hapus Input"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnLihatLaporan
        ' 
        btnLihatLaporan.Location = New Point(13, 63)
        btnLihatLaporan.Name = "btnLihatLaporan"
        btnLihatLaporan.Size = New Size(153, 23)
        btnLihatLaporan.TabIndex = 32
        btnLihatLaporan.Text = "Lihat Laporan Pemesanan"
        btnLihatLaporan.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(154, 25)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(110, 23)
        btnSimpan.TabIndex = 31
        btnSimpan.Text = "Simpan Transaksi"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHitungTotal
        ' 
        btnHitungTotal.Location = New Point(44, 26)
        btnHitungTotal.Name = "btnHitungTotal"
        btnHitungTotal.Size = New Size(85, 23)
        btnHitungTotal.TabIndex = 30
        btnHitungTotal.Text = "Hitung Total"
        btnHitungTotal.UseVisualStyleBackColor = True
        ' 
        ' FormHotelBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 359)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnExit)
        Controls.Add(Label9)
        Name = "FormHotelBooking"
        Text = "FormHotelBooking"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLamaInap As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtJumlahOrang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoKamar As TextBox
    Friend WithEvents cboJenisKamar As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnLihatLaporan As Button
    Friend WithEvents btnHitungTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSimpan As Button

End Class
