Imports System.Data.Odbc

Public Class Edit
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

    Sub tampilpasien()
        koneksi()
        cmd = New OdbcCommand("select * from pasien where id_pasien = '" & id.Text & "' ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            nama_pasien.Text = dr.Item("nama_pasien")
            alamat.Text = dr.Item("alamat")
            ttl.Text = dr.Item("ttl")
            gender = dr.Item("gender")
            keluhan.Text = dr.Item("keluhan")
            nama_dokter.Text = dr.Item("nama_dokter")
            poli.Text = dr.Item("poli")
            jpasien = dr.Item("jenis_pasien")
            status = dr.Item("status_pasien")
            If jpasien = "BPJS" Then
                BPJS.Checked = True
            ElseIf jpasien = "Umum" Then
                Umum.Checked = True
            End If
            If gender = "Laki-Laki" Then
                Laki.Checked = True
            ElseIf gender = "Perempuan" Then
                Perempuan.Checked = True
            End If
            If status = "Rujuk" Then
                Rujuk.Checked = True
            ElseIf status = "Pulang" Then
                pulang.Checked = True
            End If
        End If
    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "update pasien set nama_pasien = '" & nama_pasien.Text & "', alamat = '" & alamat.Text & "', ttl = '" & ttl.Text & "', gender = '" & gender & "', keluhan = '" & keluhan.Text & "', nama_dokter = '" & nama_dokter.Text & "', poli = '" & poli.Text & "', jenis_pasien = '" & jpasien & "', status_pasien = '" & status & "' where id_pasien = '" & id.Text & "'"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
        Pasien.tampil()
    End Sub

    Private Sub Edit_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
     (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)
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

    Private Sub Pulang_CheckedChanged(sender As Object, e As EventArgs) Handles pulang.CheckedChanged
        status = "Pulang"
    End Sub

    Private Sub Umum_CheckedChanged(sender As Object, e As EventArgs) Handles Umum.CheckedChanged
        jpasien = "Umum"
    End Sub

    Private Sub BPJS_CheckedChanged(sender As Object, e As EventArgs) Handles BPJS.CheckedChanged
        jpasien = "BPJS"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub nama_dokter_SelectedIndexChanged(sender As Object, e As EventArgs)
        koneksi()
        cmd = New OdbcCommand("select * from dokter where nama_dokter='" & nama_dokter.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            poli.Text = dr.Item("poli")
        End If
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilpasien()
        tampildokter()
    End Sub

End Class