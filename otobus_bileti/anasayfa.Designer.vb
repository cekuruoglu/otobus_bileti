<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class anasayfa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SeferEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiletSatışlarıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtobüsEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPersonelEkle = New System.Windows.Forms.ToolStripMenuItem()
        Me.saatKalkis = New System.Windows.Forms.ComboBox()
        Me.cbVaris = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbKalkis = New System.Windows.Forms.ComboBox()
        Me.dtKalkis = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbVarisSaati = New System.Windows.Forms.TextBox()
        Me.cbPlaka = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSeferId = New System.Windows.Forms.Label()
        Me.txtKoltuk = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBiletFiyat = New System.Windows.Forms.TextBox()
        Me.cbBiletTur = New System.Windows.Forms.ComboBox()
        Me.cbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtTc = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.btnSatis = New System.Windows.Forms.Button()
        Me.lblSutun = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(935, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seçilen Koltuk:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 5, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeferEkleToolStripMenuItem, Me.BiletSatışlarıToolStripMenuItem, Me.OtobüsEkleToolStripMenuItem, Me.btnPersonelEkle})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(1663, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 100, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(239, 1033)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SeferEkleToolStripMenuItem
        '
        Me.SeferEkleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeferEkleToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SeferEkleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.SeferEkleToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.SeferEkleToolStripMenuItem.Name = "SeferEkleToolStripMenuItem"
        Me.SeferEkleToolStripMenuItem.Size = New System.Drawing.Size(238, 42)
        Me.SeferEkleToolStripMenuItem.Text = "Seferler"
        '
        'BiletSatışlarıToolStripMenuItem
        '
        Me.BiletSatışlarıToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.BiletSatışlarıToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold)
        Me.BiletSatışlarıToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BiletSatışlarıToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.BiletSatışlarıToolStripMenuItem.Name = "BiletSatışlarıToolStripMenuItem"
        Me.BiletSatışlarıToolStripMenuItem.Size = New System.Drawing.Size(238, 42)
        Me.BiletSatışlarıToolStripMenuItem.Text = "Otobüs Ekle"
        '
        'OtobüsEkleToolStripMenuItem
        '
        Me.OtobüsEkleToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold)
        Me.OtobüsEkleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.OtobüsEkleToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.OtobüsEkleToolStripMenuItem.Name = "OtobüsEkleToolStripMenuItem"
        Me.OtobüsEkleToolStripMenuItem.Size = New System.Drawing.Size(238, 42)
        Me.OtobüsEkleToolStripMenuItem.Text = "Bilet Satışları"
        '
        'btnPersonelEkle
        '
        Me.btnPersonelEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnPersonelEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btnPersonelEkle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnPersonelEkle.Margin = New System.Windows.Forms.Padding(0, 400, 0, 50)
        Me.btnPersonelEkle.Name = "btnPersonelEkle"
        Me.btnPersonelEkle.Size = New System.Drawing.Size(238, 42)
        Me.btnPersonelEkle.Text = "Kullanıcı Ekle"
        '
        'saatKalkis
        '
        Me.saatKalkis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatKalkis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatKalkis.FormattingEnabled = True
        Me.saatKalkis.Location = New System.Drawing.Point(1109, 229)
        Me.saatKalkis.Name = "saatKalkis"
        Me.saatKalkis.Size = New System.Drawing.Size(265, 30)
        Me.saatKalkis.TabIndex = 21
        '
        'cbVaris
        '
        Me.cbVaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbVaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbVaris.FormattingEnabled = True
        Me.cbVaris.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbVaris.Location = New System.Drawing.Point(1109, 172)
        Me.cbVaris.Name = "cbVaris"
        Me.cbVaris.Size = New System.Drawing.Size(265, 30)
        Me.cbVaris.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(980, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Varış Yeri:"
        '
        'cbKalkis
        '
        Me.cbKalkis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbKalkis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbKalkis.FormattingEnabled = True
        Me.cbKalkis.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbKalkis.Location = New System.Drawing.Point(1109, 58)
        Me.cbKalkis.Name = "cbKalkis"
        Me.cbKalkis.Size = New System.Drawing.Size(265, 30)
        Me.cbKalkis.TabIndex = 18
        '
        'dtKalkis
        '
        Me.dtKalkis.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtKalkis.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtKalkis.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtKalkis.CustomFormat = ""
        Me.dtKalkis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtKalkis.Location = New System.Drawing.Point(1109, 115)
        Me.dtKalkis.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtKalkis.Name = "dtKalkis"
        Me.dtKalkis.Size = New System.Drawing.Size(265, 27)
        Me.dtKalkis.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(959, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kalkış Saati:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(954, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Kalkış Tarihi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(971, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Kalkış Yeri:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(968, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Varış Saati:"
        '
        'tbVarisSaati
        '
        Me.tbVarisSaati.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.tbVarisSaati.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.tbVarisSaati.Location = New System.Drawing.Point(1109, 286)
        Me.tbVarisSaati.Name = "tbVarisSaati"
        Me.tbVarisSaati.ReadOnly = True
        Me.tbVarisSaati.Size = New System.Drawing.Size(265, 28)
        Me.tbVarisSaati.TabIndex = 24
        '
        'cbPlaka
        '
        Me.cbPlaka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cbPlaka.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbPlaka.FormattingEnabled = True
        Me.cbPlaka.Location = New System.Drawing.Point(1109, 343)
        Me.cbPlaka.Name = "cbPlaka"
        Me.cbPlaka.Size = New System.Drawing.Size(265, 30)
        Me.cbPlaka.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(953, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Araç Plakası:"
        '
        'lblSeferId
        '
        Me.lblSeferId.AutoSize = True
        Me.lblSeferId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeferId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblSeferId.Location = New System.Drawing.Point(1580, 14)
        Me.lblSeferId.Name = "lblSeferId"
        Me.lblSeferId.Size = New System.Drawing.Size(60, 25)
        Me.lblSeferId.TabIndex = 2
        Me.lblSeferId.Text = "sefer"
        Me.lblSeferId.Visible = False
        '
        'txtKoltuk
        '
        Me.txtKoltuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtKoltuk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtKoltuk.Location = New System.Drawing.Point(1109, 400)
        Me.txtKoltuk.Name = "txtKoltuk"
        Me.txtKoltuk.ReadOnly = True
        Me.txtKoltuk.Size = New System.Drawing.Size(265, 28)
        Me.txtKoltuk.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(980, 457)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "TC Kimlik:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1047, 514)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Ad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1012, 571)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Soyad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(1001, 628)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Telefon:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(996, 685)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 25)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Cinsiyet:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(981, 742)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 25)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Bilet Türü:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(1027, 799)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Fiyat:"
        '
        'txtBiletFiyat
        '
        Me.txtBiletFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtBiletFiyat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtBiletFiyat.Location = New System.Drawing.Point(1109, 799)
        Me.txtBiletFiyat.Name = "txtBiletFiyat"
        Me.txtBiletFiyat.ReadOnly = True
        Me.txtBiletFiyat.Size = New System.Drawing.Size(265, 28)
        Me.txtBiletFiyat.TabIndex = 24
        '
        'cbBiletTur
        '
        Me.cbBiletTur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cbBiletTur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbBiletTur.FormattingEnabled = True
        Me.cbBiletTur.Items.AddRange(New Object() {"Öğrenci", "Tam"})
        Me.cbBiletTur.Location = New System.Drawing.Point(1109, 742)
        Me.cbBiletTur.Name = "cbBiletTur"
        Me.cbBiletTur.Size = New System.Drawing.Size(265, 30)
        Me.cbBiletTur.TabIndex = 21
        '
        'cbCinsiyet
        '
        Me.cbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cbCinsiyet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbCinsiyet.FormattingEnabled = True
        Me.cbCinsiyet.Items.AddRange(New Object() {"Kadın", "Erkek"})
        Me.cbCinsiyet.Location = New System.Drawing.Point(1109, 685)
        Me.cbCinsiyet.Name = "cbCinsiyet"
        Me.cbCinsiyet.Size = New System.Drawing.Size(265, 30)
        Me.cbCinsiyet.TabIndex = 21
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtSoyad.Location = New System.Drawing.Point(1109, 571)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(265, 28)
        Me.txtSoyad.TabIndex = 24
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtAd.Location = New System.Drawing.Point(1109, 514)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(265, 28)
        Me.txtAd.TabIndex = 24
        '
        'txtTc
        '
        Me.txtTc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtTc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtTc.Location = New System.Drawing.Point(1109, 457)
        Me.txtTc.Mask = "00000000000"
        Me.txtTc.Name = "txtTc"
        Me.txtTc.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTc.Size = New System.Drawing.Size(265, 28)
        Me.txtTc.TabIndex = 28
        '
        'txtTelefon
        '
        Me.txtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtTelefon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.txtTelefon.Location = New System.Drawing.Point(1109, 628)
        Me.txtTelefon.Mask = "(999) 000-00-00"
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(265, 28)
        Me.txtTelefon.TabIndex = 28
        '
        'btnSatis
        '
        Me.btnSatis.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSatis.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSatis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSatis.Location = New System.Drawing.Point(1094, 882)
        Me.btnSatis.Name = "btnSatis"
        Me.btnSatis.Size = New System.Drawing.Size(232, 63)
        Me.btnSatis.TabIndex = 1
        Me.btnSatis.Text = "Satış Yap"
        Me.btnSatis.UseVisualStyleBackColor = False
        '
        'lblSutun
        '
        Me.lblSutun.AutoSize = True
        Me.lblSutun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSutun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblSutun.Location = New System.Drawing.Point(1580, 73)
        Me.lblSutun.Name = "lblSutun"
        Me.lblSutun.Size = New System.Drawing.Size(65, 25)
        Me.lblSutun.TabIndex = 2
        Me.lblSutun.Text = "sutün"
        Me.lblSutun.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.otobus_bileti.My.Resources.Resources.OTOBÜS1
        Me.PictureBox1.Location = New System.Drawing.Point(62, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 963)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'anasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSutun)
        Me.Controls.Add(Me.lblSeferId)
        Me.Controls.Add(Me.btnSatis)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbPlaka)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtBiletFiyat)
        Me.Controls.Add(Me.txtKoltuk)
        Me.Controls.Add(Me.tbVarisSaati)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCinsiyet)
        Me.Controls.Add(Me.cbBiletTur)
        Me.Controls.Add(Me.saatKalkis)
        Me.Controls.Add(Me.cbVaris)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbKalkis)
        Me.Controls.Add(Me.dtKalkis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "anasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bilet Satış"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SeferEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BiletSatışlarıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtobüsEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPersonelEkle As ToolStripMenuItem
    Friend WithEvents saatKalkis As ComboBox
    Friend WithEvents cbVaris As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbKalkis As ComboBox
    Friend WithEvents dtKalkis As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbVarisSaati As TextBox
    Friend WithEvents cbPlaka As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSeferId As Label
    Friend WithEvents txtKoltuk As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBiletFiyat As TextBox
    Friend WithEvents cbBiletTur As ComboBox
    Friend WithEvents cbCinsiyet As ComboBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtTc As MaskedTextBox
    Friend WithEvents txtTelefon As MaskedTextBox
    Friend WithEvents btnSatis As Button
    Friend WithEvents lblSutun As Label
End Class
