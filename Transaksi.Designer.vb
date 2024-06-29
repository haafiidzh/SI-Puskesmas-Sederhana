<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.total_obat = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.total_biaya = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.htindakan = New System.Windows.Forms.Label()
        Me.pendaftaran = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.harga_obat = New System.Windows.Forms.Label()
        Me.jml = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.nama_obat = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.jtindakan = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TIDAK = New System.Windows.Forms.RadioButton()
        Me.YA = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.poli = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.nama_pasien = New System.Windows.Forms.Label()
        Me.nama_dokter = New System.Windows.Forms.Label()
        Me.jenis_pasien = New System.Windows.Forms.Label()
        Me.status_pasien = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.username = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 108)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(340, 37)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "TRANSAKSI PASIEN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(31, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(719, 293)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSAKSI DAN TINDAKAN"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(32, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 25)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "PROSES BIAYA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.total_obat)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.total_biaya)
        Me.GroupBox4.Controls.Add(Me.Label49)
        Me.GroupBox4.Controls.Add(Me.Label50)
        Me.GroupBox4.Controls.Add(Me.htindakan)
        Me.GroupBox4.Controls.Add(Me.pendaftaran)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(303, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(384, 232)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rincian Biaya"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(95, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(214, 48)
        Me.Button3.TabIndex = 162
        Me.Button3.Text = "PROSES"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'total_obat
        '
        Me.total_obat.BackColor = System.Drawing.SystemColors.Control
        Me.total_obat.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_obat.Location = New System.Drawing.Point(165, 81)
        Me.total_obat.Name = "total_obat"
        Me.total_obat.Size = New System.Drawing.Size(188, 23)
        Me.total_obat.TabIndex = 102
        Me.total_obat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 19)
        Me.Label23.TabIndex = 100
        Me.Label23.Text = "Obat"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(146, 81)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 19)
        Me.Label24.TabIndex = 101
        Me.Label24.Text = ":"
        '
        'total_biaya
        '
        Me.total_biaya.BackColor = System.Drawing.SystemColors.Control
        Me.total_biaya.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_biaya.Location = New System.Drawing.Point(165, 118)
        Me.total_biaya.Name = "total_biaya"
        Me.total_biaya.Size = New System.Drawing.Size(188, 42)
        Me.total_biaya.TabIndex = 99
        Me.total_biaya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(6, 124)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(139, 25)
        Me.Label49.TabIndex = 97
        Me.Label49.Text = "TOTAL BIAYA"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(146, 124)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(13, 19)
        Me.Label50.TabIndex = 98
        Me.Label50.Text = ":"
        '
        'htindakan
        '
        Me.htindakan.BackColor = System.Drawing.SystemColors.Control
        Me.htindakan.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htindakan.Location = New System.Drawing.Point(165, 53)
        Me.htindakan.Name = "htindakan"
        Me.htindakan.Size = New System.Drawing.Size(188, 23)
        Me.htindakan.TabIndex = 94
        Me.htindakan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pendaftaran
        '
        Me.pendaftaran.BackColor = System.Drawing.SystemColors.Control
        Me.pendaftaran.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pendaftaran.Location = New System.Drawing.Point(165, 25)
        Me.pendaftaran.Name = "pendaftaran"
        Me.pendaftaran.Size = New System.Drawing.Size(188, 23)
        Me.pendaftaran.TabIndex = 93
        Me.pendaftaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 25)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(94, 19)
        Me.Label35.TabIndex = 89
        Me.Label35.Text = "Pendaftaran"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(146, 25)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 19)
        Me.Label34.TabIndex = 90
        Me.Label34.Text = ":"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(6, 53)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(115, 19)
        Me.Label33.TabIndex = 87
        Me.Label33.Text = "Biaya Tindakan"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(146, 53)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 19)
        Me.Label32.TabIndex = 88
        Me.Label32.Text = ":"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.harga_obat)
        Me.GroupBox5.Controls.Add(Me.jml)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.Label39)
        Me.GroupBox5.Controls.Add(Me.nama_obat)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(15, 121)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(247, 121)
        Me.GroupBox5.TabIndex = 93
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rincian Obat"
        '
        'harga_obat
        '
        Me.harga_obat.BackColor = System.Drawing.SystemColors.Control
        Me.harga_obat.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga_obat.Location = New System.Drawing.Point(94, 56)
        Me.harga_obat.Name = "harga_obat"
        Me.harga_obat.Size = New System.Drawing.Size(137, 23)
        Me.harga_obat.TabIndex = 97
        '
        'jml
        '
        Me.jml.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml.Location = New System.Drawing.Point(94, 85)
        Me.jml.Name = "jml"
        Me.jml.Size = New System.Drawing.Size(137, 25)
        Me.jml.TabIndex = 94
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(6, 87)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(57, 19)
        Me.Label38.TabIndex = 92
        Me.Label38.Text = "Jumlah"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(6, 56)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(47, 19)
        Me.Label42.TabIndex = 95
        Me.Label42.Text = "Biaya"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(75, 56)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(13, 19)
        Me.Label43.TabIndex = 96
        Me.Label43.Text = ":"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(75, 87)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 19)
        Me.Label39.TabIndex = 93
        Me.Label39.Text = ":"
        '
        'nama_obat
        '
        Me.nama_obat.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_obat.FormattingEnabled = True
        Me.nama_obat.Location = New System.Drawing.Point(94, 26)
        Me.nama_obat.Name = "nama_obat"
        Me.nama_obat.Size = New System.Drawing.Size(137, 25)
        Me.nama_obat.TabIndex = 91
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(6, 28)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(49, 19)
        Me.Label40.TabIndex = 89
        Me.Label40.Text = "Nama"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(75, 28)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 19)
        Me.Label41.TabIndex = 90
        Me.Label41.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.jtindakan)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.TIDAK)
        Me.GroupBox2.Controls.Add(Me.YA)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 103)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tindakan"
        '
        'jtindakan
        '
        Me.jtindakan.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jtindakan.FormattingEnabled = True
        Me.jtindakan.Location = New System.Drawing.Point(6, 69)
        Me.jtindakan.Name = "jtindakan"
        Me.jtindakan.Size = New System.Drawing.Size(225, 25)
        Me.jtindakan.TabIndex = 87
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 19)
        Me.Label31.TabIndex = 86
        Me.Label31.Text = "Jenis Tindakan"
        '
        'TIDAK
        '
        Me.TIDAK.AutoSize = True
        Me.TIDAK.Location = New System.Drawing.Point(55, 17)
        Me.TIDAK.Name = "TIDAK"
        Me.TIDAK.Size = New System.Drawing.Size(70, 23)
        Me.TIDAK.TabIndex = 1
        Me.TIDAK.TabStop = True
        Me.TIDAK.Text = "Tidak"
        Me.TIDAK.UseVisualStyleBackColor = True
        '
        'YA
        '
        Me.YA.AutoSize = True
        Me.YA.Location = New System.Drawing.Point(6, 17)
        Me.YA.Name = "YA"
        Me.YA.Size = New System.Drawing.Size(45, 23)
        Me.YA.TabIndex = 0
        Me.YA.TabStop = True
        Me.YA.Text = "Ya"
        Me.YA.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(491, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 19)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(491, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 19)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 19)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 19)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Poli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 19)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = ":"
        '
        'poli
        '
        Me.poli.BackColor = System.Drawing.SystemColors.Control
        Me.poli.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poli.Location = New System.Drawing.Point(510, 47)
        Me.poli.Name = "poli"
        Me.poli.Size = New System.Drawing.Size(188, 23)
        Me.poli.TabIndex = 148
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(382, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Dokter"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 19)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "Nama Pasien"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(20, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 19)
        Me.Label18.TabIndex = 132
        Me.Label18.Text = "ID Pasien"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(380, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 19)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "Jenis Pasien"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(491, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 19)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(379, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 19)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "Status Pasien"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(491, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 19)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = ":"
        '
        'id
        '
        Me.id.BackColor = System.Drawing.SystemColors.Control
        Me.id.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(186, 14)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(188, 23)
        Me.id.TabIndex = 153
        '
        'nama_pasien
        '
        Me.nama_pasien.BackColor = System.Drawing.SystemColors.Control
        Me.nama_pasien.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_pasien.Location = New System.Drawing.Point(185, 47)
        Me.nama_pasien.Name = "nama_pasien"
        Me.nama_pasien.Size = New System.Drawing.Size(188, 23)
        Me.nama_pasien.TabIndex = 154
        '
        'nama_dokter
        '
        Me.nama_dokter.BackColor = System.Drawing.SystemColors.Control
        Me.nama_dokter.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama_dokter.Location = New System.Drawing.Point(510, 18)
        Me.nama_dokter.Name = "nama_dokter"
        Me.nama_dokter.Size = New System.Drawing.Size(188, 23)
        Me.nama_dokter.TabIndex = 159
        '
        'jenis_pasien
        '
        Me.jenis_pasien.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_pasien.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_pasien.Location = New System.Drawing.Point(510, 79)
        Me.jenis_pasien.Name = "jenis_pasien"
        Me.jenis_pasien.Size = New System.Drawing.Size(188, 23)
        Me.jenis_pasien.TabIndex = 160
        '
        'status_pasien
        '
        Me.status_pasien.BackColor = System.Drawing.SystemColors.Control
        Me.status_pasien.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_pasien.Location = New System.Drawing.Point(510, 110)
        Me.status_pasien.Name = "status_pasien"
        Me.status_pasien.Size = New System.Drawing.Size(188, 23)
        Me.status_pasien.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 19)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Tanggal Transaksi"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(166, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 19)
        Me.Label20.TabIndex = 163
        Me.Label20.Text = ":"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(186, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(188, 20)
        Me.DateTimePicker1.TabIndex = 164
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.status_pasien)
        Me.GroupBox3.Controls.Add(Me.jenis_pasien)
        Me.GroupBox3.Controls.Add(Me.nama_dokter)
        Me.GroupBox3.Controls.Add(Me.nama_pasien)
        Me.GroupBox3.Controls.Add(Me.id)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.poli)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(31, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(719, 145)
        Me.GroupBox3.TabIndex = 95
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Pasien"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.username.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(614, 12)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(157, 26)
        Me.username.TabIndex = 165
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(650, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 36)
        Me.Button2.TabIndex = 166
        Me.Button2.Text = "KEMBALI"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 593)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transaksi"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents jtindakan As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TIDAK As System.Windows.Forms.RadioButton
    Friend WithEvents YA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents harga_obat As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents jml As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents nama_obat As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents total_biaya As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents htindakan As System.Windows.Forms.Label
    Friend WithEvents pendaftaran As System.Windows.Forms.Label
    Friend WithEvents total_obat As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents poli As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents nama_pasien As System.Windows.Forms.Label
    Friend WithEvents nama_dokter As System.Windows.Forms.Label
    Friend WithEvents jenis_pasien As System.Windows.Forms.Label
    Friend WithEvents status_pasien As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
