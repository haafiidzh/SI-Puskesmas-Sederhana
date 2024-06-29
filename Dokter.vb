Imports System.Data.Odbc

Public Class Dokter
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

    Sub jeruk()
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 210
        DataGridView1.Columns(2).Width = 115
        DataGridView1.Columns(3).Width = 130
    End Sub

    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from dokter order by id_dokter asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Dokter_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
     (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Dokter yang dihapus belum DIPILIH", vbInformation, "INFORMASI")
        Else
            If (MessageBox.Show("Anda yakin menghapus data " & a & " ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from dokter where nama_dokter='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data Dokter BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TDokter.ShowDialog()
    End Sub

    Private Sub Dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call jeruk()
        tampil()
    End Sub
End Class