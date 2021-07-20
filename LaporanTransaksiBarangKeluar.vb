Public Class LaporanTransaksiBarangKeluar
    Private Sub LaporanTransaksiBarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'persedianbarangDataSet.tbbarangkeluar' table. You can move, or remove it, as needed.
        Me.tbbarangkeluarTableAdapter.Fill(Me.persedianbarangDataSet.tbbarangkeluar)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class