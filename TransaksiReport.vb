Public Class TransaksiReport

    Private Sub TransaksiReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.transaksi' table. You can move, or remove it, as needed.
        Me.transaksiTableAdapter.Fill(Me.DataSet1.transaksi)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub tTransaksiReport_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
     (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a
        a = MessageBox.Show("Apakah Anda yakin untuk keluar dari halaman laporan?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If a = vbOK Then
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub
End Class