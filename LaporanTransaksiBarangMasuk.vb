Public Class LaporanTransaksiBarangMasuk
    Private Sub LaporanTransaksiBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'persedianbarangDataSet.tbbarangmasuk' table. You can move, or remove it, as needed.
        Me.tbbarangmasukTableAdapter.Fill(Me.persedianbarangDataSet.tbbarangmasuk)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class