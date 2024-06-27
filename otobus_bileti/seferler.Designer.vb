<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class seferler
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.saatVarisF = New System.Windows.Forms.ComboBox()
        Me.cbVarisF = New System.Windows.Forms.ComboBox()
        Me.dtVarisF = New System.Windows.Forms.DateTimePicker()
        Me.saatKalkisF = New System.Windows.Forms.ComboBox()
        Me.cbKalkisF = New System.Windows.Forms.ComboBox()
        Me.dtKalkisF = New System.Windows.Forms.DateTimePicker()
        Me.cbPlakaF = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SeferEkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeferiGüncelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeferiSilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UcretTxt = New System.Windows.Forms.MaskedTextBox()
        Me.saatVaris = New System.Windows.Forms.ComboBox()
        Me.saatKalkis = New System.Windows.Forms.ComboBox()
        Me.cbVaris = New System.Windows.Forms.ComboBox()
        Me.dtVaris = New System.Windows.Forms.DateTimePicker()
        Me.cbKalkis = New System.Windows.Forms.ComboBox()
        Me.dtKalkis = New System.Windows.Forms.DateTimePicker()
        Me.Durak1Ucret = New System.Windows.Forms.MaskedTextBox()
        Me.saatDurak1 = New System.Windows.Forms.ComboBox()
        Me.cbDurak1 = New System.Windows.Forms.ComboBox()
        Me.dtDurak1 = New System.Windows.Forms.DateTimePicker()
        Me.Durak2Ucret = New System.Windows.Forms.MaskedTextBox()
        Me.saatDurak2 = New System.Windows.Forms.ComboBox()
        Me.cbDurak2 = New System.Windows.Forms.ComboBox()
        Me.dtDurak2 = New System.Windows.Forms.DateTimePicker()
        Me.Durak3Ucret = New System.Windows.Forms.MaskedTextBox()
        Me.saatDurak3 = New System.Windows.Forms.ComboBox()
        Me.cbDurak3 = New System.Windows.Forms.ComboBox()
        Me.dtDurak3 = New System.Windows.Forms.DateTimePicker()
        Me.Durak4Ucret = New System.Windows.Forms.MaskedTextBox()
        Me.saatDurak4 = New System.Windows.Forms.ComboBox()
        Me.cbDurak4 = New System.Windows.Forms.ComboBox()
        Me.dtDurak4 = New System.Windows.Forms.DateTimePicker()
        Me.lblSeferId = New System.Windows.Forms.Label()
        Me.cbPlaka = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1856, 733)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.saatVarisF)
        Me.Panel1.Controls.Add(Me.cbVarisF)
        Me.Panel1.Controls.Add(Me.dtVarisF)
        Me.Panel1.Controls.Add(Me.saatKalkisF)
        Me.Panel1.Controls.Add(Me.cbKalkisF)
        Me.Panel1.Controls.Add(Me.dtKalkisF)
        Me.Panel1.Controls.Add(Me.cbPlakaF)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(397, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 97)
        Me.Panel1.TabIndex = 1
        '
        'saatVarisF
        '
        Me.saatVarisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.saatVarisF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatVarisF.FormattingEnabled = True
        Me.saatVarisF.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatVarisF.Location = New System.Drawing.Point(951, 60)
        Me.saatVarisF.Name = "saatVarisF"
        Me.saatVarisF.Size = New System.Drawing.Size(141, 24)
        Me.saatVarisF.TabIndex = 24
        '
        'cbVarisF
        '
        Me.cbVarisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.cbVarisF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbVarisF.FormattingEnabled = True
        Me.cbVarisF.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbVarisF.Location = New System.Drawing.Point(397, 54)
        Me.cbVarisF.Name = "cbVarisF"
        Me.cbVarisF.Size = New System.Drawing.Size(152, 24)
        Me.cbVarisF.TabIndex = 23
        '
        'dtVarisF
        '
        Me.dtVarisF.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtVarisF.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtVarisF.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtVarisF.CustomFormat = "dd-MM-yyyy"
        Me.dtVarisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.dtVarisF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtVarisF.Location = New System.Drawing.Point(687, 58)
        Me.dtVarisF.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtVarisF.Name = "dtVarisF"
        Me.dtVarisF.Size = New System.Drawing.Size(130, 22)
        Me.dtVarisF.TabIndex = 22
        '
        'saatKalkisF
        '
        Me.saatKalkisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.saatKalkisF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatKalkisF.FormattingEnabled = True
        Me.saatKalkisF.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatKalkisF.Location = New System.Drawing.Point(951, 18)
        Me.saatKalkisF.Name = "saatKalkisF"
        Me.saatKalkisF.Size = New System.Drawing.Size(141, 24)
        Me.saatKalkisF.TabIndex = 21
        '
        'cbKalkisF
        '
        Me.cbKalkisF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.cbKalkisF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbKalkisF.FormattingEnabled = True
        Me.cbKalkisF.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbKalkisF.Location = New System.Drawing.Point(397, 20)
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
        Me.dtKalkisF.Location = New System.Drawing.Point(687, 20)
        Me.dtKalkisF.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtKalkisF.Name = "dtKalkisF"
        Me.dtKalkisF.Size = New System.Drawing.Size(130, 22)
        Me.dtKalkisF.TabIndex = 19
        '
        'cbPlakaF
        '
        Me.cbPlakaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbPlakaF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbPlakaF.FormattingEnabled = True
        Me.cbPlakaF.Location = New System.Drawing.Point(85, 20)
        Me.cbPlakaF.Name = "cbPlakaF"
        Me.cbPlakaF.Size = New System.Drawing.Size(167, 24)
        Me.cbPlakaF.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(555, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Varış Tarihi:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(18, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 20)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Plaka:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(823, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Varış Saati:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(280, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Varış Yeri:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(823, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kalkış Saati:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(555, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kalkış Tarihi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(280, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Kalkış Yeri:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeferEkToolStripMenuItem, Me.SeferiGüncelleToolStripMenuItem, Me.SeferiSilToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 63)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SeferEkToolStripMenuItem
        '
        Me.SeferEkToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SeferEkToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SeferEkToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeferEkToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.SeferEkToolStripMenuItem.Name = "SeferEkToolStripMenuItem"
        Me.SeferEkToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5)
        Me.SeferEkToolStripMenuItem.Size = New System.Drawing.Size(187, 59)
        Me.SeferEkToolStripMenuItem.Text = "Sefer Ekle"
        '
        'SeferiGüncelleToolStripMenuItem
        '
        Me.SeferiGüncelleToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold)
        Me.SeferiGüncelleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeferiGüncelleToolStripMenuItem.Margin = New System.Windows.Forms.Padding(457, 0, 0, 0)
        Me.SeferiGüncelleToolStripMenuItem.Name = "SeferiGüncelleToolStripMenuItem"
        Me.SeferiGüncelleToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5)
        Me.SeferiGüncelleToolStripMenuItem.Size = New System.Drawing.Size(266, 59)
        Me.SeferiGüncelleToolStripMenuItem.Text = "Seferi Güncelle"
        '
        'SeferiSilToolStripMenuItem
        '
        Me.SeferiSilToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold)
        Me.SeferiSilToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeferiSilToolStripMenuItem.Margin = New System.Windows.Forms.Padding(427, 0, 0, 0)
        Me.SeferiSilToolStripMenuItem.Name = "SeferiSilToolStripMenuItem"
        Me.SeferiSilToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5)
        Me.SeferiSilToolStripMenuItem.Size = New System.Drawing.Size(170, 59)
        Me.SeferiSilToolStripMenuItem.Text = "Seferi Sil"
        '
        'UcretTxt
        '
        Me.UcretTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.UcretTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.UcretTxt.Location = New System.Drawing.Point(21, 581)
        Me.UcretTxt.Mask = "0000"
        Me.UcretTxt.Name = "UcretTxt"
        Me.UcretTxt.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UcretTxt.Size = New System.Drawing.Size(97, 28)
        Me.UcretTxt.TabIndex = 32
        Me.UcretTxt.Visible = False
        '
        'saatVaris
        '
        Me.saatVaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatVaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatVaris.FormattingEnabled = True
        Me.saatVaris.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatVaris.Location = New System.Drawing.Point(21, 551)
        Me.saatVaris.Name = "saatVaris"
        Me.saatVaris.Size = New System.Drawing.Size(98, 30)
        Me.saatVaris.TabIndex = 30
        Me.saatVaris.Visible = False
        '
        'saatKalkis
        '
        Me.saatKalkis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatKalkis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatKalkis.FormattingEnabled = True
        Me.saatKalkis.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatKalkis.Location = New System.Drawing.Point(21, 464)
        Me.saatKalkis.Name = "saatKalkis"
        Me.saatKalkis.Size = New System.Drawing.Size(98, 30)
        Me.saatKalkis.TabIndex = 31
        Me.saatKalkis.Visible = False
        '
        'cbVaris
        '
        Me.cbVaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbVaris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbVaris.FormattingEnabled = True
        Me.cbVaris.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbVaris.Location = New System.Drawing.Point(21, 494)
        Me.cbVaris.Name = "cbVaris"
        Me.cbVaris.Size = New System.Drawing.Size(98, 30)
        Me.cbVaris.TabIndex = 29
        Me.cbVaris.Visible = False
        '
        'dtVaris
        '
        Me.dtVaris.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtVaris.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtVaris.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtVaris.CustomFormat = ""
        Me.dtVaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtVaris.Location = New System.Drawing.Point(21, 524)
        Me.dtVaris.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtVaris.Name = "dtVaris"
        Me.dtVaris.Size = New System.Drawing.Size(98, 27)
        Me.dtVaris.TabIndex = 28
        Me.dtVaris.Visible = False
        '
        'cbKalkis
        '
        Me.cbKalkis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbKalkis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbKalkis.FormattingEnabled = True
        Me.cbKalkis.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbKalkis.Location = New System.Drawing.Point(21, 407)
        Me.cbKalkis.Name = "cbKalkis"
        Me.cbKalkis.Size = New System.Drawing.Size(98, 30)
        Me.cbKalkis.TabIndex = 27
        Me.cbKalkis.Visible = False
        '
        'dtKalkis
        '
        Me.dtKalkis.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtKalkis.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtKalkis.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtKalkis.CustomFormat = ""
        Me.dtKalkis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtKalkis.Location = New System.Drawing.Point(21, 437)
        Me.dtKalkis.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtKalkis.Name = "dtKalkis"
        Me.dtKalkis.Size = New System.Drawing.Size(98, 27)
        Me.dtKalkis.TabIndex = 26
        Me.dtKalkis.Visible = False
        '
        'Durak1Ucret
        '
        Me.Durak1Ucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Durak1Ucret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Durak1Ucret.Location = New System.Drawing.Point(23, 696)
        Me.Durak1Ucret.Mask = "0000"
        Me.Durak1Ucret.Name = "Durak1Ucret"
        Me.Durak1Ucret.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Durak1Ucret.Size = New System.Drawing.Size(97, 28)
        Me.Durak1Ucret.TabIndex = 36
        Me.Durak1Ucret.Visible = False
        '
        'saatDurak1
        '
        Me.saatDurak1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatDurak1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatDurak1.FormattingEnabled = True
        Me.saatDurak1.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatDurak1.Location = New System.Drawing.Point(23, 666)
        Me.saatDurak1.Name = "saatDurak1"
        Me.saatDurak1.Size = New System.Drawing.Size(96, 30)
        Me.saatDurak1.TabIndex = 35
        Me.saatDurak1.Visible = False
        '
        'cbDurak1
        '
        Me.cbDurak1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbDurak1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbDurak1.FormattingEnabled = True
        Me.cbDurak1.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbDurak1.Location = New System.Drawing.Point(21, 609)
        Me.cbDurak1.Name = "cbDurak1"
        Me.cbDurak1.Size = New System.Drawing.Size(98, 30)
        Me.cbDurak1.TabIndex = 34
        Me.cbDurak1.Visible = False
        '
        'dtDurak1
        '
        Me.dtDurak1.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtDurak1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak1.CustomFormat = ""
        Me.dtDurak1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtDurak1.Location = New System.Drawing.Point(21, 639)
        Me.dtDurak1.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtDurak1.Name = "dtDurak1"
        Me.dtDurak1.Size = New System.Drawing.Size(98, 27)
        Me.dtDurak1.TabIndex = 33
        Me.dtDurak1.Visible = False
        '
        'Durak2Ucret
        '
        Me.Durak2Ucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Durak2Ucret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Durak2Ucret.Location = New System.Drawing.Point(23, 807)
        Me.Durak2Ucret.Mask = "0000"
        Me.Durak2Ucret.Name = "Durak2Ucret"
        Me.Durak2Ucret.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Durak2Ucret.Size = New System.Drawing.Size(96, 28)
        Me.Durak2Ucret.TabIndex = 40
        Me.Durak2Ucret.Visible = False
        '
        'saatDurak2
        '
        Me.saatDurak2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatDurak2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatDurak2.FormattingEnabled = True
        Me.saatDurak2.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatDurak2.Location = New System.Drawing.Point(23, 777)
        Me.saatDurak2.Name = "saatDurak2"
        Me.saatDurak2.Size = New System.Drawing.Size(95, 30)
        Me.saatDurak2.TabIndex = 39
        Me.saatDurak2.Visible = False
        '
        'cbDurak2
        '
        Me.cbDurak2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbDurak2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbDurak2.FormattingEnabled = True
        Me.cbDurak2.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbDurak2.Location = New System.Drawing.Point(23, 720)
        Me.cbDurak2.Name = "cbDurak2"
        Me.cbDurak2.Size = New System.Drawing.Size(97, 30)
        Me.cbDurak2.TabIndex = 38
        Me.cbDurak2.Visible = False
        '
        'dtDurak2
        '
        Me.dtDurak2.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak2.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak2.CustomFormat = ""
        Me.dtDurak2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtDurak2.Location = New System.Drawing.Point(23, 750)
        Me.dtDurak2.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtDurak2.Name = "dtDurak2"
        Me.dtDurak2.Size = New System.Drawing.Size(97, 27)
        Me.dtDurak2.TabIndex = 37
        Me.dtDurak2.Visible = False
        '
        'Durak3Ucret
        '
        Me.Durak3Ucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Durak3Ucret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Durak3Ucret.Location = New System.Drawing.Point(24, 918)
        Me.Durak3Ucret.Mask = "0000"
        Me.Durak3Ucret.Name = "Durak3Ucret"
        Me.Durak3Ucret.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Durak3Ucret.Size = New System.Drawing.Size(98, 28)
        Me.Durak3Ucret.TabIndex = 44
        Me.Durak3Ucret.Visible = False
        '
        'saatDurak3
        '
        Me.saatDurak3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatDurak3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatDurak3.FormattingEnabled = True
        Me.saatDurak3.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatDurak3.Location = New System.Drawing.Point(24, 888)
        Me.saatDurak3.Name = "saatDurak3"
        Me.saatDurak3.Size = New System.Drawing.Size(96, 30)
        Me.saatDurak3.TabIndex = 43
        Me.saatDurak3.Visible = False
        '
        'cbDurak3
        '
        Me.cbDurak3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbDurak3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbDurak3.FormattingEnabled = True
        Me.cbDurak3.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbDurak3.Location = New System.Drawing.Point(21, 831)
        Me.cbDurak3.Name = "cbDurak3"
        Me.cbDurak3.Size = New System.Drawing.Size(99, 30)
        Me.cbDurak3.TabIndex = 42
        Me.cbDurak3.Visible = False
        '
        'dtDurak3
        '
        Me.dtDurak3.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak3.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtDurak3.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak3.CustomFormat = ""
        Me.dtDurak3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtDurak3.Location = New System.Drawing.Point(21, 861)
        Me.dtDurak3.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtDurak3.Name = "dtDurak3"
        Me.dtDurak3.Size = New System.Drawing.Size(99, 27)
        Me.dtDurak3.TabIndex = 41
        Me.dtDurak3.Visible = False
        '
        'Durak4Ucret
        '
        Me.Durak4Ucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Durak4Ucret.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Durak4Ucret.Location = New System.Drawing.Point(303, 950)
        Me.Durak4Ucret.Mask = "0000"
        Me.Durak4Ucret.Name = "Durak4Ucret"
        Me.Durak4Ucret.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Durak4Ucret.Size = New System.Drawing.Size(86, 28)
        Me.Durak4Ucret.TabIndex = 48
        Me.Durak4Ucret.Visible = False
        '
        'saatDurak4
        '
        Me.saatDurak4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.saatDurak4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saatDurak4.FormattingEnabled = True
        Me.saatDurak4.Items.AddRange(New Object() {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.saatDurak4.Location = New System.Drawing.Point(210, 948)
        Me.saatDurak4.Name = "saatDurak4"
        Me.saatDurak4.Size = New System.Drawing.Size(87, 30)
        Me.saatDurak4.TabIndex = 47
        Me.saatDurak4.Visible = False
        '
        'cbDurak4
        '
        Me.cbDurak4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbDurak4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbDurak4.FormattingEnabled = True
        Me.cbDurak4.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli (İzmit)", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya (Adapazarı)", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"})
        Me.cbDurak4.Location = New System.Drawing.Point(24, 948)
        Me.cbDurak4.Name = "cbDurak4"
        Me.cbDurak4.Size = New System.Drawing.Size(87, 30)
        Me.cbDurak4.TabIndex = 46
        Me.cbDurak4.Visible = False
        '
        'dtDurak4
        '
        Me.dtDurak4.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak4.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.dtDurak4.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.dtDurak4.CustomFormat = ""
        Me.dtDurak4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dtDurak4.Location = New System.Drawing.Point(117, 948)
        Me.dtDurak4.MinDate = New Date(2023, 12, 5, 0, 0, 0, 0)
        Me.dtDurak4.Name = "dtDurak4"
        Me.dtDurak4.Size = New System.Drawing.Size(87, 27)
        Me.dtDurak4.TabIndex = 45
        Me.dtDurak4.Visible = False
        '
        'lblSeferId
        '
        Me.lblSeferId.AutoSize = True
        Me.lblSeferId.Location = New System.Drawing.Point(43, 387)
        Me.lblSeferId.Name = "lblSeferId"
        Me.lblSeferId.Size = New System.Drawing.Size(51, 17)
        Me.lblSeferId.TabIndex = 49
        Me.lblSeferId.Text = "Label7"
        Me.lblSeferId.Visible = False
        '
        'cbPlaka
        '
        Me.cbPlaka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbPlaka.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.cbPlaka.FormattingEnabled = True
        Me.cbPlaka.Location = New System.Drawing.Point(397, 948)
        Me.cbPlaka.Name = "cbPlaka"
        Me.cbPlaka.Size = New System.Drawing.Size(94, 33)
        Me.cbPlaka.TabIndex = 50
        Me.cbPlaka.Visible = False
        '
        'seferler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.cbPlaka)
        Me.Controls.Add(Me.lblSeferId)
        Me.Controls.Add(Me.Durak4Ucret)
        Me.Controls.Add(Me.saatDurak4)
        Me.Controls.Add(Me.cbDurak4)
        Me.Controls.Add(Me.dtDurak4)
        Me.Controls.Add(Me.Durak3Ucret)
        Me.Controls.Add(Me.saatDurak3)
        Me.Controls.Add(Me.cbDurak3)
        Me.Controls.Add(Me.dtDurak3)
        Me.Controls.Add(Me.Durak2Ucret)
        Me.Controls.Add(Me.saatDurak2)
        Me.Controls.Add(Me.cbDurak2)
        Me.Controls.Add(Me.dtDurak2)
        Me.Controls.Add(Me.Durak1Ucret)
        Me.Controls.Add(Me.saatDurak1)
        Me.Controls.Add(Me.cbDurak1)
        Me.Controls.Add(Me.dtDurak1)
        Me.Controls.Add(Me.UcretTxt)
        Me.Controls.Add(Me.saatVaris)
        Me.Controls.Add(Me.saatKalkis)
        Me.Controls.Add(Me.cbVaris)
        Me.Controls.Add(Me.dtVaris)
        Me.Controls.Add(Me.cbKalkis)
        Me.Controls.Add(Me.dtKalkis)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "seferler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seferler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbPlakaF As ComboBox
    Friend WithEvents saatKalkisF As ComboBox
    Friend WithEvents cbKalkisF As ComboBox
    Friend WithEvents dtKalkisF As DateTimePicker
    Friend WithEvents saatVarisF As ComboBox
    Friend WithEvents cbVarisF As ComboBox
    Friend WithEvents dtVarisF As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SeferEkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UcretTxt As MaskedTextBox
    Friend WithEvents saatVaris As ComboBox
    Friend WithEvents saatKalkis As ComboBox
    Friend WithEvents cbVaris As ComboBox
    Friend WithEvents dtVaris As DateTimePicker
    Friend WithEvents cbKalkis As ComboBox
    Friend WithEvents dtKalkis As DateTimePicker
    Friend WithEvents Durak1Ucret As MaskedTextBox
    Friend WithEvents saatDurak1 As ComboBox
    Friend WithEvents cbDurak1 As ComboBox
    Friend WithEvents dtDurak1 As DateTimePicker
    Friend WithEvents Durak2Ucret As MaskedTextBox
    Friend WithEvents saatDurak2 As ComboBox
    Friend WithEvents cbDurak2 As ComboBox
    Friend WithEvents dtDurak2 As DateTimePicker
    Friend WithEvents Durak3Ucret As MaskedTextBox
    Friend WithEvents saatDurak3 As ComboBox
    Friend WithEvents cbDurak3 As ComboBox
    Friend WithEvents dtDurak3 As DateTimePicker
    Friend WithEvents Durak4Ucret As MaskedTextBox
    Friend WithEvents saatDurak4 As ComboBox
    Friend WithEvents cbDurak4 As ComboBox
    Friend WithEvents dtDurak4 As DateTimePicker
    Friend WithEvents lblSeferId As Label
    Friend WithEvents cbPlaka As ComboBox
    Friend WithEvents SeferiGüncelleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeferiSilToolStripMenuItem As ToolStripMenuItem
End Class
