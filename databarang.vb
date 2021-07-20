Public Class databarang
    Sub TampilGrid()
        Call Koneksi()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tbbarang", CONN)
        DS = New DataSet
        DA.Fill(DS)
        Grid1.DataSource = DS.Tables(0)
        Grid1.ReadOnly = True
    End Sub
    Sub KosongkanField()
        txtkodebarang.Text = ""
        txtnamabarang.Text = ""
        txtpersediaan.Text = ""
    End Sub
    Sub MatikanField()
        txtkodebarang.Enabled = False
        txtnamabarang.Enabled = False
        txtpersediaan.Enabled = False
    End Sub
    Sub HidupkanField()
        txtkodebarang.Enabled = True
        txtnamabarang.Enabled = True
        txtpersediaan.Enabled = True
    End Sub
    Sub RefreshGrid()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tbbarang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbbarang")
        Grid1.DataSource = (DS.Tables("tbbarang"))
    End Sub
    Private Sub Databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call KosongkanField()
        Call MatikanField()

    End Sub
    Private Sub Btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call HidupkanField()
        Call KosongkanField()
        txtkodebarang.Focus()
        txtpersediaan.Text = 0
    End Sub
    Private Sub Btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkodebarang.Text = "" Or txtkodebarang.Text = "" Or txtpersediaan.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New OleDb.OleDbCommand("SELECT * FROM tbbarang WHERE kodebarang='" & txtkodebarang.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String
                simpan = "INSERT INTO tbbarang VALUES ('" & txtkodebarang.Text & "','" & txtnamabarang.Text & "','" & txtpersediaan.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan")
            Else
                MsgBox("Kode Barang Sudah Ada")
            End If
            Call RefreshGrid()
            Call TampilGrid()
            Call KosongkanField()
            Call MatikanField()
        End If
    End Sub

    Private Sub Btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call KosongkanField()
        Call MatikanField()
    End Sub

    Private Sub Btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkodebarang.Text = "" Or txtkodebarang.Text = "" Or txtpersediaan.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            CMD = New OleDb.OleDbCommand("UPDATE tbbarang SET namabarang='" & txtnamabarang.Text & "',persediaan='" & txtpersediaan.Text & "' WHERE kodebarang='" & txtkodebarang.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah")
        End If
        Call MatikanField()
        Call KosongkanField()
        Call TampilGrid()
    End Sub

    Private Sub Grid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellContentClick

    End Sub

    Private Sub Grid1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid1.CellMouseClick
        On Error Resume Next
        txtkodebarang.Text = Grid1.Rows(e.RowIndex).Cells(0).Value
        txtnamabarang.Text = Grid1.Rows(e.RowIndex).Cells(1).Value
        txtpersediaan.Text = Grid1.Rows(e.RowIndex).Cells(2).Value
        Call HidupkanField()
        txtkodebarang.Enabled = False
    End Sub

    Private Sub Btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtkodebarang.Text = "" Then
            MsgBox("Data Yang Akan Dihapus Tidak Ada")
            Exit Sub
        Else
            If MessageBox.Show("Yakin Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                CMD = New OleDb.OleDbCommand("DELETE FROM tbbarang WHERE kodebarang='" & txtkodebarang.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus")
                Call MatikanField()
                Call KosongkanField()
                Call TampilGrid()
            Else
                Call MatikanField()
                Call KosongkanField()
            End If
        End If
    End Sub

    Private Sub Txtkodebarang_TextChanged(sender As Object, e As EventArgs) Handles txtkodebarang.TextChanged

    End Sub

    Private Sub Btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Menu_Utama.Show()
        Me.Close()
    End Sub


End Class