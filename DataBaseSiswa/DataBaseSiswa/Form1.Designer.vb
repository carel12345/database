<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formkontak
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
        Me.Groupkontak = New System.Windows.Forms.GroupBox()
        Me.Btnkeluar = New System.Windows.Forms.Button()
        Me.Btnhapus = New System.Windows.Forms.Button()
        Me.Btnbatal = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btntambah = New System.Windows.Forms.Button()
        Me.Btnsimpan = New System.Windows.Forms.Button()
        Me.Combokelamin = New System.Windows.Forms.ComboBox()
        Me.Textalamat = New System.Windows.Forms.TextBox()
        Me.Textemail = New System.Windows.Forms.TextBox()
        Me.Textnotelp = New System.Windows.Forms.TextBox()
        Me.Textnama = New System.Windows.Forms.TextBox()
        Me.Textkode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Groupkontak.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Groupkontak
        '
        Me.Groupkontak.Controls.Add(Me.Btnkeluar)
        Me.Groupkontak.Controls.Add(Me.Btnhapus)
        Me.Groupkontak.Controls.Add(Me.Btnbatal)
        Me.Groupkontak.Controls.Add(Me.Btnedit)
        Me.Groupkontak.Controls.Add(Me.Btntambah)
        Me.Groupkontak.Controls.Add(Me.Btnsimpan)
        Me.Groupkontak.Controls.Add(Me.Combokelamin)
        Me.Groupkontak.Controls.Add(Me.Textalamat)
        Me.Groupkontak.Controls.Add(Me.Textemail)
        Me.Groupkontak.Controls.Add(Me.Textnotelp)
        Me.Groupkontak.Controls.Add(Me.Textnama)
        Me.Groupkontak.Controls.Add(Me.Textkode)
        Me.Groupkontak.Controls.Add(Me.Label6)
        Me.Groupkontak.Controls.Add(Me.Label5)
        Me.Groupkontak.Controls.Add(Me.Label4)
        Me.Groupkontak.Controls.Add(Me.Label3)
        Me.Groupkontak.Controls.Add(Me.Label2)
        Me.Groupkontak.Controls.Add(Me.Label1)
        Me.Groupkontak.Location = New System.Drawing.Point(13, 13)
        Me.Groupkontak.Name = "Groupkontak"
        Me.Groupkontak.Size = New System.Drawing.Size(677, 200)
        Me.Groupkontak.TabIndex = 0
        Me.Groupkontak.TabStop = False
        Me.Groupkontak.Text = "Form kontak"
        '
        'Btnkeluar
        '
        Me.Btnkeluar.Location = New System.Drawing.Point(524, 143)
        Me.Btnkeluar.Name = "Btnkeluar"
        Me.Btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.Btnkeluar.TabIndex = 17
        Me.Btnkeluar.Text = "Keluar"
        Me.Btnkeluar.UseVisualStyleBackColor = True
        '
        'Btnhapus
        '
        Me.Btnhapus.Location = New System.Drawing.Point(443, 143)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.Btnhapus.TabIndex = 16
        Me.Btnhapus.Text = "Hapus"
        Me.Btnhapus.UseVisualStyleBackColor = True
        '
        'Btnbatal
        '
        Me.Btnbatal.Location = New System.Drawing.Point(362, 143)
        Me.Btnbatal.Name = "Btnbatal"
        Me.Btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.Btnbatal.TabIndex = 15
        Me.Btnbatal.Text = "Batal"
        Me.Btnbatal.UseVisualStyleBackColor = True
        '
        'Btnedit
        '
        Me.Btnedit.Location = New System.Drawing.Point(262, 144)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(75, 23)
        Me.Btnedit.TabIndex = 14
        Me.Btnedit.Text = "Edit"
        Me.Btnedit.UseVisualStyleBackColor = True
        '
        'Btntambah
        '
        Me.Btntambah.Location = New System.Drawing.Point(78, 144)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(75, 23)
        Me.Btntambah.TabIndex = 13
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = True
        '
        'Btnsimpan
        '
        Me.Btnsimpan.Location = New System.Drawing.Point(172, 143)
        Me.Btnsimpan.Name = "Btnsimpan"
        Me.Btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.Btnsimpan.TabIndex = 12
        Me.Btnsimpan.Text = "Simpan"
        Me.Btnsimpan.UseVisualStyleBackColor = True
        '
        'Combokelamin
        '
        Me.Combokelamin.FormattingEnabled = True
        Me.Combokelamin.Items.AddRange(New Object() {"L", "P"})
        Me.Combokelamin.Location = New System.Drawing.Point(172, 100)
        Me.Combokelamin.Name = "Combokelamin"
        Me.Combokelamin.Size = New System.Drawing.Size(100, 21)
        Me.Combokelamin.TabIndex = 11
        '
        'Textalamat
        '
        Me.Textalamat.Location = New System.Drawing.Point(438, 101)
        Me.Textalamat.Name = "Textalamat"
        Me.Textalamat.Size = New System.Drawing.Size(100, 20)
        Me.Textalamat.TabIndex = 10
        '
        'Textemail
        '
        Me.Textemail.Location = New System.Drawing.Point(438, 68)
        Me.Textemail.Name = "Textemail"
        Me.Textemail.Size = New System.Drawing.Size(100, 20)
        Me.Textemail.TabIndex = 9
        '
        'Textnotelp
        '
        Me.Textnotelp.Location = New System.Drawing.Point(438, 31)
        Me.Textnotelp.Name = "Textnotelp"
        Me.Textnotelp.Size = New System.Drawing.Size(100, 20)
        Me.Textnotelp.TabIndex = 8
        '
        'Textnama
        '
        Me.Textnama.Location = New System.Drawing.Point(172, 69)
        Me.Textnama.Name = "Textnama"
        Me.Textnama.Size = New System.Drawing.Size(100, 20)
        Me.Textnama.TabIndex = 7
        '
        'Textkode
        '
        Me.Textkode.Location = New System.Drawing.Point(172, 35)
        Me.Textkode.Name = "Textkode"
        Me.Textkode.Size = New System.Drawing.Size(100, 20)
        Me.Textkode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Teman"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(677, 203)
        Me.DataGridView1.TabIndex = 1
        '
        'Formkontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 435)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Groupkontak)
        Me.Name = "Formkontak"
        Me.Text = "DATA SISWA"
        Me.Groupkontak.ResumeLayout(False)
        Me.Groupkontak.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Groupkontak As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combokelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Textalamat As System.Windows.Forms.TextBox
    Friend WithEvents Textemail As System.Windows.Forms.TextBox
    Friend WithEvents Textnotelp As System.Windows.Forms.TextBox
    Friend WithEvents Textnama As System.Windows.Forms.TextBox
    Friend WithEvents Textkode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btnkeluar As System.Windows.Forms.Button
    Friend WithEvents Btnhapus As System.Windows.Forms.Button
    Friend WithEvents Btnbatal As System.Windows.Forms.Button
    Friend WithEvents Btnedit As System.Windows.Forms.Button
    Friend WithEvents Btntambah As System.Windows.Forms.Button
    Friend WithEvents Btnsimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
