Imports System.Data.Odbc

Public Class Tdokter
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
        Dim sql As String = "insert into dokter values('" & id.Text & "','" & nama_dokter.Text & "','" & nip.Text & "','" & poli.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
        id.Text = ""
        nama_dokter.Text = ""
        nip.Text = ""
        poli.Text = ""
        Dokter.tampil()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        id.Text = ""
        nama_dokter.Text = ""
        nip.Text = ""
        poli.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id.Text = ""
        nama_dokter.Text = ""
        nip.Text = ""
        poli.Text = ""
        Me.Close()
        Beranda.tampil()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        id.Text = ""
        nama_dokter.Text = ""
        nip.Text = ""
        poli.Text = ""
    End Sub

    Private Sub Tdokter_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
     (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub Tdokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class