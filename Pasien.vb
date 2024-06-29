Imports System.Data.Odbc

Public Class Pasien
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

    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from pasien order by id_pasien asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Private Sub Pasien_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
     (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Pasien yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data " & a & " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from pasien where nama_pasien='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data Pasien BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Edit.id.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Edit.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Transaksi.id.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Transaksi.Show()
        If Transaksi.jenis_pasien.Text = "Umum" And Transaksi.status_pasien.Text = "Pulang" Then
            Transaksi.pendaftaran.Text = "7000"
        ElseIf Transaksi.jenis_pasien.Text = "BPJS" And Transaksi.status_pasien.Text = "Pulang" Then
            Transaksi.pendaftaran.Text = "0"
        ElseIf Transaksi.jenis_pasien.Text = "Umum" And Transaksi.status_pasien.Text = "Rujuk" Then
            Transaksi.pendaftaran.Text = "0"
        ElseIf Transaksi.jenis_pasien.Text = "BPJS" And Transaksi.status_pasien.Text = "Rujuk" Then
            Transaksi.pendaftaran.Text = "0"
        End If
    End Sub

    Private Sub Pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Beranda.tampil()
    End Sub
End Class