<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MASTERDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATABARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.transaksibarangmasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiBarangKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lpdatabarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.ltpbarangmasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.lptbarangkeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Aqua
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERDATAToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.TRANSAKSIToolStripMenuItem, Me.KELUARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(126, 489)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MASTERDATAToolStripMenuItem
        '
        Me.MASTERDATAToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.MASTERDATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATABARANGToolStripMenuItem})
        Me.MASTERDATAToolStripMenuItem.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASTERDATAToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.MASTERDATAToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 200, 0, 0)
        Me.MASTERDATAToolStripMenuItem.Name = "MASTERDATAToolStripMenuItem"
        Me.MASTERDATAToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.MASTERDATAToolStripMenuItem.Text = "MASTER DATA"
        '
        'DATABARANGToolStripMenuItem
        '
        Me.DATABARANGToolStripMenuItem.Name = "DATABARANGToolStripMenuItem"
        Me.DATABARANGToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DATABARANGToolStripMenuItem.Text = "DATA BARANG"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.transaksibarangmasuk, Me.TransaksiBarangKeluar})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 20)
        Me.ToolStripMenuItem1.Text = "TRANSAKSI"
        '
        'transaksibarangmasuk
        '
        Me.transaksibarangmasuk.Name = "transaksibarangmasuk"
        Me.transaksibarangmasuk.Size = New System.Drawing.Size(188, 22)
        Me.transaksibarangmasuk.Text = "BARANG MASUK"
        '
        'TransaksiBarangKeluar
        '
        Me.TransaksiBarangKeluar.Name = "TransaksiBarangKeluar"
        Me.TransaksiBarangKeluar.Size = New System.Drawing.Size(188, 22)
        Me.TransaksiBarangKeluar.Text = "BARANG KELUAR"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lpdatabarang, Me.ltpbarangmasuk, Me.lptbarangkeluar})
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripMenuItem4.Margin = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(113, 20)
        Me.ToolStripMenuItem4.Text = "LAPORAN"
        '
        'lpdatabarang
        '
        Me.lpdatabarang.Name = "lpdatabarang"
        Me.lpdatabarang.Size = New System.Drawing.Size(330, 22)
        Me.lpdatabarang.Text = "LAPORAN DATA BARANG"
        '
        'ltpbarangmasuk
        '
        Me.ltpbarangmasuk.Name = "ltpbarangmasuk"
        Me.ltpbarangmasuk.Size = New System.Drawing.Size(330, 22)
        Me.ltpbarangmasuk.Text = "LAPORAN TRANSAKSI BARANG MASUK"
        '
        'lptbarangkeluar
        '
        Me.lptbarangkeluar.Name = "lptbarangkeluar"
        Me.lptbarangkeluar.Size = New System.Drawing.Size(330, 22)
        Me.lptbarangkeluar.Text = "LAPORAN TRANSAKSI BARANG KELUAR"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TRANSAKSIToolStripMenuItem.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRANSAKSIToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.TRANSAKSIToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 150, 0, 0)
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "KELUAR"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Font = New System.Drawing.Font("Eras Demi ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KELUARToolStripMenuItem.ForeColor = System.Drawing.Color.Navy
        Me.KELUARToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 170, 0, 0)
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.KELUARToolStripMenuItem.Text = "KELUAR"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Lalu_Husni_Hawari_1901010194_UAS.My.Resources.Resources.gambar_1
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(121, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 489)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Aqua
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 114)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Eras Bold ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(142, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SELAMAT DATANG "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Eras Bold ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(264, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Eras Bold ITC", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(75, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "APLIKASI PERSEDIAN BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Eras Bold ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(428, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CREATE BY LALU HUSNI HAWARI"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 489)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Menu_Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MASTERDATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATABARANGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents transaksibarangmasuk As ToolStripMenuItem
    Friend WithEvents TransaksiBarangKeluar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents lpdatabarang As ToolStripMenuItem
    Friend WithEvents ltpbarangmasuk As ToolStripMenuItem
    Friend WithEvents lptbarangkeluar As ToolStripMenuItem
End Class
