<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bilet_satis
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.biletİptal = New System.Windows.Forms.ToolStripMenuItem()
        Me.iptalBiletler = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.txtTc = New System.Windows.Forms.MaskedTextBox()
        Me.cbVarisF = New System.Windows.Forms.ComboBox()
        Me.cbKalkisF = New System.Windows.Forms.ComboBox()
        Me.dtKalkisF = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPlaka = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.biletİptal, Me.iptalBiletler})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 63)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'biletİptal
        '
        Me.biletİptal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.biletİptal.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.biletİptal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.biletİptal.Margin = New System.Windows.Forms.Padding(230, 0, 0, 0)
        Me.biletİptal.Name = "biletİptal"
        Me.biletİptal.Padding = New System.Windows.Forms.Padding(5)
        Me.biletİptal.Size = New System.Drawing.Size(232, 59)
        Me.biletİptal.Text = "Bileti İptal Et"
        '
        'iptalBiletler
        '
        Me.iptalBiletler.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold)
        Me.iptalBiletler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.iptalBiletler.Margin = New System.Windows.Forms.Padding(427, 0, 0, 0)
        Me.iptalBiletler.Name = "iptalBiletler"
        Me.iptalBiletler.Padding = New System.Windows.Forms.Padding(5)
        Me.iptalBiletler.Size = New System.Drawing.Size(326, 59)
        Me.iptalBiletler.Text = "İptal Edilen Biletler"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txtSoyad)
        Me.Panel1.Controls.Add(Me.txtTelefon)
        Me.Panel1.Controls.Add(Me.txtTc)
        Me.Panel1.Controls.Add(Me.cbPlaka)
        Me.Panel1.Controls.Add(Me.cbVarisF)
        Me.Panel1.Controls.Add(Me.cbKalkisF)
        Me.Panel1.Controls.Add(Me.dtKalkisF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(271, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1361, 97)
        Me.Panel1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(323, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 22)
        Me.TextBox1.TabIndex = 31
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtSoyad.Location = New System.Drawing.Point(607, 22)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(156, 22)
        Me.txtSoyad.TabIndex = 31
        '
        'txtTelefon
        '
        Me.txtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtTelefon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtTelefon.Location = New System.Drawing.Point(893, 20)
        Me.txtTelefon.Mask = "(999) 000-00-00"
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(134, 22)
        Me.txtTelefon.TabIndex = 30
        '
        'txtTc
        '
        Me.txtTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txtTc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtTc.Location = New System.Drawing.Point(63, 24)
        Me.txtTc.Mask = "00000000000"
        Me.txtTc.Name = "txtTc"
        Me.txtTc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTc.Size = New System.Drawing.Size(166, 22)
        Me.txtTc.TabIndex = 29
        '
        'cbVarisF
        '
        Me.cbVarisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.cbVarisF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbVarisF.FormattingEnabled = True
        Me.cbVarisF.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbVarisF.Location = New System.Drawing.Point(861, 62)
        Me.cbVarisF.Name = "cbVarisF"
        Me.cbVarisF.Size = New System.Drawing.Size(166, 24)
        Me.cbVarisF.TabIndex = 23
        '
        'cbKalkisF
        '
        Me.cbKalkisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.cbKalkisF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbKalkisF.FormattingEnabled = True
        Me.cbKalkisF.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbKalkisF.Location = New System.Drawing.Point(494, 64)
        Me.cbKalkisF.Name = "cbKalkisF"
        Me.cbKalkisF.Size = New System.Drawing.Size(152, 24)
        Me.cbKalkisF.TabIndex = 20
        '
        'dtKalkisF
        '
        Me.dtKalkisF.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtKalkisF.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtKalkisF.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtKalkisF.CustomFormat = "dd-MM-yyyy"
        Me.dtKalkisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.dtKalkisF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtKalkisF.Location = New System.Drawing.Point(144, 62)
        Me.dtKalkisF.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtKalkisF.Name = "dtKalkisF"
        Me.dtKalkisF.Size = New System.Drawing.Size(130, 22)
        Me.dtKalkisF.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(373, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Kalkış Yeri:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(18, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 20)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "TC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(744, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Varış Yeri:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(535, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Soyad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(810, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sefer Tarihi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(280, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ad:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1856, 733)
        Me.DataGridView1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(1068, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Plaka:"
        '
        'cbPlaka
        '
        Me.cbPlaka.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.cbPlaka.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbPlaka.FormattingEnabled = True
        Me.cbPlaka.Location = New System.Drawing.Point(1144, 20)
        Me.cbPlaka.Name = "cbPlaka"
        Me.cbPlaka.Size = New System.Drawing.Size(166, 24)
        Me.cbPlaka.TabIndex = 23
        '
        'bilet_satis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "bilet_satis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bilet Satışları"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents biletİptal As ToolStripMenuItem
    Friend WithEvents iptalBiletler As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbVarisF As ComboBox
    Friend WithEvents cbKalkisF As ComboBox
    Friend WithEvents dtKalkisF As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTc As MaskedTextBox
    Friend WithEvents txtTelefon As MaskedTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents cbPlaka As ComboBox
    Friend WithEvents Label7 As Label
End Class
