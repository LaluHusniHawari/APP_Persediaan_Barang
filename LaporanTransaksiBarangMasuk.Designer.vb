<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanTransaksiBarangMasuk
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.persedianbarangDataSet = New Lalu_Husni_Hawari_1901010194_UAS.persedianbarangDataSet()
        Me.tbbarangmasukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbbarangmasukTableAdapter = New Lalu_Husni_Hawari_1901010194_UAS.persedianbarangDataSetTableAdapters.tbbarangmasukTableAdapter()
        CType(Me.persedianbarangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbbarangmasukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "LaporanBarangMasuk"
        ReportDataSource1.Value = Me.tbbarangmasukBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lalu_Husni_Hawari_1901010194_UAS.ReportBarangMasuk.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'persedianbarangDataSet
        '
        Me.persedianbarangDataSet.DataSetName = "persedianbarangDataSet"
        Me.persedianbarangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbbarangmasukBindingSource
        '
        Me.tbbarangmasukBindingSource.DataMember = "tbbarangmasuk"
        Me.tbbarangmasukBindingSource.DataSource = Me.persedianbarangDataSet
        '
        'tbbarangmasukTableAdapter
        '
        Me.tbbarangmasukTableAdapter.ClearBeforeFill = True
        '
        'LaporanTransaksiBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LaporanTransaksiBarangMasuk"
        Me.Text = "LaporanTransaksiBarangMasuk"
        CType(Me.persedianbarangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbbarangmasukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbbarangmasukBindingSource As BindingSource
    Friend WithEvents persedianbarangDataSet As persedianbarangDataSet
    Friend WithEvents tbbarangmasukTableAdapter As persedianbarangDataSetTableAdapters.tbbarangmasukTableAdapter
End Class
