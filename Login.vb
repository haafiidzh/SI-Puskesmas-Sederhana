Imports System.Data.Odbc

Public Class Login
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

    Private Sub Login_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.CadetBlue, Color.DimGray, Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a
        Dim b
        If username.Text = "" And password.Text = "" Then
            a = MessageBox.Show("Form Harus Diisi!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            koneksi()
            Dim sql As String = "select * from admin where (username ='" & username.Text & "' and password ='" & password.Text & "')"
            cmd = New OdbcCommand(sql, con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Beranda.ShowDialog()
            Else
                b = MessageBox.Show("Username/Password Salah!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        username.Text = ""
        password.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password.PasswordChar = "*"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub
End Class