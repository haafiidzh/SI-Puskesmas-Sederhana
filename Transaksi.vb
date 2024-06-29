Imports System.Data.Odbc

Public Class Transaksi
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=project_uas"
        con.Open()
    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "insert into transaksi values('" & id.Text & "','" & nama_pasien.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & nama_dokter.Text & "','" & jtindakan.Text & "','" & htindakan.Text & "','" & nama_obat.Text & "','" & jml.Text & "','" & total_obat.Text & "','" & total_biaya.Text & "','" & username.Text & "' )"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampiladmin()
        koneksi()
        cmd = New OdbcCommand("select username from admin", con)
        dr = cmd.ExecuteReader
        username.Text = ""
        Do While dr.Read
            username.Text = dr.Item("username")
        Loop
    End Sub

    Sub tampilobat()
        koneksi()
        cmd = New OdbcCommand("select nama_obat from obat", con)
        dr = cmd.ExecuteReader
        nama_obat.Items.Clear()
        Do While dr.Read
            nama_obat.Items.Add(dr.Item("nama_obat"))
        Loop
    End Sub

    Sub hargaobat()
        koneksi()
        cmd = New OdbcCommand("select * from obat where nama_obat = '" & nama_obat.Text & "' ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            harga_obat.Text = dr.Item("harga_obat")
        ElseIf nama_obat.Text = "-" Then
            harga_obat.Text = "0"
        End If
    End Sub

    Sub tampilpasien()
        koneksi()
        cmd = New OdbcCommand("select * from pasien where id_pasien = '" & id.Text & "' ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            nama_pasien.Text = dr.Item("nama_pasien")
            nama_dokter.Text = dr.Item("nama_dokter")
            poli.Text = dr.Item("poli")
            jenis_pasien.Text = dr.Item("jenis_pasien")
            status_pasien.Text = dr.Item("status_pasien")
        End If
    End Sub

    Private Sub Transaksi_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
      (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub YA_CheckedChanged(sender As Object, e As EventArgs) Handles YA.CheckedChanged
        If poli.Text = "Gigi" Then
            jtindakan.Items.Clear()
            jtindakan.Items.Add("Cabut gigi susu")
            jtindakan.Items.Add("Cabut gigi tetap tanpa penyulit")
            jtindakan.Items.Add("Trepanasi gigi")
            jtindakan.Items.Add("Tumpatan sementara")
            jtindakan.Items.Add("Tambalan tetap")
            jtindakan.Items.Add("Pembersihan karang gigi/rahang")
        ElseIf poli.Text = "Umum" Then
            jtindakan.Items.Clear()
            jtindakan.Items.Add("Debridemen")
            jtindakan.Items.Add("Jahit Luka")
            jtindakan.Items.Add("Mengeluarkan benda asing hidung/telinga/mata")
            jtindakan.Items.Add("Cabut kuku")
            jtindakan.Items.Add("Angkat jahit")
        ElseIf poli.Text = "Lansia" Then
            jtindakan.Items.Clear()
            jtindakan.Items.Add("Debridemen")
            jtindakan.Items.Add("Jahit Luka")
            jtindakan.Items.Add("Mengeluarkan benda asing hidung/telinga/mata")
            jtindakan.Items.Add("Cabut kuku")
            jtindakan.Items.Add("Angkat jahit")
        ElseIf poli.Text = "KIA" Then
            jtindakan.Items.Clear()
            jtindakan.Items.Add("Tindik Bayi")
            jtindakan.Items.Add("Debridemen")
        ElseIf poli.Text = "KB" Then
            jtindakan.Items.Clear()
            jtindakan.Items.Add("KB Suntik")
            jtindakan.Items.Add("Pasang IUD")
            jtindakan.Items.Add("Lepas Pasang IUD")
        End If
    End Sub

    Private Sub TIDAK_CheckedChanged(sender As Object, e As EventArgs) Handles TIDAK.CheckedChanged
        jtindakan.Text = ""
        jtindakan.Items.Clear()
        htindakan.Text = "0"
    End Sub

    Private Sub jtindakan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jtindakan.SelectedIndexChanged
        If jtindakan.Text = "Debridemen" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "Jahit Luka" Then
            htindakan.Text = "30000"
        ElseIf jtindakan.Text = "Mengeluarkan benda asing hidung/telinga/mata" Then
            htindakan.Text = "30000"
        ElseIf jtindakan.Text = "Cabut kuku" Then
            htindakan.Text = "30000"
        ElseIf jtindakan.Text = "Angkat jahit" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "Cabut gigi susu" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "Cabut gigi tetap tanpa penyulit" Then
            htindakan.Text = "50000"
        ElseIf jtindakan.Text = "Trepanasi gigi" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "Tumpatan sementara" Then
            htindakan.Text = "20000"
        ElseIf jtindakan.Text = "Tambalan tetap" Then
            htindakan.Text = "20000"
        ElseIf jtindakan.Text = "Pembersihan karang gigi/rahang" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "Tindik Bayi" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "Debridemen" Then
            htindakan.Text = "10000"
        ElseIf jtindakan.Text = "KB Suntik" Then
            htindakan.Text = "7500"
        ElseIf jtindakan.Text = "Pasang IUD" Then
            htindakan.Text = "50000"
        ElseIf jtindakan.Text = "Lepas Pasang IUD" Then
            htindakan.Text = "75000"
        End If
    End Sub

    Private Sub nama_obat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nama_obat.SelectedIndexChanged
        hargaobat()
        If nama_obat.Text = "-" Then
            jml.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tobat As Single
        Dim jmlah As Integer
        Dim totall As Single
        Dim tdaftar As Single
        Dim ttindakan As Single
        Dim ttotal_biaya As Single

        tobat = harga_obat.Text
        jmlah = jml.Text
        tdaftar = pendaftaran.Text
        ttindakan = htindakan.Text

        totall = tobat * jmlah
        total_obat.Text = totall

        ttotal_biaya = tdaftar + totall + ttindakan
        total_biaya.Text = ttotal_biaya

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a
        a = MessageBox.Show("Apakah Anda yakin untuk melakukan transaksi ini?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If a = vbOK Then
            simpan()
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampiladmin()
        tampilpasien()
        tampilobat()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a
        a = MessageBox.Show("Apakah Anda yakin untuk membatalkan transaksi?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If a = vbOK Then
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub

End Class