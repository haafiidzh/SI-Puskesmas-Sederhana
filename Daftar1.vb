Imports System.Data.Odbc

Public Class Daftar1
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Dim gender As String
    Dim jpasien As String
    Dim status As String

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=project_uas"
        con.Open()
    End Sub

    Sub tampildokter()
        koneksi()
        cmd = New OdbcCommand("select nama_dokter from dokter", con)
        dr = cmd.ExecuteReader
        nama_dokter.Items.Clear()
        Do While dr.Read
            nama_dokter.Items.Add(dr.Item("nama_dokter"))
        Loop
    End Sub

    Private Sub Daftar_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "insert into pasien values('" & id.Text & "','" & nama_pasien.Text & "','" & alamat.Text & "','" & ttl.Text & "','" & gender & "','" & keluhan.Text & "','" & nama_dokter.Text & "','" & poli.Text & "','" & jpasien & "','" & status & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Private Sub Laki_CheckedChanged(sender As Object, e As EventArgs) Handles Laki.CheckedChanged
        gender = "Laki-Laki"
    End Sub

    Private Sub Perempuan_CheckedChanged(sender As Object, e As EventArgs) Handles Perempuan.CheckedChanged
        gender = "Perempuan"
    End Sub

    Private Sub Rujuk_CheckedChanged(sender As Object, e As EventArgs) Handles Rujuk.CheckedChanged
        status = "Rujuk"
    End Sub

    Private Sub Pulang_CheckedChanged(sender As Object, e As EventArgs) Handles Pulang.CheckedChanged
        status = "Pulang"
    End Sub

    Private Sub Umum_CheckedChanged(sender As Object, e As EventArgs) Handles Umum.CheckedChanged
        jpasien = "Umum"
    End Sub

    Private Sub BPJS_CheckedChanged(sender As Object, e As EventArgs) Handles BPJS.CheckedChanged
        jpasien = "BPJS"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        id.Text = ""
        nama_pasien.Text = ""
        alamat.Text = ""
        ttl.Text = ""
        keluhan.Text = ""
        nama_dokter.Text = ""
        poli.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
        Me.Close()
        Beranda.tampil()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Beranda.tampil()
    End Sub

    Private Sub nama_dokter_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles nama_dokter.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("select * from dokter where nama_dokter='" & nama_dokter.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            poli.Text = dr.Item("poli")
        End If
    End Sub

    Private Sub Daftar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id.Text = ""
        nama_pasien.Text = ""
        alamat.Text = ""
        ttl.Text = ""
        keluhan.Text = ""
        nama_dokter.Text = ""
        poli.Text = ""
        tampildokter()
    End Sub

End Class