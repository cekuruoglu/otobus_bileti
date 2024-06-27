<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kullaniciekle
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
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.cmbTuru = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGiris.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btnGiris.Location = New System.Drawing.Point(239, 290)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(123, 48)
        Me.btnGiris.TabIndex = 8
        Me.btnGiris.Text = "Ekle"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(215, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Şifre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(137, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'txtSifre
        '
        Me.txtSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtSifre.Location = New System.Drawing.Point(306, 189)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSifre.Size = New System.Drawing.Size(171, 28)
        Me.txtSifre.TabIndex = 4
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(306, 148)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(171, 28)
        Me.txtKullaniciAdi.TabIndex = 5
        '
        'cmbTuru
        '
        Me.cmbTuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.cmbTuru.FormattingEnabled = True
        Me.cmbTuru.Items.AddRange(New Object() {"Personel", "Yönetici"})
        Me.cmbTuru.Location = New System.Drawing.Point(306, 232)
        Me.cmbTuru.Name = "cmbTuru"
        Me.cmbTuru.Size = New System.Drawing.Size(171, 30)
        Me.cmbTuru.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(124, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kullanıcı Türü:"
        '
        'kullaniciekle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 481)
        Me.Controls.Add(Me.cmbTuru)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Name = "kullaniciekle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Ekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGiris As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents cmbTuru As ComboBox
    Friend WithEvents Label3 As Label
End Class
