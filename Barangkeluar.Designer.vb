<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barangkeluar
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
        Me.txtjumlah2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpencarian = New System.Windows.Forms.TextBox()
        Me.Grid2 = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtpersediaan = New System.Windows.Forms.TextBox()
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.cbkodebarang = New System.Windows.Forms.ComboBox()
        Me.datetgl = New System.Windows.Forms.DateTimePicker()
        Me.txtidtransaksi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtjumlah2
        '
        Me.txtjumlah2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtjumlah2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjumlah2.Location = New System.Drawing.Point(307, 292)
        Me.txtjumlah2.Name = "txtjumlah2"
        Me.txtjumlah2.Size = New System.Drawing.Size(41, 20)
        Me.txtjumlah2.TabIndex = 46
        Me.txtjumlah2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "PENCARIAN"
        '
        'txtpencarian
        '
        Me.txtpencarian.Location = New System.Drawing.Point(360, 360)
        Me.txtpencarian.Name = "txtpencarian"
        Me.txtpencarian.Size = New System.Drawing.Size(104, 20)
        Me.txtpencarian.TabIndex = 44
        '
        'Grid2
        '
        Me.Grid2.BackgroundColor = System.Drawing.Color.White
        Me.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid2.Location = New System.Drawing.Point(68, 396)
        Me.Grid2.Name = "Grid2"
        Me.Grid2.Size = New System.Drawing.Size(396, 110)
        Me.Grid2.TabIndex = 43
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(389, 278)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(84, 33)
        Me.btnhapus.TabIndex = 42
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnubah.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.White
        Me.btnubah.Location = New System.Drawing.Point(389, 237)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(84, 32)
        Me.btnubah.TabIndex = 41
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Teal
        Me.btnbatal.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(389, 195)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(84, 36)
        Me.btnbatal.TabIndex = 40
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsimpan.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(389, 153)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(84, 36)
        Me.btnsimpan.TabIndex = 39
        Me.btnsimpan.Text = " SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Lime
        Me.btntambah.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(389, 116)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(84, 31)
        Me.btntambah.TabIndex = 38
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(201, 291)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtjumlah.TabIndex = 37
        '
        'txtpersediaan
        '
        Me.txtpersediaan.Location = New System.Drawing.Point(201, 255)
        Me.txtpersediaan.Name = "txtpersediaan"
        Me.txtpersediaan.Size = New System.Drawing.Size(100, 20)
        Me.txtpersediaan.TabIndex = 36
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(201, 218)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(100, 20)
        Me.txtnamabarang.TabIndex = 35
        '
        'cbkodebarang
        '
        Me.cbkodebarang.FormattingEnabled = True
        Me.cbkodebarang.Location = New System.Drawing.Point(201, 184)
        Me.cbkodebarang.Name = "cbkodebarang"
        Me.cbkodebarang.Size = New System.Drawing.Size(100, 21)
        Me.cbkodebarang.TabIndex = 34
        '
        'datetgl
        '
        Me.datetgl.Location = New System.Drawing.Point(201, 147)
        Me.datetgl.Name = "datetgl"
        Me.datetgl.Size = New System.Drawing.Size(140, 20)
        Me.datetgl.TabIndex = 33
        '
        'txtidtransaksi
        '
        Me.txtidtransaksi.Location = New System.Drawing.Point(201, 114)
        Me.txtidtransaksi.Name = "txtidtransaksi"
        Me.txtidtransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtidtransaksi.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "JUMLAH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "PERSEDIAAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "NAMA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "KODE BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "TANGGAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID TRANSAKSI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Bold ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 28)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "TRANSAKSI BARANG KELUAR"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Blue
        Me.btnkeluar.Font = New System.Drawing.Font("Eras Bold ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.White
        Me.btnkeluar.Location = New System.Drawing.Point(440, 568)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(84, 32)
        Me.btnkeluar.TabIndex = 47
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'Barangkeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(536, 625)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.txtjumlah2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpencarian)
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
        Me.Controls.Add(Me.txtidtransaksi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Barangkeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangkeluar"
        CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtjumlah2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpencarian As TextBox
    Friend WithEvents Grid2 As DataGridView
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtpersediaan As TextBox
    Friend WithEvents txtnamabarang As TextBox
    Friend WithEvents cbkodebarang As ComboBox
    Friend WithEvents datetgl As DateTimePicker
    Friend WithEvents txtidtransaksi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnkeluar As Button
End Class
