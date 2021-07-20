<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barangmasuk
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkodetransaksi = New System.Windows.Forms.TextBox()
        Me.datetgl = New System.Windows.Forms.DateTimePicker()
        Me.cbkodebarang = New System.Windows.Forms.ComboBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.txtpersediaan = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Grid2 = New System.Windows.Forms.DataGridView()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.txtpencarian = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjumlah2 = New System.Windows.Forms.TextBox()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Bold ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSAKSI BARANG MASUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID TRANSAKSI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TANGGAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "KODE BARANG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NAMA BARANG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PERSEDIAAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "JUMLAH"
        '
        'txtkodetransaksi
        '
        Me.txtkodetransaksi.Location = New System.Drawing.Point(202, 123)
        Me.txtkodetransaksi.Name = "txtkodetransaksi"
        Me.txtkodetransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtkodetransaksi.TabIndex = 7
        '
        'datetgl
        '
        Me.datetgl.Location = New System.Drawing.Point(202, 156)
        Me.datetgl.Name = "datetgl"
        Me.datetgl.Size = New System.Drawing.Size(140, 20)
        Me.datetgl.TabIndex = 8
        '
        'cbkodebarang
        '
        Me.cbkodebarang.FormattingEnabled = True
        Me.cbkodebarang.Location = New System.Drawing.Point(202, 193)
        Me.cbkodebarang.Name = "cbkodebarang"
        Me.cbkodebarang.Size = New System.Drawing.Size(100, 21)
        Me.cbkodebarang.TabIndex = 9
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(202, 227)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(100, 20)
        Me.txtnamabarang.TabIndex = 10
        '
        'txtpersediaan
        '
        Me.txtpersediaan.Location = New System.Drawing.Point(202, 264)
        Me.txtpersediaan.Name = "txtpersediaan"
        Me.txtpersediaan.Size = New System.Drawing.Size(100, 20)
        Me.txtpersediaan.TabIndex = 11
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(202, 300)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtjumlah.TabIndex = 12
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(390, 287)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(84, 33)
        Me.btnhapus.TabIndex = 18
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnubah.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.White
        Me.btnubah.Location = New System.Drawing.Point(390, 246)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(84, 32)
        Me.btnubah.TabIndex = 17
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Teal
        Me.btnbatal.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(390, 204)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(84, 36)
        Me.btnbatal.TabIndex = 16
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsimpan.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(390, 162)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(84, 36)
        Me.btnsimpan.TabIndex = 15
        Me.btnsimpan.Text = " SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Lime
        Me.btntambah.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(390, 125)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(84, 31)
        Me.btntambah.TabIndex = 14
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Grid2
        '
        Me.Grid2.BackgroundColor = System.Drawing.Color.White
        Me.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid2.Location = New System.Drawing.Point(69, 405)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(396, 110)
        Me.Grid2.TabIndex = 19
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Blue
        Me.btnkeluar.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.White
        Me.btnkeluar.Location = New System.Drawing.Point(428, 564)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(84, 32)
        Me.btnkeluar.TabIndex = 20
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'txtpencarian
        '
        Me.txtpencarian.Location = New System.Drawing.Point(361, 369)
        Me.txtpencarian.Name = "txtpencarian"
        Me.txtpencarian.Size = New System.Drawing.Size(104, 20)
        Me.txtpencarian.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(271, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "PENCARIAN"
        '
        'txtjumlah2
        '
        Me.txtjumlah2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtjumlah2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah2.Location = New System.Drawing.Point(308, 301)
        Me.txtjumlah2.Name = "txtjumlah2"
        Me.txtjumlah2.Size = New System.Drawing.Size(41, 20)
        Me.txtjumlah2.TabIndex = 24
        Me.txtjumlah2.Visible = False
        '
        'Barangmasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(536, 605)
        Me.Controls.Add(Me.txtjumlah2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpencarian)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.Grid2)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtpersediaan)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.cbkodebarang)
        Me.Controls.Add(Me.datetgl)
        Me.Controls.Add(Me.txtkodetransaksi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Barangmasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangmasuk"
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtkodetransaksi As TextBox
    Friend WithEvents datetgl As DateTimePicker
    Friend WithEvents cbkodebarang As ComboBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents txtpersediaan As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents Grid2 As DataGridView
    Friend WithEvents btnkeluar As Button
    Friend WithEvents txtpencarian As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjumlah2 As TextBox
End Class
