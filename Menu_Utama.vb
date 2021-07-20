Public Class Menu_Utama
    Private Sub DATABARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABARANGToolStripMenuItem.Click
        databarang.Show()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        Select Case MsgBox("Yakin Ingin Keluar ?", MsgBoxStyle.YesNo, "Keluar")
            Case MsgBoxResult.Yes
                End
        End Select
    End Sub

    Private Sub Transaksibarangmasuk_Click(sender As Object, e As EventArgs) Handles transaksibarangmasuk.Click
        Barangmasuk.ShowDialog()
    End Sub

    Private Sub TransaksiBarangKeluar_Click(sender As Object, e As EventArgs) Handles TransaksiBarangKeluar.Click
        Barangkeluar.ShowDialog()
    End Sub

    Private Sub Ltpbarangmasuk_Click(sender As Object, e As EventArgs) Handles ltpbarangmasuk.Click
        LaporanTransaksiBarangMasuk.Show()
    End Sub

    Private Sub Lpdatabarang_Click(sender As Object, e As EventArgs) Handles lpdatabarang.Click
        LaporanDataBarang.Show()
    End Sub

    Private Sub Lptbarangkeluar_Click(sender As Object, e As EventArgs) Handles lptbarangkeluar.Click
        LaporanTransaksiBarangKeluar.Show()
    End Sub

End Class
