Public Class LaporanDataBarang
    Private Sub LaporanDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'persedianbarangDataSet.tbbarang' table. You can move, or remove it, as needed.
        Me.tbbarangTableAdapter.Fill(Me.persedianbarangDataSet.tbbarang)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class