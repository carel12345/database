Public Class Formkontak

    Sub kosongkanform()
        Textkode.Text = ""
        Textnama.Text = ""
        Combokelamin.Text = ""
        Textnotelp.Text = ""
        Textemail.Text = ""
        Textalamat.Text = ""
        Textkode.Text = ""
        Textkode.Focus()
    End Sub

    Sub matikanform()
        Textkode.Enabled = False
        Textnama.Enabled = False
        Combokelamin.Enabled = False
        Textnotelp.Enabled = False
        Textemail.Enabled = False
        Textalamat.Enabled = False
    End Sub


    Sub hidupkanform()
        Textkode.Enabled = True
        Textnama.Enabled = True
        Combokelamin.Enabled = True
        Textnotelp.Enabled = True
        Textemail.Enabled = True
        Textalamat.Enabled = True
    End Sub

    Sub tampilkandata()
        Call koneksiDB()
        DA = New OleDb.OleDbDataAdapter("select * from kontak", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    '...FROM DATA SISWA....!!!!!!
    Private Sub Formkontak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksiDB()
        Call matikanform()
        Call tampilkandata()
    End Sub

    Private Sub Btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntambah.Click
        Call hidupkanform()
        Call kosongkanform()
    End Sub

    Private Sub Btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnkeluar.Click
        Me.Close()
        '....KONTOL
    End Sub

    Private Sub Btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbatal.Click
        Call matikanform()
        Call kosongkanform()
    End Sub

    '...input database!!!!
    Private Sub Btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsimpan.Click
        If Textkode.Text = "" Or Textnama.Text = "" Or Combokelamin.Text = "" Then
            MsgBox("HARAP DI ISI....")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("select * from kontak where kode ='" & Textkode.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Kontak values('" & Textkode.Text & "', '" & Textnama.Text & "', '" & Combokelamin.Text & "', '" & Textnotelp.Text & "', '" & Textemail.Text & "', '" & Textalamat.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("INPUT DATA SUKSES...")
            Else
                MsgBox("DATA TERIMPUT...")

            End If
            Call matikanform()
            Call kosongkanform()
            Call tampilkandata()

        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        Textkode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Textnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Combokelamin.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Textnotelp.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Textemail.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Textalamat.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

        Call hidupkanform()
        Textkode.Enabled = False
    End Sub

    Private Sub Btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnedit.Click
        If Textkode.Text = "" Or Textnama.Text = "" Or Combokelamin.Text = "" Then
            MsgBox("HARAP DI ISI....")
            Exit Sub
        Else
            Call koneksiDB()
            CMD = New OleDb.OleDbCommand("update kontak set nama='" & Textnama.Text & "',jenis_kelamin='" & Combokelamin.Text & "',no_telp='" & Textnotelp.Text & "',email='" & Textemail.Text & "',alamat_rumah='" & Textalamat.Text & "' where kode='" & Textkode.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data UPDATE")
        End If
        Call matikanform()
        Call kosongkanform()
        Call tampilkandata()

    End Sub

    Private Sub Btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhapus.Click
        If Textkode.Text = "" Then
            MsgBox("TIDAK ADA DATA YANG AKAN DI HAPUS")
            Exit Sub
        Else
            If MessageBox.Show("YAKIN ANDA INGIN MENGHAPUS?", "KONFIRMASI", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Call koneksiDB()
                CMD = New OleDb.OleDbCommand("delete from kontak where kode='" & Textkode.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("HAPUS DATA SUKSES!!!!...")
                Call matikanform()
                Call kosongkanform()
                Call tampilkandata()
            Else
                Call matikanform()
                Call kosongkanform()
            End If
        End If
    End Sub
End Class
